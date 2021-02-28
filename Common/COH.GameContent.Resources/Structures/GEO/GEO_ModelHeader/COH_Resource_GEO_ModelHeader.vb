Namespace GameContent.Structures.Resources.GEO
    Public Class COH_Resource_GEO_ModelHeader
        Inherits COH_FileStructure

#Region "Proporties - Identifier"
        <Category("_Identifier")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return ModelName
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("Details")> Property ModelName As String
        <Category("Details")> Property Models As COH_Resource_GEOModel()
        <Category("Details")> Property Model_Count As Integer
        <Category("Unknown")> Property Length As Single 'of animation track, if any, in case the sequencer doesn't specify, kinda hack.
        <Category("Unknown")> Property ModelData_Pointer As UInteger
        <Category("Unknown")> Property ModelsPointer As UInteger
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
            ModelName = CurrentReader.ReadString_LengthFixed_UTF8(124)
            ModelName = ModelName.Substring(0, ModelName.IndexOf(ChrW(0)))
            ModelData_Pointer = CurrentReader.ReadUInt32 'POINTER TO MODEL DATA
            Length = CurrentReader.ReadUInt32 '//of animation track, if any, in case the sequencer doesn't specify, kinda hack.
            ModelsPointer = CurrentReader.ReadUInt32
            Model_Count = CurrentReader.ReadUInt32
            Models = New COH_Resource_GEOModel(Model_Count - 1) {}
            For X = 0 To Model_Count - 1
                Models(X) = New COH_Resource_GEOModel(CurrentReader)
                If Models(X).CurrentInstance_Valid = False Then Return False
            Next
            Return True
        End Function
#End Region

    End Class
End Namespace