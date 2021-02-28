Imports COH.HelperClasses.Wrappers
Imports COH.Toolkit.Enums

Namespace ProjectFiles
    Public Class COH_ProjectFile

#Region "Properties"
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property Author As String
            Get
                Return mAuthor
            End Get
            Set(value As String)
                mAuthor = value
            End Set
        End Property
        Property Website As String
            Get
                Return mWebsite
            End Get
            Set(value As String)
                mWebsite = value
            End Set
        End Property
        Property Version As String
            Get
                Return mVersion
            End Get
            Set(value As String)
                mVersion = value
            End Set
        End Property
        Property ReleaseDate As String
            Get
                Return mReleaseDate
            End Get
            Set(value As String)
                mReleaseDate = value
            End Set
        End Property
        Property Description As String
            Get
                Return mDescription
            End Get
            Set(value As String)
                mDescription = value
            End Set
        End Property
#End Region

#Region "Properties - Content"
        ReadOnly Property CharacterOrigins As COH_CrypticS
            Get
                Return Index_Retrieve(COH_ProjectContent.CharacterClasses_PlayerClasses_Origins)
            End Get
        End Property
        ReadOnly Property EnemyOrigins As COH_CrypticS
            Get
                Return Index_Retrieve(COH_ProjectContent.CharacterClasses_EnemyClass_Origins)
            End Get
        End Property
        ReadOnly Property CharacterClasses As COH_CrypticS
            Get
                Return Index_Retrieve(COH_ProjectContent.CharacterClasses_PlayerClasses)
            End Get
        End Property
        ReadOnly Property EnemyClasses As COH_CrypticS
            Get
                Return Index_Retrieve(COH_ProjectContent.CharacterClasses_EnemyClass)
            End Get
        End Property
        ReadOnly Property PowerCategories As COH_CrypticS
            Get
                Return Index_Retrieve(COH_ProjectContent.PowerCategory)
            End Get
        End Property
        ReadOnly Property PowerSets As COH_CrypticS
            Get
                Return Index_Retrieve(COH_ProjectContent.PowerSets)
            End Get
        End Property
        ReadOnly Property Powers As COH_CrypticS
            Get
                Return Index_Retrieve(COH_ProjectContent.Powers)
            End Get
        End Property
        ReadOnly Property Tricks As COH_CrypticS
            Get
                Return Index_Retrieve(COH_ProjectContent.Tricks)
            End Get
        End Property
        Property Content As COH_XML_Dictionary(Of COH_ProjectContent, COH_CrypticS)
            Get
                Return mContent
            End Get
            Set(value As COH_XML_Dictionary(Of COH_ProjectContent, COH_CrypticS))
                mContent = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mName As String
        Private mAuthor As String
        Private mWebsite As String
        Private mVersion As String
        Private mReleaseDate As String
        Private mDescription As String
        Private mContent As COH_XML_Dictionary(Of COH_ProjectContent, COH_CrypticS)
#End Region

#Region "Create New Instances"
        Public Sub New()
            ResetDefaults()
        End Sub
        Public Sub New(ClassName As String)
            ResetDefaults()
            Name = ClassName
        End Sub
        Private Sub ResetDefaults()
            mName = String.Empty
            mAuthor = String.Empty
            mWebsite = String.Empty
            mVersion = String.Empty
            mReleaseDate = String.Empty
            mContent = New COH_XML_Dictionary(Of COH_ProjectContent, COH_CrypticS)
            mDescription = "Full Package"
        End Sub
#End Region

#Region "Search"
        Public Function Retrieve_Details(Search As String, Selected As COH_ProjectContent, ByRef Found As COH_CrypticS_FileContentDetails) As Boolean
            Dim Existing = Index_Retrieve(Selected)
            Dim FoundEntry As COH_CrypticS_FileContentDetails = Nothing
            If Existing.Retrieve_Entry_FromName(Search, FoundEntry) = False Then Return False
            Found = FoundEntry
            Return True
        End Function
        Public Function Retrieve_FilePath(Search As String, Selected As COH_ProjectContent, ByRef Found As String) As Boolean
            Dim Existing = Index_Retrieve(Selected)
            Dim FoundEntry As COH_CrypticS_FileContentDetails = Nothing
            If Existing.Retrieve_Entry_FromName(Search, FoundEntry) = False Then Return False
            Found = FoundEntry.XML_RelativePath
            Return True
        End Function
#End Region

#Region "Update"
        Public Function Index_Update(Selected As COH_ProjectContent, FilePAth As String) As Boolean
            Dim Result As COH_CrypticS = Nothing
            If COH_CrypticS.Import_XMLFile(FilePAth, Result) = False Then Return False
            If mContent.ContainsKey(Selected) = False Then
                mContent.Add(Selected, Result)
            Else
                mContent.Item(Selected) = Result
            End If
            Return True
        End Function
        Public Function Index_Retrieve(Selected As COH_ProjectContent) As COH_CrypticS
            Dim Result As COH_CrypticS = Nothing
            mContent.TryGetValue(Selected, Result)
            Return Result
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_ProjectFile
            Dim Result = New COH_ProjectFile
            With Result
                .mName = String.Copy(mName)
                .mAuthor = String.Copy(mAuthor)
                .mWebsite = String.Copy(mWebsite)
                .mVersion = String.Copy(mVersion)
                .mReleaseDate = String.Copy(mReleaseDate)
                .mDescription = String.Copy(mDescription)
            End With
            Return Result
        End Function
#End Region

#Region "Import/Export"
        Public Shared Function Export_XML_ProjectFolder(FilePAth As String, ByRef Item As COH_ProjectFile) As Boolean
            If HelperFunctions.XML.Export_XMLFile(FilePAth, Item) = False Then
                Return False
            End If
            Return True
        End Function
        Public Shared Function Import_XMLFile(Filepath As String, ByRef Result As COH_ProjectFile) As Boolean
            Result = New COH_ProjectFile
            Dim ImportResult As Boolean = True
            If IO.File.Exists(Filepath) = True Then
                Try
                    Dim Reader As New IO.StreamReader(Filepath)
                    Dim x As New Xml.Serialization.XmlSerializer(Result.GetType)
                    Result = x.Deserialize(Reader)
                    Reader.Close()
                Catch ex As Exception
                    ' ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Error: Unable to Import ProjectFile" & Environment.NewLine & Filepath, ex, True)
                    ImportResult = False
                End Try
            End If
            Return ImportResult
        End Function
#End Region
    End Class
End Namespace