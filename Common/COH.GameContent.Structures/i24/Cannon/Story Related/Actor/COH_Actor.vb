Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_Actor
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Type As COH_Enum_ActorType
            Get
                Return mType
            End Get
            Set(value As COH_Enum_ActorType)
                mType = value
            End Set
        End Property
        Property Number As Int32
            Get
                Return mNumber
            End Get
            Set(value As Int32)
                mNumber = value
            End Set
        End Property
        Property MinimumHeroesRequired As Int32
            Get
                Return mMinimumHeroesRequired
            End Get
            Set(value As Int32)
                mMinimumHeroesRequired = value
            End Set
        End Property
        Property MaximumHeroesRequired As Int32
            Get
                Return mMaximumHeroesRequired
            End Get
            Set(value As Int32)
                mMaximumHeroesRequired = value
            End Set
        End Property
        Property ExactHeroesRequired As Int32
            Get
                Return mExactHeroesRequired
            End Get
            Set(value As Int32)
                mExactHeroesRequired = value
            End Set
        End Property
        Property ActorName As String
            Get
                Return mActorName
            End Get
            Set(value As String)
                mActorName = value
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
        Property DisplayInfo As String
            Get
                Return mDisplayInfo
            End Get
            Set(value As String)
                mDisplayInfo = value
            End Set
        End Property
        Property DisplayGroup As String
            Get
                Return mDisplayGroup
            End Get
            Set(value As String)
                mDisplayGroup = value
            End Set
        End Property
        Property Location As Int32()
            Get
                Return mLocation
            End Get
            Set(value As Int32())
                mLocation = value
            End Set
        End Property
        Property ShoutRange As String
            Get
                Return mShoutRange
            End Get
            Set(value As String)
                mShoutRange = value
            End Set
        End Property
        Property ShoutChance As String
            Get
                Return mShoutChance
            End Get
            Set(value As String)
                mShoutChance = value
            End Set
        End Property
        Property WalkRange As String
            Get
                Return mWalkRange
            End Get
            Set(value As String)
                mWalkRange = value
            End Set
        End Property
        Property NotRequired As String
            Get
                Return mNotRequired
            End Get
            Set(value As String)
                mNotRequired = value
            End Set
        End Property
        Property NoGroundSnap As Int32
            Get
                Return mNoGroundSnap
            End Get
            Set(value As Int32)
                mNoGroundSnap = value
            End Set
        End Property
        Property Ally As String
            Get
                Return mAlly
            End Get
            Set(value As String)
                mAlly = value
            End Set
        End Property
        Property Gang As String
            Get
                Return mGang
            End Get
            Set(value As String)
                mGang = value
            End Set
        End Property
        Property ClassOverride As String
            Get
                Return mClassOverride
            End Get
            Set(value As String)
                mClassOverride = value
            End Set
        End Property
        Property NoUnroll As Int32
            Get
                Return mNoUnroll
            End Get
            Set(value As Int32)
                mNoUnroll = value
            End Set
        End Property
        Property SucceedOnDeath As Int32
            Get
                Return mSucceedOnDeath
            End Get
            Set(value As Int32)
                mSucceedOnDeath = value
            End Set
        End Property
        Property FailOnDeath As Int32
            Get
                Return mFailOnDeath
            End Get
            Set(value As Int32)
                mFailOnDeath = value
            End Set
        End Property
        Property CustomCritterIdx As Int32
            Get
                Return mCustomCritterIdx
            End Get
            Set(value As Int32)
                mCustomCritterIdx = value
            End Set
        End Property
        Property npcDefOverride As Int32
            Get
                Return mnpcDefOverride
            End Get
            Set(value As Int32)
                mnpcDefOverride = value
            End Set
        End Property
        Property Flags As COH_Enum_ActorFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_ActorFlags)
                mFlags = value
            End Set
        End Property
        Property Reward As COH_StoryReward()
            Get
                Return mReward
            End Get
            Set(value As COH_StoryReward())
                mReward = value
            End Set
        End Property
        Property ConColor As COH_Enum_ConColor
            Get
                Return mConColor
            End Get
            Set(value As COH_Enum_ConColor)
                mConColor = value
            End Set
        End Property
        Property RewardScaleOverridePct As Int32
            Get
                Return mRewardScaleOverridePct
            End Get
            Set(value As Int32)
                mRewardScaleOverridePct = value
            End Set
        End Property
        Property VisionPhases As String()
            Get
                Return mVisionPhases
            End Get
            Set(value As String())
                mVisionPhases = value
            End Set
        End Property
        Property DONTUSETHISJUSTINITIALIZE As Int32
            Get
                Return mDONTUSETHISJUSTINITIALIZE
            End Get
            Set(value As Int32)
                mDONTUSETHISJUSTINITIALIZE = value
            End Set
        End Property
        Property ExclusiveVisionPhase As String
            Get
                Return mExclusiveVisionPhase
            End Get
            Set(value As String)
                mExclusiveVisionPhase = value
            End Set
        End Property
        Property DONTUSETHISEITHERINITIALIZE As Int32
            Get
                Return mDONTUSETHISEITHERINITIALIZE
            End Get
            Set(value As Int32)
                mDONTUSETHISEITHERINITIALIZE = value
            End Set
        End Property
        Property Model As String
            Get
                Return mModel
            End Get
            Set(value As String)
                mModel = value
            End Set
        End Property
        Property VillainLevelMod As Int32
            Get
                Return mVillainLevelMod
            End Get
            Set(value As Int32)
                mVillainLevelMod = value
            End Set
        End Property
        Property Villain As String
            Get
                Return mVillain
            End Get
            Set(value As String)
                mVillain = value
            End Set
        End Property
        Property VillainGroup As String
            Get
                Return mVillainGroup
            End Get
            Set(value As String)
                mVillainGroup = value
            End Set
        End Property
        Property VillainType As String
            Get
                Return mVillainType
            End Get
            Set(value As String)
                mVillainType = value
            End Set
        End Property
        Property AI_Group As Int32
            Get
                Return mAI_Group
            End Get
            Set(value As Int32)
                mAI_Group = value
            End Set
        End Property
        Property AI_InActive As String
            Get
                Return mAI_InActive
            End Get
            Set(value As String)
                mAI_InActive = value
            End Set
        End Property
        Property AI_Active As String
            Get
                Return mAI_Active
            End Get
            Set(value As String)
                mAI_Active = value
            End Set
        End Property
        Property AI_Alerted As String
            Get
                Return mAI_Alerted
            End Get
            Set(value As String)
                mAI_Alerted = value
            End Set
        End Property
        Property AI_Completion As String
            Get
                Return mAI_Completion
            End Get
            Set(value As String)
                mAI_Completion = value
            End Set
        End Property
        Property Dialog_InActive As String
            Get
                Return mDialog_InActive
            End Get
            Set(value As String)
                mDialog_InActive = value
            End Set
        End Property
        Property Dialog_Active As String
            Get
                Return mDialog_Active
            End Get
            Set(value As String)
                mDialog_Active = value
            End Set
        End Property
        Property Dialog_Alerted As String
            Get
                Return mDialog_Alerted
            End Get
            Set(value As String)
                mDialog_Alerted = value
            End Set
        End Property
        Property Dialog_Completion As String
            Get
                Return mDialog_Completion
            End Get
            Set(value As String)
                mDialog_Completion = value
            End Set
        End Property
        Property Dialog_ThankHero As String
            Get
                Return mDialog_ThankHero
            End Get
            Set(value As String)
                mDialog_ThankHero = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mType As COH_Enum_ActorType
       Private mNumber As Int32
       Private mMinimumHeroesRequired As Int32
       Private mMaximumHeroesRequired As Int32
       Private mExactHeroesRequired As Int32
       Private mActorName As String
       Private mName As String
       Private mDisplayInfo As String
       Private mDisplayGroup As String
       Private mLocation As Int32()
       Private mShoutRange As String
       Private mShoutChance As String
       Private mWalkRange As String
       Private mNotRequired As String
       Private mNoGroundSnap As Int32
       Private mAlly As String
       Private mGang As String
       Private mClassOverride As String
       Private mNoUnroll As Int32
       Private mSucceedOnDeath As Int32
       Private mFailOnDeath As Int32
       Private mCustomCritterIdx As Int32
       Private mnpcDefOverride As Int32
       Private mFlags As COH_Enum_ActorFlags
       Private mReward As COH_StoryReward()
       Private mConColor As COH_Enum_ConColor
       Private mRewardScaleOverridePct As Int32
       Private mVisionPhases As String()
       Private mDONTUSETHISJUSTINITIALIZE As Int32
       Private mExclusiveVisionPhase As String
       Private mDONTUSETHISEITHERINITIALIZE As Int32
       Private mModel As String
       Private mVillainLevelMod As Int32
       Private mVillain As String
       Private mVillainGroup As String
       Private mVillainType As String
       Private mAI_Group As Int32
       Private mAI_InActive As String
       Private mAI_Active As String
       Private mAI_Alerted As String
       Private mAI_Completion As String
       Private mDialog_InActive As String
       Private mDialog_Active As String
       Private mDialog_Alerted As String
       Private mDialog_Completion As String
       Private mDialog_ThankHero As String
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
            mActorName = String.Empty
            mName = String.Empty
            mDisplayInfo = String.Empty
            mDisplayGroup = String.Empty
            mLocation = New Int32() {}
            mShoutRange = String.Empty
            mShoutChance = String.Empty
            mWalkRange = String.Empty
            mNotRequired = String.Empty
            mAlly = String.Empty
            mGang = String.Empty
            mClassOverride = String.Empty
            mReward = New COH_StoryReward() {}
            mVisionPhases = New String() {}
            mExclusiveVisionPhase = String.Empty
            mModel = String.Empty
            mVillain = String.Empty
            mVillainGroup = String.Empty
            mVillainType = String.Empty
            mAI_InActive = String.Empty
            mAI_Active = String.Empty
            mAI_Alerted = String.Empty
            mAI_Completion = String.Empty
            mDialog_InActive = String.Empty
            mDialog_Active = String.Empty
            mDialog_Alerted = String.Empty
            mDialog_Completion = String.Empty
            mDialog_ThankHero = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Actor
            Dim Result As COH_Actor = New COH_Actor
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mType = mType
                .mNumber = mNumber
                .mMinimumHeroesRequired = mMinimumHeroesRequired
                .mMaximumHeroesRequired = mMaximumHeroesRequired
                .mExactHeroesRequired = mExactHeroesRequired
                .mActorName = String.Copy(mActorName)
                .mName = String.Copy(mName)
                .mDisplayInfo = String.Copy(mDisplayInfo)
                .mDisplayGroup = String.Copy(mDisplayGroup)
                .mLocation = New Int32(mLocation.Count - 1) {} : mLocation.CopyTo(.mLocation, 0)
                .mShoutRange = String.Copy(mShoutRange)
                .mShoutChance = String.Copy(mShoutChance)
                .mWalkRange = String.Copy(mWalkRange)
                .mNotRequired = String.Copy(mNotRequired)
                .mNoGroundSnap = mNoGroundSnap
                .mAlly = String.Copy(mAlly)
                .mGang = String.Copy(mGang)
                .mClassOverride = String.Copy(mClassOverride)
                .mNoUnroll = mNoUnroll
                .mSucceedOnDeath = mSucceedOnDeath
                .mFailOnDeath = mFailOnDeath
                .mCustomCritterIdx = mCustomCritterIdx
                .mnpcDefOverride = mnpcDefOverride
                .mFlags = mFlags
                .mReward = New COH_StoryReward(mReward.Count - 1) {}
                For X = 0 To mReward.Count - 1
                    .mReward(X) = mReward(X).Clone
                Next
                .mConColor = mConColor
                .mRewardScaleOverridePct = mRewardScaleOverridePct
                .mVisionPhases = mVisionPhases.CloneTheStrings
                .mDONTUSETHISJUSTINITIALIZE = mDONTUSETHISJUSTINITIALIZE
                .mExclusiveVisionPhase = String.Copy(mExclusiveVisionPhase)
                .mDONTUSETHISEITHERINITIALIZE = mDONTUSETHISEITHERINITIALIZE
                .mModel = String.Copy(mModel)
                .mVillainLevelMod = mVillainLevelMod
                .mVillain = String.Copy(mVillain)
                .mVillainGroup = String.Copy(mVillainGroup)
                .mVillainType = String.Copy(mVillainType)
                .mAI_Group = mAI_Group
                .mAI_InActive = String.Copy(mAI_InActive)
                .mAI_Active = String.Copy(mAI_Active)
                .mAI_Alerted = String.Copy(mAI_Alerted)
                .mAI_Completion = String.Copy(mAI_Completion)
                .mDialog_InActive = String.Copy(mDialog_InActive)
                .mDialog_Active = String.Copy(mDialog_Active)
                .mDialog_Alerted = String.Copy(mDialog_Alerted)
                .mDialog_Completion = String.Copy(mDialog_Completion)
                .mDialog_ThankHero = String.Copy(mDialog_ThankHero)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mType)
            CurrentWriter.Write(mNumber)
            '!!REDUNDENT!!CurrentWriter.Write(mHeroesRequired)
            CurrentWriter.Write(mMinimumHeroesRequired)
            CurrentWriter.Write(mMaximumHeroesRequired)
            CurrentWriter.Write(mExactHeroesRequired)
            CurrentWriter.Write_CrypticS_String(mActorName)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mDisplayInfo)
            CurrentWriter.Write_CrypticS_String(mDisplayGroup)
            CurrentWriter.Write_CrypticS_IntegerArray(mLocation)
            CurrentWriter.Write_CrypticS_String(mShoutRange)
            CurrentWriter.Write_CrypticS_String(mShoutChance)
            CurrentWriter.Write_CrypticS_String(mWalkRange)
            CurrentWriter.Write_CrypticS_String(mNotRequired)
            CurrentWriter.Write(mNoGroundSnap)
            CurrentWriter.Write_CrypticS_String(mAlly)
            CurrentWriter.Write_CrypticS_String(mGang)
            CurrentWriter.Write_CrypticS_String(mClassOverride)
            CurrentWriter.Write(mNoUnroll)
            CurrentWriter.Write(mSucceedOnDeath)
            CurrentWriter.Write(mFailOnDeath)
            CurrentWriter.Write(mCustomCritterIdx)
            CurrentWriter.Write(mnpcDefOverride)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            If CurrentWriter.Write_CrypticS_StructArray(mReward) = False Then Return False
            CurrentWriter.Write(mConColor)
            CurrentWriter.Write(mRewardScaleOverridePct)
            CurrentWriter.Write_CrypticS_StringArray(mVisionPhases)
            CurrentWriter.Write(mDONTUSETHISJUSTINITIALIZE)
            CurrentWriter.Write_CrypticS_String(mExclusiveVisionPhase)
            CurrentWriter.Write(mDONTUSETHISEITHERINITIALIZE)
            CurrentWriter.Write_CrypticS_String(mModel)
            CurrentWriter.Write(mVillainLevelMod)
            CurrentWriter.Write_CrypticS_String(mVillain)
            CurrentWriter.Write_CrypticS_String(mVillainGroup)
            CurrentWriter.Write_CrypticS_String(mVillainType)
            CurrentWriter.Write(mAI_Group)
            CurrentWriter.Write_CrypticS_String(mAI_InActive)
            CurrentWriter.Write_CrypticS_String(mAI_Active)
            CurrentWriter.Write_CrypticS_String(mAI_Alerted)
            CurrentWriter.Write_CrypticS_String(mAI_Completion)
            CurrentWriter.Write_CrypticS_String(mDialog_InActive)
            CurrentWriter.Write_CrypticS_String(mDialog_Active)
            CurrentWriter.Write_CrypticS_String(mDialog_Alerted)
            CurrentWriter.Write_CrypticS_String(mDialog_Completion)
            CurrentWriter.Write_CrypticS_String(mDialog_ThankHero)
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mActorReward) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mType = CurrentReader.ReadInt32
            mNumber = CurrentReader.ReadInt32
            '!!REDUNDENT!!mHeroesRequired = CurrentReader.ReadInt32
            mMinimumHeroesRequired = CurrentReader.ReadInt32
            mMaximumHeroesRequired = CurrentReader.ReadInt32
            mExactHeroesRequired = CurrentReader.ReadInt32
            mActorName = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mDisplayInfo = CurrentReader.Read_CrypticS_String
            mDisplayGroup = CurrentReader.Read_CrypticS_String
            mLocation = CurrentReader.Read_CrypticS_IntegerArray()
            mShoutRange = CurrentReader.Read_CrypticS_String
            mShoutChance = CurrentReader.Read_CrypticS_String
            mWalkRange = CurrentReader.Read_CrypticS_String
            mNotRequired = CurrentReader.Read_CrypticS_String
            mNoGroundSnap = CurrentReader.ReadInt32
            mAlly = CurrentReader.Read_CrypticS_String
            mGang = CurrentReader.Read_CrypticS_String
            mClassOverride = CurrentReader.Read_CrypticS_String
            mNoUnroll = CurrentReader.ReadInt32
            mSucceedOnDeath = CurrentReader.ReadInt32
            mFailOnDeath = CurrentReader.ReadInt32
            mCustomCritterIdx = CurrentReader.ReadInt32
            mnpcDefOverride = CurrentReader.ReadInt32
            mFlags = CurrentReader.Read_CrypticS_Flags
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mReward) = False Then Return False
            mConColor = CurrentReader.ReadInt32
            mRewardScaleOverridePct = CurrentReader.ReadInt32
            mVisionPhases = CurrentReader.Read_CrypticS_StringArray()
            mDONTUSETHISJUSTINITIALIZE = CurrentReader.ReadInt32
            mExclusiveVisionPhase = CurrentReader.Read_CrypticS_String
            mDONTUSETHISEITHERINITIALIZE = CurrentReader.ReadInt32
            mModel = CurrentReader.Read_CrypticS_String
            mVillainLevelMod = CurrentReader.ReadInt32
            mVillain = CurrentReader.Read_CrypticS_String
            mVillainGroup = CurrentReader.Read_CrypticS_String
            mVillainType = CurrentReader.Read_CrypticS_String
            mAI_Group = CurrentReader.ReadInt32
            mAI_InActive = CurrentReader.Read_CrypticS_String
            mAI_Active = CurrentReader.Read_CrypticS_String
            mAI_Alerted = CurrentReader.Read_CrypticS_String
            mAI_Completion = CurrentReader.Read_CrypticS_String
            mDialog_InActive = CurrentReader.Read_CrypticS_String
            mDialog_Active = CurrentReader.Read_CrypticS_String
            mDialog_Alerted = CurrentReader.Read_CrypticS_String
            mDialog_Completion = CurrentReader.Read_CrypticS_String
            mDialog_ThankHero = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mActorReward) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
