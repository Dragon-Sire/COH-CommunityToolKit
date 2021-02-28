Imports COH.GameContent.Structures.Powers

Namespace GameContent.Structures.Enemies
    Public Class COH_EnemyVillain
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("Display")> Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property [Class] As String
            Get
                Return mClass
            End Get
            Set(value As String)
                mClass = value
            End Set
        End Property
        Property Gender As COH_Enum_Genders
            Get
                Return mGender
            End Get
            Set(value As COH_Enum_Genders)
                mGender = value
            End Set
        End Property
        Property DisplayDescription As String
            Get
                Return mDisplayDescription
            End Get
            Set(value As String)
                mDisplayDescription = value
            End Set
        End Property
        Property GroupDescription As String
            Get
                Return mGroupDescription
            End Get
            Set(value As String)
                mGroupDescription = value
            End Set
        End Property
        Property DisplayClassName As String
            Get
                Return mDisplayClassName
            End Get
            Set(value As String)
                mDisplayClassName = value
            End Set
        End Property
        Property AIConfig As String
            Get
                Return mAIConfig
            End Get
            Set(value As String)
                mAIConfig = value
            End Set
        End Property
        ReadOnly Property VillainGroup As COH_Enum_VillainGroup
            Get
                Return mVillainGroupIndex
            End Get
        End Property
        Property VillainGroupIndex As Int32
            Get
                Return mVillainGroupIndex
            End Get
            Set(value As Int32)
                mVillainGroupIndex = value
            End Set
        End Property
        Property Power As COH_PowerName()
            Get
                Return mPower
            End Get
            Set(value As COH_PowerName())
                mPower = value
            End Set
        End Property
        Property Level As COH_EnemyVillain_Level()
            Get
                Return mLevel
            End Get
            Set(value As COH_EnemyVillain_Level())
                mLevel = value
            End Set
        End Property
        Property Rank As COH_Enum_VillainRank
            Get
                Return mRank
            End Get
            Set(value As COH_Enum_VillainRank)
                mRank = value
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
        Property Exclusion As Int32
            Get
                Return mExclusion
            End Get
            Set(value As Int32)
                mExclusion = value
            End Set
        End Property
        Property IgnoreCombatMods As Boolean
            Get
                Return mIgnoreCombatMods
            End Get
            Set(value As Boolean)
                mIgnoreCombatMods = value
            End Set
        End Property
        Property CopyCreatorMods As Boolean
            Get
                Return mCopyCreatorMods
            End Get
            Set(value As Boolean)
                mCopyCreatorMods = value
            End Set
        End Property
        Property IgnoreReduction As Boolean
            Get
                Return mIgnoreReduction
            End Get
            Set(value As Boolean)
                mIgnoreReduction = value
            End Set
        End Property
        Property CanZone As Boolean
            Get
                Return mCanZone
            End Get
            Set(value As Boolean)
                mCanZone = value
            End Set
        End Property
        Property SpawnLimit As Int32
            Get
                Return mSpawnLimit
            End Get
            Set(value As Int32)
                mSpawnLimit = value
            End Set
        End Property
        Property SpawnLimitMission As Int32
            Get
                Return mSpawnLimitMission
            End Get
            Set(value As Int32)
                mSpawnLimitMission = value
            End Set
        End Property
        Property SuccessRewards As String()
            Get
                Return mSuccessRewards
            End Get
            Set(value As String())
                mSuccessRewards = value
            End Set
        End Property
        Property FavoriteWeapon As String
            Get
                Return mFavoriteWeapon
            End Get
            Set(value As String)
                mFavoriteWeapon = value
            End Set
        End Property
        Property DeathFailureRewards As String()
            Get
                Return mDeathFailureRewards
            End Get
            Set(value As String())
                mDeathFailureRewards = value
            End Set
        End Property
        Property StatusFailureRewards As String()
            Get
                Return mStatusFailureRewards
            End Get
            Set(value As String())
                mStatusFailureRewards = value
            End Set
        End Property
        Property RewardScale As Single
            Get
                Return mRewardScale
            End Get
            Set(value As Single)
                mRewardScale = value
            End Set
        End Property
        Property PowerTags As String()
            Get
                Return mPowerTags
            End Get
            Set(value As String())
                mPowerTags = value
            End Set
        End Property
        Property SpecialPetPower As String
            Get
                Return mSpecialPetPower
            End Get
            Set(value As String)
                mSpecialPetPower = value
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
        Property FileName As String
            Get
                Return mFileName
            End Get
            Set(value As String)
                mFileName = value
            End Set
        End Property
        Property PetCommandStrings As COH_PetCommands()
            Get
                Return mPetCommandStrings
            End Get
            Set(value As COH_PetCommands())
                mPetCommandStrings = value
            End Set
        End Property
        Property PetVisibility As Int32
            Get
                Return mPetVisibility
            End Get
            Set(value As Int32)
                mPetVisibility = value
            End Set
        End Property
        Property PetCommandability As Int32
            Get
                Return mPetCommandability
            End Get
            Set(value As Int32)
                mPetCommandability = value
            End Set
        End Property
        Property BadgeStat As String
            Get
                Return mBadgeStat
            End Get
            Set(value As String)
                mBadgeStat = value
            End Set
        End Property
        Property Flags As COH_Enum_VillainBadgeFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_VillainBadgeFlags)
                mFlags = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mClass As String
       Private mGender As COH_Enum_Genders
       Private mDisplayDescription As String
       Private mGroupDescription As String
       Private mDisplayClassName As String
       Private mAIConfig As String
       Private mVillainGroupIndex As Integer
       Private mPower As COH_PowerName()
       Private mLevel As COH_EnemyVillain_Level()
       Private mRank As COH_Enum_VillainRank
       Private mAlly As String
       Private mGang As String
       Private mExclusion As Int32
       Private mIgnoreCombatMods As Boolean
       Private mCopyCreatorMods As Boolean
       Private mIgnoreReduction As Boolean
       Private mCanZone As Boolean
       Private mSpawnLimit As Int32
       Private mSpawnLimitMission As Int32
       Private mSuccessRewards As String()
       Private mFavoriteWeapon As String
       Private mDeathFailureRewards As String()
       Private mStatusFailureRewards As String()
       Private mRewardScale As Single
       Private mPowerTags As String()
       Private mSpecialPetPower As String
       Private mFileAge As Int32
       Private mFileName As String
       Private mPetCommandStrings As COH_PetCommands()
       Private mPetVisibility As Int32
       Private mPetCommandability As Int32
       Private mBadgeStat As String
       Private mFlags As COH_Enum_VillainBadgeFlags
        '//<EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mScriptDef As COH_None()
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
            mName = String.Empty
            mClass = String.Empty
            mGender = 0
            mDisplayDescription = String.Empty
            mGroupDescription = String.Empty
            mDisplayClassName = String.Empty
            mAIConfig = String.Empty
            mVillainGroupIndex = 0
            mPower = New COH_PowerName() {}
            mLevel = New COH_EnemyVillain_Level() {}
            mRank = 0
            mAlly = String.Empty
            mGang = String.Empty
            mExclusion = 0
            mIgnoreCombatMods = 0
            mCopyCreatorMods = 0
            mIgnoreReduction = 0
            mCanZone = 0
            mSpawnLimit = -1
            mSpawnLimitMission = -2
            mSuccessRewards = New String() {}
            mFavoriteWeapon = String.Empty
            mDeathFailureRewards = New String() {}
            mStatusFailureRewards = New String() {}
            mRewardScale = 1
            mPowerTags = New String() {}
            mSpecialPetPower = String.Empty
            mFileAge = 0
            mFileName = String.Empty
            mPetCommandStrings = New COH_PetCommands() {}
            mPetVisibility = -1
            mPetCommandability = 0
            mBadgeStat = String.Empty
            mFlags = 0
            '// mScriptDef = New COH_None()()
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_EnemyVillain
            Dim Result As COH_EnemyVillain = New COH_EnemyVillain
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mClass = String.Copy(mClass)
                .mGender = mGender
                .mDisplayDescription = String.Copy(mDisplayDescription)
                .mGroupDescription = String.Copy(mGroupDescription)
                .mDisplayClassName = String.Copy(mDisplayClassName)
                .mAIConfig = String.Copy(mAIConfig)
                .mVillainGroupIndex = mVillainGroupIndex
                .mPower = New COH_PowerName(mPower.Count - 1) {}
                For X = 0 To mPower.Count - 1
                    .mPower(X) = mPower(X).Clone
                Next
                .mLevel = New COH_EnemyVillain_Level(mLevel.Count - 1) {}
                For X = 0 To mLevel.Count - 1
                    .mLevel(X) = mLevel(X).Clone
                Next
                .mRank = mRank
                .mAlly = String.Copy(mAlly)
                .mGang = String.Copy(mGang)
                .mExclusion = mExclusion
                .mIgnoreCombatMods = mIgnoreCombatMods
                .mCopyCreatorMods = mCopyCreatorMods
                .mIgnoreReduction = mIgnoreReduction
                .mCanZone = mCanZone
                .mSpawnLimit = mSpawnLimit
                .mSpawnLimitMission = mSpawnLimitMission
                .mSuccessRewards = mSuccessRewards.CloneTheStrings
                .mFavoriteWeapon = String.Copy(mFavoriteWeapon)
                .mDeathFailureRewards = mDeathFailureRewards.CloneTheStrings
                .mStatusFailureRewards = mStatusFailureRewards.CloneTheStrings
                .mRewardScale = mRewardScale
                .mPowerTags = mPowerTags.CloneTheStrings
                .mSpecialPetPower = String.Copy(mSpecialPetPower)
                .mFileAge = mFileAge
                .mFileName = String.Copy(mFileName)
                .mPetCommandStrings = New COH_PetCommands(mPetCommandStrings.Count - 1) {}
                For X = 0 To mPetCommandStrings.Count - 1
                    .mPetCommandStrings(X) = mPetCommandStrings(X).Clone
                Next
                .mPetVisibility = mPetVisibility
                .mPetCommandability = mPetCommandability
                .mBadgeStat = String.Copy(mBadgeStat)
                .mFlags = mFlags
            End With
            Return Result
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mClass)
            CurrentWriter.Write(CInt(mGender))
            CurrentWriter.Write_CrypticS_String(mDisplayDescription)
            CurrentWriter.Write_CrypticS_String(mGroupDescription)
            CurrentWriter.Write_CrypticS_String(mDisplayClassName)
            CurrentWriter.Write_CrypticS_String(mAIConfig)
            CurrentWriter.Write(mVillainGroupIndex)
            If CurrentWriter.Write_CrypticS_StructArray(mPower) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mLevel) = False Then Return False
            CurrentWriter.Write(CInt(mRank))
            CurrentWriter.Write_CrypticS_String(mAlly)
            CurrentWriter.Write_CrypticS_String(mGang)
            CurrentWriter.Write(mExclusion)
            CurrentWriter.Write_CrypticS_Boolean(mIgnoreCombatMods)
            CurrentWriter.Write_CrypticS_Boolean(mCopyCreatorMods)
            CurrentWriter.Write_CrypticS_Boolean(mIgnoreReduction)
            CurrentWriter.Write_CrypticS_Boolean(mCanZone)
            CurrentWriter.Write(mSpawnLimit)
            CurrentWriter.Write(mSpawnLimitMission)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mAdditionalRewards)
            CurrentWriter.Write_CrypticS_StringArray(mSuccessRewards)
            CurrentWriter.Write_CrypticS_String(mFavoriteWeapon)
            CurrentWriter.Write_CrypticS_StringArray(mDeathFailureRewards)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mIntegrityFailureRewards)
            CurrentWriter.Write_CrypticS_StringArray(mStatusFailureRewards)
            CurrentWriter.Write(mRewardScale)
            CurrentWriter.Write_CrypticS_StringArray(mPowerTags)
            CurrentWriter.Write_CrypticS_String(mSpecialPetPower)
            CurrentWriter.Write_CrypticS_String(mFileName)
            CurrentWriter.Write_CrypticS_TimeStamp(mFileAge)
            If CurrentWriter.Write_CrypticS_StructArray(mPetCommandStrings) = False Then Return False
            CurrentWriter.Write(mPetVisibility)
            CurrentWriter.Write(mPetCommandability)
            CurrentWriter.Write_CrypticS_String(mBadgeStat)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mClass = CurrentReader.Read_CrypticS_String
            mGender = CurrentReader.ReadInt32
            mDisplayDescription = CurrentReader.Read_CrypticS_String
            mGroupDescription = CurrentReader.Read_CrypticS_String
            mDisplayClassName = CurrentReader.Read_CrypticS_String
            mAIConfig = CurrentReader.Read_CrypticS_String
            mVillainGroupIndex = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_PowerName), mPower) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_EnemyVillain_Level), mLevel) = False Then Return False
            mRank = CurrentReader.ReadInt32
            mAlly = CurrentReader.Read_CrypticS_String
            mGang = CurrentReader.Read_CrypticS_String
            mExclusion = CurrentReader.ReadInt32
            mIgnoreCombatMods = CurrentReader.Read_CrypticS_Boolean
            mCopyCreatorMods = CurrentReader.Read_CrypticS_Boolean
            mIgnoreReduction = CurrentReader.Read_CrypticS_Boolean
            mCanZone = CurrentReader.Read_CrypticS_Boolean
            mSpawnLimit = CurrentReader.ReadInt32
            mSpawnLimitMission = CurrentReader.ReadInt32
            '!!REDUNDENT!!mAdditionalRewards = CurrentReader.Read_CrypticS_StringArray()
            mSuccessRewards = CurrentReader.Read_CrypticS_StringArray()
            mFavoriteWeapon = CurrentReader.Read_CrypticS_String
            mDeathFailureRewards = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mIntegrityFailureRewards = CurrentReader.Read_CrypticS_StringArray()
            mStatusFailureRewards = CurrentReader.Read_CrypticS_StringArray()
            mRewardScale = CurrentReader.ReadSingle
            mPowerTags = CurrentReader.Read_CrypticS_StringArray()
            mSpecialPetPower = CurrentReader.Read_CrypticS_String
            mFileName = CurrentReader.Read_CrypticS_String
            mFileAge = CurrentReader.Read_CrypticS_TimeStamp
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_PetCommands), mPetCommandStrings) = False Then Return False
            mPetVisibility = CurrentReader.ReadInt32
            mPetCommandability = CurrentReader.ReadInt32
            mBadgeStat = CurrentReader.Read_CrypticS_String
            mFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace