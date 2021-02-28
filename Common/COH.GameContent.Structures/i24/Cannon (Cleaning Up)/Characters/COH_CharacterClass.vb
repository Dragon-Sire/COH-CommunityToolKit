Imports COH.GameContent.Structures.Characters.Attributes
Imports COH.GameContent.Structures.Shared

Namespace GameContent.Structures.Characters
    <COH_TOK("Class")> Public NotInheritable Class COH_CharacterClass
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        <Xml.Serialization.XmlAttribute> <Category("Display")> Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                Dim V As String = value
                SetValue(mName, V)
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
        <Category("Restrictions")> Property AllowedOrigins As String()
            Get
                Return mAllowedOrigins
            End Get
            Set(value As String())
                SetValue(mAllowedOrigins, value)
            End Set
        End Property
        <Category("Restrictions")> Property SpecialRestrictions As String()
            Get
                Return mSpecialRestrictions
            End Get
            Set(value As String())
                SetValue(mSpecialRestrictions, value)
            End Set
        End Property
        <Category("Store")> Property StoreRequires As String
            Get
                Return mStoreRequires
            End Get
            Set(value As String)
                Dim V As String = value
                SetValue(mStoreRequires, V)
            End Set
        End Property
        <Category("Store")> Property LockedTooltip As CrypticS_String
            Get
                Return mLockedTooltip
            End Get
            Set(value As CrypticS_String)
                SetValue(mLockedTooltip, value)
            End Set
        End Property
        <Category("Store")> Property ProductCode As String
            Get
                Return mProductCode
            End Get
            Set(value As String)
                Dim V As String = value
                SetValue(mProductCode, V)
            End Set
        End Property
        <Category("Reductions")> Property ReductionClass As String
            Get
                Return mReductionClass
            End Get
            Set(value As String)
                Dim V As String = value
                SetValue(mReductionClass, V)
            End Set
        End Property
        <Category("Reductions")> Property ReduceAsArchvillain As Boolean
            Get
                Return mReduceAsArchvillain
            End Get
            Set(value As Boolean)
                SetValue(mReduceAsArchvillain, value)
            End Set
        End Property
        Property LevelUpRespecs As Int32()
            Get
                Return mLevelUpRespecs
            End Get
            Set(value As Int32())
                SetValue(mLevelUpRespecs, value)
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
        <Category("Display")> Property Icon As String
            Get
                Return mIcon
            End Get
            Set(value As String)
                Dim V As String = value
                SetValue(mIcon, V)
            End Set
        End Property
        <Category("Power")> Property PrimaryCategory As String
            Get
                Return mPrimaryCategory
            End Get
            Set(value As String)
                Dim V As String = value
                SetValue(mPrimaryCategory, V)
            End Set
        End Property
        <Category("Power")> Property SecondaryCategory As String
            Get
                Return mSecondaryCategory
            End Get
            Set(value As String)
                Dim V As String = value
                SetValue(mSecondaryCategory, V)
            End Set
        End Property
        <Category("Power")> Property PowerPoolCategory As String
            Get
                Return mPowerPoolCategory
            End Get
            Set(value As String)
                Dim V As String = value
                SetValue(mPowerPoolCategory, V)
            End Set
        End Property
        <Category("Power")> Property EpicPoolCategory As String
            Get
                Return mEpicPoolCategory
            End Get
            Set(value As String)
                Dim V As String = value
                SetValue(mEpicPoolCategory, V)
            End Set
        End Property
        <Category("Power - Attributes")> Property AttribMin As COH_CharacterClass_Attributes
            Get
                Return mAttribMin
            End Get
            Set(value As COH_CharacterClass_Attributes)
                SetValue(mAttribMin, value)
            End Set
        End Property
        <Category("Power - Attributes")> Property AttribBase As COH_CharacterClass_Attributes
            Get
                Return mAttribBase
            End Get
            Set(value As COH_CharacterClass_Attributes)
                SetValue(mAttribBase, value)
            End Set
        End Property
        <Category("Power - Attributes")> Property StrengthMin As COH_CharacterClass_Attributes
            Get
                Return mStrengthMin
            End Get
            Set(value As COH_CharacterClass_Attributes)
                SetValue(mStrengthMin, value)
            End Set
        End Property
        <Category("Power - Attributes")> Property ResistanceMin As COH_CharacterClass_Attributes
            Get
                Return mResistanceMin
            End Get
            Set(value As COH_CharacterClass_Attributes)
                SetValue(mResistanceMin, value)
            End Set
        End Property
        <Category("Power - Attributes")> Property AtrribDiminStrIn As COH_CharacterClass_Attributes
            Get
                Return mAtrribDiminStrIn
            End Get
            Set(value As COH_CharacterClass_Attributes)
                SetValue(mAtrribDiminStrIn, value)
            End Set
        End Property
        <Category("Power - Attributes")> Property AtrribDiminStrOut As COH_CharacterClass_Attributes
            Get
                Return mAtrribDiminStrOut
            End Get
            Set(value As COH_CharacterClass_Attributes)
                SetValue(mAtrribDiminStrOut, value)
            End Set
        End Property
        <Category("Power - Attributes")> Property AtrribDiminCurIn As COH_CharacterClass_Attributes
            Get
                Return mAtrribDiminCurIn
            End Get
            Set(value As COH_CharacterClass_Attributes)
                SetValue(mAtrribDiminCurIn, value)
            End Set
        End Property
        <Category("Power - Attributes")> Property AtrribDiminCurOut As COH_CharacterClass_Attributes
            Get
                Return mAtrribDiminCurOut
            End Get
            Set(value As COH_CharacterClass_Attributes)
                SetValue(mAtrribDiminCurOut, value)
            End Set
        End Property
        <Category("Power - Attributes")> Property AtrribDiminResIn As COH_CharacterClass_Attributes
            Get
                Return mAtrribDiminResIn
            End Get
            Set(value As COH_CharacterClass_Attributes)
                SetValue(mAtrribDiminResIn, value)
            End Set
        End Property
        <Category("Power - Attributes")> Property AtrribDiminResOut As COH_CharacterClass_Attributes
            Get
                Return mAtrribDiminResOut
            End Get
            Set(value As COH_CharacterClass_Attributes)
                SetValue(mAtrribDiminResOut, value)
            End Set
        End Property
        <Category("Power - Attributes Tables")> Property AttribMaxTable As COH_CharacterClass_AttributesTable
            Get
                Return mAttribMaxTable
            End Get
            Set(value As COH_CharacterClass_AttributesTable)
                SetValue(mAttribMaxTable, value)
            End Set
        End Property
        <Category("Power - Attributes Tables")> Property AttribMaxMaxTable As COH_CharacterClass_AttributesTable
            Get
                Return mAttribMaxMaxTable
            End Get
            Set(value As COH_CharacterClass_AttributesTable)
                SetValue(mAttribMaxMaxTable, value)
            End Set
        End Property
        <Category("Power - Attributes Tables")> Property StrengthMaxTable As COH_CharacterClass_AttributesTable
            Get
                Return mStrengthMaxTable
            End Get
            Set(value As COH_CharacterClass_AttributesTable)
                SetValue(mStrengthMaxTable, value)
            End Set
        End Property
        <Category("Power - Attributes Tables")> Property ResistanceMaxTable As COH_CharacterClass_AttributesTable
            Get
                Return mResistanceMaxTable
            End Get
            Set(value As COH_CharacterClass_AttributesTable)
                SetValue(mResistanceMaxTable, value)
            End Set
        End Property
        <Category("Power - Mod Tables")> Property ModTable As COH_NamedTable()
            Get
                Return mModTable
            End Get
            Set(value As COH_NamedTable())
                SetValue(mModTable, value)
            End Set
        End Property
        Property ConnectHPAndStatus As Boolean
            Get
                Return mConnectHPAndStatus
            End Get
            Set(value As Boolean)
                SetValue(mConnectHPAndStatus, value)
            End Set
        End Property
        Property DefiantHitPointsAttrib As Int32
            Get
                Return mDefiantHitPointsAttrib
            End Get
            Set(value As Int32)
                SetValue(mDefiantHitPointsAttrib, value)
            End Set
        End Property
        Property DefiantScale As Single
            Get
                Return mDefiantScale
            End Get
            Set(value As Single)
                SetValue(mDefiantScale, value)
            End Set
        End Property
