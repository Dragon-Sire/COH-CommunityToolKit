Imports COH.CodeManagement.Enums.Databases
Imports COH.Storage.Databases

Namespace CodeManagement.Interfaces.Databases
    Public Interface I_Support_DataStorage
        Function Database_CreateNew(FilePath As String, DeleteExisting As Boolean) As Boolean
        Function Database_OpenExisting(FilePath As IO.FileInfo) As Data.DataSet
        Function Database_Save() As Boolean
        Function Tables_RetrieveTable(Table As GameDataBase_Tables) As GameDatabase_GenericTable
    End Interface
    Public Interface I_Support_DataStorage_Row
        ReadOnly Property DB_Table As GameDataBase_Tables
        Function Retrieve_Item(ColumnName As String) As Object
        Function Retrieve_Items() As Object()
    End Interface

End Namespace