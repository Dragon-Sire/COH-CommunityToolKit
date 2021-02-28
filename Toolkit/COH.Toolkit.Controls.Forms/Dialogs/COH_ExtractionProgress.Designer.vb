Namespace Toolkit.Controls.WinForms.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_ExtractionProgress
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.Label_Progress = New System.Windows.Forms.Label()
            Me.CoH_ProgressBar1 = New WinForms.UserControls.COH_ProgressBar()
            Me.SuspendLayout()
            '
            'Label_Progress
            '
            Me.Label_Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label_Progress.Location = New System.Drawing.Point(14, 10)
            Me.Label_Progress.Name = "Label_Progress"
            Me.Label_Progress.Size = New System.Drawing.Size(567, 14)
            Me.Label_Progress.TabIndex = 1
            Me.Label_Progress.Text = "N/A"
            Me.Label_Progress.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'CoH_ProgressBar1
            '
            Me.CoH_ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CoH_ProgressBar1.Location = New System.Drawing.Point(3, 27)
            Me.CoH_ProgressBar1.Maximum = CType(100UL, ULong)
            Me.CoH_ProgressBar1.Minimum = CType(0UL, ULong)
            Me.CoH_ProgressBar1.Name = "CoH_ProgressBar1"
            Me.CoH_ProgressBar1.ProgressBarColor = System.Drawing.Color.Blue
            Me.CoH_ProgressBar1.Size = New System.Drawing.Size(578, 31)
            Me.CoH_ProgressBar1.Step = CType(0UL, ULong)
            Me.CoH_ProgressBar1.TabIndex = 2
            Me.CoH_ProgressBar1.Value = CType(50UL, ULong)
            '
            'COH_ExtractionProgress
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(585, 62)
            Me.Controls.Add(Me.CoH_ProgressBar1)
            Me.Controls.Add(Me.Label_Progress)
            Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "COH_ExtractionProgress"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Extraction in Progress"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label_Progress As Label
        Friend WithEvents CoH_ProgressBar1 As WinForms.UserControls.COH_ProgressBar
    End Class
End Namespace
