Imports COH.GameContent.Internal.Events.COH_Event_Error
Imports COH.GameContent.Internal.Events.COH_Event_ProgressUpdate
Imports COH.Storage.Serialization

Namespace Internal.Events
    Public NotInheritable Class COH_LibraryEventControl

#Region "Properties"
        Shared ReadOnly Property Instance As COH_LibraryEventControl
            Get
                Return sInstance
            End Get
        End Property
        Private Shared sInstance As COH_LibraryEventControl
#End Region

#Region "Initialized"
        Public Sub New()
        End Sub
        Shared Sub New()
            If sInstance Is Nothing Then sInstance = New COH_LibraryEventControl
        End Sub
#End Region

#Region "Events"
        Public Event ProgressEvent(ByRef e As GameContent.Internal.Events.COH_Event_ProgressUpdate)
        Public Function ProgressUpdate(EventType As COH_ProgressEvent, Optional UpdateAmount As Double = 0, Optional Message As String = Nothing) As Boolean
            Dim NewEvent As New GameContent.Internal.Events.COH_Event_ProgressUpdate(EventType, Message, UpdateAmount)
            RaiseEvent ProgressEvent(NewEvent)
            Return (NewEvent.Cancel = False)
        End Function
#End Region

#Region "Events - Compare Strings"
        Public Event Prompt_Compare2Items(ByRef e As Internal.Events.COH_EventResponse_Compare2Items)
        Public Function Prompt_Override(Title As String, ByRef message1 As String, ByRef message2 As String) As Boolean
            Dim NewEvent As Internal.Events.COH_EventResponse_Compare2Items = New Internal.Events.COH_EventResponse_Compare2Items(Title, message1, message2, Internal.Events.COH_EventResponse_Compare2Items.COH_ResponseEnum.Yes)
            RaiseEvent Prompt_Compare2Items(NewEvent)
            Return (NewEvent.Result = Internal.Events.COH_EventResponse_Compare2Items.COH_ResponseEnum.Yes)
        End Function
#End Region

#Region "Events - Messages"
        Public Event MessageEvent(ByRef e As COH_Event_Message)
        Public Function Trigger_MessageOccured(ByRef Message As String) As Boolean
            Dim NewEvent As New COH_Event_Message(Message)
            RaiseEvent MessageEvent(NewEvent)
            Return True
        End Function
#End Region

#Region "Events - Errors"
        Public Event ErrorOccuredEvent(ByRef e As COH_Event_Error)
        Public Function Trigger_ErrorOccured(TheEvent As COH_ErrorEvent, Message As String, ByRef ErrorException As Exception, Optional AllowContinue As Boolean = False) As Boolean
            Dim NewEvent As New COH_Event_Error(TheEvent, Message, ErrorException, AllowContinue)
            RaiseEvent ErrorOccuredEvent(NewEvent)
            If NewEvent.ThrowException = True Then
                Throw NewEvent.MessageException
            Else
                If NewEvent.AllowContinue = False Then Environment.Exit(0)
            End If
            Return True
        End Function
#End Region

#Region "Developer"
        'Public Event TriggerInspectStream(ByRef e As COH_EventResponse_StreamInspect)
        'Public Function Trigger_InspectStream(Title As String, ByRef CurrentReader As COH_BinaryReader) As Boolean
        ' Dim NewEvent As New COH_EventResponse_StreamInspect(Title, CurrentReader)
        ' RaiseEvent TriggerInspectStream(NewEvent)
        '     CurrentReader.Position = NewEvent.StartPosition
        ' Return True
        ' End Function
#End Region

    End Class
End Namespace