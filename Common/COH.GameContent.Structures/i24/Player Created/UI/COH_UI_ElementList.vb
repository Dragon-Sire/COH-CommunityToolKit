Imports COH.GameContent.Structures.PlayerCreated.Critter

Namespace GameContent.Structures.PlayerCreated.UI
    Public NotInheritable Class COH_UI_PlayerCreated_ElementList
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
        Property Template As String
            Get
                Return mTemplate
            End Get
            Set(value As String)
                mTemplate = value
            End Set
        End Property
        Property SpecialAction As COH_Enum_PlayerCreated_SpecialActions
            Get
                Return mSpecialAction
            End Get
            Set(value As COH_Enum_PlayerCreated_SpecialActions)
                mSpecialAction = value
            End Set
        End Property
        Property Element As COH_UI_PlayerCreated_Element()
            Get
                Return mElements
            End Get
            Set(value As COH_UI_PlayerCreated_Element())
                mElements = value
            End Set
        End Property
        Property current_element As Int32
            Get
                Return mcurrent_element
            End Get
            Set(value As Int32)
                mcurrent_element = value
            End Set
        End Property
        Property updated As Int32
            Get
                Return mupdated
            End Get
            Set(value As Int32)
                mupdated = value
            End Set
        End Property
        Property ToolTip As String
            Get
                Return mToolTip
            End Get
            Set(value As String)
                mToolTip = value
            End Set
        End Property
        Property [Default] As String
            Get
                Return mDefault
            End Get
            Set(value As String)
                mDefault = value
            End Set
        End Property
        Property Field As String
            Get
                Return mField
            End Get
            Set(value As String)
                mField = value
            End Set
        End Property
        Property AmbushLoad As String
            Get
                Return mAmbushLoad
            End Get
            Set(value As String)
                mAmbushLoad = value
            End Set
        End Property
        Property DestinationLoad As String
            Get
                Return mDestinationLoad
            End Get
            Set(value As String)
                mDestinationLoad = value
            End Set
        End Property
        Property ReplaceNoneWith As String
            Get
                Return mReplaceNoneWith
            End Get
            Set(value As String)
                mReplaceNoneWith = value
            End Set
        End Property
        Property CheckBoxList As Int32
            Get
                Return mCheckBoxList
            End Get
            Set(value As Int32)
                mCheckBoxList = value
            End Set
        End Property
        Property Button As Int32
            Get
                Return mButton
            End Get
            Set(value As Int32)
                mButton = value
            End Set
        End Property
        Property CopyrightCheck As Int32
            Get
                Return mCopyrightCheck
            End Get
            Set(value As Int32)
                mCopyrightCheck = value
            End Set
        End Property
        Property TabbedSelection As Int32
            Get
                Return mTabbedSelection
            End Get
            Set(value As Int32)
                mTabbedSelection = value
            End Set
        End Property
        Property KeywordSelector As Int32
            Get
                Return mKeywordSelector
            End Get
            Set(value As Int32)
                mKeywordSelector = value
            End Set
        End Property
        Property Required As Int32
            Get
                Return mRequired
            End Get
            Set(value As Int32)
                mRequired = value
            End Set
        End Property
        Property FieldRestrictionAlreadyDefined As Int32
            Get
                Return mFieldRestrictionAlreadyDefined
            End Get
            Set(value As Int32)
                mFieldRestrictionAlreadyDefined = value
            End Set
        End Property
        Property DontUnlockCheck As Int32
            Get
                Return mDontUnlockCheck
            End Get
            Set(value As Int32)
                mDontUnlockCheck = value
            End Set
        End Property
        Property AllowHTML As Int32
            Get
                Return mAllowHTML
            End Get
            Set(value As Int32)
                mAllowHTML = value
            End Set
        End Property
        Property CharLimit As Int32
            Get
                Return mCharLimit
            End Get
            Set(value As Int32)
                mCharLimit = value
            End Set
        End Property
        Property ValMin As Int32
            Get
                Return mValMin
            End Get
            Set(value As Int32)
                mValMin = value
            End Set
        End Property
        Property ValMax As Int32
            Get
                Return mValMax
            End Get
            Set(value As Int32)
                mValMax = value
            End Set
        End Property
        Property MultiList As COH_UI_PlayerCreated_ElementList()
            Get
                Return mMultiList
            End Get
            Set(value As COH_UI_PlayerCreated_ElementList())
                mMultiList = value
            End Set
        End Property
        Property current_list As Int32
            Get
                Return mcurrent_list
            End Get
            Set(value As Int32)
                mcurrent_list = value
            End Set
        End Property
        Property previous_list As Int32
            Get
                Return mprevious_list
            End Get
            Set(value As Int32)
                mprevious_list = value
            End Set
        End Property
        Property SelectedCritter As COH_PlayerCreated_Critter()
            Get
                Return mSelectedCritter
            End Get
            Set(value As COH_PlayerCreated_Critter())
                mSelectedCritter = value
            End Set
        End Property
        Property reasonForInvalid As Int32
            Get
                Return mreasonForInvalid
            End Get
            Set(value As Int32)
                mreasonForInvalid = value
            End Set
        End Property
        Property doneCritterValidation As Int32
            Get
                Return mdoneCritterValidation
            End Get
            Set(value As Int32)
                mdoneCritterValidation = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
        Property NameKey As String
            Get
                Return mNameKey
            End Get
            Set(value As String)
                mNameKey = value
            End Set
        End Property
        Property TooltipKey As String
            Get
                Return mTooltipKey
            End Get
            Set(value As String)
                mTooltipKey = value
            End Set
        End Property
        Property DefaultKey As String
            Get
                Return mDefaultKey
            End Get
            Set(value As String)
                mDefaultKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mTemplate As String
       Private mSpecialAction As COH_Enum_PlayerCreated_SpecialActions
       Private mElements As COH_UI_PlayerCreated_Element()
       Private mcurrent_element As Int32
       Private mupdated As Int32
       Private mToolTip As String
       Private mDefault As String
       Private mField As String
       Private mAmbushLoad As String
       Private mDestinationLoad As String
       Private mReplaceNoneWith As String
       Private mCheckBoxList As Int32
       Private mButton As Int32
       Private mCopyrightCheck As Int32
       Private mTabbedSelection As Int32
       Private mKeywordSelector As Int32
       Private mRequired As Int32
       Private mFieldRestrictionAlreadyDefined As Int32
       Private mDontUnlockCheck As Int32
       Private mAllowHTML As Int32
       Private mCharLimit As Int32
       Private mValMin As Int32
       Private mValMax As Int32
       Private mMultiList As COH_UI_PlayerCreated_ElementList()
       Private mcurrent_list As Int32
       Private mprevious_list As Int32
       Private mSelectedCritter As COH_PlayerCreated_Critter()
       Private mreasonForInvalid As Int32
       Private mdoneCritterValidation As Int32
        '//LOCALIZED
       Private mNameKey As String
       Private mTooltipKey As String
       Private mDefaultKey As String
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
            mName = String.Empty
            mTemplate = String.Empty
            mSpecialAction = 0
            mElements = New COH_UI_PlayerCreated_Element() {}
            mToolTip = String.Empty
            mDefault = String.Empty
            mField = String.Empty
            mAmbushLoad = String.Empty
            mDestinationLoad = String.Empty
            mReplaceNoneWith = String.Empty
            mMultiList = New COH_UI_PlayerCreated_ElementList() {}
            mSelectedCritter = New COH_PlayerCreated_Critter() {}
            mNameKey = String.Empty
            mTooltipKey = String.Empty
            mDefaultKey = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mName = LocalizeController.RetrieveLocalizedString(mNameKey)
            mToolTip = LocalizeController.RetrieveLocalizedString(mTooltipKey)
            mDefault = LocalizeController.RetrieveLocalizedString(mDefaultkey)
            For Each E In Element
                E.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_UI_PlayerCreated_ElementList
            Dim Result As COH_UI_PlayerCreated_ElementList = New COH_UI_PlayerCreated_ElementList
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mTemplate = String.Copy(mTemplate)
                .mSpecialAction = mSpecialAction
                .mElements = New COH_UI_PlayerCreated_Element(mElements.Count - 1) {}
                For X = 0 To mElements.Count - 1
                    .mElements(X) = mElements(X).Clone
                Next
                .mcurrent_element = mcurrent_element
                .mupdated = mupdated
                .mToolTip = String.Copy(mToolTip)
                .mDefault = String.Copy(mDefault)
                .mField = String.Copy(mField)
                .mAmbushLoad = String.Copy(mAmbushLoad)
                .mDestinationLoad = String.Copy(mDestinationLoad)
                .mReplaceNoneWith = String.Copy(mReplaceNoneWith)
                .mCheckBoxList = mCheckBoxList
                .mButton = mButton
                .mCopyrightCheck = mCopyrightCheck
                .mTabbedSelection = mTabbedSelection
                .mKeywordSelector = mKeywordSelector
                .mRequired = mRequired
                .mFieldRestrictionAlreadyDefined = mFieldRestrictionAlreadyDefined
                .mDontUnlockCheck = mDontUnlockCheck
                .mAllowHTML = mAllowHTML
                .mCharLimit = mCharLimit
                .mValMin = mValMin
                .mValMax = mValMax
                .mMultiList = New COH_UI_PlayerCreated_ElementList(mMultiList.Count - 1) {}
                For X = 0 To mMultiList.Count - 1
                    .mMultiList(X) = mMultiList(X).Clone
                Next
                .mcurrent_list = mcurrent_list
                .mprevious_list = mprevious_list
                .mSelectedCritter = New COH_PlayerCreated_Critter(mSelectedCritter.Count - 1) {}
                For X = 0 To mSelectedCritter.Count - 1
                    .mSelectedCritter(X) = mSelectedCritter(X).Clone
                Next
                .mreasonForInvalid = mreasonForInvalid
                .mdoneCritterValidation = mdoneCritterValidation
                .mNameKey = String.Copy(mNameKey)
                .mTooltipKey = String.Copy(mTooltipKey)
                .mDefaultKey = String.Copy(mDefaultKey)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mMMElementList)
            CurrentWriter.Write_CrypticS_String(mNameKey)
            CurrentWriter.Write_CrypticS_String(mTemplate)
            CurrentWriter.Write(CInt(mSpecialAction))
            If CurrentWriter.Write_CrypticS_StructArray(mElements) = False Then Return False
            CurrentWriter.Write(mcurrent_element)
            CurrentWriter.Write(mupdated)
            CurrentWriter.Write_CrypticS_String(mTooltipKey)
            CurrentWriter.Write_CrypticS_String(mDefaultKey)
            CurrentWriter.Write_CrypticS_String(mField)
            CurrentWriter.Write_CrypticS_String(mAmbushLoad)
            CurrentWriter.Write_CrypticS_String(mDestinationLoad)
            CurrentWriter.Write_CrypticS_String(mReplaceNoneWith)
            CurrentWriter.Write(mCheckBoxList)
            CurrentWriter.Write(mButton)
            CurrentWriter.Write(mCopyrightCheck)
            CurrentWriter.Write(mTabbedSelection)
            CurrentWriter.Write(mKeywordSelector)
            CurrentWriter.Write(mRequired)
            CurrentWriter.Write(mFieldRestrictionAlreadyDefined)
            CurrentWriter.Write(mDontUnlockCheck)
            CurrentWriter.Write(mAllowHTML)
            CurrentWriter.Write(mCharLimit)
            CurrentWriter.Write(mValMin)
            CurrentWriter.Write(mValMax)
            If CurrentWriter.Write_CrypticS_StructArray(mMultiList) = False Then Return False
            CurrentWriter.Write(mcurrent_list)
            CurrentWriter.Write(mprevious_list)
            If CurrentWriter.Write_CrypticS_StructArray(mSelectedCritter) = False Then Return False
            CurrentWriter.Write(mreasonForInvalid)
            CurrentWriter.Write(mdoneCritterValidation)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mMMElementList = 
            mNameKey = CurrentReader.Read_CrypticS_String
            mTemplate = CurrentReader.Read_CrypticS_String
            mSpecialAction = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_UI_PlayerCreated_Element), mElements) = False Then Return False
            mcurrent_element = CurrentReader.ReadInt32
            mupdated = CurrentReader.ReadInt32
            mTooltipKey = CurrentReader.Read_CrypticS_String
            mDefaultKey = CurrentReader.Read_CrypticS_String
            mField = CurrentReader.Read_CrypticS_String
            mAmbushLoad = CurrentReader.Read_CrypticS_String
            mDestinationLoad = CurrentReader.Read_CrypticS_String
            mReplaceNoneWith = CurrentReader.Read_CrypticS_String
            mCheckBoxList = CurrentReader.ReadInt32
            mButton = CurrentReader.ReadInt32
            mCopyrightCheck = CurrentReader.ReadInt32
            mTabbedSelection = CurrentReader.ReadInt32
            mKeywordSelector = CurrentReader.ReadInt32
            mRequired = CurrentReader.ReadInt32
            mFieldRestrictionAlreadyDefined = CurrentReader.ReadInt32
            mDontUnlockCheck = CurrentReader.ReadInt32
            mAllowHTML = CurrentReader.ReadInt32
            mCharLimit = CurrentReader.ReadInt32
            mValMin = CurrentReader.ReadInt32
            mValMax = CurrentReader.ReadInt32

            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_UI_PlayerCreated_ElementList), mMultiList) = False Then Return False
            mcurrent_list = CurrentReader.ReadInt32
            mprevious_list = CurrentReader.ReadInt32

            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_PlayerCreated_Critter), mSelectedCritter) = False Then Return False '//OPTIONAL
            mreasonForInvalid = CurrentReader.ReadInt32
            mdoneCritterValidation = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
