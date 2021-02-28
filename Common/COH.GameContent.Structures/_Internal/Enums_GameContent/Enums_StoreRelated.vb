Namespace CodeManagement.Enums
    <Flags> Public Enum COH_Enum_AccountProductFlags
        NotDefined = 0
        <COH_DefEnum("Unpublished")> PRODFLAG_NOT_PUBLISHED = 1 '1 << 0,	// item Is Not ready To show To the user yet
        <COH_DefEnum("FreeForVIP")> PRODFLAG_FREE_FOR_VIP = 4 '1 << 2
    End Enum
    Public Enum COH_Enum_InventoryType
        <COH_DefEnum("Certification")> kAccountInventoryType_Certification = 0
        <COH_DefEnum("Voucher")> kAccountInventoryType_Voucher = 1
        <COH_DefEnum("PlayerInventory")> kAccountInventoryType_PlayerInventory = 2
        kAccountInventoryType_Count
    End Enum
    Public Enum COH_Enum_Product_AuthBit
        PRODUCT_AUTHBIT_INVALID = 0
        <COH_DefEnum("RogueAccess")> PRODUCT_AUTHBIT_ROGUE_ACCESS = 1
        <COH_DefEnum("RogueCompleteBox")> PRODUCT_AUTHBIT_ROGUE_COMPLETE = 2
    End Enum
    Public Enum AccountStatusFlags
        ACCOUNT_STATUS_FLAG_DEFAULT = 0
        ACCOUNT_STATUS_FLAG_IS_VIP = 1 '1 << 0,	// For subscribers And others who Get everything free
        ACCOUNT_STATUS_FLAG_DEBUG_VIP = 2 '1 << 1,	// debug flag which doesn't get overwritten by loyalty update logic
    End Enum
    Public Enum BillingPlanID
        BILLING_PLAN_INACTIVE = 0
        BILLING_PLAN_ONE_MONTH = 1
        BILLING_PLAN_THREE_MONTH = 2
        BILLING_PLAN_SIX_MONTH = 3
        BILLING_PLAN_TWELVE_MONTH = 4
        BILLING_PLAN_FOUR_MONTH = 5
        BILLING_PLAN_EIGHT_MONTH = 6
        BILLING_PLAN_SIXTEEN_MONTH = 7
        BILLING_PLAN_TWO_MONTH = 8
        BILLING_PLAN_ONE_WEEK = 9
        BILLING_PLAN_TIME_CARD = 10
        BILLING_PLAN_TRIAL = 11
        BILLING_PLAN_PROMO_1 = 12
        BILLING_PLAN_PROMO_2 = 13
        BILLING_PLAN_GUILD_WARS = 14
        BILLING_PLAN_BETA = 15
        BILLING_PLAN_PRESALE = 16
        BILLING_PLAN_GUEST_ACCOUNT = 17
        BILLING_PLAN_NOT_DETERMINED = 19 ' // NOTICE WE SKIPPED ONE!
        BILLING_PLAN_EXTERNAL_COMPED = 97 ' // NOTICE WE SKIPPED A LOT!
        BILLING_PLAN_INTERNAL_COMPED = 98
        BILLING_PLAN_GM_COMPED = 99
    End Enum
    Public Enum AccountRequestType
        kAccountRequestType_CertificationGrant
        kAccountRequestType_CertificationClaim
        kAccountRequestType_Rename
        kAccountRequestType_Respec
        kAccountRequestType_Slot
        kAccountRequestType_ShardTransfer
        kAccountRequestType_MultiTransaction
        kAccountRequestType_UnknownTransaction '// used When you aren't sure which of the above the request is
        kAccountRequestType_Count
    End Enum
End Namespace