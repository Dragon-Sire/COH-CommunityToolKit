Imports COH.Toolkit.Controls.WinForms.Dialogs

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Private Properties"
       Private mSplashForm As SplashScreen
#End Region

#Region "Create Form"
        Private Sub SplashScreen_Create()
            mSplashForm = New SplashScreen
            '//mSplashForm.PrepareUsage(My.Application.Info.Version.ToString, 100)
            mSplashForm.Show()
        End Sub
        Private Sub SplashScreen_Update(Name As String, UpdateAmount As Integer, Optional UseWait As Boolean = False)
            If mSplashForm Is Nothing Then Exit Sub
            mSplashForm.UpdateProgress(Name, UpdateAmount)
            If UseWait = True Then Threading.Thread.Sleep(200)
        End Sub
        Private Sub SplashScreen_Destroy()
            mSplashForm.Close()
            mSplashForm.Dispose()
        End Sub
#End Region

    End Class
End Namespace