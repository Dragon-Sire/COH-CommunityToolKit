Imports COH.GameContent.Structures.Shared.Drawing

Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_FX_System
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
        Property FrontOrLocalFacing As Int32
            Get
                Return mFrontOrLocalFacing
            End Get
            Set(value As Int32)
                mFrontOrLocalFacing = value
            End Set
        End Property
        Property WorldOrLocalPosition As Int32
            Get
                Return mWorldOrLocalPosition
            End Get
            Set(value As Int32)
                mWorldOrLocalPosition = value
            End Set
        End Property
        Property TimeToFull As Single
            Get
                Return mTimeToFull
            End Get
            Set(value As Single)
                mTimeToFull = value
            End Set
        End Property
        Property KickStart As Int32
            Get
                Return mKickStart
            End Get
            Set(value As Int32)
                mKickStart = value
            End Set
        End Property
        Property NewPerFrame As Single()
            Get
                Return mNewPerFrame
            End Get
            Set(value As Single())
                mNewPerFrame = value
            End Set
        End Property
        Property Burst As Int32()
            Get
                Return mBurst
            End Get
            Set(value As Int32())
                mBurst = value
            End Set
        End Property
        Property BurbleAmplitude As Single()
            Get
                Return mBurbleAmplitude
            End Get
            Set(value As Single())
                mBurbleAmplitude = value
            End Set
        End Property
        Property BurbleType As Int32
            Get
                Return mBurbleType
            End Get
            Set(value As Int32)
                mBurbleType = value
            End Set
        End Property
        Property BurbleFrequency As Single
            Get
                Return mBurbleFrequency
            End Get
            Set(value As Single)
                mBurbleFrequency = value
            End Set
        End Property
        Property BurbleThreshold As Single
            Get
                Return mBurbleThreshold
            End Get
            Set(value As Single)
                mBurbleThreshold = value
            End Set
        End Property
        Property MoveScale As Single
            Get
                Return mMoveScale
            End Get
            Set(value As Single)
                mMoveScale = value
            End Set
        End Property
        Property EmissionType As Int32
            Get
                Return mEmissionType
            End Get
            Set(value As Int32)
                mEmissionType = value
            End Set
        End Property
        Property EmissionStartJitter As Single()
            Get
                Return mEmissionStartJitter
            End Get
            Set(value As Single())
                mEmissionStartJitter = value
            End Set
        End Property
        Property EmissionRadius As Single
            Get
                Return mEmissionRadius
            End Get
            Set(value As Single)
                mEmissionRadius = value
            End Set
        End Property
        Property EmissionHeight As Single
            Get
                Return mEmissionHeight
            End Get
            Set(value As Single)
                mEmissionHeight = value
            End Set
        End Property
        Property EmissionLifeSpan As Single
            Get
                Return mEmissionLifeSpan
            End Get
            Set(value As Single)
                mEmissionLifeSpan = value
            End Set
        End Property
        Property EmissionLifeSpanJitter As Single
            Get
                Return mEmissionLifeSpanJitter
            End Get
            Set(value As Single)
                mEmissionLifeSpanJitter = value
            End Set
        End Property
        Property Spin As Int32
            Get
                Return mSpin
            End Get
            Set(value As Int32)
                mSpin = value
            End Set
        End Property
        Property SpinJitter As Int32
            Get
                Return mSpinJitter
            End Get
            Set(value As Int32)
                mSpinJitter = value
            End Set
        End Property
        Property OrientationJitter As Int32
            Get
                Return mOrientationJitter
            End Get
            Set(value As Int32)
                mOrientationJitter = value
            End Set
        End Property
        Property Magnetism As Single
            Get
                Return mMagnetism
            End Get
            Set(value As Single)
                mMagnetism = value
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
        Property KillOnZero As Int32
            Get
                Return mKillOnZero
            End Get
            Set(value As Int32)
                mKillOnZero = value
            End Set
        End Property
        Property Terrain As Int32
            Get
                Return mTerrain
            End Get
            Set(value As Int32)
                mTerrain = value
            End Set
        End Property
        Property InitialVelocity As Single()
            Get
                Return mInitialVelocity
            End Get
            Set(value As Single())
                mInitialVelocity = value
            End Set
        End Property
        Property InitialVelocityJitter As Single()
            Get
                Return mInitialVelocityJitter
            End Get
            Set(value As Single())
                mInitialVelocityJitter = value
            End Set
        End Property
        Property VelocityJitter As COH_Struct_Vector3
            Get
                Return mVelocityJitter
            End Get
            Set(value As COH_Struct_Vector3)
                mVelocityJitter = value
            End Set
        End Property
        Property TightenUp As Single
            Get
                Return mTightenUp
            End Get
            Set(value As Single)
                mTightenUp = value
            End Set
        End Property
        Property SortBias As Single
            Get
                Return mSortBias
            End Get
            Set(value As Single)
                mSortBias = value
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
        Property Stickiness As Single
            Get
                Return mStickiness
            End Get
            Set(value As Single)
                mStickiness = value
            End Set
        End Property
        Property ColorOffset As COH_Struct_Vector3
            Get
                Return mColorOffset
            End Get
            Set(value As COH_Struct_Vector3)
                mColorOffset = value
            End Set
        End Property
        Property ColorOffsetJitter As COH_Struct_Vector3
            Get
                Return mColorOffsetJitter
            End Get
            Set(value As COH_Struct_Vector3)
                mColorOffsetJitter = value
            End Set
        End Property
        Property Alpha As Int32()
            Get
                Return mAlpha
            End Get
            Set(value As Int32())
                mAlpha = value
            End Set
        End Property
        Property ColorChangeType As Int32
            Get
                Return mColorChangeType
            End Get
            Set(value As Int32)
                mColorChangeType = value
            End Set
        End Property
        Property FadeInBy As Single
            Get
                Return mFadeInBy
            End Get
            Set(value As Single)
                mFadeInBy = value
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
        Property FadeOutBy As Single
            Get
                Return mFadeOutBy
            End Get
            Set(value As Single)
                mFadeOutBy = value
            End Set
        End Property
        Property DieLikeThis As String
            Get
                Return mDieLikeThis
            End Get
            Set(value As String)
                mDieLikeThis = value
            End Set
        End Property
        Property DeathAgeToZero As UInt32
            Get
                Return mDeathAgeToZero
            End Get
            Set(value As UInt32)
                mDeathAgeToZero = value
            End Set
        End Property
        Property StartSize As Single()
            Get
                Return mStartSize
            End Get
            Set(value As Single())
                mStartSize = value
            End Set
        End Property
        Property StartSizeJitter As Single
            Get
                Return mStartSizeJitter
            End Get
            Set(value As Single)
                mStartSizeJitter = value
            End Set
        End Property
        Property Blend_mode As COH_Enum_Particles
            Get
                Return mBlend_mode
            End Get
            Set(value As COH_Enum_Particles)
                mBlend_mode = value
            End Set
        End Property




















        Property EndSize As Single()
            Get
                Return mEndSize
            End Get
            Set(value As Single())
                mEndSize = value
            End Set
        End Property
        Property ExpandRate As Single
            Get
                Return mExpandRate
            End Get
            Set(value As Single)
                mExpandRate = value
            End Set
        End Property
        Property ExpandType As Int32
            Get
                Return mExpandType
            End Get
            Set(value As Int32)
                mExpandType = value
            End Set
        End Property
        Property StreakType As Int32
            Get
                Return mStreakType
            End Get
            Set(value As Int32)
                mStreakType = value
            End Set
        End Property
        Property StreakScale As Single
            Get
                Return mStreakScale
            End Get
            Set(value As Single)
                mStreakScale = value
            End Set
        End Property
        Property StreakOrient As Int32
            Get
                Return mStreakOrient
            End Get
            Set(value As Int32)
                mStreakOrient = value
            End Set
        End Property
        Property StreakDirection As Int32
            Get
                Return mStreakDirection
            End Get
            Set(value As Int32)
                mStreakDirection = value
            End Set
        End Property
        Property VisRadius As Single
            Get
                Return mVisRadius
            End Get
            Set(value As Single)
                mVisRadius = value
            End Set
        End Property
        Property VisDist As Single
            Get
                Return mVisDist
            End Get
            Set(value As Single)
                mVisDist = value
            End Set
        End Property
        Property Flags As COH_Enum_ParticleFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_ParticleFlags)
                mFlags = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mFrontOrLocalFacing As Int32
       Private mWorldOrLocalPosition As Int32
       Private mTimeToFull As Single
       Private mKickStart As Int32
       Private mNewPerFrame As Single()
       Private mBurst As Int32()
       Private mBurbleAmplitude As Single()
       Private mBurbleType As Int32
       Private mBurbleFrequency As Single
       Private mBurbleThreshold As Single
       Private mMoveScale As Single
       Private mEmissionType As Int32
       Private mEmissionStartJitter As Single()
       Private mEmissionRadius As Single
       Private mEmissionHeight As Single
       Private mEmissionLifeSpan As Single
       Private mEmissionLifeSpanJitter As Single
       Private mSpin As Int32
       Private mSpinJitter As Int32
       Private mOrientationJitter As Int32
       Private mMagnetism As Single
       Private mGravity As Single
       Private mKillOnZero As Int32
       Private mTerrain As Int32
       Private mInitialVelocity As Single()
       Private mInitialVelocityJitter As Single()
       Private mVelocityJitter As COH_Struct_Vector3
       Private mTightenUp As Single
       Private mSortBias As Single
       Private mDrag As Single
       Private mStickiness As Single
       Private mColorOffset As COH_Struct_Vector3
       Private mColorOffsetJitter As COH_Struct_Vector3
       Private mAlpha As Int32()
       Private mColorChangeType As Int32
       Private mFadeInBy As Single

       Private mPartTex As COH_FX_System_ParticleTex()
       Private mColorNav As COH_FX_Particle_ColorNav()


       Private mFadeOutStart As Single
       Private mFadeOutBy As Single
       Private mDieLikeThis As String
       Private mDeathAgeToZero As UInt32
       Private mStartSize As Single()
       Private mStartSizeJitter As Single
       Private mBlend_mode As COH_Enum_Particles



       Private mEndSize As Single()
       Private mExpandRate As Single
       Private mExpandType As Int32
       Private mStreakType As Int32
       Private mStreakScale As Single
       Private mStreakOrient As Int32
       Private mStreakDirection As Int32
       Private mVisRadius As Single
       Private mVisDist As Single
       Private mFlags As COH_Enum_ParticleFlags
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
            mNewPerFrame = New Single() {}
            mBurst = New Int32() {}
            mBurbleAmplitude = New Single() {}
            mEmissionStartJitter = New Single() {}
            mInitialVelocity = New Single() {}
            mInitialVelocityJitter = New Single() {}
            mVelocityJitter = New COH_Struct_Vector3
            mColorOffset = New COH_Struct_Vector3
            mColorOffsetJitter = New COH_Struct_Vector3
            mAlpha = New Int32() {}
            mDieLikeThis = String.Empty
            mStartSize = New Single() {}
            mEndSize = New Single() {}
            mPartTex = New COH_FX_System_ParticleTex() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_FX_System
            Dim Result As COH_FX_System = New COH_FX_System
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFrontOrLocalFacing = mFrontOrLocalFacing
                .mWorldOrLocalPosition = mWorldOrLocalPosition
                .mTimeToFull = mTimeToFull
                .mKickStart = mKickStart
                .mNewPerFrame = New Single(mNewPerFrame.Count - 1) {} : mNewPerFrame.CopyTo(.mNewPerFrame, 0)
                .mBurst = New Int32(mBurst.Count - 1) {} : mBurst.CopyTo(.mBurst, 0)
                .mBurbleAmplitude = New Single(mBurbleAmplitude.Count - 1) {} : mBurbleAmplitude.CopyTo(.mBurbleAmplitude, 0)
                .mBurbleType = mBurbleType
                .mBurbleFrequency = mBurbleFrequency
                .mBurbleThreshold = mBurbleThreshold
                .mMoveScale = mMoveScale
                .mEmissionType = mEmissionType
                .mEmissionStartJitter = New Single(mEmissionStartJitter.Count - 1) {} : mEmissionStartJitter.CopyTo(.mEmissionStartJitter, 0)
                .mEmissionRadius = mEmissionRadius
                .mEmissionHeight = mEmissionHeight
                .mEmissionLifeSpan = mEmissionLifeSpan
                .mEmissionLifeSpanJitter = mEmissionLifeSpanJitter
                .mSpin = mSpin
                .mSpinJitter = mSpinJitter
                .mOrientationJitter = mOrientationJitter
                .mMagnetism = mMagnetism
                .mGravity = mGravity
                .mKillOnZero = mKillOnZero
                .mTerrain = mTerrain
                .mInitialVelocity = New Single(mInitialVelocity.Count - 1) {} : mInitialVelocity.CopyTo(.mInitialVelocity, 0)
                .mInitialVelocityJitter = New Single(mInitialVelocityJitter.Count - 1) {} : mInitialVelocityJitter.CopyTo(.mInitialVelocityJitter, 0)
                .mVelocityJitter = mVelocityJitter
                .mTightenUp = mTightenUp
                .mSortBias = mSortBias
                .mDrag = mDrag
                .mStickiness = mStickiness
                .mColorOffset = mColorOffset
                .mColorOffsetJitter = mColorOffsetJitter
                .mAlpha = New Int32(mAlpha.Count - 1) {} : mAlpha.CopyTo(.mAlpha, 0)
                .mColorChangeType = mColorChangeType

                .mPartTex = New COH_FX_System_ParticleTex(mPartTex.Count - 1) {}
                For x =0 To mPartTex.Count -1
                    .mPartTex(x) = mPartTex.clone  
                Next
                .mFadeInBy = mFadeInBy
                .mFadeOutStart = mFadeOutStart
                .mFadeOutBy = mFadeOutBy
                .mDieLikeThis = mDieLikeThis
                .mDeathAgeToZero = mDeathAgeToZero
                .mStartSize = New Single(mStartSize.Count - 1) {} : mStartSize.CopyTo(.mStartSize, 0)
                .mStartSizeJitter = mStartSizeJitter
                .mBlend_mode = mBlend_mode
                .mEndSize = New Single(mEndSize.Count - 1) {} : mEndSize.CopyTo(.mEndSize, 0)
                .mExpandRate = mExpandRate
                .mExpandType = mExpandType
                .mStreakType = mStreakType
                .mStreakScale = mStreakScale
                .mStreakOrient = mStreakOrient
                .mStreakDirection = mStreakDirection
                .mVisRadius = mVisRadius
                .mVisDist = mVisDist
                .mFlags = mFlags
                Return Result
            End With
        End Function
