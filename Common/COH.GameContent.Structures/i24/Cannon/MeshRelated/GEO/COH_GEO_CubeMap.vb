Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_GEO_CubeMap
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "CubeMap"
            End Get
        End Property
#End Region

#Region "Properties"
        Property TheSize As Int32
            Get
                Return mTheSize
            End Get
            Set(value As Int32)
                mTheSize = value
            End Set
        End Property
        Property CaptureSize As Int32
            Get
                Return mCaptureSize
            End Get
            Set(value As Int32)
                mCaptureSize = value
            End Set
        End Property
        Property Blue As Single
            Get
                Return mBlue
            End Get
            Set(value As Single)
                mBlue = value
            End Set
        End Property
        Property Time As Single
            Get
                Return mTime
            End Get
            Set(value As Single)
                mTime = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTheSize As Int32
       Private mCaptureSize As Int32
       Private mBlue As Single
       Private mTime As Single
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
            mTheSize = 256
            mCaptureSize = 1024
            mBlue = 0
            mTime = 12
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_GEO_CubeMap
            Dim Result As COH_GEO_CubeMap = New COH_GEO_CubeMap
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTheSize = mTheSize
                .mCaptureSize = mCaptureSize
                .mBlue = mBlue
                .mTime = mTime
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mTheSize)
            CurrentWriter.Write(mCaptureSize)
            CurrentWriter.Write(mBlue)
            CurrentWriter.Write(mTime)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTheSize = CurrentReader.ReadInt32
            mCaptureSize = CurrentReader.ReadInt32
            mBlue = CurrentReader.ReadSingle
            mTime = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
