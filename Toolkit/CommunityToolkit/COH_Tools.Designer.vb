<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class COH_Tools
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COH_Tools))
        Me.DataBaseConnection_StatusBar = New System.Windows.Forms.StatusStrip()
        Me.Label_ConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoH_Menu1 = New COH.Tools.COH_Menu()
        Me.DataBaseConnection_StatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataBaseConnection_StatusBar
        '
        Me.DataBaseConnection_StatusBar.BackColor = System.Drawing.Color.White
        Me.DataBaseConnection_StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label_ConnectionStatus})
        Me.DataBaseConnection_StatusBar.Location = New System.Drawing.Point(0, 698)
        Me.DataBaseConnection_StatusBar.Name = "DataBaseConnection_StatusBar"
        Me.DataBaseConnection_StatusBar.Size = New System.Drawing.Size(1182, 22)
        Me.DataBaseConnection_StatusBar.TabIndex = 0
        Me.DataBaseConnection_StatusBar.Text = "StatusStrip1"
        '
        'Label_ConnectionStatus
        '
        Me.Label_ConnectionStatus.BackColor = System.Drawing.Color.White
        Me.Label_ConnectionStatus.Name = "Label_ConnectionStatus"
        Me.Label_ConnectionStatus.Size = New System.Drawing.Size(88, 17)
        Me.Label_ConnectionStatus.Text = "Not Connected"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(122, 20)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(67, 22)
        '
        'CoH_Menu1
        '
        Me.CoH_Menu1.BackColor = System.Drawing.Color.Black
        Me.CoH_Menu1.BackgroundImage = Global.COH.Tools.My.Resources.Resources.CityofHeroesToolKit_Banner
        Me.CoH_Menu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CoH_Menu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CoH_Menu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CoH_Menu1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoH_Menu1.Location = New System.Drawing.Point(0, 0)
        Me.CoH_Menu1.Name = "CoH_Menu1"
        Me.CoH_Menu1.Size = New System.Drawing.Size(1182, 189)
        Me.CoH_Menu1.TabIndex = 3
        '
        'COH_Tools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1182, 720)
        Me.Controls.Add(Me.CoH_Menu1)
        Me.Controls.Add(Me.DataBaseConnection_StatusBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "COH_Tools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "City of Heroes - Community Toolkit"
        Me.DataBaseConnection_StatusBar.ResumeLayout(False)
        Me.DataBaseConnection_StatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataBaseConnection_StatusBar As StatusStrip
    Friend WithEvents Label_ConnectionStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CoH_Menu1 As COH_Menu
End Class
