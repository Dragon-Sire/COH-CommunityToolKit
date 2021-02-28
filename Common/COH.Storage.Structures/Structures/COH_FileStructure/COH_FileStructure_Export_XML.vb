#If EDITOR Then
Imports System.Xml.Serialization
Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization
Imports COH.Storage.Serialization.Configuration
#End If

Namespace Storage.Structures
#If EDITOR Then
    Partial Public Class COH_FileStructure

        Private Shared Function CreateXML_NameSpace() As XmlSerializerNamespaces
            Dim XMLNameSpace As XmlSerializerNamespaces = New XmlSerializerNamespaces()
            XMLNameSpace.Add("", "")
            Return XMLNameSpace
        End Function
        Private Shared Function XMLFile_CreateXML_Settings() As Xml.XmlWriterSettings
            Dim result As New Xml.XmlWriterSettings
            result.Indent = True
            result.OmitXmlDeclaration = True
            result.WriteEndDocumentOnClose = True
            result.Encoding = Text.Encoding.GetEncoding(1252)
            Return result
        End Function
        Private Function XMLFile_Export(Filepath As String, Source As Object) As Boolean
            Dim NewPath As String = HelperFunctions.XML.COH_HelperFunctions_XML.CleanupFileName(Filepath)
            If IO.Directory.Exists(IO.Path.GetDirectoryName(NewPath)) = False Then IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(NewPath))
            Dim XMlString As String = ""
            Dim ExportResult As Boolean = XMLFile_Export_String(Source, XMlString, New COH_Serialization_Settings(True, COH_ExportFormat.XML))
            If ExportResult = False Then Return False
            Try
                'File.WriteAllText(NewPath, XMlString)
            Catch ex As Exception
                ' ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Export XML", ex, True)
                ExportResult = False
            End Try
            Return ExportResult
        End Function
        Private Function XMLFile_Export_String(Source As Object, ByRef Result As String, Optional ByRef Settings As COH_Serialization_Settings = Nothing) As Boolean
            Result = ""
            Dim ExportResult As Boolean = True
            Dim Test As COH_XML_Serialization = New COH_XML_Serialization(Settings)
            Try
                Result = Test.Serialize_ToXML(Source)
            Catch ex As Exception
                ' COH_LibraryEventController.ShowErrorOccured_Exception(Internal.Events.COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Export XML", ex, True)
                ExportResult = False
                Result = Test.RetrieveText
            End Try
            Return ExportResult
        End Function
    End Class
#End If
End Namespace