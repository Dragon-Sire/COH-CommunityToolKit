Imports COH.CodeManagement.Enums.Databases
Imports COH.CodeManagement.Interfaces.Databases

Namespace Storage.Databases
    Public MustInherit Class BTC_Database_TableRow
        Implements I_Support_DataStorage_Row

#Region "Identifiers"
        Public MustOverride ReadOnly Property BTC_DB_Table As GameDataBase_Tables Implements I_Support_DataStorage_Row.DB_Table
#End Region

#Region "Properties"
        Friend ReadOnly Property Row As Data.DataRow
            Get
                Return mDataRow
            End Get
        End Property
        Private mDataRow As Data.DataRow
#End Region

#Region "Create New Instance"
        Friend Sub New(ByRef DataRow As Data.DataRow)
            mDataRow = DataRow
        End Sub
#End Region

#Region "Column Functions"
        Public Function Retrieve_Item(ColumnName As String) As Object Implements I_Support_DataStorage_Row.Retrieve_Item
            Dim Result As Object = Nothing
            If TryRetrieve_Item(ColumnName, Result) = False Then Return Nothing
            Return Result
        End Function
        Public Function Retrieve_Items() As Object() Implements I_Support_DataStorage_Row.Retrieve_Items
            Return mDataRow.ItemArray
        End Function
        Public Function TryRetrieve_Item(ColumnName As String, ByRef Result As Object) As Boolean
            Result = mDataRow.Item(ColumnName)
            If (Result Is Nothing) Then Return False
            Return True
        End Function
#End Region
    End Class
End Namespace