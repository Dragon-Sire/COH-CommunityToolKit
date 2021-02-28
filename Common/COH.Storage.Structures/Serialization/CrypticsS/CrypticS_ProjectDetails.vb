Imports System.ComponentModel
Imports System.Xml.Serialization
Imports COH.CodeManagement.Enums.Structures
Imports COH.GameContent.CodeManagement.Enums.Structures

Namespace Storage.Structures.CrypticsS
    Public NotInheritable Class COH_CrypticS_FileContentDetails

#Region "Properties"
        <XmlAttribute> Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        <XmlAttribute> Property FileIndex As Integer
            Get
                Return mFileIndex
            End Get
            Set(value As Integer)
                mFileIndex = value
            End Set
        End Property
        <XmlAttribute> <ReadOnlyAttribute(True)> Property IsCustom As Boolean
            Get
                Return mIsCustom
            End Get
            Set(value As Boolean)
                mIsCustom = value
            End Set
        End Property
        <XmlAttribute> <ReadOnlyAttribute(True)> Property WasModified_FromSource As Boolean
            Get
                Return mWasModified_FromSource
            End Get
            Set(value As Boolean)
                mWasModified_FromSource = value
            End Set
        End Property
        <XmlIgnore> Property Size As Integer
            Get
                Return mSize
            End Get
            Set(value As Integer)
                mSize = value
            End Set
        End Property
        <XmlIgnore> Property Offset As Integer
            Get
                Return mOffset
            End Get
            Set(value As Integer)
                mOffset = value
            End Set
        End Property
        Property XML_RelativePath As String
            Get
                Return mXML_RelativePath
            End Get
            Set(value As String)
                mXML_RelativePath = value
            End Set
        End Property
        Property REF_OriginolPath As String
            Get
                Return mRefSource
            End Get
            Set(value As String)
                mRefSource = value
            End Set
        End Property
        Property REF_FullName As String
            Get
                Return mRefFullName
            End Get
            Set(value As String)
                mRefFullName = value
            End Set
        End Property
        Property REF_ContentSource As COH_ContentSource
            Get
                Return mRefIssueSource
            End Get
            Set(value As COH_ContentSource)
                mRefIssueSource = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mFileIndex As Integer
        Private mName As String
        Private mRefFullName As String
        Private mXML_RelativePath As String
        Private mRefSource As String
        Private mSize As Integer
        Private mOffset As Integer
        Private mIsCustom As Boolean
        Private mWasModified_FromSource As Boolean
        Private mRefIssueSource As COH_ContentSource
#End Region

#Region "Create New Instance"
        Public Sub New()
            ResetDefaults()
        End Sub
        Sub New(Value As String, Value2 As Integer)
            ResetDefaults()
            mXML_RelativePath = Value
            mRefSource = ""
            mSize = Value2
        End Sub
        Private Sub ResetDefaults()
            mFileIndex = 0
            mName = String.Empty
            mXML_RelativePath = String.Empty
            mRefFullName = String.Empty
            mSize = 0
            mOffset = 0
            mIsCustom = False
            mWasModified_FromSource = False
            mRefSource = String.Empty
            mRefIssueSource = COH_ContentSource.Vol1_i24
        End Sub
        Public Overrides Function ToString() As String
            Return mXML_RelativePath
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_CrypticS_FileContentDetails
            Dim Destination As New COH_CrypticS_FileContentDetails
            With Destination
                '.mXML_RelativePath = CloneString(mXML_RelativePath)
                '.mRefSource = CloneString(mRefSource)
                '.mRefFullName = CloneString(mRefFullName)
                '.mRefIssueSource = CloneString(mRefIssueSource)
                '.mSize = mSize
                '.mOffset = mOffset
                '.mName = String.Copy(mName)
            End With
            Return Destination
        End Function
#End Region
    End Class

End Namespace