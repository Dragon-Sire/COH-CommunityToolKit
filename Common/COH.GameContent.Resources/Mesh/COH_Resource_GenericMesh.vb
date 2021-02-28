Imports COH.GameContent.Structures.Resources.GEO

Namespace GameContent.Structures.Resources
    Public Class COH_Resource_GenericMesh

#Region "Enums" '//Move Later
        <Flags> Public Enum GMesh_Enum
            USE_POSITIONS = (1 << 0)
            USE_NORMALS = 1 << 1
            USE_TEX1S = 1 << 2
            USE_TEX2S = 1 << 3
            USE_BONEWEIGHTS = 1 << 4
            USE_NOMERGE = 1 << 5
        End Enum
#End Region

#Region "Private Properties"
        Property usagebits As Integer
        Property vert_count As Integer
        Property vert_max As Integer
        Property positions As COH_Struct_Vector3
        Property normals As COH_Struct_Vector3
        Property tex1s As COH_Struct_Vector2
        Property tex2s As COH_Struct_Vector2
        Property boneweights As COH_Struct_Vector4
        Property bonemats As COH_Resource_GenericMesh_BoneMat
        Property tri_count As Integer
        Property tri_max As Integer
        Property tris As COH_Resource_GenericMesh_TriangleIndex
        Property grid As COH_Resource_GenericMesh_PolyGrid
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