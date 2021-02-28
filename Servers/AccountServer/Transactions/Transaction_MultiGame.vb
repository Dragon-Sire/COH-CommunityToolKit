Namespace GameServers.AccountServer.Transactions
	Public Class MultiGameTransaction
		Public order_id As New OrderId()
		Public count As UInteger
		Public transactions() As asql_game_transaction = Arrays.InitializeWithDefaultInstances(Of asql_game_transaction)(MAX_MULTI_GAME_TRANSACTIONS)
		Public flex_inv As New asql_flexible_inventory()
		Public account As Account
		Public ReadOnly products() As AccountProduct = Arrays.InitializeWithDefaultInstances(Of AccountProduct)(MAX_MULTI_GAME_TRANSACTIONS)
	End Class
End Namespace

Friend Module Arrays
	Public Function InitializeWithDefaultInstances(Of T As New)(ByVal length As Integer) As T()
		Dim array(length - 1) As T
		For i As Integer = 0 To length - 1
			array(i) = New T()
		Next i
		Return array
	End Function
	Public Sub DeleteArray(Of T As IDisposable)(ByVal array() As T)
		For Each element As T In array
			If element IsNot Nothing Then
				element.Dispose()
			End If
		Next element
	End Sub
End Module