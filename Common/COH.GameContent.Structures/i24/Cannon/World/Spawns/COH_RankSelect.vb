Namespace GameContent.Structures.Spawns
    Public NotInheritable Class COH_RankSelect
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "RankSelect"
            End Get
        End Property
#End Region

#Region "Properties"
        Property TeamSize As Int32
            Get
                Return mTeamSize
            End Get
            Set(value As Int32)
                mTeamSize = value
            End Set
        End Property
        Property BossChance As Single
            Get
                Return mBossChance
            End Get
            Set(value As Single)
                mBossChance = value
            End Set
        End Property
        Property LieutenantChance As Single
            Get
                Return mLieutenantChance
            End Get
            Set(value As Single)
                mLieutenantChance = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTeamSize As Int32
       Private mBossChance As Single
       Private mLieutenantChance As Single
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
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_RankSelect
            Dim Result As COH_RankSelect = New COH_RankSelect
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTeamSize = mTeamSize
                .mBossChance = mBossChance
                .mLieutenantChance = mLieutenantChance
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mTeamSize)
            CurrentWriter.Write(mBossChance)
            CurrentWriter.Write(mLieutenantChance)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTeamSize = CurrentReader.ReadInt32
            mBossChance = CurrentReader.ReadSingle
            mLieutenantChance = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
