Imports System.IO
Imports zlib

Namespace HelperFunctions.Compression
    <HideModuleName> Public Module COH_Helper_Zlib
        Public Class COH_ZLIB_CompressionStream
            Inherits ZOutputStream
            Sub New(TheStream As Stream)
                MyBase.New(TheStream)
            End Sub
            Public Overrides ReadOnly Property CanRead As Boolean
                Get
                    Return True
                End Get
            End Property
            Public Overrides ReadOnly Property CanWrite As Boolean
                Get
                    Return True
                End Get
            End Property
        End Class

#Region "CompressData"
        Public Sub CompressData(ByVal inData As Byte(), ByRef outData As Byte())
        End Sub
#End Region

#Region "Decompress"
        Public Function DecompressBytes(ByRef RawData As Byte()) As Byte()
            Dim Buffer As New IO.MemoryStream(RawData)
            Dim ByteResult As Byte() = Nothing
            ByteResult = DecompressBytes_Method1(Buffer)
            If ByteResult Is Nothing Then ByteResult = DecompressBytes_Method2(RawData)
            'If ByteResult Is Nothing Then ShowErrorOccured("Unable to DecompressBytes - Method1/2")
            Return ByteResult
        End Function
        Private Function DecompressBytes_Method1(ByRef Buffer As IO.MemoryStream) As Byte()
            Dim ByteResult As Byte() = Nothing
            Dim Result As Boolean = False
            Dim sMemmoryStream_Out As New System.IO.MemoryStream()
            Dim zStream As New COH_ZLIB_CompressionStream(sMemmoryStream_Out)
            Try
                Buffer.CopyTo(zStream)
                ByteResult = sMemmoryStream_Out.ToArray
                Result = True
                'Result = DecompressBytes_ToStream(RawData, zStream)
            Catch ex As Exception
                ' ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to DecompressBytes - Method1", ex, True)
            Finally
                zStream.Close()
                sMemmoryStream_Out.Close()
            End Try
            If Result = False Then Return Nothing
            Return ByteResult
        End Function
        Private Function DecompressBytes_Method2(ByRef RawData As Byte()) As Byte()
            Dim ByteResult As Byte() = Nothing
            Dim Result As Boolean = False
            Dim sMemmoryStream_Out As New System.IO.MemoryStream()
            Dim zStream As New COH_ZLIB_CompressionStream(sMemmoryStream_Out)
            Try
                Result = DecompressBytes_ToStream(RawData, zStream)
                ByteResult = sMemmoryStream_Out.ToArray
            Catch ex As Exception
                ' ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to DecompressBytes - Method2", ex, True)
            Finally
                zStream.Close()
                sMemmoryStream_Out.Close()
            End Try
            If Result = False Then Return Nothing
            Return ByteResult
        End Function
        Public Function DecompressBytes_ToStream(ByRef InputBytes As Byte(), ByRef Output As System.IO.Stream) As Boolean
            Dim MaxSize As Integer = 500000
            Dim Index As UInt32 = 0
            Dim Buffer(MaxSize - 1) As Byte
            Do While Index < InputBytes.Length
                If (Index + MaxSize) >= InputBytes.Length Then MaxSize = InputBytes.Length - Index : ReDim Buffer(MaxSize - 1)
                Array.ConstrainedCopy(InputBytes, Index, Buffer, 0, MaxSize)
                Try
                    Output.Write(Buffer, 0, MaxSize)
                Catch ex As Exception
                    ' ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to DecompressBytes", ex, True)
                    Output.Flush()
                    Return False
                End Try
                Index += MaxSize
            Loop
            Return True
        End Function
#End Region

    End Module
End Namespace
