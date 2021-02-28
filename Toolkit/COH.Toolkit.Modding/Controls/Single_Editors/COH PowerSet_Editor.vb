Imports COH.CodeManagement.Enums
Imports COH.CodeManagement.Enums.Structures
Imports COH.GameContent.Structures
Imports COH.GameContent.Structures.Resources.Textures
Imports COH.Storage.Structures
Imports COH.Storage.Structures.Generics
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums

Namespace Toolkit.Modding.Editors
    Public Class COH_PowerSet_Editor

#Region "Properties"
        Protected Overrides ReadOnly Property Current_Struct As COH_FileStructure
            Get
                Return mCurrent
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private WithEvents mCurrent As Characters.Powers.COH_PowerSet
        Private mIcon As Image
#End Region

#Region "Initialize"
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
            ConfigureUI()
        End Sub
#End Region

#Region "Configure UI"
        Public Overrides Sub ConfigureUI()
            MyBase.ConfigureUI()
            Changes_Locked = True
            ConfigureUI_PowerTable()
            ConfigureUI_Tooltips()
            ConfigureUI_Enums()
            Changes_Locked = False
        End Sub
        Private Sub ConfigureUI_PowerTable()
            Dim ColumnWidth As Integer = 60
            Edit_PowerTable.Columns.Clear()
            Edit_PowerTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Edit_PowerTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Edit_PowerTable.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Description", .Width = 240, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
            Edit_PowerTable.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Level Available", .Width = ColumnWidth})
            Edit_PowerTable.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "AI Max", .Width = ColumnWidth})
            Edit_PowerTable.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "AI Min Rank", .Width = ColumnWidth})
            Edit_PowerTable.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "AI Max Rank", .Width = ColumnWidth})
            Edit_PowerTable.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Min Difficulty", .Width = ColumnWidth})
            Edit_PowerTable.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Max Difficulty", .Width = ColumnWidth})
        End Sub
        Private Sub ConfigureUI_Tooltips()
            With FormToolTip
                .SetToolTip(Edit_PowerSetName, "Internal name")
                .SetToolTip(Edit_FullName, "Full name, including source category")
                .SetToolTip(Edit_Icon, "Name of icon which represents this power set.")
                .SetToolTip(Edit_Costume_Keys, "Costume keys given to players with this set")
                .SetToolTip(Edit_Costume_Parts, "Default costume pieces for new players, or parts to add for old ones")
                .SetToolTip(Select_PowerSystem, "Which power system this power set (and all the powers within it) is associated with. (Powers or Skills, for now)")
                .SetToolTip(Edit_Shared, "If true, this powerset is not specific to one of a player's multiple builds and is instead shared among them.")
                .SetToolTip(Select_Inventory, "Determines whether the power is shown in the power inventory or not.")
                .SetToolTip(Edit_ShowManage, "Bool. If true, then the power set is shown in the power management (i.e. the enhancement) and enh slot assignment screens, otherwise it is not.")
                .SetToolTip(Edit_ShowInfo, "Bool. If true, then the power set is shown in the power tab of the Player Info window.")
                .SetToolTip(Edit_SpecializedAt, "If non-zero, this powerset is a specialization powerset, available at this level as an additional set to pick from as well as their chosen set - and thus cannot be picked as a main set.")
                .SetToolTip(Edit_SpecializedReq, "Requires statement controlling whether specialization powerset can be offered of not (so multiple specializations can be listed for a class and once one or more is picked the rest are shut off).")
                .SetToolTip(Edit_AccountRequires, "Account evaluator statement controlling whether a player has access to this powerset.")
                .SetToolTip(Edit_AccountToolTip, "Tooltip to display when player has failed to meet the AccountRequires")
                .SetToolTip(Edit_Product, "Product that can be bought from the store to help the player meet the AccountRequires")
                .SetToolTip(Edit_PurchaseRequirements, "Character evaluator statement controlling whether a player has access to this powerset.")
                .SetToolTip(Edit_PurchaseFailed, "Error message to display when the player fails the SetBuyRequires")
                .SetToolTip(Edit_PowerTable, "The array of names of included powers, Avilable Level and AI usage")
            End With
        End Sub
        Private Sub ConfigureUI_Enums()
            Select_PowerSystem.DataSource = [Enum].GetValues(GetType(COH_Enum_PowerSystem))
            Select_Inventory.DataSource = [Enum].GetValues(GetType(COH_Enum_ShowPowerSetting))
        End Sub
