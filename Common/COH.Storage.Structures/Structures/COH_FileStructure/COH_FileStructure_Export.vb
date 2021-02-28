#If EDITOR Then
Imports System.IO
Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization
Imports COH.Storage.Serialization.Configuration
#End If

Namespace Storage.Structures
#If EDITOR Then
    Partial Public Class COH_FileStructure

#Region "Export - To File"
        Public Function Export_To_File(FileName As String, Folder As String, Format As COH_ExportFormat) As Boolean
            Return Export_To_File(FileName, Folder, New COH_Serialization_Settings(True, Format))
        End Function
        Public Function Export_To_File(FileName As String, Folder As String, ByRef Settings As COH_Serialization_Settings) As Boolean
            Dim ExportFileName = Determine_CleanFileName(Settings.Option_SelectedFormat, Folder, FileName)
            Select Case Settings.Option_SelectedFormat
                Case COH_ExportFormat.Unspecified
                    'ShowErrorOccured("Export to Unspecified FileFormat Not Supported")
                    'Return False
                Case COH_ExportFormat.CrypticS_BINFormat, COH_ExportFormat.Binary
                    Return Export_To_FileStream(ExportFileName, Settings)
                Case COH_ExportFormat.CrypticS_TextFormat
                   ' Return DefFile_Export(ExportFileName, Me)
                Case COH_ExportFormat.XML
                    ' Return XMLFile_Export(ExportFileName, Me)
                Case Else
                    '//  ShowErrorOccured("Unable to Export to Unknown Format")
                    Return False
            End Select
        End Function
        Private Function Export_To_FileStream(ExportFileName As String, ByRef Settings As COH_Serialization_Settings) As Boolean
            Dim CurrentStream As FileStream = New FileStream(ExportFileName, FileMode.Create)
            Try
                Using CurrentWriter As New COH_BinaryWriter(CurrentStream, Settings.Options_TextEncoding)
                    CurrentWriter.Settings = Settings
                    Export_To_Stream(CurrentWriter)
                    CurrentWriter.Flush()
                End Using
                CurrentStream.Close()
                CurrentStream = Nothing
            Catch ex As Exception
                '// ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to WriteToFile", ex, True)
            End Try
            Return True
        End Function
        Public Overridable Function Determine_DefaultRelativeFilePath(Format As COH_ExportFormat, Optional ShortenPath As Boolean = True) As String
            Dim FullPath As String = InternalDisplayName & Determine_FileExt(Format)
            Return FullPath
        End Function
        Private Function Determine_FileExt(Format As COH_ExportFormat) As String
            Select Case Format
                Case COH_ExportFormat.Binary
                    Return "." & Default_BinaryExtention()
                Case COH_ExportFormat.CrypticS_BINFormat
                    Return "." & Default_BinaryExtention()
                Case COH_ExportFormat.CrypticS_TextFormat
                    Return "." & Default_CrypricSExtention()
                Case COH_ExportFormat.XML
                    Return ".XML"
                Case Else
                    Return ".RAW"
            End Select
        End Function
        Private Function Determine_CleanFileName(Format As COH_TextFormat, ByRef Folder As String, Optional FileName As String = Nothing) As String

            If Not Folder.Substring(Folder.Length - 1, 1) = "\" Then Folder = Folder & "\"
            If FileName Is Nothing Then
                Return Folder & Determine_DefaultRelativeFilePath(Format)
            Else
                Return Folder & FileName
            End If
        End Function
#End Region

#Region "Export - Stream"
        Public Function Export_To_MemoryStream(ByRef StreamResult As IO.MemoryStream) As Boolean
            Return Export_To_MemoryStream(StreamResult, Nothing)
        End Function
        Public Function Export_To_MemoryStream(ByRef StreamResult As IO.MemoryStream, ByRef Settings As COH_Serialization_Settings) As Boolean
            If Settings Is Nothing Then Settings = New COH_Serialization_Settings(True, COH_ExportFormat.Unspecified)
            Dim Succeeded As Boolean = True
            StreamResult = New IO.MemoryStream
            Try
                Using CurrentWriter As New COH_BinaryWriter(StreamResult, Settings.Options_TextEncoding, True)
                    CurrentWriter.Settings = Settings
                    If Export_To_Stream(CurrentWriter) = False Then Succeeded = False
                    CurrentWriter.Flush()
                End Using
            Catch ex As Exception
                Succeeded = False
                ' ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to WriteToMemoryStream", ex, True)
            End Try
            Return Succeeded
        End Function
        Public Overridable Function Export_To_Stream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Return Write_ToStream(CurrentWriter)
        End Function
        Protected Overridable Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            ' ShowErrorOccured("Export to Stream Not Supported by this Structure")
            Return False
        End Function
#End Region

#Region "Export - TEXT FORMATS"
        Public Function Export_to_TextFormat(ByRef Result As String) As Boolean
            Return Export_to_TextFormat(Result, Nothing)
        End Function
        Public Function Export_to_TextFormat(ByRef Result As String, ByRef Settings As COH_Serialization_Settings) As Boolean
            Select Case Settings.Option_SelectedFormat
                Case COH_TextFormat.XML
                    Return Export_To_TextFormat_XML(Result, Settings)
                Case COH_TextFormat.CrypticS_TextFormat
                    Return Export_To_TextFormat_CrypticS(Result, Settings)
                Case Else
                    'ShowErrorOccured("Export to Specified Format Not Supported by this Structure")
                    Result = "ERROR"
                    Return False
            End Select
            Return True
        End Function
        Public Overridable Function Export_To_TextFormat_XML(ByRef Result As String, ByRef Settings As COH_Serialization_Settings) As Boolean
            'If XMLFile_Export_String(Me, Result, Settings) = False Then
            ' Result = Result & Environment.NewLine & ".......ERROR OCCURED"
            'Return False
            ' End If
            Return True
        End Function
        Public Overridable Function Export_To_TextFormat_CrypticS(ByRef Result As String, ByRef Settings As COH_Serialization_Settings) As Boolean
            ' If DefFile_Export_String(Me, Result, Settings) = False Then
            ' Result = Result & Environment.NewLine & ".......ERROR OCCURED"
            ' Return False
            ' End If
            ' Return True
        End Function
#End Region
    End Class
#End If
End Namespace