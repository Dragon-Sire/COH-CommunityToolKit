Imports COH.GameContent.Internal.Events
Imports COH.Toolkit.CodeManagement.Interfaces

Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class COH_ErrorDialog


#Region "Private Properties"
        Private mTheError As COH_Event_Error
#End Region

#Region "Initialize"
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
        End Sub
#End Region

#Region "Configure UI"
        Public Overrides Sub ConfigureUI()
            MyBase.ConfigureUI()
            Changes_Locked = True
            Changes_Locked = False
        End Sub
#End Region

#Region "Usage"
        Public Sub LoadError(ByRef TheError As COH_Event_Error)
            mTheError = TheError
            Text = "City of Heroes Community Toolkit (Alpha)"
            If TheError.MessageException Is Nothing Then
                TextBox1.Text = TheError.Message
                TextBox2.Text = ""
            Else
                TextBox1.Text = TheError.Message & Environment.NewLine & TheError.MessageException.Message.ToString
                If TheError.MessageException.InnerException Is Nothing Then
                    TextBox2.Text = ""
                Else
                    TextBox2.Text = TheError.MessageException.InnerException.ToString
                End If
                If TheError.MessageException.StackTrace Is Nothing Then
                    TextBox3.Text = ""
                Else
                    TextBox3.Text = TheError.MessageException.StackTrace.ToString
                End If
            End If
            If TheError.AllowContinue = False Then Me.Button1.Enabled = False
        End Sub
        Public Shared Function ShowErrorMessage(ByRef TheError As COH_Event_Error) As DialogResult
            Dim NewDialog As New COH_ErrorDialog(Nothing)
            NewDialog.LoadError(TheError)
            Return NewDialog.ShowDialog
        End Function

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            DialogResult = DialogResult.Yes
            Close()
        End Sub
        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            DialogResult = DialogResult.No
            Close()
            Environment.Exit(0)
        End Sub
#End Region
    End Class
End Namespace