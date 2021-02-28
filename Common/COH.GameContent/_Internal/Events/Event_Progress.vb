Namespace Internal.Events
    Public Class COH_Event_ProgressUpdate
        Inherits EventArgs

#Region "Enums"
        Public Enum COH_ProgressEvent
            None = 0
            Begin = 1
            Update = 2
            Finish = 3
        End Enum
#End Region

#Region "Properties"
        Public ReadOnly Property ProgressEvent As COH_ProgressEvent
            Get
                Return mTheEvent
            End Get
        End Property
        Public ReadOnly Property Message As String
            Get
                Return mMessage
            End Get
        End Property
        Public ReadOnly Property Value As Double
            Get
                Return mValue
            End Get
        End Property
        Public Property Cancel As Boolean
            Get
                Return mCancel
            End Get
            Set(value As Boolean)
                mCancel = value
            End Set
        End Property
#End Region

#Region "Private Usage"
       Private mCancel As Boolean
       Private mMessage As String
       Private mValue As String
       Private mTheEvent As COH_ProgressEvent
#End Region

#Region "Initialize"
        Public Sub New()
            mMessage = ""
            mValue = ""
            mCancel = False
            mTheEvent = COH_ProgressEvent.None
        End Sub
        Public Sub New(TheEvent As COH_ProgressEvent, Message As String, UpdateAmount As Double)
            mMessage = Message
            mValue = UpdateAmount
            mCancel = False
            mTheEvent = TheEvent
        End Sub
#End Region
    End Class
End Namespace
