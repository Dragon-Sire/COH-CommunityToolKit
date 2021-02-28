Imports COH.Accounts
Imports COH.CodeManagement.Constants.Accounts_Server

Namespace GameServers.AccountServer
    Public NotInheritable Class Accounts_Controller

#Region "Properties"
        Public Shared ReadOnly Property Instance As Accounts_Controller
            Get
                Return sInstance
            End Get
        End Property
        Public ReadOnly Property OnlineAccounts As Dictionary(Of UInt32, PlayerAccount)
            Get
                Return pOnlineAccounts
            End Get
        End Property
        Public Property NextAccount As PlayerAccount
        Private Shared sInstance As Accounts_Controller
        Private pOnlineAccounts As Dictionary(Of UInt32, PlayerAccount)
#End Region

#Region "Create New Instance"
        Shared Sub New()
            If sInstance Is Nothing Then sInstance = New Accounts_Controller
        End Sub
        Public Sub New()
            pOnlineAccounts = New Dictionary(Of UInteger, PlayerAccount)(ACCOUNTS_INITIAL_CAPACITY)
        End Sub
#End Region

#Region "ShutDown Server"
        Public Sub Shutdown()
            '//Close Connections, Release Data etc Here
            NextAccount = Nothing
        End Sub
#End Region

    End Class
End Namespace