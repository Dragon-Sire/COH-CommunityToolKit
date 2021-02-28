Imports COH.Tools.Controls
Imports COH.Toolkit.Controls.WinForms

Namespace Toolkit.Modding.Editors
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_PowerSet_Editor
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
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.Button_Refresh_Help = New System.Windows.Forms.Button()
            Me.Button_Refresh_DisplayName = New System.Windows.Forms.Button()
            Me.Edit_DisplayNameKey = New System.Windows.Forms.TextBox()
            Me.Button_Refresh_Tooltip = New System.Windows.Forms.Button()
            Me.Edit_ToolTipKey = New System.Windows.Forms.TextBox()
            Me.Edit_HelpKey = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Edit_FullName = New System.Windows.Forms.TextBox()
            Me.Edit_SourceFile = New System.Windows.Forms.TextBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Edit_Icon = New System.Windows.Forms.TextBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Edit_PowerSetName = New System.Windows.Forms.TextBox()
            Me.Edit_DisplayName = New System.Windows.Forms.TextBox()
            Me.Edit_Help = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Edit_ToolTip = New System.Windows.Forms.TextBox()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Edit_PowerTable = New System.Windows.Forms.DataGridView()
            Me.Select_PowerSystem = New System.Windows.Forms.ComboBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Edit_SpecializedReq = New System.Windows.Forms.ListBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Select_Inventory = New System.Windows.Forms.ComboBox()
            Me.Edit_Shared = New System.Windows.Forms.CheckBox()
            Me.Edit_SpecializedAt = New System.Windows.Forms.NumericUpDown()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Edit_ForceLevel = New System.Windows.Forms.NumericUpDown()
            Me.Edit_ShowManage = New System.Windows.Forms.CheckBox()
            Me.Edit_ShowInfo = New System.Windows.Forms.CheckBox()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.Button_Refresh_LockedTooltip = New System.Windows.Forms.Button()
            Me.Edit_LockedKey = New System.Windows.Forms.TextBox()
            Me.Edit_PurchaseRequirements = New System.Windows.Forms.ListBox()
            Me.Edit_PFail = New System.Windows.Forms.TextBox()
            Me.Button5 = New System.Windows.Forms.Button()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Edit_PurchaseFailed = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Edit_AccountToolTip = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Edit_Product = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Edit_AccountRequires = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.Edit_Costume_Parts = New System.Windows.Forms.ListBox()
            Me.Edit_Costume_Keys = New System.Windows.Forms.ListBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.TabPage12.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage3.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.Edit_PowerTable, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_SpecializedAt, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_ForceLevel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage4.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabPage12
            '
            Me.TabPage12.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.TabPage12.Controls.Add(Me.TabControl1)
            Me.TabPage12.Size = New System.Drawing.Size(889, 408)
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Controls.Add(Me.TabPage4)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!)
            Me.TabControl1.Location = New System.Drawing.Point(3, 3)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(883, 402)
            Me.TabControl1.TabIndex = 67
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.White
            Me.TabPage1.Controls.Add(Me.Button_Refresh_Help)
            Me.TabPage1.Controls.Add(Me.Button_Refresh_DisplayName)
            Me.TabPage1.Controls.Add(Me.Edit_DisplayNameKey)
            Me.TabPage1.Controls.Add(Me.Button_Refresh_Tooltip)
            Me.TabPage1.Controls.Add(Me.Edit_ToolTipKey)
            Me.TabPage1.Controls.Add(Me.Edit_HelpKey)
            Me.TabPage1.Controls.Add(Me.Label1)
            Me.TabPage1.Controls.Add(Me.Label5)
            Me.TabPage1.Controls.Add(Me.Edit_FullName)
            Me.TabPage1.Controls.Add(Me.Edit_SourceFile)
            Me.TabPage1.Controls.Add(Me.PictureBox1)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.Edit_Icon)
            Me.TabPage1.Controls.Add(Me.Label15)
            Me.TabPage1.Controls.Add(Me.Label2)
            Me.TabPage1.Controls.Add(Me.Label12)
            Me.TabPage1.Controls.Add(Me.Edit_PowerSetName)
            Me.TabPage1.Controls.Add(Me.Edit_DisplayName)
            Me.TabPage1.Controls.Add(Me.Edit_Help)
            Me.TabPage1.Controls.Add(Me.Label4)
            Me.TabPage1.Controls.Add(Me.Label3)
            Me.TabPage1.Controls.Add(Me.Edit_ToolTip)
            Me.TabPage1.Location = New System.Drawing.Point(4, 23)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(875, 375)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "General Details"
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
            Me.Button_Refresh_Help.Location = New System.Drawing.Point(805, 207)
            Me.Button_Refresh_Help.Name = "Button_Refresh_Help"
            Me.Button_Refresh_Help.Size = New System.Drawing.Size(63, 21)
            Me.Button_Refresh_Help.TabIndex = 78
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
            Me.Button_Refresh_DisplayName.Location = New System.Drawing.Point(806, 45)
            Me.Button_Refresh_DisplayName.Name = "Button_Refresh_DisplayName"
            Me.Button_Refresh_DisplayName.Size = New System.Drawing.Size(63, 21)
            Me.Button_Refresh_DisplayName.TabIndex = 77
            Me.Button_Refresh_DisplayName.Text = "Refresh"
            Me.FormToolTip.SetToolTip(Me.Button_Refresh_DisplayName, "Update PString Display Name")
            Me.Button_Refresh_DisplayName.UseVisualStyleBackColor = False
            '
            'Edit_DisplayNameKey
            '
            Me.Edit_DisplayNameKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_DisplayNameKey.Location = New System.Drawing.Point(676, 45)
            Me.Edit_DisplayNameKey.Name = "Edit_DisplayNameKey"
            Me.Edit_DisplayNameKey.ReadOnly = True
            Me.Edit_DisplayNameKey.Size = New System.Drawing.Size(127, 22)
            Me.Edit_DisplayNameKey.TabIndex = 76
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
            Me.Button_Refresh_Tooltip.Location = New System.Drawing.Point(805, 154)
            Me.Button_Refresh_Tooltip.Name = "Button_Refresh_Tooltip"
            Me.Button_Refresh_Tooltip.Size = New System.Drawing.Size(63, 21)
            Me.Button_Refresh_Tooltip.TabIndex = 75
            Me.Button_Refresh_Tooltip.Text = "Refresh"
            Me.FormToolTip.SetToolTip(Me.Button_Refresh_Tooltip, "Update PString Tooltip")
            Me.Button_Refresh_Tooltip.UseVisualStyleBackColor = False
            '
            'Edit_ToolTipKey
            '
            Me.Edit_ToolTipKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_ToolTipKey.Location = New System.Drawing.Point(675, 154)
            Me.Edit_ToolTipKey.Name = "Edit_ToolTipKey"
            Me.Edit_ToolTipKey.ReadOnly = True
            Me.Edit_ToolTipKey.Size = New System.Drawing.Size(127, 22)
            Me.Edit_ToolTipKey.TabIndex = 73
            '
            'Edit_HelpKey
            '
            Me.Edit_HelpKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_HelpKey.Location = New System.Drawing.Point(676, 206)
            Me.Edit_HelpKey.Name = "Edit_HelpKey"
            Me.Edit_HelpKey.ReadOnly = True
            Me.Edit_HelpKey.Size = New System.Drawing.Size(127, 22)
            Me.Edit_HelpKey.TabIndex = 74
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(44, 105)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(67, 14)
            Me.Label1.TabIndex = 68
            Me.Label1.Text = "Full Name :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(2, 127)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(109, 14)
            Me.Label5.TabIndex = 67
            Me.Label5.Text = "Source File (DEF) :"
            '
            'Edit_FullName
            '
            Me.Edit_FullName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_FullName.Location = New System.Drawing.Point(117, 102)
            Me.Edit_FullName.Name = "Edit_FullName"
            Me.Edit_FullName.Size = New System.Drawing.Size(552, 22)
            Me.Edit_FullName.TabIndex = 69
            '
            'Edit_SourceFile
            '
            Me.Edit_SourceFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_SourceFile.Location = New System.Drawing.Point(117, 126)
            Me.Edit_SourceFile.Name = "Edit_SourceFile"
            Me.Edit_SourceFile.Size = New System.Drawing.Size(552, 22)
            Me.Edit_SourceFile.TabIndex = 70
            '
            'PictureBox1
            '
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(117, 73)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
            Me.PictureBox1.TabIndex = 66
            Me.PictureBox1.TabStop = False
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(72, 74)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(39, 14)
            Me.Label7.TabIndex = 64
            Me.Label7.Text = "Icon :"
            '
            'Edit_Icon
            '
            Me.Edit_Icon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Icon.Location = New System.Drawing.Point(145, 73)
            Me.Edit_Icon.Name = "Edit_Icon"
            Me.Edit_Icon.Size = New System.Drawing.Size(524, 22)
            Me.Edit_Icon.TabIndex = 65
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(7, 24)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(104, 14)
            Me.Label15.TabIndex = 33
            Me.Label15.Text = "PowerSet Name :"
            '
            'Label2
            '
            Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.Black
            Me.Label2.ForeColor = System.Drawing.Color.White
            Me.Label2.Location = New System.Drawing.Point(0, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(875, 18)
            Me.Label2.TabIndex = 48
            Me.Label2.Text = "General Details :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(25, 49)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(86, 14)
            Me.Label12.TabIndex = 32
            Me.Label12.Text = "Display Name :"
            '
            'Edit_PowerSetName
            '
            Me.Edit_PowerSetName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_PowerSetName.Location = New System.Drawing.Point(117, 21)
            Me.Edit_PowerSetName.Name = "Edit_PowerSetName"
            Me.Edit_PowerSetName.ReadOnly = True
            Me.Edit_PowerSetName.Size = New System.Drawing.Size(552, 22)
            Me.Edit_PowerSetName.TabIndex = 35
            '
            'Edit_DisplayName
            '
            Me.Edit_DisplayName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_DisplayName.Location = New System.Drawing.Point(117, 45)
            Me.Edit_DisplayName.Name = "Edit_DisplayName"
            Me.Edit_DisplayName.Size = New System.Drawing.Size(552, 22)
            Me.Edit_DisplayName.TabIndex = 36
            '
            'Edit_Help
            '
            Me.Edit_Help.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Help.Location = New System.Drawing.Point(117, 206)
            Me.Edit_Help.Multiline = True
            Me.Edit_Help.Name = "Edit_Help"
            Me.Edit_Help.Size = New System.Drawing.Size(552, 113)
            Me.Edit_Help.TabIndex = 44
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(72, 230)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(39, 14)
            Me.Label4.TabIndex = 50
            Me.Label4.Text = "Help :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(16, 158)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(95, 14)
            Me.Label3.TabIndex = 49
            Me.Label3.Text = "Mouse ToolTip :"
            '
            'Edit_ToolTip
            '
            Me.Edit_ToolTip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_ToolTip.Location = New System.Drawing.Point(117, 154)
            Me.Edit_ToolTip.Multiline = True
            Me.Edit_ToolTip.Name = "Edit_ToolTip"
            Me.Edit_ToolTip.Size = New System.Drawing.Size(552, 46)
            Me.Edit_ToolTip.TabIndex = 43
            '
            'TabPage3
            '
            Me.TabPage3.BackColor = System.Drawing.Color.White
            Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
            Me.TabPage3.Location = New System.Drawing.Point(4, 23)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Size = New System.Drawing.Size(875, 375)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Powers"
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 4
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_PowerTable, 1, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.Select_PowerSystem, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Label21, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_SpecializedReq, 1, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.Label23, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.Label24, 2, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Select_Inventory, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_Shared, 3, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_SpecializedAt, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Label22, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_ForceLevel, 3, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_ShowManage, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_ShowInfo, 1, 4)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 7
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(875, 375)
            Me.TableLayoutPanel1.TabIndex = 78
            '
            'Label20
            '
            Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label20.Location = New System.Drawing.Point(3, 0)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(194, 28)
            Me.Label20.TabIndex = 59
            Me.Label20.Text = "Power System :"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_PowerTable
            '
            Me.Edit_PowerTable.AllowUserToAddRows = False
            Me.Edit_PowerTable.AllowUserToDeleteRows = False
            Me.Edit_PowerTable.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Edit_PowerTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.Edit_PowerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Edit_PowerTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.Edit_PowerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.TableLayoutPanel1.SetColumnSpan(Me.Edit_PowerTable, 3)
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Edit_PowerTable.DefaultCellStyle = DataGridViewCellStyle3
            Me.Edit_PowerTable.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_PowerTable.Location = New System.Drawing.Point(203, 257)
            Me.Edit_PowerTable.MultiSelect = False
            Me.Edit_PowerTable.Name = "Edit_PowerTable"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Edit_PowerTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.Edit_PowerTable.RowHeadersVisible = False
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Edit_PowerTable.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.Edit_PowerTable.Size = New System.Drawing.Size(669, 115)
            Me.Edit_PowerTable.TabIndex = 75
            '
            'Select_PowerSystem
            '
            Me.Select_PowerSystem.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Select_PowerSystem.FormattingEnabled = True
            Me.Select_PowerSystem.Location = New System.Drawing.Point(203, 3)
            Me.Select_PowerSystem.Name = "Select_PowerSystem"
            Me.Select_PowerSystem.Size = New System.Drawing.Size(219, 22)
            Me.Select_PowerSystem.TabIndex = 60
            '
            'Label21
            '
            Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label21.Location = New System.Drawing.Point(3, 254)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(194, 121)
            Me.Label21.TabIndex = 69
            Me.Label21.Text = "Powers :"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Edit_SpecializedReq
            '
            Me.TableLayoutPanel1.SetColumnSpan(Me.Edit_SpecializedReq, 2)
            Me.Edit_SpecializedReq.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_SpecializedReq.FormattingEnabled = True
            Me.Edit_SpecializedReq.ItemHeight = 14
            Me.Edit_SpecializedReq.Location = New System.Drawing.Point(203, 111)
            Me.Edit_SpecializedReq.Name = "Edit_SpecializedReq"
            Me.Edit_SpecializedReq.Size = New System.Drawing.Size(444, 140)
            Me.Edit_SpecializedReq.TabIndex = 73
            '
            'Label23
            '
            Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label23.Location = New System.Drawing.Point(3, 108)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(194, 146)
            Me.Label23.TabIndex = 74
            Me.Label23.Text = "Specialized Requirements :"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label24
            '
            Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label24.Location = New System.Drawing.Point(428, 56)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(219, 28)
            Me.Label24.TabIndex = 76
            Me.Label24.Text = "Force Level Bought :"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label19
            '
            Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label19.Location = New System.Drawing.Point(3, 28)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(194, 28)
            Me.Label19.TabIndex = 58
            Me.Label19.Text = "Show In Inventory :"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Select_Inventory
            '
            Me.Select_Inventory.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Select_Inventory.FormattingEnabled = True
            Me.Select_Inventory.Location = New System.Drawing.Point(203, 31)
            Me.Select_Inventory.Name = "Select_Inventory"
            Me.Select_Inventory.Size = New System.Drawing.Size(219, 22)
            Me.Select_Inventory.TabIndex = 61
            '
            'Edit_Shared
            '
            Me.Edit_Shared.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Edit_Shared.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Shared.Location = New System.Drawing.Point(653, 3)
            Me.Edit_Shared.Name = "Edit_Shared"
            Me.Edit_Shared.Size = New System.Drawing.Size(219, 22)
            Me.Edit_Shared.TabIndex = 65
            Me.Edit_Shared.Text = "Shared :"
            Me.Edit_Shared.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Edit_Shared.UseVisualStyleBackColor = True
            '
            'Edit_SpecializedAt
            '
            Me.Edit_SpecializedAt.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_SpecializedAt.Location = New System.Drawing.Point(203, 59)
            Me.Edit_SpecializedAt.Name = "Edit_SpecializedAt"
            Me.Edit_SpecializedAt.Size = New System.Drawing.Size(219, 22)
            Me.Edit_SpecializedAt.TabIndex = 72
            '
            'Label22
            '
            Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label22.Location = New System.Drawing.Point(3, 56)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(194, 28)
            Me.Label22.TabIndex = 71
            Me.Label22.Text = "Specialized At :"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_ForceLevel
            '
            Me.Edit_ForceLevel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_ForceLevel.Location = New System.Drawing.Point(653, 59)
            Me.Edit_ForceLevel.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_ForceLevel.Name = "Edit_ForceLevel"
            Me.Edit_ForceLevel.Size = New System.Drawing.Size(219, 22)
            Me.Edit_ForceLevel.TabIndex = 77
            '
            'Edit_ShowManage
            '
            Me.Edit_ShowManage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Edit_ShowManage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_ShowManage.Location = New System.Drawing.Point(3, 87)
            Me.Edit_ShowManage.Name = "Edit_ShowManage"
            Me.Edit_ShowManage.Size = New System.Drawing.Size(194, 18)
            Me.Edit_ShowManage.TabIndex = 64
            Me.Edit_ShowManage.Text = "Show In Manage :"
            Me.Edit_ShowManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Edit_ShowManage.UseVisualStyleBackColor = True
            '
            'Edit_ShowInfo
            '
            Me.Edit_ShowInfo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Edit_ShowInfo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_ShowInfo.Location = New System.Drawing.Point(203, 87)
            Me.Edit_ShowInfo.Name = "Edit_ShowInfo"
            Me.Edit_ShowInfo.Size = New System.Drawing.Size(219, 18)
            Me.Edit_ShowInfo.TabIndex = 66
            Me.Edit_ShowInfo.Text = "Show In Info :"
            Me.Edit_ShowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Edit_ShowInfo.UseVisualStyleBackColor = True
            '
            'TabPage4
            '
            Me.TabPage4.BackColor = System.Drawing.Color.White
            Me.TabPage4.Controls.Add(Me.Button_Refresh_LockedTooltip)
            Me.TabPage4.Controls.Add(Me.Edit_LockedKey)
            Me.TabPage4.Controls.Add(Me.Edit_PurchaseRequirements)
            Me.TabPage4.Controls.Add(Me.Edit_PFail)
            Me.TabPage4.Controls.Add(Me.Button5)
            Me.TabPage4.Controls.Add(Me.Label16)
            Me.TabPage4.Controls.Add(Me.Edit_PurchaseFailed)
            Me.TabPage4.Controls.Add(Me.Label17)
            Me.TabPage4.Controls.Add(Me.Label13)
            Me.TabPage4.Controls.Add(Me.Label11)
            Me.TabPage4.Controls.Add(Me.Edit_AccountToolTip)
            Me.TabPage4.Controls.Add(Me.Label10)
            Me.TabPage4.Controls.Add(Me.Edit_Product)
            Me.TabPage4.Controls.Add(Me.Label9)
            Me.TabPage4.Controls.Add(Me.Edit_AccountRequires)
            Me.TabPage4.Controls.Add(Me.Label8)
            Me.TabPage4.Location = New System.Drawing.Point(4, 23)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage4.Size = New System.Drawing.Size(875, 375)
            Me.TabPage4.TabIndex = 3
            Me.TabPage4.Text = "Requirements"
            '
            'Button_Refresh_LockedTooltip
            '
            Me.Button_Refresh_LockedTooltip.BackColor = System.Drawing.Color.White
            Me.Button_Refresh_LockedTooltip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button_Refresh_LockedTooltip.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button_Refresh_LockedTooltip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Button_Refresh_LockedTooltip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
            Me.Button_Refresh_LockedTooltip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button_Refresh_LockedTooltip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button_Refresh_LockedTooltip.Location = New System.Drawing.Point(620, 102)
            Me.Button_Refresh_LockedTooltip.Name = "Button_Refresh_LockedTooltip"
            Me.Button_Refresh_LockedTooltip.Size = New System.Drawing.Size(64, 21)
            Me.Button_Refresh_LockedTooltip.TabIndex = 68
            Me.Button_Refresh_LockedTooltip.Text = "Refresh"
            Me.FormToolTip.SetToolTip(Me.Button_Refresh_LockedTooltip, "Update PString Display Name")
            Me.Button_Refresh_LockedTooltip.UseVisualStyleBackColor = False
            '
            'Edit_LockedKey
            '
            Me.Edit_LockedKey.Location = New System.Drawing.Point(488, 102)
            Me.Edit_LockedKey.Name = "Edit_LockedKey"
            Me.Edit_LockedKey.ReadOnly = True
            Me.Edit_LockedKey.Size = New System.Drawing.Size(127, 22)
            Me.Edit_LockedKey.TabIndex = 67
            '
            'Edit_PurchaseRequirements
            '
            Me.Edit_PurchaseRequirements.FormattingEnabled = True
            Me.Edit_PurchaseRequirements.ItemHeight = 14
            Me.Edit_PurchaseRequirements.Location = New System.Drawing.Point(134, 275)
            Me.Edit_PurchaseRequirements.Name = "Edit_PurchaseRequirements"
            Me.Edit_PurchaseRequirements.Size = New System.Drawing.Size(549, 88)
            Me.Edit_PurchaseRequirements.TabIndex = 66
            '
            'Edit_PFail
            '
            Me.Edit_PFail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_PFail.Location = New System.Drawing.Point(-1621, 382)
            Me.Edit_PFail.Name = "Edit_PFail"
            Me.Edit_PFail.ReadOnly = True
            Me.Edit_PFail.Size = New System.Drawing.Size(148, 22)
            Me.Edit_PFail.TabIndex = 65
            '
            'Button5
            '
            Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button5.Location = New System.Drawing.Point(-1467, 382)
            Me.Button5.Name = "Button5"
            Me.Button5.Size = New System.Drawing.Size(26, 22)
            Me.Button5.TabIndex = 64
            Me.Button5.UseVisualStyleBackColor = True
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(29, 385)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(98, 14)
            Me.Label16.TabIndex = 59
            Me.Label16.Text = "Purchase Failed :"
            '
            'Edit_PurchaseFailed
            '
            Me.Edit_PurchaseFailed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_PurchaseFailed.Location = New System.Drawing.Point(134, 382)
            Me.Edit_PurchaseFailed.Multiline = True
            Me.Edit_PurchaseFailed.Name = "Edit_PurchaseFailed"
            Me.Edit_PurchaseFailed.ReadOnly = True
            Me.Edit_PurchaseFailed.Size = New System.Drawing.Size(0, 95)
            Me.Edit_PurchaseFailed.TabIndex = 60
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(17, 273)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(114, 14)
            Me.Label17.TabIndex = 57
            Me.Label17.Text = "Purchase Requires :"
            '
            'Label13
            '
            Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label13.BackColor = System.Drawing.Color.Black
            Me.Label13.ForeColor = System.Drawing.Color.White
            Me.Label13.Location = New System.Drawing.Point(0, 249)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(875, 18)
            Me.Label13.TabIndex = 56
            Me.Label13.Text = "Purchase Requirements :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(16, 117)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(110, 14)
            Me.Label11.TabIndex = 54
            Me.Label11.Text = "Account Tool Tip :"
            '
            'Edit_AccountToolTip
            '
            Me.Edit_AccountToolTip.Location = New System.Drawing.Point(134, 102)
            Me.Edit_AccountToolTip.Multiline = True
            Me.Edit_AccountToolTip.Name = "Edit_AccountToolTip"
            Me.Edit_AccountToolTip.ReadOnly = True
            Me.Edit_AccountToolTip.Size = New System.Drawing.Size(348, 78)
            Me.Edit_AccountToolTip.TabIndex = 55
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(19, 46)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(108, 14)
            Me.Label10.TabIndex = 52
            Me.Label10.Text = "Account Product :"
            '
            'Edit_Product
            '
            Me.Edit_Product.Location = New System.Drawing.Point(133, 43)
            Me.Edit_Product.Name = "Edit_Product"
            Me.Edit_Product.ReadOnly = True
            Me.Edit_Product.Size = New System.Drawing.Size(348, 22)
            Me.Edit_Product.TabIndex = 53
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(16, 74)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(111, 14)
            Me.Label9.TabIndex = 50
            Me.Label9.Text = "Account Requires :"
            '
            'Edit_AccountRequires
            '
            Me.Edit_AccountRequires.Location = New System.Drawing.Point(133, 71)
            Me.Edit_AccountRequires.Multiline = True
            Me.Edit_AccountRequires.Name = "Edit_AccountRequires"
            Me.Edit_AccountRequires.ReadOnly = True
            Me.Edit_AccountRequires.Size = New System.Drawing.Size(348, 25)
            Me.Edit_AccountRequires.TabIndex = 51
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Black
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label8.ForeColor = System.Drawing.Color.White
            Me.Label8.Location = New System.Drawing.Point(3, 3)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(869, 18)
            Me.Label8.TabIndex = 49
            Me.Label8.Text = "Account Requirements :"
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.White
            Me.TabPage2.Controls.Add(Me.Edit_Costume_Parts)
            Me.TabPage2.Controls.Add(Me.Edit_Costume_Keys)
            Me.TabPage2.Controls.Add(Me.Label18)
            Me.TabPage2.Controls.Add(Me.Label6)
            Me.TabPage2.Controls.Add(Me.Label14)
            Me.TabPage2.Location = New System.Drawing.Point(4, 23)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(875, 375)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Costume"
            '
            'Edit_Costume_Parts
            '
            Me.Edit_Costume_Parts.FormattingEnabled = True
            Me.Edit_Costume_Parts.ItemHeight = 14
            Me.Edit_Costume_Parts.Location = New System.Drawing.Point(118, 197)
            Me.Edit_Costume_Parts.Name = "Edit_Costume_Parts"
            Me.Edit_Costume_Parts.Size = New System.Drawing.Size(525, 158)
            Me.Edit_Costume_Parts.TabIndex = 68
            '
            'Edit_Costume_Keys
            '
            Me.Edit_Costume_Keys.FormattingEnabled = True
            Me.Edit_Costume_Keys.ItemHeight = 14
            Me.Edit_Costume_Keys.Location = New System.Drawing.Point(117, 33)
            Me.Edit_Costume_Keys.Name = "Edit_Costume_Keys"
            Me.Edit_Costume_Keys.Size = New System.Drawing.Size(525, 144)
            Me.Edit_Costume_Keys.TabIndex = 67
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.Black
            Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label18.ForeColor = System.Drawing.Color.White
            Me.Label18.Location = New System.Drawing.Point(3, 3)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(869, 18)
            Me.Label18.TabIndex = 58
            Me.Label18.Text = "Costume Parts :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(22, 33)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(88, 14)
            Me.Label6.TabIndex = 51
            Me.Label6.Text = "CostumeKeys :"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(18, 197)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(94, 14)
            Me.Label14.TabIndex = 52
            Me.Label14.Text = "Costume Parts :"
            '
            'COH_PowerSet_Editor
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Name = "COH_PowerSet_Editor"
            Me.Size = New System.Drawing.Size(897, 486)
            Me.TabPage12.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage3.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.Edit_PowerTable, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_SpecializedAt, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_ForceLevel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage4.ResumeLayout(False)
            Me.TabPage4.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents Label1 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Edit_FullName As TextBox
        Friend WithEvents Edit_SourceFile As TextBox
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents Label7 As Label
        Friend WithEvents Edit_Icon As TextBox
        Friend WithEvents Label15 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label12 As Label
        Friend WithEvents Edit_PowerSetName As TextBox
        Friend WithEvents Edit_DisplayName As TextBox
        Friend WithEvents Edit_Help As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Edit_ToolTip As TextBox
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents Edit_ForceLevel As NumericUpDown
        Friend WithEvents Label24 As Label
        Friend WithEvents Edit_PowerTable As DataGridView
        Friend WithEvents Label23 As Label
        Friend WithEvents Edit_SpecializedReq As ListBox
        Friend WithEvents Edit_SpecializedAt As NumericUpDown
        Friend WithEvents Label22 As Label
        Friend WithEvents Label21 As Label
        Friend WithEvents Edit_Shared As CheckBox
        Friend WithEvents Select_PowerSystem As ComboBox
        Friend WithEvents Label19 As Label
        Friend WithEvents Label20 As Label
        Friend WithEvents Select_Inventory As ComboBox
        Friend WithEvents TabPage4 As TabPage
        Friend WithEvents Edit_PurchaseRequirements As ListBox
        Friend WithEvents Edit_PFail As TextBox
        Friend WithEvents Button5 As Button
        Friend WithEvents Label16 As Label
        Friend WithEvents Edit_PurchaseFailed As TextBox
        Friend WithEvents Label17 As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents Edit_AccountToolTip As TextBox
        Friend WithEvents Label10 As Label
        Friend WithEvents Edit_Product As TextBox
        Friend WithEvents Label9 As Label
        Friend WithEvents Edit_AccountRequires As TextBox
        Friend WithEvents Label8 As Label
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents Edit_Costume_Parts As ListBox
        Friend WithEvents Edit_Costume_Keys As ListBox
        Friend WithEvents Label18 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label14 As Label
        Friend WithEvents Button_Refresh_Help As Button
        Friend WithEvents Button_Refresh_DisplayName As Button
        Friend WithEvents Edit_DisplayNameKey As TextBox
        Friend WithEvents Button_Refresh_Tooltip As Button
        Friend WithEvents Edit_ToolTipKey As TextBox
        Friend WithEvents Edit_HelpKey As TextBox
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents Edit_ShowManage As CheckBox
        Friend WithEvents Edit_ShowInfo As CheckBox
        Friend WithEvents Button_Refresh_LockedTooltip As Button
        Friend WithEvents Edit_LockedKey As TextBox
    End Class
End Namespace