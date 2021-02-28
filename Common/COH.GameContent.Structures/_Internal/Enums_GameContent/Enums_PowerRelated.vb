Namespace CodeManagement.Enums
    Public Enum COH_Enum_PowerType
        ' Defines if the power is auto, toggle, or click power.
        ' Click powers only activate when the user has activated them.
        ' Toggle powers activate repeatedly when the character turns them on until they shut them off (or the character runs out of endurance).
        ' Auto powers activate repeatedly.
        ' Boosts apply to powers only.
        kPowerType_Click
        kPowerType_Auto
        kPowerType_Toggle
        kPowerType_Boost
        kPowerType_Inspiration
        kPowerType_GlobalBoost
        kPowerType_Count
    End Enum
    Public Enum COH_Enum_PowerSystem
        ' Which power system to use for advancement, level lookup, etc.
        kPowerSystem_Powers = 0
        kPowerSystem_Count
    End Enum
    Public Enum COH_Enum_AIReport
        kAIReport_Always ' Report on hit or miss
        kAIReport_Never ' Never report to AI
        kAIReport_HitOnly ' Report only when hit
        kAIReport_MissOnly ' Report only when missed
        kAIReport_Count
    End Enum
    Public Enum COH_Enum_TargetVisibility
        ' Defines what kind of visibility is required between the caster and the target for successful execution of the power.
        kTargetVisibility_LineOfSight ' The caster must have direct line of sight to the target
        kTargetVisibility_None ' No visibility is required (or checked)
        kTargetVisibility_Count
    End Enum
    Public Enum COH_Enum_EffectArea
        ' The area effected by the power.
        kEffectArea_Character
        ' Any targeted entity
        kEffectArea_Cone
        ' A cone centered around the ray connecting the source to the target.
        kEffectArea_Sphere
        ' A sphere surrounding the target.
        kEffectArea_Location
        ' A single spot on the ground.
        kEffectArea_Volume
        ' In the same volume as the caster
        kEffectArea_NamedVolume
        ' In a volume named the name as the one the caster is in (not yet implemented)
        kEffectArea_Map
        ' Everybody on the same map as the caster
        kEffectArea_Room
        ' In the same Tray (Room) as the caster
        kEffectArea_Touch
        ' Capsules touch
        kEffectArea_Box
        ' A box positioned relative to the target, oriented along the regular xyz axes
        kEffectArea_Count
    End Enum
    Public Enum COH_Enum_ShowPowerSetting
        kShowPowerSetting_Never = 0 ' old false.
        ' If on a powerset that the player owns, do not show this powerset or any powers in it (no matter what settings the powers have).
        ' If on a power, don't show it (if the powerset allows the power to control its display).
        kShowPowerSetting_Default = 1 ' old true.
        ' If on a powerset that the player owns, show this powerset, but then allow the power to determine whether it is shown.
        ' If on a power, show it (if the powerset allows the power to control its display).
        kShowPowerSetting_Always
        ' If on a powerset that the player owns, show this powerset and all powers in it (no matter what settings the powers have).
        ' If on a power, show it (if the powerset allows the power to control its display).
        kShowPowerSetting_IfUsable
        ' If on a powerset that the player owns, display it, and display all powers in the powerset only if they are usable (no matter what settings the powers have).
        ' If on a power, display it only if it is usable (if the powerset allows the power to control its display).
        kShowPowerSetting_IfOwned
        ' If on a powerset that the player owns, display it, and display all powers in the powerset only if they are owned by the player (no matter what settings the powers have).
        ' If on a power, display it only if it is owned by the player (if the powerset allows the power to control its display).
    End Enum
    Public Enum COH_Enum_DeathCastableSetting
        kDeathCastableSetting_AliveOnly = 0
        kDeathCastableSetting_DeadOnly = 1
        kDeathCastableSetting_DeadOrAlive = 2
    End Enum
    Public Enum COH_Enum_ToggleDroppable
        kToggleDroppable_Sometimes
        kToggleDroppable_Always
        kToggleDroppable_First
        kToggleDroppable_Last
        kToggleDroppable_Never
    End Enum
    Public Enum COH_Enum_PowerMode
        kPowerMode_ServerTrayOverride = 0
        ' NOTE:  There are a lot more PowerModes that aren't defined here.
        ' Only modes with effects in the code are defined here.
    End Enum
    Public Enum COH_Enum_ModApplication
        <COH_DefEnum("kOnTick")> kModApplicationType_OnTick ' while the power is running
        <COH_DefEnum("kOnActivate")> kModApplicationType_OnActivate ' when the power is turned on
        <COH_DefEnum("kOnDeactivate")> kModApplicationType_OnDeactivate ' when the power is turned off
        <COH_DefEnum("kOnExpire")> kModApplicationType_OnExpire ' a limited version of onDeactivate
        ' ARM NOTE:  There are some strange edge cases around character_Reset() and related
        '   functionality where enable/disable appear to be triggering more often than they should,
        '   and in improper order.  At some point we're going to need to fix those edge cases,
        '   but I've invested enough time into this right now that I'm just going to let them be.
        '   For current usage (just granting a power on enable and revoking the power on disable),
        '   the current code appears to have the correct output, even if it doesn't get there in
        '   any understandable way...
        <COH_DefEnum("kOnEnable")> kModApplicationType_OnEnable ' when the power becomes able to be turned on
        <COH_DefEnum("kOnDisable")> kModApplicationType_OnDisable ' when the power becomes no longer able to be turned on
        '// The following are deprecated, please use the above instead.
        '<COH_DescriptionEnum("kOnIncarnateEquip")> kModApplicationType_OnEnable
        '<COH_DescriptionEnum("kOnIncarnateUnequip")> kModApplicationType_OnDisable
        ' Keep this last
        kModApplicationType_Count
    End Enum
    Public Enum COH_Enum_ModTarget
        <COH_DefEnum("kCaster")> kModTarget_Caster
        <COH_DefEnum("kCastersOwnerAndAllPets")> kModTarget_CastersOwnerAndAllPets
        <COH_DefEnum("kFocus")> kModTarget_Focus
        <COH_DefEnum("kFocusOwnerAndAllPets")> kModTarget_FocusOwnerAndAllPets
        <COH_DefEnum("kAffected")> kModTarget_Affected
        <COH_DefEnum("kAffectedsOwnerAndAllPets")> kModTarget_AffectedsOwnerAndAllPets
        <COH_DefEnum("kMarker")> kModTarget_Marker
        '//DEPRECIATED
        '<COH_DescriptionEnum("kSelf")> kModTarget_Caster
        '<COH_DescriptionEnum("kSelfsOwnerAndAllPets")> kModTarget_CastersOwnerAndAllPets
        '<COH_DescriptionEnum("kTarget")> kModTarget_Affected
        '<COH_DescriptionEnum("kTargetsOwnerAndAllPets")> kModTarget_AffectedsOwnerAndAllPets
        ' Keep this last
        kModTarget_Count
    End Enum
    Public Enum COH_Enum_ModType
        <COH_DefEnum("kDuration")> kModType_Duration
        <COH_DefEnum("kMagnitude")> kModType_Magnitude
        <COH_DefEnum("kConstant")> kModType_Constant
        <COH_DefEnum("kExpression")> kModType_Expression
        <COH_DefEnum("kSkillMagnitude")> kModType_SkillMagnitude
        ' Keep this last
        kModType_Count
    End Enum
    Public Enum COH_Enum_CasterStackType
        <COH_DefEnum("kIndividual")> kCasterStackType_Individual ' Stacking is handled for each caster individually
        <COH_DefEnum("kCollective")> kCasterStackType_Collective ' Stacking is handled for all casters collectively
        ' Keep this last
        kCasterStackType_Count
    End Enum
    Public Enum COH_Enum_StackType
        ' Determines how multiple identical AttribMods from the same power and caster are handled.
        <COH_DefEnum("kStack")> kStackType_Stack 'Stack up (allow multiples)
        <COH_DefEnum("kIgnore")> kStackType_Ignore 'Ignore the new duplicate (do nothing)
        <COH_DefEnum("kExtend")> kStackType_Extend  'Update the parameters In And extend the existing AttribMod
        <COH_DefEnum("kReplace")> kStackType_Replace 'Update the parameters and replace the existing AttribMod
        <COH_DefEnum("kOverlap")> kStackType_Overlap 'Update the parameters in the existing AttribMod, don't extend the duration
        <COH_DefEnum("kStackThenIgnore")> kStackType_StackThenIgnore ' Stack up to StackCount times (if count < StackCount, then stack, else ignore)
        <COH_DefEnum("kRefresh")> kStackType_Refresh 'Update the duration in all copies of the existing matching AttribMods, then add a new copy on
        <COH_DefEnum("kRefreshToCount")> kStackType_RefreshToCount 'If count < StackCount, then Refresh and add a new copy, else just Refresh
        <COH_DefEnum("kMaximize")> kStackType_Maximize 'If mag is greater Replace, else Ignore
        <COH_DefEnum("kSuppress")> kStackType_Suppres 'Keep all, but suppress all but the greatest magnitude
        ' Keep this last
        k_StackType_Count
    End Enum
    Public Enum COH_Enum_PowerEvent
        <COH_DefEnum("Activate")> kPowerEvent_Activate ' Must be first invoke-related event
        <COH_DefEnum("ActivateAttackClick")> kPowerEvent_ActivateAttackClick
        <COH_DefEnum("Attacked")> kPowerEvent_Attacked
        <COH_DefEnum("AttackedNoException")> kPowerEvent_AttackedNoException
        <COH_DefEnum("Helped")> kPowerEvent_Helped
        <COH_DefEnum("Hit")> kPowerEvent_Hit
        <COH_DefEnum("Miss")> kPowerEvent_Miss
        <COH_DefEnum("EndActivate")> kPowerEvent_EndActivate ' Must be last invoke-related event
        <COH_DefEnum("AttackedByOther")> kPowerEvent_AttackedByOther ' Must be the first apply-related event
        <COH_DefEnum("AttackedByOtherClick")> kPowerEvent_AttackedByOtherClick
        <COH_DefEnum("HelpedByOther")> kPowerEvent_HelpedByOther
        <COH_DefEnum("HitByOther")> kPowerEvent_HitByOther
        <COH_DefEnum("HitByFriend")> kPowerEvent_HitByFriend
        <COH_DefEnum("HitByFoe")> kPowerEvent_HitByFoe
        <COH_DefEnum("MissByOther")> kPowerEvent_MissByOther
        <COH_DefEnum("MissByFriend")> kPowerEvent_MissByFriend
        <COH_DefEnum("MissByFoe")> kPowerEvent_MissByFoe ' Must be the last apply-related event
        <COH_DefEnum("Damaged")> kPowerEvent_Damaged
        <COH_DefEnum("Healed")> kPowerEvent_Healed
        <COH_DefEnum("Stunned", "Stun")> kPowerEvent_Stunned ' Must be first status event for macro below
        <COH_DefEnum("Immobilized", "Immobilize")> kPowerEvent_Immobilized
        <COH_DefEnum("Held")> kPowerEvent_Held '21
        <COH_DefEnum("Sleep")> kPowerEvent_Sleep
        <COH_DefEnum("Terrorized", "Terrorize")> kPowerEvent_Terrorized
        <COH_DefEnum("Confused", "Confuse")> kPowerEvent_Confused
        <COH_DefEnum("Untouchable")> kPowerEvent_Untouchable
        <COH_DefEnum("Intangible")> kPowerEvent_Intangible
        <COH_DefEnum("OnlyAffectsSelf")> kPowerEvent_OnlyAffectsSelf
        <COH_DefEnum("AnyStatus")> kPowerEvent_AnyStatus ' Leave as last status event
        <COH_DefEnum("Knocked")> kPowerEvent_Knocked
        <COH_DefEnum("Defeated")> kPowerEvent_Defeated
        <COH_DefEnum("MissionObjectClick")> kPowerEvent_MissionObjectClick
        <COH_DefEnum("Moved")> kPowerEvent_Moved
        <COH_DefEnum("Defiant")> kPowerEvent_Defiant
        ' Keep this last
        kPowerEvent_Count
    End Enum
    Public Enum COH_Enum_Duration '// As Single
        <COH_DefEnum("kInstant")> kInstant = -1
        <COH_DefEnum("None")> None = 0 '//ADDED BECUASE 
        <COH_DefEnum("kUntilKilled")> kUntilKilled = 999999 '//ATTRIBMOD_DURATION_FOREVER
        <COH_DefEnum("kUntilShutOff")> kUntilShutOff = 999999
    End Enum
    Public Enum COH_Enum_SupressAlways
        WhenInactive
        Always
    End Enum
    Public Enum COH_Enum_TargetType
        ' DANGER: If you change the order or add anything to this list, you MUST MUST update g_abTargetAllowedDead and  g_abTargetAllowedAlive (below)
        ' The thing which can be targetted. Used to specify which kinds of entities are affected, auto-hit, etc by a power.
        kTargetType_None
        kTargetType_Caster ' the caster, dead or alive
        kTargetType_Player ' Any living players except the caster
        kTargetType_PlayerHero ' Any living player on Team Hero except the caster
        kTargetType_PlayerVillain ' Any living player on Team Villain except the caster
        kTargetType_DeadPlayer ' Any dead players including the caster
        kTargetType_DeadPlayerFriend ' Any dead players on the same side as the caster except the caster and skill checks
        kTargetType_DeadPlayerFoe ' Any dead players on the same side as the caster except the caster and skill checks
        kTargetType_Teammate ' Any living teammate and their pets except the caster
        kTargetType_DeadTeammate ' Any dead teammate and all teammate's dead pets except the caster
        kTargetType_DeadOrAliveTeammate ' All teammates and their pets, dead or alive except the caster
        kTargetType_Villain ' Any living critter on team evil except the caster and skill checks
        kTargetType_DeadVillain ' Any dead critter on team evil including the caster and skill checks
        kTargetType_NPC ' Any living NPC but villains and skill checks
        kTargetType_DeadOrAliveFriend ' Anyone dead or alive on the same side as the caster except the caster and skill checks.
        kTargetType_DeadFriend ' Anyone dead on the same side as the caster except the caster and skill checks.
        kTargetType_Friend ' Anyone alive on the same side as the caster except the caster and skill checks.
        kTargetType_DeadOrAliveFoe ' Anyone dead or alive on a different side from the caster except the caster and skill checks.
        kTargetType_DeadFoe ' Anyone dead on a different side from the caster except the caster and skill checks.
        kTargetType_Foe ' Anyone alive on a different side from the caster except the caster and skill checks.
        kTargetType_Location ' A specific location
        kTargetType_Any ' Any living entity which isn't dead
        kTargetType_Teleport ' A specific location with constraints for teleporting.
        kTargetType_DeadOrAliveMyPet ' Any target where the source is the owner
        kTargetType_DeadMyPet ' The target is dead and is the source is the owner
        kTargetType_MyPet ' The target is alive and is the source is the owner
        kTargetType_MyOwner ' The target is the owner of the caster (this goes all the way back up to the original owner)
        kTargetType_MyCreator '    The target is the creator of the caster (this goes only one level up to the entity that created ent)
        kTargetType_MyCreation '    The target is alive and the source is the creator
        kTargetType_DeadMyCreation '    The target is dead and the source is the creator
        kTargetType_DeadOrAliveMyCreation '    Any target where the source is the creator
        kTargetType_Leaguemate '    Any living leaguemate and their pets except the caster
        kTargetType_DeadLeaguemate '    Any dead leaguemate and all leaguemate's dead pets except the caster
        kTargetType_DeadOrAliveLeaguemate '    All leaguemates and their pets, dead or alive except the caster
        kTargetType_Position ' A position relative to an entity specified by the designer
        ' DANGER: If you change the order or add anything to this list, you
        '         MUST MUST update g_abTargetAllowedDead and
        '         g_abTargetAllowedAlive (in character_target.c)
        kTargetType_Count
    End Enum
    Public Enum COH_Enum_Category
        kCategory_Primary = 0
        kCategory_Secondary
        kCategory_Pool
        kCategory_Epic
        '/* Add New categories which a character has here */
        kCategory_Count
    End Enum
    Public Enum COH_Enum_ClassesDiminish
        kClassesDiminish_Inner
        kClassesDiminish_Outer
        kClassesDiminish_Count
    End Enum
    Public Enum COH_Enum_ProcAllowed
        <COH_DefEnum("kAll")> kProcAllowed_All
        <COH_DefEnum("kNone")> kProcAllowed_None
        <COH_DefEnum("kPowerOnly")> kProcAllowed_PowerOnly
        <COH_DefEnum("kGlobalOnly")> kProcAllowed_GlobalOnly
    End Enum
    <Flags> Public Enum COH_EnumFlags_AttribModFlags
        NoFloaters
        BoostIgnoreDiminishing
        CancelOnMiss
        NearGround
        IgnoreStrength
        IgnoreResistance
        IgnoreCombatMods
        ResistMagnitude
        ResistDuration
        CombatModMagnitude
        CombatModDuration
        Boost
        HideZero
        KeepThroughDeath
        DelayEval
        NoHitDelay
        NoProjectileDelay
        StackByAttribAndKey
        StackExactPower
        IgnoreSuppressErrors
        VanishEntOnTimeout
        DoNotTintCostume
        DoNotDisplayShift
        NoTokenTime
        RevokeAll
        CopyBoosts
        CopyCreatorMods
        NoCreatorModFX
        PseudoPet
        PetVisible
        PetCommandable
    End Enum
    <Flags> Public Enum COH_EnumFlags_EffectGroup
        PVEOnly
        PVPOnly
        Fallback
    End Enum
    Public Enum COH_Enum_AttribModParamType
        ParamType_None
        ParamType_Costume
        ParamType_Reward
        ParamType_EntCreate
        ParamType_Power
        ParamType_Phase
        ParamType_Teleport
        ParamType_Behavior
        ParamType_SZEValue
        ParamType_Token
        ParamType_EffectFilter
    End Enum


End Namespace