Imports COH.Toolkit.Enums

Namespace HelperFunctions.Defs
    Partial Public Class COH_DefReader

#Region "Parse PowerSet"
        '       Private Function ParseFromDef_Powerset(ByRef CurrentReader As IO.StreamReader) As COH_PowerSet
        '       Dim Result As New COH_PowerSet
        '           Result.ClassName = mStringBuffer2
        '           mLineBuffer = RetrieveLine(CurrentReader)
        ''      Do
        '      If RetrieveLineBuffers(CurrentReader) = False Then Exit Do
        '      Dim ResultField = COH_PowerSet.RetrieveProperties_Enum(mStringBuffer1)
        ''     Dim IsLocalized As Boolean = True
        '     If IsLocalized = True Then
        ''    Select Case ResultField
        '    Case COH_Enum_PowerSet.DisplayHelp
        '                        ResultField = COH_Enum_PowerSet.DisplayHelpKey
        ''   Case COH_Enum_PowerSet.DisplayName
        '                       ResultField = COH_Enum_PowerSet.DisplayNameKey
        ''  Case COH_Enum_PowerSet.DisplayShortHelp
        '                      ResultField = COH_Enum_PowerSet.DisplayShortHelpKey
        '  End Select
        '  End If
        ''         Result.UpdateValue(ResultField, mStringBuffer2)
        ' Loop
        ' If ParseFromDef_Powerset_Powers(CurrentReader, Result) = False Then
        '        MsgBox("BAD")
        ''Return Nothing
        ' End If
        ' If Map_LanguageFile_To_Powerset(Result) = False Then
        '
        'End I'f
        '    Re'turn Result
        'End Function
#End Region

#Region "Parse PowerSet - Powers"
        '  Private Function ParseFromDef_Powerset_Powers(ByRef CurrentReader As IO.StreamReader, ByRef Result As COH_PowerSet) As Boolean
        '        mLineBuffer = RetrieveLine_UntilNotEmpty(CurrentReader)
        '        SplitLine(mLineBuffer, mStringBuffer1, mStringBuffer2)
        '    Do
        '   If mStringBuffer1.Contains("Powers") Then
        '   If ParseFromDef_Powerset_Power(CurrentReader, Result) = False Then Return False
        ''   If RetrieveLineBuffers(CurrentReader) = False Then Exit Do
        '   Else
        '               MsgBox("ERRROR : NOT A POWER")
        '  Return False
        ''  End If
        '  Loop
        ' Return True
        ' End Function
        '' '    Private Function ParseFromDef_Powerset_Power(ByRef CurrentReader As IO.StreamReader, ByRef Result As COH_PowerSet) As Boolean
        ' Dim NewItem As New COH_PowerSet_Power
        '     NewItem.ClassName = mStringBuffer2
        ''Do
        ' If RetrieveLineBuffers(CurrentReader) = False Then Exit Do
        ' Dim ResultField = COH_PowerSet_Power.RetrieveProperties_Enum(mStringBuffer1)
        '        NewItem.UpdateValue(ResultField, mStringBuffer2)
        ''Loop
        '    Result.Powers.Add(NewItem)
        ' Return True
        ' End Function
#End Region

#Region "Map Language"
        '   Private Function Map_LanguageFile_To_Powerset(ByRef Result As COH_PowerSet) As Boolean
        '   Dim TheMap As COH_LanguageFileMap = Nothing
        '       COH_ContentController.Instance.Retrieve_LanguageMap_Client(TheMap)
        '
        '        If Map_LanguageFile_To_PowersetEntry(Result.DisplayHelp, Result.DisplayHelpKey, TheMap) Then
        '       'MsgBox("Not Found: " & Result.DisplayHelpKey)
        '       End If
        ''       If Map_LanguageFile_To_PowersetEntry(Result.DisplayName, Result.DisplayNameKey, TheMap) Then
        '       'MsgBox("Not Found: " & Result.DisplayNameKey)
        '       End If
        '       If Map_LanguageFile_To_PowersetEntry(Result.DisplayShortHelp, Result.DisplayShortHelpKey, TheMap) Then
        '       'MsgBox("Not Found: " & Result.DisplayShortHelpKey)
        '       End If
        ''      Return True
        '     End Function
        ' Private Function Map_LanguageFile_To_PowersetEntry(ByRef Value As String, Key As String, ByRef TheMap As COH_LanguageFileMap) As Boolean
        ' Dim Current As COH_LanguageFileMap_Entry = TheMap.RetrieveEntry(Key)
        ' If Current Is Nothing Then Return False
        ' Dim Temp = Current.Return_AsString()
        'If Not Value = "" Then
        'If Not Temp = Value Then
        ''If MsgBox("OLD: " & Value & Environment.NewLine & "NEW: " & Temp, MsgBoxStyle.YesNo, "Replace Entry?") = MsgBoxResult.Yes Then
        ' Value = Temp
        ''            End If
        '        End If
        '   Else
        '        Value = Temp
        '    End If
        '    Return True
        'End Function
#End Region

#Region "Shared Functions"
        '   Public Shared Function Import_FromDef_PowerSet(FileSource1 As String) As COH_PowerSet
        '   Dim CurrentReader As New COH_DefReader(FileSource1)
        '       CurrentReader.ProcessFiles()
        '   Return CurrentReader.Entries(0)
        '   End Function
        ''  Public Shared Function Import_FromDef_PowerSets(FileSource1 As String) As List(Of COH_PowerSet)
        '  Dim CurrentReader As New COH_DefReader(FileSource1)
        '      CurrentReader.ProcessFiles()
        '  Dim Result As New List(Of COH_PowerSet)
        '' For Each Item In CurrentReader.Entries
        '         Result.Add(Item)
        ' Next
        ' Return Result
        ' End Function
#End Region

    End Class
End Namespace