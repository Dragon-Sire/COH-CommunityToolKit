Imports COH.GameContent
Imports COH.GameContent.MessageStores.Structures.LanguageFiles
Imports COH.Storage.Serialization

Namespace Utilities
    Partial NotInheritable Class COH_BinTool_MessageStore

#Region "Import - Message Store"
        Public Shared Function Create_FromFile(Name As String, FilePath As String, ByRef Result As COH_MessageStore, Optional ShowProgress As Boolean = True) As Boolean
            If IO.File.Exists(FilePath) = False Then Return False
            Dim CurrentStream As New IO.FileStream(FilePath, IO.FileMode.Open)
            Using CurrentReader As New COH_BinaryReader(CurrentStream, Text.Encoding.UTF8)
                If Create_FromStream(Name, CurrentReader, Result, ShowProgress) = False Then Return False
            End Using
            CurrentStream = Nothing
            Return True
        End Function
        Public Shared Function Create_FromStream(Name As String, ByRef CurrentReader As COH_BinaryReader, ByRef Result As COH_MessageStore, Optional ShowProgress As Boolean = True) As Boolean
            Result = New COH_MessageStore(Name)
            Result.Version = CurrentReader.ReadUInt32
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, CurrentReader.Length, "Processing : City of Heroes Message Store " & Name)
            If ProcessStringTable(CurrentReader, Result.Messages, ShowProgress) = False Then Return False
            If ProcessStringTable(CurrentReader, Result.Variables, ShowProgress) = False Then Return False
            If ProcessTable(CurrentReader, Result.Table, ShowProgress) = False Then Return False
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)
            Return True
        End Function
#End Region

#Region "Import MessageStore - Content"
        Private Shared Function ProcessStringTable(ByRef CurrentReader As COH_BinaryReader, ByRef Result As List(Of String), Optional ShowProgress As Boolean = True) As Boolean
            Dim Start As Long = CurrentReader.Position
            Dim NumberEntries As UInt32 = CurrentReader.ReadUInt32 '152692
            Dim NumBytes = CurrentReader.ReadUInt32 '5133201
            If NumberEntries = 0 Then Return True
            Result = New List(Of String)
            Dim NewLine As String = "[START]"
            Dim PosProgress As Integer = 0
            Do
                If (CurrentReader.Position - PosProgress) > 50000 Then PosProgress = CurrentReader.Position
                NewLine = CurrentReader.Read_CrypticS_String_ZeroEnded_UTF8
                NewLine = Helperfunctions.StringsAndThings.Replace_SpecialCharacters(NewLine)
                Result.Add(NewLine)
                If (CurrentReader.Position - PosProgress) > 50000 Then
                    If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, CurrentReader.Position - PosProgress)
                End If
                If CurrentReader.Position >= Start + 8 + (NumBytes) Then Exit Do
            Loop
            Return True
        End Function
        Private Shared Function ProcessTable(ByRef CurrentReader As COH_BinaryReader, ByRef Result As COH_MessageStore_Dictionary, Optional ShowProgress As Boolean = True) As Boolean
            Result = New COH_MessageStore_Dictionary
            Dim NumberEntries As UInt32 = CurrentReader.ReadUInt32
            Dim NewItem As COH_MessageStore_Entry = Nothing
            Dim PosProgress As Integer = 0
            Do
                If (CurrentReader.Position - PosProgress) > 50000 Then PosProgress = CurrentReader.Position
                If CreateEntry_FromStream(CurrentReader, NewItem) = False Then Return False
                Result.Add(NewItem.MessageID, NewItem)
                If (CurrentReader.Position - PosProgress) > 50000 Then
                    If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, CurrentReader.Position - PosProgress)
                End If
                If (CurrentReader.BaseStream.Length = CurrentReader.BaseStream.Position) Then Exit Do
            Loop
            Return True
        End Function
        Private Shared Function CreateEntry_FromStream(ByRef CurrentReader As COH_BinaryReader, ByRef Result As COH_MessageStore_Entry) As Boolean
            Result = New COH_MessageStore_Entry
            With Result
                Dim Stringlength As Integer = CurrentReader.ReadInt32
                .MessageID = CurrentReader.Read_CrypticS_String_FixedLength_UTF8(Stringlength)
                .MessageIndex = CurrentReader.ReadInt32
                .HelpIndex = CurrentReader.ReadInt32
                Dim VariableCount = CurrentReader.ReadInt32
                .VariableDefNameIndices = New List(Of COH_MessageStore_EntryVariable)
                For x = 0 To VariableCount - 1
                    .VariableDefNameIndices.Add(New COH_MessageStore_EntryVariable() With {.Index = CurrentReader.ReadInt32})
                Next
            End With
            Return True
        End Function
#End Region
    End Class
End Namespace