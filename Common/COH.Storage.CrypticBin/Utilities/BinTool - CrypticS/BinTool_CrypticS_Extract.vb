Imports COH.CodeManagement.Enums.Structures
Imports COH.GameContent
Imports COH.Storage.Serialization
Imports COH.Storage.Structures
Imports COH.Storage.Structures.CrypticsS

Namespace Utilities
    Partial Public NotInheritable Class COH_BinTool_CrypticS

#Region "Extract Contents"
        Private Function Export_ToStream(ByRef Source As COH_CrypticS, ByRef CurrentWriter As COH_BinaryWriter, Optional ShowProgress As Boolean = True) As Boolean
            CurrentWriter.Write(Text.Encoding.ASCII.GetBytes("CrypticS"))
            '//Should Not Have to Update BuildCRC
            CurrentWriter.Write(Source.BuildCRC)
            CurrentWriter.Write(CShort(6))
            Select Case Source.ParseVersion
                Case CodeManagement.Enums.Structures.COH_BinaryFormat.CrypticsS_Parse6
                    CurrentWriter.Write(System.Text.Encoding.ASCII.GetBytes("Parse6"))
                Case CodeManagement.Enums.Structures.COH_BinaryFormat.CrypticsS_Parse7
                    CurrentWriter.Write(System.Text.Encoding.ASCII.GetBytes("Parse7"))
                    Return False
                Case Else
                    Return False
            End Select
            CurrentWriter.Write(CShort(6))
            Dim FilesString As String = "Files" & Source.FilesCount.ToString
            CurrentWriter.Write(System.Text.Encoding.ASCII.GetBytes(FilesString))
            Source.Update_ContentType()
            Export_ToStream_OriginolSources(Source, CurrentWriter, ShowProgress)
            Return Export_ToStream_Files(Source, CurrentWriter, ShowProgress)
            Return True
        End Function
        Private Function ExtractContents(ByRef Source As COH_CrypticS, ByRef CurrentReader As COH_BinaryReader, ByRef Results As List(Of COH_FileStructure), Optional UpdateName As Boolean = False, Optional ShowProgress As Boolean = False) As Boolean
            Results = New List(Of COH_FileStructure)
            For X = 0 To Source.FilesCount - 1
                If ExtractContents(Source, Source.Files(X), CurrentReader, Results, UpdateName, ShowProgress) = False Then Return False
            Next
            Return True
        End Function
        Private Function ExtractContents(ByRef Source As COH_CrypticS, ByRef SourceFile As COH_CrypticS_File, ByRef CurrentReader As COH_BinaryReader, ByRef Results As List(Of COH_FileStructure), Optional UpdateName As Boolean = False, Optional ShowProgress As Boolean = False) As Boolean
            If Results Is Nothing Then Results = New List(Of COH_FileStructure)
            Dim UpdateInterval As Integer = ProgressUpdate_UpdateInterval(Source.Entries.Count, ShowProgress)
            Dim UpdateStep As Integer = 0
            Dim UpdateProgressBar As Boolean = False
            For X = 0 To SourceFile.Details.Count - 1
                Dim NewItem As COH_FileStructure = Nothing
                UpdateStep += 1
                If UpdateStep = UpdateInterval Then
                    UpdateStep = 0
                    If ShowProgress = True Then UpdateProgressBar = True
                ElseIf X = SourceFile.Details.Count - 1 Then
                    If ShowProgress = True Then UpdateProgressBar = True
                Else
                    UpdateProgressBar = False
                End If
                If ExtractContent(Source, SourceFile.SupportedType, SourceFile.Details(X), CurrentReader, NewItem, UpdateProgressBar) = False Then Return False
                If UpdateProgressBar = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, UpdateInterval - 1)
                Results.Add(NewItem)
                If UpdateName = True Then SourceFile.Details(X).Name = NewItem.InternalDisplayName
            Next
            Return True
        End Function
        Private Function ExtractContent(ByRef Source As COH_CrypticS, SupportedType As Type, ByRef ContentEntry As COH_CrypticS_FileContentDetails, ByRef CurrentReader As COH_BinaryReader, ByRef Result As COH_FileStructure, Optional ShowProgress As Boolean = False) As Boolean
            Dim ResultSucceed As Boolean = False
            CurrentReader.Position = ContentEntry.Offset
            If SupportedType Is Nothing Then Return False
            Result = Activator.CreateInstance(SupportedType)
            If Result.Import_From_Stream(CurrentReader) = False Then Return False
            Result.UpdateLocalizations(CurrentReader.Settings.LocalizeController)
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, 1, Result.InternalDisplayName)
            ResultSucceed = True
            ContentEntry.XML_RelativePath = Result.Determine_DefaultRelativeFilePath(COH_ExportFormat.XML)
            ContentEntry.REF_OriginolPath = Result.Retrieve_OriginolSourceReference
            ContentEntry.REF_FullName = Result.Retrieve_LookupName
            Return ResultSucceed
        End Function
        Private Function ExtractContent(ByRef Source As COH_CrypticS, SupportedType As Type, ByRef ContentEntry As COH_CrypticS_FileContentDetails, ByRef CurrentReader As COH_BinaryReader, ByRef Result As Byte(), Optional ShowProgress As Boolean = False) As Boolean
            Dim ResultSucceed As Boolean = False
            CurrentReader.Position = ContentEntry.Offset
            Result = CurrentReader.ReadBytes(ContentEntry.Size)
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, 1, ContentEntry.Name)
            Return True
        End Function
#End Region

#Region "Combine Structures"
        Private Function CombineAllRecords(ByRef Source As COH_CrypticS, TheType As Type, ByRef Results As List(Of COH_FileStructure)) As Object
            Dim TheList As Object() = Array.CreateInstance(TheType, Results.Count)
            For X = 0 To Results.Count - 1
                '//TheList(X) = DirectCast(Results(X))
                Source.Files(0).Details(X).FileIndex = X
                Source.Files(0).Details(X).XML_RelativePath = Source.Name & ".xml"
            Next
            Return TheList
        End Function
#End Region
    End Class
End Namespace