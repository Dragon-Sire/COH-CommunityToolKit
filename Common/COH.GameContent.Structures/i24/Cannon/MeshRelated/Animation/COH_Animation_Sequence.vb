Imports COH.GameContent.Structures.Shared

Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_Animation_Sequence
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
        Property TypeDef As COH_Animation_Sequence_DEF_P()
            Get
                Return mTypeDef
            End Get
            Set(value As COH_Animation_Sequence_DEF_P())
                mTypeDef = value
            End Set
        End Property
        Property Group As COH_Generic_StringClass()
            Get
                Return mGroup
            End Get
            Set(value As COH_Generic_StringClass())
                mGroup = value
            End Set
        End Property
        Property Move As COH_Animation_Sequence_MoveP()
            Get
                Return mMove
            End Get
            Set(value As COH_Animation_Sequence_MoveP())
                mMove = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mTypeDef As COH_Animation_Sequence_DEF_P()
       Private mGroup As COH_Generic_StringClass()
       Private mMove As COH_Animation_Sequence_MoveP()
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
            mTypeDef = New COH_Animation_Sequence_DEF_P() {}
            mGroup = New COH_Generic_StringClass() {}
            mMove = New COH_Animation_Sequence_MoveP() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Animation_Sequence
            Dim Result As COH_Animation_Sequence = New COH_Animation_Sequence
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mTypeDef = New COH_Animation_Sequence_DEF_P(mTypeDef.Count - 1) {}
                For X = 0 To mTypeDef.Count - 1
                    .mTypeDef(X) = mTypeDef(X).Clone
                Next
                .mGroup = New COH_Generic_StringClass(mGroup.Count - 1) {}
                For X = 0 To mGroup.Count - 1
                    .mGroup(X) = mGroup(X).Clone
                Next
                .mMove = New COH_Animation_Sequence_MoveP(mMove.Count - 1) {}
                For X = 0 To mMove.Count - 1
                    .mMove(X) = mMove(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mSequencer)
            CurrentWriter.Write_CrypticS_String(mName)
            If CurrentWriter.Write_CrypticS_StructArray(mTypeDef) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mGroup) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mMove) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mSequencer = 
            mName = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Animation_Sequence_DEF_P), mTypeDef) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Generic_StringClass), mGroup) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Animation_Sequence_MoveP), mMove) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
