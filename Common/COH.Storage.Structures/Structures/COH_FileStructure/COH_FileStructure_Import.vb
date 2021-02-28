#If EDITOR Then
Imports System.IO
Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization
Imports COH.Storage.Serialization.Configuration
#End If

Namespace Storage.Structures
#If EDITOR Then
    Partial Public Class COH_FileStructure

#Region "Import - From File"
        Public Function Import_From_File(FileName As String, Folder As String, Format As COH_ExportFormat) As Boolean
            Dim ImportFileName = Determine_CleanFileName(Format, Folder, FileName)
            Return Import_From_File(ImportFileName, New COH_Serialization_Settings(True, Format))
        End Function
        Public Function Import_From_File(FileName As String, Folder As String, ByRef Settings As COH_Serialization_Settings) As Boolean
            Return Import_From_File(IO.Path.Combine(Folder & FileName), Settings)
        End Function
        Public Function Import_From_File(FilePath As String, ByRef Settings As COH_Serialization_Settings) As Boolean
            Select Case Settings.Option_SelectedFormat
                Case COH_ExportFormat.Unspecified
                    ' ShowErrorOccured("Import From Unspecified FileFormat Not Supported")
                    Return False
                Case COH_ExportFormat.CrypticS_BINFormat
                    ' ShowErrorOccured("Import From CrypticS (BIN) Not Supported")
                    Return False
                Case COH_ExportFormat.CrypticS_TextFormat
                    ' ShowErrorOccured("Import From CrypticS (DEF) Not Supported")
                    Return False
                Case COH_ExportFormat.XML
                    'Dim NewMe As COH_FileStructure = Nothing
                    'XMLFile_Import(FilePath, Me.GetType, NewMe)
                    '///CLONE FROM BACK TO SELF
                    '  ShowErrorOccured("Import From XML Not Supported")
                    Return False
                Case COH_ExportFormat.Binary
                    '//If String.IsNullOrEmpty(FilePathReference_Current) = True Then FilePathReference_Current = FilePath
                    Return Import_From_FileStream(FilePath, Settings)
                Case Else
                    ' ShowErrorOccured("Unable to Import to Unknown Format")
                    Return False
            End Select
        End Function
        Private Function Import_From_FileStream(ImportFileName As String, ByRef Settings As COH_Serialization_Settings) As Boolean
            Dim CurrentStream As FileStream = New FileStream(ImportFileName, FileMode.Open)
            Try
                Using CurrentReader As New COH_BinaryReader(CurrentStream, Settings.Options_TextEncoding)
                    CurrentReader.Settings = Settings
                    Import_From_Stream(CurrentReader)
                End Using
                CurrentStream.Close()
                CurrentStream = Nothing
            Catch ex As Exception
                ' ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to ImportFromFile", ex, True)
            End Try
            Return True
        End Function
#End Region

#Region "Import"
        Public Function Import_From_Buffer(ByRef Buffer As Byte()) As Boolean
            Dim Stream As New IO.MemoryStream(Buffer)
            Return Import_From_MemoryStream(Stream, Nothing)
        End Function
        Public Function Import_From_Buffer(ByRef Buffer As Byte(), ByRef Settings As COH_Serialization_Settings) As Boolean
            If Settings Is Nothing Then Settings = New COH_Serialization_Settings(True, COH_ExportFormat.Unspecified)
            Dim Stream As New IO.MemoryStream(Buffer)
            Return Import_From_MemoryStream(Stream, Settings)
        End Function
        Public Function Import_From_MemoryStream(ByRef Stream As IO.MemoryStream) As Boolean
            Return Import_From_MemoryStream(Stream, Nothing)
        End Function
        Public Function Import_From_MemoryStream(ByRef Stream As IO.MemoryStream, ByRef Settings As COH_Serialization_Settings) As Boolean
            If Settings Is Nothing Then Settings = New COH_Serialization_Settings(True, COH_ExportFormat.Unspecified)
            Dim Succeeded As Boolean = True
            Try
                Using CurrentReader As New COH_BinaryReader(Stream)
                    Succeeded = Import_From_Stream(CurrentReader)
                End Using
            Catch ex As Exception
                Succeeded = False
                ' ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to WriteToMemoryStream", ex, True)
            End Try
            Return Succeeded
        End Function
        Public Function Import_From_Stream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            ''  Update_FromSettings(CurrentReader.Settings)
            Return Read_FromStream(CurrentReader)
        End Function
        Protected Overridable Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            ' ShowErrorOccured("Import From Stream Not Supported by this Structure")
            Return False
        End Function
        Public Function Import_From_TextFormat(ByRef Source As String, Optional Version As Integer = 0, Optional Format As COH_TextFormat = COH_TextFormat.XML, Optional BuildType As COH_BuildType = COH_BuildType.Either) As Boolean
            Select Case Format
                Case COH_TextFormat.XML
                    Return Import_From_TextStream_XML(Source, Version, BuildType)
                Case COH_TextFormat.CrypticS_TextFormat
                    Return Import_From_TextStream_DEF(Source, Version, BuildType)
                Case Else
                    Return False
            End Select
        End Function
        Protected Overridable Function Import_From_TextStream_DEF(ByRef Source As String, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either) As Boolean
            Return False
        End Function
#End Region

    End Class
#End If
End Namespace