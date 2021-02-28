Namespace GameContent.Structures.Costumes
    Public NotInheritable Class COH_CostumeMaskSet
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
        Property displayName As String
            Get
                Return mdisplayName
            End Get
            Set(value As String)
                mdisplayName = value
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
        Property Product As String
            Get
                Return mProduct
            End Get
            Set(value As String)
                mProduct = value
            End Set
        End Property
        'Property InternalProducts As String()
        'Get
        'Return mInternalProducts
        'End Get
        'Set(value As String())
        '        mInternalProducts = value
        'End Set
        'End Property
        Property Tag As String()
            Get
                Return mTag
            End Get
            Set(value As String())
                mTag = value
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
#End Region

#Region "Properties - Localized"
        Property DisplayNameKey As String
            Get
                Return mdisplayNameKey
            End Get
            Set(value As String)
                mdisplayNameKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mdisplayName As String
       Private mdisplayNameKey As String
       Private mKeys As String()
       Private mProduct As String
        ''Private mInternalProducts As String()
       Private mTag As String()
       Private mLegacy As Int32
       Private mDevOnly As Int32
       Private mCOV As Int32
       Private mCOH As Int32
       Private mCOHV As Int32
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
            mdisplayName = String.Empty
            mdisplayNameKey = String.Empty
            mKeys = New String() {}
            mProduct = String.Empty
            ' mInternalProducts = New String() {}
            mTag = New String() {}
            mLegacy = 0
            mDevOnly = 0
            mCOV = 0
            mCOH = 0
            mCOHV = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mdisplayName = LocalizeController.RetrieveLocalizedString(mdisplayNameKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeMaskSet
            Dim Result As COH_CostumeMaskSet = New COH_CostumeMaskSet
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mdisplayName = String.Copy(mdisplayName)
                .mdisplayNameKey = String.Copy(mdisplayNameKey)
                .mKeys = mKeys.CloneTheStrings
                .mProduct = String.Copy(mProduct)
                ' .mInternalProducts = mInternalProducts.CloneTheStrings
                .mTag = mTag.CloneTheStrings
                .mLegacy = mLegacy
                .mDevOnly = mDevOnly
                .mCOV = mCOV
                .mCOH = mCOH
                .mCOHV = mCOHV
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mdisplayNameKey)
            CurrentWriter.Write_CrypticS_StringArray(mKeys)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mKey)
            CurrentWriter.Write_CrypticS_String(mProduct)
            'CurrentWriter.Write_CrypticS_StringArray(mInternalProducts)
            CurrentWriter.Write_CrypticS_StringArray(mTag)
            CurrentWriter.Write(mLegacy)
            CurrentWriter.Write(mDevOnly)
            CurrentWriter.Write(mCOV)
            CurrentWriter.Write(mCOH)
            CurrentWriter.Write(mCOHV)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mdisplayNameKey = CurrentReader.Read_CrypticS_String
            mKeys = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mKey = CurrentReader.Read_CrypticS_StringArray()
            mProduct = CurrentReader.Read_CrypticS_String
            'mInternalProducts = CurrentReader.Read_CrypticS_StringArray()
            mTag = CurrentReader.Read_CrypticS_StringArray()
            mLegacy = CurrentReader.ReadInt32
            mDevOnly = CurrentReader.ReadInt32
            mCOV = CurrentReader.ReadInt32
            mCOH = CurrentReader.ReadInt32
            mCOHV = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
