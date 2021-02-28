Namespace Toolkit.Controls.WinForms.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_FormWrapped_Pigg_View
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
            Me.TreeView1 = New System.Windows.Forms.TreeView()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ListView2 = New System.Windows.Forms.ListView()
            Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.Tab_Preview = New System.Windows.Forms.TabPage()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.TabPage1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'TreeView1
            '
            Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TreeView1.HideSelection = False
            Me.TreeView1.Location = New System.Drawing.Point(3, 2)
            Me.TreeView1.Name = "TreeView1"
            Me.TreeView1.Size = New System.Drawing.Size(319, 600)
            Me.TreeView1.TabIndex = 30
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.ListView1)
            Me.TabPage1.Controls.Add(Me.ListView2)
            Me.TabPage1.Location = New System.Drawing.Point(4, 23)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(883, 573)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Table Content (Details)"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'ListView1
            '
            Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ListView1.BackColor = System.Drawing.Color.YellowGreen
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader7})
            Me.ListView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListView1.FullRowSelect = True
            Me.ListView1.GridLines = True
            Me.ListView1.HideSelection = False
            Me.ListView1.Location = New System.Drawing.Point(0, 0)
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(883, 393)
            Me.ListView1.TabIndex = 31
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Index"
            Me.ColumnHeader1.Width = 72
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Name"
            Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader2.Width = 185
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "Type"
            Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader6.Width = 101
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Offset"
            Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader3.Width = 93
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Size"
            Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader4.Width = 87
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "Is Compressed"
            Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader5.Width = 100
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "Time Stamp"
            Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader8.Width = 118
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "Slot Index"
            Me.ColumnHeader7.Width = 90
            '
            'ListView2
            '
            Me.ListView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ListView2.BackColor = System.Drawing.Color.OliveDrab
            Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
            Me.ListView2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListView2.FullRowSelect = True
            Me.ListView2.GridLines = True
            Me.ListView2.HideSelection = False
            Me.ListView2.Location = New System.Drawing.Point(0, 399)
            Me.ListView2.Name = "ListView2"
            Me.ListView2.Size = New System.Drawing.Size(883, 174)
            Me.ListView2.TabIndex = 33
            Me.ListView2.UseCompatibleStateImageBehavior = False
            Me.ListView2.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader9
            '
            Me.ColumnHeader9.Text = "Index"
            Me.ColumnHeader9.Width = 72
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "Type"
            Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader11.Width = 496
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "Offset"
            Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader12.Width = 99
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.Text = "Size"
            Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader13.Width = 92
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.Text = "Is Compressed"
            Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader14.Width = 90
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.Tab_Preview)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Location = New System.Drawing.Point(328, 2)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(891, 600)
            Me.TabControl1.TabIndex = 34
            '
            'Tab_Preview
            '
            Me.Tab_Preview.Location = New System.Drawing.Point(4, 23)
            Me.Tab_Preview.Name = "Tab_Preview"
            Me.Tab_Preview.Padding = New System.Windows.Forms.Padding(3)
            Me.Tab_Preview.Size = New System.Drawing.Size(883, 573)
            Me.Tab_Preview.TabIndex = 1
            Me.Tab_Preview.Text = "Preview"
            Me.Tab_Preview.UseVisualStyleBackColor = True
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.PropertyGrid1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 23)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Size = New System.Drawing.Size(883, 573)
            Me.TabPage2.TabIndex = 2
            Me.TabPage2.Text = "Properties"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'PropertyGrid1
            '
            Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PropertyGrid1.Location = New System.Drawing.Point(0, 0)
            Me.PropertyGrid1.Name = "PropertyGrid1"
            Me.PropertyGrid1.Size = New System.Drawing.Size(883, 573)
            Me.PropertyGrid1.TabIndex = 2
            '
            'COH_PiggView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1219, 606)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.TreeView1)
            Me.Name = "COH_PiggView"
            Me.Text = "City of Heroes Tool Kit Pigg Viewer"
            Me.TabPage1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TreeView1 As TreeView
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents ListView1 As ListView
        Friend WithEvents ColumnHeader1 As ColumnHeader
        Friend WithEvents ColumnHeader2 As ColumnHeader
        Friend WithEvents ColumnHeader6 As ColumnHeader
        Friend WithEvents ColumnHeader3 As ColumnHeader
        Friend WithEvents ColumnHeader4 As ColumnHeader
        Friend WithEvents ColumnHeader5 As ColumnHeader
        Friend WithEvents ColumnHeader8 As ColumnHeader
        Friend WithEvents ColumnHeader7 As ColumnHeader
        Friend WithEvents ListView2 As ListView
        Friend WithEvents ColumnHeader9 As ColumnHeader
        Friend WithEvents ColumnHeader11 As ColumnHeader
        Friend WithEvents ColumnHeader12 As ColumnHeader
        Friend WithEvents ColumnHeader13 As ColumnHeader
        Friend WithEvents ColumnHeader14 As ColumnHeader
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents Tab_Preview As TabPage
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents PropertyGrid1 As PropertyGrid
    End Class
End Namespace