Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Controls.WinForms.Enums
Imports COH.Toolkit.Controls.WinForms.Interfaces
Imports COH.Toolkit.Controls.WinForms.Settings

Namespace Toolkit.Controls.WinForms.Internal
    Partial Public Class COH_FormTemplate

#Region "Protected Properties"
        Protected CurrentEditMode As COH_Form_EditMode
        Protected Changes_Locked As Boolean = True
        Protected FormToolTip As ToolTip
        Protected ContentController As ISupport_MasterController
        Protected IsLoaded As Boolean = False
        Protected IsModified As Boolean = False
#End Region

#Region "Initialize"
        Public Sub New()
            Me.New(Nothing)
        End Sub
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            ContentController = TheContentController
            InitializeComponent()
            Initialize_Tooltip()
            SetDefaults()
        End Sub
        Protected Overridable Sub DisposeAdditional()
        End Sub
        Private Sub SetDefaults()
            CurrentEditMode = COH_Form_EditMode.ViewOnly
            Changes_Locked = True
        End Sub
        Private Sub Initialize_Tooltip()
            FormToolTip = New ToolTip
            With FormToolTip
                .AutoPopDelay = 5000
                .InitialDelay = 1000
                .ReshowDelay = 200
                .ShowAlways = True
            End With
        End Sub
        Private Sub COH_3D_View_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            IsLoaded = True
        End Sub
#End Region

#Region "Load"
        Private Sub COH_FormTemplate_Load(sender As Object, e As EventArgs) Handles Me.Load
        End Sub
#End Region

#Region "Overridable Functions"
        Public Overridable Sub ConfigureUI()
            Changes_Locked = True
        End Sub
        Public Overridable Sub Finish()
            Changes_Locked = False
        End Sub
        Public Overridable Sub WasModified()
            If IsLoaded = False Then Exit Sub
            IsModified = True
        End Sub
#End Region

#Region "Set Appearance - Controls"
        Public Sub ApplyColorScheme(ByRef Settings As COH_ColorScheme)
            Settings.ApplyColorScheme(Me)
        End Sub
#End Region

#Region "Display Form"
        Public Function ShowMe_AsForm(Optional ByRef ParentForm As COH_ParentFormInterface = Nothing) As Form
            ConfigureAppearance(ParentForm)
            Show()
            ConfigureUI()
            Finish()
            Return Me
        End Function
        Public Function ShowMe_AsDialog(Optional ByRef ParentForm As COH_ParentFormInterface = Nothing) As DialogResult
            ConfigureAppearance(ParentForm)
            ConfigureUI()
            Finish()
            Return ShowDialog()
        End Function
        Public Sub ShowMe_AsControl()
            FormBorderStyle = FormBorderStyle.None
            Dock = DockStyle.Fill
            ConfigureUI()
            Finish()
        End Sub
        Private Sub ConfigureAppearance(Optional ByRef ParentForm As COH_ParentFormInterface = Nothing)
            Dim OriginalSize = Size
            MdiParent = ParentForm
            If ParentForm Is Nothing Then
                StartPosition = FormStartPosition.CenterScreen
            Else
                StartPosition = FormStartPosition.Manual
                Dim AvailableArea = ParentForm.AvailableClientArea
                Dim FormSize = ClientRectangle
                Location = New Point((AvailableArea.Width - Me.Width) / 2, (AvailableArea.Height - Height) / 2)
            End If
        End Sub


#End Region
    End Class
End Namespace