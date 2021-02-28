Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_GEO_Omni
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Omni"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Color1 As COH_XML_Color
            Get
                Return mColor1
            End Get
            Set(value As COH_XML_Color)
                mColor1 = value
            End Set
        End Property
        Property Radius As Single
            Get
                Return mRadius
            End Get
            Set(value As Single)
                mRadius = value
            End Set
        End Property
        Property Flags As COH_Enum_OmniLightFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_OmniLightFlags)
                mFlags = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mColor1 As Drawing.Color
       Private mRadius As Single
       Private mFlags As COH_Enum_OmniLightFlags
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
            mColor1 = New Drawing.Color
            mRadius = 0
            mFlags = COH_Enum_OmniLightFlags.Negative
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_GEO_Omni
            Dim Result As COH_GEO_Omni = New COH_GEO_Omni
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mColor1 = mColor1
                .mRadius = mRadius
                .mFlags = mFlags
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_RGB(mColor1)
            CurrentWriter.Write(mRadius)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mColor1 = CurrentReader.Read_CrypticS_RGB
            mRadius = CurrentReader.ReadSingle
            mFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace
