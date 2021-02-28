Namespace Storage.Controllers
    Public Class COH_FSI_Section
        Property SectionName As String
        Property SectionType As Type
        Sub New()
        End Sub
        Sub New(Name As String, TheType As Type)
            SectionName = Name
            SectionType = TheType
        End Sub
        Sub New(TheType As Type)
            SectionName = "Root"
            SectionType = TheType
        End Sub
    End Class
End Namespace
