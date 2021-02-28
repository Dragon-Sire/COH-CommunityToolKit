Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_StoryReward_ItemChance
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Chance"
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
        Property AddRemove As COH_Enum_AddRemovePower
            Get
                Return mAddRemove
            End Get
            Set(value As COH_Enum_AddRemovePower)
                mAddRemove = value
            End Set
        End Property
        Property PowerCategory As String
            Get
                Return mPowerCategory
            End Get
            Set(value As String)
                mPowerCategory = value
            End Set
        End Property
        Property PowerSet As String
            Get
                Return mPowerSet
            End Get
            Set(value As String)
                mPowerSet = value
            End Set
        End Property
        Property Power As String
            Get
                Return mPower
            End Get
            Set(value As String)
                mPower = value
            End Set
        End Property
        Property Level As Int32
            Get
                Return mLevel
            End Get
            Set(value As Int32)
                mLevel = value
            End Set
        End Property
        Property FixedLevel As Int32
            Get
                Return mFixedLevel
            End Get
            Set(value As Int32)
                mFixedLevel = value
            End Set
        End Property
        Property Type As Int32
            Get
                Return mType
            End Get
            Set(value As Int32)
                mType = value
            End Set
        End Property
        Property Pad1 As Int32
            Get
                Return mPad1
            End Get
            Set(value As Int32)
                mPad1 = value
            End Set
        End Property
        Property Pad2 As Int32
            Get
                Return mPad2
            End Get
            Set(value As Int32)
                mPad2 = value
            End Set
        End Property
        Property ItemSetAddRemove As COH_Enum_AddRemovePower
            Get
                Return mItemSetAddRemove
            End Get
            Set(value As COH_Enum_AddRemovePower)
                mItemSetAddRemove = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mChance As Int32
       Private mAddRemove As COH_Enum_AddRemovePower
       Private mPowerCategory As String
       Private mPowerSet As String
       Private mPower As String
       Private mLevel As Int32
       Private mFixedLevel As Int32
       Private mType As Int32
       Private mPad1 As Int32
       Private mPad2 As Int32
       Private mItemSetAddRemove As COH_Enum_AddRemovePower
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
            mAddRemove = 0
            mPowerCategory = String.Empty
            mPowerSet = String.Empty
            mPower = String.Empty
            mItemSetAddRemove = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_StoryReward_ItemChance
            Dim Result As COH_StoryReward_ItemChance = New COH_StoryReward_ItemChance
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mChance = mChance
                .mAddRemove = mAddRemove
                .mPowerCategory = String.Copy(mPowerCategory)
                .mPowerSet = String.Copy(mPowerSet)
                .mPower = String.Copy(mPower)
                .mLevel = mLevel
                .mFixedLevel = mFixedLevel
                .mType = mType
                .mPad1 = mPad1
                .mPad2 = mPad2
                .mItemSetAddRemove = mItemSetAddRemove
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mChance)
            CurrentWriter.Write(CInt(mAddRemove))
            CurrentWriter.Write_CrypticS_String(mPowerCategory)
            CurrentWriter.Write_CrypticS_String(mPowerSet)
            CurrentWriter.Write_CrypticS_String(mPower)
            CurrentWriter.Write(mLevel)
            CurrentWriter.Write(mFixedLevel)
            CurrentWriter.Write(mType)
            CurrentWriter.Write(mPad1)
            CurrentWriter.Write(mPad2)
            CurrentWriter.Write(CInt(mItemSetAddRemove))
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mChance = CurrentReader.ReadInt32
            mAddRemove = CurrentReader.ReadInt32
            mPowerCategory = CurrentReader.Read_CrypticS_String
            mPowerSet = CurrentReader.Read_CrypticS_String
            mPower = CurrentReader.Read_CrypticS_String
            mLevel = CurrentReader.ReadInt32
            mFixedLevel = CurrentReader.ReadInt32
            mType = CurrentReader.ReadInt32
            mPad1 = CurrentReader.ReadInt32
            mPad2 = CurrentReader.ReadInt32
            mItemSetAddRemove = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
