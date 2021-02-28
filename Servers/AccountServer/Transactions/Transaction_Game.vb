Namespace GameServers.AccountServer.Transactions
	Public Class GameTransaction
		Public gtx As New asql_game_transaction()
		Public inv As New asql_inventory()
		Public account As Account
		Public ReadOnly product As AccountProduct
	End Class
End Namespace