#End Region

#Region "Configure UI Enabled/Disabled"
        Public Overrides Sub ConfigureUI_EnabledDisabled()
            MyBase.ConfigureUI_EnabledDisabled()
            Dim AllowEdit As Boolean = True
            If mCurrent Is Nothing Then AllowEdit = False
            If AllowEdit = True Then
                Button_Refresh_DisplayName.Enabled = (AdvancedEditLocked = False)
                Button_Refresh_Help.Enabled = (AdvancedEditLocked = False)
                Button_Refresh_Tooltip.Enabled = (AdvancedEditLocked = False)
                Edit_DisplayNameKey.ReadOnly = AdvancedEditLocked
                Edit_ToolTipKey.ReadOnly = AdvancedEditLocked
                Edit_HelpKey.ReadOnly = AdvancedEditLocked
            Else

            End If
            If AllowEdit = True AndAlso Current_Content.IsCustom = True Then

            Else

            End If
        End Sub
#End Region

#Region "Load Content"
        Overrides Function LoadContent(ClassType As COH_ProjectContent, FileName As String) As Boolean
            Current_Content = ContentController.Retrieve_ModableContent(FileName, COH_ProjectContent.PowerSets)
            Return DisplayContent()
        End Function
#End Region

#Region "Display"
        Private Function DisplayContent() As Boolean
            Cursor.Current = Cursors.WaitCursor
            If (Current_Content Is Nothing) = False Then
                mCurrent = TryCast(Current_Content.Content, Characters.Powers.COH_PowerSet).Clone
                Display_CurrentStruct()
                Display_PowerSet()
                ConfigureUI_EnabledDisabled()
                Cursor.Current = Cursors.Default
                Return True
            Else
                Clear_CurrentStruct()
                ConfigureUI_EnabledDisabled()
                Cursor.Current = Cursors.Default
                Return False
            End If
        End Function
        Private Function Display_PowerSet() As Boolean
            Cursor.Current = Cursors.WaitCursor
            Changes_Locked = True
            Edit_IsCustom.Checked = Current_Content.IsCustom
            Edit_WasModified.Checked = Current_Content.WasModified_FromSource
            Edit_PowerSetName.Text = mCurrent.Name
            Edit_Icon.Text = mCurrent.IconName
            Edit_DisplayName.Text = mCurrent.DisplayName.DisplayText
            Edit_DisplayNameKey.Text = mCurrent.DisplayName.Key
            Edit_Help.Text = mCurrent.DisplayHelp.DisplayText
            Edit_HelpKey.Text = mCurrent.DisplayHelp.Key
            Edit_ToolTip.Text = mCurrent.DisplayShortHelp.DisplayText
            Edit_ToolTipKey.Text = mCurrent.DisplayShortHelp.Key
            Edit_FullName.Text = mCurrent.FullName
            Edit_SourceFile.Text = mCurrent.SourceFile
            Edit_AccountRequires.Text = mCurrent.SetAccountRequires
            Edit_AccountToolTip.Text = mCurrent.SetAccountTooltip
            Edit_Product.Text = mCurrent.SetAccountProduct
            Edit_PurchaseFailed.Text = mCurrent.SetBuyRequiresFailedText

            Edit_LockedKey.Text = mCurrent.SetAccountTooltip.Key

            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_PurchaseRequirements, mCurrent.SetBuyRequires)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Costume_Keys, mCurrent.CostumeKeys)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Costume_Parts, mCurrent.CostumeParts)
            Edit_ShowInfo.Checked = mCurrent.ShowInInfo
            Edit_ShowManage.Checked = mCurrent.ShowInManage
            Edit_Shared.Checked = mCurrent.Shared
            Edit_SpecializedAt.Value = mCurrent.SpecializeAt
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_SpecializedReq, mCurrent.SpecializeRequires)
            Edit_ForceLevel.Value = mCurrent.ForceLevelBought
            Select_Inventory.Text = mCurrent.ShowInInventory.ToString
            Select_PowerSystem.Text = mCurrent.System.ToString
            ' Select_Inventory 
            DisplayIcon()
            Display_PowerTable()
            ButtonPressed_Preview()
            Changes_Locked = False
            Cursor.Current = Cursors.Default
            Return True
        End Function
        Private Sub DisplayIcon()
            Dim FileNAme = ContentController.TheController_Assets.RetrieveAsset_FilePath(IO.Path.GetFileNameWithoutExtension(mCurrent.IconName), COH_Supported_ContentType.Unknown)
            If String.IsNullOrEmpty(FileNAme) = False Then
                Dim theResource As COH_FileStructure = ContentController.TheController_Assets.RetrieveAsset_ImageStruct(FileNAme)
                If TypeOf theResource Is COH_Resource_Texture Then
                    mIcon = New Bitmap(TryCast(theResource, COH_Resource_Texture).Extract_Resource_Texture)
                ElseIf TypeOf theResource Is COH_Resource_TGA Then
                    mIcon = New Bitmap(TryCast(theResource, COH_Resource_TGA).Extract_Resource_Texture)
                End If
                PictureBox1.BackgroundImage = mIcon
            Else
                PictureBox1.BackgroundImage = Nothing
            End If
        End Sub
        Private Sub Display_PowerTable()
            Edit_PowerTable.Rows.Clear()
            Dim Avail As String = "-"
            Dim AIMaxLevel As String = "-"
            Dim MinRank As String = "-"
            Dim AIMaxCon As String = "-"
            Dim MinDiff As String = "-"
            Dim MaxDiff As String = "-"
            For X = 0 To mCurrent.Powers.Count - 1
                If mCurrent.Available.Count = 0 Then
                    Edit_PowerTable.Rows.Add(New Object(6) {mCurrent.Powers(X), 0, 0, 0, 0, 0, 0})
                Else
                    Dim Values As New List(Of String)
                    Avail = If(mCurrent.Available.Count > X, mCurrent.Available(X), "-")
                    AIMaxLevel = If(mCurrent.AIMaxLevel.Count > X, mCurrent.AIMaxLevel(X), "-")
                    MinRank = If(mCurrent.AIMinRankCon.Count > X, mCurrent.AIMinRankCon(X), "-")
                    AIMaxCon = If(mCurrent.AIMaxRankCon.Count > X, mCurrent.AIMaxRankCon(X), "-")
                    MinDiff = If(mCurrent.MinDifficulty.Count > X, mCurrent.MinDifficulty(X), "-")
                    MaxDiff = If(mCurrent.MaxDifficulty.Count > X, mCurrent.MaxDifficulty(X), "-")
                    Edit_PowerTable.Rows.Add(New Object(6) {mCurrent.Powers(X), Avail, AIMaxLevel, MinRank, AIMaxCon, MinDiff, MaxDiff})
                End If
            Next
        End Sub
