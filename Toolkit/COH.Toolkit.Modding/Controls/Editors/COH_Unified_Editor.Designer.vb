Imports COH.Toolkit.Controls.WinForms.Internal

Namespace Toolkit.Modding.Editors
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_EditModdableContent
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COH_EditModdableContent))
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.Edit_ShowAllPowers = New System.Windows.Forms.CheckBox()
            Me.TreeView1 = New System.Windows.Forms.TreeView()
            Me.ImageList1 = New System.Windows.Forms.ImageList()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.SuspendLayout()
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer1.Name = "SplitContainer1"
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.Edit_ShowAllPowers)
            Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
            Me.SplitContainer1.Size = New System.Drawing.Size(1046, 523)
            Me.SplitContainer1.SplitterDistance = 250
            Me.SplitContainer1.TabIndex = 29
            '
            'Edit_ShowAllPowers
            '
            Me.Edit_ShowAllPowers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Edit_ShowAllPowers.AutoSize = True
            Me.Edit_ShowAllPowers.Location = New System.Drawing.Point(3, 502)
            Me.Edit_ShowAllPowers.Name = "Edit_ShowAllPowers"
            Me.Edit_ShowAllPowers.Size = New System.Drawing.Size(117, 18)
            Me.Edit_ShowAllPowers.TabIndex = 0
            Me.Edit_ShowAllPowers.Text = "Show All Powers"
            Me.Edit_ShowAllPowers.UseVisualStyleBackColor = True
            '
            'TreeView1
            '
            Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TreeView1.ImageIndex = 0
            Me.TreeView1.ImageList = Me.ImageList1
            Me.TreeView1.Location = New System.Drawing.Point(0, 0)
            Me.TreeView1.Name = "TreeView1"
            Me.TreeView1.SelectedImageIndex = 0
            Me.TreeView1.Size = New System.Drawing.Size(250, 498)
            Me.TreeView1.TabIndex = 25
            '
            'ImageList1
            '
            Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            '
            'COH_EditModdableContent
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1046, 523)
            Me.Controls.Add(Me.SplitContainer1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "COH_EditModdableContent"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "City of Heroes Community Toolkit - Character Class Editor"
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel1.PerformLayout()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents TreeView1 As TreeView
        Friend WithEvents ImageList1 As ImageList
        Friend WithEvents Edit_ShowAllPowers As CheckBox
    End Class
End Namespace