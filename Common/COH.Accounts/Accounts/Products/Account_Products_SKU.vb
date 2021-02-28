Namespace Accounts.Products
    ''' <summary>
    ''' The SKU for this Inventory Record, @note Matches [sku_id] in the SQL database
    ''' </summary>
    ''' <returns></returns>
    Public MustInherit Class SkuId
    End Class
    Public MustInherit Class SkuId_64
        Inherits SkuId
        Public Property Value As UInt64
    End Class
    Public MustInherit Class SkuId_32
        Inherits SkuId
        Public Property Value1 As UInt32
        Public Property Value2 As UInt32
    End Class
    Public MustInherit Class SkuId_String
        Inherits SkuId
        Public Property Value As String
    End Class
End Namespace

