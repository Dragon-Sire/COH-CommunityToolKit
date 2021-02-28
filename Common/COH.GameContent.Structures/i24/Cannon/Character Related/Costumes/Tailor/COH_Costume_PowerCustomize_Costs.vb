Namespace GameContent.Structures.Costumes.Tailor
    Public NotInheritable Class COH_Costum_PowerCustomize_Costs
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Costs"
            End Get
        End Property
#End Region

#Region "Properties"
        Property MinLevel As Int32
            Get
                Return mMinLevel
            End Get
            Set(value As Int32)
                mMinLevel = value
            End Set
        End Property
        Property MaxLevel As Int32
            Get
                Return mMaxLevel
            End Get
            Set(value As Int32)
                mMaxLevel = value
            End Set
        End Property
        Property EntryFee As Int32
            Get
                Return mEntryFee
            End Get
            Set(value As Int32)
                mEntryFee = value
            End Set
        End Property
        Property PowerTokenCost As Int32
            Get
                Return mPowerTokenCost
            End Get
            Set(value As Int32)
                mPowerTokenCost = value
            End Set
        End Property
        Property PowerColorCost As Int32
            Get
                Return mPowerColorCost
            End Get
            Set(value As Int32)
                mPowerColorCost = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mMinLevel As Int32
       Private mMaxLevel As Int32
       Private mEntryFee As Int32
       Private mPowerTokenCost As Int32
       Private mPowerColorCost As Int32
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
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Costum_PowerCustomize_Costs
            Dim Result As COH_Costum_PowerCustomize_Costs = New COH_Costum_PowerCustomize_Costs
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mMinLevel = mMinLevel
                .mMaxLevel = mMaxLevel
                .mEntryFee = mEntryFee
                .mPowerTokenCost = mPowerTokenCost
                .mPowerColorCost = mPowerColorCost
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mMinLevel)
            CurrentWriter.Write(mMaxLevel)
            CurrentWriter.Write(mEntryFee)
            CurrentWriter.Write(mPowerTokenCost)
            CurrentWriter.Write(mPowerColorCost)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mMinLevel = CurrentReader.ReadInt32
            mMaxLevel = CurrentReader.ReadInt32
            mEntryFee = CurrentReader.ReadInt32
            mPowerTokenCost = CurrentReader.ReadInt32
            mPowerColorCost = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace

