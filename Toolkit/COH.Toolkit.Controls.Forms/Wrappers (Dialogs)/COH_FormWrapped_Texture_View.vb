Imports COH.Toolkit.CodeManagement.Interfaces

Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class COH_FormWrapped_Texture_View

#Region "Initialize"
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
        End Sub
#End Region

#Region "Prepare Usage"
        Public Sub Prepare_Editor(FilePath As String)
            Me.CoH_Control_ViewTexture1.Loadtexture(FilePath)
        End Sub
#End Region

    End Class
End Namespace