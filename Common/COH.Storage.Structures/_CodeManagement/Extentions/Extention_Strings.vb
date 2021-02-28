Imports System.Runtime.CompilerServices

Namespace CodeManagement.Extentions
    <HideModuleName> Public Module Extention_Strings
        <Extension> Public Function CloneTheStrings(ByRef Source As String()) As String()
            Return HelperFunctions.StringsAndThings.CloneStrings(Source)
        End Function
        <Extension> Public Function CloneTheStrings(ByRef Source As List(Of String)) As List(Of String)
            Return HelperFunctions.StringsAndThings.CloneStrings(Source)
        End Function
    End Module
End Namespace