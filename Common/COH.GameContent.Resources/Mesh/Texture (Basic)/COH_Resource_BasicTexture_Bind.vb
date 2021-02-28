Imports COH.CodeManagement.Enums
Imports COH.GameContent.Structures.Resources.Textures.COH_Resource_Texture_Header

Namespace GameContent.Structures.Resources
    Public Class COH_Resource_BasicTexture_Bind

        Const TEXLAYER_MAX_LAYERS = 11

#Region "Private Properties"
        Property name As String
        Property width As Integer ' Width and height of base texture (used for sprites/2D)
        Property height As Integer
        Property dirname As String ' Either directory name of the texture, or trick file name if this is a trick-made texture
        Property bind_blend_mode As COH_Resource_BasicTexture_BlendModeType() 'pixel shader to use (BLENDMODE_MULTIPLY etc)
        Property bind_scale As COH_Struct_Scale() = New COH_Struct_Scale(2) {} 'st scale for this tex and secondary texture, if any (tex_links[0])
        Property use_category As New COH_Enum_Texture_Usage() 'what is this texture used for?
        Property tex_layers As COH_Resource_BasicTexture() = New COH_Resource_BasicTexture(TEXLAYER_MAX_LAYERS - 1) {} 'set in texsetbinds, given ids in texConvertToGameFormat
        Property tex_swappable As Byte() = New Byte(TEXLAYER_MAX_LAYERS) {} ' Whether or not, on a MultiTexture shader, each layer can be swapped

        Property BitFlags As Byte
        '
        'Property U8 needs_alphasort:1
        'Property U8 allocated_scrollsScales:1 ' We allocated our own scrollsScales struct that needs to be freed
        'Property U8 allocated_byMiniTracker:1
        'Property U8 is_fallback_material:1

        Property texopt As COH_EnumFlags_Texture_Options
        Property scrollsScales As MeshRelated.Textures.COH_TextureOptions_ScrollScales()
        Property tex_lod As COH_Resource_BasicTexture_Bind ' generated on the fly when needed by the LOD system
        Property orig_bind As COH_Resource_BasicTexture_Bind ' points to self unless this is an lod of a tex bind
#End Region

#Region "Create New Instances"
        Public Sub New(Version As Integer, ByRef RawBytes As Byte())
            MyBase.New
            Update_FromBytes(Version, RawBytes)
        End Sub
#End Region

#Region "Update"
        Private Sub Update_FromBytes(Version As Integer, RawBytes As Byte())
            Dim Stream As New IO.MemoryStream(RawBytes)
            Using CurrentReader As New COH_BinaryReader(Stream)

            End Using
        End Sub
#End Region

    End Class
End Namespace