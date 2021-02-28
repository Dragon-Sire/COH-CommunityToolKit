Imports COH.Servers.AccountServer.GameAccounts

Namespace GameServers.AccountServer.Transactions
    Public Class MicroTransaction
        Inherits Transaction

#Region "Properties"
        Public Property mtx As New asql_micro_transaction()
        Public Property inv As New asql_inventory()
        Public Property ReadOnly product As AccountProduct
        Public Property message As PostbackMessage
#End Region

#Region "Initialize"
        Public Sub New(ByRef SelectedAccount As GameAccount)
            MyBase.New(SelectedAccount)
        End Sub
        Public Sub New(ByRef SelectedAccount As GameAccount, ByVal order_id As OrderId, ByVal sku_id As SkuId, ByVal transaction_date As String, ByVal quantity As Integer, ByVal points As Integer, ByVal message As PostbackMessage)
            MyBase.New(SelectedAccount)
            ConfigureTransaction(order_id, sku_id, transaction_date, quantity, points, message)
        End Sub
        Private Sub ConfigureTransaction(ByVal order_id As OrderId, ByVal sku_id As SkuId, ByVal transaction_date As String, ByVal quantity As Integer, ByVal points As Integer, ByVal message As PostbackMessage)
            Debug.Assert(account)
            Dim Result As AccountProduct = Nothing
            If accountCatalogGetProduct(sku_id, Result) = False Then
                UpdateValid(False, Nothing)
                '//LOG(LOG_TRANSACTION, LOG_LEVEL_ALERT, LOG_CONSOLE_ALWAYS, "{""reason"":""mtx has invalid product"", ""order_id"":""%.16s"", ""auth_id"":%d, ""sku_id"":""%.8s"", ""quantity"":%d, ""points"":%d}", orderIdAsString(order_id), account.auth_id, sku_id.c, quantity, points)
            Else
                Result = Result
                message = message
                mtx.order_id = order_id
                mtx.auth_id = account.auth_id
                mtx.sku_id = Result.sku_id
                mtx.quantity = quantity
                mtx.points = points
                Transaction_SetTransactionDate_FromUnixTimeString(NewTransaction.mtx.transaction_date, transaction_date)
            End If

        End Sub
#End Region

#Region "Shared Functions"
        Public Shared Sub Transaction_MicroStartTransaction(ByRef PlayerAccount As Account, ByVal order_id As OrderId, ByVal sku_id As SkuId, ByVal transaction_date As String, ByVal quantity As Integer, ByVal points As Integer, ByVal message As PostbackMessage)
            Dim NewTransaction As New MicroTransaction(PlayerAccount)
            If NewTransaction.Valid = False Then Exit Sub
            asql_add_micro_transaction_async(NewTransaction)
        End Sub
        Private Sub Transaction_MicroFinished(ByVal success As Boolean, ByVal transaction As MicroTransaction)
            If success Then
                accountInventory_UpdateInventoryFromSQL(transaction.account, transaction.inv)
            Else
                ' This line needs to log enough data for CSR to recover with
                LOG(LOG_TRANSACTION, LOG_LEVEL_ALERT, LOG_CONSOLE_ALWAYS, "{""reason"":""mtx failed"", ""order_id"":""%s"", ""auth_id"":%d, ""sku_id"":""%.8s"", ""quantity"":%d, ""points"":%d}", orderIdAsString(transaction.mtx.order_id), transaction.mtx.auth_id, transaction.mtx.sku_id.c, transaction.mtx.quantity, transaction.mtx.points)
            End If

            ' ack on failure so we do not log too many failures in the transaction log for customer service
            MP_FREE(MicroTransaction, transaction)
        End Sub

#End Region

    End Class
End Namespace
