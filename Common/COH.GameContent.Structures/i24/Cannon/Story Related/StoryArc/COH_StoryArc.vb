Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_StoryArc
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property FileName As String
            Get
                Return mFileName
            End Get
            Set(value As String)
                mFileName = value
            End Set
        End Property
        Property Deprecated As Boolean
            Get
                Return mDeprecated
            End Get
            Set(value As Boolean)
                mDeprecated = value
            End Set
        End Property
        Property Flags As COH_Enum_StoryArcFlag
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_StoryArcFlag)
                mFlags = value
            End Set
        End Property
        Property Episodes As COH_StoryEpisode()
            Get
                Return mEpisode
            End Get
            Set(value As COH_StoryEpisode())
                mEpisode = value
            End Set
        End Property
        Property ClueDef As COH_StoryClue()
            Get
                Return mClueDef
            End Get
            Set(value As COH_StoryClue())
                mClueDef = value
            End Set
        End Property
        Property MinPlayerLevel As Int32
            Get
                Return mMinPlayerLevel
            End Get
            Set(value As Int32)
                mMinPlayerLevel = value
            End Set
        End Property
        Property MaxPlayerLevel As Int32
            Get
                Return mMaxPlayerLevel
            End Get
            Set(value As Int32)
                mMaxPlayerLevel = value
            End Set
        End Property
        Property CompleteRequires As String()
            Get
                Return mCompleteRequires
            End Get
            Set(value As String())
                mCompleteRequires = value
            End Set
        End Property
        Property FlashbackRequires As String()
            Get
                Return mFlashbackRequires
            End Get
            Set(value As String())
                mFlashbackRequires = value
            End Set
        End Property
        Property FlashbackRequiresFailedText As String
            Get
                Return mFlashbackRequiresFailedText
            End Get
            Set(value As String)
                mFlashbackRequiresFailedText = value
            End Set
        End Property
        Property FlashbackTeamRequires As String()
            Get
                Return mFlashbackTeamRequires
            End Get
            Set(value As String())
                mFlashbackTeamRequires = value
            End Set
        End Property
        Property FlashbackTeamRequiresFailedText As String
            Get
                Return mFlashbackTeamRequiresFailedText
            End Get
            Set(value As String)
                mFlashbackTeamRequiresFailedText = value
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
        Property RequiresFailedText As String
            Get
                Return mRequiresFailedText
            End Get
            Set(value As String)
                mRequiresFailedText = value
            End Set
        End Property
        Property TeamRequires As String()
            Get
                Return mTeamRequires
            End Get
            Set(value As String())
                mTeamRequires = value
            End Set
        End Property
        Property TeamRequiresFailedText As String
            Get
                Return mTeamRequiresFailedText
            End Get
            Set(value As String)
                mTeamRequiresFailedText = value
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
        Property Alliance As COH_Enum_StoryArcAlliance
            Get
                Return mAlliance
            End Get
            Set(value As COH_Enum_StoryArcAlliance)
                mAlliance = value
            End Set
        End Property
        Property FlashbackDescription As String
            Get
                Return mFlashbackDescription
            End Get
            Set(value As String)
                mFlashbackDescription = value
            End Set
        End Property
        Property FlashbackCostMultiplier As Single
            Get
                Return mFlashbackCostMultiplier
            End Get
            Set(value As Single)
                mFlashbackCostMultiplier = value
            End Set
        End Property
        Property FlashbackLeft As COH_StoryReward()
            Get
                Return mFlashbackLeft
            End Get
            Set(value As COH_StoryReward())
                mFlashbackLeft = value
            End Set
        End Property
        Property architectAboutContact As String
            Get
                Return marchitectAboutContact
            End Get
            Set(value As String)
                marchitectAboutContact = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mFileName As String
       Private mDeprecated As Boolean
       Private mFlags As COH_Enum_StoryArcFlag
       Private mEpisode As COH_StoryEpisode()
       Private mClueDef As COH_StoryClue()
       Private mMinPlayerLevel As Int32
       Private mMaxPlayerLevel As Int32
       Private mCompleteRequires As String()
       Private mFlashbackRequires As String()
       Private mFlashbackRequiresFailedText As String
       Private mFlashbackTeamRequires As String()
       Private mFlashbackTeamRequiresFailedText As String
       Private mRequires As String()
       Private mRequiresFailedText As String
       Private mTeamRequires As String()
       Private mTeamRequiresFailedText As String
       Private mName As String
       Private mAlliance As COH_Enum_StoryArcAlliance
       Private mFlashbackDescription As String
       Private mFlashbackCostMultiplier As Single
       Private mFlashbackLeft As COH_StoryReward()
       Private marchitectAboutContact As String
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
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
            mFileName = String.Empty
            mEpisode = New COH_StoryEpisode() {}
            mClueDef = New COH_StoryClue() {}
            mCompleteRequires = New String() {}
            mFlashbackRequires = New String() {}
            mFlashbackRequiresFailedText = String.Empty
            mFlashbackTeamRequires = New String() {}
            mFlashbackTeamRequiresFailedText = String.Empty
            mRequires = New String() {}
            mRequiresFailedText = String.Empty
            mTeamRequires = New String() {}
            mTeamRequiresFailedText = String.Empty
            mName = String.Empty
            mFlashbackDescription = String.Empty
            mFlashbackLeft = New COH_StoryReward() {}
            marchitectAboutContact = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_StoryArc
            Dim Result As COH_StoryArc = New COH_StoryArc
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mFileName = String.Copy(mFileName)
                .mDeprecated = mDeprecated
                .mFlags = mFlags
                .mEpisode = New COH_StoryEpisode(mEpisode.Count - 1) {}
                For X = 0 To mEpisode.Count - 1
                    .mEpisode(X) = mEpisode(X).Clone
                Next
                .mClueDef = New COH_StoryClue(mClueDef.Count - 1) {}
                For X = 0 To mClueDef.Count - 1
                    .mClueDef(X) = mClueDef(X).Clone
                Next
                .mMinPlayerLevel = mMinPlayerLevel
                .mMaxPlayerLevel = mMaxPlayerLevel
                .mCompleteRequires = mCompleteRequires.CloneTheStrings
                .mFlashbackRequires = mFlashbackRequires.CloneTheStrings
                .mFlashbackRequiresFailedText = String.Copy(mFlashbackRequiresFailedText)
                .mFlashbackTeamRequires = mFlashbackTeamRequires.CloneTheStrings
                .mFlashbackTeamRequiresFailedText = String.Copy(mFlashbackTeamRequiresFailedText)
                .mRequires = mRequires.CloneTheStrings
                .mRequiresFailedText = String.Copy(mRequiresFailedText)
                .mTeamRequires = mTeamRequires.CloneTheStrings
                .mTeamRequiresFailedText = String.Copy(mTeamRequiresFailedText)
                .mName = String.Copy(mName)
                .mAlliance = mAlliance
                .mFlashbackDescription = String.Copy(mFlashbackDescription)
                .mFlashbackCostMultiplier = mFlashbackCostMultiplier
                .mFlashbackLeft = New COH_StoryReward(mFlashbackLeft.Count - 1) {}
                For X = 0 To mFlashbackLeft.Count - 1
                    .mFlashbackLeft(X) = mFlashbackLeft(X).Clone
                Next
                .marchitectAboutContact = String.Copy(marchitectAboutContact)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mFileName)
            CurrentWriter.Write_CrypticS_Boolean(mDeprecated)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            If CurrentWriter.Write_CrypticS_StructArray(mEpisode) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mClueDef) = False Then Return False
            CurrentWriter.Write(mMinPlayerLevel)
            CurrentWriter.Write(mMaxPlayerLevel)
            CurrentWriter.Write_CrypticS_StringArray(mCompleteRequires)
            CurrentWriter.Write_CrypticS_StringArray(mFlashbackRequires)
            CurrentWriter.Write_CrypticS_String(mFlashbackRequiresFailedText)
            CurrentWriter.Write_CrypticS_StringArray(mFlashbackTeamRequires)
            CurrentWriter.Write_CrypticS_String(mFlashbackTeamRequiresFailedText)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write_CrypticS_String(mRequiresFailedText)
            CurrentWriter.Write_CrypticS_StringArray(mTeamRequires)
            CurrentWriter.Write_CrypticS_String(mTeamRequiresFailedText)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mAlliance)
            CurrentWriter.Write_CrypticS_String(mFlashbackDescription)
            CurrentWriter.Write(mFlashbackCostMultiplier)
            If CurrentWriter.Write_CrypticS_StructArray(mFlashbackLeft,) = False Then Return False
            CurrentWriter.Write_CrypticS_String(marchitectAboutContact)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mFileName = CurrentReader.Read_CrypticS_String
            mDeprecated = CurrentReader.Read_CrypticS_Boolean
            mFlags = CurrentReader.Read_CrypticS_Flags
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryEpisode), mEpisode) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryClue), mClueDef) = False Then Return False
            mMinPlayerLevel = CurrentReader.ReadInt32
            mMaxPlayerLevel = CurrentReader.ReadInt32
            mCompleteRequires = CurrentReader.Read_CrypticS_StringArray()
            mFlashbackRequires = CurrentReader.Read_CrypticS_StringArray()
            mFlashbackRequiresFailedText = CurrentReader.Read_CrypticS_String
            mFlashbackTeamRequires = CurrentReader.Read_CrypticS_StringArray()
            mFlashbackTeamRequiresFailedText = CurrentReader.Read_CrypticS_String
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mRequiresFailedText = CurrentReader.Read_CrypticS_String
            mTeamRequires = CurrentReader.Read_CrypticS_StringArray()
            mTeamRequiresFailedText = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mAlliance = CurrentReader.ReadInt32
            mFlashbackDescription = CurrentReader.Read_CrypticS_String
            mFlashbackCostMultiplier = CurrentReader.ReadSingle
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mFlashbackLeft) = False Then Return False
            marchitectAboutContact = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
