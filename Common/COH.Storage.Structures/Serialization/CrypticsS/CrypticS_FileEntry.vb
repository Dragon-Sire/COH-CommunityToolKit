Imports System.Xml.Serialization

Namespace Storage.Structures.CrypticsS
    Public NotInheritable Class COH_CrypticS_FileEntry

#Region "Properties"
        <XmlAttribute> Property DefFilePath As String
            Get
                Return mFilePath
            End Get
            Set(value As String)
                mFilePath = value
            End Set
        End Property
        <XmlAttribute> Property Time As Integer
            Get
                Return mTime
            End Get
            Set(value As Integer)
                mTime = value
            End Set
        End Property
        Property FileDate_ReferenceOnly As Date
            Get
                Return HelperFunctions.DateTimeFunctions.Convert_Uint32Value_To_DateTime(mTime)
            End Get
            Set(value As Date)
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mFilePath As String
        Private mTime As Integer
#End Region

#Region "Create New Instance"
        Public Sub New()
            mFilePath = String.Empty
            mTime = 0
        End Sub
        Sub New(Value As String, Value2 As Integer)
            mFilePath = Value
            mTime = Value2
        End Sub
        Public Overrides Function ToString() As String
            Return mFilePath
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_CrypticS_FileEntry
            Dim Destination As New COH_CrypticS_FileEntry
            With Destination
                '.mFilePath = String.Copy(mFilePath)
                .mTime = mTime
            End With
            Return Destination
        End Function
#End Region

#Region "Import"
        Public Shared Function Import_XMLFile(Filepath As String, ByRef Result As List(Of COH_CrypticS_FileEntry)) As Boolean
            Result = New List(Of COH_CrypticS_FileEntry)
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

