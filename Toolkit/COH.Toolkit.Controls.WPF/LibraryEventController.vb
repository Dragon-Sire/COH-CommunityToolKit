Imports COH.GameContent.Internal.Events
Imports COH.GameContent.Internal.Events.COH_Event_Error
Imports COH.GameContent.Internal.Events.COH_Event_ProgressUpdate

Public NotInheritable Class WPFLibraryEventControl

#Region "Properties"
    Shared ReadOnly Property Instance As COH_LibraryEventControl
        Get
            Return COH_LibraryEventControl.Instance
        End Get
    End Property
#End Region

#Region "Initialized"
    Public Sub New()
    End Sub
    Shared Sub New()
    End Sub
#End Region

#Region "Events"
    Public Shared Function ProgressUpdate(EventType As COH_ProgressEvent, Optional UpdateAmount As Double = 0, Optional Message As String = Nothing) As Boolean
        Return Instance.ProgressUpdate(EventType, UpdateAmount, Message)
    End Function
#End Region

#Region "Events - Compare Strings"
    Public Shared Function Prompt_Override(Title As String, ByRef message1 As String, ByRef message2 As String) As Boolean
        Return Instance.Prompt_Override(Title, message1, message2)
    End Function
#End Region

#Region "Events - Errors Occured"
    Public Shared Function ErrorOccured_Exception(TheEvent As COH_ErrorEvent, Message As String, ByRef ErrorException As Exception, Optional AllowContinue As Boolean = False) As Boolean
        Return Instance.Trigger_ErrorOccured(TheEvent, Message, ErrorException, AllowContinue)
    End Function
#End Region
End Class
