#If EDITOR Then
Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization
Imports COH.Storage.Serialization.Configuration
#End If

Namespace Storage.Structures
#If EDITOR Then
    Partial Public Class COH_FileStructure

#Region "DEF - Serialization Standard"
        Private Function DefFile_Export(Filepath As String, Source As Object) As Boolean
            Dim NewPath As String = HelperFunctions.XML.COH_HelperFunctions_XML.CleanupFileName(Filepath)
            If IO.Directory.Exists(IO.Path.GetDirectoryName(NewPath)) = False Then IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(NewPath))
            Dim XMlString As String = ""
            Dim ExportResult As Boolean = DefFile_Export_String(Source, XMlString, New COH_Serialization_Settings(True, COH_ExportFormat.CrypticS_TextFormat))
            If ExportResult = False Then Return False
            Try
                'File.WriteAllText(NewPath, XMlString)
            Catch ex As Exception
                ' ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Export DEF", ex, True)
                ExportResult = False
            End Try
            Return ExportResult
        End Function
        Private Function DefFile_Export_String(Source As Object, ByRef Result As String, Optional ByRef Settings As COH_Serialization_Settings = Nothing) As Boolean
            Result = ""
            Dim ExportResult As Boolean = True
            Dim Test As COH_DEF_Serialization = New COH_DEF_Serialization(Settings)
            Try
                Result = Test.Serialize_ToDEF(Source)
            Catch ex As Exception
                '  COH_LibraryEventController.ShowErrorOccured_Exception(Internal.Events.COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Export DEF", ex, True)
                ExportResult = True
                Result = Test.RetrieveText
            End Try
            Return ExportResult
        End Function
#End Region
    End Class
#End If
End Namespace