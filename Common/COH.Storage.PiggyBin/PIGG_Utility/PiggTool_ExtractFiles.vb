Imports System.IO
Imports COH.CodeManagement.Enums.Pigg
Imports COH.CodeManagement.Enums.Structures
Imports COH.GameContent
Imports COH.GameContent.Structures.Resources.Anim
Imports COH.GameContent.Structures.Resources.BIN
Imports COH.GameContent.Structures.Resources.GEO
Imports COH.GameContent.Structures.Resources.Other
Imports COH.GameContent.Structures.Resources.Textures
Imports COH.Storage.Containers.PIGG.Structures
Imports COH.Storage.Containers.PIGG.Structures.Contents
Imports COH.Storage.Serialization
Imports COH.Storage.Structures

Namespace Storage.Containers.PIGG.Utilities
    Partial Public Class COH_PiggTool

#Region "Extract PiggInfo"
        Public Shared Function Create_FromFile(Name As String, FilePath As String, ByRef Result As COH_Pigg_Info, Optional ShowProgress As Boolean = False) As Boolean
            If IO.File.Exists(FilePath) = False Then Return False
            Dim CurrentStream As New IO.FileStream(FilePath, IO.FileMode.Open)
            Using CurrentReader As New COH_BinaryReader(CurrentStream, Text.Encoding.ASCII)
                If Create_FromStream(Name, CurrentReader, Result, ShowProgress) = False Then Return False
            End Using
            CurrentStream = Nothing
            Return True
        End Function
        Public Shared Function Create_FromStream(Name As String, ByRef CurrentReader As COH_BinaryReader, ByRef Result As COH_Pigg_Info, Optional ShowProgress As Boolean = False) As Boolean
            Result = New COH_Pigg_Info(Name)
            If COH_PIGG_FileHeader.CreateFromStream(CurrentReader, Result.FileHeader) = False Then Return False
            Dim TheDirectories As New List(Of COH_PIGG_DirectoryEntry)
            Dim NewItem As COH_PIGG_DirectoryEntry = Nothing
            For X = 0 To Result.FileHeader.Number_DirectoryEntries - 1
                If COH_PIGG_DirectoryEntry.CreateFromStream(CurrentReader, NewItem) = False Then Return False
                TheDirectories.Add(NewItem)
            Next
            Result.Directories = TheDirectories
            If COH_PIGG_StringTable.CreateFromStream(CurrentReader, Result.StringTable) = False Then Return False
            If COH_PIGG_SlotTable.CreateFromStream(CurrentReader, Result, Result.SlotTable) = False Then Return False
            For X = 0 To Result.FileHeader.Number_DirectoryEntries - 1
                Result.Directories(X).EntryType = Identify_SlotType(Result.StringTable.Items(X))
            Next
            Return True
        End Function
        Private Shared Function Identify_SlotType(ByRef FileName As String) As COH_Supported_ContentType
            Dim Result = PIGG_Container_SlotTypes.Unknown
            Dim EXT As String = IO.Path.GetExtension(FileName).ToUpper
            If EXT = ".TEXTURE" Or EXT = ".DDS" Then
                Return COH_Supported_ContentType.Resource_Texture
            ElseIf EXT = ".BIN" Then
                Return COH_Supported_ContentType.Resource_BIN_CrypticS
            ElseIf EXT = ".GEO" Then
                Return COH_Supported_ContentType.Resource_GEO
            ElseIf EXT = ".ANIM" Then
                Return COH_Supported_ContentType.Resource_ANIMATION
            ElseIf EXT = ".TGA" Then
                Return COH_Supported_ContentType.Resource_TGA
            Else
                Return COH_Supported_ContentType.Unknown
            End If
            Return True
        End Function
#End Region

