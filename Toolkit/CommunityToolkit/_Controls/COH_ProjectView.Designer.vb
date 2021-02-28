Imports COH.Toolkit.Controls.WinForms.Internal

Namespace Controls.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_ProjectView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COH_ProjectView))
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.Tab_Preview = New System.Windows.Forms.TabPage()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Edit_Description = New System.Windows.Forms.TextBox()
            Me.Edit_ReleaseDate = New System.Windows.Forms.DateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Edit_Version = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Edit_Website = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Edit_Author = New System.Windows.Forms.TextBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Edit_Name = New System.Windows.Forms.TextBox()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.TreeView1 = New System.Windows.Forms.TreeView()
            Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.TabControl1.SuspendLayout()
            Me.Tab_Preview.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.Tab_Preview)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(830, 415)
            Me.TabControl1.TabIndex = 35
            '
            'Tab_Preview
            '
            Me.Tab_Preview.Controls.Add(Me.Label5)
            Me.Tab_Preview.Controls.Add(Me.Edit_Description)
            Me.Tab_Preview.Controls.Add(Me.Edit_ReleaseDate)
            Me.Tab_Preview.Controls.Add(Me.Label4)
            Me.Tab_Preview.Controls.Add(Me.Label3)
            Me.Tab_Preview.Controls.Add(Me.Edit_Version)
            Me.Tab_Preview.Controls.Add(Me.Label2)
            Me.Tab_Preview.Controls.Add(Me.Edit_Website)
            Me.Tab_Preview.Controls.Add(Me.Label1)
            Me.Tab_Preview.Controls.Add(Me.Edit_Author)
            Me.Tab_Preview.Controls.Add(Me.Label21)
            Me.Tab_Preview.Controls.Add(Me.Edit_Name)
            Me.Tab_Preview.Location = New System.Drawing.Point(4, 23)
            Me.Tab_Preview.Name = "Tab_Preview"
            Me.Tab_Preview.Padding = New System.Windows.Forms.Padding(3)
            Me.Tab_Preview.Size = New System.Drawing.Size(822, 388)
            Me.Tab_Preview.TabIndex = 1
            Me.Tab_Preview.Text = "Project Details"
            Me.Tab_Preview.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(36, 162)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(75, 14)
            Me.Label5.TabIndex = 53
            Me.Label5.Text = "Description :"
            '
            'Edit_Description
            '
            Me.Edit_Description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Description.Location = New System.Drawing.Point(120, 159)
            Me.Edit_Description.Multiline = True
            Me.Edit_Description.Name = "Edit_Description"
            Me.Edit_Description.Size = New System.Drawing.Size(451, 120)
            Me.Edit_Description.TabIndex = 52
            '
            'Edit_ReleaseDate
            '
            Me.Edit_ReleaseDate.Location = New System.Drawing.Point(120, 131)
            Me.Edit_ReleaseDate.Name = "Edit_ReleaseDate"
            Me.Edit_ReleaseDate.Size = New System.Drawing.Size(451, 22)
            Me.Edit_ReleaseDate.TabIndex = 51
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(25, 131)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(86, 14)
            Me.Label4.TabIndex = 50
            Me.Label4.Text = "Release Date :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(56, 106)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 14)
            Me.Label3.TabIndex = 48
            Me.Label3.Text = "Version :"
            '
            'Edit_Version
            '
            Me.Edit_Version.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Version.Location = New System.Drawing.Point(120, 103)
            Me.Edit_Version.Name = "Edit_Version"
            Me.Edit_Version.Size = New System.Drawing.Size(451, 22)
            Me.Edit_Version.TabIndex = 49
            Me.Edit_Version.Text = "Version :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(51, 78)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 14)
            Me.Label2.TabIndex = 46
            Me.Label2.Text = "Website :"
            '
            'Edit_Website
            '
            Me.Edit_Website.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Website.Location = New System.Drawing.Point(120, 75)
            Me.Edit_Website.Name = "Edit_Website"
            Me.Edit_Website.Size = New System.Drawing.Size(451, 22)
            Me.Edit_Website.TabIndex = 47
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 50)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(99, 14)
            Me.Label1.TabIndex = 44
            Me.Label1.Text = "Author / Group :"
            '
            'Edit_Author
            '
            Me.Edit_Author.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Author.Location = New System.Drawing.Point(120, 47)
            Me.Edit_Author.Name = "Edit_Author"
            Me.Edit_Author.Size = New System.Drawing.Size(451, 22)
            Me.Edit_Author.TabIndex = 45
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(22, 22)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(89, 14)
            Me.Label21.TabIndex = 42
            Me.Label21.Text = "Project Name :"
            '
            'Edit_Name
            '
            Me.Edit_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Name.Location = New System.Drawing.Point(120, 19)
            Me.Edit_Name.Name = "Edit_Name"
            Me.Edit_Name.Size = New System.Drawing.Size(451, 22)
            Me.Edit_Name.TabIndex = 43
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.SplitContainer1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 23)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(822, 388)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Project Contents"
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
            Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.PropertyGrid1)
            Me.SplitContainer1.Size = New System.Drawing.Size(816, 382)
            Me.SplitContainer1.SplitterDistance = 272
            Me.SplitContainer1.TabIndex = 36
            '
            'TreeView1
            '
            Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TreeView1.HideSelection = False
            Me.TreeView1.Location = New System.Drawing.Point(0, 0)
            Me.TreeView1.Name = "TreeView1"
            Me.TreeView1.Size = New System.Drawing.Size(272, 382)
            Me.TreeView1.TabIndex = 35
            '
            'PropertyGrid1
            '
            Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PropertyGrid1.Location = New System.Drawing.Point(0, 0)
            Me.PropertyGrid1.Name = "PropertyGrid1"
            Me.PropertyGrid1.Size = New System.Drawing.Size(540, 382)
            Me.PropertyGrid1.TabIndex = 2
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Button1.Enabled = False
            Me.Button1.Location = New System.Drawing.Point(12, 420)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(107, 27)
            Me.Button1.TabIndex = 36
            Me.Button1.Text = "Delete Project"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button2.Enabled = False
            Me.Button2.Location = New System.Drawing.Point(709, 420)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(107, 27)
            Me.Button2.TabIndex = 37
            Me.Button2.Text = "Save"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Button3
            '
            Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button3.Enabled = False
            Me.Button3.Location = New System.Drawing.Point(564, 421)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(139, 27)
            Me.Button3.TabIndex = 38
            Me.Button3.Text = "Create Mod Package"
            Me.Button3.UseVisualStyleBackColor = True
            '
            'COH_ProjectView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.DarkOrange
            Me.ClientSize = New System.Drawing.Size(828, 460)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.TabControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "COH_ProjectView"
            Me.Text = "City of Heroes PortalCorp Toolkit Project Viewer"
            Me.TabControl1.ResumeLayout(False)
            Me.Tab_Preview.ResumeLayout(False)
            Me.Tab_Preview.PerformLayout()
            Me.TabPage1.ResumeLayout(False)
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents Tab_Preview As TabPage
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents Button1 As Button
        Friend WithEvents Button2 As Button
        Friend WithEvents Button3 As Button
        Friend WithEvents Edit_ReleaseDate As DateTimePicker
        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Edit_Version As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Edit_Website As TextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Edit_Author As TextBox
        Friend WithEvents Label21 As Label
        Friend WithEvents Edit_Name As TextBox
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents TreeView1 As TreeView
        Friend WithEvents PropertyGrid1 As PropertyGrid
        Friend WithEvents Label5 As Label
        Friend WithEvents Edit_Description As TextBox
    End Class
End Namespace