Imports COH.Toolkit.Enums
Imports COH.Tools.HelperFunctions.Defs
Imports COH.Tools.Internal.Enums

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Import & Rebuild Sources From Defs"
        Public Function BuildXML_FromDef_All(Optional ShowMessage As Boolean = False) As Boolean
            Dim RootFolder As String = ProgramFolders.LookupFolder(COH_ProgramPaths.CurrentProject)
            If BuildXML_FromDef_Origin(RootFolder, False) = False Then Return False
            If BuildXML_FromDef_Heroes_All(RootFolder, False) = False Then Return False
            If BuildXML_FromDef_Villians_All(RootFolder, False) = False Then Return False
            If BuildXML_FromDef_Enemies_All(RootFolder, False) = False Then Return False
            If BuildXML_FromDef_PowerSets_All(RootFolder, False) = False Then Return False
            'If BuildXML_FromDef_PowerCategory_All(RootFolder, False) = False Then Return False
            If ShowMessage = True Then ShowMessage_Simple("Import All Defs Complete")
            Return True
        End Function
        Public Function BuildXML_FromDef_Origin(RootFolder As String, Optional ShowMessage As Boolean = False) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_Origins(ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Defs) & "_Shared\Origins\origins.def")
            Dim ExportFolder As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.CharacterClasses_PlayerClasses_Origins)
            If ShowMessage = True Then ShowMessage_Simple("Import All Origins Complete")
            Return True
        End Function
#End Region

