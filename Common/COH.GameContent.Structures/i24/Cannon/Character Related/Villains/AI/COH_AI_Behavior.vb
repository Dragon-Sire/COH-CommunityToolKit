Imports COH.GameContent.Structures.MeshRelated
Imports COH.GameContent.Structures.Shared.Drawing

Namespace GameContent.Structures.Enemies.AI
    Public NotInheritable Class COH_Behavior
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property ParamBitfield As Byte()
            Get
                Return mParamBitfield
            End Get
            Set(value As Byte())
                mParamBitfield = value
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
        Property FileAge As Int32
            Get
                Return mFileAge
            End Get
            Set(value As Int32)
                mFileAge = value
            End Set
        End Property
        Property StartJitter As COH_Struct_Vector3
            Get
                Return mStartJitter
            End Get
            Set(value As COH_Struct_Vector3)
                mStartJitter = value
            End Set
        End Property
        Property InitialVelocity As COH_Struct_Vector3
            Get
                Return mInitialVelocity
            End Get
            Set(value As COH_Struct_Vector3)
                mInitialVelocity = value
            End Set
        End Property
        Property InitialVelocityJitter As COH_Struct_Vector3
            Get
                Return mInitialVelocityJitter
            End Get
            Set(value As COH_Struct_Vector3)
                mInitialVelocityJitter = value
            End Set
        End Property
        Property InitialVelocityAngle As Single
            Get
                Return mInitialVelocityAngle
            End Get
            Set(value As Single)
                mInitialVelocityAngle = value
            End Set
        End Property
        Property Gravity As Single
            Get
                Return mGravity
            End Get
            Set(value As Single)
                mGravity = value
            End Set
        End Property
        Property Physics As Byte
            Get
                Return mPhysics
            End Get
            Set(value As Byte)
                mPhysics = value
            End Set
        End Property
        Property PhysRadius As Single
            Get
                Return mPhysRadius
            End Get
            Set(value As Single)
                mPhysRadius = value
            End Set
        End Property
        Property PhysGravity As Single
            Get
                Return mPhysGravity
            End Get
            Set(value As Single)
                mPhysGravity = value
            End Set
        End Property
        Property PhysRestitution As Single
            Get
                Return mPhysRestitution
            End Get
            Set(value As Single)
                mPhysRestitution = value
            End Set
        End Property
        Property PhysSFriction As Single
            Get
                Return mPhysSFriction
            End Get
            Set(value As Single)
                mPhysSFriction = value
            End Set
        End Property
        Property PhysDFriction As Single
            Get
                Return mPhysDFriction
            End Get
            Set(value As Single)
                mPhysDFriction = value
            End Set
        End Property
        Property PhysKillBelowSpeed As Single
            Get
                Return mPhysKillBelowSpeed
            End Get
            Set(value As Single)
                mPhysKillBelowSpeed = value
            End Set
        End Property
        Property PhysDensity As Single
            Get
                Return mPhysDensity
            End Get
            Set(value As Single)
                mPhysDensity = value
            End Set
        End Property
        Property PhysForceRadius As Single
            Get
                Return mPhysForceRadius
            End Get
            Set(value As Single)
                mPhysForceRadius = value
            End Set
        End Property
        Property PhysForcePower As Single
            Get
                Return mPhysForcePower
            End Get
            Set(value As Single)
                mPhysForcePower = value
            End Set
        End Property
        Property PhysForcePowerJitter As Single
            Get
                Return mPhysForcePowerJitter
            End Get
            Set(value As Single)
                mPhysForcePowerJitter = value
            End Set
        End Property
        Property PhysForceCentripetal As Single
            Get
                Return mPhysForceCentripetal
            End Get
            Set(value As Single)
                mPhysForceCentripetal = value
            End Set
        End Property
        Property PhysForceSpeedScaleMax As Single
            Get
                Return mPhysForceSpeedScaleMax
            End Get
            Set(value As Single)
                mPhysForceSpeedScaleMax = value
            End Set
        End Property
        Property PhysScale As COH_Struct_Vector3
            Get
                Return mPhysScale
            End Get
            Set(value As COH_Struct_Vector3)
                mPhysScale = value
            End Set
        End Property
        Property PhysJointDOFs As Int32
            Get
                Return mPhysJointDOFs
            End Get
            Set(value As Int32)
                mPhysJointDOFs = value
            End Set
        End Property
        Property PhysJointAnchor As COH_Struct_Vector3
            Get
                Return mPhysJointAnchor
            End Get
            Set(value As COH_Struct_Vector3)
                mPhysJointAnchor = value
            End Set
        End Property
        Property PhysJointAngLimit As Single
            Get
                Return mPhysJointAngLimit
            End Get
            Set(value As Single)
                mPhysJointAngLimit = value
            End Set
        End Property
        Property PhysJointLinLimit As Single
            Get
                Return mPhysJointLinLimit
            End Get
            Set(value As Single)
                mPhysJointLinLimit = value
            End Set
        End Property
        Property PhysJointBreakTorque As Single
            Get
                Return mPhysJointBreakTorque
            End Get
            Set(value As Single)
                mPhysJointBreakTorque = value
            End Set
        End Property
        Property PhysJointBreakForce As Single
            Get
                Return mPhysJointBreakForce
            End Get
            Set(value As Single)
                mPhysJointBreakForce = value
            End Set
        End Property
        Property PhysJointLinSpring As Single
            Get
                Return mPhysJointLinSpring
            End Get
            Set(value As Single)
                mPhysJointLinSpring = value
            End Set
        End Property
        Property PhysJointLinSpringDamp As Single
            Get
                Return mPhysJointLinSpringDamp
            End Get
            Set(value As Single)
                mPhysJointLinSpringDamp = value
            End Set
        End Property
        Property PhysJointAngSpring As Single
            Get
                Return mPhysJointAngSpring
            End Get
            Set(value As Single)
                mPhysJointAngSpring = value
            End Set
        End Property
        Property PhysJointAngSpringDamp As Single
            Get
                Return mPhysJointAngSpringDamp
            End Get
            Set(value As Single)
                mPhysJointAngSpringDamp = value
            End Set
        End Property
        Property PhysJointDrag As Single
            Get
                Return mPhysJointDrag
            End Get
            Set(value As Single)
                mPhysJointDrag = value
            End Set
        End Property
        Property PhysJointCollidesWorld As Boolean
            Get
                Return mPhysJointCollidesWorld
            End Get
            Set(value As Boolean)
                mPhysJointCollidesWorld = value
            End Set
        End Property
        Property PhysForceType As Int32
            Get
                Return mPhysForceType
            End Get
            Set(value As Int32)
                mPhysForceType = value
            End Set
        End Property
        Property PhysDebris As Int32
            Get
                Return mPhysDebris
            End Get
            Set(value As Int32)
                mPhysDebris = value
            End Set
        End Property
        Property Spin As COH_Struct_Vector3
            Get
                Return mSpin
            End Get
            Set(value As COH_Struct_Vector3)
                mSpin = value
            End Set
        End Property
        Property SpinJitter As COH_Struct_Vector3
            Get
                Return mSpinJitter
            End Get
            Set(value As COH_Struct_Vector3)
                mSpinJitter = value
            End Set
        End Property
        Property FadeInLength As Single
            Get
                Return mFadeInLength
            End Get
            Set(value As Single)
                mFadeInLength = value
            End Set
        End Property
        Property FadeOutLength As Single
            Get
                Return mFadeOutLength
            End Get
            Set(value As Single)
                mFadeOutLength = value
            End Set
        End Property
        Property Shake As Single
            Get
                Return mShake
            End Get
            Set(value As Single)
                mShake = value
            End Set
        End Property
        Property ShakeFallOff As Single
            Get
                Return mShakeFallOff
            End Get
            Set(value As Single)
                mShakeFallOff = value
            End Set
        End Property
        Property ShakeRadius As Single
            Get
                Return mShakeRadius
            End Get
            Set(value As Single)
                mShakeRadius = value
            End Set
        End Property
        Property Blur As Single
            Get
                Return mBlur
            End Get
            Set(value As Single)
                mBlur = value
            End Set
        End Property
        Property BlurFallOff As Single
            Get
                Return mBlurFallOff
            End Get
            Set(value As Single)
                mBlurFallOff = value
            End Set
        End Property
        Property BlurRadius As Single
            Get
                Return mBlurRadius
            End Get
            Set(value As Single)
                mBlurRadius = value
            End Set
        End Property
        Property Scale As COH_Struct_Vector3
            Get
                Return mScale
            End Get
            Set(value As COH_Struct_Vector3)
                mScale = value
            End Set
        End Property
        Property ScaleRate As COH_Struct_Vector3
            Get
                Return mScaleRate
            End Get
            Set(value As COH_Struct_Vector3)
                mScaleRate = value
            End Set
        End Property
        Property ScaleTime As COH_Struct_Vector3
            Get
                Return mScaleTime
            End Get
            Set(value As COH_Struct_Vector3)
                mScaleTime = value
            End Set
        End Property
        Property EndScale As COH_Struct_Vector3
            Get
                Return mEndScale
            End Get
            Set(value As COH_Struct_Vector3)
                mEndScale = value
            End Set
        End Property
        Property Stretch As Byte
            Get
                Return mStretch
            End Get
            Set(value As Byte)
                mStretch = value
            End Set
        End Property
        Property Drag As Single
            Get
                Return mDrag
            End Get
            Set(value As Single)
                mDrag = value
            End Set
        End Property
        Property PyrRotate As COH_Struct_Vector3
            Get
                Return mPyrRotate
            End Get
            Set(value As COH_Struct_Vector3)
                mPyrRotate = value
            End Set
        End Property
        Property PyrRotateJitter As COH_Struct_Vector3
            Get
                Return mPyrRotateJitter
            End Get
            Set(value As COH_Struct_Vector3)
                mPyrRotateJitter = value
            End Set
        End Property
        Property PositionOffset As COH_Struct_Vector3
            Get
                Return mPositionOffset
            End Get
            Set(value As COH_Struct_Vector3)
                mPositionOffset = value
            End Set
        End Property
        Property UseShieldOffset As Boolean
            Get
                Return mUseShieldOffset
            End Get
            Set(value As Boolean)
                mUseShieldOffset = value
            End Set
        End Property
        Property TrackRate As Single
            Get
                Return mTrackRate
            End Get
            Set(value As Single)
                mTrackRate = value
            End Set
        End Property
        Property TrackMethod As Byte
            Get
                Return mTrackMethod
            End Get
            Set(value As Byte)
                mTrackMethod = value
            End Set
        End Property
        Property Collides As Byte
            Get
                Return mCollides
            End Get
            Set(value As Byte)
                mCollides = value
            End Set
        End Property
        Property LifeSpan As Int32
            Get
                Return mLifeSpan
            End Get
            Set(value As Int32)
                mLifeSpan = value
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
        Property Alpha As Byte
            Get
                Return mAlpha
            End Get
            Set(value As Byte)
                mAlpha = value
            End Set
        End Property
        Property PulsePeakTime As Single
            Get
                Return mPulsePeakTime
            End Get
            Set(value As Single)
                mPulsePeakTime = value
            End Set
        End Property
        Property PulseBrightness As Single
            Get
                Return mPulseBrightness
            End Get
            Set(value As Single)
                mPulseBrightness = value
            End Set
        End Property
        Property PulseClamp As Single
            Get
                Return mPulseClamp
            End Get
            Set(value As Single)
                mPulseClamp = value
            End Set
        End Property
        Property SplatFlags As Int32
            Get
                Return mSplatFlags
            End Get
            Set(value As Int32)
                mSplatFlags = value
            End Set
        End Property
        Property SplatFalloffType As Int32
            Get
                Return mSplatFalloffType
            End Get
            Set(value As Int32)
                mSplatFalloffType = value
            End Set
        End Property
        Property SplatNormalFade As Single
            Get
                Return mSplatNormalFade
            End Get
            Set(value As Single)
                mSplatNormalFade = value
            End Set
        End Property
        Property SplatFadeCenter As Single
            Get
                Return mSplatFadeCenter
            End Get
            Set(value As Single)
                mSplatFadeCenter = value
            End Set
        End Property
        Property SplatSetBack As Single
            Get
                Return mSplatSetBack
            End Get
            Set(value As Single)
                mSplatSetBack = value
            End Set
        End Property
        Property StAnim As COH_Tricks_ST_Anim()
            Get
                Return mStAnim
            End Get
            Set(value As COH_Tricks_ST_Anim())
                mStAnim = value
            End Set
        End Property
        Property HueShift As Single
            Get
                Return mHueShift
            End Get
            Set(value As Single)
                mHueShift = value
            End Set
        End Property
        Property HueShiftJitter As Single
            Get
                Return mHueShiftJitter
            End Get
            Set(value As Single)
                mHueShiftJitter = value
            End Set
        End Property
        Property StartColor As COH_Color_RGB
            Get
                Return mStartColor
            End Get
            Set(value As COH_Color_RGB)
                mStartColor = value
            End Set
        End Property
        Property BeColor1 As COH_Color_RGB
            Get
                Return mBeColor1
            End Get
            Set(value As COH_Color_RGB)
                mBeColor1 = value
            End Set
        End Property
        Property BeColor2 As COH_Color_RGB
            Get
                Return mBeColor2
            End Get
            Set(value As COH_Color_RGB)
                mBeColor2 = value
            End Set
        End Property
        Property BeColor3 As COH_Color_RGB
            Get
                Return mBeColor3
            End Get
            Set(value As COH_Color_RGB)
                mBeColor3 = value
            End Set
        End Property
        Property BeColor4 As COH_Color_RGB
            Get
                Return mBeColor4
            End Get
            Set(value As COH_Color_RGB)
                mBeColor4 = value
            End Set
        End Property
        Property ByTime1 As Int32
            Get
                Return mByTime1
            End Get
            Set(value As Int32)
                mByTime1 = value
            End Set
        End Property
        Property ByTime2 As Int32
            Get
                Return mByTime2
            End Get
            Set(value As Int32)
                mByTime2 = value
            End Set
        End Property
        Property ByTime3 As Int32
            Get
                Return mByTime3
            End Get
            Set(value As Int32)
                mByTime3 = value
            End Set
        End Property
        Property ByTime4 As Int32
            Get
                Return mByTime4
            End Get
            Set(value As Int32)
                mByTime4 = value
            End Set
        End Property
        Property PrimaryTint As Single
            Get
                Return mPrimaryTint
            End Get
            Set(value As Single)
                mPrimaryTint = value
            End Set
        End Property
        Property PrimaryTint1 As Single
            Get
                Return mPrimaryTint1
            End Get
            Set(value As Single)
                mPrimaryTint1 = value
            End Set
        End Property
        Property PrimaryTint2 As Single
            Get
                Return mPrimaryTint2
            End Get
            Set(value As Single)
                mPrimaryTint2 = value
            End Set
        End Property
        Property PrimaryTint3 As Single
            Get
                Return mPrimaryTint3
            End Get
            Set(value As Single)
                mPrimaryTint3 = value
            End Set
        End Property
        Property PrimaryTint4 As Single
            Get
                Return mPrimaryTint4
            End Get
            Set(value As Single)
                mPrimaryTint4 = value
            End Set
        End Property
        Property SecondaryTint As Single
            Get
                Return mSecondaryTint
            End Get
            Set(value As Single)
                mSecondaryTint = value
            End Set
        End Property
        Property SecondaryTint1 As Single
            Get
                Return mSecondaryTint1
            End Get
            Set(value As Single)
                mSecondaryTint1 = value
            End Set
        End Property
        Property SecondaryTint2 As Single
            Get
                Return mSecondaryTint2
            End Get
            Set(value As Single)
                mSecondaryTint2 = value
            End Set
        End Property
        Property SecondaryTint3 As Single
            Get
                Return mSecondaryTint3
            End Get
            Set(value As Single)
                mSecondaryTint3 = value
            End Set
        End Property
        Property SecondaryTint4 As Single
            Get
                Return mSecondaryTint4
            End Get
            Set(value As Single)
                mSecondaryTint4 = value
            End Set
        End Property
        Property InheritGroupTint As Boolean
            Get
                Return mInheritGroupTint
            End Get
            Set(value As Boolean)
                mInheritGroupTint = value
            End Set
        End Property
        Property Rgb0 As COH_Color_RGB
            Get
                Return mRgb0
            End Get
            Set(value As COH_Color_RGB)
                mRgb0 = value
            End Set
        End Property
        Property Rgb1 As COH_Color_RGB
            Get
                Return mRgb1
            End Get
            Set(value As COH_Color_RGB)
                mRgb1 = value
            End Set
        End Property
        Property Rgb2 As COH_Color_RGB
            Get
                Return mRgb2
            End Get
            Set(value As COH_Color_RGB)
                mRgb2 = value
            End Set
        End Property
        Property Rgb3 As COH_Color_RGB
            Get
                Return mRgb3
            End Get
            Set(value As COH_Color_RGB)
                mRgb3 = value
            End Set
        End Property
        Property Rgb4 As COH_Color_RGB
            Get
                Return mRgb4
            End Get
            Set(value As COH_Color_RGB)
                mRgb4 = value
            End Set
        End Property
        Property Rgb0Time As Int32
            Get
                Return mRgb0Time
            End Get
            Set(value As Int32)
                mRgb0Time = value
            End Set
        End Property
        Property Rgb1Time As Int32
            Get
                Return mRgb1Time
            End Get
            Set(value As Int32)
                mRgb1Time = value
            End Set
        End Property
        Property Rgb2Time As Int32
            Get
                Return mRgb2Time
            End Get
            Set(value As Int32)
                mRgb2Time = value
            End Set
        End Property
        Property Rgb3Time As Int32
            Get
                Return mRgb3Time
            End Get
            Set(value As Int32)
                mRgb3Time = value
            End Set
        End Property
        Property Rgb4Time As Int32
            Get
                Return mRgb4Time
            End Get
            Set(value As Int32)
                mRgb4Time = value
            End Set
        End Property
        Property TintGeom As Boolean
            Get
                Return mTintGeom
            End Get
            Set(value As Boolean)
                mTintGeom = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mParamBitfield As Byte()
       Private mFileAge As Int32
       Private mStartJitter As COH_Struct_Vector3
       Private mInitialVelocity As COH_Struct_Vector3
       Private mInitialVelocityJitter As COH_Struct_Vector3
       Private mInitialVelocityAngle As Single
       Private mGravity As Single
       Private mPhysics As Byte
       Private mPhysRadius As Single
       Private mPhysGravity As Single
       Private mPhysRestitution As Single
       Private mPhysSFriction As Single
       Private mPhysDFriction As Single
       Private mPhysKillBelowSpeed As Single
       Private mPhysDensity As Single
       Private mPhysForceRadius As Single
       Private mPhysForcePower As Single
       Private mPhysForcePowerJitter As Single
       Private mPhysForceCentripetal As Single
       Private mPhysForceSpeedScaleMax As Single
       Private mPhysScale As COH_Struct_Vector3
       Private mPhysJointDOFs As Int32
       Private mPhysJointAnchor As COH_Struct_Vector3
       Private mPhysJointAngLimit As Single
       Private mPhysJointLinLimit As Single
       Private mPhysJointBreakTorque As Single
       Private mPhysJointBreakForce As Single
       Private mPhysJointLinSpring As Single
       Private mPhysJointLinSpringDamp As Single
       Private mPhysJointAngSpring As Single
       Private mPhysJointAngSpringDamp As Single
       Private mPhysJointDrag As Single
       Private mPhysJointCollidesWorld As Boolean
       Private mPhysForceType As Int32
       Private mPhysDebris As Int32
       Private mSpin As COH_Struct_Vector3
       Private mSpinJitter As COH_Struct_Vector3
       Private mFadeInLength As Single
       Private mFadeOutLength As Single
       Private mShake As Single
       Private mShakeFallOff As Single
       Private mShakeRadius As Single
       Private mBlur As Single
       Private mBlurFallOff As Single
       Private mBlurRadius As Single
       Private mScale As COH_Struct_Vector3
       Private mScaleRate As COH_Struct_Vector3
       Private mScaleTime As COH_Struct_Vector3
       Private mEndScale As COH_Struct_Vector3
       Private mStretch As Byte
       Private mDrag As Single
       Private mPyrRotate As COH_Struct_Vector3
       Private mPyrRotateJitter As COH_Struct_Vector3
       Private mPositionOffset As COH_Struct_Vector3
       Private mUseShieldOffset As Boolean
       Private mTrackRate As Single
       Private mTrackMethod As Byte
       Private mCollides As Byte
       Private mLifeSpan As Int32
       Private mAnimScale As Single
       Private mAlpha As Byte
       Private mPulsePeakTime As Single
       Private mPulseBrightness As Single
       Private mPulseClamp As Single
       Private mSplatFlags As Int32
       Private mSplatFalloffType As Int32
       Private mSplatNormalFade As Single
       Private mSplatFadeCenter As Single
       Private mSplatSetBack As Single
       Private mStAnim As COH_Tricks_ST_Anim()
       Private mHueShift As Single
       Private mHueShiftJitter As Single
       Private mStartColor As COH_Color_RGB
       Private mBeColor1 As COH_Color_RGB
       Private mBeColor2 As COH_Color_RGB
       Private mBeColor3 As COH_Color_RGB
       Private mBeColor4 As COH_Color_RGB
       Private mByTime1 As Int32
       Private mByTime2 As Int32
       Private mByTime3 As Int32
       Private mByTime4 As Int32
       Private mPrimaryTint As Single
       Private mPrimaryTint1 As Single
       Private mPrimaryTint2 As Single
       Private mPrimaryTint3 As Single
       Private mPrimaryTint4 As Single
       Private mSecondaryTint As Single
       Private mSecondaryTint1 As Single
       Private mSecondaryTint2 As Single
       Private mSecondaryTint3 As Single
       Private mSecondaryTint4 As Single
       Private mInheritGroupTint As Boolean
       Private mRgb0 As COH_Color_RGB
       Private mRgb1 As COH_Color_RGB
       Private mRgb2 As COH_Color_RGB
       Private mRgb3 As COH_Color_RGB
       Private mRgb4 As COH_Color_RGB
       Private mRgb0Time As Int32
       Private mRgb1Time As Int32
       Private mRgb2Time As Int32
       Private mRgb3Time As Int32
       Private mRgb4Time As Int32
       Private mTintGeom As Boolean
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
            mStartJitter = New COH_Struct_Vector3
            mInitialVelocity = New COH_Struct_Vector3
            mInitialVelocityJitter = New COH_Struct_Vector3
            mPhysScale = New COH_Struct_Vector3
            mPhysJointAnchor = New COH_Struct_Vector3
            mSpin = New COH_Struct_Vector3
            mSpinJitter = New COH_Struct_Vector3
            mScale = New COH_Struct_Vector3
            mScaleRate = New COH_Struct_Vector3
            mScaleTime = New COH_Struct_Vector3
            mEndScale = New COH_Struct_Vector3
            mPyrRotate = New COH_Struct_Vector3
            mPyrRotateJitter = New COH_Struct_Vector3
            mPositionOffset = New COH_Struct_Vector3
            mStAnim = New COH_Tricks_ST_Anim() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Behavior
            Dim Result As COH_Behavior = New COH_Behavior
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFileAge = mFileAge
                .mStartJitter = mStartJitter
                .mInitialVelocity = mInitialVelocity
                .mInitialVelocityJitter = mInitialVelocityJitter
                .mInitialVelocityAngle = mInitialVelocityAngle
                .mGravity = mGravity
                .mPhysics = mPhysics
                .mPhysRadius = mPhysRadius
                .mPhysGravity = mPhysGravity
                .mPhysRestitution = mPhysRestitution
                .mPhysSFriction = mPhysSFriction
                .mPhysDFriction = mPhysDFriction
                .mPhysKillBelowSpeed = mPhysKillBelowSpeed
                .mPhysDensity = mPhysDensity
                .mPhysForceRadius = mPhysForceRadius
                .mPhysForcePower = mPhysForcePower
                .mPhysForcePowerJitter = mPhysForcePowerJitter
                .mPhysForceCentripetal = mPhysForceCentripetal
                .mPhysForceSpeedScaleMax = mPhysForceSpeedScaleMax
                .mPhysScale = mPhysScale
                .mPhysJointDOFs = mPhysJointDOFs
                .mPhysJointAnchor = mPhysJointAnchor
                .mPhysJointAngLimit = mPhysJointAngLimit
                .mPhysJointLinLimit = mPhysJointLinLimit
                .mPhysJointBreakTorque = mPhysJointBreakTorque
                .mPhysJointBreakForce = mPhysJointBreakForce
                .mPhysJointLinSpring = mPhysJointLinSpring
                .mPhysJointLinSpringDamp = mPhysJointLinSpringDamp
                .mPhysJointAngSpring = mPhysJointAngSpring
                .mPhysJointAngSpringDamp = mPhysJointAngSpringDamp
                .mPhysJointDrag = mPhysJointDrag
                .mPhysJointCollidesWorld = mPhysJointCollidesWorld
                .mPhysForceType = mPhysForceType
                .mPhysDebris = mPhysDebris
                .mSpin = mSpin
                .mSpinJitter = mSpinJitter
                .mFadeInLength = mFadeInLength
                .mFadeOutLength = mFadeOutLength
                .mShake = mShake
                .mShakeFallOff = mShakeFallOff
                .mShakeRadius = mShakeRadius
                .mBlur = mBlur
                .mBlurFallOff = mBlurFallOff
                .mBlurRadius = mBlurRadius
                .mScale = mScale
                .mScaleRate = mScaleRate
                .mScaleTime = mScaleTime
                .mEndScale = mEndScale
                .mStretch = mStretch
                .mDrag = mDrag
                .mPyrRotate = mPyrRotate
                .mPyrRotateJitter = mPyrRotateJitter
                .mPositionOffset = mPositionOffset
                .mUseShieldOffset = mUseShieldOffset
                .mTrackRate = mTrackRate
                .mTrackMethod = mTrackMethod
                .mCollides = mCollides
                .mLifeSpan = mLifeSpan
                .mAnimScale = mAnimScale
                .mAlpha = mAlpha
                .mPulsePeakTime = mPulsePeakTime
                .mPulseBrightness = mPulseBrightness
                .mPulseClamp = mPulseClamp
                .mSplatFlags = mSplatFlags
                .mSplatFalloffType = mSplatFalloffType
                .mSplatNormalFade = mSplatNormalFade
                .mSplatFadeCenter = mSplatFadeCenter
                .mSplatSetBack = mSplatSetBack
                .mStAnim = New COH_Tricks_ST_Anim(mStAnim.Count - 1) {}
                For X = 0 To mStAnim.Count - 1
                    .mStAnim(X) = mStAnim(X).Clone
                Next
                .mHueShift = mHueShift
                .mHueShiftJitter = mHueShiftJitter
                .mStartColor = mStartColor
                .mBeColor1 = mBeColor1
                .mBeColor2 = mBeColor2
                .mBeColor3 = mBeColor3
                .mBeColor4 = mBeColor4
                .mByTime1 = mByTime1
                .mByTime2 = mByTime2
                .mByTime3 = mByTime3
                .mByTime4 = mByTime4
                .mPrimaryTint = mPrimaryTint
                .mPrimaryTint1 = mPrimaryTint1
                .mPrimaryTint2 = mPrimaryTint2
                .mPrimaryTint3 = mPrimaryTint3
                .mPrimaryTint4 = mPrimaryTint4
                .mSecondaryTint = mSecondaryTint
                .mSecondaryTint1 = mSecondaryTint1
                .mSecondaryTint2 = mSecondaryTint2
                .mSecondaryTint3 = mSecondaryTint3
                .mSecondaryTint4 = mSecondaryTint4
                .mInheritGroupTint = mInheritGroupTint
                .mRgb0 = mRgb0
                .mRgb1 = mRgb1
                .mRgb2 = mRgb2
                .mRgb3 = mRgb3
                .mRgb4 = mRgb4
                .mRgb0Time = mRgb0Time
                .mRgb1Time = mRgb1Time
                .mRgb2Time = mRgb2Time
                .mRgb3Time = mRgb3Time
                .mRgb4Time = mRgb4Time
                .mTintGeom = mTintGeom
                .mParamBitfield = .mParamBitfield
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mBehavior)
            '//USURE hERE WHICH IS READ FIRST...ASSUME SIZE FIRST
            CurrentWriter.Write(mParamBitfield.Length) '//HMM USED FIELD ENUm IS ALSO 16
            CurrentWriter.Write(mParamBitfield)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_TimeStamp(mFileAge)
            CurrentWriter.Write_CrypticS_Vector3(mStartJitter)
            CurrentWriter.Write_CrypticS_Vector3(mInitialVelocity)
            CurrentWriter.Write_CrypticS_Vector3(mInitialVelocityJitter)
            CurrentWriter.Write(mInitialVelocityAngle)
            CurrentWriter.Write(mGravity)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mPhysics)
            CurrentWriter.Write(mPhysRadius)
            CurrentWriter.Write(mPhysGravity)
            CurrentWriter.Write(mPhysRestitution)
            CurrentWriter.Write(mPhysSFriction)
            CurrentWriter.Write(mPhysDFriction)
            CurrentWriter.Write(mPhysKillBelowSpeed)
            CurrentWriter.Write(mPhysDensity)
            CurrentWriter.Write(mPhysForceRadius)
            CurrentWriter.Write(mPhysForcePower)
            CurrentWriter.Write(mPhysForcePowerJitter)
            CurrentWriter.Write(mPhysForceCentripetal)
            CurrentWriter.Write(mPhysForceSpeedScaleMax)
            CurrentWriter.Write_CrypticS_Vector3(mPhysScale)
            CurrentWriter.Write_CrypticS_Flags(mPhysJointDOFs)
            CurrentWriter.Write_CrypticS_Vector3(mPhysJointAnchor)
            CurrentWriter.Write(mPhysJointAngLimit)
            CurrentWriter.Write(mPhysJointLinLimit)
            CurrentWriter.Write(mPhysJointBreakTorque)
            CurrentWriter.Write(mPhysJointBreakForce)
            CurrentWriter.Write(mPhysJointLinSpring)
            CurrentWriter.Write(mPhysJointLinSpringDamp)
            CurrentWriter.Write(mPhysJointAngSpring)
            CurrentWriter.Write(mPhysJointAngSpringDamp)
            CurrentWriter.Write(mPhysJointDrag)
            CurrentWriter.Write_CrypticS_Boolean(mPhysJointCollidesWorld)
            CurrentWriter.Write(mPhysForceType)
            CurrentWriter.Write(mPhysDebris)
            '!!IGNORED!! mPhysJointDOFs)
            '!!IGNORED!! mPhysJointAnchor)
            '!!IGNORED!! mPhysJointAngLimit)
            '!!IGNORED!! mPhysJointLinLimit)
            '!!IGNORED!! mPhysJointBreakTorque)
            '!!IGNORED!! mPhysJointBreakForce)
            '!!IGNORED!! mPhysJointLinSpring)
            '!!IGNORED!! mPhysJointLinSpringDamp)
            '!!IGNORED!! mPhysJointAngSpring)
            '!!IGNORED!! mPhysJointAngSpringDamp)
            '!!IGNORED!! mPhysJointDrag)
            '!!IGNORED!! mPhysJointCollidesWorld)
            '!!IGNORED!! mPhysForceType)
            '!!IGNORED!! mPhysDebris)
            CurrentWriter.Write_CrypticS_Vector3(mSpin)
            CurrentWriter.Write_CrypticS_Vector3(mSpinJitter)
            CurrentWriter.Write(mFadeInLength)
            CurrentWriter.Write(mFadeOutLength)
            CurrentWriter.Write(mShake)
            CurrentWriter.Write(mShakeFallOff)
            CurrentWriter.Write(mShakeRadius)
            CurrentWriter.Write(mBlur)
            CurrentWriter.Write(mBlurFallOff)
            CurrentWriter.Write(mBlurRadius)
            CurrentWriter.Write_CrypticS_Vector3(mScale)
            CurrentWriter.Write_CrypticS_Vector3(mScaleRate)
            CurrentWriter.Write_CrypticS_Vector3(mScaleTime)
            CurrentWriter.Write_CrypticS_Vector3(mEndScale)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mStretch)
            CurrentWriter.Write(mDrag)
            CurrentWriter.Write_CrypticS_Vector3(mPyrRotate)
            CurrentWriter.Write_CrypticS_Vector3(mPyrRotateJitter)
            CurrentWriter.Write_CrypticS_Vector3(mPositionOffset)
            CurrentWriter.Write_CrypticS_Boolean(mUseShieldOffset)
            CurrentWriter.Write(mTrackRate)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mTrackMethod)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mCollides)
            CurrentWriter.Write(mLifeSpan)
            CurrentWriter.Write(mAnimScale)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mAlpha)
            CurrentWriter.Write(mPulsePeakTime)
            CurrentWriter.Write(mPulseBrightness)
            CurrentWriter.Write(mPulseClamp)
            CurrentWriter.Write_CrypticS_Flags(mSplatFlags)
            CurrentWriter.Write_CrypticS_Flags(mSplatFalloffType)
            CurrentWriter.Write(mSplatNormalFade)
            CurrentWriter.Write(mSplatFadeCenter)
            CurrentWriter.Write(mSplatSetBack)
            If CurrentWriter.Write_CrypticS_StructArray(mStAnim) = False Then Return False
            CurrentWriter.Write(mHueShift)
            CurrentWriter.Write(mHueShiftJitter)
            mStartColor.Export_To_Stream(CurrentWriter)
            mBeColor1.Export_To_Stream(CurrentWriter)
            mBeColor2.Export_To_Stream(CurrentWriter)
            mBeColor3.Export_To_Stream(CurrentWriter)
            mBeColor4.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write(mByTime1)
            CurrentWriter.Write(mByTime2)
            CurrentWriter.Write(mByTime3)
            CurrentWriter.Write(mByTime4)
            CurrentWriter.Write(mPrimaryTint)
            CurrentWriter.Write(mPrimaryTint1)
            CurrentWriter.Write(mPrimaryTint2)
            CurrentWriter.Write(mPrimaryTint3)
            CurrentWriter.Write(mPrimaryTint4)
            CurrentWriter.Write(mSecondaryTint)
            CurrentWriter.Write(mSecondaryTint1)
            CurrentWriter.Write(mSecondaryTint2)
            CurrentWriter.Write(mSecondaryTint3)
            CurrentWriter.Write(mSecondaryTint4)
            CurrentWriter.Write_CrypticS_Boolean(mInheritGroupTint)
            mRgb0.Export_To_Stream(CurrentWriter)
            mRgb1.Export_To_Stream(CurrentWriter)
            mRgb2.Export_To_Stream(CurrentWriter)
            mRgb3.Export_To_Stream(CurrentWriter)
            mRgb4.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write(mRgb0Time)
            CurrentWriter.Write(mRgb1Time)
            CurrentWriter.Write(mRgb2Time)
            CurrentWriter.Write(mRgb3Time)
            CurrentWriter.Write(mRgb4Time)
            CurrentWriter.Write_CrypticS_Boolean(mTintGeom)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mBehavior = 
            '//USURE hERE WHICH IS READ FIRST...ASSUME SIZE FIRST
            Dim ParamSize As UInt32 = CurrentReader.ReadUInt32
            mParamBitfield = CurrentReader.ReadBytes(ParamSize)

            mName = CurrentReader.Read_CrypticS_String
            mFileAge = CurrentReader.Read_CrypticS_TimeStamp
            mStartJitter = CurrentReader.Read_CrypticS_Vector3
            mInitialVelocity = CurrentReader.Read_CrypticS_Vector3
            mInitialVelocityJitter = CurrentReader.Read_CrypticS_Vector3
            mInitialVelocityAngle = CurrentReader.ReadSingle
            mGravity = CurrentReader.ReadSingle
            mPhysics = CurrentReader.Read_CrypticS_Byte_Aligned4
            mPhysRadius = CurrentReader.ReadSingle
            mPhysGravity = CurrentReader.ReadSingle
            mPhysRestitution = CurrentReader.ReadSingle
            mPhysSFriction = CurrentReader.ReadSingle
            mPhysDFriction = CurrentReader.ReadSingle
            mPhysKillBelowSpeed = CurrentReader.ReadSingle
            mPhysDensity = CurrentReader.ReadSingle
            mPhysForceRadius = CurrentReader.ReadSingle
            mPhysForcePower = CurrentReader.ReadSingle
            mPhysForcePowerJitter = CurrentReader.ReadSingle
            mPhysForceCentripetal = CurrentReader.ReadSingle
            mPhysForceSpeedScaleMax = CurrentReader.ReadSingle
            mPhysScale = CurrentReader.Read_CrypticS_Vector3
            mPhysJointDOFs = CurrentReader.Read_CrypticS_Flags
            mPhysJointAnchor = CurrentReader.Read_CrypticS_Vector3
            mPhysJointAngLimit = CurrentReader.ReadSingle
            mPhysJointLinLimit = CurrentReader.ReadSingle
            mPhysJointBreakTorque = CurrentReader.ReadSingle
            mPhysJointBreakForce = CurrentReader.ReadSingle
            mPhysJointLinSpring = CurrentReader.ReadSingle
            mPhysJointLinSpringDamp = CurrentReader.ReadSingle
            mPhysJointAngSpring = CurrentReader.ReadSingle
            mPhysJointAngSpringDamp = CurrentReader.ReadSingle
            mPhysJointDrag = CurrentReader.ReadSingle
            mPhysJointCollidesWorld = CurrentReader.Read_CrypticS_Boolean
            mPhysForceType = CurrentReader.ReadInt32
            mPhysDebris = CurrentReader.ReadInt32
            '!!IGNORED!! mPhysJointDOFs = 
            '!!IGNORED!! mPhysJointAnchor = 
            '!!IGNORED!! mPhysJointAngLimit = 
            '!!IGNORED!! mPhysJointLinLimit = 
            '!!IGNORED!! mPhysJointBreakTorque = 
            '!!IGNORED!! mPhysJointBreakForce = 
            '!!IGNORED!! mPhysJointLinSpring = 
            '!!IGNORED!! mPhysJointLinSpringDamp = 
            '!!IGNORED!! mPhysJointAngSpring = 
            '!!IGNORED!! mPhysJointAngSpringDamp = 
            '!!IGNORED!! mPhysJointDrag = 
            '!!IGNORED!! mPhysJointCollidesWorld = 
            '!!IGNORED!! mPhysForceType = 
            '!!IGNORED!! mPhysDebris = 
            mSpin = CurrentReader.Read_CrypticS_Vector3
            mSpinJitter = CurrentReader.Read_CrypticS_Vector3
            mFadeInLength = CurrentReader.ReadSingle
            mFadeOutLength = CurrentReader.ReadSingle
            mShake = CurrentReader.ReadSingle
            mShakeFallOff = CurrentReader.ReadSingle
            mShakeRadius = CurrentReader.ReadSingle
            mBlur = CurrentReader.ReadSingle
            mBlurFallOff = CurrentReader.ReadSingle
            mBlurRadius = CurrentReader.ReadSingle
            mScale = CurrentReader.Read_CrypticS_Vector3
            mScaleRate = CurrentReader.Read_CrypticS_Vector3
            mScaleTime = CurrentReader.Read_CrypticS_Vector3
            mEndScale = CurrentReader.Read_CrypticS_Vector3
            mStretch = CurrentReader.Read_CrypticS_Byte_Aligned4
            mDrag = CurrentReader.ReadSingle
            mPyrRotate = CurrentReader.Read_CrypticS_Vector3
            mPyrRotateJitter = CurrentReader.Read_CrypticS_Vector3
            mPositionOffset = CurrentReader.Read_CrypticS_Vector3
            mUseShieldOffset = CurrentReader.Read_CrypticS_Boolean
            mTrackRate = CurrentReader.ReadSingle
            mTrackMethod = CurrentReader.Read_CrypticS_Byte_Aligned4
            mCollides = CurrentReader.Read_CrypticS_Byte_Aligned4
            mLifeSpan = CurrentReader.ReadInt32
            mAnimScale = CurrentReader.ReadSingle
            mAlpha = CurrentReader.Read_CrypticS_Byte_Aligned4
            mPulsePeakTime = CurrentReader.ReadSingle
            mPulseBrightness = CurrentReader.ReadSingle
            mPulseClamp = CurrentReader.ReadSingle
            mSplatFlags = CurrentReader.Read_CrypticS_Flags
            mSplatFalloffType = CurrentReader.Read_CrypticS_Flags
            mSplatNormalFade = CurrentReader.ReadSingle
            mSplatFadeCenter = CurrentReader.ReadSingle
            mSplatSetBack = CurrentReader.ReadSingle
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Tricks_ST_Anim), mStAnim) = False Then Return False
            mHueShift = CurrentReader.ReadSingle
            mHueShiftJitter = CurrentReader.ReadSingle
            mStartColor = New COH_Color_RGB(CurrentReader)
            mBeColor1 = New COH_Color_RGB(CurrentReader)
            mBeColor2 = New COH_Color_RGB(CurrentReader)
            mBeColor3 = New COH_Color_RGB(CurrentReader)
            mBeColor4 = New COH_Color_RGB(CurrentReader)
            mByTime1 = CurrentReader.ReadInt32
            mByTime2 = CurrentReader.ReadInt32
            mByTime3 = CurrentReader.ReadInt32
            mByTime4 = CurrentReader.ReadInt32
            mPrimaryTint = CurrentReader.ReadSingle
            mPrimaryTint1 = CurrentReader.ReadSingle
            mPrimaryTint2 = CurrentReader.ReadSingle
            mPrimaryTint3 = CurrentReader.ReadSingle
            mPrimaryTint4 = CurrentReader.ReadSingle
            mSecondaryTint = CurrentReader.ReadSingle
            mSecondaryTint1 = CurrentReader.ReadSingle
            mSecondaryTint2 = CurrentReader.ReadSingle
            mSecondaryTint3 = CurrentReader.ReadSingle
            mSecondaryTint4 = CurrentReader.ReadSingle
            mInheritGroupTint = CurrentReader.Read_CrypticS_Boolean
            mRgb0 = New COH_Color_RGB(CurrentReader)
            mRgb1 = New COH_Color_RGB(CurrentReader)
            mRgb2 = New COH_Color_RGB(CurrentReader)
            mRgb3 = New COH_Color_RGB(CurrentReader)
            mRgb4 = New COH_Color_RGB(CurrentReader)
            mRgb0Time = CurrentReader.ReadInt32
            mRgb1Time = CurrentReader.ReadInt32
            mRgb2Time = CurrentReader.ReadInt32
            mRgb3Time = CurrentReader.ReadInt32
            mRgb4Time = CurrentReader.ReadInt32
            mTintGeom = CurrentReader.Read_CrypticS_Boolean
            Return True
        End Function
#End Region

    End Class
End Namespace
