Imports COH.GameContent.Structures.Characters
Imports COH.Toolkit.Modding.Enums
Imports System.Data

Namespace ImportTools.Excel
    Public Module XLS_CharacterClasses

#Region "Open WorkBook"

        Public Function ReadExcelToDatatble(ByVal worksheetName As String, ByVal saveAsLocation As String, ByVal ReporType As String, ByVal HeaderLine As Integer, ByVal ColumnStart As Integer) As DataTable
            Dim dataTable As System.Data.DataTable = New DataTable()
            Dim excel As Microsoft.Office.Interop.Excel.Application
            Dim excelworkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim excelSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim range As Microsoft.Office.Interop.Excel.Range

            Try
                excel = New Microsoft.Office.Interop.Excel.Application()
                excel.Visible = False
                excel.DisplayAlerts = False
                excelworkBook = excel.Workbooks.Open(saveAsLocation)
                excelSheet = CType(excelworkBook.Worksheets.Item(worksheetName), Microsoft.Office.Interop.Excel.Worksheet)
                range = excelSheet.UsedRange
                Dim cl As Integer = range.Columns.Count
                Dim rowcount As Integer = range.Rows.Count

                For j As Integer = ColumnStart To cl
                    dataTable.Columns.Add(Convert.ToString(range.Cells(HeaderLine, j).Value2), GetType(String))
                Next

                For i As Integer = HeaderLine + 1 To rowcount
                    Dim dr As DataRow = dataTable.NewRow()

                    For j As Integer = ColumnStart To cl
                        dr(j - ColumnStart) = Convert.ToString(range.Cells(i, j).Value2)
                    Next

                    dataTable.Rows.InsertAt(dr, dataTable.Rows.Count + 1)
                Next

                excelworkBook.Close()
                excel.Quit()
                Return dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            Finally
                excelSheet = Nothing
                range = Nothing
                excelworkBook = Nothing
            End Try
        End Function


        Friend Function Database_OpenExisting(FilePath As String) As DataSet
            Dim CurrentDataSet As New DataSet()
            Dim CurrentTable As DataTable = Nothing
            Dim CurrentReader As New System.IO.FileStream(FilePath, System.IO.FileMode.Open)
            Dim CurrentReader2 As New System.IO.FileStream(FilePath.Replace(".xml", ".xsd"), System.IO.FileMode.Open)
            Try
                CurrentDataSet.ReadXmlSchema(CurrentReader2)
                CurrentDataSet.ReadXml(CurrentReader)
            Catch ex As Exception
            Finally
                CurrentReader.Close()
                CurrentReader2.Close()
            End Try
            Return CurrentDataSet
        End Function
        Public Function OpenWorkBook_AllClasses(FileSource As String, ExportFolder As String) As Boolean
            Dim DataTable As Data.DataTable = Database_OpenExisting(FileSource).Tables(0)
            Dim Result = Import_CharacterClass(DataTable)
            ' CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder & Result.Name & ".xml", Result)
            Return True
        End Function
        Public Function OpenWorkBook_AllClasses2(FileSource As String, ExportFolder As String) As Boolean
            Dim temp As New DataSet("Generic")
            Dim DataTable As Data.DataTable = ReadExcelToDatatble("_Generic", FileSource, "", 1, 1)
            temp.Tables.Add(DataTable)
            temp.WriteXml(FileSource.Replace(".xls", ".xml"))
            temp.WriteXmlSchema(FileSource.Replace(".xls", ".xsd"))

            'Dim DataTable As Data.DataTable = HelperFunctions.Excel.ReadExcelIntoDataTable(FileSource, "_Generic")
            Dim Result = Import_CharacterClass(DataTable)
            '  CharacterClasses.COH_CharacterClass.Export_XML_CharcterClass(ExportFolder & Result.Name & ".xml", Result)
            Return True
        End Function
        Private Function RetrieveItem(ByRef DataTable As Data.DataTable, Row As Integer, Item As Integer) As String
            If IsDBNull(DataTable.Rows(Row).Item(Item)) = True Then
                Return ""
            End If
            Return DataTable.Rows(Row).Item(Item)
        End Function
        Private Function RenameTable(Source As String) As String
            If Source = "Base" Then
                Return "AttribMaxTable"


            ElseIf Source = "BuffedMax" Then
                Return "AttribMaxMaxTable"
            ElseIf Source = "Max" Then
                Return "AttribMaxTable"


            ElseIf Source = "MaxMax" Then
                Return "AttribMaxMaxTable"

                'AttribMaxTable
            ElseIf Source = "StrMax" Then
                Return "StrengthMaxTable"
            ElseIf Source = "ResMax" Then
                Return "ResistanceMaxTable"
            ElseIf Source = "Min" Then
                Return "AttribMin"
            ElseIf Source = "StrMin" Then
                Return "StrengthMin"
            ElseIf Source = "ResMin" Then
                Return "ResistanceMin"

            ElseIf Source = "DiminStr" Then
                Return "AtrribDiminStr"
            ElseIf Source = "DiminCur" Then
                Return "AtrribDiminCur"
            ElseIf Source = "DiminRes" Then
                Return "AtrribDiminRes"

            ElseIf Not Source.Contains("Dimin") Then
                MsgBox("Error")
                Return Source
            End If
        End Function

        Private Function Import_CharacterClass(ByRef DataTable As Data.DataTable) As COH_CharacterClass
            'CurrentSheet.Activate()
            Dim Name As String = DataTable.Columns(0).ColumnName
            Dim Result As New COH_CharacterClass '(Name)
            With Result
                Dim RowStart As Integer = 0
                Dim RowFinish As Integer = 14
                For X = RowStart To RowFinish
                    Dim FieldValue As String = FieldNameClean(RetrieveItem(DataTable, X, 2))
                    Dim TheValue As COH_CC_Fields_Excel = [Enum].Parse(GetType(COH_CC_Fields_Excel), FieldValue)
                    ' Result.UpdateValue(TheValue, RetrieveItem(DataTable, X, 3))
                Next
            End With
            '//FIND ATTRIBUTE STARTS
            Dim FindStart As Integer = 15
            For X = 15 To 100
                If RetrieveItem(DataTable, X, 2) = "Attribute" Then
                    FindStart = X
                    Exit For
                End If
            Next
            If Not RetrieveItem(DataTable, FindStart, 2) = "Attribute" Then MsgBox("ERROR")
            FindStart += 1
            '//Begin Updating
            Do
                Dim Temp = RetrieveItem(DataTable, FindStart, 2)
                If Temp = "" Then Exit Do
                ReadEntry(Temp, DataTable, FindStart, Result)
            Loop

            Return Result
        End Function
        Private Function FieldNameClean(Source As String) As String
            Dim Result As String = Source
            Result = Replace(Result, " ", "_")
            Result = Replace(Result, "-", "_")
            Result = Replace(Result, ":", "")
            'If Result DBNull Then Return String.Empty
            If Result Is Nothing Then Result = String.Empty
            Return Result
        End Function
