Imports COH.TOOLS.GameContent.HelperClasses

Namespace GameContent.Structures.Resources
    Public Class COH_Resource_BasicTexture_cTri

#Region "Private Properties"
        Property Vector As COH_Struct_Vector3
        Property Vector2 As COH_Struct_Vector2
        Property Vector3 As COH_Struct_Vector2
        Property MidPoint As COH_Struct_Vector2
        Property Ext As COH_Struct_Vector2
        Property Normal As COH_Struct_Vector3
        Property Scale As Single
        Property Flags As UInt32
        Property SurfaceTexture As COH_Resource_BasicTexture '// wood, metal, etc.
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