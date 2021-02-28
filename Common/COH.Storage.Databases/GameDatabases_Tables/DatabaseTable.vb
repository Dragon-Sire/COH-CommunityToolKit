Imports COH.CodeManagement.Enums.Databases
Imports COH.CodeManagement.Interfaces.Databases

Namespace Storage.Databases
    Public MustInherit Class GameDatabase_GenericTable

#Region "Identifiers"
        Public MustOverride ReadOnly Property BTC_DB_Table As GameDataBase_Tables
        Public MustOverride ReadOnly Property BTC_DB_Columns As System.Type
#End Region

#Region "Private Properties"
        Private mDataTable As Data.DataTable
        Private mStorageController As I_Support_DataStorage
#End Region

#Region "Properties"
        Friend ReadOnly Property StorageController As I_Support_DataStorage
            Get
                Return mStorageController
            End Get
        End Property
        Friend ReadOnly Property Table As Data.DataTable
            Get
                Return mDataTable
            End Get
        End Property
        Public ReadOnly Property Count As Integer
            Get
                Return mDataTable.Rows.Count
            End Get
        End Property
#End Region

#Region "Create New Instance"
        Friend Sub New(ByRef StorageController As I_Support_DataStorage, ByRef DataTable As Data.DataTable)
            mStorageController = StorageController
            mDataTable = DataTable
        End Sub
        Public Overrides Function ToString() As String
            Return BTC_DB_Table.ToString()
        End Function
#End Region

#Region "Unique IDs"
        Public Shared Function Generate_UniqueGuid(MetaClass As GameDataBase_Tables) As String
            'Dim Result As String
            'Result = System.Guid.NewGuid.ToString("N")
            'Return ("BTC-" & CInt(MetaClass).ToString.PadLeft(3, "0") & "-" & Result.ToUpper)
        End Function
        Public Shared Function ValidateID(UniqueIdentifier As String) As Boolean
            'Dim Result As Boolean = True
            'If UniqueIdentifier Is Nothing OrElse UniqueIdentifier = "" Then Return False
            'If UniqueIdentifier.Length <> 40 Then Return False
            'If Not UniqueIdentifier.Contains("BTC") Then Return False
            'Result = Text.RegularExpressions.Regex.IsMatch(UniqueIdentifier, "^BTC-\d{3}-[a-zA-Z0-9_.-]*$")
            'Return Result
        End Function
        Public Shared Function Split_UniqueIdentifier(value As String, BTC_DB_Table As String, Key As String) As Boolean
            'If ValidateID(value) = False Then Return False
            'BTC_DB_Table = value.Substring(4, 3)
            'Key = value.Substring(8, 32)
            Return True
        End Function
#End Region

#Region "Column Functions"
        Protected Function TryRetrieve_Column(ColumnName As String, ByRef Result As Data.DataColumn) As Boolean
            Result = mDataTable.Columns(ColumnName)
            If (Result Is Nothing) Then Return False
            Return True
        End Function
#End Region

#Region "Row Functions"
        Protected Function TryRetrieve_Row(Key As String, ByRef Result As Data.DataRow) As Boolean
            Result = mDataTable.Rows.Find(Key)
            If (Result Is Nothing) Then Return False
            Return True
        End Function
        Protected Function TryRetrieve_Row(Index As Integer, ByRef Result As Data.DataRow) As Boolean
            Result = mDataTable.Rows.Item(Index)
            If (Result Is Nothing) Then Return False
            Return True
        End Function
        Protected Function TryFind_Row(ColumnName As String, Search As String, ByRef Result As Data.DataRow) As Boolean
            Dim Rows As Data.DataRow() = Table.Select(ColumnName & " LIKE '%" & Search & "%'")
            If Rows.Count = 0 Then Return False
            If Rows.Count > 1 Then
                '//MSG MORE THAN 1 FOUND'ContinuityName ContinuityName
                Return False
            End If
            Result = Rows(0)
            Return True
        End Function
        Protected Function TryFind_Row(ColumnName1 As String, Search1 As String, ColumnName2 As String, Search2 As String, ByRef Result As Data.DataRow) As Boolean
            Dim Rows As Data.DataRow() = Table.Select(ColumnName1 & " LIKE '%" & Search1 & "%' AND " & ColumnName2 & " LIKE '%" & Search2 & "%'")
            If Rows.Count = 0 Then Return False
            If Rows.Count > 1 Then
                '//MSG MORE THAN 1 FOUND'ContinuityName ContinuityName
                Return False
            End If
            Result = Rows(0)
            Return True
        End Function
#End Region

    End Class
End Namespace