Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_DialogPage
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
        Property MissionName As String
            Get
                Return mMissionName
            End Get
            Set(value As String)
                mMissionName = value
            End Set
        End Property
        Property ContactFilename As String
            Get
                Return mContactFilename
            End Get
            Set(value As String)
                mContactFilename = value
            End Set
        End Property
        Property TeleportDest As String
            Get
                Return mTeleportDest
            End Get
            Set(value As String)
                mTeleportDest = value
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
        Property SayOutLoudText As String
            Get
                Return mSayOutLoudText
            End Get
            Set(value As String)
                mSayOutLoudText = value
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
        Property Objectives As String()
            Get
                Return mObjectives
            End Get
            Set(value As String())
                mObjectives = value
            End Set
        End Property
        Property Rewards As String()
            Get
                Return mRewards
            End Get
            Set(value As String())
                mRewards = value
            End Set
        End Property
        Property AddClues As String()
            Get
                Return mAddClues
            End Get
            Set(value As String())
                mAddClues = value
            End Set
        End Property
        Property RemoveClues As String()
            Get
                Return mRemoveClues
            End Get
            Set(value As String())
                mRemoveClues = value
            End Set
        End Property
        Property AddTokens As String()
            Get
                Return mAddTokens
            End Get
            Set(value As String())
                mAddTokens = value
            End Set
        End Property
        Property RemoveTokens As String()
            Get
                Return mRemoveTokens
            End Get
            Set(value As String())
                mRemoveTokens = value
            End Set
        End Property
        Property AddTokensToAll As String()
            Get
                Return mAddTokensToAll
            End Get
            Set(value As String())
                mAddTokensToAll = value
            End Set
        End Property
        Property RemoveTokensFromAll As String()
            Get
                Return mRemoveTokensFromAll
            End Get
            Set(value As String())
                mRemoveTokensFromAll = value
            End Set
        End Property
        Property AbandonContacts As String()
            Get
                Return mAbandonContacts
            End Get
            Set(value As String())
                mAbandonContacts = value
            End Set
        End Property
        Property Answer As COH_DialogAnswer()
            Get
                Return mAnswer
            End Get
            Set(value As COH_DialogAnswer())
                mAnswer = value
            End Set
        End Property
        Property Flags As COH_Enum_DialogPage_Flags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_DialogPage_Flags)
                mFlags = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mMissionName As String
       Private mContactFilename As String
       Private mTeleportDest As String
       Private mText As String
       Private mSayOutLoudText As String
       Private mRequires As String()
       Private mObjectives As String()
       Private mRewards As String()
       Private mAddClues As String()
       Private mRemoveClues As String()
       Private mAddTokens As String()
       Private mRemoveTokens As String()
       Private mAddTokensToAll As String()
       Private mRemoveTokensFromAll As String()
       Private mAbandonContacts As String()
       Private mAnswer As COH_DialogAnswer()
       Private mFlags As COH_Enum_DialogPage_Flags
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
            mName = String.Empty
            mMissionName = String.Empty
            mContactFilename = String.Empty
            mTeleportDest = String.Empty
            mText = String.Empty
            mSayOutLoudText = String.Empty
            mRequires = New String() {}
            mObjectives = New String() {}
            mRewards = New String() {}
            mAddClues = New String() {}
            mRemoveClues = New String() {}
            mAddTokens = New String() {}
            mRemoveTokens = New String() {}
            mAddTokensToAll = New String() {}
            mRemoveTokensFromAll = New String() {}
            mAbandonContacts = New String() {}
            mAnswer = New COH_DialogAnswer() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_DialogPage
            Dim Result As COH_DialogPage = New COH_DialogPage
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mMissionName = String.Copy(mMissionName)
                .mContactFilename = String.Copy(mContactFilename)
                .mTeleportDest = String.Copy(mTeleportDest)
                .mText = String.Copy(mText)
                .mSayOutLoudText = String.Copy(mSayOutLoudText)
                .mRequires = mRequires.CloneTheStrings
                .mObjectives = mObjectives.CloneTheStrings
                .mRewards = mRewards.CloneTheStrings
                .mAddClues = mAddClues.CloneTheStrings
                .mRemoveClues = mRemoveClues.CloneTheStrings
                .mAddTokens = mAddTokens.CloneTheStrings
                .mRemoveTokens = mRemoveTokens.CloneTheStrings
                .mAddTokensToAll = mAddTokensToAll.CloneTheStrings
                .mRemoveTokensFromAll = mRemoveTokensFromAll.CloneTheStrings
                .mAbandonContacts = mAbandonContacts.CloneTheStrings
                .mAnswer = New COH_DialogAnswer(mAnswer.Count - 1) {}
                For X = 0 To mAnswer.Count - 1
                    .mAnswer(X) = mAnswer(X).Clone
                Next
                .mFlags = mFlags
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mMissionName)
            CurrentWriter.Write_CrypticS_String(mContactFilename)
            CurrentWriter.Write_CrypticS_String(mTeleportDest)
            CurrentWriter.Write_CrypticS_String(mText)
            CurrentWriter.Write_CrypticS_String(mSayOutLoudText)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write_CrypticS_StringArray(mObjectives)
            CurrentWriter.Write_CrypticS_StringArray(mRewards)
            CurrentWriter.Write_CrypticS_StringArray(mAddClues)
            CurrentWriter.Write_CrypticS_StringArray(mRemoveClues)
            CurrentWriter.Write_CrypticS_StringArray(mAddTokens)
            CurrentWriter.Write_CrypticS_StringArray(mRemoveTokens)
            CurrentWriter.Write_CrypticS_StringArray(mAddTokensToAll)
            CurrentWriter.Write_CrypticS_StringArray(mRemoveTokensFromAll)
            CurrentWriter.Write_CrypticS_StringArray(mAbandonContacts)
            If CurrentWriter.Write_CrypticS_StructArray(mAnswer) = False Then Return False
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mMissionName = CurrentReader.Read_CrypticS_String
            mContactFilename = CurrentReader.Read_CrypticS_String
            mTeleportDest = CurrentReader.Read_CrypticS_String
            mText = CurrentReader.Read_CrypticS_String
            mSayOutLoudText = CurrentReader.Read_CrypticS_String
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mObjectives = CurrentReader.Read_CrypticS_StringArray()
            mRewards = CurrentReader.Read_CrypticS_StringArray()
            mAddClues = CurrentReader.Read_CrypticS_StringArray()
            mRemoveClues = CurrentReader.Read_CrypticS_StringArray()
            mAddTokens = CurrentReader.Read_CrypticS_StringArray()
            mRemoveTokens = CurrentReader.Read_CrypticS_StringArray()
            mAddTokensToAll = CurrentReader.Read_CrypticS_StringArray()
            mRemoveTokensFromAll = CurrentReader.Read_CrypticS_StringArray()
            mAbandonContacts = CurrentReader.Read_CrypticS_StringArray()
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_DialogAnswer), mAnswer) = False Then Return False
            mFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace
