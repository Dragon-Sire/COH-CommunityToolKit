Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GenericMesh_PolyCell
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_Identifier")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "PolyCell"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Children As COH_Resource_GenericMesh_PolyCell
        Property TriangleIndex As UShort
        Property TriangleCount As Integer
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
        Public Function Clone() As COH_Resource_GenericMesh_PolyCell
            Dim Destination As New COH_Resource_GenericMesh_PolyCell
            CloneTo(Destination)
            Return Destination
        End Function
        Public Overloads Sub CloneTo(ByRef Destination As COH_Resource_GenericMesh_PolyCell)
            'MyBase.CloneTo(TryCast(Destination, COH_FileStructure))
            With Destination
                If Not .Children Is Nothing Then
                    .Children = Children.Clone
                End If
                .TriangleCount = TriangleCount
                .TriangleIndex = TriangleIndex
            End With
        End Sub
#End Region

#Region "Import / Export"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Dim ChildrenPointer As UInt32 = CurrentReader.ReadUInt32
            TriangleIndex = CurrentReader.ReadUInt16
            TriangleCount = CurrentReader.ReadUInt32
            Return True
        End Function
#End Region
    End Class
End Namespace