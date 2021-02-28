Namespace GameContent.Structures.Resources
    Public Class COH_Resource_GEO_LOD_Model

#Region "Private Properties"
        Property tri_percent As New Single()
        Property [error] As New Single()
        Property model As GEO.COH_Resource_GEOModel
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