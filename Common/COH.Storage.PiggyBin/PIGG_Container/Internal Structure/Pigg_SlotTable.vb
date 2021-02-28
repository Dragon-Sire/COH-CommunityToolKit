Imports COH.CodeManagement.Enums.Pigg
Imports COH.Storage.Containers.PIGG.Structures.Contents
Imports COH.Storage.Serialization

Namespace Storage.Containers.PIGG.Structures
    Public NotInheritable Class COH_PIGG_SlotTable

#Region "Properties"
        ReadOnly Property Items As List(Of COH_PIGG_SlotTableEntry)
            Get
                Return sItems
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private sSlotTableMarker As UInt32
        Private sCount As UInt32
        Private sSize As UInt32
        Private sItems As List(Of COH_PIGG_SlotTableEntry)
#End Region

#Region "Create New Instance"
        Sub New()
        End Sub
        Private Function BuildFromStream(ByRef CurrentReader As COH_BinaryReader, ByRef Source As Structures.COH_Pigg_Info) As Boolean
            sSlotTableMarker = CurrentReader.ReadUInt32
            If Not sSlotTableMarker = 39612 Then Return False
            sCount = CurrentReader.ReadUInt32
            sSize = CurrentReader.ReadUInt32
            If sCount > 0 Then
                sItems = New List(Of COH_PIGG_SlotTableEntry)
                For X = 0 To sCount - 1
                    Dim EntryType = Identify_SlotType(FindName_FromSlotIndex(X, Source))
                    Select Case EntryType
                        Case PIGG_Container_SlotTypes.Unknown
                            sItems.Add(New PIGG_SlotEntry_UNKNOWN(CurrentReader))
                        Case PIGG_Container_SlotTypes.DDS_Header
                            sItems.Add(New PIGG_SlotEntry_TextureDDS(CurrentReader))
                        Case PIGG_Container_SlotTypes.GEO
                            sItems.Add(New PIGG_SlotEntry_Geo(CurrentReader))
                    End Select
                Next
            End If
            Return True
        End Function
        Private Function FindName_FromSlotIndex(Index As Integer, ByRef Source As Structures.COH_Pigg_Info) As String
            For X = 0 To Source.Directories.Count - 1
                If Source.Directories(X).SecondarySlotIndex = Index Then Return Source.StringTable.Items(X)
            Next
            Return ""
        End Function
        Private Function Identify_SlotType(ByRef FileName As String) As PIGG_Container_SlotTypes
            Dim Result = PIGG_Container_SlotTypes.Unknown
            Dim EXT As String = IO.Path.GetExtension(FileName).ToUpper
            If EXT = ".TEXTURE" Or EXT = ".DDS" Then
                Return PIGG_Container_SlotTypes.DDS_Header
            ElseIf EXT = ".GEO" Then
                Return PIGG_Container_SlotTypes.GEO
            ElseIf EXT = ".ANIM" Then
                'Return SlotTypes.ANIM_ANIMATION
            Else
                'MsgBox("")
            End If
            Return Result
        End Function
#End Region

#Region "Shared Function"
        Public Shared Function CreateFromStream(ByRef CurrentReader As COH_BinaryReader, ByRef Source As Structures.COH_Pigg_Info, ByRef Result As COH_PIGG_SlotTable) As Boolean
            Dim Valid As Boolean = False
            Result = New COH_PIGG_SlotTable
            Valid = Result.BuildFromStream(CurrentReader, Source)
            If Valid = False Then
                'MsgBox("Invalid/Unknwn String Table", MsgBoxStyle.Critical, "COH Tools PigBin")
                Return False
            Else
                Return True
            End If
        End Function
#End Region
    End Class
End Namespace

