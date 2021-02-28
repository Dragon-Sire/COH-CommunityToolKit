Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_SouvenirClue
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property FileName As String
            Get
                Return mFileName
            End Get
            Set(value As String)
                mFileName = value
            End Set
        End Property
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property Icon As String
            Get
                Return mIcon
            End Get
            Set(value As String)
                mIcon = value
            End Set
        End Property
        Property DetailString As String
            Get
                Return mDetailString
            End Get
            Set(value As String)
                mDetailString = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
        Property DisplayNameKey As String
            Get
                Return mDisplayNameKey
            End Get
            Set(value As String)
                mDisplayNameKey = value
            End Set
        End Property
        Property DetailStringKey As String
            Get
                Return mDetailStringKey
            End Get
            Set(value As String)
                mDetailStringKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mFileName As String
       Private mDisplayName As String
       Private mIcon As String
       Private mDetailString As String
       Private mDetailStringKey As String
       Private mDisplayNameKey As String
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
            mName = String.Empty
            mFileName = String.Empty
            mDisplayName = String.Empty
            mIcon = String.Empty
            mDetailString = String.Empty
            mDetailStringKey = String.Empty
            mDisplayNameKey = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            mDetailString = LocalizeController.RetrieveLocalizedString(mDetailStringKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_SouvenirClue
            Dim Result As COH_SouvenirClue = New COH_SouvenirClue
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFileName = String.Copy(mFileName)
                .mDisplayName = String.Copy(mDisplayName)
                .mIcon = String.Copy(mIcon)
                .mDetailString = String.Copy(mDetailString)
                .mDetailStringKey = String.Copy(mDetailStringKey)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mFileName)
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_String(mIcon)
            CurrentWriter.Write_CrypticS_String(mDetailStringKey)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mFileName = CurrentReader.Read_CrypticS_String
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mIcon = CurrentReader.Read_CrypticS_String
            mDetailStringKey = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
