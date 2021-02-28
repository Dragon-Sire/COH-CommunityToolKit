Namespace GameContent.Structures.[Shared].Drawing
    Public NotInheritable Class COH_Vector3
        Inherits COH_FileStructure

#Region "Enum"
        Public Enum InternalVerions
            Standard = 0
            Default1 = 1
        End Enum
#End Region

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return String.Format("{0},{1},{2}", New Object(2) {X, Y, Z})
            End Get
        End Property
#End Region

#Region "Properties"
        <Xml.Serialization.XmlAttribute> Property X As Single
        <Xml.Serialization.XmlAttribute> Property Y As Single
        <Xml.Serialization.XmlAttribute> Property Z As Single
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
            Dim InternvalVerson As InternalVerions = Version
            Select Case InternvalVerson
                Case InternalVerions.Standard
                    X = Y = Z = 0
                Case InternalVerions.Default1
                    X = Y = Z = 1
            End Select
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Vector3
            Dim Result As COH_Vector3 = New COH_Vector3
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .X = X
                .Y = Y
                .Z = Z
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(X)
            CurrentWriter.Write(Y)
            CurrentWriter.Write(Z)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            X = CurrentReader.ReadSingle
            Y = CurrentReader.ReadSingle
            Z = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
