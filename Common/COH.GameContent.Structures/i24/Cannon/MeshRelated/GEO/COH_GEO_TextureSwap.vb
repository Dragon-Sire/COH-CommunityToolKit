Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_GEO_TextureSwap
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return TextureName
            End Get
        End Property
#End Region

#Region "Properties"
        Property TextureName As String
            Get
                Return mTextureName
            End Get
            Set(value As String)
                mTextureName = value
            End Set
        End Property
        Property ReplacementName As String
            Get
                Return mReplacementName
            End Get
            Set(value As String)
                mReplacementName = value
            End Set
        End Property
        Property Composite As Int32
            Get
                Return mComposite
            End Get
            Set(value As Int32)
                mComposite = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTextureName As String
       Private mReplacementName As String
       Private mComposite As Int32
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
            mTextureName = String.Empty
            mReplacementName = String.Empty
            mComposite = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_GEO_TextureSwap
            Dim Result As COH_GEO_TextureSwap = New COH_GEO_TextureSwap
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTextureName = String.Copy(mTextureName)
                .mReplacementName = String.Copy(mReplacementName)
                .mComposite = mComposite
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mTextureName)
            CurrentWriter.Write_CrypticS_String(mReplacementName)
            CurrentWriter.Write(mComposite)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTextureName = CurrentReader.Read_CrypticS_String
            mReplacementName = CurrentReader.Read_CrypticS_String
            mComposite = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace

