Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization

Namespace Storage.Containers.PIGG.Structures
    Public NotInheritable Class COH_PIGG_DirectoryEntry

#Region "Properties"
        ReadOnly Property Index As UInt32
            Get
                Return mIndex
            End Get
        End Property
        ReadOnly Property File_Size_Stored As UInt32
            Get
                If mFile_Size_Compressed > 0 Then
                    Return mFile_Size_Compressed
                Else
                    Return mFile_Size
                End If
            End Get
        End Property
        ReadOnly Property File_Size As UInt32
            Get
                Return mFile_Size
            End Get
        End Property
        ReadOnly Property File_Size_Compressed As UInt32
            Get
                Return mFile_Size_Compressed
            End Get
        End Property
        ReadOnly Property File_Offset As UInt32
            Get
                Return mFile_OffsetStart
            End Get
        End Property
        ReadOnly Property SecondarySlotIndex As Int32
            Get
                Return mSecondarySlotIndex
            End Get
        End Property
        ReadOnly Property TimeStamp As DateTime
            Get
                Return Helperfunctions.DateTimeFunctions.Convert_Uint32Value_To_DateTime(mFile_DateStamp)
            End Get
        End Property
        ReadOnly Property IsCompressed As Boolean
            Get
                If File_Size = File_Size_Compressed Then Return False
                Return True
            End Get
        End Property
        Public Property EntryType As COH_Supported_ContentType
            Get
                Return mEntryType
            End Get
            Set(value As COH_Supported_ContentType)
                mEntryType = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mEntryType As COH_Supported_ContentType
        Private mDirectoryMarker As UInt32 ' 0x00003456
        Private mIndex As UInt32 ' Which string in the string table this is associated with
        Private mFile_Size As UInt32  ' Uncompressed File Size
        Private mFile_Size_Compressed As UInt32  ' Compressed length of the file
        Private mFile_DateStamp As UInt32  ' Date stamp when this entry was created
        Private mFile_OffsetStart As UInt32  ' Location in the file where this chunk starts
        Private mUnknown1 As UInt32  ' Currently always zero
        Private mSecondarySlotIndex As Int32  ' Location of secondary slot this is associated with
        Private nMD5(15) As Byte ' MD5 Hash of the uncompressed data
#End Region

#Region "Create New Instance"
        Sub New()
        End Sub
        Private Function BuildFromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDirectoryMarker = CurrentReader.ReadUInt32
            If Not mDirectoryMarker = 13398 Then Return False
            mIndex = CurrentReader.ReadUInt32
            mFile_Size = CurrentReader.ReadUInt32
            mFile_DateStamp = CurrentReader.ReadUInt32
            mFile_OffsetStart = CurrentReader.ReadUInt32
            mUnknown1 = CurrentReader.ReadUInt32
            mSecondarySlotIndex = CurrentReader.ReadInt32
            nMD5 = CurrentReader.ReadBytes(16)
            mFile_Size_Compressed = CurrentReader.ReadUInt32
            Return True
        End Function
#End Region

#Region "Shared Function"
        Public Shared Function CreateFromStream(ByRef CurrentReader As COH_BinaryReader, ByRef Result As COH_PIGG_DirectoryEntry) As Boolean
            Dim Valid As Boolean = False
            Result = New COH_PIGG_DirectoryEntry
            Valid = Result.BuildFromStream(CurrentReader)
            If Valid = False Then
                'MsgBox("Invalid/Unknwn Directory Entry", MsgBoxStyle.Critical, "COH Tools PigBin")
                Return False
            Else
                Return True
            End If
        End Function
#End Region

        Public Function Convert_To_StringArray() As String()
            Return New String() {mIndex, "", mFile_OffsetStart, mFile_Size, mFile_Size_Compressed, TimeStamp, mSecondarySlotIndex, BitConverter.ToString(nMD5), mUnknown1}
        End Function
    End Class
End Namespace