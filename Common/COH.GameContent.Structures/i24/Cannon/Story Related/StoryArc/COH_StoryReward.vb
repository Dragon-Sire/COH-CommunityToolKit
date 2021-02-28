Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_StoryReward
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Reward"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Dialog As String
            Get
                Return mDialog
            End Get
            Set(value As String)
                mDialog = value
            End Set
        End Property
        Property SOLDialog As String
            Get
                Return mSOLDialog
            End Get
            Set(value As String)
                mSOLDialog = value
            End Set
        End Property
        Property Caption As String
            Get
                Return mCaption
            End Get
            Set(value As String)
                mCaption = value
            End Set
        End Property
        Property AddClue As String()
            Get
                Return mAddClue
            End Get
            Set(value As String())
                mAddClue = value
            End Set
        End Property
        Property RemoveClue As String()
            Get
                Return mRemoveClue
            End Get
            Set(value As String())
                mRemoveClue = value
            End Set
        End Property
        Property AddToken As String()
            Get
                Return mAddToken
            End Get
            Set(value As String())
                mAddToken = value
            End Set
        End Property
        Property AddTokenToAll As String()
            Get
                Return mAddTokenToAll
            End Get
            Set(value As String())
                mAddTokenToAll = value
            End Set
        End Property
        Property RemoveToken As String()
            Get
                Return mRemoveToken
            End Get
            Set(value As String())
                mRemoveToken = value
            End Set
        End Property
        Property RemoveTokenFromAll As String()
            Get
                Return mRemoveTokenFromAll
            End Get
            Set(value As String())
                mRemoveTokenFromAll = value
            End Set
        End Property
        Property PopHelp As String()
            Get
                Return mPopHelp
            End Get
            Set(value As String())
                mPopHelp = value
            End Set
        End Property
        Property AbandonContacts As String()
            Get
                Return mAbandonContacts
            End Get
            Set(value As String())
                mAbandonContacts = value
            End Set
        End Property
        Property PlaySound As String()
            Get
                Return mPlaySound
            End Get
            Set(value As String())
                mPlaySound = value
            End Set
        End Property
        Property PlaySoundChannel As COH_Enum_SoundChannel()
            Get
                Return mPlaySoundChannel
            End Get
            Set(value As COH_Enum_SoundChannel())
                mPlaySoundChannel = value
            End Set
        End Property
        Property PlaySoundVolumeLevel As Single()
            Get
                Return mPlaySoundVolumeLevel
            End Get
            Set(value As Single())
                mPlaySoundVolumeLevel = value
            End Set
        End Property
        Property FadeSoundChannel As Int32
            Get
                Return mFadeSoundChannel
            End Get
            Set(value As Int32)
                mFadeSoundChannel = value
            End Set
        End Property
        Property FadeSoundTime As Single
            Get
                Return mFadeSoundTime
            End Get
            Set(value As Single)
                mFadeSoundTime = value
            End Set
        End Property
        Property PlayFXOnPlayer As String
            Get
                Return mPlayFXOnPlayer
            End Get
            Set(value As String)
                mPlayFXOnPlayer = value
            End Set
        End Property
        Property ContactPoints As Int32
            Get
                Return mContactPoints
            End Get
            Set(value As Int32)
                mContactPoints = value
            End Set
        End Property
        Property CostumeSlot As Int32
            Get
                Return mCostumeSlot
            End Get
            Set(value As Int32)
                mCostumeSlot = value
            End Set
        End Property
        Property PrimaryReward As String()
            Get
                Return mPrimaryReward
            End Get
            Set(value As String())
                mPrimaryReward = value
            End Set
        End Property
        Property SecondaryReward As String()
            Get
                Return mSecondaryReward
            End Get
            Set(value As String())
                mSecondaryReward = value
            End Set
        End Property
        Property Chance As COH_StoryRewardSet()
            Get
                Return mChance
            End Get
            Set(value As COH_StoryRewardSet())
                mChance = value
            End Set
        End Property
        Property NewContactReward As Int32
            Get
                Return mNewContactReward
            End Get
            Set(value As Int32)
                mNewContactReward = value
            End Set
        End Property
        Property RandomFameString As String
            Get
                Return mRandomFameString
            End Get
            Set(value As String)
                mRandomFameString = value
            End Set
        End Property
        Property SouvenirClue As String()
            Get
                Return mSouvenirClue
            End Get
            Set(value As String())
                mSouvenirClue = value
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
        Property BonusTime As Int32
            Get
                Return mBonusTime
            End Get
            Set(value As Int32)
                mBonusTime = value
            End Set
        End Property
        Property FloatText As String
            Get
                Return mFloatText
            End Get
            Set(value As String)
                mFloatText = value
            End Set
        End Property
        Property ArchitectBadgeStat As String
            Get
                Return mArchitectBadgeStat
            End Get
            Set(value As String)
                mArchitectBadgeStat = value
            End Set
        End Property
        Property ArchitectBadgeStatTest As String
            Get
                Return mArchitectBadgeStatTest
            End Get
            Set(value As String)
                mArchitectBadgeStatTest = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mDialog As String
       Private mSOLDialog As String
       Private mCaption As String
       Private mAddClue As String()
       Private mRemoveClue As String()
       Private mAddToken As String()
       Private mAddTokenToAll As String()
       Private mRemoveToken As String()
       Private mRemoveTokenFromAll As String()
       Private mPopHelp As String()
       Private mAbandonContacts As String()
       Private mPlaySound As String()
       Private mPlaySoundChannel As COH_Enum_SoundChannel()
       Private mPlaySoundVolumeLevel As Single()
       Private mFadeSoundChannel As Int32
       Private mFadeSoundTime As Single
       Private mPlayFXOnPlayer As String
       Private mContactPoints As Int32
       Private mCostumeSlot As Int32
       Private mPrimaryReward As String()
       Private mSecondaryReward As String()
       Private mChance As COH_StoryRewardSet()
       Private mNewContactReward As Int32
       Private mRandomFameString As String
       Private mSouvenirClue As String()
       Private mBadgeStat As String
       Private mBonusTime As Int32
       Private mFloatText As String
       Private mArchitectBadgeStat As String
       Private mArchitectBadgeStatTest As String
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
            mDialog = String.Empty
            mSOLDialog = String.Empty
            mCaption = String.Empty
            mAddClue = New String() {}
            mRemoveClue = New String() {}
            mAddToken = New String() {}
            mAddTokenToAll = New String() {}
            mRemoveToken = New String() {}
            mRemoveTokenFromAll = New String() {}
            mPopHelp = New String() {}
            mAbandonContacts = New String() {}
            mPlaySound = New String() {}
            mPlaySoundChannel = New Int32() {}
            mPlaySoundVolumeLevel = New Single() {}
            mPlayFXOnPlayer = String.Empty
            mPrimaryReward = New String() {}
            mSecondaryReward = New String() {}
            mChance = New COH_StoryRewardSet() {}
            mRandomFameString = String.Empty
            mSouvenirClue = New String() {}
            mBadgeStat = String.Empty
            mFloatText = String.Empty
            mArchitectBadgeStat = String.Empty
            mArchitectBadgeStatTest = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_StoryReward
            Dim Result As COH_StoryReward = New COH_StoryReward
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDialog = String.Copy(mDialog)
                .mSOLDialog = String.Copy(mSOLDialog)
                .mCaption = String.Copy(mCaption)
                .mAddClue = mAddClue.CloneTheStrings
                .mRemoveClue = mRemoveClue.CloneTheStrings
                .mAddToken = mAddToken.CloneTheStrings
                .mAddTokenToAll = mAddTokenToAll.CloneTheStrings
                .mRemoveToken = mRemoveToken.CloneTheStrings
                .mRemoveTokenFromAll = mRemoveTokenFromAll.CloneTheStrings
                .mPopHelp = mPopHelp.CloneTheStrings
                .mAbandonContacts = mAbandonContacts.CloneTheStrings
                .mPlaySound = mPlaySound.CloneTheStrings
                .mPlaySoundChannel = New Int32(mPlaySoundChannel.Count - 1) {} : mPlaySoundChannel.CopyTo(.mPlaySoundChannel, 0)
                .mPlaySoundVolumeLevel = New Single(mPlaySoundVolumeLevel.Count - 1) {} : mPlaySoundVolumeLevel.CopyTo(.mPlaySoundVolumeLevel, 0)
                .mFadeSoundChannel = mFadeSoundChannel
                .mFadeSoundTime = mFadeSoundTime
                .mPlayFXOnPlayer = String.Copy(mPlayFXOnPlayer)
                .mContactPoints = mContactPoints
                .mCostumeSlot = mCostumeSlot
                .mPrimaryReward = mPrimaryReward.CloneTheStrings
                .mSecondaryReward = mSecondaryReward.CloneTheStrings
                .mChance = New COH_StoryRewardSet(mChance.Count - 1) {}
                For X = 0 To mChance.Count - 1
                    .mChance(X) = mChance(X).Clone
                Next
                .mNewContactReward = mNewContactReward
                .mRandomFameString = String.Copy(mRandomFameString)
                .mSouvenirClue = mSouvenirClue.CloneTheStrings
                .mBadgeStat = String.Copy(mBadgeStat)
                .mBonusTime = mBonusTime
                .mFloatText = String.Copy(mFloatText)
                .mArchitectBadgeStat = String.Copy(mArchitectBadgeStat)
                .mArchitectBadgeStatTest = String.Copy(mArchitectBadgeStatTest)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mDialog)
            CurrentWriter.Write_CrypticS_String(mSOLDialog)
            CurrentWriter.Write_CrypticS_String(mCaption)
            CurrentWriter.Write_CrypticS_StringArray(mAddClue)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mAddClues)
            CurrentWriter.Write_CrypticS_StringArray(mRemoveClue)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mRemoveClues)
            CurrentWriter.Write_CrypticS_StringArray(mAddToken)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mAddTokens)
            CurrentWriter.Write_CrypticS_StringArray(mAddTokenToAll)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mAddTokensToAll)
            CurrentWriter.Write_CrypticS_StringArray(mRemoveToken)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mRemoveTokens)
            CurrentWriter.Write_CrypticS_StringArray(mRemoveTokenFromAll)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mRemoveTokensFromAll)
            CurrentWriter.Write_CrypticS_StringArray(mPopHelp)
            CurrentWriter.Write_CrypticS_StringArray(mAbandonContacts)
            CurrentWriter.Write_CrypticS_StringArray(mPlaySound)
            CurrentWriter.Write_CrypticS_IntegerArray(mPlaySoundChannel)
            CurrentWriter.Write_CrypticS_SingleArray(mPlaySoundVolumeLevel)
            CurrentWriter.Write(mFadeSoundChannel)
            CurrentWriter.Write(mFadeSoundTime)
            CurrentWriter.Write_CrypticS_String(mPlayFXOnPlayer)
            CurrentWriter.Write(mContactPoints)
            CurrentWriter.Write(mCostumeSlot)
            CurrentWriter.Write_CrypticS_StringArray(mPrimaryReward)
            CurrentWriter.Write_CrypticS_StringArray(mSecondaryReward)
            If CurrentWriter.Write_CrypticS_StructArray(mChance) = False Then Return False
            CurrentWriter.Write(mNewContactReward)
            CurrentWriter.Write_CrypticS_String(mRandomFameString)
            CurrentWriter.Write_CrypticS_StringArray(mSouvenirClue)
            CurrentWriter.Write_CrypticS_String(mBadgeStat)
            CurrentWriter.Write(mBonusTime)
            CurrentWriter.Write_CrypticS_String(mFloatText)
            CurrentWriter.Write_CrypticS_String(mArchitectBadgeStat)
            CurrentWriter.Write_CrypticS_String(mArchitectBadgeStatTest)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDialog = CurrentReader.Read_CrypticS_String
            mSOLDialog = CurrentReader.Read_CrypticS_String
            mCaption = CurrentReader.Read_CrypticS_String
            mAddClue = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mAddClues = CurrentReader.Read_CrypticS_StringArray()
            mRemoveClue = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mRemoveClues = CurrentReader.Read_CrypticS_StringArray()
            mAddToken = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mAddTokens = CurrentReader.Read_CrypticS_StringArray()
            mAddTokenToAll = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mAddTokensToAll = CurrentReader.Read_CrypticS_StringArray()
            mRemoveToken = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mRemoveTokens = CurrentReader.Read_CrypticS_StringArray()
            mRemoveTokenFromAll = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mRemoveTokensFromAll = CurrentReader.Read_CrypticS_StringArray()
            mPopHelp = CurrentReader.Read_CrypticS_StringArray()
            mAbandonContacts = CurrentReader.Read_CrypticS_StringArray()
            mPlaySound = CurrentReader.Read_CrypticS_StringArray()
            mPlaySoundChannel = CurrentReader.Read_CrypticS_IntegerArray()
            mPlaySoundVolumeLevel = CurrentReader.Read_CrypticS_SingleArray()
            mFadeSoundChannel = CurrentReader.ReadInt32
            mFadeSoundTime = CurrentReader.ReadSingle
            mPlayFXOnPlayer = CurrentReader.Read_CrypticS_String
            mContactPoints = CurrentReader.ReadInt32
            mCostumeSlot = CurrentReader.ReadInt32
            mPrimaryReward = CurrentReader.Read_CrypticS_StringArray()
            mSecondaryReward = CurrentReader.Read_CrypticS_StringArray()

            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryRewardSet), mChance) = False Then Return False
            mNewContactReward = CurrentReader.ReadInt32
            mRandomFameString = CurrentReader.Read_CrypticS_String
            mSouvenirClue = CurrentReader.Read_CrypticS_StringArray()
            mBadgeStat = CurrentReader.Read_CrypticS_String
            mBonusTime = CurrentReader.ReadInt32
            mFloatText = CurrentReader.Read_CrypticS_String
            mArchitectBadgeStat = CurrentReader.Read_CrypticS_String
            mArchitectBadgeStatTest = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
