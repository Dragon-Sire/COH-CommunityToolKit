Namespace Toolkit.Controls.WinForms.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_XML_Viewer
        Inherits System.Windows.Forms.UserControl

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COH_XML_Viewer))
            Me.FastColoredTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ExportXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'FastColoredTextBox1
            '
            Me.FastColoredTextBox1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
            Me.FastColoredTextBox1.AutoIndentCharsPatterns = ""
            Me.FastColoredTextBox1.AutoScrollMinSize = New System.Drawing.Size(339, 14)
            Me.FastColoredTextBox1.BackBrush = Nothing
            Me.FastColoredTextBox1.CharHeight = 14
            Me.FastColoredTextBox1.CharWidth = 8
            Me.FastColoredTextBox1.CommentPrefix = Nothing
            Me.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
            Me.FastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FastColoredTextBox1.Font = New System.Drawing.Font("Courier New", 9.75!)
            Me.FastColoredTextBox1.IsReplaceMode = False
            Me.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.XML
            Me.FastColoredTextBox1.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
            Me.FastColoredTextBox1.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
            Me.FastColoredTextBox1.LineNumberColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FastColoredTextBox1.Location = New System.Drawing.Point(0, 24)
            Me.FastColoredTextBox1.Name = "FastColoredTextBox1"
            Me.FastColoredTextBox1.Paddings = New System.Windows.Forms.Padding(0)
            Me.FastColoredTextBox1.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
            Me.FastColoredTextBox1.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
            Me.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.FastColoredTextBox1.ServiceColors = CType(resources.GetObject("FastColoredTextBox1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
            Me.FastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.LightSteelBlue
            Me.FastColoredTextBox1.Size = New System.Drawing.Size(717, 453)
            Me.FastColoredTextBox1.TabIndex = 0
            Me.FastColoredTextBox1.Text = "<?xml version=""1.0"" encoding=""utf-16""?>"
            Me.FastColoredTextBox1.Zoom = 100
            '
            'MenuStrip1
            '
            Me.MenuStrip1.BackColor = System.Drawing.Color.CornflowerBlue
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportXMLToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(717, 24)
            Me.MenuStrip1.TabIndex = 1
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ExportXMLToolStripMenuItem
            '
            Me.ExportXMLToolStripMenuItem.Enabled = False
            Me.ExportXMLToolStripMenuItem.Name = "ExportXMLToolStripMenuItem"
            Me.ExportXMLToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
            Me.ExportXMLToolStripMenuItem.Text = "Export XML"
            '
            'TextBox1
            '
            Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TextBox1.Location = New System.Drawing.Point(23, 27)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TextBox1.Size = New System.Drawing.Size(691, 450)
            Me.TextBox1.TabIndex = 2
            Me.TextBox1.Visible = False
            '
            'COH_XML_Viewer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.FastColoredTextBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Name = "COH_XML_Viewer"
            Me.Size = New System.Drawing.Size(717, 477)
            CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents FastColoredTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
        Friend WithEvents MenuStrip1 As MenuStrip
        Friend WithEvents ExportXMLToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents TextBox1 As TextBox
    End Class
End Namespace