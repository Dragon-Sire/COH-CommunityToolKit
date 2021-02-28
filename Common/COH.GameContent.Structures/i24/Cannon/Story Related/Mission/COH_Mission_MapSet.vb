Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_Mission_MapSet
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return DisplayName
            End Get
        End Property
#End Region

#Region "Properties"
        Property MapSet As COH_Enum_MapSet
            Get
                Return mMapSet
            End Get
            Set(value As COH_Enum_MapSet)
                mMapSet = value
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
        Property RandomDoorType As String()
            Get
                Return mRandomDoorType
            End Get
            Set(value As String())
                mRandomDoorType = value
            End Set
        End Property
        Property Time As COH_Mission_MapTime()
            Get
                Return mTime
            End Get
            Set(value As COH_Mission_MapTime())
                mTime = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mMapSet As COH_Enum_MapSet
       Private mDisplayName As String
       Private mRandomDoorType As String()
       Private mTime As COH_Mission_MapTime()
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
            mMapSet = COH_Enum_MapSet.MAPSET_NONE
            mDisplayName = String.Empty
            mRandomDoorType = New String() {}
            mTime = New COH_Mission_MapTime() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Mission_MapSet
            Dim Result As COH_Mission_MapSet = New COH_Mission_MapSet
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mMapSet = mMapSet
                .mDisplayName = String.Copy(mDisplayName)
                .mRandomDoorType = mRandomDoorType.CloneTheStrings
                .mTime = New COH_Mission_MapTime(mTime.Count - 1) {}
                For X = 0 To mTime.Count - 1
                    .mTime(X) = mTime(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(CInt(mMapSet))
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_StringArray(mRandomDoorType)
            If CurrentWriter.Write_CrypticS_StructArray(mTime) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mMapSet = CurrentReader.ReadInt32
            mDisplayName = CurrentReader.Read_CrypticS_String
            mRandomDoorType = CurrentReader.Read_CrypticS_StringArray()
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Mission_MapTime), mTime) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
