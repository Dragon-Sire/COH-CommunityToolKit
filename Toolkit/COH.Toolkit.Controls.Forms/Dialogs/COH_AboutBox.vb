Imports COH.Toolkit.CodeManagement.Interfaces

Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class COH_AboutBox

#Region "Create New Control Instance"
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            'MyBase.New(TheContentController)
            InitializeComponent()
        End Sub
#End Region

#Region "Display"
        Public Sub DisplayDetails(Logo As Image, ChangeLogPath As String, Version As String)
            If IO.File.Exists(ChangeLogPath) = True Then
                Try
                    RichTextBox1.LoadFile(ChangeLogPath)
                Catch ex As Exception
                    RichTextBox1.Text = "Unable to Load ChangeLog"
                End Try
            End If
            RichTextBox1.ReadOnly = True
            PictureBox1.BackgroundImage = Logo
            Label2.Text = "Version : " & Version
        End Sub
#End Region



    End Class
End Namespace