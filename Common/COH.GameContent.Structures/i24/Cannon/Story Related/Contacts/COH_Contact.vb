Namespace GameContent.Structures.Story
    Public Class COH_Contact
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Gender As COH_Enum_Genders
            Get
                Return mGender
            End Get
            Set(value As COH_Enum_Genders)
                mGender = value
            End Set
        End Property
        Property Status As COH_Enum_Status
            Get
                Return mStatus
            End Get
            Set(value As COH_Enum_Status)
                mStatus = value
            End Set
        End Property
        Property Alliance As COH_Enum_ContactAlliance
            Get
                Return mAlliance
            End Get
            Set(value As COH_Enum_ContactAlliance)
                mAlliance = value
            End Set
        End Property
        Property Universe As COH_Enum_ContactUniverse
            Get
                Return mUniverse
            End Get
            Set(value As COH_Enum_ContactUniverse)
                mUniverse = value
            End Set
        End Property
        Property TipType As String
            Get
                Return mTipType
            End Get
            Set(value As String)
                mTipType = value
            End Set
        End Property
        Property DescriptionString As String
            Get
                Return mDescriptionString
            End Get
            Set(value As String)
                mDescriptionString = value
            End Set
        End Property
        Property ProfessionString As String
            Get
                Return mProfessionString
            End Get
            Set(value As String)
                mProfessionString = value
            End Set
        End Property
        Property HelloString As String
            Get
                Return mHelloString
            End Get
            Set(value As String)
                mHelloString = value
            End Set
        End Property
        Property SOLHelloString As String
            Get
                Return mSOLHelloString
            End Get
            Set(value As String)
                mSOLHelloString = value
            End Set
        End Property
        Property IDontKnowYouString As String
            Get
                Return mIDontKnowYouString
            End Get
            Set(value As String)
                mIDontKnowYouString = value
            End Set
        End Property
        Property SOLIDontKnowYouString As String
            Get
                Return mSOLIDontKnowYouString
            End Get
            Set(value As String)
                mSOLIDontKnowYouString = value
            End Set
        End Property
        Property FirstVisitString As String
            Get
                Return mFirstVisitString
            End Get
            Set(value As String)
                mFirstVisitString = value
            End Set
        End Property
        Property SOLFirstVisitString As String
            Get
                Return mSOLFirstVisitString
            End Get
            Set(value As String)
                mSOLFirstVisitString = value
            End Set
        End Property
        Property NoTasksRemainingString As String
            Get
                Return mNoTasksRemainingString
            End Get
            Set(value As String)
                mNoTasksRemainingString = value
            End Set
        End Property
        Property SOLNoTasksRemainingString As String
            Get
                Return mSOLNoTasksRemainingString
            End Get
            Set(value As String)
                mSOLNoTasksRemainingString = value
            End Set
        End Property
        Property PlayerBusyString As String
            Get
                Return mPlayerBusyString
            End Get
            Set(value As String)
                mPlayerBusyString = value
            End Set
        End Property
        Property SOLPlayerBusyString As String
            Get
                Return mSOLPlayerBusyString
            End Get
            Set(value As String)
                mSOLPlayerBusyString = value
            End Set
        End Property
        Property ComeBackLaterString As String
            Get
                Return mComeBackLaterString
            End Get
            Set(value As String)
                mComeBackLaterString = value
            End Set
        End Property
        Property SOLComeBackLaterString As String
            Get
                Return mSOLComeBackLaterString
            End Get
            Set(value As String)
                mSOLComeBackLaterString = value
            End Set
        End Property
        Property ZeroContactPointsString As String
            Get
                Return mZeroContactPointsString
            End Get
            Set(value As String)
                mZeroContactPointsString = value
            End Set
        End Property
        Property SOLZeroContactPointsString As String
            Get
                Return mSOLZeroContactPointsString
            End Get
            Set(value As String)
                mSOLZeroContactPointsString = value
            End Set
        End Property
        Property NeverIssuedTaskString As String
            Get
                Return mNeverIssuedTaskString
            End Get
            Set(value As String)
                mNeverIssuedTaskString = value
            End Set
        End Property
        Property SOLNeverIssuedTaskString As String
            Get
                Return mSOLNeverIssuedTaskString
            End Get
            Set(value As String)
                mSOLNeverIssuedTaskString = value
            End Set
        End Property
        Property WrongAllianceString As String
            Get
                Return mWrongAllianceString
            End Get
            Set(value As String)
                mWrongAllianceString = value
            End Set
        End Property
        Property SOLWrongAllianceString As String
            Get
                Return mSOLWrongAllianceString
            End Get
            Set(value As String)
                mSOLWrongAllianceString = value
            End Set
        End Property
        Property WrongUniverseString As String
            Get
                Return mWrongUniverseString
            End Get
            Set(value As String)
                mWrongUniverseString = value
            End Set
        End Property
        Property SOLWrongUniverseString As String
            Get
                Return mSOLWrongUniverseString
            End Get
            Set(value As String)
                mSOLWrongUniverseString = value
            End Set
        End Property
        Property CallTextOverride As String
            Get
                Return mCallTextOverride
            End Get
            Set(value As String)
                mCallTextOverride = value
            End Set
        End Property
        Property AskAboutTextOverride As String
            Get
                Return mAskAboutTextOverride
            End Get
            Set(value As String)
                mAskAboutTextOverride = value
            End Set
        End Property
        Property LeaveTextOverride As String
            Get
                Return mLeaveTextOverride
            End Get
            Set(value As String)
                mLeaveTextOverride = value
            End Set
        End Property
        Property ImageOverride As String
            Get
                Return mImageOverride
            End Get
            Set(value As String)
                mImageOverride = value
            End Set
        End Property
        Property DismissOptionOverride As String
            Get
                Return mDismissOptionOverride
            End Get
            Set(value As String)
                mDismissOptionOverride = value
            End Set
        End Property
        Property DismissConfirmTextOverride As String
            Get
                Return mDismissConfirmTextOverride
            End Get
            Set(value As String)
                mDismissConfirmTextOverride = value
            End Set
        End Property
        Property DismissConfirmYesOverride As String
            Get
                Return mDismissConfirmYesOverride
            End Get
            Set(value As String)
                mDismissConfirmYesOverride = value
            End Set
        End Property
        Property DismissConfirmNoOverride As String
            Get
                Return mDismissConfirmNoOverride
            End Get
            Set(value As String)
                mDismissConfirmNoOverride = value
            End Set
        End Property
        Property DismissSuccessOverride As String
            Get
                Return mDismissSuccessOverride
            End Get
            Set(value As String)
                mDismissSuccessOverride = value
            End Set
        End Property
        Property DismissUnableOverride As String
            Get
                Return mDismissUnableOverride
            End Get
            Set(value As String)
                mDismissUnableOverride = value
            End Set
        End Property
        Property TaskDeclineOverride As String
            Get
                Return mTaskDeclineOverride
            End Get
            Set(value As String)
                mTaskDeclineOverride = value
            End Set
        End Property
        Property NoCellOverride As String
            Get
                Return mNoCellOverride
            End Get
            Set(value As String)
                mNoCellOverride = value
            End Set
        End Property
        Property MinutesTillExpire As Single
            Get
                Return mMinutesTillExpire
            End Get
            Set(value As Single)
                mMinutesTillExpire = value
            End Set
        End Property
        Property RelationshipChangeString_ToFriend As String
            Get
                Return mRelationshipChangeString_ToFriend
            End Get
            Set(value As String)
                mRelationshipChangeString_ToFriend = value
            End Set
        End Property
        Property RelationshipChangeString_ToConfidant As String
            Get
                Return mRelationshipChangeString_ToConfidant
            End Get
            Set(value As String)
                mRelationshipChangeString_ToConfidant = value
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
        Property IntroAcceptString As String
            Get
                Return mIntroAcceptString
            End Get
            Set(value As String)
                mIntroAcceptString = value
            End Set
        End Property
        Property IntroSendoffString As String
            Get
                Return mIntroSendoffString
            End Get
            Set(value As String)
                mIntroSendoffString = value
            End Set
        End Property
        Property SOLIntroSendoffString As String
            Get
                Return mSOLIntroSendoffString
            End Get
            Set(value As String)
                mSOLIntroSendoffString = value
            End Set
        End Property
        Property IntroduceOneContact As String
            Get
                Return mIntroduceOneContact
            End Get
            Set(value As String)
                mIntroduceOneContact = value
            End Set
        End Property
        Property IntroduceTwoContacts As String
            Get
                Return mIntroduceTwoContacts
            End Get
            Set(value As String)
                mIntroduceTwoContacts = value
            End Set
        End Property
        Property FailSafeLevelString As String
            Get
                Return mFailSafeLevelString
            End Get
            Set(value As String)
                mFailSafeLevelString = value
            End Set
        End Property
        Property SOLFailSafeLevelString As String
            Get
                Return mSOLFailSafeLevelString
            End Get
            Set(value As String)
                mSOLFailSafeLevelString = value
            End Set
        End Property
        Property LocationString As String
            Get
                Return mLocationString
            End Get
            Set(value As String)
                mLocationString = value
            End Set
        End Property
        Property SubContacts As String()
            Get
                Return mSubContacts
            End Get
            Set(value As String())
                mSubContacts = value
            End Set
        End Property
        Property SubContactsDisplay As String()
            Get
                Return mSubContactsDisplay
            End Get
            Set(value As String())
                mSubContactsDisplay = value
            End Set
        End Property
        Property InteractionRequires As String()
            Get
                Return mInteractionRequires
            End Get
            Set(value As String())
                mInteractionRequires = value
            End Set
        End Property
        Property InteractionRequiresText As String
            Get
                Return mInteractionRequiresText
            End Get
            Set(value As String)
                mInteractionRequiresText = value
            End Set
        End Property
        Property RequiredBadge As String
            Get
                Return mRequiredBadge
            End Get
            Set(value As String)
                mRequiredBadge = value
            End Set
        End Property
        Property BadgeNeededString As String
            Get
                Return mBadgeNeededString
            End Get
            Set(value As String)
                mBadgeNeededString = value
            End Set
        End Property
        Property SOLBadgeNeededString As String
            Get
                Return mSOLBadgeNeededString
            End Get
            Set(value As String)
                mSOLBadgeNeededString = value
            End Set
        End Property
        Property BadgeFirstTick As String
            Get
                Return mBadgeFirstTick
            End Get
            Set(value As String)
                mBadgeFirstTick = value
            End Set
        End Property
        Property BadgeSecondTick As String
            Get
                Return mBadgeSecondTick
            End Get
            Set(value As String)
                mBadgeSecondTick = value
            End Set
        End Property
        Property BadgeThirdTick As String
            Get
                Return mBadgeThirdTick
            End Get
            Set(value As String)
                mBadgeThirdTick = value
            End Set
        End Property
        Property BadgeFourthTick As String
            Get
                Return mBadgeFourthTick
            End Get
            Set(value As String)
                mBadgeFourthTick = value
            End Set
        End Property
        Property MapTokenRequired As String
            Get
                Return mMapTokenRequired
            End Get
            Set(value As String)
                mMapTokenRequired = value
            End Set
        End Property
        Property RequiredToken As String
            Get
                Return mRequiredToken
            End Get
            Set(value As String)
                mRequiredToken = value
            End Set
        End Property
        Property DontHaveToken As String
            Get
                Return mDontHaveToken
            End Get
            Set(value As String)
                mDontHaveToken = value
            End Set
        End Property
        Property SOLDontHaveToken As String
            Get
                Return mSOLDontHaveToken
            End Get
            Set(value As String)
                mSOLDontHaveToken = value
            End Set
        End Property
        Property PlayerLevelTooLow As String
            Get
                Return mPlayerLevelTooLow
            End Get
            Set(value As String)
                mPlayerLevelTooLow = value
            End Set
        End Property
        Property PlayerLevelTooHigh As String
            Get
                Return mPlayerLevelTooHigh
            End Get
            Set(value As String)
                mPlayerLevelTooHigh = value
            End Set
        End Property
        Property NeedLargeTeam As String
            Get
                Return mNeedLargeTeam
            End Get
            Set(value As String)
                mNeedLargeTeam = value
            End Set
        End Property
        Property NeedTeamLeader As String
            Get
                Return mNeedTeamLeader
            End Get
            Set(value As String)
                mNeedTeamLeader = value
            End Set
        End Property
        Property NeedTeamOnMap As String
            Get
                Return mNeedTeamOnMap
            End Get
            Set(value As String)
                mNeedTeamOnMap = value
            End Set
        End Property
        Property BadTeamLevel As String
            Get
                Return mBadTeamLevel
            End Get
            Set(value As String)
                mBadTeamLevel = value
            End Set
        End Property
        Property TaskForceInvite As String
            Get
                Return mTaskForceInvite
            End Get
            Set(value As String)
                mTaskForceInvite = value
            End Set
        End Property
        Property TaskForceRewardRequires As String()
            Get
                Return mTaskForceRewardRequires
            End Get
            Set(value As String())
                mTaskForceRewardRequires = value
            End Set
        End Property
        Property TaskForceRewardRequiresText As String
            Get
                Return mTaskForceRewardRequiresText
            End Get
            Set(value As String)
                mTaskForceRewardRequiresText = value
            End Set
        End Property
        Property TaskForceName As String
            Get
                Return mTaskForceName
            End Get
            Set(value As String)
                mTaskForceName = value
            End Set
        End Property
        Property TaskForceLevelAdjust As Int32
            Get
                Return mTaskForceLevelAdjust
            End Get
            Set(value As Int32)
                mTaskForceLevelAdjust = value
            End Set
        End Property
        Property StoreTitleString As String
            Get
                Return mStoreTitleString
            End Get
            Set(value As String)
                mStoreTitleString = value
            End Set
        End Property
        Property Icon As String
            Get
                Return mIcon
            End Get
            Set(value As String)
                mIcon = value
            End Set
        End Property
        Property StoreYouBoughtXXXString As String
            Get
                Return mStoreYouBoughtXXXString
            End Get
            Set(value As String)
                mStoreYouBoughtXXXString = value
            End Set
        End Property
        Property Stature As Int32
            Get
                Return mStature
            End Get
            Set(value As Int32)
                mStature = value
            End Set
        End Property
        Property StatureSet As String
            Get
                Return mStatureSet
            End Get
            Set(value As String)
                mStatureSet = value
            End Set
        End Property
        Property NextStatureSet As String
            Get
                Return mNextStatureSet
            End Get
            Set(value As String)
                mNextStatureSet = value
            End Set
        End Property
        Property NextStatureSet2 As String
            Get
                Return mNextStatureSet2
            End Get
            Set(value As String)
                mNextStatureSet2 = value
            End Set
        End Property
        Property ContactsAtOnce As Int32
            Get
                Return mContactsAtOnce
            End Get
            Set(value As Int32)
                mContactsAtOnce = value
            End Set
        End Property
        Property FriendCP As Int32
            Get
                Return mFriendCP
            End Get
            Set(value As Int32)
                mFriendCP = value
            End Set
        End Property
        Property ConfidantCP As Int32
            Get
                Return mConfidantCP
            End Get
            Set(value As Int32)
                mConfidantCP = value
            End Set
        End Property
        Property CompleteCP As Int32
            Get
                Return mCompleteCP
            End Get
            Set(value As Int32)
                mCompleteCP = value
            End Set
        End Property
        Property HeistCP As Int32
            Get
                Return mHeistCP
            End Get
            Set(value As Int32)
                mHeistCP = value
            End Set
        End Property
        Property CompletePlayerLevel As Int32
            Get
                Return mCompletePlayerLevel
            End Get
            Set(value As Int32)
                mCompletePlayerLevel = value
            End Set
        End Property
        Property FailsafePlayerLevel As Int32
            Get
                Return mFailsafePlayerLevel
            End Get
            Set(value As Int32)
                mFailsafePlayerLevel = value
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
        Property StoreCount As Int32
            Get
                Return mStoreCount
            End Get
            Set(value As Int32)
                mStoreCount = value
            End Set
        End Property
        Property Stores As String()
            Get
                Return mStores
            End Get
            Set(value As String())
                mStores = value
            End Set
        End Property
        Property AccessibleContact As Int32
            Get
                Return mAccessibleContact
            End Get
            Set(value As Int32)
                mAccessibleContact = value
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
        Property SupergroupContact As Boolean
            Get
                Return mSupergroupContact
            End Get
            Set(value As Boolean)
                mSupergroupContact = value
            End Set
        End Property
        Property CanTrain As Boolean
            Get
                Return mCanTrain
            End Get
            Set(value As Boolean)
                mCanTrain = value
            End Set
        End Property
        Property TutorialContact As Boolean
            Get
                Return mTutorialContact
            End Get
            Set(value As Boolean)
                mTutorialContact = value
            End Set
        End Property
        Property TeleportOnComplete As Boolean
            Get
                Return mTeleportOnComplete
            End Get
            Set(value As Boolean)
                mTeleportOnComplete = value
            End Set
        End Property
        Property AutoIssueContact As Boolean
            Get
                Return mAutoIssueContact
            End Get
            Set(value As Boolean)
                mAutoIssueContact = value
            End Set
        End Property
        Property AutoHideContact As Boolean
            Get
                Return mAutoHideContact
            End Get
            Set(value As Boolean)
                mAutoHideContact = value
            End Set
        End Property
        Property TaskForceContact As Boolean
            Get
                Return mTaskForceContact
            End Get
            Set(value As Boolean)
                mTaskForceContact = value
            End Set
        End Property
        Property NoFriendIntroduction As Boolean
            Get
                Return mNoFriendIntroduction
            End Get
            Set(value As Boolean)
                mNoFriendIntroduction = value
            End Set
        End Property
        Property MinTaskForceSize As Int32
            Get
                Return mMinTaskForceSize
            End Get
            Set(value As Int32)
                mMinTaskForceSize = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mCurrentFile As String
       Private mName As String
       Private mGender As COH_Enum_Genders
       Private mStatus As COH_Enum_Status
       Private mAlliance As COH_Enum_ContactAlliance
       Private mUniverse As COH_Enum_ContactUniverse
       Private mTipType As String
       Private mDescriptionString As String
       Private mProfessionString As String
       Private mHelloString As String
       Private mSOLHelloString As String
       Private mIDontKnowYouString As String
       Private mSOLIDontKnowYouString As String
       Private mFirstVisitString As String
       Private mSOLFirstVisitString As String
       Private mNoTasksRemainingString As String
       Private mSOLNoTasksRemainingString As String
       Private mPlayerBusyString As String
       Private mSOLPlayerBusyString As String
       Private mComeBackLaterString As String
       Private mSOLComeBackLaterString As String
       Private mZeroContactPointsString As String
       Private mSOLZeroContactPointsString As String
       Private mNeverIssuedTaskString As String
       Private mSOLNeverIssuedTaskString As String
       Private mWrongAllianceString As String
       Private mSOLWrongAllianceString As String
       Private mWrongUniverseString As String
       Private mSOLWrongUniverseString As String
       Private mCallTextOverride As String
       Private mAskAboutTextOverride As String
       Private mLeaveTextOverride As String
       Private mImageOverride As String
       Private mDismissOptionOverride As String
       Private mDismissConfirmTextOverride As String
       Private mDismissConfirmYesOverride As String
       Private mDismissConfirmNoOverride As String
       Private mDismissSuccessOverride As String
       Private mDismissUnableOverride As String
       Private mTaskDeclineOverride As String
       Private mNoCellOverride As String
       Private mMinutesTillExpire As Single
       Private mRelationshipChangeString_ToFriend As String
       Private mRelationshipChangeString_ToConfidant As String
       Private mIntroString As String
       Private mIntroAcceptString As String
       Private mIntroSendoffString As String
       Private mSOLIntroSendoffString As String
       Private mIntroduceOneContact As String
       Private mIntroduceTwoContacts As String
       Private mFailSafeLevelString As String
       Private mSOLFailSafeLevelString As String
       Private mLocationString As String
       Private mSubContacts As String()
       Private mSubContactsDisplay As String()
       Private mInteractionRequires As String()
       Private mInteractionRequiresText As String
       Private mRequiredBadge As String
       Private mBadgeNeededString As String
       Private mSOLBadgeNeededString As String
       Private mBadgeFirstTick As String
       Private mBadgeSecondTick As String
       Private mBadgeThirdTick As String
       Private mBadgeFourthTick As String
       Private mMapTokenRequired As String
       Private mRequiredToken As String
       Private mDontHaveToken As String
       Private mSOLDontHaveToken As String
       Private mPlayerLevelTooLow As String
       Private mPlayerLevelTooHigh As String
       Private mNeedLargeTeam As String
       Private mNeedTeamLeader As String
       Private mNeedTeamOnMap As String
       Private mBadTeamLevel As String
       Private mTaskForceInvite As String
       Private mTaskForceRewardRequires As String()
       Private mTaskForceRewardRequiresText As String
       Private mTaskForceName As String
       Private mTaskForceLevelAdjust As Int32
       Private mStoreTitleString As String
       Private mIcon As String
       Private mStoreYouBoughtXXXString As String
        '<EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mTaskDef As COH_None()
        '<EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mTaskInclude As COH_None()
       Private mAutoIndex As Int32
        '<EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mStoryArc As COH_None()
        'Private mDialog As COH_None()
       Private mStature As Int32
       Private mStatureSet As String
       Private mNextStatureSet As String
       Private mNextStatureSet2 As String
       Private mContactsAtOnce As Int32
       Private mFriendCP As Int32
       Private mConfidantCP As Int32
       Private mCompleteCP As Int32
       Private mHeistCP As Int32
       Private mCompletePlayerLevel As Int32
       Private mFailsafePlayerLevel As Int32
       Private mMinPlayerLevel As Int32
       Private mMaxPlayerLevel As Int32
       Private mStoreCount As Int32
       Private mStores As String()
       Private mAccessibleContact As Int32
        '<EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mKnownVillainGroups As COH_Enum_ParseVillainGroup()
        '<EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mDismissReward As COH_None()
       Private mDeprecated As Boolean
       Private mSupergroupContact As Boolean
       Private mCanTrain As Boolean
       Private mTutorialContact As Boolean
       Private mTeleportOnComplete As Boolean
       Private mAutoIssueContact As Boolean
       Private mAutoHideContact As Boolean
       Private mTaskForceContact As Boolean
       Private mNoFriendIntroduction As Boolean
       Private mMinTaskForceSize As Int32
        '{ "Flags",						TOK_FLAGARRAY(ContactDef,flags,CONTACT_DEF_FLAGS_SIZE),	ParseContactFlag },
        '
        '{ "}",							TOK_END,			0},
        'SCRIPTVARS_STD_PARSE(ContactDef)

#End Region

#Region "Create New Instances"
        Public Sub New()
            ResetDefaults()
        End Sub
        Public Sub New(Name As String)
            ResetDefaults()
            mName = Name
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Contact
            Dim Result As COH_Contact = New COH_Contact
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                Return Result
            End With
        End Function

        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Throw New NotImplementedException()
        End Function

      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
#End Region

    End Class
End Namespace