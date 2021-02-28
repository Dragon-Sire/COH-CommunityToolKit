Imports COH.CodeManagement.Enums.Structures
Imports COH.HelperClasses

Namespace GameContent.Structures.Resources
    Public Class COH_Resource_GEO_VertexBuffer
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_Identifier")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "VBO"
            End Get
        End Property
#End Region

#Region "Properties"
        '//PER Triangle Data
        Property ElementID As Int32
        Property Triangles As Int32
        '//Per Vertex Data
        Property VertexID As Int32
        Property Vertices As COH_Struct_Vector3
        Property Norms As COH_Struct_Vector3
        Property Stencils As COH_Struct_Vector2
        Property Stencil2s As COH_Struct_Vector2
        Property Stencil3s As COH_Struct_Vector2 '//LightMap
        Property Tangents As COH_Struct_Vector4
        Property Weights As COH_Struct_Weight
        Property MaterialIndexs As COH_Struct_MaterialIndex
        '//Stencil Shadows
        Property Shadow As COH_Resource_GEO_ShadowInfo
        Property Bump_Initial As UInt32
        Property InUse As UInt32
        Property NoVBO As UInt32
        Property Stencil2_Initial As UInt32

        '//All Copied From Model
        Property TriangleCount As Integer
        Property VertexCount As Integer
        Property VertexBuffer As Integer
        Property TextureCount As Integer
        Property TextureID As COH_Struct_TextureID
        Property Flags As UInt32
        Property FrameID As Integer
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
#End Region

#Region "Import / Export"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '//PER Triangle Data
            ElementID = CurrentReader.ReadUInt32
            Triangles = CurrentReader.ReadInt32
            '//Per Vertex Data
            VertexID = CurrentReader.ReadInt32
            Vertices = CurrentReader.Read_CrypticS_Vector3
            Norms = CurrentReader.Read_CrypticS_Vector3
            Stencils = CurrentReader.Read_CrypticS_Vector2
            Stencil2s = CurrentReader.Read_CrypticS_Vector2
            Stencil3s = CurrentReader.Read_CrypticS_Vector2 '//LightMap
            Tangents = CurrentReader.Read_CrypticS_Vector4
            Weights = New COH_Struct_Weight(CurrentReader.ReadSingle, CurrentReader.ReadSingle)
            MaterialIndexs = New COH_Struct_MaterialIndex(CurrentReader.ReadSingle, CurrentReader.ReadSingle)
            '//Stencil Shadows
            Shadow = New COH_Resource_GEO_ShadowInfo(0, Nothing) '//////////////
            Bump_Initial = CurrentReader.ReadUInt32
            InUse = CurrentReader.ReadUInt32
            NoVBO = CurrentReader.ReadUInt32
            Stencil2_Initial = CurrentReader.ReadUInt32

            '//All Copied From Model
            TriangleCount = CurrentReader.ReadInt32
            VertexCount = CurrentReader.ReadInt32
            VertexBuffer = CurrentReader.ReadInt32
            TextureCount = CurrentReader.ReadInt32
            TextureID = New COH_Struct_TextureID(CurrentReader.ReadSingle, CurrentReader.ReadSingle)
            Flags = CurrentReader.ReadUInt32
            FrameID = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace