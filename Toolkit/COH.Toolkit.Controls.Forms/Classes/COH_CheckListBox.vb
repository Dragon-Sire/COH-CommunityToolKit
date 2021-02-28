Namespace Toolkit.Controls.WinForms
    Public Class COH_CheckListBox
        Inherits CheckedListBox

#Region "Events"
        Public Event AfterItemChecked()
        Public Property Enable_AfterItemChecked As Boolean = False
        Public Sub OnAfterItemCheck(ByVal e As EventArgs)
            RaiseEvent AfterItemChecked()
        End Sub
        Protected Overrides Sub OnItemCheck(ByVal e As ItemCheckEventArgs)
            MyBase.OnItemCheck(e)
            If Enable_AfterItemChecked = True Then Me.BeginInvoke(CType(Sub()
                                                                            OnAfterItemCheck(EventArgs.Empty)
                                                                        End Sub, MethodInvoker))
        End Sub
#End Region

#Region "Quick Functions"
        Public Function Retrieve_CheckedItems_Strings() As String()
            If CheckedItems.Count = 0 Then Return New String() {}
            Dim Result As String() = New String(CheckedItems.Count - 1) {}
            For X = 0 To CheckedItems.Count - 1
                Result(X) = CheckedItems(X).ToString
            Next
            Return Result
        End Function
        Public Sub PerformMatch_CheckList(ByRef MatchList As String())
            Enable_AfterItemChecked = False
            ClearSelected()
            For X = 0 To Items.Count - 1
                If MatchList.Contains(Items(X).ToString) Then
                    SetItemChecked(X, True)
                Else
                    SetItemChecked(X, False)
                End If
            Next
            Enable_AfterItemChecked = True
        End Sub
#End Region


    End Class
End Namespace