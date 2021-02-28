Namespace GameContent.Structures.Animation.FX
    Public NotInheritable Class COH_FX_Event_Splat
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Splat"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Texture1 As String
            Get
                Return mTexture1
            End Get
            Set(value As String)
                mTexture1 = value
            End Set
        End Property
        Property Texture2 As String
            Get
                Return mTexture2
            End Get
            Set(value As String)
                mTexture2 = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTexture1 As String
       Private mTexture2 As String
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings as COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings as COH_Serialization_Settings = Nothing)
             MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
             MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mTexture1 = String.Empty
            mTexture2 = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_FX_Event_Splat
            Dim Result As COH_FX_Event_Splat = New COH_FX_Event_Splat
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTexture1 = String.Copy(mTexture1)
                .mTexture2 = String.Copy(mTexture2)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mTexture1)
            CurrentWriter.Write_CrypticS_String(mTexture2)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTexture1 = CurrentReader.Read_CrypticS_String
            mTexture2 = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
