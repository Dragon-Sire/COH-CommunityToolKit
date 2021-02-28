Namespace GameContent.Structures.Costumes.NPC
    Public NotInheritable Class COH_CostumeNPC_Part
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Region
            End Get
        End Property
#End Region

#Region "Properties"
        Property Region As String
            Get
                Return mRegion
            End Get
            Set(value As String)
                mRegion = value
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
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mRegion As String
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
            mRegion = String.Empty
            mColor1 = New Drawing.Color  ' No Default Defined
            mColor2 = New Drawing.Color  ' No Default Defined
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeNPC_Part
            Dim Result As COH_CostumeNPC_Part = New COH_CostumeNPC_Part
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mRegion = String.Copy(mRegion)
                .mColor1 = mColor1
                .mColor2 = mColor2
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mRegion)
            CurrentWriter.Write_CrypticS_RGB(mColor1)
            CurrentWriter.Write_CrypticS_RGB(mColor2)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mRegion = CurrentReader.Read_CrypticS_String
            mColor1 = CurrentReader.Read_CrypticS_RGB
            mColor2 = CurrentReader.Read_CrypticS_RGB
            Return True
        End Function
#End Region

    End Class
End Namespace
