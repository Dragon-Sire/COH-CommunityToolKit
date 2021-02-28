Imports COH.Toolkit.Controls
Imports COH.Toolkit.Controls.WinForms.UserControls

Namespace Toolkit.Controls.WinForms.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_GeoModelViewer
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COH_GeoModelViewer))
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.ElementHost2 = New System.Windows.Forms.Integration.ElementHost()
            Me.CoH_3DModelViewer1 = New COH.Toolkit.Controls.WPF.COH_ModelViewer()
            Me.TabControl2 = New System.Windows.Forms.TabControl()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
            Me.Button_SelectNone = New System.Windows.Forms.Button()
            Me.Label_ModelName = New System.Windows.Forms.Label()
            Me.Button_SelectAll = New System.Windows.Forms.Button()
            Me.LabelVersion = New System.Windows.Forms.Label()
            Me.ModelList = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TabControl3 = New System.Windows.Forms.TabControl()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.ListView3 = New System.Windows.Forms.ListView()
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TabPage6 = New System.Windows.Forms.TabPage()
            Me.XML_View = New UserControls.COH_XML_Viewer
            Me.TabPage5 = New System.Windows.Forms.TabPage()
            Me.ListView2 = New System.Windows.Forms.ListView()
            Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.CoH_TextureResource_Panel1 = New COH_TextureResource_Panel()
            Me.TabPage8 = New System.Windows.Forms.TabPage()
            Me.ListView5 = New System.Windows.Forms.ListView()
            Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me.TreeView1 = New System.Windows.Forms.TreeView()
            Me.ListView4 = New System.Windows.Forms.ListView()
            Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TabPage7 = New System.Windows.Forms.TabPage()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.Toggle_Vertex = New System.Windows.Forms.ToolStripButton()
            Me.ToggleButton_Bones = New System.Windows.Forms.ToolStripButton()
            Me.ToggleButton_Materials = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToggleButton_WireFrame = New System.Windows.Forms.ToolStripButton()
            Me.ToggleButton_Model = New System.Windows.Forms.ToolStripButton()
            Me.ToggleButton_Transparent = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.Button_CameraReset = New System.Windows.Forms.ToolStripButton()
            Me.Button_AdjustPos = New System.Windows.Forms.ToolStripButton()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.TabControl2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer2.Panel1.SuspendLayout()
            Me.SplitContainer2.Panel2.SuspendLayout()
            Me.SplitContainer2.SuspendLayout()
            Me.TabControl3.SuspendLayout()
            Me.TabPage4.SuspendLayout()
            Me.TabPage6.SuspendLayout()
            Me.TabPage5.SuspendLayout()
            Me.TabPage8.SuspendLayout()
            Me.TabPage7.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Location = New System.Drawing.Point(0, 52)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1259, 585)
            Me.TabControl1.TabIndex = 2
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.SplitContainer1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 23)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1251, 558)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Model View"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
            Me.SplitContainer1.Name = "SplitContainer1"
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.ElementHost2)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl2)
            Me.SplitContainer1.Size = New System.Drawing.Size(1245, 552)
            Me.SplitContainer1.SplitterDistance = 415
            Me.SplitContainer1.TabIndex = 2
            '
            'ElementHost2
            '
            Me.ElementHost2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ElementHost2.Location = New System.Drawing.Point(0, 0)
            Me.ElementHost2.Name = "ElementHost2"
            Me.ElementHost2.Size = New System.Drawing.Size(415, 552)
            Me.ElementHost2.TabIndex = 1
            Me.ElementHost2.Text = "ElementHost2"
            Me.ElementHost2.Child = Me.CoH_3DModelViewer1
            '
            'TabControl2
            '
            Me.TabControl2.Controls.Add(Me.TabPage3)
            Me.TabControl2.Controls.Add(Me.TabPage7)
            Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl2.Location = New System.Drawing.Point(0, 0)
            Me.TabControl2.Name = "TabControl2"
            Me.TabControl2.SelectedIndex = 0
            Me.TabControl2.Size = New System.Drawing.Size(826, 552)
            Me.TabControl2.TabIndex = 0
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.SplitContainer2)
            Me.TabPage3.Location = New System.Drawing.Point(4, 23)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(818, 525)
            Me.TabPage3.TabIndex = 0
            Me.TabPage3.Text = "Overview"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'SplitContainer2
            '
            Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
            Me.SplitContainer2.Name = "SplitContainer2"
            Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SplitContainer2.Panel1
            '
            Me.SplitContainer2.Panel1.Controls.Add(Me.Button_SelectNone)
            Me.SplitContainer2.Panel1.Controls.Add(Me.Label_ModelName)
            Me.SplitContainer2.Panel1.Controls.Add(Me.Button_SelectAll)
            Me.SplitContainer2.Panel1.Controls.Add(Me.LabelVersion)
            Me.SplitContainer2.Panel1.Controls.Add(Me.ModelList)
            '
            'SplitContainer2.Panel2
            '
            Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl3)
            Me.SplitContainer2.Size = New System.Drawing.Size(812, 519)
            Me.SplitContainer2.SplitterDistance = 160
            Me.SplitContainer2.TabIndex = 9
            '
            'Button_SelectNone
            '
            Me.Button_SelectNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button_SelectNone.Location = New System.Drawing.Point(759, 106)
            Me.Button_SelectNone.Name = "Button_SelectNone"
            Me.Button_SelectNone.Size = New System.Drawing.Size(48, 25)
            Me.Button_SelectNone.TabIndex = 8
            Me.Button_SelectNone.Text = "NONE"
            Me.Button_SelectNone.UseVisualStyleBackColor = True
            '
            'Label_ModelName
            '
            Me.Label_ModelName.AutoSize = True
            Me.Label_ModelName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label_ModelName.Location = New System.Drawing.Point(4, 9)
            Me.Label_ModelName.Name = "Label_ModelName"
            Me.Label_ModelName.Size = New System.Drawing.Size(89, 14)
            Me.Label_ModelName.TabIndex = 6
            Me.Label_ModelName.Text = "Model Name :"
            Me.Label_ModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Button_SelectAll
            '
            Me.Button_SelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button_SelectAll.Location = New System.Drawing.Point(759, 32)
            Me.Button_SelectAll.Name = "Button_SelectAll"
            Me.Button_SelectAll.Size = New System.Drawing.Size(48, 25)
            Me.Button_SelectAll.TabIndex = 7
            Me.Button_SelectAll.Text = "ALL"
            Me.Button_SelectAll.UseVisualStyleBackColor = True
            '
            'LabelVersion
            '
            Me.LabelVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelVersion.AutoSize = True
            Me.LabelVersion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelVersion.Location = New System.Drawing.Point(719, 9)
            Me.LabelVersion.Name = "LabelVersion"
            Me.LabelVersion.Size = New System.Drawing.Size(88, 14)
            Me.LabelVersion.TabIndex = 1
            Me.LabelVersion.Text = "Version : N/A"
            Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'ModelList
            '
            Me.ModelList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ModelList.CheckBoxes = True
            Me.ModelList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader23, Me.ColumnHeader26})
            Me.ModelList.FullRowSelect = True
            Me.ModelList.GridLines = True
            Me.ModelList.HideSelection = False
            Me.ModelList.Location = New System.Drawing.Point(4, 32)
            Me.ModelList.Name = "ModelList"
            Me.ModelList.Size = New System.Drawing.Size(749, 125)
            Me.ModelList.TabIndex = 5
            Me.ModelList.UseCompatibleStateImageBehavior = False
            Me.ModelList.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Index"
            Me.ColumnHeader1.Width = 55
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Model Name"
            Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader2.Width = 230
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Trick"
            Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader3.Width = 118
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "# Verts"
            Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader4.Width = 66
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "# Triangles"
            Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader5.Width = 85
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "# Bones"
            Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader6.Width = 73
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "# Materials"
            Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader7.Width = 74
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "# STS"
            Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'ColumnHeader23
            '
            Me.ColumnHeader23.Text = "# Weights"
            Me.ColumnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader23.Width = 125
            '
            'ColumnHeader26
            '
            Me.ColumnHeader26.Text = "# Bone MatIndex"
            Me.ColumnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader26.Width = 126
            '
            'TabControl3
            '
            Me.TabControl3.Controls.Add(Me.TabPage4)
            Me.TabControl3.Controls.Add(Me.TabPage6)
            Me.TabControl3.Controls.Add(Me.TabPage5)
            Me.TabControl3.Controls.Add(Me.TabPage8)
            Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl3.Location = New System.Drawing.Point(0, 0)
            Me.TabControl3.Name = "TabControl3"
            Me.TabControl3.SelectedIndex = 0
            Me.TabControl3.Size = New System.Drawing.Size(812, 355)
            Me.TabControl3.TabIndex = 0
            '
            'TabPage4
            '
            Me.TabPage4.Controls.Add(Me.ListView3)
            Me.TabPage4.Controls.Add(Me.ListView1)
            Me.TabPage4.Location = New System.Drawing.Point(4, 23)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage4.Size = New System.Drawing.Size(804, 328)
            Me.TabPage4.TabIndex = 0
            Me.TabPage4.Text = "Mesh Details"
            Me.TabPage4.UseVisualStyleBackColor = True
            '
            'ListView3
            '
            Me.ListView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader18, Me.ColumnHeader19})
            Me.ListView3.FullRowSelect = True
            Me.ListView3.GridLines = True
            Me.ListView3.HideSelection = False
            Me.ListView3.Location = New System.Drawing.Point(521, 3)
            Me.ListView3.Name = "ListView3"
            Me.ListView3.Size = New System.Drawing.Size(280, 257)
            Me.ListView3.TabIndex = 7
            Me.ListView3.UseCompatibleStateImageBehavior = False
            Me.ListView3.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "Index"
            Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader12.Width = 69
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.Text = "F1"
            Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader13.Width = 54
            '
            'ColumnHeader18
            '
            Me.ColumnHeader18.Text = "F2"
            Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader18.Width = 58
            '
            'ColumnHeader19
            '
            Me.ColumnHeader19.Text = "F3"
            Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'ListView1
            '
            Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader27, Me.ColumnHeader28})
            Me.ListView1.FullRowSelect = True
            Me.ListView1.GridLines = True
            Me.ListView1.HideSelection = False
            Me.ListView1.Location = New System.Drawing.Point(3, 0)
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(512, 330)
            Me.ListView1.TabIndex = 6
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.Text = "Index"
            Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader14.Width = 69
            '
            'ColumnHeader15
            '
            Me.ColumnHeader15.Text = "X"
            Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader15.Width = 71
            '
            'ColumnHeader16
            '
            Me.ColumnHeader16.Text = "Y"
            Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader16.Width = 75
            '
            'ColumnHeader17
            '
            Me.ColumnHeader17.Text = "Z"
            Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader17.Width = 84
            '
            'ColumnHeader27
            '
            Me.ColumnHeader27.Text = "W"
            Me.ColumnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader27.Width = 86
            '
            'ColumnHeader28
            '
            Me.ColumnHeader28.Text = "B"
            Me.ColumnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader28.Width = 330
            '
            'TabPage6
            '
            Me.TabPage6.Controls.Add(Me.XML_View)
            Me.TabPage6.Location = New System.Drawing.Point(4, 22)
            Me.TabPage6.Name = "TabPage6"
            Me.TabPage6.Size = New System.Drawing.Size(804, 330)
            Me.TabPage6.TabIndex = 2
            Me.TabPage6.Text = "Trick"
            Me.TabPage6.UseVisualStyleBackColor = True
            '
            'XML_View
            '
            Me.XML_View.Dock = System.Windows.Forms.DockStyle.Fill
            Me.XML_View.Location = New System.Drawing.Point(0, 0)
            Me.XML_View.Name = "XML_View"
            Me.XML_View.Size = New System.Drawing.Size(804, 330)
            Me.XML_View.TabIndex = 1
            '
            'TabPage5
            '
            Me.TabPage5.Controls.Add(Me.ListView2)
            Me.TabPage5.Controls.Add(Me.CoH_TextureResource_Panel1)
            Me.TabPage5.Location = New System.Drawing.Point(4, 22)
            Me.TabPage5.Name = "TabPage5"
            Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage5.Size = New System.Drawing.Size(804, 330)
            Me.TabPage5.TabIndex = 1
            Me.TabPage5.Text = "Materials"
            Me.TabPage5.UseVisualStyleBackColor = True
            '
            'ListView2
            '
            Me.ListView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
            Me.ListView2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListView2.FullRowSelect = True
            Me.ListView2.GridLines = True
            Me.ListView2.HideSelection = False
            Me.ListView2.Location = New System.Drawing.Point(0, 0)
            Me.ListView2.Name = "ListView2"
            Me.ListView2.Size = New System.Drawing.Size(298, 330)
            Me.ListView2.TabIndex = 8
            Me.ListView2.UseCompatibleStateImageBehavior = False
            Me.ListView2.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader9
            '
            Me.ColumnHeader9.Text = "Index"
            Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader9.Width = 67
            '
            'ColumnHeader10
            '
            Me.ColumnHeader10.Text = "X"
            Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader10.Width = 99
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "Y"
            Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader11.Width = 99
            '
            'CoH_TextureResource_Panel1
            '
            Me.CoH_TextureResource_Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CoH_TextureResource_Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CoH_TextureResource_Panel1.Location = New System.Drawing.Point(304, 3)
            Me.CoH_TextureResource_Panel1.Name = "CoH_TextureResource_Panel1"
            Me.CoH_TextureResource_Panel1.Panels_Color_Back = System.Drawing.Color.Gray
            Me.CoH_TextureResource_Panel1.Panels_Color_Selected = System.Drawing.Color.Blue
            Me.CoH_TextureResource_Panel1.Panels_Size = New System.Drawing.Size(475, 125)
            Me.CoH_TextureResource_Panel1.Size = New System.Drawing.Size(497, 327)
            Me.CoH_TextureResource_Panel1.TabIndex = 0
            '
            'TabPage8
            '
            Me.TabPage8.Controls.Add(Me.ListView5)
            Me.TabPage8.Controls.Add(Me.ComboBox1)
            Me.TabPage8.Controls.Add(Me.TreeView1)
            Me.TabPage8.Controls.Add(Me.ListView4)
            Me.TabPage8.Location = New System.Drawing.Point(4, 23)
            Me.TabPage8.Name = "TabPage8"
            Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage8.Size = New System.Drawing.Size(804, 328)
            Me.TabPage8.TabIndex = 3
            Me.TabPage8.Text = "Bones"
            Me.TabPage8.UseVisualStyleBackColor = True
            '
            'ListView5
            '
            Me.ListView5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ListView5.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader29, Me.ColumnHeader30})
            Me.ListView5.FullRowSelect = True
            Me.ListView5.GridLines = True
            Me.ListView5.HideSelection = False
            Me.ListView5.Location = New System.Drawing.Point(469, 121)
            Me.ListView5.Name = "ListView5"
            Me.ListView5.Size = New System.Drawing.Size(335, 201)
            Me.ListView5.TabIndex = 10
            Me.ListView5.UseCompatibleStateImageBehavior = False
            Me.ListView5.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader24
            '
            Me.ColumnHeader24.Text = "Index"
            Me.ColumnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader24.Width = 69
            '
            'ColumnHeader25
            '
            Me.ColumnHeader25.Text = "Bone ID"
            Me.ColumnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader25.Width = 147
            '
            'ColumnHeader29
            '
            Me.ColumnHeader29.Text = "Position"
            Me.ColumnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader29.Width = 92
            '
            'ColumnHeader30
            '
            Me.ColumnHeader30.Text = "Connected Position"
            Me.ColumnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'ComboBox1
            '
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(6, 6)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(457, 22)
            Me.ComboBox1.TabIndex = 9
            '
            'TreeView1
            '
            Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TreeView1.Location = New System.Drawing.Point(6, 39)
            Me.TreeView1.Name = "TreeView1"
            Me.TreeView1.Size = New System.Drawing.Size(457, 283)
            Me.TreeView1.TabIndex = 8
            '
            'ListView4
            '
            Me.ListView4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22})
            Me.ListView4.FullRowSelect = True
            Me.ListView4.GridLines = True
            Me.ListView4.HideSelection = False
            Me.ListView4.Location = New System.Drawing.Point(469, 6)
            Me.ListView4.Name = "ListView4"
            Me.ListView4.Size = New System.Drawing.Size(335, 109)
            Me.ListView4.TabIndex = 7
            Me.ListView4.UseCompatibleStateImageBehavior = False
            Me.ListView4.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader20
            '
            Me.ColumnHeader20.Text = "Index"
            Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader20.Width = 69
            '
            'ColumnHeader21
            '
            Me.ColumnHeader21.Text = "Bone ID"
            Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader21.Width = 147
            '
            'ColumnHeader22
            '
            Me.ColumnHeader22.Text = "Position"
            Me.ColumnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader22.Width = 92
            '
            'TabPage7
            '
            Me.TabPage7.Controls.Add(Me.TextBox1)
            Me.TabPage7.Location = New System.Drawing.Point(4, 22)
            Me.TabPage7.Name = "TabPage7"
            Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage7.Size = New System.Drawing.Size(818, 526)
            Me.TabPage7.TabIndex = 1
            Me.TabPage7.Text = "TEMPORARY (OBJ - EXPORT TXT)"
            Me.TabPage7.UseVisualStyleBackColor = True
            '
            'TextBox1
            '
            Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBox1.Location = New System.Drawing.Point(3, 3)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TextBox1.Size = New System.Drawing.Size(812, 520)
            Me.TextBox1.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.Location = New System.Drawing.Point(4, 23)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(1251, 558)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Details"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ToolStrip1.AutoSize = False
            Me.ToolStrip1.BackColor = System.Drawing.Color.White
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toggle_Vertex, Me.ToggleButton_Bones, Me.ToggleButton_Materials, Me.ToolStripSeparator2, Me.ToggleButton_WireFrame, Me.ToggleButton_Model, Me.ToggleButton_Transparent, Me.ToolStripSeparator1, Me.Button_CameraReset, Me.Button_AdjustPos})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(1259, 49)
            Me.ToolStrip1.TabIndex = 3
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'Toggle_Vertex
            '
            Me.Toggle_Vertex.AutoSize = False
            Me.Toggle_Vertex.BackColor = System.Drawing.Color.White
            Me.Toggle_Vertex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Toggle_Vertex.CheckOnClick = True
            Me.Toggle_Vertex.Image = My.Resources.Resources.draw_vertex_icon
            Me.Toggle_Vertex.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.Toggle_Vertex.Name = "Toggle_Vertex"
            Me.Toggle_Vertex.Size = New System.Drawing.Size(64, 64)
            Me.Toggle_Vertex.Text = "Vertexs"
            Me.Toggle_Vertex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Toggle_Vertex.ToolTipText = "Show/Hide Vertex"
            '
            'ToggleButton_Bones
            '
            Me.ToggleButton_Bones.AutoSize = False
            Me.ToggleButton_Bones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ToggleButton_Bones.CheckOnClick = True
            Me.ToggleButton_Bones.Image = My.Resources.Resources.bone_icon
            Me.ToggleButton_Bones.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToggleButton_Bones.Name = "ToggleButton_Bones"
            Me.ToggleButton_Bones.Size = New System.Drawing.Size(64, 64)
            Me.ToggleButton_Bones.Text = "Bones"
            Me.ToggleButton_Bones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.ToggleButton_Bones.ToolTipText = "Show/Hide Bones"
            '
            'ToggleButton_Materials
            '
            Me.ToggleButton_Materials.CheckOnClick = True
            Me.ToggleButton_Materials.Image = CType(resources.GetObject("ToggleButton_Materials.Image"), System.Drawing.Image)
            Me.ToggleButton_Materials.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToggleButton_Materials.Name = "ToggleButton_Materials"
            Me.ToggleButton_Materials.Size = New System.Drawing.Size(59, 46)
            Me.ToggleButton_Materials.Text = "Materials"
            Me.ToggleButton_Materials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 49)
            '
            'ToggleButton_WireFrame
            '
            Me.ToggleButton_WireFrame.AutoSize = False
            Me.ToggleButton_WireFrame.BackColor = System.Drawing.Color.White
            Me.ToggleButton_WireFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ToggleButton_WireFrame.CheckOnClick = True
            Me.ToggleButton_WireFrame.Image = My.Resources.Resources.minimal_07_512
            Me.ToggleButton_WireFrame.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToggleButton_WireFrame.Name = "ToggleButton_WireFrame"
            Me.ToggleButton_WireFrame.Size = New System.Drawing.Size(64, 64)
            Me.ToggleButton_WireFrame.Text = "Wireframe"
            Me.ToggleButton_WireFrame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.ToggleButton_WireFrame.ToolTipText = "Show/Hide WireFrame"
            '
            'ToggleButton_Model
            '
            Me.ToggleButton_Model.AutoSize = False
            Me.ToggleButton_Model.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ToggleButton_Model.CheckOnClick = True
            Me.ToggleButton_Model.Image = CType(resources.GetObject("ToggleButton_Model.Image"), System.Drawing.Image)
            Me.ToggleButton_Model.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToggleButton_Model.Name = "ToggleButton_Model"
            Me.ToggleButton_Model.Size = New System.Drawing.Size(64, 64)
            Me.ToggleButton_Model.Text = "Model"
            Me.ToggleButton_Model.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'ToggleButton_Transparent
            '
            Me.ToggleButton_Transparent.AutoSize = False
            Me.ToggleButton_Transparent.CheckOnClick = True
            Me.ToggleButton_Transparent.Image = CType(resources.GetObject("ToggleButton_Transparent.Image"), System.Drawing.Image)
            Me.ToggleButton_Transparent.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToggleButton_Transparent.Name = "ToggleButton_Transparent"
            Me.ToggleButton_Transparent.Size = New System.Drawing.Size(64, 64)
            Me.ToggleButton_Transparent.Text = "Transparent"
            Me.ToggleButton_Transparent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 49)
            '
            'Button_CameraReset
            '
            Me.Button_CameraReset.AutoSize = False
            Me.Button_CameraReset.Image = CType(resources.GetObject("Button_CameraReset.Image"), System.Drawing.Image)
            Me.Button_CameraReset.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.Button_CameraReset.Name = "Button_CameraReset"
            Me.Button_CameraReset.Size = New System.Drawing.Size(80, 64)
            Me.Button_CameraReset.Text = "Reset Camera"
            Me.Button_CameraReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Button_CameraReset.ToolTipText = "Reset Camera"
            '
            'Button_AdjustPos
            '
            Me.Button_AdjustPos.CheckOnClick = True
            Me.Button_AdjustPos.Image = CType(resources.GetObject("Button_AdjustPos.Image"), System.Drawing.Image)
            Me.Button_AdjustPos.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.Button_AdjustPos.Name = "Button_AdjustPos"
            Me.Button_AdjustPos.Size = New System.Drawing.Size(96, 46)
            Me.Button_AdjustPos.Text = "Adjust Positions"
            Me.Button_AdjustPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Button_AdjustPos.ToolTipText = "Adjust Positions of Models Based on Bones (Does Not Take Into Consideration Skele" &
    "ton or Scale)"
            '
            'COH_GeoModelViewer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.CornflowerBlue
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.TabControl1)
            Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "COH_GeoModelViewer"
            Me.Size = New System.Drawing.Size(1259, 637)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            Me.TabControl2.ResumeLayout(False)
            Me.TabPage3.ResumeLayout(False)
            Me.SplitContainer2.Panel1.ResumeLayout(False)
            Me.SplitContainer2.Panel1.PerformLayout()
            Me.SplitContainer2.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer2.ResumeLayout(False)
            Me.TabControl3.ResumeLayout(False)
            Me.TabPage4.ResumeLayout(False)
            Me.TabPage6.ResumeLayout(False)
            Me.TabPage5.ResumeLayout(False)
            Me.TabPage8.ResumeLayout(False)
            Me.TabPage7.ResumeLayout(False)
            Me.TabPage7.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ElementHost2 As Integration.ElementHost
        Friend CoH_3DModelViewer1 As WPF.COH_ModelViewer
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents TabControl2 As TabControl
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents ModelList As ListView
        Friend WithEvents ColumnHeader1 As ColumnHeader
        Friend WithEvents ColumnHeader2 As ColumnHeader
        Friend WithEvents ColumnHeader3 As ColumnHeader
        Friend WithEvents ColumnHeader4 As ColumnHeader
        Friend WithEvents ColumnHeader5 As ColumnHeader
        Friend WithEvents ColumnHeader6 As ColumnHeader
        Friend WithEvents ColumnHeader7 As ColumnHeader
        Friend WithEvents LabelVersion As Label
        Friend WithEvents TabControl3 As TabControl
        Friend WithEvents TabPage4 As TabPage
        Friend WithEvents TabPage5 As TabPage
        Friend WithEvents TabPage6 As TabPage
        Friend WithEvents ToolStrip1 As ToolStrip
        Friend WithEvents ToggleButton_Bones As ToolStripButton
        Friend WithEvents Toggle_Vertex As ToolStripButton
        Friend WithEvents ToggleButton_WireFrame As ToolStripButton
        Friend WithEvents Label_ModelName As Label
        Friend WithEvents CoH_TextureResource_Panel1 As COH_TextureResource_Panel
        Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
        Friend WithEvents ToggleButton_Model As ToolStripButton
        Friend WithEvents ToggleButton_Transparent As ToolStripButton
        Friend WithEvents Button_SelectNone As Button
        Friend WithEvents Button_SelectAll As Button
        Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
        Friend WithEvents Button_CameraReset As ToolStripButton
        Friend WithEvents TabPage7 As TabPage
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents ColumnHeader8 As ColumnHeader
        Friend WithEvents ToggleButton_Materials As ToolStripButton
        Friend WithEvents ListView1 As ListView
        Friend WithEvents ColumnHeader14 As ColumnHeader
        Friend WithEvents ColumnHeader15 As ColumnHeader
        Friend WithEvents ColumnHeader16 As ColumnHeader
        Friend WithEvents ColumnHeader17 As ColumnHeader
        Friend WithEvents ListView2 As ListView
        Friend WithEvents ColumnHeader9 As ColumnHeader
        Friend WithEvents ColumnHeader10 As ColumnHeader
        Friend WithEvents ColumnHeader11 As ColumnHeader
        Friend WithEvents ListView3 As ListView
        Friend WithEvents ColumnHeader12 As ColumnHeader
        Friend WithEvents ColumnHeader13 As ColumnHeader
        Friend WithEvents ColumnHeader18 As ColumnHeader
        Friend WithEvents ColumnHeader19 As ColumnHeader
        Friend WithEvents TabPage8 As TabPage
        Friend WithEvents XML_View As UserControls.COH_XML_Viewer
        Friend WithEvents ListView4 As ListView
        Friend WithEvents ColumnHeader20 As ColumnHeader
        Friend WithEvents ColumnHeader21 As ColumnHeader
        Friend WithEvents ColumnHeader22 As ColumnHeader
        Friend WithEvents ColumnHeader23 As ColumnHeader
        Friend WithEvents ColumnHeader26 As ColumnHeader
        Friend WithEvents ColumnHeader27 As ColumnHeader
        Friend WithEvents ColumnHeader28 As ColumnHeader
        Friend WithEvents ComboBox1 As ComboBox
        Friend WithEvents TreeView1 As TreeView
        Friend WithEvents ListView5 As ListView
        Friend WithEvents ColumnHeader24 As ColumnHeader
        Friend WithEvents ColumnHeader25 As ColumnHeader
        Friend WithEvents ColumnHeader29 As ColumnHeader
        Friend WithEvents ColumnHeader30 As ColumnHeader
        Friend WithEvents Button_AdjustPos As ToolStripButton
        Friend WithEvents SplitContainer2 As SplitContainer
    End Class
End Namespace