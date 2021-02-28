Imports System.ComponentModel
Imports System.Xml.Serialization

Namespace HelperClasses.Wrappers
    <TypeConverter(GetType(ExpandableObjectConverter))> Public NotInheritable Class COH_XML_Color


#Region "Properties"
        <XmlIgnoreAttribute> Public Property Color As Drawing.Color
            Get
                Return mColor
            End Get
            Set(value As Drawing.Color)
                mColor = value
            End Set
        End Property
        Public Property ColorValue As Integer
            Get
                Return mColor.ToArgb
            End Get
            Set(value As Integer)
                mColor = Drawing.Color.FromArgb(value)
            End Set
        End Property
#End Region

#Region "Private Usage"
        Private mColor As Drawing.Color
#End Region

#Region "Create New Instance"
        Sub New()
            MyBase.New
        End Sub
        Sub New(SelectedColor As Drawing.Color)
            Me.New
            mColor = SelectedColor
        End Sub
        Sub New(SelectedColor As Integer)
            Me.New
            mColor = Drawing.Color.FromArgb(SelectedColor)
        End Sub
        Sub New(SelectedColor As String)
            Me.New
            mColor = Drawing.Color.FromName(SelectedColor)
        End Sub
#End Region

#Region "Modifications"
        Public Event ColorWasModified()
        Protected Sub OnHandleModified()
            RaiseEvent ColorWasModified()
        End Sub
#End Region

#Region "Display"
        Public Overrides Function ToString() As String
            Return Return_ColorAsHoverString()
        End Function
        Public Function Return_ColorAsHoverString() As String
            Return "Red (" & mColor.R & ") Green (" & mColor.G & ") Blue (" & mColor.B & ")"
        End Function
#End Region

#Region "Converting"
        Public Shared Widening Operator CType(ByVal value As Drawing.Color) As COH_XML_Color
            Return New COH_XML_Color(value)
        End Operator
        Public Shared Widening Operator CType(ByVal value As String) As COH_XML_Color
            Return New COH_XML_Color(value)
        End Operator
        Public Shared Widening Operator CType(ByVal value As Integer) As COH_XML_Color
            Return New COH_XML_Color(value)
        End Operator
        Public Shared Widening Operator CType(ByVal value As COH_XML_Color) As Drawing.Color
            Return value.Color
        End Operator
        Public Shared Widening Operator CType(ByVal value As COH_XML_Color) As Integer
            Return value.ColorValue
        End Operator
        Public Shared Widening Operator CType(ByVal value As COH_XML_Color) As String
            Return value.Color.Name
        End Operator
#End Region

#Region "Clone/Read/Write"
        Public Function CreateClone() As COH_XML_Color
            Dim Destination As New COH_XML_Color
            With Destination
                .mColor = mColor
            End With
            Return Destination
        End Function
#End Region
    End Class
End Namespace