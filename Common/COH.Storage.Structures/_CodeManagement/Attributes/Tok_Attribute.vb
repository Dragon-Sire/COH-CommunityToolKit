Imports COH.CodeManagement.Enums.Structures

Namespace CodeManagement.Attributes
    <AttributeUsage(AttributeTargets.Property Or AttributeTargets.Class)>
    Public Class COH_TOK
        Inherits System.Attribute
        Public Property Name As String
        Public Property TOK As StructTokenType
        Public Sub New(InternalName As String)
            Me.New(InternalName, StructTokenType.Undefined)
        End Sub
        Public Sub New(InternalName As String, TheTok As StructTokenType)
            Name = InternalName
            TOK = TheTok
        End Sub
    End Class
End Namespace