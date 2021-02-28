Imports COH.GameContent.Structures.Animation.FX
Imports COH.GameContent.Structures.Shared.Drawing

Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_Animation_Sequence_Type
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mFileName
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
        Property FileName As String
            Get
                Return mFileName
            End Get
            Set(value As String)
                mFileName = value
            End Set
        End Property
        Property FileAge As Int32
            Get
                Return mFileAge
            End Get
            Set(value As Int32)
                mFileAge = value
            End Set
        End Property
        Property Sequencer As String
            Get
                Return mSequencer
            End Get
            Set(value As String)
                mSequencer = value
            End Set
        End Property
        Property SequencerType As String
            Get
                Return mSequencerType
            End Get
            Set(value As String)
                mSequencerType = value
            End Set
        End Property
        Property Var As COH_Animation_Sequence_Var()
            Get
                Return mVar
            End Get
            Set(value As COH_Animation_Sequence_Var())
                mVar = value
            End Set
        End Property
        Property AnimScale As Single
            Get
                Return mAnimScale
            End Get
            Set(value As Single)
                mAnimScale = value
            End Set
        End Property
        Property Graphics As String
            Get
                Return mGraphics
            End Get
            Set(value As String)
                mGraphics = value
            End Set
        End Property
        Property LODs As Single()
            Get
                Return mLODs
            End Get
            Set(value As Single())
                mLODs = value
            End Set
        End Property
        Property VisSphereRadius As Single
            Get
                Return mVisSphereRadius
            End Get
            Set(value As Single)
                mVisSphereRadius = value
            End Set
        End Property
        Property MaxAlpha As Byte
            Get
                Return mMaxAlpha
            End Get
            Set(value As Byte)
                mMaxAlpha = value
            End Set
        End Property
        Property ReverseFadeOutDist As Single
            Get
                Return mReverseFadeOutDist
            End Get
            Set(value As Single)
                mReverseFadeOutDist = value
            End Set
        End Property
        Property FadeOutStart As Single
            Get
                Return mFadeOutStart
            End Get
            Set(value As Single)
                mFadeOutStart = value
            End Set
        End Property
        Property FadeOutFinish As Single
            Get
                Return mFadeOutFinish
            End Get
            Set(value As Single)
                mFadeOutFinish = value
            End Set
        End Property
        Property TicksToLingerAfterDeath As Int32
            Get
                Return mTicksToLingerAfterDeath
            End Get
            Set(value As Int32)
                mTicksToLingerAfterDeath = value
            End Set
        End Property
        Property TicksToFadeAwayAfterDeath As Int32
            Get
                Return mTicksToFadeAwayAfterDeath
            End Get
            Set(value As Int32)
                mTicksToFadeAwayAfterDeath = value
            End Set
        End Property
        Property ShadowType As Int32
            Get
                Return mShadowType
            End Get
            Set(value As Int32)
                mShadowType = value
            End Set
        End Property
        Property ShadowTexture As String
            Get
                Return mShadowTexture
            End Get
            Set(value As String)
                mShadowTexture = value
            End Set
        End Property
        Property ShadowQuality As Int32
            Get
                Return mShadowQuality
            End Get
            Set(value As Int32)
                mShadowQuality = value
            End Set
        End Property
        Property ShadowSize As COH_Struct_Vector3
            Get
                Return mShadowSize
            End Get
            Set(value As COH_Struct_Vector3)
                mShadowSize = value
            End Set
        End Property
        Property ShadowOffset As COH_Struct_Vector3
            Get
                Return mShadowOffset
            End Get
            Set(value As COH_Struct_Vector3)
                mShadowOffset = value
            End Set
        End Property
        Property Flags As COH_EnumFlags_AnimationSequence
            Get
                Return mFlags
            End Get
            Set(value As COH_EnumFlags_AnimationSequence)
                mFlags = value
            End Set
        End Property
        Property LightAsDoorOutside As Int32
            Get
                Return mLightAsDoorOutside
            End Get
            Set(value As Int32)
                mLightAsDoorOutside = value
            End Set
        End Property
        Property RejectContinuingFX As Int32
            Get
                Return mRejectContinuingFX
            End Get
            Set(value As Int32)
                mRejectContinuingFX = value
            End Set
        End Property
        Property GeomScale As COH_Vector3 '//// MAK - Default of 1 for each component isn't supported any more
            Get
                Return mGeomScale
            End Get
            Set(value As COH_Vector3)
                mGeomScale = value
            End Set
        End Property
        Property GeomScaleMax As COH_Struct_Vector3
            Get
                Return mGeomScaleMax
            End Get
            Set(value As COH_Struct_Vector3)
                mGeomScaleMax = value
            End Set
        End Property
        Property CapsuleSize As COH_Struct_Vector3
            Get
                Return mCapsuleSize
            End Get
            Set(value As COH_Struct_Vector3)
                mCapsuleSize = value
            End Set
        End Property
        Property CapsuleOffset As COH_Struct_Vector3
            Get
                Return mCapsuleOffset
            End Get
            Set(value As COH_Struct_Vector3)
                mCapsuleOffset = value
            End Set
        End Property
        Property BoneCapsule As COH_BoneCapsule()
            Get
                Return mBoneCapsule
            End Get
            Set(value As COH_BoneCapsule())
                mBoneCapsule = value
            End Set
        End Property
        Property HasRandomName As Int32
            Get
                Return mHasRandomName
            End Get
            Set(value As Int32)
                mHasRandomName = value
            End Set
        End Property
        Property RandomNameFile As String
            Get
                Return mRandomNameFile
            End Get
            Set(value As String)
                mRandomNameFile = value
            End Set
        End Property
        Property BigMonster As Int32
            Get
                Return mBigMonster
            End Get
            Set(value As Int32)
                mBigMonster = value
            End Set
        End Property
        Property Fx As String()
            Get
                Return mFx
            End Get
            Set(value As String())
                mFx = value
            End Set
        End Property
        Property OnClickFx As String
            Get
                Return mOnClickFx
            End Get
            Set(value As String)
                mOnClickFx = value
            End Set
        End Property
        Property HealthFx As COH_FX_Health()
            Get
                Return mHealthFx
            End Get
            Set(value As COH_FX_Health())
                mHealthFx = value
            End Set
        End Property
        Property MinimumAmbient As Single
            Get
                Return mMinimumAmbient
            End Get
            Set(value As Single)
                mMinimumAmbient = value
            End Set
        End Property
        Property BoneScaleFat As String
            Get
                Return mBoneScaleFat
            End Get
            Set(value As String)
                mBoneScaleFat = value
            End Set
        End Property
        Property BoneScaleSkinny As String
            Get
                Return mBoneScaleSkinny
            End Get
            Set(value As String)
                mBoneScaleSkinny = value
            End Set
        End Property
        Property RandomBoneScale As Int32
            Get
                Return mRandomBoneScale
            End Get
            Set(value As Int32)
                mRandomBoneScale = value
            End Set
        End Property
        Property NotSelectable As Int32
            Get
                Return mNotSelectable
            End Get
            Set(value As Int32)
                mNotSelectable = value
            End Set
        End Property
        Property CollisionType As Int32
            Get
                Return mCollisionType
            End Get
            Set(value As Int32)
                mCollisionType = value
            End Set
        End Property
        Property Bounciness As Single
            Get
                Return mBounciness
            End Get
            Set(value As Single)
                mBounciness = value
            End Set
        End Property
        Property Placement As Int32
            Get
                Return mPlacement
            End Get
            Set(value As Int32)
                mPlacement = value
            End Set
        End Property
        Property Selection As Int32
            Get
                Return mSelection
            End Get
            Set(value As Int32)
                mSelection = value
            End Set
        End Property
        Property ConstantState As String()
            Get
                Return mConstantState
            End Get
            Set(value As String())
                mConstantState = value
            End Set
        End Property
        Property ReticleHeightBias As Single
            Get
                Return mReticleHeightBias
            End Get
            Set(value As Single)
                mReticleHeightBias = value
            End Set
        End Property
        Property ReticleWidthBias As Single
            Get
                Return mReticleWidthBias
            End Get
            Set(value As Single)
                mReticleWidthBias = value
            End Set
        End Property
        Property ReticleBaseBias As Single
            Get
                Return mReticleBaseBias
            End Get
            Set(value As Single)
                mReticleBaseBias = value
            End Set
        End Property
        Property ShoulderScaleSkinny As COH_Struct_Vector3
            Get
                Return mShoulderScaleSkinny
            End Get
            Set(value As COH_Struct_Vector3)
                mShoulderScaleSkinny = value
            End Set
        End Property
        Property ShoulderScaleFat As COH_Struct_Vector3
            Get
                Return mShoulderScaleFat
            End Get
            Set(value As COH_Struct_Vector3)
                mShoulderScaleFat = value
            End Set
        End Property
        Property HipScale As COH_Struct_Vector3
            Get
                Return mHipScale
            End Get
            Set(value As COH_Struct_Vector3)
                mHipScale = value
            End Set
        End Property
        Property NeckScale As COH_Struct_Vector3
            Get
                Return mNeckScale
            End Get
            Set(value As COH_Struct_Vector3)
                mNeckScale = value
            End Set
        End Property
        Property LegScaleVec As COH_Struct_Vector3
            Get
                Return mLegScaleVec
            End Get
            Set(value As COH_Struct_Vector3)
                mLegScaleVec = value
            End Set
        End Property
        Property HeadScaleRange As Single
            Get
                Return mHeadScaleRange
            End Get
            Set(value As Single)
                mHeadScaleRange = value
            End Set
        End Property
        Property ShoulderScaleRange As Single
            Get
                Return mShoulderScaleRange
            End Get
            Set(value As Single)
                mShoulderScaleRange = value
            End Set
        End Property
        Property ChestScaleRange As Single
            Get
                Return mChestScaleRange
            End Get
            Set(value As Single)
                mChestScaleRange = value
            End Set
        End Property
        Property WaistScaleRange As Single
            Get
                Return mWaistScaleRange
            End Get
            Set(value As Single)
                mWaistScaleRange = value
            End Set
        End Property
        Property HipScaleRange As Single
            Get
                Return mHipScaleRange
            End Get
            Set(value As Single)
                mHipScaleRange = value
            End Set
        End Property
        Property LegScaleMin As Single
            Get
                Return mLegScaleMin
            End Get
            Set(value As Single)
                mLegScaleMin = value
            End Set
        End Property
        Property LegScaleMax As Single
            Get
                Return mLegScaleMax
            End Get
            Set(value As Single)
                mLegScaleMax = value
            End Set
        End Property
        Property HeadScaleMin As COH_Struct_Vector3
            Get
                Return mHeadScaleMin
            End Get
            Set(value As COH_Struct_Vector3)
                mHeadScaleMin = value
            End Set
        End Property
        Property HeadScaleMax As COH_Struct_Vector3
            Get
                Return mHeadScaleMax
            End Get
            Set(value As COH_Struct_Vector3)
                mHeadScaleMax = value
            End Set
        End Property
        Property LegScaleRatio As Single
            Get
                Return mLegScaleRatio
            End Get
            Set(value As Single)
                mLegScaleRatio = value
            End Set
        End Property
        Property SpawnOffsetY As Single
            Get
                Return mSpawnOffsetY
            End Get
            Set(value As Single)
                mSpawnOffsetY = value
            End Set
        End Property
        Property NoStrafe As Int32
            Get
                Return mNoStrafe
            End Get
            Set(value As Int32)
                mNoStrafe = value
            End Set
        End Property
        Property TurnSpeed As Single
            Get
                Return mTurnSpeed
            End Get
            Set(value As Single)
                mTurnSpeed = value
            End Set
        End Property
        Property CameraHeight As Single
            Get
                Return mCameraHeight
            End Get
            Set(value As Single)
                mCameraHeight = value
            End Set
        End Property
        Property Pushable As Int32
            Get
                Return mPushable
            End Get
            Set(value As Int32)
                mPushable = value
            End Set
        End Property
        Property FullBodyPortrait As Int32
            Get
                Return mFullBodyPortrait
            End Get
            Set(value As Int32)
                mFullBodyPortrait = value
            End Set
        End Property
        Property StaticLighting As Int32
            Get
                Return mStaticLighting
            End Get
            Set(value As Int32)
                mStaticLighting = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mFileName As String
       Private mFileAge As Int32
       Private mSequencer As String
       Private mSequencerType As String
       Private mVar As COH_Animation_Sequence_Var()
       Private mAnimScale As Single
       Private mGraphics As String
       Private mLODs As Single()
       Private mVisSphereRadius As Single
       Private mMaxAlpha As Byte
       Private mReverseFadeOutDist As Single
       Private mFadeOutStart As Single
       Private mFadeOutFinish As Single
       Private mTicksToLingerAfterDeath As Int32
       Private mTicksToFadeAwayAfterDeath As Int32
       Private mShadowType As Int32
       Private mShadowTexture As String
       Private mShadowQuality As Int32
       Private mShadowSize As COH_Struct_Vector3
       Private mShadowOffset As COH_Struct_Vector3
       Private mFlags As COH_EnumFlags_AnimationSequence
       Private mLightAsDoorOutside As Int32
       Private mRejectContinuingFX As Int32
       Private mGeomScale As COH_Vector3
       Private mGeomScaleMax As COH_Struct_Vector3
       Private mCapsuleSize As COH_Struct_Vector3
       Private mCapsuleOffset As COH_Struct_Vector3
       Private mBoneCapsule As COH_BoneCapsule()
       Private mHasRandomName As Int32
       Private mRandomNameFile As String
       Private mBigMonster As Int32
       Private mFx As String()
       Private mOnClickFx As String
       Private mHealthFx As COH_FX_Health()
       Private mMinimumAmbient As Single
       Private mBoneScaleFat As String
       Private mBoneScaleSkinny As String
       Private mRandomBoneScale As Int32
       Private mNotSelectable As Int32
       Private mCollisionType As Int32
       Private mBounciness As Single
       Private mPlacement As Int32
       Private mSelection As Int32
       Private mConstantState As String()
       Private mReticleHeightBias As Single
       Private mReticleWidthBias As Single
       Private mReticleBaseBias As Single
       Private mShoulderScaleSkinny As COH_Struct_Vector3
       Private mShoulderScaleFat As COH_Struct_Vector3
       Private mHipScale As COH_Struct_Vector3
       Private mNeckScale As COH_Struct_Vector3
       Private mLegScaleVec As COH_Struct_Vector3
       Private mHeadScaleRange As Single
       Private mShoulderScaleRange As Single
       Private mChestScaleRange As Single
       Private mWaistScaleRange As Single
       Private mHipScaleRange As Single
       Private mLegScaleMin As Single
       Private mLegScaleMax As Single
       Private mHeadScaleMin As COH_Struct_Vector3
       Private mHeadScaleMax As COH_Struct_Vector3
       Private mLegScaleRatio As Single
       Private mSpawnOffsetY As Single
       Private mNoStrafe As Int32
       Private mTurnSpeed As Single
       Private mCameraHeight As Single
       Private mPushable As Int32
       Private mFullBodyPortrait As Int32
       Private mStaticLighting As Int32
