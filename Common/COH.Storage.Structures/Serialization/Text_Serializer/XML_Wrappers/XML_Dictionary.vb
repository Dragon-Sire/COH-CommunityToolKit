Imports System.Xml.Serialization
Namespace HelperClasses.Wrappers
    <XmlRoot("COH_Dictionary")>
    Public Class COH_XML_Dictionary(Of TKey, TValue)
        Inherits Dictionary(Of TKey, TValue)
        Implements IXmlSerializable

#Region "Private Function"
        Private mKey_Serialize As XmlSerializer = New XmlSerializer(GetType(TKey), "")
        Private mValue_Serializer As XmlSerializer = New XmlSerializer(GetType(TValue))
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New()
            mKey_Serialize = New XmlSerializer(GetType(TKey))
            mValue_Serializer = New XmlSerializer(GetType(TValue))
        End Sub
#End Region

#Region "Serialize"
        Public Sub WriteXml(ByVal CurrentWriter As System.Xml.XmlWriter) Implements IXmlSerializable.WriteXml
            For Each Key As TKey In Me.Keys
                CurrentWriter.WriteStartElement("Entry")
                CurrentWriter.WriteStartElement("key")
                mKey_Serialize.Serialize(CurrentWriter, Key)
                CurrentWriter.WriteEndElement()
                CurrentWriter.WriteStartElement("value")

                Dim value As TValue = Me(Key)
                mValue_Serializer.Serialize(CurrentWriter, value)
                CurrentWriter.WriteEndElement()
                CurrentWriter.WriteEndElement()
            Next Key
        End Sub
        Public Sub ReadXml(ByVal CurrentReader As System.Xml.XmlReader) Implements IXmlSerializable.ReadXml
            Dim IsEmpty As Boolean = CurrentReader.IsEmptyElement
            CurrentReader.Read()
            If (IsEmpty) Then Return
            While (CurrentReader.NodeType <> System.Xml.XmlNodeType.EndElement)
                CurrentReader.ReadStartElement("Entry")
                CurrentReader.ReadStartElement("key")
                Dim key As TKey = CType(mKey_Serialize.Deserialize(CurrentReader), TKey)
                CurrentReader.ReadEndElement()
                CurrentReader.ReadStartElement("value")

                Dim value As TValue = CType(mValue_Serializer.Deserialize(CurrentReader), TValue)
                CurrentReader.ReadEndElement()
                Add(key, value)
                CurrentReader.ReadEndElement()
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