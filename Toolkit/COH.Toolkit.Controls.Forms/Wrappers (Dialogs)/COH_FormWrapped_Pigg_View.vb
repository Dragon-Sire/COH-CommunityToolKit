Imports System.ComponentModel
Imports COH.GameContent.Structures.Resources.Anim
Imports COH.GameContent.Structures.Resources.BIN
Imports COH.GameContent.Structures.Resources.GEO
Imports COH.GameContent.Structures.Resources.Textures
Imports COH.Storage.Containers.PIGG.Utilities
Imports COH.Storage.Controllers
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Controls.WinForms.UserControls

Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class COH_FormWrapped_Pigg_View


        Const COH_DeveloperMode_AllowEdit = False '//TEMP

#Region "Private Properties"
        Private mFileSource As String
        Private mTool As COH_PiggTool
        Private mPreviewControl As Control
        Private mCurrentResource As COH_FileStructure
        Private CurrentlyPreviewing As COH_Supported_ContentType = COH_Supported_ContentType.Unknown
#End Region

#Region "Initialize"
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
        End Sub
#End Region

#Region "Configure UI"
        Public Overrides Sub ConfigureUI()
            MyBase.ConfigureUI()
            Changes_Locked = True
            Changes_Locked = False
        End Sub
        Public Overrides Sub Finish()
            MyBase.Finish()
        End Sub
#End Region

#Region "Prepare Usage"
        Public Sub Prepare_Editor(FilePath As String)
            mTool = New COH_PiggTool()
            mTool.OpenExisting_PiggFile(FilePath, False)
            DisplayInfo()
        End Sub
        Private Sub DisplayInfo()
            Changes_Locked = True
            HelperFunctions.Toolkit.Controls.TreeViews.Fill_TreeView(Me.TreeView1, mTool.Content.StringTable.Items, "/", "Root", ".")
            For Each node As TreeNode In Me.TreeView1.Nodes(0).Nodes(0).Nodes
                Dim TheType As COH_FSI_Entry = Nothing
                If ContentController.TheController_SupportedStructures.Retrieve_SupportedType(node.Text, TheType) = False Then
                    If node.Text.ToUpper.Contains(".GEO") Then
                        node.ForeColor = Color.Green
                    Else
                        node.ForeColor = Color.Red
                    End If
                Else
                    Select Case TheType.ContentType
                        Case COH_Supported_ContentType.Resource_BIN_CrypticS
                            node.ForeColor = Color.Black
                        Case COH_Supported_ContentType.Resource_BIN_MessageStore
                            node.ForeColor = Color.DarkOrange
                        Case COH_Supported_ContentType.Resource_GEO
                            node.ForeColor = Color.Green
                        Case COH_Supported_ContentType.Resource_Texture
                            node.ForeColor = Color.Blue
                        Case COH_Supported_ContentType.Resource_TGA
                            node.ForeColor = Color.BlueViolet
                        Case COH_Supported_ContentType.Unknown
                            node.ForeColor = Color.Gray
                    End Select
                End If
            Next
            DisplayInfo_ContentDetails()
            DisplayInfo_SlotDetails()
            Dim CurrentNode As TreeNode = TreeView1.Nodes(0)
            Do
                CurrentNode.Expand()
                If CurrentNode.Nodes.Count = 1 Then
                    CurrentNode = CurrentNode.Nodes(0)
                Else
                    Exit Do
                End If
            Loop
            Changes_Locked = False
        End Sub
        Private Sub DisplayInfo_ContentDetails()
            ListView1.Items.Clear()
            ListView1.BeginUpdate()
            For X = 0 To mTool.Content.Directories.Count - 1
                Dim Newitem As New ListViewItem(mTool.Content.Directories(X).Index)
                Newitem.Name = X
                Newitem.SubItems.Add(mTool.Content.StringTable.Items(X))
                Newitem.SubItems.Add(mTool.Content.Directories(X).EntryType.ToString)
                Newitem.SubItems.Add(mTool.Content.Directories(X).File_Offset)
                Newitem.SubItems.Add(mTool.Content.Directories(X).File_Size_Stored)
                'Newitem.SubItems.Add(mTool.Content.Directories(X).File_Size)
                Newitem.SubItems.Add(mTool.Content.Directories(X).IsCompressed)
                'Newitem.SubItems.Add(mTool.Content.Directories(X).File_Size_Compressed)
                Newitem.SubItems.Add(mTool.Content.Directories(X).TimeStamp)
                Newitem.SubItems.Add(mTool.Content.Directories(X).SecondarySlotIndex)
                ListView1.Items.Add(Newitem)
            Next
            ListView1.EndUpdate()
        End Sub
        Private Sub DisplayInfo_SlotDetails()
            ListView2.Items.Clear()
            ListView2.BeginUpdate()
            If mTool.Content.SlotTable.Items Is Nothing Then Exit Sub
            For X = 0 To mTool.Content.SlotTable.Items.Count - 1
                Dim Newitem As New ListViewItem(X)
                Newitem.Name = X
                Newitem.SubItems.Add(mTool.Content.SlotTable.Items(X).SlotType.ToString)
                Newitem.SubItems.Add(mTool.Content.SlotTable.Items(X).Offset)
                Newitem.SubItems.Add(mTool.Content.SlotTable.Items(X).Size_Stored)
                Newitem.SubItems.Add(mTool.Content.SlotTable.Items(X).IsCompressed)
                ListView2.Items.Add(Newitem)
            Next
            ListView2.EndUpdate()
        End Sub
