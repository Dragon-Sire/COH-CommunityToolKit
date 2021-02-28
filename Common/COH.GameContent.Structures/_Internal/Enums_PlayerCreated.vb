Namespace CodeManagement.Enums
    Public Enum COH_Enum_PlayerCreated_DetailType
        None = 0
        <COH_DefEnum("Ambush")> kDetail_Ambush
        <COH_DefEnum("Boss")> kDetail_Boss
        <COH_DefEnum("Collection")> kDetail_Collection
        <COH_DefEnum("DestructObject")> kDetail_DestructObject
        <COH_DefEnum("DefendObject")> kDetail_DefendObject
        <COH_DefEnum("Patrol")> kDetail_Patrol
        <COH_DefEnum("Rescue")> kDetail_Rescue
        <COH_DefEnum("Escort")> kDetail_Escort
        <COH_DefEnum("Ally")> kDetail_Ally
        <COH_DefEnum("Rumble")> kDetail_Rumble
        <COH_DefEnum("DefeatAll")> kDetail_DefeatAll
        <COH_DefEnum("GiantMonster")> kDetail_GiantMonster
        <COH_DefEnum("Count")> kDetail_Count
    End Enum
    Public Enum COH_Enum_PlayerCreated_SpecialActions
        <COH_DefEnum("None")> kAction_None
        <COH_DefEnum("EnumMorality")> kAction_EnumMorality
        <COH_DefEnum("EnumAlignment")> kAction_EnumAlignment
        <COH_DefEnum("EnumDifficulty")> kAction_EnumDifficulty
        <COH_DefEnum("EnumDifficultyWithSingle")> kAction_EnumDifficultyWithSingle
        <COH_DefEnum("EnumPacing")> kAction_EnumPacing
        <COH_DefEnum("EnumPlacement")> kAction_EnumPlacement
        <COH_DefEnum("EnumDetail")> kAction_EnumDetail
        <COH_DefEnum("EnumPersonCombat")> kAction_EnumPersonCombat
        <COH_DefEnum("EnumPersonBehavior")> kAction_EnumPersonBehavior
        <COH_DefEnum("EnumMapLength")> kAction_EnumMapLength
        <COH_DefEnum("EnumContactType")> kAction_EnumContactType
        <COH_DefEnum("EnumRumbleType")> kAction_EnumRumbleType
        <COH_DefEnum("EnumArcStatus")> kAction_EnumArcStatus
        <COH_DefEnum("BuildVillainGroupList")> kAction_BuildVillainGroupList
        <COH_DefEnum("BuildEntityList")> kAction_BuildEntityList
        <COH_DefEnum("BuildSupportEntityList")> kAction_BuildSupportEntityList
        <COH_DefEnum("BuildBossEntityList")> kAction_BuildBossEntityList
        <COH_DefEnum("BuildObjectEntityList")> kAction_BuildObjectEntityList
        <COH_DefEnum("BuildAnimList")> kAction_BuildAnimList
        <COH_DefEnum("BuildModelList")> kAction_BuildModelList
        <COH_DefEnum("BuildMapList")> kAction_BuildMapList
        <COH_DefEnum("BuildContactList")> kAction_BuildContactList
        <COH_DefEnum("BuildModelListContact")> kAction_BuildModelListContact
        <COH_DefEnum("BuildEntityListContact")> kAction_BuildEntityListContact
        <COH_DefEnum("BuildObjectEntityListContact")> kAction_BuildObjectEntityListContact
        <COH_DefEnum("BuildLevelList")> kAction_BuildLevelList
        <COH_DefEnum("BuildCustomVillainGroupList")> kAction_BuildCustomVillainGroupList
        <COH_DefEnum("BuildCustomCritterList")> kAction_BuildCustomCritterList
        <COH_DefEnum("BuildCustomCritterAndContactList")> kAction_BuildCustomCritterAndContactList
        <COH_DefEnum("BuildAmbushTrigger")> kAction_BuildAmbushTrigger
        <COH_DefEnum("BuildDestinationList")> kAction_BuildDestinationList
        <COH_DefEnum("BuildGiantMonsterEntityList")> kAction_BuildGiantMonsterEntityList
        <COH_DefEnum("BuildDoppelEntityList")> kAction_BuildDoppelEntityList
    End Enum
    Public Enum COH_Enum_PlayerCreated_CritterDiff
        <COH_DefEnum("Standard")> PCC_DIFF_STANDARD
        <COH_DefEnum("Hard")> PCC_DIFF_HARD
        <COH_DefEnum("Extreme")> PCC_DIFF_EXTREME
        <COH_DefEnum("Custom")> PCC_DIFF_CUSTOM = -1
        PCC_DIFF_COUNT = 4
    End Enum
    Public Enum COH_Enum_PlayerCreated_CritterRank
        <COH_DefEnum("Minion")> PCC_RANK_MINION
        <COH_DefEnum("Lieutenant")> PCC_RANK_LT
        <COH_DefEnum("Boss")> PCC_RANK_BOSS
        <COH_DefEnum("EliteBoss")> PCC_RANK_ELITE_BOSS
        <COH_DefEnum("ArchVillain")> PCC_RANK_ARCH_VILLAIN
        <COH_DefEnum("Contact")> PCC_RANK_CONTACT
        PCC_RANK_COUNT
    End Enum

End Namespace