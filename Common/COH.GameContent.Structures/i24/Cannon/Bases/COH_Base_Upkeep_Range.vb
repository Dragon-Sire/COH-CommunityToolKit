Namespace GameContent.Structures.Bases
    Public NotInheritable Class COH_Base_UpkeepRange
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Range"
            End Get
        End Property
#End Region

#Region "Properties"
        Property RentMax As Int32
            Get
                Return mRentMax
            End Get
            Set(value As Int32)
                mRentMax = value
            End Set
        End Property
        Property Rate As Single
            Get
                Return mRate
            End Get
            Set(value As Single)
                mRate = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mRentMax As Int32
       Private mRate As Single
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
        Public Function Clone() As COH_Base_UpkeepRange
            Dim Result As COH_Base_UpkeepRange = New COH_Base_UpkeepRange
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mRentMax = mRentMax
                .mRate = mRate
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mRentMax)
            CurrentWriter.Write(mRate)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mRentMax = CurrentReader.ReadInt32
            mRate = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
