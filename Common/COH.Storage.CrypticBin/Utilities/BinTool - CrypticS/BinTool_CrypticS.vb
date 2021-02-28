Imports COH.CodeManagement.Enums.Structures
Imports COH.CodeManagement.Interfaces.Structures
Imports COH.GameContent
Imports COH.Storage.Controllers
Imports COH.Storage.Serialization
Imports COH.Storage.Serialization.Configuration
Imports COH.Storage.Structures
Imports COH.Storage.Structures.CrypticsS

Namespace Utilities
    Public NotInheritable Class COH_BinTool_CrypticS
        Implements IDisposable

#Region "Properties"
        Property Content As COH_CrypticS
            Get
                Return mCrypticS_Info
            End Get
            Set(value As COH_CrypticS)
                mCrypticS_Info = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mCrypticS_Info As COH_CrypticS
        Private mCurrentReader As COH_BinaryReader
        Private mValid As Boolean
        Private mLanguageMaps As ISupport_COH_LocalizeContent
        Private mFileStructs As COH_FileStructureIndex_Controller
#End Region

#Region "Create New Instance"
        Sub New()
        End Sub
        Sub New(ByRef LanguageMaps As ISupport_COH_LocalizeContent, ByRef FileStructureController As COH_FileStructureIndex_Controller)
            mFileStructs = FileStructureController
            mLanguageMaps = LanguageMaps
        End Sub
        Public Function OpenExisting_BinFile(FilePath As String, Optional Settings As COH_CrypticS_Settings = Nothing, Optional ShowProgress As Boolean = False) As Boolean
            If IO.File.Exists(FilePath) = False Then Return False
            Dim CurrentStream As New IO.FileStream(FilePath, IO.FileMode.Open)
            mCurrentReader = New COH_BinaryReader(CurrentStream, Text.Encoding.UTF8)
            mCurrentReader.Settings = New COH_Serialization_Settings(True, COH_ExportFormat.CrypticS_BINFormat, mLanguageMaps)
            mCrypticS_Info = New COH_CrypticS(IO.Path.GetFileName(FilePath), Settings, mFileStructs)
            mValid = mCrypticS_Info.Import_FromStream(mCurrentReader, ShowProgress)
            Return mValid
        End Function
        Public Function OpenExisting_BinFile(Name As String, ByRef Bytes As Byte(), Optional Settings As COH_CrypticS_Settings = Nothing, Optional ShowProgress As Boolean = False) As Boolean
            Dim CurrentStream As New IO.MemoryStream(Bytes)
            mCurrentReader = New COH_BinaryReader(CurrentStream, Text.Encoding.UTF8)
            mCurrentReader.Settings = New COH_Serialization_Settings(True, COH_ExportFormat.CrypticS_BINFormat, mLanguageMaps)
            mCrypticS_Info = New COH_CrypticS(Name, Settings, mFileStructs)
            mValid = mCrypticS_Info.Import_FromStream(mCurrentReader, ShowProgress)
            Return mValid
        End Function
        Public Function Create_NewFile(FilePath As String, ByRef Source As COH_CrypticS, Optional ShowProgress As Boolean = True) As Boolean
            If IO.File.Exists(FilePath) = True Then IO.File.Delete(FilePath)
            Source.Update_SupportedStructs(mFileStructs)
            Dim CurrentStream As New IO.FileStream(FilePath, IO.FileMode.Create)
            Using CurrentWriter As New COH_BinaryWriter(CurrentStream, Text.Encoding.ASCII)
                If Export_ToStream(Source, CurrentWriter, ShowProgress) = False Then Return False
            End Using
            CurrentStream = Nothing
            Return True
        End Function
#End Region

#Region "Create CrypticS"
        Public Shared Function Create_FromFile(Name As String, FilePath As String, ByRef Result As COH_CrypticS, Optional Settings As COH_CrypticS_Settings = Nothing, Optional ShowProgress As Boolean = False) As Boolean
        End Function

#End Region

#Region "Search"
        Public Function Retrieve_TotalNumberEntries() As Integer
            Dim Total As Integer
            For X = 0 To mCrypticS_Info.Files.Count - 1
                Total += mCrypticS_Info.Files(X).Details.Count
            Next
            Return Total
        End Function
#End Region

