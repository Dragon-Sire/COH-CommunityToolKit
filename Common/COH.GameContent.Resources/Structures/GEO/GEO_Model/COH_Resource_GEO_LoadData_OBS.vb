Imports COH.GameContent.Structures.Resources.GEO
Imports COH.GameContent.Structures
Imports COH.GameContent.Structures.Enums
Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources
    Public Class COH_Resource_GEO_LoadData 'Almost Identical to Header...so...

#Region "Private Properties"
        Property ModelHeader As COH_Resource_GEO_ModelHeader
        Property name As New String(New Char(191) {})
        Property texnames As New COH_Resource_GEO_PackNames
        Property headersize As Integer
        Property datasize As Integer
        Property loadstate As Integer
        Property lasttimeused As Single
        Property type As Integer
        Property file As UInteger ''POINTER
        Property tex_load_style As COH_Enum_LoadHow ' from main or bg thread?
        Property geo_use_type As COH_Enums_GEOUsage
        Property header_data As Byte()
        Property geo_data As Byte()
        Property data_offset As Integer
        Property file_format_version As Integer
        Public lod_infos As MeshRelated.COH_LOD_Info
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