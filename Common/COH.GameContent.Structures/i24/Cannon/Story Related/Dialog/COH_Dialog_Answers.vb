Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_DialogAnswer
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Text
            End Get
        End Property
#End Region

#Region "Properties"
        Property Text As String
            Get
                Return mText
            End Get
            Set(value As String)
                mText = value
            End Set
        End Property
        Property Page As String
            Get
                Return mPage
            End Get
            Set(value As String)
                mPage = value
            End Set
        End Property
        Property Requires As String()
            Get
                Return mRequires
            End Get
            Set(value As String())
                mRequires = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mText As String
       Private mPage As String
       Private mRequires As String()
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
            mText = String.Empty
            mPage = String.Empty
            mRequires = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_DialogAnswer
            Dim Result As COH_DialogAnswer = New COH_DialogAnswer
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mText = String.Copy(mText)
                .mPage = String.Copy(mPage)
                .mRequires = mRequires.CloneTheStrings
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mText)
            CurrentWriter.Write_CrypticS_String(mPage)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mText = CurrentReader.Read_CrypticS_String
            mPage = CurrentReader.Read_CrypticS_String
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
