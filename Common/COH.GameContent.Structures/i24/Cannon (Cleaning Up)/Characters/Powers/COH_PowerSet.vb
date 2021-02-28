Namespace GameContent.Structures.Characters.Powers
    Public NotInheritable Class COH_PowerSet
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
        <Category("_Identifier")> Property FullName As String
            Get
                Return mFullName
            End Get
            Set(value As String)
                SetValue(mFullName, value)
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
        Property System As COH_Enum_PowerSystem
            Get
                Return mSystem
            End Get
            Set(value As COH_Enum_PowerSystem)
                SetValue(mSystem, value)
            End Set
        End Property
        Property [Shared] As Boolean
            Get
                Return mShared
            End Get
            Set(value As Boolean)
                SetValue(mShared, value)
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
        <Category("Display")> Property IconName As String
            Get
                Return mIconName
            End Get
            Set(value As String)
                SetValue(mIconName, value)
            End Set
        End Property
        <Category("Costume")> Property CostumeKeys As String()
            Get
                Return mCostumeKeys
            End Get
            Set(value As String())
                SetValue(mCostumeKeys, value)
            End Set
        End Property
        <Category("Costume")> Property CostumeParts As String()
            Get
                Return mCostumeParts
            End Get
            Set(value As String())
                SetValue(mCostumeParts, value)
            End Set
        End Property
        <Category("Requirements")> Property SetAccountRequires As String
            Get
                Return mSetAccountRequires
            End Get
            Set(value As String)
                SetValue(mSetAccountRequires, value)
            End Set
        End Property
        <Category("Requirements")> Property SetAccountTooltip As CrypticS_String
            Get
                Return mSetAccountTooltip
            End Get
            Set(value As CrypticS_String)
                SetValue(mSetAccountTooltip, value)
            End Set
        End Property
        <Category("Requirements")> Property SetAccountProduct As String
            Get
                Return mSetAccountProduct
            End Get
            Set(value As String)
                SetValue(mSetAccountProduct, value)
            End Set
        End Property
        <Category("Requirements")> Property SetBuyRequires As String()
            Get
                Return mSetBuyRequires
            End Get
            Set(value As String())
                SetValue(mSetBuyRequires, value)
            End Set
        End Property
        <Category("Requirements")> Property SetBuyRequiresFailedText As CrypticS_String
            Get
                Return mSetBuyRequiresFailedText
            End Get
            Set(value As CrypticS_String)
                SetValue(mSetBuyRequiresFailedText, value)
            End Set
        End Property
        <Category("Display")> Property ShowInInventory As COH_Enum_ShowPowerSetting
            Get
                Return mShowInInventory
            End Get
            Set(value As COH_Enum_ShowPowerSetting)
                SetValue(mShowInInventory, value)
            End Set
        End Property
        <Category("Display")> <DefaultValue(True)> Property ShowInManage As Boolean
            Get
                Return mShowInManage
            End Get
            Set(value As Boolean)
                SetValue(mShowInManage, value)
            End Set
        End Property
        <Category("Display")> <DefaultValue(True)> Property ShowInInfo As Boolean
            Get
                Return mShowInInfo
            End Get
            Set(value As Boolean)
                SetValue(mShowInInfo, value)
            End Set
        End Property
        Property SpecializeAt As Int32
            Get
                Return mSpecializeAt
            End Get
            Set(value As Int32)
                SetValue(mSpecializeAt, value)
            End Set
        End Property
        Property SpecializeRequires As String()
            Get
                Return mSpecializeRequires
            End Get
            Set(value As String())
                SetValue(mSpecializeRequires, value)
            End Set
        End Property
        <Category("Powers")> Property Powers As String()
            Get
                Return mPowers
            End Get
            Set(value As String())
                SetValue(mPowers, value)
            End Set
        End Property
        <COH_VersionRange(0, 6)> <Category("Powers")> Property IndexAvailable As Int32
            Get
                Return mIndexAvailable
            End Get
            Set(value As Int32)
                SetValue(mIndexAvailable, value)
            End Set
        End Property
        <Category("Powers")> Property Available As Int32()
            Get
                Return mAvailable
            End Get
            Set(value As Int32())
                SetValue(mAvailable, value)
            End Set
        End Property
        <Category("Powers AI")> Property AIMaxLevel As Int32()
            Get
                Return mAIMaxLevel
            End Get
            Set(value As Int32())
                SetValue(mAIMaxLevel, value)
            End Set
        End Property
        <Category("Powers AI")> Property AIMinRankCon As Int32()
            Get
                Return mAIMinRankCon
            End Get
            Set(value As Int32())
                SetValue(mAIMinRankCon, value)
            End Set
        End Property
        <Category("Powers AI")> Property AIMaxRankCon As Int32()
            Get
                Return mAIMaxRankCon
            End Get
            Set(value As Int32())
                SetValue(mAIMaxRankCon, value)
            End Set
        End Property
        <Category("Powers AI")> Property MinDifficulty As Int32()
            Get
                Return mMinDifficulty
            End Get
            Set(value As Int32())
                SetValue(mMinDifficulty, value)
            End Set
        End Property
        <Category("Powers AI")> Property MaxDifficulty As Int32()
            Get
                Return mMaxDifficulty
            End Get
            Set(value As Int32())
                SetValue(mMaxDifficulty, value)
            End Set
        End Property
        <DefaultValue(-1)> Property ForceLevelBought As Int32
            Get
                Return mForceLevelBought
            End Get
            Set(value As Int32)
                SetValue(mForceLevelBought, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mSourceFile As String
       Private mFullName As String
       Private mName As String
       Private mSystem As COH_Enum_PowerSystem
       Private mShared As Boolean
       Private mDisplayName As CrypticS_String
       Private mDisplayHelp As CrypticS_String
       Private mDisplayShortHelp As CrypticS_String
       Private mIconName As String
       Private mCostumeKeys As String()
       Private mCostumeParts As String()
       Private mSetAccountRequires As String
       Private mSetAccountTooltip As CrypticS_String
       Private mSetAccountProduct As String
       Private mSetBuyRequires As String()
       Private mSetBuyRequiresFailedText As CrypticS_String
       Private mShowInInventory As COH_Enum_ShowPowerSetting
       Private mShowInManage As Boolean
       Private mShowInInfo As Boolean
       Private mSpecializeAt As Int32
       Private mSpecializeRequires As String()
       Private mPowers As String()
       Private mIndexAvailable As Int32
       Private mAvailable As Int32()
       Private mAIMaxLevel As Int32()
       Private mAIMinRankCon As Int32()
       Private mAIMaxRankCon As Int32()
       Private mMinDifficulty As Int32()
       Private mMaxDifficulty As Int32()
       Private mForceLevelBought As Int32
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
            mFullName = String.Empty
            mName = String.Empty
            mSystem = COH_Enum_PowerSystem.kPowerSystem_Powers
            mIconName = String.Empty
            mSetAccountRequires = String.Empty
            mSetAccountProduct = String.Empty
            mShowInInventory = COH_Enum_ShowPowerSetting.kShowPowerSetting_Default
            mAvailable = New Int32() {}
            mAIMaxLevel = New Int32() {}
            mAIMinRankCon = New Int32() {}
            mAIMaxRankCon = New Int32() {}
            mMinDifficulty = New Int32() {}
            mMaxDifficulty = New Int32() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_PowerSet
            Dim Result As COH_PowerSet = New COH_PowerSet
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mSourceFile = String.Copy(mSourceFile)
                .mFullName = String.Copy(mFullName)
                .mName = String.Copy(mName)
                .mSystem = mSystem
                .mShared = mShared
                .mDisplayName = mDisplayName.Clone
                .mDisplayHelp = mDisplayHelp.Clone
                .mDisplayShortHelp = mDisplayShortHelp.Clone
                .mIconName = String.Copy(mIconName)
                .mCostumeKeys = CloneStrings(mCostumeKeys)
                .mCostumeParts = CloneStrings(mCostumeParts)
                .mSetAccountRequires = String.Copy(mSetAccountRequires)
                .mSetAccountTooltip = mSetAccountTooltip
                .mSetAccountProduct = String.Copy(mSetAccountProduct)
                .mSetBuyRequires = CloneStrings(mSetBuyRequires)
                .mSetBuyRequiresFailedText = mSetBuyRequiresFailedText
                .mShowInInventory = mShowInInventory
                .mShowInManage = mShowInManage
                .mShowInInfo = mShowInInfo
                .mSpecializeAt = mSpecializeAt
                .mSpecializeRequires = mSpecializeRequires.Clone
                .mPowers = CloneStrings(mPowers)
                .mIndexAvailable = mIndexAvailable
                .mAvailable = New Int32(mAvailable.Count - 1) {} : mAvailable.CopyTo(.mAvailable, 0)
                .mAIMaxLevel = New Int32(mAIMaxLevel.Count - 1) {} : mAIMaxLevel.CopyTo(.mAIMaxLevel, 0)
                .mAIMinRankCon = New Int32(mAIMinRankCon.Count - 1) {} : mAIMinRankCon.CopyTo(.mAIMinRankCon, 0)
                .mAIMaxRankCon = New Int32(mAIMaxRankCon.Count - 1) {} : mAIMaxRankCon.CopyTo(.mAIMaxRankCon, 0)
                .mMinDifficulty = New Int32(mMinDifficulty.Count - 1) {} : mMinDifficulty.CopyTo(.mMinDifficulty, 0)
                .mMaxDifficulty = New Int32(mMaxDifficulty.Count - 1) {} : mMaxDifficulty.CopyTo(.mMaxDifficulty, 0)
                .mForceLevelBought = mForceLevelBought
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - XML"
        Public Overrides Function Default_CrypricSExtention() As String
            Return "POWERSETS"
        End Function
        Public Overrides Function Retrieve_LookupName() As String
            Return mFullName
        End Function
        Public Overrides Function Retrieve_OriginolSourceReference() As String
            Return mSourceFile
        End Function
        Public Overrides Function Determine_DefaultRelativeFilePath(Format As COH_ExportFormat, Optional ShortenPath As Boolean = True) As String
            If Format = COH_ExportFormat.XML Then
                Dim AdjustedPath As String = ""
                Dim PathAddition As String = ""
                If ShortenPath = True Then
                    PathAddition = mFullName.Replace(".", "\")
                Else
                    PathAddition = mFullName
                End If
                If Not mFullName = "" Then
                    AdjustedPath = AdjustedPath & PathAddition & ".xml"
                Else
                    AdjustedPath = mName
                End If
                Dim Folderpath As String = IO.Path.GetDirectoryName(AdjustedPath) & "\"
                Dim FileName As String = IO.Path.GetFileName(AdjustedPath).Replace(".xml", "")
                Dim EndLine As String = If(Folderpath.Length >= 3, Folderpath.Substring(Folderpath.Length - 3, 1), "")
                If EndLine = "_" Then Folderpath = Folderpath.Substring(0, Folderpath.Length - 3) & "\"
                Dim FullPath = Folderpath & FileName & ".xml"
                Return FullPath
            ElseIf Format = COH_ExportFormat.CrypticS_TextFormat Then
                Dim PathAddition As String = ""
                If ShortenPath = True Then
                    PathAddition = mFullName.Replace(".", "\")
                Else
                    PathAddition = mFullName
                End If
                Return PathAddition & "." & Default_CrypricSExtention()
            Else
                Return MyBase.Determine_DefaultRelativeFilePath(Format)
            End If
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mSourceFile)
            CurrentWriter.Write_CrypticS_String(mFullName)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(CInt(mSystem))
            CurrentWriter.Write_CrypticS_Boolean(mShared)
            mDisplayName.Export_To_Stream(CurrentWriter)
            mDisplayHelp.Export_To_Stream(CurrentWriter)
            mDisplayShortHelp.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_String(mIconName)
            CurrentWriter.Write_CrypticS_StringArray(mCostumeKeys)
            CurrentWriter.Write_CrypticS_StringArray(mCostumeParts)
            CurrentWriter.Write_CrypticS_String(mSetAccountRequires)
            mSetAccountTooltip.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_String(mSetAccountProduct)
            CurrentWriter.Write_CrypticS_StringArray(mSetBuyRequires)
            mSetBuyRequiresFailedText.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write(CInt(mShowInInventory))
            CurrentWriter.Write_CrypticS_Boolean(mShowInManage)
            CurrentWriter.Write_CrypticS_Boolean(mShowInInfo)
            CurrentWriter.Write(mSpecializeAt)
            CurrentWriter.Write_CrypticS_StringArray(mSpecializeRequires)
            CurrentWriter.Write_CrypticS_StringArray(mPowers)
            If CurrentWriter.Settings.Option_Version <= 6 Then CurrentWriter.Write(mIndexAvailable)
            CurrentWriter.Write_CrypticS_IntegerArray(mAvailable)
            CurrentWriter.Write_CrypticS_IntegerArray(mAIMaxLevel)
            CurrentWriter.Write_CrypticS_IntegerArray(mAIMinRankCon)
            CurrentWriter.Write_CrypticS_IntegerArray(mAIMaxRankCon)
            CurrentWriter.Write_CrypticS_IntegerArray(mMinDifficulty)
            CurrentWriter.Write_CrypticS_IntegerArray(mMaxDifficulty)
            CurrentWriter.Write(mForceLevelBought)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mSourceFile = CurrentReader.Read_CrypticS_String
            mFullName = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mSystem = CurrentReader.ReadInt32
            mShared = CurrentReader.Read_CrypticS_Boolean
            mDisplayName = New CrypticS_String(CurrentReader)
            mDisplayHelp = New CrypticS_String(CurrentReader)
            mDisplayShortHelp = New CrypticS_String(CurrentReader)
            mIconName = CurrentReader.Read_CrypticS_String
            mCostumeKeys = CurrentReader.Read_CrypticS_StringArray
            mCostumeParts = CurrentReader.Read_CrypticS_StringArray
            mSetAccountRequires = CurrentReader.Read_CrypticS_String
            mSetAccountTooltip = New CrypticS_String(CurrentReader)
            mSetAccountProduct = CurrentReader.Read_CrypticS_String
            mSetBuyRequires = CurrentReader.Read_CrypticS_StringArray
            mSetBuyRequiresFailedText = New CrypticS_String(CurrentReader)
            mShowInInventory = CurrentReader.ReadInt32
            mShowInManage = CurrentReader.Read_CrypticS_Boolean
            mShowInInfo = CurrentReader.Read_CrypticS_Boolean
            mSpecializeAt = CurrentReader.ReadInt32
            mSpecializeRequires = CurrentReader.Read_CrypticS_StringArray
            mPowers = CurrentReader.Read_CrypticS_StringArray
            If CurrentReader.Settings.Option_Version <= 6 Then mIndexAvailable = CurrentReader.ReadInt32
            mAvailable = CurrentReader.Read_CrypticS_IntegerArray()
            mAIMaxLevel = CurrentReader.Read_CrypticS_IntegerArray()
            mAIMinRankCon = CurrentReader.Read_CrypticS_IntegerArray()
            mAIMaxRankCon = CurrentReader.Read_CrypticS_IntegerArray()
            mMinDifficulty = CurrentReader.Read_CrypticS_IntegerArray()
            mMaxDifficulty = CurrentReader.Read_CrypticS_IntegerArray()
            mForceLevelBought = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
