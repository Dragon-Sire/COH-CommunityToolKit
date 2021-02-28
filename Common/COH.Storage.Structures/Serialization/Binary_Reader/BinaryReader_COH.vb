Imports COH.CodeManagement.Enums.Binary
Imports COH.HelperClasses.Wrappers

Namespace Storage.Serialization
    Partial Public NotInheritable Class COH_BinaryReader

#Region "Arrays"
        Public Function Read_CrypticS_StringArray() As String()
            Dim NumString As Integer = ReadInt32()
            Return Read_CrypticS_StringArray(NumString)
        End Function
        Public Function Read_CrypticS_StringArray(Count As Integer) As String()
            Dim Result As String() = New String(Count - 1) {}
            For X2 = 0 To Count - 1
                Result(X2) = Read_CrypticS_String()
            Next
            Return Result
        End Function
        Public Function Read_CrypticS_IntegerArray() As Integer()
            Dim NumIntegers As Integer = ReadInt32()
            Return Read_CrypticS_IntegerArray(NumIntegers)
        End Function
        Public Function Read_CrypticS_uIntegerArray() As UInteger()
            Dim NumIntegers As Integer = ReadUInt32()
            Return Read_CrypticS_uIntegerArray(NumIntegers)
        End Function
        Public Function Read_CrypticS_IntegerArray(Count As Integer) As Integer()
            Dim Result As Integer() = New Integer(Count - 1) {}
            For X2 = 0 To Count - 1
                Result(X2) = ReadInt32()
            Next
            Return Result
        End Function
        Public Function Read_CrypticS_uIntegerArray(Count As Integer) As UInteger()
            Dim Result As UInteger() = New UInteger(Count - 1) {}
            For X2 = 0 To Count - 1
                Result(X2) = ReadUInt32()
            Next
            Return Result
        End Function
        Public Function Read_CrypticS_SingleArray() As Single()
            Dim NumSingles As Integer = ReadInt32()
            Return Read_CrypticS_SingleArray(NumSingles)
        End Function
        Public Function Read_CrypticS_SingleArray(Count As Integer) As Single()
            Dim Result As Single() = New Single(Count - 1) {}
            For X2 = 0 To Count - 1
                Result(X2) = ReadSingle()
            Next
            Return Result
        End Function
#End Region

#Region "Values"
        Public Function ReadTriBoolean() As COH_TriBoolean
            Return ReadByte()
        End Function
        Public Function Read_CrypticS_Flags() As UInteger
            Dim Value = ReadUInt32()
            Return Value
        End Function
        Public Function Read_CrypticS_Flags_Singned() As Integer
            Dim Value = ReadInt32()
            Return Value
        End Function
        Public Function Read_CrypticS_Boolean() As Boolean
            Dim Value = ReadInt32()
            If Value = 1 Then Return True
            Return False
        End Function
        Public Function Read_CrypticS_BooleanByte() As Boolean
            Dim Value = ReadByte()
            If Value = 1 Then Return True
            Return False
        End Function
        Public Function Read_CrypticS_Byte_Aligned4() As Byte
            Dim Value = ReadBytes(4)
            Return Value(0)
        End Function
        Public Function Read_CrypticS_Short_Aligned4() As UShort
            Dim Value = ReadBytes(4)
            Return BitConverter.ToUInt16(Value, 0)
        End Function
        Public Function Read_CrypticS_RG() As Drawing.Color
            Dim ColorBytes() As Integer = New Integer(1) {ReadInt32(), ReadInt32()}
            Dim Result As Drawing.Color = Drawing.Color.FromArgb(ColorBytes(0), ColorBytes(1), 0)
            Return Result
        End Function
        Public Function Read_CrypticS_RGB() As Drawing.Color
            Dim ColorBytes() As Integer = New Integer(2) {ReadInt32(), ReadInt32(), ReadInt32()}
            Dim Result As Drawing.Color = Drawing.Color.FromArgb(ColorBytes(0), ColorBytes(1), ColorBytes(2))
            Return Result
        End Function
        Public Function Read_CrypticS_RGBA2() As Drawing.Color
            Dim ColorBytes() As Integer = New Integer(3) {ReadInt32(), ReadInt32(), ReadInt32(), ReadInt32()}
            Dim Result As Drawing.Color = Drawing.Color.FromArgb(ColorBytes(3), ColorBytes(0), ColorBytes(1), ColorBytes(2))
            Return Result
        End Function
        Public Function Read_CrypticS_CondRGB() As Drawing.Color
            Dim ColorBytes() As Integer = New Integer(3) {ReadInt32(), ReadInt32(), ReadInt32(), ReadInt32()}
            Dim Result As Drawing.Color = Drawing.Color.FromArgb(ColorBytes(3), ColorBytes(0), ColorBytes(1), ColorBytes(2))
            Return Result
        End Function
        Public Function Read_CrypticS_Vector2() As HelperClasses.COH_Struct_Vector2
            Dim VectorBytes As Single() = New Single(1) {ReadSingle(), ReadSingle()}
            Return New HelperClasses.COH_Struct_Vector2(VectorBytes(0), VectorBytes(1))
        End Function
        Public Function Read_CrypticS_Vector3() As HelperClasses.COH_Struct_Vector3
            Dim VectorBytes As Single() = New Single(2) {ReadSingle(), ReadSingle(), ReadSingle()}
            Return New HelperClasses.COH_Struct_Vector3(VectorBytes(0), VectorBytes(1), VectorBytes(2))
        End Function
        Public Function Read_CrypticS_Vector4() As HelperClasses.COH_Struct_Vector4
            Dim VectorBytes As Single() = New Single(3) {ReadSingle(), ReadSingle(), ReadSingle(), ReadSingle()}
            Return New HelperClasses.COH_Struct_Vector4(VectorBytes(0), VectorBytes(1), VectorBytes(2), VectorBytes(3))
        End Function
        Public Function Read_CrypticS_TimeStamp() As Int32
            Return ReadInt32()
        End Function
        Public Function Read_CrypticS_Degrees() As HelperClasses.COH_Struct_Degrees
            Dim DegreeSingles As Single() = New Single(2) {ReadSingle(), ReadSingle(), ReadSingle()}
            Return New HelperClasses.COH_Struct_Degrees(DegreeSingles(0), DegreeSingles(1), DegreeSingles(2))
        End Function
        Public Function Read_CrypticS_Matrix4() As HelperClasses.COH_Struct_Matrix4
            Dim VectorBytes As HelperClasses.COH_Struct_Vector3() = New HelperClasses.COH_Struct_Vector3(3) {Read_CrypticS_Vector3(), Read_CrypticS_Vector3(), Read_CrypticS_Vector3(), Read_CrypticS_Vector3()}
            Return New HelperClasses.COH_Struct_Matrix4(VectorBytes(0), VectorBytes(1), VectorBytes(2), VectorBytes(3))
        End Function
#End Region

#Region "Strings - Parse 7"
        Public Function Read_CrypticS_String_Parse7BIN() As String
            Dim TempLength_String As Int32 = ReadUInt32()
            Dim Result As String = ""
            If TempLength_String <= 0 Then
                Result = ""
            Else
                Result = ReadString_LengthFixed_Ascii(TempLength_String)
            End If
            CrypticS_AlignString(TempLength_String)
            Return Result
        End Function
        Private Function Read_CrypticS_String_Parse7() As String
            Dim Start As Int32 = ReadInt32() '+ 2
            If Start >= Settings.Argument.Length Then
                ' ShowErrorOccured("String Pointer is Larger than Buffer, Possible Structure Change", False)
            End If
            If Start = 0 Then Return ""
            Dim Finish As Integer = Settings.Argument.IndexOf(ChrW(0), Start)
            If Finish <= 0 Then
                Return Settings.Argument.Substring(Start)
            Else
                Return Settings.Argument.Substring(Start, Finish - Start)
            End If
        End Function
#End Region

