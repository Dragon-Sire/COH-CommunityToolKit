Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GEO
        Inherits COH_FileStructure

#Region "Properties"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return ModelName
            End Get
        End Property
        <Category("Identifier")> Property Header As COH_Resource_GEO_Header
        <Category("Model")> Property ModelName As String
        <Category("Model")> Property Models As List(Of COH_Resource_GEO_Model)
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            ModelName = "New Model"
            Header = New COH_Resource_GEO_Header
            Models = New List(Of COH_Resource_GEO_Model)
        End Sub
        Public Overrides Function EntryType() As COH_Supported_ContentType
            Return COH_Supported_ContentType.Resource_GEO
        End Function
#End Region

#Region "Export"
        Public Function Convert_To_Model_OBJ() As String
            Dim AdjustHandiness As Integer = -1
            '//1 if not used...tangents determined

            Dim CurrentWriter As New Text.StringBuilder
            CurrentWriter.AppendLine("# Wavefront OBJ exported by City of Heres Community Toolkit")
            Dim TotalV As Integer = 0
            For Each Model In Models
                For Each Vertice In Model.Mesh.Vertexs
                    CurrentWriter.AppendLine("v " & Vertice.X * AdjustHandiness & " " & Vertice.Y & " " & Vertice.Z)
                Next
                TotalV += Model.Mesh.Vertexs.Length
            Next
            CurrentWriter.AppendLine("# " & TotalV & " Vertices")
            CurrentWriter.AppendLine()
            TotalV = 0
            For Each Model In Models
                For Each uv In Model.Mesh.UV
                    Dim X As String = If(uv.X < 0, 0.000000, uv.X.ToString("0.######", New System.Globalization.CultureInfo("en-US")))
                    Dim Y As String = If(uv.Y < 0, 0.000000, uv.Y.ToString("0.######", New System.Globalization.CultureInfo("en-US")))
                    If uv.X = 1 Then X = "1.000000"
                    If uv.Y = 1 Then Y = "1.000000"
                    If uv.X <= 0 Then X = "0.000000"
                    If uv.Y <= 0 Then Y = "0.000000"
                    X = X.ToString.PadRight(8, "0")
                    Y = Y.ToString.PadRight(8, "0")
                    CurrentWriter.AppendLine("vt " & X & " " & Y)
                Next
                TotalV += Model.Mesh.UV.Length
            Next
            CurrentWriter.AppendLine("# " & TotalV & " UV Coordinates")
            CurrentWriter.AppendLine()
            TotalV = 0
            For Each Model In Models
                For Each Normal In Model.Mesh.Normals
                    CurrentWriter.AppendLine("vn " & Normal.X & " " & Normal.Y & " " & Normal.Z)
                Next
                TotalV += Model.Mesh.Vertexs.Length
            Next
            CurrentWriter.AppendLine("# " & TotalV & " Normals")
            CurrentWriter.AppendLine()
            Dim FaceIndex_Offset As Integer = 1
            For Each Model In Models
                TotalV = 0
                CurrentWriter.AppendLine("g " & Model.ModelName)
                For Each Faces In Model.Mesh.TriangleIndices
                    Dim Face1 As String = Faces.Value1 + FaceIndex_Offset & "/" & Faces.Value1 + FaceIndex_Offset & "/" & Faces.Value1 + FaceIndex_Offset
                    Dim Face2 As String = Faces.Value2 + FaceIndex_Offset & "/" & Faces.Value2 + FaceIndex_Offset & "/" & Faces.Value1 + FaceIndex_Offset
                    Dim Face3 As String = Faces.Value3 + FaceIndex_Offset & "/" & Faces.Value3 + FaceIndex_Offset & "/" & Faces.Value1 + FaceIndex_Offset
                    CurrentWriter.AppendLine("f " & Face1 & " " & Face2 & " " & Face3)
                Next
                TotalV = Model.Mesh.TriangleIndices.Length
                FaceIndex_Offset += Model.Mesh.Vertexs.Length
                CurrentWriter.AppendLine("# " & TotalV & " Triangles In Group")
                CurrentWriter.AppendLine()
            Next
            Return CurrentWriter.ToString
            Return True
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_GEO
            Dim Result As COH_Resource_GEO = New COH_Resource_GEO
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
            End With
            Return Result
        End Function
#End Region

#Region "Read/Write"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Settings.Option_SelectedFormat = COH_StreamFormat.Binary Then 'DDS
                'CurrentWriter.Write(mRawBytes)
            ElseIf CurrentWriter.Settings.Option_SelectedFormat = COH_StreamFormat.CrypticS_BINFormat Then 'Texture
            Else
                Return MyBase.Export_To_Stream(CurrentWriter)
            End If
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Header = New COH_Resource_GEO_Header(CurrentReader)
            Dim Valid = Header.CurrentInstance_Valid
            If Valid = False Then
                If Header Is Nothing Then Return False
                If Header.ModelHeader Is Nothing Then Return False
                ModelName = Header.ModelHeader.ModelName
                'Models = Header.Convert_To_GEOModels(CurrentReader)
                ForceNotValid()
                Return False
            End If
            ModelName = Header.ModelHeader.ModelName
            Models = Header.Convert_To_GEOModels(CurrentReader)
            Return True
        End Function
#End Region
    End Class
End Namespace