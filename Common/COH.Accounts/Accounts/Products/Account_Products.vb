Imports COH.CodeManagement.Enums.Accounts

Namespace Accounts.Products
    Public NotInheritable Class AccountProduct

#Region "Properties"
        Public Property SKU_ID As SkuId
        Public Property AuthBit As UInt32
        Public Property IsGlobal As Boolean
        Public Property GrantLimit As Integer
        Public Property InventoryCount As Integer
        ''' <summary>
        ''' Seconds since 2000
        ''' </summary>
        ''' <returns></returns>
        Public Property ProductStartDate As UInt32
        ''' <summary>
        ''' Seconds since 2000
        ''' </summary>
        ''' <returns></returns>
        Public Property ProductEndDate As UInt32
        Public Property ExpirationSeconds As UInt32
        Public Property InventoryType As AccountInventoryType
        ''' <summary>
        ''' AccountProductDefFlag flags; static product definiton from local data file, sometimes updated on the fly
        ''' </summary>
        ''' <returns></returns>
        Public Property ProductFlags As UInt32
        ''' <summary>
        ''' type-specific unique string. e.g., for certifications, the recipe name.
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Recipe As String
            Get
                Return pRecipe
            End Get
        End Property
        Public ReadOnly Property Title As String
            Get
                Return pTitle
            End Get
        End Property
#End Region

#Region "Private"
        Private pRecipe As String
        Private pTitle As String
#End Region
    End Class
End Namespace