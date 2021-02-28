Namespace Toolkit.Modding.Enums
    Public Enum COH_Enum_PowerCategory
        ClassName
        DisplayName
        DisplayNameKey
    End Enum
    Public Enum COH_Enum_PowerSet
        ClassName
        Name
        DisplayName
        DisplayNameKey
        DisplayShortHelp
        DisplayShortHelpKey
        DisplayHelp
        DisplayHelpKey
        CostumeKeys
        CostumeParts
        IconName
        SetAccountRequires
        SetAccountTooltip
        SetAccountProduct
        '//Added
        ShowInManage
        ShowInInventory
        ShowInInfo
        SpecializeAt
        SpecializeRequires
    End Enum
    Public Enum COH_Enum_PowerSet_Powers
        ClassName
        Available
        AIMaxLevel
        AIMinRankCon
        AIMaxRankCon
        MinDifficulty
        MaxDifficulty
    End Enum

    Public Enum COH_CC_Fields
        Name
        DisplayName
        PrimaryCategory
        SecondaryCategory
        PowerPoolCategory
        DisplayShortHelp
        DisplayHelp
        Icon
        AllowedOrigins
        SpecialRestrictions
        ConnectHpAndStatus
        StoreRequires
        LockedTooltip
        ProductCode
        '//LOCALIZATIONS ADDED
        DisplayNameKey
        DisplayShortHelpKey
        DisplayHelpKey
        LockedTooltipKey
        '//LATER STUFF
        LevelUpRespecs
        ReductionClass
        ReduceAsArchvillain
    End Enum
    Public Enum COH_CC_AttributeTables
        AttribMaxTable
        AttribMaxMaxTable
        AttribMin
        ResistanceMaxTable
        ResistanceMin
        StrengthMaxTable
        StrengthMin
        AtrribDiminCurIn
        AtrribDiminCurOut
        AtrribDiminResIn
        AtrribDiminResOut
        AtrribDiminStrIn
        AtrribDiminStrOut
    End Enum
    Public Enum COH_CC_Attributes
        Absorb
        Accuracy
        Afraid
        AOE_Attack
        Arc
        Cold
        Cold_Attack
        Confused
        Defense
        Electrical
        Endurance
        EnduranceDiscount
        Energy
        Energy_Attack
        Fire
        Fire_Attack
        Fly
        Heal
        Held
        HitPoints
        Immobilized
        Intangible
        InterruptTime
        JumpHeight
        Jumppack
        Knockback
        Knockup
        Lethal
        Lethal_Attack
        Melee_Attack
        Meter
        MovementControl
        MovementFriction
        Negative_Energy
        Negative_Energy_Attack
        NullBool
        OnlyAffectsSelf
        PerceptionRadius
        Placate
        Psionic
        Psionic_Attack
        Radiation
        Radius
        Rage
        Range
        Ranged_Attack
        RechargeTime
        Recovery
        Regeneration
        Repel
        Sleep
        Smashing
        Smashing_Attack
        Special
        SpeedFlying
        SpeedJumping
        SpeedRunning
        SpeedSwimming
        Stealth
        StealthRadius
        StealthRadiusPlayer
        Stunned
        Taunt
        Teleport
        Terrorized
        ThreatLevel
        TimeToActivate
        ToHit
        Toxic
        Unique1
        Unique2
        Unique3
        Untouchable
    End Enum
End Namespace