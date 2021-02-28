Imports COH.GameContent.Structures
Imports COH.GameContent.Structures.Resources.Textures
Imports COH.Toolkit.CodeManagement.Interfaces

Namespace Toolkit.Controls.WinForms.UserControls
    Public Class COH_ResourceView_Texture

#Region "Private"
        Private mName As String
        Private mResource As COH_FileStructure
        Private mImage As Bitmap
#End Region

#Region "Initialize / Create New Instance"
        Public Sub New(ByRef ContentController As ISupport_MasterController)
            MyBase.New(ContentController)
            Changes_Locked = True
            InitializeComponent()
            ResetDefault_Interface()
            Changes_Locked = False
        End Sub
        Protected Overrides Sub DisposeAdditional()
            If Not (mImage Is Nothing) Then mImage.Dispose()
        End Sub
#End Region

#Region "Reset Defaults"
        Private Sub ResetDefault_Interface()
        End Sub
#End Region

#Region "Load Model"
        Public Sub Loadtexture(FileName As String)
            If FileName.ToLower.Contains(".texture") Then
                Dim Result As New COH_Resource_Texture
                Result.Import_From_File(IO.Path.GetFileName(FileName), IO.Path.GetDirectoryName(FileName), COH_ExportFormat.Binary)
                Loadtexture(FileName, Result)
            ElseIf FileName.ToLower.Contains(".tga") Then
                Dim Result As New COH_Resource_TGA
                Result.Import_From_File(IO.Path.GetFileName(FileName), IO.Path.GetDirectoryName(FileName), COH_ExportFormat.Binary)
                Loadtexture(FileName, Result)
            End If
        End Sub
        Public Sub Loadtexture(Name As String, ByRef TheResource As COH_FileStructure)
            mResource = TheResource
            mName = Name
            If mResource Is Nothing Then

            Else
                If TypeOf TheResource Is COH_Resource_Texture Then
                    mImage = New Bitmap(TryCast(TheResource, COH_Resource_Texture).Extract_Resource_Texture)
                ElseIf TypeOf TheResource Is COH_Resource_TGA Then
                    mImage = New Bitmap(TryCast(TheResource, COH_Resource_TGA).Extract_Resource_Texture)
                End If
                PreviewBox.BackgroundImage = mImage
                PreviewBox.BackgroundImageLayout = ImageLayout.Stretch
                'Label2.Text = "Location : " & TheResource.FilePathReference_Current
            End If
            Me.PropertyGrid1.SelectedObject = TheResource
        End Sub
#End Region

    End Class
End Namespace