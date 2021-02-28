Imports COH.CodeManagement.Enums.Binary

Namespace Storage.Serialization
    Partial Public NotInheritable Class COH_BinaryWriter

#Region "Bytes"
        Public Overloads Sub Write(values As Byte(), Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then MyBase.Write(values)
            Array.Reverse(values)
            MyBase.Write(values)
        End Sub
#End Region

#Region "NumericValues"
        Public Overloads Sub Write(value As Int16, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value)
            Else
                Write(BitConverter.GetBytes(value), COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As Int32, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value)
            Else
                Write(BitConverter.GetBytes(value), COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As Int64, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value)
            Else
                Write(BitConverter.GetBytes(value), COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As UInt16, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value)
            Else
                Write(BitConverter.GetBytes(value), COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As UInt32, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value)
            Else
                Write(BitConverter.GetBytes(value), COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As UInt64, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value)
            Else
                Write(BitConverter.GetBytes(value), COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As Single, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value)
            Else
                Write(BitConverter.GetBytes(value), COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As Double, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value)
            Else
                Write(BitConverter.GetBytes(value), COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As Decimal, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value)
            Else
                Dim TheBytes As Byte() = HelperFunctions.Bytes.ConvertDecimal_ToBytes(value)
                Write(TheBytes, COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
#End Region
    End Class
End Namespace