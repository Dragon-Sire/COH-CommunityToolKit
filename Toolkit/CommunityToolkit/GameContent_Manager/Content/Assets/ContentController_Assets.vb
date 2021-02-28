Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Tools.Internal.Enums

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Properties"
        Public ReadOnly Property Assets_Controller As COH_ResourceAssets_Controller
            Get
                If mAssets_Controller Is Nothing Then Return Nothing
                Return mAssets_Controller
            End Get
        End Property
        Public ReadOnly Property TheController_Assets As ISupport_COH_AssetRetrieval Implements ISupport_MasterController.TheController_Assets
            Get
                Return Assets_Controller
            End Get
        End Property

#End Region

#Region "Private Properties"
        Private mAssets_Controller As COH_ResourceAssets_Controller
#End Region

#Region "Assets"
        Private Function Prepare_AssetsController() As Boolean
            mAssets_Controller = New COH_ResourceAssets_Controller(ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Assets), ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Bones))
            Return True
        End Function
#End Region

#Region "Extract Assets"
        Public Function Extract_Skeletons(Optional SHowProgress As Boolean = False, Optional ShowMessage As Boolean = False) As Boolean
            mAssets_Controller.Extract_ALL_BaseSkeletons(SHowProgress)
            If ShowMessage = True Then ShowMessage_Simple("Extraction Finished")
            Return True
        End Function
#End Region

    End Class
End Namespace