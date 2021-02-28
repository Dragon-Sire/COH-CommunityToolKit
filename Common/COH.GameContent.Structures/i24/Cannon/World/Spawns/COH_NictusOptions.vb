Namespace GameContent.Structures.Spawns
    Public NotInheritable Class COH_NictusOptions
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "NictusOption"
            End Get
        End Property
#End Region

#Region "Properties"
        Property MissionAdd As Single
            Get
                Return mMissionAdd
            End Get
            Set(value As Single)
                mMissionAdd = value
            End Set
        End Property
        Property ZoneAdd As Single
            Get
                Return mZoneAdd
            End Get
            Set(value As Single)
                mZoneAdd = value
            End Set
        End Property
        Property NictusGroup As Single
            Get
                Return mNictusGroup
            End Get
            Set(value As Single)
                mNictusGroup = value
            End Set
        End Property
        Property TeamSize As COH_RankSelect()
            Get
                Return mTeamSize
            End Get
            Set(value As COH_RankSelect())
                mTeamSize = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mMissionAdd As Single
       Private mZoneAdd As Single
       Private mNictusGroup As Single
       Private mTeamSize As COH_RankSelect()
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0)
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
            mTeamSize = New COH_RankSelect() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_NictusOptions
            Dim Result As COH_NictusOptions = New COH_NictusOptions
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mMissionAdd = mMissionAdd
                .mZoneAdd = mZoneAdd
                .mNictusGroup = mNictusGroup
                .mTeamSize = New COH_RankSelect(mTeamSize.Count - 1) {}
                For X = 0 To mTeamSize.Count - 1
                    .mTeamSize(X) = mTeamSize(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mMissionAdd)
            CurrentWriter.Write(mZoneAdd)
            CurrentWriter.Write(mNictusGroup)
            If CurrentWriter.Write_CrypticS_StructArray(mTeamSize) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mMissionAdd = CurrentReader.ReadSingle
            mZoneAdd = CurrentReader.ReadSingle
            mNictusGroup = CurrentReader.ReadSingle
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_RankSelect), mTeamSize) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
