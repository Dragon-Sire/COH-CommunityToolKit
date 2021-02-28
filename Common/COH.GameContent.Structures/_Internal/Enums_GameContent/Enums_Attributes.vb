Namespace CodeManagement.Enums
    Public Enum COH_Boolean
        ' Which power system to use for advancement, level lookup, etc.
        <COH_DefEnum("false", "kfalse")> [false] = 0
        <COH_DefEnum("true", "ktrue")> [true] = 1
    End Enum
    Public Enum COH_Enum_AttribStyle
        <COH_DefEnum("None")> kAttribStyle_None
        <COH_DefEnum("Percent")> kAttribStyle_Percent
        <COH_DefEnum("Magnitude")> kAttribStyle_Magnitude
        <COH_DefEnum("Distance")> kAttribStyle_Distance
        <COH_DefEnum("PercentMinus100")> kAttribStyle_PercentMinus100
        <COH_DefEnum("PerSecond")> kAttribStyle_PerSecond
        <COH_DefEnum("Speed")> kAttribStyle_Speed
        <COH_DefEnum("ResistanceDuration")> kAttribStyle_ResistanceDuration
        <COH_DefEnum("Multiply")> kAttribStyle_Multiply
        <COH_DefEnum("Integer")> kAttribStyle_Integer
        <COH_DefEnum("EnduranceReduction")> kAttribStyle_EnduranceReduction
        <COH_DefEnum("InversePercent")> kAttribStyle_InversePercent
    End Enum
    Public Enum COH_Enum_AttribType
        <COH_DefEnum("Cur")> kAttribType_Cur
        <COH_DefEnum("Str")> kAttribType_Str
        <COH_DefEnum("Res")> kAttribType_Res
        <COH_DefEnum("Max")> kAttribType_Max
        <COH_DefEnum("Mod")> kAttribType_Mod
        <COH_DefEnum("Abs")> kAttribType_Abs
        <COH_DefEnum("Special")> kAttribType_Special
        kAttribType_Count
    End Enum

    Public Enum COH_Enum_AttribSource
        kAttribSource_Unknown
        kAttribSource_Self
        kAttribSource_Player
        kAttribSource_Critter
    End Enum
End Namespace
