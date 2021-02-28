Namespace GameContent.Structures.Story
    Public Class COH_NPC
        Inherits COH_FileStructure

        Const DEFAULT_SHOUT_FREQUENCY = 5
        Const DEFAULT_SHOUT_VARIATION = 10

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("Display")> Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property CurrentFile As String
            Get
                Return mCurrentFile
            End Get
            Set(value As String)
                mCurrentFile = value
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
        Property Model As String
            Get
                Return mModel
            End Get
            Set(value As String)
                mModel = value
            End Set
        End Property
        Property SupergroupContact As String
            Get
                Return mSupergroupContact
            End Get
            Set(value As String)
                mSupergroupContact = value
            End Set
        End Property
        Property AI As String
            Get
                Return mAI
            End Get
            Set(value As String)
                mAI = value
            End Set
        End Property
        Property Contact As String
            Get
                Return mContact
            End Get
            Set(value As String)
                mContact = value
            End Set
        End Property
        Property RegistersSupergroup As Int32
            Get
                Return mRegistersSupergroup
            End Get
            Set(value As Int32)
                mRegistersSupergroup = value
            End Set
        End Property
        Property StoreCount As Int32
            Get
                Return mStoreCount
            End Get
            Set(value As Int32)
                mStoreCount = value
            End Set
        End Property
        Property Store As String()
            Get
                Return mStore
            End Get
            Set(value As String())
                mStore = value
            End Set
        End Property
        Property CanTailor As Int32
            Get
                Return mCanTailor
            End Get
            Set(value As Int32)
                mCanTailor = value
            End Set
        End Property
        Property CanRespec As Int32
            Get
                Return mCanRespec
            End Get
            Set(value As Int32)
                mCanRespec = value
            End Set
        End Property
        Property CanAuction As Int32
            Get
                Return mCanAuction
            End Get
            Set(value As Int32)
                mCanAuction = value
            End Set
        End Property
        Property NoHeadshot As Int32
            Get
                Return mNoHeadshot
            End Get
            Set(value As Int32)
                mNoHeadshot = value
            End Set
        End Property
        Property Dialog As String()
            Get
                Return mDialog
            End Get
            Set(value As String())
                mDialog = value
            End Set
        End Property
        Property ShoutDialog As String()
            Get
                Return mShoutDialog
            End Get
            Set(value As String())
                mShoutDialog = value
            End Set
        End Property
        Property ShoutFrequency As Int32
            Get
                Return mShoutFrequency
            End Get
            Set(value As Int32)
                mShoutFrequency = value
            End Set
        End Property
        Property ShoutVariation As Int32
            Get
                Return mShoutVariation
            End Get
            Set(value As Int32)
                mShoutVariation = value
            End Set
        End Property
        Property AutoRewards As String()
            Get
                Return mAutoRewards
            End Get
            Set(value As String())
                mAutoRewards = value
            End Set
        End Property
        Property TalksToStrangers As Int32
            Get
                Return mTalksToStrangers
            End Get
            Set(value As Int32)
                mTalksToStrangers = value
            End Set
        End Property
        Property VisionPhases As String()
            Get
                Return mVisionPhases
            End Get
            Set(value As String())
                mVisionPhases = value
            End Set
        End Property
        Property ExclusiveVisionPhase As String
            Get
                Return mExclusiveVisionPhase
            End Get
            Set(value As String)
                mExclusiveVisionPhase = value
            End Set
        End Property
        Property WrongAllianceString As String
            Get
                Return mWrongAllianceString
            End Get
            Set(value As String)
                mWrongAllianceString = value
            End Set
        End Property
#End Region

#Region "Properties - Localization"
        Property DisplayNameKey As String
            Get
                Return mDisplayNameKey
            End Get
            Set(value As String)
                mDisplayNameKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mCurrentFile As String
       Private mModel As String
       Private mDisplayName As String
       Private mDisplayNameKey As String
       Private mSupergroupContact As String
       Private mAI As String
       Private mContact As String
       Private mRegistersSupergroup As Int32
       Private mStoreCount As Int32
       Private mStore As String()
       Private mCanTailor As Int32
       Private mCanRespec As Int32
       Private mCanAuction As Int32
       Private mNoHeadshot As Int32
       Private mDialog As String()
       Private mShoutDialog As String()
       Private mShoutFrequency As Int32
       Private mShoutVariation As Int32
       Private mAutoRewards As String()
       Private mTalksToStrangers As Int32
       Private mVisionPhases As String()
       Private mExclusiveVisionPhase As String
       Private mWrongAllianceString As String
        '<EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mScript As COH_None()
#End Region

