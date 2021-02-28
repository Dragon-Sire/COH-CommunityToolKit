Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources_Simplified
    Public NotInheritable Class COH_Resource_GEO_Skeleton
        Inherits COH_FileStructure

#Region "Properties"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Name
            End Get
        End Property
        Property Name As String
        Property Root As GEO_Enums_MESH_BoneId
        Property NumberBonesUsed As UInt32
        Property Bones As COH_Resource_GEO_SkeletonBone()
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
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
        End Sub
#End Region

#Region "Search"
        Public Function SearchBone(Name As String) As COH_Resource_GEO_SkeletonBone
            Dim FoundBone As COH_Resource_GEO_SkeletonBone = Nothing
            For Each Bone In Bones
                If Bone.ID.ToString = Name Then Return Bone
                If SearchBone(Bone, Name, FoundBone) = True Then Return FoundBone
            Next
            Return Bones(0)
        End Function
        Private Function SearchBone(ByRef ParentBone As COH_Resource_GEO_SkeletonBone, Name As String, ByRef FoundBone As COH_Resource_GEO_SkeletonBone) As Boolean
            FoundBone = Nothing
            For Each Bone In ParentBone.Children
                If Bone.ID.ToString = Name Then
                    FoundBone = Bone
                    Return True
                End If
                If SearchBone(Bone, Name, FoundBone) = True Then Return True
            Next
            Return False
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_GEO_Skeleton
            Dim Result As COH_Resource_GEO_Skeleton = New COH_Resource_GEO_Skeleton
            'MyBase.CloneTo(Result)
            With Result
                .Name = String.Copy(Name)
                .Root = Root
                .NumberBonesUsed = NumberBonesUsed
                .Bones = New COH_Resource_GEO_SkeletonBone(Bones.Count - 1) {}
                For X = 0 To Bones.Count - 1
                    .Bones(X) = Bones(X).Clone
                Next
            End With
            Return Result
        End Function
#End Region

#Region "Read/Write"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Return True
        End Function
#End Region
    End Class
End Namespace
