Imports COH.CodeManagement.Enums.Binary

Namespace Storage.Serialization
    Partial Public NotInheritable Class COH_BinaryReader

#Region "Read Single Character"
        Public Overloads Function ReadChar(Optional StringEncoding As COH_Supported_StringEncoding = COH_Supported_StringEncoding.Default) As Char
            If StringEncoding = COH_Supported_StringEncoding.Default Then Return ReadChar()
            Select Case StringEncoding
                Case COH_Supported_StringEncoding.ASCII
                    Return ReadChar_Ascii()
                Case COH_Supported_StringEncoding.UTF16
                    Return ReadChar_UTF16(COH_Supported_BinaryByteOrder.LittleEndian)
                Case COH_Supported_StringEncoding.UTF16_BigEndian
                    Return ReadChar_UTF16(COH_Supported_BinaryByteOrder.BigEndian)
                Case COH_Supported_StringEncoding.UTF32
                    Return ReadChar_UTF32(COH_Supported_BinaryByteOrder.LittleEndian)
                    'Case COH_Supported_StringEncoding.UTF16_Fixed2Bytes
                '    Return ReadChar_UTF16_Fixed2Bytes(COH_Supported_BinaryByteOrder.LittleEndian)
                Case COH_Supported_StringEncoding.UTF7
                    '//ERROR throw not supported
                    Return ""
                Case COH_Supported_StringEncoding.UTF8
                    Return ReadChar_UTF8()
                Case Else
                    '//ERROR throw not supported
                    Return ""
            End Select
        End Function
        Private Function ReadChar_Ascii() As Char
            Dim ByteBuffer(0) As Byte
            ByteBuffer(0) = ReadByte()
            Return Text.Encoding.ASCII.GetChars(ByteBuffer)(0)
        End Function
        Private Function ReadChar_UTF8() As Char
            Dim ByteBuffer() As Byte
            Dim FirstBYte As Byte = ReadByte()
            If FirstBYte >= 252 Then ' CAN BE 6 MAX Length?
                ReDim ByteBuffer(5)
            ElseIf FirstBYte >= 248 Then '245 seen referenced??
                ReDim ByteBuffer(4)
            ElseIf FirstBYte >= 240 Then
                ReDim ByteBuffer(3)
            ElseIf FirstBYte >= 224 Then
                ReDim ByteBuffer(2)
            ElseIf FirstBYte >= 192 Then
                ReDim ByteBuffer(1)
            Else
                ReDim ByteBuffer(0)
            End If
            ByteBuffer(0) = FirstBYte
            For X = 1 To ByteBuffer.Length - 1
                ByteBuffer(X) = ReadByte()
            Next
            Return Text.Encoding.UTF8.GetChars(ByteBuffer)(0)
        End Function
        Private Function ReadChar_UTF16(ByteOrder As COH_Supported_BinaryByteOrder) As Char
            Dim FirstInt As Int16 = ReadInt16(ByteOrder)
            If FirstInt <= 55295 Then ' 2BYTES
                Return Text.Encoding.Unicode.GetChars(BitConverter.GetBytes(FirstInt))(0)
            ElseIf FirstInt >= 57344 And FirstInt <= 65533 Then '2 Bytes
                Return Text.Encoding.Unicode.GetChars(BitConverter.GetBytes(FirstInt))(0)
            ElseIf FirstInt > 55295 And FirstInt < 57343 Then 'SURROGATE PAIR STUFF
                'NO IDEA
            Else '4 BYTES
                Dim SecondInt As Int16 = ReadInt16(ByteOrder)
                Dim FirstByteArray As Byte() = BitConverter.GetBytes(FirstInt)
                Dim SecondByteArray As Byte() = BitConverter.GetBytes(SecondInt)
                Dim ByteBuffer As Byte() = FirstByteArray.Union(SecondByteArray).ToArray()
                Return Text.Encoding.Unicode.GetChars(ByteBuffer)(0)
            End If
            Return ""
        End Function
        Private Function ReadChar_UTF16_Fixed2Bytes(ByteOrder As COH_Supported_BinaryByteOrder) As Char
            Dim ByteBuffer() As Byte = ReadBytes(2, ByteOrder)
            Return Text.Encoding.Unicode.GetChars(ByteBuffer)(0)
        End Function
        Private Function ReadChar_UTF32(ByteOrder As COH_Supported_BinaryByteOrder) As Char
            Dim ByteBuffer() As Byte = ReadBytes(4, ByteOrder)
            Return Text.Encoding.UTF32.GetChars(ByteBuffer)(0)
        End Function
