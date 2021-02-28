Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_Mission
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
        Property EntryString As String
            Get
                Return mEntryString
            End Get
            Set(value As String)
                mEntryString = value
            End Set
        End Property
        Property ExitStringFail As String
            Get
                Return mExitStringFail
            End Get
            Set(value As String)
                mExitStringFail = value
            End Set
        End Property
        Property ExitStringSuccess As String
            Get
                Return mExitStringSuccess
            End Get
            Set(value As String)
                mExitStringSuccess = value
            End Set
        End Property
        Property DefeatAllText As String
            Get
                Return mDefeatAllText
            End Get
            Set(value As String)
                mDefeatAllText = value
            End Set
        End Property
        Property MapFile As String
            Get
                Return mMapFile
            End Get
            Set(value As String)
                mMapFile = value
            End Set
        End Property
        Property MapSet As COH_Enum_MapSet
            Get
                Return mMapSet
            End Get
            Set(value As COH_Enum_MapSet)
                mMapSet = value
            End Set
        End Property
        Property MapLength As Int32
            Get
                Return mMapLength
            End Get
            Set(value As Int32)
                mMapLength = value
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
        Property VillainGroupVar As String
            Get
                Return mVillainGroupVar
            End Get
            Set(value As String)
                mVillainGroupVar = value
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
        Property Flags As COH_Enum_MissionFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_MissionFlags)
                mFlags = value
            End Set
        End Property
        Property CityZone As String
            Get
                Return mCityZone
            End Get
            Set(value As String)
                mCityZone = value
            End Set
        End Property
        Property DoorType As String
            Get
                Return mDoorType
            End Get
            Set(value As String)
                mDoorType = value
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
        Property FoyerType As String
            Get
                Return mFoyerType
            End Get
            Set(value As String)
                mFoyerType = value
            End Set
        End Property
        Property DoorNPC As String
            Get
                Return mDoorNPC
            End Get
            Set(value As String)
                mDoorNPC = value
            End Set
        End Property
        Property DoorNPCDialog As String
            Get
                Return mDoorNPCDialog
            End Get
            Set(value As String)
                mDoorNPCDialog = value
            End Set
        End Property
        Property DoorNPCDialogStart As String
            Get
                Return mDoorNPCDialogStart
            End Get
            Set(value As String)
                mDoorNPCDialogStart = value
            End Set
        End Property
        Property NumSideMissions As Int32
            Get
                Return mNumSideMissions
            End Get
            Set(value As Int32)
                mNumSideMissions = value
            End Set
        End Property
        Property SideMission As String()
            Get
                Return mSideMission
            End Get
            Set(value As String())
                mSideMission = value
            End Set
        End Property
        Property VillainPacing As COH_Enum_VillainPacingEnum
            Get
                Return mVillainPacing
            End Get
            Set(value As COH_Enum_VillainPacingEnum)
                mVillainPacing = value
            End Set
        End Property
        Property TimeToComplete As Int32
            Get
                Return mTimeToComplete
            End Get
            Set(value As Int32)
                mTimeToComplete = value
            End Set
        End Property
        Property RandomNPCs As Int32
            Get
                Return mRandomNPCs
            End Get
            Set(value As Int32)
                mRandomNPCs = value
            End Set
        End Property
        Property MissionLevel As Int32
            Get
                Return mMissionLevel
            End Get
            Set(value As Int32)
                mMissionLevel = value
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
        Property Objective As COH_Mission_Objective()
            Get
                Return mObjective
            End Get
            Set(value As COH_Mission_Objective())
                mObjective = value
            End Set
        End Property
        Property CanCompleteWith As COH_Mission_Objectives_Set()
            Get
                Return mCanCompleteWith
            End Get
            Set(value As COH_Mission_Objectives_Set())
                mCanCompleteWith = value
            End Set
        End Property
        Property CanFailWith As COH_Mission_Objectives_Set()
            Get
                Return mCanFailWith
            End Get
            Set(value As COH_Mission_Objectives_Set())
                mCanFailWith = value
            End Set
        End Property
        Property Race As String
            Get
                Return mRace
            End Get
            Set(value As String)
                mRace = value
            End Set
        End Property
        Property DayNightCycle As COH_Enum_DayNightCycle
            Get
                Return mDayNightCycle
            End Get
            Set(value As COH_Enum_DayNightCycle)
                mDayNightCycle = value
            End Set
        End Property
        Property KeyDoor As COH_Mission_KeyDoor()
            Get
                Return mKeyDoor
            End Get
            Set(value As COH_Mission_KeyDoor())
                mKeyDoor = value
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
        Property KeyClueDef As COH_StoryClue()
            Get
                Return mKeyClueDef
            End Get
            Set(value As COH_StoryClue())
                mKeyClueDef = value
            End Set
        End Property
        Property CustomVGIdx As Int32
            Get
                Return mCustomVGIdx
            End Get
            Set(value As Int32)
                mCustomVGIdx = value
            End Set
        End Property
        Property FogDist As Single
            Get
                Return mFogDist
            End Get
            Set(value As Single)
                mFogDist = value
            End Set
        End Property
        Property FogColor As COH_Struct_Vector3
            Get
                Return mFogColor
            End Get
            Set(value As COH_Struct_Vector3)
                mFogColor = value
            End Set
        End Property
        Property ShowItemsOnMinimap As Int32
            Get
                Return mShowItemsOnMinimap
            End Get
            Set(value As Int32)
                mShowItemsOnMinimap = value
            End Set
        End Property
        Property ShowCrittersOnMinimap As Int32
            Get
                Return mShowCrittersOnMinimap
            End Get
            Set(value As Int32)
                mShowCrittersOnMinimap = value
            End Set
        End Property
        Property LoadScreenPages As String()
            Get
                Return mLoadScreenPages
            End Get
            Set(value As String())
                mLoadScreenPages = value
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
       Private mEntryString As String
       Private mExitStringFail As String
       Private mExitStringSuccess As String
       Private mDefeatAllText As String
       Private mMapFile As String
       Private mMapSet As COH_Enum_MapSet
       Private mMapLength As Int32
       Private mVillainGroup As String
       Private mVillainGroupVar As String
       Private mVillainGroupType As Int32
       Private mFlags As COH_Enum_MissionFlags
       Private mCityZone As String
       Private mDoorType As String
       Private mLocationName As String
       Private mFoyerType As String
       Private mDoorNPC As String
       Private mDoorNPCDialog As String
       Private mDoorNPCDialogStart As String
       Private mNumSideMissions As Int32
       Private mSideMission As String()
       Private mVillainPacing As COH_Enum_VillainPacingEnum
       Private mTimeToComplete As Int32
       Private mRandomNPCs As Int32
       Private mMissionLevel As Int32
       Private mSpawnDef As COH_SpawnDef()
       Private mObjective As COH_Mission_Objective()
       Private mCanCompleteWith As COH_Mission_Objectives_Set()
       Private mCanFailWith As COH_Mission_Objectives_Set()
       Private mRace As String
       Private mDayNightCycle As COH_Enum_DayNightCycle
       Private mKeyDoor As COH_Mission_KeyDoor()
       Private mScript As COH_ScriptDef()
       Private mKeyClueDef As COH_StoryClue()
       Private mCustomVGIdx As Int32
       Private mFogDist As Single
       Private mFogColor As COH_Struct_Vector3
       Private mShowItemsOnMinimap As Int32
       Private mShowCrittersOnMinimap As Int32
       Private mLoadScreenPages As String()
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
            mEntryString = String.Empty
            mExitStringFail = String.Empty
            mExitStringSuccess = String.Empty
            mDefeatAllText = String.Empty
            mMapFile = String.Empty
            mMapSet = COH_Enum_MapSet.MAPSET_NONE
            mVillainGroup = String.Empty
            mVillainGroupVar = String.Empty
            mCityZone = String.Empty
            mDoorType = String.Empty
            mLocationName = String.Empty
            mFoyerType = String.Empty
            mDoorNPC = String.Empty
            mDoorNPCDialog = String.Empty
            mDoorNPCDialogStart = String.Empty
            mSideMission = New String() {}
            mVillainPacing = COH_Enum_VillainPacingEnum.PACING_FLAT
            mSpawnDef = New COH_SpawnDef() {}
            mObjective = New COH_Mission_Objective() {}
            mCanCompleteWith = New COH_Mission_Objectives_Set() {}
            mCanFailWith = New COH_Mission_Objectives_Set() {}
            mRace = String.Empty
            mDayNightCycle = COH_Enum_DayNightCycle.DAYNIGHT_NORMAL
            mKeyDoor = New COH_Mission_KeyDoor() {}
            mScript = New COH_ScriptDef() {}
            mKeyClueDef = New COH_StoryClue() {}
            mFogColor = New COH_Struct_Vector3
            mLoadScreenPages = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Mission
            Dim Result As COH_Mission = New COH_Mission
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCurrentFile = String.Copy(mCurrentFile)
                .mEntryString = String.Copy(mEntryString)
                .mExitStringFail = String.Copy(mExitStringFail)
                .mExitStringSuccess = String.Copy(mExitStringSuccess)
                .mDefeatAllText = String.Copy(mDefeatAllText)
                .mMapFile = String.Copy(mMapFile)
                .mMapSet = mMapSet
                .mMapLength = mMapLength
                .mVillainGroup = String.Copy(mVillainGroup)
                .mVillainGroupVar = String.Copy(mVillainGroupVar)
                .mVillainGroupType = mVillainGroupType
                .mFlags = mFlags
                .mCityZone = String.Copy(mCityZone)
                .mDoorType = String.Copy(mDoorType)
                .mLocationName = String.Copy(mLocationName)
                .mFoyerType = String.Copy(mFoyerType)
                .mDoorNPC = String.Copy(mDoorNPC)
                .mDoorNPCDialog = String.Copy(mDoorNPCDialog)
                .mDoorNPCDialogStart = String.Copy(mDoorNPCDialogStart)
                .mNumSideMissions = mNumSideMissions
                .mSideMission = mSideMission.CloneTheStrings
                .mVillainPacing = mVillainPacing
                .mTimeToComplete = mTimeToComplete
                .mRandomNPCs = mRandomNPCs
                .mMissionLevel = mMissionLevel
                .mSpawnDef = New COH_SpawnDef(mSpawnDef.Count - 1) {}
                For X = 0 To mSpawnDef.Count - 1
                    .mSpawnDef(X) = mSpawnDef(X).Clone
                Next
                .mObjective = New COH_Mission_Objective(mObjective.Count - 1) {}
                For X = 0 To mObjective.Count - 1
                    .mObjective(X) = mObjective(X).Clone
                Next
                .mCanCompleteWith = New COH_Mission_Objectives_Set(mCanCompleteWith.Count - 1) {}
                For X = 0 To mCanCompleteWith.Count - 1
                    .mCanCompleteWith(X) = mCanCompleteWith(X).Clone
                Next
                .mCanFailWith = New COH_Mission_Objectives_Set(mCanFailWith.Count - 1) {}
                For X = 0 To mCanFailWith.Count - 1
                    .mCanFailWith(X) = mCanFailWith(X).Clone
                Next
                .mRace = String.Copy(mRace)
                .mDayNightCycle = mDayNightCycle
                .mKeyDoor = New COH_Mission_KeyDoor(mKeyDoor.Count - 1) {}
                For X = 0 To mKeyDoor.Count - 1
                    .mKeyDoor(X) = mKeyDoor(X).Clone
                Next
                .mScript = New COH_ScriptDef(mScript.Count - 1) {}
                For X = 0 To mScript.Count - 1
                    .mScript(X) = mScript(X).Clone
                Next
                .mKeyClueDef = New COH_StoryClue(mKeyClueDef.Count - 1) {}
                For X = 0 To mKeyClueDef.Count - 1
                    .mKeyClueDef(X) = mKeyClueDef(X).Clone
                Next
                .mCustomVGIdx = mCustomVGIdx
                .mFogDist = mFogDist
                .mFogColor = mFogColor
                .mShowItemsOnMinimap = mShowItemsOnMinimap
                .mShowCrittersOnMinimap = mShowCrittersOnMinimap
                .mLoadScreenPages = mLoadScreenPages.CloneTheStrings
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mCurrentFile)
            CurrentWriter.Write_CrypticS_String(mEntryString)
            CurrentWriter.Write_CrypticS_String(mExitStringFail)
            CurrentWriter.Write_CrypticS_String(mExitStringSuccess)
            CurrentWriter.Write_CrypticS_String(mDefeatAllText)
            CurrentWriter.Write_CrypticS_String(mMapFile)
            CurrentWriter.Write(CInt(mMapSet))
            CurrentWriter.Write(mMapLength)
            CurrentWriter.Write_CrypticS_String(mVillainGroup)
            CurrentWriter.Write_CrypticS_String(mVillainGroupVar)
            CurrentWriter.Write(mVillainGroupType)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            CurrentWriter.Write_CrypticS_String(mCityZone)
            CurrentWriter.Write_CrypticS_String(mDoorType)
            CurrentWriter.Write_CrypticS_String(mLocationName)
            CurrentWriter.Write_CrypticS_String(mFoyerType)
            CurrentWriter.Write_CrypticS_String(mDoorNPC)
            CurrentWriter.Write_CrypticS_String(mDoorNPCDialog)
            CurrentWriter.Write_CrypticS_String(mDoorNPCDialogStart)
            CurrentWriter.Write(mNumSideMissions)
            CurrentWriter.Write_CrypticS_StringArray(mSideMission)
            CurrentWriter.Write(CInt(mVillainPacing))
            CurrentWriter.Write(mTimeToComplete)
            CurrentWriter.Write(mRandomNPCs)
            CurrentWriter.Write(mMissionLevel)
            If CurrentWriter.Write_CrypticS_StructArray(mSpawnDef) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mObjective) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mCanCompleteWith) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mCanFailWith) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mRace)
            CurrentWriter.Write(CInt(mDayNightCycle))
            If CurrentWriter.Write_CrypticS_StructArray(mKeyDoor) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mScript) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mKeyClueDef) = False Then Return False
            CurrentWriter.Write(mCustomVGIdx)
            CurrentWriter.Write(mFogDist)
            CurrentWriter.Write_CrypticS_Vector3(mFogColor)
            CurrentWriter.Write(mShowItemsOnMinimap)
            CurrentWriter.Write(mShowCrittersOnMinimap)
            CurrentWriter.Write_CrypticS_StringArray(mLoadScreenPages)

            Throw New Exception("NEED TO WRITE VARS")

            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mCurrentFile = CurrentReader.Read_CrypticS_String
            mEntryString = CurrentReader.Read_CrypticS_String
            mExitStringFail = CurrentReader.Read_CrypticS_String
            mExitStringSuccess = CurrentReader.Read_CrypticS_String
            mDefeatAllText = CurrentReader.Read_CrypticS_String
            mMapFile = CurrentReader.Read_CrypticS_String
            mMapSet = CurrentReader.ReadInt32
            mMapLength = CurrentReader.ReadInt32
            mVillainGroup = CurrentReader.Read_CrypticS_String
            mVillainGroupVar = CurrentReader.Read_CrypticS_String
            mVillainGroupType = CurrentReader.ReadInt32
            mFlags = CurrentReader.Read_CrypticS_Flags
            mCityZone = CurrentReader.Read_CrypticS_String
            mDoorType = CurrentReader.Read_CrypticS_String
            mLocationName = CurrentReader.Read_CrypticS_String
            mFoyerType = CurrentReader.Read_CrypticS_String
            mDoorNPC = CurrentReader.Read_CrypticS_String
            mDoorNPCDialog = CurrentReader.Read_CrypticS_String
            mDoorNPCDialogStart = CurrentReader.Read_CrypticS_String
            mNumSideMissions = CurrentReader.ReadInt32
            mSideMission = CurrentReader.Read_CrypticS_StringArray()
            mVillainPacing = CurrentReader.ReadInt32
            mTimeToComplete = CurrentReader.ReadInt32
            mRandomNPCs = CurrentReader.ReadInt32
            mMissionLevel = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_SpawnDef), mSpawnDef) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Mission_Objective), mObjective) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Mission_Objectives_Set), mCanCompleteWith) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Mission_Objectives_Set), mCanFailWith) = False Then Return False
            mRace = CurrentReader.Read_CrypticS_String
            mDayNightCycle = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Mission_KeyDoor), mKeyDoor) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_ScriptDef), mScript) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryClue), mKeyClueDef) = False Then Return False
            mCustomVGIdx = CurrentReader.ReadInt32
            mFogDist = CurrentReader.ReadSingle
            mFogColor = CurrentReader.Read_CrypticS_Vector3
            mShowItemsOnMinimap = CurrentReader.ReadInt32
            mShowCrittersOnMinimap = CurrentReader.ReadInt32
            mLoadScreenPages = CurrentReader.Read_CrypticS_StringArray()


            mVars = New COH_STD(CurrentReader)
            Return True
        End Function
#End Region

    End Class
End Namespace
