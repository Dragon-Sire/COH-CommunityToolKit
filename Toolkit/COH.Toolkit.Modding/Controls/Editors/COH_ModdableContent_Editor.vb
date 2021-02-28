Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization.Configuration
Imports COH.Storage.Structures
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums

Namespace Toolkit.Modding.Editors
    Public Class COH_ModdableContent_Editor

#Region "Properties"
        Protected Property Current_Content As COH_ModableContent
            Get
                Return mModDetails
            End Get
            Set(value As COH_ModableContent)
                mModDetails = value
            End Set
        End Property
        Protected Overridable ReadOnly Property Current_Struct As COH_FileStructure
            Get
                Return Nothing
            End Get
        End Property
        Protected Overridable ReadOnly Property Export_FileName_DEF As String
            Get
                Return ""
            End Get
        End Property
        Protected Overridable ReadOnly Property Export_FileName_XML As String
            Get
                Return ""
            End Get
        End Property
        Protected ReadOnly Property AdvancedEditLocked As Boolean
            Get
                Return mAdvancedEditLocked
            End Get
        End Property
        Private mAdvancedEditLocked As Boolean
        Private mSettings_DEF As COH_Serialization_Settings
        Private mSettings_XML As COH_Serialization_Settings
        Private mModDetails As COH_ModableContent
#End Region

#Region "Create New Instance"
        Public Sub New()
            Me.New(Nothing)
        End Sub
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
            mSettings_DEF = New COH_Serialization_Settings(True, COH_ExportFormat.CrypticS_TextFormat)
            mSettings_DEF.Option_Export_DontWriteDebug = True
            mSettings_DEF.Option_Export_DontWriteDefaults = True
            mSettings_DEF.Option_Export_DontWriteEmpty = True
            mSettings_DEF.Option_Export_DontWriteProject = True
            mSettings_XML = New COH_Serialization_Settings(True, COH_ExportFormat.XML)
            mSettings_XML.Option_Export_DontWriteDebug = True
            mSettings_XML.Option_Export_DontWriteDefaults = False
            mSettings_XML.Option_Export_DontWriteEmpty = False
            mSettings_XML.Option_Export_DontWriteProject = False
            mAdvancedEditLocked = True
        End Sub
#End Region

#Region "Load Content"
        Overridable Function LoadContent(TheType As COH_ProjectContent, FileName As String) As Boolean
            Return False
        End Function
        Protected Overridable Sub ButtonPressed_Preview()
            Cursor.Current = Cursors.WaitCursor
            Changes_Locked = True
            Dim Preview As String = ""
            Current_Struct.Export_to_TextFormat(Preview, mSettings_XML)
            XML_View2.ViewText(Preview)
            Current_Struct.Export_to_TextFormat(Preview, mSettings_DEF)
            TextBox1.Text = Preview
            PropertyGrid1.SelectedObject = Current_Struct
            Changes_Locked = False
            Cursor.Current = Cursors.Default
        End Sub
        Protected Overridable Sub ButtonPressed_Undo()
        End Sub
        Protected Overridable Sub ButtonPressed_Save()
        End Sub
        Protected Overridable Sub UpdateUI_Unlocked()
            ConfigureUI_EnabledDisabled()
        End Sub
#End Region

#Region "Configure UI Enabled/Disabled"
        Public Overridable Sub ConfigureUI_EnabledDisabled()
            If (Current_Content Is Nothing) = False Then
                ToolStrip1.Enabled = True
                Button_UpdatePreview.Enabled = True
                Button_Undo.Enabled = CheckModified()
                Button_Save.Enabled = True
            Else
                ToolStrip1.Enabled = False
                Button_UpdatePreview.Enabled = False
                Button_Undo.Enabled = False
                Button_Save.Enabled = False
            End If
            If AdvancedEditLocked = True Then
                Image_Locked.BackgroundImage = My.Resources.Button_Locked
            Else
                Image_Locked.BackgroundImage = My.Resources.Button_Unlocked
            End If
        End Sub
#End Region

#Region "Display"
        Protected Overridable Function Display_CurrentStruct() As Boolean
            Changes_Locked = True
            Edit_IsCustom.Checked = Current_Content.IsCustom
            Edit_WasModified.Checked = Current_Content.WasModified_FromSource
            Edit_Current_Editing.Text = "Currently Editing : " & Current_Content.RelativePath_Current
            Changes_Locked = False
            Return True
        End Function
        Protected Overridable Function Clear_CurrentStruct() As Boolean
            Changes_Locked = True
            Edit_IsCustom.Checked = False
            Edit_WasModified.Checked = False
            Edit_Current_Editing.Text = "Currently Editing : N/A"
            Changes_Locked = False
            Return True
        End Function
#End Region

#Region "Modified"
        Public Overrides Sub WasModified()
            MyBase.WasModified()
            Button_Undo.Enabled = CheckModified()
        End Sub
        Private Function CheckModified() As Boolean
            If Current_Struct Is Nothing Then Return False
            Return IsModified
        End Function
