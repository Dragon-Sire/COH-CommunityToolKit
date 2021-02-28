Namespace GameContent.Structures.World.DayJobs
    Public NotInheritable Class COH_DayJob
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "JOB"
            End Get
        End Property
#End Region

#Region "Properties"
        Property DayJob As COH_DayJob_Detail()
            Get
                Return mDayJob
            End Get
            Set(value As COH_DayJob_Detail())
                mDayJob = value
            End Set
        End Property
        Property MinTime As Int32
            Get
                Return mMinTime
            End Get
            Set(value As Int32)
                mMinTime = value
            End Set
        End Property
        Property PatrolXPMultiplier As Single
            Get
                Return mPatrolXPMultiplier
            End Get
            Set(value As Single)
                mPatrolXPMultiplier = value
            End Set
        End Property
        Property PatrolScalar As Single
            Get
                Return mPatrolScalar
            End Get
            Set(value As Single)
                mPatrolScalar = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mDayJob As COH_DayJob_Detail()
       Private mMinTime As Int32
       Private mPatrolXPMultiplier As Single
       Private mPatrolScalar As Single
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
            mDayJob = New COH_DayJob_Detail() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_DayJob
            Dim Result As COH_DayJob = New COH_DayJob
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDayJob = New COH_DayJob_Detail(mDayJob.Count - 1) {}
                For X = 0 To mDayJob.Count - 1
                    .mDayJob(X) = mDayJob(X).Clone
                Next
                .mMinTime = mMinTime
                .mPatrolXPMultiplier = mPatrolXPMultiplier
                .mPatrolScalar = mPatrolScalar
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Write_CrypticS_StructArray(mDayJob) = False Then Return False
            CurrentWriter.Write(mMinTime)
            CurrentWriter.Write(mPatrolXPMultiplier)
            CurrentWriter.Write(mPatrolScalar)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_DayJob_Detail), mDayJob) = False Then Return False
            mMinTime = CurrentReader.ReadInt32
            mPatrolXPMultiplier = CurrentReader.ReadSingle
            mPatrolScalar = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
