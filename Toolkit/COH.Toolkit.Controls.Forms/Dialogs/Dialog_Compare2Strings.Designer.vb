
Namespace Toolkit.Controls.WinForms.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Dialog_Compare2Strings
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 19)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(89, 14)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Originol Value :"
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(15, 46)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(491, 204)
            Me.TextBox1.TabIndex = 1
            '
            'TextBox2
            '
            Me.TextBox2.Location = New System.Drawing.Point(512, 46)
            Me.TextBox2.Multiline = True
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(491, 204)
            Me.TextBox2.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(509, 19)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(74, 14)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "New Value :"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(876, 256)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(127, 31)
            Me.Button1.TabIndex = 4
            Me.Button1.Text = "Yes"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(745, 256)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(125, 31)
            Me.Button2.TabIndex = 5
            Me.Button2.Text = "No"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Dialog_Compare2Strings
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1020, 297)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.TextBox2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Dialog_Compare2Strings"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "DialogBox: Compare 2 Items"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents TextBox2 As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Button1 As Button
        Friend WithEvents Button2 As Button
    End Class
End Namespace