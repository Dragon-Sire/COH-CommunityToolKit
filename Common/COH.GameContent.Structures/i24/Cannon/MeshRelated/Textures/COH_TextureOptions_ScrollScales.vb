Namespace GameContent.Structures.MeshRelated.Textures
    Public Class COH_TextureOptions_ScrollScales
        Inherits COH_FileStructure

#Region "Enums"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Scroll Scales"
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("Scaling")> Property TextureOption_Scales As COH_Struct_Vector2()  ''texopt_scale[BLEND_NUM_BLEND_NAMES][2];

        <Category("Scrolling")> Property TextureOption_Scrolls As COH_Struct_Vector2() 'texopt_scroll[BLEND_NUM_BLEND_NAMES][2];
        <Category("Scrolling")> Property TextureOption_ScrollTypes As COH_Enum_Texture_ScrollType()

        <Category("Alpha")> Property Alpha_Mask As Byte ' Use just the alpha channel of the Mask layer
        <Category("Alpha")> Property Alpha_MaskWeight As Single
        <Category("Alpha")> Property HasRgb34 As Byte
        <Category("Alpha")> Property Alpha_Water As Byte ' flag to honor base1 texture alpha value when applying water (e.g. for puddles)

        <Category("Glow")> Property GlowAmount_Base As Byte
        <Category("Glow")> Property GlowAmount_Min As Byte
        <Category("Glow")> Property GlowAmount_Max As Byte

        <Category("Glow")> Property Glow_AddSubMaterial2 As Byte ' flag to add the glow texture to MULTI sub-material 2 instead of sub-material 1 (the default)
        <Category("Glow")> Property Glow_Tint As Byte ' flag to tint the glow by the current tint 'const color 1'

        <Category("Color")> Property Color1() As [Shared].Drawing.COH_Color_RGBA '= 'Color 4 bytes
        <Category("Color")> Property Color2() As [Shared].Drawing.COH_Color_RGBA '= 'Color 4 Bytes

        <Category("Specular")> Property Specular1() As [Shared].Drawing.COH_Color_RGBA '= 'Color 4 bytes
        <Category("Specular")> Property Specular2() As [Shared].Drawing.COH_Color_RGBA ' = 'Color 4 Bytes
        <Category("Specular")> Property SpecularExponent1 As Single()
        <Category("Specular")> Property SpecularExponent2 As Single()

        <Category("Reflectivity")> <DefaultValue(0)> Property Reflectivity As Single ' for environment mapping (deprecated)
        <Category("Reflectivity")> <DefaultValue(-1.0F)> Property Reflectivity_Base As Single
        <Category("Reflectivity")> <DefaultValue(-1.0F)> Property Reflectivity_Scale As Single
        <Category("Reflectivity")> <DefaultValue(-1.0F)> Property Reflectivity_Power As Single
        <Category("Reflectivity")> Property Reflect_Multiplier1 As Byte
        <Category("Reflectivity")> Property Reflect_Multiplier2 As Byte

        <Category("Reflectivity")> Property Reflectivity_Tint As Byte ' flag to tint environment reflections by current tint 'const color 1'
        <Category("Reflectivity")> Property Reflectivity_Desaturate As Byte ' flag to desaturate the environment reflection to grayscale before applying

        <Category("Diffuse")> Property Diffuse_Scale_Trick As COH_Struct_Vector3
        <Category("Ambient")> Property Ambient_Scale_Trick As COH_Struct_Vector3
        <Category("Ambient")> Property Ambient_Min As COH_Struct_Vector3

        'Redundant
        <Category("Redundant")> Property Ambient_Scale As COH_Struct_Vector3
        <Category("Redundant")> Property Diffuse_Scale As COH_Struct_Vector3

        Property debug_backpointer As COH_EnumFlags_Texture_Options
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings as COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings as COH_Serialization_Settings = Nothing)
            MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            TextureOption_Scales = New COH_Struct_Vector2(COH_Enum_Texture_BlendIndex.BLEND_NUM_BLEND_NAMES - 1) {}
            TextureOption_Scrolls = New COH_Struct_Vector2(COH_Enum_Texture_BlendIndex.BLEND_NUM_BLEND_NAMES - 1) {}
            TextureOption_ScrollTypes = New COH_Enum_Texture_ScrollType(COH_Enum_Texture_BlendIndex.BLEND_NUM_BLEND_NAMES - 1) {}
            Color1 = New [Shared].Drawing.COH_Color_RGBA(0, 0, 0, 0)
            Color2 = New [Shared].Drawing.COH_Color_RGBA(0, 0, 0, 0)
            Specular1 = New [Shared].Drawing.COH_Color_RGBA(255, 255, 255, 0)
            Specular2 = New [Shared].Drawing.COH_Color_RGBA(0, 0, 0, 0)
            Reflectivity = 0
            Reflectivity_Base = -1.0F
            Reflectivity_Power = -1.0F
            Reflectivity_Scale = -1.0F
            Alpha_Mask = 0
            Alpha_MaskWeight = 1
            Reflect_Multiplier1 = 0
            Reflect_Multiplier2 = 0
            GlowAmount_Base = 0
            GlowAmount_Min = 0
            GlowAmount_Max = 128
            Glow_AddSubMaterial2 = 0
            Glow_Tint = 0
            Alpha_Water = 0
            Ambient_Scale_Trick = New COH_Struct_Vector3(1, 1, 1)
            Diffuse_Scale_Trick = New COH_Struct_Vector3(1, 1, 1)
        End Sub
#End Region

#Region "Update"
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Throw New NotImplementedException()
        End Function
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
#End Region

    End Class
End Namespace