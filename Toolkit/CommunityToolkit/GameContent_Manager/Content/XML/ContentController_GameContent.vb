Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Private Functions"
        Private mCached_Structs As Dictionary(Of COH_ProjectContent, List(Of COH_FileStructure))
#End Region

#Region "Retrieve Content Cached"
        Public Function Retrieve_Structs(ContentType As COH_ProjectContent) As List(Of COH_FileStructure) Implements ISupport_MasterController.Retrieve_Structs
            If mCached_Structs.ContainsKey(ContentType) = False Then
                mCached_Structs.Add(ContentType, Retrieve_AllContent_FromFileNames_RelativePath(ContentType, COH_ExportFormat.XML)) '//RETRIEVE ALL OF TYPE
            End If
            Return mCached_Structs.Item(ContentType)
        End Function
#End Region

#Region "Retrieve All"
        Public Function Retrieve_AllContent_FromFileNames_RelativePath(ContentType As COH_ProjectContent, SelectedFormat As COH_ExportFormat) As List(Of COH_FileStructure) Implements ISupport_MasterController.Retrieve_AllContent_FromFileNames_RelativePath
            Dim Results = New List(Of COH_FileStructure)
            Dim TheType As Type = Nothing
            Dim Index As Integer = 0
            If Retrieve_MapToType(ContentType, Nothing, Index, TheType) = False Then Return Nothing
            Dim TheList = mCached_CurrentProjectFile.Index_Retrieve(ContentType).Files(Index).Details
            For Each File In TheList
                Dim NewItem As COH_FileStructure = Nothing
                Dim FilePath As String = ProgramFolders.LookupFolder_ProjectFile(ContentType) & File.XML_RelativePath
                If Retrieve_Content_FromFileName(TheType, FilePath, SelectedFormat, NewItem) = False Then

                Else
                    Results.Add(NewItem)
                End If
            Next
            Return Results
        End Function
#End Region

#Region "Retrieve Specific Content"
        Public Function RetrieveStruct(ByRef Search As String, ContentType As COH_ProjectContent, SelectedFormat As COH_ExportFormat, ByRef Result As COH_FileStructure) As Boolean Implements ISupport_MasterController.RetrieveStruct
            Dim SearchList As IEnumerable(Of COH_FileStructure) = Retrieve_Structs(ContentType)
            'For Each Entry In SearchList
            ' If Entry.FilePathReference_Current = Search Then
            ' Result = Entry
            ' Return True
            ' End If
            ' Next
            ' Return False
        End Function
        Public Function RetrieveStruct_FilePath(ByRef Search As String, ContentType As COH_ProjectContent, SelectedFormat As COH_ExportFormat) As String Implements ISupport_MasterController.RetrieveStruct_FilePath


        End Function
        Public Function Retrieve_Content_FromFileName_NoPath(ContentType As COH_ProjectContent, RelativePath As String, SelectedFormat As COH_ExportFormat, ByRef Result As COH_FileStructure) As Boolean Implements ISupport_MasterController.Retrieve_Content_FromFileName_NoPath
            Dim Index_FileIndex As Integer = 0
            Dim TheType As Type = Nothing
            Dim ProjectType As COH_ProjectContent = Nothing
            Retrieve_MapToType(ContentType, Nothing, Index_FileIndex, TheType, ProjectType)

            Dim FilePath As String = ""
            Dim Index = Cached_CurrentProjectFile.Index_Retrieve(ProjectType)
            For X = 0 To Index.Files(Index_FileIndex).Details.Count - 1
                If String.Equals(Index.Files(Index_FileIndex).Details(X).Name, RelativePath, StringComparison.CurrentCultureIgnoreCase) Then
                    FilePath = Index.Files(Index_FileIndex).Details(X).XML_RelativePath
                    Exit For
                End If
            Next
            FilePath = ProgramFolders.LookupFolder_ProjectFile(ContentType) & FilePath
            Return Retrieve_Content_FromFileName(TheType, FilePath, SelectedFormat, Result)
        End Function
        Public Function Retrieve_Content_FromFileName_RelativePath(ContentType As COH_ProjectContent, RelativePath As String, SelectedFormat As COH_ExportFormat, ByRef Result As COH_FileStructure) As Boolean Implements ISupport_MasterController.Retrieve_Content_FromFileName_RelativePath
            Dim FilePath As String = ProgramFolders.LookupFolder_ProjectFile(ContentType) & RelativePath
            Dim TheType As Type = Nothing
            Retrieve_MapToType(ContentType, Nothing, Nothing, TheType)
            Return Retrieve_Content_FromFileName(TheType, FilePath, SelectedFormat, Result)
        End Function
        Public Function Retrieve_Content_FromFileName(TheType As Type, FilePath As String, SelectedFormat As COH_ExportFormat, ByRef Result As COH_FileStructure) As Boolean Implements ISupport_MasterController.Retrieve_Content_FromFileName
            If SelectedFormat = COH_ExportFormat.Unspecified Then Return False '//Attempt to Determine From FileName?
            Select Case SelectedFormat
                Case COH_ExportFormat.XML
                    Return COH_FileStructure.Import_COHStruct_FromXMLFile(FilePath, TheType, Result)
                Case COH_ExportFormat.Binary
                    Result = Activator.CreateInstance(TheType)
                    Return Result.Import_From_File(FilePath, New COH_Serialization_Settings(True) With {.Option_SelectedFormat = COH_ExportFormat.Binary})
                Case COH_ExportFormat.CrypticS_TextFormat
                    Result = Activator.CreateInstance(TheType)
                    Return Result.Import_From_File(FilePath, New COH_Serialization_Settings(True) With {.Option_SelectedFormat = COH_ExportFormat.CrypticS_TextFormat})
                Case COH_ExportFormat.CrypticS_BINFormat
                    ShowMessage_SimpleError(FilePath & "Contains Multiple Records, Cannot Extract This Way")
                    Return False
            End Select
            Return False
        End Function
#End Region
    End Class
End Namespace