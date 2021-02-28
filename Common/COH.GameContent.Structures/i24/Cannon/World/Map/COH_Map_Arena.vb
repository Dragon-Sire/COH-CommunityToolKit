Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_Map_Arena
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return DisplayName
            End Get
        End Property
#End Region

#Region "Properties"
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property MapName As String
            Get
                Return mMapName
            End Get
            Set(value As String)
                mMapName = value
            End Set
        End Property
        Property MinPlayers As Int32
            Get
                Return mMinPlayers
            End Get
            Set(value As Int32)
                mMinPlayers = value
            End Set
        End Property
        Property MaxPlayers As Int32
            Get
                Return mMaxPlayers
            End Get
            Set(value As Int32)
                mMaxPlayers = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
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
       Private mDisplayName As String
       Private mDisplayNameKey As String
       Private mMapName As String
       Private mMinPlayers As Int32
       Private mMaxPlayers As Int32
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
            mDisplayName = String.Empty
            mDisplayNameKey = String.Empty
            mMapName = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Map_Arena
            Dim Result As COH_Map_Arena = New COH_Map_Arena
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mMapName = String.Copy(mMapName)
                .mMinPlayers = mMinPlayers
                .mMaxPlayers = mMaxPlayers
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_String(mMapName)
            CurrentWriter.Write(mMinPlayers)
            CurrentWriter.Write(mMaxPlayers)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mMapName = CurrentReader.Read_CrypticS_String
            mMinPlayers = CurrentReader.ReadInt32
            mMaxPlayers = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
