Imports COH.CodeManagement.Interfaces.Databases
Imports COH.CodeManagement.Constants.Databases.SQL

Namespace Storage.Databases.SQL
    Public Class AccountDatabase_SQL
        Implements I_SupportDatabase_Accounts

#Region "Properties"
		''' auth_id index into a @ref asql_account
		Public Property Accounts As New StashTable()
		'''
		Public Property ASQL_WORKERS()
		''' SQL connection state
		Public Property Connections As SQL_Connection()
		''' Asynchronous queries in flight
		Public Property In_Flight As Integer
#End Region

#Region "Create New Instances"
		Public Sub New()
			Connections = HelperFunctions.Arrays.InitializeArray(Of SQL_Connection)(SQLCONN_MAX)
			ASQL_WORKERS = HelperFunctions.Arrays.InitializeArray(Of Object)(SQLCONN_MAX - 1)
		End Sub
#End Region


#Region "Open/Close Connections"
		Public Function OpenConnection() As Boolean Implements I_SupportDatabase_Accounts.OpenConnection
			Dim i As Integer

			MP_CREATE(asql_account, ACCOUNT_INITIAL_CONTAINER_SIZE)
			MP_CREATE(asql_task, ACCOUNT_INITIAL_CONTAINER_SIZE)

			Accounts = stashTableCreateInt(stashOptimalSize(ACCOUNT_INITIAL_CONTAINER_SIZE))
			In_Flight = 0

			sql_task_init(ASQL_WORKERS, 2048)
			For i = 0 To ASQL_WORKERS - 1
				sql_task_set_callback(i, asql_run_entry, DirectCast(CType(i + 1, IntPtr), Object))
			Next i
			sql_task_freeze()

			Debug.Assert(sqlConnInit(SQLCONN_MAX))
			sqlConnSetLogin(g_accountServerState.cfg.sqlLogin)

			If Not sqlConnDatabaseConnect(g_accountServerState.cfg.sqlDbName, "ACCOUNTSERVER") Then
				FatalErrorf("AccountServer could not connect to SQL database.")
			End If

			For i = 0 To SQLCONN_MAX - 1
				'C++ TO VB CONVERTER TODO TASK: The memory management function 'memset' has no equivalent in VB:
				'C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
				memset(Connections(i).Procedures, 0, sizeof(Connections(i).proc))
			Next i
		End Function
#End Region




    End Class
End Namespace