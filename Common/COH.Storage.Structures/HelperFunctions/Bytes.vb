Imports COH.CodeManagement.Enums.Binary
Imports COH.GameContent.CodeManagement.Enums.Structures

Namespace HelperFunctions.Bytes
    <HideModuleName> Public Module DS_HelperFunctions_ByteFunctions

#Region "Random"
        Public Function Generate_RandomByte() As Byte
            Dim Generator As System.Random = New System.Random(Guid.NewGuid().GetHashCode())
            Return CByte(Generator.Next(0, 255))
        End Function
        Public Function Generate_RandomBytes(Count As Integer) As Byte()
            Dim Result As Byte() = New Byte(Count - 1) {}
            Dim Generator As System.Random = New System.Random(Guid.NewGuid().GetHashCode())
            Generator.NextBytes(Result)
            Return Result
        End Function
#End Region

#Region "String Length Markers"
        Public Function ConvertInt32_7BitEncoded(ByVal value As Integer) As Byte()
            Dim Result As New List(Of Byte)
            Dim num As UInt32 = value
            Do While (num >= &H80)
                Dim TempValue As Byte = Convert.ToByte((num Or 128) And &HFF)
                Result.Add(CByte(TempValue))
                num = (num >> 7)
            Loop
            Result.Add(CByte(num))
            Return Result.ToArray
        End Function
#End Region

#Region "Decimals"
        Public Function ConvertBytes_ToDecimal(ByRef TheBytes As Byte(), Offset As Integer) As Decimal
            Dim Values As Int32()
            ReDim Values(3)
            Values(0) = BitConverter.ToInt32(TheBytes, Offset)
            Values(1) = BitConverter.ToInt32(TheBytes, Offset + 4)
            Values(2) = BitConverter.ToInt32(TheBytes, Offset + 8)
            Values(3) = BitConverter.ToInt32(TheBytes, Offset + 12)
            Return New Decimal(Values)
        End Function
        Public Function ConvertDecimal_ToBytes(value As Decimal, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.LittleEndian) As Byte()
            Dim bits As Int32() = Decimal.GetBits(value)
            Dim bytes As New List(Of Byte)
            For Each i As Int32 In bits
                If ByteOrder = COH_Supported_BinaryByteOrder.BigEndian Then
                    Dim Result As Byte() = BitConverter.GetBytes(i)
                    Array.Reverse(Result)
                    bytes.AddRange(Result)
                Else
                    bytes.AddRange(BitConverter.GetBytes(i))
                End If
            Next
            Return bytes.ToArray
        End Function
#End Region

#Region "Extentions"
        <Runtime.CompilerServices.Extension()> Public Function ReadInt32_7BitEncoded(ByRef CurrentReader As IO.BinaryReader) As Integer
            Dim num3 As Byte, num As Integer = 0, BitCount As Integer = 0
            Do
                '//If (BitCount = 35) Then LibraryErrors.OnNotifyErrorOccured(New FormatException(""))
                If (BitCount = 35) Then Throw New FormatException("")
                num3 = CurrentReader.ReadByte()
                num = (num Or ((num3 And 127) << BitCount))
                BitCount += 7
            Loop While ((num3 And 128) <> 0)
            Return num
        End Function
#End Region

#Region "Write"
        Public Function Write_BytesToFile(ByRef SourceStream As IO.Stream, FilePath As String) As Boolean
            Dim CurrentStream As IO.FileStream
            CurrentStream = New IO.FileStream(FilePath, System.IO.FileMode.OpenOrCreate)
            SourceStream.CopyTo(CurrentStream)
            CurrentStream.Close()
            Return True
        End Function
        Public Function Write_BytesToFile(ByRef ByteBuffer As Byte(), FilePath As String) As Boolean
            Dim CurrentStream As IO.FileStream
            CurrentStream = New IO.FileStream(FilePath, System.IO.FileMode.OpenOrCreate)
            CurrentStream.Write(ByteBuffer, 0, ByteBuffer.Length)
            CurrentStream.Close()
            Return True
        End Function
#End Region
    End Module
End Namespace