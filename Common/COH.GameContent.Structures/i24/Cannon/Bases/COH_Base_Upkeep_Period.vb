Namespace GameContent.Structures.Bases
    Public NotInheritable Class COH_Base_UpkeepPeriod
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Period"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Period As Int32
            Get
                Return mPeriod
            End Get
            Set(value As Int32)
                mPeriod = value
            End Set
        End Property
        Property ShutBaseDown As Boolean
            Get
                Return mShutBaseDown
            End Get
            Set(value As Boolean)
                mShutBaseDown = value
            End Set
        End Property
        Property DenyBaseEntry As Boolean
            Get
                Return mDenyBaseEntry
            End Get
            Set(value As Boolean)
                mDenyBaseEntry = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mPeriod As Int32
       Private mShutBaseDown As Boolean
       Private mDenyBaseEntry As Boolean
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

#Region "Clone"
        Public Function Clone() As COH_Base_UpkeepPeriod
            Dim Result As COH_Base_UpkeepPeriod = New COH_Base_UpkeepPeriod
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mPeriod = mPeriod
                .mShutBaseDown = mShutBaseDown
                .mDenyBaseEntry = mDenyBaseEntry
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mPeriod)
            CurrentWriter.Write_CrypticS_Boolean(mShutBaseDown)
            CurrentWriter.Write_CrypticS_Boolean(mDenyBaseEntry)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mPeriod = CurrentReader.ReadInt32
            mShutBaseDown = CurrentReader.Read_CrypticS_Boolean
            mDenyBaseEntry = CurrentReader.Read_CrypticS_Boolean
            Return True
        End Function
#End Region

    End Class
End Namespace
