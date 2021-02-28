Imports COH.CodeManagement.Enums.Structures
Imports COH.GameContent.Structures.Characters
Imports COH.GameContent.Structures.Characters.Attributes
Imports COH.GameContent.Structures.Resources.Textures
Imports COH.Storage.Structures
Imports COH.Storage.Structures.Generics
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums

Namespace Toolkit.Modding.Editors
    Public Class COH_CharacterClass_Editor

#Region "Properties"
        Protected Overrides ReadOnly Property Current_Struct As COH_FileStructure
            Get
                Return mCharacterClass_Current
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private WithEvents mCharacterClass_Current As COH_CharacterClass
        Private mIcon As Image
#End Region

#Region "Initialize"
        Public Sub New()
            Me.New(Nothing)
        End Sub
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
            Helperfunctions.Toolkit.Structs.Display_InCheckListBox_CharacterOrigins(Select_Allowed_Origins, ContentController)
            Display_InCombos()
            ConfigureUI_Tooltips()
            ConfigureUI_Table_BaseAttributes()
            ConfigureUI_Table_TableAttributes()
            ConfigureUI_Table_NamedTable()
            ConfigureUI_EnabledDisabled()
            Changes_Locked = False
        End Sub
        Private Sub Display_InCombos()
            Dim AllAllowed_Epic As New List(Of String) : AllAllowed_Epic.Add("Epic")
            Dim AllAllowed_Pool As New List(Of String) : AllAllowed_Pool.Add("Pool")
            Dim AllAllowed_Restrictions As New List(Of String)
            AllAllowed_Restrictions.Add("Class_Lt_Grunt")
            AllAllowed_Restrictions.Add("Class_Boss_Grunt")
            AllAllowed_Restrictions.Add("Class_Boss_Elite")
            AllAllowed_Restrictions.Add("Class_Lt_PraetorianGrunt")
            AllAllowed_Restrictions.Add("Class_Boss_PraetorianGrunt")
            AllAllowed_Restrictions.Add("Class_Boss_PraetorianElite")
            Helperfunctions.Toolkit.Controls.Lists.Fill_ComboBox(Select_EpicPool, AllAllowed_Epic)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ComboBox(Select_Pool, AllAllowed_Pool)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ChecklistBox(Select_Restrictions, AllAllowed_Restrictions)
        End Sub
        Private Sub ConfigureUI_Tooltips()
            With FormToolTip
                .SetToolTip(Select_Allowed_Origins, "This determins what origins can be picked by the player")
                .SetToolTip(Select_Restrictions, "This is a string array of special restrictions (e.g. Kheldian, Avian, etc)")
                .SetToolTip(Edit_StoreRequires, "This is a string of store restrictions")
                .SetToolTip(Edit_Locked, "This message is displayed to the user if this AT is locked describing what they can do to unlock it")
                .SetToolTip(Edit_ProductCode, "Product code that will be used for the purchase option if this AT is locked")
                .SetToolTip(Edit_ReductionClass, "Class that is used for mission difficulty reduction purposes")
                .SetToolTip(Edit_ReduceAV, "Class uses AV flag for mission difficulty reduction purposes")
                .SetToolTip(Edit_HPStatus, "Gang together hit points and status points. Modifications to hit points will affect status points and vice-versa. Hit points are are set to be the same as status points.")
                .SetToolTip(Edit_Defiant, "Scale applied to damage before it's removed from the DefiantHitPointsAttrib.")
                .SetToolTip(Edit_Primary, "Categories of powers available to the character")
                .SetToolTip(Edit_Secondary, "Categories of powers available to the character")
                .SetToolTip(Select_Pool, "Always Pool")
                .SetToolTip(Select_EpicPool, "Always Empty, but internally always EPIC")
            End With
        End Sub
        Private Sub ConfigureUI_Table_BaseAttributes()
            Dim ColumnWidth As Integer = 80
            Edit_BaseAttributes.Columns.Clear()
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Default", .Width = ColumnWidth})
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Base", .Width = ColumnWidth})
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Min", .Width = ColumnWidth})
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Strength (Min)", .Width = ColumnWidth})
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Resistence (Min)", .Width = ColumnWidth})
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Dim Strength (IN)", .Width = ColumnWidth})
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Dim Strength (Out)", .Width = ColumnWidth})
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Dim Resistance (IN)", .Width = ColumnWidth})
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Dim Resistance (Out)", .Width = ColumnWidth})
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Dim Cur (IN)", .Width = ColumnWidth})
            Edit_BaseAttributes.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Dim Cur (Out)", .Width = ColumnWidth})
            Dim info() As Reflection.PropertyInfo = GetType(COH_CharacterClass_Attributes).GetProperties()
            Dim RowIndex As Integer = 0
            For Each SingleInfo In info
                If SingleInfo.PropertyType = GetType(Single) Then
                    Edit_BaseAttributes.Rows.Add()
                    Edit_BaseAttributes.Rows(RowIndex).HeaderCell.Value = SingleInfo.Name
                    RowIndex += 1
                End If
            Next
        End Sub
        Private Sub ConfigureUI_Table_TableAttributes()
            With Select_Attributes
                .BeginUpdate()
                .Items.Clear()
                .Items.Add("Attribute Max Table")
                .Items.Add("Attribute Max Max Table")
                .Items.Add("Attribute Strength Max Table")
                .Items.Add("Attribute Resistance Max Table")
                .EndUpdate()
                .SelectedIndex = 0
            End With
            Dim ColumnWidth As Integer = 80
            Edit_AttributesTable.Columns.Clear()
            For X = 0 To 54
                Edit_AttributesTable.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = (X + 1).ToString, .Width = ColumnWidth})
            Next
            Dim info() As Reflection.PropertyInfo = GetType(COH_CharacterClass_AttributesTable).GetProperties()
            Dim RowIndex As Integer = 0
            For Each SingleInfo In info
                If SingleInfo.PropertyType = GetType(Single()) Then
                    Edit_AttributesTable.Rows.Add()
                    Edit_AttributesTable.Rows(RowIndex).HeaderCell.Value = SingleInfo.Name
                    RowIndex += 1
                End If
            Next
        End Sub
        Private Sub ConfigureUI_Table_NamedTable()
            Dim ColumnWidth As Integer = 80
            Edit_NamedTable.Columns.Clear()
            Edit_NamedTable.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Description", .Width = 240, .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells})
            For X = 0 To 54
                Edit_NamedTable.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = (X + 1).ToString, .Width = ColumnWidth})
            Next
        End Sub
        Private Sub ContentWasModified() Handles mCharacterClass_Current.WasModified
            If Changes_Locked = True Then Exit Sub
            WasModified()
        End Sub
