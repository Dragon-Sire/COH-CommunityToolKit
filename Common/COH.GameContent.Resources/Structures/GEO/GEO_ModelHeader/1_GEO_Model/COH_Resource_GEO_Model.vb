Imports COH.GameContent.Structures.Resources
Imports COH.GameContent.Structures
Imports COH.GameContent.Structures.Enums
Imports COH.HelperClasses
Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GEOModel
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_Identifier")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Model"
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
        <Category("Model Details")> Property Radius As Single
        <Category("Model Details")> Property Grid As COH_Resource_GenericMesh_PolyGrid
        <Category("Texture Details")> Property Texture_Count As UInteger
        <Category("Texture Details")> Property BlendMode As COH_Enum_BlendModeShader
        <Category("Unknown")> Property Flags As COH_Enum_ModelFlags
        <Category("Unknown")> Property ID As UShort
        <Category("Unknown")> Property LoadState As COH_Enum_LoadState
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

#Region "Properties Used in Version >=3"
        <Category("Model Details >=3")> Property ReflectionQuadCount As Integer
        <Category("Model Details >=3")> Property Texture_Indexes As COH_Struct_TextureID() 'INdex Start & Count Really Kinda Redundant  as it's just pulling the damn name
        <Category("Model Details >=3")> Property AutoLOD_Distances As Single() '3 ARRAY
#End Region

#Region "Properties"
        Property VertexBuffer As COH_Resource_GEO_VertexBuffer
        Property BoneInfo As COH_Resource_GEO_BoneInfo
        Property Tricks As COH_Resource_GEO_Animation_TrickNode
        Property CTriangles As COH_Resource_BasicTexture_cTri
        Property Alternate_PivotPoints As COH_Resource_GEO_AlternatePivotInfo '// if I have alternate pivot points defined for fx, everything about that
        Property ModelExtras As COH_Resource_GEO_ModelExtra '// Portals
        Property GeoLoadData As COH_Resource_GEO_LoadData
#End Region

#Region "Properties Not Used in ModelFormatOnDisk_v2, Version <3"

        Property Name As String
        Property NameLength As Integer
        Property NameLength_NoTrick As Integer



        Property BlendModeType As COH_Resource_BasicTexture_BlendModeType
        '//CLIENT

        Property BlendModes As COH_Resource_BasicTexture_BlendModeType()
        Property TextureBind As COH_Resource_BasicTexture_Bind
        Property ModelLOD As MeshRelated.COH_LOD_Info
        '//CLIENT
        '//Collision

        Property Flags_OnAll As Integer
        Property Flags_OnSome As Integer

        Property GridSize_Originol As Single
        '//
        Property SourceModel As COH_Resource_GEOModel '//// only valid for lod models
        Property LODModel As COH_Resource_GEO_LOD_Model
        Property MinError As Single
        Property MaxError As Single
        Property MinTrianglePercent As Single
        Property MaxTrianglePercent As Single
        Property FileName As String
        'Property SharededHeapHandle As SharedHeap_Handle
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
        Public Function CloneFrom(Source As COH_Resource_GEO_ModelonDiskv2) As Boolean
            With Source
                Flags = .Flags
                Radius = .Radius
                VertexBuffer_Pointer = .VertexBuffer_Pointer
                Texture_Count = .Texture_Count
                ID = .ID
                BlendMode = .BlendMode
                LoadState = .LoadState
                BoneInfo_Pointer = .BoneInfo_Pointer
                Tricks_Pointer = .Tricks_Pointer
                VertexCount = .VertexCount
                TriangleCount = .TriangleCount
                Texture_Indexes_Pointer = .Texture_Indexes_Pointer
                Grid = .Grid.Clone
                CTriangles_Pointer = .CTriangles_Pointer
                Tags = .Tags
                Name_Offset = .Name_Offset
                Alternate_PivotPoints_Pointer = .Alternate_PivotPoints_Pointer
                ModelExtras_Pointer = .ModelExtras_Pointer
                Scale = .Scale
                Min = .Min
                Max = .Max
                GeoLoadData_Pointer = .GeoLoadData_Pointer
                PackedData = .PackedData.Clone
            End With
            Return True
        End Function
#End Region

#Region "Import / Export"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Settings.Option_Version < 3 Then
                Dim ModelOnDisk = New COH_Resource_GEO_ModelonDiskv2(CurrentReader)
                If ModelOnDisk.CurrentInstance_Valid = False Then Return False
                Return CloneFrom(ModelOnDisk)
            Else
                Flags = CurrentReader.ReadInt32
                Radius = CurrentReader.ReadSingle
                Texture_Count = CurrentReader.ReadUInt32
                BoneInfo_Pointer = CurrentReader.ReadUInt32
                VertexCount = CurrentReader.ReadInt32
                TriangleCount = CurrentReader.ReadInt32
                If CurrentReader.Settings.Option_Version >= 8 Then
                    ReflectionQuadCount = CurrentReader.ReadInt32
                End If
                Texture_Indexes_Pointer = CurrentReader.ReadUInt32
                Grid = New COH_Resource_GenericMesh_PolyGrid(CurrentReader)
                Name_Offset = CurrentReader.ReadUInt32
                '//dst->name = objname_base + (int)dst->name;
                Alternate_PivotPoints_Pointer = CurrentReader.ReadUInt32
                Scale = CurrentReader.Read_CrypticS_Vector3
                Min = CurrentReader.Read_CrypticS_Vector3
                Max = CurrentReader.Read_CrypticS_Vector3
                PackedData = New COH_Resource_GEO_PackBlockonDiskv2(CurrentReader)
                '//Commented Out ??
                If CurrentReader.Settings.Option_Version < 8 Then
                    Dim LightMapSize = CurrentReader.ReadSingle
                End If
                If CurrentReader.Settings.Option_Version < 7 Then
                    AutoLOD_Distances = New Single(2) {-1, -1, -1}
                ElseIf CurrentReader.Settings.Option_Version >= 7 And Build = COH_BuildType.ClientOnly Then '//autolod_dists
                    AutoLOD_Distances = New Single(2) {CurrentReader.ReadSingle, CurrentReader.ReadSingle, CurrentReader.ReadSingle}
                Else '//Allocate Space but don't read..... okay ignoring that for now
                    AutoLOD_Distances = New Single(2) {CurrentReader.ReadSingle, CurrentReader.ReadSingle, CurrentReader.ReadSingle}
                End If
                ID = CurrentReader.ReadUInt16
                Dim Unknown As Int16 = CurrentReader.ReadUInt16
                If Not ID = 65532 AndAlso Not ID = 65534 Then '65534
                    'COH_LibraryEventControl.Instance.Trigger_ErrorOccured(COH_Event_Error.COH_ErrorEvent.ControlledError, "ID <>65532, Unhandled Something Not Aligned?", Nothing, True)
                    'COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)
                    Return False
                End If
                Return True
            End If
        End Function
#End Region
    End Class
End Namespace