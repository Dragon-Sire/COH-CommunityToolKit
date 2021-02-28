Imports COH.CodeManagement.Enums
Imports COH.GameContent.Structures.Resources_Simplified

Namespace GameContent.Structures.Resources.Anim
    Public Class COH_Resource_Anim
        Inherits COH_FileStructure

#Region "Properties"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Anim"
            End Get
        End Property
        Shared Property LookupTable As Single() '= New Single(LOOKUPSIZE12BIT - 1) {}
        Property SkeletonTrack As COH_Resource_ANIM_SkeletonTrack
        Property Bones As COH_Skeleton_BoneLocation()
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
        End Sub
        Public Overrides Function EntryType() As COH_Supported_ContentType
            Return COH_Supported_ContentType.Resource_ANIMATION
        End Function
#End Region

#Region "DynamicMenus"
        Public Overrides Function Retrieve_DynamicMenus() As List(Of DynamicMenu_Cmmand)
            Dim List As New List(Of DynamicMenu_Cmmand)
            List.Add(New DynamicMenu_Cmmand("Extract Skeleton", DynamicMenu_CommandType.Extract_ToXML, "Extract_Skeleton"))
            Return List
        End Function
#End Region

#Region "Extract Heirarchy"
        Public Function Extract_SkeletonHeirarchy() As COH_Skeleton_Heirarchy
            If SkeletonTrack Is Nothing Then Return Nothing
            If SkeletonTrack.Skeleton_Heirarchy Is Nothing Then Return Nothing
            Dim Result As COH_Skeleton_Heirarchy = SkeletonTrack.Skeleton_Heirarchy.Clone
            Return Result
        End Function
        Public Function Retrieve_BoneLocation(TheID As GEO_Enums_MESH_BoneId) As COH_Skeleton_BoneLocation
            For Each Bone In Bones
                If Bone.ID = TheID Then Return Bone
            Next
            Return Nothing
        End Function
#End Region

