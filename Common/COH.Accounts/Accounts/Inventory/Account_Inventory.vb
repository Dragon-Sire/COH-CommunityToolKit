Imports COH.Accounts.Products

Namespace Accounts.Inventories
    Public NotInheritable Class AccountInventory

#Region "Properties"
        ''' <summary>
        ''' The SKU for this Inventory Record, @note Matches [sku_id] in the SQL database
        ''' </summary>
        ''' <returns></returns>
        Public Property SKU_ID As SkuId
        ''' <summary>
        ''' The total number of times this inventory type was purchased
        ''' </summary>
        ''' <returns></returns>
        Public Property Total_Granted As Integer
        ''' <summary>
        ''' The total number of times this this inventory type was claimed
        ''' </summary>
        ''' <returns></returns>
        Public Property Total_Claimed As Integer
        ''' <summary>
        ''' Expiration date for this inventory type
        ''' </summary>
        ''' <returns></returns>
        Public Property Expires As UInteger
#End Region

#Region "Properties - Account Server Only"
#If ACCOUNTSERVER Then
		''' <summary>
		''' The total number of times this this inventory type was correctly saved on the dbserver
		''' </summary>
		''' <returns></returns>
		Public Property Total_Saved As Integer
#End If
#End Region

#Region "Properties - CLIENT or SERVER Only"
#If CLIENT OrElse SERVER Then
		''' <summary>
		''' Recipe for this object
		''' </summary>
		''' <returns></returns>
		Public ReadOnly Property Recipe As String
			Get
				Return pRecipe
			End Get
		End Property
		''' <summary>
		''' Copy of the @ref AccountInventoryType from the @ref AccountProduct
		''' </summary>
		''' <returns></returns>
		Public Property InventoryType As AccountInventoryType
		Private pRecipe As String
#End If
#End Region
    End Class
End Namespace
