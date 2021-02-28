Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources.Anim
    Public Class COH_Skeleton_Heirarchy
        Inherits COH_FileStructure

#Region "Properties"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Anim"
            End Get
        End Property
        Property Root As GEO_Enums_MESH_BoneId
        Property NumberBonesUsed As UInt32
        Property Skeleton_Hierarchy As COH_Skeleton_Hierarchy_BoneLink() '100){} ' BonesOnDisk   'skeleton_heirarchy[BONES_ON_DISK]; //tree Structure
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
            Skeleton_Hierarchy = New COH_Skeleton_Hierarchy_BoneLink(100 - 1) {}
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Skeleton_Heirarchy
            Dim Result As COH_Skeleton_Heirarchy = New COH_Skeleton_Heirarchy
            'MyBase.CloneTo(Result)
            With Result
                .Root = Root
                .NumberBonesUsed = NumberBonesUsed
                .Skeleton_Hierarchy = New COH_Skeleton_Hierarchy_BoneLink(Skeleton_Hierarchy.Count - 1) {}
                For x = 0 To Skeleton_Hierarchy.Count - 1
                    .Skeleton_Hierarchy(x) = Skeleton_Hierarchy(x).Clone
                Next
            End With
            Return Result
        End Function
#End Region

#Region "Read/Write"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Return True
        End Function
#End Region
    End Class
End Namespace
