Imports COH.CodeManagement.Enums.Databases.SQL

Namespace Storage.Databases.SQL
    Public Class SQL_Connection
        ''' Stored procedures for the connection
        Public Procedures() As HSTMT = HelperFunctions.Arrays.InitializeArray(Of HSTMT)(SQL_ENUM_Procedures.ASQL_STORED_PROCEDURE_MAX)
    End Class
End Namespace