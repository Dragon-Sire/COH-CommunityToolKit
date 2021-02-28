Imports System.Xml.Serialization

Namespace GameContent.Structures.Costumes.Textures
    Public NotInheritable Class COH_Color
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Color"
            End Get
        End Property
#End Region

#Region "Properties"
        <XmlAttribute> Property Color1 As Single
            Get
                Return mColor1
            End Get
            Set(value As Single)
                mColor1 = value
            End Set
        End Property
        <XmlAttribute> Property Color2 As Single
            Get
                Return mColor2
            End Get
            Set(value As Single)
                mColor2 = value
            End Set
        End Property
        <XmlAttribute> Property Color3 As Single
            Get
                Return mColor3
            End Get
            Set(value As Single)
                mColor3 = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mColor1 As Single
       Private mColor2 As Single
       Private mColor3 As Single
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
            mColor1 = 0
            mColor2 = 0
            mColor3 = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Color
            Dim Result As COH_Color = New COH_Color
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mColor1 = mColor1
                .mColor2 = mColor2
                .mColor3 = mColor3
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mColor1)
            CurrentWriter.Write(mColor2)
            CurrentWriter.Write(mColor3)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mColor1 = CurrentReader.ReadSingle
            mColor2 = CurrentReader.ReadSingle
            mColor3 = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
