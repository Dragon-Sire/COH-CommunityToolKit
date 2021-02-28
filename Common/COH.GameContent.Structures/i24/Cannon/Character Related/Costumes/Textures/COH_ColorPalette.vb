Namespace GameContent.Structures.Costumes.Textures
    Public NotInheritable Class COH_ColorPalette
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Color As COH_COLOR()
            Get
                Return mColor
            End Get
            Set(value As COH_COLOR())
                mColor = value
            End Set
        End Property
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mColor As COH_COLOR()
       Private mName As String
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
            mColor = New COH_Color() {}
            mName = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ColorPalette
            Dim Result As COH_ColorPalette = New COH_ColorPalette
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mColor = New COH_COLOR(mColor.Count - 1) {}
                For X = 0 To mColor.Count - 1
                    .mColor(X) = mColor(X).Clone
                Next
                .mName = String.Copy(mName)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Write_CrypticS_StructArray(mColor) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mName)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Color), mColor) = False Then Return False
            mName = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