#Region "Extract"
        Public Function ExtractFromBin_Items(Title As String, ByRef Results As COH_FileStructure(), Optional FileIndex As Integer = 0, Optional ShowProgress As Boolean = True) As Boolean
            Dim TempList = New List(Of COH_FileStructure)
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, Retrieve_TotalNumberEntries, "Extracting Contents - " & Title)
            If ExtractContents(mCrypticS_Info, mCurrentReader, TempList, True, ShowProgress) = False Then Return False
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)
            Results = TempList.ToArray
            Return True
        End Function
        Public Function ExtractFromBin_Items(Title As String, ByRef Results As COH_FileStructure()(), Optional ShowProgress As Boolean = True) As Boolean
            Results = New COH_FileStructure(mCrypticS_Info.Files.Count - 1)() {}
            For X = 0 To mCrypticS_Info.Files.Count - 1
                Dim TempList = New List(Of COH_FileStructure)
                If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, Retrieve_TotalNumberEntries, "Extracting Contents - " & Title)
                If ExtractContents(mCrypticS_Info, mCrypticS_Info.Files(X), mCurrentReader, TempList, True, ShowProgress) = False Then Return False
                If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)
                Results(X) = TempList.ToArray
            Next
            Return True
        End Function
#End Region


#Region "Export"
        Public Function ExtractFromBin_WriteXML(Title As String, Folder As String, Optional FileIndex As Integer = 0, Optional ShowProgress As Boolean = True) As Boolean
            Dim TempList = New List(Of COH_FileStructure)
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, Retrieve_TotalNumberEntries, "Extracting Contents - " & Title)
            If ExtractContents(mCrypticS_Info, mCurrentReader, TempList, True, ShowProgress) = False Then Return False
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)

            Select Case mCrypticS_Info.Options.Option_BINs_CombineStructures
                Case COH_CrypticS_Settings.COH_CombineStructs_Option.SeperateFiles
                    Export_ToXML(Title, TempList, Folder)
                Case COH_CrypticS_Settings.COH_CombineStructs_Option.AllCombined
                    Dim NewResults = CombineAllRecords(mCrypticS_Info, mCrypticS_Info.Files(FileIndex).SupportedType, TempList)
                    Export_ToXML_Combined(Title, TempList, Folder & mCrypticS_Info.Files(FileIndex).Details(0).XML_RelativePath)
                Case Else
                    Return False
            End Select
            ExtractFromBin_FileList(mCrypticS_Info.Name, Folder)
            Return True
        End Function
        Public Function ExtractFromBin_WriteXML(Title As String, RootFolder As String, SubFolders As String(), Optional ShowProgress As Boolean = True) As Boolean
            Dim TempList As List(Of COH_FileStructure)
            For X = 0 To mCrypticS_Info.Files.Count - 1
                TempList = New List(Of COH_FileStructure)
                If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, Retrieve_TotalNumberEntries, "Extracting Contents - " & Title)
                If ExtractContents(mCrypticS_Info, mCrypticS_Info.Files(X), mCurrentReader, TempList, True, ShowProgress) = False Then Return False
                If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)
                Select Case mCrypticS_Info.Options.Option_BINs_CombineStructures
                    Case COH_CrypticS_Settings.COH_CombineStructs_Option.SeperateFiles
                        Export_ToXML(Title, TempList, SubFolders(X))
                    Case COH_CrypticS_Settings.COH_CombineStructs_Option.AllCombined
                        Dim NewResults = CombineAllRecords(mCrypticS_Info, mCrypticS_Info.Files(X).SupportedType, TempList)
                        Export_ToXML_Combined(Title, TempList, SubFolders(X) & mCrypticS_Info.Files(X).Details(0).XML_RelativePath)
                    Case Else
                        Return False
                End Select
            Next
            ExtractFromBin_FileList(mCrypticS_Info.Name, RootFolder)
            Return True
        End Function
        Public Function ExtractFromBin_FileList(Name As String, Folder As String) As Boolean
            Dim FilePath As String = Folder & "Index_" & Name & ".Xml"
            Helperfunctions.XML.Export_XMLFile(FilePath, mCrypticS_Info)
            Return True
        End Function
        Public Function ExtractFromBin_Item(FileIndex As Integer, ContentIndex As Integer, ByRef Result As COH_FileStructure, ByRef LanguageMaps As ISupport_COH_LocalizeContent) As Boolean
            Return ExtractContent(mCrypticS_Info, mCrypticS_Info.Files(FileIndex).SupportedType, mCrypticS_Info.Files(FileIndex).Details(ContentIndex), mCurrentReader, Result, False)
        End Function
        Public Function ExtractFromBin_RawBytes(FileIndex As Integer, ContentIndex As Integer, ByRef Result As Byte(), ByRef LanguageMaps As ISupport_COH_LocalizeContent) As Boolean
            Return ExtractContent(mCrypticS_Info, mCrypticS_Info.Files(FileIndex).SupportedType, mCrypticS_Info.Files(FileIndex).Details(ContentIndex), mCurrentReader, Result, False)
        End Function
        Public Function RebuildBin(ByRef CurrentWriter As COH_BinaryWriter, ByRef Sources() As COH_FileStructure) As Boolean
            Throw New NotImplementedException()
        End Function
#End Region

#Region "Convert to XML"
        Private Shared Function Export_ToXML(Title As String, ByRef Entries As List(Of COH_FileStructure), Folder As String, Optional UseSourcePath As Boolean = False, Optional ShowProgress As Boolean = True) As Boolean
            Dim results As New List(Of String)
            COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, Entries.Count, "Writing XML - " & Title)
            Dim UpdateInterval As Integer = ProgressUpdate_UpdateInterval(Entries.Count, ShowProgress)
            Dim UpdateStep As Integer = 0
            Dim UpdateProgressBar As Boolean = False
            Dim Index As Integer = 1
            For Each item In Entries
                UpdateStep += 1
                If UpdateStep >= UpdateInterval Then
                    UpdateStep = 0
                    If ShowProgress = True Then UpdateProgressBar = True
                Else
                    UpdateProgressBar = False
                End If
                item.Export_To_File(Nothing, Folder, COH_ExportFormat.XML)
                If UpdateProgressBar = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, UpdateInterval, item.InternalDisplayName)
            Next
            COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)
            Return True
        End Function
        Private Shared Function Export_ToXML_Combined(Title As String, ByRef Entries As List(Of COH_FileStructure), Folder As String, Optional UseSourcePath As Boolean = False, Optional ShowProgress As Boolean = True) As Boolean
            Dim results As New List(Of String)
            COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, 1, "Writing XML - " & Title)
            Helperfunctions.XML.Export_XMLFile(Folder, Entries, True)
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, 1, Title)
            COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)
            Return True
        End Function
        Private Function Import_MasterList(MasterListPath As String) As Boolean
            ' If COH_FileStorageBin_CrypticS_FileEntry.Import_XMLFile(MasterListPath, mMasterList) = False Then Return False
            '  Return True
        End Function
#End Region

#Region "Export - DEF"
        Public Function ExtractFromBin_WriteDEF(Title As String, Folder As String, Optional FileIndex As Integer = 0, Optional ShowProgress As Boolean = True) As Boolean
            Dim TempList = New List(Of COH_FileStructure)
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, Retrieve_TotalNumberEntries, "Extracting Contents - " & Title)
            If ExtractContents(mCrypticS_Info, mCurrentReader, TempList, True, ShowProgress) = False Then Return False
            If ShowProgress = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)

            Select Case mCrypticS_Info.Options.Option_BINs_CombineStructures
                Case COH_CrypticS_Settings.COH_CombineStructs_Option.SeperateFiles
                    Export_ToDEF(Title, TempList, Folder)
                Case COH_CrypticS_Settings.COH_CombineStructs_Option.AllCombined
                    Dim NewResults = CombineAllRecords(mCrypticS_Info, mCrypticS_Info.Files(FileIndex).SupportedType, TempList)
                    '//Export_ToDEF_Combined(Title, TempList, Folder & mCrypticS_Info.Files(FileIndex).Details(0).XML_RelativePath)
                Case Else
                    Return False
            End Select
            Return True
        End Function
        Private Shared Function Export_ToDEF(Title As String, ByRef Entries As List(Of COH_FileStructure), Folder As String, Optional UseSourcePath As Boolean = False, Optional ShowProgress As Boolean = True) As Boolean
            Dim results As New List(Of String)
            COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, Entries.Count, "Writing DEF - " & Title)
            Dim UpdateInterval As Integer = ProgressUpdate_UpdateInterval(Entries.Count, ShowProgress)
            Dim UpdateStep As Integer = 0
            Dim UpdateProgressBar As Boolean = False
            Dim Index As Integer = 1
            For Each item In Entries
                UpdateStep += 1
                If UpdateStep >= UpdateInterval Then
                    UpdateStep = 0
                    If ShowProgress = True Then UpdateProgressBar = True
                Else
                    UpdateProgressBar = False
                End If
                item.Export_To_File(Nothing, Folder, COH_ExportFormat.CrypticS_TextFormat)
                If UpdateProgressBar = True Then COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, UpdateInterval, item.InternalDisplayName)
            Next
            COH_LibraryEventController.ShowProgressUpdate(GameContent.Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)
            Return True
        End Function
#End Region



#Region " Handle Progress"
        Private Shared Function ProgressUpdate_UpdateInterval(Count As Integer, AllowShow As Boolean) As Int32
            If AllowShow = False Then Return Int32.MaxValue
            If Count < 1000 Then
                Return 1
            Else
                Return 5
            End If
        End Function
#End Region

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                    If Not (mCurrentReader Is Nothing) Then mCurrentReader.Dispose()
                End If
            End If
            disposedValue = True
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            ' TODO: uncomment the following line if Finalize() is overridden above.
            ' GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class
End Namespace