Namespace Toolkit.Controls.WinForms.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_CRC_Tool
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COH_CRC_Tool))
            Me.Button1 = New System.Windows.Forms.Button()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.TextBox4 = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(447, 4)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(93, 22)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Process"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(108, 6)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(333, 92)
            Me.TextBox1.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(21, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(81, 14)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Inout String :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(5, 107)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(97, 14)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "CRC-32 PString :"
            '
            'TextBox2
            '
            Me.TextBox2.Location = New System.Drawing.Point(108, 104)
            Me.TextBox2.Multiline = True
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.ReadOnly = True
            Me.TextBox2.Size = New System.Drawing.Size(333, 20)
            Me.TextBox2.TabIndex = 3
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(42, 158)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(60, 14)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "CRC-32c :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(2, 133)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(100, 14)
            Me.Label4.TabIndex = 7
            Me.Label4.Text = "CRC-32 Quoted :"
            '
            'TextBox3
            '
            Me.TextBox3.Location = New System.Drawing.Point(108, 130)
            Me.TextBox3.Multiline = True
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.ReadOnly = True
            Me.TextBox3.Size = New System.Drawing.Size(333, 20)
            Me.TextBox3.TabIndex = 6
            '
            'TextBox4
            '
            Me.TextBox4.Location = New System.Drawing.Point(108, 156)
            Me.TextBox4.Multiline = True
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.ReadOnly = True
            Me.TextBox4.Size = New System.Drawing.Size(333, 20)
            Me.TextBox4.TabIndex = 8
            '
            'COH_CRC_Tool
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(567, 198)
            Me.Controls.Add(Me.TextBox4)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.TextBox3)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TextBox2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "COH_CRC_Tool"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "City of Heroes Community Toolkit - CRC Tool"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Button1 As Button
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents TextBox2 As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents TextBox3 As TextBox
        Friend WithEvents TextBox4 As TextBox
    End Class
End Namespace