#End Region

#Region "Menu Buttons"
        Private Sub DontWriteDefaultsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DontWriteDefaultsToolStripMenuItem1.Click
            If mSettings_XML Is Nothing Then Exit Sub
            mSettings_XML.Option_Export_DontWriteDefaults = DontWriteDebugToolStripMenuItem1.Checked
            If Current_Struct Is Nothing Then Exit Sub
            ButtonPressed_Preview()
        End Sub
        Private Sub DontWriteEmptyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DontWriteEmptyToolStripMenuItem1.Click
            If mSettings_XML Is Nothing Then Exit Sub
            mSettings_XML.Option_Export_DontWriteEmpty = DontWriteEmptyToolStripMenuItem1.Checked
            If Current_Struct Is Nothing Then Exit Sub
            ButtonPressed_Preview()
        End Sub
        Private Sub DontWriteDebugToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DontWriteDebugToolStripMenuItem1.Click
            If mSettings_XML Is Nothing Then Exit Sub
            mSettings_XML.Option_Export_DontWriteDebug = DontWriteDebugToolStripMenuItem1.Checked
            If Current_Struct Is Nothing Then Exit Sub
            ButtonPressed_Preview()
        End Sub
        Private Sub DontWriteDefaultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DontWriteDefaultsToolStripMenuItem.Click
            If mSettings_DEF Is Nothing Then Exit Sub
            mSettings_DEF.Option_Export_DontWriteDefaults = DontWriteDefaultsToolStripMenuItem.Checked
            If Current_Struct Is Nothing Then Exit Sub
            ButtonPressed_Preview()
        End Sub
        Private Sub DontWriteEmptyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DontWriteEmptyToolStripMenuItem.Click
            If mSettings_DEF Is Nothing Then Exit Sub
            mSettings_DEF.Option_Export_DontWriteEmpty = DontWriteEmptyToolStripMenuItem.Checked
            If Current_Struct Is Nothing Then Exit Sub
            ButtonPressed_Preview()
        End Sub
        Private Sub DontWriteDebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DontWriteDebugToolStripMenuItem.Click
            If mSettings_DEF Is Nothing Then Exit Sub
            mSettings_DEF.Option_Export_DontWriteDebug = DontWriteDebugToolStripMenuItem.Checked
            If Current_Struct Is Nothing Then Exit Sub
            ButtonPressed_Preview()
        End Sub
#End Region

#Region "Buttons"
        Private Sub Button_UpdatePreview_Click(sender As Object, e As EventArgs) Handles Button_UpdatePreview.Click
            ButtonPressed_Preview()
        End Sub
        Private Sub Button_Undo_Click(sender As Object, e As EventArgs) Handles Button_Undo.Click
            ButtonPressed_Undo()
        End Sub
        Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
            ButtonPressed_Save()
        End Sub
        Private Sub ExportCurrentAsXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportCurrentAsXMLToolStripMenuItem.Click
            If Changes_Locked = True Then Exit Sub
            Dim ExportFilePath As String = IO.Path.GetFileName(Current_Struct.Determine_DefaultRelativeFilePath(COH_ExportFormat.XML, False))
            If Helperfunctions.Toolkit.General.LocateFilePath("Export XML", "XML File|*.XML", ExportFilePath) = False Then Exit Sub
            If Current_Content.Content.Export_To_File(IO.Path.GetFileName(ExportFilePath), IO.Path.GetDirectoryName(ExportFilePath), New COH_Serialization_Settings(True, COH_ExportFormat.XML)) = False Then Exit Sub
            GameContent.ShowMessage("Export Complete")
        End Sub
        Private Sub ExportCurrentAsDEFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportCurrentAsDEFToolStripMenuItem.Click
            If Changes_Locked = True Then Exit Sub
            Dim ExportFilePath As String = IO.Path.GetFileName(Current_Struct.Determine_DefaultRelativeFilePath(COH_ExportFormat.CrypticS_TextFormat, False))
            If Helperfunctions.Toolkit.General.LocateFilePath("Export DEF", "DEF File|*.DEF", ExportFilePath) = False Then Exit Sub
            If Current_Content.Content.Export_To_File(IO.Path.GetFileName(ExportFilePath), IO.Path.GetDirectoryName(ExportFilePath), New COH_Serialization_Settings(True, COH_ExportFormat.CrypticS_TextFormat)) = False Then Exit Sub
            GameContent.ShowMessage("Export Complete")
        End Sub
        Private Sub Image_Locked_Click(sender As Object, e As EventArgs) Handles Image_Locked.Click
            If mAdvancedEditLocked = False Then Exit Sub
            If Current_Content Is Nothing Then Exit Sub
            Select Case MsgBox("Do You Wish To Unlock Restricted Editing?", MsgBoxStyle.YesNo, "Character Class Editiing")
                Case MsgBoxResult.No
                    Exit Sub
            End Select
            mAdvancedEditLocked = False
            UpdateUI_Unlocked()
        End Sub



#End Region


    End Class
End Namespace