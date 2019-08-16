﻿Namespace Story
    Public NotInheritable Class COH_Mission_MapTime
        Inherits COH_Struct

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Time"
            End Get
        End Property
#End Region

#Region "Properties"
        Property MapTime As Int32
            Get
                Return mMapTime
            End Get
            Set(value As Int32)
                mMapTime = value
            End Set
        End Property
        Property Map As COH_Mission_Map()
            Get
                Return mMap
            End Get
            Set(value As COH_Mission_Map())
                mMap = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mMapTime As Int32
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mMap As COH_Mission_Map()
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
            mMap = New COH_Mission_Map() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Mission_MapTime
            Dim Result As COH_Mission_MapTime = New COH_Mission_MapTime
            MyBase.CloneTo(TryCast(Result, COH_Struct))
            With Result
                .mMapTime = mMapTime
                .mMap = New COH_Mission_Map(mMap.Count - 1) {}
                For X = 0 To mMap.Count - 1
                    .mMap(X) = mMap(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mMapTime)
            If CurrentWriter.Write_CrypticS_StructArray(mMap) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mMapTime = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Mission_Map), mMap) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
