Namespace GameContent.Structures.Costumes
    Public NotInheritable Class COH_CostumeTxtSet
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
        Property GeoName As String
            Get
                Return mGeoName
            End Get
            Set(value As String)
                mGeoName = value
            End Set
        End Property
        Property Geo As String
            Get
                Return mGeo
            End Get
            Set(value As String)
                mGeo = value
            End Set
        End Property
        Property Tex1 As String
            Get
                Return mTex1
            End Get
            Set(value As String)
                mTex1 = value
            End Set
        End Property
        Property Tex2 As String
            Get
                Return mTex2
            End Get
            Set(value As String)
                mTex2 = value
            End Set
        End Property
        Property Fx As String
            Get
                Return mFx
            End Get
            Set(value As String)
                mFx = value
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
        '        mInternalProducts = value
        'End Set
        'End Property
        Property Keys As String()
            Get
                Return mKeys
            End Get
            Set(value As String())
                mKeys = value
            End Set
        End Property
        Property Tag As String()
            Get
                Return mTag
            End Get
            Set(value As String())
                mTag = value
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
        Property DevOnly As Int32
            Get
                Return mDevOnly
            End Get
            Set(value As Int32)
                mDevOnly = value
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
        Property COHV As Int32
            Get
                Return mCOHV
            End Get
            Set(value As Int32)
                mCOHV = value
            End Set
        End Property
        Property IsMask As Int32
            Get
                Return mIsMask
            End Get
            Set(value As Int32)
                mIsMask = value
            End Set
        End Property
        Property Level As Int32
            Get
                Return mLevel
            End Get
            Set(value As Int32)
                mLevel = value
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
       Private mGeoName As String
       Private mGeo As String
       Private mTex1 As String
       Private mTex2 As String
       Private mFx As String
       Private mProduct As String
        'Private mInternalProducts As String()
       Private mKeys As String()
       Private mTag As String()
       Private mFlags As String()
       Private mDevOnly As Int32
       Private mCOV As Int32
       Private mCOH As Int32
       Private mCOHV As Int32
       Private mIsMask As Int32
       Private mLevel As Int32
       Private mLegacy As Int32
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
            mGeoName = String.Empty
            mGeo = String.Empty
            mTex1 = String.Empty
            mTex2 = String.Empty
            mFx = String.Empty
            mProduct = String.Empty
            ' mInternalProducts = New String() {}
            mKeys = New String() {}
            mTag = New String() {}
            mFlags = New String() {}
            mDevOnly = 0
            mCOV = 0
            mCOH = 0
            mCOHV = 0
            mIsMask = 0
            mLevel = 0
            mLegacy = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeTxtSet
            Dim Result As COH_CostumeTxtSet = New COH_CostumeTxtSet
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mGeoName = String.Copy(mGeoName)
                .mGeo = String.Copy(mGeo)
                .mTex1 = String.Copy(mTex1)
                .mTex2 = String.Copy(mTex2)
                .mFx = String.Copy(mFx)
                .mProduct = String.Copy(mProduct)
                '.mInternalProducts = mInternalProducts.CloneTheStrings
                .mKeys = mKeys.CloneTheStrings
                .mTag = mTag.CloneTheStrings
                .mFlags = mFlags.CloneTheStrings
                .mDevOnly = mDevOnly
                .mCOV = mCOV
                .mCOH = mCOH
                .mCOHV = mCOHV
                .mIsMask = mIsMask
                .mLevel = mLevel
                .mLegacy = mLegacy
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_String(mGeoName)
            CurrentWriter.Write_CrypticS_String(mGeo)
            CurrentWriter.Write_CrypticS_String(mTex1)
            CurrentWriter.Write_CrypticS_String(mTex2)
            CurrentWriter.Write_CrypticS_String(mFx)
            CurrentWriter.Write_CrypticS_String(mProduct)
            ' CurrentWriter.Write_CrypticS_StringArray(mInternalProducts)
            CurrentWriter.Write_CrypticS_StringArray(mKeys)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mKey)
            CurrentWriter.Write_CrypticS_StringArray(mTag)
            CurrentWriter.Write_CrypticS_StringArray(mFlags)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mFlag)
            CurrentWriter.Write(mDevOnly)
            CurrentWriter.Write(mCOV)
            CurrentWriter.Write(mCOH)
            CurrentWriter.Write(mCOHV)
            CurrentWriter.Write(mIsMask)
            CurrentWriter.Write(mLevel)
            CurrentWriter.Write(mLegacy)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mGeoName = CurrentReader.Read_CrypticS_String
            mGeo = CurrentReader.Read_CrypticS_String
            mTex1 = CurrentReader.Read_CrypticS_String
            mTex2 = CurrentReader.Read_CrypticS_String
            mFx = CurrentReader.Read_CrypticS_String
            mProduct = CurrentReader.Read_CrypticS_String
            ' mInternalProducts = CurrentReader.Read_CrypticS_StringArray()
            mKeys = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mKey = CurrentReader.Read_CrypticS_StringArray()
            mTag = CurrentReader.Read_CrypticS_StringArray()
            mFlags = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mFlag = CurrentReader.Read_CrypticS_StringArray()
            mDevOnly = CurrentReader.ReadInt32
            mCOV = CurrentReader.ReadInt32
            mCOH = CurrentReader.ReadInt32
            mCOHV = CurrentReader.ReadInt32
            mIsMask = CurrentReader.ReadInt32
            mLevel = CurrentReader.ReadInt32
            mLegacy = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
