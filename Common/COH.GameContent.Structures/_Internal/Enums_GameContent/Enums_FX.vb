Namespace CodeManagement.Enums
    <Flags> Public Enum COH_Enum_HealthFX
        None = 0
        <COH_DefEnum("NoCollision")> HEALTHFX_NO_COLLISION = (1 << 0)
    End Enum
    <Flags> Public Enum COH_Enum_ParticleFlags
        None = 0
        <COH_DefEnum("AlwaysDraw")> PART_ALWAYS_DRAW = (1 << 0)
        <COH_DefEnum("FadeImmediatelyOnDeath")> PART_FADE_IMMEDIATELY_ON_DEATH = (1 << 1)
        <COH_DefEnum("Ribbon")> PART_RIBBON = (1 << 2)
        <COH_DefEnum("IgnoreFxTint")> PART_IGNORE_FX_TINT = (1 << 3)
    End Enum
    Public Enum COH_Enum_Particles
        <COH_DefEnum("Normal")> PARTICLE_NORMAL
        <COH_DefEnum("Additive")> PARTICLE_ADDITIVE
        <COH_DefEnum("Subtractive")> PARTICLE_SUBTRACTIVE
        <COH_DefEnum("PremultipliedAlpha")> PARTICLE_PREMULTIPLIED_ALPHA
        <COH_DefEnum("Multiply")> PARTICLE_MULTIPLY
        <COH_DefEnum("SubtractiveInverse")> PARTICLE_SUBTRACTIVE_INVERSE
    End Enum
    <Flags> Public Enum COH_Enum_FX_Transform
        <COH_DefEnum("None")> FX_NONE = 0
        <COH_DefEnum("Position")> FX_POSITION = 1 << 0
        <COH_DefEnum("Rotation")> FX_ROTATION = 1 << 1
        <COH_DefEnum("Scale")> FX_SCALE = 1 << 2
        FX_ROTATE_ALL = 1 << 3
        <COH_DefEnum("SuperRotation")> SuperRotation = (FX_ROTATION Or FX_ROTATE_ALL)
        <COH_DefEnum("All")> FX_ALL = FX_POSITION Or FX_ROTATION Or FX_SCALE
    End Enum
    Public Enum COH_Enum_FX_CollisionRotation
        <COH_DefEnum("UseCollisionNormal")> FX_CEVENT_USE_COLLISION_NORM = 0
        <COH_DefEnum("UseWorldUp")> FX_CEVENT_USE_WORLD_UP = 1
    End Enum


End Namespace