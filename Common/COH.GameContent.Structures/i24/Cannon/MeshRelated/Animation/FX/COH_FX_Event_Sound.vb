Namespace GameContent.Structures.Animation.FX
    Public NotInheritable Class COH_FX_Event_Sound
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return SoundName
            End Get
        End Property
#End Region

#Region "Properties"
        Property SoundName As String
            Get
                Return mSoundName
            End Get
            Set(value As String)
                mSoundName = value
            End Set
        End Property
        Property Radius As Single
            Get
                Return mRadius
            End Get
            Set(value As Single)
                mRadius = value
            End Set
        End Property
        Property Fade As Single
            Get
                Return mFade
            End Get
            Set(value As Single)
                mFade = value
            End Set
        End Property
        Property Volume As Single
            Get
                Return mVolume
            End Get
            Set(value As Single)
                mVolume = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mSoundName As String
       Private mRadius As Single
       Private mFade As Single
       Private mVolume As Single
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
            mSoundName = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_FX_Event_Sound
            Dim Result As COH_FX_Event_Sound = New COH_FX_Event_Sound
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mSoundName = String.Copy(mSoundName)
                .mRadius = mRadius
                .mFade = mFade
                .mVolume = mVolume
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mSoundName)
            CurrentWriter.Write(mRadius)
            CurrentWriter.Write(mFade)
            CurrentWriter.Write(mVolume)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mSoundName = CurrentReader.Read_CrypticS_String
            mRadius = CurrentReader.ReadSingle
            mFade = CurrentReader.ReadSingle
            mVolume = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
