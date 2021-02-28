Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Retrieve Content"

        Function Retrieve_ModableContent(ByRef Search As String, ContentType As COH_ProjectContent) As ISupport_COH_OriginolSources Implements ISupport_MasterController.Retrieve_ModableContent
            Dim Details As COH_CrypticS_FileContentDetails = Nothing
            If mCached_CurrentProjectFile.Retrieve_Details(Search, ContentType, Details) = False Then Return Nothing

            Dim FileName As String = Details.XML_RelativePath
            Dim Folder As String = ProgramFolders.LookupFolder_ProjectFile(ContentType)
            Dim Destination As String = Folder & FileName
            Dim TheType As Type = Nothing
            Dim Index As Integer = 0
            If Retrieve_MapToType(ContentType, Nothing, Index, TheType) = False Then Return Nothing
            Dim ModType As Type = Nothing
            If Retrieve_MapToModType(ContentType, ModType) = False Then Return Nothing
            Dim NewItem As ISupport_COH_OriginolSources = Nothing
            If Retrieve_ModableContent_FromFileName(ModType, Destination, NewItem) = False Then Return Nothing
            NewItem.RelativePath_Current = Details.XML_RelativePath
            NewItem.IsCustom = Details.IsCustom
            NewItem.WasModified_FromSource = Details.WasModified_FromSource
            NewItem.RelativePath_Originol = Details.REF_OriginolPath
            NewItem.FullName = Details.REF_FullName
            Return NewItem
        End Function
        Public Function Retrieve_ModableContent(ContentType As COH_ProjectContent) As List(Of ISupport_COH_OriginolSources) Implements ISupport_MasterController.Retrieve_ModableContent
            Dim Results = New List(Of ISupport_COH_OriginolSources)
            Dim TheType As Type = Nothing
            Dim Index As Integer = 0
            If Retrieve_MapToType(ContentType, Nothing, Index, TheType) = False Then Return Nothing
            Dim TheList = mCached_CurrentProjectFile.Index_Retrieve(ContentType).Files(Index).Details
            Dim ModType As Type = Nothing
            If Retrieve_MapToModType(ContentType, ModType) = False Then Return Nothing
            For Each File In TheList
                Dim NewItem As ISupport_COH_OriginolSources = Nothing
                Dim FilePath As String = ProgramFolders.LookupFolder_ProjectFile(ContentType) & File.XML_RelativePath
                If Retrieve_ModableContent_FromFileName(ModType, FilePath, NewItem) = True Then
                    NewItem.IsCustom = File.IsCustom
                    NewItem.WasModified_FromSource = File.WasModified_FromSource
                    NewItem.RelativePath_Current = File.XML_RelativePath
                    NewItem.RelativePath_Originol = File.REF_OriginolPath
                    NewItem.FullName = File.REF_FullName
                    Results.Add(NewItem)
                End If
            Next
            Return Results
        End Function
        Public Function Retrieve_ModableContent_FromFileName(TheType As Type, FilePath As String, ByRef Result As COH_ModableContent) As Boolean
            Dim Content As COH_FileStructure = Nothing
            If COH_FileStructure.Import_COHStruct_FromXMLFile(FilePath, TheType, Content) = False Then
                Return False
            End If
            Result = New COH_ModableContent
            Result.Content = Content
            Return True
        End Function
#End Region


#Region "Extract"

#End Region

    End Class
End Namespace