#Region "Extract Files"
        Public Shared Function ExtractAllFiles_ToDirectory(ByRef CurrentReader As COH_BinaryReader, RootPath As String, ByRef Source As COH_Pigg_Info, Optional ProcessEntry As Boolean = False, Optional ShowProgress As Boolean = False) As Boolean
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, Source.Directories.Count, "Extracting PIGG - " & Source.FileName)
            CurrentReader.Settings.Option_SelectedFormat = COH_ExportFormat.Binary
            For X = 0 To Source.Directories.Count - 1
                If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(COH_Event_ProgressUpdate.COH_ProgressEvent.Update, 1, "Extracting PIGG - " & Source.StringTable.Items(X))
                Dim DestinationFile As String = DeterminePath(RootPath, Source, X)
                Dim Result As Byte() = Nothing
                Dim ResultSlot As Contents.COH_PIGG_SlotTableEntry = Nothing
                If Extract_Entry(CurrentReader, Source, X, Result, ResultSlot) = False Then Return False
                If Not Result Is Nothing Then
                    WriteData(Result, DestinationFile)
                    If ProcessEntry = True Then
                        Dim ResourceResult As COH_FileStructure = Nothing
                        If Process_Entry(Result, Source, X, ResourceResult) = True Then
                            ResourceResult.Export_To_File(IO.Path.GetFileNameWithoutExtension(DestinationFile) & "." & ResourceResult.Default_BinaryExtention, IO.Path.GetDirectoryName(DestinationFile), COH_StreamFormat.Binary)
                        End If
                    End If
                    If Source.Directories(X).SecondarySlotIndex >= 0 Then
                        Dim SlotFile As String = DestinationFile & "_Slot.raw"
                        WriteData_Slot(ResultSlot, SlotFile)
                    End If
                Else
                    ShowErrorOccured("Nothing Extracted : " & DestinationFile)
                End If
            Next
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(COH_Event_ProgressUpdate.COH_ProgressEvent.Finish, Source.Directories.Count, "Extracting PIGG - " & Source.FileName)
            Return True
        End Function
        Public Shared Function Extract_Entry(ByRef CurrentReader As COH_BinaryReader, ByRef Source As COH_Pigg_Info, Index As Integer, ByRef Result As COH_FileStructure, Optional ShowProgress As Boolean = False) As Boolean
            Dim RawBytes As Byte() = Nothing
            Dim Slot As Contents.COH_PIGG_SlotTableEntry = Nothing
            If Extract_Entry(CurrentReader, Source, Index, RawBytes, Slot) Then
                Return Process_Entry(RawBytes, Source, Index, Result)
            End If
            Return True
        End Function
        Public Shared Function Process_Entry(ByRef RawBytes As Byte(), ByRef Source As COH_Pigg_Info, Index As Integer, ByRef Result As COH_FileStructure) As Boolean
            Select Case Source.Directories(Index).EntryType
                Case COH_Supported_ContentType.Resource_Texture
                    Return Extract_Entry_Resource_Texture(RawBytes, Result)
                Case COH_Supported_ContentType.Resource_BIN_CrypticS
                    Return Extract_Entry_Resource_BIN(RawBytes, Result)
                Case COH_Supported_ContentType.Resource_GEO
                    Return Extract_Entry_Resource_GEO(RawBytes, Result)
                Case COH_Supported_ContentType.Resource_ANIMATION
                    Return Extract_Entry_Resource_ANIM(RawBytes, Result)
                Case COH_Supported_ContentType.Resource_TGA
                    Return Extract_Entry_Resource_TGA(RawBytes, Result)
                Case COH_Supported_ContentType.Unknown
                    Return Extract_Entry_Resource_Unknown(RawBytes, Result)
                Case Else
                    Return False
            End Select
        End Function
        Public Shared Function Extract_Entry(ByRef CurrentReader As COH_BinaryReader, ByRef Source As COH_Pigg_Info, Index As Integer, ByRef Result As Byte(), ByRef Slot As Contents.COH_PIGG_SlotTableEntry) As Boolean
            Result = Extract_RawData(CurrentReader, Index, Source, Source.Directories(Index).IsCompressed)
            If Source.Directories(Index).SecondarySlotIndex >= 0 Then
                Slot = Source.SlotTable.Items(Source.Directories(Index).SecondarySlotIndex)
            Else
                Slot = Nothing
            End If
            Return True
        End Function
        Private Shared Function DeterminePath(RootPath As String, ByRef Source As COH_Pigg_Info, Index As Int32) As String
            Dim FilePath As String = RootPath & Source.StringTable.Items(Source.Directories(Index).Index).ToString.Replace("/", "\")
            FilePath = FilePath.Replace(ChrW(0), "")
            'Dim L1 As String = FilePath.Length

            If File.Exists(FilePath) = True Then IO.File.Delete(FilePath)
            Dim Folder As String = IO.Path.GetDirectoryName(FilePath)
            If IO.Directory.Exists(Folder) = False Then IO.Directory.CreateDirectory(Folder)
            Return FilePath
        End Function
        Private Shared Function Extract_RawData(ByRef CurrentReader As COH_BinaryReader, Index As Int32, ByRef Source As COH_Pigg_Info, Optional Decompress As Boolean = False) As Byte()
            CurrentReader.BaseStream.Position = Source.Directories(Index).File_Offset
            If Decompress = True And Source.Directories(Index).File_Size_Compressed > 0 Then
                Return HelperFunctions.Compression.DecompressBytes(CurrentReader.ReadBytes(Source.Directories(Index).File_Size_Stored))
            Else
                '//HelperFunctions.Bytes.Write_BytesToFile(CurrentReader.ReadBytes(8000), "E:\SOURCE.RAW")
                Return CurrentReader.ReadBytes(Source.Directories(Index).File_Size_Stored)
            End If
        End Function
#End Region

#Region "Extract Single Resources"
        Public Shared Function Extract_Entry_Resource_TGA(ByRef RawBytes As Byte(), ByRef Result As COH_FileStructure) As Boolean
            Dim NewResource As New COH_Resource_TGA()
            NewResource.Update_FromBytes(RawBytes)
            Result = NewResource
            Return True
        End Function
        Public Shared Function Extract_Entry_Resource_Unknown(ByRef RawBytes As Byte(), ByRef Result As COH_FileStructure) As Boolean
            Dim NewResource As New COH_Resource_Unknown()
            NewResource.Update_FromBytes(RawBytes)
            Result = NewResource
            Return True
        End Function
        Public Shared Function Extract_Entry_Resource_Texture(ByRef RawBytes As Byte(), ByRef Result As COH_FileStructure) As Boolean
            Dim NewResource As New COH_Resource_Texture()
            NewResource.Update_FromBytes(RawBytes)
            Result = NewResource
            Return True
        End Function
        Public Shared Function Extract_Entry_Resource_BIN(ByRef RawBytes As Byte(), ByRef Result As COH_FileStructure) As Boolean
            Dim NewResource As New COH_Resource_BIN()
            NewResource.Update_FromBytes(RawBytes)
            Result = NewResource
            Return True
        End Function
        Public Shared Function Extract_Entry_Resource_GEO(ByRef RawBytes As Byte(), ByRef Result As COH_FileStructure) As Boolean
            Dim NewResource As New COH_Resource_GEO()
            NewResource.Import_From_Buffer(RawBytes)
            Result = NewResource
            Return True
        End Function
        Public Shared Function Extract_Entry_Resource_ANIM(ByRef RawBytes As Byte(), ByRef Result As COH_FileStructure) As Boolean
            Dim NewResource As New COH_Resource_Anim()
            NewResource.Import_From_Buffer(RawBytes)
            Result = NewResource
            Return True
        End Function
#End Region

#Region "Write File"
        Private Shared Function WriteData(ByRef RawBytes As Byte(), DestinationFile As String) As Boolean
            Dim CurrentStream As FileStream = New FileStream(DestinationFile, FileMode.Create)
            Try
                Using CurrentWriter As New COH_BinaryWriter(CurrentStream, Text.Encoding.ASCII)
                    CurrentWriter.Write(RawBytes)
                    CurrentWriter.Flush()
                End Using
                CurrentStream.Close()
                CurrentStream = Nothing
            Catch ex As Exception
                ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Extract PIGG Entry", ex, True)
            End Try
            Return True
        End Function
        Private Shared Function WriteData_Slot(Entry As COH_PIGG_SlotTableEntry, DestinationFile As String) As Boolean
            Dim CurrentStream As FileStream
            CurrentStream = New FileStream(DestinationFile, FileMode.Create)
            Using CurrentWriter As New COH_BinaryWriter(CurrentStream, Text.Encoding.ASCII)
                Entry.WriteToStream(CurrentWriter)
                CurrentWriter.Flush()
            End Using
            Return True
        End Function
#End Region
    End Class
End Namespace