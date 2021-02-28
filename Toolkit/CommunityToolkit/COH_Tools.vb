Imports System.Drawing
Imports COH.Toolkit.Controls.WinForms.Interfaces
Imports COH.Tools.Internal.ContentController

Public Class COH_Tools
    Implements COH_ParentFormInterface

#Region "Startup"
    Private Sub COH_Tools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
#End Region

#Region "Display"
    Public Function AvailableClientArea() As Rectangle Implements COH_ParentFormInterface.AvailableClientArea
        Return New Rectangle(Me.ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height - CoH_Menu1.Height)
    End Function
#End Region

#Region "FileMenu"
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub
#End Region

#Region "Menu - Editors"
    Private Sub CharacterClassEditorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Cursor.Current = Cursors.WaitCursor
        COH_ContentController.Instance.OpenEditor_ModdableContentEditor()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub RebuildStandardProjectToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Cursor.Current = Cursors.WaitCursor
        COH_ContentController.Instance.Start_FreshProjectFile_Standard(True)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub PowerSetsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Cursor.Current = Cursors.WaitCursor
        COH_ContentController.Instance.BuildXML_FromDef_PowerSets_All(Nothing, True)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub PowerCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Cursor.Current = Cursors.WaitCursor
        COH_ContentController.Instance.BuildXML_FromDef_PowerCategory_All(Nothing, True)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub MessageStoreEditorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Cursor.Current = Cursors.WaitCursor
        COH_ContentController.Instance.BuildXML_FromDef_PowerCategory_All(Nothing, True)
        Cursor.Current = Cursors.Default
    End Sub
#End Region

End Class
