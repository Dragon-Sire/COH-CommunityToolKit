Namespace GameContent.Structures.World.Maps
    Public NotInheritable Class COH_UniqueMap
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mDisplayName
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
        Property Map As COH_UniqueMap_File()
            Get
                Return mMap
            End Get
            Set(value As COH_UniqueMap_File())
                mMap = value
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
       Private mMap As COH_UniqueMap_File()
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
            mMap = New COH_UniqueMap_File() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            For Each Entry In mMap
                Entry.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_UniqueMap
            Dim Result As COH_UniqueMap = New COH_UniqueMap
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mMap = New COH_UniqueMap_File(mMap.Count - 1) {}
                For X = 0 To mMap.Count - 1
                    .mMap(X) = mMap(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            If CurrentWriter.Write_CrypticS_StructArray(mMap) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_UniqueMap_File), mMap) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
