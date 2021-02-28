Imports System.Xml.Serialization
Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources.Anim
    Public Class COH_Resource_ANIM_BoneTrack
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "BoneTrack"
            End Get
        End Property
#End Region

#Region "Properties"
        <XmlAttribute> Property id As GEO_Enums_MESH_BoneId 'I am this bone's animation track
        Property Rotation_Offset As UInt32 'Full keys
        Property Position_Offset As UInt32 'Full keys
        Property rot_fullkeycount As UInt16
        Property pos_fullkeycount As UInt16 'only needed for debug

        Property rot_count As New UInt16
        Property pos_count As New UInt16 'why can't I figure out how to get rid of this?

        Property flags As SByte
        Property flags_Check As COH_AnimCompression
            Get
                Return flags
            End Get
            Set(value As COH_AnimCompression)
            End Set
        End Property

        Property pack_pad As UShort ' make padding explicit
#End Region

#Region "Private Properties"
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version, BuildType)
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

#Region "Clone"
        Public Function Clone() As COH_Resource_ANIM_BoneTrack
            Dim Result As COH_Resource_ANIM_BoneTrack = New COH_Resource_ANIM_BoneTrack
            'MyBase.CloneTo(Result)
            With Result
            End With
            Return Result
        End Function
#End Region

#Region "Read/Write"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Rotation_Offset = CurrentReader.ReadUInt32
            Position_Offset = CurrentReader.ReadUInt32
            rot_fullkeycount = CurrentReader.ReadUInt16
            pos_fullkeycount = CurrentReader.ReadUInt16

            rot_count = CurrentReader.ReadUInt16
            pos_count = CurrentReader.ReadUInt16

            id = CurrentReader.ReadSByte
            flags = CurrentReader.ReadSByte
            pack_pad = CurrentReader.ReadUInt16

            Return True
        End Function
#End Region
    End Class
End Namespace