Namespace GameContent.Structures.[Shared]
    Public Class COH_AttributesCategory
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("Display")> Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property Attrib As COH_AttributeDescription()
            Get
                Return mAttrib
            End Get
            Set(value As COH_AttributeDescription())
                mAttrib = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mAttrib As COH_AttributeDescription()
#End Region

#Region "Create New Instances"
        Public Sub New()
            ResetDefaults()
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mName = String.Empty
            mAttrib = New COH_AttributeDescription() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
            For Each Item In mAttrib
                Item.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_AttributesCategory
            Dim Result As COH_AttributesCategory = New COH_AttributesCategory
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mAttrib = New COH_AttributeDescription(mAttrib.Count - 1) {}
                For X = 0 To mAttrib.Count - 1
                    .mAttrib(X) = mAttrib(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            If CurrentWriter.Write_CrypticS_StructArray(Attrib) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_AttributeDescription), Attrib) = False Then Return False
            Return True
        End Function
#End Region
    End Class
End Namespace