#End Region

#Region "Attributes Table"
        Private Function ReadEntry(Name As String, ByRef DataTable As Data.DataTable, ByRef FindStart As Integer, ByRef Result As COH_CharacterClass)
            Dim AttribName As String = Name
            Dim Checksecond As String = RetrieveItem(DataTable, FindStart, 6)
            Dim LineName As String = ""
            If Checksecond = "" Then
                '  Dim newbase = New COH_CharacterClass_Base(AttribName)
                ' Dim value = RetrieveItem(DataTable, FindStart, 5)
                ' newbase.Level = value
                ' Result.BaseAttributes.Add(newbase)
                FindStart += 1
            Else
                LineName = RetrieveItem(DataTable, FindStart, 4) 'BASE
                LineName = "AttribMaxTable"
                ReadEntry_Line(AttribName, LineName, DataTable, FindStart, Result)
                FindStart += 1
            End If
            LineName = RetrieveItem(DataTable, FindStart, 4) 'MAX or BUFFED
            If LineName = "BuffedMax" Then
                If Checksecond = "" Then
                    LineName = "AttribMaxTable"
                    ReadEntry_Line(AttribName, LineName, DataTable, FindStart, Result)
                End If
                LineName = "AttribMaxMaxTable"
                ReadEntry_Line(AttribName, LineName, DataTable, FindStart, Result)
                FindStart += 1
            ElseIf LineName = "Max" Then
                LineName = "AttribMaxTable"
                ReadEntry_Line(AttribName, LineName, DataTable, FindStart, Result)
                FindStart += 1
            End If
            Do
                LineName = RenameTable(RetrieveItem(DataTable, FindStart, 4)) 'BASE
                If LineName = "" Then Exit Do
                If LineName.Contains("Dimin") Then Exit Do
                ReadEntry_Line(AttribName, LineName, DataTable, FindStart, Result)
                FindStart += 1
            Loop
            '//DiminishingReturns
            Do
                LineName = RenameTable(RetrieveItem(DataTable, FindStart, 4)) 'BASE
                If LineName = "" Then Exit Do
                If Not LineName.Contains("Dimin") Then Exit Do
                ' Dim Find = Result.RetrieveTable_Attributes(LineName & "In")
                ' Dim NewItem As CharacterClasses.COH_CharacterClass_Attributes2 = Nothing
                ' NewItem = New CharacterClasses.COH_CharacterClass_Attributes2(AttribName, 1)
                ' NewItem.Levels(0) = RetrieveItem(DataTable, FindStart, 5)
                ' Find.AttributesAdjusments.Add(NewItem)
                '
                '                Find = Result.RetrieveTable_Attributes(LineName & "Out")
                '                NewItem = New CharacterClasses.COH_CharacterClass_Attributes2(AttribName, 1)
                ' NewItem.Levels(0) = RetrieveItem(DataTable, FindStart, 6) '
                ' Find.AttributesAdjusments.Add(NewItem')
                ' FindStart += 1
            Loop
        End Function
        Private Function ReadEntry_Line(AttribName As String, LineName As String, ByRef DataTable As Data.DataTable, ByRef FindStart As Integer, ByRef Result As COH_CharacterClass) As Boolean
            Dim Multi As String = RetrieveItem(DataTable, FindStart, 1)
            Dim TheMax As String = RetrieveItem(DataTable, FindStart, 0)
            Dim Checksecond As String = RetrieveItem(DataTable, FindStart, 6)
            ' Dim Find = Result.RetrieveTable_Attributes(LineName)
            ' Dim NewItem As CharacterClasses.COH_CharacterClass_Attributes2 = Nothing
            ' If Checksecond = "" Then
            ' NewItem = New CharacterClasses.COH_CharacterClass_Attributes2(AttribName, 1)
            ' Else
            ' NewItem = New CharacterClasses.COH_CharacterClass_Attributes2(AttribName, 55)
            ' End If
            ' NewItem.ClassMultiplier = If(Multi = "", 0, Multi)
            ' For Y = 1 To NewItem.MaxLevel
            'NewItem.Levels(Y - 1) = RetrieveItem(DataTable, FindStart, 4 + Y)
            'Next
            'Find.AttributesAdjusments.Add(NewItem)
            Return True
        End Function
#End Region




    End Module
End Namespace