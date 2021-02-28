Imports COH.Toolkit.CodeManagement.Interfaces

Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class COH_FormWrapped_Bin_View

#Region "Initialize"
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
        End Sub
#End Region

#Region "Prepare Usage"
        Public Sub Prepare_Editor(FilePath As String)
            Me.CoH_Control_ViewBin1.Prepare_Editor(FilePath)
        End Sub

        Private Sub CoH_Control_ViewBin1_Load(sender As Object, e As EventArgs) Handles CoH_Control_ViewBin1.Load

        End Sub
#End Region
    End Class
End Namespace