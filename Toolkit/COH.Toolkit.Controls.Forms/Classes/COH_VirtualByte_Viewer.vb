Imports System.ComponentModel
Imports System.IO

Namespace Toolkit.Controls.WinForms
    Public Class COH_VirtualByte_Viewer
        Inherits DataGridView

#Region "Enum"
        Public Enum BytesView
            Hex = 0
            Bytes = 1
            Bits = 2
        End Enum
        Public Enum BytesEncoding
            [DEFAULT] = 0
            Ascii = 1
            UTF8 = 2
        End Enum
        Public Enum TableView
            Hex = 0
            Numbers = 1
        End Enum
#End Region

#Region "Properties"
        <Category("Data Appearance")> Property View_TableView As TableView
            Get
                If mConfiguration Is Nothing Then mConfiguration = New VirtualHexView_Configuration
                Return mConfiguration.TableView
            End Get
            Set(value As TableView)
                If mConfiguration Is Nothing Then mConfiguration = New VirtualHexView_Configuration
                mConfiguration.TableView = value
                ResetAppearance()
            End Set
        End Property
        <Category("Data Appearance")> Property View_DataView As BytesView
            Get
                If mConfiguration Is Nothing Then mConfiguration = New VirtualHexView_Configuration
                Return mConfiguration.DataView
            End Get
            Set(value As BytesView)
                If mConfiguration Is Nothing Then mConfiguration = New VirtualHexView_Configuration
                mConfiguration.DataView = value
                ResetAppearance()
            End Set
        End Property
        <Category("Data Appearance")> Property View_NumberColumns As Integer
            Get
                If mConfiguration Is Nothing Then mConfiguration = New VirtualHexView_Configuration
                Return mConfiguration.NumberColumns
            End Get
            Set(value As Integer)
                If mConfiguration Is Nothing Then mConfiguration = New VirtualHexView_Configuration
                mConfiguration.NumberColumns = value
                ResetAppearance()
            End Set
        End Property
        ReadOnly Property TotalLength As Long
            Get
                If mIsCached = False Then
                    If mCurrentReader Is Nothing Then Return 0
                    Return mCurrentReader.Length
                Else
                    If mRawbytes Is Nothing Then Return 0
                    Return mRawbytes.LongCount
                End If
            End Get
        End Property
#End Region

#Region "Private Usage"
        Private mWidth_Column As Integer
        Private mWidth_Table As Integer
        Private mWidth_Ascii As Integer
        Private mTableOffsetLen As Integer
        Private mConfiguration As VirtualHexView_Configuration
        '//Data Control
        Private WithEvents mCurrentReader As COH_BinaryReader
        Private mRawbytes() As Byte
        Private mFocusedPosition As Long
        Private mIsCached As Boolean
        Private mCached_MaxSize As Integer = 200000
#End Region

#Region "Initialize"
        Sub New()
            MyBase.New
            mIsCached = False
            VirtualMode = True
            AllowDrop = False
            AllowUserToAddRows = False
            AllowUserToDeleteRows = False
            AllowUserToOrderColumns = False
            AllowUserToResizeColumns = False
            AllowUserToResizeRows = False
            DoubleBuffered = True
            AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
            DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            ResetAppearance(True)
        End Sub
#End Region