#Region "Standard Heroes"
        Public Function BuildXML_FromDef_Heroes_All(RootFolder As String, Optional ShowMessage As Boolean = False) As Boolean
            Dim ImportFolder As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Defs)
            Dim ExportFolder As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.CharacterClasses_PlayerClasses)
            If BuildXML_FromDef_Heroes_Blaster(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Heroes_Controller(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Heroes_Defender(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Heroes_Scrapper(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Heroes_Tanker(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Heroes_PeaceBringer(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Heroes_Warshade(ImportFolder, ExportFolder) = False Then Return False
            If ShowMessage = True Then ShowMessage_Simple("Import All Player Classes (Heroes) Complete")
            Return True
        End Function
        Private Function BuildXML_FromDef_Heroes_Blaster(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Heroes\PC_Blaster.def") '
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Heroes_Controller(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Heroes\PC_Controller.def") ' "PlayerClasses\Heroes\PC_Controller.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Heroes_Defender(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Heroes\PC_Defender.def") ' "PlayerClasses\Heroes\PC_Defender.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Heroes_Scrapper(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Heroes\PC_Scrapper.def") ' "PlayerClasses\Heroes\PC_Scrapper.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Heroes_Tanker(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Heroes\PC_Tanker.def") ' "PlayerClasses\Heroes\PC_Tanker.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Heroes_PeaceBringer(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Heroes\PC_PeaceBringer.def") ' "PlayerClasses\Heroes\PC_PeaceBringer.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Heroes_Warshade(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Heroes\PC_Warshade.def") ' "PlayerClasses\Heroes\PC_Warshade.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
#End Region

#Region "Standard Villians"
        Public Function BuildXML_FromDef_Villians_All(RootFolder As String, Optional ShowMessage As Boolean = False) As Boolean
            Dim ImportFolder As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Defs)
            Dim ExportFolder As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.CharacterClasses_PlayerClasses)
            If BuildXML_FromDef_Villians_Brute(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Villians_Stalker(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Villians_Mastermind(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Villians_Dominator(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Villians_Corruptor(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Villians_Arachnos_Widow(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Villians_Arachnos_Soldier(ImportFolder, ExportFolder) = False Then Return False
            If ShowMessage = True Then ShowMessage_Simple("Import All Player Classes (Villians) Complete")
            Return True
        End Function
        Private Function BuildXML_FromDef_Villians_Brute(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Villians\V_PC_Brute.def") ' "PlayerClasses\Villians\V_PC_Brute.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Villians_Stalker(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Villians\V_PC_Stalker.def") ' "PlayerClasses\Villians\V_PC_Stalker.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Villians_Mastermind(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Villians\V_PC_Mastermind.def") ' "PlayerClasses\Villians\V_PC_Mastermind.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Villians_Dominator(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Villians\V_PC_Dominator.def") ' "PlayerClasses\Villians\V_PC_Dominator.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Villians_Corruptor(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Villians\V_PC_Corruptor.def") ' "PlayerClasses\Villians\V_PC_Corruptor.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Villians_Arachnos_Widow(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Villians\V_PC_Arachnos_Widow.def") ' "PlayerClasses\Villians\V_PC_Arachnos_Widow.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Villians_Arachnos_Soldier(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "PlayerClasses\Villians\V_PC_Arachnos_Soldier.def") ' "PlayerClasses\Villians\V_PC_Arachnos_Soldier.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
#End Region

#Region "Enemy Classes"
        Public Function BuildXML_FromDef_Enemies_All(RootFolder As String, Optional ShowMessage As Boolean = False) As Boolean
            Dim ImportFolder As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Defs)
            Dim ExportFolder As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.CharacterClasses_EnemyClass)
            If BuildXML_FromDef_Enemy_Minion_Grunt(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Minion_Small(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Minion_Turret(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Minion_Fire(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Lt_Grunt(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Lt_Sniper(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Lt_Turret(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Grunt(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Elite(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Turret(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Monster(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Archvillain(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Minion_Practice(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Minion_OilSlickTarget(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Minion_Pets(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Guard(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Minion_Swarm(ImportFolder, ExportFolder) = False Then Return False

            If BuildXML_FromDef_Enemy_Boss_Mito(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Hamidon(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Minion_Monument(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_RularuuFM(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Rularuu(ImportFolder, ExportFolder) = False Then Return False

            If BuildXML_FromDef_Enemy_Minion_UnkillableNPC(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_EliteTurret(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_HugeDevice(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Monster_Flying(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Archvillain_Flying(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Shield(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_HeavyPet(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Signature_Pets(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_Reichsman(ImportFolder, ExportFolder) = False Then Return False

            If BuildXML_FromDef_Enemy_Minion_PraetorianSmall(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Minion_PraetorianGrunt(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Lt_PraetorianGrunt(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_PraetorianGrunt(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_PraetorianElite(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_PraetorianArchvillain(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_RularuuCoP(ImportFolder, ExportFolder) = False Then Return False
            If BuildXML_FromDef_Enemy_Boss_PraetorianAVLowPerception(ImportFolder, ExportFolder) = False Then Return False

            If ShowMessage = True Then ShowMessage_Simple("Import All Enemy Classes Complete")
            Return True
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_Grunt(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_Grunt.def") ' "VillianClasses\Minion_Grunt.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_Small(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_Small.def") ' "VillianClasses\Minion_Small.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_Turret(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_Turret.def") ' "VillianClasses\Minion_Turret.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_Fire(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_Fire.def") ' "VillianClasses\Minion_Fire.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Lt_Grunt(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Lt_Grunt.def") ' "VillianClasses\Lt_Grunt.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Lt_Sniper(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Lt_Sniper.def") ' "VillianClasses\Lt_Sniper.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Lt_Turret(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Lt_Turret.def") ' "VillianClasses\Lt_Turret.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Grunt(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Grunt.def") ' "VillianClasses\Boss_Grunt.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Elite(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Elite.def") ' "VillianClasses\Boss_Elite.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Turret(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Turret.def") ' "VillianClasses\Boss_Turret.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Monster(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Monster.def") ' "VillianClasses\Boss_Monster.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Archvillain(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Archvillain.def") ' "VillianClasses\Boss_Archvillain.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_Practice(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_Practice.def") ' "VillianClasses\Minion_Practice.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_OilSlickTarget(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_OilSlickTarget.def") ' "VillianClasses\Minion_OilSlickTarget.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_Pets(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_Pets.def") ' "VillianClasses\Minion_Pets.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Guard(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Guard.def") ' "VillianClasses\Boss_Guard.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_Swarm(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_Swarm.def") ' "VillianClasses\Minion_Swarm.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Mito(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Mito.def") ' "VillianClasses\Boss_Mito.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Hamidon(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Hamidon.def") ' "VillianClasses\Boss_Hamidon.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_Monument(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_Monument.def") ' "VillianClasses\Minion_Monument.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_RularuuFM(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_RularuuFM.def") ' "VillianClasses\Boss_RularuuFM.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Rularuu(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Rularuu.def") ' "VillianClasses\Boss_Rularuu.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_Small_Agressive(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_Small_Agressive.def") ' "VillianClasses\Minion_Small_Agressive.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_Henchman(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_Henchman.def") ' "VillianClasses\Minion_Henchman.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Lt_Henchman(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Lt_Henchman.def") ' "VillianClasses\Lt_Henchman.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Henchman(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Henchman.def") ' "VillianClasses\Boss_Henchman.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Lt_LongRangeDrone(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Lt_LongRangeDrone.def") ' "VillianClasses\Lt_LongRangeDrone.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_UnkillableNPC(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_UnkillableNPC.def") ' "VillianClasses\Minion_UnkillableNPC.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_EliteTurret(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_EliteTurret.def") ' "VillianClasses\Boss_EliteTurret.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_HugeDevice(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_HugeDevice.def") ' "VillianClasses\Boss_HugeDevice.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Monster_Flying(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Monster_Flying.def") ' "VillianClasses\Boss_Monster_Flying.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Archvillain_Flying(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Archvillain_Flying.def") ' "VillianClasses\Boss_Archvillain_Flying.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Shield(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Shield.def") ' "VillianClasses\Boss_Shield.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_HeavyPet(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_HeavyPet.def") ' "VillianClasses\Boss_HeavyPet.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Signature_Pets(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Signature_Pets.def") ' "VillianClasses\Boss_Signature_Pets.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_Reichsman(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_Reichsman.def") ' "VillianClasses\Boss_Reichsman.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_PraetorianSmall(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_PraetorianSmall.def") ' "VillianClasses\Minion_PraetorianSmall.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Minion_PraetorianGrunt(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Minion_PraetorianGrunt.def") ' "VillianClasses\Minion_PraetorianGrunt.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Lt_PraetorianGrunt(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Lt_PraetorianGrunt.def") ' "VillianClasses\Lt_PraetorianGrunt.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_PraetorianGrunt(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_PraetorianGrunt.def") ' "VillianClasses\Boss_PraetorianGrunt.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_PraetorianElite(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_PraetorianElite.def") ' "VillianClasses\Boss_PraetorianElite.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_PraetorianArchvillain(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_PraetorianArchvillain.def") ' "VillianClasses\Boss_PraetorianArchvillain.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_RularuuCoP(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_RularuuCoP.def") ' "VillianClasses\Boss_RularuuCoP.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
        Private Function BuildXML_FromDef_Enemy_Boss_PraetorianAVLowPerception(ByRef ImportFolder As String, ExportFolder As String) As Boolean
            Dim Result = COH_DefReader.Import_FromDef_CharacterClass(ImportFolder & "VillianClasses\Boss_PraetorianAVLowPerception.def") ' "VillianClasses\Boss_PraetorianAVLowPerception.def")
            '   Return CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder, Result)
        End Function
#End Region

#Region "PowerSets"
        Public Function BuildXML_FromDef_PowerSets_All(RootFolder As String, Optional ShowMessage As Boolean = False) As Boolean
            Dim ImportFolder As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Defs)
            Dim ExportFolder As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.PowerSets)
            'If BuildXML_FromDef_PowerSets_Folder(ImportFolder & "Powersets\PlayerClasses\Heroes\", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerSets_Heroes)) = False Then Return False
            'If BuildXML_FromDef_PowerSets_Folder(ImportFolder & "Powersets\PlayerClasses\Villians\", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerSets_Villians)) = False Then Return False
            'If BuildXML_FromDef_PowerSets_Folder(ImportFolder & "Powersets\EnemyClasses\", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerSets_Enemies)) = False Then Return False
            'If BuildXML_FromDef_PowerSets_Folder(ImportFolder & "Powersets\EnemyClasses\", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerSets_Shared)) = False Then Return False
            'If BuildXML_FromDef_PowerSets_Folder(ImportFolder & "Powersets\EnemyClasses\", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerSets_Other)) = False Then Return False
            If ShowMessage = True Then ShowMessage_Simple("Import All PowerSets Complete")
            Return True
        End Function
        Private Function BuildXML_FromDef_PowerSets_Folder(ImportFolder As String, ExportFolder As String) As Boolean
            For Each File In IO.Directory.GetFiles(ImportFolder, "*.powersets")
                'Dim Result = COH_DefReader.Import_FromDef_PowerSets(File)
                ' If PowerSets.COH_PowerSet.Export_XML_PowerSets(ExportFolder, Result) = False Then Return False
            Next
            Return True
        End Function
#End Region

#Region "PowerSets - Categories"
        Public Function BuildXML_FromDef_PowerCategory_All(RootFolder As String, Optional ShowMessage As Boolean = False) As Boolean
            'Dim ImportFolder As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Defs)
            'Dim ExportFolder As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerCategory)
            'If BuildXML_FromDef_PowerCategory_Folder(ImportFolder & "Powersets\PlayerClasses\Heroes\", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerCategory_Player)) = False Then Return False
            'If BuildXML_FromDef_PowerCategory_Folder(ImportFolder & "Powersets\PlayerClasses\Villians\", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerCategory_Player)) = False Then Return False
            'If BuildXML_FromDef_PowerCategory_Folder(ImportFolder & "Powersets\PlayerClasses\_Shared\", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerCategory_Shared)) = False Then Return False
            'If BuildXML_FromDef_PowerCategory_Folder(ImportFolder & "Powersets\EnemyClasses\", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerCategory_Enemies)) = False Then Return False
            'If BuildXML_FromDef_PowerCategory_Folder(ImportFolder & "Powersets\_Other\", ProgramFolders.LookupFolder_ProjectFile(COH_ProjectPaths.PowerCategory_Other)) = False Then Return False
            'If ShowMessage = True Then ShowMessage_Simple("Import All Power Categories Complete")
            Return True
        End Function
        Private Function BuildXML_FromDef_PowerCategory_Folder(ImportFolder As String, ExportFolder As String) As Boolean
            For Each File In IO.Directory.GetFiles(ImportFolder, "*.categories")
                Dim Result = COH_DefReader.Import_FromDef_PowerCategory(File)
                ' If PowerSets.COH_PowerCategory.Export_XML_PowerCategory(ExportFolder, Result) = False Then Return False
            Next
            Return True
        End Function
#End Region

    End Class
End Namespace