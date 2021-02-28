Imports COH.CodeManagement.Enums.Binary

Namespace HelperFunctions.Bits
    <HideModuleName()> Public Module COH_Bit_HelperFunctions

#Region "Enums"
        Enum BitMasks
            BIT0 = &H1
            BIT1 = &H2
            BIT2 = &H4
            BIT3 = &H8
            BIT4 = &H10
            BIT5 = &H20
            BIT6 = &H40
            BIT7 = &H80
            BIT8 = &H100
            BIT9 = &H200
            BIT10 = &H400
            BIT11 = &H800
            BIT12 = &H1000
            BIT13 = &H2000
            BIT14 = &H4000
            BIT15 = &H8000
            BIT16 = &H10000
            BIT17 = &H20000
            BIT18 = &H40000
            BIT19 = &H80000
            BIT20 = &H100000
            BIT21 = &H200000
            BIT22 = &H400000
            BIT23 = &H800000
            BIT24 = &H1000000
            BIT25 = &H2000000
            BIT26 = &H4000000
            BIT27 = &H8000000
            BIT28 = &H10000000
            BIT29 = &H20000000
            BIT30 = &H40000000
            BIT31 = &H80000000
        End Enum
#End Region

#Region "Convert From BinaryString"
        Public Function Convert_ToUint32_FromBinaryString(ByVal binarystring As String) As UInt32
            binarystring = binarystring.Replace(" ", "")
            Dim BinaryNum As ULong
            For X = 0 To binarystring.Length - 1
                BinaryNum += (binarystring.Substring(X, 1) * (2 ^ (31 - X)))
            Next
            Return (BinaryNum And &HFFFFFFFFL)
        End Function
#End Region

#Region "Convert to Booleans"
        Public Function Return_IsBitSet_InByte(Value As Byte, Index As Integer) As Boolean
            Dim Mask As Byte = CByte(1) << (8 - Index)
            Return Value And Mask
        End Function
        Public Function Convert_ToBooleans(value As Byte) As Boolean()
            Dim Result = New Boolean(7) {}
            For X = 0 To 7
                Result(X) = Return_IsBitSet_InByte(value, X)
            Next
            Return Result
        End Function
        Public Function Convert_ToBooleans(values As Byte()) As Boolean()
            Dim Result = New Boolean((values.Count * 8) - 1) {}
            Dim Index As Integer = 0
            For Z = 0 To values.Count - 1
                For X = 0 To 7
                    Result(Index) = Return_IsBitSet_InByte(values(Z), X + 1)
                    Index += 1
                Next
            Next
            Return Result
        End Function
        Public Function Convert_ToByte(Values As Boolean()) As Byte
            Dim Result As Byte = 0
            For X = 0 To Values.Count - 2
                If Values(X) = True Then Result += (2 ^ ((Values.Count - X) - 1))
                If X = 6 Then Exit For
            Next
            If Values(Values.Count - 1) = True Then Result += 1
            Return Result
        End Function
        Public Function Convert_ToBytes(Values As Boolean(), Optional AligntoByte As Boolean = True, Optional PadFront As Boolean = True) As Byte()
            Dim TheValues As Boolean() = AlignBooleans_ToBytes(Values, AligntoByte, PadFront)
            Dim NumBytes As Integer = TheValues.Count \ 8
            Dim Results = New Byte(NumBytes - 1) {}
            Dim Start As Integer = 0
            For ByteIndex = 0 To NumBytes - 1
                Dim Result As Byte = 0
                Start = 8 * ByteIndex
                For X = 0 To 6
                    If TheValues(X + Start) = True Then Result += (2 ^ ((8 - X) - 1))
                Next
                If TheValues(7 + Start) = True Then Result += 1
                Results(ByteIndex) = Result
            Next
            Return Results.ToArray
        End Function
        Public Function AlignBooleans_ToBytes(Values As Boolean(), Optional AligntoByte As Boolean = True, Optional PadFront As Boolean = True) As Boolean()
            Dim ConvertedBytesCount As Integer = (Values.Count \ 8)
            Dim Remaining As Integer = Values.Count Mod 8
            If Remaining > 0 Then
                ConvertedBytesCount += 1
            End If
            Dim NewSourceArray = New Boolean((ConvertedBytesCount * 8) - 1) {}
            If PadFront = True Then
                Array.ConstrainedCopy(Values, 0, NewSourceArray, (8 - Remaining), Values.Count)
            Else
                Array.ConstrainedCopy(Values, 0, NewSourceArray, 0, Values.Count)
            End If
            Return NewSourceArray
        End Function
