Namespace GameContent.Structures.Bases
    Public NotInheritable Class COH_Base_Upkeep
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return filename
            End Get
        End Property
#End Region

#Region "Properties"
        Property filename As String
            Get
                Return mfilename
            End Get
            Set(value As String)
                mfilename = value
            End Set
        End Property
        Property RentPeriodSeconds As Int32
            Get
                Return mRentPeriodSeconds
            End Get
            Set(value As Int32)
                mRentPeriodSeconds = value
            End Set
        End Property
        Property RentRange As COH_Base_UpkeepRange()
            Get
                Return mRentRange
            End Get
            Set(value As COH_Base_UpkeepRange())
                mRentRange = value
            End Set
        End Property
        Property RentDueDateResetPeriod As Int32
            Get
                Return mRentDueDateResetPeriod
            End Get
            Set(value As Int32)
                mRentDueDateResetPeriod = value
            End Set
        End Property
        Property LatePeriod As COH_Base_UpkeepPeriod()
            Get
                Return mLatePeriod
            End Get
            Set(value As COH_Base_UpkeepPeriod())
                mLatePeriod = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mfilename As String
       Private mRentPeriodSeconds As Int32
       Private mRentRange As COH_Base_UpkeepRange()
       Private mRentDueDateResetPeriod As Int32
       Private mLatePeriod As COH_Base_UpkeepPeriod()
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
            mfilename = String.Empty
            mRentRange = New COH_Base_UpkeepRange() {}
            mLatePeriod = New COH_Base_UpkeepPeriod() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Base_Upkeep
            Dim Result As COH_Base_Upkeep = New COH_Base_Upkeep
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mfilename = String.Copy(mfilename)
                .mRentPeriodSeconds = mRentPeriodSeconds
                .mRentRange = New COH_Base_UpkeepRange(mRentRange.Count - 1) {}
                For X = 0 To mRentRange.Count - 1
                    .mRentRange(X) = mRentRange(X).Clone
                Next
                .mRentDueDateResetPeriod = mRentDueDateResetPeriod
                .mLatePeriod = New COH_Base_UpkeepPeriod(mLatePeriod.Count - 1) {}
                For X = 0 To mLatePeriod.Count - 1
                    .mLatePeriod(X) = mLatePeriod(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mfilename)
            CurrentWriter.Write(mRentPeriodSeconds)
            If CurrentWriter.Write_CrypticS_StructArray(mRentRange) = False Then Return False
            CurrentWriter.Write(mRentDueDateResetPeriod)
            If CurrentWriter.Write_CrypticS_StructArray(mLatePeriod) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mfilename = CurrentReader.Read_CrypticS_String
            mRentPeriodSeconds = CurrentReader.ReadInt32
            'COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Base_UpkeepRange), mRentRange) = False Then Return False
            mRentDueDateResetPeriod = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Base_UpkeepPeriod), mLatePeriod) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
