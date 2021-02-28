Namespace CodeManagement.Enums
    <Flags> Public Enum COH_EnumFlags_AnimationSequence
        None = 0
        <COH_DefEnum("NoShallowSplash")> SEQ_NO_SHALLOW_SPLASH = (1 << 0)
        SEQ_NO_DEEP_SPLASH = (1 << 1)
        <COH_DefEnum("NoDeepSplash")> NoSplash = SEQ_NO_DEEP_SPLASH Or SEQ_NO_SHALLOW_SPLASH
        <COH_DefEnum("UseNormalTargeting")> SEQ_USE_NORMAL_TARGETING = (1 << 2)
        <COH_DefEnum("UseDynamicLibraryPiece")> SEQ_USE_DYNAMIC_LIBRARY_PIECE = (1 << 3)
        <COH_DefEnum("UseCapsuleForRangeFinding")> SEQ_USE_CAPSULE_FOR_RANGE_FINDING = (1 << 4)
        SEQ_PLAY_FX_IF_BONE_MISSING = (1 << 5)
    End Enum
    <Flags> Public Enum COH_EnumFlags_AnimationStateBits
        None = 0
        <COH_DefEnum("Predictable")> STATEBIT_PREDICTABLE = (1 << 2)
        <COH_DefEnum("Flash")> STATEBIT_FLASH = (1 << 1)
        <COH_DefEnum("Continuing")> STATEBIT_CONTINUING = (1 << 0)
        <COH_DefEnum("CodeSet")> STATEBIT_CODESET = (1 << 3) '//Cannot Set From Data File
    End Enum
    <Flags> Public Enum COH_EnumFlags_MoveSequence
        None = 0
        <COH_DefEnum("Cycle")> SEQMOVE_CYCLE = (1 << 0)
        SEQMOVE_GLOBALANIM = (1 << 1)
        <COH_DefEnum("FinishCycle")> SEQMOVE_FINISHCYCLE = (1 << 2)
        <COH_DefEnum("ReqInputs")> SEQMOVE_REQINPUTS = (1 << 3)
        SEQMOVE_COMPLEXCYCLE = (1 << 4)
        <COH_DefEnum("NoInterp")> SEQMOVE_NOINTERP = (1 << 5)
        <COH_DefEnum("HitReact")> SEQMOVE_HITREACT = (1 << 6)
        <COH_DefEnum("NoSizeScale")> SEQMOVE_NOSIZESCALE = (1 << 7)
        <COH_DefEnum("MoveScale")> SEQMOVE_MOVESCALE = (1 << 8)
        <COH_DefEnum("NotSelectable")> SEQMOVE_NOTSELECTABLE = (1 << 9)
        <COH_DefEnum("SmoothSprint")> SEQMOVE_SMOOTHSPRINT = (1 << 10)
        <COH_DefEnum("PitchToTarget")> SEQMOVE_PITCHTOTARGET = (1 << 11)
        <COH_DefEnum("PickRandomly")> SEQMOVE_PICKRANDOMLY = (1 << 12)
        <COH_DefEnum("FullSizeScale")> SEQMOVE_FULLSIZESCALE = (1 << 13) '//Default Is CAPPEDSIZESCALE, alternates are NOSIZESCALE And FULLSIZESCALE
        <COH_DefEnum("AlwaysSizeScale")> SEQMOVE_ALWAYSSIZESCALE = (1 << 14)
        <COH_DefEnum("FixArmReg")> SEQMOVE_FIXARMREG = (1 << 15)
        <COH_DefEnum("Hide")> SEQMOVE_HIDE = (1 << 16)
        <COH_DefEnum("NoCollision")> SEQMOVE_NOCOLLISION = (1 << 17)
        <COH_DefEnum("WalkThrough")> SEQMOVE_WALKTHROUGH = (1 << 18)
        <COH_DefEnum("CantMove")> SEQMOVE_CANTMOVE = (1 << 19)
        <COH_DefEnum("RunIn")> SEQMOVE_RUNIN = (1 << 20)
        SEQMOVE_PREDICTABLE = (1 << 21) ', //Calcualted only, cant be Set In text file
        <COH_DefEnum("FixHipsReg")> SEQMOVE_FIXHIPSREG = (1 << 22)
        <COH_DefEnum("DoNotDelay")> SEQMOVE_DONOTDELAY = (1 << 23) ', //Calcualted only, cant be set in text file
        <COH_DefEnum("FixWeaponReg")> SEQMOVE_FIXWEAPONREG = (1 << 24)
        <COH_DefEnum("NoDraw")> SEQMOVE_NODRAW = (1 << 25)
        SEQMOVE_COSTUMECHANGE = (1 << 26)
        <COH_DefEnum("HideWeapon")> SEQMOVE_HIDEWEAPON = (1 << 27)
        <COH_DefEnum("HideShield")> SEQMOVE_HIDESHIELD = (1 << 28)
    End Enum
    <Flags> Public Enum COH_EnumFlags_SequenceFX
        None = 0
        <COH_DefEnum("Constant")> SEQFX_CONSTANT = (1 << 0)
        Unknown1 = 16
        Unknown2 = 30
    End Enum
    Public Enum COH_Enum_WeaponStance
        <COH_DefEnum("None")> None = 0
        TAILOR_STANCE_PROFILE = (1 << 0)
        TAILOR_STANCE_HIGH = (1 << 1)
        TAILOR_STANCE_COMBAT = (1 << 2)
        TAILOR_STANCE_WEAPON = (1 << 3)
        <COH_DefEnum("Shield")> TAILOR_STANCE_SHIELD = (1 << 4)
        <COH_DefEnum("RightHand")> TAILOR_STANCE_RIGHTHAND = (1 << 5)
        <COH_DefEnum("EpicRight")> TAILOR_STANCE_EPICRIGHTHAND = (1 << 6)
        <COH_DefEnum("LeftHand")> TAILOR_STANCE_LEFTHAND = (1 << 7)
        TAILOR_STANCE_TWOHAND = (1 << 8)
        <COH_DefEnum("DualHand")> TAILOR_STANCE_DUALHAND = (1 << 9)
        <COH_DefEnum("Katana1")> TAILOR_STANCE_KATANA = (1 << 10)
        TAILOR_STANCE_GUN = (1 << 11)
        <COH_DefEnum("DualHandLarge")> TAILOR_STANCE_TWOHAND_LARGE = (1 << 12)
        <COH_DefEnum("Katana")> KATANA = TAILOR_STANCE_LEFTHAND Or TAILOR_STANCE_KATANA
        <COH_DefEnum("Rifle")> RIFLE = TAILOR_STANCE_TWOHAND Or TAILOR_STANCE_GUN
    End Enum
    <Flags> Public Enum COH_Enum_FX_Used
        <COH_DefEnum("SoundOnly")> FX_SOUND_ONLY = 1 << 0
        <COH_DefEnum("InheritAlpha")> FX_INHERIT_ALPHA = 1 << 1
        <COH_DefEnum("IsArmor")> FX_IS_ARMOR = 1 << 2 '/* no longer used */
        <COH_DefEnum("InheritAnimScale")> FX_INHERIT_ANIM_SCALE = 1 << 3
        <COH_DefEnum("DontInheritBits")> FX_DONT_INHERIT_BITS = 1 << 4
        <COH_DefEnum("DontSuppress")> FX_DONT_SUPPRESS = 1 << 5
        <COH_DefEnum("DontInheritTexFromCostume")> FX_DONT_INHERIT_TEX_FROM_COSTUME = 1 << 6
        <COH_DefEnum("UseSkinTint")> FX_USE_SKIN_TINT = 1 << 7
        <COH_DefEnum("IsShield")> FX_IS_SHIELD = 1 << 8 '// fx spawns shield geo (used in conjunction with "HideShield" Move flag
        <COH_DefEnum("IsWeapon")> FX_IS_WEAPON = 1 << 9 '// fx spawns weapon (used in conjunction with "HideWeapon" Move flag -- only need this if geo on bone other than WepR/WepL
        <COH_DefEnum("NotCompatibleWithAnimalHead")> FX_NOT_COMPATIBLE_WITH_ANIMAL_HEAD = 1 << 10 '// dont spawn this fx on character's using animal head.  Yes, this is a hack.
        <COH_DefEnum("InheritGeoScale")> FX_INHERIT_GEO_SCALE = 1 << 11 '// scale fx geo by character's "physique" scale value
        <COH_DefEnum("UseTargetSeq")> FX_USE_TARGET_SEQ = 1 << 12 '// fx updates using the target sequencer instead of the parent (for HitFX + Triggerbits)
    End Enum
    <Flags> Public Enum COH_Enum_FXEvent
        None = 0
        <COH_DefEnum("AdoptParentEntity")> FXGEO_ADOPT_PARENT_ENTITY = 1 << 0
        <COH_DefEnum("NoReticle")> FXGEO_NO_RETICLE = 1 << 1
        <COH_DefEnum("PowerLoopingSound")> FXGEO_POWER_LOOPING_SOUND = 1 << 2
        <COH_DefEnum("OneAtATime")> FXGEO_ONE_AT_A_TIME = 1 << 3
    End Enum
    <Flags> Public Enum COH_AnimCompression
        None = 0
        ROTATION_UNCOMPRESSED = (1 << 0)
        ROTATION_COMPRESSED_TO_5_BYTES = (1 << 1)
        ROTATION_COMPRESSED_TO_8_BYTES = (1 << 2)
        POSITION_UNCOMPRESSED = (1 << 3)
        POSITION_COMPRESSED_TO_6_BYTES = (1 << 4)
        ROTATION_DELTACODED = (1 << 5)
        POSITION_DELTACODED = (1 << 6)
        ROTATION_COMPRESSED_NONLINEAR = (1 << 7)
    End Enum


End Namespace