#End Region

#Region "Convert to String"
        Public Function Convert_ToString(TheBytes As Byte(), Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.LittleEndian, Optional SeperateBytes As Boolean = False) As String
            Dim Result As String = ""
            For X = 0 To TheBytes.Length - 1
                Result += Convert_ToString(TheBytes(X), ByteOrder)
                If SeperateBytes = True And X < (TheBytes.Length - 1) Then Result += " "
            Next
            Return Result
        End Function
        Public Function Convert_ToString(value As Byte, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.LittleEndian) As String
            Dim Result As String = Convert.ToString(value, 2).PadLeft(8, "0")
            If ByteOrder = COH_Supported_BinaryByteOrder.BigEndian Then Array.Reverse(Result.ToCharArray())
            Return Result
        End Function
        Public Function Convert_ToString(value As Int16, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.LittleEndian, Optional SeperateBytes As Boolean = True) As String
            Dim Result As String = Convert.ToString(value, 2).PadLeft(16, "0")
            If ByteOrder = COH_Supported_BinaryByteOrder.BigEndian Then Array.Reverse(Result.ToCharArray())
            If SeperateBytes = False Then Return Result
            Return Split_BinaryString(Result)
        End Function
        Public Function Convert_ToString(value As Int32, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.LittleEndian, Optional SeperateBytes As Boolean = True) As String
            Dim Result As String = Convert.ToString(value, 2).PadLeft(32, "0")
            If ByteOrder = COH_Supported_BinaryByteOrder.BigEndian Then Array.Reverse(Result.ToCharArray())
            If SeperateBytes = False Then Return Result
            Return Split_BinaryString(Result)
        End Function
        Public Function Convert_ToString(value As Int64, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.LittleEndian, Optional SeperateBytes As Boolean = True) As String
            Dim Result As String = Convert.ToString(value, 2).PadLeft(64, "0")
            If ByteOrder = COH_Supported_BinaryByteOrder.BigEndian Then Array.Reverse(Result.ToCharArray())
            If SeperateBytes = False Then Return Result
            Return Split_BinaryString(Result)
        End Function
        Private Function Split_BinaryString(Value As String) As String
            Dim Result As String = ""
            Dim Numloops As Integer = Value.Length / 8
            For X = 0 To Numloops - 1
                If Not X = Numloops - 1 Then
                    Result += Value.Substring(X * 8, 8) & " "
                Else
                    Result += Value.Substring(X * 8, 8)
                End If
            Next
            Return Result
        End Function
#End Region

#Region "Convert to String - Unsigned"
        Public Function Convert_ToString(value As UInt16, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.LittleEndian, Optional SeperateBytes As Boolean = True) As String
            Dim Result As String = Convert_ToString(value, 16)
            If SeperateBytes = False Then Return Result
            Return Split_BinaryString(Result)
        End Function
        Public Function Convert_ToString(value As UInt32, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.LittleEndian, Optional SeperateBytes As Boolean = True) As String
            Dim Result As String = Convert_ToString(value, 32)
            If SeperateBytes = False Then Return Result
            Return Split_BinaryString(Result)
        End Function
        Public Function Convert_ToString(value As UInt64, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.LittleEndian, Optional SeperateBytes As Boolean = True) As String
            Dim Result As String = Convert_ToString(value, 64)
            If SeperateBytes = False Then Return Result
            Return Split_BinaryString(Result)
        End Function
        Public Function Convert_ToString(ByVal value As UInt64, Length As Integer) As String
            Dim BaseString As String = "0123456789ABCDEFGHIZKLMNOPQRSTUVWXYZ"
            Dim DivisibleNum As Long, NumberofDivisible As Double, ValidFound As Boolean = False
            Dim ResultString As String = ""
            For X = Length To 1 Step -1
                DivisibleNum = 2 ^ X
                NumberofDivisible = value \ DivisibleNum
                If NumberofDivisible >= 1 Then
                    value = value - (NumberofDivisible * DivisibleNum)
                    ValidFound = True
                End If
                If ValidFound = True Then ResultString += BaseString.Substring(NumberofDivisible, 1)
            Next
            Dim remainder As Integer = value
            ResultString += BaseString.Substring(remainder, 1)
            Return ResultString
        End Function
#End Region

