Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources
    Public Class COH_Resource_GEO_BoneInfo
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Bones"
            End Get
        End Property
#End Region

#Region "Private Properties"
        Public Const MAXBONES = 15
        Property NumberBones As Integer 'Only has boneinfo if numbones
        Property BoneIDs() As GEO_Enums_MESH_BoneId() '//Max 15
        Property Weights As COH_Struct_Weight() 'per vert: list of weights
        Property MaterialIndexs As COH_Struct_MaterialIndex()  'per vert: list of mat associated with each weight
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
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            BoneIDs = New GEO_Enums_MESH_BoneId(MAXBONES - 1) {}
        End Sub
#End Region

#Region "Update"
        Private Sub Update_FromBytes(Version As Integer, RawBytes As Byte())
            Dim Stream As New IO.MemoryStream(RawBytes)
            Using CurrentReader As New COH_BinaryReader(Stream)

            End Using
        End Sub
#End Region

#Region "Clone"
        Public Function CloneFrom(Source As COH_Resource_GEO_BoneInfo) As Boolean
            With Source
                .NumberBones = NumberBones
                .BoneIDs = New GEO_Enums_MESH_BoneId(MAXBONES - 1) {}
                For X = 0 To MAXBONES - 1
                    .BoneIDs(X) = BoneIDs(X)
                Next
                .Weights = New COH_Struct_Weight(Weights.Count - 1) {}
                For X = 0 To Weights.Count - 1
                    .Weights(X) = Weights(X) '.clone  
                Next
                .MaterialIndexs = New COH_Struct_MaterialIndex(MaterialIndexs.Count - 1) {}
                For X = 0 To MaterialIndexs.Count - 1
                    .MaterialIndexs(X) = MaterialIndexs(X) '.clone  
                Next
            End With
            Return True
        End Function
#End Region

#Region "Import / Export"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            NumberBones = CurrentReader.ReadUInt32
            For x = 0 To MAXBONES - 1
                BoneIDs(x) = CurrentReader.ReadUInt32
            Next
            Dim Unknown1 As UInt32 = CurrentReader.ReadUInt32 '//Reference to Weights or Materials
            If Unknown1 >= 1 Then
                ' COH_LibraryEventControl.Instance.Trigger_ErrorOccured(COH_Event_Error.COH_ErrorEvent.ControlledError, "Bone Unknown1 Has Value: " & Unknown1, Nothing, True)
                ' COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)
            End If
            Dim Unknown2 As UInt32 = CurrentReader.ReadUInt32
            If Unknown2 >= 1 Then
                ' COH_LibraryEventControl.Instance.Trigger_ErrorOccured(COH_Event_Error.COH_ErrorEvent.ControlledError, "Bone Unknown2 Has Value: " & Unknown1, Nothing, True)
                ' COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)
            End If
            Return True
        End Function
#End Region
    End Class
End Namespace