Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_StoryClue
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
        Property CurrentFile As String
            Get
                Return mCurrentFile
            End Get
            Set(value As String)
                mCurrentFile = value
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
        Property DetailString As String
            Get
                Return mDetailString
            End Get
            Set(value As String)
                mDetailString = value
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
        Property IntroString As String
            Get
                Return mIntroString
            End Get
            Set(value As String)
                mIntroString = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mCurrentFile As String
       Private mDisplayName As String
       Private mDetailString As String
       Private mIcon As String
       Private mIntroString As String
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
            mCurrentFile = String.Empty
            mDisplayName = String.Empty
            mDetailString = String.Empty
            mIcon = String.Empty
            mIntroString = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_StoryClue
            Dim Result As COH_StoryClue = New COH_StoryClue
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mCurrentFile = String.Copy(mCurrentFile)
                .mDisplayName = String.Copy(mDisplayName)
                .mDetailString = String.Copy(mDetailString)
                .mIcon = String.Copy(mIcon)
                .mIntroString = String.Copy(mIntroString)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mCurrentFile)
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_String(mDetailString)
            CurrentWriter.Write_CrypticS_String(mIcon)
            CurrentWriter.Write_CrypticS_String(mIntroString)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mClueName)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mDisplay)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mDetail)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mCurrentFile = CurrentReader.Read_CrypticS_String
            mDisplayName = CurrentReader.Read_CrypticS_String
            mDetailString = CurrentReader.Read_CrypticS_String
            mIcon = CurrentReader.Read_CrypticS_String
            mIntroString = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mClueName = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mDisplay = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mDetail = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
