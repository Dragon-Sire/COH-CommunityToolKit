Imports COH.GameContent.Structures.PlayerCreated.Critter

Namespace GameContent.Structures.PlayerCreated.UI
    Public NotInheritable Class COH_UI_PlayerCreated_Element
        Inherits COH_FileStructure

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
        Property Text As String
            Get
                Return mText
            End Get
            Set(value As String)
                mText = value
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
        Property Active As Int32
            Get
                Return mActive
            End Get
            Set(value As Int32)
                mActive = value
            End Set
        End Property
        Property minLevel As Int32
            Get
                Return mminLevel
            End Get
            Set(value As Int32)
                mminLevel = value
            End Set
        End Property
        Property maxLevel As Int32
            Get
                Return mmaxLevel
            End Get
            Set(value As Int32)
                mmaxLevel = value
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
        Property Description As String
            Get
                Return mDescription
            End Get
            Set(value As String)
                mDescription = value
            End Set
        End Property
        Property VGDescription As String
            Get
                Return mVGDescription
            End Get
            Set(value As String)
                mVGDescription = value
            End Set
        End Property
        Property PowerDescription As String
            Get
                Return mPowerDescription
            End Get
            Set(value As String)
                mPowerDescription = value
            End Set
        End Property
        Property [Alias] As String
            Get
                Return mAlias
            End Get
            Set(value As String)
                mAlias = value
            End Set
        End Property
        Property Seq As String
            Get
                Return mSeq
            End Get
            Set(value As String)
                mSeq = value
            End Set
        End Property
        Property npcIndex As Int32
            Get
                Return mnpcIndex
            End Get
            Set(value As Int32)
                mnpcIndex = value
            End Set
        End Property
        Property npcIndexList As Int32()
            Get
                Return mnpcIndexList
            End Get
            Set(value As Int32())
                mnpcIndexList = value
            End Set
        End Property
        Property animationUpdate As Int32
            Get
                Return manimationUpdate
            End Get
            Set(value As Int32)
                manimationUpdate = value
            End Set
        End Property
        Property setnum As Int32
            Get
                Return msetnum
            End Get
            Set(value As Int32)
                msetnum = value
            End Set
        End Property
        Property Colorable As Int32
            Get
                Return mColorable
            End Get
            Set(value As Int32)
                mColorable = value
            End Set
        End Property
        Property mapImageName As String
            Get
                Return mmapImageName
            End Get
            Set(value As String)
                mmapImageName = value
            End Set
        End Property
        Property maplimit As COH_UI_PlayerCreated_MapLimit
            Get
                Return mmaplimit
            End Get
            Set(value As COH_UI_PlayerCreated_MapLimit)
                mmaplimit = value
            End Set
        End Property
        Property Critter As COH_PlayerCreated_Critter()
            Get
                Return mCritter
            End Get
            Set(value As COH_PlayerCreated_Critter())
                mCritter = value
            End Set
        End Property
        Property doppelFlags As Int32
            Get
                Return mdoppelFlags
            End Get
            Set(value As Int32)
                mdoppelFlags = value
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
       Private mDisplayName As String
       Private mText As String
       Private mToolTip As String
       Private mActive As Int32
       Private mminLevel As Int32
       Private mmaxLevel As Int32
       Private mElementList As COH_UI_PlayerCreated_ElementList()
       Private mDescription As String
       Private mVGDescription As String
       Private mPowerDescription As String
       Private mAlias As String
       Private mSeq As String
       Private mnpcIndex As Int32
       Private mnpcIndexList As Int32()
       Private manimationUpdate As Int32
       Private msetnum As Int32
       Private mColorable As Int32
       Private mmapImageName As String
       Private mmaplimit As COH_UI_PlayerCreated_MapLimit
       Private mCritter As COH_PlayerCreated_Critter()
       Private mdoppelFlags As Int32
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
            mDisplayName = String.Empty
            mText = String.Empty
            mToolTip = String.Empty
            mElementList = New COH_UI_PlayerCreated_ElementList() {}
            mDescription = String.Empty
            mVGDescription = String.Empty
            mPowerDescription = String.Empty
            mAlias = String.Empty
            mSeq = String.Empty
            mnpcIndexList = New Int32() {}
            mmapImageName = String.Empty
            mmaplimit = New COH_UI_PlayerCreated_MapLimit()
            mCritter = New COH_PlayerCreated_Critter() {}
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
        Public Function Clone() As COH_UI_PlayerCreated_Element
            Dim Result As COH_UI_PlayerCreated_Element = New COH_UI_PlayerCreated_Element
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayName = String.Copy(mDisplayName)
                .mText = String.Copy(mText)
                .mToolTip = String.Copy(mToolTip)
                .mActive = mActive
                .mminLevel = mminLevel
                .mmaxLevel = mmaxLevel
                .mElementList = New COH_UI_PlayerCreated_ElementList(mElementList.Count - 1) {}
                For X = 0 To mElementList.Count - 1
                    .mElementList(X) = mElementList(X).Clone
                Next
                .mDescription = String.Copy(mDescription)
                .mVGDescription = String.Copy(mVGDescription)
                .mPowerDescription = String.Copy(mPowerDescription)
                .mAlias = String.Copy(mAlias)
                .mSeq = String.Copy(mSeq)
                .mnpcIndex = mnpcIndex
                .mnpcIndexList = New Int32(mnpcIndexList.Count - 1) {} : mnpcIndexList.CopyTo(.mnpcIndexList, 0)
                .manimationUpdate = manimationUpdate
                .msetnum = msetnum
                .mColorable = mColorable
                .mmapImageName = String.Copy(mmapImageName)
                .mmaplimit = mmaplimit
                .mCritter = New COH_PlayerCreated_Critter(mCritter.Count - 1) {}
                For X = 0 To mCritter.Count - 1
                    .mCritter(X) = mCritter(X).Clone
                Next
                .mdoppelFlags = mdoppelFlags
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mTooltipKey = String.Copy(mTooltipKey)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mMMElement)
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_String(mText)
            CurrentWriter.Write_CrypticS_String(mTooltipKey)
            CurrentWriter.Write(mActive)
            CurrentWriter.Write(mminLevel)
            CurrentWriter.Write(mmaxLevel)
            If CurrentWriter.Write_CrypticS_StructArray(mElementList) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mDescription)
            CurrentWriter.Write_CrypticS_String(mVGDescription)
            CurrentWriter.Write_CrypticS_String(mPowerDescription)
            CurrentWriter.Write_CrypticS_String(mAlias)
            CurrentWriter.Write_CrypticS_String(mSeq)
            CurrentWriter.Write(mnpcIndex)
            CurrentWriter.Write_CrypticS_IntegerArray(mnpcIndexList)
            CurrentWriter.Write(manimationUpdate)
            CurrentWriter.Write(msetnum)
            CurrentWriter.Write(mColorable)
            CurrentWriter.Write_CrypticS_String(mmapImageName)
            If CurrentWriter.Write_CrypticS_Struct(mmaplimit) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mCritter) = False Then Return False
            CurrentWriter.Write(mdoppelFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mMMElement = 
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mText = CurrentReader.Read_CrypticS_String
            mTooltipKey = CurrentReader.Read_CrypticS_String
            mActive = CurrentReader.ReadInt32
            mminLevel = CurrentReader.ReadInt32
            mmaxLevel = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_UI_PlayerCreated_ElementList), mElementList) = False Then Return False
            mDescription = CurrentReader.Read_CrypticS_String
            mVGDescription = CurrentReader.Read_CrypticS_String
            mPowerDescription = CurrentReader.Read_CrypticS_String
            mAlias = CurrentReader.Read_CrypticS_String
            mSeq = CurrentReader.Read_CrypticS_String
            mnpcIndex = CurrentReader.ReadInt32
            mnpcIndexList = CurrentReader.Read_CrypticS_IntegerArray()
            manimationUpdate = CurrentReader.ReadInt32
            msetnum = CurrentReader.ReadInt32
            mColorable = CurrentReader.ReadInt32
            mmapImageName = CurrentReader.Read_CrypticS_String

            If CurrentReader.Read_CrypticS_Struct(GetType(COH_UI_PlayerCreated_MapLimit), mmaplimit) = False Then Return False

            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_PlayerCreated_Critter), mCritter) = False Then Return False

            mdoppelFlags = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
