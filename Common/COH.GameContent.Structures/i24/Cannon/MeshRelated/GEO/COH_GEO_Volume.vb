Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_GEO_Volume
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Volume"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Scale1 As Single
            Get
                Return mScale1
            End Get
            Set(value As Single)
                mScale1 = value
            End Set
        End Property
        Property Scale2 As Single
            Get
                Return mScale2
            End Get
            Set(value As Single)
                mScale2 = value
            End Set
        End Property
        Property Scale3 As Single
            Get
                Return mScale3
            End Get
            Set(value As Single)
                mScale3 = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mScale1 As Single
       Private mScale2 As Single
       Private mScale3 As Single
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mScale1 = 0
            mScale2 = 0
            mScale3 = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_GEO_Volume
            Dim Result As COH_GEO_Volume = New COH_GEO_Volume
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mScale1 = mScale1
                .mScale2 = mScale2
                .mScale3 = mScale3
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mScale1)
            CurrentWriter.Write(mScale2)
            CurrentWriter.Write(mScale3)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mScale1 = CurrentReader.ReadSingle
            mScale2 = CurrentReader.ReadSingle
            mScale3 = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