#Region "Create New Instances"
        Public Sub New()
            ResetDefaults()
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mName = String.Empty
            mCurrentFile = String.Empty
            mModel = String.Empty
            mDisplayName = String.Empty
            mDisplayNameKey = String.Empty
            mSupergroupContact = String.Empty
            mAI = String.Empty
            mContact = String.Empty
            mRegistersSupergroup = 0
            mStoreCount = 0
            mStore = New String() {}
            mCanTailor = 0
            mCanRespec = 0
            mCanAuction = 0
            mNoHeadshot = 0
            mDialog = New String() {}
            mShoutDialog = New String() {}
            mShoutFrequency = DEFAULT_SHOUT_FREQUENCY
            mShoutVariation = DEFAULT_SHOUT_VARIATION
            mAutoRewards = New String() {}
            mTalksToStrangers = 0
            mVisionPhases = New String() {}
            mExclusiveVisionPhase = String.Empty
            mWrongAllianceString = String.Empty
            'mScript = New COH_None()()
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_NPC
            Dim Result As COH_NPC = New COH_NPC
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mCurrentFile = String.Copy(mCurrentFile)
                .mModel = String.Copy(mModel)
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mSupergroupContact = String.Copy(mSupergroupContact)
                .mAI = String.Copy(mAI)
                .mContact = String.Copy(mContact)
                .mRegistersSupergroup = mRegistersSupergroup
                .mStoreCount = mStoreCount
                .mStore = mStore.CloneTheStrings
                .mCanTailor = mCanTailor
                .mCanRespec = mCanRespec
                .mCanAuction = mCanAuction
                .mNoHeadshot = mNoHeadshot
                .mDialog = mDialog.CloneTheStrings
                .mShoutDialog = mShoutDialog.CloneTheStrings
                .mShoutFrequency = mShoutFrequency
                .mShoutVariation = mShoutVariation
                .mAutoRewards = mAutoRewards.CloneTheStrings
                .mTalksToStrangers = mTalksToStrangers
                .mVisionPhases = mVisionPhases.CloneTheStrings
                .mExclusiveVisionPhase = String.Copy(mExclusiveVisionPhase)
                .mWrongAllianceString = String.Copy(mWrongAllianceString)
                '.mScript = New COH_None(mScript.Count - 1) {}
                'For X = 0 To mScript.Count - 1
                ' .mScript(X) = mScript(X).Clone
                ' Next
            End With
            Return Result
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(CurrentFile)
            CurrentWriter.Write_CrypticS_String(Model)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(DisplayNameKey)
            CurrentWriter.Write_CrypticS_String(SupergroupContact)
            CurrentWriter.Write_CrypticS_String(AI)
            CurrentWriter.Write_CrypticS_String(Contact)
            CurrentWriter.Write(RegistersSupergroup)
            CurrentWriter.Write(StoreCount)
            CurrentWriter.Write_CrypticS_StringArray(Store)
            CurrentWriter.Write(CanTailor)
            CurrentWriter.Write(CanRespec)
            CurrentWriter.Write(CanAuction)
            CurrentWriter.Write(NoHeadshot)
            CurrentWriter.Write_CrypticS_StringArray(Dialog)
            CurrentWriter.Write_CrypticS_StringArray(ShoutDialog)
            CurrentWriter.Write(ShoutFrequency)
            CurrentWriter.Write(ShoutVariation)
            CurrentWriter.Write_CrypticS_StringArray(AutoRewards)
            CurrentWriter.Write(TalksToStrangers)
            CurrentWriter.Write_CrypticS_StringArray(VisionPhases)
            CurrentWriter.Write_CrypticS_String(ExclusiveVisionPhase)
            CurrentWriter.Write_CrypticS_String(WrongAllianceString)
            ' If ParseToStream_COH_None()(CurrentWriter, Result.Script) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            CurrentFile = CurrentReader.Read_CrypticS_String
            Model = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            DisplayNameKey = CurrentReader.Read_CrypticS_String
            SupergroupContact = CurrentReader.Read_CrypticS_String
            AI = CurrentReader.Read_CrypticS_String
            Contact = CurrentReader.Read_CrypticS_String
            RegistersSupergroup = CurrentReader.ReadInt32
            StoreCount = CurrentReader.ReadInt32
            Store = CurrentReader.Read_CrypticS_StringArray()
            CanTailor = CurrentReader.ReadInt32
            CanRespec = CurrentReader.ReadInt32
            CanAuction = CurrentReader.ReadInt32
            NoHeadshot = CurrentReader.ReadInt32
            Dialog = CurrentReader.Read_CrypticS_StringArray()
            ShoutDialog = CurrentReader.Read_CrypticS_StringArray()
            ShoutFrequency = CurrentReader.ReadInt32
            ShoutVariation = CurrentReader.ReadInt32
            AutoRewards = CurrentReader.Read_CrypticS_StringArray()
            TalksToStrangers = CurrentReader.ReadInt32
            VisionPhases = CurrentReader.Read_CrypticS_StringArray()
            ExclusiveVisionPhase = CurrentReader.Read_CrypticS_String
            WrongAllianceString = CurrentReader.Read_CrypticS_String
            '//If ParseFromStream_COH_None()(CurrentReader,Script) = False Then Return False

            'CLIENT NOTHING MORE
            Dim FakeCount As Integer = CurrentReader.ReadInt32
            'if Nothing Don't Continue DAH 
            Return True
        End Function
#End Region

    End Class
End Namespace