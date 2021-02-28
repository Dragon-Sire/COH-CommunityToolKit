Namespace GameContent.Structures.Characters
    Public Class COH_CharacterEmoteAnim

#Region "Properties"

#End Region

#Region "Private Properties"
       Private mName As String
#End Region

#Region "Create New Instances"
        Public Sub New()
            ResetDefaults()
        End Sub
        Private Sub ResetDefaults()
            mName = String.Empty
        End Sub
        Public Overrides Function ToString() As String
            Return mName
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_CharacterEmoteAnim
            Dim Result As COH_CharacterEmoteAnim = New COH_CharacterEmoteAnim
            With Result
                Return Result
            End With
        End Function
#End Region
    End Class
End Namespace