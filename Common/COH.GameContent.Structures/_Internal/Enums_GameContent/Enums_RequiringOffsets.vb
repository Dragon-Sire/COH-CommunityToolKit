﻿Namespace CodeManagement.Enums
    Public Enum COH_Enum_Aspect '//THIS RELIES ON OFFSET
        <COH_DefEnum("kCurrent")> kCurrent = 0 '//Values Yes, Order Not Confirmed
        <COH_DefEnum("kMaximum")> kMaximum = 4
        <COH_DefEnum("kStrength")> kStrength = 8
        <COH_DefEnum("kResistance")> kResistance = 12
        <COH_DefEnum("kAbsolute")> kAbsolut = 16
        <COH_DefEnum("kCurrentAbsolute")> kCurrentAbsolute = 16
        <COH_DefEnum("kCur")> kCur = 0
        <COH_DefEnum("kMax")> kMax = 4
        <COH_DefEnum("kStr")> kStr = 8
        <COH_DefEnum("kRes")> kRes = 12
        <COH_DefEnum("kAbs")> kAbs = 16
        <COH_DefEnum("kCurAbs")> kCurAbs = 16
    End Enum
    Public Enum COH_Enum_Origin
        <COH_DefEnum("Science")> kScience = 0
        <COH_DefEnum("Mutation")> kMutation = 1
        <COH_DefEnum("Magic")> kMagic = 2
        <COH_DefEnum("Technology")> kTechnology = 3
        <COH_DefEnum("Natural")> kNatural = 4
    End Enum
    Public Enum COH_Enum_Attrib_OriginBoosts
        <COH_DefEnum("Science")> kScience_Boost = 0
        <COH_DefEnum("Mutation")> kMutation_Boost = 1
        <COH_DefEnum("Magic")> kMagic_Boost = 2
        <COH_DefEnum("Technology")> kTechnology_Boost = 3
        <COH_DefEnum("Natural")> kNatural_Boost = 4
        '//Attributes
        <COH_DefEnum("Accuracy Boost")> kAccuracy_Boost = 5
        <COH_DefEnum("Buff Defense Boost")> kBuff_Defense_Boost = 6
        <COH_DefEnum("Buff ToHit Boost")> kBuff_ToHit_Boost = 7
        <COH_DefEnum("Confuse Boost")> kConfuse_Boost = 8
        <COH_DefEnum("Damage Boost")> kDamage_Boost = 9
        <COH_DefEnum("Debuff Defense Boost")> kDebuff_Defense_Boost = 10
        <COH_DefEnum("Debuff ToHit Boost")> kDebuff_ToHit_Boost = 11
        <COH_DefEnum("Fear Boost")> kFear_Boost = 12
        <COH_DefEnum("SpeedFlying Boost")> kSpeedFlying_Boost = 13
        <COH_DefEnum("Heal Boost")> kHeal_Boost = 14
        <COH_DefEnum("Immobilized Boost")> kImmobilized_Boost = 15
        <COH_DefEnum("Jump Boost")> kJump_Boost = 16
        <COH_DefEnum("Knockback Boost")> kKnockback_Boost = 17
        <COH_DefEnum("Recharge Boost")> kRecharge_Boost = 18
        <COH_DefEnum("SpeedRunning Boost")> kSpeedRunning_Boost = 19
        <COH_DefEnum("Sleep Boost")> kSleep_Boost = 20
        <COH_DefEnum("Stunned Boost")> kStunned_Boost = 21
        <COH_DefEnum("Range Boost")> kRange_Boost = 22
        <COH_DefEnum("EnduranceDiscount Boost")> kEnduranceDiscount_Boost = 23
        <COH_DefEnum("Buff Damage Boost")> kBuff_Damage_Boost = 24
        <COH_DefEnum("Debuff Damage Boost")> kDebuff_Damage_Boost = 25
        <COH_DefEnum("Radius Boost")> kRadius_Boost = 26
        <COH_DefEnum("Cone Boost")> kCone_Boost = 27
        <COH_DefEnum("Taunt Boost")> kTaunt_Boost = 28
        <COH_DefEnum("Slow Boost")> kSlow_Boost = 29
        <COH_DefEnum("Hold Boost")> kHold_Boost = 30
        <COH_DefEnum("Intangible Boost")> kIntangible_Boost = 31
        <COH_DefEnum("Interrupt Boost")> kInterrupt_Boost = 32
        <COH_DefEnum("Recovery Boost")> kRecovery_Boost = 33
        <COH_DefEnum("Endurance Drain Boost")> kEndurance_Drain_Boost = 34
        <COH_DefEnum("Res Damage Boost")> kRes_Damage_Boost = 35
        <COH_DefEnum("Hamidon Boost")> kHamidon_Boost = 36
        <COH_DefEnum("Incarnate Judgement Boost")> kIncarnate_Judgement_Boost = 37
        <COH_DefEnum("Incarnate Interface Boost")> kIncarnate_Interface_Boost = 38
        <COH_DefEnum("Incarnate Lore Boost")> kIncarnate_Lore_Boost = 39
        <COH_DefEnum("Incarnate Destiny Boost")> kIncarnate_Destiny_Boost = 40
    End Enum
    Public Enum COH_Enum_Attrib_Modes
        <COH_DefEnum("ServerTrayOverride")> kServerTrayOverride = 0
        <COH_DefEnum("Peacebringer Blaster Mode")> kPeacebringer_Blaster_Mode = 1
        <COH_DefEnum("Peacebringer Tanker Mode")> kPeacebringer_Tanker_Mode = 2
        <COH_DefEnum("Peacebringer Light Mode")> kPeacebringer_Light_Mode = 3
        <COH_DefEnum("Warshade Blaster Mode")> kWarshade_Blaster_Mode = 4
        <COH_DefEnum("Warshade Tanker Mode")> kWarshade_Tanker_Mode = 5
        <COH_DefEnum("Shivan Mode")> kShivan_Mode = 6
        <COH_DefEnum("Disable Travel")> kDisable_Travel = 7
        <COH_DefEnum("Disable Pool")> kDisable_Pool = 8
        <COH_DefEnum("Disable Temp")> kDisable_Temp = 9
        <COH_DefEnum("Disable Teleport")> kDisable_Teleport = 10
        <COH_DefEnum("Disable Portals")> kDisable_Portals = 11
        <COH_DefEnum("Disable All")> kDisable_All = 12
        <COH_DefEnum("Disable Inspiration")> kDisable_Inspiration = 13
        <COH_DefEnum("Disable Inspiration Small")> kDisable_Inspiration_Small = 14
        <COH_DefEnum("Disable Inspiration Medium")> kDisable_Inspiration_Medium = 15
        <COH_DefEnum("Disable Inspiration Large")> kDisable_Inspiration_Large = 16
        <COH_DefEnum("Disable Inspiration Special")> kDisable_Inspiration_Special = 17
        <COH_DefEnum("Disable SetBonus")> kDisable_SetBonus = 18
        <COH_DefEnum("Disable Recall")> kDisable_Recall = 19
        <COH_DefEnum("Disable Walk")> kDisable_Walk = 20
        <COH_DefEnum("Disable Suicide")> kDisable_Suicide = 21
        <COH_DefEnum("Disable RocketBoard")> kDisable_RocketBoard = 22
        <COH_DefEnum("Disable FlyingCarpet")> kDisable_FlyingCarpet = 23
        <COH_DefEnum("Disable VoidSkiff")> kDisable_VoidSkiff = 24
        <COH_DefEnum("Arena")> kArena = 25
        <COH_DefEnum("Disable Awaken")> kDisable_Awaken = 26
        <COH_DefEnum("Disable Toggle")> kDisable_Toggle = 27
        <COH_DefEnum("Mastermind Upgrade 1")> kMastermind_Upgrade_1 = 28
        <COH_DefEnum("Mastermind Upgrade 2")> kMastermind_Upgrade_2 = 29
        <COH_DefEnum("Domination")> kDomination = 30
        <COH_DefEnum("Domination Active")> kDomination_Active = 31
        <COH_DefEnum("Vengeance Mode")> kVengeance_Mode = 32
        <COH_DefEnum("Proc Mode")> kProc_Mode = 33
        <COH_DefEnum("No Shopping")> kNo_Shopping = 34
        <COH_DefEnum("Disable Epic")> kDisable_Epic = 35
        <COH_DefEnum("Raid Defender Mode")> kRaid_Defender_Mode = 36
        <COH_DefEnum("Raid Attacker Mode")> kRaid_Attacker_Mode = 37
        <COH_DefEnum("Range Finder Mode")> kRange_Finder_Mode = 38
        <COH_DefEnum("Temporal Disruption")> kTemporal_Disruption = 39
        <COH_DefEnum("DD StatusMode 1")> kDD_StatusMode_1 = 40
        <COH_DefEnum("DD StatusMode 2")> kDD_StatusMode_2 = 41
        <COH_DefEnum("DD DebuffMode 1")> kDD_DebuffMode_1 = 42
        <COH_DefEnum("DD DebuffMode 2")> kDD_DebuffMode_2 = 43
        <COH_DefEnum("DD BonusAoEMode 1")> kDD_BonusAoEMode_1 = 44
        <COH_DefEnum("DD BonusAoEMode 2")> kDD_BonusAoEMode_2 = 45
        <COH_DefEnum("DD BonusDoTMode 1")> kDD_BonusDoTMode_1 = 46
        <COH_DefEnum("DD BonusDoTMode 2")> kDD_BonusDoTMode_2 = 47
        <COH_DefEnum("KillTK")> kKillTK = 48
        <COH_DefEnum("Defiant")> kDefiant = 49
        <COH_DefEnum("LostCure")> kLostCure = 50
        <COH_DefEnum("Midnight Disguise")> kMidnight_Disguise = 51
        <COH_DefEnum("Chain Induction")> kChain_Induction = 52
        <COH_DefEnum("Chain Stun Mode")> kChain_Stun_Mode = 53
        <COH_DefEnum("Chain Jolt Mode")> kChain_Jolt_Mode = 54
        <COH_DefEnum("Chain Confuse Mode")> kChain_Confuse_Mode = 55
        <COH_DefEnum("Sequestor 1")> kSequestor_1 = 56
        <COH_DefEnum("Sequestor 2")> kSequestor_2 = 57
        <COH_DefEnum("Sequestor 3")> kSequestor_3 = 58
        <COH_DefEnum("NoNukes")> kNoNukes = 59
        <COH_DefEnum("HAC Offense")> kHAC_Offense = 60
        <COH_DefEnum("HAC Defense")> kHAC_Defense = 61
        <COH_DefEnum("Disable Juggernaut")> kDisable_Juggernaut = 62
        <COH_DefEnum("Tower Protection")> kTower_Protection = 63
        <COH_DefEnum("Panacea")> kPanacea = 64
        <COH_DefEnum("Grounded")> kGrounded = 65
        <COH_DefEnum("LethalAmmo")> kLethalAmmo = 66
        <COH_DefEnum("IceAmmo")> kIceAmmo = 67
        <COH_DefEnum("FireAmmo")> kFireAmmo = 68
        <COH_DefEnum("ToxicAmmo")> kToxicAmmo = 69
        <COH_DefEnum("ArchitectMissionMode")> kArchitectMissionMode = 70
        <COH_DefEnum("CoOpTeam")> kCoOpTeam = 71
        <COH_DefEnum("Broken")> kBroken = 72
        <COH_DefEnum("DisableFortuneBuffs")> kDisableFortuneBuffs = 73
        <COH_DefEnum("InCostume")> kInCostume = 74
        <COH_DefEnum("Wintery Aegis")> kWintery_Aegis = 75
        <COH_DefEnum("RoidedIDF")> kRoidedIDF = 76
        <COH_DefEnum("Harmonic Destabilizer")> kHarmonic_Destabilizer = 77
        <COH_DefEnum("Hidden Attack")> kHidden_Attack = 78
        <COH_DefEnum("SiphonMode")> kSiphonMode = 79
        <COH_DefEnum("TurretStage1")> kTurretStage1 = 80
        <COH_DefEnum("TurretStage2")> kTurretStage2 = 81
        <COH_DefEnum("TurretStage3")> kTurretStage3 = 82
        <COH_DefEnum("TurretStage4")> kTurretStage4 = 83
        <COH_DefEnum("TurretStage5")> kTurretStage5 = 84
        <COH_DefEnum("Defeated OilSlick")> kDefeated_OilSlick = 85
        <COH_DefEnum("MarkedForDeath")> kMarkedForDeath = 86
        <COH_DefEnum("Enraged")> kEnraged = 87
        <COH_DefEnum("TargetingReticule")> kTargetingReticule = 88
        <COH_DefEnum("NotInCombat")> kNotInCombat = 89
        <COH_DefEnum("UltimateInspire")> kUltimateInspire = 90
        <COH_DefEnum("FastMode")> kFastMode = 91
        <COH_DefEnum("Infected 01")> kInfected_01 = 92
        <COH_DefEnum("Infected 02")> kInfected_02 = 93
        <COH_DefEnum("Infected 03")> kInfected_03 = 94
        <COH_DefEnum("Incarnate Equipped")> kIncarnate_Equipped = 95
        <COH_DefEnum("OnePowerCell")> kOnePowerCell = 96
        <COH_DefEnum("TwoPowerCell")> kTwoPowerCell = 97
        <COH_DefEnum("ThreePowerCell")> kThreePowerCell = 98
        <COH_DefEnum("EntangledA")> kEntangledA = 99
        <COH_DefEnum("EntangledB")> kEntangledB = 100
        <COH_DefEnum("HunterMode")> kHunterMode = 101
        <COH_DefEnum("ProwlerMode")> kProwlerMode = 102
        <COH_DefEnum("ProwlerCloakMode")> kProwlerCloakMode = 103
        <COH_DefEnum("HybridLockout")> kHybridLockout = 104
        <COH_DefEnum("RestedAdaptation")> kRestedAdaptation = 105
        <COH_DefEnum("DefensiveAdaptation")> kDefensiveAdaptation = 106
        <COH_DefEnum("OffensiveAdaptation")> kOffensiveAdaptation = 107
        <COH_DefEnum("ClearSkies")> kClearSkies = 108
        <COH_DefEnum("CloudedSkies")> kCloudedSkies = 109
        <COH_DefEnum("SpeedofSoundOn")> kSpeedofSoundOn = 110
        <COH_DefEnum("MightyLeapOn")> kMightyLeapOn = 111
        <COH_DefEnum("JetpackOn")> kJetpackOn = 112
        <COH_DefEnum("MysticFlightOn")> kMysticFlightOn = 113
        <COH_DefEnum("FreeRunningOn")> kFreeRunningOn = 114
    End Enum
    Public Enum COH_Enum_Attrib_Group
        <COH_DefEnum("Flying Group")> kFlying_Group = 0
        <COH_DefEnum("Speed Group")> kSpeed_Group = 1
        <COH_DefEnum("Sprint Group")> kSprint_Group = 2
        <COH_DefEnum("Leap Group")> kLeap_Group = 3
        <COH_DefEnum("FlyingRoot Group")> kFlyingRoot_Group = 4
        <COH_DefEnum("SpeedRoot Group")> kSpeedRoot_Group = 5
        <COH_DefEnum("SprintRoot Group")> kSprintRoot_Group = 6
        <COH_DefEnum("LeapRoot Group")> kLeapRoot_Group = 7
        <COH_DefEnum("Rock Armor Group")> kRock_Armor_Group = 8
        <COH_DefEnum("Brimstone Armor Group")> kBrimstone_Armor_Group = 9
        <COH_DefEnum("Crystal Armor Group")> kCrystal_Armor_Group = 10
        <COH_DefEnum("Mineral Armor Group")> kMineral_Armor_Group = 11
        <COH_DefEnum("Stealth Group")> kStealth_Group = 12
        <COH_DefEnum("Hide Group")> kHide_Group = 13
        <COH_DefEnum("Rest Group")> kRest_Group = 14
        <COH_DefEnum("Kheldian Group")> kKheldian_Group = 15
        <COH_DefEnum("Ascendant Group")> kAscendant_Group = 16
        <COH_DefEnum("Darkness Group")> kDarkness_Group = 17
        <COH_DefEnum("Ammo Group")> kAmmo_Group = 18
        <COH_DefEnum("HAC Group")> kHAC_Group = 19
        <COH_DefEnum("VanityPet Group",)> kVanityPet_Group = 20
        <COH_DefEnum("CombatPet Group")> kCombatPet_Group = 21
        <COH_DefEnum("Primalist Group")> kPrimalist_Group = 22
        <COH_DefEnum("Bio Group")> kBio_Group = 23
        <COH_DefEnum("CombatPet Group")> kCombatPet_Group2 = 24
    End Enum
    Public Enum COH_Enum_Attrib_Stack
        <COH_DefEnum("TestStack")> kTestStack = 0
        <COH_DefEnum("HybridSupport")> kHybridSupport = 1
        <COH_DefEnum("HybridDefense")> kHybridDefense = 2
        <COH_DefEnum("RecoveryBuff")> kRecoveryBuff = 3
        <COH_DefEnum("EnduranceCostBuff")> kEnduranceCostBuff = 4
        <COH_DefEnum("KineticAssaultImpulse")> kKineticAssaultImpulse = 5
    End Enum
    Public Enum COH_Enum_Attrib_SpecialAttrib '//ppAttribNames; /4
        kSpecialAttrib_Translucency = CharacterAttributesSize ''//= sizeof(CharacterAttributes), WHICH IS 460?
        kSpecialAttrib_EntCreate = CharacterAttributesSize + 1
        kSpecialAttrib_ClearDamagers = CharacterAttributesSize + 2
        kSpecialAttrib_SilentKill = CharacterAttributesSize + 3
        kSpecialAttrib_XPDebtProtection = CharacterAttributesSize + 4
        kSpecialAttrib_SetMode = CharacterAttributesSize + 5
        kSpecialAttrib_SetCostume = CharacterAttributesSize + 6
        kSpecialAttrib_Glide = CharacterAttributesSize + 7
        kSpecialAttrib_Null = CharacterAttributesSize + 8
        kSpecialAttrib_Avoid = CharacterAttributesSize + 9
        kSpecialAttrib_Reward = CharacterAttributesSize + 10
        kSpecialAttrib_XPDebt = CharacterAttributesSize + 11
        kSpecialAttrib_DropToggles = CharacterAttributesSize + 12
        kSpecialAttrib_GrantPower = CharacterAttributesSize + 13
        kSpecialAttrib_RevokePower = CharacterAttributesSize + 14
        kSpecialAttrib_UnsetMode = CharacterAttributesSize + 15
        kSpecialAttrib_GlobalChanceMod = CharacterAttributesSize + 16
        kSpecialAttrib_PowerChanceMod = CharacterAttributesSize + 17
        kSpecialAttrib_GrantBoostedPower = CharacterAttributesSize + 18
        kSpecialAttrib_ViewAttrib = CharacterAttributesSize + 19
        kSpecialAttrib_RewardSource = CharacterAttributesSize + 20
        kSpecialAttrib_RewardSourceTeam = CharacterAttributesSize + 21
        kSpecialAttrib_ClearFog = CharacterAttributesSize + 22
        kSpecialAttrib_CombatPhase = CharacterAttributesSize + 23
        kSpecialAttrib_CombatModShift = CharacterAttributesSize + 24
        kSpecialAttrib_RechargePower = CharacterAttributesSize + 25
        kSpecialAttrib_VisionPhase = CharacterAttributesSize + 26
        kSpecialAttrib_NinjaRun = CharacterAttributesSize + 27
        kSpecialAttrib_Walk = CharacterAttributesSize + 28
        kSpecialAttrib_BeastRun = CharacterAttributesSize + 29
        kSpecialAttrib_SteamJump = CharacterAttributesSize + 30
        kSpecialAttrib_DesignerStatus = CharacterAttributesSize + 31
        kSpecialAttrib_ExclusiveVisionPhase = CharacterAttributesSize + 32
        kSpecialAttrib_HoverBoard = CharacterAttributesSize + 33
        kSpecialAttrib_SetSZEValue = CharacterAttributesSize + 34
        kSpecialAttrib_AddBehavior = CharacterAttributesSize + 35
        kSpecialAttrib_PowerRedirect = CharacterAttributesSize + 36
        kSpecialAttrib_MagicCarpet = CharacterAttributesSize + 37
        kSpecialAttrib_TokenAdd = CharacterAttributesSize + 38
        kSpecialAttrib_TokenSet = CharacterAttributesSize + 39
        kSpecialAttrib_TokenClear = CharacterAttributesSize + 40
        kSpecialAttrib_LuaExec = CharacterAttributesSize + 41
        kSpecialAttrib_ForceMove = CharacterAttributesSize + 42
        kSpecialAttrib_ParkourRun = CharacterAttributesSize + 43
    End Enum
    Public Enum COH_Enum_Attrib_Character ' Add k to front of all these
        <COH_DefEnum("Smashing")> kSmashing = 0                                     'kDamageType00
        <COH_DefEnum("Lethal")> kLethal = 4                                         'kDamageType01
        <COH_DefEnum("Fire")> kFire = 8                                             'kDamageType02
        <COH_DefEnum("Cold")> kCold = 12                                            'kDamageType03
        <COH_DefEnum("Energy")> kEnergy = 16                                        'kDamageType04
        <COH_DefEnum("Negative Energy")> kNegative_Energy = 20                      'kDamageType05
        <COH_DefEnum("Psionic")> kPsionic = 24                                      'kDamageType06
        <COH_DefEnum("Heal")> kHeal = 28                                            'kDamageType07
        <COH_DefEnum("Special")> kSpecial = 32                                      'kDamageType08
        <COH_DefEnum("Toxic")> kToxic = 36                                          'kDamageType09
        <COH_DefEnum("Radiation")> kRadiation = 40                                  'kDamageType10
        <COH_DefEnum("Electrical")> kElectrical = 44                                'kDamageType11
        <COH_DefEnum("Unique1")> kUnique1 = 48                                      'kDamageType12
        <COH_DefEnum("Unique2")> kUnique2 = 52                                      'kDamageType13
        <COH_DefEnum("Unique3")> kUnique3 = 56                                      'kDamageType14
        kDamageType15 = 60
        kDamageType16 = 64
        kDamageType17 = 68
        kDamageType18 = 72
        kDamageType19 = 76
        kHitPoints = 80
        kEndurance = 84
        kInsight = 88
        '//REDUNDENT - Idea
        kRage = 92
        kToHit = 96
        <COH_DefEnum("Ranged Attack")> kRanged_Attack = 100                         'kDefenseType00
        <COH_DefEnum("Melee Attack")> kMelee_Attack = 104                           'kDefenseType01
        <COH_DefEnum("AOE Attack")> kAOE_Attack = 108                               'kDefenseType02
        <COH_DefEnum("Smashing Attack")> kSmashing_Attack = 112                     'kDefenseType03
        <COH_DefEnum("Lethal Attack")> kLethal_Attack = 116                         'kDefenseType04
        <COH_DefEnum("Fire Attack")> kFire_Attack = 120                             'kDefenseType05
        <COH_DefEnum("Cold Attack")> kCold_Attack = 124                             'kDefenseType06
        <COH_DefEnum("Energy Attack")> kEnergy_Attack = 128                         'kDefenseType07
        <COH_DefEnum("Negative Energy Attack")> kNegative_Energy_Attack = 132       'kDefenseType08
        <COH_DefEnum("Psionic Attack")> kPsionic_Attack = 136                       'kDefenseType09
        <COH_DefEnum("Toxic Attack")> kToxic_Attack = 140                           'kDefenseType10
        kDefenseType11 = 144
        kDefenseType12 = 148
        kDefenseType13 = 152
        kDefenseType14 = 156
        kDefenseType15 = 160
        kDefenseType16 = 164
        kDefenseType17 = 168
        kDefenseType18 = 172
        kDefenseType19 = 176
        kDefense = 180
        kSpeedRunning = 184
        '//REDUNDENT - RunSpeed
        kSpeedFlying = 188
        '//REDUNDENT - FlySpeed
        kSpeedSwimming = 192
        kSpeedJumping = 196
        kJumpHeight = 200
        kMovementControl = 204
        kMovementFriction = 208
        kStealth = 212
        kStealthRadius = 216
        kStealthRadiusPlayer = 220
        kPerceptionRadius = 224
        kRegeneration = 228
        kRecovery = 232
        kInsightRecovery = 236
        kThreatLevel = 240
        kTaunt = 244
        kPlacate = 248
        kConfused = 252
        '//REDUNDENT - Confuse
        kAfraid = 256
        kTerrorized = 260
        '//REDUNDENT - Terrorize
        kHeld = 264
        kImmobilized = 268
        '//REDUNDENT - Immobilize
        kStunned = 272
        '//REDUNDENT - Stun
        kSleep = 276
        kFly = 280
        kJumppack = 284
        kTeleport = 288
        kUntouchable = 292
        kIntangible = 296
        kOnlyAffectsSelf = 300
        kExperienceGain = 304
        kInfluenceGain = 308
        kPrestigeGain = 312
        kNullBool = 316
        '//REDUNDENT - Evade
        kKnockup = 320
        kKnockback = 324
        kRepel = 328
        kAccuracy = 332
        kRadius = 336
        kArc = 340
        kRange = 344 '///HMMM FOUND REF THIS MIGHT ACTUALLY BE 348
        kTimeToActivate = 348
        kRechargeTime = 352
        kInterruptTime = 356
        kEnduranceDiscount = 360
        kInsightDiscount = 364
        kMeter = 368
        <COH_DefEnum("Ranged Elude")> kRanged_Elude = 372                           'kElusivity00
        <COH_DefEnum("Melee Elude")> kMelee_Elude = 376                             'kElusivity01
        <COH_DefEnum("AOE Elude")> kAOE_Elude = 380                                 'kElusivity02
        <COH_DefEnum("Smashing Elude")> kSmashing_Elude = 384                       'kElusivity03
        <COH_DefEnum("Lethal Elude")> kLethal_Elude = 388                           'kElusivity04
        <COH_DefEnum("Fire Elude")> kFire_Elude = 392                               'kElusivity05
        <COH_DefEnum("Cold Elude")> kCold_Elude = 396                               'kElusivity06
        <COH_DefEnum("Energy Elude")> kEnergy_Elude = 400                           'kElusivity07
        <COH_DefEnum("Negative Energy Elude")> kNegative_Energy_Elude = 404         'kElusivity08
        <COH_DefEnum("Psionic Elude")> kPsionic_Elude = 408                         'kElusivity09
        <COH_DefEnum("Toxic Elude")> kToxic_Elude = 412                             'kElusivity10
        kElusivity11 = 416
        kElusivity12 = 420
        kElusivity13 = 424
        kElusivity14 = 428
        kElusivity15 = 432
        kElusivity16 = 436
        kElusivity17 = 440
        kElusivity18 = 444
        kElusivity19 = 448
        kDefense2 = 452
        kAbsorb = 456
    End Enum
    Public Enum COH_Enum_Attrib_CharacterAll
        <COH_DefEnum("Smashing")> kSmashing = 0                                     'kDamageType00
        <COH_DefEnum("Lethal")> kLethal = 4                                         'kDamageType01
        <COH_DefEnum("Fire")> kFire = 8                                             'kDamageType02
        <COH_DefEnum("Cold")> kCold = 12                                            'kDamageType03
        <COH_DefEnum("Energy")> kEnergy = 16                                        'kDamageType04
        <COH_DefEnum("Negative Energy")> kNegative_Energy = 20                      'kDamageType05
        <COH_DefEnum("Psionic")> kPsionic = 24                                      'kDamageType06
        <COH_DefEnum("Heal")> kHeal = 28                                            'kDamageType07
        <COH_DefEnum("Special")> kSpecial = 32                                      'kDamageType08
        <COH_DefEnum("Toxic")> kToxic = 36                                          'kDamageType09
        <COH_DefEnum("Radiation")> kRadiation = 40                                  'kDamageType10
        <COH_DefEnum("Electrical")> kElectrical = 44                                'kDamageType11
        <COH_DefEnum("Unique1")> kUnique1 = 48                                      'kDamageType12
        <COH_DefEnum("Unique2")> kUnique2 = 52                                      'kDamageType13
        <COH_DefEnum("Unique3")> kUnique3 = 56                                      'kDamageType14
        kDamageType15 = 60
        kDamageType16 = 64
        kDamageType17 = 68
        kDamageType18 = 72
        kDamageType19 = 76
        kHitPoints = 80
        kEndurance = 84
        kInsight = 88
        '//REDUNDENT - Idea
        kRage = 92
        kToHit = 96
        <COH_DefEnum("Ranged Attack")> kRanged_Attack = 100                         'kDefenseType00
        <COH_DefEnum("Melee Attack")> kMelee_Attack = 104                           'kDefenseType01
        <COH_DefEnum("AOE Attack")> kAOE_Attack = 108                               'kDefenseType02
        <COH_DefEnum("Smashing Attack")> kSmashing_Attack = 112                     'kDefenseType03
        <COH_DefEnum("Lethal Attack")> kLethal_Attack = 116                         'kDefenseType04
        <COH_DefEnum("Fire Attack")> kFire_Attack = 120                             'kDefenseType05
        <COH_DefEnum("Cold Attack")> kCold_Attack = 124                             'kDefenseType06
        <COH_DefEnum("Energy Attack")> kEnergy_Attack = 128                         'kDefenseType07
        <COH_DefEnum("Negative Energy Attack")> kNegative_Energy_Attack = 132       'kDefenseType08
        <COH_DefEnum("Psionic Attack")> kPsionic_Attack = 136                       'kDefenseType09
        <COH_DefEnum("Toxic Attack")> kToxic_Attack = 140                           'kDefenseType10
        kDefenseType11 = 144
        kDefenseType12 = 148
        kDefenseType13 = 152
        kDefenseType14 = 156
        kDefenseType15 = 160
        kDefenseType16 = 164
        kDefenseType17 = 168
        kDefenseType18 = 172
        kDefenseType19 = 176
        kDefense = 180
        kSpeedRunning = 184
        '//REDUNDENT - RunSpeed
        kSpeedFlying = 188
        '//REDUNDENT - FlySpeed
        kSpeedSwimming = 192
        kSpeedJumping = 196
        kJumpHeight = 200
        kMovementControl = 204
        kMovementFriction = 208
        kStealth = 212
        kStealthRadius = 216
        kStealthRadiusPlayer = 220
        kPerceptionRadius = 224
        kRegeneration = 228
        kRecovery = 232
        kInsightRecovery = 236
        kThreatLevel = 240
        kTaunt = 244
        kPlacate = 248
        kConfused = 252
        '//REDUNDENT - Confuse
        kAfraid = 256
        kTerrorized = 260
        '//REDUNDENT - Terrorize
        kHeld = 264
        kImmobilized = 268
        '//REDUNDENT - Immobilize
        kStunned = 272
        '//REDUNDENT - Stun
        kSleep = 276
        kFly = 280
        kJumppack = 284
        kTeleport = 288
        kUntouchable = 292
        kIntangible = 296
        kOnlyAffectsSelf = 300
        kExperienceGain = 304
        kInfluenceGain = 308
        kPrestigeGain = 312
        kNullBool = 316
        '//REDUNDENT - Evade
        kKnockup = 320
        kKnockback = 324
        kRepel = 328
        kAccuracy = 332
        kRadius = 336
        kArc = 340
        kRange = 344
        kTimeToActivate = 348
        kRechargeTime = 352
        kInterruptTime = 356
        kEnduranceDiscount = 360
        kInsightDiscount = 364
        kMeter = 368
        <COH_DefEnum("Ranged Elude")> kRanged_Elude = 372                           'kElusivity00
        <COH_DefEnum("Melee Elude")> kMelee_Elude = 376                             'kElusivity01
        <COH_DefEnum("AOE Elude")> kAOE_Elude = 380                                 'kElusivity02
        <COH_DefEnum("Smashing Elude")> kSmashing_Elude = 384                       'kElusivity03
        <COH_DefEnum("Lethal Elude")> kLethal_Elude = 388                           'kElusivity04
        <COH_DefEnum("Fire Elude")> kFire_Elude = 392                               'kElusivity05
        <COH_DefEnum("Cold Elude")> kCold_Elude = 396                               'kElusivity06
        <COH_DefEnum("Energy Elude")> kEnergy_Elude = 400                           'kElusivity07
        <COH_DefEnum("Negative Energy Elude")> kNegative_Energy_Elude = 404         'kElusivity08
        <COH_DefEnum("Psionic Elude")> kPsionic_Elude = 408                         'kElusivity09
        <COH_DefEnum("Toxic Elude")> kToxic_Elude = 412                             'kElusivity10
        kElusivity11 = 416
        kElusivity12 = 420
        kElusivity13 = 424
        kElusivity14 = 428
        kElusivity15 = 432
        kElusivity16 = 436
        kElusivity17 = 440
        kElusivity18 = 444
        kElusivity19 = 448
        kDefense2 = 452
        kAbsorb = 456
        kSpecialAttrib_Translucency = CharacterAttributesSize ''//= sizeof(CharacterAttributes), WHICH IS 460?
        kSpecialAttrib_EntCreate = CharacterAttributesSize + 1
        kSpecialAttrib_ClearDamagers = CharacterAttributesSize + 2
        kSpecialAttrib_SilentKill = CharacterAttributesSize + 3
        kSpecialAttrib_XPDebtProtection = CharacterAttributesSize + 4
        kSpecialAttrib_SetMode = CharacterAttributesSize + 5
        kSpecialAttrib_SetCostume = CharacterAttributesSize + 6
        kSpecialAttrib_Glide = CharacterAttributesSize + 7
        kSpecialAttrib_Null = CharacterAttributesSize + 8
        kSpecialAttrib_Avoid = CharacterAttributesSize + 9
        kSpecialAttrib_Reward = CharacterAttributesSize + 10
        kSpecialAttrib_XPDebt = CharacterAttributesSize + 11
        kSpecialAttrib_DropToggles = CharacterAttributesSize + 12
        kSpecialAttrib_GrantPower = CharacterAttributesSize + 13
        kSpecialAttrib_RevokePower = CharacterAttributesSize + 14
        kSpecialAttrib_UnsetMode = CharacterAttributesSize + 15
        kSpecialAttrib_GlobalChanceMod = CharacterAttributesSize + 16
        kSpecialAttrib_PowerChanceMod = CharacterAttributesSize + 17
        kSpecialAttrib_GrantBoostedPower = CharacterAttributesSize + 18
        kSpecialAttrib_ViewAttrib = CharacterAttributesSize + 19
        kSpecialAttrib_RewardSource = CharacterAttributesSize + 20
        kSpecialAttrib_RewardSourceTeam = CharacterAttributesSize + 21
        kSpecialAttrib_ClearFog = CharacterAttributesSize + 22
        kSpecialAttrib_CombatPhase = CharacterAttributesSize + 23
        kSpecialAttrib_CombatModShift = CharacterAttributesSize + 24
        kSpecialAttrib_RechargePower = CharacterAttributesSize + 25
        kSpecialAttrib_VisionPhase = CharacterAttributesSize + 26
        kSpecialAttrib_NinjaRun = CharacterAttributesSize + 27
        kSpecialAttrib_Walk = CharacterAttributesSize + 28
        kSpecialAttrib_BeastRun = CharacterAttributesSize + 29
        kSpecialAttrib_SteamJump = CharacterAttributesSize + 30
        kSpecialAttrib_DesignerStatus = CharacterAttributesSize + 31
        kSpecialAttrib_ExclusiveVisionPhase = CharacterAttributesSize + 32
        kSpecialAttrib_HoverBoard = CharacterAttributesSize + 33
        kSpecialAttrib_SetSZEValue = CharacterAttributesSize + 34
        kSpecialAttrib_AddBehavior = CharacterAttributesSize + 35
        kSpecialAttrib_PowerRedirect = CharacterAttributesSize + 36
        kSpecialAttrib_MagicCarpet = CharacterAttributesSize + 37
        kSpecialAttrib_TokenAdd = CharacterAttributesSize + 38
        kSpecialAttrib_TokenSet = CharacterAttributesSize + 39
        kSpecialAttrib_TokenClear = CharacterAttributesSize + 40
        kSpecialAttrib_LuaExec = CharacterAttributesSize + 41
        kSpecialAttrib_ForceMove = CharacterAttributesSize + 42
        kSpecialAttrib_ParkourRun = CharacterAttributesSize + 43
    End Enum
End Namespace