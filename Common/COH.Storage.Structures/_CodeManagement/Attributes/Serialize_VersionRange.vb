Imports COH.CodeManagement.Enums.Structures

Namespace CodeManagement.Attributes
    <AttributeUsage(AttributeTargets.Property Or AttributeTargets.Class)>
    Public Class COH_VersionRange
        Inherits System.Attribute

        Public Const MAX_PARSEVERSION = 7
        Property MinVersion As Integer
        Property MaxVersion As Integer
        Property Build As COH_BuildType

        Public Sub New()
            MinVersion = 0
            MaxVersion = 6
            Build = COH_BuildType.Either
        End Sub
        Public Sub New(Min_Version As Integer)
            MinVersion = Min_Version
            MaxVersion = MAX_PARSEVERSION
            Build = COH_BuildType.Either
        End Sub
        Public Sub New(Min_Version As Integer, Max_Version As Integer, Optional ForBuild As COH_BuildType = COH_BuildType.Either)
            MinVersion = Min_Version
            MaxVersion = MaxVersion
            Build = ForBuild
        End Sub
    End Class
End Namespace