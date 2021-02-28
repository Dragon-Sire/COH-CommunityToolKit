Namespace GameContent.Structures.Costumes
    Public NotInheritable Class COH_Costume
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Costume"
            End Get
        End Property
#End Region

#Region "Properties"
        Property EntTypeFile As String
            Get
                Return mEntTypeFile
            End Get
            Set(value As String)
                mEntTypeFile = value
            End Set
        End Property
        Property CostumeFilePrefix As String
            Get
                Return mCostumeFilePrefix
            End Get
            Set(value As String)
                mCostumeFilePrefix = value
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
        Property BoneScale As Single
            Get
                Return mBoneScale
            End Get
            Set(value As Single)
                mBoneScale = value
            End Set
        End Property
        Property HeadScale As Single
            Get
                Return mHeadScale
            End Get
            Set(value As Single)
                mHeadScale = value
            End Set
        End Property
        Property ShoulderScale As Single
            Get
                Return mShoulderScale
            End Get
            Set(value As Single)
                mShoulderScale = value
            End Set
        End Property
        Property ChestScale As Single
            Get
                Return mChestScale
            End Get
            Set(value As Single)
                mChestScale = value
            End Set
        End Property
        Property WaistScale As Single
            Get
                Return mWaistScale
            End Get
            Set(value As Single)
                mWaistScale = value
            End Set
        End Property
        Property HipScale As Single
            Get
                Return mHipScale
            End Get
            Set(value As Single)
                mHipScale = value
            End Set
        End Property
        Property LegScale As Single
            Get
                Return mLegScale
            End Get
            Set(value As Single)
                mLegScale = value
            End Set
        End Property
        Property ArmScale As Single
            Get
                Return mArmScale
            End Get
            Set(value As Single)
                mArmScale = value
            End Set
        End Property
        Property HeadScales As COH_Struct_Vector3
            Get
                Return mHeadScales
            End Get
            Set(value As COH_Struct_Vector3)
                mHeadScales = value
            End Set
        End Property
        Property BrowScales As COH_Struct_Vector3
            Get
                Return mBrowScales
            End Get
            Set(value As COH_Struct_Vector3)
                mBrowScales = value
            End Set
        End Property
        Property CheekScales As COH_Struct_Vector3
            Get
                Return mCheekScales
            End Get
            Set(value As COH_Struct_Vector3)
                mCheekScales = value
            End Set
        End Property
        Property ChinScales As COH_Struct_Vector3
            Get
                Return mChinScales
            End Get
            Set(value As COH_Struct_Vector3)
                mChinScales = value
            End Set
        End Property
        Property CraniumScales As COH_Struct_Vector3
            Get
                Return mCraniumScales
            End Get
            Set(value As COH_Struct_Vector3)
                mCraniumScales = value
            End Set
        End Property
        Property JawScales As COH_Struct_Vector3
            Get
                Return mJawScales
            End Get
            Set(value As COH_Struct_Vector3)
                mJawScales = value
            End Set
        End Property
        Property NoseScales As COH_Struct_Vector3
            Get
                Return mNoseScales
            End Get
            Set(value As COH_Struct_Vector3)
                mNoseScales = value
            End Set
        End Property
        Property SkinColor As COH_XML_Color
            Get
                Return mSkinColor
            End Get
            Set(value As COH_XML_Color)
                mSkinColor = value
            End Set
        End Property
        Property NumParts As Int32
            Get
                Return mNumParts
            End Get
            Set(value As Int32)
                mNumParts = value
            End Set
        End Property
        Property BodyType As Int32
            Get
                Return mBodyType
            End Get
            Set(value As Int32)
                mBodyType = value
            End Set
        End Property
        Property CostumePart As COH_CostumePart()
            Get
                Return mCostumePart
            End Get
            Set(value As COH_CostumePart())
                mCostumePart = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mEntTypeFile As String
       Private mCostumeFilePrefix As String
       Private mScale As Single
       Private mBoneScale As Single
       Private mHeadScale As Single
       Private mShoulderScale As Single
       Private mChestScale As Single
       Private mWaistScale As Single
       Private mHipScale As Single
       Private mLegScale As Single
       Private mArmScale As Single
       Private mHeadScales As COH_Struct_Vector3
       Private mBrowScales As COH_Struct_Vector3
       Private mCheekScales As COH_Struct_Vector3
       Private mChinScales As COH_Struct_Vector3
       Private mCraniumScales As COH_Struct_Vector3
       Private mJawScales As COH_Struct_Vector3
       Private mNoseScales As COH_Struct_Vector3
       Private mSkinColor As Drawing.Color
       Private mNumParts As Int32
       Private mBodyType As Int32
       Private mCostumePart As COH_CostumePart()
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
            mEntTypeFile = String.Empty
            mCostumeFilePrefix = String.Empty
            mScale = 0
            mBoneScale = 0
            mHeadScale = 0
            mShoulderScale = 0
            mChestScale = 0
            mWaistScale = 0
            mHipScale = 0
            mLegScale = 0
            mArmScale = 0
            mHeadScales = New COH_Struct_Vector3  ' No Default Defined
            mBrowScales = New COH_Struct_Vector3  ' No Default Defined
            mCheekScales = New COH_Struct_Vector3  ' No Default Defined
            mChinScales = New COH_Struct_Vector3  ' No Default Defined
            mCraniumScales = New COH_Struct_Vector3  ' No Default Defined
            mJawScales = New COH_Struct_Vector3 ' No Default Defined
            mNoseScales = New COH_Struct_Vector3  ' No Default Defined
            mSkinColor = New Drawing.Color  ' No Default Defined
            mNumParts = 0
            mBodyType = 0
            mCostumePart = New COH_CostumePart() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            For Each Part In mCostumePart
                Part.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Costume
            Dim Result As COH_Costume = New COH_Costume
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mEntTypeFile = String.Copy(mEntTypeFile)
                .mCostumeFilePrefix = String.Copy(mCostumeFilePrefix)
                .mScale = mScale
                .mBoneScale = mBoneScale
                .mHeadScale = mHeadScale
                .mShoulderScale = mShoulderScale
                .mChestScale = mChestScale
                .mWaistScale = mWaistScale
                .mHipScale = mHipScale
                .mLegScale = mLegScale
                .mArmScale = mArmScale
                .mHeadScales = mHeadScales
                .mBrowScales = mBrowScales
                .mCheekScales = mCheekScales
                .mChinScales = mChinScales
                .mCraniumScales = mCraniumScales
                .mJawScales = mJawScales
                .mNoseScales = mNoseScales
                .mSkinColor = mSkinColor
                .mNumParts = mNumParts
                .mBodyType = mBodyType
                .mCostumePart = New COH_CostumePart(mCostumePart.Count - 1) {}
                For X = 0 To mCostumePart.Count - 1
                    .mCostumePart(X) = mCostumePart(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mEntTypeFile)
            CurrentWriter.Write_CrypticS_String(mCostumeFilePrefix)
            CurrentWriter.Write(mScale)
            CurrentWriter.Write(mBoneScale)
            CurrentWriter.Write(mHeadScale)
            CurrentWriter.Write(mShoulderScale)
            CurrentWriter.Write(mChestScale)
            CurrentWriter.Write(mWaistScale)
            CurrentWriter.Write(mHipScale)
            CurrentWriter.Write(mLegScale)
            CurrentWriter.Write(mArmScale)
            CurrentWriter.Write_CrypticS_Vector3(mHeadScales)
            CurrentWriter.Write_CrypticS_Vector3(mBrowScales)
            CurrentWriter.Write_CrypticS_Vector3(mCheekScales)
            CurrentWriter.Write_CrypticS_Vector3(mChinScales)
            CurrentWriter.Write_CrypticS_Vector3(mCraniumScales)
            CurrentWriter.Write_CrypticS_Vector3(mJawScales)
            CurrentWriter.Write_CrypticS_Vector3(mNoseScales)
            CurrentWriter.Write_CrypticS_RGB(mSkinColor)
            CurrentWriter.Write(mNumParts)
            CurrentWriter.Write(mBodyType)
            If CurrentWriter.Write_CrypticS_StructArray(mCostumePart) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mEntTypeFile = CurrentReader.Read_CrypticS_String
            mCostumeFilePrefix = CurrentReader.Read_CrypticS_String
            mScale = CurrentReader.ReadSingle
            mBoneScale = CurrentReader.ReadSingle
            mHeadScale = CurrentReader.ReadSingle
            mShoulderScale = CurrentReader.ReadSingle
            mChestScale = CurrentReader.ReadSingle
            mWaistScale = CurrentReader.ReadSingle
            mHipScale = CurrentReader.ReadSingle
            mLegScale = CurrentReader.ReadSingle
            mArmScale = CurrentReader.ReadSingle
            mHeadScales = CurrentReader.Read_CrypticS_Vector3
            mBrowScales = CurrentReader.Read_CrypticS_Vector3
            mCheekScales = CurrentReader.Read_CrypticS_Vector3
            mChinScales = CurrentReader.Read_CrypticS_Vector3
            mCraniumScales = CurrentReader.Read_CrypticS_Vector3
            mJawScales = CurrentReader.Read_CrypticS_Vector3
            mNoseScales = CurrentReader.Read_CrypticS_Vector3
            mSkinColor = CurrentReader.Read_CrypticS_RGB
            mNumParts = CurrentReader.ReadInt32
            mBodyType = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumePart), mCostumePart) = False Then Return False
            Return True
        End Function
#End Region
    End Class
End Namespace
