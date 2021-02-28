Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_StoryTask
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property TaskType As COH_Enum_TaskType
            Get
                Return mTaskType
            End Get
            Set(value As COH_Enum_TaskType)
                mTaskType = value
            End Set
        End Property
        Property TaskFlag As COH_Enum_TaskFlags
            Get
                Return mTaskFlag
            End Get
            Set(value As COH_Enum_TaskFlags)
                mTaskFlag = value
            End Set
        End Property
        Property CurrentFile As String
            Get
                Return mCurrentFile
            End Get
            Set(value As String)
                mCurrentFile = value
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
        Property Deprecated As Boolean
            Get
                Return mDeprecated
            End Get
            Set(value As Boolean)
                mDeprecated = value
            End Set
        End Property
        Property MissionDef As COH_Mission()
            Get
                Return mMissionDef
            End Get
            Set(value As COH_Mission())
                mMissionDef = value
            End Set
        End Property
        Property MissionEditor As String
            Get
                Return mMissionEditor
            End Get
            Set(value As String)
                mMissionEditor = value
            End Set
        End Property
        Property Spawn As String
            Get
                Return mSpawn
            End Get
            Set(value As String)
                mSpawn = value
            End Set
        End Property
        Property SpawnDef As COH_SpawnDef()
            Get
                Return mSpawnDef
            End Get
            Set(value As COH_SpawnDef())
                mSpawnDef = value
            End Set
        End Property
        Property ClueDef As COH_StoryClue()
            Get
                Return mClueDef
            End Get
            Set(value As COH_StoryClue())
                mClueDef = value
            End Set
        End Property
        Property VillainGroup As Int32
            Get
                Return mVillainGroup
            End Get
            Set(value As Int32)
                mVillainGroup = value
            End Set
        End Property
        Property VillainGroupType As Int32
            Get
                Return mVillainGroupType
            End Get
            Set(value As Int32)
                mVillainGroupType = value
            End Set
        End Property
        Property Dialog As COH_DialogDef()
            Get
                Return mDialog
            End Get
            Set(value As COH_DialogDef())
                mDialog = value
            End Set
        End Property
        Property MaxPlayers As Int32
            Get
                Return mMaxPlayers
            End Get
            Set(value As Int32)
                mMaxPlayers = value
            End Set
        End Property
        Property IntroString As String
            Get
                Return mIntroString
            End Get
            Set(value As String)
                mIntroString = value
            End Set
        End Property
        Property SOLIntroString As String
            Get
                Return mSOLIntroString
            End Get
            Set(value As String)
                mSOLIntroString = value
            End Set
        End Property
        Property HeadlineString As String
            Get
                Return mHeadlineString
            End Get
            Set(value As String)
                mHeadlineString = value
            End Set
        End Property
        Property AcceptString As String
            Get
                Return mAcceptString
            End Get
            Set(value As String)
                mAcceptString = value
            End Set
        End Property
        Property DeclineString As String
            Get
                Return mDeclineString
            End Get
            Set(value As String)
                mDeclineString = value
            End Set
        End Property
        Property SendoffString As String
            Get
                Return mSendoffString
            End Get
            Set(value As String)
                mSendoffString = value
            End Set
        End Property
        Property SOLSendoffString As String
            Get
                Return mSOLSendoffString
            End Get
            Set(value As String)
                mSOLSendoffString = value
            End Set
        End Property
        Property DeclineSendoffString As String
            Get
                Return mDeclineSendoffString
            End Get
            Set(value As String)
                mDeclineSendoffString = value
            End Set
        End Property
        Property SOLDeclineSendoffString As String
            Get
                Return mSOLDeclineSendoffString
            End Get
            Set(value As String)
                mSOLDeclineSendoffString = value
            End Set
        End Property
        Property YoureStillBusyString As String
            Get
                Return mYoureStillBusyString
            End Get
            Set(value As String)
                mYoureStillBusyString = value
            End Set
        End Property
        Property SOLYoureStillBusyString As String
            Get
                Return mSOLYoureStillBusyString
            End Get
            Set(value As String)
                mSOLYoureStillBusyString = value
            End Set
        End Property
        Property ActiveTaskString As String
            Get
                Return mActiveTaskString
            End Get
            Set(value As String)
                mActiveTaskString = value
            End Set
        End Property
        Property TaskCompleteDescription As String
            Get
                Return mTaskCompleteDescription
            End Get
            Set(value As String)
                mTaskCompleteDescription = value
            End Set
        End Property
        Property TaskFailedDescription As String
            Get
                Return mTaskFailedDescription
            End Get
            Set(value As String)
                mTaskFailedDescription = value
            End Set
        End Property
        Property TaskAbandonedString As String
            Get
                Return mTaskAbandonedString
            End Get
            Set(value As String)
                mTaskAbandonedString = value
            End Set
        End Property
        Property TaskTitle As String
            Get
                Return mTaskTitle
            End Get
            Set(value As String)
                mTaskTitle = value
            End Set
        End Property
        Property TaskSubTitle As String
            Get
                Return mTaskSubTitle
            End Get
            Set(value As String)
                mTaskSubTitle = value
            End Set
        End Property
        Property TaskIssueTitle As String
            Get
                Return mTaskIssueTitle
            End Get
            Set(value As String)
                mTaskIssueTitle = value
            End Set
        End Property
        Property FlashbackDescription As String
            Get
                Return mFlashbackDescription
            End Get
            Set(value As String)
                mFlashbackDescription = value
            End Set
        End Property
        Property Alliance As Int32
            Get
                Return mAlliance
            End Get
            Set(value As Int32)
                mAlliance = value
            End Set
        End Property
        Property CompleteRequires As String()
            Get
                Return mCompleteRequires
            End Get
            Set(value As String())
                mCompleteRequires = value
            End Set
        End Property
        Property FlashbackRequires As String()
            Get
                Return mFlashbackRequires
            End Get
            Set(value As String())
                mFlashbackRequires = value
            End Set
        End Property
        Property FlashbackRequiresFailedText As String
            Get
                Return mFlashbackRequiresFailedText
            End Get
            Set(value As String)
                mFlashbackRequiresFailedText = value
            End Set
        End Property
        Property FlashbackTeamRequires As String()
            Get
                Return mFlashbackTeamRequires
            End Get
            Set(value As String())
                mFlashbackTeamRequires = value
            End Set
        End Property
        Property FlashbackTeamRequiresFailedText As String
            Get
                Return mFlashbackTeamRequiresFailedText
            End Get
            Set(value As String)
                mFlashbackTeamRequiresFailedText = value
            End Set
        End Property
        Property Requires As String()
            Get
                Return mRequires
            End Get
            Set(value As String())
                mRequires = value
            End Set
        End Property
        Property RequiresFailedText As String
            Get
                Return mRequiresFailedText
            End Get
            Set(value As String)
                mRequiresFailedText = value
            End Set
        End Property
        Property TeamRequires As String()
            Get
                Return mTeamRequires
            End Get
            Set(value As String())
                mTeamRequires = value
            End Set
        End Property
        Property TeamRequiresFailedText As String
            Get
                Return mTeamRequiresFailedText
            End Get
            Set(value As String)
                mTeamRequiresFailedText = value
            End Set
        End Property
        Property AutoIssueRequires As String()
            Get
                Return mAutoIssueRequires
            End Get
            Set(value As String())
                mAutoIssueRequires = value
            End Set
        End Property
        Property MinPlayerLevel As Int32
            Get
                Return mMinPlayerLevel
            End Get
            Set(value As Int32)
                mMinPlayerLevel = value
            End Set
        End Property
        Property MaxPlayerLevel As Int32
            Get
                Return mMaxPlayerLevel
            End Get
            Set(value As Int32)
                mMaxPlayerLevel = value
            End Set
        End Property
        Property TimeoutMinutes As Int32
            Get
                Return mTimeoutMinutes
            End Get
            Set(value As Int32)
                mTimeoutMinutes = value
            End Set
        End Property
        Property ForceTaskLevel As Int32
            Get
                Return mForceTaskLevel
            End Get
            Set(value As Int32)
                mForceTaskLevel = value
            End Set
        End Property
        Property PvPType As Int32
            Get
                Return mPvPType
            End Get
            Set(value As Int32)
                mPvPType = value
            End Set
        End Property
        Property NewspaperType As Int32
            Get
                Return mNewspaperType
            End Get
            Set(value As Int32)
                mNewspaperType = value
            End Set
        End Property
        Property LocationName As String
            Get
                Return mLocationName
            End Get
            Set(value As String)
                mLocationName = value
            End Set
        End Property
        Property LocationMap As String
            Get
                Return mLocationMap
            End Get
            Set(value As String)
                mLocationMap = value
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
        Property VillainCount As Int32
            Get
                Return mVillainCount
            End Get
            Set(value As Int32)
                mVillainCount = value
            End Set
        End Property
        Property VillainMap As String
            Get
                Return mVillainMap
            End Get
            Set(value As String)
                mVillainMap = value
            End Set
        End Property
        Property VillainNeighborhood As String
            Get
                Return mVillainNeighborhood
            End Get
            Set(value As String)
                mVillainNeighborhood = value
            End Set
        End Property
        Property VillainVolumeName As String
            Get
                Return mVillainVolumeName
            End Get
            Set(value As String)
                mVillainVolumeName = value
            End Set
        End Property
        Property VillainDescription As String
            Get
                Return mVillainDescription
            End Get
            Set(value As String)
                mVillainDescription = value
            End Set
        End Property
        Property VillainSingularDescription As String
            Get
                Return mVillainSingularDescription
            End Get
            Set(value As String)
                mVillainSingularDescription = value
            End Set
        End Property
        Property VillainType2 As String
            Get
                Return mVillainType2
            End Get
            Set(value As String)
                mVillainType2 = value
            End Set
        End Property
        Property VillainCount2 As Int32
            Get
                Return mVillainCount2
            End Get
            Set(value As Int32)
                mVillainCount2 = value
            End Set
        End Property
        Property VillainMap2 As String
            Get
                Return mVillainMap2
            End Get
            Set(value As String)
                mVillainMap2 = value
            End Set
        End Property
        Property VillainNeighborhood2 As String
            Get
                Return mVillainNeighborhood2
            End Get
            Set(value As String)
                mVillainNeighborhood2 = value
            End Set
        End Property
        Property VillainVolumeName2 As String
            Get
                Return mVillainVolumeName2
            End Get
            Set(value As String)
                mVillainVolumeName2 = value
            End Set
        End Property
        Property VillainDescription2 As String
            Get
                Return mVillainDescription2
            End Get
            Set(value As String)
                mVillainDescription2 = value
            End Set
        End Property
        Property VillainSingularDescription2 As String
            Get
                Return mVillainSingularDescription2
            End Get
            Set(value As String)
                mVillainSingularDescription2 = value
            End Set
        End Property
        Property VisitLocationName As String()
            Get
                Return mVisitLocationName
            End Get
            Set(value As String())
                mVisitLocationName = value
            End Set
        End Property
        Property DeliveryTargetName As String()
            Get
                Return mDeliveryTargetName
            End Get
            Set(value As String())
                mDeliveryTargetName = value
            End Set
        End Property
        Property DeliveryDialog As String()
            Get
                Return mDeliveryDialog
            End Get
            Set(value As String())
                mDeliveryDialog = value
            End Set
        End Property
        Property DeliveryDialogStartPage As String()
            Get
                Return mDeliveryDialogStartPage
            End Get
            Set(value As String())
                mDeliveryDialogStartPage = value
            End Set
        End Property
        Property DeliveryMethod As COH_Enum_Deliverymethod()
            Get
                Return mDeliveryMethod
            End Get
            Set(value As COH_Enum_Deliverymethod())
                mDeliveryMethod = value
            End Set
        End Property
        Property InventionName As String
            Get
                Return mInventionName
            End Get
            Set(value As String)
                mInventionName = value
            End Set
        End Property
        Property TokenName As String
            Get
                Return mTokenName
            End Get
            Set(value As String)
                mTokenName = value
            End Set
        End Property
        Property TokenCount As Int32
            Get
                Return mTokenCount
            End Get
            Set(value As Int32)
                mTokenCount = value
            End Set
        End Property
        Property TokenProgressString As String
            Get
                Return mTokenProgressString
            End Get
            Set(value As String)
                mTokenProgressString = value
            End Set
        End Property
        Property TokenFlags As COH_Enum_TokenFlags
            Get
                Return mTokenFlags
            End Get
            Set(value As COH_Enum_TokenFlags)
                mTokenFlags = value
            End Set
        End Property
        Property ZowieType As String
            Get
                Return mZowieType
            End Get
            Set(value As String)
                mZowieType = value
            End Set
        End Property
        Property ZowiePoolSize As String
            Get
                Return mZowiePoolSize
            End Get
            Set(value As String)
                mZowiePoolSize = value
            End Set
        End Property
        Property ZowieDisplayName As String
            Get
                Return mZowieDisplayName
            End Get
            Set(value As String)
                mZowieDisplayName = value
            End Set
        End Property
        Property ZowieCount As Int32
            Get
                Return mZowieCount
            End Get
            Set(value As Int32)
                mZowieCount = value
            End Set
        End Property
        Property ZowieDescription As String
            Get
                Return mZowieDescription
            End Get
            Set(value As String)
                mZowieDescription = value
            End Set
        End Property
        Property ZowieSingularDescription As String
            Get
                Return mZowieSingularDescription
            End Get
            Set(value As String)
                mZowieSingularDescription = value
            End Set
        End Property
        Property ZowieMap As String
            Get
                Return mZowieMap
            End Get
            Set(value As String)
                mZowieMap = value
            End Set
        End Property
        Property InteractDelay As Int32
            Get
                Return mInteractDelay
            End Get
            Set(value As Int32)
                mInteractDelay = value
            End Set
        End Property
        Property InteractBeginString As String
            Get
                Return mInteractBeginString
            End Get
            Set(value As String)
                mInteractBeginString = value
            End Set
        End Property
        Property InteractCompleteString As String
            Get
                Return mInteractCompleteString
            End Get
            Set(value As String)
                mInteractCompleteString = value
            End Set
        End Property
        Property InteractInterruptedString As String
            Get
                Return mInteractInterruptedString
            End Get
            Set(value As String)
                mInteractInterruptedString = value
            End Set
        End Property
        Property InteractActionString As String
            Get
                Return mInteractActionString
            End Get
            Set(value As String)
                mInteractActionString = value
            End Set
        End Property
        Property VolumeMapName As String
            Get
                Return mVolumeMapName
            End Get
            Set(value As String)
                mVolumeMapName = value
            End Set
        End Property
        Property VolumeName As String
            Get
                Return mVolumeName
            End Get
            Set(value As String)
                mVolumeName = value
            End Set
        End Property
        Property VolumeDescription As String
            Get
                Return mVolumeDescription
            End Get
            Set(value As String)
                mVolumeDescription = value
            End Set
        End Property
        Property TaskDef As COH_StoryTask()
            Get
                Return mTaskDef
            End Get
            Set(value As COH_StoryTask())
                mTaskDef = value
            End Set
        End Property
        Property TaskBegin As COH_StoryReward()
            Get
                Return mTaskBegin
            End Get
            Set(value As COH_StoryReward())
                mTaskBegin = value
            End Set
        End Property
        Property TaskBeginFlashback As COH_StoryReward()
            Get
                Return mTaskBeginFlashback
            End Get
            Set(value As COH_StoryReward())
                mTaskBeginFlashback = value
            End Set
        End Property
        Property TaskBeginNoFlashback As COH_StoryReward()
            Get
                Return mTaskBeginNoFlashback
            End Get
            Set(value As COH_StoryReward())
                mTaskBeginNoFlashback = value
            End Set
        End Property
        Property TaskSuccess As COH_StoryReward()
            Get
                Return mTaskSuccess
            End Get
            Set(value As COH_StoryReward())
                mTaskSuccess = value
            End Set
        End Property
        Property TaskSuccessFlashback As COH_StoryReward()
            Get
                Return mTaskSuccessFlashback
            End Get
            Set(value As COH_StoryReward())
                mTaskSuccessFlashback = value
            End Set
        End Property
        Property TaskSuccessNoFlashback As COH_StoryReward()
            Get
                Return mTaskSuccessNoFlashback
            End Get
            Set(value As COH_StoryReward())
                mTaskSuccessNoFlashback = value
            End Set
        End Property
        Property TaskFailure As COH_StoryReward()
            Get
                Return mTaskFailure
            End Get
            Set(value As COH_StoryReward())
                mTaskFailure = value
            End Set
        End Property
        Property TaskAbandon As COH_StoryReward()
            Get
                Return mTaskAbandon
            End Get
            Set(value As COH_StoryReward())
                mTaskAbandon = value
            End Set
        End Property
        Property ReturnSuccess As COH_StoryReward()
            Get
                Return mReturnSuccess
            End Get
            Set(value As COH_StoryReward())
                mReturnSuccess = value
            End Set
        End Property
        Property ReturnSuccessFlashback As COH_StoryReward()
            Get
                Return mReturnSuccessFlashback
            End Get
            Set(value As COH_StoryReward())
                mReturnSuccessFlashback = value
            End Set
        End Property
        Property ReturnSuccessNoFlashback As COH_StoryReward()
            Get
                Return mReturnSuccessNoFlashback
            End Get
            Set(value As COH_StoryReward())
                mReturnSuccessNoFlashback = value
            End Set
        End Property
        Property ReturnFailure As COH_StoryReward()
            Get
                Return mReturnFailure
            End Get
            Set(value As COH_StoryReward())
                mReturnFailure = value
            End Set
        End Property
        Property Vars As COH_STD
            Get
                Return mVars
            End Get
            Set(value As COH_STD)
                mVars = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTaskType As COH_Enum_TaskType
       Private mTaskFlag As COH_Enum_TaskFlags
       Private mCurrentFile As String
       Private mName As String
       Private mDeprecated As Boolean
       Private mMissionDef As COH_Mission()
       Private mMissionEditor As String
       Private mSpawn As String
       Private mSpawnDef As COH_SpawnDef()
       Private mClueDef As COH_StoryClue()
       Private mVillainGroup As Int32
       Private mVillainGroupType As Int32
       Private mDialog As COH_DialogDef()
       Private mMaxPlayers As Int32
       Private mIntroString As String
       Private mSOLIntroString As String
       Private mHeadlineString As String
       Private mAcceptString As String
       Private mDeclineString As String
       Private mSendoffString As String
       Private mSOLSendoffString As String
       Private mDeclineSendoffString As String
       Private mSOLDeclineSendoffString As String
       Private mYoureStillBusyString As String
       Private mSOLYoureStillBusyString As String
       Private mActiveTaskString As String
       Private mTaskCompleteDescription As String
       Private mTaskFailedDescription As String
       Private mTaskAbandonedString As String
       Private mTaskTitle As String
       Private mTaskSubTitle As String
       Private mTaskIssueTitle As String
       Private mFlashbackDescription As String
       Private mAlliance As Int32
       Private mCompleteRequires As String()
       Private mFlashbackRequires As String()
       Private mFlashbackRequiresFailedText As String
       Private mFlashbackTeamRequires As String()
       Private mFlashbackTeamRequiresFailedText As String
       Private mRequires As String()
       Private mRequiresFailedText As String
       Private mTeamRequires As String()
       Private mTeamRequiresFailedText As String
       Private mAutoIssueRequires As String()
       Private mMinPlayerLevel As Int32
       Private mMaxPlayerLevel As Int32
       Private mTimeoutMinutes As Int32
       Private mForceTaskLevel As Int32
       Private mPvPType As Int32
       Private mNewspaperType As Int32
       Private mLocationName As String
       Private mLocationMap As String
       Private mVillainType As String
       Private mVillainCount As Int32
       Private mVillainMap As String
       Private mVillainNeighborhood As String
       Private mVillainVolumeName As String
       Private mVillainDescription As String
       Private mVillainSingularDescription As String
       Private mVillainType2 As String
       Private mVillainCount2 As Int32
       Private mVillainMap2 As String
       Private mVillainNeighborhood2 As String
       Private mVillainVolumeName2 As String
       Private mVillainDescription2 As String
       Private mVillainSingularDescription2 As String
       Private mVisitLocationName As String()
       Private mDeliveryTargetName As String()
       Private mDeliveryDialog As String()
       Private mDeliveryDialogStartPage As String()
       Private mDeliveryMethod As COH_Enum_Deliverymethod()
       Private mInventionName As String
       Private mTokenName As String
       Private mTokenCount As Int32
       Private mTokenProgressString As String
       Private mTokenFlags As COH_Enum_TokenFlags
       Private mZowieType As String
       Private mZowiePoolSize As String
       Private mZowieDisplayName As String
       Private mZowieCount As Int32
       Private mZowieDescription As String
       Private mZowieSingularDescription As String
       Private mZowieMap As String
       Private mInteractDelay As Int32
       Private mInteractBeginString As String
       Private mInteractCompleteString As String
       Private mInteractInterruptedString As String
       Private mInteractActionString As String
       Private mVolumeMapName As String
       Private mVolumeName As String
       Private mVolumeDescription As String
       Private mTaskDef As COH_StoryTask()
       Private mTaskBegin As COH_StoryReward()
       Private mTaskBeginFlashback As COH_StoryReward()
       Private mTaskBeginNoFlashback As COH_StoryReward()
       Private mTaskSuccess As COH_StoryReward()
       Private mTaskSuccessFlashback As COH_StoryReward()
       Private mTaskSuccessNoFlashback As COH_StoryReward()
       Private mTaskFailure As COH_StoryReward()
       Private mTaskAbandon As COH_StoryReward()
       Private mReturnSuccess As COH_StoryReward()
       Private mReturnSuccessFlashback As COH_StoryReward()
       Private mReturnSuccessNoFlashback As COH_StoryReward()
       Private mReturnFailure As COH_StoryReward()
       Private mVars As COH_STD
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
            mTaskFlag = 0
            mCurrentFile = String.Empty
            mName = String.Empty
            mMissionDef = New COH_Mission() {}
            mMissionEditor = String.Empty
            mSpawn = String.Empty
            mSpawnDef = New COH_SpawnDef() {}
            mClueDef = New COH_StoryClue() {}
            mVillainGroup = 0
            mDialog = New COH_DialogDef() {}
            mIntroString = String.Empty
            mSOLIntroString = String.Empty
            mHeadlineString = String.Empty
            mAcceptString = String.Empty
            mDeclineString = String.Empty
            mSendoffString = String.Empty
            mSOLSendoffString = String.Empty
            mDeclineSendoffString = String.Empty
            mSOLDeclineSendoffString = String.Empty
            mYoureStillBusyString = String.Empty
            mSOLYoureStillBusyString = String.Empty
            mActiveTaskString = String.Empty
            mTaskCompleteDescription = String.Empty
            mTaskFailedDescription = String.Empty
            mTaskAbandonedString = String.Empty
            mTaskTitle = String.Empty
            mTaskSubTitle = String.Empty
            mTaskIssueTitle = String.Empty
            mFlashbackDescription = String.Empty
            mCompleteRequires = New String() {}
            mFlashbackRequires = New String() {}
            mFlashbackRequiresFailedText = String.Empty
            mFlashbackTeamRequires = New String() {}
            mFlashbackTeamRequiresFailedText = String.Empty
            mRequires = New String() {}
            mRequiresFailedText = String.Empty
            mTeamRequires = New String() {}
            mTeamRequiresFailedText = String.Empty
            mAutoIssueRequires = New String() {}
            mLocationName = String.Empty
            mLocationMap = String.Empty
            mVillainType = String.Empty
            mVillainMap = String.Empty
            mVillainNeighborhood = String.Empty
            mVillainVolumeName = String.Empty
            mVillainDescription = String.Empty
            mVillainSingularDescription = String.Empty
            mVillainType2 = String.Empty
            mVillainMap2 = String.Empty
            mVillainNeighborhood2 = String.Empty
            mVillainVolumeName2 = String.Empty
            mVillainDescription2 = String.Empty
            mVillainSingularDescription2 = String.Empty
            mVisitLocationName = New String() {}
            mDeliveryTargetName = New String() {}
            mDeliveryDialog = New String() {}
            mDeliveryDialogStartPage = New String() {}
            mDeliveryMethod = New COH_Enum_Deliverymethod() {}
            mInventionName = String.Empty
            mTokenName = String.Empty
            mTokenProgressString = String.Empty
            mZowieType = String.Empty
            mZowiePoolSize = String.Empty
            mZowieDisplayName = String.Empty
            mZowieDescription = String.Empty
            mZowieSingularDescription = String.Empty
            mZowieMap = String.Empty
            mInteractBeginString = String.Empty
            mInteractCompleteString = String.Empty
            mInteractInterruptedString = String.Empty
            mInteractActionString = String.Empty
            mVolumeMapName = String.Empty
            mVolumeName = String.Empty
            mVolumeDescription = String.Empty
            mTaskDef = New COH_StoryTask() {}
            mTaskBegin = New COH_StoryReward() {}
            mTaskBeginFlashback = New COH_StoryReward() {}
            mTaskBeginNoFlashback = New COH_StoryReward() {}
            mTaskSuccess = New COH_StoryReward() {}
            mTaskSuccessFlashback = New COH_StoryReward() {}
            mTaskSuccessNoFlashback = New COH_StoryReward() {}
            mTaskFailure = New COH_StoryReward() {}
            mTaskAbandon = New COH_StoryReward() {}
            mReturnSuccess = New COH_StoryReward() {}
            mReturnSuccessFlashback = New COH_StoryReward() {}
            mReturnSuccessNoFlashback = New COH_StoryReward() {}
            mReturnFailure = New COH_StoryReward() {}
            mVars = New COH_STD
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_StoryTask
            Dim Result As COH_StoryTask = New COH_StoryTask
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTaskType = mTaskType
                .mTaskFlag = mTaskFlag
                .mCurrentFile = String.Copy(mCurrentFile)
                .mName = String.Copy(mName)
                .mDeprecated = mDeprecated
                .mDeprecated = mDeprecated
                .mMissionDef = New COH_Mission(mMissionDef.Count - 1) {}
                For X = 0 To mMissionDef.Count - 1
                    .mMissionDef(X) = mMissionDef(X).Clone
                Next
                .mMissionEditor = String.Copy(mMissionEditor)
                .mSpawn = String.Copy(mSpawn)
                .mSpawnDef = New COH_SpawnDef(mSpawnDef.Count - 1) {}
                For X = 0 To mSpawnDef.Count - 1
                    .mSpawnDef(X) = mSpawnDef(X).Clone
                Next
                .mClueDef = New COH_StoryClue(mClueDef.Count - 1) {}
                For X = 0 To mClueDef.Count - 1
                    .mClueDef(X) = mClueDef(X).Clone
                Next
                .mVillainGroup = mVillainGroup
                .mVillainGroupType = mVillainGroupType
                .mDialog = New COH_DialogDef(mDialog.Count - 1) {}
                For X = 0 To mDialog.Count - 1
                    .mDialog(X) = mDialog(X).Clone
                Next
                .mMaxPlayers = mMaxPlayers
                .mIntroString = String.Copy(mIntroString)
                .mSOLIntroString = String.Copy(mSOLIntroString)
                .mHeadlineString = String.Copy(mHeadlineString)
                .mAcceptString = String.Copy(mAcceptString)
                .mDeclineString = String.Copy(mDeclineString)
                .mSendoffString = String.Copy(mSendoffString)
                .mSOLSendoffString = String.Copy(mSOLSendoffString)
                .mDeclineSendoffString = String.Copy(mDeclineSendoffString)
                .mSOLDeclineSendoffString = String.Copy(mSOLDeclineSendoffString)
                .mYoureStillBusyString = String.Copy(mYoureStillBusyString)
                .mSOLYoureStillBusyString = String.Copy(mSOLYoureStillBusyString)
                .mActiveTaskString = String.Copy(mActiveTaskString)
                .mTaskCompleteDescription = String.Copy(mTaskCompleteDescription)
                .mTaskFailedDescription = String.Copy(mTaskFailedDescription)
                .mTaskAbandonedString = String.Copy(mTaskAbandonedString)
                .mTaskTitle = String.Copy(mTaskTitle)
                .mTaskSubTitle = String.Copy(mTaskSubTitle)
                .mTaskIssueTitle = String.Copy(mTaskIssueTitle)
                .mFlashbackDescription = String.Copy(mFlashbackDescription)
                .mAlliance = mAlliance
                .mCompleteRequires = mCompleteRequires.CloneTheStrings
                .mFlashbackRequires = mFlashbackRequires.CloneTheStrings
                .mFlashbackRequiresFailedText = String.Copy(mFlashbackRequiresFailedText)
                .mFlashbackTeamRequires = mFlashbackTeamRequires.CloneTheStrings
                .mFlashbackTeamRequiresFailedText = String.Copy(mFlashbackTeamRequiresFailedText)
                .mRequires = mRequires.CloneTheStrings
                .mRequiresFailedText = String.Copy(mRequiresFailedText)
                .mTeamRequires = mTeamRequires.CloneTheStrings
                .mTeamRequiresFailedText = String.Copy(mTeamRequiresFailedText)
                .mAutoIssueRequires = mAutoIssueRequires.CloneTheStrings
                .mMinPlayerLevel = mMinPlayerLevel
                .mMaxPlayerLevel = mMaxPlayerLevel
                .mTimeoutMinutes = mTimeoutMinutes
                .mForceTaskLevel = mForceTaskLevel
                .mPvPType = mPvPType
                .mNewspaperType = mNewspaperType
                .mLocationName = String.Copy(mLocationName)
                .mLocationMap = String.Copy(mLocationMap)
                .mVillainType = String.Copy(mVillainType)
                .mVillainCount = mVillainCount
                .mVillainMap = String.Copy(mVillainMap)
                .mVillainNeighborhood = String.Copy(mVillainNeighborhood)
                .mVillainVolumeName = String.Copy(mVillainVolumeName)
                .mVillainDescription = String.Copy(mVillainDescription)
                .mVillainSingularDescription = String.Copy(mVillainSingularDescription)
                .mVillainType2 = String.Copy(mVillainType2)
                .mVillainCount2 = mVillainCount2
                .mVillainMap2 = String.Copy(mVillainMap2)
                .mVillainNeighborhood2 = String.Copy(mVillainNeighborhood2)
                .mVillainVolumeName2 = String.Copy(mVillainVolumeName2)
                .mVillainDescription2 = String.Copy(mVillainDescription2)
                .mVillainSingularDescription2 = String.Copy(mVillainSingularDescription2)
                .mVisitLocationName = mVisitLocationName.CloneTheStrings
                .mDeliveryTargetName = mDeliveryTargetName.CloneTheStrings
                .mDeliveryDialog = mDeliveryDialog.CloneTheStrings
                .mDeliveryDialogStartPage = mDeliveryDialogStartPage.CloneTheStrings
                .mDeliveryMethod = mDeliveryMethod
                .mInventionName = String.Copy(mInventionName)
                .mTokenName = String.Copy(mTokenName)
                .mTokenCount = mTokenCount
                .mTokenProgressString = String.Copy(mTokenProgressString)
                .mTokenFlags = mTokenFlags
                .mZowieType = String.Copy(mZowieType)
                .mZowiePoolSize = String.Copy(mZowiePoolSize)
                .mZowieDisplayName = String.Copy(mZowieDisplayName)
                .mZowieCount = mZowieCount
                .mZowieDescription = String.Copy(mZowieDescription)
                .mZowieSingularDescription = String.Copy(mZowieSingularDescription)
                .mZowieMap = String.Copy(mZowieMap)
                .mInteractDelay = mInteractDelay
                .mInteractBeginString = String.Copy(mInteractBeginString)
                .mInteractCompleteString = String.Copy(mInteractCompleteString)
                .mInteractInterruptedString = String.Copy(mInteractInterruptedString)
                .mInteractActionString = String.Copy(mInteractActionString)
                .mVolumeMapName = String.Copy(mVolumeMapName)
                .mVolumeName = String.Copy(mVolumeName)
                .mVolumeDescription = String.Copy(mVolumeDescription)
                .mTaskDef = New COH_StoryTask(mTaskDef.Count - 1) {}
                For X = 0 To mTaskDef.Count - 1
                    .mTaskDef(X) = mTaskDef(X).Clone
                Next
                .mTaskBegin = New COH_StoryReward(mTaskBegin.Count - 1) {}
                For X = 0 To mTaskBegin.Count - 1
                    .mTaskBegin(X) = mTaskBegin(X).Clone
                Next
                .mTaskBeginFlashback = New COH_StoryReward(mTaskBeginFlashback.Count - 1) {}
                For X = 0 To mTaskBeginFlashback.Count - 1
                    .mTaskBeginFlashback(X) = mTaskBeginFlashback(X).Clone
                Next
                .mTaskBeginNoFlashback = New COH_StoryReward(mTaskBeginNoFlashback.Count - 1) {}
                For X = 0 To mTaskBeginNoFlashback.Count - 1
                    .mTaskBeginNoFlashback(X) = mTaskBeginNoFlashback(X).Clone
                Next
                .mTaskSuccess = New COH_StoryReward(mTaskSuccess.Count - 1) {}
                For X = 0 To mTaskSuccess.Count - 1
                    .mTaskSuccess(X) = mTaskSuccess(X).Clone
                Next
                .mTaskSuccessFlashback = New COH_StoryReward(mTaskSuccessFlashback.Count - 1) {}
                For X = 0 To mTaskSuccessFlashback.Count - 1
                    .mTaskSuccessFlashback(X) = mTaskSuccessFlashback(X).Clone
                Next
                .mTaskSuccessNoFlashback = New COH_StoryReward(mTaskSuccessNoFlashback.Count - 1) {}
                For X = 0 To mTaskSuccessNoFlashback.Count - 1
                    .mTaskSuccessNoFlashback(X) = mTaskSuccessNoFlashback(X).Clone
                Next
                .mTaskFailure = New COH_StoryReward(mTaskFailure.Count - 1) {}
                For X = 0 To mTaskFailure.Count - 1
                    .mTaskFailure(X) = mTaskFailure(X).Clone
                Next
                .mTaskAbandon = New COH_StoryReward(mTaskAbandon.Count - 1) {}
                For X = 0 To mTaskAbandon.Count - 1
                    .mTaskAbandon(X) = mTaskAbandon(X).Clone
                Next
                .mReturnSuccess = New COH_StoryReward(mReturnSuccess.Count - 1) {}
                For X = 0 To mReturnSuccess.Count - 1
                    .mReturnSuccess(X) = mReturnSuccess(X).Clone
                Next
                .mReturnSuccessFlashback = New COH_StoryReward(mReturnSuccessFlashback.Count - 1) {}
                For X = 0 To mReturnSuccessFlashback.Count - 1
                    .mReturnSuccessFlashback(X) = mReturnSuccessFlashback(X).Clone
                Next
                .mReturnSuccessNoFlashback = New COH_StoryReward(mReturnSuccessNoFlashback.Count - 1) {}
                For X = 0 To mReturnSuccessNoFlashback.Count - 1
                    .mReturnSuccessNoFlashback(X) = mReturnSuccessNoFlashback(X).Clone
                Next
                .mReturnFailure = New COH_StoryReward(mReturnFailure.Count - 1) {}
                For X = 0 To mReturnFailure.Count - 1
                    .mReturnFailure(X) = mReturnFailure(X).Clone
                Next
                .mVars = mVars.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mTaskType)
            CurrentWriter.Write(mTaskFlag)
            CurrentWriter.Write_CrypticS_String(mCurrentFile)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_Boolean(mDeprecated)
            If CurrentWriter.Write_CrypticS_StructArray(mMissionDef) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mMissionEditor)
            CurrentWriter.Write_CrypticS_String(mSpawn)
            If CurrentWriter.Write_CrypticS_StructArray(mSpawnDef) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mClueDef) = False Then Return False
            CurrentWriter.Write(CInt(mVillainGroup))
            CurrentWriter.Write(mVillainGroupType)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_Flags(mTaskFlags)
            If CurrentWriter.Write_CrypticS_StructArray(mDialog) = False Then Return False
            CurrentWriter.Write(mMaxPlayers)
            CurrentWriter.Write_CrypticS_String(mIntroString)
            CurrentWriter.Write_CrypticS_String(mSOLIntroString)
            CurrentWriter.Write_CrypticS_String(mHeadlineString)
            CurrentWriter.Write_CrypticS_String(mAcceptString)
            CurrentWriter.Write_CrypticS_String(mDeclineString)
            CurrentWriter.Write_CrypticS_String(mSendoffString)
            CurrentWriter.Write_CrypticS_String(mSOLSendoffString)
            CurrentWriter.Write_CrypticS_String(mDeclineSendoffString)
            CurrentWriter.Write_CrypticS_String(mSOLDeclineSendoffString)
            CurrentWriter.Write_CrypticS_String(mYoureStillBusyString)
            CurrentWriter.Write_CrypticS_String(mSOLYoureStillBusyString)
            CurrentWriter.Write_CrypticS_String(mActiveTaskString)
            CurrentWriter.Write_CrypticS_String(mTaskCompleteDescription)
            CurrentWriter.Write_CrypticS_String(mTaskFailedDescription)
            CurrentWriter.Write_CrypticS_String(mTaskAbandonedString)
            CurrentWriter.Write_CrypticS_String(mTaskTitle)
            CurrentWriter.Write_CrypticS_String(mTaskSubTitle)
            CurrentWriter.Write_CrypticS_String(mTaskIssueTitle)
            CurrentWriter.Write_CrypticS_String(mFlashbackDescription)
            CurrentWriter.Write(mAlliance)
            CurrentWriter.Write_CrypticS_StringArray(mCompleteRequires)
            CurrentWriter.Write_CrypticS_StringArray(mFlashbackRequires)
            CurrentWriter.Write_CrypticS_String(mFlashbackRequiresFailedText)
            CurrentWriter.Write_CrypticS_StringArray(mFlashbackTeamRequires)
            CurrentWriter.Write_CrypticS_String(mFlashbackTeamRequiresFailedText)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write_CrypticS_String(mRequiresFailedText)
            CurrentWriter.Write_CrypticS_StringArray(mTeamRequires)
            CurrentWriter.Write_CrypticS_String(mTeamRequiresFailedText)
            CurrentWriter.Write_CrypticS_StringArray(mAutoIssueRequires)
            CurrentWriter.Write(mMinPlayerLevel)
            CurrentWriter.Write(mMaxPlayerLevel)
            CurrentWriter.Write(mTimeoutMinutes)
            CurrentWriter.Write(mForceTaskLevel)
            CurrentWriter.Write(mPvPType)
            CurrentWriter.Write(mNewspaperType)
            CurrentWriter.Write_CrypticS_String(mLocationName)
            CurrentWriter.Write_CrypticS_String(mLocationMap)
            CurrentWriter.Write_CrypticS_String(mVillainType)
            CurrentWriter.Write(mVillainCount)
            CurrentWriter.Write_CrypticS_String(mVillainMap)
            CurrentWriter.Write_CrypticS_String(mVillainNeighborhood)
            CurrentWriter.Write_CrypticS_String(mVillainVolumeName)
            CurrentWriter.Write_CrypticS_String(mVillainDescription)
            CurrentWriter.Write_CrypticS_String(mVillainSingularDescription)
            CurrentWriter.Write_CrypticS_String(mVillainType2)
            CurrentWriter.Write(mVillainCount2)
            CurrentWriter.Write_CrypticS_String(mVillainMap2)
            CurrentWriter.Write_CrypticS_String(mVillainNeighborhood2)
            CurrentWriter.Write_CrypticS_String(mVillainVolumeName2)
            CurrentWriter.Write_CrypticS_String(mVillainDescription2)
            CurrentWriter.Write_CrypticS_String(mVillainSingularDescription2)
            CurrentWriter.Write_CrypticS_StringArray(mVisitLocationName)
            CurrentWriter.Write_CrypticS_StringArray(mDeliveryTargetName)
            CurrentWriter.Write_CrypticS_StringArray(mDeliveryDialog)
            CurrentWriter.Write_CrypticS_StringArray(mDeliveryDialogStartPage)
            CurrentWriter.Write_CrypticS_IntegerArray(mDeliveryMethod)
            CurrentWriter.Write_CrypticS_String(mInventionName)
            CurrentWriter.Write_CrypticS_String(mTokenName)
            CurrentWriter.Write(mTokenCount)
            CurrentWriter.Write_CrypticS_String(mTokenProgressString)
            CurrentWriter.Write_CrypticS_Flags(mTokenFlags)
            CurrentWriter.Write_CrypticS_String(mZowieType)
            CurrentWriter.Write_CrypticS_String(mZowiePoolSize)
            CurrentWriter.Write_CrypticS_String(mZowieDisplayName)
            CurrentWriter.Write(mZowieCount)
            CurrentWriter.Write_CrypticS_String(mZowieDescription)
            CurrentWriter.Write_CrypticS_String(mZowieSingularDescription)
            CurrentWriter.Write_CrypticS_String(mZowieMap)
            CurrentWriter.Write(mInteractDelay)
            CurrentWriter.Write_CrypticS_String(mInteractBeginString)
            CurrentWriter.Write_CrypticS_String(mInteractCompleteString)
            CurrentWriter.Write_CrypticS_String(mInteractInterruptedString)
            CurrentWriter.Write_CrypticS_String(mInteractActionString)
            CurrentWriter.Write_CrypticS_String(mVolumeMapName)
            CurrentWriter.Write_CrypticS_String(mVolumeName)
            CurrentWriter.Write_CrypticS_String(mVolumeDescription)
            If CurrentWriter.Write_CrypticS_StructArray(mTaskDef) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mTaskBegin) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mTaskBeginFlashback) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mTaskBeginNoFlashback) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mTaskSuccess) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mTaskSuccessFlashback) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mTaskSuccessNoFlashback) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mTaskFailure) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mTaskAbandon) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mReturnSuccess) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mReturnSuccessFlashback) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mReturnSuccessNoFlashback) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mReturnFailure) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mTaskComplete) = False Then Return False

            Throw New Exception("NEED TO WRITE VARS")

            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTaskType = CurrentReader.ReadInt32
            mTaskFlag = CurrentReader.Read_CrypticS_Flags
            mCurrentFile = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mDeprecated = CurrentReader.Read_CrypticS_Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Mission), mMissionDef) = False Then Return False
            mMissionEditor = CurrentReader.Read_CrypticS_String
            mSpawn = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_SpawnDef), mSpawnDef) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryClue), mClueDef) = False Then Return False
            mVillainGroup = CurrentReader.ReadInt32
            mVillainGroupType = CurrentReader.ReadInt32
            '!!REDUNDENT!!mTaskFlags = CurrentReader.Read_CrypticS_Flags
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_DialogDef), mDialog) = False Then Return False
            mMaxPlayers = CurrentReader.ReadInt32
            mIntroString = CurrentReader.Read_CrypticS_String
            mSOLIntroString = CurrentReader.Read_CrypticS_String
            mHeadlineString = CurrentReader.Read_CrypticS_String
            mAcceptString = CurrentReader.Read_CrypticS_String
            mDeclineString = CurrentReader.Read_CrypticS_String
            mSendoffString = CurrentReader.Read_CrypticS_String
            mSOLSendoffString = CurrentReader.Read_CrypticS_String
            mDeclineSendoffString = CurrentReader.Read_CrypticS_String
            mSOLDeclineSendoffString = CurrentReader.Read_CrypticS_String
            mYoureStillBusyString = CurrentReader.Read_CrypticS_String
            mSOLYoureStillBusyString = CurrentReader.Read_CrypticS_String
            mActiveTaskString = CurrentReader.Read_CrypticS_String
            mTaskCompleteDescription = CurrentReader.Read_CrypticS_String
            mTaskFailedDescription = CurrentReader.Read_CrypticS_String
            mTaskAbandonedString = CurrentReader.Read_CrypticS_String
            mTaskTitle = CurrentReader.Read_CrypticS_String
            mTaskSubTitle = CurrentReader.Read_CrypticS_String
            mTaskIssueTitle = CurrentReader.Read_CrypticS_String
            mFlashbackDescription = CurrentReader.Read_CrypticS_String
            mAlliance = CurrentReader.ReadInt32
            mCompleteRequires = CurrentReader.Read_CrypticS_StringArray()
            mFlashbackRequires = CurrentReader.Read_CrypticS_StringArray()
            mFlashbackRequiresFailedText = CurrentReader.Read_CrypticS_String
            mFlashbackTeamRequires = CurrentReader.Read_CrypticS_StringArray()
            mFlashbackTeamRequiresFailedText = CurrentReader.Read_CrypticS_String
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mRequiresFailedText = CurrentReader.Read_CrypticS_String
            mTeamRequires = CurrentReader.Read_CrypticS_StringArray()
            mTeamRequiresFailedText = CurrentReader.Read_CrypticS_String
            mAutoIssueRequires = CurrentReader.Read_CrypticS_StringArray()
            mMinPlayerLevel = CurrentReader.ReadInt32
            mMaxPlayerLevel = CurrentReader.ReadInt32
            mTimeoutMinutes = CurrentReader.ReadInt32
            mForceTaskLevel = CurrentReader.ReadInt32
            mPvPType = CurrentReader.ReadInt32
            mNewspaperType = CurrentReader.ReadInt32
            mLocationName = CurrentReader.Read_CrypticS_String
            mLocationMap = CurrentReader.Read_CrypticS_String
            mVillainType = CurrentReader.Read_CrypticS_String
            mVillainCount = CurrentReader.ReadInt32
            mVillainMap = CurrentReader.Read_CrypticS_String
            mVillainNeighborhood = CurrentReader.Read_CrypticS_String
            mVillainVolumeName = CurrentReader.Read_CrypticS_String
            mVillainDescription = CurrentReader.Read_CrypticS_String
            mVillainSingularDescription = CurrentReader.Read_CrypticS_String
            mVillainType2 = CurrentReader.Read_CrypticS_String
            mVillainCount2 = CurrentReader.ReadInt32
            mVillainMap2 = CurrentReader.Read_CrypticS_String
            mVillainNeighborhood2 = CurrentReader.Read_CrypticS_String
            mVillainVolumeName2 = CurrentReader.Read_CrypticS_String
            mVillainDescription2 = CurrentReader.Read_CrypticS_String
            mVillainSingularDescription2 = CurrentReader.Read_CrypticS_String
            mVisitLocationName = CurrentReader.Read_CrypticS_StringArray()
            mDeliveryTargetName = CurrentReader.Read_CrypticS_StringArray()
            mDeliveryDialog = CurrentReader.Read_CrypticS_StringArray()
            mDeliveryDialogStartPage = CurrentReader.Read_CrypticS_StringArray()
            mDeliveryMethod = CurrentReader.Read_CrypticS_IntegerArray
            mInventionName = CurrentReader.Read_CrypticS_String
            mTokenName = CurrentReader.Read_CrypticS_String
            mTokenCount = CurrentReader.ReadInt32
            mTokenProgressString = CurrentReader.Read_CrypticS_String
            mTokenFlags = CurrentReader.Read_CrypticS_Flags
            mZowieType = CurrentReader.Read_CrypticS_String
            mZowiePoolSize = CurrentReader.Read_CrypticS_String
            mZowieDisplayName = CurrentReader.Read_CrypticS_String
            mZowieCount = CurrentReader.ReadInt32
            mZowieDescription = CurrentReader.Read_CrypticS_String
            mZowieSingularDescription = CurrentReader.Read_CrypticS_String
            mZowieMap = CurrentReader.Read_CrypticS_String
            mInteractDelay = CurrentReader.ReadInt32
            mInteractBeginString = CurrentReader.Read_CrypticS_String
            mInteractCompleteString = CurrentReader.Read_CrypticS_String
            mInteractInterruptedString = CurrentReader.Read_CrypticS_String
            mInteractActionString = CurrentReader.Read_CrypticS_String
            mVolumeMapName = CurrentReader.Read_CrypticS_String
            mVolumeName = CurrentReader.Read_CrypticS_String
            mVolumeDescription = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryTask), mTaskDef) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mTaskBegin) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mTaskBeginFlashback) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mTaskBeginNoFlashback) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mTaskSuccess) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mTaskSuccessFlashback) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mTaskSuccessNoFlashback) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mTaskFailure) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mTaskAbandon) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mReturnSuccess) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mReturnSuccessFlashback) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mReturnSuccessNoFlashback) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mReturnFailure) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_StoryReward), mTaskComplete) = False Then Return False

            mVars = New COH_STD(CurrentReader)
            Return True
        End Function
#End Region

    End Class
End Namespace
