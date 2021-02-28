Namespace GameContent.Structures.Resources
    Public Class COH_Resource_GEO_ShadowInfo

#Region "Private Properties"
        Property [Shadows] As GEO.COH_Resource_GEO_Model()
        Property ShadowVertex As COH_Struct_Vector3()
        Property ShadowVertexCount As Int32
        Property ShadowNorms As COH_Struct_Vector3()
        Property Triangles As Int32()
        Property TrianglesCount As Int32
        Property ZeroArea_TriangleCount As Int32
        Property TrianglesNormals As COH_Struct_Vector3()
        Property OpenEdges As Byte()
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