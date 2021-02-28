Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GEO_AlternatePivotInfo
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_Identifier")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "PolyCell"
            End Get
        End Property
#End Region

#Region "CONST"
        Const MAX_ALTPIVOTS As Int32 = 15
#End Region

#Region "Private Properties"
        Property PivotCount As Integer
        Property Pivot As COH_Struct_Matrix4() '15
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
            PivotCount = CurrentReader.ReadInt32
            Pivot = New COH_Struct_Matrix4(MAX_ALTPIVOTS - 1) {}
            For X = 0 To MAX_ALTPIVOTS - 1 ' Max 15 - 1
                Pivot(X) = CurrentReader.Read_CrypticS_Matrix4
            Next
            Return True
            Return True
        End Function
#End Region
    End Class
End Namespace