Imports COH.GameContent.Structures.Powers
Imports COH.GameContent.Structures.Shared.Drawing

Namespace GameContent.Structures.Characters.Powers
    Public NotInheritable Class COH_Power
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property FullName As String
            Get
                Return mFullName
            End Get
            Set(value As String)
                SetValue(mFullName, value)
            End Set
        End Property
        Property CRCFullName As UInt32
            Get
                Return mCRCFullName
            End Get
            Set(value As UInt32)
                SetValue(mCRCFullName, value)
            End Set
        End Property
        Property SourceFile As String
            Get
                Return mSourceFile
            End Get
            Set(value As String)
                SetValue(mSourceFile, value)
            End Set
        End Property
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                SetValue(mName, value)
            End Set
        End Property
        Property SourceName As String
            Get
                Return mSourceName
            End Get
            Set(value As String)
                SetValue(mSourceName, value)
            End Set
        End Property
        Property System As COH_Enum_PowerSystem
            Get
                Return mSystem
            End Get
            Set(value As COH_Enum_PowerSystem)
                SetValue(mSystem, value)
            End Set
        End Property
        Property AutoIssue As Boolean
            Get
                Return mAutoIssue
            End Get
            Set(value As Boolean)
                SetValue(mAutoIssue, value)
            End Set
        End Property
        Property AutoIssueSaveLevel As Boolean
            Get
                Return mAutoIssueSaveLevel
            End Get
            Set(value As Boolean)
                SetValue(mAutoIssueSaveLevel, value)
            End Set
        End Property
        Property Free As Boolean
            Get
                Return mFree
            End Get
            Set(value As Boolean)
                SetValue(mFree, value)
            End Set
        End Property
        Property DisplayName As CrypticS_String
            Get
                Return mDisplayName
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayName, value)
            End Set
        End Property
        Property DisplayHelp As CrypticS_String
            Get
                Return mDisplayHelp
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayHelp, value)
            End Set
        End Property
        Property DisplayShortHelp As CrypticS_String
            Get
                Return mDisplayShortHelp
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayShortHelp, value)
            End Set
        End Property
        Property DisplayTargetHelp As CrypticS_String
            Get
                Return mDisplayTargetHelp
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayTargetHelp, value)
            End Set
        End Property
        Property DisplayTargetShortHelp As CrypticS_String
            Get
                Return mDisplayTargetShortHelp
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayTargetShortHelp, value)
            End Set
        End Property
        Property DisplayAttackerAttack As CrypticS_String
            Get
                Return mDisplayAttackerAttack
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayAttackerAttack, value)
            End Set
        End Property
        Property DisplayAttackerAttackFloater As CrypticS_String
            Get
                Return mDisplayAttackerAttackFloater
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayAttackerAttackFloater, value)
            End Set
        End Property
        Property DisplayAttackerHit As CrypticS_String
            Get
                Return mDisplayAttackerHit
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayAttackerHit, value)
            End Set
        End Property
        Property DisplayVictimHit As CrypticS_String
            Get
                Return mDisplayVictimHit
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayVictimHit, value)
            End Set
        End Property
        Property DisplayConfirm As CrypticS_String
            Get
                Return mDisplayConfirm
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayConfirm, value)
            End Set
        End Property
        Property FloatRewarded As CrypticS_String
            Get
                Return mFloatRewarded
            End Get
            Set(value As CrypticS_String)
                SetValue(mFloatRewarded, value)
            End Set
        End Property
        Property DisplayPowerDefenseFloat As CrypticS_String
            Get
                Return mDisplayPowerDefenseFloat
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayPowerDefenseFloat, value)
            End Set
        End Property
        Property IconName As String
            Get
                Return mIconName
            End Get
            Set(value As String)
                SetValue(mIconName, value)
            End Set
        End Property
        Property Type As COH_Enum_PowerType
            Get
                Return mType
            End Get
            Set(value As COH_Enum_PowerType)
                SetValue(mType, value)
            End Set
        End Property
        <DefaultValue(1)> Property NumAllowed As Int32
            Get
                Return mNumAllowed
            End Get
            Set(value As Int32)
                SetValue(mNumAllowed, value)
            End Set
        End Property
        Property AttackTypes As Int32()
            Get
                Return mAttackTypes
            End Get
            Set(value As Int32())
                SetValue(mAttackTypes, value)
            End Set
        End Property
        Property BuyRequires As String()
            Get
                Return mBuyRequires
            End Get
            Set(value As String())
                SetValue(mBuyRequires, value)
            End Set
        End Property
        Property ActivateRequires As String()
            Get
                Return mActivateRequires
            End Get
            Set(value As String())
                SetValue(mActivateRequires, value)
            End Set
        End Property
        Property SlotRequires As String()
            Get
                Return mSlotRequires
            End Get
            Set(value As String())
                SetValue(mSlotRequires, value)
            End Set
        End Property
        Property TargetRequires As String()
            Get
                Return mTargetRequires
            End Get
            Set(value As String())
                SetValue(mTargetRequires, value)
            End Set
        End Property
        Property RewardRequires As String()
            Get
                Return mRewardRequires
            End Get
            Set(value As String())
                SetValue(mRewardRequires, value)
            End Set
        End Property
        Property AuctionRequires As String()
            Get
                Return mAuctionRequires
            End Get
            Set(value As String())
                SetValue(mAuctionRequires, value)
            End Set
        End Property
        Property RewardFallback As String
            Get
                Return mRewardFallback
            End Get
            Set(value As String)
                SetValue(mRewardFallback, value)
            End Set
        End Property
        Property Accuracy As Single
            Get
                Return mAccuracy
            End Get
            Set(value As Single)
                SetValue(mAccuracy, value)
            End Set
        End Property
        Property NearGround As Boolean
            Get
                Return mNearGround
            End Get
            Set(value As Boolean)
                SetValue(mNearGround, value)
            End Set
        End Property
        Property TargetNearGround As Boolean
            Get
                Return mTargetNearGround
            End Get
            Set(value As Boolean)
                SetValue(mTargetNearGround, value)
            End Set
        End Property
        Property CastableAfterDeath As COH_Enum_DeathCastableSetting
            Get
                Return mCastableAfterDeath
            End Get
            Set(value As COH_Enum_DeathCastableSetting)
                SetValue(mCastableAfterDeath, value)
            End Set
        End Property
        Property CastThroughHold As Boolean
            Get
                Return mCastThroughHold
            End Get
            Set(value As Boolean)
                SetValue(mCastThroughHold, value)
            End Set
        End Property
        Property CastThroughSleep As Boolean
            Get
                Return mCastThroughSleep
            End Get
            Set(value As Boolean)
                SetValue(mCastThroughSleep, value)
            End Set
        End Property
        Property CastThroughStun As Boolean
            Get
                Return mCastThroughStun
            End Get
            Set(value As Boolean)
                SetValue(mCastThroughStun, value)
            End Set
        End Property
        Property CastThroughTerrorize As Boolean
            Get
                Return mCastThroughTerrorize
            End Get
            Set(value As Boolean)
                SetValue(mCastThroughTerrorize, value)
            End Set
        End Property
        Property ToggleIgnoreHold As Boolean
            Get
                Return mToggleIgnoreHold
            End Get
            Set(value As Boolean)
                SetValue(mToggleIgnoreHold, value)
            End Set
        End Property
        Property ToggleIgnoreSleep As Boolean
            Get
                Return mToggleIgnoreSleep
            End Get
            Set(value As Boolean)
                SetValue(mToggleIgnoreSleep, value)
            End Set
        End Property
        Property ToggleIgnoreStun As Boolean
            Get
                Return mToggleIgnoreStun
            End Get
            Set(value As Boolean)
                SetValue(mToggleIgnoreStun, value)
            End Set
        End Property
        Property IgnoreLevelBought As Boolean
            Get
                Return mIgnoreLevelBought
            End Get
            Set(value As Boolean)
                SetValue(mIgnoreLevelBought, value)
            End Set
        End Property
        Property ShootThroughUntouchable As Boolean
            Get
                Return mShootThroughUntouchable
            End Get
            Set(value As Boolean)
                SetValue(mShootThroughUntouchable, value)
            End Set
        End Property
        Property InterruptLikeSleep As Boolean
            Get
                Return mInterruptLikeSleep
            End Get
            Set(value As Boolean)
                SetValue(mInterruptLikeSleep, value)
            End Set
        End Property
        Property AIReport As COH_Enum_AIReport
            Get
                Return mAIReport
            End Get
            Set(value As COH_Enum_AIReport)
                SetValue(mAIReport, value)
            End Set
        End Property
        Property EffectArea As COH_Enum_EffectArea
            Get
                Return mEffectArea
            End Get
            Set(value As COH_Enum_EffectArea)
                SetValue(mEffectArea, value)
            End Set
        End Property
        Property MaxTargetsHit As Int32
            Get
                Return mMaxTargetsHit
            End Get
            Set(value As Int32)
                SetValue(mMaxTargetsHit, value)
            End Set
        End Property
        Property Radius As Single
            Get
                Return mRadius
            End Get
            Set(value As Single)
                SetValue(mRadius, value)
            End Set
        End Property
        Property Arc As Single
            Get
                Return mArc
            End Get
            Set(value As Single)
                SetValue(mArc, value)
            End Set
        End Property
        Property BoxOffset As COH_Struct_Vector3
            Get
                Return mBoxOffset
            End Get
            Set(value As COH_Struct_Vector3)
                SetValue(mBoxOffset, value)
            End Set
        End Property
        Property BoxSize As COH_Struct_Vector3
            Get
                Return mBoxSize
            End Get
            Set(value As COH_Struct_Vector3)
                SetValue(mBoxSize, value)
            End Set
        End Property
        Property Range As Single
            Get
                Return mRange
            End Get
            Set(value As Single)
                SetValue(mRange, value)
            End Set
        End Property
        Property RangeSecondary As Single
            Get
                Return mRangeSecondary
            End Get
            Set(value As Single)
                SetValue(mRangeSecondary, value)
            End Set
        End Property
        Property TimeToActivate As Single
            Get
                Return mTimeToActivate
            End Get
            Set(value As Single)
                SetValue(mTimeToActivate, value)
            End Set
        End Property
        Property RechargeTime As Single
            Get
                Return mRechargeTime
            End Get
            Set(value As Single)
                SetValue(mRechargeTime, value)
            End Set
        End Property
        Property ActivatePeriod As Single
            Get
                Return mActivatePeriod
            End Get
            Set(value As Single)
                SetValue(mActivatePeriod, value)
            End Set
        End Property
        Property EnduranceCost As Single
            Get
                Return mEnduranceCost
            End Get
            Set(value As Single)
                SetValue(mEnduranceCost, value)
            End Set
        End Property
        Property IdeaCost As Single
            Get
                Return mIdeaCost
            End Get
            Set(value As Single)
                SetValue(mIdeaCost, value)
            End Set
        End Property
        Property TimeToConfirm As Int32
            Get
                Return mTimeToConfirm
            End Get
            Set(value As Int32)
                SetValue(mTimeToConfirm, value)
            End Set
        End Property
        Property SelfConfirm As Int32
            Get
                Return mSelfConfirm
            End Get
            Set(value As Int32)
                SetValue(mSelfConfirm, value)
            End Set
        End Property
        Property ConfirmRequires As String()
            Get
                Return mConfirmRequires
            End Get
            Set(value As String())
                SetValue(mConfirmRequires, value)
            End Set
        End Property
        <DefaultValue(True)> Property DestroyOnLimit As Boolean
            Get
                Return mDestroyOnLimit
            End Get
            Set(value As Boolean)
                SetValue(mDestroyOnLimit, value)
            End Set
        End Property
        Property StackingUsage As Boolean
            Get
                Return mStackingUsage
            End Get
            Set(value As Boolean)
                SetValue(mStackingUsage, value)
            End Set
        End Property
        Property NumCharges As Int32
            Get
                Return mNumCharges
            End Get
            Set(value As Int32)
                SetValue(mNumCharges, value)
            End Set
        End Property
        Property MaxNumCharges As Int32
            Get
                Return mMaxNumCharges
            End Get
            Set(value As Int32)
                SetValue(mMaxNumCharges, value)
            End Set
        End Property
        Property UsageTime As Single
            Get
                Return mUsageTime
            End Get
            Set(value As Single)
                SetValue(mUsageTime, value)
            End Set
        End Property
        Property MaxUsageTime As Single
            Get
                Return mMaxUsageTime
            End Get
            Set(value As Single)
                SetValue(mMaxUsageTime, value)
            End Set
        End Property
        Property Lifetime As Single
            Get
                Return mLifetime
            End Get
            Set(value As Single)
                SetValue(mLifetime, value)
            End Set
        End Property
        Property MaxLifetime As Single
            Get
                Return mMaxLifetime
            End Get
            Set(value As Single)
                SetValue(mMaxLifetime, value)
            End Set
        End Property
        Property LifetimeInGame As Single
            Get
                Return mLifetimeInGame
            End Get
            Set(value As Single)
                SetValue(mLifetimeInGame, value)
            End Set
        End Property
        Property MaxLifetimeInGame As Single
            Get
                Return mMaxLifetimeInGame
            End Get
            Set(value As Single)
                SetValue(mMaxLifetimeInGame, value)
            End Set
        End Property
        Property InterruptTime As Single
            Get
                Return mInterruptTime
            End Get
            Set(value As Single)
                SetValue(mInterruptTime, value)
            End Set
        End Property
        Property TargetVisibility As COH_Enum_TargetVisibility
            Get
                Return mTargetVisibility
            End Get
            Set(value As COH_Enum_TargetVisibility)
                SetValue(mTargetVisibility, value)
            End Set
        End Property
        Property Target As COH_Enum_TargetType
            Get
                Return mTarget
            End Get
            Set(value As COH_Enum_TargetType)
                SetValue(mTarget, value)
            End Set
        End Property
        Property TargetSecondary As COH_Enum_TargetType
            Get
                Return mTargetSecondary
            End Get
            Set(value As COH_Enum_TargetType)
                SetValue(mTargetSecondary, value)
            End Set
        End Property
        Property EntsAutoHit As COH_Enum_TargetType()
            Get
                Return mEntsAutoHit
            End Get
            Set(value As COH_Enum_TargetType())
                SetValue(mEntsAutoHit, value)
            End Set
        End Property
        Property EntsAffected As COH_Enum_TargetType()
            Get
                Return mEntsAffected
            End Get
            Set(value As COH_Enum_TargetType())
                SetValue(mEntsAffected, value)
            End Set
        End Property
        Property TargetsThroughVisionPhase As Boolean
            Get
                Return mTargetsThroughVisionPhase
            End Get
            Set(value As Boolean)
                SetValue(mTargetsThroughVisionPhase, value)
            End Set
        End Property
        Property BoostsAllowed As Int32()
            Get
                Return mBoostsAllowed
            End Get
            Set(value As Int32())
                SetValue(mBoostsAllowed, value)
            End Set
        End Property
        Property GroupMembership As Int32()
            Get
                Return mGroupMembership
            End Get
            Set(value As Int32())
                SetValue(mGroupMembership, value)
            End Set
        End Property
        Property ModesRequired As Int32()
            Get
                Return mModesRequired
            End Get
            Set(value As Int32())
                SetValue(mModesRequired, value)
            End Set
        End Property
        Property ModesDisallowed As Int32()
            Get
                Return mModesDisallowed
            End Get
            Set(value As Int32())
                SetValue(mModesDisallowed, value)
            End Set
        End Property
        Property AIGroups As String()
            Get
                Return mAIGroups
            End Get
            Set(value As String())
                SetValue(mAIGroups, value)
            End Set
        End Property
        <COH_VersionRange(0, 6)> Property AttribMod As COH_Power_AttributeMod()
            Get
                Return mAttribMod
            End Get
            Set(value As COH_Power_AttributeMod())
                SetValue(mAttribMod, value)
            End Set
        End Property
        Property IgnoreStrength As Boolean
            Get
                Return mIgnoreStrength
            End Get
            Set(value As Boolean)
                SetValue(mIgnoreStrength, value)
            End Set
        End Property
        Property ShowBuffIcon As Boolean
            Get
                Return mShowBuffIcon
            End Get
            Set(value As Boolean)
                SetValue(mShowBuffIcon, value)
            End Set
        End Property
        Property ShowInInventory As COH_Enum_ShowPowerSetting
            Get
                Return mShowInInventory
            End Get
            Set(value As COH_Enum_ShowPowerSetting)
                SetValue(mShowInInventory, value)
            End Set
        End Property
        <DefaultValue(True)> Property ShowInManage As Boolean
            Get
                Return mShowInManage
            End Get
            Set(value As Boolean)
                SetValue(mShowInManage, value)
            End Set
        End Property
        <DefaultValue(True)> Property ShowInInfo As Boolean
            Get
                Return mShowInInfo
            End Get
            Set(value As Boolean)
                SetValue(mShowInInfo, value)
            End Set
        End Property
        Property Deletable As Boolean
            Get
                Return mDeletable
            End Get
            Set(value As Boolean)
                SetValue(mDeletable, value)
            End Set
        End Property
        Property Tradeable As Boolean
            Get
                Return mTradeable
            End Get
            Set(value As Boolean)
                SetValue(mTradeable, value)
            End Set
        End Property
        <DefaultValue(6)> Property MaxBoosts As Int32
            Get
                Return mMaxBoosts
            End Get
            Set(value As Int32)
                SetValue(mMaxBoosts, value)
            End Set
        End Property
        Property DoNotSave As Boolean
            Get
                Return mDoNotSave
            End Get
            Set(value As Boolean)
                SetValue(mDoNotSave, value)
            End Set
        End Property
        Property BoostIgnoreEffectiveness As Boolean
            Get
                Return mBoostIgnoreEffectiveness
            End Get
            Set(value As Boolean)
                SetValue(mBoostIgnoreEffectiveness, value)
            End Set
        End Property
        Property BoostAlwaysCountForSet As Boolean
            Get
                Return mBoostAlwaysCountForSet
            End Get
            Set(value As Boolean)
                SetValue(mBoostAlwaysCountForSet, value)
            End Set
        End Property
        <DefaultValue(True)> Property BoostTradeable As Boolean
            Get
                Return mBoostTradeable
            End Get
            Set(value As Boolean)
                SetValue(mBoostTradeable, value)
            End Set
        End Property
        <DefaultValue(True)> Property BoostCombinable As Boolean
            Get
                Return mBoostCombinable
            End Get
            Set(value As Boolean)
                SetValue(mBoostCombinable, value)
            End Set
        End Property
        Property BoostAccountBound As Boolean
            Get
                Return mBoostAccountBound
            End Get
            Set(value As Boolean)
                SetValue(mBoostAccountBound, value)
            End Set
        End Property
        Property BoostBoostable As Boolean
            Get
                Return mBoostBoostable
            End Get
            Set(value As Boolean)
                SetValue(mBoostBoostable, value)
            End Set
        End Property
        Property BoostUsePlayerLevel As Boolean
            Get
                Return mBoostUsePlayerLevel
            End Get
            Set(value As Boolean)
                SetValue(mBoostUsePlayerLevel, value)
            End Set
        End Property
        Property BoostCatalystConversion As String
            Get
                Return mBoostCatalystConversion
            End Get
            Set(value As String)
                SetValue(mBoostCatalystConversion, value)
            End Set
        End Property
        Property StoreProduct As String
            Get
                Return mStoreProduct
            End Get
            Set(value As String)
                SetValue(mStoreProduct, value)
            End Set
        End Property
        <DefaultValue(999)> Property BoostLicenseLevel As Int32
            Get
                Return mBoostLicenseLevel
            End Get
            Set(value As Int32)
                SetValue(mBoostLicenseLevel, value)
            End Set
        End Property
        <DefaultValue(-3)> Property MinSlotLevel As Int32
            Get
                Return mMinSlotLevel
            End Get
            Set(value As Int32)
                SetValue(mMinSlotLevel, value)
            End Set
        End Property
        Property MaxSlotLevel As Int32
            Get
                Return mMaxSlotLevel
            End Get
            Set(value As Int32)
                SetValue(mMaxSlotLevel, value)
            End Set
        End Property
        Property MaxBoostLevel As Int32
            Get
                Return mMaxBoostLevel
            End Get
            Set(value As Int32)
                SetValue(mMaxBoostLevel, value)
            End Set
        End Property
        Property Var As COH_PowerVar()
            Get
                Return mVar
            End Get
            Set(value As COH_PowerVar())
                SetValue(mVar, value)
            End Set
        End Property
        Property ToggleDroppable As COH_Enum_ToggleDroppable
            Get
                Return mToggleDroppable
            End Get
            Set(value As COH_Enum_ToggleDroppable)
                SetValue(mToggleDroppable, value)
            End Set
        End Property
        Property StrengthsDisallowed As Int32()
            Get
                Return mStrengthsDisallowed
            End Get
            Set(value As Int32())
                SetValue(mStrengthsDisallowed, value)
            End Set
        End Property
        Property ProcMainTargetOnly As Boolean
            Get
                Return mProcMainTargetOnly
            End Get
            Set(value As Boolean)
                SetValue(mProcMainTargetOnly, value)
            End Set
        End Property
        Property AnimMainTargetOnly As Boolean
            Get
                Return mAnimMainTargetOnly
            End Get
            Set(value As Boolean)
                SetValue(mAnimMainTargetOnly, value)
            End Set
        End Property
        Property HighlightEval As String()
            Get
                Return mHighlightEval
            End Get
            Set(value As String())
                SetValue(mHighlightEval, value)
            End Set
        End Property
        Property HighlightIcon As String
            Get
                Return mHighlightIcon
            End Get
            Set(value As String)
                SetValue(mHighlightIcon, value)
            End Set
        End Property
        Property HighlightRing As COH_Color_RGBA
            Get
                Return mHighlightRing
            End Get
            Set(value As COH_Color_RGBA)
                SetValue(mHighlightRing, value)
            End Set
        End Property
        Property TravelSuppression As Single
            Get
                Return mTravelSuppression
            End Get
            Set(value As Single)
                SetValue(mTravelSuppression, value)
            End Set
        End Property
        <DefaultValue(1)> Property PreferenceMultiplier As Single
            Get
                Return mPreferenceMultiplier
            End Get
            Set(value As Single)
                SetValue(mPreferenceMultiplier, value)
            End Set
        End Property
        Property DontSetStance As Boolean
            Get
                Return mDontSetStance
            End Get
            Set(value As Boolean)
                SetValue(mDontSetStance, value)
            End Set
        End Property
        Property PointValue As Single
            Get
                Return mPointValue
            End Get
            Set(value As Single)
                SetValue(mPointValue, value)
            End Set
        End Property
        Property PointMultiplier As Single
            Get
                Return mPointMultiplier
            End Get
            Set(value As Single)
                SetValue(mPointMultiplier, value)
            End Set
        End Property
        <DefaultValue("NULL")> Property ChainIntoPower As String
            Get
                Return mChainIntoPower
            End Get
            Set(value As String)
                SetValue(mChainIntoPower, value)
            End Set
        End Property
        Property InstanceLocked As Boolean
            Get
                Return mInstanceLocked
            End Get
            Set(value As Boolean)
                SetValue(mInstanceLocked, value)
            End Set
        End Property
        Property IsEnvironmentHit As Boolean
            Get
                Return mIsEnvironmentHit
            End Get
            Set(value As Boolean)
                SetValue(mIsEnvironmentHit, value)
            End Set
        End Property
        Property ShuffleTargets As Boolean
            Get
                Return mShuffleTargets
            End Get
            Set(value As Boolean)
                SetValue(mShuffleTargets, value)
            End Set
        End Property
        <DefaultValue(-1)> Property ForceLevelBought As Int32
            Get
                Return mForceLevelBought
            End Get
            Set(value As Int32)
                SetValue(mForceLevelBought, value)
            End Set
        End Property
        Property RefreshesOnActivePlayerChange As Boolean
            Get
                Return mRefreshesOnActivePlayerChange
            End Get
            Set(value As Boolean)
                SetValue(mRefreshesOnActivePlayerChange, value)
            End Set
        End Property
        <COH_VersionRange(0, 6)> Property PowerRedirector As Boolean
            Get
                Return mPowerRedirector
            End Get
            Set(value As Boolean)
                SetValue(mPowerRedirector, value)
            End Set
        End Property
        Property Cancelable As Boolean
            Get
                Return mCancelable
            End Get
            Set(value As Boolean)
                SetValue(mCancelable, value)
            End Set
        End Property
        Property IgnoreToggleMaxDistance As Boolean
            Get
                Return mIgnoreToggleMaxDistance
            End Get
            Set(value As Boolean)
                SetValue(mIgnoreToggleMaxDistance, value)
            End Set
        End Property
        Property ServerTrayPriority As Int32
            Get
                Return mServerTrayPriority
            End Get
            Set(value As Int32)
                SetValue(mServerTrayPriority, value)
            End Set
        End Property
        Property AbusiveBuff As Boolean
            Get
                Return mAbusiveBuff
            End Get
            Set(value As Boolean)
                SetValue(mAbusiveBuff, value)
            End Set
        End Property
        Property PositionCenter As COH_Enum_ModTarget
            Get
                Return mPositionCenter
            End Get
            Set(value As COH_Enum_ModTarget)
                SetValue(mPositionCenter, value)
            End Set
        End Property
        Property PositionDistance As Single
            Get
                Return mPositionDistance
            End Get
            Set(value As Single)
                SetValue(mPositionDistance, value)
            End Set
        End Property
        Property PositionHeight As Single
            Get
                Return mPositionHeight
            End Get
            Set(value As Single)
                SetValue(mPositionHeight, value)
            End Set
        End Property
        Property PositionYaw As Single
            Get
                Return mPositionYaw
            End Get
            Set(value As Single)
                SetValue(mPositionYaw, value)
            End Set
        End Property
        Property FaceTarget As Boolean
            Get
                Return mFaceTarget
            End Get
            Set(value As Boolean)
                SetValue(mFaceTarget, value)
            End Set
        End Property
        Property VisualFX As String
            Get
                Return mVisualFX
            End Get
            Set(value As String)
                SetValue(mVisualFX, value)
            End Set
        End Property
        Property FX As COH_PowerFX
            Get
                Return mFX
            End Get
            Set(value As COH_PowerFX)
                SetValue(mFX, value)
            End Set
        End Property
        Property CustomFX As COH_PowerCustomFX()
            Get
                Return mCustomFX
            End Get
            Set(value As COH_PowerCustomFX())
                SetValue(mCustomFX, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Properties - i25 Score Specific"
        <COH_VersionRange(7)> Property ChainDelay As Single
            Get
                Return mChainDelay
            End Get
            Set(value As Single)
                SetValue(mChainDelay, value)
            End Set
        End Property
        <COH_VersionRange(7)> Property ChainEff As String()
            Get
                Return mChainEff
            End Get
            Set(value As String())
                SetValue(mChainEff, value)
            End Set
        End Property
        <COH_VersionRange(7)> Property ChainFork As Int32()
            Get
                Return mChainFork
            End Get
            Set(value As Int32())
                SetValue(mChainFork, value)
            End Set
        End Property
        <COH_VersionRange(7)> Property Redirect As COH_PowerRedirect()
            Get
                Return mRedirect
            End Get
            Set(value As COH_PowerRedirect())
                SetValue(mRedirect, value)
            End Set
        End Property
        <COH_VersionRange(7)> Property Effect As COH_PowerEffectGroup()
            Get
                Return mEffect
            End Get
            Set(value As COH_PowerEffectGroup())
                SetValue(mEffect, value)
            End Set
        End Property
        <COH_VersionRange(7)> Property ProcAllowed As COH_Enum_ProcAllowed
            Get
                Return mProcAllowed
            End Get
            Set(value As COH_Enum_ProcAllowed)
                SetValue(mProcAllowed, value)
            End Set
        End Property
        <COH_VersionRange(7)> Property ServerTrayRequires As String()
            Get
                Return mServerTrayRequires
            End Get
            Set(value As String())
                SetValue(mServerTrayRequires, value)
            End Set
        End Property
        <COH_VersionRange(7)> Property AttribCache As Int32()
            Get
                Return mAttribCache
            End Get
            Set(value As Int32())
                SetValue(mAttribCache, value)
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mFullName As String
       Private mCRCFullName As UInt32
       Private mSourceFile As String
       Private mName As String
       Private mSourceName As String
       Private mSystem As COH_Enum_PowerSystem
       Private mAutoIssue As Boolean
       Private mAutoIssueSaveLevel As Boolean
       Private mFree As Boolean
       Private mDisplayName As CrypticS_String
       Private mDisplayHelp As CrypticS_String
       Private mDisplayShortHelp As CrypticS_String
       Private mDisplayTargetHelp As CrypticS_String
       Private mDisplayTargetShortHelp As CrypticS_String
       Private mDisplayAttackerAttack As CrypticS_String
       Private mDisplayAttackerAttackFloater As CrypticS_String
       Private mDisplayAttackerHit As CrypticS_String
       Private mDisplayVictimHit As CrypticS_String
       Private mDisplayConfirm As CrypticS_String
       Private mFloatRewarded As CrypticS_String
       Private mDisplayPowerDefenseFloat As CrypticS_String
       Private mIconName As String
       Private mType As COH_Enum_PowerType
       Private mNumAllowed As Int32
       Private mAttackTypes As Int32()
       Private mBuyRequires As String()
       Private mActivateRequires As String()
       Private mSlotRequires As String()
       Private mTargetRequires As String()
       Private mRewardRequires As String()
       Private mAuctionRequires As String()
       Private mRewardFallback As String
       Private mAccuracy As Single
       Private mNearGround As Boolean
       Private mTargetNearGround As Boolean
       Private mCastableAfterDeath As COH_Enum_DeathCastableSetting
       Private mCastThroughHold As Boolean
       Private mCastThroughSleep As Boolean
       Private mCastThroughStun As Boolean
       Private mCastThroughTerrorize As Boolean
       Private mToggleIgnoreHold As Boolean
       Private mToggleIgnoreSleep As Boolean
       Private mToggleIgnoreStun As Boolean
       Private mIgnoreLevelBought As Boolean
       Private mShootThroughUntouchable As Boolean
       Private mInterruptLikeSleep As Boolean
       Private mAIReport As COH_Enum_AIReport
       Private mEffectArea As COH_Enum_EffectArea
       Private mMaxTargetsHit As Int32
       Private mRadius As Single
       Private mArc As Single
       Private mBoxOffset As COH_Struct_Vector3
       Private mBoxSize As COH_Struct_Vector3
       Private mRange As Single
       Private mRangeSecondary As Single
       Private mTimeToActivate As Single
       Private mRechargeTime As Single
       Private mActivatePeriod As Single
       Private mEnduranceCost As Single
       Private mIdeaCost As Single
       Private mTimeToConfirm As Int32
       Private mSelfConfirm As Int32
       Private mConfirmRequires As String()
       Private mDestroyOnLimit As Boolean
       Private mStackingUsage As Boolean
       Private mNumCharges As Int32
       Private mMaxNumCharges As Int32
       Private mUsageTime As Single
       Private mMaxUsageTime As Single
       Private mLifetime As Single
       Private mMaxLifetime As Single
       Private mLifetimeInGame As Single
       Private mMaxLifetimeInGame As Single
       Private mInterruptTime As Single
       Private mTargetVisibility As COH_Enum_TargetVisibility
       Private mTarget As COH_Enum_TargetType
       Private mTargetSecondary As COH_Enum_TargetType
       Private mEntsAutoHit As COH_Enum_TargetType()
       Private mEntsAffected As COH_Enum_TargetType()
       Private mTargetsThroughVisionPhase As Boolean
       Private mBoostsAllowed As Int32()
       Private mGroupMembership As Int32()
       Private mModesRequired As Int32()
       Private mModesDisallowed As Int32()
       Private mAIGroups As String()
       Private mIgnoreStrength As Boolean
       Private mShowBuffIcon As Boolean
       Private mShowInInventory As COH_Enum_ShowPowerSetting
       Private mShowInManage As Boolean
       Private mShowInInfo As Boolean
       Private mDeletable As Boolean
       Private mTradeable As Boolean
       Private mMaxBoosts As Int32
       Private mDoNotSave As Boolean
       Private mBoostIgnoreEffectiveness As Boolean
       Private mBoostAlwaysCountForSet As Boolean
       Private mBoostTradeable As Boolean
       Private mBoostCombinable As Boolean
       Private mBoostAccountBound As Boolean
       Private mBoostBoostable As Boolean
       Private mBoostUsePlayerLevel As Boolean
       Private mBoostCatalystConversion As String
       Private mStoreProduct As String
       Private mBoostLicenseLevel As Int32
       Private mMinSlotLevel As Int32
       Private mMaxSlotLevel As Int32
       Private mMaxBoostLevel As Int32
       Private mVar As COH_PowerVar()
       Private mToggleDroppable As COH_Enum_ToggleDroppable
       Private mStrengthsDisallowed As Int32()
       Private mProcMainTargetOnly As Boolean
       Private mAnimMainTargetOnly As Boolean
       Private mHighlightEval As String()
       Private mHighlightIcon As String
       Private mHighlightRing As COH_Color_RGBA
       Private mTravelSuppression As Single
       Private mPreferenceMultiplier As Single
       Private mDontSetStance As Boolean
       Private mPointValue As Single
       Private mPointMultiplier As Single
       Private mChainIntoPower As String
       Private mInstanceLocked As Boolean
       Private mIsEnvironmentHit As Boolean
       Private mShuffleTargets As Boolean
       Private mForceLevelBought As Int32
       Private mRefreshesOnActivePlayerChange As Boolean
       Private mCancelable As Boolean
       Private mIgnoreToggleMaxDistance As Boolean
       Private mServerTrayPriority As Int32
       Private mAbusiveBuff As Boolean
       Private mPositionCenter As COH_Enum_ModTarget
       Private mPositionDistance As Single
       Private mPositionHeight As Single
       Private mPositionYaw As Single
       Private mFaceTarget As Boolean
       Private mVisualFX As String
       Private mFX As COH_PowerFX
       Private mCustomFX As COH_PowerCustomFX()
        '//PARSE 7 REMOVED
       Private mAttribMod As COH_Power_AttributeMod()
       Private mPowerRedirector As Boolean
        '//PARSE 7 ADDITIONS
       Private mChainDelay As Single
       Private mChainEff As String()
       Private mChainFork As Int32()
       Private mRedirect As COH_PowerRedirect()
       Private mEffect As COH_PowerEffectGroup()
       Private mProcAllowed As COH_Enum_ProcAllowed
       Private mServerTrayRequires As String()
       Private mAttribCache As Int32()
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mFullName = String.Empty
            mSourceFile = String.Empty
            mName = String.Empty
            mSourceName = String.Empty
            mSystem = COH_Enum_PowerSystem.kPowerSystem_Powers
            mIconName = String.Empty
            mType = COH_Enum_PowerType.kPowerType_Click
            mAttackTypes = New Int32() {}
            mBuyRequires = New String() {}
            mActivateRequires = New String() {}
            mSlotRequires = New String() {}
            mTargetRequires = New String() {}
            mRewardRequires = New String() {}
            mAuctionRequires = New String() {}
            mRewardFallback = String.Empty
            mCastableAfterDeath = COH_Enum_DeathCastableSetting.kDeathCastableSetting_AliveOnly
            mAIReport = COH_Enum_AIReport.kAIReport_Always
            mEffectArea = COH_Enum_EffectArea.kEffectArea_Character
            mBoxOffset = New COH_Struct_Vector3()
            mBoxSize = New COH_Struct_Vector3()
            mConfirmRequires = New String() {}
            mTargetVisibility = COH_Enum_TargetVisibility.kTargetVisibility_LineOfSight
            mTarget = COH_Enum_TargetType.kTargetType_None
            mTargetSecondary = COH_Enum_TargetType.kTargetType_None
            mEntsAutoHit = New COH_Enum_TargetType() {} '0' No Default Defined
            mEntsAffected = New COH_Enum_TargetType() {} '0' No Default Defined
            mBoostsAllowed = New Int32() {}
            mGroupMembership = New Int32() {}
            mModesRequired = New Int32() {}
            mModesDisallowed = New Int32() {}
            mAIGroups = New String() {}
            mAttribMod = New COH_Power_AttributeMod() {}
            mShowInInventory = COH_Enum_ShowPowerSetting.kShowPowerSetting_Default
            mBoostCatalystConversion = String.Empty
            mStoreProduct = String.Empty
            mVar = New COH_PowerVar() {}
            mToggleDroppable = COH_Enum_ToggleDroppable.kToggleDroppable_Sometimes
            mStrengthsDisallowed = New Int32() {}
            mHighlightEval = New String() {}
            mHighlightIcon = String.Empty
            mHighlightRing = New [Shared].Drawing.COH_Color_RGBA
            mTravelSuppression = 0
            mPreferenceMultiplier = 1
            mDontSetStance = 0
            mPointValue = 0
            mPointMultiplier = 0
            mChainIntoPower = String.Empty
            mInstanceLocked = 0
            mIsEnvironmentHit = 0
            mShuffleTargets = 0
            mForceLevelBought = -1
            mRefreshesOnActivePlayerChange = 0
            mPowerRedirector = 0
            mCancelable = 0
            mIgnoreToggleMaxDistance = 0
            mServerTrayPriority = 0
            mAbusiveBuff = True
            mPositionCenter = COH_Enum_ModTarget.kModTarget_Caster
            mPositionDistance = 0.0F
            mPositionHeight = 0.0F
            mPositionYaw = 0.0F
            mFaceTarget = True
            mVisualFX = String.Empty
            mFX = New COH_PowerFX
            mCustomFX = New COH_PowerCustomFX() {}
            If Version = 0 Or Version >= 7 Then
                '//I25 SCORE
                mChainDelay = 0
                mChainEff = New String() {}
                mChainFork = New Int32() {}
                mRedirect = New COH_PowerRedirect() {}
                mEffect = New COH_PowerEffectGroup() {}
                mProcAllowed = COH_Enum_ProcAllowed.kProcAllowed_All
                mServerTrayRequires = New String() {}
                mAttribCache = New Int32() {}
            End If
        End Sub
#End Region

#Region "Validation"
        Public Function CheckValid_CRC32c(Optional ByRef Result As String = "") As Boolean
            Dim Value As UInt32 = Create_CRC32c()
            Result = Value.ToString("X8")
            If Convert.ToUInt32(mCRCFullName) = Value Then Return True
            Return False
        End Function
        Public Function Create_CRC32c() As UInt32
            Dim Result As UInt32 = HelperFunctions.Cryptic.Calculate_CRC32(mFullName.ToLower, HelperFunctions.Cryptic.COH_CRC32_Functions.CRC32_Method.Cryptic)
            Return Result
        End Function
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Power
            Dim Result As COH_Power = New COH_Power
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mFullName = CloneString(mFullName)
                .mCRCFullName = mCRCFullName
                .mSourceFile = CloneString(mSourceFile)
                .mName = CloneString(mName)
                .mSourceName = CloneString(mSourceName)
                .mSystem = mSystem
                .mAutoIssue = mAutoIssue
                .mAutoIssueSaveLevel = mAutoIssueSaveLevel
                .mFree = mFree
                .mDisplayName = mDisplayName.Clone
                .mDisplayHelp = mDisplayHelp.Clone
                .mDisplayShortHelp = mDisplayShortHelp.Clone
                .mDisplayTargetHelp = mDisplayTargetHelp.Clone
                .mDisplayTargetShortHelp = mDisplayTargetShortHelp.Clone
                .mDisplayAttackerAttack = mDisplayAttackerAttack.Clone
                .mDisplayAttackerAttackFloater = mDisplayAttackerAttackFloater.Clone
                .mDisplayAttackerHit = mDisplayAttackerHit.Clone
                .mDisplayVictimHit = mDisplayVictimHit.Clone
                .mDisplayConfirm = mDisplayConfirm.Clone
                .mFloatRewarded = mFloatRewarded.Clone
                .mDisplayPowerDefenseFloat = mDisplayPowerDefenseFloat.Clone
                .mIconName = CloneString(mIconName)
                .mType = mType
                .mNumAllowed = mNumAllowed
                .mAttackTypes = New Int32(mAttackTypes.Count - 1) {} : mAttackTypes.CopyTo(.mAttackTypes, 0)
                .mBuyRequires = CloneStrings(mBuyRequires)
                .mActivateRequires = CloneStrings(mActivateRequires)
                .mSlotRequires = CloneStrings(mSlotRequires)
                .mTargetRequires = CloneStrings(mTargetRequires)
                .mRewardRequires = CloneStrings(mRewardRequires)
                .mAuctionRequires = CloneStrings(mAuctionRequires)
                .mRewardFallback = CloneString(mRewardFallback)
                .mAccuracy = mAccuracy
                .mNearGround = mNearGround
                .mTargetNearGround = mTargetNearGround
                .mCastableAfterDeath = mCastableAfterDeath
                .mCastThroughHold = mCastThroughHold
                .mCastThroughSleep = mCastThroughSleep
                .mCastThroughStun = mCastThroughStun
                .mCastThroughTerrorize = mCastThroughTerrorize
                .mToggleIgnoreHold = mToggleIgnoreHold
                .mToggleIgnoreSleep = mToggleIgnoreSleep
                .mToggleIgnoreStun = mToggleIgnoreStun
                .mIgnoreLevelBought = mIgnoreLevelBought
                .mShootThroughUntouchable = mShootThroughUntouchable
                .mInterruptLikeSleep = mInterruptLikeSleep
                .mAIReport = mAIReport
                .mEffectArea = mEffectArea
                .mMaxTargetsHit = mMaxTargetsHit
                .mRadius = mRadius
                .mArc = mArc
                .mBoxOffset = mBoxOffset
                .mBoxSize = mBoxSize
                .mRange = mRange
                .mRangeSecondary = mRangeSecondary
                .mTimeToActivate = mTimeToActivate
                .mRechargeTime = mRechargeTime
                .mActivatePeriod = mActivatePeriod
                .mEnduranceCost = mEnduranceCost
                .mIdeaCost = mIdeaCost
                .mTimeToConfirm = mTimeToConfirm
                .mSelfConfirm = mSelfConfirm
                .mConfirmRequires = CloneStrings(mConfirmRequires)
                .mDestroyOnLimit = mDestroyOnLimit
                .mStackingUsage = mStackingUsage
                .mNumCharges = mNumCharges
                .mMaxNumCharges = mMaxNumCharges
                .mUsageTime = mUsageTime
                .mMaxUsageTime = mMaxUsageTime
                .mLifetime = mLifetime
                .mMaxLifetime = mMaxLifetime
                .mLifetimeInGame = mLifetimeInGame
                .mMaxLifetimeInGame = mMaxLifetimeInGame
                .mInterruptTime = mInterruptTime
                .mTargetVisibility = mTargetVisibility
                .mTarget = mTarget
                .mTargetSecondary = mTargetSecondary
                .mEntsAutoHit = New COH_Enum_TargetType(mEntsAutoHit.Count - 1) {} : mEntsAutoHit.CopyTo(.mEntsAutoHit, 0)
                .mEntsAffected = New COH_Enum_TargetType(mEntsAffected.Count - 1) {} : mEntsAffected.CopyTo(.mEntsAffected, 0)
                .mTargetsThroughVisionPhase = mTargetsThroughVisionPhase
                .mBoostsAllowed = New Int32(mBoostsAllowed.Count - 1) {} : mBoostsAllowed.CopyTo(.mBoostsAllowed, 0)
                .mGroupMembership = New Int32(mGroupMembership.Count - 1) {} : mGroupMembership.CopyTo(.mGroupMembership, 0)
                .mModesRequired = New Int32(mModesRequired.Count - 1) {} : mModesRequired.CopyTo(.mModesRequired, 0)
                .mModesDisallowed = New Int32(mModesDisallowed.Count - 1) {} : mModesDisallowed.CopyTo(.mModesDisallowed, 0)
                .mAIGroups = CloneStrings(mAIGroups)
                .mAttribMod = New COH_Power_AttributeMod(mAttribMod.Count - 1) {}
                For X = 0 To mAttribMod.Count - 1
                    .mAttribMod(X) = mAttribMod(X).Clone
                Next
                .mIgnoreStrength = mIgnoreStrength
                .mShowBuffIcon = mShowBuffIcon
                .mShowInInventory = mShowInInventory
                .mShowInManage = mShowInManage
                .mShowInInfo = mShowInInfo
                .mDeletable = mDeletable
                .mTradeable = mTradeable
                .mMaxBoosts = mMaxBoosts
                .mDoNotSave = mDoNotSave
                .mBoostIgnoreEffectiveness = mBoostIgnoreEffectiveness
                .mBoostAlwaysCountForSet = mBoostAlwaysCountForSet
                .mBoostTradeable = mBoostTradeable
                .mBoostCombinable = mBoostCombinable
                .mBoostAccountBound = mBoostAccountBound
                .mBoostBoostable = mBoostBoostable
                .mBoostUsePlayerLevel = mBoostUsePlayerLevel
                .mBoostCatalystConversion = CloneString(mBoostCatalystConversion)
                .mStoreProduct = CloneString(mStoreProduct)
                .mBoostLicenseLevel = mBoostLicenseLevel
                .mMinSlotLevel = mMinSlotLevel
                .mMaxSlotLevel = mMaxSlotLevel
                .mMaxBoostLevel = mMaxBoostLevel
                .mVar = New COH_PowerVar(mVar.Count - 1) {}
                For X = 0 To mVar.Count - 1
                    .mVar(X) = mVar(X).Clone
                Next
                .mToggleDroppable = mToggleDroppable
                .mStrengthsDisallowed = New Int32(mStrengthsDisallowed.Count - 1) {} : mStrengthsDisallowed.CopyTo(.mStrengthsDisallowed, 0)
                .mProcMainTargetOnly = mProcMainTargetOnly
                .mAnimMainTargetOnly = mAnimMainTargetOnly
                .mHighlightEval = CloneStrings(mHighlightEval)
                .mHighlightIcon = CloneString(mHighlightIcon)
                .mHighlightRing = mHighlightRing
                .mTravelSuppression = mTravelSuppression
                .mPreferenceMultiplier = mPreferenceMultiplier
                .mDontSetStance = mDontSetStance
                .mPointValue = mPointValue
                .mPointMultiplier = mPointMultiplier
                .mChainIntoPower = CloneString(mChainIntoPower)
                .mInstanceLocked = mInstanceLocked
                .mIsEnvironmentHit = mIsEnvironmentHit
                .mShuffleTargets = mShuffleTargets
                .mForceLevelBought = mForceLevelBought
                .mRefreshesOnActivePlayerChange = mRefreshesOnActivePlayerChange
                .mPowerRedirector = mPowerRedirector
                .mCancelable = mCancelable
                .mIgnoreToggleMaxDistance = mIgnoreToggleMaxDistance
                .mServerTrayPriority = mServerTrayPriority
                .mAbusiveBuff = mAbusiveBuff
                .mPositionCenter = mPositionCenter
                .mPositionDistance = mPositionDistance
                .mPositionHeight = mPositionHeight
                .mPositionYaw = mPositionYaw
                .mFaceTarget = mFaceTarget
                .mVisualFX = CloneString(mVisualFX)
                .mFX = mFX.Clone
                .mCustomFX = New COH_PowerCustomFX(mCustomFX.Count - 1) {}
                For X = 0 To mCustomFX.Count - 1
                    .mCustomFX(X) = mCustomFX(X).Clone
                Next
                '//PARSE 7 SPECIFIC
                .mChainDelay = mChainDelay
                .mChainEff = CloneStrings(mChainEff)
                .mChainFork = New Int32(mChainFork.Count - 1) {} : mChainFork.CopyTo(.mChainFork, 0)
                .mRedirect = New COH_PowerRedirect(mRedirect.Count - 1) {}
                For X = 0 To mRedirect.Count - 1
                    .mRedirect(X) = mRedirect(X).Clone
                Next
                .mEffect = New COH_PowerEffectGroup(mEffect.Count - 1) {}
                For X = 0 To mEffect.Count - 1
                    .mEffect(X) = mEffect(X).Clone
                Next
                .mProcAllowed = mProcAllowed
                .mServerTrayRequires = CloneStrings(mServerTrayRequires)
                .mAttribCache = New Int32(mAttribCache.Count - 1) {} : mAttribCache.CopyTo(.mAttribCache, 0)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export -XML"
        Public Overrides Function Default_CrypricSExtention() As String
            Return "POWERS"
        End Function
        Public Overrides Function Retrieve_OriginolSourceReference() As String
            Return mSourceFile
        End Function
        Public Overrides Function Retrieve_LookupName() As String
            Return mFullName
        End Function
        Public Overrides Function Determine_DefaultRelativeFilePath(Format As COH_ExportFormat, Optional ShortenPath As Boolean = True) As String
            If Format = COH_ExportFormat.XML Then
                Dim SubFolder As String = Identify_SubFolder()
                Dim AdjustedPath As String = Identify_SubFolder2(SubFolder) & ".xml"
                AdjustedPath = AdjustedPath.Replace("/", "\")

                If AdjustedPath.Contains("Boosts") Then AdjustedPath = AdjustedPath
                Dim Folderpath As String = IO.Path.GetDirectoryName(AdjustedPath) & "\"
                Dim FileName As String = IO.Path.GetFileName(AdjustedPath).Replace(".xml", "")

                Dim EndLine As String = Folderpath.Substring(Folderpath.Length - 3, 3)
                Dim EndLine2 As String = Folderpath.Substring(Folderpath.Length - 4, 4)
                Dim CombinePaths As String = "_A\_B\_C\_D\_E\_F\_G\_H\_I\_J\_1\_2\_3\_4\_5\_6\_7\_8\_9\"
                Dim CombinePaths4 As String = "_10\_11\_12\"
                If CombinePaths4.Contains(EndLine) Then
                    Folderpath = Folderpath.Substring(0, Folderpath.Length - 4) & "\"
                    EndLine = EndLine.Replace("\", "")
                    FileName = FileName & EndLine
                    If FileName.Contains(EndLine) = False Then FileName = FileName & EndLine
                ElseIf CombinePaths.Contains(EndLine) Then
                    Folderpath = Folderpath.Substring(0, Folderpath.Length - 3) & "\"
                    EndLine = EndLine.Replace("\", "")
                    If FileName.Contains(EndLine) = False Then FileName = FileName & EndLine
                End If
                Dim FullPath = Folderpath & FileName & ".xml"
                Return FullPath
            ElseIf Format = COH_ExportFormat.CrypticS_TextFormat Then
                Dim PathAddition As String = ""
                If ShortenPath = True Then
                    PathAddition = mFullName.Replace(".", "\")
                Else
                    PathAddition = mFullName
                End If
                Return PathAddition & "." & Default_CrypricSExtention()
            Else
                Return MyBase.Determine_DefaultRelativeFilePath(Format)
            End If
        End Function
        Private Function Identify_SubFolder2(ByRef SubFolder As String) As String
            Dim NewPath As String = SubFolder & mFullName.Replace(".", "\")
            If NewPath.Contains("Base\Base") Then Return NewPath.Replace("Base\Base\", "Base\")
            If NewPath.Contains("Boosts\Boosts") Then Return NewPath.Replace("Boosts\Boosts\", "Boosts\")
            If NewPath.Contains("Epic\Epic") Then Return NewPath.Replace("Epic\Epic\", "Epic\")
            If NewPath.Contains("Inherent\Inherent") Then Return NewPath.Replace("Inherent\Inherent\", "Inherent\")
            If NewPath.Contains("Inspirations\Inspirations") Then Return NewPath.Replace("Inspirations\Inspirations\", "Inspirations\")
            If NewPath.Contains("Objects\Objects") Then Return NewPath.Replace("Objects\Objects\", "Objects\")
            If NewPath.Contains("Pool\Pool") Then Return NewPath.Replace("Pool\Pool\", "Pool\")
            If NewPath.Contains("Set_Bonus\Set_Bonus") Then Return NewPath.Replace("Set_Bonus\Set_Bonus\", "Set_Bonus\")
            If NewPath.Contains("Set_Bonus\PVP_Set_Bonus") Then Return NewPath.Replace("Set_Bonus\PVP_Set_Bonus\", "")
            If NewPath.Contains("Team\Teamwork") Then Return NewPath.Replace("Team\Teamwork\", "Team\")
            If NewPath.Contains("Temporary\Temporary_Powers") Then Return NewPath.Replace("Temporary\Temporary_Powers\", "Temporary\")
            If NewPath.Contains("Weapons\Guns") Then Return NewPath.Replace("Weapons\Guns\", "Weapons\")
            Return NewPath
        End Function
        Private Function Identify_SubFolder() As String
            Dim NewPath As String = mSourceFile.Replace("DEFS/POWERS", "")
            If NewPath.Contains("/INHERENT_") Then Return "Inherent\"
            If NewPath.Contains("/GENERIC_") Then Return "Generic\"
            If NewPath.Contains("/GENERICVILLAINS_") Then Return "Generic\"
            If NewPath.Contains("/BASE_") Then Return "Base\"
            If NewPath.Contains("/ITEMS_OF_POWER_") Then Return "Base\"
            If NewPath.Contains("/EPIC") Then Return "Epic\"
            If NewPath.Contains("/POOL") Then Return "Pool\"
            If NewPath.Contains("/TEAMWORK_") Then Return "Team\"
            If NewPath.Contains("/TEMPORARY_") Then Return "Temporary\"
            If NewPath.Contains("/INCARNATE_") Then Return "Incarnate\"

            If NewPath.Contains("/EVENT") Then Return "Event\"
            If NewPath.Contains("/SUMMEREVENT_") Then Return "Event\"
            If NewPath.Contains("/HALLOWEEN_") Then Return "Event\"
            If NewPath.Contains("/PALADINEVENT_") Then Return "Event\"

            If NewPath.Contains("/INSPIRATIONS_") Then Return "Inspirations\"
            If NewPath.Contains("/OBJECTS_") Then Return "Objects\"

            If NewPath.Contains("/BLASTER_") Then Return "Player\"
            If NewPath.Contains("/CONTROLLER_") Then Return "Player\"
            If NewPath.Contains("/DEFENDER_") Then Return "Player\"
            If NewPath.Contains("/TANKER_") Then Return "Player\"
            If NewPath.Contains("/MASTERMIND_") Then Return "Player\"
            If NewPath.Contains("/KHELDIAN_") Then Return "Player\"
            If NewPath.Contains("/NICTUS_") Then Return "Player\"
            If NewPath.Contains("/PEACEBRINGER_") Then Return "Player\"
            If NewPath.Contains("/SCRAPPER_") Then Return "Player\"
            If NewPath.Contains("/WARSHADE_") Then Return "Player\"

            If NewPath.Contains("/BRUTE_") Then Return "Player Villain\"
            If NewPath.Contains("/CORRUPTOR_") Then Return "Player Villain\"
            If NewPath.Contains("/DOMINATOR_") Then Return "Player Villain\"
            If NewPath.Contains("/STALKER_") Then Return "Player Villain\"

            If NewPath.Contains("/DILEMMADIABOLIQUE_") Then Return "Enemies Unique\"
            If NewPath.Contains("/MAGISTERIUM_") Then Return "Enemies Unique\"
            If NewPath.Contains("/ROGUESGALLERY_") Then Return "Enemies Unique\"
            If NewPath.Contains("/SIGNATURE_SUMMON_") Then Return "Enemies Unique\"
            If NewPath.Contains("/TROLLS_ATTA_") Then Return "Enemies Unique\"

            If NewPath.Contains("/CROATOAMISSIONS_") Then Return "Enemies Missions\"
            If NewPath.Contains("/HELLIONSEWERTRIAL_") Then Return "Enemies Missions\"
            If NewPath.Contains("/HYDRASEWERTRIAL_") Then Return "Enemies Missions\"
            If NewPath.Contains("/LOSTSEWERTRIAL_") Then Return "Enemies Missions\"
            If NewPath.Contains("/MISSION_") Then Return "Enemies Missions\"
            If NewPath.Contains("_TUTORIAL_") Then Return "Enemies Missions\"
            If NewPath.Contains("/ONEWILLDIE_") Then Return "Enemies Missions\"
            If NewPath.Contains("/PANDORASBOX_") Then Return "Enemies Missions\"
            If NewPath.Contains("/TERRAVOLTA_") Then Return "Enemies Missions\"
            If NewPath.Contains("/TPNCAMPUS_") Then Return "Enemies Missions\"
            If NewPath.Contains("/VAHZSEWERTRIAL_") Then Return "Enemies Missions\"

            If NewPath.Contains("/NPC_PETS_") Then Return "Pets\"
            If NewPath.Contains("/PETS_") Then Return "Pets\"
            If NewPath.Contains("/VILLAIN_PETS_") Then Return "Pets\"

            If NewPath.Contains("/ONGOINGTRAININGCHARACTERS_") Then Return "Other\"
            If NewPath.Contains("/PORTAL_") Then Return "Other\"
            If NewPath.Contains("/PRACTICEROBOTS_") Then Return "Other\"
            If NewPath.Contains("/TRAINING_GADGETS") Then Return "Other\"
            If NewPath.Contains("/WIDOW_TRAINING_") Then Return "Other\"

            If NewPath.Contains("/5THCOLUMN_") Then Return "Enemies\"
            If NewPath.Contains("/ANIMUSARCANA_") Then Return "Enemies\"
            If NewPath.Contains("/APPARITIONS_") Then Return "Enemies\"
            If NewPath.Contains("/ARACHNOS_") Then Return "Enemies\"
            If NewPath.Contains("/AWAKENED_") Then Return "Enemies\"
            If NewPath.Contains("/BANISHEDPANTHEON_") Then Return "Enemies\"
            If NewPath.Contains("/BLACKKNIGHTS_") Then Return "Enemies\"
            If NewPath.Contains("/CABAL_") Then Return "Enemies\"
            If NewPath.Contains("/CARNIVAL_") Then Return "Enemies\"
            If NewPath.Contains("/CARNIVALOFLIGHT_") Then Return "Enemies\"
            If NewPath.Contains("/CIRCLEOFTHORNS_") Then Return "Enemies\"
            If NewPath.Contains("/CLOCKWORK_") Then Return "Enemies\"
            If NewPath.Contains("/COUNCIL_") Then Return "Enemies\"
            If NewPath.Contains("/COUNCILEMPIRE_") Then Return "Enemies\"
            If NewPath.Contains("/CREY_") Then Return "Enemies\"
            If NewPath.Contains("/CROATOAGHOSTS_") Then Return "Enemies\"
            If NewPath.Contains("/DESTROYERS_") Then Return "Enemies\"
            If NewPath.Contains("/DEVOURINGEARTH_") Then Return "Enemies\"
            If NewPath.Contains("/DEVOURINGEARTHSEED_") Then Return "Enemies\"
            If NewPath.Contains("/DREGS_") Then Return "Enemies\"
            If NewPath.Contains("/DRUDGES_") Then Return "Enemies\"
            If NewPath.Contains("/FAMILY_") Then Return "Enemies\"
            If NewPath.Contains("/FERAL_") Then Return "Enemies\"
            If NewPath.Contains("/FIRBOLG_") Then Return "Enemies\"
            If NewPath.Contains("/FORLORN_") Then Return "Enemies\"
            If NewPath.Contains("/FREAKSHOW_") Then Return "Enemies\"
            If NewPath.Contains("/HELLIONS_") Then Return "Enemies\"
            If NewPath.Contains("/HYDRA_") Then Return "Enemies\"
            If NewPath.Contains("/IGNEOUS_") Then Return "Enemies\"
            If NewPath.Contains("/KNIVESOFVENGEANCE_") Then Return "Enemies\"
            If NewPath.Contains("/MALTA_") Then Return "Enemies\"
            If NewPath.Contains("/MIDNIGHT_") Then Return "Enemies\"
            If NewPath.Contains("/MIDNIGHTMASTERS_") Then Return "Enemies\"
            If NewPath.Contains("/MINDSOFMAYHEM_") Then Return "Enemies\"
            If NewPath.Contains("/NEMESIS_") Then Return "Enemies\"
            If NewPath.Contains("/NEWPRAETORIANS_") Then Return "Enemies\"
            If NewPath.Contains("/NIGHTSTALKERS_") Then Return "Enemies\"
            If NewPath.Contains("/NPC_") Then Return "Enemies\"
            If NewPath.Contains("/OUTCASTS_") Then Return "Enemies\"
            If NewPath.Contains("/PRISONERS_") Then Return "Enemies\"
            If NewPath.Contains("/REDCAPS_") Then Return "Enemies\"
            If NewPath.Contains("/RIKTI_") Then Return "Enemies\"
            If NewPath.Contains("/ROMANS_") Then Return "Enemies\"
            If NewPath.Contains("/RULARUU_") Then Return "Enemies\"
            If NewPath.Contains("/RULUSHINPOWERS_") Then Return "Enemies\"
            If NewPath.Contains("/SKULLS_") Then Return "Enemies\"
            If NewPath.Contains("/SKYRAIDERS_") Then Return "Enemies\"
            If NewPath.Contains("/SYNDICATE_") Then Return "Enemies\"
            If NewPath.Contains("/TALONSOFVENGEANCE_") Then Return "Enemies\"
            If NewPath.Contains("/TROLLS_") Then Return "Enemies\"
            If NewPath.Contains("/TSOO_") Then Return "Enemies\"
            If NewPath.Contains("/TUATHA_") Then Return "Enemies\"
            If NewPath.Contains("/TURRETS_") Then Return "Enemies\"
            If NewPath.Contains("/UNIFIEDPEOPLESARMY_") Then Return "Enemies\"
            If NewPath.Contains("/UNSEELIE_") Then Return "Enemies\"
            If NewPath.Contains("/VAHZILOK_") Then Return "Enemies\"
            If NewPath.Contains("/VANGUARD_") Then Return "Enemies\"
            If NewPath.Contains("/WARRIORS_") Then Return "Enemies\"
            If NewPath.Contains("/WISDOM_") Then Return "Enemies\"
            If NewPath.Contains("/WISPS_") Then Return "Enemies\"
            If NewPath.Contains("/ZOMBIES_") Then Return "Enemies\"

            If NewPath.Contains("/PRIMAL_") Then Return "Enemies\"
            If NewPath.Contains("/PRIMALIST_") Then Return "Enemies\"

            If NewPath.Contains("/P_CITIZEN") Then Return "Enemies Praetoria\"
            If NewPath.Contains("/P_GHOULS") Then Return "Enemies Praetoria\"
            If NewPath.Contains("/P_") Then Return "Enemies Praetoria\"
            If NewPath.Contains("/PRAETORIANCLOCKWORK") Then Return "Enemies Praetoria\"
            If NewPath.Contains("/PRAETORIANIDF") Then Return "Enemies Praetoria\"
            If NewPath.Contains("/PRAETORIANPOLICE") Then Return "Enemies Praetoria\"
            If NewPath.Contains("/PRAETORIANRESISTANCE") Then Return "Enemies Praetoria\"
            If NewPath.Contains("/PRAETORIANS") Then Return "Enemies Praetoria\"

            If NewPath.Contains("/V_") Then Return "Enemies Villain\"


            If NewPath.Contains("/GUNS_") Then Return "Weapons\"
            If NewPath.Contains("_PVP_") Then Return "Set Bonus (PVP)\"
            If NewPath.Contains("SET_BONUS_") Then Return "Set Bonus\"
            If NewPath.Contains("BOOSTS_") Then Return "Boosts\"

            Return "Enemies\"
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mFullName)
            CurrentWriter.Write(mCRCFullName)
            CurrentWriter.Write_CrypticS_String(mSourceFile)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mSourceName)
            CurrentWriter.Write(CInt(mSystem))
            CurrentWriter.Write_CrypticS_Boolean(mAutoIssue)
            CurrentWriter.Write_CrypticS_Boolean(mAutoIssueSaveLevel)
            CurrentWriter.Write_CrypticS_Boolean(mFree)
            mDisplayName.Export_To_Stream(CurrentWriter)
            mDisplayHelp.Export_To_Stream(CurrentWriter)
            mDisplayShortHelp.Export_To_Stream(CurrentWriter)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mDisplayCasterHelp)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mDisplayCasterShortHelp)
            mDisplayTargetHelp.Export_To_Stream(CurrentWriter)
            mDisplayTargetShortHelp.Export_To_Stream(CurrentWriter)
            mDisplayAttackerAttack.Export_To_Stream(CurrentWriter)
            mDisplayAttackerAttackFloater.Export_To_Stream(CurrentWriter)
            mDisplayAttackerHit.Export_To_Stream(CurrentWriter)
            mDisplayVictimHit.Export_To_Stream(CurrentWriter)
            mDisplayConfirm.Export_To_Stream(CurrentWriter)
            mFloatRewarded.Export_To_Stream(CurrentWriter)
            mDisplayPowerDefenseFloat.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_String(mIconName)
            '!!IGNORED!! mFXName)
            CurrentWriter.Write(CInt(mType))
            CurrentWriter.Write(mNumAllowed)
            CurrentWriter.Write_CrypticS_IntegerArray(mAttackTypes)
            CurrentWriter.Write_CrypticS_StringArray(mBuyRequires)
            CurrentWriter.Write_CrypticS_StringArray(mActivateRequires)
            CurrentWriter.Write_CrypticS_StringArray(mSlotRequires)
            CurrentWriter.Write_CrypticS_StringArray(mTargetRequires)
            CurrentWriter.Write_CrypticS_StringArray(mRewardRequires)
            CurrentWriter.Write_CrypticS_StringArray(mAuctionRequires)
            CurrentWriter.Write_CrypticS_String(mRewardFallback)
            CurrentWriter.Write(mAccuracy)
            CurrentWriter.Write_CrypticS_Boolean(mNearGround)
            CurrentWriter.Write_CrypticS_Boolean(mTargetNearGround)
            CurrentWriter.Write(CInt(mCastableAfterDeath))
            CurrentWriter.Write_CrypticS_Boolean(mCastThroughHold)
            CurrentWriter.Write_CrypticS_Boolean(mCastThroughSleep)
            CurrentWriter.Write_CrypticS_Boolean(mCastThroughStun)
            CurrentWriter.Write_CrypticS_Boolean(mCastThroughTerrorize)
            CurrentWriter.Write_CrypticS_Boolean(mToggleIgnoreHold)
            CurrentWriter.Write_CrypticS_Boolean(mToggleIgnoreSleep)
            CurrentWriter.Write_CrypticS_Boolean(mToggleIgnoreStun)
            CurrentWriter.Write_CrypticS_Boolean(mIgnoreLevelBought)
            CurrentWriter.Write_CrypticS_Boolean(mShootThroughUntouchable)
            CurrentWriter.Write_CrypticS_Boolean(mInterruptLikeSleep)
            CurrentWriter.Write(CInt(mAIReport))
            CurrentWriter.Write(CInt(mEffectArea))
            CurrentWriter.Write(mMaxTargetsHit)
            CurrentWriter.Write(mRadius)
            CurrentWriter.Write(mArc)

            If CurrentWriter.Settings.Option_Version >= 7 Then
                CurrentWriter.Write(mChainDelay)
                CurrentWriter.Write_CrypticS_StringArray(mChainEff)
                CurrentWriter.Write_CrypticS_IntegerArray(mChainFork)
            End If

            CurrentWriter.Write_CrypticS_Vector3(mBoxOffset)
            CurrentWriter.Write_CrypticS_Vector3(mBoxSize)
            CurrentWriter.Write(mRange)
            CurrentWriter.Write(mRangeSecondary)
            CurrentWriter.Write(mTimeToActivate)
            CurrentWriter.Write(mRechargeTime)
            CurrentWriter.Write(mActivatePeriod)
            CurrentWriter.Write(mEnduranceCost)
            '!!REDUNDENT!!CurrentWriter.Write(mInsightCost)
            CurrentWriter.Write(mIdeaCost)
            CurrentWriter.Write(mTimeToConfirm)
            CurrentWriter.Write(mSelfConfirm)
            CurrentWriter.Write_CrypticS_StringArray(mConfirmRequires)
            CurrentWriter.Write_CrypticS_Boolean(mDestroyOnLimit)
            CurrentWriter.Write_CrypticS_Boolean(mStackingUsage)
            CurrentWriter.Write(mNumCharges)
            CurrentWriter.Write(mMaxNumCharges)
            CurrentWriter.Write(mUsageTime)
            CurrentWriter.Write(mMaxUsageTime)
            CurrentWriter.Write(mLifetime)
            CurrentWriter.Write(mMaxLifetime)
            CurrentWriter.Write(mLifetimeInGame)
            CurrentWriter.Write(mMaxLifetimeInGame)
            CurrentWriter.Write(mInterruptTime)
            CurrentWriter.Write(CInt(mTargetVisibility))
            CurrentWriter.Write(CInt(mTarget))
            CurrentWriter.Write(CInt(mTargetSecondary))
            CurrentWriter.Write_CrypticS_IntegerArray(mEntsAutoHit)
            CurrentWriter.Write_CrypticS_IntegerArray(mEntsAffected)
            CurrentWriter.Write_CrypticS_Boolean(mTargetsThroughVisionPhase)
            CurrentWriter.Write_CrypticS_IntegerArray(mBoostsAllowed)
            CurrentWriter.Write_CrypticS_IntegerArray(mGroupMembership)
            CurrentWriter.Write_CrypticS_IntegerArray(mModesRequired)
            CurrentWriter.Write_CrypticS_IntegerArray(mModesDisallowed)
            CurrentWriter.Write_CrypticS_StringArray(mAIGroups)

            If CurrentWriter.Settings.Option_Version <= 6 Then If CurrentWriter.Write_CrypticS_StructArray(mAttribMod) = False Then Return False
            If CurrentWriter.Settings.Option_Version >= 7 Then
                If CurrentWriter.Write_CrypticS_StructArray(mRedirect) = False Then Return False
                If CurrentWriter.Write_CrypticS_StructArray(mEffect) = False Then Return False
            End If

            CurrentWriter.Write_CrypticS_Boolean(mIgnoreStrength)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_Boolean(mIgnoreStr)
            CurrentWriter.Write_CrypticS_Boolean(mShowBuffIcon)
            CurrentWriter.Write(CInt(mShowInInventory))
            CurrentWriter.Write_CrypticS_Boolean(mShowInManage)
            CurrentWriter.Write_CrypticS_Boolean(mShowInInfo)
            CurrentWriter.Write_CrypticS_Boolean(mDeletable)
            CurrentWriter.Write_CrypticS_Boolean(mTradeable)
            CurrentWriter.Write(mMaxBoosts)
            CurrentWriter.Write_CrypticS_Boolean(mDoNotSave)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_Boolean(mDoesNotExpire)
            CurrentWriter.Write_CrypticS_Boolean(mBoostIgnoreEffectiveness)
            CurrentWriter.Write_CrypticS_Boolean(mBoostAlwaysCountForSet)
            CurrentWriter.Write_CrypticS_Boolean(mBoostTradeable)
            CurrentWriter.Write_CrypticS_Boolean(mBoostCombinable)
            CurrentWriter.Write_CrypticS_Boolean(mBoostAccountBound)
            CurrentWriter.Write_CrypticS_Boolean(mBoostBoostable)
            CurrentWriter.Write_CrypticS_Boolean(mBoostUsePlayerLevel)
            CurrentWriter.Write_CrypticS_String(mBoostCatalystConversion)
            CurrentWriter.Write_CrypticS_String(mStoreProduct)
            CurrentWriter.Write(mBoostLicenseLevel)
            CurrentWriter.Write(mMinSlotLevel)
            CurrentWriter.Write(mMaxSlotLevel)
            CurrentWriter.Write(mMaxBoostLevel)
            If CurrentWriter.Write_CrypticS_StructArray(mVar) = False Then Return False
            CurrentWriter.Write(CInt(mToggleDroppable))
            '!!REDUNDENT!!CurrentWriter.Write(Cint(mTogglesDroppable)

            If CurrentWriter.Settings.Option_Version >= 7 Then CurrentWriter.Write(CInt(mProcAllowed))

            CurrentWriter.Write_CrypticS_IntegerArray(mStrengthsDisallowed)
            CurrentWriter.Write_CrypticS_Boolean(mProcMainTargetOnly)
            CurrentWriter.Write_CrypticS_Boolean(mAnimMainTargetOnly)
            CurrentWriter.Write_CrypticS_StringArray(mHighlightEval)
            CurrentWriter.Write_CrypticS_String(mHighlightIcon)
            mHighlightRing.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write(mTravelSuppression)
            CurrentWriter.Write(mPreferenceMultiplier)
            CurrentWriter.Write_CrypticS_Boolean(mDontSetStance)
            CurrentWriter.Write(mPointValue)
            CurrentWriter.Write(mPointMultiplier)
            CurrentWriter.Write_CrypticS_String(mChainIntoPower)
            CurrentWriter.Write_CrypticS_Boolean(mInstanceLocked)
            CurrentWriter.Write_CrypticS_Boolean(mIsEnvironmentHit)
            CurrentWriter.Write_CrypticS_Boolean(mShuffleTargets)
            CurrentWriter.Write(mForceLevelBought)
            CurrentWriter.Write_CrypticS_Boolean(mRefreshesOnActivePlayerChange)
            If CurrentWriter.Settings.Option_Version <= 6 Then CurrentWriter.Write_CrypticS_Boolean(mPowerRedirector)
            CurrentWriter.Write_CrypticS_Boolean(mCancelable)
            CurrentWriter.Write_CrypticS_Boolean(mIgnoreToggleMaxDistance)
            CurrentWriter.Write(mServerTrayPriority)
            If CurrentWriter.Settings.Option_Version >= 7 Then CurrentWriter.Write_CrypticS_StringArray(mServerTrayRequires)
            CurrentWriter.Write_CrypticS_Boolean(mAbusiveBuff)
            CurrentWriter.Write(CInt(mPositionCenter))
            CurrentWriter.Write(mPositionDistance)
            CurrentWriter.Write(mPositionHeight)
            CurrentWriter.Write(mPositionYaw)
            CurrentWriter.Write_CrypticS_Boolean(mFaceTarget)
            If CurrentWriter.Settings.Option_Version >= 7 Then CurrentWriter.Write_CrypticS_IntegerArray(mAttribCache)
            CurrentWriter.Write_CrypticS_String(mVisualFX)
            If FX.Export_To_Stream(CurrentWriter) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mCustomFX) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mFullName = CurrentReader.Read_CrypticS_String
            mCRCFullName = CurrentReader.ReadUInt32
            mSourceFile = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mSourceName = CurrentReader.Read_CrypticS_String
            mSystem = CurrentReader.ReadInt32
            mAutoIssue = CurrentReader.Read_CrypticS_Boolean
            mAutoIssueSaveLevel = CurrentReader.Read_CrypticS_Boolean
            mFree = CurrentReader.Read_CrypticS_Boolean
            mDisplayName = New CrypticS_String(CurrentReader)
            mDisplayHelp = New CrypticS_String(CurrentReader)
            mDisplayShortHelp = New CrypticS_String(CurrentReader)
            '!!REDUNDENT!!mDisplayCasterHelp = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mDisplayCasterShortHelp = CurrentReader.Read_CrypticS_String
            mDisplayTargetHelp = New CrypticS_String(CurrentReader)
            mDisplayTargetShortHelp = New CrypticS_String(CurrentReader)
            mDisplayAttackerAttack = New CrypticS_String(CurrentReader)
            mDisplayAttackerAttackFloater = New CrypticS_String(CurrentReader)
            mDisplayAttackerHit = New CrypticS_String(CurrentReader)
            mDisplayVictimHit = New CrypticS_String(CurrentReader)
            mDisplayConfirm = New CrypticS_String(CurrentReader)
            mFloatRewarded = New CrypticS_String(CurrentReader)
            mDisplayPowerDefenseFloat = New CrypticS_String(CurrentReader)
            mIconName = CurrentReader.Read_CrypticS_String
            '!!IGNORED!! mFXName = 
            mType = CurrentReader.ReadInt32
            mNumAllowed = CurrentReader.ReadInt32
            mAttackTypes = CurrentReader.Read_CrypticS_IntegerArray()
            mBuyRequires = CurrentReader.Read_CrypticS_StringArray
            mActivateRequires = CurrentReader.Read_CrypticS_StringArray
            mSlotRequires = CurrentReader.Read_CrypticS_StringArray
            mTargetRequires = CurrentReader.Read_CrypticS_StringArray
            mRewardRequires = CurrentReader.Read_CrypticS_StringArray
            mAuctionRequires = CurrentReader.Read_CrypticS_StringArray
            mRewardFallback = CurrentReader.Read_CrypticS_String
            mAccuracy = CurrentReader.ReadSingle
            mNearGround = CurrentReader.Read_CrypticS_Boolean
            mTargetNearGround = CurrentReader.Read_CrypticS_Boolean
            mCastableAfterDeath = CurrentReader.ReadInt32
            mCastThroughHold = CurrentReader.Read_CrypticS_Boolean
            mCastThroughSleep = CurrentReader.Read_CrypticS_Boolean
            mCastThroughStun = CurrentReader.Read_CrypticS_Boolean
            mCastThroughTerrorize = CurrentReader.Read_CrypticS_Boolean
            mToggleIgnoreHold = CurrentReader.Read_CrypticS_Boolean
            mToggleIgnoreSleep = CurrentReader.Read_CrypticS_Boolean
            mToggleIgnoreStun = CurrentReader.Read_CrypticS_Boolean
            mIgnoreLevelBought = CurrentReader.Read_CrypticS_Boolean
            mShootThroughUntouchable = CurrentReader.Read_CrypticS_Boolean
            mInterruptLikeSleep = CurrentReader.Read_CrypticS_Boolean
            mAIReport = CurrentReader.ReadInt32
            mEffectArea = CurrentReader.ReadInt32
            mMaxTargetsHit = CurrentReader.ReadInt32
            mRadius = CurrentReader.ReadSingle
            mArc = CurrentReader.ReadSingle
            If CurrentReader.Settings.Option_Version >= 7 Then
                mChainDelay = CurrentReader.ReadSingle
                mChainEff = CurrentReader.Read_CrypticS_StringArray
                mChainFork = CurrentReader.Read_CrypticS_IntegerArray()
            End If
            mBoxOffset = CurrentReader.Read_CrypticS_Vector3
            mBoxSize = CurrentReader.Read_CrypticS_Vector3
            mRange = CurrentReader.ReadSingle
            mRangeSecondary = CurrentReader.ReadSingle
            mTimeToActivate = CurrentReader.ReadSingle
            mRechargeTime = CurrentReader.ReadSingle
            mActivatePeriod = CurrentReader.ReadSingle
            mEnduranceCost = CurrentReader.ReadSingle
            '!!REDUNDENT!!mInsightCost = CurrentReader.ReadSingle
            mIdeaCost = CurrentReader.ReadSingle
            mTimeToConfirm = CurrentReader.ReadInt32
            mSelfConfirm = CurrentReader.ReadInt32
            mConfirmRequires = CurrentReader.Read_CrypticS_StringArray
            mDestroyOnLimit = CurrentReader.Read_CrypticS_Boolean
            mStackingUsage = CurrentReader.Read_CrypticS_Boolean
            mNumCharges = CurrentReader.ReadInt32
            mMaxNumCharges = CurrentReader.ReadInt32
            mUsageTime = CurrentReader.ReadSingle
            mMaxUsageTime = CurrentReader.ReadSingle
            mLifetime = CurrentReader.ReadSingle
            mMaxLifetime = CurrentReader.ReadSingle
            mLifetimeInGame = CurrentReader.ReadSingle
            mMaxLifetimeInGame = CurrentReader.ReadSingle
            mInterruptTime = CurrentReader.ReadSingle
            mTargetVisibility = CurrentReader.ReadInt32
            mTarget = CurrentReader.ReadInt32
            mTargetSecondary = CurrentReader.ReadInt32
            mEntsAutoHit = CurrentReader.Read_CrypticS_IntegerArray()
            mEntsAffected = CurrentReader.Read_CrypticS_IntegerArray()
            mTargetsThroughVisionPhase = CurrentReader.Read_CrypticS_Boolean
            mBoostsAllowed = CurrentReader.Read_CrypticS_IntegerArray()
            mGroupMembership = CurrentReader.Read_CrypticS_IntegerArray()
            mModesRequired = CurrentReader.Read_CrypticS_IntegerArray()
            mModesDisallowed = CurrentReader.Read_CrypticS_IntegerArray()
            mAIGroups = CurrentReader.Read_CrypticS_StringArray


            'FAILS HERE BECAUSE OF mEFFECT

            If CurrentReader.Settings.Option_Version >= 7 Then
                If CurrentReader.Read_CrypticS_StructArray(GetType(COH_PowerRedirect), mRedirect) = False Then Return False
                If CurrentReader.Read_CrypticS_StructArray(GetType(COH_PowerEffectGroup), mEffect) = False Then Return False
            End If
            If CurrentReader.Settings.Option_Version <= 6 Then If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Power_AttributeMod), mAttribMod) = False Then Return False
            mIgnoreStrength = CurrentReader.Read_CrypticS_Boolean
            '!!REDUNDENT!!mIgnoreStr = CurrentReader.Read_CrypticS_Boolean
            mShowBuffIcon = CurrentReader.Read_CrypticS_Boolean
            mShowInInventory = CurrentReader.ReadInt32
            mShowInManage = CurrentReader.Read_CrypticS_Boolean
            mShowInInfo = CurrentReader.Read_CrypticS_Boolean
            mDeletable = CurrentReader.Read_CrypticS_Boolean
            mTradeable = CurrentReader.Read_CrypticS_Boolean
            mMaxBoosts = CurrentReader.ReadInt32
            mDoNotSave = CurrentReader.Read_CrypticS_Boolean
            '!!REDUNDENT!!mDoesNotExpire = CurrentReader.Read_CrypticS_Boolean
            mBoostIgnoreEffectiveness = CurrentReader.Read_CrypticS_Boolean
            mBoostAlwaysCountForSet = CurrentReader.Read_CrypticS_Boolean
            mBoostTradeable = CurrentReader.Read_CrypticS_Boolean
            mBoostCombinable = CurrentReader.Read_CrypticS_Boolean
            mBoostAccountBound = CurrentReader.Read_CrypticS_Boolean
            mBoostBoostable = CurrentReader.Read_CrypticS_Boolean
            mBoostUsePlayerLevel = CurrentReader.Read_CrypticS_Boolean
            mBoostCatalystConversion = CurrentReader.Read_CrypticS_String
            mStoreProduct = CurrentReader.Read_CrypticS_String
            mBoostLicenseLevel = CurrentReader.ReadInt32
            mMinSlotLevel = CurrentReader.ReadInt32
            mMaxSlotLevel = CurrentReader.ReadInt32
            mMaxBoostLevel = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_PowerVar), mVar) = False Then Return False
            mToggleDroppable = CurrentReader.ReadInt32
            '!!REDUNDENT!!mTogglesDroppable = CurrentReader.ReadInt32
            If CurrentReader.Settings.Option_Version >= 7 Then mProcAllowed = CurrentReader.ReadInt32
            mStrengthsDisallowed = CurrentReader.Read_CrypticS_IntegerArray()
            mProcMainTargetOnly = CurrentReader.Read_CrypticS_Boolean
            mAnimMainTargetOnly = CurrentReader.Read_CrypticS_Boolean
            mHighlightEval = CurrentReader.Read_CrypticS_StringArray
            mHighlightIcon = CurrentReader.Read_CrypticS_String


            mHighlightRing = New COH_Color_RGBA(CurrentReader)
            mTravelSuppression = CurrentReader.ReadSingle
            mPreferenceMultiplier = CurrentReader.ReadSingle
            mDontSetStance = CurrentReader.Read_CrypticS_Boolean
            mPointValue = CurrentReader.ReadSingle
            mPointMultiplier = CurrentReader.ReadSingle
            mChainIntoPower = CurrentReader.Read_CrypticS_String
            mInstanceLocked = CurrentReader.Read_CrypticS_Boolean
            mIsEnvironmentHit = CurrentReader.Read_CrypticS_Boolean
            mShuffleTargets = CurrentReader.Read_CrypticS_Boolean
            mForceLevelBought = CurrentReader.ReadInt32
            mRefreshesOnActivePlayerChange = CurrentReader.Read_CrypticS_Boolean
            If CurrentReader.Settings.Option_Version <= 6 Then mPowerRedirector = CurrentReader.Read_CrypticS_Boolean
            mCancelable = CurrentReader.Read_CrypticS_Boolean
            mIgnoreToggleMaxDistance = CurrentReader.Read_CrypticS_Boolean
            mServerTrayPriority = CurrentReader.ReadInt32
            If CurrentReader.Settings.Option_Version >= 7 Then mServerTrayRequires = CurrentReader.Read_CrypticS_StringArray
            mAbusiveBuff = CurrentReader.Read_CrypticS_Boolean
            mPositionCenter = CurrentReader.ReadInt32
            mPositionDistance = CurrentReader.ReadSingle
            mPositionHeight = CurrentReader.ReadSingle
            mPositionYaw = CurrentReader.ReadSingle
            mFaceTarget = CurrentReader.Read_CrypticS_Boolean

            If CurrentReader.Settings.Option_Version >= 7 Then mAttribCache = CurrentReader.Read_CrypticS_IntegerArray()
            mVisualFX = CurrentReader.Read_CrypticS_String
            If mFX.Import_From_Stream(CurrentReader) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_PowerCustomFX), CustomFX) = False Then Return False '//THESE SHOULD BE THE LAST 4 BYTES
            Return True
        End Function
#End Region

    End Class
End Namespace