#End Region

#Region "Control Usage"
        Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
            If Changes_Locked = True Then Exit Sub
            If e.Node.Name.Contains("_Folder_") = True Then Exit Sub
            If e.Node.Name = "" Then Exit Sub
            Dim Index As String = e.Node.Name
            Preview_Contents(Index, e.Node.Text)
        End Sub
        Private Sub Preview_Contents(Index As Integer, Name As String)
            mTool.ExtractEntry(Index, mCurrentResource)
            Select Case mCurrentResource.EntryType
                Case COH_Supported_ContentType.Resource_Texture
                    CreatePreviewControl_DDS()
                Case COH_Supported_ContentType.Resource_TGA
                    CreatePreviewControl_TGA()
                Case COH_Supported_ContentType.Resource_BIN_CrypticS
                    CreatePreviewControl_BinTool(Name)
                Case COH_Supported_ContentType.Resource_BIN_MessageStore
                    CreatePreviewControl_MessageStore(Name)
                Case COH_Supported_ContentType.Resource_GEO
                    CreatePreviewControl_3DView()
                Case COH_Supported_ContentType.Resource_ANIMATION
                    CreatePreviewControl_Animation(Name)
            End Select
        End Sub
#End Region

#Region "Preview Section"
        Private Sub CreatePreviewControl_DDS()
            Dim PreviewControl As PictureBox = Nothing
            If Not CurrentlyPreviewing = COH_Supported_ContentType.Resource_Texture And Not CurrentlyPreviewing = COH_Supported_ContentType.Resource_TGA Then
                DestroyPreviewControl()
                PreviewControl = New PictureBox
                Tab_Preview.Controls.Add(PreviewControl)
                PreviewControl.Dock = DockStyle.Fill
                PreviewControl.Visible = True
                mPreviewControl = PreviewControl
            Else
                PreviewControl = mPreviewControl
            End If
            PreviewControl.BackgroundImage = DirectCast(mCurrentResource, COH_Resource_Texture).Extract_Resource_Texture()
            PreviewControl.BackgroundImageLayout = ImageLayout.Zoom
            CurrentlyPreviewing = COH_Supported_ContentType.Resource_Texture
            Dim Temp = DirectCast(mCurrentResource, COH_Resource_Texture)
            If COH_DeveloperMode_AllowEdit = False Then TypeDescriptor.AddAttributes(Temp, New Attribute() {New ReadOnlyAttribute(True)})
            PropertyGrid1.SelectedObject = Temp
        End Sub
        Private Sub CreatePreviewControl_TGA()
            Dim PreviewControl As PictureBox = Nothing
            If Not CurrentlyPreviewing = COH_Supported_ContentType.Resource_Texture And Not CurrentlyPreviewing = COH_Supported_ContentType.Resource_TGA Then
                DestroyPreviewControl()
                PreviewControl = New PictureBox
                Tab_Preview.Controls.Add(PreviewControl)
                PreviewControl.Dock = DockStyle.Fill
                PreviewControl.Visible = True
                mPreviewControl = PreviewControl
            Else
                PreviewControl = mPreviewControl
            End If
            PreviewControl.BackgroundImage = DirectCast(mCurrentResource, COH_Resource_TGA).Extract_Resource_Texture()
            PreviewControl.BackgroundImageLayout = ImageLayout.Zoom
            CurrentlyPreviewing = COH_Supported_ContentType.Resource_TGA
            Dim Temp = DirectCast(mCurrentResource, COH_Resource_TGA)
            If COH_DeveloperMode_AllowEdit = False Then TypeDescriptor.AddAttributes(Temp, New Attribute() {New ReadOnlyAttribute(True)})
            PropertyGrid1.SelectedObject = Temp
        End Sub
        Private Sub CreatePreviewControl_BinTool(Name As String)
            Dim PreviewControl As COH_Control_ViewBin = Nothing
            If Not CurrentlyPreviewing = COH_Supported_ContentType.Resource_BIN_CrypticS Then
                DestroyPreviewControl()
                PreviewControl = New COH_Control_ViewBin(Me.ContentController)
                Tab_Preview.Controls.Add(PreviewControl)
                PreviewControl.Dock = DockStyle.Fill
                PreviewControl.Visible = True
                mPreviewControl = PreviewControl
            Else
                PreviewControl = mPreviewControl
            End If
            Dim Temp = DirectCast(mCurrentResource, COH_Resource_BIN)
            PreviewControl.LinkControllers(ContentController)
            PreviewControl.Prepare_Editor(Name, Temp.EntryType, Temp.RawBytes)
            CurrentlyPreviewing = COH_Supported_ContentType.Resource_BIN_CrypticS

            If COH_DeveloperMode_AllowEdit = False Then TypeDescriptor.AddAttributes(Temp, New Attribute() {New ReadOnlyAttribute(True)})
            PropertyGrid1.SelectedObject = Temp
        End Sub
        Private Sub CreatePreviewControl_MessageStore(Name As String)
            Dim PreviewControl As COH_Control_MessageStore = Nothing
            If Not CurrentlyPreviewing = COH_Supported_ContentType.Resource_BIN_MessageStore Then
                DestroyPreviewControl()
                PreviewControl = New COH_Control_MessageStore
                Tab_Preview.Controls.Add(PreviewControl)
                PreviewControl.Dock = DockStyle.Fill
                PreviewControl.Visible = True
                mPreviewControl = PreviewControl
            Else
                PreviewControl = mPreviewControl
            End If
            Dim Temp = DirectCast(mCurrentResource, COH_Resource_BIN)
            PreviewControl.Prepare_Editor(Name, Temp.EntryType, Temp.RawBytes)
            CurrentlyPreviewing = COH_Supported_ContentType.Resource_BIN_MessageStore

            If COH_DeveloperMode_AllowEdit = False Then TypeDescriptor.AddAttributes(Temp, New Attribute() {New ReadOnlyAttribute(True)})
            PropertyGrid1.SelectedObject = Temp
        End Sub
        Private Sub CreatePreviewControl_3DView()
            Dim PreviewControl As COH_GeoModelViewer = Nothing
            If Not CurrentlyPreviewing = COH_Supported_ContentType.Resource_GEO Then
                DestroyPreviewControl()
                PreviewControl = New COH_GeoModelViewer(Me.ContentController)
                PreviewControl.LinkControllers(Me.ContentController)
                Tab_Preview.Controls.Add(PreviewControl)
                PreviewControl.Dock = DockStyle.Fill
                PreviewControl.Visible = True
                mPreviewControl = PreviewControl
            Else
                PreviewControl = mPreviewControl
            End If

            Dim Temp = DirectCast(mCurrentResource, COH_Resource_GEO)
            If COH_DeveloperMode_AllowEdit = False Then TypeDescriptor.AddAttributes(Temp, New Attribute() {New ReadOnlyAttribute(True)})
            PropertyGrid1.SelectedObject = Temp
            PreviewControl.LoadModel(Temp)
            CurrentlyPreviewing = COH_Supported_ContentType.Resource_GEO
        End Sub
        Private Sub CreatePreviewControl_Animation(Name As String)
            Dim PreviewControl As COH_ResourceView_ANIM = Nothing
            If Not CurrentlyPreviewing = COH_Supported_ContentType.Resource_ANIMATION Then
                DestroyPreviewControl()
                PreviewControl = New COH_ResourceView_ANIM
                Tab_Preview.Controls.Add(PreviewControl)
                PreviewControl.Dock = DockStyle.Fill
                PreviewControl.Visible = True
                mPreviewControl = PreviewControl
            Else
                PreviewControl = mPreviewControl
            End If
            Dim Temp = DirectCast(mCurrentResource, COH_Resource_Anim)
            PreviewControl.Prepare_Editor(Name, Temp)
            CurrentlyPreviewing = COH_Supported_ContentType.Resource_ANIMATION
            If COH_DeveloperMode_AllowEdit = False Then TypeDescriptor.AddAttributes(Temp, New Attribute() {New ReadOnlyAttribute(True)})
            PropertyGrid1.SelectedObject = Temp
        End Sub
        Private Sub DestroyPreviewControl()
            If Tab_Preview.Controls.Count = 0 Then Exit Sub
            Tab_Preview.Controls.RemoveAt(0)
            mPreviewControl.Dispose()
            mPreviewControl = Nothing
        End Sub
#End Region
    End Class
End Namespace