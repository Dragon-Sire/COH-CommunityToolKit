Namespace HelperFunctions.Defs
    Partial Public Class COH_DefReader

#Region "Properties"
        Public ReadOnly Property Entries As List(Of COH_FileStructure)
            Get
                Return mEntries
            End Get
        End Property
#End Region

#Region "Private Properties"
       Private mFileNames As List(Of String)
       Private mEntries As List(Of COH_FileStructure)
       Private mLineBuffer As String = Nothing
       Private mStringBuffer1 As String = Nothing
       Private mStringBuffer2 As String = Nothing
#End Region

#Region "Create New Instance"
        Public Sub New()
            ResetDefaults()
        End Sub
        Public Sub New(FileName As String)
            ResetDefaults()
            mFileNames = New List(Of String)
            mFileNames.Add(FileName)
            mEntries = New List(Of COH_FileStructure)
        End Sub
        Private Sub ResetDefaults()
            mEntries = New List(Of COH_FileStructure)
        End Sub
#End Region

#Region "Process Files"
        Private Function ProcessFiles() As Boolean
            Dim Line As String = ""
            mEntries = New List(Of COH_FileStructure)
            For Each File In mFileNames
                Using CurrentReader As IO.StreamReader = New IO.StreamReader(File, Text.Encoding.UTF8)
                    Return ProcessFile(CurrentReader)
                End Using
            Next
            Return True
        End Function
        Private Function ProcessFile(ByRef CurrentReader As IO.StreamReader) As Boolean
            Do
                RetrieveLineBuffers(CurrentReader)
                If IdentifyLine_IsCommentorEmptyLine(mLineBuffer) = False Then
                    If mLineBuffer = "Class" Then 'CharacterClass
                        mEntries.Add(ParseFromDef_CharacterClass(CurrentReader))
                    ElseIf mLineBuffer = "Origin" Then 'Origin
                        mEntries.Add(ParseFromDef_Origins(CurrentReader))
                    ElseIf mLineBuffer.Contains("PowerSet ") = True Then 'PowerSet
                        ' mEntries.Add(ParseFromDef_Powerset(CurrentReader))
                    ElseIf mLineBuffer.Contains("PowerCategory ") = True Then 'PowerSet
                        mEntries.Add(ParseFromDef_PowerCategory(CurrentReader))
                    End If
                End If
                If CurrentReader.EndOfStream = True Then Exit Do
            Loop
            Return True
        End Function
#End Region

#Region "RetrieveLine"
        Private Function RetrieveLine(ByRef CurrentReader As IO.StreamReader) As String
            Return CleanString(CurrentReader.ReadLine)
        End Function
        Private Function RetrieveLineSplit(ByRef CurrentReader As IO.StreamReader, ByRef Value1 As String, ByRef Value2 As String) As Boolean
            Dim Line As String = RetrieveLine(CurrentReader)
            Line = Trim(Line.Replace(Chr(9), " "))
            Dim Temp As String() = Line.Split(" ")
            Value1 = Trim(CleanStringValue(Temp(0)))
            Value2 = Trim(CleanStringValue(Temp(Temp.Length - 1)))
            If Value1.Contains("}") = True Then Return False
            Return (Not Value1 = "" And Not Value2 = "")
        End Function 'R
        Private Function RetrieveLineBuffers(ByRef CurrentReader As IO.StreamReader) As Boolean
            mLineBuffer = RetrieveLine(CurrentReader)
            mLineBuffer = Trim(mLineBuffer.Replace(Chr(9), " "))
            Dim Temp As String() = mLineBuffer.Split(" ")
            mStringBuffer1 = Trim(CleanStringValue(Temp(0)))
            mStringBuffer2 = Trim(CleanStringValue(Temp(Temp.Length - 1)))
            If mStringBuffer1.Contains("}") = True Then Return False
            Return (Not mStringBuffer1 = "" And Not mStringBuffer2 = "")
        End Function 'RetrieveLineSplit
        Private Function RetrieveLine_UntilNotEmpty(ByRef CurrentReader As IO.StreamReader) As String
            Dim Line As String = ""
            Do
                Line = CleanString(CurrentReader.ReadLine)
                If String.IsNullOrEmpty(Line) = False Then Return Line
            Loop
            Return ""
        End Function
#End Region

#Region "Clean Functions"
        Private Function CleanString(ByRef Source As String) As String
            If String.IsNullOrEmpty(Source) Then Return ""
            RemoveAllTabs_InFront(Source)
            Return Source
        End Function
        Public Function CleanStringValue(ByRef Source As String) As String
            Dim Result As String = Source
            Result = Result.Replace(Chr(34), "")
            Return Result
        End Function
        Private Sub RemoveAllTabs_InFront(ByRef Source As String)
            Dim offset As Integer = 0
            For x = 0 To Source.Length - 1
                If Mid(Source, x + 1, 1) = Chr(9) Then
                    offset += 1
                Else
                    Exit For
                End If
            Next
            Source = Trim(Source.Substring(offset))
        End Sub
        Private Function IdentifyLine_IsCommentorEmptyLine(Source As String) As Boolean
            If String.IsNullOrEmpty(Source) Then Return True
            If Source.Length >= 2 Then
                If Source.Substring(0, 2) = "//" Then Return True
            End If
            Return False
        End Function
#End Region

#Region "Split Functions"
        Public Function SplitLine(Source As String, ByRef Value1 As String, ByRef Value2 As String) As Boolean
            Dim Result = CleanString(Source)
            Dim Temp As String() = mLineBuffer.Split(" ")
            Value1 = Trim(CleanStringValue(Temp(0)))
            Value2 = Trim(CleanStringValue(Temp(Temp.Length - 1)))
            Return True
        End Function
#End Region
    End Class
End Namespace