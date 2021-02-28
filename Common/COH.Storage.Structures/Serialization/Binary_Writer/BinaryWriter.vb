Imports COH.GameContent.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization.Configuration

Namespace Storage.Serialization
    '<DebuggerStepThrough>
    Partial Public NotInheritable Class COH_BinaryWriter
        Inherits IO.BinaryWriter

#Region "Properties"
        Public Property Position As Long
            Get
                'If mStream_Reader Is Nothing Then Return -1
                If Stream Is Nothing Then Return -1
                Return Stream.Position
            End Get
            Set(value As Long)
                'If mStream_Reader Is Nothing Then Exit Property
                If Stream Is Nothing Then Exit Property
                Stream.Position = value
            End Set
        End Property
        Public ReadOnly Property RemainingBytes As Long
            Get
                'If mStream_Reader Is Nothing Then Return -1
                If Stream Is Nothing Then Return -1
                Return (Stream.Length - Stream.Position)
            End Get
        End Property
        Public ReadOnly Property Length As Long
            Get
                If Stream Is Nothing Then Return -1
                Return Stream.Length
            End Get
        End Property
        Public ReadOnly Property Stream As IO.Stream
            Get
                Return MyBase.BaseStream
            End Get
        End Property
        Public Property Settings As COH_Serialization_Settings
            Get
                Return mOptions
            End Get
            Set(value As COH_Serialization_Settings)
                mOptions = value
            End Set
        End Property
        Public Sub CloseStream()
            MyBase.Close()
        End Sub
#End Region

#Region "Private Properties"
        Private mOptions As COH_Serialization_Settings
        Private mBuffer As Byte() = Nothing '= New Byte(4096 - 1) {}
        Private mBuffer_Chars As Char() = Nothing '= New Byte(128 - 1) {}
#End Region

#Region "Create New Instance"
        Public Sub New(value As IO.Stream)
            MyBase.New(value)
            '//mCurrentStream = value
        End Sub
        Public Sub New(value As IO.MemoryStream, Optional LeaveOpen As Boolean = False)
            MyBase.New(value, Text.Encoding.UTF8, LeaveOpen)
            Initialize_Settings(Text.Encoding.UTF8)
        End Sub
        Public Sub New(value As IO.Stream, DefaultEncoding As Text.Encoding)
            MyBase.New(value, DefaultEncoding)
            Initialize_Settings(DefaultEncoding)
        End Sub
        Public Sub New(value As IO.Stream, DefaultEncoding As Text.Encoding, LeaveOpen As Boolean)
            MyBase.New(value, DefaultEncoding, LeaveOpen)
            Initialize_Settings(DefaultEncoding)
        End Sub
        Public Sub New(value As IO.FileInfo, DefaultEncoding As Text.Encoding, LeaveOpen As Boolean)
            Me.New(New IO.FileStream(value.FullName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None, 4096), DefaultEncoding, LeaveOpen)
            Initialize_Settings(DefaultEncoding)
        End Sub
        Private Sub Initialize_Settings(DefaultEncoding As Text.Encoding)
            mOptions = New COH_Serialization_Settings
            mOptions.Options_TextEncoding = DefaultEncoding
            mOptions.Option_Version = 0
            mOptions.Option_SelectedFormat = CodeManagement.Enums.Structures.COH_ExportFormat.CrypticS_BINFormat
        End Sub
#End Region

    End Class
End Namespace