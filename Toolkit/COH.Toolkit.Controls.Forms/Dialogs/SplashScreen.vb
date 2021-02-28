Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class SplashScreen

#Region "Prepare USage"
        Public Sub PrepareUsage(Version As String, Max As Integer)
            VersionLabel.Text = "Version : " & Version
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = Max
            ProgressBar1.Value = 0
        End Sub
        Public Sub UpdateProgress(Name As String, IncrementAmount As Integer)
            Label_Progress.Text = Name
            ProgressBar1.Increment(IncrementAmount)
            Application.DoEvents()
        End Sub
#End Region


    End Class
End Namespace