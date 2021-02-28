Namespace Storage.Serialization
    Partial Public NotInheritable Class COH_BinaryWriter

#Region "Bytes"
        Public Overrides Sub Write(value As Byte)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As SByte)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As Byte())
            MyBase.Write(value)
        End Sub
        Private Sub WriteBytes_Buffered(ByRef value As Byte())
            Dim Length As Integer = 4096
            For X = 0 To value.Length Step 4096
                If (X + 4096) > value.Length Then
                    Length = (value.Length) - X
                End If
                MyBase.Write(value, X, Length)
            Next
        End Sub
        Public Overrides Sub Write(Values() As Byte, StartIndex As Integer, Count As Integer)
            MyBase.Write(Values, StartIndex, Count)
        End Sub
#End Region

#Region "NumericValues"
        Public Overrides Sub Write(value As Int16)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As Int32)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As Int64)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As UInt16)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As UInt32)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As UInt64)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As Single)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As Double)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As Decimal)
            MyBase.Write(value)
        End Sub
#End Region

#Region "Charaters & Strings"
        Public Overrides Sub Write(value As Char)
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As Char())
            MyBase.Write(value)
        End Sub
        Public Overrides Sub Write(value As String)
            MyBase.Write(value)
        End Sub
#End Region

#Region "Other"
        Public Overrides Sub Write(value As Boolean)
            MyBase.Write(value)
        End Sub
        Public Overloads Sub Write(value As Date)
            MyBase.Write(BitConverter.GetBytes(value.ToBinary))
        End Sub
#End Region
    End Class
End Namespace