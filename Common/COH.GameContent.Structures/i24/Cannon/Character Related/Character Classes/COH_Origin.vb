Namespace GameContent.Structures.Characters
    Public NotInheritable Class COH_Origin
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("Display")> Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
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

#Region "Properties - Localization"
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
       Private mName As String
       Private mFilePathReference_Def As String
       Private mFilePathReference_XML As String
       Private mDisplayName As String
       Private mDisplayHelp As String
       Private mDisplayShortHelp As String
       Private mIcon As String
        '//LOCALIZATION
       Private mDisplayNameKey As String
       Private mDisplayHelpKey As String
       Private mDisplayShortHelpKey As String
#End Region

#Region "Create New Instance"
        Public Sub New()
            Name = "New Origin"
        End Sub
        Public Sub New(UniqueName As String, Display_Name As String, Display_Help As String, Display_ShortHelp As String, IconFileName As String)
            ResetDefaults()
            Name = UniqueName
            DisplayName = Display_Name
            DisplayHelp = Display_Help
            DisplayShortHelp = DisplayShortHelp
            Icon = IconFileName
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mName = "New Origin"
            DisplayName = String.Empty
            DisplayNameKey = String.Empty
            DisplayHelp = String.Empty
            DisplayHelpKey = String.Empty
            DisplayShortHelp = String.Empty
            DisplayShortHelpKey = String.Empty
            Icon = String.Empty
            mFilePathReference_Def = String.Empty
            mFilePathReference_XML = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            mDisplayHelp = LocalizeController.RetrieveLocalizedString(mDisplayHelpKey)
            mDisplayShortHelp = LocalizeController.RetrieveLocalizedString(mDisplayShortHelpKey)
        End Sub
#End Region

#Region "Special - Convert to List of Enums"
        Public Shared Sub Convert_ToEnumList(ByRef TheOrigins As COH_Origin())
            Dim Result As New List(Of String)
            Dim NewItem As String = ""
            For X = 0 To TheOrigins.Count - 1
                Dim TempItem As String = "k" & TheOrigins(X).Name & "_Boost"
                NewItem = "<COH_DescriptionEnum(""" & TheOrigins(X).Name & """)>" & TempItem & " = " & X.ToString
                Result.Add(NewItem)
            Next
            Dim TEMP As String = String.Join(ChrW(10), Result)
            Dim TER As Integer = 0
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Origin
            Dim Result As COH_Origin = New COH_Origin
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayHelp = String.Copy(mDisplayHelp)
                .mDisplayShortHelp = String.Copy(mDisplayShortHelp)
                .mIcon = String.Copy(mIcon)
                .mFilePathReference_Def = String.Copy(mFilePathReference_Def)
                .mFilePathReference_XML = String.Copy(mFilePathReference_XML)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export -CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(Name)
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_String(mDisplayHelpKey)
            CurrentWriter.Write_CrypticS_String(mDisplayShortHelpKey)
            CurrentWriter.Write_CrypticS_String(mIcon)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Name = CurrentReader.Read_CrypticS_String
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mDisplayHelpKey = CurrentReader.Read_CrypticS_String
            mDisplayShortHelpKey = CurrentReader.Read_CrypticS_String
            mIcon = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region
    End Class
End Namespace
