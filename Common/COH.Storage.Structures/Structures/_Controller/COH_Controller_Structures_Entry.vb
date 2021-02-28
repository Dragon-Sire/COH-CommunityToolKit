Imports COH.CodeManagement.Enums.Structures

Namespace Storage.Controllers
    Public Class COH_FSI_Entry
        Property EntryName As String
        Property ContentType As COH_Supported_ContentType = COH_Supported_ContentType.Resource_BIN_CrypticS
        Property SingleRoot As Boolean
        Property BuildChecks As List(Of UInt32)
        Property Sections As List(Of COH_FSI_Section)
        Sub New()
            Sections = New List(Of COH_FSI_Section)
            BuildChecks = New List(Of UInt32)
        End Sub
        Sub New(Name As String, TheType As COH_Supported_ContentType, Optional ListIds As List(Of UInt32) = Nothing, Optional TheSections As List(Of COH_FSI_Section) = Nothing, Optional SingleOnly As Boolean = False)
            EntryName = Name
            ContentType = TheType
            SingleRoot = SingleOnly
            BuildChecks = ListIds
            Sections = TheSections
            If ListIds Is Nothing Then BuildChecks = New List(Of UInt32)
            If Sections Is Nothing Then Sections = New List(Of COH_FSI_Section)
        End Sub
    End Class
End Namespace