#End Region

#Region "Properties - Offsets (Not Used)"
        <Category("Other (Offsets Ignored)")> Property _FinalAttrMax_ As Int32
            Get
                Return m_FinalAttrMax_
            End Get
            Set(value As Int32)
                SetValue(m_FinalAttrMax_, value)
            End Set
        End Property
        <Category("Other (Offsets Ignored)")> Property _FinalAttrMaxMax_ As Int32
            Get
                Return m_FinalAttrMaxMax_
            End Get
            Set(value As Int32)
                SetValue(m_FinalAttrMaxMax_, value)
            End Set
        End Property
        <Category("Other (Offsets Ignored)")> Property _FinalAttrStrengthMax_ As Int32
            Get
                Return m_FinalAttrStrengthMax_
            End Get
            Set(value As Int32)
                SetValue(m_FinalAttrStrengthMax_, value)
            End Set
        End Property
        <Category("Other (Offsets Ignored)")> Property _FinalAttrResistanceMax_ As Int32
            Get
                Return m_FinalAttrResistanceMax_
            End Get
            Set(value As Int32)
                SetValue(m_FinalAttrResistanceMax_, value)
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mName As String
        Private mAllowedOrigins As String()
        Private mSpecialRestrictions As String()
        Private mStoreRequires As String
        Private mProductCode As String
        Private mReductionClass As String
        Private mReduceAsArchvillain As Boolean
        Private mLevelUpRespecs As Int32()
        Private mDisplayShortHelp As CrypticS_String
        Private mIcon As String
        Private mPrimaryCategory As String
        Private mSecondaryCategory As String
        Private mPowerPoolCategory As String
        Private mEpicPoolCategory As String
        Private mModTable As COH_NamedTable()
        Private mConnectHPAndStatus As Boolean
        Private mDefiantHitPointsAttrib As Int32
        Private mDefiantScale As Single
        Private m_FinalAttrMax_ As Int32
        Private m_FinalAttrMaxMax_ As Int32
        Private m_FinalAttrStrengthMax_ As Int32
        Private m_FinalAttrResistanceMax_ As Int32
        '//LOCALIZED
        Private mDisplayName As CrypticS_String
        Private mDisplayHelp As CrypticS_String
        Private mLockedTooltip As CrypticS_String
        '//HAVE EVENTS
        Private WithEvents mAttribMin As COH_CharacterClass_Attributes
        Private WithEvents mAttribBase As COH_CharacterClass_Attributes
        Private WithEvents mStrengthMin As COH_CharacterClass_Attributes
        Private WithEvents mResistanceMin As COH_CharacterClass_Attributes
        Private WithEvents mAtrribDiminStrIn As COH_CharacterClass_Attributes
        Private WithEvents mAtrribDiminStrOut As COH_CharacterClass_Attributes
        Private WithEvents mAtrribDiminCurIn As COH_CharacterClass_Attributes
        Private WithEvents mAtrribDiminCurOut As COH_CharacterClass_Attributes
        Private WithEvents mAtrribDiminResIn As COH_CharacterClass_Attributes
        Private WithEvents mAtrribDiminResOut As COH_CharacterClass_Attributes
        Private WithEvents mAttribMaxTable As COH_CharacterClass_AttributesTable
        Private WithEvents mAttribMaxMaxTable As COH_CharacterClass_AttributesTable
        Private WithEvents mStrengthMaxTable As COH_CharacterClass_AttributesTable
        Private WithEvents mResistanceMaxTable As COH_CharacterClass_AttributesTable
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
            mLevelUpRespecs = New Int32() {}
            mAttribMin = New COH_CharacterClass_Attributes
            mAttribBase = New COH_CharacterClass_Attributes
            mStrengthMin = New COH_CharacterClass_Attributes
            mResistanceMin = New COH_CharacterClass_Attributes
            mAtrribDiminStrIn = New COH_CharacterClass_Attributes
            mAtrribDiminStrOut = New COH_CharacterClass_Attributes
            mAtrribDiminCurIn = New COH_CharacterClass_Attributes
            mAtrribDiminCurOut = New COH_CharacterClass_Attributes
            mAtrribDiminResIn = New COH_CharacterClass_Attributes
            mAtrribDiminResOut = New COH_CharacterClass_Attributes
            mAttribMaxTable = New COH_CharacterClass_AttributesTable
            mAttribMaxMaxTable = New COH_CharacterClass_AttributesTable
            mStrengthMaxTable = New COH_CharacterClass_AttributesTable
            mResistanceMaxTable = New COH_CharacterClass_AttributesTable
            mModTable = New COH_NamedTable() {}
        End Sub
