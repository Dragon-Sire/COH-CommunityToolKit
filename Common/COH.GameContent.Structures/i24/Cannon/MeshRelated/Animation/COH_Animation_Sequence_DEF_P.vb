Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_Animation_Sequence_DEF_P
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
        Property BaseSkeleton As String
            Get
                Return mBaseSkeleton
            End Get
            Set(value As String)
                mBaseSkeleton = value
            End Set
        End Property
        Property ParentType As String
            Get
                Return mParentType
            End Get
            Set(value As String)
                mParentType = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mBaseSkeleton As String
       Private mParentType As String
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
            mBaseSkeleton = String.Empty
            mParentType = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Animation_Sequence_DEF_P
            Dim Result As COH_Animation_Sequence_DEF_P = New COH_Animation_Sequence_DEF_P
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mBaseSkeleton = String.Copy(mBaseSkeleton)
                .mParentType = String.Copy(mParentType)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mBaseSkeleton)
            CurrentWriter.Write_CrypticS_String(mParentType)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mBaseSkeleton = CurrentReader.Read_CrypticS_String
            mParentType = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
