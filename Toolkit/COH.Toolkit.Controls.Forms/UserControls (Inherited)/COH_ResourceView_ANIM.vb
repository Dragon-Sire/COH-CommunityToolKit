Imports COH.GameContent.Structures.Resources.Anim

Namespace Toolkit.Controls.WinForms.UserControls
    Public Class COH_ResourceView_ANIM

#Region "Private Properties"
        Private mFileSource As String
        Private mAnimation As COH_Resource_Anim
#End Region

#Region "Prepare Usage"
        Public Sub Prepare_Editor(FilePath As String)
        End Sub
        Public Sub Prepare_Editor(Name As String, Animation As COH_Resource_Anim)
            mAnimation = Animation
            DisplayInfo()
        End Sub
        Private Sub DisplayInfo()
            Cursor.Current = Cursors.WaitCursor
            Dim TheXML As String = Nothing
            If mAnimation.Export_to_TextFormat(TheXML, New COH_Serialization_Settings(True) With {.Option_SelectedFormat = COH_ExportFormat.XML}) = False Then
                XML_View.ViewText("ERROR")
            Else
                XML_View.ViewText(TheXML)
                PropertyGrid1.SelectedObject = mAnimation
            End If
            Dim Skeleton = mAnimation.Extract_Skeleton
            If Skeleton Is Nothing Then
                CoH_XML_Viewer1.ViewText("NOT A BASE SKELETON")
            Else
                If Skeleton.Export_to_TextFormat(TheXML, New COH_Serialization_Settings(True) With {.Option_SelectedFormat = COH_ExportFormat.XML}) = False Then
                    CoH_XML_Viewer1.ViewText("ERROR")
                Else
                    CoH_XML_Viewer1.ViewText(TheXML)
                End If
            End If
            Cursor.Current = Cursors.Default
        End Sub
#End Region
    End Class
End Namespace