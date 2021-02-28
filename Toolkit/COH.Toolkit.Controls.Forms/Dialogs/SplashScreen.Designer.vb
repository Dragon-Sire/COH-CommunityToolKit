Namespace Toolkit.Controls.WinForms.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SplashScreen
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
            Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
            Me.Label_Progress = New System.Windows.Forms.Label()
            Me.VersionLabel = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'ProgressBar1
            '
            Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ProgressBar1.Location = New System.Drawing.Point(0, 331)
            Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.ProgressBar1.Name = "ProgressBar1"
            Me.ProgressBar1.Size = New System.Drawing.Size(697, 15)
            Me.ProgressBar1.TabIndex = 0
            '
            'Label_Progress
            '
            Me.Label_Progress.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label_Progress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label_Progress.ForeColor = System.Drawing.Color.White
            Me.Label_Progress.Location = New System.Drawing.Point(0, 315)
            Me.Label_Progress.Name = "Label_Progress"
            Me.Label_Progress.Size = New System.Drawing.Size(697, 16)
            Me.Label_Progress.TabIndex = 1
            Me.Label_Progress.Text = "Startup"
            Me.Label_Progress.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'VersionLabel
            '
            Me.VersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.VersionLabel.BackColor = System.Drawing.Color.Transparent
            Me.VersionLabel.ForeColor = System.Drawing.Color.White
            Me.VersionLabel.Location = New System.Drawing.Point(460, 9)
            Me.VersionLabel.Name = "VersionLabel"
            Me.VersionLabel.Size = New System.Drawing.Size(225, 16)
            Me.VersionLabel.TabIndex = 3
            Me.VersionLabel.Text = "Version : N/A"
            Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'SplashScreen
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.DarkSlateBlue
            Me.BackgroundImage = Internal.ControlResources.Toolkit
            Me.ClientSize = New System.Drawing.Size(697, 346)
            Me.Controls.Add(Me.VersionLabel)
            Me.Controls.Add(Me.Label_Progress)
            Me.Controls.Add(Me.ProgressBar1)
            Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "SplashScreen"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SplashScreen"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents ProgressBar1 As ProgressBar
        Friend WithEvents Label_Progress As Label
        Friend WithEvents VersionLabel As Label
    End Class
End Namespace