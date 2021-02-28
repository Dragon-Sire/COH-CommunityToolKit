Imports COH.Storage.Controllers
Imports COH.Toolkit.CodeManagement.Interfaces

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Properties"
        Public ReadOnly Property Structures_Controller As COH_FileStructureIndex_Controller Implements ISupport_MasterController.TheController_SupportedStructures
            Get
                Return mStruct_Controller
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private mStruct_Controller As COH_FileStructureIndex_Controller
#End Region

#Region "MessageStores"
        Private Function Prepare_StructuresController() As Boolean
            mStruct_Controller = New COH_FileStructureIndex_Controller
            mStruct_Controller.Add_ListSupportedFiles(COH_LibraryRegister_CrypticS.CreateList_BinMapping_ToTypes)
            mStruct_Controller.Add_ListSupportedFiles(COH_LibraryRegister_MessageStore.CreateList_BinMapping_ToTypes)
            mStruct_Controller.Add_ListSupportedFiles(COH_LibraryRegister_Resources.CreateList_BinMapping_ToTypes)
            Return True
        End Function
#End Region

    End Class
End Namespace