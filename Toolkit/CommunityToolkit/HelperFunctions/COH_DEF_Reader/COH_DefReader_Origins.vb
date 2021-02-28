Imports COH.GameContent.Structures.Characters

Namespace HelperFunctions.Defs
    Partial Public Class COH_DefReader

#Region "Parse CharacterClass"
        Private Function ParseFromDef_Origins(ByRef CurrentReader As IO.StreamReader) As COH_Origin
            Dim Result As New COH_Origin
            mLineBuffer = RetrieveLine_UntilNotEmpty(CurrentReader)
            Do
                '  If RetrieveLineBuffers(CurrentReader) = False Then Exit Do
                '  Dim ResultField = COH_Origin.RetrieveProperties_Enum(mStringBuffer1)
                '  Dim IsLocalized As Boolean = True
                '  If IsLocalized = True Then
                ' Select Case ResultField
                '' Case COH_OriginFields.DisplayHelp
                ' ResultField = COH_OriginFields.DisplayHelpKey
                ' Case COH_OriginFields.DisplayName
                ' ResultField = COH_OriginFields.DisplayNameKey
                ' Case COH_OriginFields.DisplayShortHelp
                'ResultField = COH_OriginFields.DisplayShortHelpKey
                'End Select
                'End If
                'Result.UpdateValue(ResultField, mStringBuffer2)
            Loop
            'Map_LanguageFile_To_Origins(Result)
            Return Result
        End Function
#End Region

#Region "Shared Functions"
        Public Shared Function Import_FromDef_Origin(FileSource1 As String) As COH_Origin
            Dim CurrentReader As New COH_DefReader(FileSource1)
            CurrentReader.ProcessFiles()
            Return CurrentReader.Entries(0)
        End Function
        Public Shared Function Import_FromDef_Origins(FileSource1 As String) As List(Of COH_Origin)
            Dim CurrentReader As New COH_DefReader(FileSource1)
            CurrentReader.ProcessFiles()
            Dim Result As New List(Of COH_Origin)
            For Each Item In CurrentReader.Entries
                Result.Add(Item)
            Next
            Return Result
        End Function
#End Region

    End Class
End Namespace
