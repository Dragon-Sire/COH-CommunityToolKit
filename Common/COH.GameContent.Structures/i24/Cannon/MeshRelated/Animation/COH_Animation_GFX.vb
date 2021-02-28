Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_Animation_GFX
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return FileName
            End Get
        End Property
#End Region

#Region "Properties"
        Property FileName As String
            Get
                Return mFileName
            End Get
            Set(value As String)
                mFileName = value
            End Set
        End Property
        Property Anim As COH_Animation_AnimP()
            Get
                Return mAnim
            End Get
            Set(value As COH_Animation_AnimP())
                mAnim = value
            End Set
        End Property
        Property Ragdoll As Int32
            Get
                Return mRagdoll
            End Get
            Set(value As Int32)
                mRagdoll = value
            End Set
        End Property
        Property PlayFx As COH_Animation_Sequence_FX()
            Get
                Return mPlayFx
            End Get
            Set(value As COH_Animation_Sequence_FX())
                mPlayFx = value
            End Set
        End Property
        Property Scale As Single
            Get
                Return mScale
            End Get
            Set(value As Single)
                mScale = value
            End Set
        End Property
        Property MoveRate As Single
            Get
                Return mMoveRate
            End Get
            Set(value As Single)
                mMoveRate = value
            End Set
        End Property
        Property SmoothSprint As Single
            Get
                Return mSmoothSprint
            End Get
            Set(value As Single)
                mSmoothSprint = value
            End Set
        End Property
        Property PitchAngle As Single
            Get
                Return mPitchAngle
            End Get
            Set(value As Single)
                mPitchAngle = value
            End Set
        End Property
        Property PitchRate As Single
            Get
                Return mPitchRate
            End Get
            Set(value As Single)
                mPitchRate = value
            End Set
        End Property
        Property PitchStart As Single
            Get
                Return mPitchStart
            End Get
            Set(value As Single)
                mPitchStart = value
            End Set
        End Property
        Property PitchEnd As Single
            Get
                Return mPitchEnd
            End Get
            Set(value As Single)
                mPitchEnd = value
            End Set
        End Property
        Property ScaleRootBone As String
            Get
                Return mScaleRootBone
            End Get
            Set(value As String)
                mScaleRootBone = value
            End Set
        End Property
        Property fn As String
            Get
                Return mfn
            End Get
            Set(value As String)
                mfn = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mFileName As String
       Private mAnim As COH_Animation_AnimP()
       Private mRagdoll As Int32
       Private mPlayFx As COH_Animation_Sequence_FX()
       Private mScale As Single
       Private mMoveRate As Single
       Private mSmoothSprint As Single
       Private mPitchAngle As Single
       Private mPitchRate As Single
       Private mPitchStart As Single
       Private mPitchEnd As Single
       Private mScaleRootBone As String
       Private mfn As String
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
            mFileName = String.Empty
            mAnim = New COH_Animation_AnimP() {}
            mPlayFx = New COH_Animation_Sequence_FX() {}
            mScaleRootBone = String.Empty
            mfn = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Animation_GFX
            Dim Result As COH_Animation_GFX = New COH_Animation_GFX
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mFileName = String.Copy(mFileName)
                .mAnim = New COH_Animation_AnimP(mAnim.Count - 1) {}
                For X = 0 To mAnim.Count - 1
                    .mAnim(X) = mAnim(X).Clone
                Next
                .mRagdoll = mRagdoll
                .mPlayFx = New COH_Animation_Sequence_FX(mPlayFx.Count - 1) {}
                For X = 0 To mPlayFx.Count - 1
                    .mPlayFx(X) = mPlayFx(X).Clone
                Next
                .mScale = mScale
                .mMoveRate = mMoveRate
                .mSmoothSprint = mSmoothSprint
                .mPitchAngle = mPitchAngle
                .mPitchRate = mPitchRate
                .mPitchStart = mPitchStart
                .mPitchEnd = mPitchEnd
                .mScaleRootBone = String.Copy(mScaleRootBone)
                .mfn = String.Copy(mfn)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mFileName)
            If CurrentWriter.Write_CrypticS_StructArray(mAnim) = False Then Return False
            CurrentWriter.Write(mRagdoll)
            If CurrentWriter.Write_CrypticS_StructArray(mPlayFx) = False Then Return False
            CurrentWriter.Write(mScale)
            CurrentWriter.Write(mMoveRate)
            CurrentWriter.Write(mSmoothSprint)
            CurrentWriter.Write(mPitchAngle)
            CurrentWriter.Write(mPitchRate)
            CurrentWriter.Write(mPitchStart)
            CurrentWriter.Write(mPitchEnd)
            CurrentWriter.Write_CrypticS_String(mScaleRootBone)
            CurrentWriter.Write_CrypticS_String(mfn)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mFileName = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Animation_AnimP), mAnim) = False Then Return False
            mRagdoll = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Animation_Sequence_FX), mPlayFx) = False Then Return False
            mScale = CurrentReader.ReadSingle
            mMoveRate = CurrentReader.ReadSingle
            mSmoothSprint = CurrentReader.ReadSingle
            mPitchAngle = CurrentReader.ReadSingle
            mPitchRate = CurrentReader.ReadSingle
            mPitchStart = CurrentReader.ReadSingle
            mPitchEnd = CurrentReader.ReadSingle
            mScaleRootBone = CurrentReader.Read_CrypticS_String
            mfn = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
