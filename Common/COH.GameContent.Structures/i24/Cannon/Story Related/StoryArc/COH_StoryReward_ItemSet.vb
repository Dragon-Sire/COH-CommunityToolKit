Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_StoryReward_ItemSet
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
        Property Filename As String
            Get
                Return mFilename
            End Get
            Set(value As String)
                mFilename = value
            End Set
        End Property
        Property Verified As Int32
            Get
                Return mVerified
            End Get
            Set(value As Int32)
                mVerified = value
            End Set
        End Property
        Property Chance As COH_StoryReward_ItemChance()
            Get
                Return mChance
            End Get
            Set(value As COH_StoryReward_ItemChance())
                mChance = value
            End Set
        End Property
        Property ChanceRequires As COH_StoryReward_ChanceRequiresItem()
            Get
                Return mChanceRequires
            End Get
            Set(value As COH_StoryReward_ChanceRequiresItem())
                mChanceRequires = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mFilename As String
       Private mVerified As Int32
       Private mChance As COH_StoryReward_ItemChance()
       Private mChanceRequires As COH_StoryReward_ChanceRequiresItem()
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
            mFilename = String.Empty
            mChance = New COH_StoryReward_ItemChance() {}
            mChanceRequires = New COH_StoryReward_ChanceRequiresItem() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_StoryReward_ItemSet
            Dim Result As COH_StoryReward_ItemSet = New COH_StoryReward_ItemSet
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFilename = String.Copy(mFilename)
                .mVerified = mVerified
                .mChance = New COH_StoryReward_ItemChance(mChance.Count - 1) {}
                For X = 0 To mChance.Count - 1
                    .mChance(X) = mChance(X).Clone
                Next
                .mChanceRequires = New COH_StoryReward_ChanceRequiresItem(mChanceRequires.Count - 1) {}
                For X = 0 To mChanceRequires.Count - 1
                    .mChanceRequires(X) = mChanceRequires(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mFilename)
            CurrentWriter.Write(mVerified)
            If CurrentWriter.Write_CrypticS_StructArray(mChance) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mPower) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mRemovePower) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mSalvage) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mConcept) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mProficiency) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mDetailRecipe) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mRecipe) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mDetail) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mRemoveToken) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mRewardTable) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mTokenCount) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mIncarnatePoints) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mAccountProduct) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mFixedLevelEnh) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mFixedLevelEnhancement) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mChanceRequires) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mFilename = CurrentReader.Read_CrypticS_String
            mVerified = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward_ItemChance), mChance) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mPower) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mRemovePower) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mSalvage) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mConcept) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mProficiency) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mDetailRecipe) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mRecipe) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mDetail) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mRemoveToken) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mRewardTable) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mTokenCount) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mIncarnatePoints) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mAccountProduct) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mFixedLevelEnh) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mFixedLevelEnhancement) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward_ChanceRequiresItem), mChanceRequires) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
