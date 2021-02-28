Imports System.ComponentModel

Namespace Storage.Structures
    Public MustInherit Class COH_ObservableObject
        Implements INotifyPropertyChanged

        Public Event WasModified As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Public Sub RaisePropertyChanged(<Runtime.CompilerServices.CallerMemberName> Optional memberName As String = Nothing)
            RaiseEvent WasModified(Me, New PropertyChangedEventArgs(memberName))
        End Sub
        Protected Function SetValue(Of T)(ByRef backingField As T, ByVal value As T, <Runtime.CompilerServices.CallerMemberName> ByVal Optional propertyName As String = "") As Boolean
            If Object.Equals(backingField, value) Then
                Return False
            End If
            backingField = value
            RaisePropertyChanged(propertyName)
            Return True
        End Function
    End Class
End Namespace