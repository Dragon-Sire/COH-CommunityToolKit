Imports COH.Tools.Internal.ContentController

Public Class COH_Menu

#Region "Proects"
    Private Sub ViewCurrentProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCurrentProjectToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.OpenEditor_Project()
        UpdateCursor(False)
    End Sub
    Private Sub StartFreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartFreshToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.Start_FreshProjectFile_Standard(True)
        UpdateCursor(False)
    End Sub
#End Region

#Region "Menu Pigg"
    Private Sub ExtractAllSupportedBinsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractAllSupportedBinsToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractPiggs_All(True, False)
        UpdateCursor(False)
    End Sub
    Private Sub ExtractAllTexturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractAllTexturesToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractPiggs_AllTextures(True, False)
        UpdateCursor(False)
    End Sub
    Private Sub ExtractAllGEOsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractAllGEOsToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractPiggs_AllGEO(True, False)
        UpdateCursor(False)
    End Sub
    Private Sub ExtractAllANIMsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractAllANIMsToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractPiggs_AllAnimations(True, False)
        UpdateCursor(False)
    End Sub
    Private Sub PiggbinMainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PiggbinMainToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractPigg_MainBin(True)
        UpdateCursor(False)
    End Sub
    Private Sub TextWorldBuildingsTESTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextWorldBuildingsTESTToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractPigg_Test(True)
        UpdateCursor(False)
    End Sub
#End Region

#Region "Menu Pigg - Viewer"
    Private Sub OpenFileBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileBrowserToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.OpenEditor_PiggViewer_FindFile()
        UpdateCursor(False)
    End Sub
    Private Sub Texgui1piggToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Texgui1piggToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ViewPigg_texgui1(False)
        UpdateCursor(False)
    End Sub
    Private Sub GeomPiggToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeomPiggToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ViewPigg_geom(False)
        UpdateCursor(False)
    End Sub
    Private Sub BinPiggToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinPiggToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ViewPigg_PrimaryBin(False)
        UpdateCursor(False)
    End Sub
    Private Sub Binpiggi25ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Binpiggi25ToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ViewPigg_PrimaryBin_i25(False)
        UpdateCursor(False)
    End Sub
    Private Sub BinpowerspiggToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinpowerspiggToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ViewPigg_PowersBin_i25(False)
        UpdateCursor(False)
    End Sub
#End Region

#Region "Menu BIN - Extract"
    Private Sub ExtractAllSupportedBinsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExtractAllSupportedBinsToolStripMenuItem1.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBins_All(True, False, True)
        UpdateCursor(False)
    End Sub
    Private Sub ExtractAllSupportedMessageStoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractAllSupportedMessageStoresToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBins_All(True, True, False)
        UpdateCursor(False)
    End Sub
    Private Sub ClassesbinToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClassesbinToolStripMenuItem1.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_CharacterClasses(True)
        UpdateCursor(False)
    End Sub
    Private Sub VillainclassesbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VillainclassesbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_EnemyClasses(True)
        UpdateCursor(False)
    End Sub
    Private Sub PowerCategoriespowercatsbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerCategoriespowercatsbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_PowerCategories(True)
        UpdateCursor(False)
    End Sub
    Private Sub PowerSetspowersetsbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerSetspowersetsbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_PowerSets(True)
        UpdateCursor(False)
    End Sub
    Private Sub PowerspowersbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerspowersbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_Powers(True)
        UpdateCursor(False)
    End Sub
    Private Sub MessageStoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessageStoresToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_AllMessagesStores(True)
        UpdateCursor(False)
    End Sub
    Private Sub OriginbinVillianoriginbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OriginbinVillianoriginbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_AllOrigins(True)
        UpdateCursor(False)
    End Sub
    Private Sub AttributenamesbinAttributedescriptionsbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttributenamesbinAttributedescriptionsbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_AllAttribs(True)
        UpdateCursor(False)
    End Sub
    Private Sub ProductCatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductCatalogToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_ProductCatalog(True)
        UpdateCursor(False)
    End Sub
    Private Sub ContactsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactsListToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_ContactList(True)
        UpdateCursor(False)
    End Sub
    Private Sub NPCClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NPCClientToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_NPC(True)
        UpdateCursor(False)
    End Sub
    Private Sub EntitiesenttypesbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntitiesenttypesbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_Entities(True)
        UpdateCursor(False)
    End Sub
    Private Sub AnimationSequencessequencesbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimationSequencessequencesbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_AnimationSeq(True)
        UpdateCursor(False)
    End Sub
    Private Sub TrickstricksbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrickstricksbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ExtractBin_TricksANDTextureOptions(True)
        UpdateCursor(False)
    End Sub
#End Region

