Imports COH.Toolkit.Controls.WinForms.COH_VirtualByte_Viewer

Namespace Toolkit.Controls.WinForms.UserControls
    Public Class COH_BytesViewer

#Region "Initialize"
        Public Sub New()
            MyBase.New
            InitializeComponent()
        End Sub
#End Region

        Private ChangesLocked As Boolean = False
        Private Visible_Changed As Boolean = False

#Region "Usage"
        Public Sub LoadFile(TheFile As String, Optional Encoding As BytesEncoding = BytesEncoding.DEFAULT, Optional LeaveOpen As Boolean = True)
            CoH_VirtualByte_Viewer1.LoadFile(TheFile, Encoding, LeaveOpen)
            UpdateLayout()
        End Sub
        Public Sub LoadBuffer(ByRef Buffer As Byte(), Optional Encoding As BytesEncoding = BytesEncoding.DEFAULT, Optional LeaveOpen As Boolean = True)
            CoH_VirtualByte_Viewer1.LoadBuffer(Buffer, Encoding, LeaveOpen)
            UpdateLayout()
        End Sub
        Public Sub LoadStream(ByRef theStream As IO.MemoryStream, Optional Encoding As BytesEncoding = BytesEncoding.DEFAULT, Optional LeaveOpen As Boolean = True)
            CoH_VirtualByte_Viewer1.LoadStream(theStream, Encoding, LeaveOpen)
            UpdateLayout()
        End Sub
        Public Sub LoadStream(ByRef ExistingReader As COH_BinaryReader)
            CoH_VirtualByte_Viewer1.LoadStream(ExistingReader)
            UpdateLayout()
        End Sub
        Private Sub UpdateLayout()
            Label_Len.Text = "Total Length = " & CoH_VirtualByte_Viewer1.TotalLength & " Bytes"
        End Sub
#End Region

#Region "Menu Usage - Data"
        Private Sub ViewAsHexToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles ViewAsHexToolStripMenuItem.CheckedChanged
            If ChangesLocked = True Then Exit Sub
            If ViewAsHexToolStripMenuItem.Checked = False Then Exit Sub
            UncheckAll()
            ViewAsHexToolStripMenuItem.Checked = True
            CoH_VirtualByte_Viewer1.View_DataView = BytesView.Hex
            ChangesLocked = False
        End Sub
        Private Sub ViewAsBytesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAsBytesToolStripMenuItem.CheckedChanged
            If ChangesLocked = True Then Exit Sub
            If ViewAsBytesToolStripMenuItem.Checked = False Then Exit Sub
            UncheckAll()
            ViewAsBytesToolStripMenuItem.Checked = True
            CoH_VirtualByte_Viewer1.View_DataView = BytesView.Bytes
            ChangesLocked = False
        End Sub
        Private Sub ViewAsBitsToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs) Handles ViewAsBitsToolStripMenuItem.CheckStateChanged
            If ChangesLocked = True Then Exit Sub
            If ViewAsBitsToolStripMenuItem.Checked = False Then Exit Sub
            UncheckAll()
            ViewAsBitsToolStripMenuItem.Checked = True
            CoH_VirtualByte_Viewer1.View_DataView = BytesView.Bits
            ChangesLocked = False
        End Sub
        Private Sub UncheckAll()
            ChangesLocked = True
            ViewAsHexToolStripMenuItem.Checked = False
            ViewAsBytesToolStripMenuItem.Checked = False
            ViewAsBitsToolStripMenuItem.Checked = False
        End Sub

        Private Sub TableAsHexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableAsHexToolStripMenuItem.Click

        End Sub

        Private Sub TableAsNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableAsNumbersToolStripMenuItem.Click

        End Sub

        Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
            Dim ExportFilePath As String = "CurrentInspection.RAW"
            If HelperFunctions.Toolkit.General.LocateFilePath("Export RAW", "RAW File|*.RAW", ExportFilePath) = False Then Exit Sub
            Me.CoH_VirtualByte_Viewer1.Export_ToFile(ExportFilePath)
            '' GameContent.ShowMessage("Export Complete")
        End Sub
#End Region

#Region "Menu - Focus CurrentLocation"
        Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
            CoH_VirtualByte_Viewer1.Scroll_ToFocus()
        End Sub

        Private Sub COH_BytesViewer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
            If Visible_Changed = True Then Exit Sub
            CoH_VirtualByte_Viewer1.Scroll_ToFocus()
            Visible_Changed = True
        End Sub

        Private Sub CoH_VirtualByte_Viewer1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        End Sub

        Private Sub CoH_VirtualByte_Viewer1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles CoH_VirtualByte_Viewer1.CellEnter
            If ChangesLocked = True Then Exit Sub
            Dim Position As Long = (e.RowIndex * CoH_VirtualByte_Viewer1.View_NumberColumns) + e.ColumnIndex
            Label_Pos.Text = "Current Position = " & Position
        End Sub

        Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
            Try
                Clipboard.Clear()
                Clipboard.SetText(Me.CoH_VirtualByte_Viewer1.Create_TXTVersion)
            Catch ex As Exception
                MsgBox(ex.InnerException)
            End Try
        End Sub
#End Region

    End Class
End Namespace