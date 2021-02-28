Namespace GameContent.Structures.Store
    Public NotInheritable Class COH_Loyalty_RewardTier
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
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property DisplayDescription As String
            Get
                Return mDisplayDescription
            End Get
            Set(value As String)
                mDisplayDescription = value
            End Set
        End Property
        Property NextTier As String
            Get
                Return mNextTier
            End Get
            Set(value As String)
                mNextTier = value
            End Set
        End Property
        Property NodesRequiredForNext As Int32
            Get
                Return mNodesRequiredForNext
            End Get
            Set(value As Int32)
                mNodesRequiredForNext = value
            End Set
        End Property
        Property Node As COH_Loyalty_RewardNode()
            Get
                Return mNode
            End Get
            Set(value As COH_Loyalty_RewardNode())
                mNode = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mDisplayName As String
       Private mDisplayDescription As String
       Private mNextTier As String
       Private mNodesRequiredForNext As Int32
       Private mNode As COH_Loyalty_RewardNode()
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
            mName = String.Empty
            mDisplayName = String.Empty
            mDisplayDescription = String.Empty
            mNextTier = String.Empty
            mNode = New COH_Loyalty_RewardNode() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Loyalty_RewardTier
            Dim Result As COH_Loyalty_RewardTier = New COH_Loyalty_RewardTier
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayDescription = String.Copy(mDisplayDescription)
                .mNextTier = String.Copy(mNextTier)
                .mNodesRequiredForNext = mNodesRequiredForNext
                .mNode = New COH_Loyalty_RewardNode(mNode.Count - 1) {}
                For X = 0 To mNode.Count - 1
                    .mNode(X) = mNode(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_String(mDisplayDescription)
            CurrentWriter.Write_CrypticS_String(mNextTier)
            CurrentWriter.Write(mNodesRequiredForNext)
            If CurrentWriter.Write_CrypticS_StructArray(mNode) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mDisplayName = CurrentReader.Read_CrypticS_String
            mDisplayDescription = CurrentReader.Read_CrypticS_String
            mNextTier = CurrentReader.Read_CrypticS_String
            mNodesRequiredForNext = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Loyalty_RewardNode), mNode) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
