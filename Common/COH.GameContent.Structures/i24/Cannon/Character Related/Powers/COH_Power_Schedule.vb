Namespace GameContent.Structures.Powers
    Public NotInheritable Class COH_Power_Schedule
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Schedule"
            End Get
        End Property
#End Region

#Region "Properties"
        Property FreeBoostSlotsOnPower As Int32()
            Get
                Return mFreeBoostSlotsOnPower
            End Get
            Set(value As Int32())
                mFreeBoostSlotsOnPower = value
            End Set
        End Property
        Property PoolPowerSet As Int32()
            Get
                Return mPoolPowerSet
            End Get
            Set(value As Int32())
                mPoolPowerSet = value
            End Set
        End Property
        Property EpicPowerSet As Int32()
            Get
                Return mEpicPowerSet
            End Get
            Set(value As Int32())
                mEpicPowerSet = value
            End Set
        End Property
        Property Power As Int32()
            Get
                Return mPower
            End Get
            Set(value As Int32())
                mPower = value
            End Set
        End Property
        Property AssignableBoost As Int32()
            Get
                Return mAssignableBoost
            End Get
            Set(value As Int32())
                mAssignableBoost = value
            End Set
        End Property
        Property InspirationCol As Int32()
            Get
                Return mInspirationCol
            End Get
            Set(value As Int32())
                mInspirationCol = value
            End Set
        End Property
        Property InspirationRow As Int32()
            Get
                Return mInspirationRow
            End Get
            Set(value As Int32())
                mInspirationRow = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mFreeBoostSlotsOnPower As Int32()
       Private mPoolPowerSet As Int32()
       Private mEpicPowerSet As Int32()
       Private mPower As Int32()
       Private mAssignableBoost As Int32()
       Private mInspirationCol As Int32()
       Private mInspirationRow As Int32()
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
            mFreeBoostSlotsOnPower = New Int32() {}
            mPoolPowerSet = New Int32() {}
            mEpicPowerSet = New Int32() {}
            mPower = New Int32() {}
            mAssignableBoost = New Int32() {}
            mInspirationCol = New Int32() {}
            mInspirationRow = New Int32() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Power_Schedule
            Dim Result As COH_Power_Schedule = New COH_Power_Schedule
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mFreeBoostSlotsOnPower = New Int32(mFreeBoostSlotsOnPower.Count - 1) {} : mFreeBoostSlotsOnPower.CopyTo(.mFreeBoostSlotsOnPower, 0)
                .mPoolPowerSet = New Int32(mPoolPowerSet.Count - 1) {} : mPoolPowerSet.CopyTo(.mPoolPowerSet, 0)
                .mEpicPowerSet = New Int32(mEpicPowerSet.Count - 1) {} : mEpicPowerSet.CopyTo(.mEpicPowerSet, 0)
                .mPower = New Int32(mPower.Count - 1) {} : mPower.CopyTo(.mPower, 0)
                .mAssignableBoost = New Int32(mAssignableBoost.Count - 1) {} : mAssignableBoost.CopyTo(.mAssignableBoost, 0)
                .mInspirationCol = New Int32(mInspirationCol.Count - 1) {} : mInspirationCol.CopyTo(.mInspirationCol, 0)
                .mInspirationRow = New Int32(mInspirationRow.Count - 1) {} : mInspirationRow.CopyTo(.mInspirationRow, 0)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_IntegerArray(mFreeBoostSlotsOnPower)
            CurrentWriter.Write_CrypticS_IntegerArray(mPoolPowerSet)
            CurrentWriter.Write_CrypticS_IntegerArray(mEpicPowerSet)
            CurrentWriter.Write_CrypticS_IntegerArray(mPower)
            CurrentWriter.Write_CrypticS_IntegerArray(mAssignableBoost)
            CurrentWriter.Write_CrypticS_IntegerArray(mInspirationCol)
            CurrentWriter.Write_CrypticS_IntegerArray(mInspirationRow)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mFreeBoostSlotsOnPower = CurrentReader.Read_CrypticS_IntegerArray()
            mPoolPowerSet = CurrentReader.Read_CrypticS_IntegerArray()
            mEpicPowerSet = CurrentReader.Read_CrypticS_IntegerArray()
            mPower = CurrentReader.Read_CrypticS_IntegerArray()
            mAssignableBoost = CurrentReader.Read_CrypticS_IntegerArray()
            mInspirationCol = CurrentReader.Read_CrypticS_IntegerArray()
            mInspirationRow = CurrentReader.Read_CrypticS_IntegerArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
