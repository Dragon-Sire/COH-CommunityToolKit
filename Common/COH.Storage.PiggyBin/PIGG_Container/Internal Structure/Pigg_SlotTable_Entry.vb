Imports COH.CodeManagement.Enums.Pigg
Imports COH.Storage.Serialization

Namespace Storage.Containers.PIGG.Structures.Contents
    Public MustInherit Class COH_PIGG_SlotTableEntry

#Region "Properties"
        ReadOnly Property Offset As UInt32
            Get
                Return mEntry_Offset
            End Get
        End Property
        ReadOnly Property Size As UInt32
            Get
                Return mEntry_Size
            End Get
        End Property
        ReadOnly Property Size_Stored As UInt32
            Get
                If IsCompressed = True Then
                    Return mEntry_Size_Compressed
                Else
                    Return mEntry_Size
                End If
            End Get
        End Property
        ReadOnly Property Size_Decompressed As UInt32
            Get
                Return mEntry_Size_Decompressed
            End Get
        End Property
        ReadOnly Property IsCompressed As Boolean
            Get
                If mEntry_Size = mEntry_Size Then Return False
                Return True
            End Get
        End Property
        MustOverride ReadOnly Property SlotType As PIGG_Container_SlotTypes
#End Region

#Region "Private Properties"
        Private mEntry_Offset As UInt32
        Private mEntry_Size As UInt32
        Private mEntry_Size_Compressed As UInt32
        Private mEntry_Size_Decompressed As UInt32
        Private mSlotType As PIGG_Container_SlotTypes
#End Region

#Region "Create New Instance"
        Public Sub New()
        End Sub
        Sub New(ByRef CurrentReader As COH_BinaryReader)
            mEntry_Offset = CurrentReader.Position
            mEntry_Size = CurrentReader.ReadUInt32  'Size Marker Included in Size
            mEntry_Size_Compressed = CurrentReader.ReadUInt32
            If mEntry_Size = mEntry_Size_Compressed Then
                CurrentReader.Position -= 4
                Extract_EntryInfo(CurrentReader, mEntry_Size)
            Else
                If mEntry_Size = (mEntry_Size_Compressed + 4) Then
                    mEntry_Size_Decompressed = CurrentReader.ReadUInt32
                    Extract_EntryInfo(CurrentReader, mEntry_Size_Compressed - 4)
                Else
                    Throw New Exception("NO IDEA")
                End If
            End If
        End Sub
#End Region

#Region "Parsing"
        Public MustOverride Function Extract_EntryInfo(ByRef CurrentReader As COH_BinaryReader, ExpectedSize As Integer) As Boolean
        Public MustOverride Function WriteToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
#End Region

    End Class
End Namespace