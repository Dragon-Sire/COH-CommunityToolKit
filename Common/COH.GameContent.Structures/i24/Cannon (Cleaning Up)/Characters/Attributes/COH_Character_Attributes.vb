Namespace GameContent.Structures.Characters.Attributes
    Public NotInheritable Class COH_CharacterClass_Attributes
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Attributes"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Smashing As Single
            Get
                Return mSmashing
            End Get
            Set(value As Single)
                SetValue(mSmashing, value)
            End Set
        End Property
        Property Lethal As Single
            Get
                Return mLethal
            End Get
            Set(value As Single)
                SetValue(mLethal, value)
            End Set
        End Property
        Property Fire As Single
            Get
                Return mFire
            End Get
            Set(value As Single)
                SetValue(mFire, value)
            End Set
        End Property
        Property Cold As Single
            Get
                Return mCold
            End Get
            Set(value As Single)
                SetValue(mCold, value)
            End Set
        End Property
        Property Energy As Single
            Get
                Return mEnergy
            End Get
            Set(value As Single)
                SetValue(mEnergy, value)
            End Set
        End Property
        Property Negative_Energy As Single
            Get
                Return mNegative_Energy
            End Get
            Set(value As Single)
                SetValue(mNegative_Energy, value)
            End Set
        End Property
        Property Psionic As Single
            Get
                Return mPsionic
            End Get
            Set(value As Single)
                SetValue(mPsionic, value)
            End Set
        End Property
        Property Heal As Single
            Get
                Return mHeal
            End Get
            Set(value As Single)
                SetValue(mHeal, value)
            End Set
        End Property
        Property Special As Single
            Get
                Return mSpecial
            End Get
            Set(value As Single)
                SetValue(mSpecial, value)
            End Set
        End Property
        Property Toxic As Single
            Get
                Return mToxic
            End Get
            Set(value As Single)
                SetValue(mToxic, value)
            End Set
        End Property
        Property Radiation As Single
            Get
                Return mRadiation
            End Get
            Set(value As Single)
                SetValue(mRadiation, value)
            End Set
        End Property
        Property Electtrical As Single
            Get
                Return mElecttrical
            End Get
            Set(value As Single)
                SetValue(mElecttrical, value)
            End Set
        End Property
        Property Unique1 As Single
            Get
                Return mUnique1
            End Get
            Set(value As Single)
                SetValue(mUnique1, value)
            End Set
        End Property
        Property Unique2 As Single
            Get
                Return mUnique2
            End Get
            Set(value As Single)
                SetValue(mUnique2, value)
            End Set
        End Property
        Property Unique3 As Single
            Get
                Return mUnique3
            End Get
            Set(value As Single)
                SetValue(mUnique3, value)
            End Set
        End Property
        Property DamageType15 As Single
            Get
                Return mDamageType15
            End Get
            Set(value As Single)
                SetValue(mDamageType15, value)
            End Set
        End Property
        Property DamageType16 As Single
            Get
                Return mDamageType16
            End Get
            Set(value As Single)
                SetValue(mDamageType16, value)
            End Set
        End Property
        Property DamageType17 As Single
            Get
                Return mDamageType17
            End Get
            Set(value As Single)
                SetValue(mDamageType17, value)
            End Set
        End Property
        Property DamageType18 As Single
            Get
                Return mDamageType18
            End Get
            Set(value As Single)
                SetValue(mDamageType18, value)
            End Set
        End Property
        Property DamageType19 As Single
            Get
                Return mDamageType19
            End Get
            Set(value As Single)
                SetValue(mDamageType19, value)
            End Set
        End Property
        Property HitPoints As Single
            Get
                Return mHitPoints
            End Get
            Set(value As Single)
                SetValue(mHitPoints, value)
            End Set
        End Property
        Property Absorb As Single
            Get
                Return mAbsorb
            End Get
            Set(value As Single)
                SetValue(mAbsorb, value)
            End Set
        End Property
        Property Endurance As Single
            Get
                Return mEndurance
            End Get
            Set(value As Single)
                SetValue(mEndurance, value)
            End Set
        End Property
        Property Insight As Single
            Get
                Return mInsight
            End Get
            Set(value As Single)
                SetValue(mInsight, value)
            End Set
        End Property
        Property Rage As Single
            Get
                Return mRage
            End Get
            Set(value As Single)
                SetValue(mRage, value)
            End Set
        End Property
        Property ToHit As Single
            Get
                Return mToHit
            End Get
            Set(value As Single)
                SetValue(mToHit, value)
            End Set
        End Property
        Property Ranged_Attack As Single
            Get
                Return mRanged_Attack
            End Get
            Set(value As Single)
                SetValue(mRanged_Attack, value)
            End Set
        End Property
        Property Melee_Attack As Single
            Get
                Return mMelee_Attack
            End Get
            Set(value As Single)
                SetValue(mMelee_Attack, value)
            End Set
        End Property
        Property AOE_Attack As Single
            Get
                Return mAOE_Attack
            End Get
            Set(value As Single)
                SetValue(mAOE_Attack, value)
            End Set
        End Property
        Property Smashing_Attack As Single
            Get
                Return mSmashing_Attack
            End Get
            Set(value As Single)
                SetValue(mSmashing_Attack, value)
            End Set
        End Property
        Property Lethal_Attack As Single
            Get
                Return mLethal_Attack
            End Get
            Set(value As Single)
                SetValue(mLethal_Attack, value)
            End Set
        End Property
        Property Fire_Attack As Single
            Get
                Return mFire_Attack
            End Get
            Set(value As Single)
                SetValue(mFire_Attack, value)
            End Set
        End Property
        Property Cold_Attack As Single
            Get
                Return mCold_Attack
            End Get
            Set(value As Single)
                SetValue(mCold_Attack, value)
            End Set
        End Property
        Property Energy_Attack As Single
            Get
                Return mEnergy_Attack
            End Get
            Set(value As Single)
                SetValue(mEnergy_Attack, value)
            End Set
        End Property
        Property Negative_EnergyAttack As Single
            Get
                Return mNegative_EnergyAttack
            End Get
            Set(value As Single)
                SetValue(mNegative_EnergyAttack, value)
            End Set
        End Property
        Property Psionic_Attack As Single
            Get
                Return mPsionic_Attack
            End Get
            Set(value As Single)
                SetValue(mPsionic_Attack, value)
            End Set
        End Property
        Property Toxic_Attack As Single
            Get
                Return mToxic_Attack
            End Get
            Set(value As Single)
                SetValue(mToxic_Attack, value)
            End Set
        End Property
        Property DefenseType11 As Single
            Get
                Return mDefenseType11
            End Get
            Set(value As Single)
                SetValue(mDefenseType11, value)
            End Set
        End Property
        Property DefenseType12 As Single
            Get
                Return mDefenseType12
            End Get
            Set(value As Single)
                SetValue(mDefenseType12, value)
            End Set
        End Property
        Property DefenseType13 As Single
            Get
                Return mDefenseType13
            End Get
            Set(value As Single)
                SetValue(mDefenseType13, value)
            End Set
        End Property
        Property DefenseType14 As Single
            Get
                Return mDefenseType14
            End Get
            Set(value As Single)
                SetValue(mDefenseType14, value)
            End Set
        End Property
        Property DefenseType15 As Single
            Get
                Return mDefenseType15
            End Get
            Set(value As Single)
                SetValue(mDefenseType15, value)
            End Set
        End Property
        Property DefenseType16 As Single
            Get
                Return mDefenseType16
            End Get
            Set(value As Single)
                SetValue(mDefenseType16, value)
            End Set
        End Property
        Property DefenseType17 As Single
            Get
                Return mDefenseType17
            End Get
            Set(value As Single)
                SetValue(mDefenseType17, value)
            End Set
        End Property
        Property DefenseType18 As Single
            Get
                Return mDefenseType18
            End Get
            Set(value As Single)
                SetValue(mDefenseType18, value)
            End Set
        End Property
        Property DefenseType19 As Single
            Get
                Return mDefenseType19
            End Get
            Set(value As Single)
                SetValue(mDefenseType19, value)
            End Set
        End Property
        Property Defense As Single
            Get
                Return mDefense
            End Get
            Set(value As Single)
                SetValue(mDefense, value)
            End Set
        End Property
        Property SpeedRunning As Single
            Get
                Return mSpeedRunning
            End Get
            Set(value As Single)
                SetValue(mSpeedRunning, value)
            End Set
        End Property
        Property SpeedFlying As Single
            Get
                Return mSpeedFlying
            End Get
            Set(value As Single)
                SetValue(mSpeedFlying, value)
            End Set
        End Property
        Property SpeedSwimming As Single
            Get
                Return mSpeedSwimming
            End Get
            Set(value As Single)
                SetValue(mSpeedSwimming, value)
            End Set
        End Property
        Property SpeedJumping As Single
            Get
                Return mSpeedJumping
            End Get
            Set(value As Single)
                SetValue(mSpeedJumping, value)
            End Set
        End Property
        Property JumpHeight As Single
            Get
                Return mJumpHeight
            End Get
            Set(value As Single)
                SetValue(mJumpHeight, value)
            End Set
        End Property
        Property MovementControl As Single
            Get
                Return mMovementControl
            End Get
            Set(value As Single)
                SetValue(mMovementControl, value)
            End Set
        End Property
        Property MovementFriction As Single
            Get
                Return mMovementFriction
            End Get
            Set(value As Single)
                SetValue(mMovementFriction, value)
            End Set
        End Property
        Property Stealth As Single
            Get
                Return mStealth
            End Get
            Set(value As Single)
                SetValue(mStealth, value)
            End Set
        End Property
        Property StealthRadius As Single
            Get
                Return mStealthRadius
            End Get
            Set(value As Single)
                SetValue(mStealthRadius, value)
            End Set
        End Property
        Property StealthRadiusPlayer As Single
            Get
                Return mStealthRadiusPlayer
            End Get
            Set(value As Single)
                SetValue(mStealthRadiusPlayer, value)
            End Set
        End Property
        Property PerceptionRadius As Single
            Get
                Return mPerceptionRadius
            End Get
            Set(value As Single)
                SetValue(mPerceptionRadius, value)
            End Set
        End Property
        Property Regeneration As Single
            Get
                Return mRegeneration
            End Get
            Set(value As Single)
                SetValue(mRegeneration, value)
            End Set
        End Property
        Property Recovery As Single
            Get
                Return mRecovery
            End Get
            Set(value As Single)
                SetValue(mRecovery, value)
            End Set
        End Property
        Property InsightRecovery As Single
            Get
                Return mInsightRecovery
            End Get
            Set(value As Single)
                SetValue(mInsightRecovery, value)
            End Set
        End Property
        Property ThreatLevel As Single
            Get
                Return mThreatLevel
            End Get
            Set(value As Single)
                SetValue(mThreatLevel, value)
            End Set
        End Property
        Property Taunt As Single
            Get
                Return mTaunt
            End Get
            Set(value As Single)
                SetValue(mTaunt, value)
            End Set
        End Property
        Property Placate As Single
            Get
                Return mPlacate
            End Get
            Set(value As Single)
                SetValue(mPlacate, value)
            End Set
        End Property
        Property Confused As Single
            Get
                Return mConfused
            End Get
            Set(value As Single)
                SetValue(mConfused, value)
            End Set
        End Property
        Property Afraid As Single
            Get
                Return mAfraid
            End Get
            Set(value As Single)
                SetValue(mAfraid, value)
            End Set
        End Property
        Property Terrorized As Single
            Get
                Return mTerrorized
            End Get
            Set(value As Single)
                SetValue(mTerrorized, value)
            End Set
        End Property
        Property Held As Single
            Get
                Return mHeld
            End Get
            Set(value As Single)
                SetValue(mHeld, value)
            End Set
        End Property
        Property Immobilized As Single
            Get
                Return mImmobilized
            End Get
            Set(value As Single)
                SetValue(mImmobilized, value)
            End Set
        End Property
        Property Stunned As Single
            Get
                Return mStunned
            End Get
            Set(value As Single)
                SetValue(mStunned, value)
            End Set
        End Property
        Property Sleep As Single
            Get
                Return mSleep
            End Get
            Set(value As Single)
                SetValue(mSleep, value)
            End Set
        End Property
        Property Fly As Single
            Get
                Return mFly
            End Get
            Set(value As Single)
                SetValue(mFly, value)
            End Set
        End Property
        Property Jumppack As Single
            Get
                Return mJumppack
            End Get
            Set(value As Single)
                SetValue(mJumppack, value)
            End Set
        End Property
        Property Teleport As Single
            Get
                Return mTeleport
            End Get
            Set(value As Single)
                SetValue(mTeleport, value)
            End Set
        End Property
        Property Untouchable As Single
            Get
                Return mUntouchable
            End Get
            Set(value As Single)
                SetValue(mUntouchable, value)
            End Set
        End Property
        Property Intangible As Single
            Get
                Return mIntangible
            End Get
            Set(value As Single)
                SetValue(mIntangible, value)
            End Set
        End Property
        Property OnlyAffectsSelf As Single
            Get
                Return mOnlyAffectsSelf
            End Get
            Set(value As Single)
                SetValue(mOnlyAffectsSelf, value)
            End Set
        End Property
        Property ExperienceGain As Single
            Get
                Return mExperienceGain
            End Get
            Set(value As Single)
                SetValue(mExperienceGain, value)
            End Set
        End Property
        Property InfluenceGain As Single
            Get
                Return mInfluenceGain
            End Get
            Set(value As Single)
                SetValue(mInfluenceGain, value)
            End Set
        End Property
        Property PrestigeGain As Single
            Get
                Return mPrestigeGain
            End Get
            Set(value As Single)
                SetValue(mPrestigeGain, value)
            End Set
        End Property
        Property NullBool As Single
            Get
                Return mNullBool
            End Get
            Set(value As Single)
                SetValue(mNullBool, value)
            End Set
        End Property
        Property Knockup As Single
            Get
                Return mKnockup
            End Get
            Set(value As Single)
                SetValue(mKnockup, value)
            End Set
        End Property
        Property Knockback As Single
            Get
                Return mKnockback
            End Get
            Set(value As Single)
                SetValue(mKnockback, value)
            End Set
        End Property
        Property Repel As Single
            Get
                Return mRepel
            End Get
            Set(value As Single)
                SetValue(mRepel, value)
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
        Property Range As Single
            Get
                Return mRange
            End Get
            Set(value As Single)
                SetValue(mRange, value)
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
        Property InterruptTime As Single
            Get
                Return mInterruptTime
            End Get
            Set(value As Single)
                SetValue(mInterruptTime, value)
            End Set
        End Property
        Property EnduranceDiscount As Single
            Get
                Return mEnduranceDiscount
            End Get
            Set(value As Single)
                SetValue(mEnduranceDiscount, value)
            End Set
        End Property
        Property InsightDiscount As Single
            Get
                Return mInsightDiscount
            End Get
            Set(value As Single)
                SetValue(mInsightDiscount, value)
            End Set
        End Property
        Property Meter As Single
            Get
                Return mMeter
            End Get
            Set(value As Single)
                SetValue(mMeter, value)
            End Set
        End Property
        Property Ranged_Elude As Single
            Get
                Return mRanged_Elude
            End Get
            Set(value As Single)
                SetValue(mRanged_Elude, value)
            End Set
        End Property
        Property Melee_Elude As Single
            Get
                Return mMelee_Elude
            End Get
            Set(value As Single)
                SetValue(mMelee_Elude, value)
            End Set
        End Property
        Property AOE_Elude As Single
            Get
                Return mAOE_Elude
            End Get
            Set(value As Single)
                SetValue(mAOE_Elude, value)
            End Set
        End Property
        Property Smashing_Elude As Single
            Get
                Return mSmashing_Elude
            End Get
            Set(value As Single)
                SetValue(mSmashing_Elude, value)
            End Set
        End Property
        Property Lethal_Elude As Single
            Get
                Return mLethal_Elude
            End Get
            Set(value As Single)
                SetValue(mLethal_Elude, value)
            End Set
        End Property
        Property Fire_Elude As Single
            Get
                Return mFire_Elude
            End Get
            Set(value As Single)
                SetValue(mFire_Elude, value)
            End Set
        End Property
        Property Cold_Elude As Single
            Get
                Return mCold_Elude
            End Get
            Set(value As Single)
                SetValue(mCold_Elude, value)
            End Set
        End Property
        Property Energy_Elude As Single
            Get
                Return mEnergy_Elude
            End Get
            Set(value As Single)
                SetValue(mEnergy_Elude, value)
            End Set
        End Property
        Property NegativeEnergy_Elude As Single
            Get
                Return mNegativeEnergy_Elude
            End Get
            Set(value As Single)
                SetValue(mNegativeEnergy_Elude, value)
            End Set
        End Property
        Property Psionic_Elude As Single
            Get
                Return mPsionic_Elude
            End Get
            Set(value As Single)
                SetValue(mPsionic_Elude, value)
            End Set
        End Property
        Property Toxic_Elude As Single
            Get
                Return mToxic_Elude
            End Get
            Set(value As Single)
                SetValue(mToxic_Elude, value)
            End Set
        End Property
        Property Elusivity11 As Single
            Get
                Return mElusivity11
            End Get
            Set(value As Single)
                SetValue(mElusivity11, value)
            End Set
        End Property
        Property Elusivity12 As Single
            Get
                Return mElusivity12
            End Get
            Set(value As Single)
                SetValue(mElusivity12, value)
            End Set
        End Property
        Property Elusivity13 As Single
            Get
                Return mElusivity13
            End Get
            Set(value As Single)
                SetValue(mElusivity13, value)
            End Set
        End Property
        Property Elusivity14 As Single
            Get
                Return mElusivity14
            End Get
            Set(value As Single)
                SetValue(mElusivity14, value)
            End Set
        End Property
        Property Elusivity15 As Single
            Get
                Return mElusivity15
            End Get
            Set(value As Single)
                SetValue(mElusivity15, value)
            End Set
        End Property
        Property Elusivity16 As Single
            Get
                Return mElusivity16
            End Get
            Set(value As Single)
                SetValue(mElusivity16, value)
            End Set
        End Property
        Property Elusivity17 As Single
            Get
                Return mElusivity17
            End Get
            Set(value As Single)
                SetValue(mElusivity17, value)
            End Set
        End Property
        Property Elusivity18 As Single
            Get
                Return mElusivity18
            End Get
            Set(value As Single)
                SetValue(mElusivity18, value)
            End Set
        End Property
        Property Elusivity19 As Single
            Get
                Return mElusivity19
            End Get
            Set(value As Single)
                SetValue(mElusivity19, value)
            End Set
        End Property
        Property ElusivityBase As Single
            Get
                Return mElusivityBase
            End Get
            Set(value As Single)
                SetValue(mElusivityBase, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mSmashing As Single
       Private mLethal As Single
       Private mFire As Single
       Private mCold As Single
       Private mEnergy As Single
       Private mNegative_Energy As Single
       Private mPsionic As Single
       Private mHeal As Single
       Private mSpecial As Single
       Private mToxic As Single
       Private mRadiation As Single
       Private mElecttrical As Single
       Private mUnique1 As Single
       Private mUnique2 As Single
       Private mUnique3 As Single
       Private mDamageType15 As Single
       Private mDamageType16 As Single
       Private mDamageType17 As Single
       Private mDamageType18 As Single
       Private mDamageType19 As Single
       Private mHitPoints As Single
       Private mAbsorb As Single
       Private mEndurance As Single
       Private mInsight As Single
       Private mRage As Single
       Private mToHit As Single
       Private mRanged_Attack As Single
       Private mMelee_Attack As Single
       Private mAOE_Attack As Single
       Private mSmashing_Attack As Single
       Private mLethal_Attack As Single
       Private mFire_Attack As Single
       Private mCold_Attack As Single
       Private mEnergy_Attack As Single
       Private mNegative_EnergyAttack As Single
       Private mPsionic_Attack As Single
       Private mToxic_Attack As Single
       Private mDefenseType11 As Single
       Private mDefenseType12 As Single
       Private mDefenseType13 As Single
       Private mDefenseType14 As Single
       Private mDefenseType15 As Single
       Private mDefenseType16 As Single
       Private mDefenseType17 As Single
       Private mDefenseType18 As Single
       Private mDefenseType19 As Single
       Private mDefense As Single
       Private mSpeedRunning As Single
       Private mSpeedFlying As Single
       Private mSpeedSwimming As Single
       Private mSpeedJumping As Single
       Private mJumpHeight As Single
       Private mMovementControl As Single
       Private mMovementFriction As Single
       Private mStealth As Single
       Private mStealthRadius As Single
       Private mStealthRadiusPlayer As Single
       Private mPerceptionRadius As Single
       Private mRegeneration As Single
       Private mRecovery As Single
       Private mInsightRecovery As Single
       Private mThreatLevel As Single
       Private mTaunt As Single
       Private mPlacate As Single
       Private mConfused As Single
       Private mAfraid As Single
       Private mTerrorized As Single
       Private mHeld As Single
       Private mImmobilized As Single
       Private mStunned As Single
       Private mSleep As Single
       Private mFly As Single
       Private mJumppack As Single
       Private mTeleport As Single
       Private mUntouchable As Single
       Private mIntangible As Single
       Private mOnlyAffectsSelf As Single
       Private mExperienceGain As Single
       Private mInfluenceGain As Single
       Private mPrestigeGain As Single
       Private mNullBool As Single
       Private mKnockup As Single
       Private mKnockback As Single
       Private mRepel As Single
       Private mAccuracy As Single
       Private mRadius As Single
       Private mArc As Single
       Private mRange As Single
       Private mTimeToActivate As Single
       Private mRechargeTime As Single
       Private mInterruptTime As Single
       Private mEnduranceDiscount As Single
       Private mInsightDiscount As Single
       Private mMeter As Single
       Private mRanged_Elude As Single
       Private mMelee_Elude As Single
       Private mAOE_Elude As Single
       Private mSmashing_Elude As Single
       Private mLethal_Elude As Single
       Private mFire_Elude As Single
       Private mCold_Elude As Single
       Private mEnergy_Elude As Single
       Private mNegativeEnergy_Elude As Single
       Private mPsionic_Elude As Single
       Private mToxic_Elude As Single
       Private mElusivity11 As Single
       Private mElusivity12 As Single
       Private mElusivity13 As Single
       Private mElusivity14 As Single
       Private mElusivity15 As Single
       Private mElusivity16 As Single
       Private mElusivity17 As Single
       Private mElusivity18 As Single
       Private mElusivity19 As Single
       Private mElusivityBase As Single
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
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CharacterClass_Attributes
            Dim Result As COH_CharacterClass_Attributes = New COH_CharacterClass_Attributes
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mSmashing = mSmashing
                .mLethal = mLethal
                .mFire = mFire
                .mCold = mCold
                .mEnergy = mEnergy
                .mNegative_Energy = mNegative_Energy
                .mPsionic = mPsionic
                .mHeal = mHeal
                .mSpecial = mSpecial
                .mToxic = mToxic
                .mRadiation = mRadiation
                .mElecttrical = mElecttrical
                .mUnique1 = mUnique1
                .mUnique2 = mUnique2
                .mUnique3 = mUnique3
                .mDamageType15 = mDamageType15
                .mDamageType16 = mDamageType16
                .mDamageType17 = mDamageType17
                .mDamageType18 = mDamageType18
                .mDamageType19 = mDamageType19
                .mHitPoints = mHitPoints
                .mAbsorb = mAbsorb
                .mEndurance = mEndurance
                .mInsight = mInsight
                .mRage = mRage
                .mToHit = mToHit
                .mRanged_Attack = mRanged_Attack
                .mMelee_Attack = mMelee_Attack
                .mAOE_Attack = mAOE_Attack
                .mSmashing_Attack = mSmashing_Attack
                .mLethal_Attack = mLethal_Attack
                .mFire_Attack = mFire_Attack
                .mCold_Attack = mCold_Attack
                .mEnergy_Attack = mEnergy_Attack
                .mNegative_EnergyAttack = mNegative_EnergyAttack
                .mPsionic_Attack = mPsionic_Attack
                .mToxic_Attack = mToxic_Attack
                .mDefenseType11 = mDefenseType11
                .mDefenseType12 = mDefenseType12
                .mDefenseType13 = mDefenseType13
                .mDefenseType14 = mDefenseType14
                .mDefenseType15 = mDefenseType15
                .mDefenseType16 = mDefenseType16
                .mDefenseType17 = mDefenseType17
                .mDefenseType18 = mDefenseType18
                .mDefenseType19 = mDefenseType19
                .mDefense = mDefense
                .mSpeedRunning = mSpeedRunning
                .mSpeedFlying = mSpeedFlying
                .mSpeedSwimming = mSpeedSwimming
                .mSpeedJumping = mSpeedJumping
                .mJumpHeight = mJumpHeight
                .mMovementControl = mMovementControl
                .mMovementFriction = mMovementFriction
                .mStealth = mStealth
                .mStealthRadius = mStealthRadius
                .mStealthRadiusPlayer = mStealthRadiusPlayer
                .mPerceptionRadius = mPerceptionRadius
                .mRegeneration = mRegeneration
                .mRecovery = mRecovery
                .mInsightRecovery = mInsightRecovery
                .mThreatLevel = mThreatLevel
                .mTaunt = mTaunt
                .mPlacate = mPlacate
                .mConfused = mConfused
                .mAfraid = mAfraid
                .mTerrorized = mTerrorized
                .mHeld = mHeld
                .mImmobilized = mImmobilized
                .mStunned = mStunned
                .mSleep = mSleep
                .mFly = mFly
                .mJumppack = mJumppack
                .mTeleport = mTeleport
                .mUntouchable = mUntouchable
                .mIntangible = mIntangible
                .mOnlyAffectsSelf = mOnlyAffectsSelf
                .mExperienceGain = mExperienceGain
                .mInfluenceGain = mInfluenceGain
                .mPrestigeGain = mPrestigeGain
                .mNullBool = mNullBool
                .mKnockup = mKnockup
                .mKnockback = mKnockback
                .mRepel = mRepel
                .mAccuracy = mAccuracy
                .mRadius = mRadius
                .mArc = mArc
                .mRange = mRange
                .mTimeToActivate = mTimeToActivate
                .mRechargeTime = mRechargeTime
                .mInterruptTime = mInterruptTime
                .mEnduranceDiscount = mEnduranceDiscount
                .mInsightDiscount = mInsightDiscount
                .mMeter = mMeter
                .mRanged_Elude = mRanged_Elude
                .mMelee_Elude = mMelee_Elude
                .mAOE_Elude = mAOE_Elude
                .mSmashing_Elude = mSmashing_Elude
                .mLethal_Elude = mLethal_Elude
                .mFire_Elude = mFire_Elude
                .mCold_Elude = mCold_Elude
                .mEnergy_Elude = mEnergy_Elude
                .mNegativeEnergy_Elude = mNegativeEnergy_Elude
                .mPsionic_Elude = mPsionic_Elude
                .mToxic_Elude = mToxic_Elude
                .mElusivity11 = mElusivity11
                .mElusivity12 = mElusivity12
                .mElusivity13 = mElusivity13
                .mElusivity14 = mElusivity14
                .mElusivity15 = mElusivity15
                .mElusivity16 = mElusivity16
                .mElusivity17 = mElusivity17
                .mElusivity18 = mElusivity18
                .mElusivity19 = mElusivity19
                .mElusivityBase = mElusivityBase
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mSmashing)
            CurrentWriter.Write(mLethal)
            CurrentWriter.Write(mFire)
            CurrentWriter.Write(mCold)
            CurrentWriter.Write(mEnergy)
            CurrentWriter.Write(mNegative_Energy)
            CurrentWriter.Write(mPsionic)
            CurrentWriter.Write(mHeal)
            CurrentWriter.Write(mSpecial)
            CurrentWriter.Write(mToxic)
            CurrentWriter.Write(mRadiation)
            CurrentWriter.Write(mElecttrical)
            CurrentWriter.Write(mUnique1)
            CurrentWriter.Write(mUnique2)
            CurrentWriter.Write(mUnique3)
            CurrentWriter.Write(mDamageType15)
            CurrentWriter.Write(mDamageType16)
            CurrentWriter.Write(mDamageType17)
            CurrentWriter.Write(mDamageType18)
            CurrentWriter.Write(mDamageType19)
            CurrentWriter.Write(mHitPoints)
            CurrentWriter.Write(mAbsorb)
            CurrentWriter.Write(mEndurance)
            CurrentWriter.Write(mInsight)
            '!!REDUNDENT!!CurrentWriter.Write(mIdea)
            CurrentWriter.Write(mRage)
            CurrentWriter.Write(mToHit)
            CurrentWriter.Write(mRanged_Attack)
            CurrentWriter.Write(mMelee_Attack)
            CurrentWriter.Write(mAOE_Attack)
            CurrentWriter.Write(mSmashing_Attack)
            CurrentWriter.Write(mLethal_Attack)
            CurrentWriter.Write(mFire_Attack)
            CurrentWriter.Write(mCold_Attack)
            CurrentWriter.Write(mEnergy_Attack)
            CurrentWriter.Write(mNegative_EnergyAttack)
            CurrentWriter.Write(mPsionic_Attack)
            CurrentWriter.Write(mToxic_Attack)
            CurrentWriter.Write(mDefenseType11)
            CurrentWriter.Write(mDefenseType12)
            CurrentWriter.Write(mDefenseType13)
            CurrentWriter.Write(mDefenseType14)
            CurrentWriter.Write(mDefenseType15)
            CurrentWriter.Write(mDefenseType16)
            CurrentWriter.Write(mDefenseType17)
            CurrentWriter.Write(mDefenseType18)
            CurrentWriter.Write(mDefenseType19)
            CurrentWriter.Write(mDefense)
            CurrentWriter.Write(mSpeedRunning)
            '!!REDUNDENT!!CurrentWriter.Write(mRunSpeed)
            CurrentWriter.Write(mSpeedFlying)
            '!!REDUNDENT!!CurrentWriter.Write(mFlySpeed)
            CurrentWriter.Write(mSpeedSwimming)
            CurrentWriter.Write(mSpeedJumping)
            CurrentWriter.Write(mJumpHeight)
            CurrentWriter.Write(mMovementControl)
            CurrentWriter.Write(mMovementFriction)
            CurrentWriter.Write(mStealth)
            CurrentWriter.Write(mStealthRadius)
            CurrentWriter.Write(mStealthRadiusPlayer)
            CurrentWriter.Write(mPerceptionRadius)
            CurrentWriter.Write(mRegeneration)
            CurrentWriter.Write(mRecovery)
            CurrentWriter.Write(mInsightRecovery)
            CurrentWriter.Write(mThreatLevel)
            CurrentWriter.Write(mTaunt)
            CurrentWriter.Write(mPlacate)
            CurrentWriter.Write(mConfused)
            '!!REDUNDENT!!CurrentWriter.Write(mConfuse)
            CurrentWriter.Write(mAfraid)
            CurrentWriter.Write(mTerrorized)
            '!!REDUNDENT!!CurrentWriter.Write(mTerrorize)
            CurrentWriter.Write(mHeld)
            CurrentWriter.Write(mImmobilized)
            '!!REDUNDENT!!CurrentWriter.Write(mImmobilize)
            CurrentWriter.Write(mStunned)
            '!!REDUNDENT!!CurrentWriter.Write(mStun)
            CurrentWriter.Write(mSleep)
            CurrentWriter.Write(mFly)
            CurrentWriter.Write(mJumppack)
            CurrentWriter.Write(mTeleport)
            CurrentWriter.Write(mUntouchable)
            CurrentWriter.Write(mIntangible)
            CurrentWriter.Write(mOnlyAffectsSelf)
            CurrentWriter.Write(mExperienceGain)
            CurrentWriter.Write(mInfluenceGain)
            CurrentWriter.Write(mPrestigeGain)
            CurrentWriter.Write(mNullBool)
            '!!REDUNDENT!!CurrentWriter.Write(mEvade)
            CurrentWriter.Write(mKnockup)
            CurrentWriter.Write(mKnockback)
            CurrentWriter.Write(mRepel)
            CurrentWriter.Write(mAccuracy)
            CurrentWriter.Write(mRadius)
            CurrentWriter.Write(mArc)
            CurrentWriter.Write(mRange)
            CurrentWriter.Write(mTimeToActivate)
            CurrentWriter.Write(mRechargeTime)
            CurrentWriter.Write(mInterruptTime)
            CurrentWriter.Write(mEnduranceDiscount)
            CurrentWriter.Write(mInsightDiscount)
            CurrentWriter.Write(mMeter)
            CurrentWriter.Write(mRanged_Elude)
            CurrentWriter.Write(mMelee_Elude)
            CurrentWriter.Write(mAOE_Elude)
            CurrentWriter.Write(mSmashing_Elude)
            CurrentWriter.Write(mLethal_Elude)
            CurrentWriter.Write(mFire_Elude)
            CurrentWriter.Write(mCold_Elude)
            CurrentWriter.Write(mEnergy_Elude)
            CurrentWriter.Write(mNegativeEnergy_Elude)
            CurrentWriter.Write(mPsionic_Elude)
            CurrentWriter.Write(mToxic_Elude)
            CurrentWriter.Write(mElusivity11)
            CurrentWriter.Write(mElusivity12)
            CurrentWriter.Write(mElusivity13)
            CurrentWriter.Write(mElusivity14)
            CurrentWriter.Write(mElusivity15)
            CurrentWriter.Write(mElusivity16)
            CurrentWriter.Write(mElusivity17)
            CurrentWriter.Write(mElusivity18)
            CurrentWriter.Write(mElusivity19)
            CurrentWriter.Write(mElusivityBase)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mSmashing = CurrentReader.ReadSingle
            mLethal = CurrentReader.ReadSingle
            mFire = CurrentReader.ReadSingle
            mCold = CurrentReader.ReadSingle
            mEnergy = CurrentReader.ReadSingle
            mNegative_Energy = CurrentReader.ReadSingle
            mPsionic = CurrentReader.ReadSingle
            mHeal = CurrentReader.ReadSingle
            mSpecial = CurrentReader.ReadSingle
            mToxic = CurrentReader.ReadSingle
            mRadiation = CurrentReader.ReadSingle
            mElecttrical = CurrentReader.ReadSingle
            mUnique1 = CurrentReader.ReadSingle
            mUnique2 = CurrentReader.ReadSingle
            mUnique3 = CurrentReader.ReadSingle
            mDamageType15 = CurrentReader.ReadSingle
            mDamageType16 = CurrentReader.ReadSingle
            mDamageType17 = CurrentReader.ReadSingle
            mDamageType18 = CurrentReader.ReadSingle
            mDamageType19 = CurrentReader.ReadSingle
            mHitPoints = CurrentReader.ReadSingle
            mAbsorb = CurrentReader.ReadSingle
            mEndurance = CurrentReader.ReadSingle
            mInsight = CurrentReader.ReadSingle
            '!!REDUNDENT!!mIdea = CurrentReader.ReadSingle
            mRage = CurrentReader.ReadSingle
            mToHit = CurrentReader.ReadSingle
            mRanged_Attack = CurrentReader.ReadSingle
            mMelee_Attack = CurrentReader.ReadSingle
            mAOE_Attack = CurrentReader.ReadSingle
            mSmashing_Attack = CurrentReader.ReadSingle
            mLethal_Attack = CurrentReader.ReadSingle
            mFire_Attack = CurrentReader.ReadSingle
            mCold_Attack = CurrentReader.ReadSingle
            mEnergy_Attack = CurrentReader.ReadSingle
            mNegative_EnergyAttack = CurrentReader.ReadSingle
            mPsionic_Attack = CurrentReader.ReadSingle
            mToxic_Attack = CurrentReader.ReadSingle
            mDefenseType11 = CurrentReader.ReadSingle
            mDefenseType12 = CurrentReader.ReadSingle
            mDefenseType13 = CurrentReader.ReadSingle
            mDefenseType14 = CurrentReader.ReadSingle
            mDefenseType15 = CurrentReader.ReadSingle
            mDefenseType16 = CurrentReader.ReadSingle
            mDefenseType17 = CurrentReader.ReadSingle
            mDefenseType18 = CurrentReader.ReadSingle
            mDefenseType19 = CurrentReader.ReadSingle
            mDefense = CurrentReader.ReadSingle
            mSpeedRunning = CurrentReader.ReadSingle
            '!!REDUNDENT!!mRunSpeed = CurrentReader.ReadSingle
            mSpeedFlying = CurrentReader.ReadSingle
            '!!REDUNDENT!!mFlySpeed = CurrentReader.ReadSingle
            mSpeedSwimming = CurrentReader.ReadSingle
            mSpeedJumping = CurrentReader.ReadSingle
            mJumpHeight = CurrentReader.ReadSingle
            mMovementControl = CurrentReader.ReadSingle
            mMovementFriction = CurrentReader.ReadSingle
            mStealth = CurrentReader.ReadSingle
            mStealthRadius = CurrentReader.ReadSingle
            mStealthRadiusPlayer = CurrentReader.ReadSingle
            mPerceptionRadius = CurrentReader.ReadSingle
            mRegeneration = CurrentReader.ReadSingle
            mRecovery = CurrentReader.ReadSingle
            mInsightRecovery = CurrentReader.ReadSingle
            mThreatLevel = CurrentReader.ReadSingle
            mTaunt = CurrentReader.ReadSingle
            mPlacate = CurrentReader.ReadSingle
            mConfused = CurrentReader.ReadSingle
            '!!REDUNDENT!!mConfuse = CurrentReader.ReadSingle
            mAfraid = CurrentReader.ReadSingle
            mTerrorized = CurrentReader.ReadSingle
            '!!REDUNDENT!!mTerrorize = CurrentReader.ReadSingle
            mHeld = CurrentReader.ReadSingle
            mImmobilized = CurrentReader.ReadSingle
            '!!REDUNDENT!!mImmobilize = CurrentReader.ReadSingle
            mStunned = CurrentReader.ReadSingle
            '!!REDUNDENT!!mStun = CurrentReader.ReadSingle
            mSleep = CurrentReader.ReadSingle
            mFly = CurrentReader.ReadSingle
            mJumppack = CurrentReader.ReadSingle
            mTeleport = CurrentReader.ReadSingle
            mUntouchable = CurrentReader.ReadSingle
            mIntangible = CurrentReader.ReadSingle
            mOnlyAffectsSelf = CurrentReader.ReadSingle
            mExperienceGain = CurrentReader.ReadSingle
            mInfluenceGain = CurrentReader.ReadSingle
            mPrestigeGain = CurrentReader.ReadSingle
            mNullBool = CurrentReader.ReadSingle
            '!!REDUNDENT!!mEvade = CurrentReader.ReadSingle
            mKnockup = CurrentReader.ReadSingle
            mKnockback = CurrentReader.ReadSingle
            mRepel = CurrentReader.ReadSingle
            mAccuracy = CurrentReader.ReadSingle
            mRadius = CurrentReader.ReadSingle
            mArc = CurrentReader.ReadSingle
            mRange = CurrentReader.ReadSingle
            mTimeToActivate = CurrentReader.ReadSingle
            mRechargeTime = CurrentReader.ReadSingle
            mInterruptTime = CurrentReader.ReadSingle
            mEnduranceDiscount = CurrentReader.ReadSingle
            mInsightDiscount = CurrentReader.ReadSingle
            mMeter = CurrentReader.ReadSingle
            mRanged_Elude = CurrentReader.ReadSingle
            mMelee_Elude = CurrentReader.ReadSingle
            mAOE_Elude = CurrentReader.ReadSingle
            mSmashing_Elude = CurrentReader.ReadSingle
            mLethal_Elude = CurrentReader.ReadSingle
            mFire_Elude = CurrentReader.ReadSingle
            mCold_Elude = CurrentReader.ReadSingle
            mEnergy_Elude = CurrentReader.ReadSingle
            mNegativeEnergy_Elude = CurrentReader.ReadSingle
            mPsionic_Elude = CurrentReader.ReadSingle
            mToxic_Elude = CurrentReader.ReadSingle
            mElusivity11 = CurrentReader.ReadSingle
            mElusivity12 = CurrentReader.ReadSingle
            mElusivity13 = CurrentReader.ReadSingle
            mElusivity14 = CurrentReader.ReadSingle
            mElusivity15 = CurrentReader.ReadSingle
            mElusivity16 = CurrentReader.ReadSingle
            mElusivity17 = CurrentReader.ReadSingle
            mElusivity18 = CurrentReader.ReadSingle
            mElusivity19 = CurrentReader.ReadSingle
            mElusivityBase = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