#End Region

#Region "Byte Reader - Multiple Chars"
        Public Overloads Function ReadChars(Count As Integer, Optional CharEncoding As COH_Supported_StringEncoding = COH_Supported_StringEncoding.Default) As Char()
            If CharEncoding = COH_Supported_StringEncoding.Default Then
                Dim ResultChar = MyBase.ReadChars(Count) : OnPositionChanged()
                Return ResultChar
            End If
            Dim Result As Char() : ReDim Result(Count - 1)
            For X = 0 To Count - 1
                Result(X) = ReadChar(CharEncoding)
            Next
            Return Result
        End Function
#End Region

#Region "Read String - Char by Char, Zero Ended"
        Public Function ReadString_ZeroEnded_Ascii() As String
            Dim TheBytes = ReadBytes_UntilZero()
            If TheBytes Is Nothing Then Return ""
            If TheBytes.Count = 0 Then Return ""
            Dim Result As String = Text.ASCIIEncoding.ASCII.GetString(TheBytes.ToArray)
            Return Result
        End Function
        Public Function ReadString_ZeroEnded_UTF8() As String
            Dim TheBytes = ReadBytes_UntilZero()
            If TheBytes Is Nothing Then Return ""
            If TheBytes.Count = 0 Then Return ""

            Dim Result As String = Text.UTF8Encoding.UTF8.GetString(TheBytes.ToArray)
            Return Result
        End Function
        Public Function ReadBytes_UntilZero() As Byte()
            Dim TheBytes As New List(Of Byte)
            Dim LastByte As Byte = 255
            Do
                If RemainingBytes = 0 Then Exit Do
                LastByte = ReadByte()
                If LastByte = 0 Then Exit Do
                TheBytes.Add(LastByte)
            Loop
            Return TheBytes.ToArray
        End Function
#End Region

#Region "Fixed Length Strings"
        Public Function ReadString_LengthFixed_Ascii(Count As UInt64) As String
            Return System.Text.Encoding.ASCII.GetString(ReadBytes(Count))
        End Function
        Public Function ReadString_LengthFixed_Ascii(Count As UInt64, SplitAtZero As Boolean) As String
            If Count = 0 Then Return ""
            Dim Result As String = HelperFunctions.StringsAndThings.ConvertTo_String(ReadBytes(Count), 0, Count, COH_Supported_StringEncoding.ASCII)
            If SplitAtZero = True Then
                If Not Result.Contains(Convert.ToChar(0)) Then
                    Return Result.Substring(0, Result.IndexOf(Convert.ToChar(0)))
                End If
            End If
            Return Result
        End Function
        Public Function ReadString_LengthFixed_UTF8(Count As UInt64, Optional SplitAtZero As Boolean = False) As String
            If Count = 0 Then Return ""
            Dim Result As String = HelperFunctions.StringsAndThings.ConvertTo_String(ReadBytes(Count), 0, Count, COH_Supported_StringEncoding.UTF8)
            If SplitAtZero = True Then
                If Result.Contains(Convert.ToChar(0)) Then
                    Return Result.Substring(0, Result.IndexOf(Convert.ToChar(0))) ' InStr(Result, Convert.ToChar(0)) - 1)
                End If
            End If
            Return Result
        End Function
        Public Function ReadString_LengthFixed_UTF16_Fixed2Bytes(Count As UInt64, Optional SplitAtZero As Boolean = False) As String
            If Count = 0 Then Return ""
            Dim Result As String = HelperFunctions.StringsAndThings.ConvertTo_String(ReadBytes(Count * 2), 0, Count * 2, COH_Supported_StringEncoding.UTF16)
            If SplitAtZero = True Then
                If Not Result.Contains(Convert.ToChar(0)) Then
                    Return Result.Substring(0, Result.IndexOf(Convert.ToChar(0))) ' InStr(Result, Convert.ToChar(0)) - 1)
                End If
            End If
            Return Result
        End Function
#End Region
    End Class
End Namespace