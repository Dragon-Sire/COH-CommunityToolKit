Namespace GameContent.Structures.Textures
    Public NotInheritable Class COH_TextWord_Layer_DropShadow
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return X & " ," & Y
            End Get
        End Property
#End Region

#Region "Properties"
        Property X As Byte
            Get
                Return mX
            End Get
            Set(value As Byte)
                mX = value
            End Set
        End Property
        Property Y As Byte
            Get
                Return mY
            End Get
            Set(value As Byte)
                mY = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mX As Byte
       Private mY As Byte
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
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_TextWord_Layer_DropShadow
            Dim Result As COH_TextWord_Layer_DropShadow = New COH_TextWord_Layer_DropShadow
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mX = mX
                .mY = mY
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mX)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mY)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mX = CurrentReader.Read_CrypticS_Byte_Aligned4
            mY = CurrentReader.Read_CrypticS_Byte_Aligned4
            Return True
        End Function
#End Region

    End Class
End Namespace
