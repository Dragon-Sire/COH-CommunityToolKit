Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GEO_ModelExtra
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Model Extras"
            End Get
        End Property
#End Region

#Region "Properties"
        Property PortalCount As Integer
        Property Portals As COH_Resource_GEO_Portal() '//8
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
            PortalCount = CurrentReader.ReadUInt32
            Portals = New COH_Resource_GEO_Portal(7) {}
            For X = 0 To 7 ' PortalCount - 1
                Portals(X) = New COH_Resource_GEO_Portal(CurrentReader)
            Next
            Return True
        End Function
#End Region
    End Class
End Namespace