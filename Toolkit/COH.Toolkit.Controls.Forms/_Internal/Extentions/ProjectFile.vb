Imports System.Runtime.CompilerServices
Imports COH.Toolkit.Enums
Imports COH.Toolkit.ProjectFiles

Namespace Toolkit.Controls.WinForms.Extentsions
    Public Module COH_ProjectFile_Extensions

        <Extension> Public Sub Display_InTreeView(ByRef Source As COH_ProjectFile, ByRef TheTree As TreeView, Selected As COH_ProjectContent)
            Dim Existing = Source.Index_Retrieve(Selected)
            Dim Paths As List(Of KeyValuePair(Of String, String)) = Existing.Retrieve_AllEntryPaths(True)
            HelperFunctions.Toolkit.Controls.TreeViews.Fill_TreeView(TheTree, Selected, Paths, "\")
        End Sub
        <Extension> Public Function RetrieveNodes(ByRef Source As COH_ProjectFile, Selected As COH_ProjectContent()) As TreeNode
            Dim RootNode As New TreeNode(Selected(0).ToString) With {.Name = "_Folder_" & Selected(0).ToString}
            Dim Existing = Source.Index_Retrieve(Selected(0))
            If Existing.FilesCount = 1 Then
                Dim Paths As List(Of KeyValuePair(Of String, String)) = Existing.Retrieve_AllEntryPaths(True)
                HelperFunctions.Toolkit.Controls.TreeViews.Fill_TreeView_GetNodes(RootNode, Selected(0), Paths, ".xml")
            Else
                For X = 0 To Existing.FilesCount - 1
                    Dim Paths As List(Of KeyValuePair(Of String, String)) = Existing.Retrieve_AllEntryPaths_SpecifiedFile(X, True)
                    Dim SubProjectPath As COH_ProjectContent = Selected(X + 1) '//NEED TO FIGURE THIS OUT SOMEHOW
                    Dim SubNode As New TreeNode(SubProjectPath.ToString) With {.Name = "_Folder_" & SubProjectPath.ToString}
                    HelperFunctions.Toolkit.Controls.TreeViews.Fill_TreeView_GetNodes(SubNode, Selected(X + 1), Paths, ".xml")
                    RootNode.Nodes.Add(SubNode)
                Next
            End If
            Return RootNode
        End Function
    End Module
End Namespace