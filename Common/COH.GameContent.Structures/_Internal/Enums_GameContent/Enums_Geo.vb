Namespace CodeManagement.Enums
    <Flags> Public Enum COH_Group_Flags
        none = 0
        <COH_DefEnum("DisablePlanarReflections")> GROUP_DISABLEPLANARREFLECTIONS = 1
    End Enum
    <Flags> Public Enum COH_Enum_DefFlags
        None = 0
        <COH_DefEnum("Ungroupable")> DEF_UNGROUPABLE = 1
        <COH_DefEnum("FadeNode")> DEF_FADENODE = 2
        <COH_DefEnum("FadeNode2")> DEF_FADENODE2 = 4
        <COH_DefEnum("NoFogClip")> DEF_NOFOGCLIP = 8
        <COH_DefEnum("NoColl")> DEF_NOCOLL = 16
        <COH_DefEnum("NoOcclusion")> DEF_NOOCCLUSION = 32
    End Enum
    <Flags> Public Enum COH_Enum_OmniLightFlags
        None = 0
        <COH_DefEnum("Negative")> Negative = 1
    End Enum
    <Flags> Public Enum COH_Enum_SoundFlags
        None = 0
        <COH_DefEnum("Exclude")> Exclude = 1
    End Enum
    <Flags> Public Enum COH_Enum_AutoLODFlags As UInteger
        None = 0
        'LOD_IGNORE_SEAMS = 1
        <COH_DefEnum("ErrorTriCount")> LOD_ERROR_TRICOUNT = 2
        'LOD_ERROR_CONTRACTIONS = 4
        'LOD_PLACEMENT_ENDPOINTS = 8
        'LOD_GREY_TEX = 16
        'LOD_IGNORE_NORMAL_SEAMS = 32
        LOD_LEGACY = 64
        <COH_DefEnum("UseFallbackMaterial")> LOD_USEFALLBACKMATERIAL = 128
    End Enum
    <Flags> Public Enum COH_Enums_GEOUsage
        GEO_DONT_INIT_FOR_DRAWING = 1 << 0 '// just called from geoload
        GEO_INIT_FOR_DRAWING = 1 << 1 '// called from modelload
        GEO_USED_BY_WORLD = 1 << 2
        GEO_USED_BY_GFXTREE = 1 << 3
        GEO_GETVRML_FASTLOAD = 1 << 4
        GEO_USE_MASK = GEO_USED_BY_WORLD Or GEO_USED_BY_GFXTREE
    End Enum
    Public Enum GEO_Enums_MESH_BoneId
        BONEID_DEFAULT = 0
        BONEID_HIPS = 0
        BONEID_WAIST
        BONEID_CHEST
        BONEID_NECK
        BONEID_HEAD
        BONEID_COL_R
        BONEID_COL_L
        BONEID_UARMR
        BONEID_UARML
        BONEID_LARMR
        BONEID_LARML
        BONEID_HANDR
        BONEID_HANDL
        BONEID_F1_R
        BONEID_F1_L
        BONEID_F2_R
        BONEID_F2_L
        BONEID_T1_R
        BONEID_T1_L
        BONEID_T2_R
        BONEID_T2_L
        BONEID_T3_R
        BONEID_T3_L
        BONEID_ULEGR
        BONEID_ULEGL
        BONEID_LLEGR
        BONEID_LLEGL
        BONEID_FOOTR
        BONEID_FOOTL
        BONEID_TOER
        BONEID_TOEL

        BONEID_FACE
        BONEID_DUMMY
        BONEID_BREAST
        BONEID_BELT
        BONEID_GLOVEL
        BONEID_GLOVER
        BONEID_BOOTL
        BONEID_BOOTR
        BONEID_RINGL
        BONEID_RINGR
        BONEID_WEPL
        BONEID_WEPR     '// I love how extents are L/R but everything Else Is R/L
        BONEID_HAIR
        BONEID_EYES
        BONEID_EMBLEM
        BONEID_SPADL
        BONEID_SPADR
        BONEID_BACK
        BONEID_NECKLINE
        BONEID_CLAWL
        BONEID_CLAWR
        BONEID_GUN

        BONEID_RWING1
        BONEID_RWING2
        BONEID_RWING3
        BONEID_RWING4

        BONEID_LWING1
        BONEID_LWING2
        BONEID_LWING3
        BONEID_LWING4

        BONEID_MYSTIC

        BONEID_SLEEVEL
        BONEID_SLEEVER
        BONEID_ROBE
        BONEID_BENDMYSTIC

        BONEID_COLLAR
        BONEID_BROACH

        BONEID_BOSOMR
        BONEID_BOSOML

        BONEID_TOP          '// really "shirt" but that's an alias for chest
        BONEID_SKIRT
        BONEID_SLEEVES

        BONEID_BROW
        BONEID_CHEEKS
        BONEID_CHIN
        BONEID_CRANIUM
        BONEID_JAW
        BONEID_NOSE

        BONEID_HIND_ULEGL
        BONEID_HIND_LLEGL
        BONEID_HIND_FOOTL
        BONEID_HIND_TOEL
        BONEID_HIND_ULEGR
        BONEID_HIND_LLEGR
        BONEID_HIND_FOOTR
        BONEID_HIND_TOER
        BONEID_FORE_ULEGL
        BONEID_FORE_LLEGL
        BONEID_FORE_FOOTL
        BONEID_FORE_TOEL
        BONEID_FORE_ULEGR
        BONEID_FORE_LLEGR
        BONEID_FORE_FOOTR
        BONEID_FORE_TOER

        BONEID_LEG_L_JET1
        BONEID_LEG_L_JET2
        BONEID_LEG_R_JET1
        BONEID_LEG_R_JET2

        '// these are last!
        BONEID_COUNT
        BONEID_INVALID = -1


        Unnown = -2

    End Enum
    Public Enum COH_Enum_ClothCollisionShape
        <COH_DefEnum("None")> CLOTH_COL_NONE
        <COH_DefEnum("Sphere")> CLOTH_COL_SPHERE
        <COH_DefEnum("Plane")> CLOTH_COL_PLANE
        <COH_DefEnum("Cylinder")> CLOTH_COL_CYLINDER
        <COH_DefEnum("Balloon")> CLOTH_COL_BALLOON
        <COH_DefEnum("Box")> CLOTH_COL_BOX ' 5
        CLOTH_COL_SKIP = 4096
        CLOTH_COL_SPECIAL_BACKWARDS_FLAG = 4096
        CLOTH_COL_SPECIAL_FORWARDS_FLAG = 8192
        CLOTH_COL_CYLINDER_SPECIAL = (CLOTH_COL_CYLINDER + CLOTH_COL_SPECIAL_BACKWARDS_FLAG)
        CYLINDER_WithForwardFlag = (CLOTH_COL_CYLINDER + CLOTH_COL_SPECIAL_FORWARDS_FLAG)
        Balloon_WithForwardBlag = (CLOTH_COL_BALLOON + CLOTH_COL_SPECIAL_FORWARDS_FLAG)
    End Enum

End Namespace