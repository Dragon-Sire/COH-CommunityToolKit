Namespace GameContent.Structures.PlayerCreated.UI
    Public NotInheritable Class COH_UI_PlayerCreated_Region
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
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property UserName As String
            Get
                Return mUserName
            End Get
            Set(value As String)
                mUserName = value
            End Set
        End Property
        Property ActualDisplay As String
            Get
                Return mActualDisplay
            End Get
            Set(value As String)
                mActualDisplay = value
            End Set
        End Property
        Property ElementList As COH_UI_PlayerCreated_ElementList()
            Get
                Return mElementList
            End Get
            Set(value As COH_UI_PlayerCreated_ElementList())
                mElementList = value
            End Set
        End Property
        Property Button As COH_UI_PlayerCreated_Region_Button()
            Get
                Return mButton
            End Get
            Set(value As COH_UI_PlayerCreated_Region_Button())
                mButton = value
            End Set
        End Property
        Property Struct As String
            Get
                Return mStruct
            End Get
            Set(value As String)
                mStruct = value
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
        Property Icon As String
            Get
                Return mIcon
            End Get
            Set(value As String)
                mIcon = value
            End Set
        End Property
        Property IconGlow As String
            Get
                Return mIconGlow
            End Get
            Set(value As String)
                mIconGlow = value
            End Set
        End Property
        Property outer_ht As Single
            Get
                Return mouter_ht
            End Get
            Set(value As Single)
                mouter_ht = value
            End Set
        End Property
        Property inner_ht As Single
            Get
                Return minner_ht
            End Get
            Set(value As Single)
                minner_ht = value
            End Set
        End Property
        Property inner_wd As Single
            Get
                Return minner_wd
            End Get
            Set(value As Single)
                minner_wd = value
            End Set
        End Property
        Property isOpen As Int32
            Get
                Return misOpen
            End Get
            Set(value As Int32)
                misOpen = value
            End Set
        End Property
        Property Undeleteable As Int32
            Get
                Return mUndeleteable
            End Get
            Set(value As Int32)
                mUndeleteable = value
            End Set
        End Property
        Property detailType As COH_Enum_PlayerCreated_DetailType
            Get
                Return mdetailType
            End Get
            Set(value As COH_Enum_PlayerCreated_DetailType)
                mdetailType = value
            End Set
        End Property
        Property limit As Int32
            Get
                Return mlimit
            End Get
            Set(value As Int32)
                mlimit = value
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
        Property TooltipKey As String
            Get
                Return mTooltipKey
            End Get
            Set(value As String)
                mTooltipKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mDisplayName As String
       Private mUserName As String
       Private mActualDisplay As String
       Private mElementList As COH_UI_PlayerCreated_ElementList()
       Private mButton As COH_UI_PlayerCreated_Region_Button()
       Private mStruct As String
       Private mToolTip As String
       Private mIcon As String
       Private mIconGlow As String
       Private mouter_ht As Single
       Private minner_ht As Single
       Private minner_wd As Single
       Private misOpen As Int32
       Private mUndeleteable As Int32
       Private mdetailType As COH_Enum_PlayerCreated_DetailType
       Private mlimit As Int32
        '//Localized
       Private mDisplayNameKey As String
       Private mTooltipKey As String
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
            mDisplayName = String.Empty
            mUserName = String.Empty
            mActualDisplay = String.Empty
            mElementList = New COH_UI_PlayerCreated_ElementList() {}
            mButton = New COH_UI_PlayerCreated_Region_Button() {}
            mStruct = String.Empty
            mToolTip = String.Empty
            mIcon = String.Empty
            mIconGlow = String.Empty
            mdetailType = 0
            mDisplayNameKey = String.Empty
            mTooltipKey = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            mToolTip = LocalizeController.RetrieveLocalizedString(mTooltipKey)
            For Each E In ElementList
                E.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_UI_PlayerCreated_Region
            Dim Result As COH_UI_PlayerCreated_Region = New COH_UI_PlayerCreated_Region
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mUserName = String.Copy(mUserName)
                .mActualDisplay = String.Copy(mActualDisplay)
                .mElementList = New COH_UI_PlayerCreated_ElementList(mElementList.Count - 1) {}
                For X = 0 To mElementList.Count - 1
                    .mElementList(X) = mElementList(X).Clone
                Next
                .mButton = New COH_UI_PlayerCreated_Region_Button(mButton.Count - 1) {}
                For X = 0 To mButton.Count - 1
                    .mButton(X) = mButton(X).Clone
                Next
                .mStruct = String.Copy(mStruct)
                .mToolTip = String.Copy(mToolTip)
                .mIcon = String.Copy(mIcon)
                .mIconGlow = String.Copy(mIconGlow)
                .mouter_ht = mouter_ht
                .minner_ht = minner_ht
                .minner_wd = minner_wd
                .misOpen = misOpen
                .mUndeleteable = mUndeleteable
                .mdetailType = mdetailType
                .mlimit = mlimit
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mTooltipKey = String.Copy(mTooltipKey)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mMMRegion)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_String(mUserName)
            CurrentWriter.Write_CrypticS_String(mActualDisplay)
            If CurrentWriter.Write_CrypticS_StructArray(mElementList) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mButton) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mStruct)
            CurrentWriter.Write_CrypticS_String(mTooltipKey)
            CurrentWriter.Write_CrypticS_String(mIcon)
            CurrentWriter.Write_CrypticS_String(mIconGlow)
            CurrentWriter.Write(mouter_ht)
            CurrentWriter.Write(minner_ht)
            CurrentWriter.Write(minner_wd)
            CurrentWriter.Write(misOpen)
            CurrentWriter.Write(mUndeleteable)
            CurrentWriter.Write(CInt(mdetailType))
            CurrentWriter.Write(mlimit)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mMMRegion = 
            mName = CurrentReader.Read_CrypticS_String
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mUserName = CurrentReader.Read_CrypticS_String
            mActualDisplay = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_UI_PlayerCreated_ElementList), mElementList) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_UI_PlayerCreated_Region_Button), mButton) = False Then Return False
            mStruct = CurrentReader.Read_CrypticS_String
            mTooltipKey = CurrentReader.Read_CrypticS_String
            mIcon = CurrentReader.Read_CrypticS_String
            mIconGlow = CurrentReader.Read_CrypticS_String
            mouter_ht = CurrentReader.ReadSingle
            minner_ht = CurrentReader.ReadSingle
            minner_wd = CurrentReader.ReadSingle
            misOpen = CurrentReader.ReadInt32
            mUndeleteable = CurrentReader.ReadInt32
            mdetailType = CurrentReader.ReadInt32
            mlimit = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