#End Region

#Region "Configure UI Enabled/Disabled"
        Public Overrides Sub ConfigureUI_EnabledDisabled()
            MyBase.ConfigureUI_EnabledDisabled()
            Dim AllowEdit As Boolean = True
            If mCharacterClass_Current Is Nothing Then AllowEdit = False
            TabControl2.Enabled = AllowEdit
            If AllowEdit = True Then
                Button_Refresh_DisplayName.Enabled = (AdvancedEditLocked = False)
                Button_Refresh_Help.Enabled = (AdvancedEditLocked = False)
                Button_Refresh_Tooltip.Enabled = (AdvancedEditLocked = False)
                Edit_DisplayNameKey.ReadOnly = AdvancedEditLocked
                Edit_ToolTipKey.ReadOnly = AdvancedEditLocked
                Edit_HelpKey.ReadOnly = AdvancedEditLocked
            Else
                Edit_ClassName.ReadOnly = True
            End If
            If AllowEdit = True AndAlso Current_Content.IsCustom = True Then
                Edit_ClassName.ReadOnly = False
                Edit_Primary.ReadOnly = False
                Edit_Secondary.ReadOnly = False
            Else
                Edit_ClassName.ReadOnly = True
                Edit_Primary.ReadOnly = True
                Edit_Secondary.ReadOnly = True
            End If
        End Sub
#End Region

