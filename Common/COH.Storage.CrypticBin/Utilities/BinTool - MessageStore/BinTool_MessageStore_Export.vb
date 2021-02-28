Imports COH.GameContent
Imports COH.GameContent.MessageStores.Structures.LanguageFiles
Imports COH.Storage.Serialization

Namespace Utilities
    Partial NotInheritable Class COH_BinTool_MessageStore

#Region "Export - Message Store"
        Public Shared Function Create_NewFile(Name As String, FilePath As String, ByRef Source As COH_MessageStore, Optional ShowProgress As Boolean = True) As Boolean
            If IO.File.Exists(FilePath) = True Then IO.File.Delete(FilePath)
            Dim CurrentStream As New IO.FileStream(FilePath, IO.FileMode.Create)
            Using CurrentWriter As New COH_BinaryWriter(CurrentStream, Text.Encoding.UTF8)
                If Export_ToStream(Source, CurrentWriter, ShowProgress) = False Then Return False
            End Using
            CurrentStream = Nothing
            Return True
        End Function
        Public Shared Function Export_ToStream(ByRef Source As COH_MessageStore, ByRef CurrentWriter As COH_BinaryWriter, Optional ShowProgress As Boolean = True) As Boolean
            CurrentWriter.Write(Source.Version)
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, Source.Messages.Count + Source.Variables.Count + Source.Table.Count, "Building : City of Heroes Message Store " & Source.Name)
            Export_ToStream_StringTable(Source.Messages, CurrentWriter, ShowProgress)
            Export_ToStream_StringTable(Source.Variables, CurrentWriter, ShowProgress)
            Export_ToStream_Table(Source.Table, CurrentWriter, ShowProgress)
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)
            Return True
        End Function
#End Region

#Region "Export - Message Store Contents"
        Private Shared Function Export_ToStream_StringTable(ByRef StringTable As List(Of String), ByRef CurrentWriter As COH_BinaryWriter, Optional ShowProgress As Boolean = True) As Boolean
            CurrentWriter.Write(CUInt(StringTable.Count))
            Dim CurrentStream As New IO.MemoryStream
            Using InternalWriter As New COH_BinaryWriter(CurrentStream)
                For X = 0 To StringTable.Count - 1
                    Dim NewLine As String = StringTable(X)
                    NewLine = Helperfunctions.StringsAndThings.Return_SpecialCharacters(NewLine)
                    InternalWriter.WriteString_ZeroEnded_UTF8_COH(NewLine)
                    If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, 1)
                Next
                CurrentWriter.Write(CInt(0 + CurrentStream.Length))
                CurrentWriter.Write(CurrentStream.ToArray)
            End Using
            CurrentStream = Nothing
            Return True
        End Function
        Private Shared Function Export_ToStream_Table(ByRef Entries As COH_MessageStore_Dictionary, ByRef CurrentWriter As COH_BinaryWriter, Optional ShowProgress As Boolean = True) As Boolean
            CurrentWriter.Write(CUInt(Entries.Count))
            For Each Entry In Entries
                ExportEntry_ToStream(Entry.Value, CurrentWriter)
                If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, 1)
            Next
            Return True
        End Function
        Private Shared Function ExportEntry_ToStream(ByRef Source As COH_MessageStore_Entry, ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(CInt(Source.MessageID.Length))
            CurrentWriter.WriteString_NoMarker_UTF8_COH(Source.MessageID)
            CurrentWriter.Write(Source.MessageIndex)
            CurrentWriter.Write(Source.HelpIndex)
            CurrentWriter.Write(Source.VariableDefNameIndices.Count)
            For x = 0 To Source.VariableDefNameIndices.Count - 1
                CurrentWriter.Write(Source.VariableDefNameIndices(x).Index)
            Next
            Return True
        End Function
#End Region
    End Class
End Namespace