Imports COH.CodeManagement.Interfaces.Structures

Namespace GameContent.MessageStores.Structures.LanguageFiles
    Public Class COH_LocalizeContent_Controller
        Implements ISupport_COH_LocalizeContent

#Region "Properties"
        Public Property MessageStores() As List(Of KeyValuePair(Of String, COH_MessageStore))
            Get
                Return mMessageStores
            End Get
            Set(value As List(Of KeyValuePair(Of String, COH_MessageStore)))
                mMessageStores = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mMessageStores As List(Of KeyValuePair(Of String, COH_MessageStore))
#End Region

#Region "Create New Instance"
        Public Sub New()
            mMessageStores = New List(Of KeyValuePair(Of String, COH_MessageStore))
        End Sub
#End Region

#Region "Content Update"
        Public Function AddNew_MessageStore(DisplayName As String, FileSource As String) As Boolean
            If Check_MessageStoreExists(DisplayName) = True Then
                '//MESSAGE HERE NEED TO ADD EVENT LIBRARY HOOKS
            End If
            Dim NewStore As COH_MessageStore = Nothing
            If COH_MessageStore.Import_XMLFile(FileSource, NewStore) = False Then
                '//MESSAGE HERE NEED TO ADD EVENT LIBRARY HOOKS
            End If
            mMessageStores.Add(New KeyValuePair(Of String, COH_MessageStore)(DisplayName, NewStore))
            Return True
        End Function
        Public Function CreateKey(ByRef Value As String) As String Implements ISupport_COH_LocalizeContent.CreateKey
            Dim MStore = mMessageStores(0).Value
            If MStore Is Nothing Then Return Value
            Return MStore.CreateNewID(Value)
        End Function
        Public Function CreateKey(ByRef Value As String, MessageStoreName As String) As String Implements ISupport_COH_LocalizeContent.CreateKey
            Dim MStore = RetrieveMessageStore(MessageStoreName)
            If MStore Is Nothing Then Return Value
            Return MStore.CreateNewID(Value)
        End Function
#End Region

#Region "Internal Functions"
        Private Function Check_MessageStoreExists(Search As String) As Boolean
            For Each TheStore In mMessageStores
                If TheStore.Key = Search Then Return True
                If TheStore.Value.Name = Search Then Return True
            Next
            Return False
        End Function
#End Region

#Region "Search"
        Public Function RetrieveMessageStore(MessageStoreName As String) As COH_MessageStore
            For Each MStore In mMessageStores
                If MStore.Key = MessageStoreName Then Return MStore.Value
            Next
            Return Nothing
        End Function
        Public Function RetrieveLocalizedString(ByRef Search As String) As String Implements ISupport_COH_LocalizeContent.RetrieveLocalizedString
            Dim Found = RetrieveEntry(Search)
            If Not Found Is Nothing Then
                Return Found.Message
            Else
                Return Search
            End If
        End Function
        Private Function RetrieveEntry(Search As String) As COH_MessageStore_Entry
            Dim Found As COH_MessageStore_Entry = Nothing
            If Search = "" Then Return Nothing
            If Try_RetrieveEntry(Search, Found) = False Then Return Nothing
            Return Found
        End Function
        Private Function Try_RetrieveEntry(Search As String, ByRef Result As COH_MessageStore_Entry) As Boolean
            For Each TheStore In mMessageStores
                If TheStore.Value.Try_RetrieveEntry(Search, Result) = True Then
                    Return True
                End If
            Next
            Return False
        End Function


#End Region

    End Class
End Namespace