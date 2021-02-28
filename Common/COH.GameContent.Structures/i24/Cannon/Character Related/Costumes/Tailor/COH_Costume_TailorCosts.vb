Namespace GameContent.Structures.Costumes.Tailor
    Public NotInheritable Class COH_Costume_TailorCosts
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Tailor Costs - " & MinLevel + 1 & " - " & MaxLevel
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
        Property [Global] As Int32
            Get
                Return mGlobal
            End Get
            Set(value As Int32)
                mGlobal = value
            End Set
        End Property
        Property HeadCost As Int32
            Get
                Return mHeadCost
            End Get
            Set(value As Int32)
                mHeadCost = value
            End Set
        End Property
        Property HeadSubCost As Int32
            Get
                Return mHeadSubCost
            End Get
            Set(value As Int32)
                mHeadSubCost = value
            End Set
        End Property
        Property UpperCost As Int32
            Get
                Return mUpperCost
            End Get
            Set(value As Int32)
                mUpperCost = value
            End Set
        End Property
        Property UpperSubCost As Int32
            Get
                Return mUpperSubCost
            End Get
            Set(value As Int32)
                mUpperSubCost = value
            End Set
        End Property
        Property LowerCost As Int32
            Get
                Return mLowerCost
            End Get
            Set(value As Int32)
                mLowerCost = value
            End Set
        End Property
        Property LoserSubCost As Int32
            Get
                Return mLoserSubCost
            End Get
            Set(value As Int32)
                mLoserSubCost = value
            End Set
        End Property
        Property NumCostumes As Int32
            Get
                Return mNumCostumes
            End Get
            Set(value As Int32)
                mNumCostumes = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mMinLevel As Int32
       Private mMaxLevel As Int32
       Private mEntryFee As Int32
       Private mGlobal As Int32
       Private mHeadCost As Int32
       Private mHeadSubCost As Int32
       Private mUpperCost As Int32
       Private mUpperSubCost As Int32
       Private mLowerCost As Int32
       Private mLoserSubCost As Int32
       Private mNumCostumes As Int32
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
        Public Function Clone() As COH_Costume_TailorCosts
            Dim Result As COH_Costume_TailorCosts = New COH_Costume_TailorCosts
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mMinLevel = mMinLevel
                .mMaxLevel = mMaxLevel
                .mEntryFee = mEntryFee
                .mGlobal = mGlobal
                .mHeadCost = mHeadCost
                .mHeadSubCost = mHeadSubCost
                .mUpperCost = mUpperCost
                .mUpperSubCost = mUpperSubCost
                .mLowerCost = mLowerCost
                .mLoserSubCost = mLoserSubCost
                .mNumCostumes = mNumCostumes
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mMinLevel)
            CurrentWriter.Write(mMaxLevel)
            CurrentWriter.Write(mEntryFee)
            CurrentWriter.Write(mGlobal)
            CurrentWriter.Write(mHeadCost)
            CurrentWriter.Write(mHeadSubCost)
            CurrentWriter.Write(mUpperCost)
            CurrentWriter.Write(mUpperSubCost)
            CurrentWriter.Write(mLowerCost)
            CurrentWriter.Write(mLoserSubCost)
            CurrentWriter.Write(mNumCostumes)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mMinLevel = CurrentReader.ReadInt32
            mMaxLevel = CurrentReader.ReadInt32
            mEntryFee = CurrentReader.ReadInt32
            mGlobal = CurrentReader.ReadInt32
            mHeadCost = CurrentReader.ReadInt32
            mHeadSubCost = CurrentReader.ReadInt32
            mUpperCost = CurrentReader.ReadInt32
            mUpperSubCost = CurrentReader.ReadInt32
            mLowerCost = CurrentReader.ReadInt32
            mLoserSubCost = CurrentReader.ReadInt32
            mNumCostumes = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
