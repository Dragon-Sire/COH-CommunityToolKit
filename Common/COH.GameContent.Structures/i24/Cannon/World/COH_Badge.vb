Imports COH.GameContent.Structures.Shared.Drawing

Namespace GameContent.Structures.World
    Public NotInheritable Class COH_Badge
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property CurrentFile As String
            Get
                Return mCurrentFile
            End Get
            Set(value As String)
                mCurrentFile = value
            End Set
        End Property
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property Index As Int32
            Get
                Return mIndex
            End Get
            Set(value As Int32)
                mIndex = value
            End Set
        End Property
        Property Collection As COH_Enum_CollectionType
            Get
                Return mCollection
            End Get
            Set(value As COH_Enum_CollectionType)
                mCollection = value
            End Set
        End Property
        Property Category As COH_Enum_BadgeType
            Get
                Return mCategory
            End Get
            Set(value As COH_Enum_BadgeType)
                mCategory = value
            End Set
        End Property
        Property SteamExport As String
            Get
                Return mSteamExport
            End Get
            Set(value As String)
                mSteamExport = value
            End Set
        End Property
        Property DisplayHint As String
            Get
                Return mDisplayHint
            End Get
            Set(value As String)
                mDisplayHint = value
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
        Property DisplayTitle As String
            Get
                Return mDisplayTitle
            End Get
            Set(value As String)
                mDisplayTitle = value
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
        Property DisplayHintVillain As String
            Get
                Return mDisplayHintVillain
            End Get
            Set(value As String)
                mDisplayHintVillain = value
            End Set
        End Property
        Property DisplayTextVillain As String
            Get
                Return mDisplayTextVillain
            End Get
            Set(value As String)
                mDisplayTextVillain = value
            End Set
        End Property
        Property DisplayTitleVillain As String
            Get
                Return mDisplayTitleVillain
            End Get
            Set(value As String)
                mDisplayTitleVillain = value
            End Set
        End Property
        Property VillainIcon As String
            Get
                Return mVillainIcon
            End Get
            Set(value As String)
                mVillainIcon = value
            End Set
        End Property
        Property Reward As String()
            Get
                Return mReward
            End Get
            Set(value As String())
                mReward = value
            End Set
        End Property
        Property Visible As String()
            Get
                Return mVisible
            End Get
            Set(value As String())
                mVisible = value
            End Set
        End Property
        Property Hinted As String()
            Get
                Return mHinted
            End Get
            Set(value As String())
                mHinted = value
            End Set
        End Property
        Property Requires As String()
            Get
                Return mRequires
            End Get
            Set(value As String())
                mRequires = value
            End Set
        End Property
        Property Meter As String()
            Get
                Return mMeter
            End Get
            Set(value As String())
                mMeter = value
            End Set
        End Property
        Property Revoke As String()
            Get
                Return mRevoke
            End Get
            Set(value As String())
                mRevoke = value
            End Set
        End Property
        Property DisplayButton As String
            Get
                Return mDisplayButton
            End Get
            Set(value As String)
                mDisplayButton = value
            End Set
        End Property
        Property ButtonReward As String()
            Get
                Return mButtonReward
            End Get
            Set(value As String())
                mButtonReward = value
            End Set
        End Property
        Property DoNotCount As Boolean
            Get
                Return mDoNotCount
            End Get
            Set(value As Boolean)
                mDoNotCount = value
            End Set
        End Property
        Property DisplayPopup As String
            Get
                Return mDisplayPopup
            End Get
            Set(value As String)
                mDisplayPopup = value
            End Set
        End Property
        Property AwardText As String
            Get
                Return mAwardText
            End Get
            Set(value As String)
                mAwardText = value
            End Set
        End Property
        Property AwardTextColor As COH_Color_RGBA
            Get
                Return mAwardTextColor
            End Get
            Set(value As COH_Color_RGBA)
                mAwardTextColor = value
            End Set
        End Property
        Property Contacts As String()
            Get
                Return mContacts
            End Get
            Set(value As String())
                mContacts = value
            End Set
        End Property
        Property BadgeValues As Int32
            Get
                Return mBadgeValues
            End Get
            Set(value As Int32)
                mBadgeValues = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mCurrentFile As String
       Private mName As String
       Private mIndex As Int32
       Private mCollection As COH_Enum_CollectionType
       Private mCategory As COH_Enum_BadgeType
       Private mSteamExport As String
       Private mDisplayHint As String
       Private mDisplayText As String
       Private mDisplayTitle As String
       Private mIcon As String
       Private mDisplayHintVillain As String
       Private mDisplayTextVillain As String
       Private mDisplayTitleVillain As String
       Private mVillainIcon As String
       Private mReward As String()
       Private mVisible As String()
       Private mHinted As String()
       Private mRequires As String()
       Private mMeter As String()
       Private mRevoke As String()
       Private mDisplayButton As String
       Private mButtonReward As String()
       Private mDoNotCount As Boolean
       Private mDisplayPopup As String
       Private mAwardText As String
       Private mAwardTextColor As COH_Color_RGBA
       Private mContacts As String()
       Private mBadgeValues As Int32
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mCurrentFile = String.Empty
            mName = String.Empty
            mIndex = 0
            mCollection = COH_Enum_CollectionType.kCollectionType_Badge
            mCategory = COH_Enum_BadgeType.kBadgeType_None
            mSteamExport = String.Empty
            mDisplayHint = String.Empty
            mDisplayText = String.Empty
            mDisplayTitle = String.Empty
            mIcon = String.Empty
            mDisplayHintVillain = String.Empty
            mDisplayTextVillain = String.Empty
            mDisplayTitleVillain = String.Empty
            mVillainIcon = String.Empty
            mReward = New String() {}
            mVisible = New String() {}
            mHinted = New String() {}
            mRequires = New String() {}
            mMeter = New String() {}
            mRevoke = New String() {}
            mDisplayButton = String.Empty
            mButtonReward = New String() {}
            mDoNotCount = False
            mDisplayPopup = String.Empty
            mAwardText = String.Empty
            mAwardTextColor = New COH_Color_RGBA
            mContacts = New String() {}
            mBadgeValues = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Badge
            Dim Result As COH_Badge = New COH_Badge
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCurrentFile = String.Copy(mCurrentFile)
                .mName = String.Copy(mName)
                .mIndex = mIndex
                .mCollection = mCollection
                .mCategory = mCategory
                .mSteamExport = String.Copy(mSteamExport)
                .mDisplayHint = String.Copy(mDisplayHint)
                .mDisplayText = String.Copy(mDisplayText)
                .mDisplayTitle = String.Copy(mDisplayTitle)
                .mIcon = String.Copy(mIcon)
                .mDisplayHintVillain = String.Copy(mDisplayHintVillain)
                .mDisplayTextVillain = String.Copy(mDisplayTextVillain)
                .mDisplayTitleVillain = String.Copy(mDisplayTitleVillain)
                .mVillainIcon = String.Copy(mVillainIcon)
                .mReward = mReward.CloneTheStrings
                .mVisible = mVisible.CloneTheStrings
                .mHinted = mHinted.CloneTheStrings
                .mRequires = mRequires.CloneTheStrings
                .mMeter = mMeter.CloneTheStrings
                .mRevoke = mRevoke.CloneTheStrings
                .mDisplayButton = String.Copy(mDisplayButton)
                .mButtonReward = mButtonReward.CloneTheStrings
                .mDoNotCount = mDoNotCount
                .mDisplayPopup = String.Copy(mDisplayPopup)
                .mAwardText = String.Copy(mAwardText)
                .mAwardTextColor = mAwardTextColor
                .mContacts = mContacts.CloneTheStrings
                .mBadgeValues = mBadgeValues
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mCurrentFile)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mIndex)
            CurrentWriter.Write(CInt(mCollection))
            CurrentWriter.Write(CInt(mCategory))
            CurrentWriter.Write_CrypticS_String(mSteamExport)
            CurrentWriter.Write_CrypticS_String(mDisplayHint)
            CurrentWriter.Write_CrypticS_String(mDisplayText)
            CurrentWriter.Write_CrypticS_String(mDisplayTitle)
            CurrentWriter.Write_CrypticS_String(mIcon)
            CurrentWriter.Write_CrypticS_String(mDisplayHintVillain)
            CurrentWriter.Write_CrypticS_String(mDisplayTextVillain)
            CurrentWriter.Write_CrypticS_String(mDisplayTitleVillain)
            CurrentWriter.Write_CrypticS_String(mVillainIcon)
            CurrentWriter.Write_CrypticS_StringArray(mReward)
            CurrentWriter.Write_CrypticS_StringArray(mVisible)
            CurrentWriter.Write_CrypticS_StringArray(mHinted)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mKnown)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write_CrypticS_StringArray(mMeter)
            CurrentWriter.Write_CrypticS_StringArray(mRevoke)
            CurrentWriter.Write_CrypticS_String(mDisplayButton)
            CurrentWriter.Write_CrypticS_StringArray(mButtonReward)
            CurrentWriter.Write_CrypticS_Boolean(mDoNotCount)
            CurrentWriter.Write_CrypticS_String(mDisplayPopup)
            CurrentWriter.Write_CrypticS_String(mAwardText)
            mAwardTextColor.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write_CrypticS_StringArray(mContacts)
            CurrentWriter.Write(mBadgeValues)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mCurrentFile = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mIndex = CurrentReader.ReadInt32
            mCollection = CurrentReader.ReadInt32
            mCategory = CurrentReader.ReadInt32
            mSteamExport = CurrentReader.Read_CrypticS_String
            mDisplayHint = CurrentReader.Read_CrypticS_String
            mDisplayText = CurrentReader.Read_CrypticS_String
            mDisplayTitle = CurrentReader.Read_CrypticS_String
            mIcon = CurrentReader.Read_CrypticS_String
            mDisplayHintVillain = CurrentReader.Read_CrypticS_String
            mDisplayTextVillain = CurrentReader.Read_CrypticS_String
            mDisplayTitleVillain = CurrentReader.Read_CrypticS_String
            mVillainIcon = CurrentReader.Read_CrypticS_String
            mReward = CurrentReader.Read_CrypticS_StringArray()
            mVisible = CurrentReader.Read_CrypticS_StringArray()
            mHinted = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mKnown = CurrentReader.Read_CrypticS_StringArray()
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mMeter = CurrentReader.Read_CrypticS_StringArray()
            mRevoke = CurrentReader.Read_CrypticS_StringArray()
            mDisplayButton = CurrentReader.Read_CrypticS_String
            mButtonReward = CurrentReader.Read_CrypticS_StringArray()
            mDoNotCount = CurrentReader.Read_CrypticS_Boolean
            mDisplayPopup = CurrentReader.Read_CrypticS_String
            mAwardText = CurrentReader.Read_CrypticS_String
            mAwardTextColor = New [Shared].Drawing.COH_Color_RGBA(CurrentReader)
            mContacts = CurrentReader.Read_CrypticS_StringArray()
            mBadgeValues = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
