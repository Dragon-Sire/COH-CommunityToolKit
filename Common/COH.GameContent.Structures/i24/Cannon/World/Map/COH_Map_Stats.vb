Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_Map_Stats
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
        Property roomCount As Int32
            Get
                Return mroomCount
            End Get
            Set(value As Int32)
                mroomCount = value
            End Set
        End Property
        Property floorCount As Int32
            Get
                Return mfloorCount
            End Get
            Set(value As Int32)
                mfloorCount = value
            End Set
        End Property
        Property objectiveRoomCount As Int32
            Get
                Return mobjectiveRoomCount
            End Get
            Set(value As Int32)
                mobjectiveRoomCount = value
            End Set
        End Property
        Property placeCount As Int32
            Get
                Return mplaceCount
            End Get
            Set(value As Int32)
                mplaceCount = value
            End Set
        End Property
        Property places As COH_Map_PlaceStats()
            Get
                Return mplaces
            End Get
            Set(value As COH_Map_PlaceStats())
                mplaces = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mroomCount As Int32
       Private mfloorCount As Int32
       Private mobjectiveRoomCount As Int32
       Private mplaceCount As Int32
       Private mplaces As COH_Map_PlaceStats()
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
            mplaces = New COH_Map_PlaceStats() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Map_Stats
            Dim Result As COH_Map_Stats = New COH_Map_Stats
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mroomCount = mroomCount
                .mfloorCount = mfloorCount
                .mobjectiveRoomCount = mobjectiveRoomCount
                .mplaceCount = mplaceCount
                .mplaces = New COH_Map_PlaceStats(mplaces.Count - 1) {}
                For X = 0 To mplaces.Count - 1
                    .mplaces(X) = mplaces(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mroomCount)
            CurrentWriter.Write(mfloorCount)
            CurrentWriter.Write(mobjectiveRoomCount)
            CurrentWriter.Write(mplaceCount)
            If CurrentWriter.Write_CrypticS_StructArray(mplaces) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mroomCount = CurrentReader.ReadInt32
            mfloorCount = CurrentReader.ReadInt32
            mobjectiveRoomCount = CurrentReader.ReadInt32
            mplaceCount = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Map_PlaceStats), mplaces) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