#Region "Menu BIN - Rebuild"
    Private Sub ClassesbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassesbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.RebuildBin_AllCharacterClasses(True)
        UpdateCursor(False)
    End Sub
    Private Sub CharacterOriginsoriginsbinVillainoriginsbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterOriginsoriginsbinVillainoriginsbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.RebuildBin_AllCharacterOrigins(True)
        UpdateCursor(False)
    End Sub
    Private Sub PowerCategoriespowercatbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerCategoriespowercatbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.RebuildBin_PowerCategories(True)
        UpdateCursor(False)
    End Sub
    Private Sub PowerSetsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PowerSetsToolStripMenuItem1.Click
        UpdateCursor(True)
        COH_ContentController.Instance.RebuildBin_PowerSets(True)
        UpdateCursor(False)
    End Sub
    Private Sub PowerspowersbinToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PowerspowersbinToolStripMenuItem1.Click
        UpdateCursor(True)
        COH_ContentController.Instance.RebuildBin_Powers(True)
        UpdateCursor(False)
    End Sub
    Private Sub ProductCatalogproductcatalogbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductCatalogproductcatalogbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.RebuildBin_ProductCatalog(True)
        UpdateCursor(False)
    End Sub
#End Region

#Region "Menu BIN - Viewer"
    Private Sub OpenFileExporerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileExporerToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.OpenEditor_BinViewer_FindFile()
        UpdateCursor(False)
    End Sub
    Private Sub CharacterClassesclassesbinToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        UpdateCursor(True)
        COH_ContentController.Instance.OpenEditor_ModdableContentEditor()
        UpdateCursor(False)
    End Sub
    Private Sub StoryarcbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoryarcbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ViewBin_StoryArc()
        UpdateCursor(False)
    End Sub
    Private Sub DayJobsbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DayJobsbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.ViewBin_DayJobs()
        UpdateCursor(False)
    End Sub
    Private Sub DViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DViewerToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.OpenEditor_3Viewer()
        UpdateCursor(False)
    End Sub
    Private Sub TextureViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextureViewerToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.OpenEditor_TextureViewer_FindFile()
        UpdateCursor(False)
    End Sub
#End Region

#Region "Menu BIN - Import"
    Private Sub ClientmessagesbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientmessagesbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.Extract_CompareBin_ClientMessages(True)
        UpdateCursor(False)
    End Sub
    Private Sub MessagesenbinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessagesenbinToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.Extract_CompareBin_ServerMessages(True)
        UpdateCursor(False)
    End Sub
#End Region

#Region "Menu - Extract Assets"
    Private Sub ExtractSkeletonsFromANIMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractSkeletonsFromANIMToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.Extract_Skeletons(True, True)
        UpdateCursor(False)
    End Sub
#End Region

#Region "Menu - Ouroboros Code"
    Private Sub RebuildSourceCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebuildSourceCodeToolStripMenuItem.Click
        COH_ContentController.Instance.ProgramFolders.Rebuild_Ouroboros_RepoPathRoot()
    End Sub
    Private Sub UpdateMSBuildPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMSBuildPathToolStripMenuItem.Click
        COH_ContentController.Instance.ProgramFolders.UpdateEnviromentPath_MSBUILD()
    End Sub
    Private Sub DownloadSourceCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadSourceCodeToolStripMenuItem.Click
        COH_ContentController.Instance.ProgramFolders.Download_Ouroboros_Repo()
    End Sub
#End Region

#Region "Menu Tools"
    Private Sub CRC32ToolToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CRC32ToolToolStripMenuItem1.Click
        UpdateCursor(True)
        COH_ContentController.Instance.OpenCRCTool()
        UpdateCursor(False)
    End Sub
    Private Sub MessageStoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessageStoreToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.OpenEditor_MessageStores(Nothing)
        UpdateCursor(False)
    End Sub
#End Region

#Region "About"
    Private Sub AboutToolKitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolKitToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.OpenAboutBox()
        UpdateCursor(False)
    End Sub
    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdateToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.CheckUpdate(True)
        UpdateCursor(False)
    End Sub
    Private Sub UpdateLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UpdateLink.LinkClicked
        If String.IsNullOrEmpty(UpdateLink.Tag) = True Then Exit Sub
        UpdateCursor(True)
        System.Diagnostics.Process.Start(UpdateLink.Tag)
        UpdateCursor(False)
    End Sub
#End Region

#Region "Cursor"
    Private Sub UpdateCursor(Wait As Boolean)
        If Wait = True Then
            Cursor.Current = Cursors.WaitCursor
            UseWaitCursor = True
            ParentForm.UseWaitCursor = True
        Else
            Cursor.Current = Cursors.Default
            UseWaitCursor = False
            ParentForm.UseWaitCursor = False
        End If
    End Sub

    Private Sub DownloadInstallGitForWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadInstallGitForWindowsToolStripMenuItem.Click
        COH_ContentController.Instance.Download_GitForWindows()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        System.Environment.Exit(0)
    End Sub

    Private Sub EditModdableContentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditModdableContentToolStripMenuItem.Click
        UpdateCursor(True)
        COH_ContentController.Instance.OpenEditor_ModdableContentEditor()
        UpdateCursor(False)
    End Sub
#End Region
End Class
