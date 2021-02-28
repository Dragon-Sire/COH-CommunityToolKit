Namespace GameContent.Structures.World.DayJobs
    Public NotInheritable Class COH_DayJob_Power
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Power
            End Get
        End Property
#End Region

#Region "Properties"
        Property Power As String
            Get
                Return mPower
            End Get
            Set(value As String)
                mPower = value
            End Set
        End Property
        Property Salvage As String
            Get
                Return mSalvage
            End Get
            Set(value As String)
                mSalvage = value
            End Set
        End Property
        Property Requires As String()
            Get
                Return mRequires
            End Get
            Set(value As String())
                mRequires = value
            End Set
        End Property
        Property Factor As Single
            Get
                Return mFactor
            End Get
            Set(value As Single)
                mFactor = value
            End Set
        End Property
        Property Max As Int32
            Get
                Return mMax
            End Get
            Set(value As Int32)
                mMax = value
            End Set
        End Property
        Property RemainderToken As String
            Get
                Return mRemainderToken
            End Get
            Set(value As String)
                mRemainderToken = value
            End Set
        End Property
        Property Type As COH_Enum_JobPowerType
            Get
                Return mType
            End Get
            Set(value As COH_Enum_JobPowerType)
                mType = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mPower As String
       Private mSalvage As String
       Private mRequires As String()
       Private mFactor As Single
       Private mMax As Int32
       Private mRemainderToken As String
       Private mType As COH_Enum_JobPowerType
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0)
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
            mPower = String.Empty
            mSalvage = String.Empty
            mRequires = New String() {}
            mRemainderToken = String.Empty
            mType = COH_Enum_JobPowerType.kDayJobPowerType_TimeInGame
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_DayJob_Power
            Dim Result As COH_DayJob_Power = New COH_DayJob_Power
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mPower = String.Copy(mPower)
                .mSalvage = String.Copy(mSalvage)
                .mRequires = mRequires.CloneTheStrings
                .mFactor = mFactor
                .mMax = mMax
                .mRemainderToken = String.Copy(mRemainderToken)
                .mType = mType
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mPower)
            CurrentWriter.Write_CrypticS_String(mSalvage)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write(mFactor)
            CurrentWriter.Write(mMax)
            CurrentWriter.Write_CrypticS_String(mRemainderToken)
            CurrentWriter.Write(CInt(mType))
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mPower = CurrentReader.Read_CrypticS_String
            mSalvage = CurrentReader.Read_CrypticS_String
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mFactor = CurrentReader.ReadSingle
            mMax = CurrentReader.ReadInt32
            mRemainderToken = CurrentReader.Read_CrypticS_String
            mType = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
