Imports COH.GameContent.Structures.Costumes.Mesh
Imports COH.GameContent.Structures.Costumes.Textures

Namespace GameContent.Structures.Costumes
    Public NotInheritable Class COH_CostumeOrigin
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
        Property BodyPalette As COH_ColorPalette()
            Get
                Return mBodyPalette
            End Get
            Set(value As COH_ColorPalette())
                mBodyPalette = value
            End Set
        End Property
        Property SkinPalette As COH_ColorPalette()
            Get
                Return mSkinPalette
            End Get
            Set(value As COH_ColorPalette())
                mSkinPalette = value
            End Set
        End Property
        Property PowerPalette As COH_ColorPalette()
            Get
                Return mPowerPalette
            End Get
            Set(value As COH_ColorPalette())
                mPowerPalette = value
            End Set
        End Property
        Property Region As COH_CostumeRegion()
            Get
                Return mRegion
            End Get
            Set(value As COH_CostumeRegion())
                mRegion = value
            End Set
        End Property
        Property CostumeSet As COH_CostumeSet_Set()
            Get
                Return mCostumeSet
            End Get
            Set(value As COH_CostumeSet_Set())
                mCostumeSet = value
            End Set
        End Property
        Property GeoData As COH_CostumeGeoData()
            Get
                Return mGeoData
            End Get
            Set(value As COH_CostumeGeoData())
                mGeoData = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mFilename As String
       Private mBodyPalette As COH_ColorPalette()
       Private mSkinPalette As COH_ColorPalette()
       Private mPowerPalette As COH_ColorPalette()
       Private mRegion As COH_CostumeRegion()
       Private mCostumeSet As COH_CostumeSet_Set()
       Private mGeoData As COH_CostumeGeoData()
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
            mBodyPalette = New COH_ColorPalette() {}
            mSkinPalette = New COH_ColorPalette() {}
            mPowerPalette = New COH_ColorPalette() {}
            mRegion = New COH_CostumeRegion() {}
            mCostumeSet = New COH_CostumeSet_Set() {}
            mGeoData = New COH_CostumeGeoData() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            For Each TheRegion In mRegion
                TheRegion.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeOrigin
            Dim Result As COH_CostumeOrigin = New COH_CostumeOrigin
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFilename = String.Copy(mFilename)
                .mBodyPalette = New COH_ColorPalette(mBodyPalette.Count - 1) {}
                For X = 0 To mBodyPalette.Count - 1
                    .mBodyPalette(X) = mBodyPalette(X).Clone
                Next
                .mSkinPalette = New COH_ColorPalette(mSkinPalette.Count - 1) {}
                For X = 0 To mSkinPalette.Count - 1
                    .mSkinPalette(X) = mSkinPalette(X).Clone
                Next
                .mPowerPalette = New COH_ColorPalette(mPowerPalette.Count - 1) {}
                For X = 0 To mPowerPalette.Count - 1
                    .mPowerPalette(X) = mPowerPalette(X).Clone
                Next
                .mRegion = New COH_CostumeRegion(mRegion.Count - 1) {}
                For X = 0 To mRegion.Count - 1
                    .mRegion(X) = mRegion(X).Clone
                Next
                .mCostumeSet = New COH_CostumeSet_Set(mCostumeSet.Count - 1) {}
                For X = 0 To mCostumeSet.Count - 1
                    .mCostumeSet(X) = mCostumeSet(X).Clone
                Next
                .mGeoData = New COH_CostumeGeoData(mGeoData.Count - 1) {}
                For X = 0 To mGeoData.Count - 1
                    .mGeoData(X) = mGeoData(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mFilename)
            If CurrentWriter.Write_CrypticS_StructArray(mBodyPalette) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mSkinPalette) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mPowerPalette) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mRegion) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mCostumeSet) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mGeoData) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mFilename = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_ColorPalette), mBodyPalette) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_ColorPalette), mSkinPalette) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_ColorPalette), mPowerPalette) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumeRegion), mRegion) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumeSet_Set), mCostumeSet) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumeGeoData), mGeoData) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
