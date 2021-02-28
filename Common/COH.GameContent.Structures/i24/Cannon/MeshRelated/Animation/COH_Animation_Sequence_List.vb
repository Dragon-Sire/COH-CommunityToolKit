Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_Animation_Sequence_List
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "List"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Seqs As String()
            Get
                Return mSeqs
            End Get
            Set(value As String())
                mSeqs = value
            End Set
        End Property
        Property Anims As String()
            Get
                Return mAnims
            End Get
            Set(value As String())
                mAnims = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mSeqs As String()
       Private mAnims As String()
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
            mSeqs = New String() {}
            mAnims = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Animation_Sequence_List
            Dim Result As COH_Animation_Sequence_List = New COH_Animation_Sequence_List
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mSeqs = mSeqs.CloneTheStrings
                .mAnims = mAnims.CloneTheStrings
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_StringArray(mSeqs)
            CurrentWriter.Write_CrypticS_StringArray(mAnims)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mSeqs = CurrentReader.Read_CrypticS_StringArray()
            mAnims = CurrentReader.Read_CrypticS_StringArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
