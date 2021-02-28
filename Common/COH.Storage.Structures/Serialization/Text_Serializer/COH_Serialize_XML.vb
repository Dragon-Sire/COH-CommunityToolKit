Imports System.ComponentModel
Imports System.Xml
Imports COH.Storage.Serialization.Configuration
Imports COH.Storage.Structures.Generics
Imports COH.CodeManagement.Attributes
Imports COH.CodeManagement.Enums.Structures
Imports COH.HelperFunctions.Attributes

Namespace Storage.Serialization
    Public Class COH_XML_Serialization

#Region "Enums"
        Public Enum DateTimeSerializationMode
            [Default] = 0
            Local = 2
            Roundtrip = 1
        End Enum
        Public Enum ExtendedTypeCode
            [Boolean] = 3
            [Byte] = 6
            [Char] = 4
            DateTime = &H10
            DBNull = 2
            [Decimal] = 15
            [Double] = 14
            Empty = 0
            Int16 = 7
            Int32 = 9
            Int64 = 11
            [Object] = 1
            [SByte] = 5
            [Single] = 13
            [String] = &H12
            UInt16 = 8
            UInt32 = 10
            UInt64 = 12
        End Enum
#End Region

#Region "Private Properties"
        Public ReadOnly Property Settings As COH_Serialization_Settings
            Get
                Return mOptions
            End Get
        End Property

        Private mStringWriter As IO.StringWriter
        Private mCurrentWriter As XmlTextWriter
        Private mOptions As COH_Serialization_Settings
        Private mListTypes_Numeric As List(Of Type)
        Private mListTypes_String As List(Of Type)
        Private mListTypes_StringV As List(Of Type)
        Private mListTypes_List As List(Of Type)
        Private mCurrentLevel As Integer
#End Region

#Region "Create New Instance"
        Sub New()
            Me.New(New COH_Serialization_Settings(True, COH_ExportFormat.XML))
        End Sub
        Public Sub New(ByRef Settings As COH_Serialization_Settings)
            mOptions = Settings
            Initialize()
        End Sub
        Private Sub Initialize()
            mCurrentLevel = 0
            mStringWriter = New IO.StringWriter()
            mCurrentWriter = New XmlTextWriter(mStringWriter) With {.Formatting = Formatting.Indented, .Indentation = 2}
            Initialize_NumericType()
            Initialize_StringType()
            Initialize_StringType_Single()
            mListTypes_List = New List(Of Type) From {GetType(IList), GetType(ICollection)}
        End Sub
        Private Sub Initialize_NumericType()
            mListTypes_Numeric = New List(Of Type)
            mListTypes_Numeric.Add(GetType(Int16))
            mListTypes_Numeric.Add(GetType(Int32))
            mListTypes_Numeric.Add(GetType(Int64))
            mListTypes_Numeric.Add(GetType(UInt16))
            mListTypes_Numeric.Add(GetType(UInt32))
            mListTypes_Numeric.Add(GetType(UInt64))
            mListTypes_Numeric.Add(GetType(Decimal))
            mListTypes_Numeric.Add(GetType(Single))
            mListTypes_Numeric.Add(GetType(Double))
        End Sub
        Private Sub Initialize_StringType()
            mListTypes_String = New List(Of Type)
            mListTypes_String.Add(GetType(String))
            mListTypes_String.Add(GetType(CrypticS_String))
            mListTypes_String.Add(GetType(CrypticS_String_NotLocalizable))
            mListTypes_String.Add(GetType(CrypticS_NotAligned))
        End Sub
        Private Sub Initialize_StringType_Single()
            mListTypes_StringV = New List(Of Type)
            mListTypes_StringV.Add(GetType(String))
            mListTypes_StringV.Add(GetType(CrypticS_String_NotLocalizable))
        End Sub
#End Region