#End Region

#Region "Modified"
        Protected Overrides Sub OnModified()
        End Sub
        Private Sub ListenEvent(Source As Object, e As PropertyChangedEventArgs) Handles mAtrribDiminCurIn.WasModified, mAtrribDiminCurOut.WasModified, mAtrribDiminResIn.WasModified, mAtrribDiminResOut.WasModified, mAtrribDiminStrIn.WasModified, mAtrribDiminStrOut.WasModified, mAttribBase.WasModified, mAttribMin.WasModified, mResistanceMin.WasModified, mStrengthMin.WasModified, mAttribMaxMaxTable.WasModified, mResistanceMaxTable.WasModified, mStrengthMaxTable.WasModified, mAttribMaxTable.WasModified
            UpdateModified()
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CharacterClass
            Dim Result As COH_CharacterClass = New COH_CharacterClass
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                '.mName = CloneString(mName)
                .mDisplayName = mDisplayName.Clone
                .mDisplayHelp = mDisplayHelp.Clone
                '.mAllowedOrigins = CloneStrings(mAllowedOrigins)
                ' .mSpecialRestrictions = CloneStrings(mSpecialRestrictions)
                ' .mStoreRequires = CloneString(mStoreRequires)
                .mLockedTooltip = mLockedTooltip.Clone
                '.mProductCode = CloneString(mProductCode)
                ' .mReductionClass = CloneString(mReductionClass)
                .mReduceAsArchvillain = mReduceAsArchvillain
                .mLevelUpRespecs = New Int32(mLevelUpRespecs.Count - 1) {} : mLevelUpRespecs.CopyTo(.mLevelUpRespecs, 0)
                .mDisplayShortHelp = mDisplayShortHelp.Clone
                '.mIcon = CloneString(mIcon)
                '.mPrimaryCategory = CloneString(mPrimaryCategory)
                '.mSecondaryCategory = CloneString(mSecondaryCategory)
                '.mPowerPoolCategory = CloneString(mPowerPoolCategory)
                '.mEpicPoolCategory = CloneString(mEpicPoolCategory)
                .mAttribMin = mAttribMin.Clone
                .mAttribBase = mAttribBase.Clone
                .mStrengthMin = mStrengthMin.Clone
                .mResistanceMin = mResistanceMin.Clone
                .mAtrribDiminStrIn = mAtrribDiminStrIn.Clone
                .mAtrribDiminStrOut = mAtrribDiminStrOut.Clone
                .mAtrribDiminCurIn = mAtrribDiminCurIn.Clone
                .mAtrribDiminCurOut = mAtrribDiminCurOut.Clone
                .mAtrribDiminResIn = mAtrribDiminResIn.Clone
                .mAtrribDiminResOut = mAtrribDiminResOut.Clone
                .mAttribMaxTable = mAttribMaxTable.Clone
                .mAttribMaxMaxTable = mAttribMaxMaxTable.Clone
                .mStrengthMaxTable = mStrengthMaxTable.Clone
                .mResistanceMaxTable = mResistanceMaxTable.Clone
                .mModTable = New COH_NamedTable(mModTable.Count - 1) {}
                For X = 0 To mModTable.Count - 1
                    .mModTable(X) = mModTable(X).Clone
                Next
                .mConnectHPAndStatus = mConnectHPAndStatus
                .mDefiantHitPointsAttrib = mDefiantHitPointsAttrib
                .mDefiantScale = mDefiantScale
                .m_FinalAttrMax_ = m_FinalAttrMax_
                .m_FinalAttrMaxMax_ = m_FinalAttrMaxMax_
                .m_FinalAttrStrengthMax_ = m_FinalAttrStrengthMax_
                .m_FinalAttrResistanceMax_ = m_FinalAttrResistanceMax_
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            mDisplayName.Export_To_Stream(CurrentWriter)
            mDisplayHelp.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_StringArray(mAllowedOrigins)
            CurrentWriter.Write_CrypticS_StringArray(mSpecialRestrictions)
            CurrentWriter.Write_CrypticS_String(mStoreRequires)
            mLockedTooltip.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_String(mProductCode)
            CurrentWriter.Write_CrypticS_String(mReductionClass)
            CurrentWriter.Write_CrypticS_Boolean(mReduceAsArchvillain)
            CurrentWriter.Write_CrypticS_IntegerArray(mLevelUpRespecs)
            mDisplayShortHelp.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_String(mIcon)
            CurrentWriter.Write_CrypticS_String(mPrimaryCategory)
            CurrentWriter.Write_CrypticS_String(mSecondaryCategory)
            CurrentWriter.Write_CrypticS_String(mPowerPoolCategory)
            CurrentWriter.Write_CrypticS_String(mEpicPoolCategory)
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mAttribMin) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mAttribBase) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mStrengthMin) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mResistanceMin) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mAtrribDiminStrIn) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mAtrribDiminStrOut) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mAtrribDiminCurIn) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mAtrribDiminCurOut) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mAtrribDiminResIn) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mAtrribDiminResOut) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mAttribMaxTable) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mAttribMaxMaxTable) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mStrengthMaxTable) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray_SingleItem(mResistanceMaxTable) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mModTable) = False Then Return False
            CurrentWriter.Write_CrypticS_Boolean(mConnectHPAndStatus)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_Boolean(mConnectHPAndIntegrity)
            CurrentWriter.Write(mDefiantHitPointsAttrib)
            CurrentWriter.Write(mDefiantScale)
            CurrentWriter.Write(m_FinalAttrMax_)
            CurrentWriter.Write(m_FinalAttrMaxMax_)
            CurrentWriter.Write(m_FinalAttrStrengthMax_)
            CurrentWriter.Write(m_FinalAttrResistanceMax_)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mDisplayName = New CrypticS_String(CurrentReader)
            mDisplayHelp = New CrypticS_String(CurrentReader)
            mAllowedOrigins = CurrentReader.Read_CrypticS_StringArray
            mSpecialRestrictions = CurrentReader.Read_CrypticS_StringArray
            mStoreRequires = CurrentReader.Read_CrypticS_String
            mLockedTooltip = New CrypticS_String(CurrentReader)
            mProductCode = CurrentReader.Read_CrypticS_String
            mReductionClass = CurrentReader.Read_CrypticS_String
            mReduceAsArchvillain = CurrentReader.Read_CrypticS_Boolean
            mLevelUpRespecs = CurrentReader.Read_CrypticS_IntegerArray()
            mDisplayShortHelp = New CrypticS_String(CurrentReader)
            mIcon = CurrentReader.Read_CrypticS_String
            mPrimaryCategory = CurrentReader.Read_CrypticS_String
            mSecondaryCategory = CurrentReader.Read_CrypticS_String
            mPowerPoolCategory = CurrentReader.Read_CrypticS_String
            mEpicPoolCategory = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_Attributes), mAttribMin) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_Attributes), mAttribBase) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_Attributes), mStrengthMin) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_Attributes), mResistanceMin) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_Attributes), mAtrribDiminStrIn) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_Attributes), mAtrribDiminStrOut) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_Attributes), mAtrribDiminCurIn) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_Attributes), mAtrribDiminCurOut) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_Attributes), mAtrribDiminResIn) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_Attributes), mAtrribDiminResOut) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_AttributesTable), mAttribMaxTable) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_AttributesTable), mAttribMaxMaxTable) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_AttributesTable), mStrengthMaxTable) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray_FirstItem(GetType(COH_CharacterClass_AttributesTable), mResistanceMaxTable) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_NamedTable), mModTable) = False Then Return False
            mConnectHPAndStatus = CurrentReader.Read_CrypticS_Boolean
            '!!REDUNDENT!!mConnectHPAndIntegrity = CurrentReader.Read_CrypticS_Boolean
            mDefiantHitPointsAttrib = CurrentReader.ReadInt32
            mDefiantScale = CurrentReader.ReadSingle
            m_FinalAttrMax_ = CurrentReader.ReadInt32
            m_FinalAttrMaxMax_ = CurrentReader.ReadInt32
            m_FinalAttrStrengthMax_ = CurrentReader.ReadInt32
            m_FinalAttrResistanceMax_ = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
