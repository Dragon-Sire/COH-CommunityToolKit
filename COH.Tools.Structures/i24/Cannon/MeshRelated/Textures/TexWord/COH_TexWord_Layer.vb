﻿Namespace Textures
    Public NotInheritable Class COH_TextWord_Layer
        Inherits COH_Struct

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property Type As Int32
            Get
                Return mType
            End Get
            Set(value As Int32)
                mType = value
            End Set
        End Property
        Property Stretch As Int32
            Get
                Return mStretch
            End Get
            Set(value As Int32)
                mStretch = value
            End Set
        End Property
        Property Text As String
            Get
                Return mText
            End Get
            Set(value As String)
                mText = value
            End Set
        End Property
        Property Image As String
            Get
                Return mImage
            End Get
            Set(value As String)
                mImage = value
            End Set
        End Property
        Property TheColor As [Shared].Drawing.COH_Color_RGBA
            Get
                Return mColor
            End Get
            Set(value As [Shared].Drawing.COH_Color_RGBA)
                mColor = value
            End Set
        End Property
        Property Colors As [Shared].Drawing.COH_Color_RGBA()
            Get
                Return mColors
            End Get
            Set(value As [Shared].Drawing.COH_Color_RGBA())
                mColors = value
            End Set
        End Property
        Property Pos As Vector2
            Get
                Return mPos
            End Get
            Set(value As Vector2)
                mPos = value
            End Set
        End Property
        Property Size As Vector2
            Get
                Return mSize
            End Get
            Set(value As Vector2)
                mSize = value
            End Set
        End Property
        Property Rot As Single
            Get
                Return mRot
            End Get
            Set(value As Single)
                mRot = value
            End Set
        End Property
        Property Hidden As Boolean
            Get
                Return mHidden
            End Get
            Set(value As Boolean)
                mHidden = value
            End Set
        End Property
        Property Font As COH_TextWord_Layer_Font
            Get
                Return mFont
            End Get
            Set(value As COH_TextWord_Layer_Font)
                mFont = value
            End Set
        End Property
        Property Filter As COH_TexWord_Layer_Filter()
            Get
                Return mFilter
            End Get
            Set(value As COH_TexWord_Layer_Filter())
                mFilter = value
            End Set
        End Property
        Property SubLayer As COH_TextWord_Layer()
            Get
                Return mSubLayer
            End Get
            Set(value As COH_TextWord_Layer())
                mSubLayer = value
            End Set
        End Property
        Property SubBlend As COH_Enum_BlendType
            Get
                Return mSubBlend
            End Get
            Set(value As COH_Enum_BlendType)
                mSubBlend = value
            End Set
        End Property
        Property SubBlendWeight As Single
            Get
                Return mSubBlendWeight
            End Get
            Set(value As Single)
                mSubBlendWeight = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mName As String
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mType As Int32
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mStretch As Int32
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mText As String
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mImage As String
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mColor As [Shared].Drawing.COH_Color_RGBA
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mColors As [Shared].Drawing.COH_Color_RGBA()
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mPos As Vector2
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mSize As Vector2
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mRot As Single
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mHidden As Boolean
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mFont As COH_TextWord_Layer_Font
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mFilter As COH_TexWord_Layer_Filter()
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mSubLayer As COH_TextWord_Layer()
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mSubBlend As COH_Enum_BlendType
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mSubBlendWeight As Single
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
            mName = String.Empty
            mText = String.Empty
            mImage = String.Empty
            mColor = New [Shared].Drawing.COH_Color_RGBA
            mColors = New [Shared].Drawing.COH_Color_RGBA(3) {}
            mPos = New Vector2
            mSize = New Vector2
            mFont = New COH_TextWord_Layer_Font()
            mFilter = New COH_TexWord_Layer_Filter() {}
            mSubLayer = New COH_TextWord_Layer() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_TextWord_Layer
            Dim Result As COH_TextWord_Layer = New COH_TextWord_Layer
            MyBase.CloneTo(TryCast(Result, COH_Struct))
            With Result
                .mName = String.Copy(mName)
                .mType = mType
                .mStretch = mStretch
                .mText = String.Copy(mText)
                .mImage = String.Copy(mImage)
                .mColor = mColor.Clone
                .mColors = New [Shared].Drawing.COH_Color_RGBA(mColors.Count - 1) {}
                For x = 0 To mColors.Count - 1
                    .mColors(x) = mColors(x).Clone
                Next

                .mPos = mPos
                .mSize = mSize
                .mRot = mRot
                .mHidden = mHidden
                .mFont = mFont.Clone
                .mFilter = New COH_TexWord_Layer_Filter(mFilter.Count - 1) {}
                For X = 0 To mFilter.Count - 1
                    .mFilter(X) = mFilter(X).Clone
                Next
                .mSubLayer = New COH_TextWord_Layer(mSubLayer.Count - 1) {}
                For X = 0 To mSubLayer.Count - 1
                    .mSubLayer(X) = mSubLayer(X).Clone
                Next
                .mSubBlend = mSubBlend
                .mSubBlendWeight = mSubBlendWeight
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mType)
            CurrentWriter.Write(mStretch)
            CurrentWriter.Write_CrypticS_String(mText)
            CurrentWriter.Write_CrypticS_String(mImage)

            mColor.Export_To_Stream(CurrentWriter)
            mColors(0).Export_To_Stream(CurrentWriter)
            mColors(1).Export_To_Stream(CurrentWriter)
            mColors(2).Export_To_Stream(CurrentWriter)
            mColors(3).Export_To_Stream(CurrentWriter)

            CurrentWriter.Write_CrypticS_Vector2(mPos)
            CurrentWriter.Write_CrypticS_Vector2(mSize)
            CurrentWriter.Write(mRot)
            CurrentWriter.Write_CrypticS_Boolean(mHidden)
            If CurrentWriter.Write_CrypticS_Struct(mFont) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mFilter) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mSubLayer) = False Then Return False
            CurrentWriter.Write(mSubBlend)
            CurrentWriter.Write(mSubBlendWeight)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mType = CurrentReader.ReadInt32
            mStretch = CurrentReader.ReadInt32
            mText = CurrentReader.Read_CrypticS_String
            mImage = CurrentReader.Read_CrypticS_String

            mColor = New [Shared].Drawing.COH_Color_RGBA(CurrentReader.Read_CrypticS_uIntegerArray())
            mColors(0) = New [Shared].Drawing.COH_Color_RGBA(CurrentReader.Read_CrypticS_uIntegerArray())
            mColors(1) = New [Shared].Drawing.COH_Color_RGBA(CurrentReader.Read_CrypticS_uIntegerArray())
            mColors(2) = New [Shared].Drawing.COH_Color_RGBA(CurrentReader.Read_CrypticS_uIntegerArray())
            mColors(3) = New [Shared].Drawing.COH_Color_RGBA(CurrentReader.Read_CrypticS_uIntegerArray())


            mPos = CurrentReader.Read_CrypticS_Vector2
            mSize = CurrentReader.Read_CrypticS_Vector2
            mRot = CurrentReader.ReadSingle
            mHidden = CurrentReader.Read_CrypticS_Boolean
            If CurrentReader.Read_CrypticS_Struct(GetType(COH_TextWord_Layer_Font), mFont) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_TexWord_Layer_Filter), mFilter) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_TextWord_Layer), mSubLayer) = False Then Return False
            mSubBlend = CurrentReader.ReadInt32
            mSubBlendWeight = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
