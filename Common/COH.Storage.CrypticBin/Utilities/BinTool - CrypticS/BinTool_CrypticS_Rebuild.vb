Imports COH.GameContent
Imports COH.Storage.Serialization
Imports COH.Storage.Structures
Imports COH.Storage.Structures.CrypticsS

Namespace Utilities
    Partial Public NotInheritable Class COH_BinTool_CrypticS

#Region "Export CrypticS - File Structure"
        Private Function Export_ToStream_Files(ByRef Source As COH_CrypticS, ByRef CurrentWriter As COH_BinaryWriter, Optional ShowProgress As Boolean = True) As Boolean
            For Each FileEntry In Source.Files
                FileEntry.BinaryTableStarts = CurrentWriter.Position
                Export_ToStream_Contents(Source, FileEntry, CurrentWriter, ShowProgress)
            Next
            Return True
        End Function
        Private Function Export_ToStream_OriginolSources(ByRef Source As COH_CrypticS, ByRef CurrentWriter As COH_BinaryWriter, Optional ShowProgress As Boolean = True) As Boolean
            Dim CurrentStream As New IO.MemoryStream
            Using InternalWriter As New COH_BinaryWriter(CurrentStream)
                For Each Entry In Source.Entries
                    InternalWriter.Write_CrypticS_String(Entry.DefFilePath)
                    If Source.Options.Option_BINs_UpdateTimeStamps = True Then
                        InternalWriter.Write(Helperfunctions.DateTimeFunctions.Convert_DateTime_to_Uint32Value(Date.Now))
                    Else
                        InternalWriter.Write(Entry.Time) '//For Now TimeStamp Does Not Change...
                    End If
                Next
                CurrentWriter.Write(CInt(CurrentStream.Length + 4))
                CurrentWriter.Write(Source.Entries.Count)
                CurrentWriter.Write(CurrentStream.ToArray)
            End Using
            CurrentStream = Nothing
            Return True
        End Function
        Private Function Export_ToStream_Contents(ByRef Source As COH_CrypticS, ByRef FileEntry As COH_CrypticS_File, ByRef CurrentWriter As COH_BinaryWriter, Optional ShowProgress As Boolean = True) As Boolean
            Dim CurrentStream As New IO.MemoryStream
            Using InternalWriter As New COH_BinaryWriter(CurrentStream)
                For X = 0 To FileEntry.Details.Count - 1
                    RebuildContents_SingleItem_ImportXML(Source, FileEntry.SupportedType, FileEntry.Details(X), InternalWriter, ShowProgress)
                Next
                CurrentWriter.Write(CInt(CurrentStream.Length + 4))
                CurrentWriter.Write(FileEntry.Details.Count)
                CurrentWriter.Write(CurrentStream.ToArray)
            End Using
            FileEntry.BinaryTableStarts = CurrentWriter.Position
            CurrentStream = Nothing
            Return True
        End Function
#End Region

#Region "Export CrypticsS - Contents"
        Private Function RebuildContents_SingleItem_ImportXML(ByRef Source As COH_CrypticS, SupportedType As Type, ByRef ContentEntry As COH_CrypticS_FileContentDetails, ByRef CurrentWriter As COH_BinaryWriter, Optional ShowProgress As Boolean = False) As Boolean
            Dim ExistingSource As COH_FileStructure = Nothing
            If COH_FileStructure.Import_COHStruct_FromXMLFile(ContentEntry.XML_RelativePath, SupportedType, ExistingSource) = False Then Return False
            Return RebuildContents_SingleItem(ExistingSource, CurrentWriter, ShowProgress)
        End Function
        Private Function RebuildContents_SingleItem(ByRef ExistingSource As COH_FileStructure, ByRef CurrentWriter As COH_BinaryWriter, Optional ShowProgress As Boolean = False) As Boolean
            Dim ResultSucceed As Boolean = True
            Dim TheStream As IO.MemoryStream = Nothing
            ResultSucceed = ExistingSource.Export_To_MemoryStream(TheStream, CurrentWriter.Settings) '//Version)
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, 1, ExistingSource.InternalDisplayName)
            If ResultSucceed = True Then
                CurrentWriter.Write(CInt(TheStream.Length))
                CurrentWriter.Write(TheStream.ToArray)
            ElseIf ResultSucceed = True Then '//WHY IS NO STRUCT HERE MARKER SIZE HERE? WHAT WAS I THINKING?>
                CurrentWriter.Write(TheStream.ToArray)
            End If
            Return ResultSucceed
        End Function
#End Region
    End Class
End Namespace