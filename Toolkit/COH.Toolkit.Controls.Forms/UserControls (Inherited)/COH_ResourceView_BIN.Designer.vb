Namespace Toolkit.Controls.WinForms.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_Control_ViewBin
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
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TreeView1 = New System.Windows.Forms.TreeView()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.CheckBox4 = New System.Windows.Forms.CheckBox()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage6 = New System.Windows.Forms.TabPage()
            Me.XML_View2 = New COH.Toolkit.Controls.WinForms.UserControls.COH_XML_Viewer()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.CoH_BytesViewer1 = New COH.Toolkit.Controls.WinForms.UserControls.COH_BytesViewer()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.TabPage5 = New System.Windows.Forms.TabPage()
            Me.ListView2 = New System.Windows.Forms.ListView()
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.CheckBox3 = New System.Windows.Forms.CheckBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportDEFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportRAWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportAll_XML_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportAll_DEF_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportAll_RAW_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.CheckBox2 = New System.Windows.Forms.CheckBox()
            Me.CheckBox1 = New System.Windows.Forms.CheckBox()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage6.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.TabPage4.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabPage5.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ListView1
            '
            Me.ListView1.BackColor = System.Drawing.Color.YellowGreen
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader3, Me.ColumnHeader4})
            Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ListView1.FullRowSelect = True
            Me.ListView1.GridLines = True
            Me.ListView1.HideSelection = False
            Me.ListView1.Location = New System.Drawing.Point(3, 3)
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(713, 565)
            Me.ListView1.TabIndex = 31
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Index"
            Me.ColumnHeader1.Width = 84
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Name"
            Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader2.Width = 225
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "XML"
            Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader5.Width = 177
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Offset"
            Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader3.Width = 94
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Size"
            Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader4.Width = 87
            '
            'TreeView1
            '
            Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TreeView1.HideSelection = False
            Me.TreeView1.Location = New System.Drawing.Point(0, 0)
            Me.TreeView1.Name = "TreeView1"
            Me.TreeView1.Size = New System.Drawing.Size(363, 647)
            Me.TreeView1.TabIndex = 30
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer1.Name = "SplitContainer1"
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.CheckBox4)
            Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
            Me.SplitContainer1.Panel2.Controls.Add(Me.CheckBox3)
            Me.SplitContainer1.Panel2.Controls.Add(Me.MenuStrip1)
            Me.SplitContainer1.Panel2.Controls.Add(Me.CheckBox2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.CheckBox1)
            Me.SplitContainer1.Size = New System.Drawing.Size(1094, 647)
            Me.SplitContainer1.SplitterDistance = 363
            Me.SplitContainer1.TabIndex = 33
            '
            'CheckBox4
            '
            Me.CheckBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CheckBox4.AutoSize = True
            Me.CheckBox4.Checked = True
            Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox4.Location = New System.Drawing.Point(567, 27)
            Me.CheckBox4.Name = "CheckBox4"
            Me.CheckBox4.Size = New System.Drawing.Size(149, 17)
            Me.CheckBox4.TabIndex = 5
            Me.CheckBox4.Text = "Dont Show Debug Values"
            Me.CheckBox4.UseVisualStyleBackColor = True
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.TabPage6)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Controls.Add(Me.TabPage4)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage5)
            Me.TabControl1.Location = New System.Drawing.Point(0, 50)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(727, 597)
            Me.TabControl1.TabIndex = 33
            '
            'TabPage6
            '
            Me.TabPage6.BackColor = System.Drawing.Color.DodgerBlue
            Me.TabPage6.Controls.Add(Me.XML_View2)
            Me.TabPage6.Location = New System.Drawing.Point(4, 22)
            Me.TabPage6.Name = "TabPage6"
            Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage6.Size = New System.Drawing.Size(719, 571)
            Me.TabPage6.TabIndex = 5
            Me.TabPage6.Text = "XML (Custom)"
            '
            'XML_View2
            '
            Me.XML_View2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.XML_View2.Location = New System.Drawing.Point(3, 3)
            Me.XML_View2.Name = "XML_View2"
            Me.XML_View2.Size = New System.Drawing.Size(713, 565)
            Me.XML_View2.TabIndex = 1
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.TextBox1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(719, 571)
            Me.TabPage1.TabIndex = 6
            Me.TabPage1.Text = "DEF (Custom)"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'TextBox1
            '
            Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(3, 3)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TextBox1.Size = New System.Drawing.Size(713, 565)
            Me.TextBox1.TabIndex = 7
            Me.TextBox1.WordWrap = False
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.PropertyGrid1)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(719, 571)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Properties"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'PropertyGrid1
            '
            Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PropertyGrid1.Location = New System.Drawing.Point(3, 3)
            Me.PropertyGrid1.Name = "PropertyGrid1"
            Me.PropertyGrid1.Size = New System.Drawing.Size(713, 565)
            Me.PropertyGrid1.TabIndex = 1
            '
            'TabPage4
            '
            Me.TabPage4.Controls.Add(Me.CoH_BytesViewer1)
            Me.TabPage4.Location = New System.Drawing.Point(4, 22)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage4.Size = New System.Drawing.Size(719, 571)
            Me.TabPage4.TabIndex = 3
            Me.TabPage4.Text = "RAW"
            Me.TabPage4.UseVisualStyleBackColor = True
            '
            'CoH_BytesViewer1
            '
            Me.CoH_BytesViewer1.BackColor = System.Drawing.Color.DodgerBlue
            Me.CoH_BytesViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CoH_BytesViewer1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CoH_BytesViewer1.Location = New System.Drawing.Point(3, 3)
            Me.CoH_BytesViewer1.Name = "CoH_BytesViewer1"
            Me.CoH_BytesViewer1.Size = New System.Drawing.Size(713, 565)
            Me.CoH_BytesViewer1.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.ListView1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(719, 571)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Bin Content Details"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'TabPage5
            '
            Me.TabPage5.Controls.Add(Me.ListView2)
            Me.TabPage5.Location = New System.Drawing.Point(4, 22)
            Me.TabPage5.Name = "TabPage5"
            Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage5.Size = New System.Drawing.Size(719, 571)
            Me.TabPage5.TabIndex = 4
            Me.TabPage5.Text = "Bin Sources"
            Me.TabPage5.UseVisualStyleBackColor = True
            '
            'ListView2
            '
            Me.ListView2.BackColor = System.Drawing.Color.YellowGreen
            Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
            Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ListView2.FullRowSelect = True
            Me.ListView2.GridLines = True
            Me.ListView2.HideSelection = False
            Me.ListView2.Location = New System.Drawing.Point(3, 3)
            Me.ListView2.Name = "ListView2"
            Me.ListView2.Size = New System.Drawing.Size(713, 565)
            Me.ListView2.TabIndex = 32
            Me.ListView2.UseCompatibleStateImageBehavior = False
            Me.ListView2.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "File Name"
            Me.ColumnHeader6.Width = 446
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "Time Stamp"
            Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader7.Width = 225
            '
            'CheckBox3
            '
            Me.CheckBox3.AutoSize = True
            Me.CheckBox3.Location = New System.Drawing.Point(142, 27)
            Me.CheckBox3.Name = "CheckBox3"
            Me.CheckBox3.Size = New System.Drawing.Size(151, 17)
            Me.CheckBox3.TabIndex = 4
            Me.CheckBox3.Text = "Dont Show Default Values"
            Me.CheckBox3.UseVisualStyleBackColor = True
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.ExportAllToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(727, 24)
            Me.MenuStrip1.TabIndex = 34
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ExportToolStripMenuItem
            '
            Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportDEFToolStripMenuItem, Me.ExportXMLToolStripMenuItem, Me.ExportRAWToolStripMenuItem})
            Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
            Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
            Me.ExportToolStripMenuItem.Text = "Export (Current)"
            '
            'ExportDEFToolStripMenuItem
            '
            Me.ExportDEFToolStripMenuItem.Name = "ExportDEFToolStripMenuItem"
            Me.ExportDEFToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.ExportDEFToolStripMenuItem.Text = "Export Current as XML"
            '
            'ExportXMLToolStripMenuItem
            '
            Me.ExportXMLToolStripMenuItem.Name = "ExportXMLToolStripMenuItem"
            Me.ExportXMLToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.ExportXMLToolStripMenuItem.Text = "Export Current as DEF"
            '
            'ExportRAWToolStripMenuItem
            '
            Me.ExportRAWToolStripMenuItem.Name = "ExportRAWToolStripMenuItem"
            Me.ExportRAWToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
            Me.ExportRAWToolStripMenuItem.Text = "Export Current as RAW"
            '
            'ExportAllToolStripMenuItem
            '
            Me.ExportAllToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportAll_XML_ToolStripMenuItem, Me.ExportAll_DEF_ToolStripMenuItem, Me.ExportAll_RAW_ToolStripMenuItem})
            Me.ExportAllToolStripMenuItem.Name = "ExportAllToolStripMenuItem"
            Me.ExportAllToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
            Me.ExportAllToolStripMenuItem.Text = "Export All"
            '
            'ExportAll_XML_ToolStripMenuItem
            '
            Me.ExportAll_XML_ToolStripMenuItem.Name = "ExportAll_XML_ToolStripMenuItem"
            Me.ExportAll_XML_ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.ExportAll_XML_ToolStripMenuItem.Text = "Export ALL as XML"
            '
            'ExportAll_DEF_ToolStripMenuItem
            '
            Me.ExportAll_DEF_ToolStripMenuItem.Name = "ExportAll_DEF_ToolStripMenuItem"
            Me.ExportAll_DEF_ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.ExportAll_DEF_ToolStripMenuItem.Text = "Export ALL as DEF"
            '
            'ExportAll_RAW_ToolStripMenuItem
            '
            Me.ExportAll_RAW_ToolStripMenuItem.Enabled = False
            Me.ExportAll_RAW_ToolStripMenuItem.Name = "ExportAll_RAW_ToolStripMenuItem"
            Me.ExportAll_RAW_ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.ExportAll_RAW_ToolStripMenuItem.Text = "Export ALL as RAW"
            '
            'CheckBox2
            '
            Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CheckBox2.AutoSize = True
            Me.CheckBox2.Location = New System.Drawing.Point(411, 27)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New System.Drawing.Size(150, 17)
            Me.CheckBox2.TabIndex = 3
            Me.CheckBox2.Text = "Dont Show Project Values"
            Me.CheckBox2.UseVisualStyleBackColor = True
            '
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Location = New System.Drawing.Point(4, 27)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(139, 17)
            Me.CheckBox1.TabIndex = 2
            Me.CheckBox1.Text = "Dont Show Empty Lines"
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'COH_Control_ViewBin
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.CornflowerBlue
            Me.Controls.Add(Me.SplitContainer1)
            Me.Name = "COH_Control_ViewBin"
            Me.Size = New System.Drawing.Size(1094, 647)
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            Me.SplitContainer1.Panel2.PerformLayout()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage6.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage4.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage5.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ListView1 As ListView
        Friend WithEvents ColumnHeader1 As ColumnHeader
        Friend WithEvents ColumnHeader2 As ColumnHeader
        Friend WithEvents ColumnHeader3 As ColumnHeader
        Friend WithEvents ColumnHeader4 As ColumnHeader
        Friend WithEvents TreeView1 As TreeView
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents PropertyGrid1 As PropertyGrid
        Friend WithEvents ColumnHeader5 As ColumnHeader
        Friend WithEvents TabPage4 As TabPage
        Friend WithEvents CoH_BytesViewer1 As COH_BytesViewer
        Friend WithEvents TabPage5 As TabPage
        Friend WithEvents ListView2 As ListView
        Friend WithEvents ColumnHeader6 As ColumnHeader
        Friend WithEvents ColumnHeader7 As ColumnHeader
        Friend WithEvents TabPage6 As TabPage
        Friend WithEvents XML_View2 As COH_XML_Viewer
        Friend WithEvents CheckBox2 As CheckBox
        Friend WithEvents CheckBox1 As CheckBox
        Friend WithEvents CheckBox3 As CheckBox
        Friend WithEvents MenuStrip1 As MenuStrip
        Friend WithEvents CheckBox4 As CheckBox
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExportDEFToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExportXMLToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExportRAWToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExportAllToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExportAll_XML_ToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExportAll_DEF_ToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExportAll_RAW_ToolStripMenuItem As ToolStripMenuItem
    End Class
End Namespace