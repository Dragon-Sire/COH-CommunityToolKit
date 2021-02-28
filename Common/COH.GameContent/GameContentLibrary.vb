Imports COH.GameContent.Internal.Events.COH_Event_Error
Imports COH.GameContent.Internal.Events.COH_Event_ProgressUpdate

'<HideModuleName>
Public Module COH_LibraryEventController

#Region "Events"
    Public Function ShowProgressUpdate(EventType As COH_ProgressEvent, Optional UpdateAmount As Double = 0, Optional Message As String = Nothing) As Boolean
        Return COH_LibraryEventControl.Instance.ProgressUpdate(EventType, UpdateAmount, Message)
    End Function
#End Region

#Region "Events - Compare Strings"
    Public Function ShowPrompt_Override(Title As String, ByRef message1 As String, ByRef message2 As String) As Boolean
        Return COH_LibraryEventControl.Instance.Prompt_Override(Title, message1, message2)
    End Function
#End Region

#Region "Events - Message"
    Public Function ShowMessage(ByRef Message As String) As Boolean
        Return COH_LibraryEventControl.Instance.Trigger_MessageOccured(Message)
    End Function
#End Region

#Region "Events - Errors Occured"
    Public Function ShowErrorOccured(Message As String, Optional AllowContinue As Boolean = True) As Boolean
        Return COH_LibraryEventControl.Instance.Trigger_ErrorOccured(COH_ErrorEvent.ControlledError, Message, Nothing, AllowContinue)
    End Function
    Public Function ShowErrorOccured_Exception(TheEvent As COH_ErrorEvent, Message As String, ByRef ErrorException As Exception, Optional AllowContinue As Boolean = False) As Boolean
        Return COH_LibraryEventControl.Instance.Trigger_ErrorOccured(TheEvent, Message, ErrorException, AllowContinue)
    End Function
#End Region
End Module