#Region "Extract Skeleton"
        Public Function Extract_Skeleton() As COH_Resource_GEO_Skeleton
            Dim SkelH = Extract_SkeletonHeirarchy()
            If SkelH Is Nothing Then Return Nothing

            Dim ThemBones As New List(Of COH_Resource_GEO_SkeletonBone)
            Dim BonesNodeIndex As Integer = 0
            CreateSkeleton_FromHeirarchy(SkelH, SkelH.Root, Nothing, ThemBones, 0)

            Dim TheSkeleton As New COH_Resource_GEO_Skeleton
            With TheSkeleton
                .Name = SkeletonTrack.Name
                .Root = SkelH.Root
                .NumberBonesUsed = SkelH.Root
                .Bones = ThemBones.ToArray
            End With
            Return TheSkeleton
        End Function
        Private Sub CreateSkeleton_FromHeirarchy(ByRef BonesH As COH_Skeleton_Heirarchy, ByRef CurrentIndex As Integer, ByRef ParentBone As COH_Resource_GEO_SkeletonBone, ByRef BoneList As List(Of COH_Resource_GEO_SkeletonBone), ByRef NumberBonesAdded As Integer)
            Dim CurrentBone As GEO_Enums_MESH_BoneId = CurrentIndex
            Dim BoneLink As COH_Skeleton_Hierarchy_BoneLink = Nothing
            Do Until CurrentBone = GEO_Enums_MESH_BoneId.BONEID_INVALID
                BoneLink = BonesH.Skeleton_Hierarchy(CurrentBone)
                Dim NewBone As New COH_Resource_GEO_SkeletonBone
                With NewBone
                    .ID = BoneLink.ID
                    .ParentIndex = If(ParentBone Is Nothing, -1, ParentBone.BoneIndex)
                    .BoneIndex = NumberBonesAdded

                    Dim Location = Retrieve_BoneLocation(BoneLink.ID)
                    If Not (Location Is Nothing) Then
                        .FirstPosition = If(Location.Position Is Nothing, New COH_Struct_Vector3, Location.Position(0))
                        .FirstRotation = If(Location.Rotation Is Nothing, New COH_Struct_Quat, Location.Rotation(0))
                    End If

                    Dim NewVector As COH_Struct_Vector3
                    If BoneLink.ID = 0 Or (ParentBone Is Nothing) Then
                        NewVector = .FirstPosition
                    Else
                        Dim ParentBoneVector As COH_Struct_Vector3 = ParentBone.ConnectedPosition
                        NewVector = ParentBoneVector.AddVec3(New COH_Struct_Vector3(.FirstPosition.Retrieve_Singles))
                    End If
                    .ConnectedPosition = NewVector
                    .ConnectedRotation = .FirstRotation '//Not Supposed to use in BASE ANIM
                    '.BindPose = SharpDX.Matrix.Transformation(New COH_Struct_Vector3(0, 0, 0), New SharpDX.Quaternion(0, 0, 0, 0), New COH_Struct_Vector3(1, 1, 1), New COH_Struct_Vector3(0, 0, 0), New SharpDX.Quaternion(BoneLink.FirstRotation.Retrieve_Singles), New COH_Struct_Vector3(BoneLink.FirstPosition.Retrieve_Singles))
                    '.BindPose = SharpDX.Matrix.Translation(NewVector)
                End With
                If ParentBone Is Nothing Then
                    BoneList.Add(NewBone)
                Else
                    ParentBone.Children.Add(NewBone)
                End If
                NumberBonesAdded += 1
                If BoneLink.Child > -1 Then
                    CreateSkeleton_FromHeirarchy(BonesH, BoneLink.Child, NewBone, BoneList, NumberBonesAdded)
                End If
                CurrentBone = BoneLink.Next
            Loop
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_Anim
            Dim Result As COH_Resource_Anim = New COH_Resource_Anim
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
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
            SkeletonTrack = New COH_Resource_ANIM_SkeletonTrack(CurrentReader)
            Bones = New COH_Skeleton_BoneLocation(SkeletonTrack.Bone_Tracks_count - 1) {}
            For X = 0 To SkeletonTrack.Bone_Tracks_count - 1
                Bones(X) = Convert_ToBoneLocation(CurrentReader, SkeletonTrack.Bone_Tracks(X))
            Next
            If SkeletonTrack.Skeleton_Heirarchy Is Nothing Then Return True
            Dim Location As COH_Skeleton_BoneLocation = Nothing
            Return True
        End Function
        Private Function Convert_ToBoneLocation(ByRef CurrentReader As COH_BinaryReader, ByRef BoneTrack As COH_Resource_ANIM_BoneTrack) As COH_Skeleton_BoneLocation
            Dim Result As New COH_Skeleton_BoneLocation
            Result.ID = BoneTrack.id
            If Convert_ToBoneLocation_Rotation(CurrentReader, BoneTrack, Result.Rotation) = False Then ForceNotValid()
            Result.Position = Convert_ToBoneLocation_Position(CurrentReader, BoneTrack)
            Return Result
        End Function
        Private Function Convert_ToBoneLocation_Rotation(ByRef CurrentReader As COH_BinaryReader, ByRef BoneTrack As COH_Resource_ANIM_BoneTrack, ByRef Result As COH_Struct_Quat()) As Boolean
            If BoneTrack.Rotation_Offset = 0 Then
                Return Nothing
            End If
            CurrentReader.Position = BoneTrack.Rotation_Offset
            Result = New COH_Struct_Quat(BoneTrack.rot_fullkeycount - 1) {}
            If BoneTrack.flags_Check And COH_AnimCompression.ROTATION_UNCOMPRESSED Then
                For X = 0 To BoneTrack.rot_fullkeycount - 1
                    Dim Singles As Single() = CurrentReader.Read_CrypticS_SingleArray(4)
                    Result(X) = New COH_Struct_Quat(Singles)
                Next
            ElseIf BoneTrack.flags_Check And COH_AnimCompression.ROTATION_COMPRESSED_TO_8_BYTES Then
                For X = 0 To BoneTrack.rot_fullkeycount - 1
                    Dim Singles As Single() = New Single(3) {}
                    Singles(0) = Decompress_8Bytes_ToSingle(CurrentReader.ReadInt16)
                    Singles(1) = Decompress_8Bytes_ToSingle(CurrentReader.ReadInt16)
                    Singles(2) = Decompress_8Bytes_ToSingle(CurrentReader.ReadInt16)
                    Singles(3) = Decompress_8Bytes_ToSingle(CurrentReader.ReadInt16)
                    Result(X) = New COH_Struct_Quat(Singles)
                Next
            ElseIf BoneTrack.flags_Check And COH_AnimCompression.ROTATION_COMPRESSED_TO_5_BYTES Then
                For X = 0 To BoneTrack.rot_fullkeycount - 1
                    Dim NewValue As COH_Struct_Quat = Nothing
                    If Decompress_5Byte_Quat(CurrentReader.ReadBytes(5), NewValue) = False Then Return False
                    Result(X) = NewValue
                Next
            ElseIf BoneTrack.flags_Check And COH_AnimCompression.ROTATION_COMPRESSED_NONLINEAR Then
                For X = 0 To BoneTrack.rot_fullkeycount - 1
                    Dim NewValue As COH_Struct_Quat = Nothing
                    If Decompress_5Byte_Quat_NonLinear(CurrentReader.ReadBytes(5), NewValue) = False Then Return False
                    Result(X) = NewValue
                Next
            ElseIf BoneTrack.flags_Check And COH_AnimCompression.ROTATION_DELTACODED Then
                'COH_LibraryEventControl.Instance.Trigger_ErrorOccured(COH_Event_Error.COH_ErrorEvent.ControlledError, "SomeBody was too Lazy to add Support for Bone Rotation DeltaCoded", Nothing, True)
                'COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)
                Return False
            End If
            Return True
        End Function
        Private Function Convert_ToBoneLocation_Position(ByRef CurrentReader As COH_BinaryReader, ByRef BoneTrack As COH_Resource_ANIM_BoneTrack) As COH_Struct_Vector3()
            If BoneTrack.Position_Offset = 0 Then
                Return Nothing
            End If
            CurrentReader.Position = BoneTrack.Position_Offset
            Dim Result As COH_Struct_Vector3() = New COH_Struct_Vector3(BoneTrack.pos_fullkeycount - 1) {}
            If BoneTrack.flags_Check And COH_AnimCompression.POSITION_UNCOMPRESSED Then
                For X = 0 To BoneTrack.pos_fullkeycount - 1
                    Dim Singles As Single() = CurrentReader.Read_CrypticS_SingleArray(3)
                    Result(X) = New COH_Struct_Vector3(Singles)
                Next
            ElseIf BoneTrack.flags_Check And COH_AnimCompression.POSITION_COMPRESSED_TO_6_BYTES Then
                For X = 0 To BoneTrack.pos_fullkeycount - 1
                    Dim Singles As Single() = New Single(2) {}
                    Singles(0) = Decompress_6Bytes_ToSingle(CurrentReader.ReadInt16)
                    Singles(1) = Decompress_6Bytes_ToSingle(CurrentReader.ReadInt16)
                    Singles(2) = Decompress_6Bytes_ToSingle(CurrentReader.ReadInt16)
                    Result(X) = New COH_Struct_Vector3(Singles)
                Next
            ElseIf BoneTrack.flags_Check And COH_AnimCompression.POSITION_DELTACODED Then
                'COH_LibraryEventControl.Instance.Trigger_ErrorOccured(COH_Event_Error.COH_ErrorEvent.ControlledError, "SomeBody was too Lazy to add Support for Bone Position DeltaCoded", Nothing, True)
                'COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)
                ForceNotValid()
            Else
                ForceNotValid()
            End If
            Return Result
        End Function
        Private Function Decompress_6Bytes_ToSingle(Value As Int16) As Single
            'CFACTOR_6BYTE_POS 32000
            'EFACTOR_6BYTE_POS 0.00003125 //((F32)((F32)1/(F32)CFACTOR_6BYTE_POS))
            Return (Convert.ToSingle(Value) * 0.00003125)
        End Function
        Private Function Decompress_8Bytes_ToSingle(Value As Int16) As Single
            'CFACTOR_8BYTE_QUAT 10000
            'EFACTOR_8BYTE_QUAT 0.0001
            Return (Convert.ToSingle(Value) * 0.0001)
        End Function
        Private Function Decompress_5Byte_Quat(ByVal Buffer() As Byte, ByRef Result As COH_Struct_Quat) As Boolean
            If LookupTable Is Nothing OrElse LookupTable.Count < LOOKUPSIZE12BIT Then Create_LookUpTable()
            Dim Values As UInt32() = Nothing
            Dim QuatValues As Single() = New Single(3) {}
            Dim Missing As Int32
            If UnPack_5Byte_Quat(Buffer, Values, Missing) = False Then Return False
            For X = 0 To 3
                If X <> Missing Then
                    QuatValues(X) = LookupTable(Values(X))
                End If
            Next
            Dim SQR As Single
            QuatValues(Missing) = 0
            If Missing = 3 Then
                SQR = ((1 - QuatValues(2) * QuatValues(2)) - QuatValues(1) * QuatValues(1)) - QuatValues(0) * QuatValues(0)
                If SQR < 0 Then SQR = 0
                QuatValues(3) = Math.Sqrt(SQR)
            ElseIf Missing = 2 Then
                SQR = ((1 - QuatValues(3) * QuatValues(3)) - QuatValues(1) * QuatValues(1)) - QuatValues(0) * QuatValues(0) + 0.001
                If SQR < 0 Then SQR = 0
                QuatValues(2) = Math.Sqrt(SQR)
            ElseIf Missing = 1 Then
                SQR = ((1 - QuatValues(3) * QuatValues(3)) - QuatValues(2) * QuatValues(2)) - QuatValues(0) * QuatValues(0)
                If SQR < 0 Then SQR = 0
                QuatValues(1) = Math.Sqrt(SQR)
            ElseIf Missing = 0 Then
                SQR = ((1 - QuatValues(3) * QuatValues(3)) - QuatValues(2) * QuatValues(2)) - QuatValues(1) * QuatValues(1)
                If SQR < 0 Then SQR = 0
                QuatValues(0) = Math.Sqrt(SQR)
            End If
            Result = New COH_Struct_Quat(QuatValues)
            Return True
        End Function
        Private Function Decompress_5Byte_Quat_NonLinear(ByVal Buffer() As Byte, ByRef Result As COH_Struct_Quat) As Boolean
            If LookupTable Is Nothing OrElse LookupTable.Count < LOOKUPSIZE12BIT Then Create_LookUpTable()
            Dim Values As UInt32() = Nothing
            Dim QuatValues As Single() = New Single(3) {}
            Dim Missing As Int32
            If UnPack_5Byte_Quat(Buffer, Values, Missing) = False Then Return False
            For X = 0 To 3
                If X <> Missing Then
                    QuatValues(X) = UnPack_Quat_ElemQuarterPi(Values(X), 12)
                End If
            Next
            Dim SQR As Single
            QuatValues(Missing) = 0
            If Missing = 3 Then
                SQR = ((1 - QuatValues(2) * QuatValues(2)) - QuatValues(1) * QuatValues(1)) - QuatValues(0) * QuatValues(0)
                If SQR < 0 Then SQR = 0
                QuatValues(3) = Math.Sqrt(SQR)
            ElseIf Missing = 2 Then
                SQR = ((1 - QuatValues(3) * QuatValues(3)) - QuatValues(1) * QuatValues(1)) - QuatValues(0) * QuatValues(0) + 0.001
                If SQR < 0 Then SQR = 0
                QuatValues(2) = Math.Sqrt(SQR)
            ElseIf Missing = 1 Then
                SQR = ((1 - QuatValues(3) * QuatValues(3)) - QuatValues(2) * QuatValues(2)) - QuatValues(0) * QuatValues(0)
                If SQR < 0 Then SQR = 0
                QuatValues(1) = Math.Sqrt(SQR)
            ElseIf Missing = 0 Then
                SQR = ((1 - QuatValues(3) * QuatValues(3)) - QuatValues(2) * QuatValues(2)) - QuatValues(1) * QuatValues(1)
                If SQR < 0 Then SQR = 0
                QuatValues(0) = Math.Sqrt(SQR)
            End If
            Result = New COH_Struct_Quat(QuatValues)
            Return True
        End Function
        Private Function UnPack_5Byte_Quat(ByVal Buffer() As Byte, ByRef Result() As UInt32, ByRef missing As Integer) As Boolean
            '//If Buffer Is Nothing OrElse Buffer.Count < 64 Then Return False
            Result = New UInt32(3) {}
            Dim TempV As UInt32

            'decompress idxs (mirrors code in compressQuatToFiveBytes)
            'Unpack low bytes
            TempV = BitConverter.ToUInt32(Buffer, 1)
            Result(2) = (&HFFF And TempV)
            Result(1) = (&HFFF000 And TempV) >> 12
            Result(0) = (&HFF000000 And TempV) >> 24

            'Unpack high byte
            Dim Top As Byte = CType(Buffer(0), Byte)
            missing = (&HF0 And Top) >> 4
            Result(0) = Result(0) Or (&HF And Top) << 8

            If missing >= 0 AndAlso missing <= 3 Then
                Return True
            End If
            Return True
        End Function
        Private Function UnPack_Quat_ElemQuarterPi(ByVal val As UInt32, ByVal numbits As Integer) As Single
            Dim PI As Decimal = "3.14159265358979323846"
            Dim TWOPI As Decimal = "6.28318530717958647692"
            Dim HALFPI As Decimal = "1.57079632679489661923"
            Dim QUARTERPI As Decimal = "0.78539816339744830962"
            Dim ONEOVERPI As Decimal = "0.31830988618379067154"
            Dim qelem As Single

            qelem = CType(val, Single)
            qelem = CType(((qelem * HALFPI) / (1 << numbits)) - QUARTERPI, Single)
            If qelem < -QUARTERPI Then
                qelem = -QUARTERPI
            End If
            If qelem > (QUARTERPI - 0.00001F) Then
                qelem = QUARTERPI
            End If

            If Math.Abs(qelem) < 0.00001F Then
                qelem = 0.0F
            End If

            Return Convert.ToSingle(Math.Sin(qelem))
        End Function
        Const LOOKUPSIZE12BIT = 4096
        Private Sub Create_LookUpTable()
            LookupTable = New Single(LOOKUPSIZE12BIT - 1) {}
            Dim max_value As Single
            Dim i As Integer
            max_value = (1.0 / Convert.ToSingle(Math.Sqrt(2.0)))
            For i = 0 To LOOKUPSIZE12BIT - 1
                LookupTable(i) = (2.0 * max_value * (CType(i, Single) / CType(LOOKUPSIZE12BIT, Single))) - max_value
            Next i
        End Sub
#End Region
    End Class
End Namespace