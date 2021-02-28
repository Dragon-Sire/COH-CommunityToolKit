Namespace GameContent.Structures.Characters
    Public NotInheritable Class COH_ExperienceTables
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Experience Table"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Table As COH_ExperienceTable
            Get
                Return mTables
            End Get
            Set(value As COH_ExperienceTable)
                mTables = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTables As COH_ExperienceTable
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings as COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings as COH_Serialization_Settings = Nothing)
            MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mTables = New COH_ExperienceTable
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ExperienceTables
            Dim Result As COH_ExperienceTables = New COH_ExperienceTables
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTables = mTables.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTables = New COH_ExperienceTable
            Dim StructSize As UInt32 = CurrentReader.ReadUInt32
            mTables = New COH_ExperienceTable(CurrentReader)
            Return True
        End Function
#End Region

    End Class
End Namespace
