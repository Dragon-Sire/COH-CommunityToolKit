Imports Microsoft.VisualBasic.ApplicationServices

Public Class COH_Tools_Application
    Inherits WindowsFormsApplicationBase
    Sub New()
        IsSingleInstance = True
        EnableVisualStyles = True
        ShutdownStyle = ShutdownMode.AfterMainFormCloses
    End Sub
    Protected Overrides Sub OnCreateMainForm()
        Initialize_Program()
        MainForm = sMainForm
    End Sub
    Private Sub App_StartupNextInstance(ByVal sender As Object, ByVal e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
        'MessageBox.Show("ONLY ONE SORRY")
    End Sub
End Class