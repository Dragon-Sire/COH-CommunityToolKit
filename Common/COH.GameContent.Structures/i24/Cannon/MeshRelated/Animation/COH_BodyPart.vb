Namespace GameContent.Structures.Body
    Public NotInheritable Class COH_BodyPart
        Inherits COH_FileStructure

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
        Property SourceFile As String
            Get
                Return mSourceFile
            End Get
            Set(value As String)
                mSourceFile = value
            End Set
        End Property
        Property BoneCount As Int32
            Get
                Return mBoneCount
            End Get
            Set(value As Int32)
                mBoneCount = value
            End Set
        End Property
        Property InfluenceCost As Int32
            Get
                Return mInfluenceCost
            End Get
            Set(value As Int32)
                mInfluenceCost = value
            End Set
        End Property
        Property GeoName As String
            Get
                Return mGeoName
            End Get
            Set(value As String)
                mGeoName = value
            End Set
        End Property
        Property TexName As String
            Get
                Return mTexName
            End Get
            Set(value As String)
                mTexName = value
            End Set
        End Property
        Property BaseName As String
            Get
                Return mBaseName
            End Get
            Set(value As String)
                mBaseName = value
            End Set
        End Property
        Property BoneCount2 As Int32
            Get
                Return mBoneCount2
            End Get
            Set(value As Int32)
                mBoneCount2 = value
            End Set
        End Property
        Property DontClear As Boolean
            Get
                Return mDontClear
            End Get
            Set(value As Boolean)
                mDontClear = value
            End Set
        End Property
        Property Bone1 As GEO_Enums_MESH_BoneId
            Get
                Return mBone1
            End Get
            Set(value As GEO_Enums_MESH_BoneId)
                mBone1 = value
            End Set
        End Property
        Property Bone2 As GEO_Enums_MESH_BoneId
            Get
                Return mBone2
            End Get
            Set(value As GEO_Enums_MESH_BoneId)
                mBone2 = value
            End Set
        End Property
        Property BodyPartIndex As Int32
            Get
                Return mBodyPartIndex
            End Get
            Set(value As Int32)
                mBodyPartIndex = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mSourceFile As String
       Private mBoneCount As Int32
       Private mInfluenceCost As Int32
       Private mGeoName As String
       Private mTexName As String
       Private mBaseName As String
       Private mBoneCount2 As Int32
       Private mDontClear As Boolean
       Private mBone1 As GEO_Enums_MESH_BoneId
       Private mBone2 As GEO_Enums_MESH_BoneId
       Private mBodyPartIndex As Int32
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
            mName = String.Empty
            mSourceFile = String.Empty
            mGeoName = String.Empty
            mTexName = String.Empty
            mBaseName = String.Empty
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_BodyPart
            Dim Result As COH_BodyPart = New COH_BodyPart
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mSourceFile = String.Copy(mSourceFile)
                .mBoneCount = mBoneCount
                .mInfluenceCost = mInfluenceCost
                .mGeoName = String.Copy(mGeoName)
                .mTexName = String.Copy(mTexName)
                .mBaseName = String.Copy(mBaseName)
                .mBoneCount2 = mBoneCount2
                .mDontClear = mDontClear
                .mBone1 = mBone1
                .mBone2 = mBone2
                .mBodyPartIndex = mBodyPartIndex
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mSourceFile)
            CurrentWriter.Write(mBoneCount)
            CurrentWriter.Write(mInfluenceCost)
            CurrentWriter.Write_CrypticS_String(mGeoName)
            CurrentWriter.Write_CrypticS_String(mTexName)
            CurrentWriter.Write_CrypticS_String(mBaseName)
            CurrentWriter.Write(mBoneCount)
            CurrentWriter.Write_CrypticS_Boolean(mDontClear)
            CurrentWriter.Write(mBone1)
            CurrentWriter.Write(mBone2)
            CurrentWriter.Write(mBodyPartIndex)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mSourceFile = CurrentReader.Read_CrypticS_String
            mBoneCount = CurrentReader.ReadInt32
            mInfluenceCost = CurrentReader.ReadInt32
            mGeoName = CurrentReader.Read_CrypticS_String
            mTexName = CurrentReader.Read_CrypticS_String
            mBaseName = CurrentReader.Read_CrypticS_String
            mBoneCount = CurrentReader.ReadInt32
            mDontClear = CurrentReader.Read_CrypticS_Boolean
            mBone1 = CurrentReader.ReadInt32
            mBone2 = CurrentReader.ReadInt32
            mBodyPartIndex = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
