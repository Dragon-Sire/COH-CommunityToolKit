Namespace GameContent.Structures.Resources
    Public Class COH_Resource_GenericMesh_Reduction

#Region "Private Properties"
        Property NumberReductions As Int32()
        Property NumberTrianglesRemain As Single() 'one for each reduction step
        Property ErrorValues As Single() 'one for each reduction step
        Property NumberRemaps As Int32()
        Property NumberChanges As Int32()
        '//Triangle Remaps
        Property TotalRemaps As Int32
        Property Remaps As Int32() 'sequence of [oldidx,newidx,numtris]
        Property TotalRemaps_Triangles As Int32
        Property RemapTriangles As Int32()
        '//Vertex Changes
        Property TotalChanges As Int32
        Property Changes As Int32() 'Vertex Indexs
        Property Positions As Single() 'Vector3 Array
        Property Tex1s As Single() 'Vector2 Array
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