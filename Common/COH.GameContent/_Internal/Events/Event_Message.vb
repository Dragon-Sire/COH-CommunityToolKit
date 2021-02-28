Namespace Internal.Events
    Public Class COH_Event_Message
        Inherits EventArgs

#Region "Properties"
        Public ReadOnly Property Message As String
            Get
                Return mMessage
            End Get
        End Property
        Public ReadOnly Property IsLargeMessage As String
            Get
                If String.IsNullOrEmpty(mMessage) = True Then Return False
                Return mMessage.Length > 100
            End Get
        End Property
        Public ReadOnly Property IsXML As Boolean
            Get
                If String.IsNullOrEmpty(mMessage) = True Then Return False
                Return mMessage.Contains("<XML")
            End Get
        End Property
#End Region

#Region "Private Usage"
       Private mMessage As String
#End Region

#Region "Initialize"
        Public Sub New()
            mMessage = ""
        End Sub
        Public Sub New(Message As String)
            mMessage = Message
        End Sub
#End Region
    End Class
End Namespace
