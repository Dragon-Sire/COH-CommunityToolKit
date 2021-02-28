Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_Trick
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
        Property FileName As String
            Get
                Return mFileName
            End Get
            Set(value As String)
                mFileName = value
            End Set
        End Property
        Property FileAge As Integer
            Get
                Return mFileAge
            End Get
            Set(value As Integer)
                mFileAge = value
            End Set
        End Property
        Property LodFar As Single
            Get
                Return mLodFar
            End Get
            Set(value As Single)
                mLodFar = value
            End Set
        End Property
        Property LodFarFade As Single
            Get
                Return mLodFarFade
            End Get
            Set(value As Single)
                mLodFarFade = value
            End Set
        End Property
        Property LodNear As Single
            Get
                Return mLodNear
            End Get
            Set(value As Single)
                mLodNear = value
            End Set
        End Property
        Property LodNearFade As Single
            Get
                Return mLodNearFade
            End Get
            Set(value As Single)
                mLodNearFade = value
            End Set
        End Property
        Property TrickFlags As COH_EnumFlags_Tricks
            Get
                Return mTrickFlags
            End Get
            Set(value As COH_EnumFlags_Tricks)
                mTrickFlags = value
            End Set
        End Property
        Property ObjFlags As Int32
            Get
                Return mObjFlags
            End Get
            Set(value As Int32)
                mObjFlags = value
            End Set
        End Property
        Property GroupFlags As Int32
            Get
                Return mGroupFlags
            End Get
            Set(value As Int32)
                mGroupFlags = value
            End Set
        End Property
        Property Sway As COH_Struct_Vector2
            Get
                Return mSway
            End Get
            Set(value As COH_Struct_Vector2)
                mSway = value
            End Set
        End Property
        Property SwayRandomize As COH_Struct_Vector2
            Get
                Return mSwayRandomize
            End Get
            Set(value As COH_Struct_Vector2)
                mSwayRandomize = value
            End Set
        End Property
        Property SwayPitch As COH_Struct_Vector2
            Get
                Return mSwayPitch
            End Get
            Set(value As COH_Struct_Vector2)
                mSwayPitch = value
            End Set
        End Property
        Property SwayRoll As COH_Struct_Vector2
            Get
                Return mSwayRoll
            End Get
            Set(value As COH_Struct_Vector2)
                mSwayRoll = value
            End Set
        End Property
        Property AlphaRef As Single
            Get
                Return mAlphaRef
            End Get
            Set(value As Single)
                mAlphaRef = value
            End Set
        End Property
        Property SortBias As Single
            Get
                Return mSortBias
            End Get
            Set(value As Single)
                mSortBias = value
            End Set
        End Property
        Property WaterReflectionSkew As Single
            Get
                Return mWaterReflectionSkew
            End Get
            Set(value As Single)
                mWaterReflectionSkew = value
            End Set
        End Property
        Property WaterReflectionStrength As Single
            Get
                Return mWaterReflectionStrength
            End Get
            Set(value As Single)
                mWaterReflectionStrength = value
            End Set
        End Property
        Property ScrollAmount As COH_Struct_Vector3()
            Get
                Return mScrollAmount
            End Get
            Set(value As COH_Struct_Vector3())
                mScrollAmount = value
            End Set
        End Property
        Property ShadowDist As Single
            Get
                Return mShadowDist
            End Get
            Set(value As Single)
                mShadowDist = value
            End Set
        End Property
        Property NightGlow As COH_Struct_Vector2
            Get
                Return mNightGlow
            End Get
            Set(value As COH_Struct_Vector2)
                mNightGlow = value
            End Set
        End Property
        Property ObjTexBias As Single
            Get
                Return mObjTexBias
            End Get
            Set(value As Single)
                mObjTexBias = value
            End Set
        End Property
        Property CameraFaceTightenUp As Single
            Get
                Return mCameraFaceTightenUp
            End Get
            Set(value As Single)
                mCameraFaceTightenUp = value
            End Set
        End Property
        Property StAnim As COH_Tricks_ST_Anim()
            Get
                Return mStAnim
            End Get
            Set(value As COH_Tricks_ST_Anim())
                mStAnim = value
            End Set
        End Property
        Property TrickNode As COH_TrickNode
            Get
                Return mTrickNode
            End Get
            Set(value As COH_TrickNode)
                mTrickNode = value
            End Set
        End Property
        Property AutoLOD As MeshRelated.COH_LOD_Auto()
            Get
                Return mAutoLOD
            End Get
            Set(value As MeshRelated.COH_LOD_Auto())
                mAutoLOD = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mFileName As String
       Private mFileAge As Integer
       Private mLodFar As Single
       Private mLodFarFade As Single
       Private mLodNear As Single
       Private mLodNearFade As Single
       Private mTrickFlags As COH_EnumFlags_Tricks
       Private mObjFlags As Int32
       Private mGroupFlags As Int32
       Private mSway As COH_Struct_Vector2
       Private mSwayRandomize As COH_Struct_Vector2
       Private mSwayPitch As COH_Struct_Vector2
       Private mSwayRoll As COH_Struct_Vector2
       Private mAlphaRef As Single
       Private mSortBias As Single
       Private mWaterReflectionSkew As Single
       Private mWaterReflectionStrength As Single
       Private mScrollAmount As COH_Struct_Vector3()
       Private mShadowDist As Single
       Private mNightGlow As COH_Struct_Vector2
       Private mObjTexBias As Single
       Private mCameraFaceTightenUp As Single
       Private mStAnim As COH_Tricks_ST_Anim()
       Private mAutoLOD As MeshRelated.COH_LOD_Auto()
       Private mTrickNode As COH_TrickNode
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
            mFileName = String.Empty
            mFileAge = 0 ' No Default Defined
            mLodFar = 0
            mLodFarFade = 0
            mLodNear = 0
            mLodNearFade = 0
            mTrickFlags = 0
            mObjFlags = 0
            mGroupFlags = 0
            mSway = New COH_Struct_Vector2  ' No Default Defined
            mSwayRandomize = New COH_Struct_Vector2 ' No Default Defined
            mSwayPitch = New COH_Struct_Vector2  ' No Default Defined
            mSwayRoll = New COH_Struct_Vector2  ' No Default Defined
            mAlphaRef = 0
            mSortBias = 0
            mWaterReflectionSkew = 30
            mWaterReflectionStrength = 60
            mScrollAmount = New COH_Struct_Vector3(1) {}
            mShadowDist = 0
            mNightGlow = New COH_Struct_Vector2  ' No Default Defined
            mObjTexBias = 0
            mCameraFaceTightenUp = 0
            mStAnim = New COH_Tricks_ST_Anim() {}
            mAutoLOD = New COH_LOD_Auto() {}
            mTrickNode = New COH_TrickNode
        End Sub
