Imports System.IO
Imports System.Xml.Serialization
Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization
Imports COH.Storage.Serialization.Configuration


Namespace GameContent.MessageStores.Structures.LanguageFiles
    Public NotInheritable Class COH_MessageStore

#Region "Properties"
        <XmlAttribute("Name")> Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        <XmlAttribute("Version")> Property Version As UInt32
            Get
                Return mVersion
            End Get
            Set(value As UInt32)
                mVersion = value
            End Set
        End Property
        <XmlElement("Message")> Property Messages As List(Of String)
            Get
                Return mMessages
            End Get
            Set(value As List(Of String))
                mMessages = value
            End Set
        End Property
        <XmlElement("Variable")> Property Variables As List(Of String)
            Get
                Return mVariables
            End Get
            Set(value As List(Of String))
                mVariables = value
            End Set
        End Property
        '<XmlArray("MessageStoreTable")> <XmlArrayItem("Entry")>
        <XmlElement("MessageStore_Table")> Property Table As COH_MessageStore_Dictionary
            Get
                Return mMessageDetails
            End Get
            Set(value As COH_MessageStore_Dictionary)
                mMessageDetails = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mLastSearchIndex As Integer = -1
        Private mfileSource As String
        Private mName As String
        Private mVersion As UInteger
        Private mNumBytes As UInteger
        Private mMessages As List(Of String)
        Private mVariables As List(Of String)
        Private mMessageDetails As COH_MessageStore_Dictionary
#End Region

#Region "Create New Instance"
        Sub New()
            mfileSource = String.Empty
            mName = String.Empty
            mVersion = 20090521
            mMessages = New List(Of String)
            mVariables = New List(Of String)
            mMessageDetails = New COH_MessageStore_Dictionary
        End Sub
        Sub New(Name As String)
            mName = Name
        End Sub
#End Region

#Region "Create Entries"
        Public Function AddNew_Entry_Message(Message As String, Optional Help As String = "", Optional ID As String = "") As COH_MessageStore_Entry
            Dim Result As New COH_MessageStore_Entry
            With Result
                .CustomContent = True
                .Message = Message
                .HelpMessage = Help
                If String.IsNullOrEmpty(ID) Then
                    .MessageID = CreateNewID(Message)
                Else
                    .MessageID = ID
                End If
                .MessageIndex = mMessages.Count
                .HelpIndex = mMessages.Count + 1
                .VariableDefNameIndices = New List(Of COH_MessageStore_EntryVariable)
            End With
            Messages.Add(Message)
            Messages.Add("")
            mMessageDetails.Add(Result.MessageID, Result)
            Return Result
        End Function
#End Region

#Region "Update Entries"
        Public Function UpdateEntry(OriginalID As String, ByRef UpdatedEntry As COH_MessageStore_Entry) As Boolean
            Dim OriginolEntry As COH_MessageStore_Entry = Nothing
            If Try_RetrieveEntry(OriginalID, OriginolEntry) = False Then Return False
            mMessages(UpdatedEntry.MessageIndex) = HelperFunctions.StringsAndThings.Replace_SpecialCharacters(UpdatedEntry.Message)
            mMessages(UpdatedEntry.HelpIndex) = HelperFunctions.StringsAndThings.Replace_SpecialCharacters(UpdatedEntry.HelpMessage)
            UpdatedEntry.CloneTo(OriginolEntry)
            Return True
        End Function
#End Region

#Region "Function IssueNew CRC"
        Public Function CreateNewID(Message As String) As String
            Dim Result As String = "PCORP" & HelperFunctions.Cryptic.Calculate_CRC32(Text.Encoding.ASCII.GetBytes(Message)).ToString
            Dim IndexLoop As Integer = 0
            Do
                If Try_RetrieveEntry(Result, Nothing) = True Then
                    Result = "PCORP" & HelperFunctions.Cryptic.Calculate_CRC32(Text.Encoding.ASCII.GetBytes(Message & IndexLoop.ToString))
                Else
                    Exit Do
                End If
                IndexLoop += 1
            Loop
            Return Result
        End Function
#End Region

#Region "Searching - Text"
        Public Function Try_RetrieveEntry_TextSearch(Search As String, ByRef Result As COH_MessageStore_Entry, Optional SearchNext As Boolean = False) As Boolean
            Dim FoundIndex As Integer = -1
            Dim Start As Integer = 0
            If SearchNext = True Then Start = (mLastSearchIndex + 1)
            For x = Start To mMessages.Count - 1
                Dim match As Text.RegularExpressions.Match = Text.RegularExpressions.Regex.Match(mMessages(x), Search, Text.RegularExpressions.RegexOptions.IgnoreCase)
                If match.Success Then
                    FoundIndex = x
                    Exit For
                End If
            Next
            If FoundIndex = -1 Then
                mLastSearchIndex = -1
                Return False
            Else
                mLastSearchIndex = FoundIndex
            End If
            For Each Entry In mMessageDetails
                If Entry.Value.MessageIndex = FoundIndex Then
                    Result = Entry.Value
                    Return True
                End If
            Next
            Return FoundIndex >= 0
        End Function
#End Region