#Region "Load Data"
        Public Sub LoadBuffer(ByRef Buffer As Byte(), Optional Encoding As BytesEncoding = BytesEncoding.DEFAULT, Optional LeaveOpen As Boolean = True)
            If Buffer.Length < mCached_MaxSize Then
                mIsCached = True
                mRawbytes = Buffer
                RowCount = Math.Ceiling(Buffer.Length / View_NumberColumns)
            Else
                mIsCached = False
                mCurrentReader = New COH_BinaryReader(New IO.MemoryStream(Buffer), RetrieveEncoding(Encoding), LeaveOpen)
                RowCount = Math.Ceiling(Buffer.Length / View_NumberColumns)
            End If
            mFocusedPosition = 0
            Update_TableRow_OffsetLength()
            Me.Invalidate()
        End Sub
        Public Sub LoadFile(TheFile As String, Optional Encoding As BytesEncoding = BytesEncoding.DEFAULT, Optional LeaveOpen As Boolean = True)
            Dim mFileStream = New IO.FileStream(TheFile, FileMode.Open, IO.FileAccess.ReadWrite, FileShare.ReadWrite)
            mCurrentReader = New COH_BinaryReader(mFileStream, RetrieveEncoding(Encoding), LeaveOpen)
            If mCurrentReader.Length < mCached_MaxSize Then
                mIsCached = True
                mRawbytes = mCurrentReader.ReadBytes(mCurrentReader.RemainingBytes)
                RowCount = Math.Ceiling(mFileStream.Length / View_NumberColumns)
                mCurrentReader.Dispose()
            Else
                mIsCached = False
                RowCount = Math.Ceiling(mFileStream.Length / View_NumberColumns)
            End If
            mFocusedPosition = 0
            Update_TableRow_OffsetLength()
            Me.Invalidate()
        End Sub
        Public Sub LoadStream(ByRef theStream As IO.MemoryStream, Optional Encoding As BytesEncoding = BytesEncoding.DEFAULT, Optional LeaveOpen As Boolean = True)
            mFocusedPosition = theStream.Position
            If mCurrentReader.Length < mCached_MaxSize Then
                mIsCached = True
                theStream.Position = 0
                mRawbytes = theStream.ToArray
                If LeaveOpen = False Then theStream.Dispose()
                RowCount = Math.Ceiling(mRawbytes.Length / View_NumberColumns)
            Else
                mIsCached = False
                mCurrentReader = New COH_BinaryReader(theStream, RetrieveEncoding(Encoding), LeaveOpen)
                RowCount = Math.Ceiling(theStream.Length / View_NumberColumns)
            End If
            Update_TableRow_OffsetLength()
            Me.Invalidate()
        End Sub
        Public Sub LoadStream(ByRef ExistingReader As COH_BinaryReader)
            mIsCached = False
            mCurrentReader = ExistingReader
            RowCount = Math.Ceiling(ExistingReader.Stream.Length / View_NumberColumns)
            mFocusedPosition = ExistingReader.Position
            Update_TableRow_OffsetLength()
            Me.Invalidate()
        End Sub
        Public Sub Scroll_ToFocus()
            If mFocusedPosition = 0 Then Exit Sub
            Dim RowIndex As Integer = mFocusedPosition / 16
            If RowIndex = 0 Then
                RowIndex = 1
            Else
                RowIndex -= 1
            End If
            Me.Select()
            Rows(RowIndex).Selected = True
            FirstDisplayedScrollingRowIndex = RowIndex
        End Sub
#End Region

#Region "Internal"
        Private Function RetrieveEncoding(Encoding As BytesEncoding) As System.Text.Encoding
            Select Case Encoding
                Case BytesEncoding.DEFAULT
                    Return mConfiguration.TextEncoding
                Case BytesEncoding.Ascii
                    Return System.Text.Encoding.ASCII
                Case BytesEncoding.UTF8
                    Return System.Text.Encoding.UTF8
            End Select
            Return mConfiguration.TextEncoding
        End Function
#End Region

