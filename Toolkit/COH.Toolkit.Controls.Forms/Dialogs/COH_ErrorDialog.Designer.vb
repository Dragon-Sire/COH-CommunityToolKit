Namespace Toolkit.Controls.WinForms.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_ErrorDialog
        Inherits Internal.COH_FormTemplate

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
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Location = New System.Drawing.Point(3, 2)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(591, 259)
            Me.TabControl1.TabIndex = 0
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.TextBox1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 23)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(583, 232)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Error"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'TextBox1
            '
            Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBox1.Location = New System.Drawing.Point(3, 3)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(577, 226)
            Me.TextBox1.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.TextBox2)
            Me.TabPage2.Location = New System.Drawing.Point(4, 23)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(583, 232)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Inner Exeption"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'TextBox2
            '
            Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBox2.Location = New System.Drawing.Point(3, 3)
            Me.TextBox2.Multiline = True
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(577, 226)
            Me.TextBox2.TabIndex = 1
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.TextBox3)
            Me.TabPage3.Location = New System.Drawing.Point(4, 23)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(583, 232)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Stack"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'TextBox3
            '
            Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBox3.Location = New System.Drawing.Point(3, 3)
            Me.TextBox3.Multiline = True
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TextBox3.Size = New System.Drawing.Size(577, 226)
            Me.TextBox3.TabIndex = 2
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button1.Location = New System.Drawing.Point(384, 267)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(107, 37)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "Continue"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button2.Location = New System.Drawing.Point(497, 267)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(93, 37)
            Me.Button2.TabIndex = 2
            Me.Button2.Text = "Exit"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'COH_ErrorDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.OrangeRed
            Me.ClientSize = New System.Drawing.Size(595, 306)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.TabControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "COH_ErrorDialog"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "COH_ErrorDialog"
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents Button1 As Button
        Friend WithEvents Button2 As Button
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents TextBox2 As TextBox
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents TextBox3 As TextBox
    End Class
End Namespace