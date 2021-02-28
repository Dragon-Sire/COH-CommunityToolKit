Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources.Anim
    Public Class COH_Skeleton_BoneLocation
        Inherits COH_FileStructure

#Region "Properties"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Anim"
            End Get
        End Property
        Property ID As GEO_Enums_MESH_BoneId
        Property Position As COH_Struct_Vector3()
        Property Rotation As COH_Struct_Quat()
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

#Region "Clone"
        Public Function Clone() As COH_Skeleton_BoneLocation
            Dim Result As COH_Skeleton_BoneLocation = New COH_Skeleton_BoneLocation
            'MyBase.CloneTo(Result)
            With Result
            End With
            Return Result
        End Function
#End Region
    End Class
End Namespace
