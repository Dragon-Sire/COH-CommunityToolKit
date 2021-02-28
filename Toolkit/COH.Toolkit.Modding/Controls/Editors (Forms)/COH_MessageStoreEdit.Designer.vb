Imports COH.Toolkit.Controls.WinForms.Internal

Namespace Toolkit.Modding.Editors
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_MessageStoreEdit
        Inherits COH_FormTemplate

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COH_MessageStoreEdit))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Edit_Find = New System.Windows.Forms.TextBox()
            Me.Select_MessageStore = New System.Windows.Forms.ComboBox()
            Me.Button_Search = New System.Windows.Forms.Button()
            Me.Edit_Message = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Edit_MessageID = New System.Windows.Forms.TextBox()
            Me.Edit_Index1 = New System.Windows.Forms.TextBox()
            Me.Edit_Index2 = New System.Windows.Forms.TextBox()
            Me.Edit_Help = New System.Windows.Forms.TextBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.View_Variables = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Button_AddNewEntry = New System.Windows.Forms.Button()
            Me.Button5 = New System.Windows.Forms.Button()
            Me.Button6 = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Button_Unlock = New System.Windows.Forms.Button()
            Me.Button_Refresh = New System.Windows.Forms.Button()
            Me.Label_Custom = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label_NumEntries = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Edit_SearchText = New System.Windows.Forms.TextBox()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(4, 12)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(52, 14)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Search :"
            '
            'Edit_Find
            '
            Me.Edit_Find.Location = New System.Drawing.Point(344, 10)
            Me.Edit_Find.Name = "Edit_Find"
            Me.Edit_Find.Size = New System.Drawing.Size(196, 22)
            Me.Edit_Find.TabIndex = 1
            '
            'Select_MessageStore
            '
            Me.Select_MessageStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.Select_MessageStore.FormattingEnabled = True
            Me.Select_MessageStore.Location = New System.Drawing.Point(62, 9)
            Me.Select_MessageStore.Name = "Select_MessageStore"
            Me.Select_MessageStore.Size = New System.Drawing.Size(216, 22)
            Me.Select_MessageStore.TabIndex = 2
            '
            'Button_Search
            '
            Me.Button_Search.Location = New System.Drawing.Point(546, 10)
            Me.Button_Search.Name = "Button_Search"
            Me.Button_Search.Size = New System.Drawing.Size(86, 22)
            Me.Button_Search.TabIndex = 3
            Me.Button_Search.Text = "Search"
            Me.Button_Search.UseVisualStyleBackColor = True
            '
            'Edit_Message
            '
            Me.Edit_Message.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Message.Location = New System.Drawing.Point(6, 55)
            Me.Edit_Message.Multiline = True
            Me.Edit_Message.Name = "Edit_Message"
            Me.Edit_Message.Size = New System.Drawing.Size(819, 71)
            Me.Edit_Message.TabIndex = 4
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 11)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 14)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Result :"
            '
            'Edit_MessageID
            '
            Me.Edit_MessageID.Location = New System.Drawing.Point(61, 7)
            Me.Edit_MessageID.Name = "Edit_MessageID"
            Me.Edit_MessageID.ReadOnly = True
            Me.Edit_MessageID.Size = New System.Drawing.Size(225, 22)
            Me.Edit_MessageID.TabIndex = 6
            '
            'Edit_Index1
            '
            Me.Edit_Index1.Location = New System.Drawing.Point(574, 3)
            Me.Edit_Index1.Name = "Edit_Index1"
            Me.Edit_Index1.ReadOnly = True
            Me.Edit_Index1.Size = New System.Drawing.Size(86, 22)
            Me.Edit_Index1.TabIndex = 7
            '
            'Edit_Index2
            '
            Me.Edit_Index2.Location = New System.Drawing.Point(730, 3)
            Me.Edit_Index2.Name = "Edit_Index2"
            Me.Edit_Index2.ReadOnly = True
            Me.Edit_Index2.Size = New System.Drawing.Size(95, 22)
            Me.Edit_Index2.TabIndex = 8
            '
            'Edit_Help
            '
            Me.Edit_Help.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Help.Location = New System.Drawing.Point(6, 132)
            Me.Edit_Help.Multiline = True
            Me.Edit_Help.Name = "Edit_Help"
            Me.Edit_Help.Size = New System.Drawing.Size(819, 81)
            Me.Edit_Help.TabIndex = 9
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Panel1.Controls.Add(Me.Button3)
            Me.Panel1.Controls.Add(Me.Button2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 486)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(830, 55)
            Me.Panel1.TabIndex = 10
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(7, 11)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(98, 35)
            Me.Button3.TabIndex = 1
            Me.Button3.Text = "Rebuild BIN"
            Me.Button3.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button2.Location = New System.Drawing.Point(720, 11)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(98, 35)
            Me.Button2.TabIndex = 0
            Me.Button2.Text = "Save Changes"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'View_Variables
            '
            Me.View_Variables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.View_Variables.BackColor = System.Drawing.Color.SlateGray
            Me.View_Variables.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
            Me.View_Variables.FullRowSelect = True
            Me.View_Variables.GridLines = True
            Me.View_Variables.HideSelection = False
            Me.View_Variables.Location = New System.Drawing.Point(6, 219)
            Me.View_Variables.Name = "View_Variables"
            Me.View_Variables.Size = New System.Drawing.Size(764, 188)
            Me.View_Variables.TabIndex = 11
            Me.View_Variables.UseCompatibleStateImageBehavior = False
            Me.View_Variables.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Variable"
            Me.ColumnHeader1.Width = 300
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Format"
            Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader2.Width = 267
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Index"
            Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader3.Width = 147
            '
            'Button_AddNewEntry
            '
            Me.Button_AddNewEntry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button_AddNewEntry.Location = New System.Drawing.Point(797, 3)
            Me.Button_AddNewEntry.Name = "Button_AddNewEntry"
            Me.Button_AddNewEntry.Size = New System.Drawing.Size(29, 28)
            Me.Button_AddNewEntry.TabIndex = 12
            Me.Button_AddNewEntry.Text = "+"
            Me.FormToolTip.SetToolTip(Me.Button_AddNewEntry, "Add New Entry")
            Me.Button_AddNewEntry.UseVisualStyleBackColor = True
            '
            'Button5
            '
            Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button5.Enabled = False
            Me.Button5.Location = New System.Drawing.Point(788, 265)
            Me.Button5.Name = "Button5"
            Me.Button5.Size = New System.Drawing.Size(29, 28)
            Me.Button5.TabIndex = 13
            Me.Button5.Text = "X"
            Me.Button5.UseVisualStyleBackColor = True
            '
            'Button6
            '
            Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button6.Enabled = False
            Me.Button6.Location = New System.Drawing.Point(788, 219)
            Me.Button6.Name = "Button6"
            Me.Button6.Size = New System.Drawing.Size(29, 28)
            Me.Button6.TabIndex = 14
            Me.Button6.Text = "+"
            Me.Button6.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.Button_Unlock)
            Me.Panel2.Controls.Add(Me.Button_Refresh)
            Me.Panel2.Controls.Add(Me.Label_Custom)
            Me.Panel2.Controls.Add(Me.Label4)
            Me.Panel2.Controls.Add(Me.Label3)
            Me.Panel2.Controls.Add(Me.Edit_Index2)
            Me.Panel2.Controls.Add(Me.Button5)
            Me.Panel2.Controls.Add(Me.Button6)
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.Edit_Message)
            Me.Panel2.Controls.Add(Me.Edit_MessageID)
            Me.Panel2.Controls.Add(Me.Edit_Index1)
            Me.Panel2.Controls.Add(Me.Edit_Help)
            Me.Panel2.Controls.Add(Me.View_Variables)
            Me.Panel2.Enabled = False
            Me.Panel2.Location = New System.Drawing.Point(0, 66)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(830, 420)
            Me.Panel2.TabIndex = 15
            '
            'Button_Unlock
            '
            Me.Button_Unlock.Location = New System.Drawing.Point(327, 7)
            Me.Button_Unlock.Name = "Button_Unlock"
            Me.Button_Unlock.Size = New System.Drawing.Size(29, 22)
            Me.Button_Unlock.TabIndex = 19
            Me.FormToolTip.SetToolTip(Me.Button_Unlock, "Unlock")
            Me.Button_Unlock.UseVisualStyleBackColor = True
            '
            'Button_Refresh
            '
            Me.Button_Refresh.Location = New System.Drawing.Point(292, 7)
            Me.Button_Refresh.Name = "Button_Refresh"
            Me.Button_Refresh.Size = New System.Drawing.Size(29, 22)
            Me.Button_Refresh.TabIndex = 18
            Me.FormToolTip.SetToolTip(Me.Button_Refresh, "Rebuild")
            Me.Button_Refresh.UseVisualStyleBackColor = True
            '
            'Label_Custom
            '
            Me.Label_Custom.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label_Custom.Location = New System.Drawing.Point(61, 32)
            Me.Label_Custom.Name = "Label_Custom"
            Me.Label_Custom.Size = New System.Drawing.Size(225, 15)
            Me.Label_Custom.TabIndex = 17
            Me.Label_Custom.Text = "n/a"
            Me.Label_Custom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(674, 7)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(50, 14)
            Me.Label4.TabIndex = 16
            Me.Label4.Text = "Index :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(518, 7)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(50, 14)
            Me.Label3.TabIndex = 15
            Me.Label3.Text = "Index :"
            '
            'Label_NumEntries
            '
            Me.Label_NumEntries.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label_NumEntries.Location = New System.Drawing.Point(59, 34)
            Me.Label_NumEntries.Name = "Label_NumEntries"
            Me.Label_NumEntries.Size = New System.Drawing.Size(219, 14)
            Me.Label_NumEntries.TabIndex = 16
            Me.Label_NumEntries.Text = "# Entries"
            Me.Label_NumEntries.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(284, 13)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(57, 15)
            Me.Label5.TabIndex = 18
            Me.Label5.Text = "PSTRING : "
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(302, 41)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(36, 15)
            Me.Label6.TabIndex = 21
            Me.Label6.Text = "TEXT :"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(546, 38)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(86, 22)
            Me.Button1.TabIndex = 20
            Me.Button1.Text = "Search"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Edit_SearchText
            '
            Me.Edit_SearchText.Location = New System.Drawing.Point(344, 38)
            Me.Edit_SearchText.Name = "Edit_SearchText"
            Me.Edit_SearchText.Size = New System.Drawing.Size(196, 22)
            Me.Edit_SearchText.TabIndex = 19
            '
            'Button4
            '
            Me.Button4.Location = New System.Drawing.Point(639, 38)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(86, 22)
            Me.Button4.TabIndex = 22
            Me.Button4.Text = "Search Next"
            Me.Button4.UseVisualStyleBackColor = True
            '
            'COH_MessageStoreEdit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.CornflowerBlue
            Me.ClientSize = New System.Drawing.Size(830, 541)
            Me.Controls.Add(Me.Button4)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Edit_SearchText)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label_NumEntries)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Button_AddNewEntry)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Button_Search)
            Me.Controls.Add(Me.Select_MessageStore)
            Me.Controls.Add(Me.Edit_Find)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "COH_MessageStoreEdit"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ToolBox Message Store Editor"
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents Edit_Find As TextBox
        Friend WithEvents Select_MessageStore As ComboBox
        Friend WithEvents Button_Search As Button
        Friend WithEvents Edit_Message As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Edit_MessageID As TextBox
        Friend WithEvents Edit_Index1 As TextBox
        Friend WithEvents Edit_Index2 As TextBox
        Friend WithEvents Edit_Help As TextBox
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Button3 As Button
        Friend WithEvents Button2 As Button
        Friend WithEvents View_Variables As ListView
        Friend WithEvents ColumnHeader1 As ColumnHeader
        Friend WithEvents ColumnHeader2 As ColumnHeader
        Friend WithEvents Button_AddNewEntry As Button
        Friend WithEvents Button5 As Button
        Friend WithEvents Button6 As Button
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents ColumnHeader3 As ColumnHeader
        Friend WithEvents Label_Custom As Label
        Friend WithEvents Label_NumEntries As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Button1 As Button
        Friend WithEvents Edit_SearchText As TextBox
        Friend WithEvents Button4 As Button
        Friend WithEvents Button_Unlock As Button
        Friend WithEvents Button_Refresh As Button
    End Class
End Namespace