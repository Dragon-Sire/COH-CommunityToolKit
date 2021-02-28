Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Controls.WinForms.Extentsions
Imports COH.Toolkit.ProjectFiles
Imports COH.Tools.Internal.ContentController

Namespace Controls.Forms
    Public Class COH_ProjectView

#Region "Private Properties"
        Private rCurrentProject As COH_ProjectFile
        Private rExportProject As COH_ProjectFile
        Private rCurrent As COH_FileStructure
#End Region

#Region "Initialize"
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
        End Sub
#End Region

#Region "Configure UI"
        Public Overrides Sub ConfigureUI()
            MyBase.ConfigureUI()
            Changes_Locked = True
            rCurrentProject = COH_ContentController.Instance.Cached_CurrentProjectFile
            ConfiguireUI_FillControls()
            Display_Project()
            Changes_Locked = False
        End Sub
        Private Sub ConfiguireUI_FillControls()
        End Sub
#End Region

#Region "Display"
        Private Sub Display_Project()
            Cursor.Current = Cursors.WaitCursor
            Changes_Locked = True
            Edit_Name.Text = rCurrentProject.Name
            Edit_Author.Text = rCurrentProject.Author
            Edit_Version.Text = rCurrentProject.Version
            Edit_Website.Text = rCurrentProject.Website
            Edit_ReleaseDate.Value = rCurrentProject.ReleaseDate
            Edit_Description.Text = rCurrentProject.Description
            DisplayTreeView()
            Changes_Locked = False
            Cursor.Current = Cursors.Default
        End Sub
        Private Sub DisplayTreeView()
            TreeView1.BeginUpdate()
            Dim RootNode As New TreeNode("Project Contents") With {.Name = "_Folder_Root"}
            For Each Bin In rCurrentProject.Content
                RootNode.Nodes.Add(rCurrentProject.RetrieveNodes(COH_ContentController.Instance.Retrieve_ProjectPathType(Bin.Value.Name)))
            Next
            TreeView1.Nodes.Add(RootNode)
            TreeView1.Nodes(0).Expand()
            TreeView1.EndUpdate()
        End Sub

#End Region

#Region "Control Usage"
        Private Sub TreeView1_AfterSelect_1(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
            If Changes_Locked = True Then Exit Sub
            Cursor.Current = Cursors.WaitCursor
            If e.Node.Name.Contains("_Folder_") = True Then Exit Sub
            Dim Parts As String() = e.Node.Name.Split("!")
            Dim FileName As String = Parts(1)
            COH_ContentController.Instance.Retrieve_Content_FromFileName_RelativePath(Parts(0), Parts(1), COH_ExportFormat.XML, rCurrent)
            If rCurrent Is Nothing Then
                PropertyGrid1.SelectedObject = Nothing
            Else
                PropertyGrid1.SelectedObject = rCurrent
            End If
            Cursor.Current = Cursors.Default
        End Sub
#End Region
    End Class
End Namespace