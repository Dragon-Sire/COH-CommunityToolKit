Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums
Imports COH.Tools.Internal.ContentController.Settings
Imports COH.Tools.Internal.Enums

Namespace Internal.ContentController
    Public NotInheritable Class COH_ContentController
        Implements ISupport_MasterController

#Region "Instance"
        Public ReadOnly Property ProgramFolders As COH_ProgramPathsManager
            Get
                Return mProgramFolders
            End Get
        End Property
        Public ReadOnly Property Settings As ContentManager_Settings
            Get
                Return mSettings
            End Get
        End Property
        Public Shared ReadOnly Property Instance As COH_ContentController
            Get
                Return sInstance
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private Shared sInstance As COH_ContentController
        Private sMainForm As COH_Tools
        Private mProgramFolders As COH_ProgramPathsManager
        Private mSettings As ContentManager_Settings
        Private mLoadScreenVisible As Boolean
#End Region

#Region "Initialize"
        Public Sub New(ByRef MainForm As COH_Tools, InstalledProgramPath As String, Optional PrepareCache As Boolean = True)
            sMainForm = MainForm
            PrepareUsage(InstalledProgramPath)
            If PrepareCache = True Then CacheFiles()
            SplashScreen_Destroy()
            CheckUpdate()
        End Sub
        Private Sub PrepareUsage(InstalledProgramPath As String)
            sInstance = Me
            mCached_Structs = New Dictionary(Of COH_ProjectContent, List(Of COH_FileStructure))
            SplashScreen_Create()
            SplashScreen_Update("Initializing", 5, True)
            mCached_ProjectMapping = CreateListProjectMapping()
            mCahced_ModMapping = CreateListProjectMapping_ModType()
            mEventController = GameContent.Internal.Events.COH_LibraryEventControl.Instance
            SplashScreen_Update("Preparing Folders", 5, True)
            mProgramFolders = New COH_ProgramPathsManager(InstalledProgramPath)
            If PrepareUsage_Settings() = False Then Environment.Exit(0)
            If Check_PrepareFirstTimeUsage() = True Then
                If PrepareUsage_FirstTime() = False Then Environment.Exit(0)
            Else
                CacheFiles()
            End If
            'If PrepareUsage_Localization() = False Then ThrowError(New Logging.BTC_EventResponse(BTC_ResponseCodeSeverity.SevereError, BTC_ResponseCodes.Unknown, ""))
        End Sub
        Private Function PrepareUsage_Settings() As Boolean
            Dim FilePath As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Settings) & "Settings.xml"
            If IO.File.Exists(FilePath) = False Then
                mSettings = New ContentManager_Settings(True)
                mSettings.Save()
            Else
                If ContentManager_Settings.Import_XMLFile(FilePath, mSettings) = False Then
                    mSettings = New ContentManager_Settings(True)
                    mSettings.Save()
                End If
            End If
            mProgramFolders.EnsureAllProjectFoldersExist(mSettings.CurrentProject_RootFolder)
            Return True
        End Function
        Private Function Check_PrepareFirstTimeUsage() As Boolean
            Dim FilePath As String = mSettings.CurrentProject_FilePath
            If IO.File.Exists(FilePath) = False Then Return True
            Return False
        End Function
        Private Function PrepareUsage_FirstTime() As Boolean
            SplashScreen_Update("Registering Structures", 10, False)
            Prepare_StructuresController()
            SplashScreen_Update("Extracting Piggs", 10, True)
            If ExtractPiggs_FreshInstall(False) = False Then Return False
            SplashScreen_Update("Extracting Bins", 10, True)
            If ExtractBins_All(False) = False Then Return False
            SplashScreen_Update("Creating Standard Project", 5, True)
            If Start_FreshProjectFile_Standard(False) = False Then Return False
            Return True
        End Function
        Private Sub CacheFiles()
            SplashScreen_Update("Registering Structures", 10, False)
            Prepare_StructuresController()
            SplashScreen_Update("Loading Message Stores", 10, False)
            Prepare_MessageStoreController()
            SplashScreen_Update("Searching Available Assets", 10, True)
            Prepare_AssetsController()
            SplashScreen_Update("Loading Project File", 10, False)
            Retrieve_CurrentPoject(False)
        End Sub
