Imports System.Xml.Serialization
Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Controllers
Imports COH.Storage.Serialization

Namespace Storage.Structures.CrypticsS
    Public Class COH_CrypticS

#Region "Properties"
        Property ID As String
            Get
                Return mIdentifier
            End Get
            Set(value As String)
                mIdentifier = value
            End Set
        End Property
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property ParseVersion As COH_BinaryFormat
            Get
                Return mParseVersionUsed
            End Get
            Set(value As COH_BinaryFormat)
                mParseVersionUsed = value
            End Set
        End Property
        Property Build As COH_BuildType
            Get
                Return mBuild
            End Get
            Set(value As COH_BuildType)
                mBuild = value
            End Set
        End Property
        Property BuildCRC As Integer
            Get
                Return mAdler32CheckSum
            End Get
            Set(value As Integer)
                mAdler32CheckSum = value
            End Set
        End Property
        ReadOnly Property SupportedBinType As COH_SupportedBinFiles
            Get
                Return mAdler32CheckSum
            End Get
        End Property
        ReadOnly Property FilesCount As Integer
            Get
                Return mFiles.Count
            End Get
        End Property
        <XmlArray("COH_BIN_FileTableEntries")> <XmlArrayItem("COH_BIN_FileTableEntry")>
        Public Property Entries As List(Of COH_CrypticS_FileEntry)
            Get
                Return mEntries
            End Get
            Set(value As List(Of COH_CrypticS_FileEntry))
                mEntries = value
            End Set
        End Property
        <XmlArray("COH_BIN_FileTables")> <XmlArrayItem("COH_BIN_FileTable")>
        Public Property Files As List(Of COH_CrypticS_File)
            Get
                Return mFiles
            End Get
            Set(value As List(Of COH_CrypticS_File))
                mFiles = value
            End Set
        End Property

#End Region

#Region "Property Options"
        Public Property Options As COH_CrypticS_Settings
            Get
                Return mSettings
            End Get
            Set(value As COH_CrypticS_Settings)
                mSettings = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mIdentifier As String
        Private mName As String
        Private mEntries As List(Of COH_CrypticS_FileEntry)
        Private mParseVersionUsed As COH_BinaryFormat
        Private mBuild As COH_BuildType
        Private mAdler32CheckSum As Integer ' Should Be CheckSum
        Private mFiles As List(Of COH_CrypticS_File)
        '//Options
        Private mSettings As COH_CrypticS_Settings
        '//Not Implemented Yet
        Friend mMasterList As List(Of COH_CrypticS_FileEntry)
        Private rFileStructs As COH_FileStructureIndex_Controller
#End Region

#Region "Create New Instance"
        Public Sub New()
            mSettings = New COH_CrypticS_Settings
        End Sub
        Public Sub New(Name As String, Settings As COH_CrypticS_Settings, ByRef RegisteredFileStructs As COH_FileStructureIndex_Controller)
            mName = Name
            mSettings = Settings
            mBuild = COH_BuildType.Either
            rFileStructs = RegisteredFileStructs
        End Sub
        Public Sub Update_SupportedStructs(ByRef RegisteredFileStructs As COH_FileStructureIndex_Controller)
            rFileStructs = RegisteredFileStructs
        End Sub
#End Region

#Region "Internal Private Functions"
        Public Function Import_FromStream(ByRef CurrentReader As COH_BinaryReader, Optional ShowProgress As Boolean = False) As Boolean
            mIdentifier = System.Text.Encoding.ASCII.GetString(CurrentReader.ReadBytes(8))
            If Not mIdentifier = "CrypticS" Then Return False
            mAdler32CheckSum = CurrentReader.ReadInt32 '1495568075
            Dim L1 As Int16 = CurrentReader.ReadInt16
            Dim TempV = System.Text.Encoding.ASCII.GetString(CurrentReader.ReadBytes(L1))
            If TempV = "Parse6" Then
                mParseVersionUsed = COH_BinaryFormat.CrypticsS_Parse6
                Return Import_FromStream_Parse6(CurrentReader, ShowProgress)
            ElseIf TempV = "Parse7" Then
                mParseVersionUsed = COH_BinaryFormat.CrypticsS_Parse7
                Return Import_FromStream_Parse7(CurrentReader, ShowProgress)
            Else
                mParseVersionUsed = COH_BinaryFormat.Unknown
                Return False
            End If
        End Function
#End Region

#Region "Search"
        Public Function Retrieve_Entry_FromName(Search As String, ByRef Result As COH_CrypticS_FileContentDetails) As Boolean
            For Each Entry In Files
                If Entry.Retrieve_Entry_FromName(Search, Result) = True Then Return True
            Next
            Return False
        End Function
        Public Function Retrieve_AllEntryPaths(Optional Sort As Boolean = True) As List(Of KeyValuePair(Of String, String))
            Dim Result As New List(Of KeyValuePair(Of String, String))

            For Each Entry In Files
                Result.AddRange(Entry.Retrieve_AllEntryPaths(False))
            Next
            If Sort = True Then
                Result.Sort(Function(x, y) x.Key.CompareTo(y.Key))
            End If
            Return Result
        End Function
        Public Function Retrieve_AllEntryPaths_SpecifiedFile(Index As Integer, Optional Sort As Boolean = True) As List(Of KeyValuePair(Of String, String))
            Dim Result As New List(Of KeyValuePair(Of String, String))
            Result.AddRange(Files(Index).Retrieve_AllEntryPaths(False))
            If Sort = True Then Result.Sort(Function(x, y) x.Key.CompareTo(y.Key))
            Return Result
        End Function
#End Region

#Region "Import"
        Public Shared Function Import_XMLFile(Filepath As String, ByRef Result As COH_CrypticS) As Boolean
            Result = New COH_CrypticS
            Dim ImportResult As Boolean = True
            If IO.File.Exists(Filepath) = True Then
                Try
                    Dim Reader As New IO.StreamReader(Filepath)
                    Dim x As New Xml.Serialization.XmlSerializer(Result.GetType)
                    Result = x.Deserialize(Reader)
                    Reader.Close()
                Catch ex As Exception
                    ImportResult = False
                End Try
            End If
            Return ImportResult
        End Function
#End Region

    End Class
End Namespace