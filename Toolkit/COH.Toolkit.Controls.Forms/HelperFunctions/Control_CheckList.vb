Namespace HelperFunctions.Toolkit.Controls.Lists
    <HideModuleName> Public Module COH_QuickControlHelpers_CheckList
        Public Sub PerformMatch_CheckList(ByRef CheckList As CheckedListBox, ByRef MatchList As String())
            CheckList.ClearSelected()
            For X = 0 To CheckList.Items.Count - 1
                If MatchList.Contains(CheckList.Items(X).ToString) Then
                    CheckList.SetItemChecked(X, True)
                Else
                    CheckList.SetItemChecked(X, False)
                End If
            Next
        End Sub
        Public Sub Fill_ChecklistBox(CheckList As CheckedListBox, DataSource As Object)
            With CheckList
                .DataSource = Nothing
                .BeginUpdate()
                .Items.Clear()
                .DataSource = DataSource
                .EndUpdate()
            End With
        End Sub
        Public Sub Fill_ListBox(TheList As ListBox, Items As String())
            With TheList
                .BeginUpdate()
                .Items.Clear()
                .Items.AddRange(Items)
                .EndUpdate()
            End With
        End Sub
        Public Sub Fill_ComboBox(TheComboBox As ComboBox, DataSource As Object)
            With TheComboBox
                .DataSource = Nothing
                .BeginUpdate()
                .Items.Clear()
                .DataSource = DataSource
                .EndUpdate()
            End With
        End Sub
        Public Function Retrieve_Strings_FromCheckList(CheckList As CheckedListBox) As String()
            Dim Result As String() = New String(CheckList.CheckedItems.Count - 1) {}
            For X = 0 To CheckList.CheckedItems.Count - 1
                Result(X) = CheckList.CheckedItems(X).ToString
            Next
            Return Result
        End Function
    End Module
End Namespace