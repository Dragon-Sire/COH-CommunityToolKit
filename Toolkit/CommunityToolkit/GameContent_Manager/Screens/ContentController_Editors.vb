Imports COH.GameContent.Internal.Events
Imports COH.Internal.Events
Imports COH.Toolkit.Controls.WinForms.Dialogs
Imports COH.Toolkit.Controls.WinForms.Internal
Imports COH.Toolkit.Modding.Editors
Imports COH.Tools.Controls.Forms
Imports COH.Tools.Internal.Enums

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Properties"
        Public ReadOnly Property ListWindows_InUse As List(Of COH_FormTemplate)
            Get
                Return mListWindows_InUse
            End Get
        End Property
#End Region

#Region "Private Usage"
        Private mListWindows_InUse As List(Of COH_FormTemplate)
        Private mUseIndependentScreens As Boolean = False
#End Region

#Region "Project Editors"
        Public Sub OpenEditor_Project()
            Dim NewEditor As New COH_ProjectView(Me)
            ShowWindow(NewEditor, False)
        End Sub
#End Region

#Region "Editors"
        Public Sub OpenEditor_MessageStores(Optional Search As String = Nothing)
            Dim NewEditor As New COH_MessageStoreEdit(Me)
            NewEditor.Prepare_Editor(COH_ContentController.Instance.MessageStore_Controller, Search)
            ShowWindow(NewEditor, False)
        End Sub
        Public Sub OpenEditor_ModdableContentEditor()
            Dim NewEditor As New COH_EditModdableContent(Me)
            ShowWindow(NewEditor, False)
        End Sub
        Public Sub OpenEditor_PiggViewer_FindFile()
            Dim FileName As String = ""
            If OpenFile_PIGG(FileName) = False Then Exit Sub
            OpenEditor_PiggEditor(FileName)
        End Sub
        Public Sub OpenEditor_PiggEditor(FileName As String)
            If IO.File.Exists(FileName) = False Then
                ShowMessage_SimpleError(FileName & " - Does Not Exist")
                If LocateFile(IO.Path.GetFileName(FileName), FileName) = False Then Exit Sub
            End If
            Dim NewEditor As New COH_FormWrapped_Pigg_View(Me)
            NewEditor.Prepare_Editor(FileName)
            ShowWindow(NewEditor, False)
        End Sub
        Public Sub OpenEditor_3Viewer()
            Dim FileName As String = ""
            If OpenFile_GEO(FileName) = False Then Exit Sub
            If IO.File.Exists(FileName) = False Then
                ShowMessage_SimpleError(FileName & " - Does Not Exist")
                If LocateFile(IO.Path.GetFileName(FileName), FileName) = False Then Exit Sub
            End If
            Assets_Controller.Add_CustomLocation_Textures(IO.Path.GetDirectoryName(FileName))
            Assets_Controller.Add_CustomLocation_TGA(IO.Path.GetDirectoryName(FileName))
            Dim NewEditor As New COH_3D_View(Me)
            ShowWindow(NewEditor, False)
            NewEditor.Prepare_Editor(FileName)
        End Sub
#End Region

#Region "View Screens"
        Public Sub OpenAboutBox()
            Dim NewEditor As New COH_AboutBox(Me)
            '//NewEditor.DisplayDetails(My.Resources.Logo, ProgramFolders.LookupFolder(COH_ProgramPaths.Root) & "ChangeLog.rtf", My.Application.Info.Version.ToString)
            ShowWindow(NewEditor, True)
        End Sub
        Public Sub CheckUpdate(Optional ForceShowMessage As Boolean = False)
            '#If Not DEBUG Then
            Check_Update(Settings.GitReleaseFeed, ForceShowMessage, sMainForm.CoH_Menu1.UpdateLink)
            '#End If
        End Sub
        Public Sub OpenCRCTool()
            Dim NewEditor As New COH_CRC_Tool(Me)
            ShowWindow(NewEditor, True)
        End Sub
        Public Sub OpenByteInspection(ByRef e As COH_EventResponse_StreamInspect) '///Handles mEventController.TriggerInspectStream
            Dim NewEditor As New Dialog_ByteView(Me)
            NewEditor.LoadStream(e.StreamReader)
            ShowWindow(NewEditor, True)
        End Sub
#End Region

