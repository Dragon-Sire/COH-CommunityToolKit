Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GEO_Model
        Inherits COH_FileStructure

#Region "Properties"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return ModelName
            End Get
        End Property
        <Category("Identifier")> Property Version As Integer
        <Category("Identifier")> Property ModelName As String
        Property TrickName As String
        <Category("Identifier")> Property Index As Integer
        <Category("ModelDetails")> Property Mesh As COH_Resource_GEO_Model_MeshDetails
        <Category("ModelDetails")> Property BoundingBox_Min As COH_Struct_Vector3
        <Category("ModelDetails")> Property BoundingBox_Max As COH_Struct_Vector3
        <Category("ModelDetails")> Property Radius As Single
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
            Version = 0 '//DECIDE THIS LATER BUT THINKING 8
            ModelName = "New Model"
            Mesh = New COH_Resource_GEO_Model_MeshDetails
            BoundingBox_Max = New COH_Struct_Vector3
            BoundingBox_Min = New COH_Struct_Vector3
            Radius = 0
        End Sub
#End Region

#Region "Export Single Model"
        Public Function Convert_To_Model_OBJ() As String
            Dim CurrentWriter As New Text.StringBuilder
            CurrentWriter.AppendLine("# List of geometric vertices, with (x, y, z [, w]) coordinates, w Is Optional And defaults To 1.0.)")
            For Each Vertice In Mesh.Vertexs
                CurrentWriter.AppendLine("v " & Vertice.X & " " & Vertice.Y & " " & Vertice.Z)
            Next
            CurrentWriter.AppendLine("# List of vertex normals in (x,y,z) form; normals might not be unit vectors.")
            For Each Normal In Mesh.Normals
                CurrentWriter.AppendLine("vn " & Normal.X & " " & Normal.Y & " " & Normal.Z)
            Next
            CurrentWriter.AppendLine("# Polygonal face element ")
            For Each Faces In Mesh.TriangleIndices
                CurrentWriter.AppendLine("f " & Faces.Value1 + 1 & " " & Faces.Value2 + 1 & " " & Faces.Value3 + 1)
            Next
            Return CurrentWriter.ToString
            Return True
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_GEO_Model
            Dim Result As COH_Resource_GEO_Model = New COH_Resource_GEO_Model
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