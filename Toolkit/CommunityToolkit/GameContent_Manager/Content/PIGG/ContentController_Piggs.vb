Imports COH.Storage.Containers.PIGG.Utilities
Imports COH.Tools.Internal.Enums

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Private Properties"
        Private WithEvents mCurrentPiggReader As COH_PiggTool
#End Region

#Region "Import & Rebuild Sources From Defs"
        Public Function ExtractPigg_MainBin(Optional ShowMessage As Boolean = False) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_PIGG_i24) & "bin.pigg"
            Dim Destination As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24)
            Return ExtractPigg_File("bin.pigg", FileSource, Destination, ShowMessage)
        End Function
        Public Function ExtractPiggs_FreshInstall(Optional ShowMessage As Boolean = False, Optional ProcessRecords As Boolean = False) As Boolean
            Dim Succeeded As Boolean = True
            If ExtractPigg_MainBin(False) = False Then Succeeded = False
            If ShowQuestion_Simple("Do You Wish To Extract all Additional Supported Piggs?") = MsgBoxResult.Yes Then
                If ExtractPiggs_AllTextures(False, ProcessRecords) = False Then Succeeded = False
                If ExtractPiggs_AllGEO(False, ProcessRecords) = False Then Succeeded = False
                If ExtractPiggs_AllAnimations(False, ProcessRecords) = False Then Succeeded = False
            End If
            If ShowMessage = True Then
                If Succeeded = True Then
                    ShowMessage_Simple("Extract Piggs Complete")
                Else
                    ShowMessage_Simple("Not Piggs Extracted Completly **NEED LOG**")
                End If
            End If
            Return True
        End Function
        Public Function ExtractPiggs_All(Optional ShowMessage As Boolean = False, Optional ProcessRecords As Boolean = False) As Boolean
            Dim Succeeded As Boolean = True
            If ExtractPigg_MainBin(False) = False Then Succeeded = False
            If ExtractPiggs_AllTextures(False, ProcessRecords) = False Then Succeeded = False
            If ExtractPiggs_AllGEO(False, ProcessRecords) = False Then Succeeded = False
            If ExtractPiggs_AllAnimations(False, ProcessRecords) = False Then Succeeded = False
            If ShowMessage = True Then
                If Succeeded = True Then
                    ShowMessage_Simple("Extract All Piggs Complete")
                Else
                    ShowMessage_Simple("Not All Piggs Extracted Complete **NEED LOG**")
                End If
            End If
            Prepare_AssetsController()
            Return True
        End Function
        Public Function ExtractPiggs_AllTextures(Optional ShowMessage As Boolean = False, Optional ProcessRecords As Boolean = False) As Boolean
            Dim Succeeded As Boolean = True
            If ExtractPigg_PlayerTextures(ProcessRecords, False, False) = False Then Succeeded = False
            If ExtractPigg_WorldTextures(ProcessRecords, False, False) = False Then Succeeded = False
            If ExtractPigg_EnemiesTextures(ProcessRecords, False, False) = False Then Succeeded = False
            If ExtractPigg_VillainTextures(ProcessRecords, False, False) = False Then Succeeded = False
            If ExtractPigg_MainTextures(ProcessRecords, False, False) = False Then Succeeded = False
            If ShowMessage = True Then
                If Succeeded = True Then
                    ShowMessage_Simple("Extract All Piggs Textures Complete")
                Else
                    ShowMessage_Simple("Not All Piggs Extracted Complete **NEED LOG**")
                End If
                Prepare_AssetsController()
            End If
            Return True
        End Function
        Public Function ExtractPiggs_AllGEO(Optional ShowMessage As Boolean = False, Optional ProcessRecords As Boolean = False) As Boolean
            Dim Succeeded As Boolean = True
            If ExtractPigg_MainGEOs(ProcessRecords, False, False) = False Then Succeeded = False
            If ShowMessage = True Then
                If Succeeded = True Then
                    ShowMessage_Simple("Extract All Piggs GEOs Complete")
                Else
                    ShowMessage_Simple("Not All Piggs Extracted Complete **NEED LOG**")
                End If
                Prepare_AssetsController()
            End If
            Return True
        End Function
        Public Function ExtractPiggs_AllAnimations(Optional ShowMessage As Boolean = False, Optional ProcessRecords As Boolean = False) As Boolean
            Dim Succeeded As Boolean = True
            If ExtractPigg_Animations(ProcessRecords, False, False) = False Then Succeeded = False
            If ShowMessage = True Then
                If Succeeded = True Then
                    ShowMessage_Simple("Extract All Piggs ANIMs Complete")
                Else
                    ShowMessage_Simple("Not All Piggs Extracted Complete **NEED LOG**")
                End If
                Prepare_AssetsController()
            End If
            Return True
        End Function
