Imports COH.GameContent.Structures.Resources.GEO
Imports COH.Toolkit.CodeManagement.Interfaces

Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class COH_3D_View

#Region "Private Properties"
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
            Dim GEO As New COH_Resource_GEO
            GEO.Import_From_File(FilePath, New COH_Serialization_Settings(True) With {.Option_SelectedFormat = COH_ExportFormat.Binary})
            CoH_GeoModelViewer1.LoadModel(GEO)
        End Sub
        Public Sub Prepare_Editor(ByRef GEO As COH_Resource_GEO)
            CoH_GeoModelViewer1.LoadModel(GEO)
        End Sub
#End Region
    End Class
End Namespace