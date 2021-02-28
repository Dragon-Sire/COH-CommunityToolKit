Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_GEO_FOG
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "FOG"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Radius As Single
            Get
                Return mRadius
            End Get
            Set(value As Single)
                mRadius = value
            End Set
        End Property
        Property NearDistance As Single
            Get
                Return mNearDistance
            End Get
            Set(value As Single)
                mNearDistance = value
            End Set
        End Property
        Property FarDistance As Single
            Get
                Return mFarDistance
            End Get
            Set(value As Single)
                mFarDistance = value
            End Set
        End Property
        Property Color1 As COH_XML_Color
            Get
                Return mColor1
            End Get
            Set(value As COH_XML_Color)
                mColor1 = value
            End Set
        End Property
        Property Color2 As COH_XML_Color
            Get
                Return mColor2
            End Get
            Set(value As COH_XML_Color)
                mColor2 = value
            End Set
        End Property
        Property Speed As Single
            Get
                Return mSpeed
            End Get
            Set(value As Single)
                mSpeed = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mRadius As Single
       Private mNearDistance As Single
       Private mFarDistance As Single
       Private mColor1 As Drawing.Color
       Private mColor2 As Drawing.Color
       Private mSpeed As Single
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
            mRadius = 0
            mNearDistance = 0
            mFarDistance = 0
            mColor1 = New Drawing.Color
            mColor2 = New Drawing.Color
            mSpeed = 1.0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_GEO_FOG
            Dim Result As COH_GEO_FOG = New COH_GEO_FOG
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mRadius = mRadius
                .mNearDistance = mNearDistance
                .mFarDistance = mFarDistance
                .mColor1 = mColor1
                .mColor2 = mColor2
                .mSpeed = mSpeed
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mRadius)
            CurrentWriter.Write(mNearDistance)
            CurrentWriter.Write(mFarDistance)
            CurrentWriter.Write_CrypticS_RGB(mColor1)
            CurrentWriter.Write_CrypticS_RGB(mColor2)
            CurrentWriter.Write(mSpeed)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mRadius = CurrentReader.ReadSingle
            mNearDistance = CurrentReader.ReadSingle
            mFarDistance = CurrentReader.ReadSingle
            mColor1 = CurrentReader.Read_CrypticS_RGB
            mColor2 = CurrentReader.Read_CrypticS_RGB
            mSpeed = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