#Region "Strings - Parse 6"
        Public Function Read_CrypticS_StringKey() As COH_XML_CrypticS_String
            Dim TempLength_String As Short = ReadInt16()
            Dim Result As String = ""
            If TempLength_String = 0 Then
                Result = ""
            Else
                Result = ReadString_LengthFixed_Ascii(TempLength_String)
            End If
            CrypticS_AlignString(TempLength_String + 2)
            Return New COH_XML_CrypticS_String(Result)
        End Function

        Public Function Read_CrypticS_String() As String
            If Settings.Option_Version = 7 Then Return Read_CrypticS_String_Parse7()
            Dim TempLength_String As Short = ReadInt16()
            Dim Result As String = ""
            If TempLength_String <= 0 Then
                Result = ""
            Else
                Result = ReadString_LengthFixed_Ascii(TempLength_String)
            End If
            CrypticS_AlignString(TempLength_String + 2)
            Return Result
        End Function

        Private Sub CrypticS_AlignString(ByVal nPos As UInteger)
            Dim NumAlignmentBytes As Integer = (4 - (nPos And 3)) And 3
            If NumAlignmentBytes = 0 Then Exit Sub
            Dim AlignmentBytes As Byte() = ReadBytes(NumAlignmentBytes)
        End Sub
        Private Function CrypticS_AlignString3(ByVal nPos As UInteger, ShowSkip As Boolean) As String
            Dim NumAlignmentBytes As Integer = (4 - (nPos And 3)) And 3
            If NumAlignmentBytes = 0 Then Return ""
            Dim AlignmentBytes As Byte() = ReadBytes(NumAlignmentBytes)
            If ShowSkip = False Then Return ""
            Dim AlignmentString As String = vbCrLf & "Skip: " & NumAlignmentBytes & " "
            For X = 0 To NumAlignmentBytes - 1
                AlignmentString += " " & (AlignmentBytes(X).ToString).PadLeft(2, "0")
            Next
            AlignmentString += vbCrLf
            Return AlignmentString
        End Function
        Public Function Read_CrypticS_String_ZeroEnded_UTF8() As String
            Dim TheBytes = ReadBytes_UntilZero()
            If TheBytes Is Nothing Then Return ""
            If TheBytes.Count = 0 Then Return ""
            Dim Enc = Text.Encoding.GetEncoding(850)
            Dim Result As String = Enc.GetString(TheBytes.ToArray)
            Return Result
        End Function
        Public Function Read_CrypticS_String_FixedLength_UTF8() As String
            Dim Count As UInt32 = ReadUInt16()
            Dim Enc = Text.Encoding.GetEncoding(850)
            Return Enc.GetString(ReadBytes(Count), 0, Count)
        End Function
        Public Function Read_CrypticS_String_FixedLength_UTF8_IntCount() As String
            Dim Count As UInt32 = ReadUInt32()
            Dim Enc = Text.Encoding.GetEncoding(850)
            Return Enc.GetString(ReadBytes(Count), 0, Count)
        End Function
        Public Function Read_CrypticS_String_FixedLength_UTF8(Count As UInt64) As String
            If Count = 0 Then Return ""
            Dim Enc = Text.Encoding.GetEncoding(850)
            Return Enc.GetString(ReadBytes(Count), 0, Count)
        End Function
#End Region

#Region "Structures"
        Public Function Read_CrypticS_StructArray_FirstItem(TheType As Type, ByRef Result As Structures.COH_FileStructure) As Boolean
            Dim Results As Structures.COH_FileStructure() = Nothing
            If Read_CrypticS_StructArray(TheType, Results) = False Then Return False
            Result = Results(0)
            Return True
        End Function
        Public Function Read_CrypticS_StructArray(TheType As Type, ByRef Result As Object) As Boolean
            Dim NumCount As Integer = ReadInt32()
            If NumCount = 0 Then Return True
            Dim TheList As Object() = Array.CreateInstance(TheType, NumCount)
            For X = 0 To NumCount - 1
                Dim NewItem As Structures.COH_FileStructure = Nothing
                If Read_CrypticS_Struct(TheType, NewItem) = False Then
                    TheList(X) = NewItem
                    Result = TheList
                    Return False
                End If
                TheList(X) = NewItem
            Next
            Result = TheList
            Return True
        End Function
        Public Function Read_CrypticS_Struct(TheType As Type, ByRef Result As Structures.COH_FileStructure) As Boolean
            '// mOptions.Option_Version = Version
            Dim NumBytes As Integer = ReadInt32()
            Dim NewItem As Structures.COH_FileStructure = Activator.CreateInstance(TheType)
            Dim ImportResult As Boolean '''= NewItem.Import_From_Stream(Me)
            Result = NewItem
            Return ImportResult
        End Function
#End Region
    End Class
End Namespace