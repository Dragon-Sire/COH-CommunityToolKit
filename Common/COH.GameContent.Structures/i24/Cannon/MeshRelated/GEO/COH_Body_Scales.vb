Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_Body_Scales
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Scales"
            End Get
        End Property
#End Region

#Region "Properties"
        Property [Global] As Single
            Get
                Return mGlobal
            End Get
            Set(value As Single)
                mGlobal = value
            End Set
        End Property
        Property Bone As Single
            Get
                Return mBone
            End Get
            Set(value As Single)
                mBone = value
            End Set
        End Property
        Property Head As Single
            Get
                Return mHead
            End Get
            Set(value As Single)
                mHead = value
            End Set
        End Property
        Property Chest As Single
            Get
                Return mChest
            End Get
            Set(value As Single)
                mChest = value
            End Set
        End Property
        Property Shoulder As Single
            Get
                Return mShoulder
            End Get
            Set(value As Single)
                mShoulder = value
            End Set
        End Property
        Property Waist As Single
            Get
                Return mWaist
            End Get
            Set(value As Single)
                mWaist = value
            End Set
        End Property
        Property Hip As Single
            Get
                Return mHip
            End Get
            Set(value As Single)
                mHip = value
            End Set
        End Property
        Property Leg As Single
            Get
                Return mLeg
            End Get
            Set(value As Single)
                mLeg = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mGlobal As Single
       Private mBone As Single
       Private mHead As Single
       Private mChest As Single
       Private mShoulder As Single
       Private mWaist As Single
       Private mHip As Single
       Private mLeg As Single
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
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Body_Scales
            Dim Result As COH_Body_Scales = New COH_Body_Scales
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mGlobal = mGlobal
                .mBone = mBone
                .mHead = mHead
                .mChest = mChest
                .mShoulder = mShoulder
                .mWaist = mWaist
                .mHip = mHip
                .mLeg = mLeg
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mGlobal)
            CurrentWriter.Write(mBone)
            CurrentWriter.Write(mHead)
            CurrentWriter.Write(mChest)
            CurrentWriter.Write(mShoulder)
            CurrentWriter.Write(mWaist)
            CurrentWriter.Write(mHip)
            CurrentWriter.Write(mLeg)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mGlobal = CurrentReader.ReadSingle
            mBone = CurrentReader.ReadSingle
            mHead = CurrentReader.ReadSingle
            mChest = CurrentReader.ReadSingle
            mShoulder = CurrentReader.ReadSingle
            mWaist = CurrentReader.ReadSingle
            mHip = CurrentReader.ReadSingle
            mLeg = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
