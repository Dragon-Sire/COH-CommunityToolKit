Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization
Imports COH.Storage.Structures

Namespace CodeManagement.Interfaces.Structures
    Public Interface ISupport_COH_DisplayName
        ReadOnly Property InternalDisplayName As String
    End Interface
    Public Interface ISupport_COH_LocalizeContent
        Function CreateKey(ByRef Value As String) As String
        Function CreateKey(ByRef Value As String, MessageStoreName As String) As String
        Function RetrieveLocalizedString(ByRef Search As String) As String
    End Interface
    Public Interface ISupport_COH_Localized
        Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
    End Interface
    Public Interface ISupport_COH_FileStructure
        Inherits ISupport_COH_Localized, ISupport_COH_Export, ISupport_COH_Import
        Function Export_To_MemoryStream(Optional Version As Integer = 0, Optional Format As COH_StreamFormat = COH_StreamFormat.Unspecified, Optional BuildType As COH_BuildType = COH_BuildType.Either) As IO.MemoryStream
        Function Export_To_File(Format As COH_StreamFormat, Folder As String, Optional FileName As String = Nothing, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either) As Boolean
        Function Export_To_TextFormat(ByRef Result As String, Optional Version As Integer = 0, Optional Format As COH_TextFormat = COH_TextFormat.XML, Optional BuildType As COH_BuildType = COH_BuildType.Either) As Boolean
        Property FilePathReference_Current As String
        Function Determine_DefaultRelativeFilePath(Format As COH_StreamFormat) As String
    End Interface
    Public Interface ISupport_COH_Export
        Function Export_To_Stream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
    End Interface
    Public Interface ISupport_COH_Import
        Function Import_From_Stream(ByRef CurrentReader As COH_BinaryReader) As Boolean
    End Interface
    Public Interface ISupport_COH_ExportToDEF
        Function Export_To_Def() As String
    End Interface
    Public Interface ISupport_COH_OriginolSources
        Property FullName As String
        Property IsCustom As Boolean
        Property WasModified_FromSource As Boolean
        Property RelativePath_Current As String
        Property RelativePath_Originol As String
        Property Content As COH_FileStructure
        Sub Initialize_DefaultRelativePath()
    End Interface
    Public Interface ISupport_COH_AssetRetrieval
        Function RetrieveAsset_ImageStruct(FilePath As String) As COH_FileStructure
        Function RetrieveAsset(ByRef Search As String) As COH_FileStructure
        Function RetrieveAsset(ByRef Search As String, Type As COH_Supported_ContentType)
        Function RetrieveAsset_FilePath(ByRef Search As String, Optional TheType As COH_Supported_ContentType = COH_Supported_ContentType.Unknown) As String
    End Interface
End Namespace