#Region "Convert to Bit Array"
        Public Function Convert_ToStringArray(TheBytes As Byte(), Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.LittleEndian) As String()
            Dim Result(TheBytes.Length - 1) As String
            For X = 0 To TheBytes.Length - 1
                Result(X) = Convert_ToString(TheBytes(X), ByteOrder)
            Next
            Return Result
        End Function
        Public Function Convert_ToStringArray(TheBytes As Byte()) As String
            Dim newBin As New Text.StringBuilder
            For x = 0 To TheBytes.Count - 1
                If x > 0 Then newBin.Append(" ")
                newBin.Append(Convert.ToString(TheBytes(x), 2).PadLeft(8, "0"))
            Next
            Return newBin.ToString
        End Function
#End Region

#Region "Bit Shifting Right- Standard (Sign Propragating)"
        Public Function BitShift_Standard_Right(value As Byte, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As Byte
            If ZeroOnGreaterShift = True And Count > 8 Then Return 0
            Dim Result As Byte = value >> Count
            Return Result
        End Function
        Public Function BitShift_Standard_Right(value As SByte, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As SByte
            If ZeroOnGreaterShift = True And Count > 8 Then Return 0
            Dim Result As SByte = value >> Count
            Return Result
        End Function
        Public Function BitShift_Standard_Right(value As UInt16, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As UInt16
            If ZeroOnGreaterShift = True And Count > 16 Then Return 0
            Dim Result As UInt16 = value >> Count
            Return Result
        End Function
        Public Function BitShift_Standard_Right(value As UInt32, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As UInt32
            If ZeroOnGreaterShift = True And Count > 32 Then Return 0
            Dim Result As UInt32 = value >> Count
            Return Result
        End Function
        Public Function BitShift_Standard_Right(value As UInt64, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As UInt64
            If ZeroOnGreaterShift = True And Count > 64 Then Return 0
            Dim Result As UInt64 = value >> Count
            Return Result
        End Function
        Public Function BitShift_Standard_Right(value As Int16, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As Int16
            If ZeroOnGreaterShift = True And Count > 16 Then Return 0
            Dim Result As Int16 = value >> Count
            Return Result
        End Function
        Public Function BitShift_Standard_Right(value As Int32, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As Int32
            If ZeroOnGreaterShift = True And Count > 32 Then Return 0
            Dim Result As Int32 = value >> Count
            Return Result
        End Function
        Public Function BitShift_Standard_Right(value As Int64, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As Int64
            If ZeroOnGreaterShift = True And Count > 64 Then Return 0
            Dim Result As Int64 = value >> Count
            Return Result
        End Function
#End Region

#Region "Bit Shifting Right - Zero Fill"
        Public Function BitShift_ZeroFill_Right(value As SByte, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As Byte
            If value >= 0 Then Return BitShift_Standard_Right(value, Count, ZeroOnGreaterShift)
            Dim Result As SByte = BitShift_Standard_Right(value, Count, ZeroOnGreaterShift)
            For X = 0 To Count - 1
                Result = ClearBit(Result, CByte(7 - X))
            Next
            Return Result
        End Function
        Public Function BitShift_ZeroFill_Right(value As Int16, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As Int16
            If value >= 0 Then Return BitShift_Standard_Right(value, Count, ZeroOnGreaterShift)
            Dim Result As Int16 = BitShift_Standard_Right(value, Count, ZeroOnGreaterShift)
            For X = 0 To Count - 1
                Result = ClearBit(Result, CByte(15 - X))
            Next
            Return Result
        End Function
        Public Function BitShift_ZeroFill_Right(value As Int32, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As Int32
            If value >= 0 Then Return BitShift_Standard_Right(value, Count, ZeroOnGreaterShift)
            Dim Result As Int32 = BitShift_Standard_Right(value, Count, ZeroOnGreaterShift)
            For X = 0 To Count - 1
                Result = ClearBit(Result, CByte(31 - X))
            Next
            Return Result
        End Function
        Public Function BitShift_ZeroFill_Right(value As Int64, Count As Byte, Optional ZeroOnGreaterShift As Boolean = False) As Int64
            If value >= 0 Then Return BitShift_Standard_Right(value, Count, ZeroOnGreaterShift)
            Dim Result As Int64 = BitShift_Standard_Right(value, Count, ZeroOnGreaterShift)
            For X = 0 To Count - 1
                Result = ClearBit(Result, CByte(63 - X))
            Next
            Return Result
        End Function
#End Region

#Region "Bit Shifting - Circular, Rotate Left"
        Public Function BitWise_RotateLeft_Int16(value As Int16, count As Integer) As Int16
            Return (value << count) Or (value >> (16 - count))
        End Function
        Public Function BitWise_RotateLeft_UInt16(value As UInt16, count As Integer) As UInt16
            Return (value << count) Or (value >> (16 - count))
        End Function
        Public Function BitWise_RotateLeft_Int32(value As Int32, count As Integer) As Int32
            Return (value << count) Or (value >> (32 - count))
        End Function
        Public Function BitWise_RotateLeft_UInt32(value As UInt32, count As Integer) As UInt32
            Return (value << count) Or (value >> (32 - count))
        End Function
#End Region

#Region "Bit Shifting - Circular, Rotate Right"
        Public Function BitWise_RotateRight_ZeroFill(value As UInt32, count As Byte) As UInt32
            value = (value And &HFFFFFFFFL)
            Dim R1 As Object = BitShift_ZeroFill_Right(value, count)
            Dim R2 As Object = (value << (32 - count))
            Dim R3 As UInt32 = ((CUInt(R1) Or CUInt(R2)) And &HFFFFFFFFL) 'THIS MODIFIED IN PORTABLE
            If R3 < 0 Then
                Dim TheBits As String = Bits.Convert_ToString(R3, COH_Supported_BinaryByteOrder.LittleEndian, False)
                Return Convert_ToUint32_FromBinaryString(TheBits)
            End If
            Return R3
        End Function
#End Region

#Region "Set Bits"
        Function SetBit(ByVal value As SByte, ByVal bit As Byte) As SByte
            Dim mask As Byte
            mask = 2 ^ bit
            If mask > SByte.MaxValue Then
                Return (SByte.MinValue + value) Or mask
            Else
                Return value Or mask
            End If
        End Function
        Function SetBit(ByVal value As Int16, ByVal bit As Byte) As Int16
            Dim mask As UInt16
            mask = 2 ^ bit
            If mask > Int16.MaxValue Then
                Return (Int16.MinValue + value) Or mask
            Else
                Return value Or mask
            End If
        End Function
        Function SetBit(ByVal value As Int32, ByVal bit As Byte) As Int32
            Dim mask As UInt32
            mask = 2 ^ bit
            If mask > Int32.MaxValue Then
                Return (Int32.MinValue + value) Or mask
            Else
                Return value Or mask
            End If
        End Function
        Function SetBit(ByVal value As Int64, ByVal bit As Byte) As Int64
            Dim mask As UInt64
            mask = 2 ^ bit
            If mask > Int64.MaxValue Then
                Return (Int64.MinValue + value) Or mask
            Else
                Return value Or mask
            End If
        End Function
#End Region

#Region "Clear Bits"
        Function ClearBit(ByVal value As Byte, ByVal bit As Byte) As Byte
            Dim BitMask As Byte
            BitMask = 2 ^ bit
            Return (value And Not BitMask)
        End Function
        Function ClearBit(ByVal value As Int16, ByVal bit As Byte) As Int16
            Dim BitMask As UInt16
            BitMask = 2 ^ bit
            Return (value And Not BitMask)
        End Function
        Function ClearBit(ByVal value As Int32, ByVal bit As Byte) As Int32
            Dim BitMask As UInt32
            BitMask = 2 ^ bit
            Return (value And Not BitMask)
        End Function
        Function ClearBit(ByVal value As Int64, ByVal bit As Byte) As Int64
            Dim BitMask As UInt64
            BitMask = 2 ^ bit
            Return (value And Not BitMask)
        End Function
#End Region

#Region "Check Bits"
        Function CheckBit(ByVal value As Int16, ByVal bit As Byte) As Boolean
            Dim BitMask As UInt16
            BitMask = 2 ^ bit
            Return ((value And BitMask) > 0)
        End Function
        Function CheckBit(ByVal value As Int32, ByVal bit As Byte) As Boolean
            Dim BitMask As UInt32
            BitMask = 2 ^ bit
            Return ((value And BitMask) > 0)
        End Function
        Function CheckBit(ByVal value As Int64, ByVal bit As Byte) As Boolean
            Dim BitMask As UInt64
            BitMask = 2 ^ bit
            Return ((value And BitMask) > 0)
        End Function
#End Region

#Region "Reverse"
        Public Function Reverse_BitOrder(ByVal x As UInteger) As UInteger
            Dim y As UInteger = 0
            For i As Integer = 0 To 31
                y <<= 1
                y = y Or (x And 1)
                x >>= 1
            Next i
            Return y
        End Function
#End Region

    End Module
End Namespace
