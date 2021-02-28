Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel

Namespace HelperFunctions.Excel
    <HideModuleName()> Public Module DS_MicrosoftExcel_Helper

#Region "Instance"
        Public Function ExcelPropgram() As Microsoft.Office.Interop.Excel.Application
            Dim ExcelInstance As New Microsoft.Office.Interop.Excel.Application
            If ExcelInstance Is Nothing Then
                Console.WriteLine("ERROR: EXCEL couldn't be started")
                MsgBox("ERROR: EXCEL couldn't be started")
                Return Nothing
            Else
                Return ExcelInstance
            End If
            Return Nothing
        End Function
#End Region

#Region "Open Excel File"
        Public Function Excel_OpenWorkBook(FileName As String, ByRef ExcelWorkBook As Workbook) As Boolean
            Dim ExcelInstance As Microsoft.Office.Interop.Excel.Application = ExcelPropgram()
            If ExcelInstance Is Nothing Then Return False
            Dim Excel_WorkBooks As Workbooks = ExcelInstance.Workbooks
            ExcelWorkBook = Excel_WorkBooks.Open(FileName)
            Return Not (ExcelWorkBook Is Nothing)
        End Function
        Public Function Excel_RetrieveSheet(Name As String, ByRef Source As Workbook, ByRef Sheet As Worksheet) As Boolean
            For Each SingleSheet In Source.Sheets
                If SingleSheet.Name = Name Then
                    Sheet = SingleSheet
                    Return True
                End If
            Next
            Return False
        End Function
#End Region

#Region "Test"

        Public Function ReadExcelIntoDataTable(ByVal FileName As String, ByVal SheetName As String) As Data.DataTable
            Dim RetVal As New Data.DataTable
            Dim strConnString As String
            strConnString = "dsn=City;"
            Dim strSQL As String
            strSQL = "SELECT * FROM [" & SheetName & "$]"
            Dim y As New OdbcDataAdapter(strSQL, strConnString)
            y.Fill(RetVal)
            Return RetVal
        End Function
#End Region



#Region "Excel Output Generic - Listview"
        Public Enum ExcelPattern
            None = 0
            AllNumbersCurrency = 1
        End Enum
        Public Sub Excel_FormatColumn(ByVal Width As Integer, ByVal Col As String, ByVal Row As String, ByRef WorkSheet As Worksheet, ByVal Constants As Constants)
            With WorkSheet
                .Columns(Col & ":" & Col).columnwidth = Width
                .Columns(Col & ":" & Col).HorizontalAlignment = Constants
                '.Columns.FormatConditions()
            End With
        End Sub
        Public Sub Excel_FormatCell(ByVal Col As Integer, ByVal Row As Integer, ByRef WorkSheet As Worksheet, ByVal Description As String, ByVal FontBold As Boolean, Optional ByVal Pattern As ExcelPattern = 0)
            With WorkSheet
                .Cells(Row, Col) = Description
                .Cells(Row, Col).Font.Bold = FontBold
                Select Case Pattern
                    Case ExcelPattern.None
                    Case ExcelPattern.AllNumbersCurrency
                        .Cells(Row, Col).numberformat = "$0.00"
                End Select
                .Cells.BorderAround(XlBorderWeight.xlThin, XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic)
            End With
        End Sub
        Public Sub Excel_FormatCell2(ByVal Col As Integer, ByVal Row As Integer, ByRef WorkSheet As Worksheet, ByVal Description As String, ByVal Pattern As ExcelPattern)
            With WorkSheet
                .Cells(Row, Col) = Description
                Select Case Pattern
                    Case ExcelPattern.None
                    Case ExcelPattern.AllNumbersCurrency
                        .Cells(Row, Col).numberformat = "$0.00"
                End Select
            End With
        End Sub
        Private Function DetermineColSize(ByVal TheSize As Integer) As Integer
            DetermineColSize = TheSize / 6.5
        End Function
        Public Function ExcelOutput_ListView_General(ByVal Name As String, ByVal TheListView As ListView, ByVal Pattern As ExcelPattern) As Boolean
            Dim ExcelInstance As Microsoft.Office.Interop.Excel.Application = Nothing
            If ExcelInstance Is Nothing Then ExcelInstance = ExcelPropgram()
            If ExcelInstance Is Nothing Then Return False
            Dim Excel_WorkBooks As Workbooks = ExcelInstance.Workbooks
            Dim Excel_WorkBook1 As Workbook = Excel_WorkBooks.Add(XlWBATemplate.xlWBATWorksheet)
            Dim Excel_WorkSheets As Sheets = Excel_WorkBook1.Sheets
            Dim Excel_WorkSheet As Worksheet = Excel_WorkSheets.Add
            Excel_WorkSheet.Name = Name
            With Excel_WorkSheet
                Dim NumberCols As Integer = TheListView.Columns.Count
                For Z = 0 To NumberCols - 1
                    If Z = 0 Then
                        Excel_FormatColumn(DetermineColSize(TheListView.Columns(0).Width), "A", "A", Excel_WorkSheet, Constants.xlLeft)
                    Else
                        Excel_FormatColumn(DetermineColSize(TheListView.Columns(Z).Width), Chr(Z + 65), Chr(Z + 65), Excel_WorkSheet, Constants.xlCenter)
                    End If
                    Excel_FormatCell(Z + 1, 1, Excel_WorkSheet, TheListView.Columns(Z).Text, True, 0)
                Next

                Dim SelectedItem As ListViewItem = Nothing
                'Dim BoldLine As Boolean = True
                For X = 0 To TheListView.Items.Count - 1
                    SelectedItem = TheListView.Items(X)
                    'If X = 1 Then BoldLine = False
                    Excel_FormatCell2(1, X + 2, Excel_WorkSheet, SelectedItem.Text, Pattern)
                    For X2 = 1 To NumberCols - 1
                        If Pattern = 1 Then 'Currency
                            If SelectedItem.SubItems.Count > X2 Then Excel_FormatCell2(X2 + 1, X + 2, Excel_WorkSheet, SelectedItem.SubItems(X2).Text, Pattern)
                        Else
                            If SelectedItem.SubItems.Count > X2 Then Excel_FormatCell2(X2 + 1, X + 2, Excel_WorkSheet, SelectedItem.SubItems(X2).Text, 0)
                        End If
                    Next
                Next
            End With
            MsgBox("Output to Excel Complete.", MsgBoxStyle.Information, "DragonSire Excel Helper Functions")
            ExcelInstance.Visible = True
            Return True
        End Function
#End Region
    End Module
End Namespace

