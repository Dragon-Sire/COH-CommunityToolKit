Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_StoryReward_DropGroup
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Reward Drop Group"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Chance As Int32
            Get
                Return mChance
            End Get
            Set(value As Int32)
                mChance = value
            End Set
        End Property
        Property ItemSetName As String()
            Get
                Return mItemSetName
            End Get
            Set(value As String())
                mItemSetName = value
            End Set
        End Property
        Property ItemSet As COH_StoryReward_ItemSet()
            Get
                Return mItemSet
            End Get
            Set(value As COH_StoryReward_ItemSet())
                mItemSet = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mChance As Int32
       Private mItemSetName As String()
       Private mItemSet As COH_StoryReward_ItemSet()
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
            mItemSetName = New String() {}
            mItemSet = New COH_StoryReward_ItemSet() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_StoryReward_DropGroup
            Dim Result As COH_StoryReward_DropGroup = New COH_StoryReward_DropGroup
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mChance = mChance
                .mItemSetName = mItemSetName.CloneTheStrings
                .mItemSet = New COH_StoryReward_ItemSet(mItemSet.Count - 1) {}
                For X = 0 To mItemSet.Count - 1
                    .mItemSet(X) = mItemSet(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mChance)
            CurrentWriter.Write_CrypticS_StringArray(mItemSetName)
            If CurrentWriter.Write_CrypticS_StructArray(mItemSet) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mChance = CurrentReader.ReadInt32
            mItemSetName = CurrentReader.Read_CrypticS_StringArray()
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward_ItemSet), mItemSet) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
