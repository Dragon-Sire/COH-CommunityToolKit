Namespace GameContent.Structures.Textures
    Public NotInheritable Class COH_TextWord_Layer_Size
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Width & ", " & Height
            End Get
        End Property
#End Region

#Region "Properties"
        Property Width As Int32
            Get
                Return mWidth
            End Get
            Set(value As Int32)
                mWidth = value
            End Set
        End Property
        Property Height As Int32
            Get
                Return mHeight
            End Get
            Set(value As Int32)
                mHeight = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mWidth As Int32
       Private mHeight As Int32
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
        Public Function Clone() As COH_TextWord_Layer_Size
            Dim Result As COH_TextWord_Layer_Size = New COH_TextWord_Layer_Size
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mWidth = mWidth
                .mHeight = mHeight
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mWidth)
            CurrentWriter.Write(mHeight)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mWidth = CurrentReader.ReadInt32
            mHeight = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
