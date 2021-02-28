Imports System.Xml.Serialization

Namespace GameContent.MessageStores.Structures.LanguageFiles
    Public NotInheritable Class COH_MessageStore_Entry

#Region "Properties"
        <XmlAttribute> Property MessageID As String
            Get
                Return mMessageID
            End Get
            Set(value As String)
                mMessageID = value
            End Set
        End Property
        <XmlAttribute> Property MessageIndex As Integer
            Get
                Return mMessageIndex
            End Get
            Set(value As Integer)
                mMessageIndex = value
            End Set
        End Property
        <XmlAttribute> Property HelpIndex As Integer
            Get
                Return mHelpIndex
            End Get
            Set(value As Integer)
                mHelpIndex = value
            End Set
        End Property
        <XmlAttribute> Property CustomContent As Boolean
            Get
                Return mCustomContent
            End Get
            Set(value As Boolean)
                mCustomContent = value
            End Set
        End Property
        <XmlArray("VariableEntries")> <XmlArrayItem("VariableEntry")>
        Property VariableDefNameIndices As List(Of COH_MessageStore_EntryVariable)
            Get
                Return mVariableDefNameIndices
            End Get
            Set(value As List(Of COH_MessageStore_EntryVariable))
                If value Is Nothing Then Exit Property
                mVariableDefNameIndices = value
            End Set
        End Property
#End Region

#Region "Properties - Reference Map"
        <XmlIgnore> Property Message As String
            Get
                Return mMessage
            End Get
            Set(value As String)
                mMessage = value
            End Set
        End Property
        <XmlIgnore> Property HelpMessage As String
            Get
                Return mHelpMessage
            End Get
            Set(value As String)
                mHelpMessage = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mMessage As String
        Private mHelpMessage As String
        Private mMessageID As String ' The message ID associated with the message.  For debugging convenience.
        Private mMessageIndex As Integer 'The message index into a string table,  to be printed as double-byte strings.
        Private mHelpIndex As Integer 'The help index into a string table,  to be printed as double-byte strings.
        Private mVariableDefNameIndices As List(Of COH_MessageStore_EntryVariable)
        Private mCustomContent As Boolean
#End Region

#Region "Create New Instance"
        Public Sub New()
            mMessage = String.Empty
            mHelpMessage = String.Empty
            mMessageID = String.Empty
            mMessageIndex = -1
            mHelpIndex = -1
            mVariableDefNameIndices = New List(Of COH_MessageStore_EntryVariable)
            mCustomContent = False
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_MessageStore_Entry
            Dim Result As COH_MessageStore_Entry = New COH_MessageStore_Entry
            CloneTo(Result)
            Return Result
        End Function
        Public Sub CloneTo(ByRef Destination As COH_MessageStore_Entry)
            With Destination
                .mMessage = String.Copy(mMessage)
                .mHelpMessage = String.Copy(mHelpMessage)
                .mMessageID = String.Copy(mMessageID)
                .mMessageIndex = mMessageIndex
                .mHelpIndex = mHelpIndex
                .mVariableDefNameIndices = New List(Of COH_MessageStore_EntryVariable)
                For x = 0 To mVariableDefNameIndices.Count - 1
                    .mVariableDefNameIndices.Add(mVariableDefNameIndices(x).Clone)
                Next
                .mCustomContent = mCustomContent
            End With
        End Sub
#End Region

    End Class
End Namespace