#Region "Load Content"
        Overrides Function LoadContent(ClassType As COH_ProjectContent, FileName As String) As Boolean
            Select Case ClassType
                Case COH_ProjectContent.CharacterClasses_PlayerClasses
                    Current_Content = ContentController.Retrieve_ModableContent(FileName, COH_ProjectContent.CharacterClasses_PlayerClasses)
                Case COH_ProjectContent.CharacterClasses_EnemyClass
                    Current_Content = ContentController.Retrieve_ModableContent(FileName, COH_ProjectContent.CharacterClasses_EnemyClass)
            End Select
            Return DisplayContent()
        End Function
#End Region

#Region "Display"
        Public Function DisplayContent() As Boolean
            Cursor.Current = Cursors.WaitCursor
            If (Current_Content Is Nothing) = False Then
                mCharacterClass_Current = TryCast(Current_Content.Content, COH_CharacterClass).Clone
                Display_CurrentStruct()
                Display_CharacterClass()
                ConfigureUI_EnabledDisabled()
                Return True
            Else
                Clear_CurrentStruct()
                ConfigureUI_EnabledDisabled()
                Return False
            End If
            Cursor.Current = Cursors.Default
        End Function
        Private Sub Display_CharacterClass()
            Cursor.Current = Cursors.WaitCursor
            Changes_Locked = True
            DisplayIcon()
            Edit_DisplayName.Text = mCharacterClass_Current.DisplayName.DisplayText
            Edit_DisplayNameKey.Text = mCharacterClass_Current.DisplayName.Key
            Edit_ClassName.Text = mCharacterClass_Current.Name
            Edit_Primary.Text = mCharacterClass_Current.PrimaryCategory
            Edit_Secondary.Text = mCharacterClass_Current.SecondaryCategory
            Select_Pool.Text = mCharacterClass_Current.PowerPoolCategory
            Edit_Tooltip.Text = mCharacterClass_Current.DisplayShortHelp.DisplayText
            Edit_ToolTipKey.Text = mCharacterClass_Current.DisplayShortHelp.Key
            Edit_Help.Text = mCharacterClass_Current.DisplayHelp.DisplayText
            Edit_HelpKey.Text = mCharacterClass_Current.DisplayHelp.Key
            Edit_Icon.Text = mCharacterClass_Current.Icon
            Edit_Locked.Text = mCharacterClass_Current.LockedTooltip.DisplayText
            Edit_LockedKey.Text = mCharacterClass_Current.LockedTooltip.Key
            Edit_ProductCode.Text = mCharacterClass_Current.ProductCode
            Edit_StoreRequires.Text = mCharacterClass_Current.StoreRequires
            ' Edit_Respecs.Text = mCharacterClass_Current.LevelUpRespecs
            Edit_ReduceAV.Checked = mCharacterClass_Current.ReduceAsArchvillain
            Edit_HPStatus.Checked = mCharacterClass_Current.ConnectHPAndStatus
            Edit_ReductionClass.Text = mCharacterClass_Current.ReductionClass
            Edit_Defiant.Value = mCharacterClass_Current.DefiantScale
            Select_Allowed_Origins.PerformMatch_CheckList(mCharacterClass_Current.AllowedOrigins)
            Select_Restrictions.PerformMatch_CheckList(mCharacterClass_Current.SpecialRestrictions)
            Display_Attributes_Base()
            Display_Attributes_Table(Select_Attributes.SelectedIndex)
            Display_NamedTable()
            Display_LevelRespecs()
            ButtonPressed_Preview()
            Changes_Locked = False
            Cursor.Current = Cursors.Default
        End Sub
        Private Sub DisplayIcon()
            Dim FileNAme = ContentController.TheController_Assets.RetrieveAsset_FilePath(IO.Path.GetFileNameWithoutExtension(mCharacterClass_Current.Icon), COH_Supported_ContentType.Unknown)
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
        Private Sub Display_Attributes_Base()
            Dim DefaultAttrib As New COH_CharacterClass_Attributes
            FillTable_FromAttrib(DefaultAttrib, Edit_BaseAttributes, 0)
            FillTable_FromAttrib(mCharacterClass_Current.AttribBase, Edit_BaseAttributes, 1)
            FillTable_FromAttrib(mCharacterClass_Current.AttribMin, Edit_BaseAttributes, 2)
            FillTable_FromAttrib(mCharacterClass_Current.StrengthMin, Edit_BaseAttributes, 3)
            FillTable_FromAttrib(mCharacterClass_Current.ResistanceMin, Edit_BaseAttributes, 4)

            FillTable_FromAttrib(mCharacterClass_Current.AtrribDiminStrIn, Edit_BaseAttributes, 5)
            FillTable_FromAttrib(mCharacterClass_Current.AtrribDiminStrOut, Edit_BaseAttributes, 6)
            FillTable_FromAttrib(mCharacterClass_Current.AtrribDiminResIn, Edit_BaseAttributes, 7)
            FillTable_FromAttrib(mCharacterClass_Current.AtrribDiminResOut, Edit_BaseAttributes, 8)
            FillTable_FromAttrib(mCharacterClass_Current.AtrribDiminCurIn, Edit_BaseAttributes, 9)
            FillTable_FromAttrib(mCharacterClass_Current.AtrribDiminCurOut, Edit_BaseAttributes, 10)
        End Sub
        Private Sub FillTable_FromAttrib(Source As COH_CharacterClass_Attributes, Table As DataGridView, ColumnIndex As Integer)
            Dim info() As Reflection.PropertyInfo = GetType(COH_CharacterClass_Attributes).GetProperties()
            Dim RowIndex As Integer = 0
            For Each Item In info
                If Item.PropertyType = GetType(Single) Then
                    Table.Rows(RowIndex).Cells.Item(ColumnIndex).Value = Item.GetValue(Source, Nothing)
                    RowIndex += 1
                End If
            Next
        End Sub
        Private Sub Display_Attributes_Table(Index As Integer)
            Dim Source As COH_CharacterClass_AttributesTable = Nothing
            Select Case Index
                Case 0
                    Source = mCharacterClass_Current.AttribMaxTable
                Case 1
                    Source = mCharacterClass_Current.AttribMaxMaxTable
                Case 2
                    Source = mCharacterClass_Current.StrengthMaxTable
                Case 3
                    Source = mCharacterClass_Current.ResistanceMaxTable
            End Select
            FillTable_FromAttribTable(Source, Edit_AttributesTable)
        End Sub
        Private Sub FillTable_FromAttribTable(Source As COH_CharacterClass_AttributesTable, Table As DataGridView)
            Dim info() As Reflection.PropertyInfo = GetType(COH_CharacterClass_AttributesTable).GetProperties()
            Dim RowIndex As Integer = 0
            For Each Item In info
                If Item.PropertyType Is GetType(Single()) Then
                    Dim CurrentAttrib As Single() = Item.GetValue(Source, Nothing)
                    For X = 0 To CurrentAttrib.Count - 1
                        Table.Rows(RowIndex).Cells.Item(X).Value = CurrentAttrib(X)
                        Table.Rows(RowIndex).Cells.Item(X).ReadOnly = False
                    Next
                    For X = CurrentAttrib.Count To 54
                        Table.Rows(RowIndex).Cells.Item(X).Value = "-"
                        Table.Rows(RowIndex).Cells.Item(X).ReadOnly = True
                    Next
                    RowIndex += 1
                End If
            Next
        End Sub
        Private Sub Display_NamedTable()
            Edit_NamedTable.Rows.Clear()
            Dim RowIndex As Integer = 0
            For Each Item In mCharacterClass_Current.ModTable
                Edit_NamedTable.Rows.Add(New Object(0) {Item.Name})
                For X = 0 To Item.Values.Count - 1
                    Edit_NamedTable.Rows(RowIndex).Cells.Item(X + 1).Value = Item.Values(X)
                    Edit_NamedTable.Rows(RowIndex).Cells.Item(X + 1).ReadOnly = False
                Next
                For X = Item.Values.Count To 54
                    Edit_NamedTable.Rows(RowIndex).Cells.Item(X + 1).Value = "-"
                    Edit_NamedTable.Rows(RowIndex).Cells.Item(X + 1).ReadOnly = True
                Next
                RowIndex += 1
            Next
        End Sub
        Private Sub Display_LevelRespecs()
            Edit_RespecAtlevels.Items.Clear()
            For X = 0 To mCharacterClass_Current.LevelUpRespecs.Count - 1
                Edit_RespecAtlevels.Items.Add(mCharacterClass_Current.LevelUpRespecs(X))
            Next
        End Sub
