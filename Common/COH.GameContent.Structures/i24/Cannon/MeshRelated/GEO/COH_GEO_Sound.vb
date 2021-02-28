Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_GEO_Sound
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
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
        Property Radius As Single
            Get
                Return mRadius
            End Get
            Set(value As Single)
                mRadius = value
            End Set
        End Property
        Property Ramp As Single
            Get
                Return mRamp
            End Get
            Set(value As Single)
                mRamp = value
            End Set
        End Property
        Property Exclude As COH_Enum_SoundFlags
            Get
                Return mExclude
            End Get
            Set(value As COH_Enum_SoundFlags)
                mExclude = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mVolume As Single
       Private mRadius As Single
       Private mRamp As Single
       Private mExclude As COH_Enum_SoundFlags
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
            mName = String.Empty
            mVolume = 0
            mRadius = 0
            mRamp = 0
            mExclude = COH_Enum_SoundFlags.Exclude
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_GEO_Sound
            Dim Result As COH_GEO_Sound = New COH_GEO_Sound
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mVolume = mVolume
                .mRadius = mRadius
                .mRamp = mRamp
                .mExclude = mExclude
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mVolume)
            CurrentWriter.Write(mRadius)
            CurrentWriter.Write(mRamp)
            CurrentWriter.Write_CrypticS_Flags(mExclude)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mVolume = CurrentReader.ReadSingle
            mRadius = CurrentReader.ReadSingle
            mRamp = CurrentReader.ReadSingle
            mExclude = CurrentReader.Read_CrypticS_Flags()
            Return True
        End Function
#End Region

    End Class
End Namespace
