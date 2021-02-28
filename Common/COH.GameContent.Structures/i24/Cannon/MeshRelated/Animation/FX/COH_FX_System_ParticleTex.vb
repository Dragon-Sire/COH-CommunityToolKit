Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_FX_System_ParticleTex
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Particle Tex"
            End Get
        End Property
#End Region

#Region "Properties"
        Property TextureName As String
            Get
                Return mTextureName
            End Get
            Set(value As String)
                mTextureName = value
            End Set
        End Property
        Property TexScroll As COH_Struct_Vector3
            Get
                Return mTexScroll
            End Get
            Set(value As COH_Struct_Vector3)
                mTexScroll = value
            End Set
        End Property
        Property TexScrollJitter As COH_Struct_Vector3
            Get
                Return mTexScrollJitter
            End Get
            Set(value As COH_Struct_Vector3)
                mTexScrollJitter = value
            End Set
        End Property
        Property AnimFrames As Single
            Get
                Return mAnimFrames
            End Get
            Set(value As Single)
                mAnimFrames = value
            End Set
        End Property
        Property AnimPace As Single
            Get
                Return mAnimPace
            End Get
            Set(value As Single)
                mAnimPace = value
            End Set
        End Property
        Property AnimType As Int32
            Get
                Return mAnimType
            End Get
            Set(value As Int32)
                mAnimType = value
            End Set
        End Property
        Property TexScale As COH_Struct_Vector2
            Get
                Return mTexScale
            End Get
            Set(value As COH_Struct_Vector2)
                mTexScale = value
            End Set
        End Property
        Property FrameWidth As Int32
            Get
                Return mFrameWidth
            End Get
            Set(value As Int32)
                mFrameWidth = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTextureName As String
       Private mTexScroll As COH_Struct_Vector3
       Private mTexScrollJitter As COH_Struct_Vector3
       Private mAnimFrames As Single
       Private mAnimPace As Single
       Private mAnimType As Int32
       Private mTexScale As COH_Struct_Vector2
       Private mFrameWidth As Int32
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
            mTextureName = String.Empty
            mTexScroll = New COH_Struct_Vector3
            mTexScrollJitter = New COH_Struct_Vector3
            mTexScale = New COH_Struct_Vector2
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_FX_System_ParticleTex
            Dim Result As COH_FX_System_ParticleTex = New COH_FX_System_ParticleTex
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTextureName = mTextureName
                .mTexScroll = mTexScroll
                .mTexScrollJitter = mTexScrollJitter
                .mAnimFrames = mAnimFrames
                .mAnimPace = mAnimPace
                .mAnimType = mAnimType
                .mFrameWidth = mFrameWidth
                .mTexScale = mTexScale
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Return True
        End Function
#End Region

    End Class
End Namespace
