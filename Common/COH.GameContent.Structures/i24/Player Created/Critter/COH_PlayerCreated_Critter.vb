Imports COH.GameContent.Structures.Costumes

Namespace GameContent.Structures.PlayerCreated.Critter
    Public NotInheritable Class COH_PlayerCreated_Critter
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property ReferenceFile As String
            Get
                Return mReferenceFile
            End Get
            Set(value As String)
                mReferenceFile = value
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
        Property Description As String
            Get
                Return mDescription
            End Get
            Set(value As String)
                mDescription = value
            End Set
        End Property
        Property VillainGroup As String
            Get
                Return mVillainGroup
            End Get
            Set(value As String)
                mVillainGroup = value
            End Set
        End Property
        Property PrimaryPower As String
            Get
                Return mPrimaryPower
            End Get
            Set(value As String)
                mPrimaryPower = value
            End Set
        End Property
        Property Difficulty As COH_Enum_PlayerCreated_CritterDiff
            Get
                Return mDifficulty
            End Get
            Set(value As COH_Enum_PlayerCreated_CritterDiff)
                mDifficulty = value
            End Set
        End Property
        Property SelectedPowers As Int32
            Get
                Return mSelectedPowers
            End Get
            Set(value As Int32)
                mSelectedPowers = value
            End Set
        End Property
        Property SecondaryPower As String
            Get
                Return mSecondaryPower
            End Get
            Set(value As String)
                mSecondaryPower = value
            End Set
        End Property
        Property Difficulty2 As COH_Enum_PlayerCreated_CritterDiff
            Get
                Return mDifficulty2
            End Get
            Set(value As COH_Enum_PlayerCreated_CritterDiff)
                mDifficulty2 = value
            End Set
        End Property
        Property SelectedPowers2 As Int32
            Get
                Return mSelectedPowers2
            End Get
            Set(value As Int32)
                mSelectedPowers2 = value
            End Set
        End Property
        Property TravelPower As String
            Get
                Return mTravelPower
            End Get
            Set(value As String)
                mTravelPower = value
            End Set
        End Property
        Property Rank As String
            Get
                Return mRank
            End Get
            Set(value As String)
                mRank = value
            End Set
        End Property
        Property Designation As COH_Enum_PlayerCreated_CritterRank
            Get
                Return mDesignation
            End Get
            Set(value As COH_Enum_PlayerCreated_CritterRank)
                mDesignation = value
            End Set
        End Property
        Property Ranged As Int32
            Get
                Return mRanged
            End Get
            Set(value As Int32)
                mRanged = value
            End Set
        End Property
        Property Costume As COH_Costume()
            Get
                Return mCostume
            End Get
            Set(value As COH_Costume())
                mCostume = value
            End Set
        End Property
        Property DiffCostume As COH_Costume_Diff()
            Get
                Return mDiffCostume
            End Get
            Set(value As COH_Costume_Diff())
                mDiffCostume = value
            End Set
        End Property
        Property SourceFile As String
            Get
                Return mSourceFile
            End Get
            Set(value As String)
                mSourceFile = value
            End Set
        End Property
        Property TimeStamp As Int32
            Get
                Return mTimeStamp
            End Get
            Set(value As Int32)
                mTimeStamp = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mReferenceFile As String
       Private mName As String
       Private mDescription As String
       Private mVillainGroup As String
       Private mPrimaryPower As String
       Private mDifficulty As COH_Enum_PlayerCreated_CritterDiff
       Private mSelectedPowers As Int32
       Private mSecondaryPower As String
       Private mDifficulty2 As COH_Enum_PlayerCreated_CritterDiff
       Private mSelectedPowers2 As Int32
       Private mTravelPower As String
       Private mRank As String
       Private mDesignation As COH_Enum_PlayerCreated_CritterRank
       Private mRanged As Int32
       Private mCostume As COH_Costume()
       Private mDiffCostume As COH_Costume_Diff()
       Private mSourceFile As String
       Private mTimeStamp As Int32
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
            mReferenceFile = String.Empty
            mName = String.Empty
            mDescription = String.Empty
            mVillainGroup = String.Empty
            mPrimaryPower = String.Empty
            mDifficulty = 0
            mSecondaryPower = String.Empty
            mDifficulty2 = 0
            mTravelPower = String.Empty
            mRank = String.Empty
            mDesignation = 0
            mCostume = New COH_Costume() {}
            mDiffCostume = New COH_Costume_Diff() {}
            mSourceFile = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_PlayerCreated_Critter
            Dim Result As COH_PlayerCreated_Critter = New COH_PlayerCreated_Critter
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mReferenceFile = String.Copy(mReferenceFile)
                .mName = String.Copy(mName)
                .mDescription = String.Copy(mDescription)
                .mVillainGroup = String.Copy(mVillainGroup)
                .mPrimaryPower = String.Copy(mPrimaryPower)
                .mDifficulty = mDifficulty
                .mSelectedPowers = mSelectedPowers
                .mSecondaryPower = String.Copy(mSecondaryPower)
                .mDifficulty2 = mDifficulty2
                .mSelectedPowers2 = mSelectedPowers2
                .mTravelPower = String.Copy(mTravelPower)
                .mRank = String.Copy(mRank)
                .mDesignation = mDesignation
                .mRanged = mRanged
                .mCostume = New COH_Costume(mCostume.Count - 1) {}
                For X = 0 To mCostume.Count - 1
                    .mCostume(X) = mCostume(X).Clone
                Next
                .mDiffCostume = New COH_Costume_Diff(mDiffCostume.Count - 1) {}
                For X = 0 To mDiffCostume.Count - 1
                    .mDiffCostume(X) = mDiffCostume(X).Clone
                Next
                .mSourceFile = String.Copy(mSourceFile)
                .mTimeStamp = mTimeStamp
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mReferenceFile)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mDescription)
            CurrentWriter.Write_CrypticS_String(mVillainGroup)
            CurrentWriter.Write_CrypticS_String(mPrimaryPower)
            CurrentWriter.Write(CInt(mDifficulty))
            CurrentWriter.Write(mSelectedPowers)
            CurrentWriter.Write_CrypticS_String(mSecondaryPower)
            CurrentWriter.Write(CInt(mDifficulty2))
            CurrentWriter.Write(mSelectedPowers2)
            CurrentWriter.Write_CrypticS_String(mTravelPower)
            CurrentWriter.Write_CrypticS_String(mRank)
            CurrentWriter.Write(CInt(mDesignation))
            CurrentWriter.Write(mRanged)
            If CurrentWriter.Write_CrypticS_StructArray(mCostume) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mDiffCostume) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mSourceFile)
            CurrentWriter.Write_CrypticS_TimeStamp(mTimeStamp)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mReferenceFile = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            mDescription = CurrentReader.Read_CrypticS_String
            mVillainGroup = CurrentReader.Read_CrypticS_String
            mPrimaryPower = CurrentReader.Read_CrypticS_String
            mDifficulty = CurrentReader.ReadInt32
            mSelectedPowers = CurrentReader.ReadInt32
            mSecondaryPower = CurrentReader.Read_CrypticS_String
            mDifficulty2 = CurrentReader.ReadInt32
            mSelectedPowers2 = CurrentReader.ReadInt32
            mTravelPower = CurrentReader.Read_CrypticS_String
            mRank = CurrentReader.Read_CrypticS_String
            mDesignation = CurrentReader.ReadInt32
            mRanged = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Costume), mCostume) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Costume_Diff), mDiffCostume) = False Then Return False
            mSourceFile = CurrentReader.Read_CrypticS_String
            mTimeStamp = CurrentReader.Read_CrypticS_TimeStamp
            Return True
        End Function
#End Region

    End Class
End Namespace
