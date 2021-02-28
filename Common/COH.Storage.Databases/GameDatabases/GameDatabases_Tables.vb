Imports System.Data
Imports COH.CodeManagement.Enums.Databases

Namespace Storage.Databases
    Partial Public Class GameDatabase_Generic

#Region "Private Properties"
        '//Private mTable_Publisher As BTC_MetaData_Publisher_Table
#End Region

#Region "Properties"
        Friend ReadOnly Property Tables(Table As GameDataBase_Tables) As GameDatabase_GenericTable
            Get
                Return Tables_RetrieveTable(Table)
            End Get
        End Property
#End Region

#Region "Tables"
        Friend Sub LinkCachedTables()
            'mTable_Publisher = New BTC_MetaData_Publisher_Table(Me, DataSet.Tables(BTC_DB_Tables.Publisher.toString))
            'mTable_IndustryPerson = New BTC_MetaData_IndustryPerson_Table(Me, DataSet.Tables(BTC_DB_Tables.IndustryPerson.toString))
        End Sub
        Function Tables_RetrieveTable(Table As GameDataBase_Tables) As GameDatabase_GenericTable Implements CodeManagement.Interfaces.Databases.I_Support_DataStorage.Tables_RetrieveTable
            Dim Result As GameDatabase_GenericTable = Nothing
            Return Result
        End Function
#End Region

    End Class
End Namespace
