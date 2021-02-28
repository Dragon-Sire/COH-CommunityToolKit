Imports COH.CodeManagement.Enums
Imports COH.GameContent.Structures.Enums

Namespace GameContent.Structures.Resources.Anim
    Public Class COH_Resource_ANIM_SkeletonTrack
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Header"
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("Identifier")> Property FileAge As Integer
        <Category("Identifier")> Property HaderSize As Integer
        <Category("Identifier")> Property Name As String 'File name
        <Category("Identifier")> Property Name_BaseAnimation As String '.anim file to get missing bones, and heirarchy target wil heve a skeleton_heirarchy and have skel_ in the name
        <Category("Animation")> Property Max_Hip_Displacement As Single 'for visibility code
        <Category("Animation")> Property Length As Single 'of animation track, if any, in case the sequencer doesn't specify, kinda hack.
        <Category("Bones")> Property Bone_Tracks_count As Integer
        <Category("Storage")> Property CompressionUsed_Rotation As COH_AnimCompression
        <Category("Storage")> Property CompressionUsed_Position As COH_AnimCompression
        <Category("Other")> Property loadstate As Integer
        <Category("Other")> Property lasttimeused As Single
        <Category("Other")> Property spare_room As Integer() '//9
#End Region

#Region "Properties - Pointers / Offsets"
        <Category("System")> Property Backup_AnimTrack_Pointer As UInt32
        <Category("System")> Property BoneTracks_Pointer As UInt32
        <Category("System")> Property Skeleton_Heirarchy_Pointer As UInt32
#End Region

#Region "Proprties - ReadFrom Offsets"
        <Category("Bones")> Property Skeleton_Heirarchy As COH_Skeleton_Heirarchy 'only the _skel file in each folder needs one of these in data file, every one else just points to this file
        <Category("Bones")> Property Bone_Tracks As COH_Resource_ANIM_BoneTrack()
        <Category("Animation")> Property Backup_AnimTrack As COH_Resource_ANIM_SkeletonTrack 'contains defaults and the heirarchy
#End Region

#Region "CONSTS"
        Const BONES_ON_DISK = 100
        'Const	STATIC_ASSERT = (BONEID_COUNT <= BONES_ON_DISK)
        Const MAX_ANIMSETS = 1000  '//so big so they can be reloaded in development mode
        Const MAX_ANIMDATATRACKS = 100
        Const SIZE_OF_ROTKEY_UNCOMPRESSED = (16)
        Const SIZE_OF_ROTKEY_COMPRESSED_TO_5_BYTES = (5) '//quantized quaternion
        Const SIZE_OF_ROTKEY_COMPRESSED_TO_8_BYTES = (8)    '//stuff quat into shorts
        Const SIZE_OF_UNCOMPRESSED_POSKEY = (4 * 3)      '//full size Vec3  = (3 floats)
        Const SIZE_OF_POSKEY_COMPRESSED_TO_6_BYTES = (2 * 3) '//3 floats quantized to 2 byte chunks
        Const SIZE_OF_TIME = (4 * 1) '//1 float
        Const SIZE_OF_KEYCORRECTION = (2)
        Const CFACTOR_8BYTE_QUAT = 10000
        Const EFACTOR_8BYTE_QUAT = 0.0001
        Const ROTATION_KEY = 0
        Const POSITION_KEY = 1
        Const CFACTOR_6BYTE_POS = 32000
        Const EFACTOR_6BYTE_POS = 0.00003125 '// = ( = (F32) = ( = (F32)1/ = (F32)CFACTOR_6BYTE_POS))
        Const ROTATION_UNCOMPRESSED = (1 << 0)
        Const ROTATION_COMPRESSED_TO_5_BYTES = (1 << 1)
        Const ROTATION_COMPRESSED_TO_8_BYTES = (1 << 2)
        Const POSITION_UNCOMPRESSED = (1 << 3)
        Const POSITION_COMPRESSED_TO_6_BYTES = (1 << 4)
        Const ROTATION_DELTACODED = (1 << 5)
        Const POSITION_DELTACODED = (1 << 6)
        Const ROTATION_COMPRESSED_NONLINEAR = (1 << 7)
        Const POS_BIGGEST = 2000000 '//debug thingy
        Const LOOKUPSIZE12BIT = 4096
        Const COMPRESSEDQUATSIZE = 5
        Const MAX_ANIM_FILE_NAME_LEN = 256
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
        Public Function Clone() As COH_Resource_ANIM_SkeletonTrack
            Dim Result As COH_Resource_ANIM_SkeletonTrack = New COH_Resource_ANIM_SkeletonTrack
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
            HaderSize = CurrentReader.ReadUInt32
            Name = CurrentReader.ReadString_LengthFixed_UTF8(256, True)
            Name_BaseAnimation = CurrentReader.ReadString_LengthFixed_UTF8(256, True)
            Max_Hip_Displacement = CurrentReader.ReadSingle
            Length = CurrentReader.ReadSingle '60
            BoneTracks_Pointer = CurrentReader.ReadUInt32 '1800
            Bone_Tracks_count = CurrentReader.ReadUInt32 '68
            CompressionUsed_Rotation = CurrentReader.ReadInt32
            CompressionUsed_Position = CurrentReader.ReadInt32
            Skeleton_Heirarchy_Pointer = CurrentReader.ReadUInt32
            Backup_AnimTrack_Pointer = CurrentReader.ReadUInt32
            loadstate = CurrentReader.ReadInt32
            lasttimeused = CurrentReader.ReadSingle '556
            FileAge = CurrentReader.ReadInt32 '560
            spare_room = CurrentReader.Read_CrypticS_IntegerArray(9)
            If Skeleton_Heirarchy_Pointer > 0 Then
                CurrentReader.Position = Skeleton_Heirarchy_Pointer
                Skeleton_Heirarchy = New COH_Skeleton_Heirarchy()
                Skeleton_Heirarchy.Root = CurrentReader.ReadInt32
                Skeleton_Heirarchy.NumberBonesUsed = ((BoneTracks_Pointer - Skeleton_Heirarchy_Pointer) - 4) / 12
                Skeleton_Heirarchy.Skeleton_Hierarchy = New COH_Skeleton_Hierarchy_BoneLink(Skeleton_Heirarchy.NumberBonesUsed - 1) {} '//STRUCT IS 100, however it seems to be ignored
                For X = 0 To Skeleton_Heirarchy.NumberBonesUsed - 1
                    Skeleton_Heirarchy.Skeleton_Hierarchy(X) = New COH_Skeleton_Hierarchy_BoneLink(CurrentReader)
                Next
            End If
            If BoneTracks_Pointer > 0 Then
                CurrentReader.Position = BoneTracks_Pointer
                Bone_Tracks = New COH_Resource_ANIM_BoneTrack(Bone_Tracks_count - 1) {}
                For X = 0 To Bone_Tracks_count - 1
                    Bone_Tracks(X) = New COH_Resource_ANIM_BoneTrack(CurrentReader)
                Next
            End If
            If Backup_AnimTrack_Pointer > 0 Then
                '//Do I Need to Bother?
            End If
            Return True
        End Function
#End Region
    End Class
End Namespace