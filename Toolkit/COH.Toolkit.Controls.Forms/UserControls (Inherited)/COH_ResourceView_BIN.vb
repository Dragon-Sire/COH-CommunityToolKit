Imports System.IO
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Utilities

Namespace Toolkit.Controls.WinForms.UserControls
    Public Class COH_Control_ViewBin

#Region "Private Properties"
        Private mFileSource As String
        Private mBinTool As COH_BinTool_CrypticS
        Private mSettings As COH_Serialization_Settings
        Private mFileIndex As Integer
        Private mContentIndex As Integer
        Private mCurrentStruct As COH_FileStructure
        Private mMenuItems As List(Of COH_FileStructure.DynamicMenu_Cmmand)
#End Region

#Region "Initialize"
        Public Sub New(ByRef ContentController As ISupport_MasterController)
            MyBase.New(ContentController)
            InitializeComponent()
            Changes_Locked = True
        End Sub
        Protected Overrides Sub DisposeAdditional()
            mBinTool.Dispose()
        End Sub
#End Region

#Region "Prepare Usage"
        Public Sub Prepare_Editor(FilePath As String)
            Select Case HelperFunctions.Serialize.PIGG.Identify_BinType(FilePath)
                Case COH_Supported_ContentType.Resource_BIN_CrypticS
                    mSettings = New COH_Serialization_Settings(True, COH_ExportFormat.XML, ContentController.TheController_Localize)  ' //THIS SHOULD GET PASSED FROM MAIN CONTROLLER AND STORED
                    mBinTool = New Utilities.COH_BinTool_CrypticS(ContentController.TheController_Localize, ContentController.TheController_SupportedStructures)
                    mBinTool.OpenExisting_BinFile(FilePath, New COH_CrypticS_Settings(False, False), False)
                    mSettings.Option_Version = mBinTool.Content.ParseVersion
                    DisplayInfo()
            End Select
        End Sub
        Public Sub Prepare_Editor(Name As String, EntryType As COH_Supported_ContentType, ByRef Bytes As Byte())
            Select Case EntryType
                Case COH_Supported_ContentType.Resource_BIN_CrypticS
                    mContentIndex = 0
                    mSettings = New COH_Serialization_Settings(True, COH_ExportFormat.XML, ContentController.TheController_Localize) ' //THIS SHOULD GET PASSED FROM MAIN CONTROLLER AND STORED
                    mBinTool = New COH_BinTool_CrypticS(ContentController.TheController_Localize, ContentController.TheController_SupportedStructures)
                    mBinTool.OpenExisting_BinFile(Name, Bytes, New COH_CrypticS_Settings(False, False), False)
                    mSettings.Option_Version = mBinTool.Content.ParseVersion
                    DisplayInfo()
                Case COH_Supported_ContentType.Resource_BIN_MessageStore
                Case COH_Supported_ContentType.Unknown
            End Select
        End Sub
        Private Sub DisplayInfo()
            Changes_Locked = True
            Display_Content_InTree()
            DisplayInfo_ContentDetails(0)
            DisplayInfo_ContentDetails()
            Changes_Locked = False
        End Sub
#End Region

#Region "Display CrypticS Content"
        Private Sub Display_Content_InTree()
            TreeView1.BeginUpdate()
            TreeView1.Nodes.Clear()
            Dim UseView1 As Boolean = True
            If mBinTool.Content.Files(0).Details(0).XML_RelativePath.Contains(".") And mBinTool.Content.Files(0).Details(0).XML_RelativePath.Contains("/") Then
                If mBinTool.Content.Files(0).Details(0).XML_RelativePath.Contains(".STORYARC") Then UseView1 = False
            End If
            For X = 0 To mBinTool.Content.Files.Count - 1
                If UseView1 = True Then
                    TreeView1.Nodes.Add(AddToTree_Content_InTree_File(X + 1, mBinTool.Content.Files(X)))
                Else
                    TreeView1.Nodes.Add(AddToTree_Content_InTree_File2(X + 1, mBinTool.Content.Files(X)))
                End If
            Next
            TreeView1.Nodes(0).ExpandAll()
            TreeView1.EndUpdate()
        End Sub
        Private Function AddToTree_Content_InTree_File(Index As Integer, ByRef theFile As COH_CrypticS_File) As TreeNode
            Dim NewRootNode As New TreeNode(theFile.Name)
            For X = 0 To theFile.Details.Count - 1
                NewRootNode.Nodes.Add(New TreeNode(theFile.Details(X).XML_RelativePath) With {.Name = "File" & Index & "!" & X})
            Next
            Return NewRootNode
        End Function
        Private Function AddToTree_Content_InTree_File2(Index As Integer, ByRef theFile As COH_CrypticS_File) As TreeNode
            Dim NewRootNode As New TreeNode(theFile.Name)
            Dim PAths = mBinTool.Content.Files(Index - 1).Retrieve_AllEntryPaths(False)
            HelperFunctions.Toolkit.Controls.TreeViews.Fill_TreeView_GetNodes_WithIndex(NewRootNode, Index, PAths, ".")
            Return NewRootNode
        End Function
