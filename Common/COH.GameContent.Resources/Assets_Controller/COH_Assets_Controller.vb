Imports COH.GameContent.Structures.Resources.Anim
Imports COH.GameContent.Structures.Resources.Textures
Imports COH.GameContent.Structures.Resources_Simplified

Public Class COH_ResourceAssets_Controller
    Implements ISupport_COH_AssetRetrieval

#Region "Properties"
    Public Property Textures As Dictionary(Of String, String)
        Get
            Return mTextures
        End Get
        Set(value As Dictionary(Of String, String))
            mTextures = value
        End Set
    End Property
    Public Property TGA As Dictionary(Of String, String)
        Get
            Return mTGA
        End Get
        Set(value As Dictionary(Of String, String))
            mTGA = value
        End Set
    End Property
    Public Property ANIM As Dictionary(Of String, String)
        Get
            Return mAnim
        End Get
        Set(value As Dictionary(Of String, String))
            mAnim = value
        End Set
    End Property
    Public Property Bones As Dictionary(Of String, COH_Resource_GEO_Skeleton)
        Get
            Return mBones
        End Get
        Set(value As Dictionary(Of String, COH_Resource_GEO_Skeleton))
            mBones = value
        End Set
    End Property
#End Region

#Region "Private Properties"
    Private mRootFolder As String
    Private mBonesFolder As String
    Private mTextures As Dictionary(Of String, String)
    Private mTGA As Dictionary(Of String, String)
    Private mAnim As Dictionary(Of String, String)
    Private mBones As Dictionary(Of String, COH_Resource_GEO_Skeleton)
#End Region

#Region "Create New Instance"
    Public Sub New()
    End Sub
    Public Sub New(Root As String, BonesFolder As String)
        mRootFolder = Root
        mBonesFolder = BonesFolder
        If IO.Directory.Exists(mRootFolder) = False Then Exit Sub
        Find_AllTextures()
        Find_AllTGA()
        Find_AllAnim()
        Find_AllBones()
    End Sub
#End Region

#Region "Initialize Available Resources"
    Private Sub Find_AllTextures()
        mTextures = New Dictionary(Of String, String)
        For Each File In IO.Directory.GetFiles(mRootFolder, "*.texture", IO.SearchOption.AllDirectories)
            mTextures.Add(IO.Path.GetFileNameWithoutExtension(File).ToLower, File)
        Next
    End Sub
    Private Sub Find_AllTGA()
        mTGA = New Dictionary(Of String, String)
        For Each File In IO.Directory.GetFiles(mRootFolder, "*.tga", IO.SearchOption.AllDirectories)
            mTGA.Add(IO.Path.GetFileNameWithoutExtension(File).ToLower, File)
        Next
    End Sub
    Private Sub Find_AllAnim()
        mAnim = New Dictionary(Of String, String)
        For Each File In IO.Directory.GetFiles(mRootFolder, "*.anim", IO.SearchOption.AllDirectories)
            Dim Key As String = IO.Path.GetFileNameWithoutExtension(File).ToLower
            If mAnim.ContainsKey(Key) = False Then mAnim.Add(Key, File)
        Next
    End Sub
    Private Sub Find_AllBones()
        mBones = New Dictionary(Of String, COH_Resource_GEO_Skeleton)
        For Each File In IO.Directory.GetFiles(mBonesFolder, "*.XML", IO.SearchOption.AllDirectories)
            Dim Key As String = IO.Path.GetFileNameWithoutExtension(File).ToLower
            If mBones.ContainsKey(Key) = False Then
                Dim NewBone As COH_Resource_GEO_Skeleton = Nothing
                If COH_Resource_GEO_Skeleton.Import_COHStruct_FromXMLFile(File, GetType(COH_Resource_GEO_Skeleton), NewBone) = True Then
                    mBones.Add(Key, NewBone)
                End If
            End If
        Next
    End Sub
    Public Sub Add_CustomLocation_Textures(Folder As String)
        If IO.Directory.Exists(Folder) = False Then Exit Sub
        For Each File In IO.Directory.GetFiles(Folder, "*.texture", IO.SearchOption.TopDirectoryOnly)
            Dim Key As String = IO.Path.GetFileNameWithoutExtension(File).ToLower
            If mTextures.ContainsKey(Key) = False Then mTextures.Add(Key, File)
        Next
    End Sub
    Public Sub Add_CustomLocation_TGA(Folder As String)
        If IO.Directory.Exists(Folder) = False Then Exit Sub
        For Each File In IO.Directory.GetFiles(Folder, "*.tga", IO.SearchOption.TopDirectoryOnly)
            Dim Key As String = IO.Path.GetFileNameWithoutExtension(File).ToLower
            If mTGA.ContainsKey(Key) = False Then mTGA.Add(Key, File)
        Next
    End Sub
#End Region

