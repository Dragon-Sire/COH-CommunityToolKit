Imports COH.GameContent.Structures.Enemies.AI
Imports COH.GameContent.Structures.Shared
Imports COH.GameContent.Structures.Shared.Drawing

Namespace GameContent.Structures.Animation.FX
    Public NotInheritable Class COH_FX_Event
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return EName
            End Get
        End Property
#End Region

#Region "Properties"
        Property EName As String
            Get
                Return mEName
            End Get
            Set(value As String)
                mEName = value
            End Set
        End Property
        Property Type As Int32
            Get
                Return mType
            End Get
            Set(value As Int32)
                mType = value
            End Set
        End Property
        Property Inherit As COH_Enum_FX_Transform
            Get
                Return mInherit
            End Get
            Set(value As COH_Enum_FX_Transform)
                mInherit = value
            End Set
        End Property
        Property Update As COH_Enum_FX_Transform
            Get
                Return mUpdate
            End Get
            Set(value As COH_Enum_FX_Transform)
                mUpdate = value
            End Set
        End Property
        Property At As String
            Get
                Return mAt
            End Get
            Set(value As String)
                mAt = value
            End Set
        End Property
        Property Bhvr As String
            Get
                Return mBhvr
            End Get
            Set(value As String)
                mBhvr = value
            End Set
        End Property
        Property BhvrOverride As COH_Behavior()
            Get
                Return mBhvrOverride
            End Get
            Set(value As COH_Behavior())
                mBhvrOverride = value
            End Set
        End Property
        Property JEvent As String
            Get
                Return mJEvent
            End Get
            Set(value As String)
                mJEvent = value
            End Set
        End Property
        Property CEvent As String
            Get
                Return mCEvent
            End Get
            Set(value As String)
                mCEvent = value
            End Set
        End Property
        Property CDestroy As Byte
            Get
                Return mCDestroy
            End Get
            Set(value As Byte)
                mCDestroy = value
            End Set
        End Property
        Property JDestroy As Byte
            Get
                Return mJDestroy
            End Get
            Set(value As Byte)
                mJDestroy = value
            End Set
        End Property
        Property CRotation As COH_Enum_FX_CollisionRotation
            Get
                Return mCRotation
            End Get
            Set(value As COH_Enum_FX_CollisionRotation)
                mCRotation = value
            End Set
        End Property
        Property ParentVelocityFraction As Single
            Get
                Return mParentVelocityFraction
            End Get
            Set(value As Single)
                mParentVelocityFraction = value
            End Set
        End Property
        Property CThresh As Single
            Get
                Return mCThresh
            End Get
            Set(value As Single)
                mCThresh = value
            End Set
        End Property
        Property HardwareOnly As Boolean
            Get
                Return mHardwareOnly
            End Get
            Set(value As Boolean)
                mHardwareOnly = value
            End Set
        End Property
        Property SoftwareOnly As Boolean
            Get
                Return mSoftwareOnly
            End Get
            Set(value As Boolean)
                mSoftwareOnly = value
            End Set
        End Property
        Property PhysicsOnly As Boolean
            Get
                Return mPhysicsOnly
            End Get
            Set(value As Boolean)
                mPhysicsOnly = value
            End Set
        End Property
        Property CameraSpace As Boolean
            Get
                Return mCameraSpace
            End Get
            Set(value As Boolean)
                mCameraSpace = value
            End Set
        End Property
        Property RayLength As Single
            Get
                Return mRayLength
            End Get
            Set(value As Single)
                mRayLength = value
            End Set
        End Property
        Property AtRayFx As String
            Get
                Return mAtRayFx
            End Get
            Set(value As String)
                mAtRayFx = value
            End Set
        End Property
        Property Geom As COH_Generic_StringTableArray
            Get
                Return mGeom
            End Get
            Set(value As COH_Generic_StringTableArray)
                mGeom = value
            End Set
        End Property
        Property Cape As COH_Generic_StringTableArray
            Get
                Return mCape
            End Get
            Set(value As COH_Generic_StringTableArray)
                mCape = value
            End Set
        End Property
        Property AltPiv As Int32
            Get
                Return mAltPiv
            End Get
            Set(value As Int32)
                mAltPiv = value
            End Set
        End Property
        Property AnimPiv As String
            Get
                Return mAnimPiv
            End Get
            Set(value As String)
                mAnimPiv = value
            End Set
        End Property
        Property Part As COH_Generic_StringTableArray
            Get
                Return mPart
            End Get
            Set(value As COH_Generic_StringTableArray)
                mPart = value
            End Set
        End Property
        Property Anim As String
            Get
                Return mAnim
            End Get
            Set(value As String)
                mAnim = value
            End Set
        End Property
        Property SetState As String
            Get
                Return mSetState
            End Get
            Set(value As String)
                mSetState = value
            End Set
        End Property
        Property ChildFx As String
            Get
                Return mChildFx
            End Get
            Set(value As String)
                mChildFx = value
            End Set
        End Property
        Property Magnet As String
            Get
                Return mMagnet
            End Get
            Set(value As String)
                mMagnet = value
            End Set
        End Property
        Property LookAt As String
            Get
                Return mLookAt
            End Get
            Set(value As String)
                mLookAt = value
            End Set
        End Property
        Property PMagnet As String
            Get
                Return mPMagnet
            End Get
            Set(value As String)
                mPMagnet = value
            End Set
        End Property
        Property POther As String
            Get
                Return mPOther
            End Get
            Set(value As String)
                mPOther = value
            End Set
        End Property
        Property Splat As COH_FX_Event_Splat()
            Get
                Return mSplat
            End Get
            Set(value As COH_FX_Event_Splat())
                mSplat = value
            End Set
        End Property
        Property Sound As COH_FX_Event_Sound()
            Get
                Return mSound
            End Get
            Set(value As COH_FX_Event_Sound())
                mSound = value
            End Set
        End Property
        Property SoundNoRepeat As Int32
            Get
                Return mSoundNoRepeat
            End Get
            Set(value As Int32)
                mSoundNoRepeat = value
            End Set
        End Property
        Property LifeSpan As Single
            Get
                Return mLifeSpan
            End Get
            Set(value As Single)
                mLifeSpan = value
            End Set
        End Property
        Property LifeSpanJitter As Single
            Get
                Return mLifeSpanJitter
            End Get
            Set(value As Single)
                mLifeSpanJitter = value
            End Set
        End Property
        Property Power As COH_Color_RG
            Get
                Return mPower
            End Get
            Set(value As COH_Color_RG)
                mPower = value
            End Set
        End Property
        Property [While] As COH_Generic_StringTableArray
            Get
                Return mWhile
            End Get
            Set(value As COH_Generic_StringTableArray)
                mWhile = value
            End Set
        End Property
        Property Until As COH_Generic_StringTableArray
            Get
                Return mUntil
            End Get
            Set(value As COH_Generic_StringTableArray)
                mUntil = value
            End Set
        End Property
        Property WorldGroup As String
            Get
                Return mWorldGroup
            End Get
            Set(value As String)
                mWorldGroup = value
            End Set
        End Property
        Property Flags As COH_Enum_FXEvent
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_FXEvent)
                mFlags = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mEName As String
       Private mType As Int32
       Private mInherit As COH_Enum_FX_Transform
       Private mUpdate As COH_Enum_FX_Transform
       Private mAt As String
       Private mBhvr As String
       Private mBhvrOverride As COH_Behavior()
       Private mJEvent As String
       Private mCEvent As String
       Private mCDestroy As Byte
       Private mJDestroy As Byte
       Private mCRotation As COH_Enum_FX_CollisionRotation
       Private mParentVelocityFraction As Single
       Private mCThresh As Single
       Private mHardwareOnly As Boolean
       Private mSoftwareOnly As Boolean
       Private mPhysicsOnly As Boolean
       Private mCameraSpace As Boolean
       Private mRayLength As Single
       Private mAtRayFx As String
       Private mGeom As COH_Generic_StringTableArray
       Private mCape As COH_Generic_StringTableArray
       Private mAltPiv As Int32
       Private mAnimPiv As String
       Private mPart As COH_Generic_StringTableArray
       Private mAnim As String
       Private mSetState As String
       Private mChildFx As String
       Private mMagnet As String
       Private mLookAt As String
       Private mPMagnet As String
       Private mPOther As String
       Private mSplat As COH_FX_Event_Splat()
       Private mSound As COH_FX_Event_Sound()
       Private mSoundNoRepeat As Int32
       Private mLifeSpan As Single
       Private mLifeSpanJitter As Single
       Private mPower As COH_Color_RG
       Private mWorldGroup As String
       Private mFlags As COH_Enum_FXEvent
       Private mWhile As COH_Generic_StringTableArray
       Private mUntil As COH_Generic_StringTableArray
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
            mEName = String.Empty
            mAt = String.Empty
            mBhvr = String.Empty
            mBhvrOverride = New COH_Behavior() {}
            mJEvent = String.Empty
            mCEvent = String.Empty
            mAtRayFx = String.Empty
            mAnimPiv = String.Empty
            mAnim = String.Empty
            mSetState = String.Empty
            mChildFx = String.Empty
            mMagnet = String.Empty
            mLookAt = String.Empty
            mPMagnet = String.Empty
            mPOther = String.Empty
            mSplat = New COH_FX_Event_Splat() {}
            mSound = New COH_FX_Event_Sound() {}
            mWorldGroup = String.Empty
            mGeom = New COH_Generic_StringTableArray()
            mCape = New COH_Generic_StringTableArray()
            mPart = New COH_Generic_StringTableArray()
            mWhile = New COH_Generic_StringTableArray()
            mUntil = New COH_Generic_StringTableArray()
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_FX_Event
            Dim Result As COH_FX_Event = New COH_FX_Event
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mEName = String.Copy(mEName)
                .mType = mType
                .mInherit = mInherit
                .mUpdate = mUpdate
                .mAt = String.Copy(mAt)
                .mBhvr = String.Copy(mBhvr)
                .mBhvrOverride = New COH_Behavior(mBhvrOverride.Count - 1) {}
                For X = 0 To mBhvrOverride.Count - 1
                    .mBhvrOverride(X) = mBhvrOverride(X).Clone
                Next
                .mJEvent = String.Copy(mJEvent)
                .mCEvent = String.Copy(mCEvent)
                .mCDestroy = mCDestroy
                .mJDestroy = mJDestroy
                .mCRotation = mCRotation
                .mParentVelocityFraction = mParentVelocityFraction
                .mCThresh = mCThresh
                .mHardwareOnly = mHardwareOnly
                .mSoftwareOnly = mSoftwareOnly
                .mPhysicsOnly = mPhysicsOnly
                .mCameraSpace = mCameraSpace
                .mRayLength = mRayLength
                .mAtRayFx = String.Copy(mAtRayFx)
                .mGeom = mGeom
                .mCape = mCape
                .mAltPiv = mAltPiv
                .mAnimPiv = String.Copy(mAnimPiv)
                .mPart = mPart
                .mAnim = String.Copy(mAnim)
                .mSetState = String.Copy(mSetState)
                .mChildFx = String.Copy(mChildFx)
                .mMagnet = String.Copy(mMagnet)
                .mLookAt = String.Copy(mLookAt)
                .mPMagnet = String.Copy(mPMagnet)
                .mPOther = String.Copy(mPOther)
                .mSplat = New COH_FX_Event_Splat(mSplat.Count - 1) {}
                For X = 0 To mSplat.Count - 1
                    .mSplat(X) = mSplat(X).Clone
                Next
                .mSound = New COH_FX_Event_Sound(mSound.Count - 1) {}
                For X = 0 To mSound.Count - 1
                    .mSound(X) = mSound(X).Clone
                Next
                .mSoundNoRepeat = mSoundNoRepeat
                .mLifeSpan = mLifeSpan
                .mLifeSpanJitter = mLifeSpanJitter
                .mPower = mPower
                .mWhile = mWhile
                .mUntil = mUntil
                .mWorldGroup = String.Copy(mWorldGroup)
                .mFlags = mFlags
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mEName)
            CurrentWriter.Write(mType)
            CurrentWriter.Write_CrypticS_Flags(mInherit)
            CurrentWriter.Write_CrypticS_Flags(mUpdate)
            CurrentWriter.Write_CrypticS_String(mAt)
            CurrentWriter.Write_CrypticS_String(mBhvr)
            If CurrentWriter.Write_CrypticS_StructArray(mBhvrOverride) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mJEvent)
            CurrentWriter.Write_CrypticS_String(mCEvent)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mCDestroy)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mJDestroy)
            CurrentWriter.Write_CrypticS_Flags(mCRotation)
            CurrentWriter.Write(mParentVelocityFraction)
            CurrentWriter.Write(mCThresh)
            CurrentWriter.Write_CrypticS_Boolean(mHardwareOnly)
            CurrentWriter.Write_CrypticS_Boolean(mSoftwareOnly)
            CurrentWriter.Write_CrypticS_Boolean(mPhysicsOnly)
            CurrentWriter.Write_CrypticS_Boolean(mCameraSpace)
            CurrentWriter.Write(mRayLength)
            CurrentWriter.Write_CrypticS_String(mAtRayFx)
            If CurrentWriter.Write_CrypticS_Struct(mGeom) = False Then Return False
            If CurrentWriter.Write_CrypticS_Struct(mCape) = False Then Return False
            CurrentWriter.Write(mAltPiv)
            CurrentWriter.Write_CrypticS_String(mAnimPiv)
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mPart1, Version, BuildType) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mPart2, Version, BuildType) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mPart3, Version, BuildType) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mPart4, Version, BuildType) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mPart5, Version, BuildType) = False Then Return False
            If CurrentWriter.Write_CrypticS_Struct(mPart) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mAnim)
            CurrentWriter.Write_CrypticS_String(mSetState)
            CurrentWriter.Write_CrypticS_String(mChildFx)
            CurrentWriter.Write_CrypticS_String(mMagnet)
            CurrentWriter.Write_CrypticS_String(mLookAt)
            CurrentWriter.Write_CrypticS_String(mPMagnet)
            CurrentWriter.Write_CrypticS_String(mPOther)
            If CurrentWriter.Write_CrypticS_StructArray(mSplat) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mSound) = False Then Return False
            CurrentWriter.Write(mSoundNoRepeat)
            CurrentWriter.Write(mLifeSpan)
            CurrentWriter.Write(mLifeSpanJitter)
            mPower.Export_To_Stream(CurrentWriter)
            If CurrentWriter.Write_CrypticS_Struct(mWhile) = False Then Return False
            If CurrentWriter.Write_CrypticS_Struct(mUntil) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mWorldGroup)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mEName = CurrentReader.Read_CrypticS_String
            mType = CurrentReader.ReadInt32
            mInherit = CurrentReader.Read_CrypticS_Flags
            mUpdate = CurrentReader.Read_CrypticS_Flags
            mAt = CurrentReader.Read_CrypticS_String
            mBhvr = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Behavior), mBhvrOverride) = False Then Return False
            mJEvent = CurrentReader.Read_CrypticS_String
            mCEvent = CurrentReader.Read_CrypticS_String
            mCDestroy = CurrentReader.Read_CrypticS_Byte_Aligned4
            mJDestroy = CurrentReader.Read_CrypticS_Byte_Aligned4
            mCRotation = CurrentReader.Read_CrypticS_Flags
            mParentVelocityFraction = CurrentReader.ReadSingle
            mCThresh = CurrentReader.ReadSingle
            mHardwareOnly = CurrentReader.Read_CrypticS_Boolean
            mSoftwareOnly = CurrentReader.Read_CrypticS_Boolean
            mPhysicsOnly = CurrentReader.Read_CrypticS_Boolean
            mCameraSpace = CurrentReader.Read_CrypticS_Boolean
            mRayLength = CurrentReader.ReadSingle
            mAtRayFx = CurrentReader.Read_CrypticS_String
            mGeom = New COH_Generic_StringTableArray(CurrentReader)
            mCape = New COH_Generic_StringTableArray(CurrentReader)
            mAltPiv = CurrentReader.ReadInt32
            mAnimPiv = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mPart1 = New COH_Generic_StringTableArray(CurrentReader, Version, COH_ExportFormats.CrypticS,BuildType)
            '!!REDUNDENT!!mPart2 = New COH_Generic_StringTableArray(CurrentReader, Version, COH_ExportFormats.CrypticS,BuildType)
            '!!REDUNDENT!!mPart3 = New COH_Generic_StringTableArray(CurrentReader, Version, COH_ExportFormats.CrypticS,BuildType)
            '!!REDUNDENT!!mPart4 = New COH_Generic_StringTableArray(CurrentReader, Version, COH_ExportFormats.CrypticS,BuildType)
            '!!REDUNDENT!!mPart5 = New COH_Generic_StringTableArray(CurrentReader, Version, COH_ExportFormats.CrypticS,BuildType)
            mPart = New COH_Generic_StringTableArray(CurrentReader)
            mAnim = CurrentReader.Read_CrypticS_String
            mSetState = CurrentReader.Read_CrypticS_String
            mChildFx = CurrentReader.Read_CrypticS_String
            mMagnet = CurrentReader.Read_CrypticS_String
            mLookAt = CurrentReader.Read_CrypticS_String
            mPMagnet = CurrentReader.Read_CrypticS_String
            mPOther = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_FX_Event_Splat), mSplat) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_FX_Event_Sound), mSound) = False Then Return False
            mSoundNoRepeat = CurrentReader.ReadInt32
            mLifeSpan = CurrentReader.ReadSingle
            mLifeSpanJitter = CurrentReader.ReadSingle
            mPower = New COH_Color_RG(CurrentReader)
            mWhile = New COH_Generic_StringTableArray(CurrentReader)
            mUntil = New COH_Generic_StringTableArray(CurrentReader)
            mWorldGroup = CurrentReader.Read_CrypticS_String
            mFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace
