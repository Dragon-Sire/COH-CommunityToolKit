Namespace CodeManagement.Interfaces.TOKs
    Public Interface ISupport_COH_TOK_String
        Function Convert_ToString(Optional ReturnKey As Boolean = True, Optional WithQuotes As Boolean = True) As String
    End Interface
    Public Interface ISupport_COH_TOK_StringArray
        Function Convert_ToString(Optional ReturnKeys As Boolean = True, Optional WithQuotes_Array As Boolean = False, Optional WithQuotesItem As Boolean = False) As String
        Function Convert_ToStrings(Optional ReturnKeys As Boolean = True, Optional WithQuotes As Boolean = False) As String()
    End Interface
End Namespace