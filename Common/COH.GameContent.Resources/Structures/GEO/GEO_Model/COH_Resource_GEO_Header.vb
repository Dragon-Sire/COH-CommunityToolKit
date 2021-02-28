Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GEO_Header
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Header"
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("Identifier")> Property HeaderVersion As Integer
        <Category("Textures")> Property TextureNames_Count As UInt32   '//Number Of textures In section
        <Category("Textures")> Property TextureNames_Offsets As UInt32()
        <Category("Textures")> Property TextureNames As String()
        <Category("Textures")> Property TextureBinds As COH_Resource_GEO_TextBind()
        <Category("Models")> Property ModelHeader As COH_Resource_GEO_ModelHeader
        <Category("Models")> Property ObjectNames As String()
        <Category("Models")> Property NumberLODs_Used As Integer
        <Category("Models")> Property LOD_Info As MeshRelated.COH_LOD_Info()
        <Category("Sizes")> Property TotalSize As Integer
        <Category("Sizes")> Property HeaderSize As Integer
        <Category("Sizes")> Property StoredSize As Integer
        <Category("Sizes")> Property ActualSize As Integer
        <Category("Offset")> Property CompressedMeshData_Offset As Integer
        <Category("Sizes")> Property SectionSize_GeoData As Integer
        <Category("Sizes")> Property SectionSize_Texture As Integer
        <Category("Sizes")> Property SectionSize_ObjectNames As Integer
        <Category("Sizes")> Property SectionSize_TextureBinds As Integer
        <Category("Sizes")> Property SectionSize_LODInfo As Integer
#End Region

#Region "Private Properties"
        Const MaxVersion As Integer = 8
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

#Region "Convert To Usable"
        Public Function Convert_To_GEOModels(ByRef CurrentReader As COH_BinaryReader) As List(Of COH_Resource_GEO_Model)
            If ModelHeader.Models Is Nothing Then Return Nothing
            Dim Result As New List(Of COH_Resource_GEO_Model)
            For X = 0 To ModelHeader.Model_Count - 1
                If ModelHeader.Models(X).CurrentInstance_Valid = False Then Exit For
                Dim NewModel As New COH_Resource_GEO_Model

                If ObjectNames(X).Contains("__") Then 'Trick
                    NewModel.TrickName = ObjectNames(X).Substring(ObjectNames(X).IndexOf("__") + 2)
                    NewModel.ModelName = ObjectNames(X).Substring(0, ObjectNames(X).IndexOf("__") - 2)
                Else
                    NewModel.TrickName = ""
                    NewModel.ModelName = ObjectNames(X)
                End If

                NewModel.Index = X

                Dim UnPackedData As New GEO.COH_Resource_GEO_PackData_UnPack(HeaderVersion, ModelHeader, X, CompressedMeshData_Offset, CurrentReader)
                NewModel.Mesh.TriangleIndices = UnPackedData.TriangleIndices
                NewModel.Mesh.Vertexs = UnPackedData.Vertexs
                NewModel.Mesh.Normals = UnPackedData.Normals
                If ModelHeader.Models(X).BoneInfo_Pointer > 0 Then
                    NewModel.Mesh.Bones = ModelHeader.Models(X).BoneInfo.BoneIDs
                    NewModel.Mesh.BoneWeights = UnPackedData.Weights
                    NewModel.Mesh.BoneMatIndex = UnPackedData.BoneMatIndex
                End If

                NewModel.BoundingBox_Min = ModelHeader.Models(X).Min
                NewModel.BoundingBox_Max = ModelHeader.Models(X).Max
                NewModel.Radius = ModelHeader.Models(X).Radius

                NewModel.Mesh.UV = UnPackedData.STS

                'TEXTURES



                Dim IndexValueStart As Integer = ModelHeader.Models(X).Texture_Indexes_Pointer / 4
                NewModel.Mesh.TextureNames = New String(ModelHeader.Models(X).Texture_Count - 1) {}
                NewModel.Mesh.TextureSTSCounts = New Integer(ModelHeader.Models(X).Texture_Count - 1) {}
                For X2 = 0 To ModelHeader.Models(X).Texture_Count - 1
                    Dim TextureBind = Me.TextureBinds(IndexValueStart + X2)
                    NewModel.Mesh.TextureNames(X2) = TextureNames(TextureBind.TextureIndex)
                    NewModel.Mesh.TextureSTSCounts(X2) = TextureBind.Number_STS_Using
                Next
                Result.Add(NewModel)
            Next
                Return Result
        End Function
