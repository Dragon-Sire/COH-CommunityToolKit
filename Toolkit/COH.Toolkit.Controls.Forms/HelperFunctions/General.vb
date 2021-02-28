Namespace HelperFunctions.Toolkit.General
    <HideModuleName> Public Module COH_HelperFunctions_General

#Region "Dialogs"
        Public Function LocateFilePath(Title As String, Filter As String, ByRef PathResult As String) As Boolean
            Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            saveFileDialog1.Filter = Filter '"JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
            saveFileDialog1.Title = Title
            saveFileDialog1.FileName = IO.Path.GetFileName(PathResult)
            Select Case saveFileDialog1.ShowDialog()
                Case DialogResult.Cancel
                    PathResult = ""
                    Return False
            End Select
            If saveFileDialog1.FileName <> "" Then
                PathResult = saveFileDialog1.FileName
                Return True
            Else
                Return False
            End If
        End Function
        Public Function LocateFolder(Title As String, ByRef PathResult As String) As Boolean
            Dim TheDialog As FolderBrowserDialog = New FolderBrowserDialog
            TheDialog.Description = Title
            Select Case TheDialog.ShowDialog()
                Case DialogResult.Cancel
                    PathResult = ""
                    Return False
            End Select
            If TheDialog.SelectedPath <> "" Then
                PathResult = TheDialog.SelectedPath
                Return True
            Else
                Return False
            End If
        End Function
#End Region
    End Module
End Namespace