#End Region

#Region "Control Editing - General"
        Private Sub Edit_PowerSetName_TextChanged(sender As Object, e As EventArgs) Handles Edit_PowerSetName.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.Name = Edit_PowerSetName.Text
            WasModified()
        End Sub
        Private Sub Edit_Icon_TextChanged(sender As Object, e As EventArgs) Handles Edit_Icon.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.IconName = Edit_Icon.Text
            DisplayIcon()
            WasModified()
        End Sub
        Private Sub Edit_FullName_TextChanged(sender As Object, e As EventArgs) Handles Edit_FullName.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.FullName = Edit_FullName.Text
            WasModified()
        End Sub
        Private Sub Edit_SourceFile_TextChanged(sender As Object, e As EventArgs) Handles Edit_SourceFile.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.SourceFile = Edit_SourceFile.Text
            WasModified()
        End Sub
        Private Sub Edit_Product_TextChanged(sender As Object, e As EventArgs) Handles Edit_Product.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.SetAccountProduct = Edit_Product.Text
            WasModified()
        End Sub
        Private Sub Edit_AccountRequires_TextChanged(sender As Object, e As EventArgs) Handles Edit_AccountRequires.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.SetAccountRequires = Edit_AccountRequires.Text
            WasModified()
        End Sub
#End Region