#Region "Bin Viewer"
        Public Sub OpenEditor_BinViewer_FindFile()
            Dim FileName As String = ""
            If OpenFile_BIN(FileName) = False Then Exit Sub
            OpenEditor_BinViewer(FileName)
        End Sub
        Public Sub OpenEditor_BinViewer(FileName As String)
            If IO.File.Exists(FileName) = False Then
                ShowMessage_SimpleError(FileName & " - Does Not Exist")
                If LocateFile(IO.Path.GetFileName(FileName), FileName) = False Then Exit Sub
            End If
            Dim NewEditor As New COH_FormWrapped_Bin_View(Me)
            NewEditor.Prepare_Editor(FileName)
            ShowWindow(NewEditor, False)
        End Sub
        Public Function ViewBin_CharacterClasses(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "bin\classes.bin"
            OpenEditor_BinViewer(FileSource)
            Return True
        End Function
        Public Function ViewBin_StoryArc() As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "bin\storyarc.bin"
            OpenEditor_BinViewer(FileSource)
            Return True
        End Function
        Public Function ViewBin_DayJobs() As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "bin\DayJobs.bin"
            OpenEditor_BinViewer(FileSource)
            Return True
        End Function
#End Region

#Region "Texture Viewer"
        Public Sub OpenEditor_TextureViewer_FindFile()
            Dim FileName As String = ""
            If OpenFile_Texture(FileName) = False Then Exit Sub
            OpenEditor_TextureViewer(FileName)
        End Sub
        Public Sub OpenEditor_TextureViewer(FileName As String)
            If IO.File.Exists(FileName) = False Then
                ShowMessage_SimpleError(FileName & " - Does Not Exist")
                If LocateFile(IO.Path.GetFileName(FileName), FileName) = False Then Exit Sub
            End If
            Dim NewEditor As New COH_FormWrapped_Texture_View(Me)
            NewEditor.Prepare_Editor(FileName)
            ShowWindow(NewEditor, False)
        End Sub
#End Region

#Region "Pigg Specific Editors"
        Public Function ViewPigg_PrimaryBin(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_PIGG_i24) & "bin.pigg"
            OpenEditor_PiggEditor(FileSource)
            Return True
        End Function
        Public Function ViewPigg_PrimaryBin_i25(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_PIGG_i25_Score) & "bin.pigg"
            OpenEditor_PiggEditor(FileSource)
            Return True
        End Function
        Public Function ViewPigg_PowersBin_i25(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_PIGG_i25_Score) & "bin_powers.pigg"
            OpenEditor_PiggEditor(FileSource)
            Return True
        End Function
        Public Function ViewPigg_texgui1(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_PIGG_i24) & "texGui1.pigg"
            OpenEditor_PiggEditor(FileSource)
            Return True
        End Function
        Public Function ViewPigg_geom(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_PIGG_i24) & "geom.pigg"
            OpenEditor_PiggEditor(FileSource)
            Return True
        End Function
        Public Function ViewPigg_geomBC(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_PIGG_i24) & "geomBC.pigg"
            OpenEditor_PiggEditor(FileSource)
            Return True
        End Function
#End Region

#Region "XML Editors"
        Public Function ViewXML(ByRef Source As String) As Boolean
            Dim NewEditor As New COH_XML_Viewer()
            NewEditor.ViewTex(Source, True)
            ShowWindow(NewEditor, False)
            Return True
        End Function
        Public Function ViewText(ByRef Source As String) As Boolean
            Dim NewEditor As New COH_XML_Viewer()
            NewEditor.ViewTex(Source, False)
            ShowWindow(NewEditor, False)
            Return True
        End Function
#End Region


#Region "Events"
        Event AllWindowsClosed()
        Event PrimaryWindowsIsOpen()
        Private Sub Handle_Event_WindowAdded(NewForm As COH_FormTemplate)
            If mListWindows_InUse Is Nothing Then mListWindows_InUse = New List(Of COH_FormTemplate)
            AddHandler NewForm.Disposed, AddressOf Handle_Event_WindowDisposed
            mListWindows_InUse.Add(NewForm)
            RaiseEvent PrimaryWindowsIsOpen()
        End Sub
        Private Sub Handle_Event_WindowDisposed(sender As Object, e As EventArgs)
            Dim NewForm As Control = sender
            RemoveHandler NewForm.Disposed, AddressOf Handle_Event_WindowDisposed
            mListWindows_InUse.Remove(NewForm)
            If mListWindows_InUse.Count = 0 Then RaiseEvent AllWindowsClosed()
        End Sub
#End Region

#Region "Open Windows"
        Private Function ShowWindow(ByRef NewForm As COH_FormTemplate, Optional IsDialog As Boolean = False) As DialogResult
            Handle_Event_WindowAdded(NewForm)
            If mUseIndependentScreens = True Or IsDialog = True Then
                Return ShowWindow_Independent(NewForm, IsDialog)
            Else
                Return ShowWindow_HasParent(NewForm, IsDialog)
            End If
        End Function
        Private Function ShowWindow_Independent(ByRef NewForm As COH_FormTemplate, Optional IsDialog As Boolean = False) As DialogResult
            If IsDialog = False Then
                NewForm.ShowMe_AsForm(Nothing)
                Return DialogResult.None
            Else
                Return NewForm.ShowMe_AsDialog(Nothing)
            End If
        End Function
        Private Function ShowWindow_HasParent(ByRef NewForm As COH_FormTemplate, Optional IsDialog As Boolean = False) As DialogResult
            NewForm.StartPosition = FormStartPosition.CenterParent
            If IsDialog = False Then
                NewForm.ShowMe_AsForm(sMainForm)
                Return DialogResult.None
            Else
                Return NewForm.ShowMe_AsDialog(sMainForm)
            End If
        End Function
#End Region
    End Class
End Namespace