#End Region

#Region "Display Dynamic Menus"
        Private Sub AddMenus()
            '  ClearMenus()
            ' If mCurrentStruct Is Nothing Then Exit Sub
            ' mMenuItems = mCurrentStruct.Retrieve_DynamicMenus
            ' If mMenuItems Is Nothing Then Exit Sub
            ' For X = 0 To mMenuItems.Count
            'Dim NewMenu = New ToolStripMenuItem() With {.Text = mMenuItems(X).DisplayName, .Name = X.ToString}
            ''Me.RootMenus.DropDownItems.Add(NewMenu)
            ' AddHandler NewMenu.Click, AddressOf RootMenus_Click
            ' Next
        End Sub
        Private Sub ClearMenus()
            'For Each Item In Me.RootMenus.DropDownItems
            ' Dim NewMenu As ToolStripMenuItem = Item
            ' RemoveHandler NewMenu.Click, AddressOf RootMenus_Click
            ' Next
            ' Me.RootMenus.DropDownItems.Clear()
        End Sub
        Private Sub RootMenus_Click(sender As Object, e As EventArgs)
            ' If Changes_Locked = True Then Exit Sub

        End Sub

#End Region

#Region "Display - Details"
        Private Sub DisplayInfo_ContentDetails(FileIndex As Integer)
            ListView1.Items.Clear()
            ListView1.BeginUpdate()
            For X = 0 To mBinTool.Content.Files(FileIndex).Details.Count - 1
                Dim Entry = mBinTool.Content.Files(FileIndex).Details(X)
                Dim NewItem As New ListViewItem(X.ToString)
                NewItem.SubItems.Add(Entry.Name)
                NewItem.SubItems.Add(Entry.XML_RelativePath)
                NewItem.SubItems.Add(Entry.Offset)
                NewItem.SubItems.Add(Entry.Size)
                ListView1.Items.Add(NewItem)
            Next
            ListView1.EndUpdate()
            ListView2.Items.Clear()
            ListView2.BeginUpdate()
            For X = 0 To mBinTool.Content.Entries.Count - 1
                Dim Entry = mBinTool.Content.Entries(X)
                Dim NewItem As New ListViewItem(Entry.DefFilePath)
                NewItem.SubItems.Add(Entry.FileDate_ReferenceOnly.ToLongDateString)
                ListView2.Items.Add(NewItem)
            Next
            ListView2.EndUpdate()
        End Sub
        Private Sub DisplayInfo_ContentDetails()
            mCurrentStruct = Nothing
            mBinTool.ExtractFromBin_Item(mFileIndex, mContentIndex, mCurrentStruct, ContentController.TheController_Localize)
            Dim ResultBytes As Byte() = Nothing
            mBinTool.ExtractFromBin_RawBytes(mFileIndex, mContentIndex, ResultBytes, Nothing)
            CoH_BytesViewer1.LoadBuffer(ResultBytes)
            Display_Content()
        End Sub
        Private Sub Display_Content()
            Changes_Locked = True
            Cursor.Current = Cursors.WaitCursor
            AddMenus()
            If mCurrentStruct Is Nothing Then
                XML_View2.ViewText("ERROR")
            Else
                Dim ResultString As String = ""
                mSettings.Option_SelectedFormat = COH_ExportFormat.XML
                mCurrentStruct.Export_To_TextFormat_XML(ResultString, mSettings)
                XML_View2.ViewText(ResultString)

                mSettings.Option_SelectedFormat = COH_ExportFormat.CrypticS_TextFormat
                mCurrentStruct.Export_To_TextFormat_CrypticS(ResultString, mSettings)
                TextBox1.Text = ResultString

                PropertyGrid1.SelectedObject = mCurrentStruct
            End If
            Cursor.Current = Cursors.Default
            Changes_Locked = False
        End Sub
        Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
            Dim FileName As String = e.Node.Name
            If Not FileName.Contains("!") Then Exit Sub
            Dim Parts = Split(FileName, "!")

            Dim FileIndex As Integer = CInt(Replace(Parts(0), "File", ""))
            Dim Index As Integer = CInt(Parts(1))
            mFileIndex = (FileIndex - 1)
            mContentIndex = Index
            DisplayInfo_ContentDetails()
        End Sub
