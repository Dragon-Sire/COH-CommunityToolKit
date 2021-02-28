Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_Tricks_ST_Anim
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property SpeedScale As Single
            Get
                Return mSpeedScale
            End Get
            Set(value As Single)
                mSpeedScale = value
            End Set
        End Property
        Property STScale As Single
            Get
                Return mSTScale
            End Get
            Set(value As Single)
                mSTScale = value
            End Set
        End Property
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property AnimationFlags As COH_Enum_TricksAnimationFlags
            Get
                Return mAnimationFlags
            End Get
            Set(value As COH_Enum_TricksAnimationFlags)
                mAnimationFlags = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mSpeedScale As Single
       Private mSTScale As Single
       Private mName As String
       Private mAnimationFlags As COH_Enum_TricksAnimationFlags
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
            mSpeedScale = 0
            mSTScale = 0
            mName = String.Empty
            mAnimationFlags = 0
        End Sub
#End Region

#Region "Update From MAP"
#End Region

#Region "Clone"
        Public Function Clone() As COH_Tricks_ST_Anim
            Dim Result As COH_Tricks_ST_Anim = New COH_Tricks_ST_Anim
            'MyBase.CloneTo(Result)
            With Result
                .mSpeedScale = mSpeedScale
                .mSTScale = mSTScale
                .mName = String.Copy(mName)
                .mAnimationFlags = mAnimationFlags
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mSpeedScale)
            CurrentWriter.Write(mSTScale)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_Flags(mAnimationFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mSpeedScale = CurrentReader.ReadSingle
            mSTScale = CurrentReader.ReadSingle
            mName = CurrentReader.Read_CrypticS_String
            mAnimationFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace
