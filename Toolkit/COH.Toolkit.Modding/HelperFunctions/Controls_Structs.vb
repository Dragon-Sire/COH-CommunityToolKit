Imports COH.CodeManagement.Interfaces.Structures
Imports COH.GameContent.Structures.Characters
Imports COH.GameContent.Structures.Characters.Powers
Imports COH.GameContent.Structures.Powers
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums

Namespace Helperfunctions.Toolkit.Structs
    <HideModuleName> Public Module COH_QuickControlHelpers_COH_FileStructures

#Region "Unified"
        Public Sub Display_InTreeView_Unified(ByRef Tree As TreeView, ByRef Controller As ISupport_MasterController, Optional ShowPowers As Boolean = False)
            Tree.Nodes.Clear()
            Tree.BeginUpdate()
            Dim RootNode As New TreeNode("Project Contents") With {.Name = "_Folder_Root"}
            RootNode.Nodes.Add(Create_TreeNode_PlayerClasses(Controller))
            RootNode.Nodes.Add(Create_TreeNode_EnemyClasses(Controller))
            If ShowPowers = True Then RootNode.Nodes.Add(Create_TreeNode_Powers(Controller))
            Tree.Nodes.Add(RootNode)
            Tree.EndUpdate()
            Tree.Nodes(0).Expand()
        End Sub
#End Region

#Region "Unified - Sorted by Character Classes"
        Private Function Create_TreeNode_PlayerClasses(ByRef Controller As ISupport_MasterController) As TreeNode
            Dim Result As New TreeNode("Player Classes") With {.Name = "_Folder_PlayerClasses"}
            Dim Result_LegacyBranch As New TreeNode("Standard Classes") With {.Name = "_Folder_PlayerLegacyClasses"}
            Dim Result_CustomBranch As New TreeNode("Custom Classes") With {.Name = "_Folder_PlayerCustomClasses"}
            'Dim Result_LegacyBranch_Heroes As New TreeNode("Heroes") With {.Name = "_Folder_PlayerLegacyClasses_Heroes"}
            'Dim Result_LegacyBranch_Villians As New TreeNode("Villians") With {.Name = "_Folder_PlayerLegacyClasses_Villians"}
            Add_TreeNodes_CharacterClasses(Result_LegacyBranch, Controller, COH_ProjectContent.CharacterClasses_PlayerClasses)
            Result.Nodes.Add(Result_LegacyBranch)
            Result.Nodes.Add(Result_CustomBranch)
            Return Result
        End Function
        Private Function Create_TreeNode_EnemyClasses(ByRef Controller As ISupport_MasterController) As TreeNode
            Dim Result As New TreeNode("Enemy Classes") With {.Name = "_Folder_EnemyClasses"}
            Dim Result_LegacyBranch As New TreeNode("Standard Classes") With {.Name = "_Folder_EnemyLegacyClasses"}
            Dim Result_CustomBranch As New TreeNode("Custom Classes") With {.Name = "_Folder_EnemyCustomClasses"}
            'Dim Result_LegacyBranch_Heroes As New TreeNode("Heroes") With {.Name = "_Folder_PlayerLegacyClasses_Heroes"}
            'Dim Result_LegacyBranch_Villians As New TreeNode("Villians") With {.Name = "_Folder_PlayerLegacyClasses_Villians"}
            Add_TreeNodes_CharacterClasses(Result_LegacyBranch, Controller, COH_ProjectContent.CharacterClasses_EnemyClass)
            Result.Nodes.Add(Result_LegacyBranch)
            Result.Nodes.Add(Result_CustomBranch)
            Return Result
        End Function
        Private Sub Add_TreeNodes_CharacterClasses(ByRef ParentNode As TreeNode, ByRef Controller As ISupport_MasterController, TheType As COH_ProjectContent)
            Dim ValidToAdd As Boolean = True
            For Each Entry In Controller.Retrieve_ModableContent(TheType)
                ValidToAdd = True
                'If Entry.isCustom = False Then the '//ADDING THIS
                If ValidToAdd = True Then
                    Dim CurrentCharacter As COH_CharacterClass = Entry.Content
                    Dim ThisNode As TreeNode = New TreeNode(CurrentCharacter.DisplayName.DisplayText) With {.Name = TheType.ToString & "!" & Entry.FullName, .ImageKey = TheType.ToString, .SelectedImageKey = TheType.ToString}
                    If TheType = COH_ProjectContent.CharacterClasses_PlayerClasses Then
                        Dim COH_CAT = Controller.Retrieve_ModableContent(CurrentCharacter.PrimaryCategory, COH_ProjectContent.PowerCategory)
                        Add_PowerDetails_ToClass(ThisNode, COH_CAT, Controller)
                        Dim COH_CAT2 = Controller.Retrieve_ModableContent(CurrentCharacter.SecondaryCategory, COH_ProjectContent.PowerCategory)
                        Add_PowerDetails_ToClass(ThisNode, COH_CAT2, Controller)
                    End If
                    ParentNode.Nodes.Add(ThisNode)
                End If
            Next
        End Sub
        Private Sub Add_PowerDetails_ToClass(ByRef ParentNode As TreeNode, ByRef COH_CAT As ISupport_COH_OriginolSources, ByRef Controller As ISupport_MasterController)
            If COH_CAT Is Nothing Then Exit Sub
            Dim CurrentPowerCat As COH_PowerCategory = COH_CAT.Content
            Dim NewBranch As New TreeNode(CurrentPowerCat.Name) With {.Name = COH_ProjectContent.PowerCategory.ToString & "!" & COH_CAT.FullName, .ImageKey = COH_ProjectContent.PowerCategory.ToString, .SelectedImageKey = COH_ProjectContent.PowerCategory.ToString}
            ParentNode.Nodes.Add(NewBranch)
            If Not CurrentPowerCat.PowerSets Is Nothing Then
                For Each PowerSet In CurrentPowerCat.PowerSets
                    ' Dim Name As String = PowerSet.Replace(".", "\") & ".xml"
                    Dim Name As String = PowerSet
                    Dim PSet = Controller.Retrieve_ModableContent(Name, COH_ProjectContent.PowerSets)
                    Dim CurrentPowerSet As COH_PowerSet = PSet.Content
                    Dim ThisNode As TreeNode
                    If PSet Is Nothing Then
                        ThisNode = New TreeNode(PowerSet) With {.Name = COH_ProjectContent.PowerSets.ToString & "!" & Name, .ImageKey = COH_ProjectContent.PowerSets.ToString, .SelectedImageKey = COH_ProjectContent.PowerSets.ToString}
                    Else
                        ThisNode = New TreeNode(PowerSet) With {.Name = COH_ProjectContent.PowerSets.ToString & "!" & Name, .ImageKey = COH_ProjectContent.PowerSets.ToString, .SelectedImageKey = COH_ProjectContent.PowerSets.ToString}
                        For Each Power In CurrentPowerSet.Powers
                            ThisNode.Nodes.Add(New TreeNode(Power) With {.Name = COH_ProjectContent.Powers.ToString & "!" & Power, .ImageKey = COH_ProjectContent.Powers.ToString, .SelectedImageKey = COH_ProjectContent.Powers.ToString})
                            'ThisNode.Nodes.Add(New TreeNode(Power) With {.Name = COH_ProjectContent.Powers.ToString & "!" & Power.Replace(".", "\") & ".xml", .ImageKey = COH_ProjectContent.Powers.ToString, .SelectedImageKey = COH_ProjectContent.Powers.ToString})
                        Next
                    End If
                    NewBranch.Nodes.Add(ThisNode)
                Next
            End If
        End Sub
