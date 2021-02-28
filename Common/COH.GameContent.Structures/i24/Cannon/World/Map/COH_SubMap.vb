Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_Map_SubMap
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "SubMap"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Floor As Int32
            Get
                Return mFloor
            End Get
            Set(value As Int32)
                mFloor = value
            End Set
        End Property
        Property defaultXScale As Single
            Get
                Return mdefaultXScale
            End Get
            Set(value As Single)
                mdefaultXScale = value
            End Set
        End Property
        Property defaultYScale As Single
            Get
                Return mdefaultYScale
            End Get
            Set(value As Single)
                mdefaultYScale = value
            End Set
        End Property
        Property MapImage As COH_Map_Component()
            Get
                Return mMapImage
            End Get
            Set(value As COH_Map_Component())
                mMapImage = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mFloor As Int32
       Private mdefaultXScale As Single
       Private mdefaultYScale As Single
       Private mMapImage As COH_Map_Component()
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
            mMapImage = New COH_Map_Component() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Map_SubMap
            Dim Result As COH_Map_SubMap = New COH_Map_SubMap
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mFloor = mFloor
                .mdefaultXScale = mdefaultXScale
                .mdefaultYScale = mdefaultYScale
                .mMapImage = New COH_Map_Component(mMapImage.Count - 1) {}
                For X = 0 To mMapImage.Count - 1
                    .mMapImage(X) = mMapImage(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mArchitectMapSubMap)
            CurrentWriter.Write(mFloor)
            CurrentWriter.Write(mdefaultXScale)
            CurrentWriter.Write(mdefaultYScale)
            If CurrentWriter.Write_CrypticS_StructArray(mMapImage) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mArchitectMapSubMap = 
            mFloor = CurrentReader.ReadInt32
            mdefaultXScale = CurrentReader.ReadSingle
            mdefaultYScale = CurrentReader.ReadSingle
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Map_Component), mMapImage) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
