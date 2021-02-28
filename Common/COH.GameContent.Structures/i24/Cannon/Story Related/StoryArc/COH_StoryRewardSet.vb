Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_StoryRewardSet
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Filename
            End Get
        End Property
#End Region

#Region "Properties"
        Property Filename As String
            Get
                Return mFilename
            End Get
            Set(value As String)
                mFilename = value
            End Set
        End Property
        Property Chance As Single
            Get
                Return mChance
            End Get
            Set(value As Single)
                mChance = value
            End Set
        End Property
        Property Flags As COH_Enum_RewardsSetFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_RewardsSetFlags)
                mFlags = value
            End Set
        End Property
        Property DefaultOrigin As Boolean
            Get
                Return mDefaultOrigin
            End Get
            Set(value As Boolean)
                mDefaultOrigin = value
            End Set
        End Property
        Property Origin As String()
            Get
                Return mOrigin
            End Get
            Set(value As String())
                mOrigin = value
            End Set
        End Property
        Property DefaultArchetype As Boolean
            Get
                Return mDefaultArchetype
            End Get
            Set(value As Boolean)
                mDefaultArchetype = value
            End Set
        End Property
        Property Archetype As String()
            Get
                Return mArchetype
            End Get
            Set(value As String())
                mArchetype = value
            End Set
        End Property
        Property DefaultVillainGroup As Boolean
            Get
                Return mDefaultVillainGroup
            End Get
            Set(value As Boolean)
                mDefaultVillainGroup = value
            End Set
        End Property
        Property VillainGroupIndex As Int32()
            Get
                Return mVillainGroup
            End Get
            Set(value As Int32())
                mVillainGroup = value
            End Set
        End Property
        ReadOnly Property VillainGroup As COH_Enum_VillainGroup()
            Get
                '//Return mVillainGroup()
            End Get
        End Property
        Property Requires As String()
            Get
                Return mRequires
            End Get
            Set(value As String())
                mRequires = value
            End Set
        End Property
        Property Experience As Int32
            Get
                Return mExperience
            End Get
            Set(value As Int32)
                mExperience = value
            End Set
        End Property
        Property BonusExperience As Single
            Get
                Return mBonusExperience
            End Get
            Set(value As Single)
                mBonusExperience = value
            End Set
        End Property
        Property Wisdom As Int32
            Get
                Return mWisdom
            End Get
            Set(value As Int32)
                mWisdom = value
            End Set
        End Property
        Property Influence As Int32
            Get
                Return mInfluence
            End Get
            Set(value As Int32)
                mInfluence = value
            End Set
        End Property
        Property Prestige As Int32
            Get
                Return mPrestige
            End Get
            Set(value As Int32)
                mPrestige = value
            End Set
        End Property
        Property IncarnateSubtype As Int32
            Get
                Return mIncarnateSubtype
            End Get
            Set(value As Int32)
                mIncarnateSubtype = value
            End Set
        End Property
        Property IncarnateCount As Int32
            Get
                Return mIncarnateCount
            End Get
            Set(value As Int32)
                mIncarnateCount = value
            End Set
        End Property
        Property IgnoreRewardCaps As Boolean
            Get
                Return mIgnoreRewardCaps
            End Get
            Set(value As Boolean)
                mIgnoreRewardCaps = value
            End Set
        End Property
        Property LeagueOnly As Boolean
            Get
                Return mLeagueOnly
            End Get
            Set(value As Boolean)
                mLeagueOnly = value
            End Set
        End Property
        Property SuperDropGroup As COH_StoryReward_DropGroup()
            Get
                Return mSuperDropGroup
            End Get
            Set(value As COH_StoryReward_DropGroup())
                mSuperDropGroup = value
            End Set
        End Property
        Property DropGroup As COH_StoryReward_DropGroup()
            Get
                Return mDropGroup
            End Get
            Set(value As COH_StoryReward_DropGroup())
                mDropGroup = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mFilename As String
       Private mChance As Single
       Private mFlags As COH_Enum_RewardsSetFlags
       Private mDefaultOrigin As Boolean
       Private mOrigin As String()
       Private mDefaultArchetype As Boolean
       Private mArchetype As String()
       Private mDefaultVillainGroup As Boolean
       Private mVillainGroup As Int32()
       Private mRequires As String()
       Private mExperience As Int32
       Private mBonusExperience As Single
       Private mWisdom As Int32
       Private mInfluence As Int32
       Private mPrestige As Int32
       Private mIncarnateSubtype As Int32 '''///ENUMLIST COULD BE USED>>>IS A STATIC LOADED LIST
       Private mIncarnateCount As Int32
       Private mIgnoreRewardCaps As Boolean
       Private mLeagueOnly As Boolean
       Private mSuperDropGroup As COH_StoryReward_DropGroup()
       Private mDropGroup As COH_StoryReward_DropGroup()

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
            mFilename = String.Empty
            mFlags = COH_Enum_RewardsSetFlags.None
            mOrigin = New String() {}
            mArchetype = New String() {}
            mVillainGroup = New Int32() {}
            mRequires = New String() {}
            mIncarnateSubtype = 0
            mSuperDropGroup = New COH_StoryReward_DropGroup() {}
            mDropGroup = New COH_StoryReward_DropGroup() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_StoryRewardSet
            Dim Result As COH_StoryRewardSet = New COH_StoryRewardSet
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mFilename = String.Copy(mFilename)
                .mChance = mChance
                .mFlags = mFlags
                .mDefaultOrigin = mDefaultOrigin
                .mOrigin = mOrigin.CloneTheStrings
                .mDefaultArchetype = mDefaultArchetype
                .mArchetype = mArchetype.CloneTheStrings
                .mDefaultVillainGroup = mDefaultVillainGroup
                .mVillainGroup = New Int32(mVillainGroup.Count - 1) {} : mVillainGroup.CopyTo(.mVillainGroup, 0)
                .mRequires = mRequires.CloneTheStrings
                .mExperience = mExperience
                .mBonusExperience = mBonusExperience
                .mWisdom = mWisdom
                .mInfluence = mInfluence
                .mPrestige = mPrestige
                .mIncarnateSubtype = mIncarnateSubtype
                .mIncarnateCount = mIncarnateCount
                .mIgnoreRewardCaps = mIgnoreRewardCaps
                .mLeagueOnly = mLeagueOnly
                .mSuperDropGroup = New COH_StoryReward_DropGroup(mSuperDropGroup.Count - 1) {}
                For X = 0 To mSuperDropGroup.Count - 1
                    .mSuperDropGroup(X) = mSuperDropGroup(X).Clone
                Next
                .mDropGroup = New COH_StoryReward_DropGroup(mDropGroup.Count - 1) {}
                For X = 0 To mDropGroup.Count - 1
                    .mDropGroup(X) = mDropGroup(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mFilename)
            CurrentWriter.Write(mChance)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            CurrentWriter.Write_CrypticS_Boolean(mDefaultOrigin)
            CurrentWriter.Write_CrypticS_StringArray(mOrigin)
            CurrentWriter.Write_CrypticS_Boolean(mDefaultArchetype)
            CurrentWriter.Write_CrypticS_StringArray(mArchetype)
            CurrentWriter.Write_CrypticS_Boolean(mDefaultVillainGroup)
            CurrentWriter.Write_CrypticS_IntegerArray(mVillainGroup)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write(mExperience)
            CurrentWriter.Write(mBonusExperience)
            CurrentWriter.Write(mWisdom)
            CurrentWriter.Write(mInfluence)
            CurrentWriter.Write(mPrestige)
            CurrentWriter.Write(mIncarnateSubtype)
            CurrentWriter.Write(mIncarnateCount)
            CurrentWriter.Write_CrypticS_Boolean(mIgnoreRewardCaps)
            CurrentWriter.Write_CrypticS_Boolean(mLeagueOnly)
            If CurrentWriter.Write_CrypticS_StructArray(mSuperDropGroup) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mDropGroup) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mFilename = CurrentReader.Read_CrypticS_String
            mChance = CurrentReader.ReadSingle
            mFlags = CurrentReader.Read_CrypticS_Flags
            mDefaultOrigin = CurrentReader.Read_CrypticS_Boolean
            mOrigin = CurrentReader.Read_CrypticS_StringArray()
            mDefaultArchetype = CurrentReader.Read_CrypticS_Boolean
            mArchetype = CurrentReader.Read_CrypticS_StringArray()
            mDefaultVillainGroup = CurrentReader.Read_CrypticS_Boolean
            mVillainGroup = CurrentReader.Read_CrypticS_IntegerArray()
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mExperience = CurrentReader.ReadInt32
            mBonusExperience = CurrentReader.ReadSingle
            mWisdom = CurrentReader.ReadInt32
            mInfluence = CurrentReader.ReadInt32
            mPrestige = CurrentReader.ReadInt32
            mIncarnateSubtype = CurrentReader.ReadInt32
            mIncarnateCount = CurrentReader.ReadInt32
            mIgnoreRewardCaps = CurrentReader.Read_CrypticS_Boolean
            mLeagueOnly = CurrentReader.Read_CrypticS_Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward_DropGroup), mSuperDropGroup) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward_DropGroup), mDropGroup) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
