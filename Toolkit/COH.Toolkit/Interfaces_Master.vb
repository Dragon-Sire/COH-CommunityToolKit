Imports COH.Storage.Controllers
Imports COH.Toolkit.Enums

Namespace CodeManagement.Interfaces
    Public Interface ISupport_MasterController
        Function Retrieve_ModableContent(ContentType As COH_ProjectContent) As List(Of ISupport_COH_OriginolSources)
        Function Retrieve_ModableContent(ByRef Search As String, ContentType As COH_ProjectContent) As ISupport_COH_OriginolSources
        Function Retrieve_Structs(ContentType As COH_ProjectContent) As List(Of COH_FileStructure)
        Function RetrieveStruct(ByRef Search As String, ContentType As COH_ProjectContent, SelectedFormat As COH_ExportFormat, ByRef Result As COH_FileStructure) As Boolean
        Function RetrieveStruct_FilePath(ByRef Search As String, ContentType As COH_ProjectContent, SelectedFormat As COH_ExportFormat) As String
        Function Retrieve_Content_FromFileName_NoPath(ContentType As COH_ProjectContent, RelativePath As String, SelectedFormat As COH_ExportFormat, ByRef Result As COH_FileStructure) As Boolean
        Function Retrieve_Content_FromFileName_RelativePath(ContentType As COH_ProjectContent, RelativePath As String, SelectedFormat As COH_ExportFormat, ByRef Result As COH_FileStructure) As Boolean
        Function Retrieve_Content_FromFileName(TheType As Type, FilePath As String, SelectedFormat As COH_ExportFormat, ByRef Result As COH_FileStructure) As Boolean
        Function Retrieve_AllContent_FromFileNames_RelativePath(ContentType As COH_ProjectContent, SelectedFormat As COH_ExportFormat) As List(Of COH_FileStructure)
        ReadOnly Property TheController_Assets As ISupport_COH_AssetRetrieval
        ReadOnly Property TheController_Localize As ISupport_COH_LocalizeContent
        ReadOnly Property TheController_SupportedStructures As COH_FileStructureIndex_Controller
        ReadOnly Property CurrentProjectFile As ProjectFiles.COH_ProjectFile
    End Interface
End Namespace