﻿Namespace Costumes
    Public NotInheritable Class COH_Chest_GeoLink
        Inherits COH_Struct

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return BonesetName
            End Get
        End Property
#End Region

#Region "Properties"
        Property BonesetName As String
            Get
                Return mBonesetName
            End Get
            Set(value As String)
                mBonesetName = value
            End Set
        End Property
        Property GeoStrings As String()
            Get
                Return mGeoStrings
            End Get
            Set(value As String())
                mGeoStrings = value
            End Set
        End Property
        Property filename As String
            Get
                Return mfilename
            End Get
            Set(value As String)
                mfilename = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mBonesetName As String
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mGeoStrings As String()
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mfilename As String
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
            mBonesetName = String.Empty
            mGeoStrings = New String() {}
            mfilename = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Chest_GeoLink
            Dim Result As COH_Chest_GeoLink = New COH_Chest_GeoLink
            MyBase.CloneTo(TryCast(Result, COH_Struct))
            With Result
                .mBonesetName = String.Copy(mBonesetName)
                .mGeoStrings = mGeoStrings.CloneTheStrings
                .mfilename = String.Copy(mfilename)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mBonesetName)
            CurrentWriter.Write_CrypticS_StringArray(mGeoStrings)
            CurrentWriter.Write_CrypticS_String(mfilename)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mBonesetName = CurrentReader.Read_CrypticS_String
            mGeoStrings = CurrentReader.Read_CrypticS_StringArray()
            mfilename = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
