﻿Imports COH.GameContent.Structures.UI
Imports COH.GameContent.Structures.World

Namespace Bases
    Public NotInheritable Class COH_Base_RoomCategory
        Inherits COH_Struct

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mUI_NameANDHelp.DisplayName
            End Get
        End Property
#End Region

#Region "Properties"
        Property UI As COH_UI_NameANDHelp
            Get
                Return mUI_NameANDHelp
            End Get
            Set(value As COH_UI_NameANDHelp)
                mUI_NameANDHelp = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mUI_NameANDHelp As COH_UI_NameANDHelp
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
            mUI_NameANDHelp = New COH_UI_NameANDHelp
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mUI_NameANDHelp.UpdateLocalizations(LocalizeController)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Base_RoomCategory
            Dim Result As COH_Base_RoomCategory = New COH_Base_RoomCategory
            MyBase.CloneTo(TryCast(Result, COH_Struct))
            With Result
                .mUI_NameANDHelp = mUI_NameANDHelp.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            mUI_NameANDHelp.Export_To_Stream(CurrentWriter)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mUI_NameANDHelp = New COH_UI_NameANDHelp(CurrentReader)
            Return True
        End Function
#End Region

    End Class
End Namespace
