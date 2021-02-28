Imports System.Drawing
Imports COH.CodeManagement.Enums.Binary

Namespace Storage.Serialization
    Partial Public NotInheritable Class COH_BinaryWriter
        Implements IDisposable

#Region "Drawing"
        Public Overloads Sub Write(value As Rectangle, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            Write(value.Location, ByteOrder)
            Write(value.Size, ByteOrder)
        End Sub
        Public Overloads Sub Write(value As Point, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value.X)
                MyBase.Write(value.Y)
            Else
                Write(value.X, COH_Supported_BinaryByteOrder.BigEndian)
                Write(value.Y, COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As Size, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value.Width)
                MyBase.Write(value.Height)
            Else
                Write(value.Width, COH_Supported_BinaryByteOrder.BigEndian)
                Write(value.Height, COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As RectangleF, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            Write(value.Location, ByteOrder)
            Write(value.Size, ByteOrder)
        End Sub
        Public Overloads Sub Write(value As PointF, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value.X)
                MyBase.Write(value.Y)
            Else
                Write(value.X, COH_Supported_BinaryByteOrder.BigEndian)
                Write(value.Y, COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As SizeF, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value.Width)
                MyBase.Write(value.Height)
            Else
                Write(value.Width, COH_Supported_BinaryByteOrder.BigEndian)
                Write(value.Height, COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
        Public Overloads Sub Write(value As Color, Optional ByteOrder As COH_Supported_BinaryByteOrder = COH_Supported_BinaryByteOrder.Default)
            If ByteOrder = COH_Supported_BinaryByteOrder.LittleEndian Then
                MyBase.Write(value.ToArgb)
            Else
                Write(value.ToArgb, COH_Supported_BinaryByteOrder.BigEndian)
            End If
        End Sub
#End Region

    End Class
End Namespace