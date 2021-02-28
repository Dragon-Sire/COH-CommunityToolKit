Namespace GameContent.Structures.World.DayJobs
    Public NotInheritable Class COH_DayJob_Detail
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property SourceFile As String
            Get
                Return mSourceFile
            End Get
            Set(value As String)
                mSourceFile = value
            End Set
        End Property
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property VolumeName As String()
            Get
                Return mVolumeName
            End Get
            Set(value As String())
                mVolumeName = value
            End Set
        End Property
        Property ZoneName As String
            Get
                Return mZoneName
            End Get
            Set(value As String)
                mZoneName = value
            End Set
        End Property
        Property Stat As String
            Get
                Return mStat
            End Get
            Set(value As String)
                mStat = value
            End Set
        End Property
        Property Power As COH_DayJob_Power()
            Get
                Return mPower
            End Get
            Set(value As COH_DayJob_Power())
                mPower = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mSourceFile As String
       Private mName As String
       Private mDisplayName As String
       Private mVolumeName As String()
       Private mZoneName As String
       Private mStat As String
       Private mPower As COH_DayJob_Power()
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
            mSourceFile = String.Empty
            mName = String.Empty
            mDisplayName = String.Empty
            mVolumeName = New String() {}
            mZoneName = String.Empty
            mStat = String.Empty
            mPower = New COH_DayJob_Power() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_DayJob_Detail
            Dim Result As COH_DayJob_Detail = New COH_DayJob_Detail
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mSourceFile = String.Copy(mSourceFile)
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mVolumeName = mVolumeName.CloneTheStrings
                .mZoneName = String.Copy(mZoneName)
                .mStat = String.Copy(mStat)
                .mPower = New COH_DayJob_Power(mPower.Count - 1) {}
                For X = 0 To mPower.Count - 1
                    .mPower(X) = mPower(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mSourceFile)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_StringArray(mVolumeName)
            CurrentWriter.Write_CrypticS_String(mZoneName)
            CurrentWriter.Write_CrypticS_String(mStat)
            If CurrentWriter.Write_CrypticS_StructArray(mPower) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mSourceFile = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mDisplayName = CurrentReader.Read_CrypticS_String
            mVolumeName = CurrentReader.Read_CrypticS_StringArray()
            mZoneName = CurrentReader.Read_CrypticS_String
            mStat = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_DayJob_Power), mPower) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