#Region "Appearance"
        Private Sub UpdateConfiguration(Configuration As VirtualHexView_Configuration)
            mConfiguration = Configuration
            ResetAppearance()
        End Sub
        Private Sub ResetAppearance(Optional SetDefaults As Boolean = False)
            If SetDefaults = True Or (mConfiguration Is Nothing) Then
                mConfiguration = New VirtualHexView_Configuration
            End If
            ResetAppearance_Columns()
            ResetAppearance_Columns_Labels()
        End Sub
        Private Sub ResetAppearance_Columns()
            Select Case mConfiguration.DataView
                Case BytesView.Hex
                    mWidth_Column = 32
                    mWidth_Table = 120
                    mWidth_Ascii = 150
                Case BytesView.Bits
                    mWidth_Column = 85
                    mWidth_Table = 120
                    mWidth_Ascii = 150
                Case BytesView.Bytes
                    mWidth_Column = 50
                    mWidth_Table = 120
                    mWidth_Ascii = 150
            End Select
        End Sub
        Private Sub Update_TableRow_OffsetLength()
            If mCurrentReader Is Nothing Then Exit Sub
            Select Case mConfiguration.TableView
                Case TableView.Hex
                    mTableOffsetLen = (Hex(mCurrentReader.BaseStream.Length).ToString).Length
                Case TableView.Numbers
                    mTableOffsetLen = (mCurrentReader.BaseStream.Length).ToString.Length
            End Select
            If mTableOffsetLen < 8 Then mTableOffsetLen = 8
            Me.ReadOnly = True
            Me.Refresh()
        End Sub
        Private Sub ResetAppearance_Columns_Labels()
            If Columns.Count <> (mConfiguration.NumberColumns + 1) Then
                Columns.Clear()
                ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                For X = 0 To mConfiguration.NumberColumns - 1
                    Select Case mConfiguration.TableView
                        Case BytesView.Bytes
                            Me.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = X.ToString.PadLeft(3, "0"), .Width = mWidth_Column})
                        Case BytesView.Hex
                            Me.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = Hex(X).ToString.PadLeft(2, "0"), .Width = mWidth_Column})
                    End Select
                Next
                Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Character Text", .Width = mWidth_Ascii, .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill})
                RowHeadersWidth = mWidth_Table
            Else
                RefreshAppearance_Columns_Labels()
            End If
        End Sub
        Private Sub RefreshAppearance_Columns_Labels()
            For X = 0 To mConfiguration.NumberColumns - 2
                Select Case mConfiguration.TableView
                    Case BytesView.Bytes
                        Columns(X).HeaderText = X.ToString.PadLeft(3, "0")
                        Columns(X).Width = mWidth_Column
                    Case BytesView.Hex
                        Columns(X).HeaderText = Hex(X).ToString.PadLeft(2, "0")
                        Columns(X).Width = mWidth_Column
                End Select
            Next
            Me.RowHeadersWidth = mWidth_Table
        End Sub
#End Region

#Region "Virtualization"
        Private Sub COH_VirtualByte_Viewer_NewRowNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles Me.NewRowNeeded
            Dim Position As Long = 0 '= (e.Row * mConfiguration.NumberColumns) + e.ColumnIndex
        End Sub
        Private Sub COH_VirtualByte_Viewer_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles Me.CellValueNeeded
            If e.ColumnIndex = mConfiguration.NumberColumns Then
                RetrieveText(e)
            Else
                RetrieveCell(e)
            End If
            Rows(e.RowIndex).HeaderCell.Value = RetrieveHeader_Text(e.RowIndex)
        End Sub
        Private Function RetrieveHeader_Text(RowIndex As Integer) As String
            Select Case mConfiguration.TableView
                Case TableView.Hex
                    Return Hex(RowIndex * mConfiguration.NumberColumns).ToString.PadLeft(mTableOffsetLen, "0")
                Case TableView.Numbers
                    Return (RowIndex * mConfiguration.NumberColumns).ToString.PadLeft(mTableOffsetLen, "0")
                Case Else
                    Return ""
            End Select
        End Function
        Private Sub RetrieveCell(e As DataGridViewCellValueEventArgs)
            Dim Position As Long = (e.RowIndex * mConfiguration.NumberColumns) + e.ColumnIndex
            If Position >= (TotalLength) Then
                e.Value = "" : Exit Sub
            End If
            Dim TheByte As Byte = RetrieveByte(Position)
            Select Case mConfiguration.DataView
                Case BytesView.Bits
                    e.Value = HelperFunctions.Bits.Convert_ToString(TheByte)
                Case BytesView.Bytes
                    e.Value = TheByte
                Case BytesView.Hex
                    e.Value = Hex(TheByte).ToString.PadLeft(2, "0")
            End Select
            If Position = mFocusedPosition Then
                Me.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Yellow
            End If
        End Sub
        Private Function RetrieveText(Row As Integer) As String
            Dim Position As Long = (Row * mConfiguration.NumberColumns)
            Dim result As String = ""

            Dim TheBytes As Byte() = RetrieveBytes(Position, mConfiguration.NumberColumns)
            'result = mConfiguration.TextEncoding.GetString(TheBytes)
            result = ConvertTo_Ascii(TheBytes)
            Return result
        End Function
        Private Sub RetrieveText(e As DataGridViewCellValueEventArgs)
            e.Value = RetrieveText(e.RowIndex)
        End Sub
        Private ValidCharacters As String = "`~!@#$%^&*()-_+=|\1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ[]{};:',.<>/?" & Chr(34)
        Private Function ConvertTo_Ascii(ByRef Source As Byte()) As String
            Dim SB As New System.Text.StringBuilder
            For X = 0 To Source.Length - 1
                SB.Append(ConvertValueToValidAscii(Source(X)))
            Next
            Return SB.ToString
        End Function
        Private Function ConvertValueToValidAscii(ByVal TheByte As Byte) As String
            Dim TheChar As String = Convert.ToChar(TheByte).ToString.ToUpper
            Try
                If ValidCharacters.Contains(TheChar) Then
                    Return TheChar
                Else
                    Return "."
                End If
            Catch ex As Exception
            End Try
            Return "."
        End Function
        Private Function RetrieveByte(Row As Integer, Col As Integer) As Byte
            Dim Position As Long = (Row * mConfiguration.NumberColumns) + Col
            Return RetrieveByte(Position)
        End Function
        Private Function RetrieveByte(Position As Integer) As Byte
            If mIsCached = False Then
                If Position > mCurrentReader.Length - 1 Then Return 0
                mCurrentReader.Position = Position
                Return mCurrentReader.ReadByte
            Else
                If Position > mRawbytes.Length - 1 Then Return 0
                Return mRawbytes(Position)
            End If
        End Function
        Private Function RetrieveBytes(Position As Integer, TheLength As Integer) As Byte()
            If mIsCached = False Then
                mCurrentReader.Position = Position
                If TheLength > mCurrentReader.RemainingBytes Then
                    Return mCurrentReader.ReadBytes(mCurrentReader.RemainingBytes)
                Else
                    Return mCurrentReader.ReadBytes(TheLength)
                End If
            Else
                Dim RemainBytes As Integer = TheLength
                If (Position + TheLength) > mRawbytes.Length Then
                    RemainBytes = TheLength - ((Position + TheLength) - (mRawbytes.Length))
                End If
                Dim OutBuffer As Byte() = New Byte(RemainBytes - 1) {}
                Array.ConstrainedCopy(mRawbytes, Position, OutBuffer, 0, RemainBytes)
                Return OutBuffer
            End If
        End Function
