Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GEO_PackBlockonDiskv2
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_Identifier")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "PackBlockonDiskv2"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Triangles As COH_Resource_GEO_PackData
        Property Vertices As COH_Resource_GEO_PackData
        Property Normals As COH_Resource_GEO_PackData
        Property sts As COH_Resource_GEO_PackData
        Property Weights As COH_Resource_GEO_PackData
        Property matidxs As COH_Resource_GEO_PackData
        Property grid As COH_Resource_GEO_PackData
        '//ONLY USED IN >= 3
        Property sts3 As COH_Resource_GEO_PackData
        '//ONLY USED IN >= 7
        Property Reductions As COH_Resource_GEO_PackData
        '//ONLY USED IN >= 8
        Property ReflectionQuads As COH_Resource_GEO_PackData
        '//NO LONGER USED
        Property lmap_utransforms As COH_Resource_GEO_PackData
        Property lmap_vtransforms As COH_Resource_GEO_PackData
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
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
        Public Function Clone() As COH_Resource_GEO_PackBlockonDiskv2
            Dim Destination As New COH_Resource_GEO_PackBlockonDiskv2
            CloneTo(Destination)
            Return Destination
        End Function
        Public Overloads Sub CloneTo(ByRef Destination As COH_Resource_GEO_PackBlockonDiskv2)
            'MyBase.CloneTo(TryCast(Destination, COH_FileStructure))
            With Destination
                .Triangles = Triangles.clone
                .Vertices = Vertices.clone
                .Normals = Normals.clone
                .sts = sts.clone
                .Weights = Weights.clone
                .matidxs = matidxs.Clone
                .grid = grid.Clone
                If Not sts3 Is Nothing Then .sts3 = sts3.Clone
                If Not Reductions Is Nothing Then .Reductions = Reductions.Clone
                If Not ReflectionQuads Is Nothing Then .ReflectionQuads = ReflectionQuads.Clone
                If Not lmap_utransforms Is Nothing Then .lmap_utransforms = lmap_utransforms.Clone
                If Not lmap_vtransforms Is Nothing Then .lmap_vtransforms = lmap_vtransforms.Clone
            End With
        End Sub
#End Region

#Region "Import / Export"
    Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Triangles = New COH_Resource_GEO_PackData(CurrentReader)
            Vertices = New COH_Resource_GEO_PackData(CurrentReader)
            Normals = New COH_Resource_GEO_PackData(CurrentReader)
            sts = New COH_Resource_GEO_PackData(CurrentReader)
            If CurrentReader.Settings.Option_Version >= 3 Then
                sts3 = New COH_Resource_GEO_PackData(CurrentReader)
            End If
            Weights = New COH_Resource_GEO_PackData(CurrentReader)
            matidxs = New COH_Resource_GEO_PackData(CurrentReader)
            grid = New COH_Resource_GEO_PackData(CurrentReader)
            If CurrentReader.Settings.Option_Version = 4 Then
                lmap_utransforms = New COH_Resource_GEO_PackData(CurrentReader)
                lmap_vtransforms = New COH_Resource_GEO_PackData(CurrentReader)
            End If
            If CurrentReader.Settings.Option_Version >= 7 Then
                Reductions = New COH_Resource_GEO_PackData(CurrentReader)
            End If
            If CurrentReader.Settings.Option_Version >= 8 Then
                ReflectionQuads = New COH_Resource_GEO_PackData(CurrentReader)
            End If
            Return True
        End Function
#End Region
    End Class
End Namespace