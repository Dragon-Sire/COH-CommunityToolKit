Namespace CodeManagement.Enums
    Public Enum COH_Enum_BadgeType
        <COH_DefEnum("kNone", "kInternal")> kBadgeType_None
        '// Old categories, some of which may be going away after the re-org.
        <COH_DefEnum("kTourism")> kBadgeType_Tourism
        <COH_DefEnum("kHistory")> kBadgeType_History
        <COH_DefEnum("kAccomplishment")> kBadgeType_Accomplishment
        <COH_DefEnum("kAchievement")> kBadgeType_Achievement
        <COH_DefEnum("kPerk")> kBadgeType_Perk
        <COH_DefEnum("kGladiator")> kBadgeType_Gladiator
        <COH_DefEnum("kVeteran")> kBadgeType_Veteran

        '// New categories, for badges to be re-orged into.
        <COH_DefEnum("kPVP")> kBadgeType_PVP
        <COH_DefEnum("kInvention")> kBadgeType_Invention
        <COH_DefEnum("kDefeat")> kBadgeType_Defeat
        <COH_DefEnum("kEvent")> kBadgeType_Event
        <COH_DefEnum("kFlashback")> kBadgeType_Flashback
        <COH_DefEnum("kAuction")> kBadgeType_Auction
        <COH_DefEnum("kDayJob")> kBadgeType_DayJob
        <COH_DefEnum("kArchitect")> kBadgeType_Architect

        '// if you add more badge categories, add them before this
        kBadgeType_LastBadgeCategory
        <COH_DefEnum("kContent")> kMarketType_Content
        <COH_DefEnum("kSignatureStoryArc1")> kMarketType_SignatureStoryArc1
        <COH_DefEnum("kSignatureStoryArc2")> kMarketType_SignatureStoryArc2
        <COH_DefEnum("kHeroesAndVillains")> kSuperPackType_HeroesAndVillains
        <COH_DefEnum("kRoguesAndVigilantes")> kSuperPackType_RoguesAndVigilantes
        <COH_DefEnum("kEmpyrean")> kIncarnateType_Empyrean
        <COH_DefEnum("kAstral")> kIncarnateType_Astral

        '// supergroup badges use the regular badge types
        kBadgeType_Count
    End Enum
    Public Enum COH_Enum_CollectionType
        <COH_DefEnum("kBadge")> kCollectionType_Badge
        <COH_DefEnum("kMarket")> kCollectionType_Market
        <COH_DefEnum("kSuperPack")> kCollectionType_SuperPack
        <COH_DefEnum("kIncarnate")> kCollectionType_Incarnate
        <COH_DefEnum("kSupergroup")> kCollectionType_Supergroup
        kCollectionType_Count
    End Enum
    Public Enum COH_Enum_Surface
        <COH_DefEnum("Floor")> kSurface_Floor
        <COH_DefEnum("Wall")> kSurface_Wall
        <COH_DefEnum("Ceiling")> kSurface_Ceiling
        kSurface_Count
    End Enum
    Public Enum COH_Enum_ObjectDetailFunction
        <COH_DefEnum("None")> kDetailFunction_None
        <COH_DefEnum("Workshop")> kDetailFunction_Workshop
        <COH_DefEnum("Teleporter")> kDetailFunction_Teleporter
        <COH_DefEnum("Turret")> kDetailFunction_Turret
        <COH_DefEnum("Field")> kDetailFunction_Field
        <COH_DefEnum("Anchor")> kDetailFunction_Anchor
        <COH_DefEnum("Battery")> kDetailFunction_Battery
        <COH_DefEnum("Trap")> kDetailFunction_Trap
        <COH_DefEnum("RaidTeleporter")> kDetailFunction_RaidTeleporter
        <COH_DefEnum("ItemOfPower")> kDetailFunction_ItemOfPower
        <COH_DefEnum("ItemOfPowerMount")> kDetailFunction_ItemOfPowerMount
        <COH_DefEnum("Medivac")> kDetailFunction_Medivac
        <COH_DefEnum("Contact")> kDetailFunction_Contact
        <COH_DefEnum("Store")> kDetailFunction_Store
        <COH_DefEnum("StorageSalvage")> kDetailFunction_StorageSalvage
        <COH_DefEnum("StorageInspiration")> kDetailFunction_StorageInspiration
        <COH_DefEnum("StorageEnhancement")> kDetailFunction_StorageEnhancement
        <COH_DefEnum("AuxSpot")> kDetailFunction_AuxSpot
        <COH_DefEnum("AuxApplyPower")> kDetailFunction_AuxApplyPower
        <COH_DefEnum("AuxGrantPower")> kDetailFunction_AuxGrantPower
        <COH_DefEnum("TPBeacon")> kDetailFunction_AuxTeleBeacon
        <COH_DefEnum("AuxBoostEnergy")> kDetailFunction_AuxBoostEnergy
        <COH_DefEnum("AuxBoostControl")> kDetailFunction_AuxBoostControl
        <COH_DefEnum("MedivacImprover")> kDetailFunction_AuxMedivacImprover
        <COH_DefEnum("AuxWorkshopRepair")> kDetailFunction_AuxWorkshopRepair
        <COH_DefEnum("AuxContact")> kDetailFunction_AuxContact
    End Enum
    Public Enum COH_Enum_MissionPlace
        <COH_DefEnum("(Undefined)")> MISSION_NONE
        <COH_DefEnum("Front")> MISSION_FRONT
        <COH_DefEnum("Back")> MISSION_BACK
        <COH_DefEnum("Middle")> MISSION_MIDDLE
        <COH_DefEnum("Objective")> MISSION_OBJECTIVE
        <COH_DefEnum("Any")> MISSION_ANY
        <COH_DefEnum("ScriptControlled")> MISSION_SCRIPTCONTROLLED
        <COH_DefEnum("ReplaceGeneric")> MISSION_REPLACEGENERIC '// not actually a place on the map, these are for scripts to refer to
        <COH_DefEnum("Lobby")> MISSION_LOBBY '// not actually a place on the map, these spawns are used instead of usual generics
    End Enum
    Public Enum COH_Enum_MapSet
        MAPSET_NONE
        <COH_DefEnum("Office")> MAPSET_OFFICE
        <COH_DefEnum("AbandonedOffice")> MAPSET_ABANDONEDOFFICE
        <COH_DefEnum("FloodedOffice")> MAPSET_FLOODEDOFFICE
        <COH_DefEnum("Warehouse")> MAPSET_WAREHOUSE
        <COH_DefEnum("AbandonedWarehouse")> MAPSET_ABANDONEDWAREHOUSE
        <COH_DefEnum("5thColumn")> MAPSET_5THCOLUMN
        <COH_DefEnum("Sewers")> MAPSET_SEWERS
        <COH_DefEnum("Caves")> MAPSET_CAVES
        <COH_DefEnum("CircleOfThorns")> MAPSET_CIRCLEOFTHORNS
        <COH_DefEnum("Tech")> MAPSET_TECH
        <COH_DefEnum("Test")> MAPSET_TEST
        <COH_DefEnum("SmoothCaves")> MAPSET_SMOOTHCAVES
        <COH_DefEnum("SS_SmoothCaves")> MAPSET_SHADOWSHARD_SMOOTHCAVES
        <COH_DefEnum("Council")> MAPSET_COUNCIL
        <COH_DefEnum("CargoShip")> MAPSET_CARGOSHIP
        <COH_DefEnum("VillainAbandonedOffice")> MAPSET_VILLAINABANDONEDOFFICE
        <COH_DefEnum("VillainAbandonedWarehouse")> MAPSET_VILLAINABANDONEDWAREHOUSE
        <COH_DefEnum("VillainCaves")> MAPSET_VILLAINCAVES
        <COH_DefEnum("VillainCircleOfThorns")> MAPSET_VILLAINCIRCLEOFTHORNS
        <COH_DefEnum("VillainOffice")> MAPSET_VILLAINOFFICE
        <COH_DefEnum("VillainSewers")> MAPSET_VILLAINSEWERS
        <COH_DefEnum("VillainWarehouse")> MAPSET_VILLAINWAREHOUSE
        <COH_DefEnum("VillainSmoothCaves")> MAPSET_VILLAINSMOOTHCAVES
        <COH_DefEnum("Arachnos")> MAPSET_ARACHNOS
        <COH_DefEnum("Longbow")> MAPSET_LONGBOW
        <COH_DefEnum("LongbowUnderwater")> MAPSET_LONGBOWUNDERWATER
        <COH_DefEnum("CargoShipOutdoor")> MAPSET_CARGOSHIPOUTDOOR
        <COH_DefEnum("VillainUniqueWarehouse_Arachnos")> MAPSET_VILLAINARACHNOSWAREHOUSE
        <COH_DefEnum("VillainUniqueWarehouse_Longbow")> MAPSET_VILLAINLONGBOWWAREHOUSE
        <COH_DefEnum("VillainArachnoidTech")> MAPSET_VILLAINARACHNOIDTECH
        <COH_DefEnum("VillainArachnoidCave")> MAPSET_VILLAINARACHNOIDCAVE
        <COH_DefEnum("VillainOfficeToCave")> MAPSET_VILLAINOFFICETOCAVE
        <COH_DefEnum("VillainOfficeToSewer")> MAPSET_VILLAINOFFICETOSEWER
        <COH_DefEnum("VillainSewerToOffice")> MAPSET_VILLAINSEWERTOSEWER
        <COH_DefEnum("VillainMostoSmoothCave")> MAPSET_VILLAINMOSTOSMOOTHCAVE
        <COH_DefEnum("VillainWarehousetoArach")> MAPSET_VILLAINWAREHOUSETOARACH
        <COH_DefEnum("AbandonedTech")> MAPSET_ABANDONEDTECH
        <COH_DefEnum("Rikti")> MAPSET_RIKTI
        <COH_DefEnum("5thColumnFlashback")> MAPSET_5THCOLUMN_FLASHBACK
        <COH_DefEnum("Caves_Mediterranean")> MAPSET_CAVES_MEDITERRANEAN
        <COH_DefEnum("P_Office")> MAPSET_PRAETORIAN_OFFICE
        <COH_DefEnum("P_Office_Solo")> MAPSET_PRAETORIAN_OFFICE_SOLO
        <COH_DefEnum("P_Warehouse")> MAPSET_PRAETORIAN_WAREHOUSE
        <COH_DefEnum("P_Warehouse_Solo")> MAPSET_PRAETORIAN_WAREHOUSE_SOLO
        <COH_DefEnum("P_Tunnels")> MAPSET_PRAETORIAN_TUNNELS
        <COH_DefEnum("P_Tech")> MAPSET_PRAETORIAN_TECH
        <COH_DefEnum("P_PPD")> MAPSET_PRAETORIAN_PPD
        <COH_DefEnum("P_Tech_Bio")> MAPSET_PRAETORIAN_TECH_BIO
        <COH_DefEnum("P_Tech_Power")> MAPSET_PRAETORIAN_TECH_POWER
        <COH_DefEnum("N_Warehouse")> MAPSET_NEW_WAREHOUSE
        <COH_DefEnum("GraniteCaves")> MAPSET_GRANITE_CAVES
        <COH_DefEnum("TalonsCaves")> MAPSET_TALONS_CAVES
        <COH_DefEnum("Random")> MAPSET_RANDOM
        <COH_DefEnum("Specific")> MAPSET_SPECIFIC
    End Enum
    Public Enum COH_Enum_City
        <COH_DefEnum("ParagonCity")> CITY_PARAGON
        <COH_DefEnum("RogueIsles")> CITY_ROGUE_ISLES
        <COH_DefEnum("Praetoria")> CITY_PRAETORIA
        <COH_DefEnum("None")> CITY_NONE
        CITY_COUNT
    End Enum
    Public Enum COH_Enum_TeamArea
        <COH_DefEnum("Heroes")> MAP_TEAM_HEROES_ONLY
        <COH_DefEnum("Villains")> MAP_TEAM_VILLAINS_ONLY
        <COH_DefEnum("PrimalCommon")> MAP_TEAM_PRIMAL_COMMON
        <COH_DefEnum("Praetorians")> MAP_TEAM_PRAETORIANS
        <COH_DefEnum("Everybody")> MAP_TEAM_EVERYBODY
        <COH_DefEnum("None")> MAP_TEAM_COUNT
    End Enum


End Namespace