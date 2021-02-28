Imports COH.GameContent.MessageStores.Structures.LanguageFiles
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Controls.WinForms.Enums

Namespace Toolkit.Modding.Editors
    Public Class COH_MessageStoreEdit

#Region "Private Properties"
        Private mFileSource As String
        Private mMessageStores As COH_LocalizeContent_Controller
        Private mCurrent_Store As COH_MessageStore
        Private mOriginol_Store As COH_MessageStore
        Private mCurrent_Entry As COH_MessageStore_Entry
        Private mOriginol_Entry As COH_MessageStore_Entry
        '//Private mStandardProjectFile As COH_ProjectFile
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
            ConfigureUI_Tooltips()
            Changes_Locked = False
        End Sub
        Private Sub ConfigureUI_Tooltips()
            With FormToolTip
                .SetToolTip(Button_Unlock, "Unlock Editing")
                .SetToolTip(Button_Refresh, "Generate New ID")
            End With
        End Sub
        Public Overrides Sub Finish()
            MyBase.Finish()
        End Sub
#End Region

#Region "Prepare Usage"
        Public Sub Prepare_Editor(ByRef TheMessageStores As COH_LocalizeContent_Controller, Optional Search As String = Nothing)
            Changes_Locked = True
            mMessageStores = TheMessageStores
            UpdateContentModified()
            DisplayAvailableMessageStores()
            ClearDisplay()
            If Not Search Is Nothing Then
                Changes_Locked = True
                Edit_Find.Text = Search
                Search_ForID(Edit_Find.Text)
            End If
            Changes_Locked = False
        End Sub
        Private Sub DisplayAvailableMessageStores()
            Select_MessageStore.Items.Clear()
            Select_MessageStore.BeginUpdate()
            Select_MessageStore.Items.Clear()
            For Each Entry In mMessageStores.MessageStores
                Select_MessageStore.Items.Add(Entry.Key)
            Next
            Select_MessageStore.EndUpdate()
            If Select_MessageStore.Items.Count > 0 Then Select_MessageStore.SelectedIndex = 0
            ChangeMessageStore()
        End Sub
#End Region

#Region "Configure Editor"
        Private Sub ChangeMessageStore()
            If Select_MessageStore.Items.Count = 0 Then Exit Sub
            mCurrent_Store = mMessageStores.MessageStores(Select_MessageStore.SelectedIndex).Value '//Worry about Cloning later
            Label_NumEntries.Text = mCurrent_Store.Table.Count & " Entries"
            ClearDisplay()
            UpdateContentModified()
        End Sub
        Private Sub UpdateContentModified()
            Dim ControlsEnabled_Search As Boolean = True
            If Edit_Find.Text.Length < 3 Then ControlsEnabled_Search = False
            Button_Search.Enabled = ControlsEnabled_Search
            Button_AddNewEntry.Enabled = ControlsEnabled_Search
            Panel2.Enabled = Not (mCurrent_Entry Is Nothing)
            If Panel2.Enabled = False Then
                Panel2.BackColor = Color.Gray
            Else
                Panel2.BackColor = Color.LightSteelBlue
            End If
            If (mCurrent_Entry Is Nothing) Then
                Button_Refresh.Enabled = False
                Button_Unlock.Enabled = False
            ElseIf mCurrent_Entry.CustomContent = False Then
                Button_Refresh.Enabled = False
                Button_Unlock.Enabled = True
            Else
                Button_Refresh.Enabled = True
                Button_Unlock.Enabled = True
            End If
        End Sub
#End Region

#Region "Display"
        Private Sub ClearDisplay()
            Changes_Locked = True
            Edit_MessageID.Text = ""
            Edit_Message.Text = ""
            Edit_Help.Text = ""
            Edit_Index1.Text = ""
            Edit_Index2.Text = ""
            View_Variables.Items.Clear()
            Panel2.Enabled = False
            Changes_Locked = False
        End Sub
        Private Sub DisplayCurrentEntry()
            Changes_Locked = True
            Edit_MessageID.ReadOnly = True
            Edit_MessageID.Text = mCurrent_Entry.MessageID
            Dim Message As String = ""
            mCurrent_Store.RetrieveString_Message(mCurrent_Entry.MessageIndex, Message)
            Edit_Message.Text = Message
            mCurrent_Store.RetrieveString_Message(mCurrent_Entry.HelpIndex, Message)
            Edit_Help.Text = Message
            Edit_Index1.Text = mCurrent_Entry.MessageIndex
            Edit_Index2.Text = mCurrent_Entry.HelpIndex
            DisplayVariables()
            If mCurrent_Entry.CustomContent = True Then
                Label_Custom.Text = "Custom Entry"
            Else
                Label_Custom.Text = "Standard Entry"
            End If
            Panel2.Enabled = False
            Changes_Locked = False
        End Sub
        Private Sub DisplayVariables()
            View_Variables.BeginUpdate()
            View_Variables.Items.Clear()
            If mCurrent_Entry.VariableDefNameIndices Is Nothing Then mCurrent_Entry.VariableDefNameIndices = New List(Of COH_MessageStore_EntryVariable)
            For Each Entry In mCurrent_Entry.VariableDefNameIndices
                Dim NewItem As New ListViewItem(Entry.Variable)
                NewItem.SubItems.Add(Entry.Format)
                NewItem.SubItems.Add(Entry.Index)
                View_Variables.Items.Add(NewItem)
            Next
            View_Variables.EndUpdate()
        End Sub
#End Region

