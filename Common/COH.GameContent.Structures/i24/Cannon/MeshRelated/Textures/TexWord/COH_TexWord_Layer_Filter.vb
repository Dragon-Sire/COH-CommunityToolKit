Namespace GameContent.Structures.Textures
    Public NotInheritable Class COH_TexWord_Layer_Filter
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Filter"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Type As Int32
            Get
                Return mType
            End Get
            Set(value As Int32)
                mType = value
            End Set
        End Property
        Property Magnitude As Int32
            Get
                Return mMagnitude
            End Get
            Set(value As Int32)
                mMagnitude = value
            End Set
        End Property
        Property Percent As Single
            Get
                Return mPercent
            End Get
            Set(value As Single)
                mPercent = value
            End Set
        End Property
        Property Spread As Single
            Get
                Return mSpread
            End Get
            Set(value As Single)
                mSpread = value
            End Set
        End Property
        Property Color As [Shared].Drawing.COH_Color_RGBA
            Get
                Return mColor
            End Get
            Set(value As [Shared].Drawing.COH_Color_RGBA)
                mColor = value
            End Set
        End Property
        Property Offset As COH_TexWord_Layer_Offset
            Get
                Return mOffset
            End Get
            Set(value As COH_TexWord_Layer_Offset)
                mOffset = value
            End Set
        End Property
        Property Blend As Int32
            Get
                Return mBlend
            End Get
            Set(value As Int32)
                mBlend = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mType As Int32
       Private mMagnitude As Int32
       Private mPercent As Single
       Private mSpread As Single
       Private mColor As [Shared].Drawing.COH_Color_RGBA
       Private mOffset As COH_TexWord_Layer_Offset
       Private mBlend As Int32
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
            mColor = New [Shared].Drawing.COH_Color_RGBA
            mOffset = New COH_TexWord_Layer_Offset
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_TexWord_Layer_Filter
            Dim Result As COH_TexWord_Layer_Filter = New COH_TexWord_Layer_Filter
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mType = mType
                .mMagnitude = mMagnitude
                .mPercent = mPercent
                .mSpread = mSpread
                .mColor = mColor.Clone
                .mOffset = mOffset.Clone
                .mBlend = mBlend
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mType)
            CurrentWriter.Write(mMagnitude)
            CurrentWriter.Write(mPercent)
            CurrentWriter.Write(mSpread)
            mColor.Export_To_Stream(CurrentWriter)
            If CurrentWriter.Write_CrypticS_Struct(mOffset) = False Then Return False
            CurrentWriter.Write(mBlend)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mType = CurrentReader.ReadInt32
            mMagnitude = CurrentReader.ReadInt32
            mPercent = CurrentReader.ReadSingle
            mSpread = CurrentReader.ReadSingle
            mColor = New [Shared].Drawing.COH_Color_RGBA(CurrentReader.Read_CrypticS_uIntegerArray())
            If CurrentReader.Read_CrypticS_Struct(GetType(COH_TexWord_Layer_Offset), mOffset) = False Then Return False
            mBlend = CurrentReader.ReadInt32
            Return True
End Function
#End Region

    End Class
End Namespace
