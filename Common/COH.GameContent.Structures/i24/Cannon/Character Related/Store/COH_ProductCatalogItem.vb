Namespace GameContent.Structures.Store
    Public Class COH_ProductCatalogItem
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("Display")> Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property SKU As String
            Get
                Return mSKU
            End Get
            Set(value As String)
                mSKU = value
            End Set
        End Property
        Property InventoryType As COH_Enum_InventoryType
            Get
                Return mInventoryType
            End Get
            Set(value As COH_Enum_InventoryType)
                mInventoryType = value
            End Set
        End Property
        Property ProductFlags As COH_Enum_AccountProductFlags
            Get
                Return mProductFlags
            End Get
            Set(value As COH_Enum_AccountProductFlags)
                mProductFlags = value
            End Set
        End Property
        Property InventoryCount As Int32
            Get
                Return mInventoryCount
            End Get
            Set(value As Int32)
                mInventoryCount = value
            End Set
        End Property
        Property GrantLimit As Int32
            Get
                Return mGrantLimit
            End Get
            Set(value As Int32)
                mGrantLimit = value
            End Set
        End Property
        Property ExpirationSecs As Int32
            Get
                Return mExpirationSecs
            End Get
            Set(value As Int32)
                mExpirationSecs = value
            End Set
        End Property
        Property [Global] As Boolean
            Get
                Return mGlobal
            End Get
            Set(value As Boolean)
                mGlobal = value
            End Set
        End Property
        Property AuthBit As COH_Enum_Product_AuthBit
            Get
                Return mAuthBit
            End Get
            Set(value As COH_Enum_Product_AuthBit)
                mAuthBit = value
            End Set
        End Property
        Property Recipe As String
            Get
                Return mRecipe
            End Get
            Set(value As String)
                mRecipe = value
            End Set
        End Property
        Property StartDate As Int32
            Get
                Return mStartDate
            End Get
            Set(value As Int32)
                mStartDate = value
            End Set
        End Property
        Property EndDate As Int32
            Get
                Return mEndDate
            End Get
            Set(value As Int32)
                mEndDate = value
            End Set
        End Property
        Property StartDate_ReferenceOnly As String
            Get
                If mStartDate = 0 Then Return "NONE"
                Return HelperFunctions.DateTimeFunctions.Convert_Uint32Value_To_DateTime_From2000(mStartDate)
            End Get
            Set(value As String)
            End Set
        End Property
        Property EndDate_ReferenceOnly As String
            Get
                If mEndDate = 0 Then Return "NONE"
                Return HelperFunctions.DateTimeFunctions.Convert_Uint32Value_To_DateTime_From2000(mEndDate)
            End Get
            Set(value As String)
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mSKU As String
       Private mInventoryType As COH_Enum_InventoryType
       Private mProductFlags As COH_Enum_AccountProductFlags
       Private mInventoryCount As Int32
       Private mGrantLimit As Int32
       Private mExpirationSecs As Int32
       Private mGlobal As Boolean
       Private mAuthBit As COH_Enum_Product_AuthBit
       Private mRecipe As String
       Private mStartDate As Int32
       Private mEndDate As Int32
#End Region

#Region "Create New Instances"
        Public Sub New()
            ResetDefaults()
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mName = String.Empty
            mInventoryType = COH_Enum_InventoryType.kAccountInventoryType_Count
            mInventoryCount = 0
            mGrantLimit = 0
            mExpirationSecs = 0
            mGlobal = 0
            mAuthBit = COH_Enum_Product_AuthBit.PRODUCT_AUTHBIT_INVALID
            mRecipe = String.Empty
            mStartDate = 0
            mEndDate = 0
            mProductFlags = COH_Enum_AccountProductFlags.NotDefined
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ProductCatalogItem
            Dim Result As COH_ProductCatalogItem = New COH_ProductCatalogItem
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mInventoryType = mInventoryType
                .mInventoryCount = mInventoryCount
                .mGrantLimit = mGrantLimit
                .mExpirationSecs = mExpirationSecs
                .mGlobal = mGlobal
                .mAuthBit = mAuthBit
                .mRecipe = String.Copy(mRecipe)
                .mStartDate = mStartDate
                .mEndDate = mEndDate
                .mProductFlags = mProductFlags
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export -CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String_FixedLength_UTF8(SKU)
            CurrentWriter.Write(CInt(InventoryType))
            CurrentWriter.Write_CrypticS_Flags(ProductFlags)
            CurrentWriter.Write(InventoryCount)
            CurrentWriter.Write(GrantLimit)
            '!!REDUNDENT!!CurrentWriter.Write(InventoryMax)
            CurrentWriter.Write(ExpirationSecs)
            CurrentWriter.Write_CrypticS_Boolean([Global])
            CurrentWriter.Write(CInt(AuthBit))
            CurrentWriter.Write_CrypticS_String(Recipe)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(ItemKey)
            CurrentWriter.Write(StartDate)
            CurrentWriter.Write(EndDate)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            SKU = CurrentReader.Read_CrypticS_String_FixedLength_UTF8(8)
            InventoryType = CurrentReader.ReadInt32
            ProductFlags = CurrentReader.Read_CrypticS_Flags
            InventoryCount = CurrentReader.ReadInt32
            GrantLimit = CurrentReader.ReadInt32
            '!!REDUNDENT!!Result.InventoryMax = CurrentReader.ReadInt32
            ExpirationSecs = CurrentReader.ReadInt32
            [Global] = CurrentReader.Read_CrypticS_Boolean
            AuthBit = CurrentReader.ReadInt32
            Recipe = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!Result.ItemKey = CurrentReader.Read_CrypticS_String
            StartDate = CurrentReader.ReadInt32
            EndDate = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace