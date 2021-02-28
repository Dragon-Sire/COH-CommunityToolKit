Imports COH.Toolkit.Controls.WinForms
Imports COH.Toolkit.Controls.WinForms.UserControls

Namespace Toolkit.Modding.Editors
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_ModdableContent_Editor
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
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
            Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
            Me.ExportCurrentAsXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportCurrentAsDEFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.XMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DontWriteDefaultsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.DontWriteEmptyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.DontWriteDebugToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.DEFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DontWriteDefaultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DontWriteEmptyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DontWriteDebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Edit_IsCustom = New System.Windows.Forms.CheckBox()
            Me.Edit_WasModified = New System.Windows.Forms.CheckBox()
            Me.Button_UpdatePreview = New System.Windows.Forms.Button()
            Me.Image_Locked = New System.Windows.Forms.PictureBox()
            Me.Button_Undo = New System.Windows.Forms.Button()
            Me.Edit_Current_Editing = New System.Windows.Forms.Label()
            Me.Button_Save = New System.Windows.Forms.Button()
            Me.TabControl3 = New System.Windows.Forms.TabControl()
            Me.TabPage12 = New System.Windows.Forms.TabPage()
            Me.TabPage11 = New System.Windows.Forms.TabPage()
            Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.TabPage10 = New System.Windows.Forms.TabPage()
            Me.XML_View2 = New COH.Toolkit.Controls.WinForms.UserControls.COH_XML_Viewer()
            Me.TabPage13 = New System.Windows.Forms.TabPage()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.ToolStrip1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.Image_Locked, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl3.SuspendLayout()
            Me.TabPage11.SuspendLayout()
            Me.TabPage10.SuspendLayout()
            Me.TabPage13.SuspendLayout()
            Me.SuspendLayout()
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton1})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(1107, 25)
            Me.ToolStrip1.TabIndex = 48
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'ToolStripButton1
            '
            Me.ToolStripButton1.Enabled = False
            Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton1.Name = "ToolStripButton1"
            Me.ToolStripButton1.Size = New System.Drawing.Size(132, 22)
            Me.ToolStripButton1.Text = "Create New (Template)"
            '
            'ToolStripDropDownButton2
            '
            Me.ToolStripDropDownButton2.Enabled = False
            Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
            Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(56, 22)
            Me.ToolStripDropDownButton2.Text = "Import"
            '
            'ToolStripDropDownButton1
            '
            Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportCurrentAsXMLToolStripMenuItem, Me.ExportCurrentAsDEFToolStripMenuItem, Me.ToolStripSeparator1, Me.OptionsToolStripMenuItem})
            Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
            Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(53, 22)
            Me.ToolStripDropDownButton1.Text = "Export"
            '
            'ExportCurrentAsXMLToolStripMenuItem
            '
            Me.ExportCurrentAsXMLToolStripMenuItem.Name = "ExportCurrentAsXMLToolStripMenuItem"
            Me.ExportCurrentAsXMLToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
            Me.ExportCurrentAsXMLToolStripMenuItem.Text = "Export Current as XML"
            '
            'ExportCurrentAsDEFToolStripMenuItem
            '
            Me.ExportCurrentAsDEFToolStripMenuItem.Name = "ExportCurrentAsDEFToolStripMenuItem"
            Me.ExportCurrentAsDEFToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
            Me.ExportCurrentAsDEFToolStripMenuItem.Text = "Export Current as DEF"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
            '
            'OptionsToolStripMenuItem
            '
            Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XMLToolStripMenuItem, Me.DEFToolStripMenuItem})
            Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
            Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
            Me.OptionsToolStripMenuItem.Text = "Options"
            '
            'XMLToolStripMenuItem
            '
            Me.XMLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DontWriteDefaultsToolStripMenuItem1, Me.DontWriteEmptyToolStripMenuItem1, Me.DontWriteDebugToolStripMenuItem1})
            Me.XMLToolStripMenuItem.Name = "XMLToolStripMenuItem"
            Me.XMLToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.XMLToolStripMenuItem.Text = "XML"
            '
            'DontWriteDefaultsToolStripMenuItem1
            '
            Me.DontWriteDefaultsToolStripMenuItem1.CheckOnClick = True
            Me.DontWriteDefaultsToolStripMenuItem1.Name = "DontWriteDefaultsToolStripMenuItem1"
            Me.DontWriteDefaultsToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
            Me.DontWriteDefaultsToolStripMenuItem1.Text = "Don't Write Defaults"
            '
            'DontWriteEmptyToolStripMenuItem1
            '
            Me.DontWriteEmptyToolStripMenuItem1.CheckOnClick = True
            Me.DontWriteEmptyToolStripMenuItem1.Name = "DontWriteEmptyToolStripMenuItem1"
            Me.DontWriteEmptyToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
            Me.DontWriteEmptyToolStripMenuItem1.Text = "Don't Write Empty"
            '
            'DontWriteDebugToolStripMenuItem1
            '
            Me.DontWriteDebugToolStripMenuItem1.Checked = True
            Me.DontWriteDebugToolStripMenuItem1.CheckOnClick = True
            Me.DontWriteDebugToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.DontWriteDebugToolStripMenuItem1.Name = "DontWriteDebugToolStripMenuItem1"
            Me.DontWriteDebugToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
            Me.DontWriteDebugToolStripMenuItem1.Text = "Don't Write Debug"
            '
            'DEFToolStripMenuItem
            '
            Me.DEFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DontWriteDefaultsToolStripMenuItem, Me.DontWriteEmptyToolStripMenuItem, Me.DontWriteDebugToolStripMenuItem})
            Me.DEFToolStripMenuItem.Name = "DEFToolStripMenuItem"
            Me.DEFToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.DEFToolStripMenuItem.Text = "DEF"
            '
            'DontWriteDefaultsToolStripMenuItem
            '
            Me.DontWriteDefaultsToolStripMenuItem.Checked = True
            Me.DontWriteDefaultsToolStripMenuItem.CheckOnClick = True
            Me.DontWriteDefaultsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.DontWriteDefaultsToolStripMenuItem.Name = "DontWriteDefaultsToolStripMenuItem"
            Me.DontWriteDefaultsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.DontWriteDefaultsToolStripMenuItem.Text = "Don't Write Defaults"
            '
            'DontWriteEmptyToolStripMenuItem
            '
            Me.DontWriteEmptyToolStripMenuItem.Checked = True
            Me.DontWriteEmptyToolStripMenuItem.CheckOnClick = True
            Me.DontWriteEmptyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.DontWriteEmptyToolStripMenuItem.Name = "DontWriteEmptyToolStripMenuItem"
            Me.DontWriteEmptyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.DontWriteEmptyToolStripMenuItem.Text = "Don't Write Empty"
            '
            'DontWriteDebugToolStripMenuItem
            '
            Me.DontWriteDebugToolStripMenuItem.Checked = True
            Me.DontWriteDebugToolStripMenuItem.CheckOnClick = True
            Me.DontWriteDebugToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.DontWriteDebugToolStripMenuItem.Name = "DontWriteDebugToolStripMenuItem"
            Me.DontWriteDebugToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.DontWriteDebugToolStripMenuItem.Text = "Don't Write Debug"
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Panel1.Controls.Add(Me.Edit_IsCustom)
            Me.Panel1.Controls.Add(Me.Edit_WasModified)
            Me.Panel1.Controls.Add(Me.Button_UpdatePreview)
            Me.Panel1.Controls.Add(Me.Image_Locked)
            Me.Panel1.Controls.Add(Me.Button_Undo)
            Me.Panel1.Controls.Add(Me.Edit_Current_Editing)
            Me.Panel1.Controls.Add(Me.Button_Save)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 672)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1107, 25)
            Me.Panel1.TabIndex = 49
            '
            'Edit_IsCustom
            '
            Me.Edit_IsCustom.AutoSize = True
            Me.Edit_IsCustom.BackColor = System.Drawing.Color.Transparent
            Me.Edit_IsCustom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Edit_IsCustom.Enabled = False
            Me.Edit_IsCustom.ForeColor = System.Drawing.Color.White
            Me.Edit_IsCustom.Location = New System.Drawing.Point(35, 5)
            Me.Edit_IsCustom.Name = "Edit_IsCustom"
            Me.Edit_IsCustom.Size = New System.Drawing.Size(124, 18)
            Me.Edit_IsCustom.TabIndex = 55
            Me.Edit_IsCustom.Text = "Custom Content :"
            Me.Edit_IsCustom.UseVisualStyleBackColor = False
            '
            'Edit_WasModified
            '
            Me.Edit_WasModified.AutoSize = True
            Me.Edit_WasModified.BackColor = System.Drawing.Color.Transparent
            Me.Edit_WasModified.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Edit_WasModified.Enabled = False
            Me.Edit_WasModified.ForeColor = System.Drawing.Color.White
            Me.Edit_WasModified.Location = New System.Drawing.Point(179, 5)
            Me.Edit_WasModified.Name = "Edit_WasModified"
            Me.Edit_WasModified.Size = New System.Drawing.Size(152, 18)
            Me.Edit_WasModified.TabIndex = 54
            Me.Edit_WasModified.Text = "Modified From Source :"
            Me.Edit_WasModified.UseVisualStyleBackColor = False
            '
            'Button_UpdatePreview
            '
            Me.Button_UpdatePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button_UpdatePreview.Location = New System.Drawing.Point(817, 3)
            Me.Button_UpdatePreview.Name = "Button_UpdatePreview"
            Me.Button_UpdatePreview.Size = New System.Drawing.Size(101, 21)
            Me.Button_UpdatePreview.TabIndex = 53
            Me.Button_UpdatePreview.Text = "Update Previews"
            Me.Button_UpdatePreview.UseVisualStyleBackColor = True
            '
            'Image_Locked
            '
            Me.Image_Locked.BackgroundImage = My.Resources.Button_Locked
            Me.Image_Locked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Image_Locked.Location = New System.Drawing.Point(3, 2)
            Me.Image_Locked.Name = "Image_Locked"
            Me.Image_Locked.Size = New System.Drawing.Size(26, 22)
            Me.Image_Locked.TabIndex = 52
            Me.Image_Locked.TabStop = False
            Me.FormToolTip.SetToolTip(Me.Image_Locked, "Lock / Unlock Restricted Editing")
            '
            'Button_Undo
            '
            Me.Button_Undo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button_Undo.Location = New System.Drawing.Point(923, 3)
            Me.Button_Undo.Name = "Button_Undo"
            Me.Button_Undo.Size = New System.Drawing.Size(84, 21)
            Me.Button_Undo.TabIndex = 48
            Me.Button_Undo.Text = "UNDO"
            Me.Button_Undo.UseVisualStyleBackColor = True
            '
            'Edit_Current_Editing
            '
            Me.Edit_Current_Editing.AutoSize = True
            Me.Edit_Current_Editing.ForeColor = System.Drawing.Color.White
            Me.Edit_Current_Editing.Location = New System.Drawing.Point(337, 7)
            Me.Edit_Current_Editing.Name = "Edit_Current_Editing"
            Me.Edit_Current_Editing.Size = New System.Drawing.Size(130, 14)
            Me.Edit_Current_Editing.TabIndex = 47
            Me.Edit_Current_Editing.Text = "Currently Editing : N/A"
            '
            'Button_Save
            '
            Me.Button_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button_Save.Location = New System.Drawing.Point(1012, 3)
            Me.Button_Save.Name = "Button_Save"
            Me.Button_Save.Size = New System.Drawing.Size(84, 21)
            Me.Button_Save.TabIndex = 0
            Me.Button_Save.Text = "SAVE"
            Me.Button_Save.UseVisualStyleBackColor = True
            '
            'TabControl3
            '
            Me.TabControl3.Controls.Add(Me.TabPage12)
            Me.TabControl3.Controls.Add(Me.TabPage11)
            Me.TabControl3.Controls.Add(Me.TabPage10)
            Me.TabControl3.Controls.Add(Me.TabPage13)
            Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl3.Location = New System.Drawing.Point(0, 25)
            Me.TabControl3.Multiline = True
            Me.TabControl3.Name = "TabControl3"
            Me.TabControl3.SelectedIndex = 0
            Me.TabControl3.Size = New System.Drawing.Size(1107, 647)
            Me.TabControl3.TabIndex = 50
            '
            'TabPage12
            '
            Me.TabPage12.BackColor = System.Drawing.Color.CornflowerBlue
            Me.TabPage12.Location = New System.Drawing.Point(4, 24)
            Me.TabPage12.Name = "TabPage12"
            Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage12.Size = New System.Drawing.Size(1099, 619)
            Me.TabPage12.TabIndex = 1
            Me.TabPage12.Text = "Content View / Edit"
            '
            'TabPage11
            '
            Me.TabPage11.Controls.Add(Me.PropertyGrid1)
            Me.TabPage11.Location = New System.Drawing.Point(4, 24)
            Me.TabPage11.Name = "TabPage11"
            Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage11.Size = New System.Drawing.Size(1099, 619)
            Me.TabPage11.TabIndex = 0
            Me.TabPage11.Text = "PropertyGrid (Full Edit)"
            Me.TabPage11.UseVisualStyleBackColor = True
            '
            'PropertyGrid1
            '
            Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PropertyGrid1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PropertyGrid1.Location = New System.Drawing.Point(3, 3)
            Me.PropertyGrid1.Name = "PropertyGrid1"
            Me.PropertyGrid1.Size = New System.Drawing.Size(1093, 613)
            Me.PropertyGrid1.TabIndex = 3
            '
            'TabPage10
            '
            Me.TabPage10.Controls.Add(Me.XML_View2)
            Me.TabPage10.Location = New System.Drawing.Point(4, 24)
            Me.TabPage10.Name = "TabPage10"
            Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage10.Size = New System.Drawing.Size(1099, 619)
            Me.TabPage10.TabIndex = 2
            Me.TabPage10.Text = "Preview (XML)"
            Me.TabPage10.UseVisualStyleBackColor = True
            '
            'XML_View2
            '
            Me.XML_View2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.XML_View2.Location = New System.Drawing.Point(3, 3)
            Me.XML_View2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
            Me.XML_View2.Name = "XML_View2"
            Me.XML_View2.Size = New System.Drawing.Size(1093, 613)
            Me.XML_View2.TabIndex = 3
            '
            'TabPage13
            '
            Me.TabPage13.Controls.Add(Me.TextBox1)
            Me.TabPage13.Location = New System.Drawing.Point(4, 24)
            Me.TabPage13.Name = "TabPage13"
            Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage13.Size = New System.Drawing.Size(1099, 619)
            Me.TabPage13.TabIndex = 3
            Me.TabPage13.Text = "Preview (DEF)"
            Me.TabPage13.UseVisualStyleBackColor = True
            '
            'TextBox1
            '
            Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(3, 3)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TextBox1.Size = New System.Drawing.Size(1093, 613)
            Me.TextBox1.TabIndex = 9
            Me.TextBox1.WordWrap = False
            '
            'COH_ModdableContent_Editor
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.Controls.Add(Me.TabControl3)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "COH_ModdableContent_Editor"
            Me.Size = New System.Drawing.Size(1107, 697)
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.Image_Locked, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl3.ResumeLayout(False)
            Me.TabPage11.ResumeLayout(False)
            Me.TabPage10.ResumeLayout(False)
            Me.TabPage13.ResumeLayout(False)
            Me.TabPage13.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ToolStrip1 As ToolStrip

        Friend WithEvents ToolStripButton1 As ToolStripButton

        Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton

        Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton

        Friend WithEvents ExportCurrentAsXMLToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Button_UpdatePreview As Button
        Friend WithEvents Image_Locked As PictureBox
        Friend WithEvents Button_Undo As Button
        Friend WithEvents Edit_Current_Editing As Label
        Friend WithEvents Button_Save As Button
        Friend WithEvents TabControl3 As TabControl
        Public WithEvents TabPage12 As TabPage
        Friend WithEvents TabPage11 As TabPage
        Friend WithEvents PropertyGrid1 As PropertyGrid
        Friend WithEvents TabPage10 As TabPage
        Friend WithEvents XML_View2 As COH_XML_Viewer
        Friend WithEvents TabPage13 As TabPage
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents ExportCurrentAsDEFToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents Edit_IsCustom As CheckBox
        Friend WithEvents Edit_WasModified As CheckBox
        Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents DEFToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents DontWriteDefaultsToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents DontWriteEmptyToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents DontWriteDebugToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents XMLToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents DontWriteDefaultsToolStripMenuItem1 As ToolStripMenuItem
        Friend WithEvents DontWriteEmptyToolStripMenuItem1 As ToolStripMenuItem
        Friend WithEvents DontWriteDebugToolStripMenuItem1 As ToolStripMenuItem
        Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    End Class
End Namespace
