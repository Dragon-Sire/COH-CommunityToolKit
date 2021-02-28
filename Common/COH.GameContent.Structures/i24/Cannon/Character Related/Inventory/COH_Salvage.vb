Namespace GameContent.Structures.Inventory
    Public NotInheritable Class COH_Salvage
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property UI_Details As UI.COH_UI_Widget
            Get
                Return mUI_Details
            End Get
            Set(value As UI.COH_UI_Widget)
                mUI_Details = value
            End Set
        End Property
        Property DisplayTabName As String
            Get
                Return mDisplayTabName
            End Get
            Set(value As String)
                mDisplayTabName = value
            End Set
        End Property
        Property DisplayDropMessage As String
            Get
                Return mDisplayDropMessage
            End Get
            Set(value As String)
                mDisplayDropMessage = value
            End Set
        End Property
        Property Rarity As COH_Enum_SalvageRarity
            Get
                Return mRarity
            End Get
            Set(value As COH_Enum_SalvageRarity)
                mRarity = value
            End Set
        End Property
        Property Type As COH_Enum_SalvageType
            Get
                Return mType
            End Get
            Set(value As COH_Enum_SalvageType)
                mType = value
            End Set
        End Property
        Property ChallengePoints As Int32
            Get
                Return mChallengePoints
            End Get
            Set(value As Int32)
                mChallengePoints = value
            End Set
        End Property
        Property RewardTableName As String()
            Get
                Return mRewardTableName
            End Get
            Set(value As String())
                mRewardTableName = value
            End Set
        End Property
        Property OpenRequires As String()
            Get
                Return mOpenRequires
            End Get
            Set(value As String())
                mOpenRequires = value
            End Set
        End Property
        Property AuctionRequires As String()
            Get
                Return mAuctionRequires
            End Get
            Set(value As String())
                mAuctionRequires = value
            End Set
        End Property
        Property DisplayOpenRequiresFailed As String
            Get
                Return mDisplayOpenRequiresFailed
            End Get
            Set(value As String)
                mDisplayOpenRequiresFailed = value
            End Set
        End Property
        Property MinReverseEngineerLevel As Int32
            Get
                Return mMinReverseEngineerLevel
            End Get
            Set(value As Int32)
                mMinReverseEngineerLevel = value
            End Set
        End Property
        Property MaxInventoryAmount As Int32
            Get
                Return mMaxInventoryAmount
            End Get
            Set(value As Int32)
                mMaxInventoryAmount = value
            End Set
        End Property
        Property SellAmount As Int32
            Get
                Return mSellAmount
            End Get
            Set(value As Int32)
                mSellAmount = value
            End Set
        End Property
        Property Flags As COH_Enum_SalvageFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_SalvageFlags)
                mFlags = value
            End Set
        End Property
        Property StoreProduct As String
            Get
                Return mStoreProduct
            End Get
            Set(value As String)
                mStoreProduct = value
            End Set
        End Property
#End Region

