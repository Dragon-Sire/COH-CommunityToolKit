Imports COH.GameContent.Structures
Imports COH.GameContent.Structures.Resources.Textures

Namespace Toolkit.Controls.WinForms.UserControls
    Public Class COH_TextureResource_PanelItem


#Region "Properties"
        Property IsChecked As Boolean
            Get
                Return Check_SelectThumbnail.Checked
            End Get
            Set(value As Boolean)
                Check_SelectThumbnail.Checked = value
            End Set
        End Property
        ReadOnly Property Index As Integer
            Get
                Return mIndex
            End Get
        End Property
        ReadOnly Property CurrentImage As Image
            Get
                Return mImage
            End Get
        End Property
#End Region

#Region "Private Usage"
        Private mParent As COH_TextureResource_Panel
        Private mIndex As Integer = 0
        Private mThumbnail_Size As Size = New Size(175, 175)
        Private mName As String
        Private mResource As COH_FileStructure
        Private mImage As Bitmap
#End Region

#Region "Initialize"
        Public Sub New()
            MyBase.New
            InitializeComponent()
        End Sub
        Private Sub DisposeAdditional()
            If Not (mImage Is Nothing) Then mImage.Dispose()
        End Sub
#End Region

#Region "Prepare Usage"
        Public Sub Prepare_Usage(Parent As COH_TextureResource_Panel, ID As Integer, Name As String, NumCoords As Integer, ByRef TheResource As COH_FileStructure)
            mResource = TheResource
            mName = Name
            mParent = Parent
            mIndex = ID
            mThumbnail_Size = mParent.Panels_Size
            BackColor = mParent.Panels_Color_Back
            Check_SelectThumbnail.Checked = True
            Label1.Text = "Texture Name : " & mName
            Label3.Text = "# Coordinates : " & NumCoords
            If mResource Is Nothing Then
                Label2.Text = "Location : N/A"
            Else
                If TypeOf TheResource Is COH_Resource_Texture Then
                    Dim TheStruct = TryCast(TheResource, COH_Resource_Texture)
                    Dim TheBitMap As Bitmap = TheStruct.Extract_Resource_Texture
                    mImage = New Bitmap(TheBitMap)
                    Label2.Text = "Location : " & TheStruct.FileName
                ElseIf TypeOf TheResource Is COH_Resource_TGA Then
                    Dim TheStruct = TryCast(TheResource, COH_Resource_TGA)
                    Dim TheBitMap As Bitmap = TheStruct.Extract_Resource_Texture
                    mImage = New Bitmap(TheBitMap)
                    Label2.Text = "Location : " & TheStruct.FileName
                End If
                Preview.BackgroundImage = mImage
                Preview.BackgroundImageLayout = ImageLayout.Stretch

            End If
            Size = mThumbnail_Size
        End Sub
        Sub Update_ThumbSize(ByVal Size As Size)
            mThumbnail_Size = Size
            Me.Size = mThumbnail_Size
        End Sub
#End Region

#Region "Configure UI"
        Private Sub Configure_UI()

        End Sub
#End Region

#Region "Control Usage"
        Private Sub Check_SelectThumbnail_CheckedChanged(sender As Object, e As EventArgs) Handles Check_SelectThumbnail.CheckedChanged
        End Sub
        Private Sub ThumbImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
            mParent.Thumbnail_Selected(Me)
            BackColor = mParent.Panels_Color_Selected
        End Sub
        Private Sub Preview_Click(sender As Object, e As EventArgs) Handles Preview.Click
            mParent.Thumbnail_Selected(Me)
            BackColor = mParent.Panels_Color_Selected
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
            saveFileDialog1.Title = "Save an Image File"
            saveFileDialog1.ShowDialog()

            If saveFileDialog1.FileName <> "" Then
                Dim fs As System.IO.FileStream = CType(saveFileDialog1.OpenFile(), System.IO.FileStream)

                Dim TempImage As Bitmap = New Bitmap(mImage)
                Select Case saveFileDialog1.FilterIndex
                    Case 1
                        TempImage.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Case 2
                        TempImage.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp)
                    Case 3
                        TempImage.Save(fs, System.Drawing.Imaging.ImageFormat.Gif)
                End Select

                fs.Close()
            End If
        End Sub
#End Region
    End Class
End Namespace