#End Region

#Region "Extract Bins - Single Files"
        Public Function ExtractPigg_Test(Optional ShowMessage As Boolean = False) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_PIGG_i24) & "texWorldBuildings.pigg"
            Dim Destination As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24)
            Return ExtractPigg_File("texWorldBuildings.pigg", FileSource, Destination, ShowMessage)
        End Function
        Public Function ExtractPigg_Animations(Optional ProcessRecord As Boolean = False, Optional DeleteAllFiles As Boolean = True, Optional ShowMessage As Boolean = False) As Boolean
            Return ExtractPigg_Files(Retrieve_ListPiggs_TexturesAssets_Animation, ProcessRecord, DeleteAllFiles, ShowMessage)
        End Function
        Public Function ExtractPigg_PlayerTextures(Optional ProcessRecord As Boolean = False, Optional DeleteAllFiles As Boolean = True, Optional ShowMessage As Boolean = False) As Boolean
            Return ExtractPigg_Files(Retrieve_ListPiggs_TexturesAssets_Player, ProcessRecord, DeleteAllFiles, ShowMessage)
        End Function
        Public Function ExtractPigg_WorldTextures(Optional ProcessRecord As Boolean = False, Optional DeleteAllFiles As Boolean = True, Optional ShowMessage As Boolean = False) As Boolean
            Return ExtractPigg_Files(Retrieve_ListPiggs_TexturesAssets_World, ProcessRecord, DeleteAllFiles, ShowMessage)
        End Function
        Public Function ExtractPigg_EnemiesTextures(Optional ProcessRecord As Boolean = False, Optional DeleteAllFiles As Boolean = True, Optional ShowMessage As Boolean = False) As Boolean
            Return ExtractPigg_Files(Retrieve_ListPiggs_TexturesAssets_Enemies, ProcessRecord, DeleteAllFiles, ShowMessage)
        End Function
        Public Function ExtractPigg_VillainTextures(Optional ProcessRecord As Boolean = False, Optional DeleteAllFiles As Boolean = True, Optional ShowMessage As Boolean = False) As Boolean
            Return ExtractPigg_Files(Retrieve_ListPiggs_TexturesAssets_Villain, ProcessRecord, DeleteAllFiles, ShowMessage)
        End Function
        Public Function ExtractPigg_MainTextures(Optional ProcessRecord As Boolean = False, Optional DeleteAllFiles As Boolean = True, Optional ShowMessage As Boolean = False) As Boolean
            Return ExtractPigg_Files(Retrieve_ListPiggs_TexturesAssets_Main, ProcessRecord, DeleteAllFiles, ShowMessage)
        End Function
        Public Function ExtractPigg_MainGEOs(Optional ProcessRecord As Boolean = False, Optional DeleteAllFiles As Boolean = True, Optional ShowMessage As Boolean = False) As Boolean
            Return ExtractPigg_Files(Retrieve_ListPiggs_GEOAssets_Main, ProcessRecord, DeleteAllFiles, ShowMessage)
        End Function
        Public Function ExtractPigg_Files(Files As List(Of String), Optional ProcessRecord As Boolean = False, Optional DeleteAllFiles As Boolean = True, Optional ShowMessage As Boolean = False) As Boolean
            Dim FolderSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_PIGG_i24)
            Dim Destination As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Assets)
            Dim Result As Boolean = True
            Dim Succeeded As Integer = 0
            For Each File In Files
                If ExtractPigg_File(File, FolderSource & File, Destination, ProcessRecord, DeleteAllFiles, False) = True Then
                    Succeeded += 1
                Else
                    Result = False
                End If
            Next
            If ShowMessage = True Then
                If Result = True Then
                    ShowMessage_Simple("Successfully Extracted All " & Files.Count & " PIGG Files")
                Else
                    ShowMessage_Simple("Extracted " & Succeeded & " of " & Files.Count)
                End If
            End If
            Return Result
        End Function
