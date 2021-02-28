#If EDITOR Then
Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization.Configuration
#End If

Namespace Storage.Structures
#If EDITOR Then
    Partial Public Class COH_FileStructure

        Public Overridable Function Retrieve_DynamicMenus() As List(Of DynamicMenu_Cmmand)
            Return Nothing
        End Function
        Public Function Activate_DynamicMenu(Command As DynamicMenu_Cmmand) As Boolean
            Dim ObjectResult As Object = CallSubFunction_ByName(Command.FunctionName)
            Select Case Command.CommandType
                Case DynamicMenu_CommandType.Extract_ToXML
                    Dim XML As String = Nothing
                    Dim Struct = TryCast(ObjectResult, COH_FileStructure)
                    If (Struct Is Nothing) = False Then
                        If Struct.Export_to_TextFormat(XML, New COH_Serialization_Settings(True) With {.Option_SelectedFormat = COH_ExportFormat.XML}) = False Then Return False
                        'ShowMessage(XML)
                    Else
                        Return False
                    End If
            End Select
        End Function
        Private Function CallSubFunction_ByName(ByVal sSubroutine As String) As Object
            Dim myInfo As System.Reflection.MethodInfo = Me.GetType.GetMethod(sSubroutine)
            Return myInfo.Invoke(Me, Nothing)
        End Function
        Private Function CallSubFunction_ByName(ByVal sSubroutine As String, ByVal Parameter As String) As Object
            Dim myInfo As System.Reflection.MethodInfo = Me.GetType.GetMethod(sSubroutine)
            Dim myParameters() As Object = {Parameter}
            Return myInfo.Invoke(Me, myParameters)
        End Function
        Public Enum DynamicMenu_CommandType
            Extract_ToXML = 0
        End Enum
        Public Class DynamicMenu_Cmmand
            Property DisplayName As String
            Property CommandType As DynamicMenu_CommandType
            Property FunctionName As String
            Public Sub New(MenuText As String, Command_Type As DynamicMenu_CommandType, FunctionToCall As String)
                DisplayName = MenuText
                CommandType = Command_Type
                FunctionName = FunctionToCall
            End Sub
        End Class
    End Class
#End If
End Namespace