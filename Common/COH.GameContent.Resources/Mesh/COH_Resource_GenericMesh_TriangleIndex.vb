Namespace GameContent.Structures.Resources
    Public Class COH_Resource_GenericMesh_TriangleIndex

#Region "Private Properties"
        Property ID As Integer
        Property Index1 As Integer
        Property Index2 As Integer
        Property Index3 As Integer
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