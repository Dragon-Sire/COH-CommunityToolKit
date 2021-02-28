Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_STD
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "VarsTable"
            End Get
        End Property
#End Region

#Region "Properties"
        Property var As [Shared].COH_Generic_StringTableArray
            Get
                Return mvar
            End Get
            Set(value As [Shared].COH_Generic_StringTableArray)
                mvar = value
            End Set
        End Property
        Property vargroup As [Shared].COH_Generic_StringTableArray
            Get
                Return mvargroup
            End Get
            Set(value As [Shared].COH_Generic_StringTableArray)
                mvargroup = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mvar As [Shared].COH_Generic_StringTableArray
       Private mvargroup As [Shared].COH_Generic_StringTableArray
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
            mvar = New [Shared].COH_Generic_StringTableArray
            mvargroup = New [Shared].COH_Generic_StringTableArray
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_STD
            Dim Result As COH_STD = New COH_STD
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mvar = mvar
                ' .mvargroup = mvargroup
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            'If CurrentWriter.Write_CrypticS_Struct(mvar) = False Then Return False
            'If CurrentWriter.Write_CrypticS_Struct(mvargroup) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            var = New [Shared].COH_Generic_StringTableArray(CurrentReader)
            vargroup = New [Shared].COH_Generic_StringTableArray (CurrentReader)
            Return True
        End Function
#End Region

    End Class
End Namespace
