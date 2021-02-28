Imports COH.GameContent.Structures.UI
Imports COH.GameContent.Structures.World

Namespace GameContent.Structures.Bases
    Public NotInheritable Class COH_Base_Room
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Room
            End Get
        End Property
#End Region

#Region "Properties"
        Property UI As COH_UI_NameANDHelp
            Get
                Return mUI_NameANDHelp
            End Get
            Set(value As COH_UI_NameANDHelp)
                mUI_NameANDHelp = value
            End Set
        End Property
        Property Length As Int32
            Get
                Return mLength
            End Get
            Set(value As Int32)
                mLength = value
            End Set
        End Property
        Property Width As Int32
            Get
                Return mWidth
            End Get
            Set(value As Int32)
                mWidth = value
            End Set
        End Property
        Property AllowTeleport As Boolean
            Get
                Return mAllowTeleport
            End Get
            Set(value As Boolean)
                mAllowTeleport = value
            End Set
        End Property
        Property CostPrestige As Int32
            Get
                Return mCostPrestige
            End Get
            Set(value As Int32)
                mCostPrestige = value
            End Set
        End Property
        Property CostInfluence As Int32
            Get
                Return mCostInfluence
            End Get
            Set(value As Int32)
                mCostInfluence = value
            End Set
        End Property
        Property UpkeepPrestige As Int32
            Get
                Return mUpkeepPrestige
            End Get
            Set(value As Int32)
                mUpkeepPrestige = value
            End Set
        End Property
        Property UpkeepInfluence As Int32
            Get
                Return mUpkeepInfluence
            End Get
            Set(value As Int32)
                mUpkeepInfluence = value
            End Set
        End Property
        Property Room As String
            Get
                Return mRoom
            End Get
            Set(value As String)
                mRoom = value
            End Set
        End Property
        Property DetailAllowed As COH_ObjectDetail_CategoryLimit()
            Get
                Return mDetailAllowed
            End Get
            Set(value As COH_ObjectDetail_CategoryLimit())
                mDetailAllowed = value
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
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mUI_NameANDHelp As COH_UI_NameANDHelp
       Private mLength As Int32
       Private mWidth As Int32
       Private mAllowTeleport As Boolean
       Private mCostPrestige As Int32
       Private mCostInfluence As Int32
       Private mUpkeepPrestige As Int32
       Private mUpkeepInfluence As Int32
       Private mRoom As String
       Private mDetailAllowed As COH_ObjectDetail_CategoryLimit()
       Private mRequires As String()
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
            mRoom = String.Empty
            mDetailAllowed = New COH_ObjectDetail_CategoryLimit() {}
            mRequires = New String() {}
            mUI_NameANDHelp = New COH_UI_NameANDHelp
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mUI_NameANDHelp.UpdateLocalizations(LocalizeController)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Base_Room
            Dim Result As COH_Base_Room = New COH_Base_Room
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mLength = mLength
                .mWidth = mWidth
                .mAllowTeleport = mAllowTeleport
                .mCostPrestige = mCostPrestige
                .mCostInfluence = mCostInfluence
                .mUpkeepPrestige = mUpkeepPrestige
                .mUpkeepInfluence = mUpkeepInfluence
                .mRoom = String.Copy(mRoom)
                .mDetailAllowed = New COH_ObjectDetail_CategoryLimit(mDetailAllowed.Count - 1) {}
                For X = 0 To mDetailAllowed.Count - 1
                    .mDetailAllowed(X) = mDetailAllowed(X).Clone
                Next
                .mRequires = mRequires.CloneTheStrings
                .mUI_NameANDHelp = mUI_NameANDHelp.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            mUI_NameANDHelp.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write(mLength)
            CurrentWriter.Write(mWidth)
            CurrentWriter.Write_CrypticS_Boolean(mAllowTeleport)
            CurrentWriter.Write(mCostPrestige)
            CurrentWriter.Write(mCostInfluence)
            CurrentWriter.Write(mUpkeepPrestige)
            CurrentWriter.Write(mUpkeepInfluence)
            CurrentWriter.Write_CrypticS_String(mRoom)
            If CurrentWriter.Write_CrypticS_StructArray(mDetailAllowed) = False Then Return False
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mUI_NameANDHelp = New COH_UI_NameANDHelp(CurrentReader)
            mLength = CurrentReader.ReadInt32
            mWidth = CurrentReader.ReadInt32
            mAllowTeleport = CurrentReader.Read_CrypticS_Boolean
            mCostPrestige = CurrentReader.ReadInt32
            mCostInfluence = CurrentReader.ReadInt32
            mUpkeepPrestige = CurrentReader.ReadInt32
            mUpkeepInfluence = CurrentReader.ReadInt32
            mRoom = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_ObjectDetail_CategoryLimit), mDetailAllowed) = False Then Return False
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
