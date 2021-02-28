Imports COH.Toolkit.CodeManagement.Interfaces

Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class Dialog_Compare2Strings

#Region "Initialize"
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
        End Sub
#End Region
        Public Sub PrepareDialog(FormTitle As String, ByRef message1 As String, ByRef message2 As String)
            Text = FormTitle
            TextBox1.Text = message1
            TextBox2.Text = message2
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Me.DialogResult = DialogResult.Yes
            Close()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Me.DialogResult = DialogResult.No
            Close()
        End Sub
    End Class
End Namespace