#End Region

#Region "Splash Screen"
        Protected Friend Sub LoadScreen_AddMessage(message As String)
            If mLoadScreenVisible = False Then Exit Sub
        End Sub
#End Region

#Region "Update"
        Private Sub Check_Update(AtomFeed As String, Optional ForceShow As Boolean = False, Optional UpdateLinkLabel As LinkLabel = Nothing)
            Dim Message As String = "", Link As String = ""
            Dim UpdateFound As Boolean = Check_UpdateInfo(AtomFeed, Message, Link)
            If UpdateFound = True Then
                ShowMessage_Simple(Message & Environment.NewLine & Link)
                If Not (UpdateLinkLabel Is Nothing) Then
                    UpdateLinkLabel.Text = "Version : Update Available"
                    UpdateLinkLabel.LinkArea = New LinkArea(10, 16)
                    UpdateLinkLabel.Tag = Link
                End If
            ElseIf ForceShow = True Then
                ShowMessage_Simple(Message)
                If Not (UpdateLinkLabel Is Nothing) Then
                    UpdateLinkLabel.Text = "Version : Current"
                    UpdateLinkLabel.LinkArea = New LinkArea(0, 0)
                    UpdateLinkLabel.Tag = ""
                End If
            End If
        End Sub
        Private Function Check_UpdateInfo(AtomFeed As String, ByRef Message As String, ByRef Link As String) As Boolean
            ' If Devices.Network.IsAvailable = False Then
            ' Message = "No Internet Connection"
            ' Return False
            ' End If
            Dim UpdateFound As Boolean = False
            If String.IsNullOrEmpty(AtomFeed) = True Then AtomFeed = "https://github.com/Dragon-Sire/COH-CommunityToolKit/releases.atom"
            Using reader As Xml.XmlReader = Xml.XmlReader.Create(AtomFeed)
                'Dim feed As ServiceModel.Syndication.SyndicationFeed = ServiceModel.Syndication.SyndicationFeed.Load(reader)
                'Console.WriteLine(feed.Title.Text)
                'Console.WriteLine(feed.Links(0).Uri)

                'For Each item As ServiceModel.Syndication.SyndicationItem In feed.Items
                'Dim item As ServiceModel.Syndication.SyndicationItem = feed.Items(0)
                'Dim LastUpdated As Date = item.LastUpdatedTime.DateTime
                'Link = item.Links(0).Uri.ToString
                'Dim ID As String = item.Id ' "tag:github.com,2008:Repository/203834544/v1.0.0.93"
                'If Parse_VersionGit(ID) = True Then
                ' Message = "There is a newer version available!"
                ''UpdateFound = True
                'Else
                ' Message = "Current Version is Latest Release"
                ' End If
                'Next
            End Using
            Return UpdateFound
        End Function
        Private Function Parse_VersionGit(Source As String) As Boolean
            'Dim VersionMajor As Integer = 0, VersionMinor As Integer = 0, VersionStatus As Integer = 0, VersionRevision As Integer = 0
            If Source.Contains("/v") = False Then Return False
            Dim VString As String = Source.Substring(Source.IndexOf("/v") + 2)
            Dim Values As String() = VString.Split(".")

            'If My.Application.Info.Version.Major < Values(0) Then
            ' Return True
            ' ElseIf My.Application.Info.Version.Major > Values(0) Then
            ' Return False
            'End If
            ''
            'I 'f My.Application.Info.Version.MajorRevision < Values(1) Then
            'Return True
            'ElseIf My.Application.Info.Version.MajorRevision > Values(1) Then
            ' Return False
            ' End If
            '
            '            If My.Application.Info.Version.Minor < Values(2) Then
            ''           Return True
            '           ElseIf My.Application.Info.Version.Minor > Values(2) Then
            '           Return False
            '           End If
            ''
            '           If My.Application.Info.Version.MinorRevision < Values(3) Then
            '           Return True
            '           ElseIf My.Application.Info.Version.MinorRevision > Values(3) Then
            ' '          Return False
            '           Else
            Return False
            'End If
        End Function
#End Region

    End Class
End Namespace