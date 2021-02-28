Namespace Toolkit.Controls.WinForms.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_TextureResource_PanelItem
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                    DisposeAdditional()
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
            Me.Check_SelectThumbnail = New System.Windows.Forms.CheckBox()
            Me.Preview = New System.Windows.Forms.PictureBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            CType(Me.Preview, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Check_SelectThumbnail
            '
            Me.Check_SelectThumbnail.AutoSize = True
            Me.Check_SelectThumbnail.BackColor = System.Drawing.Color.Transparent
            Me.Check_SelectThumbnail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Check_SelectThumbnail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Check_SelectThumbnail.Location = New System.Drawing.Point(10, 10)
            Me.Check_SelectThumbnail.Name = "Check_SelectThumbnail"
            Me.Check_SelectThumbnail.Size = New System.Drawing.Size(12, 11)
            Me.Check_SelectThumbnail.TabIndex = 0
            Me.Check_SelectThumbnail.UseVisualStyleBackColor = False
            '
            'Preview
            '
            Me.Preview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Preview.Location = New System.Drawing.Point(26, 2)
            Me.Preview.Margin = New System.Windows.Forms.Padding(1)
            Me.Preview.Name = "Preview"
            Me.Preview.Size = New System.Drawing.Size(148, 112)
            Me.Preview.TabIndex = 1
            Me.Preview.TabStop = False
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button1.Location = New System.Drawing.Point(322, 89)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(115, 23)
            Me.Button1.TabIndex = 2
            Me.Button1.Text = "Save Image"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(178, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(94, 14)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Texture Name :"
            '
            'Label2
            '
            Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.Location = New System.Drawing.Point(207, 33)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(233, 37)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Location  :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(178, 93)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(92, 14)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "# Coordinates :"
            '
            'COH_TextureResource_PanelItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.DodgerBlue
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Check_SelectThumbnail)
            Me.Controls.Add(Me.Preview)
            Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "COH_TextureResource_PanelItem"
            Me.Size = New System.Drawing.Size(443, 123)
            CType(Me.Preview, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Check_SelectThumbnail As Windows.Forms.CheckBox
        Friend WithEvents Preview As Windows.Forms.PictureBox
        Friend WithEvents Button1 As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
    End Class
End Namespace
