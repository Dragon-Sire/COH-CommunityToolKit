Namespace Toolkit.Modding.Enums
    Public Enum TargetType1
        kNone = 0
        kCaster  ' kTargetType_Caster								
        kPlayer  ' kTargetType_Player								
        kPlayerHero  ' kTargetType_PlayerHero							
        kPlayerVillain  ' kTargetType_PlayerVillain						
        kDeadPlayer  ' kTargetType_DeadPlayer							
        kDeadPlayerFriend  ' 	kTargetType_DeadPlayerFriend					
        kDeadPlayerFoe  ' kTargetType_DeadPlayerFoe						
        kTeammate  ' kTargetType_Teammate							
        kDeadTeammate  ' kTargetType_DeadTeammate						
        kDeadOrAliveTeammate  ' kTargetType_DeadOrAliveTeammate					
        kFriend  ' kTargetType_Friend								
        kEnemy  ' 	kTargetType_Villain								
        kVillain  ' kTargetType_Villain								
        kDeadVillain  ' kTargetType_DeadVillain							
        kFoe  ' 	kTargetType_Foe									
        kNPC  ' 	kTargetType_NPC									
        kLocation  ' kTargetType_Location							
        kTeleport  ' kTargetType_Teleport							
        kDeadFoe  ' kTargetType_DeadFoe								
        kDeadOrAliveFoe  ' 	kTargetType_DeadOrAliveFoe						
        kDeadFriend  ' kTargetType_DeadFriend							
        kDeadOrAliveFriend  ' 	kTargetType_DeadOrAliveFriend					
        kMyPet  ' 	kTargetType_MyPet								
        kDeadMyPet  ' kTargetType_DeadMyPet							
        kDeadOrAliveMyPet  ' 	kTargetType_DeadOrAliveMyPet					
        kMyOwner  ' kTargetType_MyOwner								
        kMyCreator  ' kTargetType_MyCreator							
        kMyCreation  ' kTargetType_MyCreation							
        kDeadMyCreation  ' 	kTargetType_DeadMyCreation						
        kDeadOrAliveMyCreation  ' kTargetType_DeadOrAliveMyCreation				
        kLeaguemate  ' kTargetType_Leaguemate							
        kDeadLeaguemate  ' 	kTargetType_DeadLeaguemate						
        kDeadOrAliveLeaguemate  ' kTargetType_DeadOrAliveLeaguemate				
        kAny  ' 	kTargetType_Any									
        kPosition  ' kTargetType_Position							
    End Enum
    Public Enum EnumClassStructure
        fDamageType '[20]    '// ModBase: 0.0, Add, TimesMax, Absolute, HitPoints, DumpAttribs: NO_CUR
        '// Cur: Unused
        '// Mod: The number Of points To add Or remove from Cur.HitPoints.

        '// Make sure fHitPoints immediately follows this array

        fHitPoints         '// ModBase 0.0, Add, TimesMax, Absolute, HitPoints, DumpAttribs: ALWAYS
        '// Cur: Number of hitpoints the player currently has. Running tally.
        '//      Defaults to a table lookup
        '// Mod: How many points To add Or remove from the tally.
        '//      Defaults to 0.0

        fAbsorb            '// ModBase 0.0, Add, TimesMax, Absolute, HitPoints, DumpAttribs: ALWAYS
        '// Max: Number of absorb points the player currently has. Running tally.
        '//      Defaults to a table lookup
        '// Cur: Unused
        '// Mod: Unused

        fEndurance         '// ModBase 0.0, Add, TimesMax, Absolute, DumpAttribs: ALWAYS
        '// Cur: Measure of endurance the player currently has. Running tally.
        '//      Defaults to 100
        '// Mod: How many points To add Or remove from the tally.

        fInsight           '// ModBase 0.0, Add, TimesMax, Absolute, DumpAttribs: ALWAYS, Synonym: Idea
        '// Cur: Measure of Insight the player currently has. Running tally.
        '//      Defaults to 100
        '// Mod: How many points To add Or remove from the tally.

        fRage             '// ModBase 0.0, Add, TimesMax, Absolute, DumpAttribs: ALWAYS
        '// Cur: Measure of Rage the player currently has. Running tally.
        '// Mod: How many points To add Or remove from the tally.

        fToHit             '// ModBase 0.0, Add, CLAMP_CUR: No
        '// Cur: The chance To hit a target.
        '//      defaults to .75==75%, min 5%, max 95%
        '// Mod: This Is a percentage to be added to the base percentage value

        fDefenseType '[20]   '// ModBase 0.0, Add
        '// Cur: The chance To avoid being hit by a certain kind Of attack
        '// Mod: This Is a percentage added to the base percentage value.

        '// Make sure fDefense immediately follows this array

        fDefense           '// ModBase 0.0, Add
        '// Cur: The chance Of avoiding being hit by a direct attack.
        '// Mod: This Is a percentage to be added to the base percentage value

        fSpeedRunning      '// ModBase 1.0, Multiply, Synonym: RunSpeed
        fSpeedFlying       '// ModBase: 1.0, Multiply, Synonym: FlySpeed
        fSpeedSwimming     '// ModBase: 1.0, Multiply
        fSpeedJumping      '// ModBase: 1.0, Multiply
        '// Cur: These are how fast the character travels As a percentage Of
        '//      the basic character speed.
        '//      Defaults to 1.0 (100%) (30ft/s)
        '// Mod: These are percentages To be multiplied With the base speed values.

        fJumpHeight        '// ModBase 1.0, Multiply
        '// Cur: These are how well the character jumps As a percentage Of
        '//      the basic character jump velocity.
        '//      Defaults to 1.0 (100%) (12')
        '// Mod: This Is a percentage to be multiplied with the base value.

        fMovementControl   '// ModBase 1.0, Multiply
        fMovementFriction  '// ModBase: 1.0, Multiply
        '// Cur: Controls the character's ability to move.
        '//      Default to 0.0, which means use the built-in values.
        '//      Running Is ( 1.0, 0.3 )
        '//      Jump Is ( .03, 0.0 )
        '// Mod: This Is a percentage to be multiplied with the base value.

        fStealth           '// ModBase 0.0, Add
        '// Cur: The chance Of avoiding being seen When In eyeshot Of an enemy.
        '// Mod: This Is a percentage to be added to the base percentage value

        fStealthRadius     '// ModBase 0.0, Add
        '// Cur: This Is a distance subtracted from an enemy mob's perception distance.
        '// Mod: This Is a distance to be added to the base distance value.

        fStealthRadiusPlayer     '// ModBase 0.0, Add
        '// Cur: This Is a distance subtracted from an enemy player's perception distance.
        '// Mod: This Is a distance to be added to the base distance value.

        fPerceptionRadius  '// ModBase 1.0, Multiply, PlusAbsolute
        '// Cur: This Is the distance the character can see. (Villains only.)
        '// Mod: This Is percent improvement over the base.

        fRegeneration      '// ModBase 1.0, Multiply
        '// Cur: This Is the rate at which HitPoints are regenerated.
        '//      (1.0 = 100% MaxHP in a min)
        '// Mod: This Is a rate which will be multiplied by the base rate.

        fRecovery          '// ModBase 1.0, Multiply
        '// Cur: This Is the rate at which Endurance will recover.
        '//      (1.0 = 100% MaxEndurance in a min)
        '// Mod: This Is a rate which will be multiplied by the base rate.

        fInsightRecovery   '// ModBase 1.0, Multiply
        '// Cur: This Is the rate at which Insight will recover.
        '//      (1.0 = 100% MaxInsight in a min)
        '// Mod: This Is a rate which will be multiplied by the base rate.

        fThreatLevel       '// ModBase 0.0, Add
        '// Cur: The general threat level Of the character. (Used by AI)
        '// Mod: Not really expected to be modded

        fTaunt             '// ModBase 1.0, Add
        '// Cur: This Is how much the character Is taunting a target.
        '// (Not really useful as a real attrib. By modifying this attrib,
        '// the AI will become more belligerent to you.)

        fPlacate           '// ModBase 1.0, Add
        '// Cur: This Is how much the character Is being placated.
        '// (Not really useful as a real attrib. By modifying this attrib,
        '// the AI will become less belligerent to you.)

        fConfused    '// wanders around                '// ModBase 0.0, Add, Synonym: Confuse
        fAfraid      '// Wants to run away             '// ModBase: 0.0, Add
        fTerrorized  '// Cowers                        '// ModBase: 0.0, Add, Synonym: Terrorize
        fHeld        '// cannot move Or execute powers '// ModBase: 0.0, Add
        fImmobilized '// cannot move                   '// ModBase: 0.0, Add, Synonym: Immobilize
        fStunned     '// cannot execute powers         '// ModBase: 0.0, Add, Synonym: Stun
        fSleep       '// Immobilize+Stun unless woken  '// ModBase: 0.0, Add
        fFly         '// can fly                       '// ModBase: 0.0, Add
        fJumppack    '// can use jumppack              '// ModBase: 0.0, Add
        fTeleport    '// Initiates a teleport          '// ModBase: 0.0, Add
        fUntouchable '// Only caster can hit himself   '// ModBase: 0.0, Add
        fIntangible  '// Doesn't collide with others   '// ModBase: 0.0, Add
        fOnlyAffectsSelf '// Powers only affect self   '// ModBase: 0.0, Add
        '// Cur: If greater than zero, Then the Boolean Is True.
        '//      Defaults to 0.0
        '// Mod: These are quantities which are added To the base value.

        fExperienceGain '// XP gain factor             '// ModBase 0.0, Add
        fInfluenceGain  '// Inf gain factor            '// ModBase: 0.0, Add
        fPrestigeGain   '// Prestige gain factor       '// ModBase: 0.0, Add

        fNullBool                '// ModBase 0.0, Add, Synonym: Evade
        '// Doesn't do anything on it's own. It's just a place to hang extra
        '//   FX And other nefarious edge cases Design needs.

        fKnockup                 '// ModBase 0.0, Multiply
        fKnockback               '// ModBase: 0.0, Multiply
        fRepel                   '// ModBase: 0.0, Multiply
        '// Cur: These are how hard the character hits enemies As a percentage
        '//      of the basic character abilities.
        '//      Defaults to 1.0 (100%)
        '// Mod: These are percentages To be multiplied With the base speed values.

        '// Power facets
        fAccuracy                '// ModBase: 1.0, Multiply, DumpAttribs: STR_RES
        fRadius                  '// ModBase: 1.0, Multiply, DumpAttribs: STR_RES
        fArc                     '// ModBase: 1.0, Multiply, DumpAttribs: STR_RES
        fRange                   '// ModBase: 1.0, Multiply, DumpAttribs: STR_RES
        '// Cur: Unused
        '// Mod: Unused
        '// Str: These are percentages which are multiplied With a power's facets.

        fTimeToActivate          '// ModBase 1.0, Multiply, DumpAttribs: STR_RES
        fRechargeTime            '// ModBase: 1.0, Multiply, DumpAttribs: STR_RES
        fInterruptTime           '// ModBase: 1.0, Multiply, DumpAttribs: STR_RES
        '// Cur: Unused
        '// Mod: Unused
        '// Str: These are rates which will be multiplied by the base (hard-coded) rate.

        fEnduranceDiscount       '// ModBase 1.0, Multiply, DumpAttribs: STR_RES
        '// Cur: Unused
        '// Mod: Unused
        '// Str: This Is a magnitude which will divide into the cost.

        fInsightDiscount         '// ModBase 1.0, Multiply, DumpAttribs: STR_RES, NoDump
        '// Cur: Unused
        '// Mod: Unused
        '// Str: This Is a magnitude which will divide into the cost.

        fMeter                   '// ModBase 0.0, Add, PlusAbsolute
        '// Cur: A "fake" attribute which shows up as a meter in the UI.
        '// Mod: Amount to increase Or decrease the meter.

        fElusivity '[20]
        '// Str: Anti-Accuracy
    End Enum

End Namespace