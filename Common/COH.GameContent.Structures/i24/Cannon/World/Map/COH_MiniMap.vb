Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_MiniMap_Header
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Map
            End Get
        End Property
#End Region

#Region "Properties"
        Property Map As String
            Get
                Return mMap
            End Get
            Set(value As String)
                mMap = value
            End Set
        End Property
        Property FloorMap As COH_Map_SubMap()
            Get
                Return mFloorMap
            End Get
            Set(value As COH_Map_SubMap())
                mFloorMap = value
            End Set
        End Property
        Property ItemMap As COH_Map_SubMap()
            Get
                Return mItemMap
            End Get
            Set(value As COH_Map_SubMap())
                mItemMap = value
            End Set
        End Property
        Property SpawnMap As COH_Map_SubMap()
            Get
                Return mSpawnMap
            End Get
            Set(value As COH_Map_SubMap())
                mSpawnMap = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mMap As String
       Private mFloorMap As COH_Map_SubMap()
       Private mItemMap As COH_Map_SubMap()
       Private mSpawnMap As COH_Map_SubMap()
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
            mMap = String.Empty
            mFloorMap = New COH_Map_SubMap() {}
            mItemMap = New COH_Map_SubMap() {}
            mSpawnMap = New COH_Map_SubMap() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_MiniMap_Header
            Dim Result As COH_MiniMap_Header = New COH_MiniMap_Header
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mMap = String.Copy(mMap)
                .mFloorMap = New COH_Map_SubMap(mFloorMap.Count - 1) {}
                For X = 0 To mFloorMap.Count - 1
                    .mFloorMap(X) = mFloorMap(X).Clone
                Next
                .mItemMap = New COH_Map_SubMap(mItemMap.Count - 1) {}
                For X = 0 To mItemMap.Count - 1
                    .mItemMap(X) = mItemMap(X).Clone
                Next
                .mSpawnMap = New COH_Map_SubMap(mSpawnMap.Count - 1) {}
                For X = 0 To mSpawnMap.Count - 1
                    .mSpawnMap(X) = mSpawnMap(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mArchitectMapHeader)
            CurrentWriter.Write_CrypticS_String(mMap)
            If CurrentWriter.Write_CrypticS_StructArray(mFloorMap) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mItemMap) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mSpawnMap) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mArchitectMapHeader = 
            mMap = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Map_SubMap), mFloorMap) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Map_SubMap), mItemMap) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Map_SubMap), mSpawnMap) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
