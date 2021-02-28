Namespace HelperFunctions.Arrays
	<HideModuleName()> Public Module HelperClasses_Arrays
		Public Function InitializeArray(Of T As New)(ByVal length As Integer) As T()
			Dim array(length - 1) As T
			For i As Integer = 0 To length - 1
				array(i) = New T()
			Next i
			Return array
		End Function
		Public Sub DeleteArray(Of T As IDisposable)(ByVal array() As T)
			For Each element As T In array
				If element IsNot Nothing Then
					element.Dispose()
				End If
			Next element
		End Sub
	End Module
End Namespace
