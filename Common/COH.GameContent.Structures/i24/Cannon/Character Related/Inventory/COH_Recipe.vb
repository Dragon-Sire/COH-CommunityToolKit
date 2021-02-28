Namespace GameContent.Structures.Inventory
    Public NotInheritable Class COH_Recipe
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property SourceFile As String
            Get
                Return mSourceFile
            End Get
            Set(value As String)
                mSourceFile = value
            End Set
        End Property
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
        Property DetailIcon As String
            Get
                Return mDetailIcon
            End Get
            Set(value As String)
                mDetailIcon = value
            End Set
        End Property
        Property Workshop As String()
            Get
                Return mWorkshop
            End Get
            Set(value As String())
                mWorkshop = value
            End Set
        End Property
        Property Salvage As COH_Salvage_Required()
            Get
                Return mSalvage
            End Get
            Set(value As COH_Salvage_Required())
                mSalvage = value
            End Set
        End Property
        Property PowerComponent As COH_Power_Required()
            Get
                Return mPowerComponent
            End Get
            Set(value As COH_Power_Required())
                mPowerComponent = value
            End Set
        End Property
        Property AdditionalComponents As String()
            Get
                Return mAdditionalComponents
            End Get
            Set(value As String())
                mAdditionalComponents = value
            End Set
        End Property
        Property Detail As String
            Get
                Return mDetail
            End Get
            Set(value As String)
                mDetail = value
            End Set
        End Property
        Property Reward As String()
            Get
                Return mReward
            End Get
            Set(value As String())
                mReward = value
            End Set
        End Property
        Property Enhancement As String
            Get
                Return mEnhancement
            End Get
            Set(value As String)
                mEnhancement = value
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
        Property PowerReward As String
            Get
                Return mPowerReward
            End Get
            Set(value As String)
                mPowerReward = value
            End Set
        End Property
        Property IncarnateReward As String
            Get
                Return mIncarnateReward
            End Get
            Set(value As String)
                mIncarnateReward = value
            End Set
        End Property
        Property Requires As String()
            Get
                Return mRequires
            End Get
            Set(value As String())
                mRequires = value
            End Set
        End Property
        Property Rarity As COH_Enum_RecipeRarity
            Get
                Return mRarity
            End Get
            Set(value As COH_Enum_RecipeRarity)
                mRarity = value
            End Set
        End Property
        Property Level As Int32
            Get
                Return mLevel
            End Get
            Set(value As Int32)
                mLevel = value
            End Set
        End Property
        Property LevelMin As Int32
            Get
                Return mLevelMin
            End Get
            Set(value As Int32)
                mLevelMin = value
            End Set
        End Property
        Property LevelMax As Int32
            Get
                Return mLevelMax
            End Get
            Set(value As Int32)
                mLevelMax = value
            End Set
        End Property
        Property CreationCost As String()
            Get
                Return mCreationCost
            End Get
            Set(value As String())
                mCreationCost = value
            End Set
        End Property
        Property SellToVendor As Int32
            Get
                Return mSellToVendor
            End Get
            Set(value As Int32)
                mSellToVendor = value
            End Set
        End Property
        Property BuyFromVendor As Int32
            Get
                Return mBuyFromVendor
            End Get
            Set(value As Int32)
                mBuyFromVendor = value
            End Set
        End Property
        Property NumUses As Int32
            Get
                Return mNumUses
            End Get
            Set(value As Int32)
                mNumUses = value
            End Set
        End Property
        Property Type As COH_Enum_RecipeType
            Get
                Return mType
            End Get
            Set(value As COH_Enum_RecipeType)
                mType = value
            End Set
        End Property
        Property MaxInvAmount As Int32
            Get
                Return mMaxInvAmount
            End Get
            Set(value As Int32)
                mMaxInvAmount = value
            End Set
        End Property
        Property CreatesEnhancement As Int32
            Get
                Return mCreatesEnhancement
            End Get
            Set(value As Int32)
                mCreatesEnhancement = value
            End Set
        End Property
        Property CreatesInspiration As Int32
            Get
                Return mCreatesInspiration
            End Get
            Set(value As Int32)
                mCreatesInspiration = value
            End Set
        End Property
        Property CreatesSalvage As Int32
            Get
                Return mCreatesSalvage
            End Get
            Set(value As Int32)
                mCreatesSalvage = value
            End Set
        End Property
        Property CreatesRecipe As Int32
            Get
                Return mCreatesRecipe
            End Get
            Set(value As Int32)
                mCreatesRecipe = value
            End Set
        End Property
        Property CreatesRequires As String()
            Get
                Return mCreatesRequires
            End Get
            Set(value As String())
                mCreatesRequires = value
            End Set
        End Property
        Property ReceiveRequires As String()
            Get
                Return mReceiveRequires
            End Get
            Set(value As String())
                mReceiveRequires = value
            End Set
        End Property
        Property NeverReceiveRequires As String()
            Get
                Return mNeverReceiveRequires
            End Get
            Set(value As String())
                mNeverReceiveRequires = value
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
        Property DisplayCreatesRequiresFail As String
            Get
                Return mDisplayCreatesRequiresFail
            End Get
            Set(value As String)
                mDisplayCreatesRequiresFail = value
            End Set
        End Property
        Property DisplayReceiveRequiresFail As String
            Get
                Return mDisplayReceiveRequiresFail
            End Get
            Set(value As String)
                mDisplayReceiveRequiresFail = value
            End Set
        End Property
        Property DisplayReceive As String
            Get
                Return mDisplayReceive
            End Get
            Set(value As String)
                mDisplayReceive = value
            End Set
        End Property
        Property DisplayAccountItemPurchase As String
            Get
                Return mDisplayAccountItemPurchase
            End Get
            Set(value As String)
                mDisplayAccountItemPurchase = value
            End Set
        End Property
        Property DisplayClaimConfirmation As String
            Get
                Return mDisplayClaimConfirmation
            End Get
            Set(value As String)
                mDisplayClaimConfirmation = value
            End Set
        End Property
        Property Flags As COH_Enum_Recipe
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_Recipe)
                mFlags = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mSourceFile As String
       Private mName As String
       Private mUI_Details As UI.COH_UI_Widget
       Private mDisplayTabName As String
       Private mDetailIcon As String
       Private mWorkshop As String()
       Private mSalvage As COH_Salvage_Required()
       Private mPowerComponent As COH_Power_Required()
       Private mAdditionalComponents As String()
       Private mDetail As String
       Private mReward As String()
       Private mEnhancement As String
       Private mRecipe As String
       Private mPowerReward As String
       Private mIncarnateReward As String
       Private mRequires As String()
       Private mRarity As COH_Enum_RecipeRarity
       Private mLevel As Int32
       Private mLevelMin As Int32
       Private mLevelMax As Int32
       Private mCreationCost As String()
       Private mSellToVendor As Int32
       Private mBuyFromVendor As Int32
       Private mNumUses As Int32
       Private mType As COH_Enum_RecipeType
       Private mMaxInvAmount As Int32
       Private mCreatesEnhancement As Int32
       Private mCreatesInspiration As Int32
       Private mCreatesSalvage As Int32
       Private mCreatesRecipe As Int32
       Private mCreatesRequires As String()
       Private mReceiveRequires As String()
       Private mNeverReceiveRequires As String()
       Private mAuctionRequires As String()
       Private mDisplayCreatesRequiresFail As String
       Private mDisplayReceiveRequiresFail As String
       Private mDisplayReceive As String
       Private mDisplayAccountItemPurchase As String
       Private mDisplayClaimConfirmation As String
       Private mFlags As COH_Enum_Recipe
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
            mSourceFile = String.Empty
            mName = String.Empty
            mDisplayTabName = String.Empty
            mDetailIcon = String.Empty
            mWorkshop = New String() {}
            mSalvage = New COH_Salvage_Required() {}
            mPowerComponent = New COH_Power_Required() {}
            mAdditionalComponents = New String() {}
            mDetail = String.Empty
            mReward = New String() {}
            mEnhancement = String.Empty
            mRecipe = String.Empty
            mPowerReward = String.Empty
            mIncarnateReward = String.Empty
            mRequires = New String() {}
            mRarity = COH_Enum_RecipeRarity.kRecipeRarity_Common
            mCreationCost = New String() {}
            mType = COH_Enum_RecipeType.kRecipeType_Workshop
            mCreatesRequires = New String() {}
            mReceiveRequires = New String() {}
            mNeverReceiveRequires = New String() {}
            mAuctionRequires = New String() {}
            mDisplayCreatesRequiresFail = String.Empty
            mDisplayReceiveRequiresFail = String.Empty
            mDisplayReceive = String.Empty
            mDisplayAccountItemPurchase = String.Empty
            mDisplayClaimConfirmation = String.Empty
            mUI_Details = New UI.COH_UI_Widget
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Recipe
            Dim Result As COH_Recipe = New COH_Recipe
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mSourceFile = String.Copy(mSourceFile)
                .mName = String.Copy(mName)
                .mDisplayTabName = String.Copy(mDisplayTabName)
                .mDetailIcon = String.Copy(mDetailIcon)
                .mWorkshop = mWorkshop.CloneTheStrings
                .mSalvage = New COH_Salvage_Required(mSalvage.Count - 1) {}
                For X = 0 To mSalvage.Count - 1
                    .mSalvage(X) = mSalvage(X).Clone
                Next
                .mPowerComponent = New COH_Power_Required(mPowerComponent.Count - 1) {}
                For X = 0 To mPowerComponent.Count - 1
                    .mPowerComponent(X) = mPowerComponent(X).Clone
                Next
                .mAdditionalComponents = mAdditionalComponents.CloneTheStrings
                .mDetail = String.Copy(mDetail)
                .mReward = mReward.CloneTheStrings
                .mEnhancement = String.Copy(mEnhancement)
                .mRecipe = String.Copy(mRecipe)
                .mPowerReward = String.Copy(mPowerReward)
                .mIncarnateReward = String.Copy(mIncarnateReward)
                .mRequires = mRequires.CloneTheStrings
                .mRarity = mRarity
                .mLevel = mLevel
                .mLevelMin = mLevelMin
                .mLevelMax = mLevelMax
                .mCreationCost = mCreationCost.CloneTheStrings
                .mSellToVendor = mSellToVendor
                .mBuyFromVendor = mBuyFromVendor
                .mNumUses = mNumUses
                .mType = mType
                .mMaxInvAmount = mMaxInvAmount
                .mCreatesEnhancement = mCreatesEnhancement
                .mCreatesInspiration = mCreatesInspiration
                .mCreatesSalvage = mCreatesSalvage
                .mCreatesRecipe = mCreatesRecipe
                .mCreatesRequires = mCreatesRequires.CloneTheStrings
                .mReceiveRequires = mReceiveRequires.CloneTheStrings
                .mNeverReceiveRequires = mNeverReceiveRequires.CloneTheStrings
                .mAuctionRequires = mAuctionRequires.CloneTheStrings
                .mDisplayCreatesRequiresFail = String.Copy(mDisplayCreatesRequiresFail)
                .mDisplayReceiveRequiresFail = String.Copy(mDisplayReceiveRequiresFail)
                .mDisplayReceive = String.Copy(mDisplayReceive)
                .mDisplayAccountItemPurchase = String.Copy(mDisplayAccountItemPurchase)
                .mDisplayClaimConfirmation = String.Copy(mDisplayClaimConfirmation)
                .mFlags = mFlags
                .mUI_Details = mUI_Details.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mSourceFile)
            CurrentWriter.Write_CrypticS_String(mName)
            mUI_Details.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_String(mDisplayTabName)
            CurrentWriter.Write_CrypticS_String(mDetailIcon)
            CurrentWriter.Write_CrypticS_StringArray(mWorkshop)
            If CurrentWriter.Write_CrypticS_StructArray(mSalvage) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mSalvageComponent) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mPowerComponent) = False Then Return False
            CurrentWriter.Write_CrypticS_StringArray(mAdditionalComponents)
            CurrentWriter.Write_CrypticS_String(mDetail)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mDetailReward)
            CurrentWriter.Write_CrypticS_StringArray(mReward)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mTableReward)
            CurrentWriter.Write_CrypticS_String(mEnhancement)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mEnhancementReward)
            CurrentWriter.Write_CrypticS_String(mRecipe)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mRecipeReward)
            CurrentWriter.Write_CrypticS_String(mPowerReward)
            CurrentWriter.Write_CrypticS_String(mIncarnateReward)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write(CInt(mRarity))
            CurrentWriter.Write(mLevel)
            CurrentWriter.Write(mLevelMin)
            CurrentWriter.Write(mLevelMax)
            CurrentWriter.Write_CrypticS_StringArray(mCreationCost)
            CurrentWriter.Write(mSellToVendor)
            CurrentWriter.Write(mBuyFromVendor)
            CurrentWriter.Write(mNumUses)
            CurrentWriter.Write(CInt(mType))
            CurrentWriter.Write(mMaxInvAmount)
            CurrentWriter.Write(mCreatesEnhancement)
            CurrentWriter.Write(mCreatesInspiration)
            CurrentWriter.Write(mCreatesSalvage)
            CurrentWriter.Write(mCreatesRecipe)
            CurrentWriter.Write_CrypticS_StringArray(mCreatesRequires)
            CurrentWriter.Write_CrypticS_StringArray(mReceiveRequires)
            CurrentWriter.Write_CrypticS_StringArray(mNeverReceiveRequires)
            CurrentWriter.Write_CrypticS_StringArray(mAuctionRequires)
            CurrentWriter.Write_CrypticS_String(mDisplayCreatesRequiresFail)
            CurrentWriter.Write_CrypticS_String(mDisplayReceiveRequiresFail)
            CurrentWriter.Write_CrypticS_String(mDisplayReceive)
            CurrentWriter.Write_CrypticS_String(mDisplayAccountItemPurchase)
            CurrentWriter.Write_CrypticS_String(mDisplayClaimConfirmation)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mSourceFile = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mUI_Details = New UI.COH_UI_Widget(CurrentReader)
            mDisplayTabName = CurrentReader.Read_CrypticS_String
            mDetailIcon = CurrentReader.Read_CrypticS_String
            mWorkshop = CurrentReader.Read_CrypticS_StringArray()
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Salvage_Required), mSalvage) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mSalvageComponent) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Power_Required), mPowerComponent) = False Then Return False
            mAdditionalComponents = CurrentReader.Read_CrypticS_StringArray()
            mDetail = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mDetailReward = CurrentReader.Read_CrypticS_String
            mReward = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mTableReward = CurrentReader.Read_CrypticS_StringArray()
            mEnhancement = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mEnhancementReward = CurrentReader.Read_CrypticS_String
            mRecipe = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mRecipeReward = CurrentReader.Read_CrypticS_String
            mPowerReward = CurrentReader.Read_CrypticS_String
            mIncarnateReward = CurrentReader.Read_CrypticS_String
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mRarity = CurrentReader.ReadInt32
            mLevel = CurrentReader.ReadInt32
            mLevelMin = CurrentReader.ReadInt32
            mLevelMax = CurrentReader.ReadInt32
            mCreationCost = CurrentReader.Read_CrypticS_StringArray()
            mSellToVendor = CurrentReader.ReadInt32
            mBuyFromVendor = CurrentReader.ReadInt32
            mNumUses = CurrentReader.ReadInt32
            mType = CurrentReader.ReadInt32
            mMaxInvAmount = CurrentReader.ReadInt32
            mCreatesEnhancement = CurrentReader.ReadInt32
            mCreatesInspiration = CurrentReader.ReadInt32
            mCreatesSalvage = CurrentReader.ReadInt32
            mCreatesRecipe = CurrentReader.ReadInt32
            mCreatesRequires = CurrentReader.Read_CrypticS_StringArray()
            mReceiveRequires = CurrentReader.Read_CrypticS_StringArray()
            mNeverReceiveRequires = CurrentReader.Read_CrypticS_StringArray()
            mAuctionRequires = CurrentReader.Read_CrypticS_StringArray()
            mDisplayCreatesRequiresFail = CurrentReader.Read_CrypticS_String
            mDisplayReceiveRequiresFail = CurrentReader.Read_CrypticS_String
            mDisplayReceive = CurrentReader.Read_CrypticS_String
            mDisplayAccountItemPurchase = CurrentReader.Read_CrypticS_String
            mDisplayClaimConfirmation = CurrentReader.Read_CrypticS_String
            mFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace
