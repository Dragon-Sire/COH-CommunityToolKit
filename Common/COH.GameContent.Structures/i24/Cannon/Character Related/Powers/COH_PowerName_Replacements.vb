Namespace GameContent.Structures.Powers
    Public NotInheritable Class COH_Power_NameReplacements
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "List"
            End Get
        End Property
#End Region

#Region "Properties"
        Property PowerSet As COH_Power_NameMap()
            Get
                Return mPowerSet
            End Get
            Set(value As COH_Power_NameMap())
                mPowerSet = value
            End Set
        End Property
        Property Power As COH_Power_NameMap()
            Get
                Return mPower
            End Get
            Set(value As COH_Power_NameMap())
                mPower = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mPowerSet As COH_Power_NameMap()
       Private mPower As COH_Power_NameMap()
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
            mPowerSet = New COH_Power_NameMap() {}
            mPower = New COH_Power_NameMap() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Power_NameReplacements
            Dim Result As COH_Power_NameReplacements = New COH_Power_NameReplacements
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mPowerSet = New COH_Power_NameMap(mPowerSet.Count - 1) {}
                For X = 0 To mPowerSet.Count - 1
                    .mPowerSet(X) = mPowerSet(X).Clone
                Next
                .mPower = New COH_Power_NameMap(mPower.Count - 1) {}
                For X = 0 To mPower.Count - 1
                    .mPower(X) = mPower(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Write_CrypticS_StructArray(mPowerSet) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mPower) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Power_NameMap), mPowerSet) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Power_NameMap), mPower) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
