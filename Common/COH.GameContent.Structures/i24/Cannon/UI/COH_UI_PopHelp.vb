Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_UI_PopHelp
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Tag
            End Get
        End Property
#End Region

#Region "Properties"
        Property Tag As String
            Get
                Return mTag
            End Get
            Set(value As String)
                mTag = value
            End Set
        End Property
        Property InYourFace As Boolean
            Get
                Return mInYourFace
            End Get
            Set(value As Boolean)
                mInYourFace = value
            End Set
        End Property
        Property DisplayTitle As String
            Get
                Return mDisplayTitle
            End Get
            Set(value As String)
                mDisplayTitle = value
            End Set
        End Property
        Property DisplayText As String
            Get
                Return mDisplayText
            End Get
            Set(value As String)
                mDisplayText = value
            End Set
        End Property
        Property SoundName As String
            Get
                Return mSoundName
            End Get
            Set(value As String)
                mSoundName = value
            End Set
        End Property
        Property TimeTriggered As Int64
            Get
                Return mTimeTriggered
            End Get
            Set(value As Int64)
                mTimeTriggered = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
        Property DisplayTitleKey As String
            Get
                Return mDisplayTitleKey
            End Get
            Set(value As String)
                mDisplayTitleKey = value
            End Set
        End Property
        Property DisplayTextKey As String
            Get
                Return mDisplayTextKey
            End Get
            Set(value As String)
                mDisplayTextKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mTag As String
       Private mInYourFace As Boolean
       Private mDisplayTitle As String
       Private mDisplayText As String
       Private mSoundName As String
       Private mTimeTriggered As Int64
       Private mDisplayTitleKey As String
       Private mDisplayTextKey As String
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings as COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings as COH_Serialization_Settings = Nothing)
             MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
             MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mTag = String.Empty
            mDisplayTitle = String.Empty
            mDisplayText = String.Empty
            mSoundName = String.Empty
            mDisplayTitleKey = String.Empty
            mDisplayTextKey = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayText = LocalizeController.RetrieveLocalizedString(mDisplayTextKey)
            mDisplayTitle = LocalizeController.RetrieveLocalizedString(mDisplayTitleKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_UI_PopHelp
            Dim Result As COH_UI_PopHelp = New COH_UI_PopHelp
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTag = String.Copy(mTag)
                .mInYourFace = mInYourFace
                .mDisplayTitle = String.Copy(mDisplayTitle)
                .mDisplayText = String.Copy(mDisplayText)
                .mSoundName = String.Copy(mSoundName)
                .mTimeTriggered = mTimeTriggered
                .mDisplayTitleKey = String.Copy(mDisplayTitleKey)
                .mDisplayTextKey = String.Copy(mDisplayTextKey)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mTag)
            CurrentWriter.Write_CrypticS_Boolean(mInYourFace)
            CurrentWriter.Write_CrypticS_String(mDisplayTitleKey)
            CurrentWriter.Write_CrypticS_String(mDisplayTextKey)
            CurrentWriter.Write_CrypticS_String(mSoundName)
            CurrentWriter.Write(mTimeTriggered)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTag = CurrentReader.Read_CrypticS_String
            mInYourFace = CurrentReader.Read_CrypticS_Boolean
            mDisplayTitleKey = CurrentReader.Read_CrypticS_String
            mDisplayTextKey = CurrentReader.Read_CrypticS_String
            mSoundName = CurrentReader.Read_CrypticS_String
            mTimeTriggered = CurrentReader.ReadInt64
            Return True
        End Function
#End Region

    End Class
End Namespace
