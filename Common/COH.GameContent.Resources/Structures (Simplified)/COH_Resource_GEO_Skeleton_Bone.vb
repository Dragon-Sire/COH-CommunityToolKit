Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources_Simplified
    Public NotInheritable Class COH_Resource_GEO_SkeletonBone
        Inherits COH_FileStructure

#Region "Properties"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return ID.ToString
            End Get
        End Property
        <Xml.Serialization.XmlAttribute> Property BoneIndex As Integer
        <Xml.Serialization.XmlAttribute> Property ParentIndex As Integer
        <Xml.Serialization.XmlAttribute> Property ID As GEO_Enums_MESH_BoneId
        <Xml.Serialization.XmlIgnore> Property Children As List(Of COH_Resource_GEO_SkeletonBone)
        Property Bones As COH_Resource_GEO_SkeletonBone()
            Get
                Return Children.ToArray
            End Get
            Set(value As COH_Resource_GEO_SkeletonBone())
                Children = value.ToList
            End Set
        End Property
        Property FirstPosition As COH_Struct_Vector3
        Property FirstRotation As COH_Struct_Quat
        Property ConnectedPosition As COH_Struct_Vector3
        Property ConnectedRotation As COH_Struct_Quat
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
            Children = New List(Of COH_Resource_GEO_SkeletonBone)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_GEO_SkeletonBone
            Dim Result As COH_Resource_GEO_SkeletonBone = New COH_Resource_GEO_SkeletonBone
            'MyBase.CloneTo(Result)
            With Result
                .BoneIndex = BoneIndex
                .ParentIndex = ParentIndex
                .FirstPosition = New COH_Struct_Vector3(FirstPosition.X, FirstPosition.Y, FirstPosition.Z)
                .FirstRotation = New COH_Struct_Quat(FirstRotation.Q1, FirstRotation.Q2, FirstRotation.Q3, FirstRotation.Q4)
                .ConnectedPosition = New COH_Struct_Vector3(ConnectedPosition.X, ConnectedPosition.Y, ConnectedPosition.Z)
                .ConnectedRotation = New COH_Struct_Quat(ConnectedRotation.Q1, ConnectedRotation.Q2, ConnectedRotation.Q3, ConnectedRotation.Q4)
                .Children = New List(Of COH_Resource_GEO_SkeletonBone)
                For x = 0 To Children.Count - 1
                    .Children.Add(Children(x).Clone)
                Next
            End With
            Return Result
        End Function
#End Region

#Region "Read/Write"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
        End Function
#End Region
    End Class
End Namespace
