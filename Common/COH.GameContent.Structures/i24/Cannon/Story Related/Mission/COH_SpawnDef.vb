Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_SpawnDef
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return CurrentFile
            End Get
        End Property
#End Region

#Region "Properties"
        Property CurrentFile As String
            Get
                Return mCurrentFile
            End Get
            Set(value As String)
                mCurrentFile = value
            End Set
        End Property
        Property LogicalName As String
            Get
                Return mLogicalName
            End Get
            Set(value As String)
                mLogicalName = value
            End Set
        End Property
        Property EncounterSpawn As String
            Get
                Return mEncounterSpawn
            End Get
            Set(value As String)
                mEncounterSpawn = value
            End Set
        End Property
        Property Dialog As String
            Get
                Return mDialog
            End Get
            Set(value As String)
                mDialog = value
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
        Property SpawnRadius As Int32
            Get
                Return mSpawnRadius
            End Get
            Set(value As Int32)
                mSpawnRadius = value
            End Set
        End Property
        Property VillainMinLevel As Int32
            Get
                Return mVillainMinLevel
            End Get
            Set(value As Int32)
                mVillainMinLevel = value
            End Set
        End Property
        Property VillainMaxLevel As Int32
            Get
                Return mVillainMaxLevel
            End Get
            Set(value As Int32)
                mVillainMaxLevel = value
            End Set
        End Property
        Property MinTeamSize As Int32
            Get
                Return mMinTeamSize
            End Get
            Set(value As Int32)
                mMinTeamSize = value
            End Set
        End Property
        Property MaxTeamSize As Int32
            Get
                Return mMaxTeamSize
            End Get
            Set(value As Int32)
                mMaxTeamSize = value
            End Set
        End Property
        Property RespawnTimer As Int32
            Get
                Return mRespawnTimer
            End Get
            Set(value As Int32)
                mRespawnTimer = value
            End Set
        End Property
        Property Flags As COH_Enum_SpawnFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_SpawnFlags)
                mFlags = value
            End Set
        End Property
        Property Actor As COH_Actor()
            Get
                Return mActor
            End Get
            Set(value As COH_Actor())
                mActor = value
            End Set
        End Property
        Property Script As COH_ScriptDef()
            Get
                Return mScript
            End Get
            Set(value As COH_ScriptDef())
                mScript = value
            End Set
        End Property
        Property DialogDef As COH_DialogDef()
            Get
                Return mDialogDef
            End Get
            Set(value As COH_DialogDef())
                mDialogDef = value
            End Set
        End Property
        Property EncounterComplete As COH_StoryReward()
            Get
                Return mEncounterComplete
            End Get
            Set(value As COH_StoryReward())
                mEncounterComplete = value
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
        Property MissionCount As Int32
            Get
                Return mMissionCount
            End Get
            Set(value As Int32)
                mMissionCount = value
            End Set
        End Property
        Property MissionUncounted As Boolean
            Get
                Return mMissionUncounted
            End Get
            Set(value As Boolean)
                mMissionUncounted = value
            End Set
        End Property
        Property CreateOnObjectiveComplete As String()
            Get
                Return mCreateOnObjectiveComplete
            End Get
            Set(value As String())
                mCreateOnObjectiveComplete = value
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
        Property Objective As COH_Mission_Objective()
            Get
                Return mObjective
            End Get
            Set(value As COH_Mission_Objective())
                mObjective = value
            End Set
        End Property
        Property PlayerCreatedDetailType As Int32
            Get
                Return mPlayerCreatedDetailType
            End Get
            Set(value As Int32)
                mPlayerCreatedDetailType = value
            End Set
        End Property
        Property CutScene As COH_CutScene()
            Get
                Return mCutScene
            End Get
            Set(value As COH_CutScene())
                mCutScene = value
            End Set
        End Property
        Property EncounterAlliance As COH_Enum_EncounterAlliance
            Get
                Return mEncounterAlliance
            End Get
            Set(value As COH_Enum_EncounterAlliance)
                mEncounterAlliance = value
            End Set
        End Property
        Property MissionTeamOverride As COH_Enum_TeamOverride
            Get
                Return mMissionTeamOverride
            End Get
            Set(value As COH_Enum_TeamOverride)
                mMissionTeamOverride = value
            End Set
        End Property
        Property MissionEncounter As Int32
            Get
                Return mMissionEncounter
            End Get
            Set(value As Int32)
                mMissionEncounter = value
            End Set
        End Property
        Property CVGIndex As Int32
            Get
                Return mCVGIndex
            End Get
            Set(value As Int32)
                mCVGIndex = value
            End Set
        End Property
        Property CVGIndex2 As Int32
            Get
                Return mCVGIndex2
            End Get
            Set(value As Int32)
                mCVGIndex2 = value
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
       Private mCurrentFile As String
       Private mLogicalName As String
       Private mEncounterSpawn As String
       Private mDialog As String
       Private mDeprecated As Boolean
       Private mSpawnRadius As Int32
       Private mVillainMinLevel As Int32
       Private mVillainMaxLevel As Int32
       Private mMinTeamSize As Int32
       Private mMaxTeamSize As Int32
       Private mRespawnTimer As Int32
       Private mFlags As COH_Enum_SpawnFlags
       Private mActor As COH_Actor()
       Private mScript As COH_ScriptDef()
       Private mDialogDef As COH_DialogDef()
       Private mEncounterComplete As COH_StoryReward()
       Private mMissionPlacement As COH_Enum_MissionPlace
       Private mMissionCount As Int32
       Private mMissionUncounted As Boolean
       Private mCreateOnObjectiveComplete As String()
       Private mActivateOnObjectiveComplete As String()
       Private mObjective As COH_Mission_Objective()
       Private mPlayerCreatedDetailType As Int32
       Private mCutScene As COH_CutScene()
       Private mEncounterAlliance As COH_Enum_EncounterAlliance
       Private mMissionTeamOverride As COH_Enum_TeamOverride
       Private mMissionEncounter As Int32
       Private mCVGIndex As Int32
       Private mCVGIndex2 As Int32
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
            mCurrentFile = String.Empty
            mLogicalName = String.Empty
            mEncounterSpawn = String.Empty
            mDialog = String.Empty
            mActor = New COH_Actor() {}
            mScript = New COH_ScriptDef() {}
            mDialogDef = New COH_DialogDef() {}
            mEncounterComplete = New COH_StoryReward() {}
            mMissionPlacement = COH_Enum_MissionPlace.MISSION_ANY
            mCreateOnObjectiveComplete = New String() {}
            mActivateOnObjectiveComplete = New String() {}
            mObjective = New COH_Mission_Objective() {}
            mCutScene = New COH_CutScene() {}
            mVars = New COH_STD
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_SpawnDef
            Dim Result As COH_SpawnDef = New COH_SpawnDef
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCurrentFile = String.Copy(mCurrentFile)
                .mLogicalName = String.Copy(mLogicalName)
                .mEncounterSpawn = String.Copy(mEncounterSpawn)
                .mDialog = String.Copy(mDialog)
                .mDeprecated = mDeprecated
                .mSpawnRadius = mSpawnRadius
                .mVillainMinLevel = mVillainMinLevel
                .mVillainMaxLevel = mVillainMaxLevel
                .mMinTeamSize = mMinTeamSize
                .mMaxTeamSize = mMaxTeamSize
                .mRespawnTimer = mRespawnTimer
                .mFlags = mFlags
                .mActor = New COH_Actor(mActor.Count - 1) {}
                For X = 0 To mActor.Count - 1
                    .mActor(X) = mActor(X).Clone
                Next
                .mScript = New COH_ScriptDef(mScript.Count - 1) {}
                For X = 0 To mScript.Count - 1
                    .mScript(X) = mScript(X).Clone
                Next
                .mDialogDef = New COH_DialogDef(mDialogDef.Count - 1) {}
                For X = 0 To mDialogDef.Count - 1
                    .mDialogDef(X) = mDialogDef(X).Clone
                Next
                .mEncounterComplete = New COH_StoryReward(mEncounterComplete.Count - 1) {}
                For X = 0 To mEncounterComplete.Count - 1
                    .mEncounterComplete(X) = mEncounterComplete(X).Clone
                Next
                .mMissionPlacement = mMissionPlacement
                .mMissionCount = mMissionCount
                .mMissionUncounted = mMissionUncounted
                .mCreateOnObjectiveComplete = mCreateOnObjectiveComplete.CloneTheStrings
                .mActivateOnObjectiveComplete = mActivateOnObjectiveComplete.CloneTheStrings
                .mObjective = New COH_Mission_Objective(mObjective.Count - 1) {}
                For X = 0 To mObjective.Count - 1
                    .mObjective(X) = mObjective(X).Clone
                Next
                .mPlayerCreatedDetailType = mPlayerCreatedDetailType
                .mCutScene = New COH_CutScene(mCutScene.Count - 1) {}
                For X = 0 To mCutScene.Count - 1
                    .mCutScene(X) = mCutScene(X).Clone
                Next
                .mEncounterAlliance = mEncounterAlliance
                .mMissionTeamOverride = mMissionTeamOverride
                .mMissionEncounter = mMissionEncounter
                .mCVGIndex = mCVGIndex
                .mCVGIndex2 = mCVGIndex2
                .mVars = mVars.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mCurrentFile)
            CurrentWriter.Write_CrypticS_String(mLogicalName)
            CurrentWriter.Write_CrypticS_String(mEncounterSpawn)
            CurrentWriter.Write_CrypticS_String(mDialog)
            CurrentWriter.Write_CrypticS_Boolean(mDeprecated)
            CurrentWriter.Write(mSpawnRadius)
            CurrentWriter.Write(mVillainMinLevel)
            CurrentWriter.Write(mVillainMaxLevel)
            CurrentWriter.Write(mMinTeamSize)
            CurrentWriter.Write(mMaxTeamSize)
            CurrentWriter.Write(mRespawnTimer)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            If CurrentWriter.Write_CrypticS_StructArray(mActor) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mScript) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mDialogDef) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mEncounterComplete) = False Then Return False
            CurrentWriter.Write(CInt(mMissionPlacement))
            CurrentWriter.Write(mMissionCount)
            CurrentWriter.Write_CrypticS_Boolean(mMissionUncounted)
            CurrentWriter.Write_CrypticS_StringArray(mCreateOnObjectiveComplete)
            CurrentWriter.Write_CrypticS_StringArray(mActivateOnObjectiveComplete)
            If CurrentWriter.Write_CrypticS_StructArray(mObjective) = False Then Return False
            CurrentWriter.Write(mPlayerCreatedDetailType)
            If CurrentWriter.Write_CrypticS_StructArray(mCutScene) = False Then Return False
            CurrentWriter.Write(mEncounterAlliance)
            CurrentWriter.Write(mMissionTeamOverride)
            CurrentWriter.Write(mMissionEncounter)
            CurrentWriter.Write(mCVGIndex)
            CurrentWriter.Write(mCVGIndex2)

            Throw New Exception("NEED TO WRITE VARS")

            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mCurrentFile = CurrentReader.Read_CrypticS_String
            mLogicalName = CurrentReader.Read_CrypticS_String
            mEncounterSpawn = CurrentReader.Read_CrypticS_String
            mDialog = CurrentReader.Read_CrypticS_String
            mDeprecated = CurrentReader.Read_CrypticS_Boolean
            mSpawnRadius = CurrentReader.ReadInt32
            mVillainMinLevel = CurrentReader.ReadInt32
            mVillainMaxLevel = CurrentReader.ReadInt32
            mMinTeamSize = CurrentReader.ReadInt32
            mMaxTeamSize = CurrentReader.ReadInt32
            mRespawnTimer = CurrentReader.ReadInt32
            mFlags = CurrentReader.Read_CrypticS_Flags
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Actor), mActor) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_ScriptDef), mScript) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_DialogDef), mDialogDef) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mEncounterComplete) = False Then Return False
            mMissionPlacement = CurrentReader.ReadInt32
            mMissionCount = CurrentReader.ReadInt32
            mMissionUncounted = CurrentReader.Read_CrypticS_Boolean
            mCreateOnObjectiveComplete = CurrentReader.Read_CrypticS_StringArray()
            mActivateOnObjectiveComplete = CurrentReader.Read_CrypticS_StringArray()
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Mission_Objective), mObjective) = False Then Return False
            mPlayerCreatedDetailType = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CutScene), mCutScene) = False Then Return False
            mEncounterAlliance = CurrentReader.ReadInt32
            mMissionTeamOverride = CurrentReader.ReadInt32
            mMissionEncounter = CurrentReader.ReadInt32
            mCVGIndex = CurrentReader.ReadInt32
            mCVGIndex2 = CurrentReader.ReadInt32
            mVars = New COH_STD(CurrentReader)
            Return True
        End Function
#End Region

    End Class
End Namespace
