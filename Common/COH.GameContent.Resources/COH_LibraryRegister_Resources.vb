Imports COH.GameContent.Structures
Imports COH.Storage.Controllers

Public NotInheritable Class COH_LibraryRegister_Resources

#Region "Supported Bins"
    Public Shared Function CreateList_BinMapping_ToTypes() As List(Of COH_FSI_Entry)
        Dim Result As New List(Of COH_FSI_Entry)
        With Result
            .Add(New COH_FSI_Entry(".GEO", COH_Supported_ContentType.Resource_GEO, (New UInt32(0) {1048517264}).ToList, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(MeshRelated.COH_Mesh_GroupList))}).ToList, True))
        End With
        Return Result
    End Function
#End Region

End Class
