Namespace CodeManagement.Enums
    Public Enum COH_Enum_SalvageRarity
        <COH_DefEnum("Ubiquitous")> kSalvageRarity_Ubiquitous
        <COH_DefEnum("Common")> kSalvageRarity_Common
        <COH_DefEnum("Uncommon")> kSalvageRarity_Uncommon
        <COH_DefEnum("Rare")> kSalvageRarity_Rare
        <COH_DefEnum("VeryRare")> kSalvageRarity_VeryRare
        <COH_DefEnum("Unique")> kSalvageRarity_Unique
        <COH_DefEnum("Count")> kSalvageRarity_Count
        kSalvageRarity_Invalid = kSalvageRarity_Count
    End Enum
    Public Enum COH_Enum_SalvageType
        <COH_DefEnum("Base")> kSalvageType_Base
        <COH_DefEnum("Invention")> kSalvageType_Invention
        <COH_DefEnum("Token")> kSalvageType_Token
        <COH_DefEnum("Incarnate")> kSalvageType_Incarnate
        <COH_DefEnum("Count")> kSalvageType_Count
    End Enum
    Public Enum COH_Enum_SalvageFlags
        <COH_DefEnum("Base")> kSalvageType_Base
        <COH_DefEnum("Invention")> kSalvageType_Invention
        <COH_DefEnum("Token")> kSalvageType_Token
        <COH_DefEnum("Incarnate")> kSalvageType_Incarnate
        <COH_DefEnum("Count")> kSalvageType_Count
        kSalvageType_Invalid = kSalvageType_Count
    End Enum
    <Flags> Public Enum COH_Enum_SalvageImmediateUseStatus
        kSalvageImmediateUseFlag_OK = 0
        kSalvageImmediateUseFlag_NotApplicable = (1 << 0)
        kSalvageImmediateUseFlag_MissingPrereqs = (1 << 1)
    End Enum
    <Flags> Public Enum COH_Enum_Recipe
        <COH_DefEnum("NoGenericBadgeCredit")> RECIPE_NO_GENERIC_BADGE_CREDIT = (1 << 0) '// This detail recipe does Not give credit towards the generic recipe creation badges.
        <COH_DefEnum("NoLevelDisplayed")> RECIPE_NO_LEVEL_DISPLAYED = (1 << 1) '// This detail recipe does not display a level when shown in the UI
        <COH_DefEnum("NoTrade")> RECIPE_NO_TRADE = (1 << 2) ',	// This detail recipe cannot be traded, nor can what it creates
        <COH_DefEnum("Certification")> RECIPE_CERTIFICATON = (1 << 3) ',	// This detail awards a certification
        <COH_DefEnum("Voucher")> RECIPE_VOUCHER = (1 << 4) ',	// This detail awards a voucher
        <COH_DefEnum("LicRequired")> RECIPE_INVENTION_LIC_REQUIRED = (1 << 5) ',	// This detail recipe requires an invention license to create
        <COH_DefEnum("NoRefund")> RECIPE_NO_REFUND = (1 << 6) ',	// This detail recipe when used as a voucher cannot be refunded
        <COH_DefEnum("FixedLevel")> RECIPE_FIXED_LEVEL = (1 << 7) ',	// This detail recipe awards a fixed level recipe Or enhancement, though it appears To have a level range In split pane UIs
        <COH_DefEnum("ForceClaimDelay")> RECIPE_FORCE_CLAIM_DELAY = (1 << 8) ',	// Claiming this recipe via the account / character items will force the UI to wait 5 seconds with no shortcut.
    End Enum
    Public Enum COH_Enum_RecipeRarity
        kRecipeRarity_Ubiquitous ',	// not used but here to keep in sync with salvage rarities
        <COH_DefEnum("Common")> kRecipeRarity_Common
        <COH_DefEnum("Uncommon")> kRecipeRarity_Uncommon
        <COH_DefEnum("Rare")> kRecipeRarity_Rare
        <COH_DefEnum("VeryRare")> kRecipeRarity_VeryRare
    End Enum
    Public Enum COH_Enum_RecipeType
        <COH_DefEnum("Workshop")> kRecipeType_Workshop
        <COH_DefEnum("Drop")> kRecipeType_Drop
        <COH_DefEnum("Memorized")> kRecipeType_Memorized
    End Enum

End Namespace