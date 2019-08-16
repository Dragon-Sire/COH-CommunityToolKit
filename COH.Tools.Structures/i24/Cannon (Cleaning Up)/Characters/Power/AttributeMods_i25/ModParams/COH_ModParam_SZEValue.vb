﻿Namespace Characters.Powers.ModParams
    Public NotInheritable Class COH_ModParam_SizeValue
        Inherits COH_Struct

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "SZEValue"
            End Get
        End Property
#End Region

#Region "Properties"
        Property ScriptID As String()
            Get
                Return mScriptID
            End Get
            Set(value As String())
                SetValue(mScriptID, value)
            End Set
        End Property
        Property ScriptValue As String()
            Get
                Return mScriptValue
            End Get
            Set(value As String())
                SetValue(mScriptValue, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mScriptID As String()
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mScriptValue As String()
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
            mScriptID = New String() {}
            mScriptValue = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ModParam_SizeValue
            Dim Result As COH_ModParam_SizeValue = New COH_ModParam_SizeValue
            MyBase.CloneTo(TryCast(Result, COH_Struct))
            With Result
                .mScriptID = CloneStrings(mScriptID)
                .mScriptValue = CloneStrings(mScriptValue)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_StringArray(mScriptID)
            CurrentWriter.Write_CrypticS_StringArray(mScriptValue)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mScriptID = CurrentReader.Read_CrypticS_StringArray
            mScriptValue = CurrentReader.Read_CrypticS_StringArray
            Return True
        End Function
#End Region

    End Class
End Namespace
