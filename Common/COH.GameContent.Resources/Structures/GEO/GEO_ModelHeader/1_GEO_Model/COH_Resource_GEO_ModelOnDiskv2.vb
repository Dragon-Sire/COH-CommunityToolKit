Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GEO_ModelonDiskv2
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_Identifier")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "ModelonDiskv2"
            End Get
        End Property
#End Region

#Region "Properties - Model Details"
        <Category("Model Details")> Property VertexCount As Integer
        <Category("Model Details")> Property TriangleCount As Integer
        <Category("Model Details")> Property Scale As COH_Struct_Vector3 '// hardly used at all, but dont remove, jeremy scaling files
        <Category("Model Details")> Property Min As COH_Struct_Vector3
        <Category("Model Details")> Property Max As COH_Struct_Vector3
        <Category("Model Details")> Property PackedData As COH_Resource_GEO_PackBlockonDiskv2
        <Category("Texture Details")> Property Texture_Count As UInteger
        <Category("Texture Details")> Property BlendMode As COH_Enum_BlendModeShader
#End Region

#Region "Properties - Unknown"
        Property Flags As COH_Enum_ModelFlags
        Property Radius As Single
        Property ID As UShort
        Property LoadState As COH_Enum_LoadState
        Property Grid As COH_Resource_GenericMesh_PolyGrid
#End Region

#Region "Properties - Offsets / Pointers"
        <Category("Offsets")> Property Name_Offset As UInteger
        <Category("Offsets")> Property VertexBuffer_Pointer As UInt32
        <Category("Offsets")> Property BoneInfo_Pointer As UInt32
        <Category("Offsets")> Property Tricks_Pointer As UInt32
        <Category("Offsets")> Property Texture_Indexes_Pointer As UInt32
        <Category("Offsets")> Property CTriangles_Pointer As UInt32
        <Category("Offsets")> Property Alternate_PivotPoints_Pointer As UInt32
        <Category("Offsets")> Property ModelExtras_Pointer As UInt32
        <Category("Offsets")> Property GeoLoadData_Pointer As UInt32
        <Category("Offsets")> Property Tags As UInteger
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

#Region "Import / Export"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Flags = CurrentReader.ReadInt32
            Radius = CurrentReader.ReadSingle
            VertexBuffer_Pointer = CurrentReader.ReadUInt32
            Texture_Count = CurrentReader.ReadUInt32
            ID = CurrentReader.ReadUInt16
            BlendMode = CurrentReader.ReadByte
            LoadState = CurrentReader.ReadByte
            BoneInfo_Pointer = CurrentReader.ReadUInt32
            Tricks_Pointer = CurrentReader.ReadUInt32
            VertexCount = CurrentReader.ReadInt32
            TriangleCount = CurrentReader.ReadInt32
            Texture_Indexes_Pointer = CurrentReader.ReadUInt32
            Grid = New COH_Resource_GenericMesh_PolyGrid(CurrentReader)
            CTriangles_Pointer = CurrentReader.ReadUInt32
            Tags = CurrentReader.ReadUInt32 'Pointer
            Name_Offset = CurrentReader.ReadUInt32
            Alternate_PivotPoints_Pointer = CurrentReader.ReadUInt32
            ModelExtras_Pointer = CurrentReader.ReadUInt32
            Scale = CurrentReader.Read_CrypticS_Vector3
            Min = CurrentReader.Read_CrypticS_Vector3
            Max = CurrentReader.Read_CrypticS_Vector3
            GeoLoadData_Pointer = CurrentReader.ReadUInt32
            PackedData = New COH_Resource_GEO_PackBlockonDiskv2(CurrentReader)
            Return True
        End Function
#End Region
    End Class
End Namespace