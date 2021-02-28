Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_CommandString
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return DisplayName
            End Get
        End Property
#End Region

#Region "Properties"
        Property CmdString As String
            Get
                Return mCmdString
            End Get
            Set(value As String)
                mCmdString = value
            End Set
        End Property
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mCmdString As String
       Private mDisplayName As String
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
            mCmdString = String.Empty
            mDisplayName = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CommandString
            Dim Result As COH_CommandString = New COH_CommandString
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCmdString = String.Copy(mCmdString)
                .mDisplayName = String.Copy(mDisplayName)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mCmdString)
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mCmdString = CurrentReader.Read_CrypticS_String
            mDisplayName = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
