Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_DEF
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
        Property Group As COH_GEO_Group()
            Get
                Return mGroup
            End Get
            Set(value As COH_GEO_Group())
                mGroup = value
            End Set
        End Property
        Property [Property] As COH_GEO_Property()
            Get
                Return mProperty
            End Get
            Set(value As COH_GEO_Property())
                mProperty = value
            End Set
        End Property
        Property TintColor As COH_GEO_TINT()
            Get
                Return mTintColor
            End Get
            Set(value As COH_GEO_TINT())
                mTintColor = value
            End Set
        End Property
        Property Ambient As COH_GEO_AMBIENT()
            Get
                Return mAmbient
            End Get
            Set(value As COH_GEO_AMBIENT())
                mAmbient = value
            End Set
        End Property
        Property Omni As COH_GEO_OMNI()
            Get
                Return mOmni
            End Get
            Set(value As COH_GEO_OMNI())
                mOmni = value
            End Set
        End Property
        Property Cubemap As COH_GEO_CubeMap()
            Get
                Return mCubemap
            End Get
            Set(value As COH_GEO_CubeMap())
                mCubemap = value
            End Set
        End Property
        Property Volume As COH_GEO_Volume()
            Get
                Return mVolume
            End Get
            Set(value As COH_GEO_Volume())
                mVolume = value
            End Set
        End Property
        Property Sound As COH_GEO_Sound()
            Get
                Return mSound
            End Get
            Set(value As COH_GEO_Sound())
                mSound = value
            End Set
        End Property
        Property ReplaceTex As COH_GEO_ReplaceText()
            Get
                Return mReplaceTex
            End Get
            Set(value As COH_GEO_ReplaceText())
                mReplaceTex = value
            End Set
        End Property
        Property Beacon As COH_GEO_BEACON()
            Get
                Return mBeacon
            End Get
            Set(value As COH_GEO_BEACON())
                mBeacon = value
            End Set
        End Property
        Property Fog As COH_GEO_FOG()
            Get
                Return mFog
            End Get
            Set(value As COH_GEO_FOG())
                mFog = value
            End Set
        End Property
        Property Lod As COH_LOD()
            Get
                Return mLod
            End Get
            Set(value As COH_LOD())
                mLod = value
            End Set
        End Property
        Property Type As String
            Get
                Return mType
            End Get
            Set(value As String)
                mType = value
            End Set
        End Property
        Property Flags As COH_Enum_DefFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_DefFlags)
                mFlags = value
            End Set
        End Property
        Property Alpha As Single
            Get
                Return mAlpha
            End Get
            Set(value As Single)
                mAlpha = value
            End Set
        End Property
        Property Obj As String
            Get
                Return mObj
            End Get
            Set(value As String)
                mObj = value
            End Set
        End Property
        Property TexSwap As COH_GEO_TextureSwap()
            Get
                Return mTexSwap
            End Get
            Set(value As COH_GEO_TextureSwap())
                mTexSwap = value
            End Set
        End Property
        Property SoundScript As String
            Get
                Return mSoundScript
            End Get
            Set(value As String)
                mSoundScript = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mGroup As COH_GEO_Group()
       Private mProperty As COH_GEO_Property()
       Private mTintColor As COH_GEO_Tint()
       Private mAmbient As COH_GEO_Ambient()
       Private mOmni As COH_GEO_Omni()
       Private mCubemap As COH_GEO_CubeMap()
       Private mVolume As COH_GEO_Volume()
       Private mSound As COH_GEO_Sound()
       Private mReplaceTex As COH_GEO_ReplaceText()
       Private mBeacon As COH_GEO_BEACON()
       Private mFog As COH_GEO_FOG()
       Private mLod As COH_LOD()
       Private mType As String
       Private mFlags As COH_Enum_DefFlags
       Private mAlpha As Single
       Private mObj As String
       Private mTexSwap As COH_GEO_TextureSwap()
       Private mSoundScript As String
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
            mGroup = New COH_GEO_Group() {}
            mProperty = New COH_GEO_Property() {}
            mTintColor = New COH_GEO_Tint() {}
            mAmbient = New COH_GEO_Ambient() {}
            mOmni = New COH_GEO_Omni() {}
            mCubemap = New COH_GEO_CubeMap() {}
            mVolume = New COH_GEO_Volume() {}
            mSound = New COH_GEO_Sound() {}
            mReplaceTex = New COH_GEO_ReplaceText() {}
            mBeacon = New COH_GEO_BEACON() {}
            mFog = New COH_GEO_FOG() {}
            mLod = New COH_LOD() {}
            mType = String.Empty
            mFlags = COH_Enum_DefFlags.None
            mAlpha = 0
            mObj = String.Empty
            mTexSwap = New COH_GEO_TextureSwap() {}
            mSoundScript = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_DEF
            Dim Result As COH_DEF = New COH_DEF
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mGroup = New COH_GEO_Group(mGroup.Count - 1) {}
                For X = 0 To mGroup.Count - 1
                    .mGroup(X) = mGroup(X).Clone
                Next
                .mProperty = New COH_GEO_Property(mProperty.Count - 1) {}
                For X = 0 To mProperty.Count - 1
                    .mProperty(X) = mProperty(X).Clone
                Next
                .mTintColor = New COH_GEO_Tint(mTintColor.Count - 1) {}
                For X = 0 To mTintColor.Count - 1
                    .mTintColor(X) = mTintColor(X).Clone
                Next
                .mAmbient = New COH_GEO_Ambient(mAmbient.Count - 1) {}
                For X = 0 To mAmbient.Count - 1
                    .mAmbient(X) = mAmbient(X).Clone
                Next
                .mOmni = New COH_GEO_Omni(mOmni.Count - 1) {}
                For X = 0 To mOmni.Count - 1
                    .mOmni(X) = mOmni(X).Clone
                Next
                .mCubemap = New COH_GEO_CubeMap(mCubemap.Count - 1) {}
                For X = 0 To mCubemap.Count - 1
                    .mCubemap(X) = mCubemap(X).Clone
                Next
                .mVolume = New COH_GEO_Volume(mVolume.Count - 1) {}
                For X = 0 To mVolume.Count - 1
                    .mVolume(X) = mVolume(X).Clone
                Next
                .mSound = New COH_GEO_Sound(mSound.Count - 1) {}
                For X = 0 To mSound.Count - 1
                    .mSound(X) = mSound(X).Clone
                Next
                .mReplaceTex = New COH_GEO_ReplaceText(mReplaceTex.Count - 1) {}
                For X = 0 To mReplaceTex.Count - 1
                    .mReplaceTex(X) = mReplaceTex(X).Clone
                Next
                .mBeacon = New COH_GEO_Beacon(mBeacon.Count - 1) {}
                For X = 0 To mBeacon.Count - 1
                    .mBeacon(X) = mBeacon(X).Clone
                Next
                .mFog = New COH_GEO_FOG(mFog.Count - 1) {}
                For X = 0 To mFog.Count - 1
                    .mFog(X) = mFog(X).Clone
                Next
                .mLod = New COH_LOD(mLod.Count - 1) {}
                For X = 0 To mLod.Count - 1
                    .mLod(X) = mLod(X).Clone
                Next
                .mType = String.Copy(mType)
                .mFlags = mFlags
                .mAlpha = mAlpha
                .mObj = String.Copy(mObj)
                .mTexSwap = New COH_GEO_TextureSwap(mTexSwap.Count - 1) {}
                For X = 0 To mTexSwap.Count - 1
                    .mTexSwap(X) = mTexSwap(X).Clone
                Next
                .mSoundScript = String.Copy(mSoundScript)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mname)
            If CurrentWriter.Write_CrypticS_StructArray(mGroup) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mProperty) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mTintColor) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mAmbient) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mOmni) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mCubemap) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mVolume) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mSound) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mReplaceTex) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mBeacon) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mFog) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mLod) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mType)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            CurrentWriter.Write(mAlpha)
            CurrentWriter.Write_CrypticS_String(mObj)
            If CurrentWriter.Write_CrypticS_StructArray(mTexSwap) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mSoundScript)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_Group), mGroup) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_Property), mProperty) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_Tint), mTintColor) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_Ambient), mAmbient) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_Omni), mOmni) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_CubeMap), mCubemap) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_Volume), mVolume) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_Sound), mSound) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_ReplaceText), mReplaceTex) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_Beacon), mBeacon) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_FOG), mFog) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_LOD), mLod) = False Then Return False
            mType = CurrentReader.Read_CrypticS_String
            mFlags = CurrentReader.Read_CrypticS_Flags
            mAlpha = CurrentReader.ReadSingle
            mObj = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GEO_TextureSwap), mTexSwap) = False Then Return False
            mSoundScript = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
