Namespace GameContent.Structures.PlayerCreated.UI
    Public NotInheritable Class COH_UI_PlayerCreated_Region_Button
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
        Property SpecialAction As String
            Get
                Return mSpecialAction
            End Get
            Set(value As String)
                mSpecialAction = value
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
        Property PageName As String
            Get
                Return mPageName
            End Get
            Set(value As String)
                mPageName = value
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
        Property isOpen As Int32
            Get
                Return misOpen
            End Get
            Set(value As Int32)
                misOpen = value
            End Set
        End Property
        Property [Optional] As Int32
            Get
                Return mOptional
            End Get
            Set(value As Int32)
                mOptional = value
            End Set
        End Property
        Property FirstUse As Int32
            Get
                Return mFirstUse
            End Get
            Set(value As Int32)
                mFirstUse = value
            End Set
        End Property
        Property wd As Single
            Get
                Return mwd
            End Get
            Set(value As Single)
                mwd = value
            End Set
        End Property
        Property ht As Single
            Get
                Return mht
            End Get
            Set(value As Single)
                mht = value
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
#End Region

#Region "Private Properties"
       Private mName As String
       Private mSpecialAction As String
       Private mElementList As COH_UI_PlayerCreated_ElementList()
       Private mPageName As String
       Private mToolTip As String
       Private misOpen As Int32
       Private mOptional As Int32
       Private mFirstUse As Int32
       Private mwd As Single
       Private mht As Single
        '//LOCALIZED
       Private mNameKey As String
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
            mSpecialAction = String.Empty
            mElementList = New COH_UI_PlayerCreated_ElementList() {}
            mPageName = String.Empty
            mToolTip = String.Empty
            mNameKey = String.Empty
            mTooltipKey = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mName = LocalizeController.RetrieveLocalizedString(mNameKey)
            mToolTip = LocalizeController.RetrieveLocalizedString(mTooltipKey)
            For Each E In ElementList
                E.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_UI_PlayerCreated_Region_Button
            Dim Result As COH_UI_PlayerCreated_Region_Button = New COH_UI_PlayerCreated_Region_Button
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mSpecialAction = String.Copy(mSpecialAction)
                .mElementList = New COH_UI_PlayerCreated_ElementList(mElementList.Count - 1) {}
                For X = 0 To mElementList.Count - 1
                    .mElementList(X) = mElementList(X).Clone
                Next
                .mPageName = String.Copy(mPageName)
                .mToolTip = String.Copy(mToolTip)
                .misOpen = misOpen
                .mOptional = mOptional
                .mFirstUse = mFirstUse
                .mwd = mwd
                .mht = mht
                .mTooltipKey = String.Copy(mTooltipKey)
                .mNameKey = String.Copy(mNameKey)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mMMRegionButton)
            CurrentWriter.Write_CrypticS_String(mNameKey)
            CurrentWriter.Write_CrypticS_String(mSpecialAction)
            If CurrentWriter.Write_CrypticS_StructArray(mElementList) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mPageName)
            CurrentWriter.Write_CrypticS_String(mTooltipKey)
            CurrentWriter.Write(misOpen)
            CurrentWriter.Write(mOptional)
            CurrentWriter.Write(mFirstUse)
            CurrentWriter.Write(mwd)
            CurrentWriter.Write(mht)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mMMRegionButton = 
            mNameKey = CurrentReader.Read_CrypticS_String
            mSpecialAction = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_UI_PlayerCreated_ElementList), mElementList) = False Then Return False
            mPageName = CurrentReader.Read_CrypticS_String
            mTooltipKey = CurrentReader.Read_CrypticS_String
            misOpen = CurrentReader.ReadInt32
            mOptional = CurrentReader.ReadInt32
            mFirstUse = CurrentReader.ReadInt32
            mwd = CurrentReader.ReadSingle
            mht = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
