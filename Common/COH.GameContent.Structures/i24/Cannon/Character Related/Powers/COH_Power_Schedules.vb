Namespace GameContent.Structures.Powers
    Public NotInheritable Class COH_Power_Schedules
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Schedules"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Powers As COH_Power_Schedule
            Get
                Return mPowers
            End Get
            Set(value As COH_Power_Schedule)
                mPowers = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mPowers As COH_Power_Schedule
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
            mPowers = New COH_Power_Schedule
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Power_Schedules
            Dim Result As COH_Power_Schedules = New COH_Power_Schedules
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mPowers = mPowers
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Write_CrypticS_Struct(mPowers) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Read_CrypticS_Struct(GetType(COH_Power_Schedule), mPowers) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