#Region "Search"
    Public Function RetrieveAsset(ByRef Search As String) As COH_FileStructure Implements ISupport_COH_AssetRetrieval.RetrieveAsset
    End Function
    Public Function RetrieveAsset(ByRef Search As String, Type As COH_Supported_ContentType) As Object Implements ISupport_COH_AssetRetrieval.RetrieveAsset
        Select Case Type
            Case COH_Supported_ContentType.XML_SpecialCase_Bone
                Dim FoundSkel As COH_Resource_GEO_Skeleton = Nothing
                If mBones.TryGetValue(Search, FoundSkel) = True Then Return FoundSkel
                Return Nothing
            Case COH_Supported_ContentType.Resource_Texture
                Dim FilePath As String = RetrieveAsset_FilePath(Search, COH_Supported_ContentType.Resource_Texture)
                If String.IsNullOrEmpty(FilePath) = True Then Return Nothing
                Return RetrieveAsset_Texture(FilePath)
            Case COH_Supported_ContentType.Resource_TGA
                Dim FilePath As String = RetrieveAsset_FilePath(Search, COH_Supported_ContentType.Resource_Texture)
                If String.IsNullOrEmpty(FilePath) = True Then Return Nothing
                Return RetrieveAsset_TGA(FilePath)
            Case COH_Supported_ContentType.Unknown
                Dim FilePath As String = RetrieveAsset_FilePath_Any(Search)
                If String.IsNullOrEmpty(FilePath) = True Then Return Nothing
                Return RetrieveAsset_ImageStruct(FilePath)
        End Select
    End Function
    Public Function RetrieveAsset_Texture(FilePath As String) As COH_Resource_Texture
        Dim Result = New COH_Resource_Texture
        Result.Import_From_File(FilePath, New COH_Serialization_Settings(True, COH_ExportFormat.Binary))
        Return Result
    End Function
    Public Function RetrieveAsset_TGA(FilePath As String) As COH_Resource_TGA
        Dim Result = New COH_Resource_TGA
        Result.Import_From_File(FilePath, New COH_Serialization_Settings(True, COH_ExportFormat.Binary))
        Return Result
    End Function
    Public Function RetrieveAsset_ImageStruct(FilePath As String) As COH_FileStructure Implements ISupport_COH_AssetRetrieval.RetrieveAsset_ImageStruct
        If String.IsNullOrEmpty(FilePath) = True Then Return Nothing
        If FilePath.ToLower.Contains(".tga") Then
            Return RetrieveAsset_TGA(FilePath)
        ElseIf FilePath.ToLower.Contains(".texture") Then
            Return RetrieveAsset_Texture(FilePath)
        End If
        Return Nothing
    End Function

    Public Function RetrieveAsset_FilePath(ByRef Search As String, Optional TheType As COH_Supported_ContentType = COH_Supported_ContentType.Unknown) As String Implements ISupport_COH_AssetRetrieval.RetrieveAsset_FilePath
        Dim FileName As String = ""
        Search = Search.ToLower
        Select Case TheType
            Case COH_Supported_ContentType.Resource_Texture
                If mTextures.TryGetValue(Search, FileName) = True Then Return FileName
            Case COH_Supported_ContentType.Resource_ANIMATION
                If mAnim.TryGetValue(Search, FileName) = True Then Return FileName
            Case COH_Supported_ContentType.Resource_TGA
                If mTGA.TryGetValue(Search, FileName) = True Then Return FileName
            Case COH_Supported_ContentType.Unknown
                Return RetrieveAsset_FilePath_Any(Search)
        End Select
        Return Nothing
    End Function
    Private Function RetrieveAsset_FilePath_Any(ByRef Search As String) As String
        Dim FileName As String = ""
        Dim Found As Boolean = False
        If mTextures.TryGetValue(Search, FileName) = True Then Found = True
        If Found = False AndAlso mTGA.TryGetValue(Search, FileName) = True Then Found = True
        If Found = False Then Return ""
        Return FileName
    End Function
#End Region

#Region "Special Functions"
    Public Sub Extract_ALL_BaseSkeletons(Optional ShowProgress As Boolean = False)
        Dim FoundBones As New Dictionary(Of String, COH_Resource_GEO_Skeleton)
        Dim Files = IO.Directory.GetFiles(mRootFolder, "*.anim", IO.SearchOption.AllDirectories)
        Dim SkelName As String = ""
        '' If ShowProgress = True Then ShowProgressUpdate(COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, Files.Count, "Searching ANIM Files For Skeletons")
        For Each File In Files
            Dim Existing As New COH_Resource_Anim
            If Existing.Import_From_File(IO.Path.GetFileName(File), IO.Path.GetDirectoryName(File), COH_ExportFormat.Binary) = True Then
                If Not (Existing.SkeletonTrack.Skeleton_Heirarchy Is Nothing) Then
                    SkelName = Existing.SkeletonTrack.Name_BaseAnimation
                    If FoundBones.ContainsKey(SkelName) = False Then
                        If Not SkelName.ToLower = Existing.SkeletonTrack.Name.ToLower Then
                            SkelName = Existing.SkeletonTrack.Name_BaseAnimation
                        End If
                        Dim Skeleton = Existing.Extract_Skeleton
                        FoundBones.Add(SkelName, Skeleton)
                        Dim ExportFile As String = SkelName.Replace("/", "_")

                        Skeleton.Export_To_File(ExportFile & ".xml", mBonesFolder, COH_ExportFormat.XML)
                    End If
                End If
            End If
            ''If ShowProgress = True Then ShowProgressUpdate(COH_Event_ProgressUpdate.COH_ProgressEvent.Update, 1, SkelName)
        Next
        '''If ShowProgress = True Then ShowProgressUpdate(COH_Event_ProgressUpdate.COH_ProgressEvent.Finish, Files.Count)
    End Sub
#End Region


End Class
