Imports System.Xml.Serialization

Namespace Storage.Structures.CrypticsS
    Public NotInheritable Class COH_CrypticS_File

#Region "Properties"

        <XmlElement("Reference")> Public Property Details As List(Of COH_CrypticS_FileContentDetails)
            Get
                Return mContents
            End Get
            Set(value As List(Of COH_CrypticS_FileContentDetails))
                mContents = value
            End Set
        End Property
#End Region

#Region "Properterties - Used BIN"
        <XmlIgnore> Public Property BinaryTableStarts As Long
            Get
                Return mBinaryTableStarts
            End Get
            Set(value As Long)
                mBinaryTableStarts = value
            End Set
        End Property
        ReadOnly Property Name As String
            Get
                Return mSectionName
            End Get
        End Property
        <XmlIgnore> Property Size As Integer
            Get
                Return mSize
            End Get
            Set(value As Integer)
                mSize = value
            End Set
        End Property
        <XmlIgnore> Property NumberContents As Integer
            Get
                Return mNumberContents
            End Get
            Set(value As Integer)
                mNumberContents = value
            End Set
        End Property
        ReadOnly Property SupportedType As Type
            Get
                Return mSupportedType
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private mSectionName As String
        Private mSupportedType As Type

        Private mContents As List(Of COH_CrypticS_FileContentDetails)
        Private mBinaryTableStarts As Long
        Private mSize As Integer
        Private mNumberContents As Integer
#End Region

#Region "Create New Instance"
        Sub New()
            mContents = New List(Of COH_CrypticS_FileContentDetails)
        End Sub
#End Region

#Region "Search"
        Public Function Retrieve_Entry_FromName(Search As String, ByRef Result As COH_CrypticS_FileContentDetails) As Boolean
            For Each Item In mContents
                If String.Equals(Item.REF_FullName, Search, StringComparison.CurrentCultureIgnoreCase) Then
                    Result = Item
                    Return True
                ElseIf String.Equals(Item.Name, Search, StringComparison.CurrentCultureIgnoreCase) Then
                    Result = Item
                    Return True
                ElseIf String.Equals(Item.XML_RelativePath, Search, StringComparison.CurrentCultureIgnoreCase) Then
                    Result = Item
                    Return True
                ElseIf Item.XML_RelativePath.ToLower.Contains(Search.ToLower) Then
                    Result = Item
                    Return True
                End If
            Next
            Return False
        End Function
        Public Function Retrieve_AllEntryPaths(Optional Sort As Boolean = True) As List(Of KeyValuePair(Of String, String))
            Dim Result As New List(Of KeyValuePair(Of String, String))
            For Each Item In mContents
                Result.Add(New KeyValuePair(Of String, String)(Item.XML_RelativePath, Item.Name))
            Next
            If Sort = True Then Result.Sort()
            Return Result
        End Function
#End Region

#Region "Update Relatative Paths"
        Public Sub Update_SupportedType(Name As String, TheType As Type)
            mSectionName = Name
            mSupportedType = TheType
        End Sub
        Public Sub Update_RelativePaths(NewRoot As String)
            For Each Item In mContents
                Item.XML_RelativePath = (NewRoot & Item.XML_RelativePath)
            Next
        End Sub
#End Region

    End Class
End Namespace
