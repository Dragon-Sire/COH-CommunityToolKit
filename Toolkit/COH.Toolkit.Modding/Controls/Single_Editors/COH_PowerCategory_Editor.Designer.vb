Imports COH.Tools.Controls
Namespace Toolkit.Modding.Editors
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_CategoryEditor
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
            Me.Panelx1 = New System.Windows.Forms.Panel()
            Me.Button_Refresh_DisplayName = New System.Windows.Forms.Button()
            Me.Edit_DisplayNameKey = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Edit_List_Powers = New System.Windows.Forms.ListBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.Edit_ClassName = New System.Windows.Forms.TextBox()
            Me.Edit_DisplayName = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TabPage12.SuspendLayout()
            Me.Panelx1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabPage12
            '
            Me.TabPage12.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(16, Byte), Integer))
            Me.TabPage12.Controls.Add(Me.Panelx1)
            Me.TabPage12.Size = New System.Drawing.Size(947, 453)
            '
            'Panelx1
            '
            Me.Panelx1.BackColor = System.Drawing.Color.White
            Me.Panelx1.Controls.Add(Me.Button_Refresh_DisplayName)
            Me.Panelx1.Controls.Add(Me.Edit_DisplayNameKey)
            Me.Panelx1.Controls.Add(Me.Label1)
            Me.Panelx1.Controls.Add(Me.Edit_List_Powers)
            Me.Panelx1.Controls.Add(Me.Button2)
            Me.Panelx1.Controls.Add(Me.Button3)
            Me.Panelx1.Controls.Add(Me.Button4)
            Me.Panelx1.Controls.Add(Me.Edit_ClassName)
            Me.Panelx1.Controls.Add(Me.Edit_DisplayName)
            Me.Panelx1.Controls.Add(Me.Label2)
            Me.Panelx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panelx1.Location = New System.Drawing.Point(3, 3)
            Me.Panelx1.Name = "Panelx1"
            Me.Panelx1.Size = New System.Drawing.Size(941, 447)
            Me.Panelx1.TabIndex = 0
            '
            'Button_Refresh_DisplayName
            '
            Me.Button_Refresh_DisplayName.BackColor = System.Drawing.Color.White
            Me.Button_Refresh_DisplayName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button_Refresh_DisplayName.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button_Refresh_DisplayName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Button_Refresh_DisplayName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
            Me.Button_Refresh_DisplayName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button_Refresh_DisplayName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button_Refresh_DisplayName.Location = New System.Drawing.Point(575, 32)
            Me.Button_Refresh_DisplayName.Name = "Button_Refresh_DisplayName"
            Me.Button_Refresh_DisplayName.Size = New System.Drawing.Size(63, 21)
            Me.Button_Refresh_DisplayName.TabIndex = 52
            Me.Button_Refresh_DisplayName.Text = "Refresh"
            Me.FormToolTip.SetToolTip(Me.Button_Refresh_DisplayName, "Update PString Display Name")
            Me.Button_Refresh_DisplayName.UseVisualStyleBackColor = False
            '
            'Edit_DisplayNameKey
            '
            Me.Edit_DisplayNameKey.Location = New System.Drawing.Point(442, 32)
            Me.Edit_DisplayNameKey.Name = "Edit_DisplayNameKey"
            Me.Edit_DisplayNameKey.ReadOnly = True
            Me.Edit_DisplayNameKey.Size = New System.Drawing.Size(127, 23)
            Me.Edit_DisplayNameKey.TabIndex = 51
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(21, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(91, 15)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Class Name :"
            '
            'Edit_List_Powers
            '
            Me.Edit_List_Powers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_List_Powers.FormattingEnabled = True
            Me.Edit_List_Powers.ItemHeight = 15
            Me.Edit_List_Powers.Location = New System.Drawing.Point(3, 72)
            Me.Edit_List_Powers.Name = "Edit_List_Powers"
            Me.Edit_List_Powers.Size = New System.Drawing.Size(881, 319)
            Me.Edit_List_Powers.TabIndex = 1
            '
            'Button2
            '
            Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button2.Location = New System.Drawing.Point(890, 81)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(33, 27)
            Me.Button2.TabIndex = 3
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Button3
            '
            Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button3.Location = New System.Drawing.Point(891, 411)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(33, 27)
            Me.Button3.TabIndex = 4
            Me.Button3.UseVisualStyleBackColor = True
            '
            'Button4
            '
            Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button4.Location = New System.Drawing.Point(890, 255)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(33, 27)
            Me.Button4.TabIndex = 5
            Me.Button4.UseVisualStyleBackColor = True
            '
            'Edit_ClassName
            '
            Me.Edit_ClassName.Location = New System.Drawing.Point(116, 6)
            Me.Edit_ClassName.Name = "Edit_ClassName"
            Me.Edit_ClassName.Size = New System.Drawing.Size(320, 23)
            Me.Edit_ClassName.TabIndex = 6
            '
            'Edit_DisplayName
            '
            Me.Edit_DisplayName.Location = New System.Drawing.Point(116, 32)
            Me.Edit_DisplayName.Name = "Edit_DisplayName"
            Me.Edit_DisplayName.Size = New System.Drawing.Size(320, 23)
            Me.Edit_DisplayName.TabIndex = 8
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(9, 32)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(103, 15)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "Display Name :"
            '
            'COH_CategoryEditor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "COH_CategoryEditor"
            Me.Size = New System.Drawing.Size(955, 531)
            Me.TabPage12.ResumeLayout(False)
            Me.Panelx1.ResumeLayout(False)
            Me.Panelx1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents Edit_List_Powers As ListBox
        Friend WithEvents Button2 As Button
        Friend WithEvents Button3 As Button
        Friend WithEvents Button4 As Button
        Friend WithEvents Edit_ClassName As TextBox
        Friend WithEvents Edit_DisplayName As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Panelx1 As Panel
        Friend WithEvents Button_Refresh_DisplayName As Button
        Friend WithEvents Edit_DisplayNameKey As TextBox
    End Class
End Namespace