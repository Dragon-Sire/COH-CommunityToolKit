#If EDITOR Then
Imports System.IO
Imports System.Xml.Serialization
Imports COH.CodeManagement.Enums.Structures
#End If

Namespace Storage.Structures
#If EDITOR Then
    Partial Public Class COH_FileStructure
        Protected Overridable Function Import_From_TextStream_XML(ByRef Source As String, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either) As Boolean
            '//INIFICIENT WOULD NEED TO CLONE RESULT INTO SELF
            Return False
        End Function
        Public Shared Function Import_COHStruct_FromXMLFile(Filepath As String, SelectedType As Type, ByRef Result As COH_FileStructure) As Boolean
            Dim ImportXMLResult As COH_FileStructure = Nothing
            Dim ImportResult As Boolean = True
            If IO.File.Exists(Filepath) = True Then
                Try
                    Dim Reader As New IO.StreamReader(Filepath)
                    Dim x As New XmlSerializer(SelectedType)
                    ImportXMLResult = x.Deserialize(Reader)
                    Reader.Close()
                Catch ex As Exception
                    ' COH_LibraryEventController.ShowErrorOccured_Exception(Internal.Events.COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Import XML", ex, True)
                    ImportResult = False
                End Try
            End If
            Result = ImportXMLResult
            Return ImportResult
        End Function
    End Class
#End If
End Namespace