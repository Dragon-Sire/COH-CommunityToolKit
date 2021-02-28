
Imports COH.CodeManagement.Enums.Binary

Namespace HelperFunctions.StringsAndThings
    <HideModuleName> Public Module COH_HelperFunctions_StringFunctions
        Public Const StringEncoding_FallBack As COH_Supported_StringEncoding = COH_Supported_StringEncoding.UTF8
        Public Const VisibleCharacters_UTF As String = "`~!@#$%^&*()-_+=|\1234567890 ABCDEFGHIJKLMNOPQRSTUVWXYZ[]{};:',.<>/?abcdefghijklmnopqrstuvwxyzÇüéâäàåçêëèïîìÄÅÉæôöòûùÿÖÜ¢£¥₧ƒáíóúñÑ½¼" & ChrW(34)
        Public Const VisibleCharacters_Ascii As String = "`~!@#$%^&*()-_+=|\1234567890 ABCDEFGHIJKLMNOPQRSTUVWXYZ[]{};:',.<>/?abcdefghijklmnopqrstuvwxyz" & ChrW(34)

#Region "Random"
        Public Function Generate_RandomChar(ByRef ValidCharacterString As String) As Char
            If ValidCharacterString Is Nothing Then ValidCharacterString = VisibleCharacters_UTF
            Dim Generator As System.Random = New System.Random(Guid.NewGuid().GetHashCode())
            Dim Result As Char = ValidCharacterString.Chars(Generator.Next(0, ValidCharacterString.Length)) '-1 removed
            Return Result
        End Function
        Public Function Generate_RandomChars(Count As Integer, ByRef ValidCharacterString As String) As Char()
            Dim Result As Char() = New Char(Count - 1) {}
            For X = 1 To Count
                Result(X - 1) = Generate_RandomChar(ValidCharacterString)
            Next
            Return Result
        End Function
        Public Function Generate_RandomString(Count As Integer, ByRef ValidCharacterString As String) As String
            Return String.Concat(Generate_RandomChars(Count, ValidCharacterString))
        End Function
#End Region

#Region "Empty Strings"
        Public Function Check_StringEmptyOrNull(value As String) As Boolean
            If (value Is Nothing) = True Then Return True
            If String.IsNullOrEmpty(value) = True Then Return True
            If String.IsNullOrWhiteSpace(value) = True Then Return True
            Return False
        End Function
#End Region

#Region "FixedLength"
        Public Function FixString_MaxLengthString(ByVal value As String, Optional MaxLength As UInteger = UInt32.MaxValue, Optional CleanStringSettings As COH_CleanStringFlags = 331) As String
            If MaxLength = 0 Then Return ""
            If Not (CleanStringSettings = 0) Then value = CleanString(value, CleanStringSettings)
            If value.Length > MaxLength Then value = value.Substring(0, MaxLength)
            If (CleanStringSettings And COH_CleanStringFlags.Trim) = True Then value = value.Trim
            Return value
        End Function
#End Region

