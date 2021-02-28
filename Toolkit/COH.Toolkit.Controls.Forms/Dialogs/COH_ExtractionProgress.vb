Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class COH_ExtractionProgress
#Region "Prepare USage"
        Public Sub PrepareUsage(Title As String, Min As Integer, Max As Integer, Current As Integer)
            Text = Title
            Label_Progress.Text = Title
            CoH_ProgressBar1.Minimum = Min
            CoH_ProgressBar1.Maximum = Max
            CoH_ProgressBar1.Value = Current
            CoH_ProgressBar1.Step = 1 ' Math.Truncate((Max - Min) * 0.05)
        End Sub
        Public Sub UpdateProgress(Name As String, Progress As Integer)
            Label_Progress.Text = Name
            CoH_ProgressBar1.Increment(Progress)
            Application.DoEvents()
        End Sub
        Public Sub UpdateProgress_Value(Name As String, Progress As Integer)
            Label_Progress.Text = Name
            CoH_ProgressBar1.Value = Progress
            Application.DoEvents()
        End Sub
        Public Sub UpdateProgress(Progress As Integer)
            CoH_ProgressBar1.Increment(Progress)
            Application.DoEvents()
        End Sub
#End Region
    End Class
End Namespace