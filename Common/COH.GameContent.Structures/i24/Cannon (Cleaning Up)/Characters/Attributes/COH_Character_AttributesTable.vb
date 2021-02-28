Namespace GameContent.Structures.Characters.Attributes
    Public NotInheritable Class COH_CharacterClass_AttributesTable
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Attrib Table"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Smashing As Single()
            Get
                Return mSmashing
            End Get
            Set(value As Single())
                SetValue(mSmashing, value)
            End Set
        End Property
        Property Lethal As Single()
            Get
                Return mLethal
            End Get
            Set(value As Single())
                SetValue(mLethal, value)
            End Set
        End Property
        Property Fire As Single()
            Get
                Return mFire
            End Get
            Set(value As Single())
                SetValue(mFire, value)
            End Set
        End Property
        Property Cold As Single()
            Get
                Return mCold
            End Get
            Set(value As Single())
                SetValue(mCold, value)
            End Set
        End Property
        Property Energy As Single()
            Get
                Return mEnergy
            End Get
            Set(value As Single())
                SetValue(mEnergy, value)
            End Set
        End Property
        Property Negative_Energy As Single()
            Get
                Return mNegative_Energy
            End Get
            Set(value As Single())
                SetValue(mNegative_Energy, value)
            End Set
        End Property
        Property Psionic As Single()
            Get
                Return mPsionic
            End Get
            Set(value As Single())
                SetValue(mPsionic, value)
            End Set
        End Property
        Property Heal As Single()
            Get
                Return mHeal
            End Get
            Set(value As Single())
                SetValue(mHeal, value)
            End Set
        End Property
        Property Special As Single()
            Get
                Return mSpecial
            End Get
            Set(value As Single())
                SetValue(mSpecial, value)
            End Set
        End Property
        Property Toxic As Single()
            Get
                Return mToxic
            End Get
            Set(value As Single())
                SetValue(mToxic, value)
            End Set
        End Property
        Property Radiation As Single()
            Get
                Return mRadiation
            End Get
            Set(value As Single())
                SetValue(mRadiation, value)
            End Set
        End Property
        Property Electrical As Single()
            Get
                Return mElectrical
            End Get
            Set(value As Single())
                SetValue(mElectrical, value)
            End Set
        End Property
        Property Unique1 As Single()
            Get
                Return mUnique1
            End Get
            Set(value As Single())
                SetValue(mUnique1, value)
            End Set
        End Property
        Property Unique2 As Single()
            Get
                Return mUnique2
            End Get
            Set(value As Single())
                SetValue(mUnique2, value)
            End Set
        End Property
        Property Unique3 As Single()
            Get
                Return mUnique3
            End Get
            Set(value As Single())
                SetValue(mUnique3, value)
            End Set
        End Property
        Property DamageType15 As Single()
            Get
                Return mDamageType15
            End Get
            Set(value As Single())
                SetValue(mDamageType15, value)
            End Set
        End Property
        Property DamageType16 As Single()
            Get
                Return mDamageType16
            End Get
            Set(value As Single())
                SetValue(mDamageType16, value)
            End Set
        End Property
        Property DamageType17 As Single()
            Get
                Return mDamageType17
            End Get
            Set(value As Single())
                SetValue(mDamageType17, value)
            End Set
        End Property
        Property DamageType18 As Single()
            Get
                Return mDamageType18
            End Get
            Set(value As Single())
                SetValue(mDamageType18, value)
            End Set
        End Property
        Property DamageType19 As Single()
            Get
                Return mDamageType19
            End Get
            Set(value As Single())
                SetValue(mDamageType19, value)
            End Set
        End Property
        Property HitPoints As Single()
            Get
                Return mHitPoints
            End Get
            Set(value As Single())
                SetValue(mHitPoints, value)
            End Set
        End Property
        Property Endurance As Single()
            Get
                Return mEndurance
            End Get
            Set(value As Single())
                SetValue(mEndurance, value)
            End Set
        End Property
        Property Insight As Single()
            Get
                Return mInsight
            End Get
            Set(value As Single())
                SetValue(mInsight, value)
            End Set
        End Property
        Property Rage As Single()
            Get
                Return mRage
            End Get
            Set(value As Single())
                SetValue(mRage, value)
            End Set
        End Property
        Property ToHit As Single()
            Get
                Return mToHit
            End Get
            Set(value As Single())
                SetValue(mToHit, value)
            End Set
        End Property
        Property Ranged_Attack As Single()
            Get
                Return mRanged_Attack
            End Get
            Set(value As Single())
                SetValue(mRanged_Attack, value)
            End Set
        End Property
        Property Melee_Attack As Single()
            Get
                Return mMelee_Attack
            End Get
            Set(value As Single())
                SetValue(mMelee_Attack, value)
            End Set
        End Property
        Property AOE_Attack As Single()
            Get
                Return mAOE_Attack
            End Get
            Set(value As Single())
                SetValue(mAOE_Attack, value)
            End Set
        End Property
        Property Smashing_Attack As Single()
            Get
                Return mSmashing_Attack
            End Get
            Set(value As Single())
                SetValue(mSmashing_Attack, value)
            End Set
        End Property
        Property Lethal_Attack As Single()
            Get
                Return mLethal_Attack
            End Get
            Set(value As Single())
                SetValue(mLethal_Attack, value)
            End Set
        End Property
        Property Fire_Attack As Single()
            Get
                Return mFire_Attack
            End Get
            Set(value As Single())
                SetValue(mFire_Attack, value)
            End Set
        End Property
        Property Cold_Attack As Single()
            Get
                Return mCold_Attack
            End Get
            Set(value As Single())
                SetValue(mCold_Attack, value)
            End Set
        End Property
        Property Energy_Attack As Single()
            Get
                Return mEnergy_Attack
            End Get
            Set(value As Single())
                SetValue(mEnergy_Attack, value)
            End Set
        End Property
        Property Negative_EnergyAttack As Single()
            Get
                Return mNegative_EnergyAttack
            End Get
            Set(value As Single())
                SetValue(mNegative_EnergyAttack, value)
            End Set
        End Property
        Property Psionic_Attack As Single()
            Get
                Return mPsionic_Attack
            End Get
            Set(value As Single())
                SetValue(mPsionic_Attack, value)
            End Set
        End Property
        Property Toxic_Attack As Single()
            Get
                Return mToxic_Attack
            End Get
            Set(value As Single())
                SetValue(mToxic_Attack, value)
            End Set
        End Property
        Property DefenseType11 As Single()
            Get
                Return mDefenseType11
            End Get
            Set(value As Single())
                SetValue(mDefenseType11, value)
            End Set
        End Property
        Property DefenseType12 As Single()
            Get
                Return mDefenseType12
            End Get
            Set(value As Single())
                SetValue(mDefenseType12, value)
            End Set
        End Property
        Property DefenseType13 As Single()
            Get
                Return mDefenseType13
            End Get
            Set(value As Single())
                SetValue(mDefenseType13, value)
            End Set
        End Property
        Property DefenseType14 As Single()
            Get
                Return mDefenseType14
            End Get
            Set(value As Single())
                SetValue(mDefenseType14, value)
            End Set
        End Property
        Property DefenseType15 As Single()
            Get
                Return mDefenseType15
            End Get
            Set(value As Single())
                SetValue(mDefenseType15, value)
            End Set
        End Property
        Property DefenseType16 As Single()
            Get
                Return mDefenseType16
            End Get
            Set(value As Single())
                SetValue(mDefenseType16, value)
            End Set
        End Property
        Property DefenseType17 As Single()
            Get
                Return mDefenseType17
            End Get
            Set(value As Single())
                SetValue(mDefenseType17, value)
            End Set
        End Property
        Property DefenseType18 As Single()
            Get
                Return mDefenseType18
            End Get
            Set(value As Single())
                SetValue(mDefenseType18, value)
            End Set
        End Property
        Property DefenseType19 As Single()
            Get
                Return mDefenseType19
            End Get
            Set(value As Single())
                SetValue(mDefenseType19, value)
            End Set
        End Property
        Property Defense As Single()
            Get
                Return mDefense
            End Get
            Set(value As Single())
                SetValue(mDefense, value)
            End Set
        End Property
        Property SpeedRunning As Single()
            Get
                Return mSpeedRunning
            End Get
            Set(value As Single())
                SetValue(mSpeedRunning, value)
            End Set
        End Property
        Property SpeedFlying As Single()
            Get
                Return mSpeedFlying
            End Get
            Set(value As Single())
                SetValue(mSpeedFlying, value)
            End Set
        End Property
        Property SpeedSwimming As Single()
            Get
                Return mSpeedSwimming
            End Get
            Set(value As Single())
                SetValue(mSpeedSwimming, value)
            End Set
        End Property
        Property SpeedJumping As Single()
            Get
                Return mSpeedJumping
            End Get
            Set(value As Single())
                SetValue(mSpeedJumping, value)
            End Set
        End Property
        Property JumpHeight As Single()
            Get
                Return mJumpHeight
            End Get
            Set(value As Single())
                SetValue(mJumpHeight, value)
            End Set
        End Property
        Property MovementControl As Single()
            Get
                Return mMovementControl
            End Get
            Set(value As Single())
                SetValue(mMovementControl, value)
            End Set
        End Property
        Property MovementFriction As Single()
            Get
                Return mMovementFriction
            End Get
            Set(value As Single())
                SetValue(mMovementFriction, value)
            End Set
        End Property
        Property Stealth As Single()
            Get
                Return mStealth
            End Get
            Set(value As Single())
                SetValue(mStealth, value)
            End Set
        End Property
        Property StealthRadius As Single()
            Get
                Return mStealthRadius
            End Get
            Set(value As Single())
                SetValue(mStealthRadius, value)
            End Set
        End Property
        Property StealthRadiusPlayer As Single()
            Get
                Return mStealthRadiusPlayer
            End Get
            Set(value As Single())
                SetValue(mStealthRadiusPlayer, value)
            End Set
        End Property
        Property PerceptionRadius As Single()
            Get
                Return mPerceptionRadius
            End Get
            Set(value As Single())
                SetValue(mPerceptionRadius, value)
            End Set
        End Property
        Property Regeneration As Single()
            Get
                Return mRegeneration
            End Get
            Set(value As Single())
                SetValue(mRegeneration, value)
            End Set
        End Property
        Property Recovery As Single()
            Get
                Return mRecovery
            End Get
            Set(value As Single())
                SetValue(mRecovery, value)
            End Set
        End Property
        Property InsightRecovery As Single()
            Get
                Return mInsightRecovery
            End Get
            Set(value As Single())
                SetValue(mInsightRecovery, value)
            End Set
        End Property
        Property ThreatLevel As Single()
            Get
                Return mThreatLevel
            End Get
            Set(value As Single())
                SetValue(mThreatLevel, value)
            End Set
        End Property
        Property Taunt As Single()
            Get
                Return mTaunt
            End Get
            Set(value As Single())
                SetValue(mTaunt, value)
            End Set
        End Property
        Property Placate As Single()
            Get
                Return mPlacate
            End Get
            Set(value As Single())
                SetValue(mPlacate, value)
            End Set
        End Property
        Property Confused As Single()
            Get
                Return mConfused
            End Get
            Set(value As Single())
                SetValue(mConfused, value)
            End Set
        End Property
        Property Afraid As Single()
            Get
                Return mAfraid
            End Get
            Set(value As Single())
                SetValue(mAfraid, value)
            End Set
        End Property
        Property Terrorized As Single()
            Get
                Return mTerrorized
            End Get
            Set(value As Single())
                SetValue(mTerrorized, value)
            End Set
        End Property
        Property Held As Single()
            Get
                Return mHeld
            End Get
            Set(value As Single())
                SetValue(mHeld, value)
            End Set
        End Property
        Property Immobilized As Single()
            Get
                Return mImmobilized
            End Get
            Set(value As Single())
                SetValue(mImmobilized, value)
            End Set
        End Property
        Property Stunned As Single()
            Get
                Return mStunned
            End Get
            Set(value As Single())
                SetValue(mStunned, value)
            End Set
        End Property
        Property Sleep As Single()
            Get
                Return mSleep
            End Get
            Set(value As Single())
                SetValue(mSleep, value)
            End Set
        End Property
        Property Fly As Single()
            Get
                Return mFly
            End Get
            Set(value As Single())
                SetValue(mFly, value)
            End Set
        End Property
        Property Jumppack As Single()
            Get
                Return mJumppack
            End Get
            Set(value As Single())
                SetValue(mJumppack, value)
            End Set
        End Property
        Property Teleport As Single()
            Get
                Return mTeleport
            End Get
            Set(value As Single())
                SetValue(mTeleport, value)
            End Set
        End Property
        Property Untouchable As Single()
            Get
                Return mUntouchable
            End Get
            Set(value As Single())
                SetValue(mUntouchable, value)
            End Set
        End Property
        Property Intangible As Single()
            Get
                Return mIntangible
            End Get
            Set(value As Single())
                SetValue(mIntangible, value)
            End Set
        End Property
        Property OnlyAffectsSelf As Single()
            Get
                Return mOnlyAffectsSelf
            End Get
            Set(value As Single())
                SetValue(mOnlyAffectsSelf, value)
            End Set
        End Property
        Property ExperienceGain As Single()
            Get
                Return mExperienceGain
            End Get
            Set(value As Single())
                SetValue(mExperienceGain, value)
            End Set
        End Property
        Property InfluenceGain As Single()
            Get
                Return mInfluenceGain
            End Get
            Set(value As Single())
                SetValue(mInfluenceGain, value)
            End Set
        End Property
        Property PrestigeGain As Single()
            Get
                Return mPrestigeGain
            End Get
            Set(value As Single())
                SetValue(mPrestigeGain, value)
            End Set
        End Property
        Property NullBool As Single()
            Get
                Return mNullBool
            End Get
            Set(value As Single())
                SetValue(mNullBool, value)
            End Set
        End Property
        Property Knockup As Single()
            Get
                Return mKnockup
            End Get
            Set(value As Single())
                SetValue(mKnockup, value)
            End Set
        End Property
        Property Knockback As Single()
            Get
                Return mKnockback
            End Get
            Set(value As Single())
                SetValue(mKnockback, value)
            End Set
        End Property
        Property Repel As Single()
            Get
                Return mRepel
            End Get
            Set(value As Single())
                SetValue(mRepel, value)
            End Set
        End Property
        Property Accuracy As Single()
            Get
                Return mAccuracy
            End Get
            Set(value As Single())
                SetValue(mAccuracy, value)
            End Set
        End Property
        Property Radius As Single()
            Get
                Return mRadius
            End Get
            Set(value As Single())
                SetValue(mRadius, value)
            End Set
        End Property
        Property Arc As Single()
            Get
                Return mArc
            End Get
            Set(value As Single())
                SetValue(mArc, value)
            End Set
        End Property
        Property Range As Single()
            Get
                Return mRange
            End Get
            Set(value As Single())
                SetValue(mRange, value)
            End Set
        End Property
        Property TimeToActivate As Single()
            Get
                Return mTimeToActivate
            End Get
            Set(value As Single())
                SetValue(mTimeToActivate, value)
            End Set
        End Property
        Property RechargeTime As Single()
            Get
                Return mRechargeTime
            End Get
            Set(value As Single())
                SetValue(mRechargeTime, value)
            End Set
        End Property
        Property InterruptTime As Single()
            Get
                Return mInterruptTime
            End Get
            Set(value As Single())
                SetValue(mInterruptTime, value)
            End Set
        End Property
        Property EnduranceDiscount As Single()
            Get
                Return mEnduranceDiscount
            End Get
            Set(value As Single())
                SetValue(mEnduranceDiscount, value)
            End Set
        End Property
        Property InsightDiscount As Single()
            Get
                Return mInsightDiscount
            End Get
            Set(value As Single())
                SetValue(mInsightDiscount, value)
            End Set
        End Property
        Property Meter As Single()
            Get
                Return mMeter
            End Get
            Set(value As Single())
                SetValue(mMeter, value)
            End Set
        End Property
        Property Ranged_Elude As Single()
            Get
                Return mRanged_Elude
            End Get
            Set(value As Single())
                SetValue(mRanged_Elude, value)
            End Set
        End Property
        Property Melee_Elude As Single()
            Get
                Return mMelee_Elude
            End Get
            Set(value As Single())
                SetValue(mMelee_Elude, value)
            End Set
        End Property
        Property AOE_Elude As Single()
            Get
                Return mAOE_Elude
            End Get
            Set(value As Single())
                SetValue(mAOE_Elude, value)
            End Set
        End Property
        Property Smashing_Elude As Single()
            Get
                Return mSmashing_Elude
            End Get
            Set(value As Single())
                SetValue(mSmashing_Elude, value)
            End Set
        End Property
        Property Lethal_Elude As Single()
            Get
                Return mLethal_Elude
            End Get
            Set(value As Single())
                SetValue(mLethal_Elude, value)
            End Set
        End Property
        Property Fire_Elude As Single()
            Get
                Return mFire_Elude
            End Get
            Set(value As Single())
                SetValue(mFire_Elude, value)
            End Set
        End Property
        Property Cold_Elude As Single()
            Get
                Return mCold_Elude
            End Get
            Set(value As Single())
                SetValue(mCold_Elude, value)
            End Set
        End Property
        Property Energy_Elude As Single()
            Get
                Return mEnergy_Elude
            End Get
            Set(value As Single())
                SetValue(mEnergy_Elude, value)
            End Set
        End Property
        Property NegativeEnergy_Elude As Single()
            Get
                Return mNegativeEnergy_Elude
            End Get
            Set(value As Single())
                SetValue(mNegativeEnergy_Elude, value)
            End Set
        End Property
        Property Psionic_Elude As Single()
            Get
                Return mPsionic_Elude
            End Get
            Set(value As Single())
                SetValue(mPsionic_Elude, value)
            End Set
        End Property
        Property Toxic_Elude As Single()
            Get
                Return mToxic_Elude
            End Get
            Set(value As Single())
                SetValue(mToxic_Elude, value)
            End Set
        End Property
        Property Elusivity11 As Single()
            Get
                Return mElusivity11
            End Get
            Set(value As Single())
                SetValue(mElusivity11, value)
            End Set
        End Property
        Property Elusivity12 As Single()
            Get
                Return mElusivity12
            End Get
            Set(value As Single())
                SetValue(mElusivity12, value)
            End Set
        End Property
        Property Elusivity13 As Single()
            Get
                Return mElusivity13
            End Get
            Set(value As Single())
                SetValue(mElusivity13, value)
            End Set
        End Property
        Property Elusivity14 As Single()
            Get
                Return mElusivity14
            End Get
            Set(value As Single())
                SetValue(mElusivity14, value)
            End Set
        End Property
        Property Elusivity15 As Single()
            Get
                Return mElusivity15
            End Get
            Set(value As Single())
                SetValue(mElusivity15, value)
            End Set
        End Property
        Property Elusivity16 As Single()
            Get
                Return mElusivity16
            End Get
            Set(value As Single())
                SetValue(mElusivity16, value)
            End Set
        End Property
        Property Elusivity17 As Single()
            Get
                Return mElusivity17
            End Get
            Set(value As Single())
                SetValue(mElusivity17, value)
            End Set
        End Property
        Property Elusivity18 As Single()
            Get
                Return mElusivity18
            End Get
            Set(value As Single())
                SetValue(mElusivity18, value)
            End Set
        End Property
        Property Elusivity19 As Single()
            Get
                Return mElusivity19
            End Get
            Set(value As Single())
                SetValue(mElusivity19, value)
            End Set
        End Property
        Property ElusivityBase As Single() '//WHY IS WRITING TO mdefense
            Get
                Return mDefense
            End Get
            Set(value As Single())
                SetValue(mDefense, value)
                SetValue(mDefense2, value)
            End Set
        End Property
        Property Absorb As Single()
            Get
                Return mAbsorb
            End Get
            Set(value As Single())
                SetValue(mAbsorb, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mSmashing As Single()
       Private mLethal As Single()
       Private mFire As Single()
       Private mCold As Single()
       Private mEnergy As Single()
       Private mNegative_Energy As Single()
       Private mPsionic As Single()
       Private mHeal As Single()
       Private mSpecial As Single()
       Private mToxic As Single()
       Private mRadiation As Single()
       Private mElectrical As Single()
       Private mUnique1 As Single()
       Private mUnique2 As Single()
       Private mUnique3 As Single()
       Private mDamageType15 As Single()
       Private mDamageType16 As Single()
       Private mDamageType17 As Single()
       Private mDamageType18 As Single()
       Private mDamageType19 As Single()
       Private mHitPoints As Single()
       Private mEndurance As Single()
       Private mInsight As Single()
       Private mRage As Single()
       Private mToHit As Single()
       Private mRanged_Attack As Single()
       Private mMelee_Attack As Single()
       Private mAOE_Attack As Single()
       Private mSmashing_Attack As Single()
       Private mLethal_Attack As Single()
       Private mFire_Attack As Single()
       Private mCold_Attack As Single()
       Private mEnergy_Attack As Single()
       Private mNegative_EnergyAttack As Single()
       Private mPsionic_Attack As Single()
       Private mToxic_Attack As Single()
       Private mDefenseType11 As Single()
       Private mDefenseType12 As Single()
       Private mDefenseType13 As Single()
       Private mDefenseType14 As Single()
       Private mDefenseType15 As Single()
       Private mDefenseType16 As Single()
       Private mDefenseType17 As Single()
       Private mDefenseType18 As Single()
       Private mDefenseType19 As Single()
       Private mDefense As Single()
       Private mSpeedRunning As Single()
       Private mSpeedFlying As Single()
       Private mSpeedSwimming As Single()
       Private mSpeedJumping As Single()
       Private mJumpHeight As Single()
       Private mMovementControl As Single()
       Private mMovementFriction As Single()
       Private mStealth As Single()
       Private mStealthRadius As Single()
       Private mStealthRadiusPlayer As Single()
       Private mPerceptionRadius As Single()
       Private mRegeneration As Single()
       Private mRecovery As Single()
       Private mInsightRecovery As Single()
       Private mThreatLevel As Single()
       Private mTaunt As Single()
       Private mPlacate As Single()
       Private mConfused As Single()
       Private mAfraid As Single()
       Private mTerrorized As Single()
       Private mHeld As Single()
       Private mImmobilized As Single()
       Private mStunned As Single()
       Private mSleep As Single()
       Private mFly As Single()
       Private mJumppack As Single()
       Private mTeleport As Single()
       Private mUntouchable As Single()
       Private mIntangible As Single()
       Private mOnlyAffectsSelf As Single()
       Private mExperienceGain As Single()
       Private mInfluenceGain As Single()
       Private mPrestigeGain As Single()
       Private mNullBool As Single()
       Private mKnockup As Single()
       Private mKnockback As Single()
       Private mRepel As Single()
       Private mAccuracy As Single()
       Private mRadius As Single()
       Private mArc As Single()
       Private mRange As Single()
       Private mTimeToActivate As Single()
       Private mRechargeTime As Single()
       Private mInterruptTime As Single()
       Private mEnduranceDiscount As Single()
       Private mInsightDiscount As Single()
       Private mMeter As Single()
       Private mRanged_Elude As Single()
       Private mMelee_Elude As Single()
       Private mAOE_Elude As Single()
       Private mSmashing_Elude As Single()
       Private mLethal_Elude As Single()
       Private mFire_Elude As Single()
       Private mCold_Elude As Single()
       Private mEnergy_Elude As Single()
       Private mNegativeEnergy_Elude As Single()
       Private mPsionic_Elude As Single()
       Private mToxic_Elude As Single()
       Private mElusivity11 As Single()
       Private mElusivity12 As Single()
       Private mElusivity13 As Single()
       Private mElusivity14 As Single()
       Private mElusivity15 As Single()
       Private mElusivity16 As Single()
       Private mElusivity17 As Single()
       Private mElusivity18 As Single()
       Private mElusivity19 As Single()
       Private mDefense2 As Single()
       Private mAbsorb As Single()
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
            mSmashing = New Single() {}
            mLethal = New Single() {}
            mFire = New Single() {}
            mCold = New Single() {}
            mEnergy = New Single() {}
            mNegative_Energy = New Single() {}
            mPsionic = New Single() {}
            mHeal = New Single() {}
            mSpecial = New Single() {}
            mToxic = New Single() {}
            mRadiation = New Single() {}
            mElectrical = New Single() {}
            mUnique1 = New Single() {}
            mUnique2 = New Single() {}
            mUnique3 = New Single() {}
            mDamageType15 = New Single() {}
            mDamageType16 = New Single() {}
            mDamageType17 = New Single() {}
            mDamageType18 = New Single() {}
            mDamageType19 = New Single() {}
            mHitPoints = New Single() {}
            mEndurance = New Single() {}
            mInsight = New Single() {}
            mRage = New Single() {}
            mToHit = New Single() {}
            mRanged_Attack = New Single() {}
            mMelee_Attack = New Single() {}
            mAOE_Attack = New Single() {}
            mSmashing_Attack = New Single() {}
            mLethal_Attack = New Single() {}
            mFire_Attack = New Single() {}
            mCold_Attack = New Single() {}
            mEnergy_Attack = New Single() {}
            mNegative_EnergyAttack = New Single() {}
            mPsionic_Attack = New Single() {}
            mToxic_Attack = New Single() {}
            mDefenseType11 = New Single() {}
            mDefenseType12 = New Single() {}
            mDefenseType13 = New Single() {}
            mDefenseType14 = New Single() {}
            mDefenseType15 = New Single() {}
            mDefenseType16 = New Single() {}
            mDefenseType17 = New Single() {}
            mDefenseType18 = New Single() {}
            mDefenseType19 = New Single() {}
            mDefense = New Single() {}
            mSpeedRunning = New Single() {}
            mSpeedFlying = New Single() {}
            mSpeedSwimming = New Single() {}
            mSpeedJumping = New Single() {}
            mJumpHeight = New Single() {}
            mMovementControl = New Single() {}
            mMovementFriction = New Single() {}
            mStealth = New Single() {}
            mStealthRadius = New Single() {}
            mStealthRadiusPlayer = New Single() {}
            mPerceptionRadius = New Single() {}
            mRegeneration = New Single() {}
            mRecovery = New Single() {}
            mInsightRecovery = New Single() {}
            mThreatLevel = New Single() {}
            mTaunt = New Single() {}
            mPlacate = New Single() {}
            mConfused = New Single() {}
            mAfraid = New Single() {}
            mTerrorized = New Single() {}
            mHeld = New Single() {}
            mImmobilized = New Single() {}
            mStunned = New Single() {}
            mSleep = New Single() {}
            mFly = New Single() {}
            mJumppack = New Single() {}
            mTeleport = New Single() {}
            mUntouchable = New Single() {}
            mIntangible = New Single() {}
            mOnlyAffectsSelf = New Single() {}
            mExperienceGain = New Single() {}
            mInfluenceGain = New Single() {}
            mPrestigeGain = New Single() {}
            mNullBool = New Single() {}
            mKnockup = New Single() {}
            mKnockback = New Single() {}
            mRepel = New Single() {}
            mAccuracy = New Single() {}
            mRadius = New Single() {}
            mArc = New Single() {}
            mRange = New Single() {}
            mTimeToActivate = New Single() {}
            mRechargeTime = New Single() {}
            mInterruptTime = New Single() {}
            mEnduranceDiscount = New Single() {}
            mInsightDiscount = New Single() {}
            mMeter = New Single() {}
            mRanged_Elude = New Single() {}
            mMelee_Elude = New Single() {}
            mAOE_Elude = New Single() {}
            mSmashing_Elude = New Single() {}
            mLethal_Elude = New Single() {}
            mFire_Elude = New Single() {}
            mCold_Elude = New Single() {}
            mEnergy_Elude = New Single() {}
            mNegativeEnergy_Elude = New Single() {}
            mPsionic_Elude = New Single() {}
            mToxic_Elude = New Single() {}
            mElusivity11 = New Single() {}
            mElusivity12 = New Single() {}
            mElusivity13 = New Single() {}
            mElusivity14 = New Single() {}
            mElusivity15 = New Single() {}
            mElusivity16 = New Single() {}
            mElusivity17 = New Single() {}
            mElusivity18 = New Single() {}
            mElusivity19 = New Single() {}
            mDefense = New Single() {}
            mAbsorb = New Single() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CharacterClass_AttributesTable
            Dim Result As COH_CharacterClass_AttributesTable = New COH_CharacterClass_AttributesTable
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mSmashing = New Single(mSmashing.Count - 1) {} : mSmashing.CopyTo(.mSmashing, 0)
                .mLethal = New Single(mLethal.Count - 1) {} : mLethal.CopyTo(.mLethal, 0)
                .mFire = New Single(mFire.Count - 1) {} : mFire.CopyTo(.mFire, 0)
                .mCold = New Single(mCold.Count - 1) {} : mCold.CopyTo(.mCold, 0)
                .mEnergy = New Single(mEnergy.Count - 1) {} : mEnergy.CopyTo(.mEnergy, 0)
                .mNegative_Energy = New Single(mNegative_Energy.Count - 1) {} : mNegative_Energy.CopyTo(.mNegative_Energy, 0)
                .mPsionic = New Single(mPsionic.Count - 1) {} : mPsionic.CopyTo(.mPsionic, 0)
                .mHeal = New Single(mHeal.Count - 1) {} : mHeal.CopyTo(.mHeal, 0)
                .mSpecial = New Single(mSpecial.Count - 1) {} : mSpecial.CopyTo(.mSpecial, 0)
                .mToxic = New Single(mToxic.Count - 1) {} : mToxic.CopyTo(.mToxic, 0)
                .mRadiation = New Single(mRadiation.Count - 1) {} : mRadiation.CopyTo(.mRadiation, 0)
                .mElectrical = New Single(mElectrical.Count - 1) {} : mElectrical.CopyTo(.mElectrical, 0)
                .mUnique1 = New Single(mUnique1.Count - 1) {} : mUnique1.CopyTo(.mUnique1, 0)
                .mUnique2 = New Single(mUnique2.Count - 1) {} : mUnique2.CopyTo(.mUnique2, 0)
                .mUnique3 = New Single(mUnique3.Count - 1) {} : mUnique3.CopyTo(.mUnique3, 0)
                .mDamageType15 = New Single(mDamageType15.Count - 1) {} : mDamageType15.CopyTo(.mDamageType15, 0)
                .mDamageType16 = New Single(mDamageType16.Count - 1) {} : mDamageType16.CopyTo(.mDamageType16, 0)
                .mDamageType17 = New Single(mDamageType17.Count - 1) {} : mDamageType17.CopyTo(.mDamageType17, 0)
                .mDamageType18 = New Single(mDamageType18.Count - 1) {} : mDamageType18.CopyTo(.mDamageType18, 0)
                .mDamageType19 = New Single(mDamageType19.Count - 1) {} : mDamageType19.CopyTo(.mDamageType19, 0)
                .mHitPoints = New Single(mHitPoints.Count - 1) {} : mHitPoints.CopyTo(.mHitPoints, 0)
                .mEndurance = New Single(mEndurance.Count - 1) {} : mEndurance.CopyTo(.mEndurance, 0)
                .mInsight = New Single(mInsight.Count - 1) {} : mInsight.CopyTo(.mInsight, 0)
                .mRage = New Single(mRage.Count - 1) {} : mRage.CopyTo(.mRage, 0)
                .mToHit = New Single(mToHit.Count - 1) {} : mToHit.CopyTo(.mToHit, 0)
                .mRanged_Attack = New Single(mRanged_Attack.Count - 1) {} : mRanged_Attack.CopyTo(.mRanged_Attack, 0)
                .mMelee_Attack = New Single(mMelee_Attack.Count - 1) {} : mMelee_Attack.CopyTo(.mMelee_Attack, 0)
                .mAOE_Attack = New Single(mAOE_Attack.Count - 1) {} : mAOE_Attack.CopyTo(.mAOE_Attack, 0)
                .mSmashing_Attack = New Single(mSmashing_Attack.Count - 1) {} : mSmashing_Attack.CopyTo(.mSmashing_Attack, 0)
                .mLethal_Attack = New Single(mLethal_Attack.Count - 1) {} : mLethal_Attack.CopyTo(.mLethal_Attack, 0)
                .mFire_Attack = New Single(mFire_Attack.Count - 1) {} : mFire_Attack.CopyTo(.mFire_Attack, 0)
                .mCold_Attack = New Single(mCold_Attack.Count - 1) {} : mCold_Attack.CopyTo(.mCold_Attack, 0)
                .mEnergy_Attack = New Single(mEnergy_Attack.Count - 1) {} : mEnergy_Attack.CopyTo(.mEnergy_Attack, 0)
                .mNegative_EnergyAttack = New Single(mNegative_EnergyAttack.Count - 1) {} : mNegative_EnergyAttack.CopyTo(.mNegative_EnergyAttack, 0)
                .mPsionic_Attack = New Single(mPsionic_Attack.Count - 1) {} : mPsionic_Attack.CopyTo(.mPsionic_Attack, 0)
                .mToxic_Attack = New Single(mToxic_Attack.Count - 1) {} : mToxic_Attack.CopyTo(.mToxic_Attack, 0)
                .mDefenseType11 = New Single(mDefenseType11.Count - 1) {} : mDefenseType11.CopyTo(.mDefenseType11, 0)
                .mDefenseType12 = New Single(mDefenseType12.Count - 1) {} : mDefenseType12.CopyTo(.mDefenseType12, 0)
                .mDefenseType13 = New Single(mDefenseType13.Count - 1) {} : mDefenseType13.CopyTo(.mDefenseType13, 0)
                .mDefenseType14 = New Single(mDefenseType14.Count - 1) {} : mDefenseType14.CopyTo(.mDefenseType14, 0)
                .mDefenseType15 = New Single(mDefenseType15.Count - 1) {} : mDefenseType15.CopyTo(.mDefenseType15, 0)
                .mDefenseType16 = New Single(mDefenseType16.Count - 1) {} : mDefenseType16.CopyTo(.mDefenseType16, 0)
                .mDefenseType17 = New Single(mDefenseType17.Count - 1) {} : mDefenseType17.CopyTo(.mDefenseType17, 0)
                .mDefenseType18 = New Single(mDefenseType18.Count - 1) {} : mDefenseType18.CopyTo(.mDefenseType18, 0)
                .mDefenseType19 = New Single(mDefenseType19.Count - 1) {} : mDefenseType19.CopyTo(.mDefenseType19, 0)
                .mDefense = New Single(mDefense.Count - 1) {} : mDefense.CopyTo(.mDefense, 0)
                .mSpeedRunning = New Single(mSpeedRunning.Count - 1) {} : mSpeedRunning.CopyTo(.mSpeedRunning, 0)
                .mSpeedFlying = New Single(mSpeedFlying.Count - 1) {} : mSpeedFlying.CopyTo(.mSpeedFlying, 0)
                .mSpeedSwimming = New Single(mSpeedSwimming.Count - 1) {} : mSpeedSwimming.CopyTo(.mSpeedSwimming, 0)
                .mSpeedJumping = New Single(mSpeedJumping.Count - 1) {} : mSpeedJumping.CopyTo(.mSpeedJumping, 0)
                .mJumpHeight = New Single(mJumpHeight.Count - 1) {} : mJumpHeight.CopyTo(.mJumpHeight, 0)
                .mMovementControl = New Single(mMovementControl.Count - 1) {} : mMovementControl.CopyTo(.mMovementControl, 0)
                .mMovementFriction = New Single(mMovementFriction.Count - 1) {} : mMovementFriction.CopyTo(.mMovementFriction, 0)
                .mStealth = New Single(mStealth.Count - 1) {} : mStealth.CopyTo(.mStealth, 0)
                .mStealthRadius = New Single(mStealthRadius.Count - 1) {} : mStealthRadius.CopyTo(.mStealthRadius, 0)
                .mStealthRadiusPlayer = New Single(mStealthRadiusPlayer.Count - 1) {} : mStealthRadiusPlayer.CopyTo(.mStealthRadiusPlayer, 0)
                .mPerceptionRadius = New Single(mPerceptionRadius.Count - 1) {} : mPerceptionRadius.CopyTo(.mPerceptionRadius, 0)
                .mRegeneration = New Single(mRegeneration.Count - 1) {} : mRegeneration.CopyTo(.mRegeneration, 0)
                .mRecovery = New Single(mRecovery.Count - 1) {} : mRecovery.CopyTo(.mRecovery, 0)
                .mInsightRecovery = New Single(mInsightRecovery.Count - 1) {} : mInsightRecovery.CopyTo(.mInsightRecovery, 0)
                .mThreatLevel = New Single(mThreatLevel.Count - 1) {} : mThreatLevel.CopyTo(.mThreatLevel, 0)
                .mTaunt = New Single(mTaunt.Count - 1) {} : mTaunt.CopyTo(.mTaunt, 0)
                .mPlacate = New Single(mPlacate.Count - 1) {} : mPlacate.CopyTo(.mPlacate, 0)
                .mConfused = New Single(mConfused.Count - 1) {} : mConfused.CopyTo(.mConfused, 0)
                .mAfraid = New Single(mAfraid.Count - 1) {} : mAfraid.CopyTo(.mAfraid, 0)
                .mTerrorized = New Single(mTerrorized.Count - 1) {} : mTerrorized.CopyTo(.mTerrorized, 0)
                .mHeld = New Single(mHeld.Count - 1) {} : mHeld.CopyTo(.mHeld, 0)
                .mImmobilized = New Single(mImmobilized.Count - 1) {} : mImmobilized.CopyTo(.mImmobilized, 0)
                .mStunned = New Single(mStunned.Count - 1) {} : mStunned.CopyTo(.mStunned, 0)
                .mSleep = New Single(mSleep.Count - 1) {} : mSleep.CopyTo(.mSleep, 0)
                .mFly = New Single(mFly.Count - 1) {} : mFly.CopyTo(.mFly, 0)
                .mJumppack = New Single(mJumppack.Count - 1) {} : mJumppack.CopyTo(.mJumppack, 0)
                .mTeleport = New Single(mTeleport.Count - 1) {} : mTeleport.CopyTo(.mTeleport, 0)
                .mUntouchable = New Single(mUntouchable.Count - 1) {} : mUntouchable.CopyTo(.mUntouchable, 0)
                .mIntangible = New Single(mIntangible.Count - 1) {} : mIntangible.CopyTo(.mIntangible, 0)
                .mOnlyAffectsSelf = New Single(mOnlyAffectsSelf.Count - 1) {} : mOnlyAffectsSelf.CopyTo(.mOnlyAffectsSelf, 0)
                .mExperienceGain = New Single(mExperienceGain.Count - 1) {} : mExperienceGain.CopyTo(.mExperienceGain, 0)
                .mInfluenceGain = New Single(mInfluenceGain.Count - 1) {} : mInfluenceGain.CopyTo(.mInfluenceGain, 0)
                .mPrestigeGain = New Single(mPrestigeGain.Count - 1) {} : mPrestigeGain.CopyTo(.mPrestigeGain, 0)
                .mNullBool = New Single(mNullBool.Count - 1) {} : mNullBool.CopyTo(.mNullBool, 0)
                .mKnockup = New Single(mKnockup.Count - 1) {} : mKnockup.CopyTo(.mKnockup, 0)
                .mKnockback = New Single(mKnockback.Count - 1) {} : mKnockback.CopyTo(.mKnockback, 0)
                .mRepel = New Single(mRepel.Count - 1) {} : mRepel.CopyTo(.mRepel, 0)
                .mAccuracy = New Single(mAccuracy.Count - 1) {} : mAccuracy.CopyTo(.mAccuracy, 0)
                .mRadius = New Single(mRadius.Count - 1) {} : mRadius.CopyTo(.mRadius, 0)
                .mArc = New Single(mArc.Count - 1) {} : mArc.CopyTo(.mArc, 0)
                .mRange = New Single(mRange.Count - 1) {} : mRange.CopyTo(.mRange, 0)
                .mTimeToActivate = New Single(mTimeToActivate.Count - 1) {} : mTimeToActivate.CopyTo(.mTimeToActivate, 0)
                .mRechargeTime = New Single(mRechargeTime.Count - 1) {} : mRechargeTime.CopyTo(.mRechargeTime, 0)
                .mInterruptTime = New Single(mInterruptTime.Count - 1) {} : mInterruptTime.CopyTo(.mInterruptTime, 0)
                .mEnduranceDiscount = New Single(mEnduranceDiscount.Count - 1) {} : mEnduranceDiscount.CopyTo(.mEnduranceDiscount, 0)
                .mInsightDiscount = New Single(mInsightDiscount.Count - 1) {} : mInsightDiscount.CopyTo(.mInsightDiscount, 0)
                .mMeter = New Single(mMeter.Count - 1) {} : mMeter.CopyTo(.mMeter, 0)
                .mRanged_Elude = New Single(mRanged_Elude.Count - 1) {} : mRanged_Elude.CopyTo(.mRanged_Elude, 0)
                .mMelee_Elude = New Single(mMelee_Elude.Count - 1) {} : mMelee_Elude.CopyTo(.mMelee_Elude, 0)
                .mAOE_Elude = New Single(mAOE_Elude.Count - 1) {} : mAOE_Elude.CopyTo(.mAOE_Elude, 0)
                .mSmashing_Elude = New Single(mSmashing_Elude.Count - 1) {} : mSmashing_Elude.CopyTo(.mSmashing_Elude, 0)
                .mLethal_Elude = New Single(mLethal_Elude.Count - 1) {} : mLethal_Elude.CopyTo(.mLethal_Elude, 0)
                .mFire_Elude = New Single(mFire_Elude.Count - 1) {} : mFire_Elude.CopyTo(.mFire_Elude, 0)
                .mCold_Elude = New Single(mCold_Elude.Count - 1) {} : mCold_Elude.CopyTo(.mCold_Elude, 0)
                .mEnergy_Elude = New Single(mEnergy_Elude.Count - 1) {} : mEnergy_Elude.CopyTo(.mEnergy_Elude, 0)
                .mNegativeEnergy_Elude = New Single(mNegativeEnergy_Elude.Count - 1) {} : mNegativeEnergy_Elude.CopyTo(.mNegativeEnergy_Elude, 0)
                .mPsionic_Elude = New Single(mPsionic_Elude.Count - 1) {} : mPsionic_Elude.CopyTo(.mPsionic_Elude, 0)
                .mToxic_Elude = New Single(mToxic_Elude.Count - 1) {} : mToxic_Elude.CopyTo(.mToxic_Elude, 0)
                .mElusivity11 = New Single(mElusivity11.Count - 1) {} : mElusivity11.CopyTo(.mElusivity11, 0)
                .mElusivity12 = New Single(mElusivity12.Count - 1) {} : mElusivity12.CopyTo(.mElusivity12, 0)
                .mElusivity13 = New Single(mElusivity13.Count - 1) {} : mElusivity13.CopyTo(.mElusivity13, 0)
                .mElusivity14 = New Single(mElusivity14.Count - 1) {} : mElusivity14.CopyTo(.mElusivity14, 0)
                .mElusivity15 = New Single(mElusivity15.Count - 1) {} : mElusivity15.CopyTo(.mElusivity15, 0)
                .mElusivity16 = New Single(mElusivity16.Count - 1) {} : mElusivity16.CopyTo(.mElusivity16, 0)
                .mElusivity17 = New Single(mElusivity17.Count - 1) {} : mElusivity17.CopyTo(.mElusivity17, 0)
                .mElusivity18 = New Single(mElusivity18.Count - 1) {} : mElusivity18.CopyTo(.mElusivity18, 0)
                .mElusivity19 = New Single(mElusivity19.Count - 1) {} : mElusivity19.CopyTo(.mElusivity19, 0)
                .mDefense = New Single(mDefense.Count - 1) {} : mDefense.CopyTo(.mDefense, 0)
                .mAbsorb = New Single(mAbsorb.Count - 1) {} : mAbsorb.CopyTo(.mAbsorb, 0)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_SingleArray(mSmashing)
            CurrentWriter.Write_CrypticS_SingleArray(mLethal)
            CurrentWriter.Write_CrypticS_SingleArray(mFire)
            CurrentWriter.Write_CrypticS_SingleArray(mCold)
            CurrentWriter.Write_CrypticS_SingleArray(mEnergy)
            CurrentWriter.Write_CrypticS_SingleArray(mNegative_Energy)
            CurrentWriter.Write_CrypticS_SingleArray(mPsionic)
            CurrentWriter.Write_CrypticS_SingleArray(mHeal)
            CurrentWriter.Write_CrypticS_SingleArray(mSpecial)
            CurrentWriter.Write_CrypticS_SingleArray(mToxic)
            CurrentWriter.Write_CrypticS_SingleArray(mRadiation)
            CurrentWriter.Write_CrypticS_SingleArray(mElectrical)
            CurrentWriter.Write_CrypticS_SingleArray(mUnique1)
            CurrentWriter.Write_CrypticS_SingleArray(mUnique2)
            CurrentWriter.Write_CrypticS_SingleArray(mUnique3)
            CurrentWriter.Write_CrypticS_SingleArray(mDamageType15)
            CurrentWriter.Write_CrypticS_SingleArray(mDamageType16)
            CurrentWriter.Write_CrypticS_SingleArray(mDamageType17)
            CurrentWriter.Write_CrypticS_SingleArray(mDamageType18)
            CurrentWriter.Write_CrypticS_SingleArray(mDamageType19)
            CurrentWriter.Write_CrypticS_SingleArray(mHitPoints)
            CurrentWriter.Write_CrypticS_SingleArray(mEndurance)
            CurrentWriter.Write_CrypticS_SingleArray(mInsight)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_SingleArray(mIdea)
            CurrentWriter.Write_CrypticS_SingleArray(mRage)
            CurrentWriter.Write_CrypticS_SingleArray(mToHit)
            CurrentWriter.Write_CrypticS_SingleArray(mRanged_Attack)
            CurrentWriter.Write_CrypticS_SingleArray(mMelee_Attack)
            CurrentWriter.Write_CrypticS_SingleArray(mAOE_Attack)
            CurrentWriter.Write_CrypticS_SingleArray(mSmashing_Attack)
            CurrentWriter.Write_CrypticS_SingleArray(mLethal_Attack)
            CurrentWriter.Write_CrypticS_SingleArray(mFire_Attack)
            CurrentWriter.Write_CrypticS_SingleArray(mCold_Attack)
            CurrentWriter.Write_CrypticS_SingleArray(mEnergy_Attack)
            CurrentWriter.Write_CrypticS_SingleArray(mNegative_EnergyAttack)
            CurrentWriter.Write_CrypticS_SingleArray(mPsionic_Attack)
            CurrentWriter.Write_CrypticS_SingleArray(mToxic_Attack)
            CurrentWriter.Write_CrypticS_SingleArray(mDefenseType11)
            CurrentWriter.Write_CrypticS_SingleArray(mDefenseType12)
            CurrentWriter.Write_CrypticS_SingleArray(mDefenseType13)
            CurrentWriter.Write_CrypticS_SingleArray(mDefenseType14)
            CurrentWriter.Write_CrypticS_SingleArray(mDefenseType15)
            CurrentWriter.Write_CrypticS_SingleArray(mDefenseType16)
            CurrentWriter.Write_CrypticS_SingleArray(mDefenseType17)
            CurrentWriter.Write_CrypticS_SingleArray(mDefenseType18)
            CurrentWriter.Write_CrypticS_SingleArray(mDefenseType19)
            CurrentWriter.Write_CrypticS_SingleArray(mDefense)
            CurrentWriter.Write_CrypticS_SingleArray(mSpeedRunning)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_SingleArray(mRunSpeed)
            CurrentWriter.Write_CrypticS_SingleArray(mSpeedFlying)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_SingleArray(mFlySpeed)
            CurrentWriter.Write_CrypticS_SingleArray(mSpeedSwimming)
            CurrentWriter.Write_CrypticS_SingleArray(mSpeedJumping)
            CurrentWriter.Write_CrypticS_SingleArray(mJumpHeight)
            CurrentWriter.Write_CrypticS_SingleArray(mMovementControl)
            CurrentWriter.Write_CrypticS_SingleArray(mMovementFriction)
            CurrentWriter.Write_CrypticS_SingleArray(mStealth)
            CurrentWriter.Write_CrypticS_SingleArray(mStealthRadius)
            CurrentWriter.Write_CrypticS_SingleArray(mStealthRadiusPlayer)
            CurrentWriter.Write_CrypticS_SingleArray(mPerceptionRadius)
            CurrentWriter.Write_CrypticS_SingleArray(mRegeneration)
            CurrentWriter.Write_CrypticS_SingleArray(mRecovery)
            CurrentWriter.Write_CrypticS_SingleArray(mInsightRecovery)
            CurrentWriter.Write_CrypticS_SingleArray(mThreatLevel)
            CurrentWriter.Write_CrypticS_SingleArray(mTaunt)
            CurrentWriter.Write_CrypticS_SingleArray(mPlacate)
            CurrentWriter.Write_CrypticS_SingleArray(mConfused)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_SingleArray(mConfuse)
            CurrentWriter.Write_CrypticS_SingleArray(mAfraid)
            CurrentWriter.Write_CrypticS_SingleArray(mTerrorized)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_SingleArray(mTerrorize)
            CurrentWriter.Write_CrypticS_SingleArray(mHeld)
            CurrentWriter.Write_CrypticS_SingleArray(mImmobilized)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_SingleArray(mImmobilize)
            CurrentWriter.Write_CrypticS_SingleArray(mStunned)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_SingleArray(mStun)
            CurrentWriter.Write_CrypticS_SingleArray(mSleep)
            CurrentWriter.Write_CrypticS_SingleArray(mFly)
            CurrentWriter.Write_CrypticS_SingleArray(mJumppack)
            CurrentWriter.Write_CrypticS_SingleArray(mTeleport)
            CurrentWriter.Write_CrypticS_SingleArray(mUntouchable)
            CurrentWriter.Write_CrypticS_SingleArray(mIntangible)
            CurrentWriter.Write_CrypticS_SingleArray(mOnlyAffectsSelf)
            CurrentWriter.Write_CrypticS_SingleArray(mExperienceGain)
            CurrentWriter.Write_CrypticS_SingleArray(mInfluenceGain)
            CurrentWriter.Write_CrypticS_SingleArray(mPrestigeGain)
            CurrentWriter.Write_CrypticS_SingleArray(mNullBool)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_SingleArray(mEvade)
            CurrentWriter.Write_CrypticS_SingleArray(mKnockup)
            CurrentWriter.Write_CrypticS_SingleArray(mKnockback)
            CurrentWriter.Write_CrypticS_SingleArray(mRepel)
            CurrentWriter.Write_CrypticS_SingleArray(mAccuracy)
            CurrentWriter.Write_CrypticS_SingleArray(mRadius)
            CurrentWriter.Write_CrypticS_SingleArray(mArc)
            CurrentWriter.Write_CrypticS_SingleArray(mRange)
            CurrentWriter.Write_CrypticS_SingleArray(mTimeToActivate)
            CurrentWriter.Write_CrypticS_SingleArray(mRechargeTime)
            CurrentWriter.Write_CrypticS_SingleArray(mInterruptTime)
            CurrentWriter.Write_CrypticS_SingleArray(mEnduranceDiscount)
            CurrentWriter.Write_CrypticS_SingleArray(mInsightDiscount)
            CurrentWriter.Write_CrypticS_SingleArray(mMeter)
            CurrentWriter.Write_CrypticS_SingleArray(mRanged_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mMelee_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mAOE_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mSmashing_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mLethal_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mFire_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mCold_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mEnergy_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mNegativeEnergy_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mPsionic_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mToxic_Elude)
            CurrentWriter.Write_CrypticS_SingleArray(mElusivity11)
            CurrentWriter.Write_CrypticS_SingleArray(mElusivity12)
            CurrentWriter.Write_CrypticS_SingleArray(mElusivity13)
            CurrentWriter.Write_CrypticS_SingleArray(mElusivity14)
            CurrentWriter.Write_CrypticS_SingleArray(mElusivity15)
            CurrentWriter.Write_CrypticS_SingleArray(mElusivity16)
            CurrentWriter.Write_CrypticS_SingleArray(mElusivity17)
            CurrentWriter.Write_CrypticS_SingleArray(mElusivity18)
            CurrentWriter.Write_CrypticS_SingleArray(mElusivity19)
            CurrentWriter.Write_CrypticS_SingleArray(mDefense2)
            CurrentWriter.Write_CrypticS_SingleArray(mAbsorb)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mSmashing = CurrentReader.Read_CrypticS_SingleArray()
            mLethal = CurrentReader.Read_CrypticS_SingleArray()
            mFire = CurrentReader.Read_CrypticS_SingleArray()
            mCold = CurrentReader.Read_CrypticS_SingleArray()
            mEnergy = CurrentReader.Read_CrypticS_SingleArray()
            mNegative_Energy = CurrentReader.Read_CrypticS_SingleArray()
            mPsionic = CurrentReader.Read_CrypticS_SingleArray()
            mHeal = CurrentReader.Read_CrypticS_SingleArray()
            mSpecial = CurrentReader.Read_CrypticS_SingleArray()
            mToxic = CurrentReader.Read_CrypticS_SingleArray()
            mRadiation = CurrentReader.Read_CrypticS_SingleArray()
            mElectrical = CurrentReader.Read_CrypticS_SingleArray()
            mUnique1 = CurrentReader.Read_CrypticS_SingleArray()
            mUnique2 = CurrentReader.Read_CrypticS_SingleArray()
            mUnique3 = CurrentReader.Read_CrypticS_SingleArray()
            mDamageType15 = CurrentReader.Read_CrypticS_SingleArray()
            mDamageType16 = CurrentReader.Read_CrypticS_SingleArray()
            mDamageType17 = CurrentReader.Read_CrypticS_SingleArray()
            mDamageType18 = CurrentReader.Read_CrypticS_SingleArray()
            mDamageType19 = CurrentReader.Read_CrypticS_SingleArray()
            mHitPoints = CurrentReader.Read_CrypticS_SingleArray()
            mEndurance = CurrentReader.Read_CrypticS_SingleArray()
            mInsight = CurrentReader.Read_CrypticS_SingleArray()
            '!!REDUNDENT!!mIdea = CurrentReader.Read_CrypticS_SingleArray()
            mRage = CurrentReader.Read_CrypticS_SingleArray()
            mToHit = CurrentReader.Read_CrypticS_SingleArray()
            mRanged_Attack = CurrentReader.Read_CrypticS_SingleArray()
            mMelee_Attack = CurrentReader.Read_CrypticS_SingleArray()
            mAOE_Attack = CurrentReader.Read_CrypticS_SingleArray()
            mSmashing_Attack = CurrentReader.Read_CrypticS_SingleArray()
            mLethal_Attack = CurrentReader.Read_CrypticS_SingleArray()
            mFire_Attack = CurrentReader.Read_CrypticS_SingleArray()
            mCold_Attack = CurrentReader.Read_CrypticS_SingleArray()
            mEnergy_Attack = CurrentReader.Read_CrypticS_SingleArray()
            mNegative_EnergyAttack = CurrentReader.Read_CrypticS_SingleArray()
            mPsionic_Attack = CurrentReader.Read_CrypticS_SingleArray()
            mToxic_Attack = CurrentReader.Read_CrypticS_SingleArray()
            mDefenseType11 = CurrentReader.Read_CrypticS_SingleArray()
            mDefenseType12 = CurrentReader.Read_CrypticS_SingleArray()
            mDefenseType13 = CurrentReader.Read_CrypticS_SingleArray()
            mDefenseType14 = CurrentReader.Read_CrypticS_SingleArray()
            mDefenseType15 = CurrentReader.Read_CrypticS_SingleArray()
            mDefenseType16 = CurrentReader.Read_CrypticS_SingleArray()
            mDefenseType17 = CurrentReader.Read_CrypticS_SingleArray()
            mDefenseType18 = CurrentReader.Read_CrypticS_SingleArray()
            mDefenseType19 = CurrentReader.Read_CrypticS_SingleArray()
            mDefense = CurrentReader.Read_CrypticS_SingleArray()
            mSpeedRunning = CurrentReader.Read_CrypticS_SingleArray()
            '!!REDUNDENT!!mRunSpeed = CurrentReader.Read_CrypticS_SingleArray()
            mSpeedFlying = CurrentReader.Read_CrypticS_SingleArray()
            '!!REDUNDENT!!mFlySpeed = CurrentReader.Read_CrypticS_SingleArray()
            mSpeedSwimming = CurrentReader.Read_CrypticS_SingleArray()
            mSpeedJumping = CurrentReader.Read_CrypticS_SingleArray()
            mJumpHeight = CurrentReader.Read_CrypticS_SingleArray()
            mMovementControl = CurrentReader.Read_CrypticS_SingleArray()
            mMovementFriction = CurrentReader.Read_CrypticS_SingleArray()
            mStealth = CurrentReader.Read_CrypticS_SingleArray()
            mStealthRadius = CurrentReader.Read_CrypticS_SingleArray()
            mStealthRadiusPlayer = CurrentReader.Read_CrypticS_SingleArray()
            mPerceptionRadius = CurrentReader.Read_CrypticS_SingleArray()
            mRegeneration = CurrentReader.Read_CrypticS_SingleArray()
            mRecovery = CurrentReader.Read_CrypticS_SingleArray()
            mInsightRecovery = CurrentReader.Read_CrypticS_SingleArray()
            mThreatLevel = CurrentReader.Read_CrypticS_SingleArray()
            mTaunt = CurrentReader.Read_CrypticS_SingleArray()
            mPlacate = CurrentReader.Read_CrypticS_SingleArray()
            mConfused = CurrentReader.Read_CrypticS_SingleArray()
            '!!REDUNDENT!!mConfuse = CurrentReader.Read_CrypticS_SingleArray()
            mAfraid = CurrentReader.Read_CrypticS_SingleArray()
            mTerrorized = CurrentReader.Read_CrypticS_SingleArray()
            '!!REDUNDENT!!mTerrorize = CurrentReader.Read_CrypticS_SingleArray()
            mHeld = CurrentReader.Read_CrypticS_SingleArray()
            mImmobilized = CurrentReader.Read_CrypticS_SingleArray()
            '!!REDUNDENT!!mImmobilize = CurrentReader.Read_CrypticS_SingleArray()
            mStunned = CurrentReader.Read_CrypticS_SingleArray()
            '!!REDUNDENT!!mStun = CurrentReader.Read_CrypticS_SingleArray()
            mSleep = CurrentReader.Read_CrypticS_SingleArray()
            mFly = CurrentReader.Read_CrypticS_SingleArray()
            mJumppack = CurrentReader.Read_CrypticS_SingleArray()
            mTeleport = CurrentReader.Read_CrypticS_SingleArray()
            mUntouchable = CurrentReader.Read_CrypticS_SingleArray()
            mIntangible = CurrentReader.Read_CrypticS_SingleArray()
            mOnlyAffectsSelf = CurrentReader.Read_CrypticS_SingleArray()
            mExperienceGain = CurrentReader.Read_CrypticS_SingleArray()
            mInfluenceGain = CurrentReader.Read_CrypticS_SingleArray()
            mPrestigeGain = CurrentReader.Read_CrypticS_SingleArray()
            mNullBool = CurrentReader.Read_CrypticS_SingleArray()
            '!!REDUNDENT!!mEvade = CurrentReader.Read_CrypticS_SingleArray()
            mKnockup = CurrentReader.Read_CrypticS_SingleArray()
            mKnockback = CurrentReader.Read_CrypticS_SingleArray()
            mRepel = CurrentReader.Read_CrypticS_SingleArray()
            mAccuracy = CurrentReader.Read_CrypticS_SingleArray()
            mRadius = CurrentReader.Read_CrypticS_SingleArray()
            mArc = CurrentReader.Read_CrypticS_SingleArray()
            mRange = CurrentReader.Read_CrypticS_SingleArray()
            mTimeToActivate = CurrentReader.Read_CrypticS_SingleArray()
            mRechargeTime = CurrentReader.Read_CrypticS_SingleArray()
            mInterruptTime = CurrentReader.Read_CrypticS_SingleArray()
            mEnduranceDiscount = CurrentReader.Read_CrypticS_SingleArray()
            mInsightDiscount = CurrentReader.Read_CrypticS_SingleArray()
            mMeter = CurrentReader.Read_CrypticS_SingleArray()
            mRanged_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mMelee_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mAOE_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mSmashing_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mLethal_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mFire_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mCold_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mEnergy_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mNegativeEnergy_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mPsionic_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mToxic_Elude = CurrentReader.Read_CrypticS_SingleArray()
            mElusivity11 = CurrentReader.Read_CrypticS_SingleArray()
            mElusivity12 = CurrentReader.Read_CrypticS_SingleArray()
            mElusivity13 = CurrentReader.Read_CrypticS_SingleArray()
            mElusivity14 = CurrentReader.Read_CrypticS_SingleArray()
            mElusivity15 = CurrentReader.Read_CrypticS_SingleArray()
            mElusivity16 = CurrentReader.Read_CrypticS_SingleArray()
            mElusivity17 = CurrentReader.Read_CrypticS_SingleArray()
            mElusivity18 = CurrentReader.Read_CrypticS_SingleArray()
            mElusivity19 = CurrentReader.Read_CrypticS_SingleArray()
            mDefense2 = CurrentReader.Read_CrypticS_SingleArray()
            mDefense = mDefense2 '///WHY????? 
            mAbsorb = CurrentReader.Read_CrypticS_SingleArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
