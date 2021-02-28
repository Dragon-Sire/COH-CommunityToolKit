Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_UI_Widget
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return DisplayName
            End Get
        End Property
#End Region

#Region "Properties"
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property DisplayHelp As String
            Get
                Return mDisplayHelp
            End Get
            Set(value As String)
                mDisplayHelp = value
            End Set
        End Property
        Property DisplayShortHelp As String
            Get
                Return mDisplayShortHelp
            End Get
            Set(value As String)
                mDisplayShortHelp = value
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
        Property DisplayHelpKey As String
            Get
                Return mDisplayHelpKey
            End Get
            Set(value As String)
                mDisplayHelpKey = value
            End Set
        End Property
        Property DisplayShortHelpKey As String
            Get
                Return mDisplayShortHelpKey
            End Get
            Set(value As String)
                mDisplayShortHelpKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mDisplayName As String
       Private mDisplayHelp As String
       Private mDisplayShortHelp As String
       Private mIcon As String
       Private mDisplayNameKey As String
       Private mDisplayHelpKey As String
       Private mDisplayShortHelpKey As String
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
            mDisplayName = String.Empty
            mDisplayHelp = String.Empty
            mDisplayShortHelp = String.Empty
            mIcon = String.Empty
            mDisplayNameKey = String.Empty
            mDisplayHelpKey = String.Empty
            mDisplayShortHelpKey = String.Empty
            mIcon = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            mDisplayHelp = LocalizeController.RetrieveLocalizedString(mDisplayHelpKey)
            mDisplayShortHelp = LocalizeController.RetrieveLocalizedString(mDisplayShortHelpKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_UI_Widget
            Dim Result As COH_UI_Widget = New COH_UI_Widget
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayHelp = String.Copy(mDisplayHelp)
                .mDisplayShortHelp = String.Copy(mDisplayShortHelp)
                .mIcon = String.Copy(mIcon)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mDisplayHelpKey = String.Copy(mDisplayHelpKey)
                .mDisplayShortHelpKey = String.Copy(mDisplayShortHelpKey)
                .mIcon = String.Copy(mIcon)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_String(mDisplayHelpKey)
            CurrentWriter.Write_CrypticS_String(mDisplayShortHelpKey)
            CurrentWriter.Write_CrypticS_String(mIcon)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mDisplayHelpKey = CurrentReader.Read_CrypticS_String
            mDisplayShortHelpKey = CurrentReader.Read_CrypticS_String
            mIcon = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