#End Region

#Region "General"
        Private Function ExtractPigg_File(Name As String, FileSource As String, Destination As String, Optional ProcessRecord As Boolean = False, Optional DeleteAllFiles As Boolean = True, Optional ShowMessage As Boolean = False) As Boolean
            Dim Found As Boolean = False
            Dim FileLocation As String = FileSource
            If IO.File.Exists(FileSource) = True Then Found = True
            If Found = False Then FileLocation = mLastLocated & "\" & Name : If IO.File.Exists(FileLocation) = True Then Found = True
            If Found = False Then
                ShowMessage_SimpleError(Name & " - Not Found")
                If LocateFile(Name, FileSource) = False Then Return False
            ElseIf IO.File.Exists(FileSource) = False Then
                IO.File.Copy(FileLocation, FileSource)
            End If
            If DeleteAllFiles = True Then Delete_AllFiles_InDirectory(Destination, False, IO.SearchOption.AllDirectories)
            mCurrentPiggReader = New COH_PiggTool
            mCurrentPiggReader.OpenExisting_PiggFile(FileSource)
            mCurrentPiggReader.ExtractAllFiles_ToDirectory(Destination, ProcessRecord, True)
            mCurrentPiggReader.Dispose()
            mCurrentPiggReader = Nothing
            If ShowMessage = True Then ShowMessage_Simple("Successfully Extracted " & Name)
            Return True
        End Function
#End Region

#Region "List_Of_Files"
        Private Function Retrieve_ListPiggs_TexturesAssets_Animation() As List(Of String)
            Dim Result As New List(Of String)
            Result.Add("stage1a.pigg")
            Return Result
        End Function
        Private Function Retrieve_ListPiggs_TexturesAssets_Player() As List(Of String)
            Dim Result As New List(Of String)
            Result.Add("texPlayersUI.pigg")
            Result.Add("texGui1.pigg")
            Result.Add("texFxGuiItems.pigg")
            Result.Add("stage1d.pigg")
            Result.Add("stage1e.pigg")
            Return Result
        End Function
        Private Function Retrieve_ListPiggs_TexturesAssets_Main() As List(Of String)
            Dim Result As New List(Of String)
            Result.Add("stage1b.pigg")
            Result.Add("stage1c.pigg")
            Result.Add("stage1f.pigg")
            Result.Add("stage2c.pigg")
            Result.Add("stage3d.pigg")
            Result.Add("stage3e.pigg")
            Result.Add("stage3f.pigg")
            Result.Add("stage3g.pigg")
            Return Result
        End Function
        Private Function Retrieve_ListPiggs_TexturesAssets_World() As List(Of String)
            Dim Result As New List(Of String)
            Result.Add("texWorld.pigg")
            Result.Add("texWorldBC.pigg")
            Result.Add("texWorldBuildings.pigg")
            Result.Add("texWorldCZ.pigg")
            Result.Add("texWorldSW.pigg")
            Result.Add("texWorldV1.pigg")
            Result.Add("texWorldV2.pigg")
            Return Result
        End Function
        Private Function Retrieve_ListPiggs_TexturesAssets_Villain() As List(Of String)
            Dim Result As New List(Of String)
            Result.Add("texVWorld.pigg")
            Result.Add("texVWorld1.pigg")
            Result.Add("texVWorld2.pigg")
            Result.Add("texVWorld3.pigg")
            Result.Add("texVEnemies.pigg")
            Result.Add("texVWorldBases1.pigg")
            Result.Add("texVWorldBases2.pigg")
            Return Result
        End Function
        Private Function Retrieve_ListPiggs_TexturesAssets_Enemies() As List(Of String)
            Dim Result As New List(Of String)
            Result.Add("texEnemies.pigg")
            Result.Add("texEnemies2.pigg")
            Result.Add("texEnemies3.pigg")
            Result.Add("texEnemies4.pigg")
            Result.Add("texEnemies5.pigg")
            Return Result
        End Function
        Private Function Retrieve_ListPiggs_GEOAssets_Main() As List(Of String)
            Dim Result As New List(Of String)
            Result.Add("stage2.pigg")
            Result.Add("stage3.pigg")
            Return Result
        End Function
#End Region

    End Class
End Namespace