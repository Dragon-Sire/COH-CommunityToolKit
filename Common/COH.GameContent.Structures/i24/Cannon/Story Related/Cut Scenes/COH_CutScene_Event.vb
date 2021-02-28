Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_CutScene_Event
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "CutScene Event"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Time As Single
            Get
                Return mTime
            End Get
            Set(value As Single)
                mTime = value
            End Set
        End Property
        Property Actor As String
            Get
                Return mActor
            End Get
            Set(value As String)
                mActor = value
            End Set
        End Property
        Property Dialog As String
            Get
                Return mDialog
            End Get
            Set(value As String)
                mDialog = value
            End Set
        End Property
        Property Action As String
            Get
                Return mAction
            End Get
            Set(value As String)
                mAction = value
            End Set
        End Property
        Property Target As String
            Get
                Return mTarget
            End Get
            Set(value As String)
                mTarget = value
            End Set
        End Property
        Property Position As String
            Get
                Return mPosition
            End Get
            Set(value As String)
                mPosition = value
            End Set
        End Property
        Property MoveTo As String
            Get
                Return mMoveTo
            End Get
            Set(value As String)
                mMoveTo = value
            End Set
        End Property
        Property DepthOfField As Single
            Get
                Return mDepthOfField
            End Get
            Set(value As Single)
                mDepthOfField = value
            End Set
        End Property
        Property MoveToDepthOfField As Single
            Get
                Return mMoveToDepthOfField
            End Get
            Set(value As Single)
                mMoveToDepthOfField = value
            End Set
        End Property
        Property Over As Int32
            Get
                Return mOver
            End Get
            Set(value As Int32)
                mOver = value
            End Set
        End Property
        Property Music As String
            Get
                Return mMusic
            End Get
            Set(value As String)
                mMusic = value
            End Set
        End Property
        Property SoundFx As String
            Get
                Return mSoundFx
            End Get
            Set(value As String)
                mSoundFx = value
            End Set
        End Property
        Property LeftText As String
            Get
                Return mLeftText
            End Get
            Set(value As String)
                mLeftText = value
            End Set
        End Property
        Property LeftWatermark As String
            Get
                Return mLeftWatermark
            End Get
            Set(value As String)
                mLeftWatermark = value
            End Set
        End Property
        Property LeftObjective As String
            Get
                Return mLeftObjective
            End Get
            Set(value As String)
                mLeftObjective = value
            End Set
        End Property
        Property LeftReward As String
            Get
                Return mLeftReward
            End Get
            Set(value As String)
                mLeftReward = value
            End Set
        End Property
        Property RightText As String
            Get
                Return mRightText
            End Get
            Set(value As String)
                mRightText = value
            End Set
        End Property
        Property RightWatermark As String
            Get
                Return mRightWatermark
            End Get
            Set(value As String)
                mRightWatermark = value
            End Set
        End Property
        Property RightObjective As String
            Get
                Return mRightObjective
            End Get
            Set(value As String)
                mRightObjective = value
            End Set
        End Property
        Property RightReward As String
            Get
                Return mRightReward
            End Get
            Set(value As String)
                mRightReward = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTime As Single
       Private mActor As String
       Private mDialog As String
       Private mAction As String
       Private mTarget As String
       Private mPosition As String
       Private mMoveTo As String
       Private mDepthOfField As Single
       Private mMoveToDepthOfField As Single
       Private mOver As Int32
       Private mMusic As String
       Private mSoundFx As String
       Private mLeftText As String
       Private mLeftWatermark As String
       Private mLeftObjective As String
       Private mLeftReward As String
       Private mRightText As String
       Private mRightWatermark As String
       Private mRightObjective As String
       Private mRightReward As String
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
            mActor = String.Empty
            mDialog = String.Empty
            mAction = String.Empty
            mTarget = String.Empty
            mPosition = String.Empty
            mMoveTo = String.Empty
            mMusic = String.Empty
            mSoundFx = String.Empty
            mLeftText = String.Empty
            mLeftWatermark = String.Empty
            mLeftObjective = String.Empty
            mLeftReward = String.Empty
            mRightText = String.Empty
            mRightWatermark = String.Empty
            mRightObjective = String.Empty
            mRightReward = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CutScene_Event
            Dim Result As COH_CutScene_Event = New COH_CutScene_Event
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTime = mTime
                .mActor = String.Copy(mActor)
                .mDialog = String.Copy(mDialog)
                .mAction = String.Copy(mAction)
                .mTarget = String.Copy(mTarget)
                .mPosition = String.Copy(mPosition)
                .mMoveTo = String.Copy(mMoveTo)
                .mDepthOfField = mDepthOfField
                .mMoveToDepthOfField = mMoveToDepthOfField
                .mOver = mOver
                .mMusic = String.Copy(mMusic)
                .mSoundFx = String.Copy(mSoundFx)
                .mLeftText = String.Copy(mLeftText)
                .mLeftWatermark = String.Copy(mLeftWatermark)
                .mLeftObjective = String.Copy(mLeftObjective)
                .mLeftReward = String.Copy(mLeftReward)
                .mRightText = String.Copy(mRightText)
                .mRightWatermark = String.Copy(mRightWatermark)
                .mRightObjective = String.Copy(mRightObjective)
                .mRightReward = String.Copy(mRightReward)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mTime)
            CurrentWriter.Write_CrypticS_String(mActor)
            CurrentWriter.Write_CrypticS_String(mDialog)
            CurrentWriter.Write_CrypticS_String(mAction)
            CurrentWriter.Write_CrypticS_String(mTarget)
            CurrentWriter.Write_CrypticS_String(mPosition)
            CurrentWriter.Write_CrypticS_String(mMoveTo)
            CurrentWriter.Write(mDepthOfField)
            CurrentWriter.Write(mMoveToDepthOfField)
            CurrentWriter.Write(mOver)
            CurrentWriter.Write_CrypticS_String(mMusic)
            CurrentWriter.Write_CrypticS_String(mSoundFx)
            CurrentWriter.Write_CrypticS_String(mLeftText)
            CurrentWriter.Write_CrypticS_String(mLeftWatermark)
            CurrentWriter.Write_CrypticS_String(mLeftObjective)
            CurrentWriter.Write_CrypticS_String(mLeftReward)
            CurrentWriter.Write_CrypticS_String(mRightText)
            CurrentWriter.Write_CrypticS_String(mRightWatermark)
            CurrentWriter.Write_CrypticS_String(mRightObjective)
            CurrentWriter.Write_CrypticS_String(mRightReward)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTime = CurrentReader.ReadSingle
            mActor = CurrentReader.Read_CrypticS_String
            mDialog = CurrentReader.Read_CrypticS_String
            mAction = CurrentReader.Read_CrypticS_String
            mTarget = CurrentReader.Read_CrypticS_String
            mPosition = CurrentReader.Read_CrypticS_String
            mMoveTo = CurrentReader.Read_CrypticS_String
            mDepthOfField = CurrentReader.ReadSingle
            mMoveToDepthOfField = CurrentReader.ReadSingle
            mOver = CurrentReader.ReadInt32
            mMusic = CurrentReader.Read_CrypticS_String
            mSoundFx = CurrentReader.Read_CrypticS_String
            mLeftText = CurrentReader.Read_CrypticS_String
            mLeftWatermark = CurrentReader.Read_CrypticS_String
            mLeftObjective = CurrentReader.Read_CrypticS_String
            mLeftReward = CurrentReader.Read_CrypticS_String
            mRightText = CurrentReader.Read_CrypticS_String
            mRightWatermark = CurrentReader.Read_CrypticS_String
            mRightObjective = CurrentReader.Read_CrypticS_String
            mRightReward = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
