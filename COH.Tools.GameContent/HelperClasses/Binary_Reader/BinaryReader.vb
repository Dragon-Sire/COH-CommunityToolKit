﻿Imports COH.GameContent.Utilities

Namespace BinaryStreams
    '<DebuggerStepThrough>
    Public NotInheritable Class COH_BinaryReader
        Inherits IO.BinaryReader

#Region "Properties"
        <Category("Configuration")> Public ReadOnly Property ByteOrder As COH_Supported_BinaryByteOrder
            Get
                Return mDefaultByteOrder
            End Get
        End Property
        <Category("Stream")> Public Property Position As Long
            Get
                If Stream Is Nothing Then Return -1
                Return Stream.Position
            End Get
            Set(value As Long)
                If BaseStream Is Nothing Then Exit Property
                If value = BaseStream.Position Then Exit Property
                BaseStream.Position = value
                OnPositionChanged()
            End Set
        End Property
        <Category("Stream")> Public ReadOnly Property RemainingBytes As Long
            Get
                If BaseStream Is Nothing Then Return -1
                Return (BaseStream.Length - BaseStream.Position)
            End Get
        End Property
        <Category("Stream")> Public ReadOnly Property Length As Long
            Get
                If BaseStream Is Nothing Then Return -1
                Return BaseStream.Length
            End Get
        End Property
        <Category("Stream")> Public ReadOnly Property Stream As IO.Stream
            Get
                Return BaseStream
            End Get
        End Property
        <Category("Settings")> Public Property Settings As COH_Serialization_Settings
            Get
                Return mOptions
            End Get
            Set(value As COH_Serialization_Settings)
                mOptions = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mOptions As COH_Serialization_Settings
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mDefaultByteOrder As COH_Supported_BinaryByteOrder
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mBuffer As Byte() = Nothing '= New Byte(4096 - 1) {}
        <EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private mBuffer_Chars As Char() = Nothing '= New Byte(128 - 1) {}
#End Region

#Region "Create New Instance"
        Public Sub New(value As IO.Stream)
            MyBase.New(value)
            Initialize_Settings(Text.Encoding.ASCII)
        End Sub
        Public Sub New(value As IO.Stream, DefaultEncoding As Text.Encoding)
            MyBase.New(value, DefaultEncoding)
            Initialize_Settings(DefaultEncoding)
        End Sub
        Public Sub New(value As IO.Stream, DefaultEncoding As Text.Encoding, LeaveOpen As Boolean)
            MyBase.New(value, DefaultEncoding, LeaveOpen)
            Initialize_Settings(DefaultEncoding)
        End Sub
        Public Sub New(value As IO.FileInfo, DefaultEncoding As Text.Encoding, LeaveOpen As Boolean, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            Me.New(New IO.FileStream(value.FullName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None, 4096), DefaultEncoding, LeaveOpen)
            Select Case ByteOrder
                Case COH_Supported_BinaryByteOrder.Default, COH_Supported_BinaryByteOrder.LittleEndian
                    mDefaultByteOrder = COH_Supported_BinaryByteOrder.LittleEndian
                Case Else
                    mDefaultByteOrder = COH_Supported_BinaryByteOrder.BigEndian
            End Select
            Initialize_Settings(DefaultEncoding)
        End Sub
        Private Sub Initialize_Settings(DefaultEncoding As Text.Encoding)
            mOptions = New COH_Serialization_Settings
            mOptions.Options_TextEncoding = DefaultEncoding
            mOptions.Option_Version = 0
            mOptions.Option_SelectedFormat = Structures.COH_Struct.COH_ExportFormat.CrypticS_BINFormat
        End Sub
        Public Sub CloseStream()
            MyBase.Close()
        End Sub
        Private Function DetermineByteOrder(ByteOrder As COH_Supported_BinaryByteOrder) As COH_Supported_BinaryByteOrder
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = ByteOrder
            If UsedByteOrder = COH_Supported_BinaryByteOrder.Default Then UsedByteOrder = mDefaultByteOrder
            Return UsedByteOrder
        End Function
#End Region

#Region "Events"
        Public Event PositionChanged(NewPosition As Long)
        Public Sub OnPositionChanged()
            RaiseEvent PositionChanged(BaseStream.Position)
        End Sub
#End Region

    End Class
End Namespace