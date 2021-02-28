Imports System.ComponentModel

Namespace HelperClasses.Wrappers
    <TypeConverter(GetType(ExpandableObjectConverter))> Public NotInheritable Class COH_XML_CrypticS_String

#Region "Properties"
        Public Property Key As String
            Get
                Return mKey
            End Get
            Set(value As String)
                mKey = value
                OnHandleModified()
            End Set
        End Property
        Public Property Localized As String
            Get
                Return mLocalized
            End Get
            Set(value As String)
                mLocalized = value
                OnHandleModified()
            End Set
        End Property
#End Region

#Region "Private Usage"
        Private mKey As String
        Private mLocalized As String
#End Region

#Region "Create New Instance"
        Sub New()
            mKey = String.Empty
            mLocalized = String.Empty
        End Sub
        Sub New(Reference As String)
            mKey = Reference
            mLocalized = mKey
        End Sub
        Sub New(Reference As String, Localized As String)
            mKey = Reference
            mLocalized = Localized
        End Sub
#End Region

#Region "Modifications"
        Public Event WasModified()
        Protected Sub OnHandleModified()
            RaiseEvent WasModified()
        End Sub
#End Region

#Region "Display"
        Public Overrides Function ToString() As String
            Return mKey & " - " & mLocalized
        End Function
#End Region

#Region "Clone/Read/Write"
        Public Function CreateClone() As COH_XML_CrypticS_String
            Dim Destination As New COH_XML_CrypticS_String
            With Destination
                ' .mKey = CloneString(mKey)
                ' .mLocalized = CloneString(mLocalized)
            End With
            Return Destination
        End Function
#End Region
    End Class
End Namespace