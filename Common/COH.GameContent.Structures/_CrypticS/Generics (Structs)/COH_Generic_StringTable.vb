Namespace GameContent.Structures.[Shared]
    Public NotInheritable Class COH_Generic_StringTable
        Inherits COH_FileStructure

#Region "Enum"
        Public Enum InternalVerions
            Standard_Struct = 0
        End Enum
#End Region

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "GenericList"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Items As COH_Generic_StringClass()
            Get
                Return mItems
            End Get
            Set(value As COH_Generic_StringClass())
                mItems = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mItems As COH_Generic_StringClass()
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
            mItems = New COH_Generic_StringClass() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Generic_StringTable
            Dim Result As COH_Generic_StringTable = New COH_Generic_StringTable
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mItems = New COH_Generic_StringClass(mItems.Count - 1) {}
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
            Select Case CurrentReader.Settings.Option_Version
                Case InternalVerions.Standard_Struct
                    If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Generic_StringClass), mItems) = False Then Return False
                    Return False
            End Select
        End Function
#End Region

    End Class
End Namespace
