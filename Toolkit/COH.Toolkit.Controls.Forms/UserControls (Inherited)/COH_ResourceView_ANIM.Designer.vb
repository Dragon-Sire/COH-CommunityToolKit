Namespace Toolkit.Controls.WinForms.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_ResourceView_ANIM
        Inherits System.Windows.Forms.UserControl

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
            Me.XML_View = New COH.Toolkit.Controls.WinForms.UserControls.COH_XML_Viewer()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.CoH_XML_Viewer1 = New COH.Toolkit.Controls.WinForms.UserControls.COH_XML_Viewer()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1094, 647)
            Me.TabControl1.TabIndex = 34
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.XML_View)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1086, 621)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "XML"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'XML_View
            '
            Me.XML_View.Dock = System.Windows.Forms.DockStyle.Fill
            Me.XML_View.Location = New System.Drawing.Point(3, 3)
            Me.XML_View.Name = "XML_View"
            Me.XML_View.Size = New System.Drawing.Size(1080, 615)
            Me.XML_View.TabIndex = 0
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.PropertyGrid1)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(1086, 621)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Properties"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'PropertyGrid1
            '
            Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PropertyGrid1.Location = New System.Drawing.Point(3, 3)
            Me.PropertyGrid1.Name = "PropertyGrid1"
            Me.PropertyGrid1.Size = New System.Drawing.Size(1080, 615)
            Me.PropertyGrid1.TabIndex = 1
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.CoH_XML_Viewer1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(1086, 621)
            Me.TabPage2.TabIndex = 3
            Me.TabPage2.Text = "Extracted Skeleton"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'CoH_XML_Viewer1
            '
            Me.CoH_XML_Viewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CoH_XML_Viewer1.Location = New System.Drawing.Point(3, 3)
            Me.CoH_XML_Viewer1.Name = "CoH_XML_Viewer1"
            Me.CoH_XML_Viewer1.Size = New System.Drawing.Size(1080, 615)
            Me.CoH_XML_Viewer1.TabIndex = 1
            '
            'COH_ResourceView_ANIM
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.CornflowerBlue
            Me.Controls.Add(Me.TabControl1)
            Me.Name = "COH_ResourceView_ANIM"
            Me.Size = New System.Drawing.Size(1094, 647)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents XML_View As COH_XML_Viewer
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents PropertyGrid1 As PropertyGrid
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents CoH_XML_Viewer1 As COH_XML_Viewer
    End Class
End Namespace