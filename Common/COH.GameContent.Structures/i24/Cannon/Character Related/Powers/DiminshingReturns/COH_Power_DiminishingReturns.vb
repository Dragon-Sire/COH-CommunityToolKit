Namespace GameContent.Structures.Powers
    Public NotInheritable Class COH_Power_DiminishingReturns
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Dim Return"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Start As Single
            Get
                Return mStart
            End Get
            Set(value As Single)
                mStart = value
            End Set
        End Property
        Property Handicap As Single
            Get
                Return mHandicap
            End Get
            Set(value As Single)
                mHandicap = value
            End Set
        End Property
        Property Basis As Single
            Get
                Return mBasis
            End Get
            Set(value As Single)
                mBasis = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mStart As Single
       Private mHandicap As Single
       Private mBasis As Single
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
        Public Function Clone() As COH_Power_DiminishingReturns
            Dim Result As COH_Power_DiminishingReturns = New COH_Power_DiminishingReturns
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mStart = mStart
                .mHandicap = mHandicap
                .mBasis = mBasis
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mStart)
            CurrentWriter.Write(mHandicap)
            CurrentWriter.Write(mBasis)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mStart = CurrentReader.ReadSingle
            mHandicap = CurrentReader.ReadSingle
            mBasis = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
