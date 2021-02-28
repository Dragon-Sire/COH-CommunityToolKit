Imports System.Drawing

Namespace GameContent.Structures.Characters.Powers
    Public Class COH_PowerFX
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "PowerFX"
            End Get
        End Property
#End Region

#Region "Properties"
        Property AttackBits As Int32()
            Get
                Return mAttackBits
            End Get
            Set(value As Int32())
                mAttackBits = value
            End Set
        End Property
        Property BlockBits As Int32()
            Get
                Return mBlockBits
            End Get
            Set(value As Int32())
                mBlockBits = value
            End Set
        End Property
        Property WindUpBits As Int32()
            Get
                Return mWindUpBits
            End Get
            Set(value As Int32())
                mWindUpBits = value
            End Set
        End Property
        Property HitBits As Int32()
            Get
                Return mHitBits
            End Get
            Set(value As Int32())
                mHitBits = value
            End Set
        End Property
        Property DeathBits As Int32()
            Get
                Return mDeathBits
            End Get
            Set(value As Int32())
                mDeathBits = value
            End Set
        End Property
        Property ActivationBits As Int32()
            Get
                Return mActivationBits
            End Get
            Set(value As Int32())
                mActivationBits = value
            End Set
        End Property
        Property DeactivationBits As Int32()
            Get
                Return mDeactivationBits
            End Get
            Set(value As Int32())
                mDeactivationBits = value
            End Set
        End Property
        Property InitialAttackBits As Int32()
            Get
                Return mInitialAttackBits
            End Get
            Set(value As Int32())
                mInitialAttackBits = value
            End Set
        End Property
        Property ContinuingBits As Int32()
            Get
                Return mContinuingBits
            End Get
            Set(value As Int32())
                mContinuingBits = value
            End Set
        End Property
        Property ConditionalBits As Int32()
            Get
                Return mConditionalBits
            End Get
            Set(value As Int32())
                mConditionalBits = value
            End Set
        End Property
        Property ActivationFX As String
            Get
                Return mActivationFX
            End Get
            Set(value As String)
                mActivationFX = value
            End Set
        End Property
        Property DeactivationFX As String
            Get
                Return mDeactivationFX
            End Get
            Set(value As String)
                mDeactivationFX = value
            End Set
        End Property
        Property AttackFX As String
            Get
                Return mAttackFX
            End Get
            Set(value As String)
                mAttackFX = value
            End Set
        End Property
        <COH_VersionRange(7)> Property SecondaryAttackFX As String '//ADDED I25
            Get
                Return mSecondaryAttackFX
            End Get
            Set(value As String)
                SetValue(mSecondaryAttackFX, value)
            End Set
        End Property
        Property HitFX As String
            Get
                Return mHitFX
            End Get
            Set(value As String)
                mHitFX = value
            End Set
        End Property
        Property WindUpFX As String
            Get
                Return mWindUpFX
            End Get
            Set(value As String)
                mWindUpFX = value
            End Set
        End Property
        Property BlockFX As String
            Get
                Return mBlockFX
            End Get
            Set(value As String)
                mBlockFX = value
            End Set
        End Property
        Property DeathFX As String
            Get
                Return mDeathFX
            End Get
            Set(value As String)
                mDeathFX = value
            End Set
        End Property
        Property InitialAttackFX As String
            Get
                Return mInitialAttackFX
            End Get
            Set(value As String)
                mInitialAttackFX = value
            End Set
        End Property
        Property ContinuingFX As String
            Get
                Return mContinuingFX
            End Get
            Set(value As String)
                mContinuingFX = value
            End Set
        End Property
        Property ContinuingFX1 As String
            Get
                Return mContinuingFX1
            End Get
            Set(value As String)
                mContinuingFX1 = value
            End Set
        End Property
        Property ContinuingFX2 As String
            Get
                Return mContinuingFX2
            End Get
            Set(value As String)
                mContinuingFX2 = value
            End Set
        End Property
        Property ContinuingFX3 As String
            Get
                Return mContinuingFX3
            End Get
            Set(value As String)
                mContinuingFX3 = value
            End Set
        End Property
        Property ContinuingFX4 As String
            Get
                Return mContinuingFX4
            End Get
            Set(value As String)
                mContinuingFX4 = value
            End Set
        End Property
        Property ConditionalFX As String
            Get
                Return mConditionalFX
            End Get
            Set(value As String)
                mConditionalFX = value
            End Set
        End Property
        Property ConditionalFX1 As String
            Get
                Return mConditionalFX1
            End Get
            Set(value As String)
                mConditionalFX1 = value
            End Set
        End Property
        Property ConditionalFX2 As String
            Get
                Return mConditionalFX2
            End Get
            Set(value As String)
                mConditionalFX2 = value
            End Set
        End Property
        Property ConditionalFX3 As String
            Get
                Return mConditionalFX3
            End Get
            Set(value As String)
                mConditionalFX3 = value
            End Set
        End Property
        Property ConditionalFX4 As String
            Get
                Return mConditionalFX4
            End Get
            Set(value As String)
                mConditionalFX4 = value
            End Set
        End Property
        Property ModeBits As Int32()
            Get
                Return mModeBits
            End Get
            Set(value As Int32())
                mModeBits = value
            End Set
        End Property
        Property FramesBeforeHit As Int32
            Get
                Return mFramesBeforeHit
            End Get
            Set(value As Int32)
                mFramesBeforeHit = value
            End Set
        End Property
        <COH_VersionRange(7)> Property FramesBeforeSecondaryHit As Int32 '//ADDED I25
            Get
                Return mFramesBeforeSecondaryHit
            End Get
            Set(value As Int32)
                SetValue(mFramesBeforeSecondaryHit, value)
            End Set
        End Property
        Property DelayedHit As Boolean
            Get
                Return mDelayedHit
            End Get
            Set(value As Boolean)
                mDelayedHit = value
            End Set
        End Property
        Property AttackFrames As Int32
            Get
                Return mAttackFrames
            End Get
            Set(value As Int32)
                mAttackFrames = value
            End Set
        End Property
        Property InitialFramesBeforeHit As Int32
            Get
                Return mInitialFramesBeforeHit
            End Get
            Set(value As Int32)
                mInitialFramesBeforeHit = value
            End Set
        End Property
        Property InitialAttackFXFrameDelay As Int32
            Get
                Return mInitialAttackFXFrameDelay
            End Get
            Set(value As Int32)
                mInitialAttackFXFrameDelay = value
            End Set
        End Property
        Property ProjectileSpeed As Single
            Get
                Return mProjectileSpeed
            End Get
            Set(value As Single)
                mProjectileSpeed = value
            End Set
        End Property
        <COH_VersionRange(7)> Property SecondaryProjectileSpeed As Single '//ADDED I25
            Get
                Return mSecondaryProjectileSpeed
            End Get
            Set(value As Single)
                SetValue(mSecondaryProjectileSpeed, value)
            End Set
        End Property
        Property InitialFramesBeforeBlock As Int32
            Get
                Return mInitialFramesBeforeBlock
            End Get
            Set(value As Int32)
                mInitialFramesBeforeBlock = value
            End Set
        End Property
        Property IgnoreAttackTimeErrors As String
            Get
                Return mIgnoreAttackTimeErrors
            End Get
            Set(value As String)
                mIgnoreAttackTimeErrors = value
            End Set
        End Property
        Property FramesBeforeBlock As Int32
            Get
                Return mFramesBeforeBlock
            End Get
            Set(value As Int32)
                mFramesBeforeBlock = value
            End Set
        End Property
        Property FXImportant As Boolean
            Get
                Return mFXImportant
            End Get
            Set(value As Boolean)
                mFXImportant = value
            End Set
        End Property
        Property PrimaryTint As COH_XML_Color
            Get
                Return mPrimaryTint
            End Get
            Set(value As COH_XML_Color)
                mPrimaryTint = value
            End Set
        End Property
        Property SecondaryTint As COH_XML_Color
            Get
                Return mSecondaryTint
            End Get
            Set(value As COH_XML_Color)
                mSecondaryTint = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mAttackBits As Int32()
       Private mBlockBits As Int32()
       Private mWindUpBits As Int32()
       Private mHitBits As Int32()
       Private mDeathBits As Int32()
       Private mActivationBits As Int32()
       Private mDeactivationBits As Int32()
       Private mInitialAttackBits As Int32()
       Private mContinuingBits As Int32()
       Private mConditionalBits As Int32()
       Private mActivationFX As String
       Private mDeactivationFX As String
       Private mAttackFX As String
       Private mHitFX As String
       Private mWindUpFX As String
       Private mBlockFX As String
       Private mDeathFX As String
       Private mInitialAttackFX As String
       Private mContinuingFX As String
       Private mContinuingFX1 As String
       Private mContinuingFX2 As String
       Private mContinuingFX3 As String
       Private mContinuingFX4 As String
       Private mConditionalFX As String
       Private mConditionalFX1 As String
       Private mConditionalFX2 As String
       Private mConditionalFX3 As String
       Private mConditionalFX4 As String
       Private mModeBits As Int32()
       Private mFramesBeforeHit As Int32
       Private mDelayedHit As Boolean
       Private mAttackFrames As Int32
       Private mInitialFramesBeforeHit As Int32
       Private mInitialAttackFXFrameDelay As Int32
       Private mProjectileSpeed As Single
       Private mInitialFramesBeforeBlock As Int32
       Private mIgnoreAttackTimeErrors As String
       Private mFramesBeforeBlock As Int32
       Private mFXImportant As Boolean
       Private mPrimaryTint As COH_XML_Color
       Private mSecondaryTint As COH_XML_Color
        '//i25 Score
       Private mSecondaryAttackFX As String
       Private mFramesBeforeSecondaryHit As Int32
       Private mSecondaryProjectileSpeed As Single
