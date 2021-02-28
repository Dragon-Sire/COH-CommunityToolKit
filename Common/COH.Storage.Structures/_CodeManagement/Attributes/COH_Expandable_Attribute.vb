'#If EDITOR Then
Imports System.ComponentModel
Imports COH.Storage.Structures

Namespace CodeManagement.Attributes
    Public Class COH_FileStructure_ExpandableObjectCoverter
        Inherits ExpandableObjectConverter

#Region "Private Properties"
        Private mExcludeProperties As String() = {"Default_CrypricSExtention", "Default_BinaryExtention", "Default_StreamFormat", "Build", "Valid", "FilePathReference_Current", "FilePathReference_Original", "IsCustom", "WasModified_FromSource", "IsProjectFile"}
#End Region


        Public Overrides Function GetProperties(context As ITypeDescriptorContext, value As Object, attributes() As Attribute) As PropertyDescriptorCollection
            If TypeOf value Is COH_FileStructure Then
                Dim Source As COH_FileStructure = TryCast(value, COH_FileStructure)
                'If Source.IsProjectFile = True Then
                Return MyBase.GetProperties(context, value, attributes)
                'Else
                'Return FilterProperties(MyBase.GetProperties(context, value, attributes))
                'End If
            Else
                Return MyBase.GetProperties(context, value, attributes)
            End If
        End Function
        Private Function FilterProperties(ByVal originalCollection As PropertyDescriptorCollection) As PropertyDescriptorCollection
            Dim Source_Properties As IEnumerable(Of PropertyDescriptor) = originalCollection.OfType(Of PropertyDescriptor)().Where(Function(p) Not mExcludeProperties.Contains(p.Name))
            Dim descriptors As PropertyDescriptor() = Source_Properties.ToArray()
            Dim Result As PropertyDescriptorCollection = New PropertyDescriptorCollection(descriptors)
            Return Result
        End Function

    End Class
End Namespace
'#End If