#End Region

#Region "Menus"
        Private Sub ExportDEFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportDEFToolStripMenuItem.Click
            If Changes_Locked = True Then Exit Sub
            Dim ExportFilePath As String = IO.Path.GetFileName(mCurrentStruct.Determine_DefaultRelativeFilePath(COH_ExportFormat.XML, False))
            If HelperFunctions.Toolkit.General.LocateFilePath("Export XML", "XML File|*.XML", ExportFilePath) = False Then Exit Sub
            File.WriteAllText(ExportFilePath, XML_View2.Content)
            ''GameContent.ShowMessage("Export Complete")
        End Sub

        Private Sub ExportCurrentAsDEFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportXMLToolStripMenuItem.Click
            If Changes_Locked = True Then Exit Sub
            Dim ExportFilePath As String = IO.Path.GetFileName(mCurrentStruct.Determine_DefaultRelativeFilePath(COH_ExportFormat.CrypticS_TextFormat, False))
            If HelperFunctions.Toolkit.General.LocateFilePath("Export DEF", "DEF File|*.DEF", ExportFilePath) = False Then Exit Sub
            File.WriteAllText(ExportFilePath, TextBox1.Text)
            '' GameContent.ShowMessage("Export Complete")
        End Sub
        Private Sub ExportCurrentAsRAWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportRAWToolStripMenuItem.Click
            If Changes_Locked = True Then Exit Sub
            Dim ExportFilePath As String = IO.Path.GetFileName(mCurrentStruct.Determine_DefaultRelativeFilePath(COH_ExportFormat.CrypticS_BINFormat, False))
            If HelperFunctions.Toolkit.General.LocateFilePath("Export RAW", "RAW File|*.RAW", ExportFilePath) = False Then Exit Sub
            CoH_BytesViewer1.CoH_VirtualByte_Viewer1.Export_ToFile(ExportFilePath)
            '' GameContent.ShowMessage("Export Complete")
        End Sub

        Private Sub ExportAll_XML_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAll_XML_ToolStripMenuItem.Click
            If Changes_Locked = True Then Exit Sub
            Dim ExportFolder As String = ""
            If HelperFunctions.Toolkit.General.LocateFolder("Select Folder to Export to", ExportFolder) = False Then Exit Sub
            If mBinTool.Content.FilesCount = 1 Then
                mBinTool.ExtractFromBin_WriteXML("Extracting Contents", ExportFolder)
                ' GameContent.ShowMessage("Extraction Complete")
            Else
                ' GameContent.ShowMessage("MultiRoot Bin Files Not Supported Currently")
            End If
        End Sub
        Private Sub ExportAll_DEF_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAll_DEF_ToolStripMenuItem.Click
            If Changes_Locked = True Then Exit Sub
            Dim ExportFolder As String = ""
            If HelperFunctions.Toolkit.General.LocateFolder("Select Folder to Export to", ExportFolder) = False Then Exit Sub
            If mBinTool.Content.FilesCount = 1 Then
                mBinTool.ExtractFromBin_WriteDEF("Extracting Contents", ExportFolder)
                ' GameContent.ShowMessage("Extraction Complete")
            Else
                ' GameContent.ShowMessage("MultiRoot Bin Files Not Supported Currently")
            End If
        End Sub

        Private Sub ExportAll_RAW_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAll_RAW_ToolStripMenuItem.Click

        End Sub
#End Region

#Region "Controls"
        Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
            If mSettings Is Nothing Then Exit Sub
            If Changes_Locked = True Then Exit Sub
            mSettings.Option_Export_DontWriteEmpty = CheckBox1.Checked
            Display_Content()
        End Sub
        Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
            If mSettings Is Nothing Then Exit Sub
            If Changes_Locked = True Then Exit Sub
            mSettings.Option_Export_DontWriteProject = CheckBox2.Checked
            Display_Content()
        End Sub
        Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
            If mSettings Is Nothing Then Exit Sub
            If Changes_Locked = True Then Exit Sub
            mSettings.Option_Export_DontWriteDefaults = CheckBox3.Checked
            Display_Content()
        End Sub
        Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
            If mSettings Is Nothing Then Exit Sub
            If Changes_Locked = True Then Exit Sub
            mSettings.Option_Export_DontWriteDebug = CheckBox4.Checked
            Display_Content()
        End Sub
#End Region

    End Class
End Namespace