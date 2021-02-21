﻿Namespace [Shared]
    Public NotInheritable Class COH_Generic_IndexList
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "List"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Salvage As COH_Generic_IndexList_Item()
            Get
                Return mItems
            End Get
            Set(value As COH_Generic_IndexList_Item())
                mItems = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mItems As COH_Generic_IndexList_Item()
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
            mItems = New COH_Generic_IndexList_Item() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Generic_IndexList
            Dim Result As COH_Generic_IndexList = New COH_Generic_IndexList
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mItems = New COH_Generic_IndexList_Item(mItems.Count - 1) {}
                For X = 0 To mItems.Count - 1
                    .mItems(X) = mItems(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Write_CrypticS_StructArray(mItems) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Generic_IndexList_Item), mItems) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
