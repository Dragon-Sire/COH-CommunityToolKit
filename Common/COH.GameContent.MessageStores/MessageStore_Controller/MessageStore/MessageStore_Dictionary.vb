Imports System.Xml.Serialization

Namespace GameContent.MessageStores.Structures.LanguageFiles
    <XmlRoot("COH_MessageStoreDictionary")>
    Public Class COH_MessageStore_Dictionary
        Inherits Dictionary(Of String, COH_MessageStore_Entry)
        Implements IXmlSerializable

#Region "Private Function"
        Private mValue_Serializer As XmlSerializer = New XmlSerializer(GetType(COH_MessageStore_Entry))
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New()
            mValue_Serializer = New XmlSerializer(GetType(COH_MessageStore_Entry))
        End Sub
        Private Shared Function CreateXML_NameSpace() As XmlSerializerNamespaces
            Dim XMLNameSpace As XmlSerializerNamespaces = New XmlSerializerNamespaces()
            XMLNameSpace.Add("", "")
            Return XMLNameSpace
        End Function
#End Region


#Region "Serialize"

        Public Sub WriteXml(ByVal CurrentWriter As System.Xml.XmlWriter) Implements IXmlSerializable.WriteXml
            For Each Key As String In Me.Keys
                CurrentWriter.WriteStartElement("Entry")
                CurrentWriter.WriteAttributeString("Key", Key.ToString)
                Dim value As COH_MessageStore_Entry = Me(Key)
                mValue_Serializer.Serialize(CurrentWriter, value, CreateXML_NameSpace)
                CurrentWriter.WriteEndElement()
            Next Key
        End Sub
        Public Sub ReadXml(ByVal CurrentReader As System.Xml.XmlReader) Implements IXmlSerializable.ReadXml
            Dim IsEmpty As Boolean = CurrentReader.IsEmptyElement
            CurrentReader.Read()
            If (IsEmpty) Then Return
            While (CurrentReader.NodeType <> System.Xml.XmlNodeType.EndElement)
                Dim CurrentKey As String = CurrentReader.GetAttribute("Key")
                CurrentReader.ReadStartElement()
                Dim value As COH_MessageStore_Entry = CType(mValue_Serializer.Deserialize(CurrentReader), COH_MessageStore_Entry)
                CurrentReader.ReadEndElement()
                Add(CurrentKey, value)
                CurrentReader.MoveToContent()
            End While
            CurrentReader.ReadEndElement()
        End Sub
#End Region

#Region "Schema"
        Public Function GetSchema() As System.Xml.Schema.XmlSchema Implements IXmlSerializable.GetSchema
            Return Nothing
        End Function
#End Region
    End Class
End Namespace