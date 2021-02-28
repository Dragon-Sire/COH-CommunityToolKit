Namespace CodeManagement.Enums
    Public Enum COH_Enum_GroupAlly
        <COH_DefEnum("None")> VG_ALLY_NONE
        <COH_DefEnum("Hero")> VG_ALLY_HERO
        <COH_DefEnum("Villain")> VG_ALLY_VILLAIN
        <COH_DefEnum("Monster")> VG_ALLY_MONSTER
    End Enum
    <Flags> Public Enum COH_Enum_VillainDopple
        <COH_DefEnum("Tall")> VDF_TALL = 1
        <COH_DefEnum("Short")> VDF_SHORT = 2
        <COH_DefEnum("Shadow")> VDF_SHADOW = 4
        <COH_DefEnum("Inverse")> VDF_INVERSE = 8
        <COH_DefEnum("Reverse")> VDF_REVERSE = 16
        <COH_DefEnum("BlackAndWhite")> VDF_BLACKANDWHITE = 32
        <COH_DefEnum("Demon")> VDF_DEMON = 64
        <COH_DefEnum("Angel")> VDF_ANGEL = 128
        <COH_DefEnum("Pirate")> VDF_PIRATE = 256
        <COH_DefEnum("RandomPower")> VDF_RANDOMPOWER = 512
        <COH_DefEnum("Ghost")> VDF_GHOST = 1024
        <COH_DefEnum("NoPowers")> VDF_NOPOWERS = 2048
        VDF_COUNT = 4096
    End Enum
    Public Enum COH_Enum_VillainRank
        VR_NONE                                                             '// (conning level)
        <COH_DefEnum("Small")> VR_SMALL                              '1
        <COH_DefEnum("Minion")> VR_MINION                            '0
        <COH_DefEnum("Lieutenant")> VR_LIEUTENANT                    '1
        <COH_DefEnum("Sniper")> VR_SNIPER                            '1
        <COH_DefEnum("Boss")> VR_BOSS                                '2
        <COH_DefEnum("Elite")> VR_ELITE                              '3 Elite
        <COH_DefEnum("ArchVillain")> VR_ARCHVILLAIN                  '5
        <COH_DefEnum("ArchVillain2")> VR_ARCHVILLAIN2                '5
        <COH_DefEnum("BigMonster")> VR_BIGMONSTER                    '100
        <COH_DefEnum("Pet")> VR_PET                                  '1
        <COH_DefEnum("Destructible")> VR_DESTRUCTIBLE                '1
        VR_MAX
    End Enum
    <Flags> Public Enum COH_Enum_VillainExclusion
        VE_NONE = 0 ' // Allow In all games
        <COH_DefEnum("CoHOnly")> VE_COH = 1 '// Allow In CoH Only
        <COH_DefEnum("CoVOnly")> VE_COV = 2 '// Allow In CoV Only
        VE_MA = 4
    End Enum
    <Flags> Public Enum COH_Enum_VillainBadgeFlags
        None = 0
        <COH_DefEnum("NoGroupBadgeStat")> VILLAINDEF_NOGROUPBADGESTAT = 1
        <COH_DefEnum("NoRankBadgeStat")> VILLAINDEF_NORANKBADGESTAT = 4
        <COH_DefEnum("NoNameBadgeStat")> VILLAINDEF_NONAMEBADGESTAT = 8
        <COH_DefEnum("NoGenericBadgeStat")> VILLAINDEF_NOGENERICBADGESTAT = 13
    End Enum

    '#define VILLAINDEF_NOGROUPBADGESTAT				(1 << 0) // Don't count a badgestat for the villain group when defeated
    '#define VILLAINDEF_NORANKBADGESTAT					(1 << 2) // Don't count a badgestat for the villain rank when defeated
    '#define VILLAINDEF_NONAMEBADGESTAT					(1 << 3) // Don't count a badgestat for the villain name when defeated
    '#define VILLAINDEF_NOGENERICBADGESTAT				(VILLAINDEF_NOGROUPBADGESTAT | VILLAINDEF_NORANKBADGESTAT | VILLAINDEF_NONAMEBADGESTAT)
    Public Enum COH_Enum_AI_ConfigEnum
        AICONFIG_RANGED
        AICONFIG_MELEE
        AICONFIG_COUNT
    End Enum
    Public Enum COH_Enum_VillainGroup
        VG_NONE
        '//LIST
        VG_MAX
    End Enum
End Namespace