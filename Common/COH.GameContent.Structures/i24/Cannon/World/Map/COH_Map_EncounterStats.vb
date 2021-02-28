Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_Map_EncounterStats
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return TheType
            End Get
        End Property
#End Region

#Region "Properties"
        Property TheType As String
            Get
                Return mTheType
            End Get
            Set(value As String)
                mTheType = value
            End Set
        End Property
        Property CountGrouped As Int32
            Get
                Return mCountGrouped
            End Get
            Set(value As Int32)
                mCountGrouped = value
            End Set
        End Property
        Property CountOnly As Int32
            Get
                Return mCountOnly
            End Get
            Set(value As Int32)
                mCountOnly = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTheType As String
       Private mCountGrouped As Int32
       Private mCountOnly As Int32
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
            mTheType = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Map_EncounterStats
            Dim Result As COH_Map_EncounterStats = New COH_Map_EncounterStats
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTheType = String.Copy(mTheType)
                .mCountGrouped = mCountGrouped
                .mCountOnly = mCountOnly
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mTheType)
            CurrentWriter.Write(mCountGrouped)
            CurrentWriter.Write(mCountOnly)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTheType = CurrentReader.Read_CrypticS_String
            mCountGrouped = CurrentReader.ReadInt32
            mCountOnly = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
