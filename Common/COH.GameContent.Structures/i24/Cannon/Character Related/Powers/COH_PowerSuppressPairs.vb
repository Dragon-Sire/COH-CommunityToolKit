Namespace GameContent.Structures.Powers
    Public Class COH_SuppressPairs
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Suppress Pairs"
            End Get
        End Property
#End Region

#Region "Properties"
        Property PowerEvent As COH_Enum_PowerEvent
            Get
                Return mEvent
            End Get
            Set(value As COH_Enum_PowerEvent)
                mEvent = value
            End Set
        End Property
        Property Seconds As Int32
            Get
                Return mSeconds
            End Get
            Set(value As Int32)
                mSeconds = value
            End Set
        End Property
        ReadOnly Property Always_Enum As COH_Enum_SupressAlways
            Get
                If mAlways = True Then
                    Return COH_Enum_SupressAlways.Always
                Else
                    Return COH_Enum_SupressAlways.WhenInactive
                End If
            End Get
        End Property
        Property Always As Boolean
            Get
                Return mAlways
            End Get
            Set(value As Boolean)
                mAlways = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mEvent As COH_Enum_PowerEvent
       Private mSeconds As Int32
       Private mAlways As Boolean
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mEvent = COH_Enum_PowerEvent.kPowerEvent_Activate
            mSeconds = 0
            mAlways = False
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_SuppressPairs
            Dim Result As COH_SuppressPairs = New COH_SuppressPairs
            With Result
                .mEvent = mEvent
                .mSeconds = mSeconds
                .mAlways = mAlways
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(CInt(PowerEvent)) '12
            CurrentWriter.Write(CInt(Seconds)) '21
            CurrentWriter.Write_CrypticS_Boolean(Always) '15
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            PowerEvent = CurrentReader.ReadInt32
            Seconds = CurrentReader.ReadInt32
            Always = CurrentReader.ReadInt32
            Return True
        End Function
#End Region
    End Class
End Namespace