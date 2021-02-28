Imports COH.Toolkit.Controls.WinForms.UserControls
Namespace Toolkit.Controls.WinForms.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_ResourceView_Texture
        Inherits COH_UserControl_Template

        'UserControl overrides dispose to clean up the component list.
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
            Me.PreviewBox = New System.Windows.Forms.PictureBox()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.PreviewBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1276, 697)
            Me.TabControl1.TabIndex = 34
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.PreviewBox)
            Me.TabPage1.Location = New System.Drawing.Point(4, 23)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1268, 670)
            Me.TabPage1.TabIndex = 6
            Me.TabPage1.Text = "Preview"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'PreviewBox
            '
            Me.PreviewBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PreviewBox.Location = New System.Drawing.Point(3, 3)
            Me.PreviewBox.Name = "PreviewBox"
            Me.PreviewBox.Size = New System.Drawing.Size(1262, 664)
            Me.PreviewBox.TabIndex = 0
            Me.PreviewBox.TabStop = False
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.PropertyGrid1)
            Me.TabPage3.Location = New System.Drawing.Point(4, 23)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(1268, 670)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Properties"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'PropertyGrid1
            '
            Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PropertyGrid1.Location = New System.Drawing.Point(3, 3)
            Me.PropertyGrid1.Name = "PropertyGrid1"
            Me.PropertyGrid1.Size = New System.Drawing.Size(1262, 664)
            Me.PropertyGrid1.TabIndex = 1
            '
            'COH_ResourceView_Texture
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.CornflowerBlue
            Me.Controls.Add(Me.TabControl1)
            Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "COH_ResourceView_Texture"
            Me.Size = New System.Drawing.Size(1276, 697)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            CType(Me.PreviewBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents PropertyGrid1 As PropertyGrid
        Friend WithEvents PreviewBox As PictureBox
    End Class
End Namespace