#End Region

        Const MAX_LODS = 4
        Const SEQ_DEFAULT_VISSPHERERADIUS = 5
        Const SEQ_DEFAULT_MAX_ALPHA = 255
        Const SEQ_DEFAULT_TICKS_TO_LINGER_AFTER_DEATH = (20 * 30)
        Const SEQ_DEFAULT_TICKS_TO_FADE_AWAY_AFTER_DEATH = (90)
        Const SEQ_DEFAULT_NEAR_FADE_DISTANCE = 350
        Const SEQ_DEFAULT_RETICLEWIDTHBIAS = 1
        Const SEQ_DEFAULT_RETICLEHEIGHTBIAS = 0.5
        Const SEQ_DEFAULT_RETICLEBASEBIAS = 0.0
        Const SEQ_DEFAULT_FADE_OUT = 100
        Const SEQ_DEFAULT_ENTTYPE_CAPSULESIZE_X = 3.0
        Const SEQ_DEFAULT_ENTTYPE_CAPSULESIZE_Y = 6.0
        Const SEQ_DEFAULT_ENTTYPE_CAPSULESIZE_Z = 3.0
        Const SEQ_CRAZY_HIGH_LOD_DISTANCE = 100000
        Const SEQ_DEFAULT_MINIMUM_AMBIENT = 0.15
        Const SEQ_LOW_SHADOW_DEPTH = 3.0 '//For NPCS And other non jumpers
        Const SEQ_MEDIUM_SHADOW_DEPTH = 15.0 '//For jumpers
        Const SEQ_HIGH_SHADOW_DEPTH = 30.0 '//For fliers

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
            mFileName = String.Empty
            mSequencer = String.Empty
            mSequencerType = String.Empty
            mVar = New COH_Animation_Sequence_Var() {}
            mGraphics = String.Empty
            mShadowTexture = String.Empty
            mShadowSize = New COH_Struct_Vector3
            mShadowOffset = New COH_Struct_Vector3
            mGeomScale = New COH_Vector3(True, 1)
            mGeomScaleMax = New COH_Struct_Vector3
            mCapsuleSize = New COH_Struct_Vector3
            mCapsuleOffset = New COH_Struct_Vector3
            mBoneCapsule = New COH_BoneCapsule() {}
            mRandomNameFile = String.Empty
            mFx = New String() {}
            mOnClickFx = String.Empty
            mHealthFx = New COH_FX_Health() {}
            mBoneScaleFat = String.Empty
            mBoneScaleSkinny = String.Empty
            mConstantState = New String() {}
            mShoulderScaleSkinny = New COH_Struct_Vector3
            mShoulderScaleFat = New COH_Struct_Vector3
            mHipScale = New COH_Struct_Vector3
            mNeckScale = New COH_Struct_Vector3
            mLegScaleVec = New COH_Struct_Vector3
            mHeadScaleMin = New COH_Struct_Vector3
            mHeadScaleMax = New COH_Struct_Vector3
            mLODs = New Single(MAX_LODS - 1) {}
            mVisSphereRadius = SEQ_DEFAULT_VISSPHERERADIUS
            mMaxAlpha = SEQ_DEFAULT_MAX_ALPHA
            mTicksToFadeAwayAfterDeath = SEQ_DEFAULT_TICKS_TO_FADE_AWAY_AFTER_DEATH
            mTicksToLingerAfterDeath = SEQ_DEFAULT_TICKS_TO_LINGER_AFTER_DEATH
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Animation_Sequence_Type
            Dim Result As COH_Animation_Sequence_Type = New COH_Animation_Sequence_Type
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFileName = String.Copy(mFileName)
                .mFileAge = mFileAge
                .mSequencer = mSequencer
                .mSequencerType = mSequencerType
                .mVar = New COH_Animation_Sequence_Var(mVar.Count - 1) {}
                For X = 0 To mVar.Count - 1
                    .mVar(X) = mVar(X).Clone
                Next
                .mAnimScale = mAnimScale
                .mGraphics = String.Copy(mGraphics)
                .mLODs = New Single(MAX_LODS - 1) {}
                For X = 0 To MAX_LODS - 1
                    .mLODs(X) = mLODs(X)
                Next
                .mVisSphereRadius = mVisSphereRadius
                .mMaxAlpha = mMaxAlpha
                .mReverseFadeOutDist = mReverseFadeOutDist
                .mFadeOutStart = mFadeOutStart
                .mFadeOutFinish = mFadeOutFinish
                .mTicksToLingerAfterDeath = mTicksToLingerAfterDeath
                .mTicksToFadeAwayAfterDeath = mTicksToFadeAwayAfterDeath
                .mShadowType = mShadowType
                .mShadowTexture = String.Copy(mShadowTexture)
                .mShadowQuality = mShadowQuality
                .mShadowSize = mShadowSize
                .mShadowOffset = mShadowOffset
                .mFlags = mFlags
                .mLightAsDoorOutside = mLightAsDoorOutside
                .mRejectContinuingFX = mRejectContinuingFX
                .mGeomScale = mGeomScale
                .mGeomScaleMax = mGeomScaleMax
                .mCapsuleSize = mCapsuleSize
                .mCapsuleOffset = mCapsuleOffset
                .mBoneCapsule = New COH_BoneCapsule(mBoneCapsule.Count - 1) {}
                For X = 0 To mBoneCapsule.Count - 1
                    .mBoneCapsule(X) = mBoneCapsule(X).Clone
                Next
                .mHasRandomName = mHasRandomName
                .mRandomNameFile = String.Copy(mRandomNameFile)
                .mBigMonster = mBigMonster
                .mFx = mFx.CloneTheStrings
                .mOnClickFx = String.Copy(mOnClickFx)
                .mHealthFx = New COH_FX_Health(mHealthFx.Count - 1) {}
                For X = 0 To mHealthFx.Count - 1
                    .mHealthFx(X) = mHealthFx(X).Clone
                Next
                .mMinimumAmbient = mMinimumAmbient
                .mBoneScaleFat = String.Copy(mBoneScaleFat)
                .mBoneScaleSkinny = String.Copy(mBoneScaleSkinny)
                .mRandomBoneScale = mRandomBoneScale
                .mNotSelectable = mNotSelectable
                .mCollisionType = mCollisionType
                .mBounciness = mBounciness
                .mPlacement = mPlacement
                .mSelection = mSelection
                .mConstantState = mConstantState.CloneTheStrings
                .mReticleHeightBias = mReticleHeightBias
                .mReticleWidthBias = mReticleWidthBias
                .mReticleBaseBias = mReticleBaseBias
                .mShoulderScaleSkinny = mShoulderScaleSkinny
                .mShoulderScaleFat = mShoulderScaleFat
                .mHipScale = mHipScale
                .mNeckScale = mNeckScale
                .mLegScaleVec = mLegScaleVec
                .mHeadScaleRange = mHeadScaleRange
                .mShoulderScaleRange = mShoulderScaleRange
                .mChestScaleRange = mChestScaleRange
                .mWaistScaleRange = mWaistScaleRange
                .mHipScaleRange = mHipScaleRange
                .mLegScaleMin = mLegScaleMin
                .mLegScaleMax = mLegScaleMax
                .mHeadScaleMin = mHeadScaleMin
                .mHeadScaleMax = mHeadScaleMax
                .mLegScaleRatio = mLegScaleRatio
                .mSpawnOffsetY = mSpawnOffsetY
                .mNoStrafe = mNoStrafe
                .mTurnSpeed = mTurnSpeed
                .mCameraHeight = mCameraHeight
                .mPushable = mPushable
                .mFullBodyPortrait = mFullBodyPortrait
                .mStaticLighting = mStaticLighting
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export -XML"
        Public Overrides Function Determine_DefaultRelativeFilePath(Format As COH_ExportFormat, Optional ShortenPath As Boolean = True) As String
            If Format = COH_ExportFormat.XML Then
                Return mFileName.Substring(mFileName.IndexOf("\") + 1) & ".xml"
            Else
                Return MyBase.Determine_DefaultRelativeFilePath(Format)
            End If
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mType)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mFileName)
            CurrentWriter.Write_CrypticS_TimeStamp(mFileAge)
            CurrentWriter.Write_CrypticS_String(mSequencer)
            CurrentWriter.Write_CrypticS_String(mSequencerType)
            If CurrentWriter.Write_CrypticS_StructArray(mVar) = False Then Return False
            CurrentWriter.Write(mAnimScale)
            CurrentWriter.Write_CrypticS_String(mGraphics)
            CurrentWriter.Write(mLODs(1))
            CurrentWriter.Write(mLODs(2))
            CurrentWriter.Write(mLODs(3))
            CurrentWriter.Write(mVisSphereRadius)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mMaxAlpha)
            CurrentWriter.Write(mReverseFadeOutDist)
            CurrentWriter.Write(mFadeOutStart)
            CurrentWriter.Write(mFadeOutFinish)
            CurrentWriter.Write(mTicksToLingerAfterDeath)
            CurrentWriter.Write(mTicksToFadeAwayAfterDeath)
            CurrentWriter.Write(mShadowType)
            CurrentWriter.Write_CrypticS_String(mShadowTexture)
            CurrentWriter.Write(mShadowQuality)
            CurrentWriter.Write_CrypticS_Vector3(mShadowSize)
            CurrentWriter.Write_CrypticS_Vector3(mShadowOffset)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            CurrentWriter.Write(mLightAsDoorOutside)
            CurrentWriter.Write(mRejectContinuingFX)
            If CurrentWriter.Write_CrypticS_Struct(mGeomScale) = False Then Return False
            CurrentWriter.Write_CrypticS_Vector3(mGeomScaleMax)
            CurrentWriter.Write_CrypticS_Vector3(mCapsuleSize)
            CurrentWriter.Write_CrypticS_Vector3(mCapsuleOffset)
            If CurrentWriter.Write_CrypticS_StructArray(mBoneCapsule) = False Then Return False
            CurrentWriter.Write(mHasRandomName)
            CurrentWriter.Write_CrypticS_String(mRandomNameFile)
            CurrentWriter.Write(mBigMonster)
            CurrentWriter.Write_CrypticS_StringArray(mFx)
            CurrentWriter.Write_CrypticS_String(mOnClickFx)
            If CurrentWriter.Write_CrypticS_StructArray(mHealthFx) = False Then Return False
            CurrentWriter.Write(mMinimumAmbient)
            CurrentWriter.Write_CrypticS_String(mBoneScaleFat)
            CurrentWriter.Write_CrypticS_String(mBoneScaleSkinny)
            CurrentWriter.Write(mRandomBoneScale)
            CurrentWriter.Write(mNotSelectable)
            CurrentWriter.Write(mCollisionType)
            CurrentWriter.Write(mBounciness)
            CurrentWriter.Write(mPlacement)
            CurrentWriter.Write(mSelection)
            CurrentWriter.Write_CrypticS_StringArray(mConstantState)
            CurrentWriter.Write(mReticleHeightBias)
            CurrentWriter.Write(mReticleWidthBias)
            CurrentWriter.Write(mReticleBaseBias)
            CurrentWriter.Write_CrypticS_Vector3(mShoulderScaleSkinny)
            CurrentWriter.Write_CrypticS_Vector3(mShoulderScaleFat)
            CurrentWriter.Write_CrypticS_Vector3(mHipScale)
            CurrentWriter.Write_CrypticS_Vector3(mNeckScale)
            CurrentWriter.Write_CrypticS_Vector3(mLegScaleVec)
            CurrentWriter.Write(mHeadScaleRange)
            CurrentWriter.Write(mShoulderScaleRange)
            CurrentWriter.Write(mChestScaleRange)
            CurrentWriter.Write(mWaistScaleRange)
            CurrentWriter.Write(mHipScaleRange)
            CurrentWriter.Write(mLegScaleMin)
            CurrentWriter.Write(mLegScaleMax)
            CurrentWriter.Write_CrypticS_Vector3(mHeadScaleMin)
            CurrentWriter.Write_CrypticS_Vector3(mHeadScaleMax)
            CurrentWriter.Write(mLegScaleRatio)
            CurrentWriter.Write(mSpawnOffsetY)
            CurrentWriter.Write(mNoStrafe)
            CurrentWriter.Write(mTurnSpeed)
            CurrentWriter.Write(mCameraHeight)
            CurrentWriter.Write(mPushable)
            CurrentWriter.Write(mFullBodyPortrait)
            CurrentWriter.Write(mStaticLighting)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mType = 
            mName = CurrentReader.Read_CrypticS_String
            mFileName = CurrentReader.Read_CrypticS_String
            mFileAge = CurrentReader.Read_CrypticS_TimeStamp
            mSequencer = CurrentReader.Read_CrypticS_String
            mSequencerType = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Animation_Sequence_Var), mVar) = False Then Return False
            mAnimScale = CurrentReader.ReadSingle
            mGraphics = CurrentReader.Read_CrypticS_String

            mLODs(1) = CurrentReader.ReadSingle
            mLODs(2) = CurrentReader.ReadSingle
            mLODs(3) = CurrentReader.ReadSingle

            mVisSphereRadius = CurrentReader.ReadSingle
            mMaxAlpha = CurrentReader.Read_CrypticS_Byte_Aligned4
            mReverseFadeOutDist = CurrentReader.ReadSingle
            mFadeOutStart = CurrentReader.ReadSingle
            mFadeOutFinish = CurrentReader.ReadSingle
            mTicksToLingerAfterDeath = CurrentReader.ReadInt32
            mTicksToFadeAwayAfterDeath = CurrentReader.ReadInt32
            mShadowType = CurrentReader.ReadInt32
            mShadowTexture = CurrentReader.Read_CrypticS_String

            mShadowQuality = CurrentReader.ReadInt32
            mShadowSize = CurrentReader.Read_CrypticS_Vector3
            mShadowOffset = CurrentReader.Read_CrypticS_Vector3
            mFlags = CurrentReader.Read_CrypticS_Flags
            mLightAsDoorOutside = CurrentReader.ReadInt32
            mRejectContinuingFX = CurrentReader.ReadInt32

            If CurrentReader.Read_CrypticS_Struct(GetType(COH_Vector3), mGeomScale) = False Then Return False
            mGeomScaleMax = CurrentReader.Read_CrypticS_Vector3
            mCapsuleSize = CurrentReader.Read_CrypticS_Vector3
            mCapsuleOffset = CurrentReader.Read_CrypticS_Vector3
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_BoneCapsule), mBoneCapsule) = False Then Return False
            mHasRandomName = CurrentReader.ReadInt32
            mRandomNameFile = CurrentReader.Read_CrypticS_String
            mBigMonster = CurrentReader.ReadInt32
            mFx = CurrentReader.Read_CrypticS_StringArray()
            mOnClickFx = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_FX_Health), mHealthFx) = False Then Return False
            mMinimumAmbient = CurrentReader.ReadSingle
            mBoneScaleFat = CurrentReader.Read_CrypticS_String
            mBoneScaleSkinny = CurrentReader.Read_CrypticS_String
            mRandomBoneScale = CurrentReader.ReadInt32
            mNotSelectable = CurrentReader.ReadInt32
            mCollisionType = CurrentReader.ReadInt32
            mBounciness = CurrentReader.ReadSingle
            mPlacement = CurrentReader.ReadInt32
            mSelection = CurrentReader.ReadInt32
            mConstantState = CurrentReader.Read_CrypticS_StringArray()
            mReticleHeightBias = CurrentReader.ReadSingle
            mReticleWidthBias = CurrentReader.ReadSingle
            mReticleBaseBias = CurrentReader.ReadSingle
            mShoulderScaleSkinny = CurrentReader.Read_CrypticS_Vector3
            mShoulderScaleFat = CurrentReader.Read_CrypticS_Vector3
            mHipScale = CurrentReader.Read_CrypticS_Vector3
            mNeckScale = CurrentReader.Read_CrypticS_Vector3
            mLegScaleVec = CurrentReader.Read_CrypticS_Vector3
            mHeadScaleRange = CurrentReader.ReadSingle
            mShoulderScaleRange = CurrentReader.ReadSingle
            mChestScaleRange = CurrentReader.ReadSingle
            mWaistScaleRange = CurrentReader.ReadSingle
            mHipScaleRange = CurrentReader.ReadSingle
            mLegScaleMin = CurrentReader.ReadSingle
            mLegScaleMax = CurrentReader.ReadSingle
            mHeadScaleMin = CurrentReader.Read_CrypticS_Vector3
            mHeadScaleMax = CurrentReader.Read_CrypticS_Vector3
            mLegScaleRatio = CurrentReader.ReadSingle
            mSpawnOffsetY = CurrentReader.ReadSingle
            mNoStrafe = CurrentReader.ReadInt32
            mTurnSpeed = CurrentReader.ReadSingle
            mCameraHeight = CurrentReader.ReadSingle
            mPushable = CurrentReader.ReadInt32
            mFullBodyPortrait = CurrentReader.ReadInt32
            mStaticLighting = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