#End Region

        Const MAX_COLOR_NAV_POINTS = 5

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mSystem)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mFrontOrLocalFacing)
            CurrentWriter.Write(mWorldOrLocalPosition)
            CurrentWriter.Write(mTimeToFull)
            CurrentWriter.Write(mKickStart)
            CurrentWriter.Write_CrypticS_SingleArray(mNewPerFrame)
            CurrentWriter.Write_CrypticS_IntegerArray(mBurst)
            CurrentWriter.Write_CrypticS_SingleArray(mBurbleAmplitude)
            CurrentWriter.Write(mBurbleType)
            CurrentWriter.Write(mBurbleFrequency)
            CurrentWriter.Write(mBurbleThreshold)
            CurrentWriter.Write(mMoveScale)
            CurrentWriter.Write(mEmissionType)
            CurrentWriter.Write_CrypticS_SingleArray(mEmissionStartJitter)
            CurrentWriter.Write(mEmissionRadius)
            CurrentWriter.Write(mEmissionHeight)
            CurrentWriter.Write(mEmissionLifeSpan)
            CurrentWriter.Write(mEmissionLifeSpanJitter)
            CurrentWriter.Write(mSpin)
            CurrentWriter.Write(mSpinJitter)
            CurrentWriter.Write(mOrientationJitter)
            CurrentWriter.Write(mMagnetism)
            CurrentWriter.Write(mGravity)
            CurrentWriter.Write(mKillOnZero)
            CurrentWriter.Write(mTerrain)
            CurrentWriter.Write_CrypticS_SingleArray(mInitialVelocity)
            CurrentWriter.Write_CrypticS_SingleArray(mInitialVelocityJitter)
            CurrentWriter.Write_CrypticS_Vector3(mVelocityJitter)
            CurrentWriter.Write(mTightenUp)
            CurrentWriter.Write(mSortBias)
            CurrentWriter.Write(mDrag)
            CurrentWriter.Write(mStickiness)
            CurrentWriter.Write_CrypticS_Vector3(mColorOffset)
            CurrentWriter.Write_CrypticS_Vector3(mColorOffsetJitter)
            CurrentWriter.Write_CrypticS_IntegerArray(mAlpha)
            CurrentWriter.Write(mColorChangeType)

            '//EMBEDDED STRUCTURE BULLSHIT HERE
            mColorNav(0).Rgb.Export_To_Stream(CurrentWriter)
            mColorNav(1).Rgb.Export_To_Stream(CurrentWriter)
            mColorNav(2).Rgb.Export_To_Stream(CurrentWriter)
            mColorNav(3).Rgb.Export_To_Stream(CurrentWriter)
            mColorNav(4).Rgb.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write(mColorNav(1).ByTime)
            CurrentWriter.Write(mColorNav(2).ByTime)
            CurrentWriter.Write(mColorNav(3).ByTime)
            CurrentWriter.Write(mColorNav(4).ByTime)
            CurrentWriter.Write(mColorNav(0).PrimaryTint)
            CurrentWriter.Write(mColorNav(1).PrimaryTint)
            CurrentWriter.Write(mColorNav(2).PrimaryTint)
            CurrentWriter.Write(mColorNav(3).PrimaryTint)
            CurrentWriter.Write(mColorNav(4).PrimaryTint)
            CurrentWriter.Write(mColorNav(0).SecondaryTint)
            CurrentWriter.Write(mColorNav(1).SecondaryTint)
            CurrentWriter.Write(mColorNav(2).SecondaryTint)
            CurrentWriter.Write(mColorNav(3).SecondaryTint)
            CurrentWriter.Write(mColorNav(4).SecondaryTint)
            mColorNav(0).Rgb.Export_To_Stream(CurrentWriter)
            mColorNav(1).Rgb.Export_To_Stream(CurrentWriter)
            mColorNav(2).Rgb.Export_To_Stream(CurrentWriter)
            mColorNav(3).Rgb.Export_To_Stream(CurrentWriter)
            mColorNav(4).Rgb.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write(mColorNav(1).RgbTime)
            CurrentWriter.Write(mColorNav(2).RgbTime)
            CurrentWriter.Write(mColorNav(3).RgbTime)
            CurrentWriter.Write(mColorNav(4).RgbTime)
            CurrentWriter.Write(mColorNav(0).RgbTime)


            CurrentWriter.Write(mFadeInBy)
            CurrentWriter.Write(mFadeOutStart)
            CurrentWriter.Write(mFadeOutBy)
            CurrentWriter.Write_CrypticS_String_FixedLength_UTF8_IntCount(mDieLikeThis)
            CurrentWriter.Write(mDeathAgeToZero)
            CurrentWriter.Write_CrypticS_SingleArray(mStartSize)
            CurrentWriter.Write(mStartSizeJitter)
            CurrentWriter.Write(mBlend_mode)

            '//COH_FX_System_ParticleTex
            CurrentWriter.Write_CrypticS_String_FixedLength_UTF8_IntCount(mPartTex(0).TextureName)
            CurrentWriter.Write_CrypticS_String_FixedLength_UTF8_IntCount(mPartTex(1).TextureName)
            CurrentWriter.Write_CrypticS_Vector3(mPartTex(0).TexScroll)
            CurrentWriter.Write_CrypticS_Vector3(mPartTex(1).TexScroll)
            CurrentWriter.Write_CrypticS_Vector3(mPartTex(0).TexScrollJitter)
            CurrentWriter.Write_CrypticS_Vector3(mPartTex(1).TexScrollJitter)
            CurrentWriter.Write(mPartTex(0).AnimFrames)
            CurrentWriter.Write(mPartTex(1).AnimFrames)
            CurrentWriter.Write(mPartTex(0).AnimPace)
            CurrentWriter.Write(mPartTex(1).AnimPace)
            CurrentWriter.Write(mPartTex(0).AnimType)
            CurrentWriter.Write(mPartTex(1).AnimType)


            CurrentWriter.Write_CrypticS_SingleArray(mEndSize)
            CurrentWriter.Write(mExpandRate)
            CurrentWriter.Write(mExpandType)
            CurrentWriter.Write(mStreakType)
            CurrentWriter.Write(mStreakScale)
            CurrentWriter.Write(mStreakOrient)
            CurrentWriter.Write(mStreakDirection)
            CurrentWriter.Write(mVisRadius)
            CurrentWriter.Write(mVisDist)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mSystem = 
            mName = CurrentReader.Read_CrypticS_String
            mFrontOrLocalFacing = CurrentReader.ReadInt32
            mWorldOrLocalPosition = CurrentReader.ReadInt32
            mTimeToFull = CurrentReader.ReadSingle
            mKickStart = CurrentReader.ReadInt32
            mNewPerFrame = CurrentReader.Read_CrypticS_SingleArray()
            mBurst = CurrentReader.Read_CrypticS_IntegerArray()
            mBurbleAmplitude = CurrentReader.Read_CrypticS_SingleArray()
            mBurbleType = CurrentReader.ReadInt32
            mBurbleFrequency = CurrentReader.ReadSingle
            mBurbleThreshold = CurrentReader.ReadSingle
            mMoveScale = CurrentReader.ReadSingle
            mEmissionType = CurrentReader.ReadInt32
            mEmissionStartJitter = CurrentReader.Read_CrypticS_SingleArray()
            mEmissionRadius = CurrentReader.ReadSingle
            mEmissionHeight = CurrentReader.ReadSingle
            mEmissionLifeSpan = CurrentReader.ReadSingle
            mEmissionLifeSpanJitter = CurrentReader.ReadSingle
            mSpin = CurrentReader.ReadInt32
            mSpinJitter = CurrentReader.ReadInt32
            mOrientationJitter = CurrentReader.ReadInt32
            mMagnetism = CurrentReader.ReadSingle
            mGravity = CurrentReader.ReadSingle
            mKillOnZero = CurrentReader.ReadInt32
            mTerrain = CurrentReader.ReadInt32
            mInitialVelocity = CurrentReader.Read_CrypticS_SingleArray()
            mInitialVelocityJitter = CurrentReader.Read_CrypticS_SingleArray()
            mVelocityJitter = CurrentReader.Read_CrypticS_Vector3
            mTightenUp = CurrentReader.ReadSingle
            mSortBias = CurrentReader.ReadSingle
            mDrag = CurrentReader.ReadSingle
            mStickiness = CurrentReader.ReadSingle
            mColorOffset = CurrentReader.Read_CrypticS_Vector3
            mColorOffsetJitter = CurrentReader.Read_CrypticS_Vector3
            mAlpha = CurrentReader.Read_CrypticS_IntegerArray()
            mColorChangeType = CurrentReader.ReadInt32

            '//COH_FX_Particle_ColorNav
            mColorNav = New COH_FX_Particle_ColorNav(MAX_COLOR_NAV_POINTS - 1) {}
            For x = 0 To MAX_COLOR_NAV_POINTS - 1
                mColorNav(x) = New COH_FX_Particle_ColorNav()
            Next
            mColorNav(0).Rgb = New COH_Color_RGB(CurrentReader)
            mColorNav(1).Rgb = New COH_Color_RGB(CurrentReader)
            mColorNav(2).Rgb = New COH_Color_RGB(CurrentReader)
            mColorNav(3).Rgb = New COH_Color_RGB(CurrentReader)
            mColorNav(4).Rgb = New COH_Color_RGB(CurrentReader)
            mColorNav(1).ByTime = CurrentReader.ReadInt32
            mColorNav(2).ByTime = CurrentReader.ReadInt32
            mColorNav(3).ByTime = CurrentReader.ReadInt32
            mColorNav(4).ByTime = CurrentReader.ReadInt32
            mColorNav(0).PrimaryTint = CurrentReader.ReadSingle
            mColorNav(1).PrimaryTint = CurrentReader.ReadSingle
            mColorNav(2).PrimaryTint = CurrentReader.ReadSingle
            mColorNav(3).PrimaryTint = CurrentReader.ReadSingle
            mColorNav(4).PrimaryTint = CurrentReader.ReadSingle
            mColorNav(0).SecondaryTint = CurrentReader.ReadSingle
            mColorNav(1).SecondaryTint = CurrentReader.ReadSingle
            mColorNav(2).SecondaryTint = CurrentReader.ReadSingle
            mColorNav(3).SecondaryTint = CurrentReader.ReadSingle
            mColorNav(4).SecondaryTint = CurrentReader.ReadSingle
            '//IT READS IT TWICE??? WHAT THE FN HELL
            mColorNav(0).Rgb = New COH_Color_RGB(CurrentReader)
            mColorNav(1).Rgb = New COH_Color_RGB(CurrentReader)
            mColorNav(2).Rgb = New COH_Color_RGB(CurrentReader)
            mColorNav(3).Rgb = New COH_Color_RGB(CurrentReader)
            mColorNav(4).Rgb = New COH_Color_RGB(CurrentReader)
            mColorNav(1).RgbTime = CurrentReader.ReadInt32
            mColorNav(2).RgbTime = CurrentReader.ReadInt32
            mColorNav(3).RgbTime = CurrentReader.ReadInt32
            mColorNav(4).RgbTime = CurrentReader.ReadInt32
            mColorNav(0).RgbTime = CurrentReader.ReadInt32 '///THEY COULDN"T BE BOTHERED TO READ IN ORDER?


            mFadeInBy = CurrentReader.ReadSingle
            mFadeOutStart = CurrentReader.ReadSingle
            mFadeOutBy = CurrentReader.ReadSingle

            mDieLikeThis = CurrentReader.Read_CrypticS_String '_FixedLength_UTF8_IntCount '//MIGHT NEED INTEGER FOR SIZE
            mDeathAgeToZero = CurrentReader.ReadUInt32
            mStartSize = CurrentReader.Read_CrypticS_SingleArray()
            mStartSizeJitter = CurrentReader.ReadSingle
            mBlend_mode = CurrentReader.ReadInt32

            '//COH_FX_System_ParticleTex
            mPartTex = New COH_FX_System_ParticleTex(1) {}
            For x = 0 To 1
                mPartTex(x) = New COH_FX_System_ParticleTex()
            Next
            mPartTex(0).TextureName = CurrentReader.Read_CrypticS_String '_FixedLength_UTF8_IntCount '//MIGHT NEED INTEGER FOR SIZE
            mPartTex(1).TextureName = CurrentReader.Read_CrypticS_String '_FixedLength_UTF8_IntCount
            mPartTex(0).TexScroll = CurrentReader.Read_CrypticS_Vector3
            mPartTex(1).TexScroll = CurrentReader.Read_CrypticS_Vector3
            mPartTex(0).TexScrollJitter = CurrentReader.Read_CrypticS_Vector3
            mPartTex(1).TexScrollJitter = CurrentReader.Read_CrypticS_Vector3
            mPartTex(0).AnimFrames = CurrentReader.ReadSingle
            mPartTex(1).AnimFrames = CurrentReader.ReadSingle
            mPartTex(0).AnimPace = CurrentReader.ReadSingle
            mPartTex(1).AnimPace = CurrentReader.ReadSingle
            mPartTex(0).AnimType = CurrentReader.ReadInt32
            mPartTex(1).AnimType = CurrentReader.ReadInt32


            mEndSize = CurrentReader.Read_CrypticS_SingleArray()
            mExpandRate = CurrentReader.ReadSingle
            mExpandType = CurrentReader.ReadInt32
            mStreakType = CurrentReader.ReadInt32
            mStreakScale = CurrentReader.ReadSingle
            mStreakOrient = CurrentReader.ReadInt32
            mStreakDirection = CurrentReader.ReadInt32
            mVisRadius = CurrentReader.ReadSingle
            mVisDist = CurrentReader.ReadSingle
            mFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace
