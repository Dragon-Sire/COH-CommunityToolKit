Imports COH.GameContent.Structures.Powers

Namespace GameContent.Structures.Store
    Public NotInheritable Class COH_Store_Items
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
        Property Power As COH_PowerName
            Get
                Return mPower
            End Get
            Set(value As COH_PowerName)
                mPower = value
            End Set
        End Property
        Property Sell As Int32
            Get
                Return mSell
            End Get
            Set(value As Int32)
                mSell = value
            End Set
        End Property
        Property Buy As Int32
            Get
                Return mBuy
            End Get
            Set(value As Int32)
                mBuy = value
            End Set
        End Property
        Property CountPerStore As Int32
            Get
                Return mCountPerStore
            End Get
            Set(value As Int32)
                mCountPerStore = value
            End Set
        End Property
        Property Departments As Int32()
            Get
                Return mDepartments
            End Get
            Set(value As Int32())
                mDepartments = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mPower As COH_PowerName
       Private mSell As Int32
       Private mBuy As Int32
       Private mCountPerStore As Int32
       Private mDepartments As Int32()
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
            mPower = New COH_PowerName
            mDepartments = New Int32() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Store_Items
            Dim Result As COH_Store_Items = New COH_Store_Items
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mPower = mPower
                .mSell = mSell
                .mBuy = mBuy
                .mCountPerStore = mCountPerStore
                .mDepartments = New Int32(mDepartments.Count - 1) {} : mDepartments.CopyTo(.mDepartments, 0)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            If CurrentWriter.Write_CrypticS_Struct(mPower) = False Then Return False
            CurrentWriter.Write(mSell)
            CurrentWriter.Write(mBuy)
            CurrentWriter.Write(mCountPerStore)
            CurrentWriter.Write_CrypticS_IntegerArray(mDepartments)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_Struct(GetType(COH_PowerName), mPower) = False Then Return False
            mSell = CurrentReader.ReadInt32
            mBuy = CurrentReader.ReadInt32
            mCountPerStore = CurrentReader.ReadInt32
            mDepartments = CurrentReader.Read_CrypticS_IntegerArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
