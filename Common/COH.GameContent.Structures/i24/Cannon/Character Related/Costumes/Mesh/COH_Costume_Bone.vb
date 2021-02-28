Namespace GameContent.Structures.Costumes.Mesh
    Public NotInheritable Class COH_CostumeBone
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
        Property Filename As String
            Get
                Return mFilename
            End Get
            Set(value As String)
                mFilename = value
            End Set
        End Property
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
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
        '    End Get
        'Set(value As String())
        '        mInternalProducts = value
        'End Set
        'End Property
        Property Flags As String()
            Get
                Return mFlags
            End Get
            Set(value As String())
                mFlags = value
            End Set
        End Property
        Property GeoSet As COH_CostumeGeoSet()
            Get
                Return mGeoSet
            End Get
            Set(value As COH_CostumeGeoSet())
                mGeoSet = value
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
       Private mName As String
       Private mFilename As String
       Private mDisplayName As String
       Private mDisplayNameKey As String
       Private mKeys As String()
       Private mProduct As String
        '<EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mInternalProducts As String()
       Private mFlags As String()
       Private mGeoSet As COH_CostumeGeoSet()
       Private mLegacy As Int32
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
            mName = String.Empty
            mFilename = String.Empty
            mDisplayName = String.Empty
            mDisplayNameKey = String.Empty
            mKeys = New String() {}
            mProduct = String.Empty
            'mInternalProducts = New String() {}
            mFlags = New String() {}
            mGeoSet = New COH_CostumeGeoSet() {}
            mLegacy = 0
            mCOV = 0
            mCOH = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            For Each TheGeo In mGeoSet
                TheGeo.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeBone
            Dim Result As COH_CostumeBone = New COH_CostumeBone
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFilename = String.Copy(mFilename)
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayNameKey = String.Copy(mDisplayName)
                .mKeys = mKeys.CloneTheStrings
                .mProduct = String.Copy(mProduct)
                '.mInternalProducts = mInternalProducts.CloneTheStrings
                .mFlags = mFlags.CloneTheStrings
                .mGeoSet = New COH_CostumeGeoSet(mGeoSet.Count - 1) {}
                For X = 0 To mGeoSet.Count - 1
                    .mGeoSet(X) = mGeoSet(X).Clone
                Next
                .mLegacy = mLegacy
                .mCOV = mCOV
                .mCOH = mCOH
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mFilename)
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_StringArray(mKeys)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mKey)
            CurrentWriter.Write_CrypticS_String(mProduct)
            'CurrentWriter.Write_CrypticS_StringArray(mInternalProducts)
            CurrentWriter.Write_CrypticS_StringArray(mFlags)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_StringArray(mFlag)
            If CurrentWriter.Write_CrypticS_StructArray(mGeoSet) = False Then Return False
            CurrentWriter.Write(mLegacy)
            CurrentWriter.Write(mCOV)
            CurrentWriter.Write(mCOH)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mFilename = CurrentReader.Read_CrypticS_String
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mKeys = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mKey = CurrentReader.Read_CrypticS_StringArray()
            mProduct = CurrentReader.Read_CrypticS_String
            '//mInternalProducts = CurrentReader.Read_CrypticS_StringArray()
            mFlags = CurrentReader.Read_CrypticS_StringArray()
            '!!REDUNDENT!!mFlag = CurrentReader.Read_CrypticS_StringArray()
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumeGeoSet), mGeoSet) = False Then Return False
            mLegacy = CurrentReader.ReadInt32
            mCOV = CurrentReader.ReadInt32
            mCOH = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
