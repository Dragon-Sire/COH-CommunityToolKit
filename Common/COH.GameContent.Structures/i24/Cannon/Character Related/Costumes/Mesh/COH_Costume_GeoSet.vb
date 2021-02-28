Namespace GameContent.Structures.Costumes.Mesh
    Public NotInheritable Class COH_CostumeGeoSet
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return DisplayName
            End Get
        End Property
#End Region

#Region "Properties"
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property BodyPart As String
            Get
                Return mBodyPart
            End Get
            Set(value As String)
                mBodyPart = value
            End Set
        End Property
        Property ColorLink As String
            Get
                Return mColorLink
            End Get
            Set(value As String)
                mColorLink = value
            End Set
        End Property
        Property Keys As String()
            Get
                Return mKeys
            End Get
            Set(value As String())
                mKeys = value
            End Set
        End Property
        Property Flags As String()
            Get
                Return mFlags
            End Get
            Set(value As String())
                mFlags = value
            End Set
        End Property
        Property Product As String
            Get
                Return mProduct
            End Get
            Set(value As String)
                mProduct = value
            End Set
        End Property
        ' Property InternalProducts As String()
        'Get
        'Return mInternalProducts
        'End Get
        'Set(value As String())
        '       mInternalProducts = value
        'End Set
        ' End Property
        Property Type As Int32
            Get
                Return mType
            End Get
            Set(value As Int32)
                mType = value
            End Set
        End Property
        Property AnimBits As String()
            Get
                Return mAnimBits
            End Get
            Set(value As String())
                mAnimBits = value
            End Set
        End Property
        Property ZoomBits As String()
            Get
                Return mZoomBits
            End Get
            Set(value As String())
                mZoomBits = value
            End Set
        End Property
        Property DefaultView As COH_Struct_Vector3
            Get
                Return mDefaultView
            End Get
            Set(value As COH_Struct_Vector3)
                mDefaultView = value
            End Set
        End Property
        Property ZoomView As COH_Struct_Vector3
            Get
                Return mZoomView
            End Get
            Set(value As COH_Struct_Vector3)
                mZoomView = value
            End Set
        End Property
        Property FourColor As Int32
            Get
                Return mFourColor
            End Get
            Set(value As Int32)
                mFourColor = value
            End Set
        End Property
        Property NoDisplay As Int32
            Get
                Return mNoDisplay
            End Get
            Set(value As Int32)
                mNoDisplay = value
            End Set
        End Property
        Property Info As COH_CostumeTxtSet()
            Get
                Return mInfo
            End Get
            Set(value As COH_CostumeTxtSet())
                mInfo = value
            End Set
        End Property
        Property Mask As COH_CostumeMaskSet()
            Get
                Return mMask
            End Get
            Set(value As COH_CostumeMaskSet())
                mMask = value
            End Set
        End Property
        Property Masks As String()
            Get
                Return mMasks
            End Get
            Set(value As String())
                mMasks = value
            End Set
        End Property
        Property MaskNames As String()
            Get
                Return mMaskNames
            End Get
            Set(value As String())
                mMaskNames = value
            End Set
        End Property
        Property Legacy As Int32
            Get
                Return mLegacy
            End Get
            Set(value As Int32)
                mLegacy = value
            End Set
        End Property
        Property Face As COH_CostumeFaceScale()
            Get
                Return mFace
            End Get
            Set(value As COH_CostumeFaceScale())
                mFace = value
            End Set
        End Property
        Property COV As Int32
            Get
                Return mCOV
            End Get
            Set(value As Int32)
                mCOV = value
            End Set
        End Property
        Property COH As Int32
            Get
                Return mCOH
            End Get
            Set(value As Int32)
                mCOH = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
        Property DisplayNameKey As String
            Get
                Return mDisplayNameKey
            End Get
            Set(value As String)
                mDisplayNameKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mDisplayName As String
       Private mDisplayNameKey As String
       Private mBodyPart As String
       Private mColorLink As String
       Private mKeys As String()
       Private mFlags As String()
       Private mProduct As String
        '<EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mInternalProducts As String()
       Private mType As Int32
       Private mAnimBits As String()
       Private mZoomBits As String()
       Private mDefaultView As COH_Struct_Vector3
       Private mZoomView As COH_Struct_Vector3
       Private mFourColor As Int32
       Private mNoDisplay As Int32
       Private mInfo As COH_CostumeTxtSet()
       Private mMask As COH_CostumeMaskSet()
       Private mMasks As String()
       Private mMaskNames As String()
       Private mLegacy As Int32
       Private mFace As COH_CostumeFaceScale()
       Private mCOV As Int32
       Private mCOH As Int32
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
            mDisplayName = String.Empty
            mDisplayNameKey = String.Empty
            mBodyPart = String.Empty
            mColorLink = String.Empty
            mKeys = New String() {}
            mFlags = New String() {}
            mProduct = String.Empty
            ' mInternalProducts = New String() {}
            mType = 0
            mAnimBits = New String() {}
            mZoomBits = New String() {}
            mDefaultView = New COH_Struct_Vector3  ' No Default Defined
            mZoomView = New COH_Struct_Vector3  ' No Default Defined
            mFourColor = 0
            mNoDisplay = 0
            mInfo = New COH_CostumeTxtSet() {}
            mMask = New COH_CostumeMaskSet() {}
            mMasks = New String() {}
            mMaskNames = New String() {}
            mLegacy = 0
            mFace = New COH_CostumeFaceScale() {}
            mCOV = 0
            mCOH = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            For Each TheInfo In mInfo
                TheInfo.UpdateLocalizations(LocalizeController)
            Next
            For Each TheMask In mMask
                TheMask.UpdateLocalizations(LocalizeController)
            Next
            For Each TheFace In mFace
                TheFace.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeGeoSet
            Dim Result As COH_CostumeGeoSet = New COH_CostumeGeoSet
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mBodyPart = String.Copy(mBodyPart)
                .mColorLink = String.Copy(mColorLink)
                .mKeys = mKeys.CloneTheStrings
                .mFlags = mFlags.CloneTheStrings
                .mProduct = String.Copy(mProduct)
                ' .mInternalProducts = mInternalProducts.CloneTheStrings
                .mType = mType
                .mAnimBits = mAnimBits.CloneTheStrings
                .mZoomBits = mZoomBits.CloneTheStrings
                .mDefaultView = mDefaultView
                .mZoomView = mZoomView
                .mFourColor = mFourColor
                .mNoDisplay = mNoDisplay
                .mInfo = New COH_CostumeTxtSet(mInfo.Count - 1) {}
                For X = 0 To mInfo.Count - 1
                    .mInfo(X) = mInfo(X).Clone
                Next
                .mMask = New COH_CostumeMaskSet(mMask.Count - 1) {}
                For X = 0 To mMask.Count - 1
                    .mMask(X) = mMask(X).Clone
                Next
                .mMasks = mMasks.CloneTheStrings
                .mMaskNames = mMaskNames.CloneTheStrings
                .mLegacy = mLegacy
                .mFace = New COH_CostumeFaceScale(mFace.Count - 1) {}
                For X = 0 To mFace.Count - 1
                    .mFace(X) = mFace(X).Clone
                Next
                .mCOV = mCOV
                .mCOH = mCOH
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_String(mBodyPart)
            CurrentWriter.Write_CrypticS_String(mColorLink)
            CurrentWriter.Write_CrypticS_StringArray(mKeys)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mKey)
            CurrentWriter.Write_CrypticS_StringArray(mFlags)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mFlag)
            CurrentWriter.Write_CrypticS_String(mProduct)
            '//CurrentWriter.Write_CrypticS_StringArray(mInternalProducts)
            CurrentWriter.Write(mType)
            CurrentWriter.Write_CrypticS_StringArray(mAnimBits)
            CurrentWriter.Write_CrypticS_StringArray(mZoomBits)
            CurrentWriter.Write_CrypticS_Vector3(mDefaultView)
            CurrentWriter.Write_CrypticS_Vector3(mZoomView)
            CurrentWriter.Write(mFourColor)
            '!!REDUNDENT!!CurrentWriter.Write(mNumColor)
            CurrentWriter.Write(mNoDisplay)
            If CurrentWriter.Write_CrypticS_StructArray(mInfo) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mMask) = False Then Return False
            CurrentWriter.Write_CrypticS_StringArray(mMasks)
            CurrentWriter.Write_CrypticS_StringArray(mMaskNames)
            CurrentWriter.Write(mLegacy)
            If CurrentWriter.Write_CrypticS_StructArray(mFace) = False Then Return False
            CurrentWriter.Write(mCOV)
            CurrentWriter.Write(mCOH)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mBodyPart = CurrentReader.Read_CrypticS_String
            mColorLink = CurrentReader.Read_CrypticS_String
            mKeys = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mKey = CurrentReader.Read_CrypticS_StringArray()
            mFlags = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mFlag = CurrentReader.Read_CrypticS_StringArray()
            mProduct = CurrentReader.Read_CrypticS_String
            ''/mInternalProducts = CurrentReader.Read_CrypticS_StringArray()
            mType = CurrentReader.ReadInt32
            mAnimBits = CurrentReader.Read_CrypticS_StringArray()
            mZoomBits = CurrentReader.Read_CrypticS_StringArray()
            mDefaultView = CurrentReader.Read_CrypticS_Vector3
            mZoomView = CurrentReader.Read_CrypticS_Vector3
            mFourColor = CurrentReader.ReadInt32
            '!!REDUNDENT!!mNumColor = CurrentReader.ReadInt32
            mNoDisplay = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumeTxtSet), mInfo) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumeMaskSet), mMask) = False Then Return False
            mMasks = CurrentReader.Read_CrypticS_StringArray()
            mMaskNames = CurrentReader.Read_CrypticS_StringArray()
            mLegacy = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumeFaceScale), mFace) = False Then Return False
            mCOV = CurrentReader.ReadInt32
            mCOH = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
