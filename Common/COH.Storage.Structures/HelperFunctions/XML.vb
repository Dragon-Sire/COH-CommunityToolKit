Imports System.Xml
Imports System.Xml.Serialization

Namespace HelperFunctions.XML

    <HideModuleName> Public Module COH_HelperFunctions_XML

#Region "Import/Export"
        Private Function CreateXML_Settings() As XmlWriterSettings
            Dim result As New XmlWriterSettings
            result.Indent = True
            result.OmitXmlDeclaration = True
            result.WriteEndDocumentOnClose = True
            result.Encoding = Text.Encoding.GetEncoding(1252)
            Return result
        End Function
        Private Function CreateXML_NameSpace() As XmlSerializerNamespaces
            Dim XMLNameSpace As XmlSerializerNamespaces = New XmlSerializerNamespaces()
            XMLNameSpace.Add("", "")
            Return XMLNameSpace
        End Function
        Private Function CreateXML_AdditionalTypes() As Type()
            Dim XMLAdditionalTypes As Type() = New Type(0) {}
            '//XMLAdditionalTypes(0) = GetType(GameContent.Structures.Store.COH_ProductCatalogItem)
            Return XMLAdditionalTypes
        End Function
        Public Function Export_XMLFile(Filepath As String, Source As Object, UseAdditional As Boolean) As Boolean
            If UseAdditional = True Then
                Return Export_XMLFile(Filepath, Source, CreateXML_AdditionalTypes)
            Else
                Return Export_XMLFile(Filepath, Source, New Type() {})
            End If
        End Function
        Public Function Export_XMLFile(Filepath As String, Source As Object, Optional AdditionalTypes As Type() = Nothing) As Boolean
            Dim NewPath As String = CleanupFileName(Filepath)
            If IO.Directory.Exists(IO.Path.GetDirectoryName(NewPath)) = False Then IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(NewPath))
            Dim ExportResult As Boolean = True
            Try
                Dim Writer As New IO.StreamWriter(NewPath)
                Dim x As New XmlSerializer(Source.GetType, AdditionalTypes)
                x.Serialize(Writer, Source, CreateXML_NameSpace)
                Writer.WriteLine()
                Writer.Dispose()
            Catch ex As Exception
                'MsgBox(ex)
                ExportResult = False
            End Try
            Return ExportResult
        End Function
        Public Function Export_XML_String(Source As Object, ByRef Result As String, Optional AdditionalTypes As Type() = Nothing) As Boolean
            Result = ""
            Dim ExportResult As Boolean = True
            Try
                Dim xmlSerializer As XmlSerializer = New XmlSerializer(Source.GetType, AdditionalTypes)
                Using textWriter As IO.StringWriter = New IO.StringWriter()
                    xmlSerializer.Serialize(textWriter, Source, CreateXML_NameSpace)
                    Result = textWriter.ToString()
                End Using
            Catch ex As Exception
                'MsgBox(ex)
                ExportResult = False
            End Try
            Return ExportResult
        End Function
        Public Function CleanupFileName(Source As String) As String
            Dim Letter As String = Source.Substring(0, 2)
            Dim Result As String = Source.Substring(2)
            Source = Result.Replace(":", "_")
            Source = Source.Replace(ChrW(34), "")
            Source = Source.Replace("?", "")
            Source = Source.Replace("<", "")
            Return Letter & Source
        End Function
#End Region

    End Module
End Namespace