#Region "Controls - Search"
        Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
            Search_ForID(Edit_Find.Text)
        End Sub
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Search_ForText(Edit_SearchText.Text)
        End Sub
        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            Search_ForText(Edit_SearchText.Text, True)
        End Sub
        Private Sub Search_ForID(Search As String)
            Cursor.Current = Cursors.WaitCursor
            If mCurrent_Store.Try_RetrieveEntry(Search, mOriginol_Entry) = True Then
                mCurrent_Entry = mOriginol_Entry.Clone
                DisplayCurrentEntry()
                CurrentEditMode = COH_Form_EditMode.Edit
            Else
                '//COH_ContentController.Instance.ShowMessage_Simple("Not Found")
                mOriginol_Entry = Nothing
                mCurrent_Entry = Nothing
                ClearDisplay()
            End If
            UpdateContentModified()
            Cursor.Current = Cursor.Current
        End Sub
        Private Sub Search_ForText(Search As String, Optional SearchNext As Boolean = False)
            Cursor.Current = Cursors.WaitCursor
            If mCurrent_Store.Try_RetrieveEntry_TextSearch(Search, mOriginol_Entry, SearchNext) = True Then
                mCurrent_Entry = mOriginol_Entry.Clone
                DisplayCurrentEntry()
                CurrentEditMode = COH_Form_EditMode.Edit
            Else
                '//COH_ContentController.Instance.ShowMessage_Simple("Not Found")
                mOriginol_Entry = Nothing
                mCurrent_Entry = Nothing
                ClearDisplay()
            End If
            UpdateContentModified()
            Cursor.Current = Cursor.Current
        End Sub
#End Region

#Region "Controls - Add New"
        Private Sub Button_AddNewEntry_Click(sender As Object, e As EventArgs) Handles Button_AddNewEntry.Click
            If mCurrent_Store Is Nothing Then Exit Sub
            Cursor.Current = Cursors.WaitCursor
            mOriginol_Entry = mCurrent_Store.AddNew_Entry_Message(Edit_Find.Text)
            mCurrent_Entry = mOriginol_Entry.Clone
            DisplayCurrentEntry()
            UpdateContentModified()
            CurrentEditMode = COH_Form_EditMode.CreateNew
            Cursor.Current = Cursor.Current
        End Sub
#End Region

#Region "Controls - Editing"
        Private Sub Select_MessageStore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_MessageStore.SelectedIndexChanged
            If Changes_Locked = True Then Exit Sub
            ChangeMessageStore()
        End Sub
        Private Sub Edit_Find_TextChanged(sender As Object, e As EventArgs) Handles Edit_Find.TextChanged
            If Changes_Locked = True Then Exit Sub
            UpdateContentModified()
        End Sub
        Private Sub Edit_Message_TextChanged(sender As Object, e As EventArgs) Handles Edit_Message.TextChanged
            If Changes_Locked = True Then Exit Sub
            If mCurrent_Entry Is Nothing Then Exit Sub
            mCurrent_Entry.Message = Edit_Message.Text
        End Sub
        Private Sub Edit_Help_TextChanged(sender As Object, e As EventArgs) Handles Edit_Help.TextChanged
            If Changes_Locked = True Then Exit Sub
            If mCurrent_Entry Is Nothing Then Exit Sub
            mCurrent_Entry.HelpMessage = Edit_Help.Text
        End Sub
        Private Sub Edit_MessageID_TextChanged(sender As Object, e As EventArgs) Handles Edit_MessageID.TextChanged
            If Changes_Locked = True Then Exit Sub
            If mCurrent_Entry Is Nothing Then Exit Sub
            mCurrent_Entry.MessageID = Edit_MessageID.Text
        End Sub
#End Region

#Region "Controls - Buttons"
        Private Sub Button_Unlock_Click(sender As Object, e As EventArgs) Handles Button_Unlock.Click
            Edit_MessageID.ReadOnly = False
            Button_Unlock.Enabled = False
        End Sub
        Private Sub Button_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Refresh.Click
            Changes_Locked = True
            mCurrent_Entry.MessageID = mCurrent_Store.CreateNewID(Edit_Message.Text)
            Edit_MessageID.Text = mCurrent_Entry.MessageID
            Changes_Locked = False
        End Sub
#End Region

#Region "Save Changes = Rebuild BIN"
        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            Cursor.Current = Cursors.WaitCursor
            '// COH_ContentController.Instance.RebuildBin_AllMessages(True)
            Cursor.Current = Cursor.Current
        End Sub
#End Region

#Region "Save Changes"
        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Cursor.Current = Cursors.WaitCursor
            If SaveChanges() = True Then
                '//  COH_ContentController.Instance.ShowMessage_Simple("Message Store - " & mCurrent_Store.Name & " Saved.")
            Else
                '//  COH_ContentController.Instance.ShowMessage_SimpleError("Unable to Save Message Store - " & mCurrent_Store.Name)
            End If
            Cursor.Current = Cursor.Current
        End Sub
        Private Function SaveChanges() As Boolean
            Select Case CurrentEditMode
                Case COH_Form_EditMode.ViewOnly
                    Return False
                Case COH_Form_EditMode.Edit
                Case COH_Form_EditMode.CreateNew
            End Select
            '//Above Not Implemented Yet / Later when I added Modified tracking etc
            mCurrent_Store.UpdateEntry(mOriginol_Entry.MessageID, mCurrent_Entry)
            Return mCurrent_Store.Save()
        End Function
#End Region

    End Class
End Namespace