#Region "Linked Classes"
        Property WorkShopLinks As String()
            Get
                Return mWorkShopLinks
            End Get
            Set(value As String())
                mWorkShopLinks = value
            End Set
        End Property
        <Xml.Serialization.XmlIgnore> Property WorkShop As World.COH_ObjectDetail
            Get
                Return mWorkShop
            End Get
            Set(value As World.COH_ObjectDetail)
                mWorkShop = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mUI_Details As UI.COH_UI_Widget
       Private mDisplayTabName As String
       Private mDisplayDropMessage As String
       Private mRarity As COH_Enum_SalvageRarity
       Private mType As COH_Enum_SalvageType
       Private mChallengePoints As Int32
       Private mRewardTableName As String()
       Private mOpenRequires As String()
       Private mAuctionRequires As String()
       Private mDisplayOpenRequiresFailed As String
       Private mMinReverseEngineerLevel As Int32
       Private mMaxInventoryAmount As Int32
       Private mSellAmount As Int32
       Private mFlags As COH_Enum_SalvageFlags
       Private mStoreProduct As String
        '//LINKED
       Private mWorkShopLinks As String()
       Private mWorkShop As World.COH_ObjectDetail
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings as COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings as COH_Serialization_Settings = Nothing)
            MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mName = String.Empty
            mDisplayTabName = String.Empty
            mDisplayDropMessage = String.Empty
            mRarity = 0
            mType = 0
            mRewardTableName = New String() {}
            mOpenRequires = New String() {}
            mAuctionRequires = New String() {}
            mDisplayOpenRequiresFailed = String.Empty
            mStoreProduct = String.Empty
            mUI_Details = New UI.COH_UI_Widget
            mWorkShop = New World.COH_ObjectDetail
            mWorkShopLinks = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            '//mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Salvage
            Dim Result As COH_Salvage = New COH_Salvage
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mDisplayTabName = String.Copy(mDisplayTabName)
                .mDisplayDropMessage = String.Copy(mDisplayDropMessage)
                .mRarity = mRarity
                .mType = mType
                .mChallengePoints = mChallengePoints
                .mRewardTableName = mRewardTableName.CloneTheStrings
                .mOpenRequires = mOpenRequires.CloneTheStrings
                .mAuctionRequires = mAuctionRequires.CloneTheStrings
                .mDisplayOpenRequiresFailed = String.Copy(mDisplayOpenRequiresFailed)
                .mMinReverseEngineerLevel = mMinReverseEngineerLevel
                .mMaxInventoryAmount = mMaxInventoryAmount
                .mSellAmount = mSellAmount
                .mFlags = mFlags
                .mStoreProduct = String.Copy(mStoreProduct)
                .mUI_Details = mUI_Details.Clone
                .mWorkShop = mWorkShop.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            mUI_Details.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_String(mDisplayTabName)
            CurrentWriter.Write_CrypticS_String(mDisplayDropMessage)
            CurrentWriter.Write(CInt(mRarity))
            CurrentWriter.Write(CInt(mType))
            CurrentWriter.Write_CrypticS_StringArray(mWorkShopLinks)
            CurrentWriter.Write(mChallengePoints)
            CurrentWriter.Write_CrypticS_StringArray(mRewardTableName)
            CurrentWriter.Write_CrypticS_StringArray(mOpenRequires)
            CurrentWriter.Write_CrypticS_StringArray(mAuctionRequires)
            CurrentWriter.Write_CrypticS_String(mDisplayOpenRequiresFailed)
            CurrentWriter.Write(mMinReverseEngineerLevel)
            CurrentWriter.Write(mMaxInventoryAmount)
            CurrentWriter.Write(mSellAmount)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            CurrentWriter.Write_CrypticS_String(mStoreProduct)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mUI_Details = New UI.COH_UI_Widget(CurrentReader)
            mDisplayTabName = CurrentReader.Read_CrypticS_String
            mDisplayDropMessage = CurrentReader.Read_CrypticS_String
            mRarity = CurrentReader.ReadInt32
            mType = CurrentReader.ReadInt32
            mWorkShopLinks = CurrentReader.Read_CrypticS_StringArray
            mChallengePoints = CurrentReader.ReadInt32
            mRewardTableName = CurrentReader.Read_CrypticS_StringArray()
            mOpenRequires = CurrentReader.Read_CrypticS_StringArray()
            mAuctionRequires = CurrentReader.Read_CrypticS_StringArray()
            mDisplayOpenRequiresFailed = CurrentReader.Read_CrypticS_String
            mMinReverseEngineerLevel = CurrentReader.ReadInt32
            mMaxInventoryAmount = CurrentReader.ReadInt32
            mSellAmount = CurrentReader.ReadInt32
            mFlags = CurrentReader.Read_CrypticS_Flags
            mStoreProduct = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
