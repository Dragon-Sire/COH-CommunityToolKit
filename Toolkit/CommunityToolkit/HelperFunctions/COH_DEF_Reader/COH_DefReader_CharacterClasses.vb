Imports COH.GameContent.Structures.Characters
Imports COH.Toolkit.Modding.Enums

Namespace HelperFunctions.Defs
    Partial Public Class COH_DefReader

#Region "Parse CharacterClass"
        Private Function ParseFromDef_CharacterClass(ByRef CurrentReader As IO.StreamReader) As COH_CharacterClass
            Dim Result As COH_CharacterClass = Nothing
            Dim IsLocalized As Boolean = True '//Add Test For
            If ParseFromDef_CharacterClass_Properties(CurrentReader, Result, IsLocalized) = False Then
                Return Nothing
            End If
            If ParseFromDef_CharacterClass_AttributesTables(CurrentReader, Result) = False Then
                Return Nothing
            End If
            If ParseFromDef_CharacterClass_ModTables(CurrentReader, Result) = False Then
                Return Nothing
            End If
            Return Result
        End Function
        Private Function ParseFromDef_CharacterClass_Properties(ByRef CurrentReader As IO.StreamReader, ByRef Result As COH_CharacterClass, Optional IsLocalized As Boolean = True) As Boolean
            mLineBuffer = CurrentReader.ReadLine() '//Should be {
            Result = New COH_CharacterClass
            With Result
                Do
                    If RetrieveLineBuffers(CurrentReader) = False Then Exit Do
                    Dim Value As COH_CC_Fields ' = COH_CharacterClass.RetrieveProperties_Enum(mStringBuffer1)
                    If IsLocalized = True Then
                        Select Case Value
                            Case COH_CC_Fields.DisplayHelp
                                Value = COH_CC_Fields.DisplayHelpKey
                            Case COH_CC_Fields.DisplayName
                                Value = COH_CC_Fields.DisplayNameKey
                            Case COH_CC_Fields.DisplayShortHelp
                                Value = COH_CC_Fields.DisplayShortHelpKey
                            Case COH_CC_Fields.LockedTooltip
                                Value = COH_CC_Fields.LockedTooltipKey
                        End Select
                    End If
                    ' Result.UpdateValue(Value, mStringBuffer2)
                Loop
            End With
            Return True
        End Function
        Private Function ParseFromDef_CharacterClass_AttributesTables(ByRef CurrentReader As IO.StreamReader, ByRef Result As COH_CharacterClass) As Boolean
            Dim Line As String = RetrieveLine_UntilNotEmpty(CurrentReader)
            Dim AttributeName As String = Line
            Do
                If AttributeName = "AttribBase" Then
                    If ParseFromDef_CharacterClass_AttributesTable_Base(CurrentReader, Result) = False Then Return False
                ElseIf AttributeName = "ModTable" Then
                    Exit Do
                Else
                    ' Dim Attrib = Result.RetrieveTable_Enum(AttributeName)
                    '' Select Case Attrib
                    'Case COH_CC_AttributeTables.AttribMaxTable, COH_CC_AttributeTables.AttribMaxMaxTable, COH_CC_AttributeTables.ResistanceMaxTable, COH_CC_AttributeTables.StrengthMaxTable
                    'If ParseFromDef_CharacterClass_AttributesTable_Items(AttributeName, Result, CurrentReader) = False Then Return False
                    ''Case COH_CC_AttributeTables.AttribMin, COH_CC_AttributeTables.ResistanceMin, COH_CC_AttributeTables.StrengthMin
                    ' If ParseFromDef_CharacterClass_AttributesTable_Items(AttributeName, Result, CurrentReader) = False Then Return False
                    'Case COH_CC_AttributeTables.AtrribDiminCurIn, COH_CC_AttributeTables.AtrribDiminCurOut, COH_CC_AttributeTables.AtrribDiminResIn, COH_CC_AttributeTables.AtrribDiminResOut, COH_CC_AttributeTables.AtrribDiminStrIn, COH_CC_AttributeTables.AtrribDiminStrOut
                    'If ParseFromDef_CharacterClass_AttributesTable_Items(AttributeName, Result, CurrentReader) = False Then Return False
                    'End Select
                End If
                AttributeName = RetrieveLine_UntilNotEmpty(CurrentReader)
            Loop
            Return True
        End Function
#End Region

#Region "Parse CharacterClass - AttributesTables"
        Private Function ParseFromDef_CharacterClass_AttributesTable_Base(ByRef CurrentReader As IO.StreamReader, ByRef Result As COH_CharacterClass) As Boolean
            mLineBuffer = CurrentReader.ReadLine() '//Should be {
            Do
                If RetrieveLineBuffers(CurrentReader) = False Then Exit Do
                'Dim NewItem As New COH_CharacterClass_Base3
                'NewItem.Name = mStringBuffer1
                'NewItem.Level = mStringBuffer2
                'Result.BaseAttributes.Add(NewItem)
            Loop
            Return True
        End Function
        Private Function ParseFromDef_CharacterClass_AttributesTable_Items(ByRef AttributeName As String, ByRef Result As COH_CharacterClass, ByRef CurrentReader As IO.StreamReader) As Boolean
            '    mLineBuffer = CurrentReader.ReadLine() '//Should be {
            '    Dim Attrib = Result.RetrieveTable_Attributes(AttributeName)
            '    Dim NewItem As COH_CharacterClass_Attributes2 = Nothing
            '   Do
            ''   If RetrieveLineBuffers(CurrentReader) = False Then Exit Do
            '   If mStringBuffer2.Contains(",") = True Then
            '   Dim Values As String() = Split(mStringBuffer2, ",")
            '   NewItem = New COH_CharacterClass_Attributes2(mStringBuffer1, Values.Length)
            '  For x = 0 To Values.Length - 1
            ''  NewItem.Levels(x) = Values(x)
            '  Next
            '  Else
            ' NewItem = New COH_CharacterClass_Attributes2(mStringBuffer1, 1)
            '' NewItem.Levels(0) = mStringBuffer2
            ' End If
            ' Attrib.AttributesAdjusments.Add(NewItem)
            ' Loop
            Return True
        End Function
        Private Function ParseFromDef_CharacterClass_ModTables(ByRef CurrentReader As IO.StreamReader, ByRef Result As COH_CharacterClass) As Boolean
            ' Dim NewResult As COH_CharacterClass_EffectMod3 = Nothing
            Do
                ' NewResult = New COH_CharacterClass_EffectMod3
                '   If RetrieveLineBuffers(CurrentReader) = False Then Exit Do
                '   NewResult.Name = mStringBuffer2
                '   If RetrieveLineBuffers(CurrentReader) = False Then Exit Do
                '   Dim Values = Split(mStringBuffer2, ",")
                ''  For x = 0 To Values.Length - 1
                '  NewResult.Levels(x) = Values(x)
                '  Next
                '' ' Result.EffectMods.Add(NewResult)
                ' mLineBuffer = CurrentReader.ReadLine
                ' mLineBuffer = CurrentReader.ReadLine
                ' If Not mLineBuffer.Contains("ModTable") = True Then Exit Do
                ' If IsNothing(mLineBuffer) = True Then Exit Do
            Loop
            Return True
        End Function
#End Region

#Region "Shared Functions"
        Public Shared Function Import_FromDef_CharacterClass(FileSource1 As String) As COH_CharacterClass
            Dim CurrentReader As New COH_DefReader(FileSource1)
            CurrentReader.ProcessFiles()
            Return CurrentReader.Entries(0)
        End Function
#End Region

    End Class
End Namespace
