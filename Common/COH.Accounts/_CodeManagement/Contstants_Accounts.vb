Namespace CodeManagement.Constants.Accounts
    <HideModuleName> Public Module DefinedConstants_Accounts
        'Public Const ACCOUNTDB_UPDATE_SQL_ACCOUNT As Integer = 1 ' /// Object needs the [account] table updated in SQL
        'Public Const ACCOUNTDB_UPDATE_NETWORK As Integer = 2 '/// /// Object needs to be transmitted to the active shard
        Public Const MAX_SLOTS_PER_SHARD As Integer = 36
        Public Const MAX_SLOTS_TOTAL As Integer = MAX_SLOTS_PER_SHARD * 15
        Public Const REFUND_TIME_OUT As Integer = 2592000 '3600 * 24 * 30 ' 30 days

        '/// Default size for account related containers
        Public Const ACCOUNT_INITIAL_CONTAINER_SIZE = 65536

        '/// Number of serialized loyalty bits
        Public Const LOYALTY_BITS = 128

        '/// Number of serialized @ref OrderId bits
        Public Const ORDER_ID_BITS = 128

        '/// Number of characters to store an @ref OrderId string
        Public Const ORDER_ID_STRING_LENGTH = 37

        '/// Maximum number of subtransactions allowed in a multi-game transaction
        Public Const MAX_MULTI_GAME_TRANSACTIONS = 8
    End Module
End Namespace
