Namespace GameContent.Structures.Textures
    Public NotInheritable Class COH_TexWord_Layer_Offset
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Offset1 & ", " & Offset2
            End Get
        End Property
#End Region

#Region "Properties"
        Property Offset1 As Int32
            Get
                Return mOffset1
            End Get
            Set(value As Int32)
                mOffset1 = value
            End Set
        End Property
        Property Offset2 As Int32
            Get
                Return mOffset2
            End Get
            Set(value As Int32)
                mOffset2 = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mOffset1 As Int32
       Private mOffset2 As Int32
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
        Public Function Clone() As COH_TexWord_Layer_Offset
            Dim Result As COH_TexWord_Layer_Offset = New COH_TexWord_Layer_Offset
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mOffset1 = mOffset1
                .mOffset2 = mOffset2
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mOffset1)
            CurrentWriter.Write(mOffset2)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mOffset1 = CurrentReader.ReadInt32
            mOffset2 = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
