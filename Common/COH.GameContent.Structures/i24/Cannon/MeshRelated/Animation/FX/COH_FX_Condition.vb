Imports COH.GameContent.Structures.Shared

Namespace GameContent.Structures.Animation.FX
    Public NotInheritable Class COH_FX_Condition
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Condition"
            End Get
        End Property
#End Region

#Region "Properties"
        Property [On] As String
            Get
                Return mOn
            End Get
            Set(value As String)
                mOn = value
            End Set
        End Property
        Property Time As Single
            Get
                Return mTime
            End Get
            Set(value As Single)
                mTime = value
            End Set
        End Property
        Property DayStart As Single
            Get
                Return mDayStart
            End Get
            Set(value As Single)
                mDayStart = value
            End Set
        End Property
        Property DayEnd As Single
            Get
                Return mDayEnd
            End Get
            Set(value As Single)
                mDayEnd = value
            End Set
        End Property
        Property Dist As Single
            Get
                Return mDist
            End Get
            Set(value As Single)
                mDist = value
            End Set
        End Property
        Property Chance As Single
            Get
                Return mChance
            End Get
            Set(value As Single)
                mChance = value
            End Set
        End Property
        Property DoMany As Byte
            Get
                Return mDoMany
            End Get
            Set(value As Byte)
                mDoMany = value
            End Set
        End Property
        Property Repeat As Byte
            Get
                Return mRepeat
            End Get
            Set(value As Byte)
                mRepeat = value
            End Set
        End Property
        Property RepeatJitter As Byte
            Get
                Return mRepeatJitter
            End Get
            Set(value As Byte)
                mRepeatJitter = value
            End Set
        End Property
        Property TriggerBits As COH_Generic_StringTableArray
            Get
                Return mTriggerBits
            End Get
            Set(value As COH_Generic_StringTableArray)
                mTriggerBits = value
            End Set
        End Property
        Property [Event] As COH_FX_Event()
            Get
                Return mEvent
            End Get
            Set(value As COH_FX_Event())
                mEvent = value
            End Set
        End Property
        Property Random As Byte
            Get
                Return mRandom
            End Get
            Set(value As Byte)
                mRandom = value
            End Set
        End Property
        Property ForceThreshold As Single
            Get
                Return mForceThreshold
            End Get
            Set(value As Single)
                mForceThreshold = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mOn As String
       Private mTime As Single
       Private mDayStart As Single
       Private mDayEnd As Single
       Private mDist As Single
       Private mChance As Single
       Private mDoMany As Byte
       Private mRepeat As Byte
       Private mRepeatJitter As Byte
       Private mTriggerBits As COH_Generic_StringTableArray
       Private mEvent As COH_FX_Event()
       Private mRandom As Byte
       Private mForceThreshold As Single
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
            mOn = String.Empty
            mTriggerBits = New COH_Generic_StringTableArray()
            mEvent = New COH_FX_Event() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_FX_Condition
            Dim Result As COH_FX_Condition = New COH_FX_Condition
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mOn = String.Copy(mOn)
                .mTime = mTime
                .mDayStart = mDayStart
                .mDayEnd = mDayEnd
                .mDist = mDist
                .mChance = mChance
                .mDoMany = mDoMany
                .mRepeat = mRepeat
                .mRepeatJitter = mRepeatJitter
                .mTriggerBits = mTriggerBits
                .mEvent = New COH_FX_Event(mEvent.Count - 1) {}
                For X = 0 To mEvent.Count - 1
                    .mEvent(X) = mEvent(X).Clone
                Next
                .mRandom = mRandom
                .mForceThreshold = mForceThreshold
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mOn)
            CurrentWriter.Write(mTime)
            CurrentWriter.Write(mDayStart)
            CurrentWriter.Write(mDayEnd)
            CurrentWriter.Write(mDist)
            CurrentWriter.Write(mChance)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mDoMany)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mRepeat)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mRepeatJitter)
            If CurrentWriter.Write_CrypticS_Struct(mTriggerBits) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mEvent) = False Then Return False
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mRandom)
            CurrentWriter.Write(mForceThreshold)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mOn = CurrentReader.Read_CrypticS_String
            mTime = CurrentReader.ReadSingle
            mDayStart = CurrentReader.ReadSingle
            mDayEnd = CurrentReader.ReadSingle
            mDist = CurrentReader.ReadSingle
            mChance = CurrentReader.ReadSingle
            mDoMany = CurrentReader.Read_CrypticS_Byte_Aligned4
            mRepeat = CurrentReader.Read_CrypticS_Byte_Aligned4
            mRepeatJitter = CurrentReader.Read_CrypticS_Byte_Aligned4
            mTriggerBits = New COH_Generic_StringTableArray(CurrentReader)
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_FX_Event), mEvent) = False Then Return False
            mRandom = CurrentReader.Read_CrypticS_Byte_Aligned4
            mForceThreshold = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
