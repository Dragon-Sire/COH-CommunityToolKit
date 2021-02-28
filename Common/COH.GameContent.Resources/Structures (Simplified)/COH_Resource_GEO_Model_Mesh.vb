Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GEO_Model_MeshDetails
        Inherits COH_FileStructure

#Region "Properties"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "MeshDetails"
            End Get
        End Property
        <Category("ModelDetails")> Property Vertexs As COH_Struct_Vector3()
        <Category("ModelDetails")> Property TriangleIndices As COH_Struct_TriangleIndice()
        <Category("ModelDetails")> Property Normals As COH_Struct_Vector3()
        <Category("ModelDetails")> Property Bones As GEO_Enums_MESH_BoneId()
        <Category("ModelDetails")> Property BoneWeights As COH_Struct_Weight()
        <Category("ModelDetails")> Property BoneMatIndex As COH_Struct_MaterialIndex()
        <Category("ModelDetails")> Property UV As COH_Struct_Vector2()
        <Category("ModelDetails")> Property TextureNames As String()
        <Category("ModelDetails")> Property TextureSTSCounts As Integer()
#End Region

#Region "Private Properties"
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            UV = New COH_Struct_Vector2() {}
            Vertexs = New COH_Struct_Vector3() {}
            Normals = New COH_Struct_Vector3() {}
            TriangleIndices = New COH_Struct_TriangleIndice() {}
            TextureSTSCounts = New Integer() {}
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_GEO_Model_MeshDetails
            Dim Result As COH_Resource_GEO_Model_MeshDetails = New COH_Resource_GEO_Model_MeshDetails
            'MyBase.CloneTo(Result)
            With Result
            End With
            Return Result
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
#End Region
    End Class
End Namespace