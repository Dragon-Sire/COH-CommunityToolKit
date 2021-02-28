Imports COH.GameContent.Structures.Characters.Powers
Imports COH.Toolkit.Modding.Enums

Namespace HelperFunctions.Defs
    Partial Public Class COH_DefReader

#Region "Parse CharacterClass"
        Private Function ParseFromDef_PowerCategory(ByRef CurrentReader As IO.StreamReader) As COH_PowerCategory
            Dim Result As New COH_PowerCategory
            ' Result.ClassName = mStringBuffer2
            mLineBuffer = RetrieveLine_UntilNotEmpty(CurrentReader)
            Do
                If RetrieveLineBuffers(CurrentReader) = False Then Exit Do
                If mStringBuffer1 = "PowerSets" = True Then
                    ' Result.PowerSets.Add(mStringBuffer2)
                Else
                    Dim ResultField '= COH_PowerCategory.RetrieveProperties_Enum(mStringBuffer1)
                    Dim IsLocalized As Boolean = True
                    If IsLocalized = True Then
                        Select Case ResultField
                            Case COH_Enum_PowerCategory.DisplayName
                                ResultField = COH_OriginFields.DisplayNameKey
                        End Select
                    End If
                    ' Result.UpdateValue(ResultField, mStringBuffer2)
                End If
            Loop
            Return Result
        End Function
#End Region

#Region "Shared Functions"
        Public Shared Function Import_FromDef_PowerCategory(FileSource1 As String) As COH_PowerCategory
            Dim CurrentReader As New COH_DefReader(FileSource1)
            CurrentReader.ProcessFiles()
            Return CurrentReader.Entries(0)
        End Function
        Public Shared Function Import_FromDef_PowerCategories(FileSource1 As String) As List(Of COH_PowerCategory)
            Dim CurrentReader As New COH_DefReader(FileSource1)
            CurrentReader.ProcessFiles()
            Dim Result As New List(Of COH_PowerCategory)
            For Each Item In CurrentReader.Entries
                Result.Add(Item)
            Next
            Return Result
        End Function
#End Region

    End Class
End Namespace
