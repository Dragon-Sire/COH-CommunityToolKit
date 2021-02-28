Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_CutScene
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "CutScene"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Flags As COH_Enum_CutSceneFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_CutSceneFlags)
                mFlags = value
            End Set
        End Property
        Property CutSceneEvent As COH_CutScene_Event()
            Get
                Return mEvent
            End Get
            Set(value As COH_CutScene_Event())
                mEvent = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mFlags As COH_Enum_CutSceneFlags
       Private mEvent As COH_CutScene_Event()
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
            mEvent = New COH_CutScene_Event() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CutScene
            Dim Result As COH_CutScene = New COH_CutScene
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mFlags = mFlags
                .mEvent = New COH_CutScene_Event(mEvent.Count - 1) {}
                For X = 0 To mEvent.Count - 1
                    .mEvent(X) = mEvent(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            If CurrentWriter.Write_CrypticS_StructArray(mEvent) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mFlags = CurrentReader.Read_CrypticS_Flags
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CutScene_Event), mEvent) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