#Region "Serialize"
        Public Function Serialize_ToXML(ByRef Source As Object) As String
            '//DO ALL HEADER XML STUFF HERE
            mCurrentWriter.WriteStartDocument()
            mCurrentWriter.WriteStartElement(Source.GetType.Name)
            mCurrentLevel = 0
            Write_Object_Attributes(Source)
            mCurrentLevel += 1
            Write_Object_Properties(Source)
            mCurrentWriter.WriteEndElement()
            mCurrentWriter.WriteEndDocument()
            Return mStringWriter.ToString
        End Function
        Public Function RetrieveText() As String
            Return mStringWriter.ToString
        End Function
        Private Sub Write_Property(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, IsAttribute As Boolean)
            If SingleProperty.PropertyType.IsEnum = True Then
                Write_Property_Enum(Source, SingleProperty, IsAttribute)
            ElseIf SingleProperty.PropertyType.IsArray = True Then
                Dim TheTypeCode As TypeCode = Type.GetTypeCode(SingleProperty.PropertyType.GetElementType)
                Select Case TheTypeCode
                    Case TypeCode.Object
                        Write_Property_ChildObjectArray(Source, SingleProperty)
                    Case Else
                        Write_Property_PrimitiveArray(Source, SingleProperty, TheTypeCode, IsAttribute)
                End Select
            ElseIf IsList(SingleProperty.PropertyType) = True Then
                Write_Property_ChildObjectList(Source, SingleProperty)
            Else
                Dim TheTypeCode As TypeCode = Type.GetTypeCode(SingleProperty.PropertyType)
                Select Case TheTypeCode
                    Case TypeCode.Object
                        If mListTypes_StringV.Contains(SingleProperty.PropertyType) Then
                            Write_Property_Primitive_ForceString(Source, SingleProperty, IsAttribute)
                        Else
                            Write_Property_ChildObject(Source, SingleProperty)
                        End If
                    Case Else
                        Write_Property_Primitive(Source, SingleProperty, TheTypeCode, IsAttribute)
                End Select
            End If
        End Sub
#End Region

#Region "GetProperties"
        Private Function RetrieveAttributes(ByRef Source As Object) As PropertyDescriptor()
            Dim type = GetType(Structures.COH_FileStructure)
            Dim TheCollection = Source.GetType.GetProperties()
            Dim TheProperties() As PropertyDescriptor = New PropertyDescriptor(TheCollection.Count - 1) {}
            Dim Index As Integer = 0
            For Each Item In TheCollection
                If Not Item.DeclaringType() = type Then
                    TheProperties(Index) = GetPropertyDescriptor(Item)
                    Index += 1
                End If
            Next
            For Each Item In TheCollection
                If Item.DeclaringType() = type Then
                    TheProperties(Index) = GetPropertyDescriptor(Item)
                    Index += 1
                End If
            Next
            Return TheProperties
        End Function
        Private Function RetrieveProperties(ByRef Source As Object) As PropertyDescriptor()
            Dim type = GetType(Structures.COH_FileStructure)
            Dim TheCollection = Source.GetType.GetProperties()
            Dim TheProperties() As PropertyDescriptor = New PropertyDescriptor(TheCollection.Count - 1) {}
            Dim Index As Integer = 0
            For Each Item In TheCollection
                If Item.DeclaringType() = type Then
                    TheProperties(Index) = GetPropertyDescriptor(Item)
                    Index += 1
                End If
            Next
            For Each Item In TheCollection
                If Not Item.DeclaringType() = type Then
                    TheProperties(Index) = GetPropertyDescriptor(Item)
                    Index += 1
                End If
            Next
            Return TheProperties
        End Function
        Public Shared Function GetPropertyDescriptor(ByVal PropertyInfo As Reflection.PropertyInfo) As PropertyDescriptor
            Return TypeDescriptor.GetProperties(PropertyInfo.DeclaringType).Item(PropertyInfo.Name)
        End Function
#End Region

#Region "Write XML Elements"
        Private Sub WriteEmptyTag(ByVal Name As String, Optional IsAttribute As Boolean = False, Optional [NameSpace] As String = "")
            If mOptions.Option_Export_DontWriteEmpty = True Then Exit Sub
            If ((Not Name Is Nothing) AndAlso (Name.Length <> 0)) Then
                If IsAttribute = False Then
                    mCurrentWriter.WriteStartElement(Name, [NameSpace])
                    mCurrentWriter.WriteEndElement()
                Else
                    mCurrentWriter.WriteStartAttribute(Name, [NameSpace])
                    mCurrentWriter.WriteEndAttribute()
                End If
            End If
        End Sub
        Private Sub WriteString(ByVal Name As String, Value As String, IsAttribute As Boolean, Optional [NameSpace] As String = "")
            If mOptions.Option_Export_DontWriteEmpty = True AndAlso String.IsNullOrEmpty(Value) Then Exit Sub
            If ((Not Value Is Nothing) AndAlso (Value.Length <> 0)) Then
                If IsAttribute = False Then
                    mCurrentWriter.WriteElementString(Name, Value)
                Else
                    mCurrentWriter.WriteAttributeString(Name, Value)
                End If
            Else
                WriteEmptyTag(Name, IsAttribute, "")
                'mCurrentWriter.WriteStartElement(Name, [NameSpace])
                'mCurrentWriter.WriteAttributeString("nil", "http://www.w3.org/2001/XMLSchema-instance", "true")
                'mCurrentWriter.WriteEndElement()
            End If
        End Sub
        Private Sub WriteValue(PropertyName As String, Value As String, IsAttribute As Boolean)
            If IsAttribute = False Then
                mCurrentWriter.WriteElementString(PropertyName, Value)
            Else
                'mCurrentWriter.WriteStartAttribute(PropertyName, Value)
                mCurrentWriter.WriteAttributeString(PropertyName, Value)
            End If
        End Sub
#End Region

