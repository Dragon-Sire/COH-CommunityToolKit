Namespace Toolkit.Controls.WinForms.Settings
    Public Class COH_ColorScheme


#Region "Properties"

#End Region

#Region "Usage"
        Public Sub ApplyColorScheme(Source As Form)
            ApplyColorScheme_ToControl(Source)
        End Sub
        Public Sub ApplyColorScheme(Source As Control)
            ApplyColorScheme_ToControl(Source)
        End Sub
#End Region

#Region "Set Appearance - Controls"
        Private Sub ApplyColorScheme_ToControl(Source As Control)
            For Each SelectedControl In Source.Controls
                If TypeOf SelectedControl Is TabControl Then
                    ApplyColorScheme_TabControl(SelectedControl)
                ElseIf TypeOf SelectedControl Is DataGridView Then
                    ApplyColorScheme_DataGridView(SelectedControl)
                ElseIf TypeOf SelectedControl Is SplitContainer Then
                    ApplyColorScheme_SplitView(SelectedControl)
                End If
            Next
        End Sub
        Private Sub ApplyColorScheme_SplitView(ByRef SourceControl As SplitContainer)
            With SourceControl
                .BackColor = Color.DarkGray
                .Panel1.BackColor = Color.DarkGray
                .Panel2.BackColor = Color.DarkGray
                ApplyColorScheme_ToControl(SourceControl.Panel1)
                ApplyColorScheme_ToControl(SourceControl.Panel2)
            End With
        End Sub
        Private Sub ApplyColorScheme_TabControl(ByRef SourceControl As TabControl)
            With SourceControl
                For Each Page As TabPage In SourceControl.TabPages
                    Page.BackColor = Color.CornflowerBlue
                    ApplyColorScheme_ToControl(Page)
                Next
            End With
        End Sub
        Private Sub ApplyColorScheme_DataGridView(ByRef SourceControl As DataGridView)
            With SourceControl
                .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
                .DefaultCellStyle.BackColor = Color.White
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        End Sub
#End Region

    End Class
End Namespace