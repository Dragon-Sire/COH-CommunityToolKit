Namespace GameContent.Structures.Store
    Public NotInheritable Class COH_Loyalty_RewardTree
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Reward Tree"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Tier As COH_Loyalty_RewardTier()
            Get
                Return mTier
            End Get
            Set(value As COH_Loyalty_RewardTier())
                mTier = value
            End Set
        End Property
        Property Level As COH_Loyalty_RewardLevel()
            Get
                Return mLevel
            End Get
            Set(value As COH_Loyalty_RewardLevel())
                mLevel = value
            End Set
        End Property
        Property NodeNames As COH_Loyalty_RewardNodeName()
            Get
                Return mNodeNames
            End Get
            Set(value As COH_Loyalty_RewardNodeName())
                mNodeNames = value
            End Set
        End Property
        Property DefaultInfluenceCap As Int64
            Get
                Return mDefaultInfluenceCap
            End Get
            Set(value As Int64)
                mDefaultInfluenceCap = value
            End Set
        End Property
        Property VIPInfluenceCap As Int64
            Get
                Return mVIPInfluenceCap
            End Get
            Set(value As Int64)
                mVIPInfluenceCap = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTier As COH_Loyalty_RewardTier()
       Private mLevel As COH_Loyalty_RewardLevel()
       Private mNodeNames As COH_Loyalty_RewardNodeName()
       Private mDefaultInfluenceCap As Int64
       Private mVIPInfluenceCap As Int64
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
            mTier = New COH_Loyalty_RewardTier() {}
            mLevel = New COH_Loyalty_RewardLevel() {}
            mNodeNames = New COH_Loyalty_RewardNodeName() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Loyalty_RewardTree
            Dim Result As COH_Loyalty_RewardTree = New COH_Loyalty_RewardTree
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTier = New COH_Loyalty_RewardTier(mTier.Count - 1) {}
                For X = 0 To mTier.Count - 1
                    .mTier(X) = mTier(X).Clone
                Next
                .mLevel = New COH_Loyalty_RewardLevel(mLevel.Count - 1) {}
                For X = 0 To mLevel.Count - 1
                    .mLevel(X) = mLevel(X).Clone
                Next
                .mNodeNames = New COH_Loyalty_RewardNodeName(mNodeNames.Count - 1) {}
                For X = 0 To mNodeNames.Count - 1
                    .mNodeNames(X) = mNodeNames(X).Clone
                Next
                .mDefaultInfluenceCap = mDefaultInfluenceCap
                .mVIPInfluenceCap = mVIPInfluenceCap
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Write_CrypticS_StructArray(mTier) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mLevel) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mNodeNames) = False Then Return False
            CurrentWriter.Write(mDefaultInfluenceCap)
            CurrentWriter.Write(mVIPInfluenceCap)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Loyalty_RewardTier), mTier) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Loyalty_RewardLevel), mLevel) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Loyalty_RewardNodeName), mNodeNames) = False Then Return False
            mDefaultInfluenceCap = CurrentReader.ReadInt64
            mVIPInfluenceCap = CurrentReader.ReadInt64
            Return True
        End Function
#End Region

    End Class
End Namespace
