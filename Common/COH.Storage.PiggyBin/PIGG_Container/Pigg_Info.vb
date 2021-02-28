Namespace Storage.Containers.PIGG.Structures
    Public Class COH_Pigg_Info

#Region "Properties"
        Public Property FileHeader As COH_PIGG_FileHeader
            Get
                Return mHeader
            End Get
            Set(value As COH_PIGG_FileHeader)
                mHeader = value
            End Set
        End Property
        Public Property Directories As List(Of COH_PIGG_DirectoryEntry)
            Get
                Return mDirectories
            End Get
            Set(value As List(Of COH_PIGG_DirectoryEntry))
                mDirectories = value
            End Set
        End Property
        Public Property StringTable As COH_PIGG_StringTable
            Get
                Return mStringTable
            End Get
            Set(value As COH_PIGG_StringTable)
                mStringTable = value
            End Set
        End Property
        Public Property SlotTable As COH_PIGG_SlotTable
            Get
                Return mSlotTable
            End Get
            Set(value As COH_PIGG_SlotTable)
                mSlotTable = value
            End Set
        End Property
        Public ReadOnly Property FileName As String
            Get
                Return mFileName
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private mFileName As String
        Private mHeader As COH_PIGG_FileHeader
        Private mDirectories As List(Of COH_PIGG_DirectoryEntry)
        Private mStringTable As COH_PIGG_StringTable
        Private mSlotTable As COH_PIGG_SlotTable
#End Region

#Region "Create New Instance"
        Sub New()
        End Sub
        Sub New(FileName As String)
            mFileName = FileName
        End Sub
#End Region
    End Class
End Namespace