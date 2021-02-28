Namespace GameContent.Structures.AuctionHouse
    Public NotInheritable Class COH_AunctionHouse_Fee
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "AunctionHouseFees"
            End Get
        End Property
#End Region

#Region "Properties"
        Property SellFeePercent As Single
            Get
                Return mSellFeePercent
            End Get
            Set(value As Single)
                mSellFeePercent = value
            End Set
        End Property
        Property BuyFeePercent As Single
            Get
                Return mBuyFeePercent
            End Get
            Set(value As Single)
                mBuyFeePercent = value
            End Set
        End Property
        Property MinFee As Int32
            Get
                Return mMinFee
            End Get
            Set(value As Int32)
                mMinFee = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mSellFeePercent As Single
       Private mBuyFeePercent As Single
       Private mMinFee As Int32
#End Region

#Region "Create New Instance"
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
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_AunctionHouse_Fee
            Dim Result As COH_AunctionHouse_Fee = New COH_AunctionHouse_Fee
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mSellFeePercent = mSellFeePercent
                .mBuyFeePercent = mBuyFeePercent
                .mMinFee = mMinFee
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mAuctionConfig)
            CurrentWriter.Write(mSellFeePercent)
            CurrentWriter.Write(mBuyFeePercent)
            CurrentWriter.Write(mMinFee)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mAuctionConfig = 
            mSellFeePercent = CurrentReader.ReadSingle
            mBuyFeePercent = CurrentReader.ReadSingle
            mMinFee = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
