Namespace GameContent.MessageStores.Structures.LanguageFiles
    Partial Public NotInheritable Class COH_MessageStore

#Region "CreateMap"
        Public Sub Update_ReferenceMap(ByRef NewItem As COH_MessageStore_Entry)
            NewItem.Message = mMessages.Item(NewItem.MessageIndex)
            NewItem.HelpMessage = mMessages.Item(NewItem.HelpIndex)
            For Each Item In NewItem.VariableDefNameIndices
                Item.Variable = mVariables.Item(Item.Index)
                Item.Format = mVariables.Item(Item.Index + 1)
            Next
        End Sub
#End Region
    End Class
End Namespace