#End Region

#Region "Shared Function"
        Public Function Create_TXTVersion() As String
            Dim Result As String = ""
            Dim SB As New System.Text.StringBuilder
            Dim RowCount = Math.Ceiling(TotalLength / View_NumberColumns)
            Dim Start As Integer = 0
            If RowCount > 100 Then
                Dim RowIndex As Integer = mFocusedPosition / 16
                If RowIndex >= 5 Then Start = RowIndex - 1
                If Start + 100 > RowCount Then
                    RowCount = RowCount
                Else
                    RowCount = Start + 100
                End If
            End If
            For x = Start To RowCount - 1
                SB.Append(RetrieveHeader_Text(x).PadLeft(mTableOffsetLen, "0") & Chr(9) & Chr(9) & Chr(9))
                For X2 = 0 To mConfiguration.NumberColumns - 1
                    SB.Append(RetrieveByte(x, X2).ToString.PadLeft(3, "0") & " ")
                Next
                SB.AppendLine(RetrieveText(x))
            Next
            MsgBox("Done")
            Return SB.ToString
        End Function
        Public Function Export_ToFile(FilePath As String) As Boolean
            If mIsCached = False Then
                Dim Pos As Integer = mCurrentReader.Position
                Dim ExportResult As Boolean = HelperFunctions.Bytes.Write_BytesToFile(mCurrentReader.BaseStream, FilePath)
                mCurrentReader.Position = Pos
                Return ExportResult
            Else
                Return HelperFunctions.Bytes.Write_BytesToFile(mRawbytes, FilePath)
            End If
        End Function
#End Region

#Region "ListView_VirtualHexView_Configuration"
        Public Class VirtualHexView_Configuration
            Property NumberColumns As Int32
            Property TableView As TableView
            Property DataView As BytesView
            Property TextEncoding As System.Text.Encoding
            Public Sub New()
                TableView = TableView.Hex
                DataView = BytesView.Hex
                NumberColumns = 16
                TextEncoding = System.Text.Encoding.ASCII
            End Sub
        End Class
#End Region
    End Class
End Namespace