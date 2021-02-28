Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_Mission_Objective
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
        Property GroupName As String
            Get
                Return mGroupName
            End Get
            Set(value As String)
                mGroupName = value
            End Set
        End Property
        Property Filename As String
            Get
                Return mFilename
            End Get
            Set(value As String)
                mFilename = value
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
        Property EffectInActive As String
            Get
                Return mEffectInActive
            End Get
            Set(value As String)
                mEffectInActive = value
            End Set
        End Property
        Property EffectRequires As String
            Get
                Return mEffectRequires
            End Get
            Set(value As String)
                mEffectRequires = value
            End Set
        End Property
        Property EffectActive As String
            Get
                Return mEffectActive
            End Get
            Set(value As String)
                mEffectActive = value
            End Set
        End Property
        Property EffectCooldown As String
            Get
                Return mEffectCooldown
            End Get
            Set(value As String)
                mEffectCooldown = value
            End Set
        End Property
        Property EffectCompletion As String
            Get
                Return mEffectCompletion
            End Get
            Set(value As String)
                mEffectCompletion = value
            End Set
        End Property
        Property EffectFailure As String
            Get
                Return mEffectFailure
            End Get
            Set(value As String)
                mEffectFailure = value
            End Set
        End Property
        Property Description As String
            Get
                Return mDescription
            End Get
            Set(value As String)
                mDescription = value
            End Set
        End Property
        Property SingularDescription As String
            Get
                Return mSingularDescription
            End Get
            Set(value As String)
                mSingularDescription = value
            End Set
        End Property
        Property DescRequires As String()
            Get
                Return mDescRequires
            End Get
            Set(value As String())
                mDescRequires = value
            End Set
        End Property
        Property ActivateOnObjectiveComplete As String()
            Get
                Return mActivateOnObjectiveComplete
            End Get
            Set(value As String())
                mActivateOnObjectiveComplete = value
            End Set
        End Property
        Property CharRequires As String()
            Get
                Return mCharRequires
            End Get
            Set(value As String())
                mCharRequires = value
            End Set
        End Property
        Property CharRequiresFailedText As String
            Get
                Return mCharRequiresFailedText
            End Get
            Set(value As String)
                mCharRequiresFailedText = value
            End Set
        End Property
        Property ModelDisplayName As String
            Get
                Return mModelDisplayName
            End Get
            Set(value As String)
                mModelDisplayName = value
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
        Property Reward As COH_StoryReward()
            Get
                Return mReward
            End Get
            Set(value As COH_StoryReward())
                mReward = value
            End Set
        End Property
        Property Level As Int32
            Get
                Return mLevel
            End Get
            Set(value As Int32)
                mLevel = value
            End Set
        End Property
        Property Flags As COH_Enum_ObjectiveFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_ObjectiveFlags)
                mFlags = value
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
        Property SimultaneousObjective As Boolean
            Get
                Return mSimultaneousObjective
            End Get
            Set(value As Boolean)
                mSimultaneousObjective = value
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
        Property InteractResetString As String
            Get
                Return mInteractResetString
            End Get
            Set(value As String)
                mInteractResetString = value
            End Set
        End Property
        Property InteractWaitingString As String
            Get
                Return mInteractWaitingString
            End Get
            Set(value As String)
                mInteractWaitingString = value
            End Set
        End Property
        Property InteractOutcome As COH_Enum_InteractOutcome
            Get
                Return mInteractOutcome
            End Get
            Set(value As COH_Enum_InteractOutcome)
                mInteractOutcome = value
            End Set
        End Property
        Property ForceFieldVillain As String
            Get
                Return mForceFieldVillain
            End Get
            Set(value As String)
                mForceFieldVillain = value
            End Set
        End Property
        Property ForceFieldRespawn As Int32
            Get
                Return mForceFieldRespawn
            End Get
            Set(value As Int32)
                mForceFieldRespawn = value
            End Set
        End Property
        Property ForceFieldObjective As String
            Get
                Return mForceFieldObjective
            End Get
            Set(value As String)
                mForceFieldObjective = value
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
        Property Location As COH_Enum_LocationType
            Get
                Return mLocation
            End Get
            Set(value As COH_Enum_LocationType)
                mLocation = value
            End Set
        End Property
        Property MissionPlacement As COH_Enum_MissionPlace
            Get
                Return mMissionPlacement
            End Get
            Set(value As COH_Enum_MissionPlace)
                mMissionPlacement = value
            End Set
        End Property
        Property SkillCheck As Boolean
            Get
                Return mSkillCheck
            End Get
            Set(value As Boolean)
                mSkillCheck = value
            End Set
        End Property
        Property ScriptControlled As Boolean
            Get
                Return mScriptControlled
            End Get
            Set(value As Boolean)
                mScriptControlled = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mGroupName As String
       Private mFilename As String
       Private mModel As String
       Private mEffectInActive As String
       Private mEffectRequires As String
       Private mEffectActive As String
       Private mEffectCooldown As String
       Private mEffectCompletion As String
       Private mEffectFailure As String
       Private mDescription As String
       Private mSingularDescription As String
       Private mDescRequires As String()
       Private mActivateOnObjectiveComplete As String()
       Private mCharRequires As String()
       Private mCharRequiresFailedText As String
       Private mModelDisplayName As String
       Private mNumber As Int32
       Private mReward As COH_StoryReward()
       Private mLevel As Int32
       Private mFlags As COH_Enum_ObjectiveFlags
       Private mInteractDelay As Int32
       Private mSimultaneousObjective As Boolean
       Private mInteractBeginString As String
       Private mInteractCompleteString As String
       Private mInteractInterruptedString As String
       Private mInteractActionString As String
       Private mInteractResetString As String
       Private mInteractWaitingString As String
       Private mInteractOutcome As COH_Enum_InteractOutcome
       Private mForceFieldVillain As String
       Private mForceFieldRespawn As Int32
       Private mForceFieldObjective As String
       Private mLocationName As String
       Private mLocation As COH_Enum_LocationType
       Private mMissionPlacement As COH_Enum_MissionPlace
       Private mSkillCheck As Boolean
       Private mScriptControlled As Boolean
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
            mName = String.Empty
            mGroupName = String.Empty
            mFilename = String.Empty
            mModel = String.Empty
            mEffectInActive = String.Empty
            mEffectRequires = String.Empty
            mEffectActive = String.Empty
            mEffectCooldown = String.Empty
            mEffectCompletion = String.Empty
            mEffectFailure = String.Empty
            mDescription = String.Empty
            mSingularDescription = String.Empty
            mDescRequires = New String() {}
            mActivateOnObjectiveComplete = New String() {}
            mCharRequires = New String() {}
            mCharRequiresFailedText = String.Empty
            mModelDisplayName = String.Empty
            mReward = New COH_StoryReward() {}
            mInteractBeginString = String.Empty
            mInteractCompleteString = String.Empty
            mInteractInterruptedString = String.Empty
            mInteractActionString = String.Empty
            mInteractResetString = String.Empty
            mInteractWaitingString = String.Empty
            mInteractOutcome = COH_Enum_InteractOutcome.MIO_NONE
            mForceFieldVillain = String.Empty
            mForceFieldObjective = String.Empty
            mLocationName = String.Empty
            mLocation = COH_Enum_LocationType.LOCATION_ITEMFLOOR
            mMissionPlacement = COH_Enum_MissionPlace.MISSION_OBJECTIVE
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Mission_Objective
            Dim Result As COH_Mission_Objective = New COH_Mission_Objective
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mGroupName = String.Copy(mGroupName)
                .mFilename = String.Copy(mFilename)
                .mModel = String.Copy(mModel)
                .mEffectInActive = String.Copy(mEffectInActive)
                .mEffectRequires = String.Copy(mEffectRequires)
                .mEffectActive = String.Copy(mEffectActive)
                .mEffectCooldown = String.Copy(mEffectCooldown)
                .mEffectCompletion = String.Copy(mEffectCompletion)
                .mEffectFailure = String.Copy(mEffectFailure)
                .mDescription = String.Copy(mDescription)
                .mSingularDescription = String.Copy(mSingularDescription)
                .mDescRequires = mDescRequires.CloneTheStrings
                .mActivateOnObjectiveComplete = mActivateOnObjectiveComplete.CloneTheStrings
                .mCharRequires = mCharRequires.CloneTheStrings
                .mCharRequiresFailedText = String.Copy(mCharRequiresFailedText)
                .mModelDisplayName = String.Copy(mModelDisplayName)
                .mNumber = mNumber
                .mReward = New COH_StoryReward(mReward.Count - 1) {}
                For X = 0 To mReward.Count - 1
                    .mReward(X) = mReward(X).Clone
                Next
                .mLevel = mLevel
                .mFlags = mFlags
                .mInteractDelay = mInteractDelay
                .mSimultaneousObjective = mSimultaneousObjective
                .mInteractBeginString = String.Copy(mInteractBeginString)
                .mInteractCompleteString = String.Copy(mInteractCompleteString)
                .mInteractInterruptedString = String.Copy(mInteractInterruptedString)
                .mInteractActionString = String.Copy(mInteractActionString)
                .mInteractResetString = String.Copy(mInteractResetString)
                .mInteractWaitingString = String.Copy(mInteractWaitingString)
                .mInteractOutcome = mInteractOutcome
                .mForceFieldVillain = String.Copy(mForceFieldVillain)
                .mForceFieldRespawn = mForceFieldRespawn
                .mForceFieldObjective = String.Copy(mForceFieldObjective)
                .mLocationName = String.Copy(mLocationName)
                .mLocation = mLocation
                .mMissionPlacement = mMissionPlacement
                .mSkillCheck = mSkillCheck
                .mScriptControlled = mScriptControlled
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mGroupName)
            CurrentWriter.Write_CrypticS_String(mFilename)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mObjectiveName)
            CurrentWriter.Write_CrypticS_String(mModel)
            CurrentWriter.Write_CrypticS_String(mEffectInActive)
            CurrentWriter.Write_CrypticS_String(mEffectRequires)
            CurrentWriter.Write_CrypticS_String(mEffectActive)
            CurrentWriter.Write_CrypticS_String(mEffectCooldown)
            CurrentWriter.Write_CrypticS_String(mEffectCompletion)
            CurrentWriter.Write_CrypticS_String(mEffectFailure)
            CurrentWriter.Write_CrypticS_String(mDescription)
            CurrentWriter.Write_CrypticS_String(mSingularDescription)
            CurrentWriter.Write_CrypticS_StringArray(mDescRequires)
            CurrentWriter.Write_CrypticS_StringArray(mActivateOnObjectiveComplete)
            CurrentWriter.Write_CrypticS_StringArray(mCharRequires)
            CurrentWriter.Write_CrypticS_String(mCharRequiresFailedText)
            CurrentWriter.Write_CrypticS_String(mModelDisplayName)
            CurrentWriter.Write(mNumber)
            If CurrentWriter.Write_CrypticS_StructArray(mReward) = False Then Return False
            CurrentWriter.Write(mLevel)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            CurrentWriter.Write(mInteractDelay)
            CurrentWriter.Write_CrypticS_Boolean(mSimultaneousObjective)
            CurrentWriter.Write_CrypticS_String(mInteractBeginString)
            CurrentWriter.Write_CrypticS_String(mInteractCompleteString)
            CurrentWriter.Write_CrypticS_String(mInteractInterruptedString)
            CurrentWriter.Write_CrypticS_String(mInteractActionString)
            CurrentWriter.Write_CrypticS_String(mInteractResetString)
            CurrentWriter.Write_CrypticS_String(mInteractWaitingString)
            CurrentWriter.Write(CInt(mInteractOutcome))
            CurrentWriter.Write_CrypticS_String(mForceFieldVillain)
            CurrentWriter.Write(mForceFieldRespawn)
            CurrentWriter.Write_CrypticS_String(mForceFieldObjective)
            CurrentWriter.Write_CrypticS_String(mLocationName)
            CurrentWriter.Write(CInt(mLocation))
            '!!REDUNDENT!!CurrentWriter.Write(Cint(mRoom)
            CurrentWriter.Write(CInt(mMissionPlacement))
            CurrentWriter.Write_CrypticS_Boolean(mSkillCheck)
            CurrentWriter.Write_CrypticS_Boolean(mScriptControlled)
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mObjectiveReward) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mGroupName = CurrentReader.Read_CrypticS_String
            mFilename = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mObjectiveName = CurrentReader.Read_CrypticS_String
            mModel = CurrentReader.Read_CrypticS_String
            mEffectInActive = CurrentReader.Read_CrypticS_String
            mEffectRequires = CurrentReader.Read_CrypticS_String
            mEffectActive = CurrentReader.Read_CrypticS_String
            mEffectCooldown = CurrentReader.Read_CrypticS_String
            mEffectCompletion = CurrentReader.Read_CrypticS_String
            mEffectFailure = CurrentReader.Read_CrypticS_String
            mDescription = CurrentReader.Read_CrypticS_String
            mSingularDescription = CurrentReader.Read_CrypticS_String
            mDescRequires = CurrentReader.Read_CrypticS_StringArray()
            mActivateOnObjectiveComplete = CurrentReader.Read_CrypticS_StringArray()
            mCharRequires = CurrentReader.Read_CrypticS_StringArray()
            mCharRequiresFailedText = CurrentReader.Read_CrypticS_String
            mModelDisplayName = CurrentReader.Read_CrypticS_String
            mNumber = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mReward) = False Then Return False
            mLevel = CurrentReader.ReadInt32
            mFlags = CurrentReader.Read_CrypticS_Flags
            mInteractDelay = CurrentReader.ReadInt32
            mSimultaneousObjective = CurrentReader.Read_CrypticS_Boolean
            mInteractBeginString = CurrentReader.Read_CrypticS_String
            mInteractCompleteString = CurrentReader.Read_CrypticS_String
            mInteractInterruptedString = CurrentReader.Read_CrypticS_String
            mInteractActionString = CurrentReader.Read_CrypticS_String
            mInteractResetString = CurrentReader.Read_CrypticS_String
            mInteractWaitingString = CurrentReader.Read_CrypticS_String
            mInteractOutcome = CurrentReader.ReadInt32
            mForceFieldVillain = CurrentReader.Read_CrypticS_String
            mForceFieldRespawn = CurrentReader.ReadInt32
            mForceFieldObjective = CurrentReader.Read_CrypticS_String
            mLocationName = CurrentReader.Read_CrypticS_String
            mLocation = CurrentReader.ReadInt32
            '!!REDUNDENT!!mRoom = CurrentReader.ReadInt32
            mMissionPlacement = CurrentReader.ReadInt32
            mSkillCheck = CurrentReader.Read_CrypticS_Boolean
            mScriptControlled = CurrentReader.Read_CrypticS_Boolean
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mObjectiveReward) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