#End Region

#Region "Import / Export"
    Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            HeaderSize = CurrentReader.ReadUInt32
            Dim Zero As UInt32 = CurrentReader.ReadUInt32
            If Zero = 0 Then
                HeaderVersion = CurrentReader.ReadUInt32
                ActualSize = CurrentReader.ReadUInt32
                StoredSize = HeaderSize - 12
            Else
                HeaderVersion = 0
                ActualSize = Zero
                StoredSize = HeaderSize - 4
            End If
            If ValidateVersion(HeaderVersion) = False Then Return False
            '//CompressedHeaderData
            Dim CompressedHeader As Byte() = CurrentReader.ReadBytes(StoredSize)
            Dim HeaderBytes As Byte() = HelperFunctions.Compression.DecompressBytes(CompressedHeader)
            Using HeaderReader As New COH_BinaryReader(New IO.MemoryStream(HeaderBytes))
                HeaderReader.Settings.Option_Version = HeaderVersion
                SectionSize_GeoData = HeaderReader.ReadUInt32
                SectionSize_Texture = HeaderReader.ReadUInt32
                SectionSize_ObjectNames = HeaderReader.ReadUInt32
                SectionSize_TextureBinds = HeaderReader.ReadUInt32
                If HeaderVersion >= 2 AndAlso HeaderVersion <= 6 Then SectionSize_LODInfo = HeaderReader.ReadUInt32
                TotalSize = HeaderReader.Position + SectionSize_Texture + SectionSize_ObjectNames + SectionSize_TextureBinds + SectionSize_LODInfo
                'totalSize += sizeof(ModelHeader);
                If Update_FromBytes_TextureNames(HeaderVersion, HeaderReader) = False Then Return False
                If Update_FromBytes_ObjectNames(HeaderVersion, HeaderReader) = False Then Return False
                If Update_FromBytes_TextureBinds(HeaderVersion, HeaderReader) = False Then Return False
                If HeaderVersion >= 2 AndAlso HeaderVersion <= 6 Then If Update_FromBytes_LOD_Info(HeaderReader) = False Then Return False
                ModelHeader = New COH_Resource_GEO_ModelHeader(HeaderReader)
                If ModelHeader.CurrentInstance_Valid = False Then Return False
            End Using
            Dim Unknown1 As Byte()
            If HeaderVersion = 0 Then
                Unknown1 = CurrentReader.ReadBytes(4) '//LAST TIME USED OR TYPE
            End If
            CompressedMeshData_Offset = CurrentReader.Position
            '//////POINTER STUFF
            For X = 0 To ModelHeader.Model_Count - 1
                If ModelHeader.Models(X).BoneInfo_Pointer > 0 Then
                    Update_BoneInfo(HeaderVersion, CurrentReader, X)
                End If
            Next
            '/////Should ReallyUnpackHere and Place DataBack In ProperLocations



            Return True
        End Function
        Private Function Update_FromBytes_TextureNames(Version As Integer, ByRef CurrentReader As COH_BinaryReader) As Boolean
            Dim Start As Integer = CurrentReader.Position
            TextureNames_Count = CurrentReader.ReadUInt32
            If TextureNames_Count = 0 Then
                TextureNames_Count = 1
                TextureNames_Offsets = New UInteger(TextureNames_Count - 1) {}
                TextureNames = New String(0) {"white"}
            Else
                TextureNames_Offsets = New UInteger(TextureNames_Count - 1) {}
                TextureNames = New String(TextureNames_Count - 1) {}
                For x = 0 To TextureNames_Count - 1
                    TextureNames_Offsets(x) = CurrentReader.ReadUInt32
                Next
                For x = 0 To TextureNames_Count - 1
                    TextureNames(x) = CurrentReader.Read_CrypticS_String_ZeroEnded_UTF8
                Next
            End If
            Dim SizeRead As Integer = (CurrentReader.Position - Start)
            Dim AdditionalBytes As Byte() = CurrentReader.ReadBytes(SectionSize_Texture - SizeRead)
            Return True
        End Function
        Private Function Update_FromBytes_ObjectNames(Version As Integer, ByRef CurrentReader As COH_BinaryReader) As Boolean
            Dim Start As Integer = CurrentReader.Position
            Dim Temp As Byte() = CurrentReader.ReadBytes(SectionSize_ObjectNames)
            Dim TheString As String = Text.Encoding.GetEncoding(850).GetChars(Temp)
            Dim TempString = TheString.Split(ChrW(0))
            Dim Actual = Determine_NumberModels_FromNames(TempString)
            If Actual = 0 Then Return False
            ObjectNames = New String(Actual - 1) {}
            Array.ConstrainedCopy(TempString, 0, ObjectNames, 0, Actual)
            Return True
        End Function
        Private Function Determine_NumberModels_FromNames(source As String()) As Integer
            Dim Result As Integer = 0
            For Each Entry In source
                If Entry.Length <= 1 Then Exit For
                Result += 1
            Next
            Return Result
        End Function
        Private Function Update_FromBytes_TextureBinds(Version As Integer, ByRef CurrentReader As COH_BinaryReader) As Boolean
            Dim Count As Integer = SectionSize_TextureBinds / 4
            TextureBinds = New COH_Resource_GEO_TextBind(Count - 1) {}
            For x = 0 To Count - 1
                TextureBinds(x) = New COH_Resource_GEO_TextBind(CurrentReader)
            Next
            Return True
        End Function
        Private Function Update_FromBytes_LOD_Info(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If SectionSize_LODInfo = 0 Then Return True
            If CurrentReader.Settings.Option_Version >= 2 And CurrentReader.Settings.Option_Version <= 5 Then
                LOD_Info = New MeshRelated.COH_LOD_Info(ObjectNames.Count - 1) {}
                For X3 = 0 To ObjectNames.Count - 1
                    Dim LOD = New COH_Resource_GEO_ModelLOD_OnDiskv5(CurrentReader)
                    Dim NewLOD As New MeshRelated.COH_LOD_Info
                    Dim NumAutos As Integer = (LOD.Number_Auto_Used - 1)
                    For X = 0 To NumAutos
                        Dim NewAuto As New MeshRelated.COH_LOD_Auto
                        NewAuto.AllowedError = LOD.LOD(X).MaxError
                        NewAuto.LodFar = LOD.LOD(X).LodFar
                        NewAuto.LodFarFade = LOD.LOD(X).LodFarFade
                        NewAuto.LodFlags = LOD.LOD(X).LodFlags
                        NewAuto.LodNear = LOD.LOD(X).LodNear
                        NewAuto.LodNearFade = LOD.LOD(X).LodNearFade
                        NewLOD.AutoLOD(X) = NewAuto
                    Next
                    LOD_Info(X3) = NewLOD
                Next
            ElseIf CurrentReader.Settings.Option_Version = 6 Then
                LOD_Info = New MeshRelated.COH_LOD_Info(ObjectNames.Count - 1) {}
                For X3 = 0 To ObjectNames.Count - 1
                    Dim LOD = New COH_Resource_GEO_ModelLOD_OnDiskv5(CurrentReader)
                    Dim NewLOD As New MeshRelated.COH_LOD_Info
                    Dim NumAutos As Integer = (LOD.Number_Auto_Used - 1)
                    For X = 0 To NumAutos
                        Dim NewAuto As New MeshRelated.COH_LOD_Auto()
                        NewAuto.LodFlags = CurrentReader.Read_CrypticS_Flags
                        NewAuto.AllowedError = CurrentReader.ReadSingle
                        NewAuto.LodFar = CurrentReader.ReadSingle
                        NewAuto.LodFarFade = CurrentReader.ReadSingle
                        NewAuto.LodNear = CurrentReader.ReadSingle
                        NewAuto.LodNearFade = CurrentReader.ReadSingle
                        NewAuto.ModelName = CurrentReader.ReadString_ZeroEnded_UTF8
                        NewAuto.FileName = CurrentReader.ReadString_ZeroEnded_UTF8
                        NewLOD.AutoLOD(X) = NewAuto
                    Next
                    LOD_Info(X3) = NewLOD
                Next
                Return True
            End If
            Return True
        End Function
        Private Function ValidateVersion(Version As Integer) As Boolean
            If Version > MaxVersion Then
                Return False
            Else
                '//Temporary
                'If CurrentReader.Settings.Option_Version = 3 Or Version = 4 Then Return False
                Return True
            End If
        End Function
        Private Function Update_BoneInfo(Version As Integer, ByRef CurrentReader As COH_BinaryReader, ModelIndex As Integer) As Boolean
            CurrentReader.Position = ModelHeader.Models(ModelIndex).BoneInfo_Pointer + CompressedMeshData_Offset
            Dim Bone As New Resources.COH_Resource_GEO_BoneInfo(CurrentReader)
            ModelHeader.Models(ModelIndex).BoneInfo = Bone
            Return True
        End Function
#End Region

    End Class
End Namespace