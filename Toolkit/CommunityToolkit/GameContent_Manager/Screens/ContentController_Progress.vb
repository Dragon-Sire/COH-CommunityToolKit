Imports COH.GameContent.Internal.Events.COH_Event_ProgressUpdate
Imports COH.Toolkit.Controls.WinForms.Dialogs

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Private Properties"
       Private mCurrentProgressForm As COH_ExtractionProgress
#End Region

#Region "Create Form"
        Public Sub OnProgressUpdate(ByRef e As GameContent.Internal.Events.COH_Event_ProgressUpdate) Handles mEventController.ProgressEvent
            Select Case e.ProgressEvent
                Case COH_ProgressEvent.Begin
                    ProgressDisplay_Create(e.Message, 0, e.Value, 0)
                Case COH_ProgressEvent.Finish
                    ProgressDisplay_Destroy()
                Case COH_ProgressEvent.Update
                    If String.IsNullOrEmpty(e.Message) = True Then
                        ProgressDisplay_Update(e.Value)
                    Else
                        ProgressDisplay_Update(e.Message, e.Value)
                    End If
            End Select
        End Sub

        Private Sub ProgressDisplay_Create(Title As String, Min As Integer, Max As Integer, Current As Integer)
            mCurrentProgressForm = New COH_ExtractionProgress
            mCurrentProgressForm.PrepareUsage(Title, Min, Max, Current)
            mCurrentProgressForm.Show()
            mCurrentProgressForm.Enabled = False
            mCurrentProgressForm.TopMost = True
        End Sub
        Private Sub ProgressDisplay_Destroy()
            If mCurrentProgressForm Is Nothing Then Exit Sub
            mCurrentProgressForm.Close()
            mCurrentProgressForm.Dispose()
        End Sub
        Private Sub ProgressDisplay_Update(Name As String, Progress As Integer)
            If mCurrentProgressForm Is Nothing Then Exit Sub
            mCurrentProgressForm.UpdateProgress(Name, Progress)
        End Sub
        Private Sub ProgressDisplay_UpdateValue(Name As String, Progress As Integer)
            If mCurrentProgressForm Is Nothing Then Exit Sub
            mCurrentProgressForm.UpdateProgress_Value(Name, Progress)
        End Sub
        Private Sub ProgressDisplay_Update(Progress As Integer)
            If mCurrentProgressForm Is Nothing Then Exit Sub
            mCurrentProgressForm.UpdateProgress(Progress)
        End Sub
#End Region

    End Class
End Namespace