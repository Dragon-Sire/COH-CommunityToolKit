Imports System.Drawing
Imports COH.CodeManagement.Enums.Binary

Namespace Storage.Serialization
    Partial Public NotInheritable Class COH_BinaryReader

#Region "Bytes"
        Public Overrides Function ReadByte() As Byte
            Dim Result = MyBase.ReadByte : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadSByte() As SByte
            Dim Result = MyBase.ReadSByte : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadBytes(count As Integer) As Byte()
            Dim Result = MyBase.ReadBytes(count) : OnPositionChanged()
            Return Result
        End Function
        Public Overloads Function ReadBytes(count As Integer, ByteOrder As COH_Supported_BinaryByteOrder) As Byte()
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return ReadBytes(count)
            Return ReadBytes_BigEndian(count)
        End Function
        Public Overloads Function ReadBytes_BigEndian(count As Integer) As Byte()
            Dim TheBytes As Byte() = ReadBytes(count)
            Array.Reverse(TheBytes)
            Return TheBytes
        End Function
#End Region

#Region "NumericValues"
        Public Overrides Function ReadInt16() As Int16
            Dim Result = MyBase.ReadInt16() : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadInt32() As Int32
            Dim Result = MyBase.ReadInt32() : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadInt64() As Int64
            Dim Result = MyBase.ReadInt64() : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadUInt16() As UInt16
            Dim Result = MyBase.ReadUInt16() : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadUInt32() As UInt32
            Dim Result = MyBase.ReadUInt32() : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadUInt64() As UInt64
            Dim Result = MyBase.ReadUInt64() : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadSingle() As Single
            Dim Result = MyBase.ReadSingle() : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadDouble() As Double
            Dim Result = MyBase.ReadDouble() : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadDecimal() As Decimal
            Dim Result = MyBase.ReadDecimal() : OnPositionChanged()
            Return Result
        End Function
#End Region

#Region "NumericValues"
        Public Overloads Function ReadInt16(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As Int16
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return ReadInt16()
            Return BitConverter.ToInt16(ReadBytes_BigEndian(2), 0)
        End Function
        Public Overloads Function ReadInt32(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As Int32
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return ReadInt32()
            Return BitConverter.ToInt32(ReadBytes_BigEndian(4), 0)
        End Function
        Public Overloads Function ReadInt64(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As Int64
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return ReadInt64()
            Return BitConverter.ToInt64(ReadBytes_BigEndian(8), 0)
        End Function
        Public Overloads Function ReadUInt16(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As UInt16
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return ReadUInt16()
            Return BitConverter.ToUInt16(ReadBytes_BigEndian(2), 0)
        End Function
        Public Overloads Function ReadUInt32(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As UInt32
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return ReadUInt32()
            Return BitConverter.ToUInt32(ReadBytes_BigEndian(4), 0)
        End Function
        Public Overloads Function ReadUInt64(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As UInt64
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return ReadUInt64()
            Return BitConverter.ToUInt64(ReadBytes_BigEndian(8), 0)
        End Function
        Public Overloads Function ReadSingle(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As Single
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return ReadSingle()
            Return BitConverter.ToSingle(ReadBytes_BigEndian(4), 0)
        End Function
        Public Overloads Function ReadDouble(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As Double
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return ReadDouble()
            Return BitConverter.ToDouble(ReadBytes_BigEndian(8), 0)
        End Function
        Public Overloads Function ReadDecimal(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As Decimal
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return ReadDecimal()
            Dim TheBytes As Byte() = ReadBytes_BigEndian(16)
            Return HelperFunctions.Bytes.ConvertBytes_ToDecimal(TheBytes, 0)
        End Function
#End Region

#Region "Charaters & Strings"
        Public Overrides Function ReadChar() As Char
            Dim Result = MyBase.ReadChar() : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadChars(count As Integer) As Char()
            Dim Result = MyBase.ReadChars(count) : OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadString() As String
            Dim Result = MyBase.ReadString() : OnPositionChanged()
            Return Result
        End Function
#End Region

#Region "Other"
        Public Shadows Function Read7BitEncodedInt() As Int32
            Dim Result = MyBase.Read7BitEncodedInt()
            OnPositionChanged()
            Return Result
        End Function
        Public Overrides Function ReadBoolean() As Boolean
            Dim Result = MyBase.ReadBoolean : OnPositionChanged()
            Return Result
        End Function
        Public Function ReadDate() As Date
            Dim Result = DateTime.FromBinary(MyBase.ReadInt64) : OnPositionChanged()
            Return Result
        End Function
#End Region

#Region "Drawing"
        Public Function ReadColor_ARGB(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As Color
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return Drawing.Color.FromArgb(MyBase.ReadInt32)
            Return Drawing.Color.FromArgb(ReadInt32(COH_Supported_BinaryByteOrder.BigEndian))
        End Function
        Public Function ReadRectangle(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As Rectangle
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return New Drawing.Rectangle(ReadPoint(), ReadSize())
            Return New Drawing.Rectangle(ReadPoint(COH_Supported_BinaryByteOrder.BigEndian), ReadSize(COH_Supported_BinaryByteOrder.BigEndian))
        End Function
        Public Function ReadPoint(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As Point
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return New Drawing.Point(MyBase.ReadInt32(), MyBase.ReadInt32())
            Return New Drawing.Point(ReadInt32(COH_Supported_BinaryByteOrder.BigEndian), ReadInt32(COH_Supported_BinaryByteOrder.BigEndian))
        End Function
        Public Function ReadSize(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As Size
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return New Drawing.Size(MyBase.ReadInt32(), MyBase.ReadInt32())
            Return New Drawing.Size(ReadInt32(COH_Supported_BinaryByteOrder.BigEndian), ReadInt32(COH_Supported_BinaryByteOrder.BigEndian))
        End Function
        Public Function ReadRectangleF(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As RectangleF
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return New Drawing.RectangleF(ReadPointF(), ReadSizeF())
            Return New Drawing.RectangleF(ReadPointF(COH_Supported_BinaryByteOrder.BigEndian), ReadSizeF(COH_Supported_BinaryByteOrder.BigEndian))
        End Function
        Public Function ReadPointF(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As PointF
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return New Drawing.PointF(MyBase.ReadInt32(), MyBase.ReadInt32())
            Return New Drawing.PointF(ReadSingle(COH_Supported_BinaryByteOrder.BigEndian), ReadSingle(COH_Supported_BinaryByteOrder.BigEndian))
        End Function
        Public Function ReadSizeF(Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default) As SizeF
            Dim UsedByteOrder As COH_Supported_BinaryByteOrder = DetermineByteOrder(ByteOrder)
            If UsedByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then Return New Drawing.SizeF(MyBase.ReadInt32(), MyBase.ReadInt32())
            Return New Drawing.SizeF(ReadSingle(COH_Supported_BinaryByteOrder.BigEndian), ReadSingle(COH_Supported_BinaryByteOrder.BigEndian))
        End Function
#End Region
    End Class
End Namespace