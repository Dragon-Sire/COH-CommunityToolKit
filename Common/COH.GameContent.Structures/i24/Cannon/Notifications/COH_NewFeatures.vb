Namespace GameContent.Structures.Notifications
    Public NotInheritable Class COH_NewFeatures
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return ID
            End Get
        End Property
#End Region

#Region "Properties"
        Property ID As Int32
            Get
                Return mID
            End Get
            Set(value As Int32)
                mID = value
            End Set
        End Property
        Property Description As String
            Get
                Return mDescription
            End Get
            Set(value As String)
                mDescription = value
            End Set
        End Property
        Property Command As String
            Get
                Return mCommand
            End Get
            Set(value As String)
                mCommand = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mID As Int32
       Private mDescription As String
       Private mCommand As String
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
            mDescription = String.Empty
            mCommand = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_NewFeatures
            Dim Result As COH_NewFeatures = New COH_NewFeatures
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mID = mID
                .mDescription = String.Copy(mDescription)
                .mCommand = String.Copy(mCommand)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mID)
            CurrentWriter.Write_CrypticS_String(mDescription)
            CurrentWriter.Write_CrypticS_String(mCommand)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mID = CurrentReader.ReadInt32
            mDescription = CurrentReader.Read_CrypticS_String
            mCommand = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