#Region "Cleaning"
        Public Const ViewAbleCharacters As String = "`~!@#$%^&*()-_+=|\1234567890 ABCDEFGHIJKLMNOPQRSTUVWXYZ[]{};:',.<>/?abcdefghijklmnopqrstuvwxyzÇüéâäàåçêëèïîìÄÅÉæôöòûùÿÖÜ¢£¥₧ƒáíóúñÑ½¼" & """"
        Public Function Check_IsCharacterPrintable(ByRef value As Char) As Boolean
            Dim Result As Boolean = Not Char.IsControl(value)
            If Result = True Then Result = Not Char.IsWhiteSpace(value)
            Return Result
        End Function
        Public Function CleanString_TrimWhiteSpacesNull(value As String) As String
            Dim Start As Integer = 0
            Dim Finish As Integer = value.Length - 1
            Dim NullChar As Char = ChrW(&H0)
            While Start < value.Length
                If Not Char.IsWhiteSpace(value(Start)) AndAlso value(Start) <> NullChar Then Exit While
                Start += 1
            End While
            While Finish >= Start
                If Not Char.IsWhiteSpace(value(Finish)) AndAlso value(Finish) <> NullChar Then Exit While
                Finish -= 1
            End While
            Return value.Substring(Start, Finish - Start + 1)
        End Function
        Public Function CleanString(value As String, Optional Settings As COH_CleanStringFlags = 331) As String
            If Check_StringEmptyOrNull(value) = True Then
                If (Settings And COH_CleanStringFlags.AllowNull) = False Then
                    Return ""
                Else
                    Return value
                End If
            End If
            Dim ViewAbleCharactersSource As String = ViewAbleCharacters
            If (Settings And COH_CleanStringFlags.Remove_NewLines) = False Then ViewAbleCharactersSource = ViewAbleCharactersSource & vbLf & vbCr & vbCrLf & Environment.NewLine
            If (Settings And COH_CleanStringFlags.Remove_NewLines) = True Then
                value = value.Replace(ChrW(13) & ChrW(10), " ")
                value = value.Replace(Environment.NewLine, " ")
            End If
            If (Settings And COH_CleanStringFlags.ReturnOnZero) = True Then
                value = FixString_ReturnAtZero(value)
            End If
            value.Replace("&nbsp;", vbCrLf)    'changes to newline and return
            If (Settings And COH_CleanStringFlags.Remove_DoubleSpaces) = True Then
                value = FixString_RemoveDoubleSpaces(value)
            ElseIf (Settings And COH_CleanStringFlags.Remove_Spaces) = True Then
                value = value.Replace(" ", "")
            End If
            If (Settings And COH_CleanStringFlags.Remove_NonVisibleCharacters) = True Then
                value = FixString_RemoveInvalidCharacters(value, ViewAbleCharacters)
            End If
            If (Settings And COH_CleanStringFlags.Remove_DoubleSpacedLines) = True Then
                value = FixString_DoubleSpacing(value)
            End If
            If (Settings And COH_CleanStringFlags.Remove_SingleSpacedLines) = True Then
                value = FixString_RemoveSingleSpacing(value)
            End If
            If (Settings And COH_CleanStringFlags.Trim) = True Then
                Return value.Trim
            Else
                Return value
            End If
        End Function
#End Region

#Region "Clean Strings - COH"
        Public Const ViewAbleCharactersMessageStore As String = "`~!@#$%^&*()-_+=|\1234567890 ABCDEFGHIJKLMNOPQRSTUVWXYZ[]{};:',.<>/?abcdefghijklmnopqrstuvwxyz"
        Public Function Replace_SpecialCharacters(Source As String) As String
            Dim Result As String = Source
            Replace_NonVisibleCharacters(Result)
            Return Result
        End Function
        Public Function Return_SpecialCharacters(Source As String) As String
            Dim Result As String = Source
            Return_NonVisibleCharacters(Result)
            Return Result
        End Function
        Public Function Replace_NonVisibleCharacters(ByRef thestring As String) As Boolean
            ' If thestring.Contains(ChrW(160)) Then thestring = thestring
            'thestring = thestring.Replace(ChrW(194) & ChrW(160), "[NONBREAKSTRING]")
            'thestring = thestring.Replace(ChrW(160), "[NONBREAKSTRING]")
            thestring = thestring.Replace(ChrW(13), "[LINERETURN]")
            thestring = thestring.Replace(ChrW(10), "[LINEFEED]")
            thestring = thestring.Replace(ChrW(9), "[TAB]")
            thestring = thestring.Replace(ChrW(34), "[QUOTE]")
            thestring = thestring.Replace(ChrW(0), "[NULL]")
            Return True
        End Function
        Public Function Return_NonVisibleCharacters(ByRef thestring As String) As Boolean
            If thestring.Contains("[NONBREAKSTRING]") Then
                'thestring = thestring.Replace("[NONBREAKSTRING]", ChrW(194) & ChrW(160))
            End If
            thestring = thestring.Replace("[LINERETURN]", ChrW(13))
            thestring = thestring.Replace("[LINEFEED]", ChrW(10))
            thestring = thestring.Replace("[TAB]", ChrW(9))
            thestring = thestring.Replace("[QUOTE]", ChrW(34))
            thestring = thestring.Replace("[NULL]", ChrW(0))
            Return True
        End Function
#End Region

#Region "Repair Strings"
        Public Function FixString_StringEmptyOrNull(value As String) As String
            If Check_StringEmptyOrNull(value) = True Then Return ""
            Return value
        End Function
        Public Function FixString_ReturnAtZero(value As String) As String
            If value.Contains(ChrW(0)) = False Then Return value
            Dim Pos1 As Integer = value.IndexOf(ChrW(0))
            If Pos1 = 0 Then Return ""
            Return value.Substring(0, Pos1 - 1)
        End Function
        Public Function FixString_RemoveDoubleSpaces(value As String) As String
            Do While value.Contains("  ")
                value = value.Replace("  ", " ")
            Loop
            Return value
        End Function
        Public Function FixString_RemoveInvalidCharacters(value As String, AllowedCharacters As String) As String
            Dim Result As String = ""
            Dim CharV As Char = ""
            For X = 0 To value.Length - 1
                CharV = value.Substring(X, 1)
                If AllowedCharacters.Contains(CharV) = True Then
                    Result += CharV
                End If
            Next
            Return Result
        End Function
        Public Function FixString_RemoveSingleSpacing(ByVal thestring As String) As String
            Dim ExitNow As Boolean = False
            Do While ExitNow = False
                Dim PosN As Int16 = thestring.IndexOf(vbCrLf & vbCrLf)
                If PosN > 0 Then
                    thestring = thestring.Replace(vbCrLf & vbCrLf, vbCrLf)
                Else
                    ExitNow = True
                End If
            Loop
            Return thestring
        End Function
        Public Function FixString_DoubleSpacing(ByVal thestring As String) As String
            Dim ExitNow As Boolean = False
            Do While ExitNow = False
                Dim PosN As Int16 = thestring.IndexOf(vbCrLf & vbCrLf & vbCrLf)
                If PosN > 0 Then
                    thestring = thestring.Replace(vbCrLf & vbCrLf & vbCrLf, vbCrLf & vbCrLf)
                Else
                    ExitNow = True
                End If
            Loop
            Return thestring
        End Function
        Public Function FixString_Remove_UntilVisibleCharacter(ByVal value As String) As String
            Return FixString_Remove_UntilSpecifiedCharacter(value, ViewAbleCharacters)
        End Function
        Public Function FixString_Remove_UntilSpecifiedCharacter(ByVal value As String, SpecifiedCharacters As String) As String
            If SpecifiedCharacters Is Nothing OrElse SpecifiedCharacters = "" Then SpecifiedCharacters = ViewAbleCharacters
            For X = 0 To value.Length - 1
                Dim CharV As Char = value.Substring(X, 1)
                If SpecifiedCharacters.Contains(CharV) = True Then
                    Return value.Substring(X)
                End If
            Next
            Return ""
        End Function
        Public Function FixString_Remove_UntilVisibleCharacterRev(ByVal value As String) As String
            Return FixString_Remove_UntilSpecifiedCharacterRev(value, ViewAbleCharacters)
        End Function
        Public Function FixString_Remove_UntilSpecifiedCharacterRev(ByVal value As String, SpecifiedCharacters As String) As String
            If SpecifiedCharacters Is Nothing OrElse SpecifiedCharacters = "" Then SpecifiedCharacters = ViewAbleCharacters
            For X = value.Length - 1 To 0 Step -1
                Dim CharV As Char = value.Substring(X, 1)
                If SpecifiedCharacters.Contains(CharV) = True Then
                    Return value.Substring(0, X + 1)
                End If
            Next
            Return ""
        End Function
#End Region

#Region "String Encodings"
        Public Function Lookup_StringEncoding(StringEncoding As COH_Supported_StringEncoding) As Text.Encoding
            If StringEncoding = COH_Supported_StringEncoding.Default Then StringEncoding = StringEncoding_FallBack
            Select Case StringEncoding
                Case COH_Supported_StringEncoding.ASCII
                    Return Text.Encoding.ASCII
                Case COH_Supported_StringEncoding.UTF7
                    Return Text.Encoding.UTF7
                Case COH_Supported_StringEncoding.UTF8
                    Return Text.Encoding.UTF8
                Case COH_Supported_StringEncoding.UTF16
                    Return Text.Encoding.Unicode
                Case COH_Supported_StringEncoding.UTF16_BigEndian
                    Return Text.Encoding.BigEndianUnicode
                Case COH_Supported_StringEncoding.UTF32
                    Return Text.Encoding.UTF32
                Case Else
                    Return Text.Encoding.Unicode
            End Select
        End Function
        Public Function ConvertTo_String(ByRef TheBytes As Byte(), Offset As Integer, Count As Integer, UsedEncoding As COH_Supported_StringEncoding) As String
            Select Case UsedEncoding
                Case COH_Supported_StringEncoding.ASCII
                    Return New String(Text.Encoding.ASCII.GetChars(TheBytes, Offset, Count))
                Case COH_Supported_StringEncoding.UTF16
                    Return New String(Text.Encoding.Unicode.GetChars(TheBytes, Offset, Count))
                Case COH_Supported_StringEncoding.UTF32
                    Return New String(Text.Encoding.UTF32.GetChars(TheBytes, Offset, Count))
                Case COH_Supported_StringEncoding.UTF7
                    Return New String(Text.Encoding.UTF7.GetChars(TheBytes, Offset, Count))
                Case COH_Supported_StringEncoding.UTF8
                    Return New String(Text.Encoding.UTF8.GetChars(TheBytes, Offset, Count))
                    'Case COH_Supported_StringEncoding.UTF16_Fixed2Bytes
                    'Return New String(Text.Encoding.ASCII.GetChars(TheBytes, Offset, Count))
            End Select
            Return Nothing
        End Function
#End Region

#Region "Retrieve String InLine"
        Public Function Retrieve_Substring(ByRef Source As String, Start As Integer) As String
            Dim Finish As Integer = Source.IndexOf(ChrW(0), Start)
            If Finish = 0 Then
                Return Source.Substring(Start)
            Else
                Return Source.Substring(Start, Finish - Start)
            End If
        End Function
#End Region

#Region "Cloning"
        Public Function CloneString(ByRef Source As String) As String
            If Source Is Nothing Then Return String.Empty
            Return String.Copy(Source)
        End Function
        Public Function CloneStrings(ByRef Source As String()) As String()
            If Source Is Nothing Then Return New String() {}
            Dim Result As String() = New String(Source.Count - 1) {}
            Dim Index As Integer = 0
            For Each Item In Source
                Result(Index) = CloneString(Item)
                Index += 1
            Next
            Return Result
        End Function
        Public Function CloneStrings(ByRef Source As List(Of String)) As List(Of String)
            If Source Is Nothing Then Return New List(Of String)
            Dim Result As New List(Of String)(Source.Count - 1)
            For Each Item In Source
                Result.Add(CloneString(Item))
            Next
            Return Result
        End Function
#End Region

#Region "Write"
        Public Function Write_StringsToFile(ByRef TheList As List(Of String), FilePath As String) As Boolean
            Dim CurrentStream As IO.FileStream
            CurrentStream = New IO.FileStream(FilePath, System.IO.FileMode.OpenOrCreate)
            Dim CurretWriter As New IO.StreamWriter(CurrentStream)
            For Each Entry In TheList
                If Entry = "" Then
                    CurretWriter.WriteLine("[EMPTY]")
                Else
                    CurretWriter.WriteLine(Entry)
                End If
            Next
            CurretWriter.Flush()
            CurrentStream.Close()
            Return True
        End Function
#End Region

    End Module
End Namespace