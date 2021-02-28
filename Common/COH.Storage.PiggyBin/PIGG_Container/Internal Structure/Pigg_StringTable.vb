Imports System.IO
Imports COH.Storage.Serialization

Namespace Storage.Containers.PIGG.Structures
    Public NotInheritable Class COH_PIGG_StringTable

#Region "Properties"
        ReadOnly Property Items As List(Of String)
            Get
                Return sStringEntries
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private sStringTableMarker As UInt32
        Private sCount As UInt32
        Private sSize As UInt32
        Private sStringEntries As List(Of String)
#End Region

#Region "Create New Instance"
        Sub New()
        End Sub
        Private Function BuildFromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            sStringTableMarker = CurrentReader.ReadUInt32
            If Not sStringTableMarker = 26505 Then Return False
            sCount = CurrentReader.ReadUInt32
            sSize = CurrentReader.ReadUInt32
            Dim sStringSize As UInt32 = 0
            sStringEntries = New List(Of String)
            For X = 0 To sCount - 1
                sStringSize = CurrentReader.ReadUInt32
                sStringEntries.Add(System.Text.Encoding.ASCII.GetString(CurrentReader.ReadBytes(sStringSize - 1))) ' Last Byte Should be NuLL
                Dim TempByte As Byte = CurrentReader.ReadByte
                If Not TempByte = 0 Then Return False
            Next
            Return True
        End Function
#End Region

#Region "Shared Function"
        Public Shared Function CreateFromStream(ByRef CurrentReader As COH_BinaryReader, ByRef Result As COH_PIGG_StringTable) As Boolean
            Dim Valid As Boolean = False
            Result = New COH_PIGG_StringTable
            Valid = Result.BuildFromStream(CurrentReader)
            If Valid = False Then
                ' MsgBox("Invalid/Unknwn String Table", MsgBoxStyle.Critical, "COH Tools PigBin")
                Return False
            Else
                Return True
            End If
        End Function
#End Region
    End Class
End Namespace
