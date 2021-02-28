Namespace GameContent.Structures.Store
    Public Class COH_ProductCatalog
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Product Catalog"
            End Get
        End Property
#End Region

#Region "Properties"
        Property CatalogItems As COH_ProductCatalogItem()
            Get
                Return mItems
            End Get
            Set(value As COH_ProductCatalogItem())
                mItems = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mItems As COH_ProductCatalogItem()

#End Region

#Region "Create New Instances"
        Public Sub New()
            ResetDefaults()
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mItems = New COH_ProductCatalogItem() {}
        End Sub
        Public Overrides Function ToString() As String
            If mItems Is Nothing Then
                Return InternalDisplayName
            Else
                Return InternalDisplayName & mItems.Count & " Enties"
            End If
        End Function
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ProductCatalog
            Dim Result As COH_ProductCatalog = New COH_ProductCatalog
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mItems = New COH_ProductCatalogItem(mItems.Count - 1) {}
                For X = 0 To mItems.Count - 1
                    .mItems(X) = mItems(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export -CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            For Each Entry In CatalogItems
                Dim CurrentStream As IO.MemoryStream = Nothing
                Entry.Export_To_MemoryStream(CurrentStream)
                CurrentWriter.Write(CInt(CurrentStream.Length))
                CurrentWriter.Write(CurrentStream.ToArray)
                CurrentStream.Dispose()
            Next
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Return True
        End Function
#End Region

    End Class
End Namespace