Imports COH.Accounts.Inventories
Imports COH.CodeManagement.Enums.Accounts
Imports COH.CodeManagement.Interfaces.Accounts

Namespace Accounts
    Public NotInheritable Class PlayerAccount

#Region "Properties - Account Details"
        ''' <summary>
        ''' The AuthServer ID for Account
        ''' </summary>
        ''' <returns></returns>
        Public Property Auth_ID As UInt32
        ''' <summary>
        ''' Account Name, Max 32 Characters
        ''' </summary>
        ''' <returns></returns>		
        Public Property Auth_Name As String
#End Region
#Region "Properties - Inventory"
        ''' <summary>
        ''' Inventory item records for this account
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property InventorySet As AccountInventorySet()
            Get

            End Get
        End Property
#End Region
#Region "Properties - Loyalty"
        ''' <summary>
        ''' Number of Loyalty points earned for this account (Not Stored in SQL)
        ''' </summary>
        ''' <returns></returns>
        Public Property LoyaltyPoints_Earned As Integer
        ''' <summary>
        ''' Number of unspent Loyalty points for this account (Not Stored in SQL)
        ''' </summary>
        ''' <returns></returns>
        Public Property LoyaltyPoints_Unspent As Integer
        ''' <summary>
        ''' Last seen Amount of Virtual Currency
        ''' </summary>
        ''' <returns></returns>
        Public Property VirtualCurrencyBalance As Integer
#End Region
#Region "Properties - Email"
        ''' <summary>
        ''' Last time the player sent an email
        ''' </summary>
        ''' <returns></returns>
        Public Property Email_Lastsent As Date
        ''' <summary>
        ''' Something to do with @ref lastEmailTime
        ''' </summary>
        ''' <returns></returns>
        Public Property Email_LastsentNumber As UInt32
#End Region
#Region "Properties - Other"
        ''' <summary>
        ''' Last time a player received a free shard transfer
        ''' </summary>
        ''' <returns></returns>
        Public Property AccountShard_FreeTransferRecieved As Date
#End Region


#Region "Properties - Storage"
        ''' <summary>
        ''' Account SQL Data
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property StorageAccount As IStorage_PlayerAccount
            Get
                Return pStorageAccount
            End Get
        End Property
        ''' <summary>
        ''' Shard that the Account is Connected Too
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property AccountShard As IStorage_Shard
            Get
                Return pAccountShard
            End Get
        End Property
        ''' <summary>
        ''' Set when a character is undergoing a shard transfer
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property AccountShard_TransferInProgress As Boolean
            Get
                Return pAccountShard_TransferInProgress
            End Get
        End Property
        ''' <summary>
        ''' LEGACY --- int * shardXferTokens???
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property AccountShard_TransferTokens As UInt32
            Get
                Return pAccountShard_TransferTokens
            End Get
        End Property
        ''' <summary>
        ''' Linked for Objects that need to be Processed on the next @ref AccountDb_Tick
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property NextUpdate As PlayerAccount
            Get
                Return pNextUpdate
            End Get
        End Property
        ''' <summary>
        ''' List of Operations to perform on the next @ref AccountDB_Tick
        ''' </summary>
        ''' <returns></returns>
        Public Property NextUpdate_Flags As AccountUpdateFlags
            Get
                Return pNextUpdate_Flags
            End Get
            Set(value As AccountUpdateFlags)
                pNextUpdate_Flags = value
            End Set
        End Property
        ''' <summary>
        ''' Last Time the Client Auth Digest was sent 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property AuthDigest_Sent As UInt32
            Get
                Return pAuthDigeest_Sent
            End Get
        End Property
        ''' <summary>
        ''' Value when to resend authentication data
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property AuthResend As UInt32
            Get
                Return pAuthResend
            End Get
        End Property
#End Region
#Region "Private"
        '//RUNNING INFO
        Private pStorageAccount As IStorage_PlayerAccount
        Private pAccountShard As IStorage_Shard
        Private pAccountShard_TransferInProgress As Boolean
        Private pAccountShard_TransferTokens As UInt32
        Private pNextUpdate As PlayerAccount
        Private pNextUpdate_Flags As AccountUpdateFlags
        Private pAuthDigeest_Sent As UInt32
        Private pAuthResend As UInt32
#End Region

#Region "Create New Instance"
        Public Sub New(AuthID As Integer, AuthName As String)

        End Sub
#End Region


#Region "Functions"
        Public Sub PrepareNextUpdate(ByRef Account As PlayerAccount)
            pNextUpdate = Account
        End Sub
#End Region


        Public Sub LINK(Account, reauthLink)
            ''' Next pointer for the re-auth link
        End Sub
    End Class
End Namespace