#End Region

#Region "Editing - General"
        Private Sub Edit_ClassName_TextChanged(sender As Object, e As EventArgs) Handles Edit_ClassName.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.Name = Edit_ClassName.Text
            WasModified()
        End Sub
        Private Sub Edit_Icon_TextChanged(sender As Object, e As EventArgs) Handles Edit_Icon.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.Icon = Edit_Icon.Text
            DisplayIcon()
            WasModified()
        End Sub
#End Region

#Region "Editing - Powers"
        Private Sub Edit_Primary_TextChanged(sender As Object, e As EventArgs) Handles Edit_Primary.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.PrimaryCategory = Edit_Primary.Text
            WasModified()
        End Sub
        Private Sub Edit_Secondary_TextChanged(sender As Object, e As EventArgs) Handles Edit_Secondary.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.SecondaryCategory = Edit_Secondary.Text
            WasModified()
        End Sub
        Private Sub Edit_HPStatus_CheckedChanged(sender As Object, e As EventArgs) Handles Edit_HPStatus.CheckedChanged
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.ConnectHPAndStatus = Edit_HPStatus.Checked
            WasModified()
        End Sub
        Private Sub Edit_ReduceAV_CheckedChanged(sender As Object, e As EventArgs) Handles Edit_ReduceAV.CheckedChanged
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.ReduceAsArchvillain = Edit_ReduceAV.Checked
            WasModified()
        End Sub
        Private Sub Edit_ReductionClass_TextChanged(sender As Object, e As EventArgs) Handles Edit_ReductionClass.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.ReductionClass = Edit_ReductionClass.Text
            WasModified()
        End Sub
        Private Sub Edit_Defiant_ValueChanged(sender As Object, e As EventArgs) Handles Edit_Defiant.ValueChanged
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.DefiantScale = Edit_Defiant.Value
            WasModified()
        End Sub
