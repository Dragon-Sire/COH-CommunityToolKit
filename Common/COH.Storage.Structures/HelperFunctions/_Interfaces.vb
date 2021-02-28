Imports COH.CodeManagement.Enums.Structures
Imports COH.CodeManagement.Interfaces.TOKs

Namespace HelperFunctions.Interfaces

    <HideModuleName()> Public Module COH_Interfaces_Helper

#Region "General"
        Public Function Determine_ImplementsInterface(ByRef SourceType As Type, InterfaceType As Type) As Boolean
            If SourceType.GetInterfaces().Contains(InterfaceType) Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function Determine_ImplementsInterface(ByRef Source As Object, InterfaceType As Type) As Boolean
            If Source.GetType().GetInterfaces().Contains(InterfaceType) Then
                Return True
            Else
                Return False
            End If
        End Function
#End Region

#Region "TOK Interfaces"
        Public Function Determine_ImplementsInterface_FromTokType(ByRef Source As Object, Tok As StructTokenType) As Boolean
            Dim InterfaceType As Type = Nothing
            If Determine_Interface_FromTokType(Tok, InterfaceType) = False Then Return False
            Return Determine_ImplementsInterface(Source, InterfaceType)
        End Function
        Public Function Determine_Interface_FromTokType(Tok As StructTokenType, ByRef Result As Type) As Boolean
            Select Case Tok
                Case StructTokenType.TOK_STRING_X
                    Result = GetType(ISupport_COH_TOK_String)
                    Return True
                Case Else
                    Return False
            End Select
        End Function
#End Region

    End Module
End Namespace