#Region "Control Editing - PString"
        Private Sub Button_Refresh_DisplayName_Click(sender As Object, e As EventArgs) Handles Button_Refresh_DisplayName.Click
            If Changes_Locked = True Then Exit Sub
            Changes_Locked = True
            Edit_DisplayNameKey.Text = ContentController.TheController_Localize.CreateKey(Edit_DisplayName.Text)
            Update_PString_DisplayName()
        End Sub
        Private Sub Button_Refresh_Tooltip_Click(sender As Object, e As EventArgs) Handles Button_Refresh_Tooltip.Click
            If Changes_Locked = True Then Exit Sub
            Changes_Locked = True
            Edit_ToolTipKey.Text = ContentController.TheController_Localize.CreateKey(Edit_ToolTip.Text)
            Update_PString_ShortHelp()
        End Sub
        Private Sub Button_Refresh_Help_Click(sender As Object, e As EventArgs) Handles Button_Refresh_Help.Click
            If Changes_Locked = True Then Exit Sub
            Changes_Locked = True
            Edit_HelpKey.Text = ContentController.TheController_Localize.CreateKey(Edit_Help.Text)
            Update_PString_Help()
        End Sub
        Private Sub Button_Refresh_LockedTooltip_Click(sender As Object, e As EventArgs) Handles Button_Refresh_LockedTooltip.Click
            If Changes_Locked = True Then Exit Sub
            Changes_Locked = True
            Edit_LockedKey.Text = ContentController.TheController_Localize.CreateKey(Edit_AccountToolTip.Text)
            Update_PString_Locked()
        End Sub
        Private Sub Edit_LockedKey_TextChanged(sender As Object, e As EventArgs) Handles Edit_LockedKey.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_Locked()
        End Sub
        Private Sub Edit_AccountToolTip_TextChanged(sender As Object, e As EventArgs) Handles Edit_AccountToolTip.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_ShortHelp()
        End Sub
        Private Sub Edit_DisplayName_TextChanged(sender As Object, e As EventArgs) Handles Edit_DisplayName.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_DisplayName()
        End Sub
        Private Sub Edit_DisplayNameKey_TextChanged(sender As Object, e As EventArgs) Handles Edit_DisplayNameKey.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_DisplayName()
        End Sub
        Private Sub Edit_Tooltip_TextChanged(sender As Object, e As EventArgs) Handles Edit_ToolTip.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_ShortHelp()
        End Sub
        Private Sub Edit_ToolTipKey_TextChanged(sender As Object, e As EventArgs) Handles Edit_ToolTipKey.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_ShortHelp()
        End Sub
        Private Sub Edit_Help_TextChanged(sender As Object, e As EventArgs) Handles Edit_Help.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_Help()
        End Sub
        Private Sub Edit_HelpKey_TextChanged(sender As Object, e As EventArgs) Handles Edit_HelpKey.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_Help()
        End Sub
        Private Sub Update_PString_Locked()
            Dim NewItem As New CrypticS_String(Edit_LockedKey.Text, Edit_AccountToolTip.Text)
            mCurrent.SetAccountTooltip = NewItem
            Changes_Locked = True
            Edit_AccountToolTip.Text = mCurrent.SetAccountTooltip.DisplayText
            Edit_LockedKey.Text = mCurrent.SetAccountTooltip.Key
            Changes_Locked = False
            WasModified()
        End Sub
        Private Sub Update_PString_DisplayName()
            Dim NewItem As New CrypticS_String(Edit_DisplayNameKey.Text, Edit_DisplayName.Text)
            mCurrent.DisplayName = NewItem
            Changes_Locked = True
            Edit_DisplayName.Text = mCurrent.DisplayName.DisplayText
            Edit_DisplayNameKey.Text = mCurrent.DisplayName.Key
            Changes_Locked = False
            WasModified()
        End Sub
        Private Sub Update_PString_Help()
            Dim NewItem As New CrypticS_String(Edit_HelpKey.Text, Edit_Help.Text)
            mCurrent.DisplayHelp = NewItem
            Changes_Locked = True
            Edit_Help.Text = mCurrent.DisplayHelp.DisplayText
            Edit_HelpKey.Text = mCurrent.DisplayHelp.Key
            Changes_Locked = False
            WasModified()
        End Sub
        Private Sub Update_PString_ShortHelp()
            Dim NewItem As New CrypticS_String(Edit_ToolTipKey.Text, Edit_ToolTip.Text)
            mCurrent.DisplayShortHelp = NewItem
            Changes_Locked = True
            Edit_ToolTip.Text = mCurrent.DisplayShortHelp.DisplayText
            Edit_ToolTipKey.Text = mCurrent.DisplayShortHelp.Key
            Changes_Locked = False
            WasModified()
        End Sub
