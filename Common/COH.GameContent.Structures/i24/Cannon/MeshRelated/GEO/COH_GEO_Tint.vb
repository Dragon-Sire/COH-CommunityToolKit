Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_GEO_Tint
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Tint"
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
        Property Color2 As COH_XML_Color
            Get
                Return mColor2
            End Get
            Set(value As COH_XML_Color)
                mColor2 = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mColor1 As Drawing.Color
       Private mColor2 As Drawing.Color
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
            mColor2 = New Drawing.Color
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_GEO_Tint
            Dim Result As COH_GEO_Tint = New COH_GEO_Tint
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mColor1 = mColor1
                .mColor2 = mColor2
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_RGB(mColor1)
            CurrentWriter.Write_CrypticS_RGB(mColor2)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mColor1 = CurrentReader.Read_CrypticS_RGB()
            mColor2 = CurrentReader.Read_CrypticS_RGB()
            Return True
        End Function
#End Region

    End Class
End Namespace
