Imports System.ComponentModel
Imports System.Xml.Serialization
Imports COH.CodeManagement.Attributes

Namespace HelperFunctions.Attributes
    <HideModuleName()> Public Module COH_Attributes_Helper

#Region "Shared"
        Public Function Retrieve_COH_TOK(ByRef Source As Object, ByRef Result As COH_TOK) As Boolean
            Dim Attribs = System.Attribute.GetCustomAttributes(Source.GetType)
            For Each attr In Attribs
                If attr.GetType = GetType(COH_TOK) Then
                    Result = CType(attr, COH_TOK)
                    Exit For
                End If
            Next
            If Result Is Nothing Then
                Return False
            Else
                Return True
            End If
        End Function
        Public Function Retrieve_COH_TOK(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, ByRef Result As COH_TOK) As Boolean
            Result = CType(SingleProperty.Attributes(GetType(COH_TOK)), COH_TOK)
            Dim DefaultValue As Object = Nothing
            If Result Is Nothing Then
                Return False
            Else
                Return True
            End If
        End Function
        Public Function Retrieve_ClassName(ByRef Source As Object) As String
            Dim Result As COH_TOK = Nothing
            If Retrieve_COH_TOK(Source, Result) = False Then
                Return Source.GetType.Name
            Else
                Return Result.Name
            End If
        End Function
        Public Function Retrieve_PropertyName(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor) As String
            Dim Result As COH_TOK = Nothing
            If Retrieve_COH_TOK(Source, SingleProperty, Result) = False Then
                Dim TheName As String = ""
                If Retrieve_PropertyName_XMLElement(Source, SingleProperty, TheName) = True Then
                    Return TheName
                Else
                    Return SingleProperty.Name

                End If
            Else
                Return Result.Name
            End If
        End Function
        Public Function Retrieve_PropertyName_ArrayItem(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor) As String
            Dim TheName As String = ""
            If Retrieve_PropertyName_XMLItem(Source, SingleProperty, TheName) = True Then
                Return TheName
            Else
                If SingleProperty.PropertyType.IsArray = True Then
                    Return SingleProperty.PropertyType.GetElementType.Name
                Else
                    Return SingleProperty.PropertyType.Name
                End If
            End If
        End Function
#End Region

#Region "Enum Attributes"
        Public Function Retrieve_EnumFlagAttribute(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor) As Boolean
            Dim XMLAttrib As FlagsAttribute = CType(SingleProperty.Attributes(GetType(FlagsAttribute)), FlagsAttribute)
            Dim DefaultValue As Object = Nothing
            If XMLAttrib Is Nothing Then
                Return False
            Else
                Return True
            End If
        End Function
#End Region

#Region "XML Attributes"
        Public Function Retrieve_XMLAttribute(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor) As Boolean
            Dim XMLAttrib As XmlAttributeAttribute = CType(SingleProperty.Attributes(GetType(XmlAttributeAttribute)), XmlAttributeAttribute)
            Dim DefaultValue As Object = Nothing
            If XMLAttrib Is Nothing Then
                Return False
            Else
                Return True
            End If
        End Function
        Public Function Retrieve_XMLIgnore(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor) As Boolean
            Dim XMLAttrib As XmlIgnoreAttribute = CType(SingleProperty.Attributes(GetType(XmlIgnoreAttribute)), XmlIgnoreAttribute)
            Dim DefaultValue As Object = Nothing
            If XMLAttrib Is Nothing Then
                Return False
            Else
                Return True
            End If
        End Function
        Public Function Retrieve_XMLDebug(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor) As Boolean
            Dim XMLAttrib As COH_Attribute_XMLDebug = CType(SingleProperty.Attributes(GetType(COH_Attribute_XMLDebug)), COH_Attribute_XMLDebug)
            Dim DefaultValue As Object = Nothing
            If XMLAttrib Is Nothing Then
                Return False
            Else
                Return True
            End If
        End Function
        Public Function Retrieve_XMLversion(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, ByRef Result As COH_VersionRange) As Boolean
            Dim XMLAttrib As COH_VersionRange = CType(SingleProperty.Attributes(GetType(COH_VersionRange)), COH_VersionRange)
            If XMLAttrib Is Nothing Then
                Result = Nothing
                Return False
            Else
                Result = XMLAttrib
                Return True
            End If
        End Function
        Public Function Retrieve_EnumDescription(ByRef Source As [Enum], ByRef Result As COH_DefEnum) As Boolean
            Return COH_DefEnum.GetAttribute(Source, Result)
        End Function
        Public Function Retrieve_EnumDescription(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, ByRef Result As COH_DefEnum) As Boolean
            Dim XMLAttrib As COH_DefEnum = CType(SingleProperty.Attributes(GetType(COH_DefEnum)), COH_DefEnum)
            If XMLAttrib Is Nothing Then
                Result = Nothing
                Return False
            Else
                Result = XMLAttrib
                Return True
            End If
        End Function
        Public Function Retrieve_PropertyName_XMLElement(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, ByRef Name As String) As Boolean
            Dim XMLAttrib As XmlElementAttribute = CType(SingleProperty.Attributes(GetType(XmlElementAttribute)), XmlElementAttribute)
            If XMLAttrib Is Nothing Then
                Name = SingleProperty.Name
                Return False
            Else
                Name = XMLAttrib.ElementName
                Return True
            End If
        End Function
        Public Function Retrieve_PropertyName_XMLItem(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, ByRef Name As String) As Boolean
            Dim XMLAttrib As XmlArrayItemAttribute = CType(SingleProperty.Attributes(GetType(XmlArrayItemAttribute)), XmlArrayItemAttribute)
            Dim DefaultValue As Object = Nothing
            If XMLAttrib Is Nothing Then
                Name = SingleProperty.Name
                Return False
            Else
                Name = XMLAttrib.ElementName
                Return True
            End If
        End Function
#End Region

    End Module
End Namespace