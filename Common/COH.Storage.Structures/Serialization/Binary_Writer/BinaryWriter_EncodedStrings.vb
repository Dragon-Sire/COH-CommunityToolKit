Namespace Storage.Serialization
    Partial Public NotInheritable Class COH_BinaryWriter
        Implements IDisposable

#Region "String Length Marker"
        Public Sub WriteInt32_7BitEncoded(ByVal value As Integer)
            MyBase.Write7BitEncodedInt(value)
        End Sub
#End Region

#Region "Convert Functions"
        Public Function ConvertChars_ToBytes(ByRef Chars As Char()) As Byte()
            Dim Encoder As Text.Encoding = mOptions.Options_TextEncoding
            Dim Result As Byte() = Encoder.GetBytes(Chars)
            Return Result
        End Function
        Public Function ConvertString_ToBytes(ByRef value As String) As Byte()
            Dim Encoder As Text.Encoding = mOptions.Options_TextEncoding
            Dim Result As Byte() = Encoder.GetBytes(value)
            Return Result
        End Function
#End Region

#Region "Byte Order"
        Private Sub ChangeByteOrder(ByRef theBytes As Byte())
            'If mDefault_StringEncoding = COH_Supported_StringEncoding.UTF16 Then Exit Sub
            'If mDefault_StringEncoding = COH_Supported_StringEncoding.UTF16_BigEndian Then Exit Sub
            'If Check_CanChangeByteOrder(mDefault_StringEncoding) = False Then Exit Sub
        End Sub
#End Region

#Region "Write String - No Marker"
        Public Sub WriteString_NoMarker_Ascii(TheString As String)
            If TheString = "" Then
                Write(CByte(0))
            ElseIf String.IsNullOrEmpty(TheString) Then
                Write(CByte(0))
            Else
                Dim TheBytes As Byte() = Text.ASCIIEncoding.ASCII.GetBytes(TheString)
                Write(TheBytes)
            End If
        End Sub
        Public Sub WriteString_NoMarker_UTF8_COH(TheString As String)
            If TheString = "" Then
                Write(CByte(0))
            ElseIf String.IsNullOrEmpty(TheString) Then
                Write(CByte(0))
            Else
                Dim Enc = Text.Encoding.GetEncoding(850)
                Dim TheBytes As Byte() = Enc.GetBytes(TheString)
                Write(TheBytes)
            End If
        End Sub
#End Region

#Region "Write String - Char by Char, Zero Ended"
        Public Sub WriteString_ZeroEnded_Ascii(TheString As String)
            If TheString = "" Then
                Write(CByte(0))
            ElseIf String.IsNullOrEmpty(TheString) Then
                Write(CByte(0))
            Else
                Dim TheBytes As Byte() = Text.ASCIIEncoding.ASCII.GetBytes(TheString)
                Write(TheBytes)
                Write(CByte(0))
            End If
        End Sub
        Public Sub WriteString_ZeroEnded_UTF8_COH(TheString As String)
            If TheString = "" Then
                Write(CByte(0))
            ElseIf String.IsNullOrEmpty(TheString) Then
                Write(CByte(0))
            Else
                Dim Enc = Text.Encoding.GetEncoding(850)
                Dim TheBytes As Byte() = Enc.GetBytes(TheString)
                Write(TheBytes)
                Write(CByte(0))
                'End If
            End If
        End Sub
#End Region

        Private Function VerifyPrintable(ByRef TheString As String) As Boolean
            Dim COH_Characters = "!@#$%^&*()-_=+[]{|};:',<.>/?\ ~\r\n\t1234567890 ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" & ChrW(34) & ChrW(13) & ChrW(10) & ChrW(9)
            Dim Start As Integer = 0
            Dim Finish As Integer = TheString.Length - 1
            Dim Result As Boolean = True
            For X = Start To Finish
                Dim TheChar = TheString.Substring(X, 1)
                Dim TheCharV = AscW(TheChar)
                If TheCharV < 127 Then
                    If Not COH_Characters.Contains(TheChar) Then
                        Result = False
                        Exit For
                    End If
                End If
            Next
            Return True
        End Function

    End Class
End Namespace