Imports COH.Tools.Controls
Imports COH.Toolkit.Controls.WinForms

Namespace Toolkit.Modding.Editors
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_CharacterClass_Editor
        Inherits COH_ModdableContent_Editor

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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.TabControl2 = New System.Windows.Forms.TabControl()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.Edit_Tooltip = New System.Windows.Forms.TextBox()
            Me.Button_Refresh_Help = New System.Windows.Forms.Button()
            Me.Button_Refresh_DisplayName = New System.Windows.Forms.Button()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Button6 = New System.Windows.Forms.Button()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Edit_DisplayNameKey = New System.Windows.Forms.TextBox()
            Me.Edit_DisplayName = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Edit_ClassName = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Edit_Help = New System.Windows.Forms.TextBox()
            Me.Edit_Icon = New System.Windows.Forms.TextBox()
            Me.Button_Refresh_Tooltip = New System.Windows.Forms.Button()
            Me.Edit_ToolTipKey = New System.Windows.Forms.TextBox()
            Me.Edit_HelpKey = New System.Windows.Forms.TextBox()
            Me.TabPage6 = New System.Windows.Forms.TabPage()
            Me.Edit_ReductionClass = New System.Windows.Forms.TextBox()
            Me.Edit_Secondary = New System.Windows.Forms.TextBox()
            Me.Edit_Primary = New System.Windows.Forms.TextBox()
            Me.Edit_RespecAtlevels = New System.Windows.Forms.ListBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Edit_Defiant = New System.Windows.Forms.NumericUpDown()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Edit_HPStatus = New System.Windows.Forms.CheckBox()
            Me.Edit_ReduceAV = New System.Windows.Forms.CheckBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Select_EpicPool = New System.Windows.Forms.ComboBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Select_Pool = New System.Windows.Forms.ComboBox()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.Button_Refresh_LockedTooltip = New System.Windows.Forms.Button()
            Me.Select_Restrictions = New COH.Toolkit.Controls.WinForms.COH_CheckListBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Select_Allowed_Origins = New COH.Toolkit.Controls.WinForms.COH_CheckListBox()
            Me.Edit_ProductCode = New System.Windows.Forms.TextBox()
            Me.Edit_StoreRequires = New System.Windows.Forms.TextBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Edit_Locked = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Edit_LockedKey = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.TabPage5 = New System.Windows.Forms.TabPage()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.Edit_BaseAttributes = New System.Windows.Forms.DataGridView()
            Me.TabPage8 = New System.Windows.Forms.TabPage()
            Me.Edit_AttributesTable = New System.Windows.Forms.DataGridView()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Select_Attributes = New System.Windows.Forms.ComboBox()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.Edit_NamedTable = New System.Windows.Forms.DataGridView()
            Me.DataGridView3 = New System.Windows.Forms.DataGridView()
            Me.Edit_Respecs = New System.Windows.Forms.TextBox()
            Me.TabPage12.SuspendLayout()
            Me.TabControl2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage6.SuspendLayout()
            CType(Me.Edit_Defiant, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage4.SuspendLayout()
            Me.TabPage5.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.Edit_BaseAttributes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage8.SuspendLayout()
            CType(Me.Edit_AttributesTable, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage2.SuspendLayout()
            CType(Me.Edit_NamedTable, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TabPage12
            '
            Me.TabPage12.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(248, Byte), Integer))
            Me.TabPage12.Controls.Add(Me.TabControl2)
            Me.TabPage12.Size = New System.Drawing.Size(889, 408)
            '
            'TabControl2
            '
            Me.TabControl2.Controls.Add(Me.TabPage3)
            Me.TabControl2.Controls.Add(Me.TabPage6)
            Me.TabControl2.Controls.Add(Me.TabPage4)
            Me.TabControl2.Controls.Add(Me.TabPage5)
            Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl2.Location = New System.Drawing.Point(3, 3)
            Me.TabControl2.Name = "TabControl2"
            Me.TabControl2.SelectedIndex = 0
            Me.TabControl2.Size = New System.Drawing.Size(883, 402)
            Me.TabControl2.TabIndex = 46
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.Edit_Tooltip)
            Me.TabPage3.Controls.Add(Me.Button_Refresh_Help)
            Me.TabPage3.Controls.Add(Me.Button_Refresh_DisplayName)
            Me.TabPage3.Controls.Add(Me.Label6)
            Me.TabPage3.Controls.Add(Me.PictureBox1)
            Me.TabPage3.Controls.Add(Me.Label21)
            Me.TabPage3.Controls.Add(Me.Button6)
            Me.TabPage3.Controls.Add(Me.Label12)
            Me.TabPage3.Controls.Add(Me.Label15)
            Me.TabPage3.Controls.Add(Me.Edit_DisplayNameKey)
            Me.TabPage3.Controls.Add(Me.Edit_DisplayName)
            Me.TabPage3.Controls.Add(Me.Label5)
            Me.TabPage3.Controls.Add(Me.Edit_ClassName)
            Me.TabPage3.Controls.Add(Me.Label19)
            Me.TabPage3.Controls.Add(Me.Edit_Help)
            Me.TabPage3.Controls.Add(Me.Edit_Icon)
            Me.TabPage3.Controls.Add(Me.Button_Refresh_Tooltip)
            Me.TabPage3.Controls.Add(Me.Edit_ToolTipKey)
            Me.TabPage3.Controls.Add(Me.Edit_HelpKey)
            Me.TabPage3.Location = New System.Drawing.Point(4, 23)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(875, 375)
            Me.TabPage3.TabIndex = 0
            Me.TabPage3.Text = "General Information"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'Edit_Tooltip
            '
            Me.Edit_Tooltip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Tooltip.Location = New System.Drawing.Point(110, 100)
            Me.Edit_Tooltip.Multiline = True
            Me.Edit_Tooltip.Name = "Edit_Tooltip"
            Me.Edit_Tooltip.Size = New System.Drawing.Size(551, 47)
            Me.Edit_Tooltip.TabIndex = 22
            '
            'Button_Refresh_Help
            '
            Me.Button_Refresh_Help.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button_Refresh_Help.BackColor = System.Drawing.Color.White
            Me.Button_Refresh_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button_Refresh_Help.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button_Refresh_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Button_Refresh_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
            Me.Button_Refresh_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button_Refresh_Help.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button_Refresh_Help.Location = New System.Drawing.Point(796, 152)
            Me.Button_Refresh_Help.Name = "Button_Refresh_Help"
            Me.Button_Refresh_Help.Size = New System.Drawing.Size(63, 21)
            Me.Button_Refresh_Help.TabIndex = 51
            Me.Button_Refresh_Help.Text = "Refresh"
            Me.FormToolTip.SetToolTip(Me.Button_Refresh_Help, "Update PString Help")
            Me.Button_Refresh_Help.UseVisualStyleBackColor = False
            '
            'Button_Refresh_DisplayName
            '
            Me.Button_Refresh_DisplayName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button_Refresh_DisplayName.BackColor = System.Drawing.Color.White
            Me.Button_Refresh_DisplayName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button_Refresh_DisplayName.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button_Refresh_DisplayName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Button_Refresh_DisplayName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
            Me.Button_Refresh_DisplayName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button_Refresh_DisplayName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button_Refresh_DisplayName.Location = New System.Drawing.Point(796, 47)
            Me.Button_Refresh_DisplayName.Name = "Button_Refresh_DisplayName"
            Me.Button_Refresh_DisplayName.Size = New System.Drawing.Size(63, 21)
            Me.Button_Refresh_DisplayName.TabIndex = 50
            Me.Button_Refresh_DisplayName.Text = "Refresh"
            Me.FormToolTip.SetToolTip(Me.Button_Refresh_DisplayName, "Update PString Display Name")
            Me.Button_Refresh_DisplayName.UseVisualStyleBackColor = False
            '
            'Label6
            '
            Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label6.BackColor = System.Drawing.Color.Black
            Me.Label6.ForeColor = System.Drawing.Color.White
            Me.Label6.Location = New System.Drawing.Point(0, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(876, 17)
            Me.Label6.TabIndex = 47
            Me.Label6.Text = "General Details :"
            '
            'PictureBox1
            '
            Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(109, 73)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
            Me.PictureBox1.TabIndex = 46
            Me.PictureBox1.TabStop = False
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(23, 50)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(86, 14)
            Me.Label21.TabIndex = 39
            Me.Label21.Text = "Display Name :"
            '
            'Button6
            '
            Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button6.Enabled = False
            Me.Button6.Location = New System.Drawing.Point(634, 74)
            Me.Button6.Name = "Button6"
            Me.Button6.Size = New System.Drawing.Size(27, 20)
            Me.Button6.TabIndex = 45
            Me.Button6.Text = "..."
            Me.Button6.UseVisualStyleBackColor = True
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(69, 73)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(39, 14)
            Me.Label12.TabIndex = 11
            Me.Label12.Text = "Icon :"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(67, 155)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(39, 14)
            Me.Label15.TabIndex = 14
            Me.Label15.Text = "Help :"
            '
            'Edit_DisplayNameKey
            '
            Me.Edit_DisplayNameKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_DisplayNameKey.Location = New System.Drawing.Point(666, 47)
            Me.Edit_DisplayNameKey.Name = "Edit_DisplayNameKey"
            Me.Edit_DisplayNameKey.ReadOnly = True
            Me.Edit_DisplayNameKey.Size = New System.Drawing.Size(127, 22)
            Me.Edit_DisplayNameKey.TabIndex = 41
            '
            'Edit_DisplayName
            '
            Me.Edit_DisplayName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_DisplayName.Location = New System.Drawing.Point(109, 47)
            Me.Edit_DisplayName.Name = "Edit_DisplayName"
            Me.Edit_DisplayName.Size = New System.Drawing.Size(552, 22)
            Me.Edit_DisplayName.TabIndex = 40
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(16, 103)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(95, 14)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "Mouse ToolTip :"
            '
            'Edit_ClassName
            '
            Me.Edit_ClassName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_ClassName.Location = New System.Drawing.Point(110, 19)
            Me.Edit_ClassName.Name = "Edit_ClassName"
            Me.Edit_ClassName.ReadOnly = True
            Me.Edit_ClassName.Size = New System.Drawing.Size(552, 22)
            Me.Edit_ClassName.TabIndex = 35
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(64, 22)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(40, 14)
            Me.Label19.TabIndex = 34
            Me.Label19.Text = "Class :"
            '
            'Edit_Help
            '
            Me.Edit_Help.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Help.Location = New System.Drawing.Point(109, 152)
            Me.Edit_Help.Multiline = True
            Me.Edit_Help.Name = "Edit_Help"
            Me.Edit_Help.Size = New System.Drawing.Size(552, 159)
            Me.Edit_Help.TabIndex = 23
            '
            'Edit_Icon
            '
            Me.Edit_Icon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Icon.Location = New System.Drawing.Point(134, 73)
            Me.Edit_Icon.Name = "Edit_Icon"
            Me.Edit_Icon.Size = New System.Drawing.Size(495, 22)
            Me.Edit_Icon.TabIndex = 24
            '
            'Button_Refresh_Tooltip
            '
            Me.Button_Refresh_Tooltip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button_Refresh_Tooltip.BackColor = System.Drawing.Color.White
            Me.Button_Refresh_Tooltip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button_Refresh_Tooltip.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button_Refresh_Tooltip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Button_Refresh_Tooltip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
            Me.Button_Refresh_Tooltip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button_Refresh_Tooltip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button_Refresh_Tooltip.Location = New System.Drawing.Point(796, 100)
            Me.Button_Refresh_Tooltip.Name = "Button_Refresh_Tooltip"
            Me.Button_Refresh_Tooltip.Size = New System.Drawing.Size(63, 21)
            Me.Button_Refresh_Tooltip.TabIndex = 29
            Me.Button_Refresh_Tooltip.Text = "Refresh"
            Me.FormToolTip.SetToolTip(Me.Button_Refresh_Tooltip, "Update PString Tooltip")
            Me.Button_Refresh_Tooltip.UseVisualStyleBackColor = False
            '
            'Edit_ToolTipKey
            '
            Me.Edit_ToolTipKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_ToolTipKey.Location = New System.Drawing.Point(666, 100)
            Me.Edit_ToolTipKey.Name = "Edit_ToolTipKey"
            Me.Edit_ToolTipKey.ReadOnly = True
            Me.Edit_ToolTipKey.Size = New System.Drawing.Size(127, 22)
            Me.Edit_ToolTipKey.TabIndex = 25
            '
            'Edit_HelpKey
            '
            Me.Edit_HelpKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_HelpKey.Location = New System.Drawing.Point(666, 152)
            Me.Edit_HelpKey.Name = "Edit_HelpKey"
            Me.Edit_HelpKey.ReadOnly = True
            Me.Edit_HelpKey.Size = New System.Drawing.Size(127, 22)
            Me.Edit_HelpKey.TabIndex = 26
            '
            'TabPage6
            '
            Me.TabPage6.Controls.Add(Me.Edit_ReductionClass)
            Me.TabPage6.Controls.Add(Me.Edit_Secondary)
            Me.TabPage6.Controls.Add(Me.Edit_Primary)
            Me.TabPage6.Controls.Add(Me.Edit_RespecAtlevels)
            Me.TabPage6.Controls.Add(Me.Label8)
            Me.TabPage6.Controls.Add(Me.Edit_Defiant)
            Me.TabPage6.Controls.Add(Me.Label2)
            Me.TabPage6.Controls.Add(Me.Label7)
            Me.TabPage6.Controls.Add(Me.Edit_HPStatus)
            Me.TabPage6.Controls.Add(Me.Edit_ReduceAV)
            Me.TabPage6.Controls.Add(Me.Label22)
            Me.TabPage6.Controls.Add(Me.Select_EpicPool)
            Me.TabPage6.Controls.Add(Me.Label20)
            Me.TabPage6.Controls.Add(Me.Label1)
            Me.TabPage6.Controls.Add(Me.Label13)
            Me.TabPage6.Controls.Add(Me.Label14)
            Me.TabPage6.Controls.Add(Me.Select_Pool)
            Me.TabPage6.Location = New System.Drawing.Point(4, 23)
            Me.TabPage6.Name = "TabPage6"
            Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage6.Size = New System.Drawing.Size(875, 375)
            Me.TabPage6.TabIndex = 3
            Me.TabPage6.Text = "Powers"
            Me.TabPage6.UseVisualStyleBackColor = True
            '
            'Edit_ReductionClass
            '
            Me.Edit_ReductionClass.Location = New System.Drawing.Point(157, 184)
            Me.Edit_ReductionClass.Name = "Edit_ReductionClass"
            Me.Edit_ReductionClass.Size = New System.Drawing.Size(232, 22)
            Me.Edit_ReductionClass.TabIndex = 53
            '
            'Edit_Secondary
            '
            Me.Edit_Secondary.Location = New System.Drawing.Point(157, 48)
            Me.Edit_Secondary.Name = "Edit_Secondary"
            Me.Edit_Secondary.Size = New System.Drawing.Size(232, 22)
            Me.Edit_Secondary.TabIndex = 52
            '
            'Edit_Primary
            '
            Me.Edit_Primary.Location = New System.Drawing.Point(157, 22)
            Me.Edit_Primary.Name = "Edit_Primary"
            Me.Edit_Primary.Size = New System.Drawing.Size(232, 22)
            Me.Edit_Primary.TabIndex = 51
            '
            'Edit_RespecAtlevels
            '
            Me.Edit_RespecAtlevels.FormattingEnabled = True
            Me.Edit_RespecAtlevels.ItemHeight = 14
            Me.Edit_RespecAtlevels.Location = New System.Drawing.Point(157, 243)
            Me.Edit_RespecAtlevels.Name = "Edit_RespecAtlevels"
            Me.Edit_RespecAtlevels.Size = New System.Drawing.Size(232, 60)
            Me.Edit_RespecAtlevels.TabIndex = 50
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(44, 243)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(110, 14)
            Me.Label8.TabIndex = 7
            Me.Label8.Text = "Level Up Respecs :"
            '
            'Edit_Defiant
            '
            Me.Edit_Defiant.DecimalPlaces = 6
            Me.Edit_Defiant.Location = New System.Drawing.Point(157, 211)
            Me.Edit_Defiant.Name = "Edit_Defiant"
            Me.Edit_Defiant.Size = New System.Drawing.Size(173, 22)
            Me.Edit_Defiant.TabIndex = 49
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(64, 213)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(86, 14)
            Me.Label2.TabIndex = 48
            Me.Label2.Text = "Defiant Scale :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(51, 187)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(99, 14)
            Me.Label7.TabIndex = 46
            Me.Label7.Text = "Reduction Class :"
            '
            'Edit_HPStatus
            '
            Me.Edit_HPStatus.AutoSize = True
            Me.Edit_HPStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Edit_HPStatus.Location = New System.Drawing.Point(22, 131)
            Me.Edit_HPStatus.Name = "Edit_HPStatus"
            Me.Edit_HPStatus.Size = New System.Drawing.Size(150, 18)
            Me.Edit_HPStatus.TabIndex = 45
            Me.Edit_HPStatus.Text = "Connect HP && Status :"
            Me.Edit_HPStatus.UseVisualStyleBackColor = True
            '
            'Edit_ReduceAV
            '
            Me.Edit_ReduceAV.AutoSize = True
            Me.Edit_ReduceAV.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Edit_ReduceAV.Location = New System.Drawing.Point(24, 155)
            Me.Edit_ReduceAV.Name = "Edit_ReduceAV"
            Me.Edit_ReduceAV.Size = New System.Drawing.Size(148, 18)
            Me.Edit_ReduceAV.TabIndex = 44
            Me.Edit_ReduceAV.Text = "Reduce as ArchVillian :"
            Me.Edit_ReduceAV.UseVisualStyleBackColor = True
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(85, 106)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(64, 14)
            Me.Label22.TabIndex = 39
            Me.Label22.Text = "Epic Pool :"
            '
            'Select_EpicPool
            '
            Me.Select_EpicPool.Enabled = False
            Me.Select_EpicPool.FormattingEnabled = True
            Me.Select_EpicPool.Location = New System.Drawing.Point(157, 103)
            Me.Select_EpicPool.Name = "Select_EpicPool"
            Me.Select_EpicPool.Size = New System.Drawing.Size(170, 22)
            Me.Select_EpicPool.TabIndex = 40
            Me.Select_EpicPool.Text = "EPIC"
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.Black
            Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label20.ForeColor = System.Drawing.Color.White
            Me.Label20.Location = New System.Drawing.Point(3, 3)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(869, 17)
            Me.Label20.TabIndex = 38
            Me.Label20.Text = "Base Powers :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(44, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(107, 14)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Primary Category :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(61, 78)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(91, 14)
            Me.Label13.TabIndex = 12
            Me.Label13.Text = "Pool Category :"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(30, 50)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(125, 14)
            Me.Label14.TabIndex = 13
            Me.Label14.Text = "Secondary Category :"
            '
            'Select_Pool
            '
            Me.Select_Pool.Enabled = False
            Me.Select_Pool.FormattingEnabled = True
            Me.Select_Pool.Location = New System.Drawing.Point(157, 75)
            Me.Select_Pool.Name = "Select_Pool"
            Me.Select_Pool.Size = New System.Drawing.Size(170, 22)
            Me.Select_Pool.TabIndex = 19
            Me.Select_Pool.Text = "POOL"
            '
            'TabPage4
            '
            Me.TabPage4.Controls.Add(Me.Button_Refresh_LockedTooltip)
            Me.TabPage4.Controls.Add(Me.Select_Restrictions)
            Me.TabPage4.Controls.Add(Me.Label18)
            Me.TabPage4.Controls.Add(Me.Label11)
            Me.TabPage4.Controls.Add(Me.Label4)
            Me.TabPage4.Controls.Add(Me.Select_Allowed_Origins)
            Me.TabPage4.Controls.Add(Me.Edit_ProductCode)
            Me.TabPage4.Controls.Add(Me.Edit_StoreRequires)
            Me.TabPage4.Controls.Add(Me.Label16)
            Me.TabPage4.Controls.Add(Me.Edit_Locked)
            Me.TabPage4.Controls.Add(Me.Label10)
            Me.TabPage4.Controls.Add(Me.Edit_LockedKey)
            Me.TabPage4.Controls.Add(Me.Label9)
            Me.TabPage4.Controls.Add(Me.Label3)
            Me.TabPage4.Location = New System.Drawing.Point(4, 23)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage4.Size = New System.Drawing.Size(875, 375)
            Me.TabPage4.TabIndex = 1
            Me.TabPage4.Text = "Restrictions"
            Me.TabPage4.UseVisualStyleBackColor = True
            '
            'Button_Refresh_LockedTooltip
            '
            Me.Button_Refresh_LockedTooltip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button_Refresh_LockedTooltip.BackColor = System.Drawing.Color.White
            Me.Button_Refresh_LockedTooltip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button_Refresh_LockedTooltip.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button_Refresh_LockedTooltip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Button_Refresh_LockedTooltip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
            Me.Button_Refresh_LockedTooltip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button_Refresh_LockedTooltip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button_Refresh_LockedTooltip.Location = New System.Drawing.Point(511, 201)
            Me.Button_Refresh_LockedTooltip.Name = "Button_Refresh_LockedTooltip"
            Me.Button_Refresh_LockedTooltip.Size = New System.Drawing.Size(64, 21)
            Me.Button_Refresh_LockedTooltip.TabIndex = 51
            Me.Button_Refresh_LockedTooltip.Text = "Refresh"
            Me.FormToolTip.SetToolTip(Me.Button_Refresh_LockedTooltip, "Update PString Display Name")
            Me.Button_Refresh_LockedTooltip.UseVisualStyleBackColor = False
            '
            'Select_Restrictions
            '
            Me.Select_Restrictions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Select_Restrictions.Enable_AfterItemChecked = False
            Me.Select_Restrictions.FormattingEnabled = True
            Me.Select_Restrictions.Location = New System.Drawing.Point(500, 38)
            Me.Select_Restrictions.Name = "Select_Restrictions"
            Me.Select_Restrictions.Size = New System.Drawing.Size(372, 123)
            Me.Select_Restrictions.TabIndex = 38
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.Black
            Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label18.ForeColor = System.Drawing.Color.White
            Me.Label18.Location = New System.Drawing.Point(3, 3)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(869, 17)
            Me.Label18.TabIndex = 37
            Me.Label18.Text = "General Restrictions :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(13, 35)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(98, 14)
            Me.Label11.TabIndex = 10
            Me.Label11.Text = "Allowed Origins :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(376, 38)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(118, 14)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Special Restrictions :"
            '
            'Select_Allowed_Origins
            '
            Me.Select_Allowed_Origins.Enable_AfterItemChecked = False
            Me.Select_Allowed_Origins.FormattingEnabled = True
            Me.Select_Allowed_Origins.Location = New System.Drawing.Point(117, 38)
            Me.Select_Allowed_Origins.Name = "Select_Allowed_Origins"
            Me.Select_Allowed_Origins.Size = New System.Drawing.Size(253, 123)
            Me.Select_Allowed_Origins.TabIndex = 20
            '
            'Edit_ProductCode
            '
            Me.Edit_ProductCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_ProductCode.Location = New System.Drawing.Point(117, 289)
            Me.Edit_ProductCode.Name = "Edit_ProductCode"
            Me.Edit_ProductCode.Size = New System.Drawing.Size(253, 22)
            Me.Edit_ProductCode.TabIndex = 33
            '
            'Edit_StoreRequires
            '
            Me.Edit_StoreRequires.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_StoreRequires.Location = New System.Drawing.Point(117, 316)
            Me.Edit_StoreRequires.Name = "Edit_StoreRequires"
            Me.Edit_StoreRequires.Size = New System.Drawing.Size(253, 22)
            Me.Edit_StoreRequires.TabIndex = 32
            '
            'Label16
            '
            Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label16.BackColor = System.Drawing.Color.Black
            Me.Label16.ForeColor = System.Drawing.Color.White
            Me.Label16.Location = New System.Drawing.Point(0, 175)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(872, 17)
            Me.Label16.TabIndex = 15
            Me.Label16.Text = "Store Restrictions :"
            '
            'Edit_Locked
            '
            Me.Edit_Locked.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Locked.Location = New System.Drawing.Point(117, 195)
            Me.Edit_Locked.Multiline = True
            Me.Edit_Locked.Name = "Edit_Locked"
            Me.Edit_Locked.Size = New System.Drawing.Size(253, 88)
            Me.Edit_Locked.TabIndex = 28
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(16, 318)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(95, 14)
            Me.Label10.TabIndex = 9
            Me.Label10.Text = "Store Requires :"
            '
            'Edit_LockedKey
            '
            Me.Edit_LockedKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_LockedKey.Location = New System.Drawing.Point(379, 201)
            Me.Edit_LockedKey.Name = "Edit_LockedKey"
            Me.Edit_LockedKey.ReadOnly = True
            Me.Edit_LockedKey.Size = New System.Drawing.Size(127, 22)
            Me.Edit_LockedKey.TabIndex = 27
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(21, 292)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(90, 14)
            Me.Label9.TabIndex = 8
            Me.Label9.Text = "Product Code :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(15, 201)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(96, 14)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Locked Tooltip :"
            '
            'TabPage5
            '
            Me.TabPage5.Controls.Add(Me.TabControl1)
            Me.TabPage5.Controls.Add(Me.Edit_Respecs)
            Me.TabPage5.Location = New System.Drawing.Point(4, 23)
            Me.TabPage5.Name = "TabPage5"
            Me.TabPage5.Size = New System.Drawing.Size(875, 375)
            Me.TabPage5.TabIndex = 2
            Me.TabPage5.Text = "Character Attributes (View Only)"
            Me.TabPage5.UseVisualStyleBackColor = True
            '
            'TabControl1
            '
            Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage8)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(875, 375)
            Me.TabControl1.TabIndex = 16
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.DodgerBlue
            Me.TabPage1.Controls.Add(Me.Edit_BaseAttributes)
            Me.TabPage1.Location = New System.Drawing.Point(26, 4)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(845, 367)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Single Level Attributes"
            '
            'Edit_BaseAttributes
            '
            Me.Edit_BaseAttributes.AllowUserToAddRows = False
            Me.Edit_BaseAttributes.AllowUserToDeleteRows = False
            Me.Edit_BaseAttributes.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Edit_BaseAttributes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.Edit_BaseAttributes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Edit_BaseAttributes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.Edit_BaseAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Edit_BaseAttributes.DefaultCellStyle = DataGridViewCellStyle3
            Me.Edit_BaseAttributes.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_BaseAttributes.Location = New System.Drawing.Point(3, 3)
            Me.Edit_BaseAttributes.MultiSelect = False
            Me.Edit_BaseAttributes.Name = "Edit_BaseAttributes"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Edit_BaseAttributes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.Edit_BaseAttributes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Edit_BaseAttributes.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.Edit_BaseAttributes.Size = New System.Drawing.Size(839, 361)
            Me.Edit_BaseAttributes.TabIndex = 3
            '
            'TabPage8
            '
            Me.TabPage8.BackColor = System.Drawing.Color.White
            Me.TabPage8.Controls.Add(Me.Edit_AttributesTable)
            Me.TabPage8.Controls.Add(Me.Label17)
            Me.TabPage8.Controls.Add(Me.Select_Attributes)
            Me.TabPage8.Location = New System.Drawing.Point(26, 4)
            Me.TabPage8.Name = "TabPage8"
            Me.TabPage8.Size = New System.Drawing.Size(845, 367)
            Me.TabPage8.TabIndex = 2
            Me.TabPage8.Text = "Level Range Tables"
            '
            'Edit_AttributesTable
            '
            Me.Edit_AttributesTable.AllowUserToAddRows = False
            Me.Edit_AttributesTable.AllowUserToDeleteRows = False
            Me.Edit_AttributesTable.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Edit_AttributesTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.Edit_AttributesTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Edit_AttributesTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.Edit_AttributesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Edit_AttributesTable.DefaultCellStyle = DataGridViewCellStyle8
            Me.Edit_AttributesTable.Location = New System.Drawing.Point(2, 32)
            Me.Edit_AttributesTable.MultiSelect = False
            Me.Edit_AttributesTable.Name = "Edit_AttributesTable"
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Edit_AttributesTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.Edit_AttributesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Edit_AttributesTable.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.Edit_AttributesTable.Size = New System.Drawing.Size(1259, 757)
            Me.Edit_AttributesTable.TabIndex = 4
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(3, 6)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(102, 16)
            Me.Label17.TabIndex = 1
            Me.Label17.Text = "Attribute Table :"
            '
            'Select_Attributes
            '
            Me.Select_Attributes.FormattingEnabled = True
            Me.Select_Attributes.Location = New System.Drawing.Point(111, 4)
            Me.Select_Attributes.Name = "Select_Attributes"
            Me.Select_Attributes.Size = New System.Drawing.Size(225, 24)
            Me.Select_Attributes.TabIndex = 2
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.Edit_NamedTable)
            Me.TabPage2.Controls.Add(Me.DataGridView3)
            Me.TabPage2.Location = New System.Drawing.Point(26, 4)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(845, 367)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Effect Table"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'Edit_NamedTable
            '
            Me.Edit_NamedTable.AllowUserToAddRows = False
            Me.Edit_NamedTable.AllowUserToDeleteRows = False
            Me.Edit_NamedTable.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Edit_NamedTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Edit_NamedTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.Edit_NamedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Edit_NamedTable.DefaultCellStyle = DataGridViewCellStyle13
            Me.Edit_NamedTable.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_NamedTable.Location = New System.Drawing.Point(3, 3)
            Me.Edit_NamedTable.MultiSelect = False
            Me.Edit_NamedTable.Name = "Edit_NamedTable"
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Edit_NamedTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
            Me.Edit_NamedTable.RowHeadersVisible = False
            Me.Edit_NamedTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Edit_NamedTable.RowsDefaultCellStyle = DataGridViewCellStyle15
            Me.Edit_NamedTable.Size = New System.Drawing.Size(839, 361)
            Me.Edit_NamedTable.TabIndex = 6
            '
            'DataGridView3
            '
            Me.DataGridView3.BackgroundColor = System.Drawing.Color.DodgerBlue
            Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGridView3.Location = New System.Drawing.Point(3, 3)
            Me.DataGridView3.Name = "DataGridView3"
            Me.DataGridView3.RowHeadersVisible = False
            Me.DataGridView3.Size = New System.Drawing.Size(839, 361)
            Me.DataGridView3.TabIndex = 5
            '
            'Edit_Respecs
            '
            Me.Edit_Respecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Respecs.Location = New System.Drawing.Point(405, 15)
            Me.Edit_Respecs.Name = "Edit_Respecs"
            Me.Edit_Respecs.Size = New System.Drawing.Size(0, 22)
            Me.Edit_Respecs.TabIndex = 38
            '
            'COH_CharacterClass_Editor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Name = "COH_CharacterClass_Editor"
            Me.Size = New System.Drawing.Size(897, 486)
            Me.TabPage12.ResumeLayout(False)
            Me.TabControl2.ResumeLayout(False)
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage6.ResumeLayout(False)
            Me.TabPage6.PerformLayout()
            CType(Me.Edit_Defiant, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage4.ResumeLayout(False)
            Me.TabPage4.PerformLayout()
            Me.TabPage5.ResumeLayout(False)
            Me.TabPage5.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            CType(Me.Edit_BaseAttributes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage8.ResumeLayout(False)
            Me.TabPage8.PerformLayout()
            CType(Me.Edit_AttributesTable, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.Edit_NamedTable, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As Label
        Friend WithEvents Edit_Icon As TextBox
        Friend WithEvents Edit_Help As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents Edit_Tooltip As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Select_Allowed_Origins As COH_CheckListBox
        Friend WithEvents Label8 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents Edit_BaseAttributes As DataGridView
        Friend WithEvents Select_Attributes As ComboBox
        Friend WithEvents Label17 As Label
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents Label10 As Label
        Friend WithEvents Label16 As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents Label15 As Label
        Friend WithEvents Label12 As Label
        Friend WithEvents Label14 As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents Edit_Locked As TextBox
        Friend WithEvents Edit_LockedKey As TextBox
        Friend WithEvents Edit_HelpKey As TextBox
        Friend WithEvents Edit_ToolTipKey As TextBox
        Friend WithEvents Button_Refresh_Tooltip As Button
        Friend WithEvents Edit_ProductCode As TextBox
        Friend WithEvents Edit_StoreRequires As TextBox
        Friend WithEvents Edit_ClassName As TextBox
        Friend WithEvents Label19 As Label
        Friend WithEvents DataGridView3 As DataGridView
        Friend WithEvents Edit_Respecs As TextBox
        Friend WithEvents Edit_DisplayNameKey As TextBox
        Friend WithEvents Edit_DisplayName As TextBox
        Friend WithEvents Label21 As Label
        Friend WithEvents Button6 As Button
        Friend WithEvents TabControl2 As TabControl
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents TabPage4 As TabPage
        Friend WithEvents TabPage5 As TabPage
        Friend WithEvents TabPage6 As TabPage
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents Label22 As Label
        Friend WithEvents Select_EpicPool As ComboBox
        Friend WithEvents Label20 As Label
        Friend WithEvents Label18 As Label
        Friend WithEvents Edit_ReduceAV As CheckBox
        Friend WithEvents Label7 As Label
        Friend WithEvents Edit_HPStatus As CheckBox
        Friend WithEvents Edit_Defiant As NumericUpDown
        Friend WithEvents Label2 As Label
        Friend WithEvents Select_Restrictions As COH_CheckListBox
        Friend WithEvents TabPage8 As TabPage
        Friend WithEvents Edit_AttributesTable As DataGridView
        Friend WithEvents Label6 As Label
        Friend WithEvents Edit_NamedTable As DataGridView
        Friend WithEvents Edit_RespecAtlevels As ListBox
        Friend WithEvents Button_Refresh_Help As Button
        Friend WithEvents Button_Refresh_DisplayName As Button
        Friend WithEvents Button_Refresh_LockedTooltip As Button
        Friend WithEvents Edit_Secondary As TextBox
        Friend WithEvents Edit_Primary As TextBox
        Friend WithEvents Select_Pool As ComboBox
        Friend WithEvents Edit_ReductionClass As TextBox
    End Class
End Namespace