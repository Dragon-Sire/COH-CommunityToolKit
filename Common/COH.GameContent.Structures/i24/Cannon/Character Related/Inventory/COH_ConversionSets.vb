﻿Namespace Inventory
    Public NotInheritable Class COH_ConversionSets
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
        Property InSet As Int32
            Get
                Return mInSet
            End Get
            Set(value As Int32)
                mInSet = value
            End Set
        End Property
        Property OutSet As Int32
            Get
                Return mOutSet
            End Get
            Set(value As Int32)
                mOutSet = value
            End Set
        End Property
        Property AllowAttuned As Int32
            Get
                Return mAllowAttuned
            End Get
            Set(value As Int32)
                mAllowAttuned = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mName As String
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mInSet As Int32
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mOutSet As Int32
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mAllowAttuned As Int32
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
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ConversionSets
            Dim Result As COH_ConversionSets = New COH_ConversionSets
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mInSet = mInSet
                .mOutSet = mOutSet
                .mAllowAttuned = mAllowAttuned
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mInSet)
            CurrentWriter.Write(mOutSet)
            CurrentWriter.Write(mAllowAttuned)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mInSet = CurrentReader.ReadInt32
            mOutSet = CurrentReader.ReadInt32
            mAllowAttuned = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