#End Region

#Region "Editing Restrictions"
        Private Sub Select_Allowed_Origins_Changed() Handles Select_Allowed_Origins.AfterItemChecked
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.AllowedOrigins = Select_Allowed_Origins.Retrieve_CheckedItems_Strings
            WasModified()
        End Sub
        Private Sub Select_Restrictions_SelectedIndexChanged() Handles Select_Restrictions.AfterItemChecked
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.SpecialRestrictions = Select_Restrictions.Retrieve_CheckedItems_Strings
            WasModified()
        End Sub
        Private Sub Edit_ProductCode_TextChanged(sender As Object, e As EventArgs) Handles Edit_ProductCode.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.ProductCode = Edit_ProductCode.Text
            WasModified()
        End Sub
        Private Sub Edit_StoreRequires_TextChanged(sender As Object, e As EventArgs) Handles Edit_StoreRequires.TextChanged
            If Changes_Locked = True Then Exit Sub
            mCharacterClass_Current.StoreRequires = Edit_StoreRequires.Text
            WasModified()
        End Sub
#End Region

#Region "Editing - PStrings"
        Private Sub Button_Refresh_DisplayName_Click(sender As Object, e As EventArgs) Handles Button_Refresh_DisplayName.Click
            If Changes_Locked = True Then Exit Sub
            Changes_Locked = True
            Edit_DisplayNameKey.Text = ContentController.TheController_Localize.CreateKey(Edit_DisplayName.Text)
            Update_PString_DisplayName()
        End Sub
        Private Sub Button_Refresh_Tooltip_Click(sender As Object, e As EventArgs) Handles Button_Refresh_Tooltip.Click
            If Changes_Locked = True Then Exit Sub
            Changes_Locked = True
            Edit_ToolTipKey.Text = ContentController.TheController_Localize.CreateKey(Edit_Tooltip.Text)
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
            Edit_LockedKey.Text = ContentController.TheController_Localize.CreateKey(Edit_Locked.Text)
            Update_PString_Locked()
        End Sub
        Private Sub Edit_DisplayName_TextChanged(sender As Object, e As EventArgs) Handles Edit_DisplayName.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_DisplayName()
        End Sub
        Private Sub Edit_Tooltip_TextChanged(sender As Object, e As EventArgs) Handles Edit_Tooltip.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_ShortHelp()
        End Sub
        Private Sub Edit_Help_TextChanged(sender As Object, e As EventArgs) Handles Edit_Help.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_Help()
        End Sub
        Private Sub Edit_Locked_TextChanged(sender As Object, e As EventArgs) Handles Edit_Locked.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_Locked()
        End Sub
        Private Sub Edit_DisplayNameKey_TextChanged(sender As Object, e As EventArgs) Handles Edit_DisplayNameKey.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_DisplayName()
        End Sub
        Private Sub Edit_ToolTipKey_TextChanged(sender As Object, e As EventArgs) Handles Edit_ToolTipKey.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_ShortHelp()
        End Sub
        Private Sub Edit_HelpKey_TextChanged(sender As Object, e As EventArgs) Handles Edit_HelpKey.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_Help()
        End Sub
        Private Sub Edit_LockedKey_TextChanged(sender As Object, e As EventArgs) Handles Edit_LockedKey.TextChanged
            If Changes_Locked = True Then Exit Sub
            Update_PString_Locked()
        End Sub
        Private Sub Update_PString_DisplayName()
            Dim NewItem As New CrypticS_String(Edit_DisplayNameKey.Text, Edit_DisplayName.Text)
            mCharacterClass_Current.DisplayName = NewItem
            Changes_Locked = True
            Edit_DisplayName.Text = mCharacterClass_Current.DisplayName.DisplayText
            Edit_DisplayNameKey.Text = mCharacterClass_Current.DisplayName.Key
            Changes_Locked = False
            WasModified()
        End Sub
        Private Sub Update_PString_Help()
            Dim NewItem As New CrypticS_String(Edit_HelpKey.Text, Edit_Help.Text)
            mCharacterClass_Current.DisplayHelp = NewItem
            Changes_Locked = True
            Edit_Help.Text = mCharacterClass_Current.DisplayHelp.DisplayText
            Edit_HelpKey.Text = mCharacterClass_Current.DisplayHelp.Key
            Changes_Locked = False
            WasModified()
        End Sub
        Private Sub Update_PString_ShortHelp()
            Dim NewItem As New CrypticS_String(Edit_ToolTipKey.Text, Edit_Tooltip.Text)
            mCharacterClass_Current.DisplayShortHelp = NewItem
            Changes_Locked = True
            Edit_Tooltip.Text = mCharacterClass_Current.DisplayShortHelp.DisplayText
            Edit_ToolTipKey.Text = mCharacterClass_Current.DisplayShortHelp.Key
            Changes_Locked = False
            WasModified()
        End Sub
        Private Sub Update_PString_Locked()
            Dim NewItem As New CrypticS_String(Edit_LockedKey.Text, Edit_Locked.Text)
            mCharacterClass_Current.LockedTooltip = NewItem
            Changes_Locked = True
            Edit_Locked.Text = mCharacterClass_Current.LockedTooltip.DisplayText
            Edit_LockedKey.Text = mCharacterClass_Current.LockedTooltip.Key
            Changes_Locked = False
            WasModified()
        End Sub

#End Region

#Region "Control Usage"
        Private Sub Select_Attributes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Attributes.SelectedIndexChanged
            If Changes_Locked = True Then Exit Sub
            Changes_Locked = True
            Cursor.Current = Cursors.WaitCursor
            Display_Attributes_Table(Select_Attributes.SelectedIndex)
            Changes_Locked = False
            Cursor.Current = Cursors.Default
        End Sub
#End Region

#Region "Overrides - Buttons"
        Protected Overrides Sub ButtonPressed_Undo()
            DisplayContent()
        End Sub
        Protected Overrides Sub ButtonPressed_Save()
            Cursor.Current = Cursors.WaitCursor
            Current_Content.WasModified_FromSource = True
            Current_Content.Content = mCharacterClass_Current
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