#End Region

#Region "Update From MAP"

#End Region

#Region "Clone"
        Public Function Clone() As COH_Trick
            Dim Result As COH_Trick = New COH_Trick
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFileName = String.Copy(mFileName)
                .mFileAge = mFileAge
                .mLodFar = mLodFar
                .mLodFarFade = mLodFarFade
                .mLodNear = mLodNear
                .mLodNearFade = mLodNearFade
                .mTrickFlags = mTrickFlags
                .mObjFlags = mObjFlags
                .mGroupFlags = mGroupFlags
                .mSway = mSway
                .mSwayRandomize = mSwayRandomize
                .mSwayPitch = mSwayPitch
                .mSwayRoll = mSwayRoll
                .mAlphaRef = mAlphaRef
                .mSortBias = mSortBias
                .mWaterReflectionSkew = mWaterReflectionSkew
                .mWaterReflectionStrength = mWaterReflectionStrength
                .mScrollAmount = mScrollAmount
                .mShadowDist = mShadowDist
                .mNightGlow = mNightGlow
                .mObjTexBias = mObjTexBias
                .mCameraFaceTightenUp = mCameraFaceTightenUp
                .mStAnim = New COH_Tricks_ST_Anim(mStAnim.Count - 1) {}
                For X = 0 To mStAnim.Count - 1
                    .mStAnim(X) = mStAnim(X).Clone
                Next
                .mAutoLOD = New MeshRelated.COH_LOD_Auto(mAutoLOD.Count - 1) {}
                For X = 0 To mAutoLOD.Count - 1
                    .mAutoLOD(X) = mAutoLOD(X).Clone
                Next
                .mTrickNode = mTrickNode.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mFileName)
            CurrentWriter.Write_CrypticS_TimeStamp(mFileAge)
            CurrentWriter.Write(mLodFar)
            CurrentWriter.Write(mLodFarFade)
            CurrentWriter.Write(mLodNear)
            CurrentWriter.Write(mLodNearFade)
            CurrentWriter.Write_CrypticS_Flags(mTrickFlags)
            CurrentWriter.Write_CrypticS_Flags(mObjFlags)
            CurrentWriter.Write_CrypticS_Flags(mGroupFlags)
            CurrentWriter.Write_CrypticS_Vector2(mSway)
            CurrentWriter.Write_CrypticS_Vector2(mSwayRandomize)
            '!!REDUNDENT!!CurrentWriter.Write(mRotate)
            '!!REDUNDENT!!CurrentWriter.Write(mRotateRandomize)
            CurrentWriter.Write_CrypticS_Vector2(mSwayPitch)
            CurrentWriter.Write_CrypticS_Vector2(mSwayRoll)
            CurrentWriter.Write(mAlphaRef)
            CurrentWriter.Write(mSortBias)
            CurrentWriter.Write(mWaterReflectionSkew)
            CurrentWriter.Write(mWaterReflectionStrength)
            CurrentWriter.Write(mScrollAmount(0).X) : CurrentWriter.Write(mScrollAmount(0).Y)
            CurrentWriter.Write(mScrollAmount(1).X) : CurrentWriter.Write(mScrollAmount(1).Y)
            CurrentWriter.Write(mShadowDist)
            CurrentWriter.Write_CrypticS_Vector2(mNightGlow)




            CurrentWriter.Write(mObjTexBias)
            CurrentWriter.Write(mCameraFaceTightenUp)
            If CurrentWriter.Write_CrypticS_StructArray(mStAnim) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mAutoLOD) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTrickNode = New COH_TrickNode
            '//ENsure Already Loaded
            mName = CurrentReader.Read_CrypticS_String
            mFileName = CurrentReader.Read_CrypticS_String
            mFileAge = CurrentReader.Read_CrypticS_TimeStamp
            mLodFar = CurrentReader.ReadSingle
            mLodFarFade = CurrentReader.ReadSingle
            mLodNear = CurrentReader.ReadSingle
            mLodNearFade = CurrentReader.ReadSingle
            mTrickFlags = CurrentReader.Read_CrypticS_Flags_Singned
            mObjFlags = CurrentReader.Read_CrypticS_Flags
            mGroupFlags = CurrentReader.Read_CrypticS_Flags
            mSway = CurrentReader.Read_CrypticS_Vector2
            mSwayRandomize = CurrentReader.Read_CrypticS_Vector2
            '!!REDUNDENT!!mRotate = CurrentReader.ReadSingle
            '!!REDUNDENT!!mRotateRandomize = CurrentReader.ReadSingle
            mSwayPitch = CurrentReader.Read_CrypticS_Vector2
            mSwayRoll = CurrentReader.Read_CrypticS_Vector2
            mAlphaRef = CurrentReader.ReadSingle
            mSortBias = CurrentReader.ReadSingle
            mWaterReflectionSkew = CurrentReader.ReadSingle
            mWaterReflectionStrength = CurrentReader.ReadSingle
            mScrollAmount(0) = New COH_Struct_Vector3(CurrentReader.ReadSingle, CurrentReader.ReadSingle, 0) '//Uses only Verctor 2 portion
            mScrollAmount(1) = New COH_Struct_Vector3(CurrentReader.ReadSingle, CurrentReader.ReadSingle, 0)
            mShadowDist = CurrentReader.ReadSingle
            mNightGlow = CurrentReader.Read_CrypticS_Vector2

            mTrickNode.Color1 = New [Shared].Drawing.COH_Color_RGBA() With {.Red = CurrentReader.Read_CrypticS_Byte_Aligned4, .Green = CurrentReader.Read_CrypticS_Byte_Aligned4, .Blue = CurrentReader.Read_CrypticS_Byte_Aligned4}
            mTrickNode.Color2 = New [Shared].Drawing.COH_Color_RGBA() With {.Red = CurrentReader.Read_CrypticS_Byte_Aligned4, .Green = CurrentReader.Read_CrypticS_Byte_Aligned4, .Blue = CurrentReader.Read_CrypticS_Byte_Aligned4}

            mObjTexBias = CurrentReader.ReadSingle
            mCameraFaceTightenUp = CurrentReader.ReadSingle
            '//COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Tricks_ST_Anim), mStAnim) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_LOD_Auto), mAutoLOD) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
