Imports COH.GameContent.Structures.Resources.GEO

Namespace Toolkit.Controls.WinForms.UserControls
    Public Class COH_TextureResource_Panel

#Region "Properties"
        Public Property Panels_Color_Selected() As Color
            Get
                Return mPanels_Color_Selected
            End Get
            Set(ByVal value As Color)
                mPanels_Color_Selected = value
            End Set
        End Property
        Public Property Panels_Color_Back() As Color
            Get
                Return mPanels_Color_Back
            End Get
            Set(ByVal value As Color)
                mPanels_Color_Back = value
            End Set
        End Property
        Public Property Panels_Size() As Size
            Get
                Return mPanels_Size
            End Get
            Set(ByVal value As Size)
                mPanels_Size = value
            End Set
        End Property
        Public ReadOnly Property Panels_Count As UInt16
            Get
                Dim Result As UInt16 = 0
                Dim TheControls As COH_TextureResource_PanelItem
                For Each cControl In MaterialList.Controls
                    If (TypeOf cControl Is COH_TextureResource_PanelItem) Then
                        TheControls = cControl
                        Result += 1
                    End If
                Next cControl
                Return Result
            End Get
        End Property
#End Region


#Region "Private Usage"
        Private Const SupportedImageExtentions As String = ".jpg|.bmp|.png|.gif|.jpeg|.tiff"
        Private mPanels_Color_Selected As Color = Color.Blue
        Private mPanels_Color_Back As Color = Color.Gray
        Private mPanels_Size As Size = New Size(75, 100)
        Private mThumbnail_Selected As Integer = -1
        Private mThumbnail_CheckOnAdd As Boolean = True
#End Region

#Region "Usage"
        Public Sub Populate_List(ByRef GEO As COH_Resource_GEO, Index As Integer, ByRef Linked_Textures As Dictionary(Of String, COH_FileStructure)) ',ByRef Assets As COH_ResourceAssets_Controller,)
            For x = MaterialList.Controls.Count - 1 To 0 Step -1
                MaterialList.Controls(x).Dispose()
            Next
            If GEO.Models(Index).Mesh.TextureNames Is Nothing Then Exit Sub
            For X As UInteger = 0 To GEO.Models(Index).Mesh.TextureNames.Count - 1
                Dim MyThumb As New COH_TextureResource_PanelItem
                Dim TheName As String = IO.Path.GetFileNameWithoutExtension(GEO.Models(Index).Mesh.TextureNames(X))
                Dim NumCoords As Integer = GEO.Models(Index).Mesh.TextureSTSCounts(X)

                Dim Found As COH_FileStructure = Nothing
                If Linked_Textures.TryGetValue(TheName, Found) Then
                    MyThumb.Prepare_Usage(Me, X, TheName, NumCoords, Found)
                    MaterialList.Controls.Add(MyThumb)
                Else
                    MyThumb.Prepare_Usage(Me, X, TheName, NumCoords, Nothing)
                    MaterialList.Controls.Add(MyThumb)
                End If
            Next
        End Sub

#End Region


#Region "Events"
        Event MaterialSelected(ByVal Sender As COH_TextureResource_PanelItem, ByVal ID As Integer)
        Public Sub Thumbnail_Selected(ByVal Sender As COH_TextureResource_PanelItem)
            mThumbnail_Selected = Sender.Index
            Update_Thumbnail_BackgroundColors()
            RaiseEvent MaterialSelected(Sender, Sender.Index)
        End Sub
        Private Sub Update_Thumbnail_BackgroundColors()
            Dim ThePanel As COH_TextureResource_PanelItem
            For Each SelectedPanel In MaterialList.Controls
                If (TypeOf SelectedPanel Is COH_TextureResource_PanelItem) Then
                    ThePanel = SelectedPanel
                    If Not ThePanel.Index = mThumbnail_Selected Then
                        ThePanel.BackColor = mPanels_Color_Back
                    Else
                        ThePanel.BackColor = mPanels_Color_Selected
                    End If
                End If
            Next SelectedPanel
        End Sub
        Private Sub Update_ThumbNail_Sizes()
            Dim SelectedPanel As COH_TextureResource_PanelItem
            For Each Thumb In MaterialList.Controls
                If (TypeOf Thumb Is COH_TextureResource_PanelItem) Then
                    SelectedPanel = Thumb
                    SelectedPanel.Update_ThumbSize(mPanels_Size)
                End If
            Next Thumb
        End Sub
        Private Sub COH_TextureResource_Panel_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            mPanels_Size = New Size(Me.ClientRectangle.Width - 20, 125)
            Update_ThumbNail_Sizes()
        End Sub
#End Region



    End Class
End Namespace