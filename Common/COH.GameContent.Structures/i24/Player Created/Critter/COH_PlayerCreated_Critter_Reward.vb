Namespace GameContent.Structures.PlayerCreated.Critter
    Public NotInheritable Class COH_PlayerCreated_Critter_Reward
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Reward"
            End Get
        End Property
#End Region

#Region "Properties"
        Property DifficultyMod As Single()
            Get
                Return mDifficultyMod
            End Get
            Set(value As Single())
                mDifficultyMod = value
            End Set
        End Property
        Property MissingRankPenalty As Single()
            Get
                Return mMissingRankPenalty
            End Get
            Set(value As Single())
                mMissingRankPenalty = value
            End Set
        End Property
        Property CustomPowerNumberMod As Single()
            Get
                Return mCustomPowerNumberMod
            End Get
            Set(value As Single())
                mCustomPowerNumberMod = value
            End Set
        End Property
        Property ArchitectAmbushScaling As Single
            Get
                Return mArchitectAmbushScaling
            End Get
            Set(value As Single)
                mArchitectAmbushScaling = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mDifficultyMod As Single()
       Private mMissingRankPenalty As Single()
       Private mCustomPowerNumberMod As Single()
       Private mArchitectAmbushScaling As Single
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
            mDifficultyMod = New Single() {}
            mMissingRankPenalty = New Single() {}
            mCustomPowerNumberMod = New Single() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_PlayerCreated_Critter_Reward
            Dim Result As COH_PlayerCreated_Critter_Reward = New COH_PlayerCreated_Critter_Reward
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDifficultyMod = New Single(mDifficultyMod.Count - 1) {} : mDifficultyMod.CopyTo(.mDifficultyMod, 0)
                .mMissingRankPenalty = New Single(mMissingRankPenalty.Count - 1) {} : mMissingRankPenalty.CopyTo(.mMissingRankPenalty, 0)
                .mCustomPowerNumberMod = New Single(mCustomPowerNumberMod.Count - 1) {} : mCustomPowerNumberMod.CopyTo(.mCustomPowerNumberMod, 0)
                .mArchitectAmbushScaling = mArchitectAmbushScaling
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_SingleArray(mDifficultyMod)
            CurrentWriter.Write_CrypticS_SingleArray(mMissingRankPenalty)
            CurrentWriter.Write_CrypticS_SingleArray(mCustomPowerNumberMod)
            CurrentWriter.Write(mArchitectAmbushScaling)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDifficultyMod = CurrentReader.Read_CrypticS_SingleArray()
            mMissingRankPenalty = CurrentReader.Read_CrypticS_SingleArray()
            mCustomPowerNumberMod = CurrentReader.Read_CrypticS_SingleArray()
            mArchitectAmbushScaling = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
