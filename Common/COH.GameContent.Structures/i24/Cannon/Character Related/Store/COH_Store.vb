Namespace GameContent.Structures.Store
    Public NotInheritable Class COH_Stores
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property Sell As COH_Stores_Markup()
            Get
                Return mSell
            End Get
            Set(value As COH_Stores_Markup())
                mSell = value
            End Set
        End Property
        Property Buy As COH_Stores_Markup()
            Get
                Return mBuy
            End Get
            Set(value As COH_Stores_Markup())
                mBuy = value
            End Set
        End Property
        Property Item As COH_Stores_ItemName()
            Get
                Return mItem
            End Get
            Set(value As COH_Stores_ItemName())
                mItem = value
            End Set
        End Property
        Property Salvage As Single
            Get
                Return mSalvage
            End Get
            Set(value As Single)
                mSalvage = value
            End Set
        End Property
        Property Recipe As Single
            Get
                Return mRecipe
            End Get
            Set(value As Single)
                mRecipe = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mSell As COH_Stores_Markup()
       Private mBuy As COH_Stores_Markup()
       Private mItem As COH_Stores_ItemName()
       Private mSalvage As Single
       Private mRecipe As Single
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
            mName = String.Empty
            mSell = New COH_Stores_Markup() {}
            mBuy = New COH_Stores_Markup() {}
            mItem = New COH_Stores_ItemName() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Stores
            Dim Result As COH_Stores = New COH_Stores
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mSell = New COH_Stores_Markup(mSell.Count - 1) {}
                For X = 0 To mSell.Count - 1
                    .mSell(X) = mSell(X).Clone
                Next
                .mBuy = New COH_Stores_Markup(mBuy.Count - 1) {}
                For X = 0 To mBuy.Count - 1
                    .mBuy(X) = mBuy(X).Clone
                Next
                .mItem = New COH_Stores_ItemName(mItem.Count - 1) {}
                For X = 0 To mItem.Count - 1
                    .mItem(X) = mItem(X).Clone
                Next
                .mSalvage = mSalvage
                .mRecipe = mRecipe
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            If CurrentWriter.Write_CrypticS_StructArray(mSell) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mBuy) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mItem) = False Then Return False
            CurrentWriter.Write(mSalvage)
            CurrentWriter.Write(mRecipe)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Stores_Markup), mSell) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Stores_Markup), mBuy) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Stores_ItemName), mItem) = False Then Return False
            mSalvage = CurrentReader.ReadSingle
            mRecipe = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