#End Region

#Region "Unified - Powers Only"
        Private Function Create_TreeNode_Powers(ByRef Controller As ISupport_MasterController) As TreeNode
            Dim PowerNode As New TreeNode("PowerCategories") With {.Name = "_Folder_PowerCats"}
            'Dim TreeBranch_Player As New TreeNode("Player") With {.Name = "_Folder_Player"}
            Dim TreeBranch_Enemy As New TreeNode("Enemy") With {.Name = "_Folder_Enemy"}
            Dim TreeBranch_Shared As New TreeNode("Shared") With {.Name = "_Folder_Player"}
            Dim TreeBranch_Other As New TreeNode("Other") With {.Name = "_Folder_Enemy"}
            For Each Cat In Controller.Retrieve_ModableContent(COH_ProjectContent.PowerCategory)
                Dim CurrentPath As String = Cat.RelativePath_Current
                If CurrentPath.Contains("_Shared\") Then
                    Add_PowerDetails_ToClass(TreeBranch_Shared, Cat, Controller)
                ElseIf CurrentPath.Contains("Player\") Then
                    'Add_PowerDetails_ToClass(TreeBranch_Player, Cat, Controller)
                ElseIf CurrentPath.Contains("Enemies\") Then
                    Add_PowerDetails_ToClass(TreeBranch_Enemy, Cat, Controller)
                Else
                    Add_PowerDetails_ToClass(TreeBranch_Other, Cat, Controller)
                End If
            Next
            'PowerNode.Nodes.Add(TreeBranch_Player)
            PowerNode.Nodes.Add(TreeBranch_Enemy)
            PowerNode.Nodes.Add(TreeBranch_Shared)
            PowerNode.Nodes.Add(TreeBranch_Other)
            Return PowerNode
        End Function
#End Region
















#Region "Display - Tree (PowerCategories / PowerSets)"
        Public Sub Display_InTreeView_PowerCategories(ByRef Tree As TreeView, ByRef Controller As ISupport_MasterController)
            Tree.BeginUpdate()
            Tree.Nodes.Add(Create_TreeNode_PowerCategories(Controller))
            Tree.EndUpdate()
            Tree.Nodes(0).Expand()
        End Sub
        Private Function Create_TreeNode_PowerCategories(ByRef Controller As ISupport_MasterController) As TreeNode
            Dim Result As New TreeNode("Standard") With {.Name = "_Folder_Standard"}
            Dim TreeBranch_Player As New TreeNode("Player") With {.Name = "_Folder_Player"}
            Dim TreeBranch_Enemy As New TreeNode("Enemy") With {.Name = "_Folder_Enemy"}
            Dim TreeBranch_Shared As New TreeNode("Shared") With {.Name = "_Folder_Shared"}
            Dim TreeBranch_Other As New TreeNode("Other") With {.Name = "_Folder_Other"}
            For Each Cat In Controller.Retrieve_ModableContent(COH_ProjectContent.PowerCategory)
                Dim CurrentPath As String = Cat.RelativePath_Current
                ' Dim NewBranch As New TreeNode(Cat.PowerCategory.DisplayName) With {.Name = "_CAT_" & Cat.RelativePath_Current}
                ' For Each PowerSet In Cat.PowerCategory.PowerSets
                ' NewBranch.Nodes.Add(New TreeNode(PowerSet) With {.Name = "_POWERSET_" & PowerSet.Replace(".", "\") & ".xml"})
                ' Next
                If CurrentPath.Contains("_Shared\") Then
                    'TreeBranch_Shared.Nodes.Add(NewBranch)
                ElseIf CurrentPath.Contains("Player\") Then
                    'TreeBranch_Player.Nodes.Add(NewBranch)
                ElseIf CurrentPath.Contains("Enemies\") Then
                    'TreeBranch_Enemy.Nodes.Add(NewBranch)
                Else
                    'TreeBranch_Other.Nodes.Add(NewBranch)
                End If
            Next
            Result.Nodes.Add(TreeBranch_Player)
            Result.Nodes.Add(TreeBranch_Enemy)
            Result.Nodes.Add(TreeBranch_Shared)
            Result.Nodes.Add(TreeBranch_Other)
            Return Result
        End Function
#End Region

#Region "Display - Tree (Powers)"
        Public Sub Display_InTreeView_Powers(ByRef Tree As TreeView, ByRef Controller As ISupport_MasterController)
            Tree.BeginUpdate()
            Tree.Nodes.Add(Create_TreeNode_Powers_(Controller))
            Tree.EndUpdate()
            Tree.Nodes(0).Expand()
        End Sub
        Private Function Create_TreeNode_Powers_(ByRef Controller As ISupport_MasterController) As TreeNode
            Dim Result As New TreeNode("Standard") With {.Name = "_Folder_Standard"}

            Dim TreeBranch_Player As New TreeNode("Player") With {.Name = "_Folder_Player"}
            Dim TreeBranch_Enemy As New TreeNode("Enemy") With {.Name = "_Folder_Enemy"}

            For Each Cat In Controller.Retrieve_ModableContent(COH_ProjectContent.PowerCategory)
                Dim CurrentPath As String = Cat.RelativePath_Current
                ' Dim NewBranch As New TreeNode(Cat.PowerCategory.DisplayName) With {.Name = "_CAT_" & Cat.RelativePath_Current}
                ' For Each PowerSet In Cat.PowerCategory.PowerSets
                '  NewBranch.Nodes.Add(New TreeNode(PowerSet) With {.Name = "_POWERSET_" & PowerSet.Replace(".", "\") & ".xml"})
                'Next
                If CurrentPath.Contains("_Shared\") Then
                    'TreeBranch_Shared.Nodes.Add(NewBranch)
                ElseIf CurrentPath.Contains("Player\") Then
                    ' TreeBranch_Player.Nodes.Add(NewBranch)
                ElseIf CurrentPath.Contains("Enemies\") Then
                    ' TreeBranch_Enemy.Nodes.Add(NewBranch)
                Else
                    'TreeBranch_Other.Nodes.Add(NewBranch)
                End If
            Next
            Result.Nodes.Add(TreeBranch_Player)
            Result.Nodes.Add(TreeBranch_Enemy)
            ' Result.Nodes.Add(TreeBranch_Shared)
            ' Result.Nodes.Add(TreeBranch_Other)
            Return Result
        End Function
#End Region

#Region "Display CheckList (Chracter Classes)"
        Public Sub Display_InCombo_AllowedRestrictions(ByRef CheckList As CheckedListBox, ByRef Controller As ISupport_MasterController)
            Dim AllAllowed As New List(Of String)
            ' For Each Entry As COH_Modable_CharacterClass In Controller.Retrieve_ModableContent(COH_ProjectContent.CharacterClasses_PlayerClasses)
            ' For x = 0 To Entry.CharacterClass.SpecialRestrictions.Count - 1
            'If AllAllowed.Contains(Entry.CharacterClass.SpecialRestrictions(x)) = False Then AllAllowed.Add(Entry.CharacterClass.SpecialRestrictions(x))
            'Next
            ''Next
            'For Each Entry As COH_Modable_CharacterClass In Controller.Retrieve_ModableContent(COH_ProjectContent.CharacterClasses_EnemyClass)
            ' For x = 0 To Entry.CharacterClass.SpecialRestrictions.Count - 1
            ' If AllAllowed.Contains(Entry.CharacterClass.SpecialRestrictions(x)) = False Then AllAllowed.Add(Entry.CharacterClass.SpecialRestrictions(x))
            ' Next
            'Next
            Helperfunctions.Toolkit.Controls.Lists.Fill_ChecklistBox(CheckList, AllAllowed)
        End Sub
        Public Sub Display_InCheckListBox_CharacterOrigins(ByRef CheckList As CheckedListBox, ByRef Controller As ISupport_MasterController)
            '  Dim AllOrigins As New List(Of COH_Modable_CharacterOrigin)
            '  For Each Origin As COH_Modable_CharacterOrigin In Controller.Retrieve_ModableContent(COH_ProjectContent.CharacterClasses_PlayerClasses_Origins)
            '  AllOrigins.Add(Origin)
            '  Next
            ' For Each Origin As COH_Modable_CharacterOrigin In Controller.Retrieve_ModableContent(COH_ProjectContent.CharacterClasses_EnemyClass_Origins)
            '' AllOrigins.Add(Origin)
            ' Next
            ' Fill_ChecklistBox(CheckList, AllOrigins)
        End Sub

#End Region

#Region "Display CheckList (PowerSets)"
        Public Sub Display_InCheckListBox_PowerSet_PurchaseRequirements(ByRef CheckList As CheckedListBox, ByRef Controller As ISupport_MasterController)
            Dim AllAllowed As New List(Of String)
            For Each Entry As COH_PowerSet In Controller.Retrieve_Structs(COH_ProjectContent.PowerSets)
                For x = 0 To Entry.SetBuyRequires.Count - 1
                    If AllAllowed.Contains(Entry.SetBuyRequires(x)) = False Then AllAllowed.Add(Entry.SetBuyRequires(x))
                Next
            Next
            Helperfunctions.Toolkit.Controls.Lists.Fill_ChecklistBox(CheckList, AllAllowed)
            '//Dim Ter As String = String.Join(Chr(10), AllAllowed)
        End Sub
        Public Sub Display_InCheckListBox_PowerSet_PurchaseRequirements_NoSearch(ByRef CheckList As CheckedListBox)
            Dim AllAllowed As New List(Of String)
            AllAllowed.Add("Pool.Sorcery.Spirit_Ward")
            AllAllowed.Add("Pool.Sorcery.Arcane_Bolt")
            AllAllowed.Add("Pool.Sorcery.Mystic_Flight")
            AllAllowed.Add("Pool.Force_of_Will.Weaken_Resolve")
            AllAllowed.Add("Pool.Force_of_Will.Project_Will")
            AllAllowed.Add("Pool.Force_of_Will.Mighty_Leap")
            AllAllowed.Add("Pool.Gadgetry.Nano_Net")
            AllAllowed.Add("Pool.Gadgetry.Wrist_Blaster")
            AllAllowed.Add("Pool.Gadgetry.Jetpack")
            AllAllowed.Add("Pool.Utility_Belt.Bolas")
            AllAllowed.Add("Pool.Utility_Belt.Poisoned_Dagger")
            AllAllowed.Add("Pool.Utility_Belt.Freerunning")
            AllAllowed.Add("Pool.Experimentation.Experimental_Injection")
            AllAllowed.Add("Pool.Experimentation.Toxic_Dart")
            AllAllowed.Add("Pool.Experimentation.Speed_of_Sound")
            AllAllowed.Add("||")
            AllAllowed.Add("!")
            Helperfunctions.Toolkit.Controls.Lists.Fill_ChecklistBox(CheckList, AllAllowed)
        End Sub
#End Region
    End Module
End Namespace