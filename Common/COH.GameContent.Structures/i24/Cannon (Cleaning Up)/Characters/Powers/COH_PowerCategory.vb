Namespace GameContent.Structures.Characters.Powers
    Public NotInheritable Class COH_PowerCategory
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("_Internal")> Property SourceFile As String
            Get
                Return mSourceFile
            End Get
            Set(value As String)
                SetValue(mSourceFile, value)
            End Set
        End Property
        <Category("_Identifier")> Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                SetValue(mName, value)
            End Set
        End Property
        <Category("Display")> Property DisplayName As CrypticS_String
            Get
                Return mDisplayName
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayName, value)
            End Set
        End Property
        <Category("Display")> Property DisplayHelp As CrypticS_String
            Get
                Return mDisplayHelp
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayHelp, value)
            End Set
        End Property
        <Category("Display")> Property DisplayShortHelp As CrypticS_String
            Get
                Return mDisplayShortHelp
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayShortHelp, value)
            End Set
        End Property
        Property PowerSets As String()
            Get
                Return mPowerSets
            End Get
            Set(value As String())
                SetValue(mPowerSets, value)
            End Set
        End Property
        <COH_VersionRange(0, 6)> Property AutoIndex As Int32
            Get
                Return mAutoIndex
            End Get
            Set(value As Int32)
                SetValue(mAutoIndex, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mSourceFile As String
       Private mName As String
       Private mDisplayName As CrypticS_String
       Private mDisplayHelp As CrypticS_String
       Private mDisplayShortHelp As CrypticS_String
       Private mPowerSets As String()
       Private mAutoIndex As Int32
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
            mSourceFile = String.Empty
            mName = String.Empty
            mPowerSets = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_PowerCategory
            Dim Result As COH_PowerCategory = New COH_PowerCategory
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mSourceFile = String.Copy(mSourceFile)
                .mName = String.Copy(mName)
                .mDisplayName = mDisplayName.Clone
                .mDisplayHelp = mDisplayHelp.Clone
                .mDisplayShortHelp = mDisplayShortHelp.Clone
                .mPowerSets = CloneStrings(mPowerSets)
                .mAutoIndex = mAutoIndex
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
        Public Overrides Function Default_CrypricSExtention() As String
            Return "CATEGORIES"
        End Function
        Public Overrides Function Retrieve_OriginolSourceReference() As String
            Return mSourceFile
        End Function
        Public Overrides Function Determine_DefaultRelativeFilePath(Format As COH_ExportFormat, Optional ShortenPath As Boolean = True) As String
            If Format = COH_ExportFormat.XML Then
                Dim SubFolder As String = Identify_SubFolder()
                Dim FullPath As String = SubFolder & mName & ".xml"
                Return FullPath
            ElseIf Format = COH_ExportFormat.CrypticS_TextFormat Then
                Dim PathAddition As String = ""
                If ShortenPath = True Then
                    PathAddition = mName.Replace(".", "\")
                Else
                    PathAddition = mName
                End If
                Return PathAddition & "." & Default_CrypricSExtention()
            Else
                Return MyBase.Determine_DefaultRelativeFilePath(Format)
            End If
        End Function
        Private Function Identify_SubFolder() As String
            If mSourceFile.Contains("VILLIAN_POWERS") Then Return "Enemies\"
            If mSourceFile.Contains("_PETS") Then Return "_Shared\Pets\"
            If mSourceFile.Contains("_POOL.") Then Return "_Shared\Pool\"
            If mSourceFile.Contains("_INHERENT") Then Return "_Shared\Inherent\"
            If mSourceFile.Contains("_INSPIRATIONS") Then Return "_Shared\Items\"
            If mSourceFile.Contains("PLAYER_") Then Return "Player\"
            If mSourceFile.Contains("BASE_POWERS") Then Return "_Shared\Base_Powers\"
            If mSourceFile.Contains("EPIC_POWERS") Then Return "_Shared\Epic_Powers\"
            If mSourceFile.Contains("TEMPORARY_POWERS") Then Return "_Shared\Temporary_Powers\"
            If mSourceFile.Contains("INCARNATE") Then Return "_Shared\Incarnate\"
            If mSourceFile.Contains("BOOSTS") Then Return "_Shared\Boosts\"
            If mSourceFile.Contains("BONUS") Then Return "_Shared\Bonus\"
            If mSourceFile.Contains("OBJECTS") Then Return "_Shared\Objects\"
            If mSourceFile.Contains("TUTORIAL") Then Return "Other\"
            If mSourceFile.Contains("V_") Then Return "Enemies\"
            If mSourceFile.Contains("VILLAIN_") Then Return "Enemies\"
            Return ""
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mSourceFile)
            CurrentWriter.Write_CrypticS_String(mName)
            mDisplayName.Export_To_Stream(CurrentWriter)
            mDisplayHelp.Export_To_Stream(CurrentWriter)
            mDisplayShortHelp.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_StringArray(mPowerSets)
            If CurrentWriter.Settings.Option_Version <= 6 Then CurrentWriter.Write(mAutoIndex)
            '!!IGNORED!! mAvailable)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mSourceFile = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mDisplayName = New CrypticS_String(CurrentReader)
            mDisplayHelp = New CrypticS_String(CurrentReader)
            mDisplayShortHelp = New CrypticS_String(CurrentReader)
            mPowerSets = CurrentReader.Read_CrypticS_StringArray
            If CurrentReader.Settings.Option_Version <= 6 Then mAutoIndex = CurrentReader.ReadInt32
            '!!IGNORED!! mAvailable = 
            Return True
        End Function
#End Region

    End Class
End Namespace
