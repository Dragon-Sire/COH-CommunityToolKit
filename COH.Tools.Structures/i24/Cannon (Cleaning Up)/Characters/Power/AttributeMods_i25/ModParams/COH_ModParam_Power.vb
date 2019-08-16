﻿Namespace Characters.Powers.ModParams
    Public NotInheritable Class COH_ModParam_Power
        Inherits COH_Struct

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Power"
            End Get
        End Property
#End Region

#Region "Properties"
        Property PowerCategory As String()
            Get
                Return mPowerCategory
            End Get
            Set(value As String())
                SetValue(mPowerCategory, value)
            End Set
        End Property
        Property Powerset As String()
            Get
                Return mPowerset
            End Get
            Set(value As String())
                SetValue(mPowerset, value)
            End Set
        End Property
        Property Power As String()
            Get
                Return mPower
            End Get
            Set(value As String())
                SetValue(mPower, value)
            End Set
        End Property
        Property Count As Integer
            Get
                Return mCount
            End Get
            Set(value As Integer)
                SetValue(mCount, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mPowerCategory As String()
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mPowerset As String()
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mPower As String()
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mCount As Integer
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mPowerCategory = New String() {}
            mPowerset = New String() {}
            mPower = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ModParam_Power
            Dim Result As COH_ModParam_Power = New COH_ModParam_Power
            MyBase.CloneTo(TryCast(Result, COH_Struct))
            With Result
                .mPowerCategory = CloneStrings(mPowerCategory)
                .mPowerset = CloneStrings(mPowerset)
                .mPower = CloneStrings(mPower)
                .mCount = mCount
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_StringArray(mPowerCategory)
            CurrentWriter.Write_CrypticS_StringArray(mPowerset)
            CurrentWriter.Write_CrypticS_StringArray(mPower)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mPowerCategory = CurrentReader.Read_CrypticS_StringArray
            mPowerset = CurrentReader.Read_CrypticS_StringArray
            mPower = CurrentReader.Read_CrypticS_StringArray
            mCount = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
