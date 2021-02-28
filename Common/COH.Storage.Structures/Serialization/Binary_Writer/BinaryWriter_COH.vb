Imports COH.HelperClasses.Wrappers
Imports COH.Storage.Serialization.Configuration

Namespace Storage.Serialization
    Partial Public NotInheritable Class COH_BinaryWriter

#Region "Arrays"
        Public Sub Write_CrypticS_StringArray(Source As String())
            If Source Is Nothing OrElse Source.Length = 0 Then
                Write(CInt(0))
                Exit Sub
            Else
                Write(CInt(Source.Length))
            End If
            For X2 = 0 To Source.Length - 1
                Write_CrypticS_String(Source(X2))
            Next
        End Sub
        Public Sub Write_CrypticS_IntegerArray(Source As Integer())
            If Source Is Nothing OrElse Source.Length = 0 Then
                Write(CInt(0))
                Exit Sub
            Else
                Write(CInt(Source.Count))
            End If
            For X2 = 0 To Source.Length - 1
                Write(Source(X2))
            Next
        End Sub
        Public Sub Write_CrypticS_SingleArray(Source As Single())
            If Source Is Nothing OrElse Source.Length = 0 Then
                Write(CInt(0))
                Exit Sub
            Else
                Write(CInt(Source.Count))
            End If
            For X2 = 0 To Source.Length - 1
                Write(Source(X2))
            Next
        End Sub
#End Region

#Region "Values"
        Public Sub Write_CrypticS_Byte_Aligned4(value As Byte)
            Write(value)
            Write(New Byte(2) {0, 0, 0})
        End Sub
        Public Sub Write_CrypticS_Short_Aligned4(value As UInt16)
            Write(value)
            Write(New Byte(1) {0, 0})
        End Sub
        Public Sub Write_CrypticS_Flags(Value As UInteger)
            Write(CUInt(Value))
        End Sub
        Public Sub Write_CrypticS_Boolean(source As Boolean)
            If source = True Then
                Write(CInt(1))
            Else
                Write(CInt(0))
            End If
        End Sub
        Public Sub Write_CrypticS_RG(Source As Drawing.Color)
            Write(CInt(Source.R))
            Write(CInt(Source.G))
        End Sub
        Public Sub Write_CrypticS_RGB(Source As Drawing.Color)
            Write(CInt(Source.R))
            Write(CInt(Source.G))
            Write(CInt(Source.B))
        End Sub
        Public Sub Write_CrypticS_RGBA(Source As Drawing.Color)
            Write(CInt(Source.R))
            Write(CInt(Source.G))
            Write(CInt(Source.B))
            Write(CInt(Source.A))
        End Sub
        Public Sub Write_CrypticS_CondRGB(Source As Drawing.Color)
            Write(CInt(Source.R))
            Write(CInt(Source.G))
            Write(CInt(Source.B))
            Write(CInt(Source.A))
        End Sub
        Public Sub Write_CrypticS_Vector2(source As HelperClasses.COH_Struct_Vector2)
            Write(source.X)
            Write(source.Y)
        End Sub
        Public Sub Write_CrypticS_Vector3(source As HelperClasses.COH_Struct_Vector3)
            Write(source.X)
            Write(source.Y)
            Write(source.Z)
        End Sub
        Public Sub Write_CrypticS_Vector4(source As HelperClasses.COH_Struct_Vector4)
            Write(source.X)
            Write(source.Y)
            Write(source.Z)
            Write(source.W)
        End Sub
        Public Sub Write_CrypticS_TimeStamp(source As Int32)
            Write(source)
        End Sub
        Public Sub Write_CrypticS_Degrees(source As HelperClasses.COH_Struct_Degrees)
            Write(source.v1)
            Write(source.v2)
            Write(source.v3)
        End Sub
#End Region

#Region "Strings "
        Public Sub Write_CrypticS_String(ByRef source As COH_XML_CrypticS_String)
            If source Is Nothing OrElse source.Key.Length = 0 Then
                Write(CShort(0))
            Else
                Write(CShort(source.Key.Length))
                Write(Text.ASCIIEncoding.ASCII.GetBytes(source.Key))
            End If
            CrypticS_AlignString(source.Key.Length + 2)
        End Sub
        Public Sub Write_CrypticS_String(source As String)
            If source Is Nothing OrElse source.Length = 0 Then
                Write(CShort(0))
            Else
                Write(CShort(source.Length))
                Write(Text.ASCIIEncoding.ASCII.GetBytes(source))
            End If
            CrypticS_AlignString(source.Length + 2)
        End Sub
        Private Sub CrypticS_AlignString(ByVal nPos As UInteger)
            Dim NumAlignmentBytes As Integer = (4 - (nPos And 3)) And 3
            If NumAlignmentBytes = 0 Then Exit Sub
            Dim AlignmentBytes As Byte() = New Byte(NumAlignmentBytes - 1) {}
            Write(AlignmentBytes)
        End Sub
        Public Sub Write_CrypticS_String_ZeroEnded_UTF8(source As String)
            If source Is Nothing OrElse source.Length = 0 Then
                Write(CByte(0))
            Else
                Dim Enc = Text.Encoding.GetEncoding(850)
                Write(Enc.GetBytes(source))
                Write(CByte(0))
            End If
        End Sub
        Public Sub Write_CrypticS_String_FixedLength_UTF8(source As String)
            If source Is Nothing OrElse source.Length = 0 Then
                Write(CByte(0))
            Else
                Write(CShort(source.Length))
                Dim Enc = Text.Encoding.GetEncoding(850)
                Write(Enc.GetBytes(source))
            End If
        End Sub
        Public Sub Write_CrypticS_String_FixedLength_UTF8_IntCount(source As String)
            If source Is Nothing OrElse source.Length = 0 Then
                Write(CUInt(0))
            Else
                Write(CUInt(source.Length))
                Dim Enc = Text.Encoding.GetEncoding(850)
                Write(Enc.GetBytes(source))
            End If
        End Sub
#End Region

#Region "Structures"
        Public Function Write_CrypticS_StructArray_SingleItem(ByRef Source As Structures.COH_FileStructure, Optional Version As Integer = 0) As Boolean
            Dim Sources As Structures.COH_FileStructure() = New Structures.COH_FileStructure(0) {}
            Sources(0) = Source
            Return Write_CrypticS_StructArray(Sources, Version)
        End Function
        Public Function Write_CrypticS_StructArray(ByRef Sources As Structures.COH_FileStructure(), Optional Version As Integer = 0) As Boolean
            If Sources Is Nothing OrElse Sources.Count = 0 Then
                Write(CInt(0))
                Return True
            Else
                Write(CInt(Sources.Count))
            End If
            For x = 0 To Sources.Count - 1
                Dim X2 As Structures.COH_FileStructure = Sources(x)
                Write_CrypticS_Struct(X2)
            Next x
            Return True
        End Function
        Public Function Write_CrypticS_Struct(ByRef Source As Structures.COH_FileStructure, Optional Version As Integer = 0) As Boolean
            Dim CurrentStream As IO.MemoryStream = Nothing
            Source.Export_To_MemoryStream(CurrentStream, New COH_Serialization_Settings(True) With {.Option_Version = Version})
            Write(CInt(CurrentStream.Length - 0))
            Write(CurrentStream.ToArray)
            CurrentStream.Dispose()
            Return True
        End Function
#End Region
    End Class
End Namespace