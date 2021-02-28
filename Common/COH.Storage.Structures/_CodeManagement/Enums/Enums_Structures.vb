Namespace CodeManagement.Enums.Structures
    Public Enum COH_BuildType
        Either = 0
        ClientOnly = 1
        ServerOnly = 2
    End Enum
    Public Enum COH_BinaryFormat
        Unknown = 0
        CrypticsS_Parse6 = 6
        CrypticsS_Parse7 = 7
        CityHeroes_BinFormat = 8
    End Enum
    Public Enum COH_TextFormat
        XML = 0
        CrypticS_TextFormat = 1
    End Enum
    Public Enum COH_ContentSource
        Vol1_i24 = 0
        Vol1_i25_Score = 1
    End Enum
    Public Enum COH_StreamFormat
        CrypticS_BINFormat = 2
        Binary = 3
        Unspecified = 255
    End Enum
    Public Enum COH_ExportFormat
        XML = 0
        CrypticS_TextFormat = 1
        CrypticS_BINFormat = 2
        Binary = 3
        Unspecified = 255
    End Enum
    Public Enum COH_SupportedBinFiles
        Unknown = 0
        CharacterClass
        AttributeNames
        AttributeCategory
        Origins
        PowerCategory
        PowerSet
        Power
        ProductCatalog
        ProductCatalogItem
        Contacts
        ContactsList
        NPC
        Villain
        VillainGroups
        LOD_Info
        SuperPack
        Badge
        Costume
        GeoGroupList = 1048517264
    End Enum
    Public Enum COH_Supported_ContentType
        GameContent_Struct = 0
        Resource_BIN_CrypticS = 1
        Resource_BIN_MessageStore = 2
        Resource_Texture = 3
        Resource_GEO = 4
        Resource_ANIMATION = 5
        Resource_TGA = 6

        XML_SpecialCase_Bone = 100


        Unknown = 255
    End Enum
End Namespace