Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Controls.WinForms.Enums
Imports COH.Toolkit.Controls.WinForms.Settings

Public Class COH_UserControl_Template
#Region "Protected Properties"
    Protected CurrentEditMode As COH_Form_EditMode
    Protected FormToolTip As ToolTip
    Protected ContentController As ISupport_MasterController
    Protected IsLoaded As Boolean = False
    Protected IsModified As Boolean = False
    Protected Property Changes_Locked As Boolean
#End Region

#Region "Initialize"
    Public Sub New()
        Me.New(Nothing)
    End Sub
    Protected Overridable Sub DisposeAdditional()
    End Sub
    Public Sub New(ByRef TheContentController As ISupport_MasterController)
        ContentController = TheContentController
        Changes_Locked = True
        InitializeComponent()
        Initialize_Tooltip()
        SetDefaults()
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
#End Region

#Region "Modified"
    Public Overridable Sub WasModified()
        If IsLoaded = False Then Exit Sub
        IsModified = True
    End Sub
    Private Sub COH_UserControl_Template_Load(sender As Object, e As EventArgs) Handles Me.Load
        IsLoaded = True
    End Sub
#End Region


#Region "Overridable Functions"
    Public Overridable Sub ConfigureUI()
        Changes_Locked = True
    End Sub
    Public Overridable Sub Finish()
        Changes_Locked = False
    End Sub
#End Region

#Region "Set Appearance - Controls"
    Public Sub ApplyColorScheme(ByRef Settings As COH_ColorScheme)
        Settings.ApplyColorScheme(Me)
    End Sub
#End Region

#Region "Display Form"
    Public Sub LinkControllers(ByRef TheContentController As ISupport_MasterController)
        ContentController = TheContentController
    End Sub
#End Region
End Class
