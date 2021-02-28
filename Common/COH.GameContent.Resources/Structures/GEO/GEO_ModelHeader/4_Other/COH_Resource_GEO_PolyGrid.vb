Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GenericMesh_PolyGrid
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_Identifier")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "PolyGrid"
            End Get
        End Property
#End Region

#Region "Private Properties"
        Property PolyCell_Pointer As UInt32
        Property PolyCell As COH_Resource_GenericMesh_PolyCell
        Property Position As COH_Struct_Vector3
        Property GridSize As Single
        Property Inv_Size As Single
        Property Tag As Integer
        Property NumBits As Integer
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

#Region "Initialize"
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_GenericMesh_PolyGrid
            Dim Destination As New COH_Resource_GenericMesh_PolyGrid
            CloneTo(Destination)
            Return Destination
        End Function
        Public Overloads Sub CloneTo(ByRef Destination As COH_Resource_GenericMesh_PolyGrid)
            'MyBase.CloneTo(TryCast(Destination, COH_FileStructure))
            With Destination
                .PolyCell_Pointer = PolyCell_Pointer
                .Position = Position
                .GridSize = GridSize
                .Inv_Size = Inv_Size
                .Tag = .Tag
                .NumBits = .NumBits
                If Not .PolyCell Is Nothing Then
                    .PolyCell = PolyCell.Clone
                End If
            End With
        End Sub
#End Region

#Region "Import / Export"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            PolyCell_Pointer = CurrentReader.ReadUInt32
            Position = CurrentReader.Read_CrypticS_Vector3
            GridSize = CurrentReader.ReadSingle
            Inv_Size = CurrentReader.ReadSingle
            Tag = CurrentReader.ReadInt32
            NumBits = CurrentReader.ReadInt32
            Return True
        End Function
#End Region
    End Class
End Namespace