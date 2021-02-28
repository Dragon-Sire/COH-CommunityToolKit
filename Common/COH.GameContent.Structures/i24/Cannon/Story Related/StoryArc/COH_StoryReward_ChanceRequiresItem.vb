Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_StoryReward_ChanceRequiresItem
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "RequiredItem"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Requires As String()
            Get
                Return mRequires
            End Get
            Set(value As String())
                mRequires = value
            End Set
        End Property
        Property Chance As COH_StoryReward_ItemChance
            Get
                Return mChance
            End Get
            Set(value As COH_StoryReward_ItemChance)
                mChance = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mRequires As String()
       Private mChance As COH_StoryReward_ItemChance ' No Default Defined()
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
            mRequires = New String() {}
            mChance = New COH_StoryReward_ItemChance
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_StoryReward_ChanceRequiresItem
            Dim Result As COH_StoryReward_ChanceRequiresItem = New COH_StoryReward_ChanceRequiresItem
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mRequires = mRequires.CloneTheStrings
                .mChance = mChance
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            If CurrentWriter.Write_CrypticS_Struct(mChance) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mPower) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mRemovePower) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mSalvage) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mConcept) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mProficiency) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mDetailRecipe) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mRecipe) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mDetail) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mRemoveToken) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mRewardTable) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mTokenCount) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mIncarnatePoints) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mAccountProduct) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mFixedLevelEnh) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_Struct(mFixedLevelEnhancement) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            If CurrentReader.Read_CrypticS_Struct(GetType(COH_StoryReward_ItemChance), mChance) = False Then Return False

            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mPower) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mRemovePower) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mSalvage) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mConcept) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mProficiency) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mDetailRecipe) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mRecipe) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mDetail) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mRemoveToken) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mRewardTable) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mTokenCount) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mIncarnatePoints) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mAccountProduct) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mFixedLevelEnh) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_From_CrypticS_Struct(GetType('!!REDUNDANTNAME!! - COH_0' No Default Defined), mFixedLevelEnhancement) = False Then Return False
            Return True
End Function
#End Region

    End Class
End Namespace
