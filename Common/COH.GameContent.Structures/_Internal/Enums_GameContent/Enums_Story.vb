Namespace CodeManagement.Enums
    Public Enum COH_Enum_Genders
        <COH_DefEnum("undefined")> GENDER_UNDEFINED
        <COH_DefEnum("neuter")> GENDER_NEUTER
        <COH_DefEnum("male")> GENDER_MALE
        <COH_DefEnum("female")> GENDER_FEMALE
    End Enum
    Public Enum COH_Enum_ContactUniverse
        UNIVERSE_UNSPECIFIED
        <COH_DefEnum("Both", "Neutral")> UNIVERSE_BOTH
        <COH_DefEnum("Primal")> UNIVERSE_PRIMAL
        <COH_DefEnum("Praetorian")> UNIVERSE_PRAETORIAN
        UNIVERSE_COUNT
    End Enum
    Public Enum COH_Enum_ContactAlliance
        ALLIANCE_UNSPECIFIED
        <COH_DefEnum("Both", "Neutral")> ALLIANCE_NEUTRAL
        <COH_DefEnum("Hero")> ALLIANCE_HERO
        <COH_DefEnum("Villain")> ALLIANCE_VILLAIN
        ALLIANCE_COUNT
    End Enum
    Public Enum COH_Enum_Status
        <COH_DefEnum("undefined")> STATUS_UNDEFINED
        <COH_DefEnum("low")> STATUS_LOW
        <COH_DefEnum("medium")> STATUS_MEDIUM
        <COH_DefEnum("high")> STATUS_HIGH
    End Enum
    Public Enum COH_Enum_ContactTip
        <COH_DefEnum("None")> TIPTYPE_NONE ' Non-tip contacts have this TipType.
        <COH_DefEnum("AlignmentTip")> TIPTYPE_ALIGNMENT
        ' These tips will drop if no TIPTYPE_MORALITY tip drops during /alignment_tip_drop.
        ' Generally used for Alignment Missions, which will increase the player's alignment points when completed.
        ' These tips have a seven-length streakbreaker.
        ' A specific Alignment tip will Not drop for you if it has dropped in the previous seven Alignment tip drops.
        ' You are only allowed to hold three Alignment And Morality tips at once.
        <COH_DefEnum("MoralityTip")> TIPTYPE_MORALITY
        ' These tips are prioritized to drop over Alignment tips during /alignment_tip_drop.
        ' Generally used for Morality Missions, which will change the alignment of the player when completed.
        ' You are only allowed to hold three Alignment And Morality tips at once.
        TIPTYPE_GRSYSTEM_MAX
        ' This Is a reference value to denote the end of the tips that are dropped
        ' through the standard /alignment_tip_drop method.
        ' No contact should have this value.
        <COH_DefEnum("Special")> TIPTYPE_SPECIAL
        ' This type goes in the tip window, but at the end of the list.
        ' Also, all tips of this type will be dropped whenever /alignment_tip_drop occurs.
        ' These tips do Not count as the "one tip" to be dropped.
        ' InteractionRequires And player level ranges still apply for when they are dropped,
        ' but these tips are never revoked, even if you no longer meet those requirements.
        TIPTYPE_STANDARD_COUNT ' No contact should have this value.
    End Enum
    Public Enum COH_Enum_StoryArcAlliance
        <COH_DefEnum("Both")> SA_ALLIANCE_BOTH
        <COH_DefEnum("Hero")> SA_ALLIANCE_HERO
        <COH_DefEnum("Villain")> SA_ALLIANCE_VILLAIN
    End Enum
    <Flags> Public Enum COH_Enum_StoryArcFlag
        None = 0
        <COH_DefEnum("Deprecated")> STORYARC_DEPRECATED = 1
        <COH_DefEnum("MiniStoryarc")> STORYARC_MINI = (1 << 1)
        <COH_DefEnum("Repeatable")> STORYARC_REPEATABLE = (1 << 2)
        STORYARC_FLASHBACK = (1 << 3)
        <COH_DefEnum("NoFlashback")> STORYARC_NOFLASHBACK = (1 << 4) '// This story arc cannot be used as a flashback
        <COH_DefEnum("ScalableTf")> STORYARC_SCALABLE_TF = (1 << 5) '// AV and boss reduction even on a taskforce
        <COH_DefEnum("FlashbackOnly")> STORYARC_FLASHBACK_ONLY = (1 << 6) '// This story arc is only available in flashback
    End Enum
    <Flags> Public Enum COH_Enum_RewardsSetFlags
        None = 0
        <COH_DefEnum("always")> RSF_ALWAYS = (1 << 0)
        <COH_DefEnum("everyone")> RSF_EVERYONE = (1 << 1) ' // Give To everyone, Not just the lucky team And person.
        <COH_DefEnum("nolimit")> RSF_NOLIMIT = (1 << 2) ' // Ignore inventory limits (currently only meaningful On salvage And recipes) -Garth 1/3/7
        <COH_DefEnum("forced")> RSF_FORCED = (1 << 3) ', // Always granted, even if exemplared or side-kicked or not the proper level.
    End Enum
    Public Enum COH_Enum_AddRemovePower
        <COH_DefEnum("Power")> Power = 0
        <COH_DefEnum("Add")> Add = 0
        <COH_DefEnum("RemovePower")> RemovePower = 1
        <COH_DefEnum("Remove")> Remove = 1
    End Enum
    Public Enum COH_Enum_VillainPacingEnum
        <COH_DefEnum("Unmodifiable")> PACING_UNMODIFIABLE
        <COH_DefEnum("Flat")> PACING_FLAT
        <COH_DefEnum("SlowRampUp")> PACING_SLOWRAMPUP
        <COH_DefEnum("SlowRampDown")> PACING_SLOWRAMPDOWN
        <COH_DefEnum("Staggered")> PACING_STAGGERED
        <COH_DefEnum("FrontLoaded")> PACING_FRONTLOADED
        <COH_DefEnum("BackLoaded")> PACING_BACKLOADED
        <COH_DefEnum("HighNotoriety")> PACING_HIGHNOTORIETY
        NUM_PACING_TYPES
    End Enum
    <Flags> Public Enum COH_Enum_MissionFlags
        None = 0
        <COH_DefEnum("NoTeleportOnComplete")> MISSION_NOTELEPORTONCOMPLETE = 1
        <COH_DefEnum("NoBaseHospital")> MISSION_NOBASEHOSPITAL = (1 << 1)
        <COH_DefEnum("CoedTeamsAllowed")> MISSION_COEDTEAMSALLOWED = (1 << 2)
        <COH_DefEnum("PraetorianTutorial")> MISSION_PRAETORIAN_TUTORIAL = (1 << 3)
        <COH_DefEnum("CoUniverseTeamsAllowed")> MISSION_COUNIVERSETEAMSALLOWED = (1 << 4)
    End Enum
    <Flags> Public Enum COH_Enum_SpawnFlags
        <COH_DefEnum("AllowAddingActors")> SPAWNDEF_ALLOWADDS = (1 << 0)    '// allow adding generic actors (Nictus hunters, etc.)
        <COH_DefEnum("IgnoreRadius")> SPAWNDEF_IGNORE_RADIUS = (1 << 1) '// ignore radius checks and be ignored in radius checks
        <COH_DefEnum("AutoStart")> SPAWNDEF_AUTOSTART = (1 << 2)    '// Start this encounter as soon as the map is loaded.
        <COH_DefEnum("MissionRespawn")> SPAWNDEF_MISSIONRESPAWN = (1 << 3)    '// Respawn this encounter on mission maps
        <COH_DefEnum("CloneGroup")> SPAWNDEF_CLONEGROUP = (1 << 4)   '// Clone this encounter when allocated on mission maps
        <COH_DefEnum("NeighborhoodDefined")> SPAWNDEF_NEIGHBORHOODDEFINED = (1 << 5)    '// try to obtain min/max level and teamsize from the neighborhood this spawn is placed in
    End Enum
    <Flags> Public Enum COH_Enum_ActorFlags
        None = 0
        <COH_DefEnum("AlwaysCon")> ACTOR_ALWAYSCON = (1 << 0)   '// turn on alwaysCon bit
        <COH_DefEnum("SeeThroughWalls")> ACTOR_SEETHROUGHWALLS = (1 << 1)   '// turn on seeThroughWalls bit
        <COH_DefEnum("Invisible")> ACTOR_INVISIBLE = (1 << 2)   '// create with invisible bit set
    End Enum
    Public Enum COH_Enum_ActorType
        <COH_DefEnum("eVillain")> ACTOR_VILLAIN
        <COH_DefEnum("eNPC")> ACTOR_NPC
    End Enum
    Public Enum COH_Enum_ConColor
        <COH_DefEnum("Red")> CONCOLOR_RED
        <COH_DefEnum("Yellow")> CONCOLOR_YELLOW
    End Enum
    Public Enum COH_Enum_EncounterAlliance
        <COH_DefEnum("Default")> ENC_UNINIT
        <COH_DefEnum("Hero")> ENC_FOR_HERO
        <COH_DefEnum("Villain")> ENC_FOR_VILLAIN
    End Enum
    Public Enum COH_Enum_TeamOverride
        <COH_DefEnum("None")> MO_NONE
        <COH_DefEnum("Player")> MO_PLAYER
        <COH_DefEnum("Mission")> MO_MISSION
    End Enum
    <Flags> Public Enum COH_Enum_DialogPage_ListFlags
        None = 0
        <COH_DefEnum("Random")> DIALOGPAGELIST_RANDOM = (1 << 0)
        <COH_DefEnum("InOrder")> DIALOGPAGELIST_INORDER = (1 << 1)
    End Enum
    <Flags> Public Enum COH_Enum_DialogPage_Flags
        None = 0
        <COH_DefEnum("CompleteDeliveryTask")> DIALOGPAGE_COMPLETEDELIVERYTASK = (1 << 0)
        <COH_DefEnum("CompleteAnyTask")> DIALOGPAGE_COMPLETEANYTASK = (1 << 1)
        <COH_DefEnum("AutoClose")> DIALOGPAGE_AUTOCLOSE = (1 << 2) '// Effects are processed but page Is never shown.
        <COH_DefEnum("NoHeadshot")> DIALOGPAGE_NOHEADSHOT = (1 << 3) '// Don 't display the default headshot.
    End Enum
    <Flags> Public Enum COH_Enum_CutSceneFlags
        None = 0
        <COH_DefEnum("OnEncounterCreate")> CUTSCENE_ONENCOUNTERCREATE = (1 << 0)
        <COH_DefEnum("FreezeMapServer")> CUTSCENE_FREEZEMAPSERVER = (1 << 1)
        CUTSCENE_FROMSTRING = (1 << 2)
    End Enum
    Public Enum COH_Enum_DayNightCycle
        <COH_DefEnum("Normal")> DAYNIGHT_NORMAL
        <COH_DefEnum("AlwaysNight")> DAYNIGHT_ALWAYSNIGHT
        <COH_DefEnum("AlwaysDay")> DAYNIGHT_ALWAYSDAY
        <COH_DefEnum("FastCycle")> DAYNIGHT_FAST
    End Enum
    Public Enum COH_Enum_InteractOutcome
        <COH_DefEnum("None")> MIO_NONE
        <COH_DefEnum("Remove")> MIO_REMOVE
    End Enum
    <Flags> Public Enum COH_Enum_ObjectiveFlags
        None = 0
        <COH_DefEnum("ShowWaypoint")> MISSIONOBJECTIVE_SHOWWAYPOINT = 1
        <COH_DefEnum("RewardOnCompleteSet")> MISSIONOBJECTIVE_REWARDONCOMPLETESET = 1 << 1
    End Enum
    Public Enum COH_Enum_LocationType
        <COH_DefEnum("Person")> LOCATION_PERSON
        <COH_DefEnum("ItemAgainstWall", "ItemWall")> LOCATION_ITEMWALL
        <COH_DefEnum("ItemOnFloor", "ItemFloor")> LOCATION_ITEMFLOOR
        <COH_DefEnum("ItemOnRoof", "ItemRoof")> LOCATION_ITEMROOF
        <COH_DefEnum("Item", New String() {"HiddenItem", "WallItem", "HiddenWallItem", "Hidden", "ItemHidden", "Obvious", "ItemObvious"})> LOCATION_LEGACY
        LOCATION_TROPHY     '// For supergroup raids
    End Enum
    <Flags> Public Enum COH_Enum_TaskFlags
        <COH_DefEnum("NONE", New String() {"taskNotRequired", "taskNotRepeatable", "taskNotUrgent", "taskNotUnique"})> None = 0
        <COH_DefEnum("taskRequired")> TASK_REQUIRED = 1
        <COH_DefEnum("taskLong")> TASK_LONG = (1 << 1)
        <COH_DefEnum("taskShort")> TASK_SHORT = (1 << 2)
        <COH_DefEnum("taskRepeatable", New String() {"taskRepeatOnFailure"})> TASK_REPEATONFAILURE = (1 << 3)
        <COH_DefEnum("taskRepeatOnSuccess")> TASK_REPEATONSUCCESS = (1 << 4)
        <COH_DefEnum("taskUrgent")> TASK_URGENT = (1 << 5)  '// urgent tasks will be given out before non-urgent ones
        <COH_DefEnum("taskUnique")> TASK_UNIQUE = (1 << 6)  '// unique tasks will not be reissued, even across contact sets
        <COH_DefEnum("taskDontReturnToContact")> TASK_DONTRETURNTOCONTACT = (1 << 7)
        <COH_DefEnum("taskHeist")> TASK_HEIST = (1 << 8)
        <COH_DefEnum("taskNoTeamComplete")> TASK_NOTEAMCOMPLETE = (1 << 9)
        TASK_SUPERGROUP = (1 << 10)
        <COH_DefEnum("taskEnforceTimeLimit")> TASK_ENFORCETIMELIMIT = (1 << 11) '// Task will still boot you from a mission even When completed
        <COH_DefEnum("taskDelayedTimerStart")> TASK_DELAYEDTIMERSTART = (1 << 12) '// Task timer does Not start until entering the mission
        <COH_DefEnum("taskNoAutoComplete", "taskNoAbort")> TASK_NOAUTOCOMPLETE = (1 << 13)   '// Task cannot be automatically completed
        <COH_DefEnum("taskFlashback")> TASK_FLASHBACK = (1 << 14)   '// Task shows up in flashback list
        <COH_DefEnum("taskFlashbackOnly")> TASK_FLASHBACK_ONLY = (1 << 15) '// Task Is Not granted by normal contacts
        <COH_DefEnum("taskPlayerCreated")> TASK_PLAYERCREATED = (1 << 16)  '// Task is not granted by normal contacts
        <COH_DefEnum("taskAbandonable")> TASK_ABANDONABLE = (1 << 17) '// Deprecated
        <COH_DefEnum("taskNotAbandonable")> TASK_NOT_ABANDONABLE = (1 << 18) '// Task can be abandoned And picked up again later
        <COH_DefEnum("taskAutoIssue")> TASK_AUTO_ISSUE = (1 << 19)
        <COH_DefEnum("taskSupergroup")> TASKSUPERGROUP = TASK_SUPERGROUP Or TASK_DONTRETURNTOCONTACT
    End Enum
    Public Enum COH_Enum_Deliverymethod
        DELIVERYMETHOD_NOTYPE = 0
        <COH_DefEnum("Any")> DELIVERYMETHOD_ANY
        <COH_DefEnum("CellOnly")> DELIVERYMETHOD_CELLONLY
        <COH_DefEnum("InPersonOnly")> DELIVERYMETHOD_INPERSONONLY
        DELIVERYMETHOD_COUNT
    End Enum
    <Flags> Public Enum COH_Enum_TokenFlags
        None = 0
        TOKEN_FLAG_RESET_AT_START = 1
    End Enum
    Public Enum COH_Enum_TaskType
        TASK_NOTYPE = 0
        <COH_DefEnum("taskMission")> TASK_MISSION
        <COH_DefEnum("taskRandomEncounter")> TASK_RANDOMENCOUNTER
        <COH_DefEnum("taskRandomNPC")> TASK_RANDOMNPC
        <COH_DefEnum("taskKillX")> TASK_KILLX
        <COH_DefEnum("taskDeliverItem")> TASK_DELIVERITEM
        <COH_DefEnum("taskVisitLocation")> TASK_VISITLOCATION ' // Poorly named, more like "click on stuff".  Similar to zowie task
        <COH_DefEnum("taskCraftInvention")> TASK_CRAFTINVENTION
        <COH_DefEnum("taskCompound")> TASK_COMPOUND
        <COH_DefEnum("taskContactIntroduction")> TASK_CONTACTINTRO
        <COH_DefEnum("taskTokenCount")> TASK_TOKENCOUNT
        <COH_DefEnum("taskZowie")> TASK_ZOWIE
        <COH_DefEnum("taskGoToVolume")> TASK_GOTOVOLUME '// go to places and enter volumes
    End Enum
    Public Enum COH_Enum_SoundChannel
        <COH_DefEnum("Music")> SOUND_MUSIC = 100000
        SOUND_GAME
        SOUND_PLAYER
        SOUND_VOICEOVER
        SOUND_AMBIENT
        SOUND_AMBIENT_SPHERE_BASE = SOUND_AMBIENT
        SOUND_AMBIENT_SCRIPT_BASE = SOUND_AMBIENT_SPHERE_BASE + 64
        SOUND_UI_REPEATING
        SOUND_UI_REPEATING_SCROLL
        SOUND_UI_ALTERNATE

        <COH_DefEnum("SFX")> SFX = SOUND_GAME
        <COH_DefEnum("Voiceover")> VoiceOver = SOUND_VOICEOVER
        SOUND_FX_BASE = 1000
        SOUND_FX_LAST = 90000
        SOUND_ZOWIE_BASE = SOUND_FX_LAST
    End Enum
End Namespace