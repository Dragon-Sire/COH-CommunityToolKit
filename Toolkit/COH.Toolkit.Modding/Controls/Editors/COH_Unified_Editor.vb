Imports COH.GameContent.Enums
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums
Imports COH.Tools.Modding.HelperFunctions.Structs

Namespace Toolkit.Modding.Editors
    Public Class COH_EditModdableContent

#Region "Private Properties"
        Private mFileSource As String
        Private mEditingControl As COH_ModdableContent_Editor
        Private mContent As COH_ModableContent
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
            ConfigureUI_ImageList()
            Refresh_Tree()
            Changes_Locked = False
        End Sub
        Public Sub ConfigureUI_ImageList()
            With ImageList1
                .Images.Clear()
                .ImageSize = New Size(16, 16)
                .Images.Add(My.Resources.Unknown)
                .Images.Add(COH_ProjectContent.PowerCategory.ToString, My.Resources.PowerCategory)
                .Images.Add(COH_ProjectContent.Powers.ToString, My.Resources.Powers)
                .Images.Add(COH_ProjectContent.PowerSets.ToString, My.Resources.PowerSets)
                .Images.Add(COH_ProjectContent.CharacterClasses_PlayerClasses.ToString, My.Resources.CharacterClasses_PlayerClasses)
                .Images.Add(COH_ProjectContent.CharacterClasses_EnemyClass.ToString, My.Resources.CharacterClasses_EnemyClass)
            End With
        End Sub
        Public Overrides Sub Finish()
            MyBase.Finish()
        End Sub
        Private Sub Refresh_Tree()
            Changes_Locked = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Helperfunctions.Toolkit.Structs.Display_InTreeView_Unified(TreeView1, ContentController, Edit_ShowAllPowers.Checked)
            Cursor.Current = Cursors.Default
            Changes_Locked = False
        End Sub
#End Region

#Region "Prepare Usage"
        Public Sub Prepare_Editor(FilePath As String)
        End Sub
#End Region

#Region "Control Usage"
        Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
            If Changes_Locked = True Then Exit Sub
            If e.Node.Name.Contains("_Folder_") = True Then Exit Sub
            If e.Node.Name = "CharacterClasses" Then Exit Sub
            Dim FileName() As String = Split(e.Node.Name, "!")
            Dim TreeType As COH_ProjectContent = [Enum].Parse(GetType(COH_ProjectContent), FileName(0))
            Edit_Contents(TreeType, FileName(1))
        End Sub
        Private Sub Edit_Contents(TheType As COH_ProjectContent, FileName As String)
            Select Case TheType
                Case COH_ProjectContent.CharacterClasses, COH_ProjectContent.CharacterClasses_PlayerClasses, COH_ProjectContent.CharacterClasses_EnemyClass
                    CreateEditControl(GetType(COH_CharacterClass_Editor), TheType, FileName)
                Case COH_ProjectContent.PowerSets
                    CreateEditControl(GetType(COH_PowerSet_Editor), TheType, FileName)
                Case COH_ProjectContent.PowerCategory
                    CreateEditControl(GetType(COH_CategoryEditor), TheType, FileName)
                Case COH_ProjectContent.Powers
                    CreateEditControl(GetType(COH_Power_Editor), TheType, FileName)
            End Select
        End Sub
        Private Sub Edit_ShowAllPowers_CheckedChanged(sender As Object, e As EventArgs) Handles Edit_ShowAllPowers.CheckedChanged
            If Changes_Locked = True Then Exit Sub
            Refresh_Tree()
        End Sub
#End Region

#Region "Editing Section"
        Private Sub CreateEditControl(EditorType As Type, TheType As COH_ProjectContent, FileName As String)
            Dim PreviewControl As COH_ModdableContent_Editor = Nothing
            If mEditingControl Is Nothing OrElse Not mEditingControl.GetType = EditorType Then
                DestroyPreviewControl()
                PreviewControl = Activator.CreateInstance(EditorType, Me.ContentController)
                PreviewControl.LinkControllers(Me.ContentController)
                SplitContainer1.Panel2.Controls.Add(PreviewControl)
                PreviewControl.Dock = DockStyle.Fill
                PreviewControl.Visible = True
                mEditingControl = PreviewControl
            Else
                PreviewControl = mEditingControl
            End If
            PreviewControl.LoadContent(TheType, FileName)
        End Sub

        Private Sub DestroyPreviewControl()
            If SplitContainer1.Panel2.Controls.Count = 0 Then Exit Sub
            SplitContainer1.Panel2.Controls.RemoveAt(0)
            mEditingControl.Dispose()
            mEditingControl = Nothing
        End Sub
#End Region
    End Class
End Namespace