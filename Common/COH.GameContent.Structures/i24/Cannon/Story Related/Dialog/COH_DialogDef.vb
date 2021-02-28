Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_DialogDef
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property CurrentFile As String
            Get
                Return mCurrentFile
            End Get
            Set(value As String)
                mCurrentFile = value
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
        Property Filename As String
            Get
                Return mFilename
            End Get
            Set(value As String)
                mFilename = value
            End Set
        End Property
        Property QualifyRequires As String()
            Get
                Return mQualifyRequires
            End Get
            Set(value As String())
                mQualifyRequires = value
            End Set
        End Property
        Property Page As COH_DialogPage()
            Get
                Return mPage
            End Get
            Set(value As COH_DialogPage())
                mPage = value
            End Set
        End Property
        Property MissionPage As COH_DialogPage()
            Get
                Return mMissionPage
            End Get
            Set(value As COH_DialogPage())
                mMissionPage = value
            End Set
        End Property
        Property ContactPage As COH_DialogPage()
            Get
                Return mContactPage
            End Get
            Set(value As COH_DialogPage())
                mContactPage = value
            End Set
        End Property
        Property PageList As COH_DialogPageList()
            Get
                Return mPageList
            End Get
            Set(value As COH_DialogPageList())
                mPageList = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mCurrentFile As String
       Private mName As String
       Private mFilename As String
       Private mQualifyRequires As String()
       Private mPage As COH_DialogPage()
       Private mMissionPage As COH_DialogPage()
       Private mContactPage As COH_DialogPage()
       Private mPageList As COH_DialogPageList()
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mCurrentFile = String.Empty
            mName = String.Empty
            mFilename = String.Empty
            mQualifyRequires = New String() {}
            mPage = New COH_DialogPage() {}
            mMissionPage = New COH_DialogPage() {}
            mContactPage = New COH_DialogPage() {}
            mPageList = New COH_DialogPageList() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_DialogDef
            Dim Result As COH_DialogDef = New COH_DialogDef
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCurrentFile = String.Copy(mCurrentFile)
                .mName = String.Copy(mName)
                .mFilename = String.Copy(mFilename)
                .mQualifyRequires = mQualifyRequires.CloneTheStrings
                .mPage = New COH_DialogPage(mPage.Count - 1) {}
                For X = 0 To mPage.Count - 1
                    .mPage(X) = mPage(X).Clone
                Next
                .mMissionPage = New COH_DialogPage(mMissionPage.Count - 1) {}
                For X = 0 To mMissionPage.Count - 1
                    .mMissionPage(X) = mMissionPage(X).Clone
                Next
                .mContactPage = New COH_DialogPage(mContactPage.Count - 1) {}
                For X = 0 To mContactPage.Count - 1
                    .mContactPage(X) = mContactPage(X).Clone
                Next
                .mPageList = New COH_DialogPageList(mPageList.Count - 1) {}
                For X = 0 To mPageList.Count - 1
                    .mPageList(X) = mPageList(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mCurrentFile)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mFilename)
            CurrentWriter.Write_CrypticS_StringArray(mQualifyRequires)
            If CurrentWriter.Write_CrypticS_StructArray(mPage) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mMissionPage) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mContactPage) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mPageList) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mCurrentFile = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mFilename = CurrentReader.Read_CrypticS_String
            mQualifyRequires = CurrentReader.Read_CrypticS_StringArray()
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_DialogPage), mPage) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_DialogPage), mMissionPage) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_DialogPage), mContactPage) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_DialogPageList), mPageList) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
