Namespace GameContent.Structures.Enemies.AI
    Public NotInheritable Class COH_AI_BehaviorAlias
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return [Alias]
            End Get
        End Property
#End Region

#Region "Properties"
        Property [Alias] As String
            Get
                Return mAlias
            End Get
            Set(value As String)
                mAlias = value
            End Set
        End Property
        Property Resolve As String
            Get
                Return mResolve
            End Get
            Set(value As String)
                mResolve = value
            End Set
        End Property
        Property FileName As String
            Get
                Return mFileName
            End Get
            Set(value As String)
                mFileName = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mAlias As String
       Private mResolve As String
       Private mFileName As String
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
            mAlias = String.Empty
            mResolve = String.Empty
            mFileName = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_AI_BehaviorAlias
            Dim Result As COH_AI_BehaviorAlias = New COH_AI_BehaviorAlias
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mAlias = String.Copy(mAlias)
                .mResolve = String.Copy(mResolve)
                .mFileName = String.Copy(mFileName)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mAlias)
            CurrentWriter.Write_CrypticS_String(mResolve)
            CurrentWriter.Write_CrypticS_String(mFileName)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mAlias = CurrentReader.Read_CrypticS_String
            mResolve = CurrentReader.Read_CrypticS_String
            mFileName = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
