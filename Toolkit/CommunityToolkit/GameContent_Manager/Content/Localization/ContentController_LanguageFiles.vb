Imports COH.GameContent.MessageStores.Structures.LanguageFiles
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Properties"
        Public ReadOnly Property MessageStore_Controller As COH_LocalizeContent_Controller
            Get
                If mMessageStore_Controller Is Nothing Then Return Nothing
                Return mMessageStore_Controller
            End Get
        End Property
        Public ReadOnly Property TheController_Localize As ISupport_COH_LocalizeContent Implements ISupport_MasterController.TheController_Localize
            Get
                Return MessageStore_Controller
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private mMessageStore_Controller As COH_LocalizeContent_Controller
#End Region

#Region "MessageStores"
        Private Function Prepare_MessageStoreController() As Boolean
            mMessageStore_Controller = New COH_LocalizeContent_Controller
            mMessageStore_Controller.AddNew_MessageStore("Client (clientmessages-en.bin)", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.LanguageFiles) & "clientmessages-en.bin.xml")
            mMessageStore_Controller.AddNew_MessageStore("Server (messages-en.bin)", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.LanguageFiles) & "messages-en.bin.xml")
            mMessageStore_Controller.AddNew_MessageStore("Server (storyarcmsg-en.bin)", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.LanguageFiles) & "storyarcmsg-en.bin.xml")
            Return True
        End Function
#End Region
    End Class
End Namespace