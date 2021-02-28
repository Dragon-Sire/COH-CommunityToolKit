Namespace HelperClasses
    Public Class COH_Struct_Vector2
        <Xml.Serialization.XmlAttribute> Property X As Single
        <Xml.Serialization.XmlAttribute> Property Y As Single
        Public Sub New()
        End Sub
        Sub New(X As Single, Y As Single)
            Me.X = X
            Me.Y = Y
        End Sub
        Sub New(values As Single())
            X = values(0)
            Y = values(1)
        End Sub
        Public Overrides Function ToString() As String
            Return String.Format("{0},{1}", New Object(1) {X, Y})
        End Function
    End Class
    Public Class COH_Struct_Vector3
        <Xml.Serialization.XmlAttribute> Property X As Single
        <Xml.Serialization.XmlAttribute> Property Y As Single
        <Xml.Serialization.XmlAttribute> Property Z As Single
        Public Sub New()
        End Sub
        Sub New(X As Single, Y As Single, Z As Single)
            Me.X = X
            Me.Y = Y
            Me.Z = Z
        End Sub
        Sub New(values As Single())
            Me.X = values(0)
            Me.Y = values(1)
            Me.Z = values(2)
        End Sub
        Public Function AddVec3(NewV As COH_Struct_Vector3) As COH_Struct_Vector3
            Return New COH_Struct_Vector3(X + NewV.X, Y + NewV.Y, Z + NewV.Z)
        End Function
        Public Shared Function AddVec3(First As COH_Struct_Vector3, NewV As COH_Struct_Vector3) As COH_Struct_Vector3
            Return New COH_Struct_Vector3(First.X + NewV.X, First.Y + NewV.Y, First.Z + NewV.Z)
        End Function
        Public Function Retrieve_Singles() As Single()
            Dim Result As Single() = New Single(2) {}
            Result(0) = X
            Result(1) = Y
            Result(2) = Z
            Return Result
        End Function
        Public Overrides Function ToString() As String
            Return String.Format("{0},{1},{2}", New Object(2) {X, Y, Z})
        End Function
    End Class
    Public Class COH_Struct_Vector4
        <Xml.Serialization.XmlAttribute> Property X As Single
        <Xml.Serialization.XmlAttribute> Property Y As Single
        <Xml.Serialization.XmlAttribute> Property Z As Single
        <Xml.Serialization.XmlAttribute> Property W As Single
        Public Sub New()

        End Sub
        Sub New(X As Single, Y As Single, Z As Single, W As Single)
            Me.X = X
            Me.Y = Y
            Me.Z = Z
            Me.W = W
        End Sub
        Public Overrides Function ToString() As String
            Return String.Format("{0},{1},{2},{3}", New Object(3) {X, Y, Z, W})
        End Function
    End Class
    Public Class COH_Struct_Degrees
        <Xml.Serialization.XmlAttribute> Property v1 As Single
        <Xml.Serialization.XmlAttribute> Property v2 As Single
        <Xml.Serialization.XmlAttribute> Property v3 As Single
        Public Sub New()

        End Sub
        Sub New(X As Single, Y As Single, Z As Single)
            Me.v1 = X
            Me.v2 = Y
            Me.v3 = Z
        End Sub
    End Class
    Public Class COH_Struct_Weight
        <Xml.Serialization.XmlAttribute> Property W1 As Single
        <Xml.Serialization.XmlAttribute> Property W2 As Single
        Public Sub New()
        End Sub
        Sub New(Weight1 As Single, Weight2 As Single)
            W1 = Weight1
            W2 = Weight2
        End Sub
        Public Overrides Function ToString() As String
            Return String.Format("{0},{1}", New Object(1) {W1, W2})
        End Function
    End Class
    Public Class COH_Struct_MaterialIndex
        <Xml.Serialization.XmlAttribute> Property Pos1 As Single
        <Xml.Serialization.XmlAttribute> Property Pos2 As Single
        Public Sub New()
        End Sub
        Sub New(Position1 As Single, Position2 As Single)
            Pos1 = Position1
            Pos2 = Position2
        End Sub
        Public Overrides Function ToString() As String
            Return String.Format("{0},{1}", New Object(1) {Pos1, Pos2})
        End Function
    End Class
    Public Class COH_Struct_TextureID
        <Xml.Serialization.XmlAttribute> Property ID As Short
        <Xml.Serialization.XmlAttribute> Property Count As Short
        Public Sub New()
        End Sub
        Sub New(TheID As Short, TheCount As Short)
            ID = TheID
            Count = TheCount
        End Sub
    End Class
    Public Class COH_Struct_Matrix4
        <Xml.Serialization.XmlAttribute> Property Vector1 As COH_Struct_Vector3
        <Xml.Serialization.XmlAttribute> Property Vector2 As COH_Struct_Vector3
        <Xml.Serialization.XmlAttribute> Property Vector3 As COH_Struct_Vector3
        <Xml.Serialization.XmlAttribute> Property Vector4 As COH_Struct_Vector3
        Public Sub New()
        End Sub
        Sub New(v1 As COH_Struct_Vector3, v2 As COH_Struct_Vector3, v3 As COH_Struct_Vector3, v4 As COH_Struct_Vector3)
            Vector1 = v1
            Vector2 = v2
            Vector3 = v3
            Vector4 = v4
        End Sub
    End Class
    Public Class COH_Struct_Scale
        <Xml.Serialization.XmlAttribute> Property Value1 As Single
        <Xml.Serialization.XmlAttribute> Property Value2 As Single

        Public Sub New()
        End Sub
        Sub New(v1 As Single, v2 As Single)
            Value1 = v1
            Value2 = v2
        End Sub
    End Class
    Public Class COH_Struct_TriangleIndice
        <Xml.Serialization.XmlAttribute> Property Value1 As Integer
        <Xml.Serialization.XmlAttribute> Property Value2 As Integer
        <Xml.Serialization.XmlAttribute> Property Value3 As Integer
        Public Sub New()
        End Sub
        Sub New(v1 As Integer, v2 As Integer, v3 As Integer)
            Value1 = v1
            Value2 = v2
            Value3 = v3
        End Sub
        Sub New(values As Integer())
            Value1 = values(0)
            Value2 = values(1)
            Value3 = values(2)
        End Sub
        Public Overrides Function ToString() As String
            Return String.Format("{0},{1},{2}", New Object(2) {Value1, Value2, Value3})
        End Function
    End Class
    Public Class COH_Struct_Quat
        <Xml.Serialization.XmlAttribute> Property Q1 As Single
        <Xml.Serialization.XmlAttribute> Property Q2 As Single
        <Xml.Serialization.XmlAttribute> Property Q3 As Single
        <Xml.Serialization.XmlAttribute> Property Q4 As Single
        Public Sub New()
        End Sub
        Sub New(X As Single, Y As Single, Z As Single, W As Single)
            Me.Q1 = X
            Me.Q2 = Y
            Me.Q3 = Z
            Me.Q4 = W
        End Sub
        Sub New(values As Single())
            Me.Q1 = values(0)
            Me.Q2 = values(1)
            Me.Q3 = values(2)
            Me.Q4 = values(3)
        End Sub
        Public Function Retrieve_Singles() As Single()
            Dim Result As Single() = New Single(3) {}
            Result(0) = Q1
            Result(1) = Q2
            Result(2) = Q3
            Result(3) = Q4
            Return Result
        End Function
        Public Overrides Function ToString() As String
            Return String.Format("{0},{1},{2},{3}", New Object(3) {Q1, Q2, Q3, Q4})
        End Function
    End Class
End Namespace