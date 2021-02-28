#If EDITOR Then
Imports System.ComponentModel
Imports COH.CodeManagement.Attributes
Imports COH.CodeManagement.Interfaces.Structures
#End If

Namespace Storage.Structures
#If EDITOR Then
    <TypeConverter(GetType(COH_FileStructure_ExpandableObjectCoverter))>
    <Serializable()>
    Public MustInherit Class COH_FileStructure
        Implements ISupport_COH_DisplayName
#Else
        Public MustInherit Class COH_FileStructure
#End If

#Region "Properties"
        Private pValid As Boolean
#End Region

#Region "Create New Instances"
        Public Sub New()
            'Me.New(True)
            pValid = True
        End Sub
#End Region
    End Class
End Namespace
