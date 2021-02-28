Imports COH.CodeManagement.Enums.Databases
Imports COH.CodeManagement.Interfaces.Databases

Namespace Storage.Databases
    Public MustInherit Class GameDatabase_Generic
        Implements I_Support_DataStorage

#Region "Properties"
        Public Property DataBase_Name As String
            Get
                Return pDatabaseName
            End Get
            Set(value As String)
                pDatabaseName = value
            End Set
        End Property
        Friend ReadOnly Property DataSet As Data.DataSet
            Get
                Return pDatabase
            End Get
        End Property
        Private pDatabase As Data.DataSet
        Private pDatabaseName As String
#End Region

#Region "Create New Instance"
        Public Sub New(LocalFilePath As String, Optional DeleteExisting As Boolean = False)
            pDatabaseName = "NEW_Database"
            If IO.File.Exists(LocalFilePath) = False OrElse DeleteExisting = True Then
                If Database_CreateNew(LocalFilePath, True) = False Then Exit Sub
                pDatabase = Database_OpenExisting(New IO.FileInfo(LocalFilePath))
            Else
                pDatabase = Database_OpenExisting(New IO.FileInfo(LocalFilePath))
            End If
            '// LinkCachedTables
        End Sub
        Friend MustOverride Function Database_CreateNew(FilePath As String, DeleteExisting As Boolean) As Boolean Implements I_Support_DataStorage.Database_CreateNew
        Friend MustOverride Function Database_OpenExisting(FilePath As IO.FileInfo) As Data.DataSet Implements I_Support_DataStorage.Database_OpenExisting
        Friend MustOverride Function Database_Save() As Boolean Implements I_Support_DataStorage.Database_Save
#End Region

    End Class
End Namespace