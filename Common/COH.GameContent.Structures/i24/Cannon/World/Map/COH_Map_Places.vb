Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_Map_PlaceStats
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "PlaceStats"
            End Get
        End Property
#End Region

#Region "Properties"
        Property place As COH_Enum_MissionPlace
            Get
                Return mplace
            End Get
            Set(value As COH_Enum_MissionPlace)
                mplace = value
            End Set
        End Property
        Property genericEncounterCount As Int32
            Get
                Return mgenericEncounterCount
            End Get
            Set(value As Int32)
                mgenericEncounterCount = value
            End Set
        End Property
        Property genericEncounterOnlyCount As Int32
            Get
                Return mgenericEncounterOnlyCount
            End Get
            Set(value As Int32)
                mgenericEncounterOnlyCount = value
            End Set
        End Property
        Property hostageLocationCount As Int32
            Get
                Return mhostageLocationCount
            End Get
            Set(value As Int32)
                mhostageLocationCount = value
            End Set
        End Property
        Property wallObjectiveCount As Int32
            Get
                Return mwallObjectiveCount
            End Get
            Set(value As Int32)
                mwallObjectiveCount = value
            End Set
        End Property
        Property floorObjectiveCount As Int32
            Get
                Return mfloorObjectiveCount
            End Get
            Set(value As Int32)
                mfloorObjectiveCount = value
            End Set
        End Property
        Property roofObjectiveCount As Int32
            Get
                Return mroofObjectiveCount
            End Get
            Set(value As Int32)
                mroofObjectiveCount = value
            End Set
        End Property
        Property customEncounters As COH_Map_EncounterStats()
            Get
                Return mcustomEncounters
            End Get
            Set(value As COH_Map_EncounterStats())
                mcustomEncounters = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mplace As COH_Enum_MissionPlace
       Private mgenericEncounterCount As Int32
       Private mgenericEncounterOnlyCount As Int32
       Private mhostageLocationCount As Int32
       Private mwallObjectiveCount As Int32
       Private mfloorObjectiveCount As Int32
       Private mroofObjectiveCount As Int32
       Private mcustomEncounters As COH_Map_EncounterStats()
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
            mplace = -1
            mcustomEncounters = New COH_Map_EncounterStats() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Map_PlaceStats
            Dim Result As COH_Map_PlaceStats = New COH_Map_PlaceStats
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mplace = mplace
                .mgenericEncounterCount = mgenericEncounterCount
                .mgenericEncounterOnlyCount = mgenericEncounterOnlyCount
                .mhostageLocationCount = mhostageLocationCount
                .mwallObjectiveCount = mwallObjectiveCount
                .mfloorObjectiveCount = mfloorObjectiveCount
                .mroofObjectiveCount = mroofObjectiveCount
                .mcustomEncounters = New COH_Map_EncounterStats(mcustomEncounters.Count - 1) {}
                For X = 0 To mcustomEncounters.Count - 1
                    .mcustomEncounters(X) = mcustomEncounters(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(CInt(mplace))
            CurrentWriter.Write(mgenericEncounterCount)
            CurrentWriter.Write(mgenericEncounterOnlyCount)
            CurrentWriter.Write(mhostageLocationCount)
            CurrentWriter.Write(mwallObjectiveCount)
            CurrentWriter.Write(mfloorObjectiveCount)
            CurrentWriter.Write(mroofObjectiveCount)
            If CurrentWriter.Write_CrypticS_StructArray(mcustomEncounters) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mplace = CurrentReader.ReadInt32
            mgenericEncounterCount = CurrentReader.ReadInt32
            mgenericEncounterOnlyCount = CurrentReader.ReadInt32
            mhostageLocationCount = CurrentReader.ReadInt32
            mwallObjectiveCount = CurrentReader.ReadInt32
            mfloorObjectiveCount = CurrentReader.ReadInt32
            mroofObjectiveCount = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Map_EncounterStats), mcustomEncounters) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
