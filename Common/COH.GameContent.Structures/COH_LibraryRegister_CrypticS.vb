Imports COH.GameContent.Structures
Imports COH.GameContent.Structures.Characters
Imports COH.GameContent.Structures.Characters.Powers
Imports COH.GameContent.Structures.Costumes
Imports COH.GameContent.Structures.Costumes.Textures
Imports COH.GameContent.Structures.Powers
Imports COH.GameContent.Structures.Powers.Boosts
Imports COH.GameContent.Structures.Shared
Imports COH.GameContent.Structures.World.Maps
Imports COH.Storage.Controllers

Public NotInheritable Class COH_LibraryRegister_CrypticS

#Region "Supported Bins"
    Public Shared Function CreateList_BinMapping_ToTypes() As List(Of COH_FSI_Entry)
        Dim Result As New List(Of COH_FSI_Entry)
        With Result
            .Add(New COH_FSI_Entry("powercats.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_PowerCategory))}).ToList))
            .Add(New COH_FSI_Entry("powersets.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_PowerSet))}).ToList))
            .Add(New COH_FSI_Entry("powers.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Power))}).ToList))

            .Add(New COH_FSI_Entry("bin_powers.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Power))}).ToList)) 'i25_ScoreBIN

            .Add(New COH_FSI_Entry("classes.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_CharacterClass))}).ToList))
            .Add(New COH_FSI_Entry("villain_classes.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_CharacterClass))}).ToList))
            .Add(New COH_FSI_Entry("attrib_names.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_AttributeNameTable))}).ToList, True))
            .Add(New COH_FSI_Entry("attrib_descriptions.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_AttributesCategory))}).ToList))
            .Add(New COH_FSI_Entry("origins.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Origin))}).ToList))
            .Add(New COH_FSI_Entry("villain_origins.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Origin))}).ToList))
            .Add(New COH_FSI_Entry("product_catalog.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Store.COH_ProductCatalogItem))}).ToList))
            .Add(New COH_FSI_Entry("PC_Def_Contacts.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Story.COH_ContactCategories))}).ToList))
            .Add(New COH_FSI_Entry("npcs_client.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Story.COH_NPC))}).ToList))
            .Add(New COH_FSI_Entry("VillainGroups.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Enemies.COH_EnemyVillainGroup))}).ToList))
            .Add(New COH_FSI_Entry("VillainDef.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Enemies.COH_EnemyVillain))}).ToList))
            .Add(New COH_FSI_Entry("lods.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(MeshRelated.COH_LOD_Info))}).ToList))
            .Add(New COH_FSI_Entry("Cards.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Store.COH_Store_SuperPack))}).ToList))
            .Add(New COH_FSI_Entry("badges.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(World.COH_Badge))}).ToList))
            .Add(New COH_FSI_Entry("costume.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_CostumeBody_Set))}).ToList))
            .Add(New COH_FSI_Entry("tricks.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(1) {New COH_FSI_Section("Textures", GetType(MeshRelated.Textures.COH_TextureOptions)), New COH_FSI_Section("Tricks", GetType(MeshRelated.COH_Trick))}).ToList))
            .Add(New COH_FSI_Entry("defnames.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(1) {New COH_FSI_Section("Files", GetType(MeshRelated.COH_GroupSaveInfo_FileEntry)), New COH_FSI_Section("Libraries", GetType(MeshRelated.COH_GroupSaveInfo_LibEntry))}).ToList))
            .Add(New COH_FSI_Entry("Salvage.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Inventory.COH_Salvage))}).ToList))
            .Add(New COH_FSI_Entry("BodyParts.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Body.COH_BodyPart))}).ToList))
            .Add(New COH_FSI_Entry("command.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(UI.COH_Command))}).ToList))
            .Add(New COH_FSI_Entry("plots.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Bases.COH_Base_Plot))}).ToList))
            .Add(New COH_FSI_Entry("roomtemplates.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Bases.COH_Base_Room))}).ToList))
            .Add(New COH_FSI_Entry("roomcategories.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Bases.COH_Base_RoomCategory))}).ToList))
            .Add(New COH_FSI_Entry("detailcats.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Bases.COH_Base_DetailCategory))}).ToList))
            .Add(New COH_FSI_Entry("details.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(World.COH_ObjectDetail))}).ToList))
            .Add(New COH_FSI_Entry("tailorcost.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Costumes.Tailor.COH_Costume_TailorCosts))}).ToList))
            .Add(New COH_FSI_Entry("experience.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_ExperienceTables))}).ToList, True))
            .Add(New COH_FSI_Entry("baseupkeep.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Bases.COH_Base_Upkeep))}).ToList, True))
            .Add(New COH_FSI_Entry("items.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Store.COH_Store_Items))}).ToList))
            .Add(New COH_FSI_Entry("stores.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Store.COH_Stores))}).ToList))
            .Add(New COH_FSI_Entry("schedules.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Power_Schedules))}).ToList, True))
            .Add(New COH_FSI_Entry("depts.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Store.COH_Store_Departments))}).ToList, True))
            .Add(New COH_FSI_Entry("animlists.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Animation.COH_Animation_List))}).ToList))
            .Add(New COH_FSI_Entry("InvSalvage.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_IndexList))}).ToList, True))
            .Add(New COH_FSI_Entry("InvStoredSalvage.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_IndexList))}).ToList, True))
            .Add(New COH_FSI_Entry("InvConcept.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_IndexList))}).ToList, True))
            .Add(New COH_FSI_Entry("InvRecipe.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_IndexList))}).ToList, True))
            .Add(New COH_FSI_Entry("InvBaseDetail.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_IndexList))}).ToList, True))
            .Add(New COH_FSI_Entry("LoyaltyReward.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Store.COH_Loyalty_RewardTree))}).ToList, True))
            .Add(New COH_FSI_Entry("supergroup_badges.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(World.COH_Badge))}).ToList))
            .Add(New COH_FSI_Entry("VillainCostume.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Costumes.NPC.COH_NPC_DEF))}).ToList))
            .Add(New COH_FSI_Entry("behavioralias.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Enemies.AI.COH_AI_BehaviorAlias))}).ToList))
            .Add(New COH_FSI_Entry("behaviors.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Enemies.AI.COH_Behavior))}).ToList))
            .Add(New COH_FSI_Entry("PopHelp.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(UI.COH_UI_PopHelp))}).ToList))
            .Add(New COH_FSI_Entry("kb.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(UI.COH_UI_KeyBinds))}).ToList))
            .Add(New COH_FSI_Entry("kbkorea.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(UI.COH_UI_KeyBinds))}).ToList))
            .Add(New COH_FSI_Entry("visionPhases.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_StringArray))}).ToList, True))
            .Add(New COH_FSI_Entry("visionPhasesExclusive.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_StringArray))}).ToList, True))
            .Add(New COH_FSI_Entry("supergroupEmblems.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Mesh.COH_CostumeGeoSet))}).ToList, True))
            .Add(New COH_FSI_Entry("supergroupColors.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_ColorPalette))}).ToList, True))
            .Add(New COH_FSI_Entry("soundinfo.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Enviroment.Sound.COH_SOUND_INFO))}).ToList))
            .Add(New COH_FSI_Entry("clothColInfo.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Costumes.Cloth.COH_Costume_Cloth_CollisionInfo))}).ToList))
            .Add(New COH_FSI_Entry("capes.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Costumes.COH_Costume_Capes))}).ToList))
            .Add(New COH_FSI_Entry("powercustomizationcost.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Costumes.Tailor.COH_Costum_PowerCustomize_Costs))}).ToList))
            .Add(New COH_FSI_Entry("powercustomizationmenu.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Costumes.Tailor.COH_Costum_PowerCustomize_Menu))}).ToList))
            .Add(New COH_FSI_Entry("clothWindInfo.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(World.COH_Enviroment_Wind))}).ToList))
            .Add(New COH_FSI_Entry("boost_effect_above.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_FloatArray))}).ToList, True))
            .Add(New COH_FSI_Entry("boost_effect_below.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_FloatArray))}).ToList, True))
            .Add(New COH_FSI_Entry("boost_effect_boosters.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_FloatArray))}).ToList, True))
            .Add(New COH_FSI_Entry("exemplar_handicaps.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Characters.COH_Exemplar_Boost))}).ToList, True))
            .Add(New COH_FSI_Entry("combine_chances.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_FloatArray))}).ToList, True))
            .Add(New COH_FSI_Entry("combine_same_set_chances.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_FloatArray))}).ToList, True))
            .Add(New COH_FSI_Entry("combine_booster_chances.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_FloatArray))}).ToList, True))
            .Add(New COH_FSI_Entry("boostsets.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Boost_Set))}).ToList))
            .Add(New COH_FSI_Entry("dim_returns.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Power_DiminishingReturns_Set))}).ToList))
            .Add(New COH_FSI_Entry("seqstatebits.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Animation.COH_Animation_StateBits))}).ToList))
            .Add(New COH_FSI_Entry("chestGeoLink.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Chest_GeoLink))}).ToList))
            .Add(New COH_FSI_Entry("sequencers.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Animation.COH_Animation_Sequence))}).ToList))
            .Add(New COH_FSI_Entry("particles.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Animation.COH_FX_System))}).ToList))
            .Add(New COH_FSI_Entry("ent_types.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Animation.COH_Animation_Sequence_Type))}).ToList))
            .Add(New COH_FSI_Entry("replacepowernames.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(1) {New COH_FSI_Section("PowerSets", GetType(COH_Power_NameMap)), New COH_FSI_Section("Powers", GetType(COH_Power_NameMap))}).ToList))
            .Add(New COH_FSI_Entry("Proficiencies.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Proficiency))}).ToList))
            .Add(New COH_FSI_Entry("ProficiencyIds.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_DBI))}).ToList))
            .Add(New COH_FSI_Entry("PC_Def_Unlockable_Content.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Store.COH_UnlockableContent))}).ToList))
            .Add(New COH_FSI_Entry("texWords.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Textures.COH_TextWord))}).ToList))
            .Add(New COH_FSI_Entry("PC_Def_Entities.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Enemies.COH_Enemies_GroupList))}).ToList, True))
            .Add(New COH_FSI_Entry("PC_Def_DestructObject.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_StringTable))}).ToList, True))
            .Add(New COH_FSI_Entry("PC_Def_NonSelectable_Entities.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Generic_StringArray))}).ToList, True))
            .Add(New COH_FSI_Entry("PC_Def_Animation.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Animation.COH_Animation_List_NoContent))}).ToList))
            .Add(New COH_FSI_Entry("PC_Def_MapUnique.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_UniqueMap))}).ToList))
            .Add(New COH_FSI_Entry("PC_Def_MapSets.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_Map_Set))}).ToList))
            .Add(New COH_FSI_Entry("PC_Def_Sequencer_Anims.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Animation.COH_Animation_Sequence_List))}).ToList))
            .Add(New COH_FSI_Entry("PC_Def_Objects.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(World.Objects.COH_GameObject_Placement))}).ToList))
            .Add(New COH_FSI_Entry("PC_Def_UI.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(1) {New COH_FSI_Section("Region", GetType(PlayerCreated.UI.COH_UI_PlayerCreated_Region)), New COH_FSI_Section("Buttons", GetType(PlayerCreated.UI.COH_UI_PlayerCreated_Region_Button))}).ToList))
            .Add(New COH_FSI_Entry("minimap.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(UI.COH_MiniMap_Header))}).ToList))
            .Add(New COH_FSI_Entry("menuAnimations.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Animation.COH_Animation_Demo))}).ToList))
            .Add(New COH_FSI_Entry("mapstats.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(UI.COH_Map_Stats))}).ToList))
            .Add(New COH_FSI_Entry("mapspecs.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Story.COH_Mission_MapSet))}).ToList))
            .Add(New COH_FSI_Entry("map.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(UI.COH_CityZone))}).ToList))
            .Add(New COH_FSI_Entry("arenamaps.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(UI.COH_Map_Arena))}).ToList))
            .Add(New COH_FSI_Entry("auctionconfig.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(AuctionHouse.COH_AunctionHouse_Fee))}).ToList, True))
            .Add(New COH_FSI_Entry("baserecipes.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Inventory.COH_Recipe))}).ToList))
            .Add(New COH_FSI_Entry("conversionsets.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Inventory.COH_ConversionSets))}).ToList))
            .Add(New COH_FSI_Entry("defaultBodyCfg.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(MeshRelated.COH_Body_Config))}).ToList))
            .Add(New COH_FSI_Entry("CustomCritterRewardMods.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(PlayerCreated.Critter.COH_PlayerCreated_Critter_Reward))}).ToList, True))
            .Add(New COH_FSI_Entry("costumeWeaponStances.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(COH_CostumeWeapon_Stance))}).ToList))
            .Add(New COH_FSI_Entry("fxinfo.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Animation.FX.COH_FX_Info))}).ToList))
            '//SERVER BINS
            .Add(New COH_FSI_Entry("storyarc.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Story.COH_StoryArc))}).ToList))
            .Add(New COH_FSI_Entry("monorails.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(World.Monorail.COH_Monorail))}).ToList))
            .Add(New COH_FSI_Entry("DayJobs.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(World.DayJobs.COH_DayJob))}).ToList, True))
            .Add(New COH_FSI_Entry("NictusHunterOptions.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Spawns.COH_NictusOptions))}).ToList, True))
            .Add(New COH_FSI_Entry("NewFeatures.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Notifications.COH_NewFeatures))}).ToList))
            .Add(New COH_FSI_Entry("SouvenirClues.bin", COH_Supported_ContentType.Resource_BIN_CrypticS, Nothing, (New COH_FSI_Section(0) {New COH_FSI_Section(GetType(Story.COH_SouvenirClue))}).ToList))
            '///SouvenirClues



            'If COH_DeveloperMode_AllowEdit = True Then 
        End With
        Return Result
    End Function
#End Region

End Class
