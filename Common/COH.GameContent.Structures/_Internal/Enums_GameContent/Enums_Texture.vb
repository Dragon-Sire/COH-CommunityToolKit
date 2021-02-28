Namespace CodeManagement.Enums
    Public Enum COH_Enum_LoadHow
        None = 0
        TEX_LOAD_IN_BACKGROUND = 1
        TEX_LOAD_NOW_CALLED_FROM_MAIN_THREAD
        TEX_LOAD_NOW_CALLED_FROM_LOAD_THREAD
        TEX_LOAD_DONT_ACTUALLY_LOAD
        TEX_LOAD_IN_BACKGROUND_FROM_BACKGROUND
    End Enum
    <Flags> Public Enum COH_Enum_LoadState As Byte
        NOT_LOADED = 1 << 0
        LOADING = 1 << 1
        LOADED = 1 << 2
    End Enum
    Public Enum COH_Enum_DrawModeType
        DRAWMODE_SPRITE = 1
        DRAWMODE_DUALTEX
        DRAWMODE_COLORONLY
        DRAWMODE_DUALTEX_NORMALS
        DRAWMODE_DUALTEX_LIT_PP         '// vertex shader For per pixel lighting Of simple materials previously only vertex lighting (used When shadowmappig Is enabled) DRAWMODE_DUALTEX_NORMALS Variant
        DRAWMODE_FILL
        DRAWMODE_BUMPMAP_SKINNED
        DRAWMODE_HW_SKINNED
        DRAWMODE_BUMPMAP_NORMALS
        DRAWMODE_BUMPMAP_NORMALS_PP
        DRAWMODE_BUMPMAP_DUALTEX
        DRAWMODE_BUMPMAP_RGBS
        DRAWMODE_BUMPMAP_MULTITEX
        DRAWMODE_BUMPMAP_MULTITEX_RGBS
        DRAWMODE_BUMPMAP_SKINNED_MULTITEX
        DRAWMODE_DEPTH_ONLY
        DRAWMODE_DEPTHALPHA_ONLY
        DRAWMODE_DEPTH_SKINNED
        DRAWMODE_NUMENTRIES
    End Enum
    Public Enum COH_Enum_BlendModeShader As UInt16
        BLENDMODE_MODULATE
        <COH_DefEnum("Multiply")> BLENDMODE_MULTIPLY
        <COH_DefEnum("ColorBlendDual")> BLENDMODE_COLORBLEND_DUAL
        <COH_DefEnum("AddGlow")> BLENDMODE_ADDGLOW           '// building windows neon etc
        <COH_DefEnum("AlphaDetail")> BLENDMODE_ALPHADETAIL
        BLENDMODE_BUMPMAP_MULTIPLY
        BLENDMODE_BUMPMAP_COLORBLEND_DUAL
        BLENDMODE_WATER
        BLENDMODE_MULTI
        <COH_DefEnum("SunFlare")> BLENDMODE_SUNFLARE
        BLENDMODE_NUMENTRIES
    End Enum
    <Flags> Public Enum COH_EnumFlags_Texture_BlendModeBits As UInt16
        '// generic blendmode bits applicable to any shader
        BMB_DEFAULT = 0
        BMB_HIGH_QUALITY = 1 << 0
        BMB_SHADOWMAP = 1 << 1 '// ultra feature
        BMB_CUBEMAP = 1 << 2 '// ultra feature
        BMB_PLANAR_REFLECTION = 1 << 3 '// ultra feature
        '// blendmode bits specific to the MULTI material 'optimized' variants
        BMB_SINGLE_MATERIAL = 1 << 4
        BMB_BUILDING = 1 << 5
        '// Special "Development Only" shader variations
        'BMB_DEBUG = 1 << 6                      '// debug variant
        'BMB_VARIANT_COUNT		=1<<7            '// total possible permutations of compiled shader variants
        BMB_VARIANT_COUNT = 1 << 6               '// total possible permutations of compiled shader variants
        BMB_VARIANT_MASK = BMB_VARIANT_COUNT - 1
        BMB_OLDTINTMODE = 1 << 14   '// Chooses And old style dual blending in the MULTI material (currently very limited use in assets)
        BMB_NV1XWORLD = 1 << 15 '// for nVidia legacy register combiner logic Not actually a fragment program variation
    End Enum
    <Flags> Public Enum COH_EnumFlags_Texture_Options
        <COH_DefEnum("None")> None = 0
        TEXOPT_FADE = 1 << 0
        <COH_DefEnum("Truecolor")> TEXOPT_TRUECOLOR = 1 << 1
        TEXOPT_TREAT_AS_MULTITEX = 1 << 2 '// New texture possibly rendered With old shader but treat it As a New one
        TEXOPT_MULTITEX = 1 << 3 '// New texture TEXLAYERing scheme
        <COH_DefEnum("NoRandomAddGlow")> TEXOPT_NORANDOMADDGLOW = 1 << 4
        <COH_DefEnum("FullBright")> TEXOPT_FULLBRIGHT = 1 << 5
        <COH_DefEnum("ClampS")> TEXOPT_CLAMPS = 1 << 6
        <COH_DefEnum("ClampT")> TEXOPT_CLAMPT = 1 << 7
        <COH_DefEnum("AlwaysAddGlow")> TEXOPT_ALWAYSADDGLOW = 1 << 8
        <COH_DefEnum("MirrorS")> TEXOPT_MIRRORS = 1 << 9
        <COH_DefEnum("MirrorT")> TEXOPT_MIRRORT = 1 << 10
        <COH_DefEnum("Replaceable")> TEXOPT_REPLACEABLE = 1 << 11
        <COH_DefEnum("IsBumpMap")> TEXOPT_BUMPMAP = 1 << 12
        <COH_DefEnum("RepeatS")> TEXOPT_REPEATS = 1 << 13
        <COH_DefEnum("RepeatT")> TEXOPT_REPEATT = 1 << 14
        <COH_DefEnum("Cubemap")> TEXOPT_CUBEMAP = 1 << 15
        <COH_DefEnum("NoMip")> TEXOPT_NOMIP = 1 << 16
        <COH_DefEnum("Jpeg")> TEXOPT_JPEG = 1 << 17
        <COH_DefEnum("NoDither")> TEXOPT_NODITHER = 1 << 18
        <COH_DefEnum("NoColl")> TEXOPT_NOCOLL = 1 << 19
        <COH_DefEnum("SurfaceSlick")> TEXOPT_SURFACESLICK = 1 << 20
        <COH_DefEnum("SurfaceIcy")> TEXOPT_SURFACEICY = 1 << 21
        <COH_DefEnum("SurfaceBouncy")> TEXOPT_SURFACEBOUNCY = 1 << 22
        <COH_DefEnum("Border")> TEXOPT_BORDER = 1 << 23
        <COH_DefEnum("OldTint")> TEXOPT_OLDTINT = 1 << 24
        TEXOPT_DOUBLEFUSION = 1 << 25 '// deprecated
        <COH_DefEnum("PointSample")> TEXOPT_POINTSAMPLE = 1 << 26
        TEXOPT_NORMALMAP = 1 << 27
        TEXOPT_SPECINALPHA = 1 << 28
        <COH_DefEnum("FallbackForceOpaque")> TEXOPT_FALLBACKFORCEOPAQUE = 1 << 29
    End Enum
    <Flags> Public Enum COH_EnumFlags_Texture_ImageFormat
        TEX_ALPHA = 1 << 0
        TEX_RGB8 = 1 << 1
        TEX_COMP4 = 1 << 2
        TEX_COMP8 = 1 << 3
        TEX_TGA = 1 << 5
        TEX_DDS = 1 << 6
        TEX_CUBEMAPFACE = 1 << 9
        TEX_REPLACEABLE = 1 << 10
        TEX_BUMPMAP = 1 << 11
        TEX_JPEG = 1 << 13
    End Enum
    Public Enum COH_Enum_Texture_PixelFormat
        TEXFMT_8BIT
        TEXFMT_I_8
        TEXFMT_16BIT
        TEXFMT_ARGB_1555
        TEXFMT_ARGB_0565
        TEXFMT_ARGB_4444
        TEXFMT_32BIT
        TEXFMT_ARGB_8888
        TEXFMT_ARGB_0888
        TEXFMT_P_8
        TEXFMT_RAW_DDS '// For loading raw data To be uncompressed In software
    End Enum
    Public Enum COH_Enum_Texture_Usage
        TEX_FOR_UI = 1 << 0
        TEX_FOR_FX = 1 << 1
        TEX_FOR_ENTITY = 1 << 2
        TEX_FOR_WORLD = 1 << 3
        TEX_FOR_UTIL = 1 << 4
        TEX_FOR_NOTSURE = 1 << 5
    End Enum
    Public Enum COH_Enum_Texture_BlendIndex
        BLEND_OLD_TEX_BASE
        BLEND_OLD_TEX_GENERIC_BLEND
        BLEND_BASE1
        BLEND_MULTIPLY1
        BLEND_BUMPMAP1
        BLEND_DUALCOLOR1
        BLEND_MASK
        BLEND_BASE2
        BLEND_MULTIPLY2
        BLEND_BUMPMAP2
        BLEND_DUALCOLOR2
        BLEND_ADDGLOW1
        BLEND_CUBEMAP
        BLEND_NUM_BLEND_NAMES
    End Enum
    Public Enum COH_Enum_Texture_ScrollType
        TEXOPTSCROLL_NORMAL
        TEXOPTSCROLL_PINGPONG
        TEXOPTSCROLL_OVAL
    End Enum
    <Flags> Public Enum COH_EnumFlags_Tricks
        None = 0
        <COH_DefEnum("Additive")> TRICK_ADDITIVE = 1 << 0
        <COH_DefEnum("Subtractive")> TRICK_SUBTRACTIVE = 1 << 1
        <COH_DefEnum("FrontFace")> TRICK_FRONTYAW = 1 << 2
        <COH_DefEnum("CameraFace")> TRICK_FRONTFACE = 1 << 3
        <COH_DefEnum("AlphaCutout")> TRICK_ALPHACUTOUT = 1 << 4
        Unknown1 = 1 << 5
        <COH_DefEnum("DoubleSided")> TRICK_DOUBLESIDED = 1 << 6
        <COH_DefEnum("NoZTest")> TRICK_NOZTEST = 1 << 7
        <COH_DefEnum("ReflectTex1")> TRICK_REFLECT_TEX1 = 1 << 8
        <COH_DefEnum("FancyWaterOffOnly")> TRICK_FANCYWATEROFFONLY = 1 << 9 '// Legacy, not good practice, or unused
        <COH_DefEnum("NightLight")> TRICK_NIGHTLIGHT = 1 << 10
        <COH_DefEnum("NoZWrite")> TRICK_NOZWRITE = 1 << 11
        <COH_DefEnum("LightmapsOffOnly")> TRICK_LIGHTMAPSOFFONLY = 1 << 12 '// Legacy, not good practice, or unused
        <COH_DefEnum("NoDraw")> TRICK_HIDE = 1 << 13 '// Legacy, not good practice, or unused
        Unknown2 = 1 << 14
        Unknown3 = 1 << 15
        <COH_DefEnum("NoColl")> TRICK_NOCOLL = 1 << 16
        Unknown4 = 1 << 17
        Unknown5 = 1 << 18
        <COH_DefEnum("NoFog")> TRICK_NOFOG = 1 << 19
        Unknown6 = 1 << 20
        <COH_DefEnum("EditorVisible")> TRICK_EDITORVISIBLE = 1 << 21
        <COH_DefEnum("BaseEditVisible")> TRICK_BASEEDITVISIBLE = 1 << 22
        <COH_DefEnum("LightFace")> TRICK_LIGHTFACE = 1 << 23
        <COH_DefEnum("ReflectTex0")> TRICK_REFLECT = 1 << 24
        Unknown7 = 1 << 25
        <COH_DefEnum("SimpleAlphaSort")> TRICK_SIMPLEALPHASORT = 1 << 26 '// Legacy, not good practice, or unused
        Unknown8 = 1 << 27
        Unknown9 = 1 << 28
        <COH_DefEnum("SelectOnly")> TRICK_PLAYERSELECT = 1 << 29
        <COH_DefEnum("NoCameraCollide")> TRICK_NOCAMERACOLLIDE = 1 << 30
        <COH_DefEnum("NotSelectable")> TRICK_NOT_SELECTABLE = 1 << 31
    End Enum
    Public Enum COH_Enum_BlendType
        <COH_DefEnum("Overlay")> TWBLEND_OVERLAY
        <COH_DefEnum("Multiply")> TWBLEND_MULTIPLY
        <COH_DefEnum("Add")> TWBLEND_ADD
        <COH_DefEnum("Subtract")> TWBLEND_SUBTRACT
        <COH_DefEnum("Replace")> TWBLEND_REPLACE
    End Enum
    Public Enum COH_Enum_FilterType
        <COH_DefEnum("None")> TWFILTER_NONE
        <COH_DefEnum("Blur")> TWFILTER_BLUR
        <COH_DefEnum("DropShadow")> TWFILTER_DROPSHADOW
        <COH_DefEnum("Desaturate")> TWFILTER_DESATURATE
    End Enum
    Public Enum COH_Enum_LayerStretch
        <COH_DefEnum("None")> TWLS_NONE
        <COH_DefEnum("Full")> TWLS_FULL
        <COH_DefEnum("Tile")> TWLS_TILE
    End Enum
    Public Enum COH_Enum_LayerType
        <COH_DefEnum("None")> TWLT_NONE
        <COH_DefEnum("BaseImage")> TWLT_BASEIMAGE
        <COH_DefEnum("Text")> TWLT_TEXT
        <COH_DefEnum("Image")> TWLT_IMAGE
    End Enum
    Public Enum COH_Enum_TexWordParam
        <COH_DefEnum("TexWordParam1")> TexWordParam1 = 0
        <COH_DefEnum("TexWordParam2")> TexWordParam2 = 1
        <COH_DefEnum("TexWordParam3")> TexWordParam3 = 2
        <COH_DefEnum("TexWordParam4")> TexWordParam4 = 3
        <COH_DefEnum("TexWordParam5")> TexWordParam5 = 4
        <COH_DefEnum("TexWordParam6")> TexWordParam6 = 5
        <COH_DefEnum("TexWordParam7")> TexWordParam7 = 6
        <COH_DefEnum("TexWordParam8")> TexWordParam8 = 7
        <COH_DefEnum("TexWordParam9")> TexWordParam9 = 8
        <COH_DefEnum("TexWordParam10")> TexWordParam10 = 9
    End Enum

End Namespace