#End Region

#Region "Control Editing - other"
        Private Sub Edit_Shared_CheckedChanged(sender As Object, e As EventArgs) Handles Edit_Shared.CheckedChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.Shared = Edit_Shared.Checked
            WasModified()
        End Sub
        Private Sub Edit_ShowInfo_CheckedChanged(sender As Object, e As EventArgs) Handles Edit_ShowInfo.CheckedChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.ShowInInfo = Edit_Shared.Checked
            WasModified()
        End Sub
        Private Sub Edit_ShowManage_CheckedChanged(sender As Object, e As EventArgs) Handles Edit_ShowManage.CheckedChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.ShowInManage = Edit_Shared.Checked
            WasModified()
        End Sub
        Private Sub Edit_ForceLevel_ValueChanged(sender As Object, e As EventArgs) Handles Edit_ForceLevel.ValueChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.ForceLevelBought = Edit_ForceLevel.Value
            WasModified()
        End Sub
        Private Sub Edit_SpecializedAt_ValueChanged(sender As Object, e As EventArgs) Handles Edit_SpecializedAt.ValueChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.SpecializeAt = Edit_ForceLevel.Value
            WasModified()
        End Sub
        Private Sub Select_Inventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Inventory.SelectedIndexChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.ShowInInventory = Select_Inventory.SelectedItem
            WasModified()
        End Sub
        Private Sub Select_PowerSystem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_PowerSystem.SelectedIndexChanged
            If Changes_Locked = True Then Exit Sub
            mCurrent.System = Select_PowerSystem.SelectedItem
            WasModified()
        End Sub
#End Region

#Region "Overrides - Buttons"
        Protected Overrides Sub ButtonPressed_Undo()
            DisplayContent()
        End Sub
        Protected Overrides Sub ButtonPressed_Save()
            Cursor.Current = Cursors.WaitCursor
            Current_Content.Content = mCurrent
            Current_Content.WasModified_FromSource = True
            '//ALL LINKED CONTENT WOULD NEED TO BE LOADED AND UPDATED HERE, IF GO THAT FAR
            If Current_Content.Save() = False Then
                GameContent.ShowMessage("Unable to Save")
            Else
                GameContent.ShowMessage("Save Complete")
            End If
            Cursor.Current = Cursors.Default
        End Sub
#End Region


    End Class
End Namespace