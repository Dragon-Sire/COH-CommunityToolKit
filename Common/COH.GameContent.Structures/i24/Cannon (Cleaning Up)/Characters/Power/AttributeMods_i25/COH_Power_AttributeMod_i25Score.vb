
Imports COH.GameContent.Structures.Characters.Powers.ModParams
Imports COH.GameContent.Structures.Powers

Namespace GameContent.Structures.Characters.Powers
    Public NotInheritable Class COH_Power_AttributeMod_i25_Score
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "AttributeMod"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Attrib As Int32()
            Get
                Return mAttrib
            End Get
            Set(value As Int32())
                SetValue(mAttrib, value)
            End Set
        End Property
        Property Aspect As COH_Enum_Aspect
            Get
                Return mAspect
            End Get
            Set(value As COH_Enum_Aspect)
                SetValue(mAspect, value)
            End Set
        End Property
        Property ApplicationType As COH_Enum_ModApplication
            Get
                Return mApplicationType
            End Get
            Set(value As COH_Enum_ModApplication)
                SetValue(mApplicationType, value)
            End Set
        End Property
        Property Type As COH_Enum_ModType
            Get
                Return mType
            End Get
            Set(value As COH_Enum_ModType)
                SetValue(mType, value)
            End Set
        End Property
        Property Target As COH_Enum_ModTarget
            Get
                Return mTarget
            End Get
            Set(value As COH_Enum_ModTarget)
                SetValue(mTarget, value)
            End Set
        End Property
        Property TargetInfo As COH_AttribMod_i25Score_TagetInfo()
            Get
                Return mTargetInfo
            End Get
            Set(value As COH_AttribMod_i25Score_TagetInfo())
                SetValue(mTargetInfo, value)
            End Set
        End Property
        Property Table As String
            Get
                Return mTable
            End Get
            Set(value As String)
                SetValue(mTable, value)
            End Set
        End Property
        Property Scale As Single
            Get
                Return mScale
            End Get
            Set(value As Single)
                SetValue(mScale, value)
            End Set
        End Property
        Property Duration As Single
            Get
                Return mDuration
            End Get
            Set(value As Single)
                SetValue(mDuration, value)
            End Set
        End Property
        Property Magnitude As Single
            Get
                Return mMagnitude
            End Get
            Set(value As Single)
                SetValue(mMagnitude, value)
            End Set
        End Property
        Property DurationExpr As String()
            Get
                Return mDurationExpr
            End Get
            Set(value As String())
                SetValue(mDurationExpr, value)
            End Set
        End Property
        Property MagnitudeExpr As String()
            Get
                Return mMagnitudeExpr
            End Get
            Set(value As String())
                SetValue(mMagnitudeExpr, value)
            End Set
        End Property
        Property Delay As Single
            Get
                Return mDelay
            End Get
            Set(value As Single)
                SetValue(mDelay, value)
            End Set
        End Property
        Property Period As Single
            Get
                Return mPeriod
            End Get
            Set(value As Single)
                SetValue(mPeriod, value)
            End Set
        End Property
        <DefaultValue(1)> Property TickChance As Single
            Get
                Return mTickChance
            End Get
            Set(value As Single)
                SetValue(mTickChance, value)
            End Set
        End Property
        Property DelayedRequires As String()
            Get
                Return mDelayedRequires
            End Get
            Set(value As String())
                SetValue(mDelayedRequires, value)
            End Set
        End Property
        Property CasterStackType As COH_Enum_CasterStackType
            Get
                Return mCasterStackType
            End Get
            Set(value As COH_Enum_CasterStackType)
                SetValue(mCasterStackType, value)
            End Set
        End Property
        Property StackType As COH_Enum_StackType
            Get
                Return mStackType
            End Get
            Set(value As COH_Enum_StackType)
                SetValue(mStackType, value)
            End Set
        End Property
        <DefaultValue(2)> Property StackLimit As Int32
            Get
                Return mStackLimit
            End Get
            Set(value As Int32)
                SetValue(mStackLimit, value)
            End Set
        End Property
        <DefaultValue(-1)> Property StackKey As Int32
            Get
                Return mStackKey
            End Get
            Set(value As Int32)
                SetValue(mStackKey, value)
            End Set
        End Property
        Property CancelEvents As COH_Enum_PowerEvent()
            Get
                Return mCancelEvents
            End Get
            Set(value As COH_Enum_PowerEvent())
                SetValue(mCancelEvents, value)
            End Set
        End Property
        Property Suppress As COH_SuppressPairs()
            Get
                Return mSuppress
            End Get
            Set(value As COH_SuppressPairs())
                SetValue(mSuppress, value)
            End Set
        End Property
        Property BoostModAllowed As Int32
            Get
                Return mBoostModAllowed
            End Get
            Set(value As Int32)
                SetValue(mBoostModAllowed, value)
            End Set
        End Property
        Property Flags As COH_EnumFlags_AttribModFlags()
            Get
                Return mFlags
            End Get
            Set(value As COH_EnumFlags_AttribModFlags())
                SetValue(mFlags, value)
            End Set
        End Property
        Property Messages As COH_AttribMod_i25Score_Messages()
            Get
                Return mMessages
            End Get
            Set(value As COH_AttribMod_i25Score_Messages())
                SetValue(mMessages, value)
            End Set
        End Property
        Property FX As COH_AttribMod_i25Score_FX()
            Get
                Return mFX
            End Get
            Set(value As COH_AttribMod_i25Score_FX())
                SetValue(mFX, value)
            End Set
        End Property
        Property Param As COH_ModParam
            Get
                Return mParam
            End Get
            Set(value As COH_ModParam)
                SetValue(mParam, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mAttrib As Int32()
       Private mAspect As COH_Enum_Aspect
       Private mApplicationType As COH_Enum_ModApplication
       Private mType As COH_Enum_ModType
       Private mTarget As COH_Enum_ModTarget
       Private mTargetInfo As COH_AttribMod_i25Score_TagetInfo()
       Private mTable As String
       Private mScale As Single
       Private mDuration As Single
       Private mMagnitude As Single
       Private mDurationExpr As String()
       Private mMagnitudeExpr As String()
       Private mDelay As Single
       Private mPeriod As Single
       Private mTickChance As Single
       Private mDelayedRequires As String()
       Private mCasterStackType As COH_Enum_CasterStackType
       Private mStackType As COH_Enum_StackType
       Private mStackLimit As Int32
       Private mStackKey As Int32
       Private mCancelEvents As COH_Enum_PowerEvent()
       Private mSuppress As COH_SuppressPairs()
       Private mBoostModAllowed As Int32
       Private mFlags As COH_EnumFlags_AttribModFlags()
       Private mMessages As COH_AttribMod_i25Score_Messages()
       Private mFX As COH_AttribMod_i25Score_FX()
       Private mParam As COH_ModParam
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
            mAttrib = New Int32() {}
            mAspect = 0
            mApplicationType = COH_Enum_ModApplication.kModApplicationType_OnTick
            mType = COH_Enum_ModType.kModType_Magnitude
            mTarget = COH_Enum_ModTarget.kModTarget_Affected
            mTargetInfo = New COH_AttribMod_i25Score_TagetInfo() {}
            mTable = String.Empty
            mDurationExpr = New String() {}
            mMagnitudeExpr = New String() {}
            mDelayedRequires = New String() {}
            mCasterStackType = COH_Enum_CasterStackType.kCasterStackType_Individual
            mStackType = COH_Enum_StackType.kStackType_Replace
            mCancelEvents = New COH_Enum_PowerEvent() {} '0' No Default Defined
            mSuppress = New COH_SuppressPairs() {}
            mMessages = New COH_AttribMod_i25Score_Messages() {}
            mFX = New COH_AttribMod_i25Score_FX() {}
            mFlags = New COH_EnumFlags_AttribModFlags(1) {}
            mParam = New COH_ModParam
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Power_AttributeMod_i25_Score
            Dim Result As COH_Power_AttributeMod_i25_Score = New COH_Power_AttributeMod_i25_Score
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mAttrib = New Int32(mAttrib.Count - 1) {} : mAttrib.CopyTo(.mAttrib, 0)
                .mAspect = mAspect
                .mApplicationType = mApplicationType
                .mType = mType
                .mTarget = mTarget
                .mTargetInfo = New COH_AttribMod_i25Score_TagetInfo(mTargetInfo.Count - 1) {}
                For X = 0 To mTargetInfo.Count - 1
                    .mTargetInfo(X) = mTargetInfo(X).Clone
                Next
                .mTable = CloneString(mTable)
                .mScale = mScale
                .mDuration = mDuration
                .mMagnitude = mMagnitude
                .mDurationExpr = CloneStrings(mDurationExpr)
                .mMagnitudeExpr = CloneStrings(mMagnitudeExpr)
                .mDelay = mDelay
                .mPeriod = mPeriod
                .mTickChance = mTickChance
                .mDelayedRequires = CloneStrings(mDelayedRequires)
                .mCasterStackType = mCasterStackType
                .mStackType = mStackType
                .mStackLimit = mStackLimit
                .mStackKey = mStackKey
                .mCancelEvents = New COH_Enum_PowerEvent(mCancelEvents.Count - 1) {} : mCancelEvents.CopyTo(.mCancelEvents, 0)
                .mSuppress = New COH_SuppressPairs(mSuppress.Count - 1) {}
                For X = 0 To mSuppress.Count - 1
                    .mSuppress(X) = mSuppress(X).Clone
                Next
                .mBoostModAllowed = mBoostModAllowed
                .mMessages = New COH_AttribMod_i25Score_Messages(mMessages.Count - 1) {}
                For X = 0 To mMessages.Count - 1
                    .mMessages(X) = mMessages(X).Clone
                Next
                .mFX = New COH_AttribMod_i25Score_FX(mFX.Count - 1) {}
                For X = 0 To mFX.Count - 1
                    .mFX(X) = mFX(X).Clone
                Next
                .mFlags = mFlags
                'If Not mParam Is Nothing Then .mParam = mParam.CloneMe
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_IntegerArray(mAttrib)
            CurrentWriter.Write(CInt(mAspect))
            CurrentWriter.Write(CInt(mApplicationType))
            CurrentWriter.Write(CInt(mType))
            CurrentWriter.Write(CInt(mTarget))
            If CurrentWriter.Write_CrypticS_StructArray(mTargetInfo) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mTable)
            CurrentWriter.Write(mScale)
            CurrentWriter.Write(mDuration)
            CurrentWriter.Write(mMagnitude)
            CurrentWriter.Write_CrypticS_StringArray(mDurationExpr)
            CurrentWriter.Write_CrypticS_StringArray(mMagnitudeExpr)
            CurrentWriter.Write(mDelay)
            CurrentWriter.Write(mPeriod)
            CurrentWriter.Write(mTickChance)
            CurrentWriter.Write_CrypticS_StringArray(mDelayedRequires)
            CurrentWriter.Write(CInt(mCasterStackType))
            CurrentWriter.Write(CInt(mStackType))
            CurrentWriter.Write(mStackLimit)
            CurrentWriter.Write(mStackKey)
            CurrentWriter.Write_CrypticS_IntegerArray(mCancelEvents)
            If CurrentWriter.Write_CrypticS_StructArray(mSuppress) = False Then Return False
            CurrentWriter.Write(mBoostModAllowed)
            CurrentWriter.Write(mFlags(0))
            CurrentWriter.Write(mFlags(1))
            If CurrentWriter.Write_CrypticS_StructArray(mMessages) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mFX) = False Then Return False
            ShowErrorOccured("Does NOt Write PAram yet")
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mAttrib = CurrentReader.Read_CrypticS_IntegerArray()
            mAspect = CurrentReader.ReadInt32
            mApplicationType = CurrentReader.ReadInt32
            mType = CurrentReader.ReadInt32
            mTarget = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttribMod_i25Score_TagetInfo), mTargetInfo) = False Then Return False
            mTable = CurrentReader.Read_CrypticS_String
            mScale = CurrentReader.ReadSingle
            mDuration = CurrentReader.ReadSingle
            mMagnitude = CurrentReader.ReadSingle
            mDurationExpr = CurrentReader.Read_CrypticS_StringArray
            mMagnitudeExpr = CurrentReader.Read_CrypticS_StringArray
            mDelay = CurrentReader.ReadSingle
            mPeriod = CurrentReader.ReadSingle
            mTickChance = CurrentReader.ReadSingle
            mDelayedRequires = CurrentReader.Read_CrypticS_StringArray
            mCasterStackType = CurrentReader.ReadInt32
            mStackType = CurrentReader.ReadInt32
            mStackLimit = CurrentReader.ReadInt32
            mStackKey = CurrentReader.ReadInt32
            mCancelEvents = CurrentReader.Read_CrypticS_IntegerArray()
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_SuppressPairs), mSuppress) = False Then Return False
            mBoostModAllowed = CurrentReader.ReadInt32
            mFlags = New Int32(1) {CurrentReader.ReadInt32, CurrentReader.ReadInt32}
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttribMod_i25Score_Messages), mMessages) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttribMod_i25Score_FX), mFX) = False Then Return False
            mParam = New COH_ModParam(CurrentReader)
            Return True
        End Function
#End Region

    End Class
End Namespace