#Region "Write Object"
        Private Sub Write_Object_Attributes(ByRef Source As Object)
            Dim TheType As Type = Source.GetType
            Dim TheProperties = RetrieveAttributes(Source)
            Dim AllowWrite As Boolean = True
            For Each SingleProperty As PropertyDescriptor In TheProperties
                AllowWrite = True
                If Retrieve_XMLAttribute(Source, SingleProperty) = False Then AllowWrite = False
                If AllowWrite = True AndAlso SingleProperty.Category = "_ProjectFile" AndAlso mCurrentLevel >= 1 Then AllowWrite = False
                If AllowWrite = True AndAlso SingleProperty.Category = "_ProjectFile" AndAlso mOptions.Option_Export_DontWriteProject = True Then AllowWrite = False
                If AllowWrite = True Then Write_Property(Source, SingleProperty, True)
            Next
        End Sub
        Private Sub Write_Object_Properties(ByRef Source As Object)
            Dim TheType As Type = Source.GetType
            Dim TheProperties = RetrieveProperties(Source)
            Dim AllowWrite As Boolean = True
            Dim Version As COH_VersionRange = Nothing
            For Each SingleProperty As PropertyDescriptor In TheProperties
                AllowWrite = True
                If SingleProperty.IsReadOnly = True Then AllowWrite = False
                If AllowWrite = True AndAlso Retrieve_XMLIgnore(Source, SingleProperty) = True Then AllowWrite = False
                If AllowWrite = True AndAlso Retrieve_XMLDebug(Source, SingleProperty) = True And mOptions.Option_Export_DontWriteDebug Then AllowWrite = False
                If AllowWrite = True AndAlso Retrieve_XMLAttribute(Source, SingleProperty) = True Then AllowWrite = False
                If AllowWrite = True AndAlso Retrieve_XMLversion(Source, SingleProperty, Version) = True Then
                    If Settings.Option_Version < Version.MinVersion Or Settings.Option_Version > Version.MaxVersion Then AllowWrite = False
                    'If Settings.Option_Build  
                End If
                If AllowWrite = True Then Write_Property(Source, SingleProperty, False)
            Next
        End Sub
        Private Sub Write_Property_ChildObjectList(ByRef Parent As Object, ByRef SingleProperty As PropertyDescriptor)
            Dim PropertyName As String = Retrieve_PropertyName(Parent, SingleProperty)
            Dim ItemName As String = Retrieve_PropertyName_ArrayItem(Parent, SingleProperty)
            Dim TheArray As IList = SingleProperty.GetValue(Parent)
            'mCurrentWriter.WriteStartElement(PropertyName)
            Dim ArrayType As String = TheArray.GetType.Name.Replace("[]", "")
            For X = 0 To TheArray.Count - 1
                Dim TheValue As Object = TheArray.Item(X)
                If TheValue Is Nothing Then
                    WriteEmptyTag(ArrayType, False, "")
                Else
                    Dim TheTypeCode As TypeCode = Type.GetTypeCode(TheValue.GetType)
                    Select Case TheTypeCode
                        Case TypeCode.Object
                            'Write_Property_ChildObject(Parent, SingleProperty)
                        Case Else
                            Write_Property_PrimitiveItem(PropertyName, TheValue, Nothing, TheTypeCode, False)
                    End Select
                End If
            Next
            'mCurrentWriter.WriteEndElement()
        End Sub
        Private Sub Write_Property_ChildObjectArray(ByRef Parent As Object, ByRef SingleProperty As PropertyDescriptor)
            Dim PropertyName As String = Retrieve_PropertyName(Parent, SingleProperty)
            Dim ItemName As String = Retrieve_PropertyName_ArrayItem(Parent, SingleProperty)
            Dim TheArray As Array = SingleProperty.GetValue(Parent)
            mCurrentWriter.WriteStartElement(PropertyName)
            Dim ArrayType As String = TheArray.GetType.Name.Replace("[]", "")
            For X = 0 To TheArray.Length - 1
                Dim TheValue As Object = TheArray.GetValue(X)
                If TheValue Is Nothing Then
                    WriteEmptyTag(ArrayType, False, "")
                Else
                    ItemName = TheValue.GetType.Name
                    Dim ItemPropertyName As String = ItemName
                    If (TheValue Is Nothing) Then
                        WriteEmptyTag(ItemName, False, "")
                    Else
                        mCurrentWriter.WriteStartElement(ItemName, "")
                        Write_Object_Attributes(TheValue)
                        Write_Object_Properties(TheValue)
                        mCurrentWriter.WriteEndElement()
                    End If
                End If
            Next
            mCurrentWriter.WriteEndElement()
        End Sub
        Private Sub Write_Property_ChildObject(ByRef Parent As Object, ByRef SingleProperty As PropertyDescriptor)
            Dim TheValue As Object = SingleProperty.GetValue(Parent)
            Dim DefaultValue As Object = Retrieve_DefaultValue(Parent, SingleProperty)
            Dim PropertyName As String = Retrieve_PropertyName(Parent, SingleProperty)
            If (TheValue Is Nothing) Then
                WriteEmptyTag(PropertyName, False, "")
            Else
                mCurrentWriter.WriteStartElement(PropertyName, "")
                Write_Object_Attributes(TheValue)
                Write_Object_Properties(TheValue)
                mCurrentWriter.WriteEndElement()
            End If
        End Sub
#End Region

#Region "Write Arrays"
        Private Sub Write_Property_PrimitiveArray(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, TheTypeCode As TypeCode, IsAttribute As Boolean)
            If SingleProperty.PropertyType.HasElementType = True Then
                Dim D1 = SingleProperty.PropertyType.GetElementType
                If D1.IsEnum = True Then
                    Write_Property_EnumArray(Source, SingleProperty, TheTypeCode, IsAttribute, D1)
                    Exit Sub
                End If
            End If
            Dim PropertyName As String = Retrieve_PropertyName(Source, SingleProperty)
            Dim TheArray As Array = SingleProperty.GetValue(Source)
            If TheArray Is Nothing Then
                WriteEmptyTag(PropertyName, False, "")
            Else
                Dim ItemPropertyName As String = Retrieve_PropertyName_ArrayItem(Source, SingleProperty)
                mCurrentWriter.WriteStartElement(PropertyName)
                For X = 0 To TheArray.Length - 1
                    Dim TheValue As Object = TheArray.GetValue(X)
                    Write_Property_PrimitiveItem(ItemPropertyName, TheValue, Nothing, TheTypeCode, IsAttribute)
                Next
                mCurrentWriter.WriteEndElement()
            End If
        End Sub
#End Region

#Region "Write Enums"
        Private Sub Write_Property_Enum(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, IsAttribute As Boolean)
            Dim DefaultValue As Object = Retrieve_DefaultValue(Source, SingleProperty)
            Dim PropertyName As String = Retrieve_PropertyName(Source, SingleProperty)
            Dim TheValue2 As [Enum] = SingleProperty.GetValue(Source)
            If Retrieve_EnumFlagAttribute(Source, SingleProperty) = True Then
                Write_Property_Enum_Flag(PropertyName, DefaultValue, IsAttribute, TheValue2)
            Else
                Write_Property_PrimitiveItem(PropertyName, Retrieve_EnumString(TheValue2), DefaultValue, TypeCode.String, IsAttribute)
            End If
        End Sub
        Private Sub Write_Property_Enum_Flag(PropertyName As String, DefaultValue As Object, IsAttribute As Boolean, CurrentEnum As [Enum])
            Dim TheValues As String() = CurrentEnum.ToString.Split(", ")
            If TheValues.Count <= 1 Then
                Write_Property_PrimitiveItem(PropertyName, Retrieve_EnumString(CurrentEnum), DefaultValue, TypeCode.String, IsAttribute)
            Else
                Dim NewValues As String() = New String(TheValues.Count - 1) {}
                For X = 0 To TheValues.Count - 1
                    Dim TheEnum As [Enum] = [Enum].Parse(CurrentEnum.GetType, TheValues(X).Trim)
                    NewValues(X) = Retrieve_EnumString(TheEnum)
                Next
                Write_Property_PrimitiveItem(PropertyName, String.Join(", ", NewValues), DefaultValue, TypeCode.String, IsAttribute)
            End If
        End Sub
        Private Function Retrieve_EnumString(TheEnum As [Enum]) As String
            Dim EnumV As COH_DefEnum = Nothing
            If Settings.Option_Export_DontWriteEnumOverrides = False AndAlso Retrieve_EnumDescription(TheEnum, EnumV) = True Then
                Return EnumV.DefName
            Else
                Return TheEnum.ToString
            End If
        End Function
        Private Sub Write_Property_EnumArray(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, TheTypeCode As TypeCode, IsAttribute As Boolean, EnumType As Type)
            Dim DefaultValue As Object = Retrieve_DefaultValue(Source, SingleProperty)
            Dim PropertyName As String = Retrieve_PropertyName(Source, SingleProperty)
            Dim ItemName As String = Retrieve_PropertyName_ArrayItem(Source, SingleProperty)
            Dim TheArray As Array = SingleProperty.GetValue(Source)
            If TheArray Is Nothing OrElse TheArray.Length = 0 Then
                WriteEmptyTag(PropertyName, False, "")
                Exit Sub
            End If
            Dim IsFlag As Boolean = Retrieve_EnumFlagAttribute(Source, SingleProperty)
            mCurrentWriter.WriteStartElement(PropertyName)
            For X = 0 To TheArray.Length - 1
                Dim TheValue As Integer = TheArray.GetValue(X)
                Dim TheEnum = [Enum].ToObject(EnumType, TheValue)

                If IsFlag = True Then
                    Write_Property_Enum_Flag(ItemName, DefaultValue, IsAttribute, TheEnum)
                Else
                    Write_Property_PrimitiveItem(ItemName, Retrieve_EnumString(TheEnum), DefaultValue, TypeCode.String, IsAttribute)
                End If
            Next
            mCurrentWriter.WriteEndElement()
        End Sub
#End Region

#Region "Write Primitives"
        Private Sub Write_Property_Primitive_ForceString(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, IsAttribute As Boolean)
            Dim TheValue As String = SingleProperty.GetValue(Source).ToString
            Dim DefaultValue As Object = Retrieve_DefaultValue(Source, SingleProperty)
            Dim PropertyName As String = Retrieve_PropertyName(Source, SingleProperty)
            Write_Property_PrimitiveItem(PropertyName, TheValue, DefaultValue, TypeCode.String, IsAttribute)
        End Sub
        Private Sub Write_Property_Primitive(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor, TheTypeCode As TypeCode, IsAttribute As Boolean)
            Dim TheValue As Object = SingleProperty.GetValue(Source)
            Dim DefaultValue As Object = Retrieve_DefaultValue(Source, SingleProperty)
            Dim PropertyName As String = Retrieve_PropertyName(Source, SingleProperty)
            Write_Property_PrimitiveItem(PropertyName, TheValue, DefaultValue, TheTypeCode, IsAttribute)
        End Sub
        Private Sub Write_Property_PrimitiveItem(PropertyName As String, ByRef TheValue As Object, ByRef DefaultValue As Object, TheTypeCode As TypeCode, IsAttribute As Boolean)
            Select Case TheTypeCode
                Case TypeCode.Boolean
                    Write_Boolean(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.String
                    Write_String(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.Int16
                    Write_INT16(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.Int32
                    Write_INT32(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.Int64
                    Write_INT64(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.UInt16
                    Write_UINT16(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.UInt32
                    Write_UINT32(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.UInt64
                    Write_UINT64(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.Single
                    Write_Single(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.Double
                    Write_Double(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.Decimal
                    Write_Decimal(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.Byte
                    Write_Byte(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.SByte
                    Write_SByte(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
                Case TypeCode.DateTime
                    Write_DateTime(PropertyName, TheValue, DefaultValue, IsAttribute)
                    Return
            End Select
        End Sub
        Public Sub Write_Byte(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "unsignedByte"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not Source.Equals(thedefault) Then
                WriteValue(PropertyName, XmlConvert.ToString(CByte(Source)), IsAttribute)
            End If
        End Sub
        Public Sub Write_SByte(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "Byte"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not Source.Equals(thedefault) Then
                WriteValue(PropertyName, XmlConvert.ToString(CSByte(Source)), IsAttribute)
            End If
        End Sub
        Public Sub Write_Boolean(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "boolean"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not Source.Equals(thedefault) Then
                WriteValue(PropertyName, XmlConvert.ToString(CBool(Source)), IsAttribute)
            End If
        End Sub
        Public Sub Write_String(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "string"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not Source.Equals(thedefault) Then
                WriteString(PropertyName, CStr(Source), IsAttribute, "")
            End If
        End Sub
        Public Sub Write_INT16(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "short"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False Then
                WriteValue(PropertyName, XmlConvert.ToString(CShort(Source)), IsAttribute)
            Else
                Dim SourceValue As Int16 = CShort(Source)
                If Not SourceValue.Equals(CShort(thedefault)) Then WriteValue(PropertyName, XmlConvert.ToString(SourceValue), IsAttribute)
            End If
        End Sub
        Public Sub Write_INT32(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "int"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False Then
                WriteValue(PropertyName, XmlConvert.ToString(CInt(Source)), IsAttribute)
            Else
                Dim SourceValue As Int32 = CInt(Source)
                If Not SourceValue.Equals(CInt(thedefault)) Then WriteValue(PropertyName, XmlConvert.ToString(SourceValue), IsAttribute)
            End If
        End Sub
        Public Sub Write_INT64(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "long"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False Then
                WriteValue(PropertyName, XmlConvert.ToString(CLng(Source)), IsAttribute)
            Else
                Dim SourceValue As Int64 = CLng(Source)
                If Not SourceValue.Equals(CLng(thedefault)) Then WriteValue(PropertyName, XmlConvert.ToString(SourceValue), IsAttribute)
            End If
        End Sub
        Public Sub Write_UINT16(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "unsignedShort"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False Then
                WriteValue(PropertyName, XmlConvert.ToString(CUShort(Source)), IsAttribute)
            Else
                Dim SourceValue As UInt16 = CUShort(Source)
                If Not SourceValue.Equals(CUShort(thedefault)) Then WriteValue(PropertyName, XmlConvert.ToString(SourceValue), IsAttribute)
            End If
        End Sub
        Public Sub Write_UINT32(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "unsignedInt"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False Then
                WriteValue(PropertyName, XmlConvert.ToString(CUInt(Source)), IsAttribute)
            Else
                Dim SourceValue As UInt32 = CUInt(Source)
                If Not SourceValue.Equals(CUInt(thedefault)) Then WriteValue(PropertyName, XmlConvert.ToString(SourceValue), IsAttribute)
            End If
        End Sub
        Public Sub Write_UINT64(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "unsignedLong"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False Then
                WriteValue(PropertyName, XmlConvert.ToString(CULng(Source)), IsAttribute)
            Else
                Dim SourceValue As UInt64 = CULng(Source)
                If Not SourceValue.Equals(CULng(thedefault)) Then WriteValue(PropertyName, XmlConvert.ToString(SourceValue), IsAttribute)
            End If
        End Sub
        Public Sub Write_Single(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "float"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not CSng(Source).Equals(CSng(thedefault)) Then
                WriteValue(PropertyName, XmlConvert.ToString(CSng(Source)), IsAttribute)
            End If
        End Sub
        Public Sub Write_Double(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "double"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not CDbl(Source).Equals(CDbl(thedefault)) Then
                WriteValue(PropertyName, XmlConvert.ToString(CDbl(Source)), IsAttribute)
            End If
        End Sub
        Public Sub Write_Decimal(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "decimal"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False Then
                WriteValue(PropertyName, XmlConvert.ToString(CDec(Source)), IsAttribute)
            Else
                Dim SourceValue As Decimal = CDec(Source)
                If Not SourceValue.Equals(CDec(thedefault)) Then WriteValue(PropertyName, XmlConvert.ToString(SourceValue), IsAttribute)
            End If
        End Sub
        Public Sub Write_Char(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "char"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not Source.Equals(thedefault) Then
                WriteValue(PropertyName, XmlConvert.ToString(CChar(Source)), IsAttribute)
            End If
        End Sub
        Public Sub Write_DateTime(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "dateTime"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not Source.Equals(thedefault) Then
                mCurrentWriter.WriteElementString(PropertyName, FromDateTime(CDate(Source)), IsAttribute)
            End If
        End Sub
        Public Sub Write_QName(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "QName"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not Source.Equals(thedefault) Then
                '//NOT SUPPORTED CURRENTLY
                '//mCurrentWriter.WriteElementString(PropertyName, DirectCast(Source, XmlQualifiedName), IsAttribute)
            End If
        End Sub
        Public Sub Write_TimeSpan(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "TimeSpan"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not Source.Equals(thedefault) Then
                WriteValue(PropertyName, XmlConvert.ToString(DirectCast(Source, TimeSpan)), IsAttribute)
            End If
        End Sub
        Public Sub Write_GUID(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "TimeSpan"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not Source.Equals(thedefault) Then
                WriteValue(PropertyName, XmlConvert.ToString(DirectCast(Source, Guid)), IsAttribute)
            End If
        End Sub
        Public Sub Write_Base64Binary(PropertyName As String, ByVal Source As Object, ByVal thedefault As Object, IsAttribute As Boolean)
            If String.IsNullOrEmpty(PropertyName) = True Then PropertyName = "base64Binary"
            If (Source Is Nothing) Then
                WriteEmptyTag(PropertyName, IsAttribute, "")
            ElseIf mOptions.Option_Export_DontWriteDefaults = False OrElse Not Source.Equals(thedefault) Then
                '// WriteValue(PropertyName, DirectCast(Source, Byte())), IsAttribute)
            End If
        End Sub
#End Region

#Region "Write Other"
        Private Sub Write_Property_Other(ByRef Source As Structures.COH_FileStructure, ByRef SingleProperty As PropertyDescriptor, TheTypeCode As TypeCode, IsAttribute As Boolean)
            Dim TheValue As Object = SingleProperty.GetValue(Source)
            Dim DefaultValue As Object = Retrieve_DefaultValue(Source, SingleProperty)
            Dim PropertyName As String = Retrieve_PropertyName(Source, SingleProperty)
            Write_Property_OtherItem(PropertyName, TheValue, DefaultValue, SingleProperty.PropertyType, IsAttribute)
        End Sub
        Private Sub Write_Property_OtherItem(PropertyName As String, ByRef TheValue As Object, ByRef DefaultValue As Object, TheType As Type, IsAttribute As Boolean)
            If (TheType Is GetType(XmlQualifiedName)) Then
                'Write_QName(TheValue)
                'Write_Boolean(PropertyName, TheValue, DefaultValue, IsAttribute)
                Return
            ElseIf (TheType Is GetType(TimeSpan)) Then
                Write_TimeSpan(PropertyName, TheValue, DefaultValue, IsAttribute)
                Return
            ElseIf (TheType Is GetType(Guid)) Then
                Write_GUID(PropertyName, TheValue, DefaultValue, IsAttribute)
                Return
            End If
        End Sub
#End Region

#Region "Internal Functions"
        Private Function Retrieve_DefaultValue(ByRef Source As Object, ByRef SingleProperty As PropertyDescriptor) As Object
            Dim DefaultValueAttrribute As DefaultValueAttribute = CType(SingleProperty.Attributes(GetType(DefaultValueAttribute)), DefaultValueAttribute)
            Dim DefaultValue As Object = Nothing
            If DefaultValueAttrribute Is Nothing Then
                If Check_TypeIsNumeric(SingleProperty.PropertyType) Then
                    Return 0
                ElseIf Check_TypeIsString(SingleProperty.PropertyType) Then
                    Return String.Empty
                Else
                    Return Nothing
                End If
            Else
                Return DefaultValueAttrribute.Value
            End If
        End Function
        Private Function Check_TypeIsNumeric(TheType As Type) As Boolean
            Return mListTypes_Numeric.Contains(TheType)
        End Function
        Private Function Check_TypeIsString(TheType As Type) As Boolean
            Return mListTypes_String.Contains(TheType)
        End Function
        Private Function FromDateTime(ByVal value As DateTime) As String
            If (mOptions.Option_DateFormat = DateTimeSerializationMode.Local) Then
                Return XmlConvert.ToString(value, "yyyy-MM-ddTHH:mm:ss.fffffffzzzzzz")
            End If
            Return XmlConvert.ToString(value, XmlDateTimeSerializationMode.RoundtripKind)
        End Function

        Public Function IsList(t As Type) As Boolean
            Return t.GetInterfaces.Where(Function(i) mListTypes_List.Contains(i)).Any
        End Function
#End Region

    End Class
End Namespace