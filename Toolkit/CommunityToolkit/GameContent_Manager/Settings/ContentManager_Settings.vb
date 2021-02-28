Imports COH.Tools.Internal.Enums

Namespace Internal.ContentController.Settings
    Public NotInheritable Class ContentManager_Settings

#Region "Properties"
        Public Property CurrentProject_FileName As String
            Get
                Return mCurrentProjectFileName
            End Get
            Set(value As String)
                mCurrentProjectFileName = value
            End Set
        End Property
        Public Property CurrentProject_RootFolder As String
            Get
                Return mCurrentProjectRoot
            End Get
            Set(value As String)
                mCurrentProjectRoot = value
            End Set
        End Property
        Public Property Ouroboros_RepoPathRoot As String
            Get
                Return mOuroborosRepoPath
            End Get
            Set(value As String)
                mOuroborosRepoPath = value
            End Set
        End Property
        Public Property GitReleaseFeed As String
            Get
                Return mGitReleaseFeed
            End Get
            Set(value As String)
                mGitReleaseFeed = value
            End Set
        End Property
        Public Property GitReleaseDate As Date
            Get
                Return mGitReleaseDate
            End Get
            Set(value As Date)
                mGitReleaseDate = value
            End Set
        End Property
        ReadOnly Property CurrentProject_FilePath As String
            Get
                Return mCurrentProjectRoot & mCurrentProjectFileName
            End Get
        End Property
        Public Property Option_BINs_UpdateTimeStamps As String
            Get
                Return mUpdate_Bin_TimeStamps
            End Get
            Set(value As String)
                mUpdate_Bin_TimeStamps = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mCurrentProjectRoot As String
        Private mCurrentProjectFileName As String
        Private mUpdate_Bin_TimeStamps As Boolean
        Private mOuroborosRepoPath As String
        Private mGitReleaseFeed As String
        Private mGitReleaseDate As Date
#End Region

#Region "Create New Instance"
        Public Sub New()
        End Sub
        Public Sub New(Reset As Boolean)
            If Reset = True Then ResetDefaults()
        End Sub
        Private Sub ResetDefaults()
            mUpdate_Bin_TimeStamps = False
            Reset_ToDefaultProject(False)
        End Sub
        Public Sub Reset_ToDefaultProject(Optional SaveFile As Boolean = True)
            mGitReleaseFeed = "https://github.com/Dragon-Sire/COH-CommunityToolKit/releases.atom"
            mGitReleaseDate = "01/01/2019"
            mCurrentProjectFileName = "CityofHeroes_StandardProject.xml"
            mCurrentProjectRoot = COH_ContentController.Instance.ProgramFolders.LookupFolder(COH_ProgramPaths.ProgramData) & "StandardPackage\"
            mOuroborosRepoPath = COH_ContentController.Instance.ProgramFolders.LookupFolder(COH_ProgramPaths.Repo)
            If SaveFile = True Then Save()
        End Sub
#End Region

#Region "Save Changes"
        Public Function Save() As Boolean
            Dim FilePath As String = COH_ContentController.Instance.ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Settings) & "Settings.xml"
            Return Export_XML_Settings(FilePath, Me)
        End Function
#End Region

#Region "Import/Export"
        Public Shared Function Export_XML_Settings(FilePAth As String, ByRef Item As ContentManager_Settings) As Boolean
            If COH.Helperfunctions.XML.Export_XMLFile(FilePAth, Item) = False Then
                Return False
            End If
            Return True
        End Function
        Public Shared Function Import_XMLFile(Filepath As String, ByRef Result As ContentManager_Settings) As Boolean
            Result = New ContentManager_Settings
            Dim ImportResult As Boolean = True
            If IO.File.Exists(Filepath) = True Then
                Try
                    Dim Reader As New IO.StreamReader(Filepath)
                    Dim x As New Xml.Serialization.XmlSerializer(Result.GetType)
                    Result = x.Deserialize(Reader)
                    Reader.Close()
                Catch ex As Exception
                    COH_ContentController.Instance.ShowMessage_SimpleError("Error: Unable to Import Settings" & Environment.NewLine & Filepath)
                    ImportResult = False
                End Try
            End If
            Return ImportResult
        End Function
#End Region

    End Class
End Namespace