#End Region

#Region "Private Properties"
       Private mName As String
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mAttackBits = New Integer() {} ' 0 ' No Default Defined
            mBlockBits = New Integer() {} ' No Default Defined
            mWindUpBits = New Integer() {} ' No Default Defined
            mHitBits = New Integer() {} ' No Default Defined
            mDeathBits = New Integer() {} ' No Default Defined
            mActivationBits = New Integer() {} ' No Default Defined
            mDeactivationBits = New Integer() {} ' No Default Defined
            mInitialAttackBits = New Integer() {} ' No Default Defined
            mContinuingBits = New Integer() {} ' No Default Defined
            mConditionalBits = New Integer() {} ' No Default Defined
            mActivationFX = String.Empty
            mDeactivationFX = String.Empty
            mAttackFX = String.Empty
            mHitFX = String.Empty
            mWindUpFX = String.Empty
            mBlockFX = String.Empty
            mDeathFX = String.Empty
            mInitialAttackFX = String.Empty
            mContinuingFX = String.Empty
            mContinuingFX1 = String.Empty
            mContinuingFX2 = String.Empty
            mContinuingFX3 = String.Empty
            mContinuingFX4 = String.Empty
            mConditionalFX = String.Empty
            mConditionalFX1 = String.Empty
            mConditionalFX2 = String.Empty
            mConditionalFX3 = String.Empty
            mConditionalFX4 = String.Empty
            mModeBits = New Integer() {} ' No Default Defined
            mFramesBeforeHit = -1
            mDelayedHit = 0
            mAttackFrames = -1
            mInitialFramesBeforeHit = -1
            mInitialAttackFXFrameDelay = 0
            mProjectileSpeed = 0
            mInitialFramesBeforeBlock = 0
            mIgnoreAttackTimeErrors = String.Empty
            mFramesBeforeBlock = 0
            mFXImportant = 0
            mPrimaryTint = New Color ' No Default Defined
            mSecondaryTint = New Color ' No Default Defined

        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_PowerFX
            Dim Result As COH_PowerFX = New COH_PowerFX
            With Result
                .mAttackBits = mAttackBits
                .mBlockBits = mBlockBits
                .mWindUpBits = mWindUpBits
                .mHitBits = mHitBits
                .mDeathBits = mDeathBits
                .mActivationBits = mActivationBits
                .mDeactivationBits = mDeactivationBits
                .mInitialAttackBits = mInitialAttackBits
                .mContinuingBits = mContinuingBits
                .mConditionalBits = mConditionalBits
                .mActivationFX = String.Copy(mActivationFX)
                .mDeactivationFX = String.Copy(mDeactivationFX)
                .mAttackFX = String.Copy(mAttackFX)
                .mHitFX = String.Copy(mHitFX)
                .mWindUpFX = String.Copy(mWindUpFX)
                .mBlockFX = String.Copy(mBlockFX)
                .mDeathFX = String.Copy(mDeathFX)
                .mInitialAttackFX = String.Copy(mInitialAttackFX)
                .mContinuingFX = String.Copy(mContinuingFX)
                .mContinuingFX1 = String.Copy(mContinuingFX1)
                .mContinuingFX2 = String.Copy(mContinuingFX2)
                .mContinuingFX3 = String.Copy(mContinuingFX3)
                .mContinuingFX4 = String.Copy(mContinuingFX4)
                .mConditionalFX = String.Copy(mConditionalFX)
                .mConditionalFX1 = String.Copy(mConditionalFX1)
                .mConditionalFX2 = String.Copy(mConditionalFX2)
                .mConditionalFX3 = String.Copy(mConditionalFX3)
                .mConditionalFX4 = String.Copy(mConditionalFX4)
                .mModeBits = mModeBits
                .mFramesBeforeHit = mFramesBeforeHit
                .mDelayedHit = mDelayedHit
                .mAttackFrames = mAttackFrames
                .mInitialFramesBeforeHit = mInitialFramesBeforeHit
                .mInitialAttackFXFrameDelay = mInitialAttackFXFrameDelay
                .mProjectileSpeed = mProjectileSpeed
                .mInitialFramesBeforeBlock = mInitialFramesBeforeBlock
                .mIgnoreAttackTimeErrors = String.Copy(mIgnoreAttackTimeErrors)
                .mFramesBeforeBlock = mFramesBeforeBlock
                .mFXImportant = mFXImportant
                .mPrimaryTint = mPrimaryTint
                .mSecondaryTint = mSecondaryTint
                '//i25
                .mSecondaryAttackFX = CloneString(mSecondaryAttackFX)
                .mFramesBeforeSecondaryHit = mFramesBeforeSecondaryHit
                .mSecondaryProjectileSpeed = mSecondaryProjectileSpeed
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_IntegerArray(AttackBits)
            CurrentWriter.Write_CrypticS_IntegerArray(BlockBits)
            CurrentWriter.Write_CrypticS_IntegerArray(WindUpBits)
            CurrentWriter.Write_CrypticS_IntegerArray(HitBits)
            CurrentWriter.Write_CrypticS_IntegerArray(DeathBits)
            CurrentWriter.Write_CrypticS_IntegerArray(ActivationBits)
            CurrentWriter.Write_CrypticS_IntegerArray(DeactivationBits)
            CurrentWriter.Write_CrypticS_IntegerArray(InitialAttackBits)
            CurrentWriter.Write_CrypticS_IntegerArray(ContinuingBits)
            CurrentWriter.Write_CrypticS_IntegerArray(ConditionalBits)
            CurrentWriter.Write_CrypticS_String(ActivationFX)
            CurrentWriter.Write_CrypticS_String(DeactivationFX)
            CurrentWriter.Write_CrypticS_String(AttackFX)
            If CurrentWriter.Settings.Option_Version >= 7 Then CurrentWriter.Write_CrypticS_String(mSecondaryAttackFX)
            CurrentWriter.Write_CrypticS_String(HitFX)
            CurrentWriter.Write_CrypticS_String(WindUpFX)
            CurrentWriter.Write_CrypticS_String(BlockFX)
            CurrentWriter.Write_CrypticS_String(DeathFX)
            CurrentWriter.Write_CrypticS_String(InitialAttackFX)
            CurrentWriter.Write_CrypticS_String(ContinuingFX)
            CurrentWriter.Write_CrypticS_String(ContinuingFX1)
            CurrentWriter.Write_CrypticS_String(ContinuingFX2)
            CurrentWriter.Write_CrypticS_String(ContinuingFX3)
            CurrentWriter.Write_CrypticS_String(ContinuingFX4)
            CurrentWriter.Write_CrypticS_String(ConditionalFX)
            CurrentWriter.Write_CrypticS_String(ConditionalFX1)
            CurrentWriter.Write_CrypticS_String(ConditionalFX2)
            CurrentWriter.Write_CrypticS_String(ConditionalFX3)
            CurrentWriter.Write_CrypticS_String(ConditionalFX4)
            CurrentWriter.Write_CrypticS_IntegerArray(ModeBits)
            CurrentWriter.Write(FramesBeforeHit) '.ReadInt32
            '!!REDUNDENT!!Result.SeqBits)'.Read_CrypticS_IntegerArray()
            '!!REDUNDENT!!Result.cast_anim)'.Read_CrypticS_IntegerArray()
            '!!REDUNDENT!!Result.hit_anim)'.Read_CrypticS_IntegerArray()
            '!!REDUNDENT!!Result.deathanimbits)'.Read_CrypticS_IntegerArray()
            '!!REDUNDENT!!Result.AttachedAnim)'.Read_CrypticS_IntegerArray()
            '!!REDUNDENT!!Result.AttachedFxName)'.ReadString_CrypticS
            '!!REDUNDENT!!Result.TravellingProjectileEffect)'.ReadString_CrypticS
            '!!REDUNDENT!!Result.AttachedToVictimFxName)'.ReadString_CrypticS
            '!!REDUNDENT!!Result.TimeBeforePunchHits)'.ReadInt32
            '!!REDUNDENT!!Result.TimeBeforeMissileSpawns)'.ReadInt32
            CurrentWriter.Write_CrypticS_Boolean(DelayedHit) '.ReadInt32
            '!!IGNORED!!(TogglePower = 
            CurrentWriter.Write(AttackFrames)
            '!!REDUNDENT!!Result.NonInterruptFrames)'.ReadInt32
            CurrentWriter.Write(InitialFramesBeforeHit) '.ReadInt32
            If CurrentWriter.Settings.Option_Version >= 7 Then CurrentWriter.Write(mFramesBeforeSecondaryHit)
            CurrentWriter.Write(InitialAttackFXFrameDelay) '.ReadInt32
            CurrentWriter.Write(ProjectileSpeed) '.ReadSingle
            If CurrentWriter.Settings.Option_Version >= 7 Then CurrentWriter.Write(mSecondaryProjectileSpeed)
            CurrentWriter.Write(InitialFramesBeforeBlock) '.ReadInt32
            CurrentWriter.Write_CrypticS_String(IgnoreAttackTimeErrors)
            CurrentWriter.Write(FramesBeforeBlock) '.ReadInt32
            CurrentWriter.Write_CrypticS_Boolean(FXImportant) '.ReadInt32
            CurrentWriter.Write_CrypticS_CondRGB(PrimaryTint) '.Read_CrypticS_CondRGB
            CurrentWriter.Write_CrypticS_CondRGB(SecondaryTint) '.Read_CrypticS_CondRGB
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            AttackBits = CurrentReader.Read_CrypticS_IntegerArray()
            BlockBits = CurrentReader.Read_CrypticS_IntegerArray()
            WindUpBits = CurrentReader.Read_CrypticS_IntegerArray()
            HitBits = CurrentReader.Read_CrypticS_IntegerArray()
            DeathBits = CurrentReader.Read_CrypticS_IntegerArray()
            ActivationBits = CurrentReader.Read_CrypticS_IntegerArray()
            DeactivationBits = CurrentReader.Read_CrypticS_IntegerArray()
            InitialAttackBits = CurrentReader.Read_CrypticS_IntegerArray()
            ContinuingBits = CurrentReader.Read_CrypticS_IntegerArray()
            ConditionalBits = CurrentReader.Read_CrypticS_IntegerArray()
            ActivationFX = CurrentReader.Read_CrypticS_String
            DeactivationFX = CurrentReader.Read_CrypticS_String
            AttackFX = CurrentReader.Read_CrypticS_String
            If CurrentReader.Settings.Option_Version >= 7 Then mSecondaryAttackFX = CurrentReader.Read_CrypticS_String
            HitFX = CurrentReader.Read_CrypticS_String
            WindUpFX = CurrentReader.Read_CrypticS_String
            BlockFX = CurrentReader.Read_CrypticS_String
            DeathFX = CurrentReader.Read_CrypticS_String
            InitialAttackFX = CurrentReader.Read_CrypticS_String
            ContinuingFX = CurrentReader.Read_CrypticS_String
            ContinuingFX1 = CurrentReader.Read_CrypticS_String
            ContinuingFX2 = CurrentReader.Read_CrypticS_String
            ContinuingFX3 = CurrentReader.Read_CrypticS_String
            ContinuingFX4 = CurrentReader.Read_CrypticS_String
            ConditionalFX = CurrentReader.Read_CrypticS_String
            ConditionalFX1 = CurrentReader.Read_CrypticS_String
            ConditionalFX2 = CurrentReader.Read_CrypticS_String
            ConditionalFX3 = CurrentReader.Read_CrypticS_String
            ConditionalFX4 = CurrentReader.Read_CrypticS_String
            ModeBits = CurrentReader.Read_CrypticS_IntegerArray()
            FramesBeforeHit = CurrentReader.ReadInt32
            '!!REDUNDENT!!SeqBits = CurrentReader.Read_CrypticS_IntegerArray()
            '!!REDUNDENT!!cast_anim = CurrentReader.Read_CrypticS_IntegerArray()
            '!!REDUNDENT!!hit_anim = CurrentReader.Read_CrypticS_IntegerArray()
            '!!REDUNDENT!!deathanimbits = CurrentReader.Read_CrypticS_IntegerArray()
            '!!REDUNDENT!!AttachedAnim = CurrentReader.Read_CrypticS_IntegerArray()
            '!!REDUNDENT!!AttachedFxName = CurrentReader.ReadString_CrypticS
            '!!REDUNDENT!!TravellingProjectileEffect = CurrentReader.ReadString_CrypticS
            '!!REDUNDENT!!AttachedToVictimFxName = CurrentReader.ReadString_CrypticS
            '!!REDUNDENT!!TimeBeforePunchHits = CurrentReader.ReadInt32
            '!!REDUNDENT!!TimeBeforeMissileSpawns = CurrentReader.ReadInt32
            DelayedHit = CurrentReader.ReadInt32
            '!!IGNORED!! TogglePower = 
            AttackFrames = CurrentReader.ReadInt32
            '!!REDUNDENT!!NonInterruptFrames = CurrentReader.ReadInt32
            InitialFramesBeforeHit = CurrentReader.ReadInt32
            If CurrentReader.Settings.Option_Version >= 7 Then mFramesBeforeSecondaryHit = CurrentReader.ReadInt32
            InitialAttackFXFrameDelay = CurrentReader.ReadInt32
            ProjectileSpeed = CurrentReader.ReadSingle
            If CurrentReader.Settings.Option_Version >= 7 Then mSecondaryProjectileSpeed = CurrentReader.ReadSingle
            InitialFramesBeforeBlock = CurrentReader.ReadInt32
            IgnoreAttackTimeErrors = CurrentReader.Read_CrypticS_String
            FramesBeforeBlock = CurrentReader.ReadInt32
            FXImportant = CurrentReader.ReadInt32
            PrimaryTint = CurrentReader.Read_CrypticS_CondRGB
            SecondaryTint = CurrentReader.Read_CrypticS_CondRGB
            Return True
        End Function
#End Region
    End Class
End Namespace