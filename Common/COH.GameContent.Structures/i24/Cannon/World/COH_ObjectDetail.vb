Imports COH.GameContent.Structures.UI

Namespace GameContent.Structures.World
    Public NotInheritable Class COH_ObjectDetail
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return DisplayTabName
            End Get
        End Property
#End Region

#Region "Properties"
        Property UI As COH_UI_NameANDHelp
            Get
                Return mUI_NameANDHelp
            End Get
            Set(value As COH_UI_NameANDHelp)
                mUI_NameANDHelp = value
            End Set
        End Property
        Property Category As String
            Get
                Return mCategory
            End Get
            Set(value As String)
                mCategory = value
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
        Property GroupName As String
            Get
                Return mGroupName
            End Get
            Set(value As String)
                mGroupName = value
            End Set
        End Property
        Property GroupNameUnpowered As String
            Get
                Return mGroupNameUnpowered
            End Get
            Set(value As String)
                mGroupNameUnpowered = value
            End Set
        End Property
        Property GroupNameDestroyed As String
            Get
                Return mGroupNameDestroyed
            End Get
            Set(value As String)
                mGroupNameDestroyed = value
            End Set
        End Property
        Property GroupNameMount As String
            Get
                Return mGroupNameMount
            End Get
            Set(value As String)
                mGroupNameMount = value
            End Set
        End Property
        Property GroupNameUnpoweredMount As String
            Get
                Return mGroupNameUnpoweredMount
            End Get
            Set(value As String)
                mGroupNameUnpoweredMount = value
            End Set
        End Property
        Property GroupNameBaseEdit As String
            Get
                Return mGroupNameBaseEdit
            End Get
            Set(value As String)
                mGroupNameBaseEdit = value
            End Set
        End Property
        Property Surface As COH_Enum_Surface
            Get
                Return mSurface
            End Get
            Set(value As COH_Enum_Surface)
                mSurface = value
            End Set
        End Property
        Property Replacer As Int32
            Get
                Return mReplacer
            End Get
            Set(value As Int32)
                mReplacer = value
            End Set
        End Property
        Property HasVolumeTrigger As Boolean
            Get
                Return mHasVolumeTrigger
            End Get
            Set(value As Boolean)
                mHasVolumeTrigger = value
            End Set
        End Property
        Property Mounted As Boolean
            Get
                Return mMounted
            End Get
            Set(value As Boolean)
                mMounted = value
            End Set
        End Property
        Property CannotDelete As Boolean
            Get
                Return mCannotDelete
            End Get
            Set(value As Boolean)
                mCannotDelete = value
            End Set
        End Property
        Property WarnDelete As Boolean
            Get
                Return mWarnDelete
            End Get
            Set(value As Boolean)
                mWarnDelete = value
            End Set
        End Property
        Property DoNotBlock As Boolean
            Get
                Return mDoNotBlock
            End Get
            Set(value As Boolean)
                mDoNotBlock = value
            End Set
        End Property
        Property AnimatedEnt As Boolean
            Get
                Return mAnimatedEnt
            End Get
            Set(value As Boolean)
                mAnimatedEnt = value
            End Set
        End Property
        Property AccessPermissions As Boolean
            Get
                Return mAccessPermissions
            End Get
            Set(value As Boolean)
                mAccessPermissions = value
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
        Property CostPrestige As Int32
            Get
                Return mCostPrestige
            End Get
            Set(value As Int32)
                mCostPrestige = value
            End Set
        End Property
        Property CostInfluence As Int32
            Get
                Return mCostInfluence
            End Get
            Set(value As Int32)
                mCostInfluence = value
            End Set
        End Property
        Property UpkeepPrestige As Int32
            Get
                Return mUpkeepPrestige
            End Get
            Set(value As Int32)
                mUpkeepPrestige = value
            End Set
        End Property
        Property UpkeepInfluence As Int32
            Get
                Return mUpkeepInfluence
            End Get
            Set(value As Int32)
                mUpkeepInfluence = value
            End Set
        End Property
        Property EnergyConsume As Int32
            Get
                Return mEnergyConsume
            End Get
            Set(value As Int32)
                mEnergyConsume = value
            End Set
        End Property
        Property EnergyProduce As Int32
            Get
                Return mEnergyProduce
            End Get
            Set(value As Int32)
                mEnergyProduce = value
            End Set
        End Property
        Property ControlConsume As Int32
            Get
                Return mControlConsume
            End Get
            Set(value As Int32)
                mControlConsume = value
            End Set
        End Property
        Property ControlProduce As Int32
            Get
                Return mControlProduce
            End Get
            Set(value As Int32)
                mControlProduce = value
            End Set
        End Property
        Property MustBeReachable As Boolean
            Get
                Return mMustBeReachable
            End Get
            Set(value As Boolean)
                mMustBeReachable = value
            End Set
        End Property
        Property Obsolete As Boolean
            Get
                Return mObsolete
            End Get
            Set(value As Boolean)
                mObsolete = value
            End Set
        End Property
        Property Lifetime As Int32
            Get
                Return mLifetime
            End Get
            Set(value As Int32)
                mLifetime = value
            End Set
        End Property
        Property RepairChance As Single
            Get
                Return mRepairChance
            End Get
            Set(value As Single)
                mRepairChance = value
            End Set
        End Property
        Property EntityDef As String
            Get
                Return mEntityDef
            End Get
            Set(value As String)
                mEntityDef = value
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
        Property Behavior As String
            Get
                Return mBehavior
            End Get
            Set(value As String)
                mBehavior = value
            End Set
        End Property
        Property DecayTo As String
            Get
                Return mDecayTo
            End Get
            Set(value As String)
                mDecayTo = value
            End Set
        End Property
        Property DecayedLife As Int32
            Get
                Return mDecayedLife
            End Get
            Set(value As Int32)
                mDecayedLife = value
            End Set
        End Property
        Property AuxAllowed As String()
            Get
                Return mAuxAllowed
            End Get
            Set(value As String())
                mAuxAllowed = value
            End Set
        End Property
        Property MaxAuxAllowed As Int32
            Get
                Return mMaxAuxAllowed
            End Get
            Set(value As Int32)
                mMaxAuxAllowed = value
            End Set
        End Property
        Property [Function] As COH_Enum_ObjectDetailFunction
            Get
                Return mFunction
            End Get
            Set(value As COH_Enum_ObjectDetailFunction)
                mFunction = value
            End Set
        End Property
        Property FunctionParams As String()
            Get
                Return mFunctionParams
            End Get
            Set(value As String())
                mFunctionParams = value
            End Set
        End Property
        Property Power As String
            Get
                Return mPower
            End Get
            Set(value As String)
                mPower = value
            End Set
        End Property
        Property DisplayFloatDestroyed As String
            Get
                Return mDisplayFloatDestroyed
            End Get
            Set(value As String)
                mDisplayFloatDestroyed = value
            End Set
        End Property
        Property DisplayFloatUnpowered As String
            Get
                Return mDisplayFloatUnpowered
            End Get
            Set(value As String)
                mDisplayFloatUnpowered = value
            End Set
        End Property
        Property DisplayFloatUncontrolled As String
            Get
                Return mDisplayFloatUncontrolled
            End Get
            Set(value As String)
                mDisplayFloatUncontrolled = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mUI_NameANDHelp As COH_UI_NameANDHelp
       Private mCategory As String
       Private mDisplayTabName As String
       Private mGroupName As String
       Private mGroupNameUnpowered As String
       Private mGroupNameDestroyed As String
       Private mGroupNameMount As String
       Private mGroupNameUnpoweredMount As String
       Private mGroupNameBaseEdit As String
       Private mSurface As COH_Enum_Surface
       Private mReplacer As Int32
       Private mHasVolumeTrigger As Boolean
       Private mMounted As Boolean
       Private mCannotDelete As Boolean
       Private mWarnDelete As Boolean
       Private mDoNotBlock As Boolean
       Private mAnimatedEnt As Boolean
       Private mAccessPermissions As Boolean
       Private mRequires As String()
       Private mCostPrestige As Int32
       Private mCostInfluence As Int32
       Private mUpkeepPrestige As Int32
       Private mUpkeepInfluence As Int32
       Private mEnergyConsume As Int32
       Private mEnergyProduce As Int32
       Private mControlConsume As Int32
       Private mControlProduce As Int32
       Private mMustBeReachable As Boolean
       Private mObsolete As Boolean
       Private mLifetime As Int32
       Private mRepairChance As Single
       Private mEntityDef As String
       Private mLevel As Int32
       Private mBehavior As String
       Private mDecayTo As String
       Private mDecayedLife As Int32
       Private mAuxAllowed As String()
       Private mMaxAuxAllowed As Int32
       Private mFunction As COH_Enum_ObjectDetailFunction
       Private mFunctionParams As String()
       Private mPower As String
       Private mDisplayFloatDestroyed As String
       Private mDisplayFloatUnpowered As String
       Private mDisplayFloatUncontrolled As String
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
            mCategory = String.Empty
            mDisplayTabName = String.Empty
            mGroupName = String.Empty
            mGroupNameUnpowered = String.Empty
            mGroupNameDestroyed = String.Empty
            mGroupNameMount = String.Empty
            mGroupNameUnpoweredMount = String.Empty
            mGroupNameBaseEdit = String.Empty
            mSurface = -1
            mRequires = New String() {}
            mEntityDef = String.Empty
            mBehavior = String.Empty
            mDecayTo = String.Empty
            mAuxAllowed = New String() {}
            mFunction = 0
            mFunctionParams = New String() {}
            mPower = String.Empty
            mDisplayFloatDestroyed = String.Empty
            mDisplayFloatUnpowered = String.Empty
            mDisplayFloatUncontrolled = String.Empty
            mUI_NameANDHelp = New COH_UI_NameANDHelp
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ObjectDetail
            Dim Result As COH_ObjectDetail = New COH_ObjectDetail
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCategory = String.Copy(mCategory)
                .mDisplayTabName = String.Copy(mDisplayTabName)
                .mGroupName = String.Copy(mGroupName)
                .mGroupNameUnpowered = String.Copy(mGroupNameUnpowered)
                .mGroupNameDestroyed = String.Copy(mGroupNameDestroyed)
                .mGroupNameMount = String.Copy(mGroupNameMount)
                .mGroupNameUnpoweredMount = String.Copy(mGroupNameUnpoweredMount)
                .mGroupNameBaseEdit = String.Copy(mGroupNameBaseEdit)
                .mSurface = mSurface
                .mReplacer = mReplacer
                .mHasVolumeTrigger = mHasVolumeTrigger
                .mMounted = mMounted
                .mCannotDelete = mCannotDelete
                .mWarnDelete = mWarnDelete
                .mDoNotBlock = mDoNotBlock
                .mAnimatedEnt = mAnimatedEnt
                .mAccessPermissions = mAccessPermissions
                .mRequires = mRequires.CloneTheStrings
                .mCostPrestige = mCostPrestige
                .mCostInfluence = mCostInfluence
                .mUpkeepPrestige = mUpkeepPrestige
                .mUpkeepInfluence = mUpkeepInfluence
                .mEnergyConsume = mEnergyConsume
                .mEnergyProduce = mEnergyProduce
                .mControlConsume = mControlConsume
                .mControlProduce = mControlProduce
                .mMustBeReachable = mMustBeReachable
                .mObsolete = mObsolete
                .mLifetime = mLifetime
                .mRepairChance = mRepairChance
                .mEntityDef = String.Copy(mEntityDef)
                .mLevel = mLevel
                .mBehavior = String.Copy(mBehavior)
                .mDecayTo = String.Copy(mDecayTo)
                .mDecayedLife = mDecayedLife
                .mAuxAllowed = mAuxAllowed.CloneTheStrings
                .mMaxAuxAllowed = mMaxAuxAllowed
                .mFunction = mFunction
                .mFunctionParams = mFunctionParams.CloneTheStrings
                .mPower = String.Copy(mPower)
                .mDisplayFloatDestroyed = String.Copy(mDisplayFloatDestroyed)
                .mDisplayFloatUnpowered = String.Copy(mDisplayFloatUnpowered)
                .mDisplayFloatUncontrolled = String.Copy(mDisplayFloatUncontrolled)
                .mUI_NameANDHelp = mUI_NameANDHelp.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            mUI_NameANDHelp.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_String(mCategory)
            CurrentWriter.Write_CrypticS_String(mDisplayTabName)
            CurrentWriter.Write_CrypticS_String(mGroupName)
            CurrentWriter.Write_CrypticS_String(mGroupNameUnpowered)
            CurrentWriter.Write_CrypticS_String(mGroupNameDestroyed)
            CurrentWriter.Write_CrypticS_String(mGroupNameMount)
            CurrentWriter.Write_CrypticS_String(mGroupNameUnpoweredMount)
            CurrentWriter.Write_CrypticS_String(mGroupNameBaseEdit)
            CurrentWriter.Write(CInt(mSurface))
            CurrentWriter.Write(mReplacer)
            CurrentWriter.Write_CrypticS_Boolean(mHasVolumeTrigger)
            CurrentWriter.Write_CrypticS_Boolean(mMounted)
            CurrentWriter.Write_CrypticS_Boolean(mCannotDelete)
            CurrentWriter.Write_CrypticS_Boolean(mWarnDelete)
            CurrentWriter.Write_CrypticS_Boolean(mDoNotBlock)
            CurrentWriter.Write_CrypticS_Boolean(mAnimatedEnt)
            CurrentWriter.Write_CrypticS_Boolean(mAccessPermissions)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write(mCostPrestige)
            CurrentWriter.Write(mCostInfluence)
            CurrentWriter.Write(mUpkeepPrestige)
            CurrentWriter.Write(mUpkeepInfluence)
            CurrentWriter.Write(mEnergyConsume)
            CurrentWriter.Write(mEnergyProduce)
            CurrentWriter.Write(mControlConsume)
            CurrentWriter.Write(mControlProduce)
            CurrentWriter.Write_CrypticS_Boolean(mMustBeReachable)
            CurrentWriter.Write_CrypticS_Boolean(mObsolete)
            CurrentWriter.Write(mLifetime)
            CurrentWriter.Write(mRepairChance)
            CurrentWriter.Write_CrypticS_String(mEntityDef)
            CurrentWriter.Write(mLevel)
            CurrentWriter.Write_CrypticS_String(mBehavior)
            CurrentWriter.Write_CrypticS_String(mDecayTo)
            CurrentWriter.Write(mDecayedLife)
            CurrentWriter.Write_CrypticS_StringArray(mAuxAllowed)
            CurrentWriter.Write(mMaxAuxAllowed)
            CurrentWriter.Write(CInt(mFunction))
            CurrentWriter.Write_CrypticS_StringArray(mFunctionParams)
            CurrentWriter.Write_CrypticS_String(mPower)
            CurrentWriter.Write_CrypticS_String(mDisplayFloatDestroyed)
            CurrentWriter.Write_CrypticS_String(mDisplayFloatUnpowered)
            CurrentWriter.Write_CrypticS_String(mDisplayFloatUncontrolled)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mUI_NameANDHelp = New COH_UI_NameANDHelp(CurrentReader)
            mCategory = CurrentReader.Read_CrypticS_String
            mDisplayTabName = CurrentReader.Read_CrypticS_String
            mGroupName = CurrentReader.Read_CrypticS_String
            mGroupNameUnpowered = CurrentReader.Read_CrypticS_String
            mGroupNameDestroyed = CurrentReader.Read_CrypticS_String
            mGroupNameMount = CurrentReader.Read_CrypticS_String
            mGroupNameUnpoweredMount = CurrentReader.Read_CrypticS_String
            mGroupNameBaseEdit = CurrentReader.Read_CrypticS_String
            mSurface = CurrentReader.ReadInt32
            mReplacer = CurrentReader.ReadInt32
            mHasVolumeTrigger = CurrentReader.Read_CrypticS_Boolean
            mMounted = CurrentReader.Read_CrypticS_Boolean
            mCannotDelete = CurrentReader.Read_CrypticS_Boolean
            mWarnDelete = CurrentReader.Read_CrypticS_Boolean
            mDoNotBlock = CurrentReader.Read_CrypticS_Boolean
            mAnimatedEnt = CurrentReader.Read_CrypticS_Boolean
            mAccessPermissions = CurrentReader.Read_CrypticS_Boolean
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mCostPrestige = CurrentReader.ReadInt32
            mCostInfluence = CurrentReader.ReadInt32
            mUpkeepPrestige = CurrentReader.ReadInt32
            mUpkeepInfluence = CurrentReader.ReadInt32
            mEnergyConsume = CurrentReader.ReadInt32
            mEnergyProduce = CurrentReader.ReadInt32
            mControlConsume = CurrentReader.ReadInt32
            mControlProduce = CurrentReader.ReadInt32
            mMustBeReachable = CurrentReader.Read_CrypticS_Boolean
            mObsolete = CurrentReader.Read_CrypticS_Boolean
            mLifetime = CurrentReader.ReadInt32
            mRepairChance = CurrentReader.ReadSingle
            mEntityDef = CurrentReader.Read_CrypticS_String
            mLevel = CurrentReader.ReadInt32
            mBehavior = CurrentReader.Read_CrypticS_String
            mDecayTo = CurrentReader.Read_CrypticS_String
            mDecayedLife = CurrentReader.ReadInt32
            mAuxAllowed = CurrentReader.Read_CrypticS_StringArray()
            mMaxAuxAllowed = CurrentReader.ReadInt32
            mFunction = CurrentReader.ReadInt32
            mFunctionParams = CurrentReader.Read_CrypticS_StringArray()
            mPower = CurrentReader.Read_CrypticS_String
            mDisplayFloatDestroyed = CurrentReader.Read_CrypticS_String
            mDisplayFloatUnpowered = CurrentReader.Read_CrypticS_String
            mDisplayFloatUncontrolled = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
