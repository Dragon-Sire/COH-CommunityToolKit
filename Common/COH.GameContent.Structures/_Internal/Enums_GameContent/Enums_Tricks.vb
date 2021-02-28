Namespace CodeManagement.Enums
    <Flags> Public Enum COH_Enum_TricksAnimationFlags As UInt32
        <COH_DefEnum("FRAMESNAP")> STANIM_FRAMESNAP = (1 << 0)
        STANIM_PINGPONG = (1 << 1)
        <COH_DefEnum("LOCAL_TIMER")> STANIM_LOCAL_TIMER = (1 << 2)
        <COH_DefEnum("GLOBAL_TIMER")> STANIM_GLOBAL_TIMER = (1 << 3)
    End Enum
    <Flags> Public Enum COH_Enum_ModelFlags
        <COH_DefEnum("ForceAlphaSort")> OBJ_ALPHASORT = 1 << 0 '// Legacy, Not good practice, Or unused
        <COH_DefEnum("FancyWater")> OBJ_FANCYWATER = 1 << 1
        <COH_DefEnum("FullBright")> OBJ_FULLBRIGHT = 1 << 2
        <COH_DefEnum("SunFlare")> OBJ_SUNFLARE = 1 << 3 '// Legacy, Not good practice, Or unused
        <COH_DefEnum("NoLightAngle")> OBJ_NOLIGHTANGLE = 1 << 4
        Unknown1 = 1 << 5
        Unknown2 = 1 << 6
        OBJ_LOD = 1 << 7
        <COH_DefEnum("TreeDraw")> OBJ_TREEDRAW = 1 << 8 '// Legacy, Not good practice, Or unused
        OBJ_ALLOW_MULTISPLIT = 1 << 9
        <COH_DefEnum("ForceOpaque")> OBJ_FORCEOPAQUE = 1 <<10 '// Legacy, Not good practice, Or unused
        OBJ_BUMPMAP = 1 << 11
        <COH_DefEnum("WorldFx")> OBJ_WORLDFX = 1 << 12 '//draw this object using model draw
        OBJ_CUBEMAP = 1 << 13
        OBJ_DRAWBONED = 1 << 14 '//draw this Object Using model draw boned node
        <COH_DefEnum("StaticFx")> OBJ_STATICFX = 1 << 15 '//add Static lighting To this Object
        OBJ_HIDE = 1 << 16 '//don't draw me except in wireframe
        Unknown3 = 1 << 17
        OBJ_ALPHASORTALL = 1 << 18  '// All subs On this model must be alpha sorted
        <COH_DefEnum("DontCastShadowMap")> OBJ_DONTCASTSHADOWMAP = 1 << 19 '// will not appear in the shadow map
        <COH_DefEnum("DontReceiveShadowMap")> OBJ_DONTRECEIVESHADOWMAP = 1 << 20 '// will not receive shadows from the shadow map
    End Enum

End Namespace