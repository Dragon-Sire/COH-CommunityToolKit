Namespace CodeManagement.Attributes
    <AttributeUsage(AttributeTargets.Field)>
    Public Class COH_DefEnum
        Inherits System.Attribute
        Public Property DefName As String
        Public Property AlternativeNames As String()
        Public Sub New(Name As String, Optional Alternative As String = "")
            DefName = Name
            AlternativeNames = New String(0) {Alternative}
        End Sub
        Public Sub New(Name As String, Alternatives As String())
            DefName = Name
            AlternativeNames = Alternatives
        End Sub
        Public Shared Function GetAttribute(ByVal value As [Enum], ByRef Result As COH_DefEnum) As Boolean
            Dim fi As Reflection.FieldInfo = value.[GetType]().GetField(value.ToString())
            If fi Is Nothing Then
                Return False
            Else
                Dim attributes As COH_DefEnum() = CType(fi.GetCustomAttributes(GetType(COH_DefEnum), False), COH_DefEnum())
                If attributes.Length > 0 Then
                    Result = attributes(0)
                    Return True
                Else
                    Return False
                End If
            End If
        End Function
        Public Shared Function GetDefName(ByVal value As [Enum]) As String
            Dim fi As Reflection.FieldInfo = value.[GetType]().GetField(value.ToString())
            If fi Is Nothing Then
                Return ""
            Else
                Dim attributes As COH_DefEnum() = CType(fi.GetCustomAttributes(GetType(COH_DefEnum), False), COH_DefEnum())
                Return If((attributes.Length > 0), attributes(0).DefName, "")
            End If
        End Function
        Public Shared Function GetAlternative(ByVal value As [Enum]) As String
            Dim fi As Reflection.FieldInfo = value.[GetType]().GetField(value.ToString())
            Dim attributes As COH_DefEnum() = CType(fi.GetCustomAttributes(GetType(COH_DefEnum), False), COH_DefEnum())
            Return If((attributes.Length > 0), attributes(0).AlternativeNames, "")
        End Function
    End Class
End Namespace