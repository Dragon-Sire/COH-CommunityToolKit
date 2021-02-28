Imports COH.CodeManagement.Enums.Structures
Imports COH.GameContent.MessageStores.Structures.LanguageFiles
Imports COH.Storage.Controllers

Public NotInheritable Class COH_LibraryRegister_MessageStore

#Region "Supported Bins"
    Public Shared Function CreateList_BinMapping_ToTypes() As List(Of COH_FSI_Entry)
        Dim Result As New List(Of COH_FSI_Entry)
        With Result
            .Add(New COH_FSI_Entry("authmsg-en.bin", COH_Supported_ContentType.Resource_BIN_MessageStore, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_MessageStore))}).ToList))
            .Add(New COH_FSI_Entry("clientmessages-en.bin", COH_Supported_ContentType.Resource_BIN_MessageStore, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_MessageStore))}).ToList))
            .Add(New COH_FSI_Entry("loadingtipmessages-en.bin", COH_Supported_ContentType.Resource_BIN_MessageStore, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_MessageStore))}).ToList))
        End With
        Return Result
    End Function
#End Region

End Class
