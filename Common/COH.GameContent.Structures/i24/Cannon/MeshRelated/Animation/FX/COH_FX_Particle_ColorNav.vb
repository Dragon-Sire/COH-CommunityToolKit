Imports COH.GameContent.Structures.Shared.Drawing

Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_FX_Particle_ColorNav
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "NAV"
            End Get
        End Property
#End Region

#Region "Properties"
        Property TheColor As COH_Color_RGB
            Get
                Return mBeColor
            End Get
            Set(value As COH_Color_RGB)
                mBeColor = value
            End Set
        End Property
        Property ByTime As Int32
            Get
                Return mByTime
            End Get
            Set(value As Int32)
                mByTime = value
            End Set
        End Property
        Property PrimaryTint As Single
            Get
                Return mPrimaryTint
            End Get
            Set(value As Single)
                mPrimaryTint = value
            End Set
        End Property
        Property SecondaryTint As Single
            Get
                Return mSecondaryTint
            End Get
            Set(value As Single)
                mSecondaryTint = value
            End Set
        End Property
        Property Rgb As COH_Color_RGB
            Get
                Return mRgb
            End Get
            Set(value As COH_Color_RGB)
                mRgb = value
            End Set
        End Property
        Property RgbTime As Int32
            Get
                Return mRgbTime
            End Get
            Set(value As Int32)
                mRgbTime = value
            End Set
        End Property

#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mBeColor As COH_Color_RGB
       Private mByTime As Int32
       Private mPrimaryTint As Single
       Private mSecondaryTint As Single
       Private mRgb As COH_Color_RGB
       Private mRgbTime As Int32
       Private mFadeInBy As Single
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
            mBeColor = New COH_Color_RGB
            mRgb = New COH_Color_RGB
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_FX_Particle_ColorNav
            Dim Result As COH_FX_Particle_ColorNav = New COH_FX_Particle_ColorNav
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mBeColor = mBeColor
                .mByTime = mByTime
                .mPrimaryTint = mPrimaryTint
                .mSecondaryTint = mSecondaryTint
                .mRgb = mRgb
                .mRgbTime = mRgbTime
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
