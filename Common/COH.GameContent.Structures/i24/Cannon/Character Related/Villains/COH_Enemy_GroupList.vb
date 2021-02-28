Namespace GameContent.Structures.Enemies
    Public NotInheritable Class COH_Enemies_GroupList
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "List"
            End Get
        End Property
#End Region

#Region "Properties"
        Property VG As COH_Enemy_GroupMM()
            Get
                Return mVG
            End Get
            Set(value As COH_Enemy_GroupMM())
                mVG = value
            End Set
        End Property
        Property Embrace As String()
            Get
                Return mEmbrace
            End Get
            Set(value As String())
                mEmbrace = value
            End Set
        End Property
        Property CantMove As String()
            Get
                Return mCantMove
            End Get
            Set(value As String())
                mCantMove = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mVG As COH_Enemy_GroupMM()
       Private mEmbrace As String()
       Private mCantMove As String()
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
            mVG = New COH_Enemy_GroupMM() {}
            mEmbrace = New String() {}
            mCantMove = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Enemies_GroupList
            Dim Result As COH_Enemies_GroupList = New COH_Enemies_GroupList
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mVG = New COH_Enemy_GroupMM(mVG.Count - 1) {}
                For X = 0 To mVG.Count - 1
                    .mVG(X) = mVG(X).Clone
                Next
                .mEmbrace = mEmbrace.CloneTheStrings
                .mCantMove = mCantMove.CloneTheStrings
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Write_CrypticS_StructArray(mVG) = False Then Return False
            CurrentWriter.Write_CrypticS_StringArray(mEmbrace)
            CurrentWriter.Write_CrypticS_StringArray(mCantMove)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Enemy_GroupMM), mVG) = False Then Return False
            mEmbrace = CurrentReader.Read_CrypticS_StringArray()
            mCantMove = CurrentReader.Read_CrypticS_StringArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