#Region "Searching - Single"
        Public Function RetrieveEntry(Search As String) As COH_MessageStore_Entry
            Dim Result As COH_MessageStore_Entry = Nothing
            If Try_RetrieveEntry(Search, Result) = False Then Return Nothing
            Return Result
        End Function
        Public Function Try_RetrieveEntry(Search As String, ByRef Result As COH_MessageStore_Entry) As Boolean
            Dim ResultS As Boolean = mMessageDetails.TryGetValue(Search, Result)
            If ResultS = True Then Update_ReferenceMap(Result)
            Return ResultS
        End Function
        Public Function RetrieveString_Message(Index As Integer, ByRef Message As String) As Boolean
            Message = mMessages(Index)
            Return True
        End Function
        Public Function RetrieveString_Variable(Index As Integer, ByRef Message As String, ByRef Additional As String) As Boolean
            Message = mVariables(Index)
            Additional = mVariables(Index + 1)
            Return True
        End Function
#End Region

#Region "Import XML"
        Public Shared Function Import_XMLFile(Filepath As String, ByRef Result As COH_MessageStore) As Boolean
            Result = New COH_MessageStore
            Dim ImportResult As Boolean = True
            If IO.File.Exists(Filepath) = True Then
                Try
                    Dim Reader As New IO.StreamReader(Filepath)
                    Dim x As New Xml.Serialization.XmlSerializer(Result.GetType)
                    Result = x.Deserialize(Reader)
                    Reader.Close()
                    Result.mfileSource = Filepath
                Catch ex As Exception
                    'sContentManager.ShowMessage_SimpleError("Error: Unable to Import Character Class" & Environment.NewLine & Filepath)
                    ImportResult = False
                End Try
            End If
            Return ImportResult
        End Function
#End Region

#Region "Export - XML"
        Public Function Save() As Boolean
            Return Export_To_XMLFile(mfileSource)
        End Function
        Private Shared Function CreateXML_NameSpace() As XmlSerializerNamespaces
            Dim XMLNameSpace As XmlSerializerNamespaces = New XmlSerializerNamespaces()
            XMLNameSpace.Add("", "")
            Return XMLNameSpace
        End Function
        Private Shared Function XMLFile_CreateXML_Settings() As Xml.XmlWriterSettings
            Dim result As New Xml.XmlWriterSettings
            result.Indent = True
            result.OmitXmlDeclaration = True
            result.WriteEndDocumentOnClose = True
            result.Encoding = Text.Encoding.GetEncoding(1252)
            Return result
        End Function

#Region "Export"
        Public Function Export_To_XMLFile(Filepath As String) As Boolean
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Filepath)) = False Then IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Filepath))
            Dim Result As String = ""
            Dim ExportResult As Boolean = True
            Try
                Dim Writer As New IO.StreamWriter(Filepath)
                Dim x As New System.Xml.Serialization.XmlSerializer(Me.GetType)
                x.Serialize(Writer, Me)
                Writer.WriteLine()
                Result = Writer.ToString
                Writer.Dispose()
            Catch ex As Exception
                'MsgBox(ex)
                ExportResult = False
            End Try
            Return ExportResult
        End Function
        Public Function Export_ToTextString_XMLFormat(ByRef Result As String) As Boolean
            Result = ""
            Dim ExportResult As Boolean = True
            Try
                Dim SB As New Text.StringBuilder
                Dim xmlSerializer As XmlSerializer = New XmlSerializer(Me.GetType)
                Dim Sw = Xml.XmlWriter.Create(SB, XMLFile_CreateXML_Settings)
                xmlSerializer.Serialize(Sw, Me, CreateXML_NameSpace)
                Result = SB.ToString()
            Catch ex As Exception
                COH_LibraryEventController.ShowErrorOccured_Exception(Internal.Events.COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Export XML", ex, True)
                ExportResult = False
            End Try
            Return ExportResult
        End Function
#End Region










        Public Function Export_To_XMLFile2(Filepath As String) As Boolean
            Return XMLFile_Export(Filepath, Me)
        End Function
        Private Function XMLFile_Export(Filepath As String, Source As Object) As Boolean
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Filepath)) = False Then IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Filepath))
            Dim XMlString As String = ""
            Dim ExportResult As Boolean = XMLFile_Export_String(Source, XMlString, New COH_Serialization_Settings(True, COH_ExportFormat.XML))
            If ExportResult = False Then Return False
            Try
                File.WriteAllText(Filepath, XMlString)
            Catch ex As Exception
                ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Export XML", ex, True)
                ExportResult = False
            End Try
            Return ExportResult
        End Function
        Public Function Export_ToTextString_XMLFormat2(ByRef Result As String) As Boolean
            Return XMLFile_Export_String(Me, Result, Nothing)
        End Function
        Private Function XMLFile_Export_String(Source As Object, ByRef Result As String, Optional ByRef Settings As COH_Serialization_Settings = Nothing) As Boolean
            Result = ""
            Dim ExportResult As Boolean = True
            Dim Test As COH_XML_Serialization = New COH_XML_Serialization(Settings)
            Try
                Result = Test.Serialize_ToXML(Source)
            Catch ex As Exception
                COH_LibraryEventController.ShowErrorOccured_Exception(Internal.Events.COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Export XML", ex, True)
                ExportResult = False
                Result = Test.RetrieveText
            End Try
            Return ExportResult
        End Function
#End Region
    End Class
End Namespace