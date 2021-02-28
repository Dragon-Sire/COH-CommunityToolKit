Imports COH.CodeManagement.Enums
Imports COH.GameContent.Structures.Resources.Anim
Imports COH.GameContent.Structures.Resources_Simplified

Namespace HelperFunctions.Toolkit.Controls.TreeViews
    <HideModuleName> Public Module COH_QuickControlHelpers

        Public Sub Fill_TreeView(ByVal TreeView As TreeView, SelectedType As Integer, ByRef PathList As List(Of KeyValuePair(Of String, String)), ByVal pathSeparator As Char, Optional RootName As String = "Standard", Optional FileNameExt As String = ".xml")
            Dim RootNode As TreeNode = Fill_TreeView_GetNodes(New TreeNode(RootName), SelectedType, PathList, FileNameExt)
            TreeView.BeginUpdate()
            TreeView.Nodes.Clear()
            TreeView.Nodes.Add(RootNode)
            TreeView.EndUpdate()
        End Sub
        Public Function Fill_TreeView_GetNodes(ByVal parent As TreeNode, SelectedType As Integer, ByRef PathList As List(Of KeyValuePair(Of String, String)), FileNameExt As String) As TreeNode
            For Each strPath In PathList
                Dim thisParent As TreeNode = parent
                For Each pathPart As String In strPath.Key.Split("\"c)
                    Dim tn As TreeNode() = thisParent.Nodes.Find("_Folder_" & pathPart, False)
                    If tn.Length = 0 Then
                        If pathPart.ToLower.Contains(FileNameExt) Then
                            thisParent = thisParent.Nodes.Add(SelectedType & "!" & strPath.Key, strPath.Value)
                        Else
                            thisParent = thisParent.Nodes.Add("_Folder_" & pathPart, pathPart)
                        End If
                    Else
                        thisParent = tn(0)
                    End If
                Next
            Next
            Return parent
        End Function
        Public Function Fill_TreeView_GetNodes_WithIndex(ByVal parent As TreeNode, FileIndex As Integer, ByRef PathList As List(Of KeyValuePair(Of String, String)), FileNameExt As String) As TreeNode
            Dim Index As Integer = 0
            For Each strPath In PathList
                Dim thisParent As TreeNode = parent
                Dim Key As String = strPath.Key
                Key = Key.Replace("/", "\")
                For Each pathPart As String In Key.Split("\"c)
                    Dim tn As TreeNode() = thisParent.Nodes.Find("_Folder_" & pathPart, False)
                    If tn.Length = 0 Then
                        If pathPart.ToLower.Contains(FileNameExt) Then
                            Dim NodeName As String = strPath.Value
                            If String.IsNullOrEmpty(NodeName) = True Then NodeName = IO.Path.GetFileName(strPath.Key)
                            thisParent = thisParent.Nodes.Add("File" & FileIndex & "!" & Index, NodeName)
                            Index += 1
                        Else
                            thisParent = thisParent.Nodes.Add("_Folder_" & pathPart, pathPart)
                        End If
                    Else
                        thisParent = tn(0)
                    End If
                Next
            Next
            Return parent
        End Function
        Public Sub Fill_TreeView(ByVal TreeView As TreeView, ByRef PathList As List(Of String), ByVal pathSeparator As Char, Optional RootName As String = "Standard", Optional FileNameExt As String = ".xml")
            Dim RootNode As TreeNode = Fill_TreeView_GetNodes(New TreeNode(RootName), PathList, pathSeparator, FileNameExt)
            TreeView.BeginUpdate()
            TreeView.Nodes.Clear()
            TreeView.Nodes.Add(RootNode)
            TreeView.EndUpdate()
        End Sub
        Private Function Fill_TreeView_GetNodes(ByVal parent As TreeNode, ByRef PathList As List(Of String), ByVal pathSeparator As Char, FileNameExt As String) As TreeNode
            Dim Index As Integer = 0
            For Each strPath In PathList
                Dim thisParent As TreeNode = parent
                For Each pathPart As String In strPath.Split(pathSeparator)
                    Dim tn As TreeNode() = thisParent.Nodes.Find("_Folder_" & pathPart, False)
                    If tn.Length = 0 Then
                        If pathPart.ToLower.Contains(FileNameExt) Then
                            thisParent = thisParent.Nodes.Add(Index, pathPart)
                            Index += 1
                        Else
                            thisParent = thisParent.Nodes.Add("_Folder_" & pathPart, pathPart)
                        End If
                    Else
                        thisParent = tn(0)
                    End If
                Next
            Next
            Return parent
        End Function


#Region "Bones"
        Public Sub Fill_TreeView(ByVal TreeView As TreeView, ByRef Skeleton As COH_Skeleton_Heirarchy)
            Dim RootNode As TreeNode = Fill_TreeView_GetNodes(New TreeNode("Skeleton"), Skeleton)
            TreeView.BeginUpdate()
            TreeView.Nodes.Clear()
            TreeView.Nodes.Add(RootNode)
            TreeView.EndUpdate()
        End Sub
        Private Function Fill_TreeView_GetNodes(ByVal parent As TreeNode, ByRef Skeleton As COH_Skeleton_Heirarchy) As TreeNode
            Dim Index As Integer = 0
            Dim BonesNodeIndex As Integer = 0
            Fill_TreeView_GetNodes_BonesLoop(Skeleton, Skeleton.Root, parent)
            Return parent
        End Function
        Private Sub Fill_TreeView_GetNodes_BonesLoop(ByRef Skeleton As COH_Skeleton_Heirarchy, ByRef CurrentIndex As Integer, ByRef Parent As TreeNode)
            Dim CurrentBone As GEO_Enums_MESH_BoneId = CurrentIndex
            Dim BoneLink As COH_Skeleton_Hierarchy_BoneLink = Nothing
            Do Until CurrentBone = GEO_Enums_MESH_BoneId.BONEID_INVALID
                BoneLink = Skeleton.Skeleton_Hierarchy(CurrentBone)
                Dim ChildNode = Parent.Nodes.Add("_Bone_" & BoneLink.ID, BoneLink.ID.ToString)
                If BoneLink.Child > -1 Then
                    Fill_TreeView_GetNodes_BonesLoop(Skeleton, BoneLink.Child, ChildNode)
                End If
                CurrentBone = BoneLink.Next
            Loop
        End Sub
#End Region

#Region "Skeleton"
        Public Sub Fill_TreeView(ByVal TreeView As TreeView, ByRef Skeleton As COH_Resource_GEO_Skeleton)
            Dim SkeletonNode As TreeNode = New TreeNode(Skeleton.Name)
            For Each Bone In Skeleton.Bones
                Fill_TreeView_AddNodes(SkeletonNode, Bone)
            Next
            TreeView.BeginUpdate()
            TreeView.Nodes.Clear()
            TreeView.Nodes.Add(SkeletonNode)
            TreeView.EndUpdate()
        End Sub
        Private Sub Fill_TreeView_AddNodes(ByRef ParentNode As TreeNode, ByRef Bone As COH_Resource_GEO_SkeletonBone)
            Dim ChildBone As TreeNode = New TreeNode(Bone.ID.ToString)
            For Each SingleBone In Bone.Children
                Fill_TreeView_AddNodes(ChildBone, SingleBone)
            Next
            ParentNode.Nodes.Add(ChildBone)
        End Sub
#End Region

    End Module
End Namespace
