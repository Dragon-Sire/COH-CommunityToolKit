Namespace GameContent.Structures.Resources
    Public Class COH_Resource_GenericMesh_BoneMat

#Region "Private Properties"
        Property Value1 As Byte
        Property Value2 As Byte
        Property Value3 As Byte
        Property Value4 As Byte
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