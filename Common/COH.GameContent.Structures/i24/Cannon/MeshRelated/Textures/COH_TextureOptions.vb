Namespace GameContent.Structures.MeshRelated.Textures
    Public Class COH_TextureOptions
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property FileName As String
            Get
                Return mFileName
            End Get
            Set(value As String)
                mFileName = value
            End Set
        End Property
        Property FileAge As Int32
            Get
                Return mFileAge
            End Get
            Set(value As Int32)
                mFileAge = value
            End Set
        End Property
        Property InternalName As String
            Get
                Return mInternalName
            End Get
            Set(value As String)
                mInternalName = value
            End Set
        End Property
        Property Gloss As Single
            Get
                Return mGloss
            End Get
            Set(value As Single)
                mGloss = value
            End Set
        End Property
        Property Surface As String
            Get
                Return mSurface
            End Get
            Set(value As String)
                mSurface = value
            End Set
        End Property
        Property Fade As COH_Struct_Vector2
            Get
                Return mFade
            End Get
            Set(value As COH_Struct_Vector2)
                mFade = value
            End Set
        End Property
        Property BlendNames As String()
            Get
                Return mBlendNames
            End Get
            Set(value As String())
                mBlendNames = value
            End Set
        End Property
        Property BlendType As COH_Enum_BlendModeShader
            Get
                Return mBlendType
            End Get
            Set(value As COH_Enum_BlendModeShader)
                mBlendType = value
            End Set
        End Property
        Property Flags As COH_EnumFlags_Texture_Options
            Get
                Return mFlags
            End Get
            Set(value As COH_EnumFlags_Texture_Options)
                mFlags = value
            End Set
        End Property
        Property ObjFlags As COH_Enum_ModelFlags
            Get
                Return mObjFlags
            End Get
            Set(value As COH_Enum_ModelFlags)
                mObjFlags = value
            End Set
        End Property
        Property DF_ObjName As String
            Get
                Return mDF_ObjName
            End Get
            Set(value As String)
                mDF_ObjName = value
            End Set
        End Property
        Property Swappable As Boolean()
            Get
                Return mSwappable
            End Get
            Set(value As Boolean())
                mSwappable = value
            End Set
        End Property
        Property SpecularExponent As Single
            Get
                Return mSpecularExponent1
            End Get
            Set(value As Single)
                mSpecularExponent1 = value
            End Set
        End Property
        Property SpecularExponent2 As Single
            Get
                Return mSpecularExponent2
            End Get
            Set(value As Single)
                mSpecularExponent2 = value
            End Set
        End Property
        Property Fallback As COH_TextureOptions_Fallback
            Get
                Return mFallback
            End Get
            Set(value As COH_TextureOptions_Fallback)
                mFallback = value
            End Set
        End Property
#End Region

