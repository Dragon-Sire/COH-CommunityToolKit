﻿Namespace Textures
    Public NotInheritable Class COH_TextWord_Layer_Font
        Inherits COH_FileStructure

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
        Property Size As Int32
            Get
                Return mSize
            End Get
            Set(value As Int32)
                mSize = value
            End Set
        End Property
        Property Italic As Boolean
            Get
                Return mItalic
            End Get
            Set(value As Boolean)
                mItalic = value
            End Set
        End Property
        Property Bold As Boolean
            Get
                Return mBold
            End Get
            Set(value As Boolean)
                mBold = value
            End Set
        End Property
        Property Outline As Byte
            Get
                Return mOutline
            End Get
            Set(value As Byte)
                mOutline = value
            End Set
        End Property
        Property DropShadow As COH_TextWord_Layer_DropShadow
            Get
                Return mDropShadow
            End Get
            Set(value As COH_TextWord_Layer_DropShadow)
                mDropShadow = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mName As String
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mSize As Int32
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mItalic As Boolean
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mBold As Boolean
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mOutline As Byte
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mDropShadow As COH_TextWord_Layer_DropShadow
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
            mDropShadow = New COH_TextWord_Layer_DropShadow
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_TextWord_Layer_Font
            Dim Result As COH_TextWord_Layer_Font = New COH_TextWord_Layer_Font
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mSize = mSize
                .mItalic = mItalic
                .mBold = mBold
                .mOutline = mOutline
                .mDropShadow = mDropShadow.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mSize)
            CurrentWriter.Write_CrypticS_Boolean(mItalic)
            CurrentWriter.Write_CrypticS_Boolean(mBold)
            CurrentWriter.Write_CrypticS_Byte_Aligned4(mOutline)
            If CurrentWriter.Write_CrypticS_Struct(mDropShadow) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mSize = CurrentReader.ReadInt32
            mItalic = CurrentReader.Read_CrypticS_Boolean
            mBold = CurrentReader.Read_CrypticS_Boolean
            mOutline = CurrentReader.Read_CrypticS_Byte_Aligned4
            If CurrentReader.Read_CrypticS_Struct(GetType(COH_TextWord_Layer_DropShadow), mDropShadow) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