#Region "Properties Embeded Structures"
        Property ScrollScales As COH_TextureOptions_ScrollScales
            Get
                Return mScrollScales
            End Get
            Set(value As COH_TextureOptions_ScrollScales)
                mScrollScales = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
        '//EmbeddedStructures
       Private mScrollScales As COH_TextureOptions_ScrollScales
       Private mBlendNames As String()
       Private mSwappable As Boolean()
        '//Other
       Private mName As String
       Private mFileName As String
       Private mFileAge As Int32
       Private mInternalName As String
       Private mGloss As Single
       Private mSurface As String
       Private mFade As COH_Struct_Vector2
       Private mBlendType As COH_Enum_BlendModeShader
       Private mFlags As COH_EnumFlags_Texture_Options
       Private mObjFlags As COH_Enum_ModelFlags
       Private mDF_ObjName As String
       Private mSpecularExponent1 As Single
       Private mSpecularExponent2 As Single
       Private mFallback As COH_TextureOptions_Fallback
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            '//Embedded
            mScrollScales = New COH_TextureOptions_ScrollScales
            mBlendNames = New String(COH_Enum_Texture_BlendIndex.BLEND_NUM_BLEND_NAMES - 1) {}
            mSwappable = New Boolean(COH_Enum_Texture_BlendIndex.BLEND_NUM_BLEND_NAMES - 1) {}
            '//Other
            mName = String.Empty
            mFileName = String.Empty
            mInternalName = String.Empty
            mSurface = String.Empty
            mGloss = 0
            mSurface = String.Empty
            mFade = New COH_Struct_Vector2
            mBlendType = 0
            mFlags = COH_EnumFlags_Texture_Options.None
            mObjFlags = 0
            mDF_ObjName = String.Empty
            mSpecularExponent1 = 8
            mSpecularExponent2 = 0
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_TextureOptions
            Dim Result As COH_TextureOptions = New COH_TextureOptions
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Return True
        End Function
        Private Function Import_From_Stream_TextureDefinition(ByRef CurrentReader As COH_BinaryReader, BlendIndex As COH_Enum_Texture_BlendIndex) As Boolean
            mBlendNames(BlendIndex) = CurrentReader.Read_CrypticS_String
            Dim EmbeddedStructureSize As Integer = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 8 Then Return False
            mScrollScales.TextureOption_Scales(BlendIndex) = CurrentReader.Read_CrypticS_Vector2
            mScrollScales.TextureOption_Scrolls(BlendIndex) = CurrentReader.Read_CrypticS_Vector2

            mScrollScales.TextureOption_ScrollTypes(BlendIndex) = CurrentReader.ReadInt32
            mSwappable(BlendIndex) = CurrentReader.Read_CrypticS_Boolean '//this is a byte, but aligned to 4?
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '//EmbeddedStructures
            mBlendNames = New String(COH_Enum_Texture_BlendIndex.BLEND_NUM_BLEND_NAMES - 1) {}
            mSwappable = New Boolean(COH_Enum_Texture_BlendIndex.BLEND_NUM_BLEND_NAMES - 1) {}
            mScrollScales = New COH_TextureOptions_ScrollScales(True)
            '//Normal
            mName = CurrentReader.Read_CrypticS_String
            mFileName = CurrentReader.Read_CrypticS_String
            mFileAge = CurrentReader.Read_CrypticS_TimeStamp
            mInternalName = CurrentReader.Read_CrypticS_String
            mGloss = CurrentReader.ReadSingle
            mSurface = CurrentReader.Read_CrypticS_String
            mFade = CurrentReader.Read_CrypticS_Vector2
            Dim EmbeddedStructureSize As Integer = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 8 Then Return False
            mScrollScales.TextureOption_Scales(COH_Enum_Texture_BlendIndex.BLEND_OLD_TEX_GENERIC_BLEND) = CurrentReader.Read_CrypticS_Vector2

            EmbeddedStructureSize = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 8 Then Return False
            mScrollScales.TextureOption_Scales(COH_Enum_Texture_BlendIndex.BLEND_OLD_TEX_BASE) = CurrentReader.Read_CrypticS_Vector2

            mBlendNames(COH_Enum_Texture_BlendIndex.BLEND_OLD_TEX_GENERIC_BLEND) = CurrentReader.Read_CrypticS_String
            mBlendNames(COH_Enum_Texture_BlendIndex.BLEND_BUMPMAP1) = CurrentReader.Read_CrypticS_String

            mBlendType = CurrentReader.ReadInt32 '//COH_Enum_BlendModeShader
            mFlags = CurrentReader.Read_CrypticS_Flags
            mObjFlags = CurrentReader.Read_CrypticS_Flags
            mDF_ObjName = CurrentReader.Read_CrypticS_String

            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_BASE1) = False Then Return False
            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_MULTIPLY1) = False Then Return False
            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_DUALCOLOR1) = False Then Return False
            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_ADDGLOW1) = False Then Return False
            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_BUMPMAP1) = False Then Return False
            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_MASK) = False Then Return False
            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_BASE2) = False Then Return False
            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_MULTIPLY2) = False Then Return False
            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_DUALCOLOR2) = False Then Return False
            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_BUMPMAP2) = False Then Return False
            If Import_From_Stream_TextureDefinition(CurrentReader, COH_Enum_Texture_BlendIndex.BLEND_CUBEMAP) = False Then Return False

            EmbeddedStructureSize = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 16 Then Return False
            mScrollScales.Color1 = New [Shared].Drawing.COH_Color_RGBA() With {.Red = CurrentReader.ReadUInt32, .Green = CurrentReader.ReadUInt32, .Blue = CurrentReader.ReadUInt32}
            mScrollScales.HasRgb34 = CurrentReader.ReadUInt32

            mScrollScales.Color2 = New [Shared].Drawing.COH_Color_RGBA() With {.Red = CurrentReader.ReadUInt32, .Green = CurrentReader.ReadUInt32, .Blue = CurrentReader.ReadUInt32}

            EmbeddedStructureSize = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 12 Then Return False
            mScrollScales.Specular1 = New [Shared].Drawing.COH_Color_RGBA() With {.Red = CurrentReader.ReadUInt32, .Green = CurrentReader.ReadUInt32, .Blue = CurrentReader.ReadUInt32}

            mScrollScales.Specular2 = New [Shared].Drawing.COH_Color_RGBA() With {.Red = CurrentReader.ReadUInt32, .Green = CurrentReader.ReadUInt32, .Blue = CurrentReader.ReadUInt32}
            mSpecularExponent1 = CurrentReader.ReadSingle
            '!!REDUNDENT!!mSpecularExponent1 = CurrentReader.ReadSingle
            mSpecularExponent2 = CurrentReader.ReadSingle 'off here this shouldn't be 8
            mScrollScales.Reflectivity = CurrentReader.ReadSingle
            mScrollScales.Reflectivity_Base = CurrentReader.ReadSingle 'like off 1 here
            mScrollScales.Reflectivity_Scale = CurrentReader.ReadSingle
            mScrollScales.Reflectivity_Power = CurrentReader.ReadSingle
            mScrollScales.Alpha_Mask = CurrentReader.ReadUInt32
            mScrollScales.Alpha_MaskWeight = CurrentReader.ReadSingle
            mScrollScales.Reflect_Multiplier1 = CurrentReader.ReadUInt32
            mScrollScales.Reflect_Multiplier2 = CurrentReader.ReadUInt32
            mScrollScales.GlowAmount_Base = CurrentReader.ReadUInt32
            mScrollScales.GlowAmount_Min = CurrentReader.ReadUInt32
            mScrollScales.GlowAmount_Max = CurrentReader.ReadUInt32
            mScrollScales.Glow_AddSubMaterial2 = CurrentReader.ReadUInt32 'off by 1 byte
            mScrollScales.Glow_Tint = CurrentReader.ReadUInt32
            mScrollScales.Reflectivity_Tint = CurrentReader.ReadUInt32
            mScrollScales.Reflectivity_Desaturate = CurrentReader.ReadUInt32
            mScrollScales.Alpha_Water = CurrentReader.ReadUInt32
            '!!REDUNDENT!!mAmbientScale = CurrentReader.ReadSingle
            '!!REDUNDENT!!mDiffuseScale = CurrentReader.ReadSingle
            '!!REDUNDENT!!mAmbientMin = CurrentReader.ReadSingle
            EmbeddedStructureSize = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 12 Then Return False
            mScrollScales.Diffuse_Scale_Trick = CurrentReader.Read_CrypticS_Vector3
            EmbeddedStructureSize = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 12 Then Return False
            mScrollScales.Ambient_Scale_Trick = CurrentReader.Read_CrypticS_Vector3
            mScrollScales.Ambient_Min = CurrentReader.Read_CrypticS_Vector3
            EmbeddedStructureSize = CurrentReader.ReadInt32 '//: If EmbeddedStructureSize <> 88 Then Return False
            mFallback = New COH_TextureOptions_Fallback()
            If mFallback.Import_From_Stream(CurrentReader) = False Then Return False
            Return True
        End Function
#End Region
    End Class
End Namespace
