Imports COH.GameContent.Structures.MeshRelated
Imports COH.GameContent.Structures.MeshRelated.Textures
Imports COH.GameContent.Structures.Resources.Anim
Imports COH.GameContent.Structures.Resources.GEO
Imports COH.GameContent.Structures.Resources.Textures
Imports COH.GameContent.Structures.Resources_Simplified
Imports COH.HelperClasses
Imports COH.Toolkit.CodeManagement.Interfaces
Imports HelixToolkit
Imports HelixToolkit.Wpf
Imports HelixToolkit.Wpf.SharpDX
Imports SharpDX
Imports System.ComponentModel
Imports System.Windows.Media
Imports System.Windows.Media.Media3D

Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class COH_GeoModelViewer
        Implements INotifyPropertyChanged

#Region "Properties"
        Public ReadOnly Property ModelViewer As Viewport3DX
            Get
                Dim COH As COH.Toolkit.Controls.WPF.COH_ModelViewer = ElementHost2.Child
                Return COH.ModelWindow
            End Get
        End Property
#End Region

#Region "Properties - 3D Rendering"
#Region "Properties - Cameras"
        Public Property AvailableCameras As List(Of KeyValuePair(Of String, HelixToolkit.Wpf.SharpDX.Camera))
        Public Property CurrentCamera As HelixToolkit.Wpf.SharpDX.Camera
        Public Property UpDirection As Vector3D = New Vector3D(0, 1, 0)
        Public Property CameraDefaultPosition As New Point3D(3, 3, 5)
        Public Property CameraDefaultLookDirection As New Point3D(-3, -3, -5)
        Public Property CameraRotation_Mode As HelixToolkit.Wpf.SharpDX.CameraRotationMode
            Get
                Return mCameraRotationMode
            End Get
            Set(value As HelixToolkit.Wpf.SharpDX.CameraRotationMode)
                If SetValue(mCameraRotationMode, value) Then Update_Camera()
            End Set
        End Property
        Public Property CameraRotation_AroundMouse As Boolean
            Get
                Return mRotateAroundMouseDownPoint
            End Get
            Set(value As Boolean)
                If SetValue(mRotateAroundMouseDownPoint, value) Then Update_Camera()
            End Set
        End Property
        Public ReadOnly Property CameraRotation_Modes As HelixToolkit.Wpf.SharpDX.CameraRotationMode()
            Get
                Return mCameraRotationModes
            End Get
        End Property
#End Region
#Region "Properties - Model"
        Public Property Model_Show As Boolean
            Get
                Return mShow_Model
            End Get
            Set(value As Boolean)
                If SetValue(mShow_Model, value) Then Update_Display()
            End Set
        End Property
        Public Property Model_Show_Transparent As Boolean
            Get
                Return mShow_Transparent
            End Get
            Set(value As Boolean)
                If SetValue(mShow_Transparent, value) Then Update_Models_RenderOptions()
            End Set
        End Property
        Public Property Model_Show_Materials As Boolean
            Get
                Return mShow_Materials
            End Get
            Set(value As Boolean)
                If SetValue(mShow_Materials, value) Then Update_Models_MaterialsOptions()
            End Set
        End Property
#End Region
#Region "Properties - Vertex"
        Public Property Vertex_Show As Boolean
            Get
                Return mShow_Vertex
            End Get
            Set(value As Boolean)
                If SetValue(mShow_Vertex, value) Then Update_Display()
            End Set
        End Property
        Public Property Vertex_Color As Windows.Media.Color
            Get
                Return mVertex_Color
            End Get
            Set(value As Windows.Media.Color)
                If SetValue(mVertex_Color, value) Then Update_Models_RenderOptions()
            End Set
        End Property
        Public Property Vertex_Size As Integer
            Get
                Return mVertex_Size
            End Get
            Set(value As Integer)
                If SetValue(mVertex_Size, value) Then Update_Models_RenderOptions()
            End Set
        End Property
#End Region
#Region "Properties - Wireframe"
        Public Property WireFrame_Show As Boolean
            Get
                Return mShow_WireFrame
            End Get
            Set(value As Boolean)
                If SetValue(mShow_WireFrame, value) Then Update_Models_RenderOptions()
            End Set
        End Property
        Public Property WireFrame_Color As Windows.Media.Color
            Get
                Return mWireFrame_Color
            End Get
            Set(value As Windows.Media.Color)
                If SetValue(mWireFrame_Color, value) Then Update_Models_RenderOptions()
            End Set
        End Property
#End Region
#Region "Properties - Grid"
        Public Property Grid_Show As Boolean
            Get
                Return mShow_Grid
            End Get
            Set(value As Boolean)
                If SetValue(mShow_Grid, value) Then Update_Display()
            End Set
        End Property
        Public Property ModelWindow_GridColor As Windows.Media.Color
            Get
                Return mGrid_Color
            End Get
            Set(value As Windows.Media.Color)
                If SetValue(mGrid_Color, value) Then Update_Grid()
            End Set
        End Property
#End Region
#Region "Properties - BoundingBox"
        Public Property BoundingBox_Show As Boolean
            Get
                Return mShow_BoundingBox
            End Get
            Set(value As Boolean)
                If SetValue(mShow_BoundingBox, value) Then Update_Display()
            End Set
        End Property
        Public Property BoundingBox_Color As Windows.Media.Color
            Get
                Return mBoundingBox_Color
            End Get
            Set(value As Windows.Media.Color)
                If SetValue(mBoundingBox_Color, value) Then Update_Models_RenderOptions()
            End Set
        End Property
#End Region
#Region "Properties - Skeleton"
        Public Property Skeleton_Show As Boolean
            Get
                Return mShow_Bones
            End Get
            Set(value As Boolean)
                If SetValue(mShow_Bones, value) Then Update_Display()
            End Set
        End Property
        Public Property Skeleton_Color As Windows.Media.Color
            Get
                Return mBone_Color
            End Get
            Set(value As Windows.Media.Color)
                If SetValue(mBone_Color, value) Then Update_Display()
            End Set
        End Property
        Public Property Skeleton_AdjustPositions As Boolean
            Get
                Return mOption_AdjustModelPositions
            End Get
            Set(value As Boolean)
                If SetValue(mOption_AdjustModelPositions, value) Then ResetModel()
            End Set
        End Property
#End Region
#Region "Properties - Other"
        Public Property Lights_DirectionalLightDirection As Vector3D
        Public Property Lights_DirectionalLightColor As Windows.Media.Color
        Public Property Lights_AmbientLightColor As Windows.Media.Color
        Public Property BackgroundTexture As System.IO.Stream
        Public Property EffectsManager As IEffectsManager
#End Region
#Region "Properties - Models"
        Public ReadOnly Property Models As List(Of HelixToolkit.Wpf.SharpDX.GroupModel3D)
            Get
                Return mModels
            End Get
        End Property
        Public ReadOnly Property VertexModels As List(Of HelixToolkit.Wpf.SharpDX.PointGeometryModel3D)
            Get
                Return mVertexModels
            End Get
        End Property
        Public ReadOnly Property ModelWindow_Grid As HelixToolkit.Wpf.SharpDX.LineGeometryModel3D
            Get
                Return mGrid
            End Get
        End Property

#End Region
#End Region

#Region "Events"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Public Sub RaisePropertyChanged(<Runtime.CompilerServices.CallerMemberName> Optional memberName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))
        End Sub
        Protected Function SetValue(Of T)(ByRef backingField As T, ByVal value As T, <Runtime.CompilerServices.CallerMemberName> ByVal Optional propertyName As String = "") As Boolean
            If Object.Equals(backingField, value) Then
                Return False
            End If
            backingField = value
            RaisePropertyChanged(propertyName)
            Return True
        End Function
#End Region
        ReadOnly Property SelectedBoneIndex As Integer
            Get
                Return mSelectedBoneIndex
            End Get
        End Property

#Region "Private"
        Private mCameraRotationMode As HelixToolkit.Wpf.SharpDX.CameraRotationMode
        Private mCameraRotationModes As HelixToolkit.Wpf.SharpDX.CameraRotationMode()
        Private mRotateAroundMouseDownPoint As Boolean
        Private mShow_Model As Boolean
        Private mShow_Transparent As Boolean
        Private mShow_WireFrame As Boolean
        Private mShow_Vertex As Boolean
        Private mShow_Grid As Boolean
        Private mShow_Bones As Boolean
        Private mShow_BoundingBox As Boolean
        Private mShow_Materials As Boolean
        Private mWireFrame_Color As Windows.Media.Color
        Private mVertex_Color As Windows.Media.Color
        Private mBoundingBox_Color As Windows.Media.Color
        Private mBone_Color As Windows.Media.Color
        Private mBone_ColorUsed As Windows.Media.Color
        Private mVertex_Size As Single
        Private mVertexModels As List(Of HelixToolkit.Wpf.SharpDX.PointGeometryModel3D)
        Private mBoundingBox As List(Of HelixToolkit.Wpf.SharpDX.MeshGeometryModel3D)
        '//GRID
        Private mGrid As HelixToolkit.Wpf.SharpDX.LineGeometryModel3D
        Private mGrid_Axis As HelixToolkit.Wpf.SharpDX.GroupModel3D
        Private mGrid_Color As Windows.Media.Color
        '//LIGHT
        Private mLight As AmbientLight3D
        '//MODELS
        Private mModels As List(Of HelixToolkit.Wpf.SharpDX.GroupModel3D)
        '//BONES
        Private mBones_Joints As HelixToolkit.Wpf.SharpDX.GroupModel3D
        Private mBones_Animate As BoneSkinMeshGeometryModel3D
        Private mBones As HelixToolkit.Wpf.SharpDX.GroupModel3D
        Private mOption_AdjustModelPositions As Boolean = False
        '//ORIGINOL FILES
        Private mCurrentGEO As COH_Resource_GEO
        Private rLinked_Textures As Dictionary(Of String, COH_FileStructure)
        Private rLinked_Tricks_Tex As Dictionary(Of String, COH_TextureOptions)
        Private rLinked_Tricks As Dictionary(Of String, COH_Trick)
        Private rCurrentTextureStreams As List(Of System.IO.MemoryStream)
        '//<EditorBrowsable(COH_DeveloperMode_ShowPrivate)> Private rLinked_SkeletonsH As Dictionary(Of String, COH_Skeleton_Heirarchy)
        Private rLinked_Skeletons As Dictionary(Of String, COH_Resource_GEO_Skeleton)
        Private mModelIndex As Integer = -1
        Private mSelectedBoneIndex As Integer = 0
#End Region

#Region "Initialize / Create New Instance"
        Public Sub New(ByRef ContentController As ISupport_MasterController)
            MyBase.New(ContentController)
            Changes_Locked = True
            InitializeComponent()
            ResetDefault_Rendering()
            ResetDefault_Interface()
            Changes_Locked = False
        End Sub
        Protected Overrides Sub DisposeAdditional()
        End Sub
#End Region

#Region "Reset Defaults"
        Private Sub ResetDefault_Interface()
            With ModelViewer
                .ClipToBounds = False
                .Orthographic = False
                '.ShowCameraInfo = False
                '.ShowCoordinateSystem = True
                '.ShowFrameRate = True
                '.ShowCameraInfo = True
                '.ShowTriangleCountInfo = True
                '.ShowViewCube = True
                .CameraRotationMode = HelixToolkit.Wpf.SharpDX.CameraRotationMode.Turntable
                .RotateAroundMouseDownPoint = True
                .Background = New SolidColorBrush(Colors.Yellow)
                .BackgroundColor = Colors.YellowGreen
                .Camera = CurrentCamera
                .EffectsManager = EffectsManager
                .ModelUpDirection = UpDirection
            End With
        End Sub
        Private Sub ResetDefault_Rendering()
            mShow_Model = True
            mShow_Materials = False
            mShow_Transparent = False
            mShow_WireFrame = False
            mShow_Vertex = False
            mShow_Bones = False
            mShow_BoundingBox = False
            mShow_Grid = True
            mCameraRotationModes = New HelixToolkit.Wpf.CameraRotationMode(2) {HelixToolkit.Wpf.CameraRotationMode.Turntable, HelixToolkit.Wpf.CameraRotationMode.Trackball, HelixToolkit.Wpf.CameraRotationMode.Turnball}
            mRotateAroundMouseDownPoint = True
            mGrid_Color = Colors.Black
            mWireFrame_Color = Colors.Black
            mVertex_Color = Colors.Red
            mBone_Color = Colors.Orange
            mBone_ColorUsed = Colors.Black
            mVertex_Size = 4
            mBoundingBox_Color = Colors.LightBlue
            mCameraRotationMode = HelixToolkit.Wpf.CameraRotationMode.Turntable
            Grid_Show = True
            ResetDefault_Cameras()
            ResetDefault_Lights()
            ResetDefault_Grid()
            ResetDefault_Background()
        End Sub
        Private Sub ResetDefault_Cameras()
            CameraDefaultPosition = New Point3D(3, 3, 5)
            CameraDefaultLookDirection = New Point3D(-3, -3, -5)
            AvailableCameras = New List(Of KeyValuePair(Of String, HelixToolkit.Wpf.SharpDX.Camera))
            Dim PerspectiveCamera As New HelixToolkit.Wpf.SharpDX.PerspectiveCamera
            With PerspectiveCamera
                .Position = CameraDefaultPosition
                .LookDirection = CameraDefaultLookDirection
                .UpDirection = New Vector3D(0, 1, 0)
                .NearPlaneDistance = 0.1
                .FarPlaneDistance = 50000
                .FieldOfView = "60"
            End With
            AvailableCameras.Add(New KeyValuePair(Of String, HelixToolkit.Wpf.SharpDX.Camera)("Perspective Camera", PerspectiveCamera))
            AvailableCameras.Add(New KeyValuePair(Of String, HelixToolkit.Wpf.SharpDX.Camera)("Orthographic Camera", New HelixToolkit.Wpf.SharpDX.OrthographicCamera With {.Position = CameraDefaultPosition, .LookDirection = CameraDefaultLookDirection, .UpDirection = New Vector3D(0, 1, 0), .NearPlaneDistance = 1, .FarPlaneDistance = 50000}))
            CurrentCamera = AvailableCameras(0).Value
            UpDirection = New Vector3D(0, 1, 0)
        End Sub
        Private Sub ResetDefault_Lights()
            Lights_AmbientLightColor = Colors.DimGray
            Lights_DirectionalLightColor = Colors.White
            Lights_DirectionalLightDirection = New Vector3D(-2, -5, -2)
            mLight = New AmbientLight3D() With {.Color = Lights_AmbientLightColor}
        End Sub
        Private Sub ResetDefault_Grid()
            mGrid = HelperFunctions.Toolkit.GEO.Create_RetrieveGrid_Lines("Grid", New SharpDX.Vector2(-10, -10), 10, 5, mGrid_Color)
            mGrid_Axis = HelperFunctions.Toolkit.GEO.BuildModel_VectorArrows()
        End Sub
        Private Sub ResetDefault_Background()
            EffectsManager = New DefaultEffectsManager()
            BackgroundTexture = BitmapExtensions.CreateLinearGradientBitmapStream(EffectsManager, 128, 128, Direct2DImageFormat.Bmp, New SharpDX.Vector2(0, 0), New SharpDX.Vector2(0, 128), New SharpDX.Direct2D1.GradientStop() {New SharpDX.Direct2D1.GradientStop() With {.Color = Colors.White.ToColor4(), .Position = 0F}, New SharpDX.Direct2D1.GradientStop() With {.Color = Colors.DarkGray.ToColor4(), .Position = 1.0F}})
        End Sub
        Public Sub ResetPosition()
            CurrentCamera.Position = CameraDefaultPosition
            CurrentCamera.LookDirection = CameraDefaultLookDirection
        End Sub
        Public Sub CenterPosition()
            HelixToolkit.Wpf.SharpDX.ViewportExtensions.ZoomExtents(ModelViewer, Calculate_BoundingBox_Visible, 200)
        End Sub
#End Region

#Region "Load Model"
        Public Sub LoadModel(ByRef GEO As COH_Resource_GEO)
            If GEO Is Nothing Then Exit Sub ' ///SETUP CLEAR LATER
            mModelIndex = -1
            mOption_AdjustModelPositions = False
            rLinked_Skeletons = New Dictionary(Of String, COH_Resource_GEO_Skeleton)
            rLinked_Tricks = New Dictionary(Of String, COH_Trick)
            rLinked_Tricks_Tex = New Dictionary(Of String, COH_TextureOptions)
            mCurrentGEO = GEO
            ResetModel()
        End Sub
        Private Sub ResetModel()
            Changes_Locked = True
            mModelIndex = 0
            ClearModels()
            ConfiguireUI()
            Changes_Locked = False
            Update_Display()
        End Sub
#End Region

#Region "Configure UI"
        Private Sub ConfiguireUI()
            DisplayModelDetails()
            Update_Details()
            CoH_TextureResource_Panel1.Populate_List(mCurrentGEO, 0, rLinked_Textures)
            TextBox1.Text = mCurrentGEO.Convert_To_Model_OBJ()
        End Sub
        Private Sub DisplayModelDetails()
            Label_ModelName.Text = mCurrentGEO.ModelName
            LabelVersion.Text = "Version : " & mCurrentGEO.Header.HeaderVersion
            If mCurrentGEO.CurrentInstance_Valid = False Then
                LabelVersion.ForeColor = System.Drawing.Color.Red
            Else
                LabelVersion.ForeColor = System.Drawing.Color.Black
            End If
            Retrieve_LinkedAssets_Skeletons()
            Retrieve_LinkedAssets_Textures()
            Retrieve_LinkedAssets_Tricks()
            Retrieve_LinkedAssets_TricksTextures()
            Update_ModelSelection()
            UpdateDetails_BoneHeirarchy()
            'Update_TextureSelection(CurrentModel_Textures, 0)
        End Sub
        Private Sub Retrieve_LinkedAssets_Skeletons()
            If Not (rLinked_Skeletons Is Nothing) AndAlso rLinked_Skeletons.Count >= 1 Then Exit Sub
            ComboBox1.Items.Clear()
            ImportSkeleton("male_skel_ready")
            ImportSkeleton("female_skel_ready")
            If ComboBox1.Items.Count >= 0 Then ComboBox1.SelectedIndex = 0
        End Sub
        Private Function ImportSkeleton(Name As String) As Boolean
            Dim Skeleton = ContentController.TheController_Assets.RetrieveAsset(Name, COH_Supported_ContentType.XML_SpecialCase_Bone)
            If Skeleton Is Nothing Then Return False
            rLinked_Skeletons.Add(Name, Skeleton)
            ComboBox1.Items.Add(Name)
            Return True
        End Function
        Private Function ImportSkeleton_FromAnimation(Name As String) As Boolean
            Dim Animation As COH_Resource_Anim = Nothing
            If ImportSkeletonAnimation(Name, Animation) = False Then Return False
            Dim Skeleton = Animation.Extract_Skeleton()
            If Skeleton Is Nothing Then Return False
            rLinked_Skeletons.Add(Name, Skeleton)
            Return True
        End Function
        Private Function ImportSkeletonAnimation(Name As String, ByRef Result As COH_Resource_Anim) As Boolean
            Dim FileName As String = ContentController.TheController_Assets.RetrieveAsset_FilePath(Name, COH_Supported_ContentType.Resource_ANIMATION)
            If String.IsNullOrEmpty(FileName) = True Then Return False
            Result = New COH_Resource_Anim
            If Result.Import_From_File(FileName, New COH_Serialization_Settings(True) With {.Option_SelectedFormat = COH_ExportFormat.Binary}) = False Then Return False
            Return True
        End Function
        Private Sub Retrieve_LinkedAssets_Textures()
            rLinked_Textures = New Dictionary(Of String, COH_FileStructure) ' New GameContent.Resources.Structures.Textures.COH_Resource_Texture(mCurrentGEO.Header.TextureNames_Count - 1) {}
            For X = 0 To mCurrentGEO.Header.TextureNames_Count - 1
                Dim FileName As String = ContentController.TheController_Assets.RetrieveAsset_FilePath(System.IO.Path.GetFileNameWithoutExtension(mCurrentGEO.Header.TextureNames(X)))
                If rLinked_Textures.ContainsKey(System.IO.Path.GetFileNameWithoutExtension(FileName)) = False Then
                    Dim Temp = ContentController.TheController_Assets.RetrieveAsset_ImageStruct(FileName)
                    If Temp Is Nothing = False Then
                        rLinked_Textures.Add(System.IO.Path.GetFileNameWithoutExtension(FileName), Temp)
                    End If
                End If
            Next
        End Sub
        Private Sub Retrieve_LinkedAssets_TricksTextures()
            rLinked_Tricks_Tex = New Dictionary(Of String, COH_TextureOptions)
            For X = 0 To mCurrentGEO.Models.Count - 1
                Dim newItem As COH_TextureOptions = Nothing
                Dim TrickName As String = System.IO.Path.GetFileNameWithoutExtension(mCurrentGEO.Models(X).ModelName)
                If rLinked_Tricks_Tex.ContainsKey(TrickName) = False Then
                    'newItem = ContentController.Retrieve_ModableContent(TrickName, GameContent.Enums.COH_ProjectContent.TextureOptions)
                    'If (newItem Is Nothing) = False Then rLinked_Tricks_Tex.Add(TrickName, newItem)
                End If
            Next
        End Sub
        Private Sub Retrieve_LinkedAssets_Tricks()
            rLinked_Tricks = New Dictionary(Of String, COH_Trick)
            For X = 0 To mCurrentGEO.Models.Count - 1
                Dim newItem As COH_Trick = Nothing
                Dim TrickName As String = System.IO.Path.GetFileNameWithoutExtension(mCurrentGEO.Models(X).TrickName)
                If rLinked_Tricks.ContainsKey(TrickName) = False Then
                    'newItem = ContentController.Retrieve_ModableContent(TrickName, GameContent.Enums.COH_ProjectContent.Tricks)
                    'If (newItem Is Nothing) = False Then rLinked_Tricks.Add(TrickName, newItem)
                End If
            Next
        End Sub
#End Region

#Region "Update Details - Entire Model"
        Public Sub Update_ModelSelection()
            ModelList.Items.Clear()
            ModelList.BeginUpdate()
            For X = 0 To mCurrentGEO.Models.Count - 1
                Dim NewItem As New ListViewItem(X.ToString)
                NewItem.Name = X
                NewItem.SubItems.Add(mCurrentGEO.Models(X).ModelName)
                NewItem.SubItems.Add(mCurrentGEO.Models(X).TrickName)
                NewItem.SubItems.Add(mCurrentGEO.Models(X).Mesh.Vertexs.Count)
                NewItem.SubItems.Add(mCurrentGEO.Models(X).Mesh.TriangleIndices.Count)
                NewItem.SubItems.Add(If(mCurrentGEO.Models(X).Mesh.Bones Is Nothing, 0, mCurrentGEO.Models(X).Mesh.Bones.Count))
                NewItem.SubItems.Add(mCurrentGEO.Header.ModelHeader.Models(X).Texture_Count)
                NewItem.SubItems.Add(mCurrentGEO.Models(X).Mesh.UV.Count)
                If Not mCurrentGEO.Models(mModelIndex).Mesh.BoneWeights Is Nothing Then
                    NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.BoneWeights.Count)
                Else
                    NewItem.SubItems.Add("-")
                End If
                If Not mCurrentGEO.Models(X).Mesh.BoneMatIndex Is Nothing Then
                    NewItem.SubItems.Add(mCurrentGEO.Models(X).Mesh.BoneMatIndex.Count)
                Else
                    NewItem.SubItems.Add("-")
                End If
                ModelList.Items.Add(NewItem)
                ImportModel(mCurrentGEO.Models(X))
            Next
            ModelList.EndUpdate()
            If ModelList.Items.Count > 0 Then ModelList.Items(0).Checked = True
            If ModelList.Items.Count > 0 Then ModelList.Items(0).Selected = True
            ResetPosition()
            CenterPosition()
        End Sub
        Private Sub UpdateDetails_BoneHeirarchy()
            If (rLinked_Skeletons Is Nothing) OrElse rLinked_Skeletons.Count = 0 Then
                '' GameContent.ShowErrorOccured("Missing Skeleton, You may Need to Extract ANIM Files", True)
                Me.TreeView1.Nodes.Clear()
                Me.ListView5.Items.Clear()
            Else
                HelperFunctions.Toolkit.Controls.TreeViews.Fill_TreeView(Me.TreeView1, rLinked_Skeletons.Values(SelectedBoneIndex))
                Me.TreeView1.Nodes(0).ExpandAll()
                Update_Bones_CoordinatesH()
            End If
        End Sub
#End Region

#Region "Update Details Display"
        Private Sub Update_Details()
            If mModelIndex = -1 Then Exit Sub
            Cursor.Current = Cursors.WaitCursor
            Update_Trick()
            Update_Materials()
            Update_UV_Coordinates()
            Update_Vertex_Coordinates()
            Update_Faces_Coordinates()
            Update_Bones_Coordinates()
            Cursor.Current = Cursors.Default
        End Sub
        Private Sub Update_Materials()
            CoH_TextureResource_Panel1.Populate_List(mCurrentGEO, mModelIndex, rLinked_Textures)
        End Sub
        Private Sub Update_Trick()
            If mCurrentGEO.Models.Count = 0 Then
                XML_View.ViewText("NO MODEL")
                Exit Sub
            End If
            Dim TrickName = mCurrentGEO.Models(mModelIndex).TrickName
            If TrickName = "" Then
                XML_View.ViewText("NO TRICK REFERENCED")
                Exit Sub
            End If
            Dim CurrentTrick As COH_Trick = Nothing
            If rLinked_Tricks.TryGetValue(TrickName, CurrentTrick) Then
                Dim XMLString As String = ""
                If CurrentTrick.Export_to_TextFormat(XMLString, New COH_Serialization_Settings(True) With {.Option_SelectedFormat = COH_ExportFormat.XML}) = True Then
                    XML_View.ViewText(XMLString)
                Else
                    XML_View.ViewText("ERROR")
                End If
            Else
                XML_View.ViewText("NO TRICK FOUND")
            End If
        End Sub
        Private Sub Update_UV_Coordinates()
            With Me.ListView2
                .Items.Clear()
                .BeginUpdate()
                For X = 0 To mCurrentGEO.Models(mModelIndex).Mesh.UV.Count - 1
                    Dim NewItem As New ListViewItem(X.ToString)
                    NewItem.Name = X.ToString
                    NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.UV(X).X)
                    NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.UV(X).Y)
                    .Items.Add(NewItem)
                Next
                .EndUpdate()
            End With
        End Sub
        Private Sub Update_Vertex_Coordinates()
            With Me.ListView1
                .Items.Clear()
                .BeginUpdate()
                For X = 0 To mCurrentGEO.Models(mModelIndex).Mesh.Vertexs.Count - 1
                    Dim NewItem As New ListViewItem(X.ToString)
                    NewItem.Name = X.ToString
                    NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.Vertexs(X).X)
                    NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.Vertexs(X).Y)
                    NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.Vertexs(X).Z)
                    If mCurrentGEO.Models(mModelIndex).Mesh.BoneWeights Is Nothing Then
                        NewItem.SubItems.Add("-")
                    Else
                        NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.BoneWeights(X).ToString)
                    End If
                    If mCurrentGEO.Models(mModelIndex).Mesh.BoneMatIndex Is Nothing Then
                        NewItem.SubItems.Add("-")
                    Else
                        NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.BoneMatIndex(X).ToString & " : " & mCurrentGEO.Models(mModelIndex).Mesh.Bones(mCurrentGEO.Models(mModelIndex).Mesh.BoneMatIndex(X).Pos1 / 3).ToString & " , " & mCurrentGEO.Models(mModelIndex).Mesh.Bones(mCurrentGEO.Models(mModelIndex).Mesh.BoneMatIndex(X).Pos2 / 3).ToString)
                    End If
                    .Items.Add(NewItem)
                Next
                .EndUpdate()
            End With
        End Sub
        Private Sub Update_Faces_Coordinates()
            With Me.ListView3
                .Items.Clear()
                .BeginUpdate()
                For X = 0 To mCurrentGEO.Models(mModelIndex).Mesh.TriangleIndices.Count - 1
                    Dim NewItem As New ListViewItem(X.ToString)
                    NewItem.Name = X.ToString
                    NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.TriangleIndices(X).Value1)
                    NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.TriangleIndices(X).Value2)
                    NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.TriangleIndices(X).Value3)
                    .Items.Add(NewItem)
                Next
                .EndUpdate()
            End With
        End Sub
        Private Sub Update_Bones_Coordinates()
            With Me.ListView4
                .Items.Clear()
                .BeginUpdate()
                If Not mCurrentGEO.Header.ModelHeader.Models(mModelIndex).BoneInfo Is Nothing Then
                    For X = 0 To mCurrentGEO.Header.ModelHeader.Models(mModelIndex).BoneInfo.NumberBones - 1
                        Dim NewItem As New ListViewItem(X.ToString)
                        NewItem.Name = X.ToString
                        NewItem.SubItems.Add(mCurrentGEO.Models(mModelIndex).Mesh.Bones(X).ToString)
                        NewItem.SubItems.Add("Unknown")
                        .Items.Add(NewItem)
                    Next
                End If
                .EndUpdate()
            End With
        End Sub
        Private Sub Update_Bones_CoordinatesH()
            With Me.ListView5
                .Items.Clear()
                .BeginUpdate()
                If Not rLinked_Skeletons.Values Is Nothing Then
                    For X = 0 To rLinked_Skeletons.Values(SelectedBoneIndex).Bones.Count - 1
                        AddBone_ToListView(rLinked_Skeletons.Values(SelectedBoneIndex).Bones(X))
                    Next
                End If
                .EndUpdate()
            End With
        End Sub
        Private Sub AddBone_ToListView(ByRef Bone As COH_Resource_GEO_SkeletonBone)
            Dim NewItem As New ListViewItem(Bone.BoneIndex)
            NewItem.Name = Bone.ID.ToString
            NewItem.SubItems.Add(Bone.ID.ToString)
            NewItem.SubItems.Add(Bone.FirstPosition.ToString)
            NewItem.SubItems.Add(Bone.ConnectedPosition.ToString)
            ListView5.Items.Add(NewItem)
            For X = 0 To Bone.Children.Count - 1
                AddBone_ToListView(Bone.Children(X))
            Next
        End Sub
#End Region

#Region "Display"
        Public Sub Update_Display()
            If Changes_Locked = True Then Exit Sub
            If ModelViewer Is Nothing Then Exit Sub
            Update_Models_RenderOptions()
            ModelViewer.Items.Clear()
            'DisplayModel_LightSource()
            ModelViewer.Items.Add(mLight)
            If mShow_Grid = True Then ModelViewer.Items.Add(mGrid)
            If mShow_Grid = True Then ModelViewer.Items.Add(HelperFunctions.Toolkit.GEO.BuildModel_VectorArrows)
            If mShow_Bones = True Then
                Update_Models_BonesUsedOptions()
                ModelViewer.Items.Add(mBones)
            End If
            For x = 0 To ModelList.Items.Count - 1
                If ModelList.Items(x).Checked = True Then
                    If mShow_Model = True Then ModelViewer.Items.Add(mModels(x))
                    If mShow_Vertex = True Then ModelViewer.Items.Add(mVertexModels(x))
                    If mShow_BoundingBox = True Then ModelViewer.Items.Add(mBoundingBox(x))
                End If
            Next
        End Sub
        Public Sub Update_Camera()
            ModelViewer.CameraMode = mCameraRotationMode
            ModelViewer.RotateAroundMouseDownPoint = mRotateAroundMouseDownPoint
        End Sub
        Public Sub Update_Grid()
            With mGrid
                .Color = mGrid_Color
            End With
        End Sub
#End Region

#Region "Build Render"
        Public Sub ClearModels()
            mModels = New List(Of HelixToolkit.Wpf.SharpDX.GroupModel3D)
            mVertexModels = New List(Of PointGeometryModel3D)
            ClearTextures()
        End Sub
        Public Sub ClearTextures()
            If rCurrentTextureStreams Is Nothing Then
                rCurrentTextureStreams = New List(Of System.IO.MemoryStream)
            Else
                For X = rCurrentTextureStreams.Count - 1 To 0 Step -1
                    rCurrentTextureStreams(X).Dispose()
                Next
            End If
        End Sub
        Private Sub ImportModel(ByRef theModel As COH_Resource_GEO_Model)
            '///TESTING
            mBones = HelperFunctions.Toolkit.GEO.CreateSkeletonMesh_Bones(rLinked_Skeletons.Values(SelectedBoneIndex), Skeleton_Color)

            Dim AdjustHandiness As Integer = -1 '//GET FROM TANGENTS NEED TO ADD
            If theModel.Mesh.TextureNames.Count <= 1 Then
                ImportModel_SingleMaterialGroup(theModel, AdjustHandiness)
            Else
                ImportModel_IntoMaterialGroups(theModel, AdjustHandiness)
            End If
            Update_ModelGrid(AdjustHandiness)
        End Sub
        Private Sub ImportModel_IntoMaterialGroups(ByRef theModel As COH_Resource_GEO_Model, Optional AdjustHandiness As Integer = 1)
            Dim NumberMaterialGroups As Integer = theModel.Mesh.TextureNames.Count
            If mModels Is Nothing Then mModels = New List(Of HelixToolkit.Wpf.SharpDX.GroupModel3D)
            Dim VertexBuffer As New Vector3Collection
            Dim HasBones As Boolean = (Not (theModel.Mesh.Bones Is Nothing) AndAlso theModel.Mesh.Bones.Count > 0)
            For x = 0 To theModel.Mesh.Vertexs.Count - 1
                Dim NewVector As Vector3 = Nothing
                If mOption_AdjustModelPositions = True AndAlso HasBones = True Then
                    NewVector = AdjustVertexPosition_FromBone(x, theModel)
                Else
                    NewVector = HelperFunctions.Toolkit.GEO.Convert_Vector3_SharpVector3D(theModel.Mesh.Vertexs(x), AdjustHandiness)
                End If
                VertexBuffer.Add(NewVector)
            Next
            Dim Normals As New Vector3Collection
            For x = 0 To theModel.Mesh.Normals.Count - 1
                Normals.Add(HelperFunctions.Toolkit.GEO.Convert_Vector3_SharpVector3D(theModel.Mesh.Normals(x)))
            Next
            Dim UV As New Vector2Collection
            For x = 0 To theModel.Mesh.UV.Count - 1
                UV.Add(HelperFunctions.Toolkit.GEO.Convert_Vector2_SharpVector3D_InversedY(theModel.Mesh.UV(x)))
            Next
            Dim TriangleIndicesL(NumberMaterialGroups - 1) As IntCollection
            Dim TIndex As Integer = 0
            Dim UniqueIndicies As New List(Of Integer)
            For X = 0 To NumberMaterialGroups - 1
                TriangleIndicesL(X) = New IntCollection
                For X2 = 0 To theModel.Mesh.TextureSTSCounts(X) - 1
                    TriangleIndicesL(X).Add(theModel.Mesh.TriangleIndices(TIndex).Value1)
                    TriangleIndicesL(X).Add(theModel.Mesh.TriangleIndices(TIndex).Value2)
                    TriangleIndicesL(X).Add(theModel.Mesh.TriangleIndices(TIndex).Value3)
                    TIndex += 1
                Next
            Next
            Dim BoundingBox As New SharpDX.BoundingBox(HelperFunctions.Toolkit.GEO.Convert_Vector3_SharpVector3D(theModel.BoundingBox_Min), HelperFunctions.Toolkit.GEO.Convert_Vector3_SharpVector3D(theModel.BoundingBox_Max))
            Dim Rect3D As New Rect3D(theModel.BoundingBox_Min.X, theModel.BoundingBox_Min.Y, theModel.BoundingBox_Min.Z, BoundingBox.Width, BoundingBox.Height, BoundingBox.Depth)

            Dim NewGroup As New HelixToolkit.Wpf.SharpDX.GroupModel3D()
            mModels.Add(NewGroup)
            For X = 0 To NumberMaterialGroups - 1
                Dim CurrentMeshGeometry = New HelixToolkit.Wpf.SharpDX.MeshGeometry3D() With {.Positions = VertexBuffer, .Indices = TriangleIndicesL(X), .Normals = Normals, .Bound = BoundingBox, .TextureCoordinates = UV}
                'meshGeometry.Colors = Nothing
                'meshGeometry.Tangents = Nothing
                'meshGeometry.BiTangents = Nothing
                CurrentMeshGeometry.RemoveIsolatedVertices
                CurrentMeshGeometry.Normals = CurrentMeshGeometry.CalculateNormals()
                Dim NewMesh = CreateModel_Mesh(theModel.ModelName & "_x_" & X, theModel.Index, X, CurrentMeshGeometry)
                NewGroup.Children.Add(NewMesh)
            Next

            Dim TheGeometry = New HelixToolkit.Wpf.SharpDX.PointGeometry3D With {.Positions = VertexBuffer}
            AddModel_Vertex(theModel.ModelName, TheGeometry)

            AddModel_BoundingBox(theModel.ModelName, Rect3D, theModel.Radius)
        End Sub
        Private Sub ImportModel_SingleMaterialGroup(ByRef theModel As COH_Resource_GEO_Model, Optional AdjustHandiness As Integer = 1)
            '//1 if not used...tangents determined
            If mModels Is Nothing Then mModels = New List(Of HelixToolkit.Wpf.SharpDX.GroupModel3D)
            Dim VertexBuffer As New Vector3Collection
            Dim HasBones As Boolean = (Not (theModel.Mesh.Bones Is Nothing) AndAlso theModel.Mesh.Bones.Count > 0)
            For x = 0 To theModel.Mesh.Vertexs.Count - 1
                Dim NewVector As Vector3 = Nothing
                If mOption_AdjustModelPositions = True AndAlso HasBones = True Then
                    NewVector = AdjustVertexPosition_FromBone(x, theModel)
                Else
                    NewVector = HelperFunctions.Toolkit.GEO.Convert_Vector3_SharpVector3D(theModel.Mesh.Vertexs(x), AdjustHandiness)
                End If
                VertexBuffer.Add(NewVector)
            Next
            Dim TriangleIndices As New IntCollection
            For x = 0 To theModel.Mesh.TriangleIndices.Count - 1
                TriangleIndices.Add(theModel.Mesh.TriangleIndices(x).Value1)
                TriangleIndices.Add(theModel.Mesh.TriangleIndices(x).Value2)
                TriangleIndices.Add(theModel.Mesh.TriangleIndices(x).Value3)
            Next
            Dim Normals As New Vector3Collection
            For x = 0 To theModel.Mesh.Normals.Count - 1
                Normals.Add(HelperFunctions.Toolkit.GEO.Convert_Vector3_SharpVector3D(theModel.Mesh.Normals(x)))
            Next
            Dim UV As New Vector2Collection
            For x = 0 To theModel.Mesh.UV.Count - 1
                UV.Add(HelperFunctions.Toolkit.GEO.Convert_Vector2_SharpVector3D_InversedY(theModel.Mesh.UV(x)))
            Next
            Dim BoundingBox As New SharpDX.BoundingBox(HelperFunctions.Toolkit.GEO.Convert_Vector3_SharpVector3D(theModel.BoundingBox_Min), HelperFunctions.Toolkit.GEO.Convert_Vector3_SharpVector3D(theModel.BoundingBox_Max))
            Dim Rect3D As New Rect3D(theModel.BoundingBox_Min.X, theModel.BoundingBox_Min.Y, theModel.BoundingBox_Min.Z, BoundingBox.Width, BoundingBox.Height, BoundingBox.Depth)

            Dim CurrentMeshGeometry = New HelixToolkit.Wpf.SharpDX.MeshGeometry3D() With {.Positions = VertexBuffer, .Indices = TriangleIndices, .Normals = Normals, .Bound = BoundingBox, .TextureCoordinates = UV}
            'meshGeometry.Colors = Nothing
            'meshGeometry.Tangents = Nothing
            'meshGeometry.BiTangents = Nothing
            Dim NewMesh = CreateModel_Mesh(theModel.ModelName, theModel.Index, 0, CurrentMeshGeometry)
            Dim NewGroup As New HelixToolkit.Wpf.SharpDX.GroupModel3D()
            NewGroup.Children.Add(NewMesh)
            mModels.Add(NewGroup)

            Dim TheGeometry = New HelixToolkit.Wpf.SharpDX.PointGeometry3D With {.Positions = VertexBuffer}
            AddModel_Vertex(theModel.ModelName, TheGeometry)

            AddModel_BoundingBox(theModel.ModelName, Rect3D, theModel.Radius)
        End Sub
        Private Function AdjustVertexPosition_FromBone(ByRef VecIndex As Integer, ByRef theModel As COH_Resource_GEO_Model, Optional AdjustHandiness As Integer = 1) As Vector3
            Dim NewVector As Vector3 = HelperFunctions.Toolkit.GEO.Convert_Vector3_SharpVector3D(theModel.Mesh.Vertexs(VecIndex), AdjustHandiness)
            Dim BoneName1 As String = theModel.Mesh.Bones(theModel.Mesh.BoneMatIndex(VecIndex).Pos1 / 3).ToString
            Dim BoneName2 As String = theModel.Mesh.Bones(theModel.Mesh.BoneMatIndex(VecIndex).Pos2 / 3).ToString
            Dim ConnectedBone1 As COH_Resource_GEO_SkeletonBone = rLinked_Skeletons.Values(SelectedBoneIndex).SearchBone(BoneName1)
            Dim ConnectedBone2 As COH_Resource_GEO_SkeletonBone = rLinked_Skeletons.Values(SelectedBoneIndex).SearchBone(BoneName2)
            Dim BoneWeight1 As Single = theModel.Mesh.BoneWeights(VecIndex).W1
            Dim BoneWeight2 As Single = theModel.Mesh.BoneWeights(VecIndex).W2

            Dim Matrix = SharpDX.Matrix.Translation(New Vector3(ConnectedBone1.ConnectedPosition.Retrieve_Singles))
            Dim A1 = (BoneWeight1 * New Vector3(ConnectedBone1.ConnectedPosition.Retrieve_Singles))
            Dim A2 = (BoneWeight2 * New Vector3(ConnectedBone2.ConnectedPosition.Retrieve_Singles))
            A1.X = A1.X * AdjustHandiness
            A2.X = A2.X * AdjustHandiness

            NewVector += A1
            NewVector += A2
            Return NewVector
        End Function
        Private Function Calculate_NumberMaterialGroups(Index As Integer, MaterialIndex As Integer) As Integer
            Dim Total As Integer = 0
            For X = 0 To Index - 1
                Total += mModels(X).Children.Count
            Next
            Total += MaterialIndex
            Return Total
        End Function
        Private Function CreateModel_Mesh(Name As String, Index As Integer, MaterialIndex As Integer, ByRef CurrentMeshGeometry As HelixToolkit.Wpf.SharpDX.MeshGeometry3D) As MeshGeometryModel3D
            If mModels Is Nothing Then mModels = New List(Of HelixToolkit.Wpf.SharpDX.GroupModel3D)
            Dim CurrentMesh As New MeshGeometryModel3D()
            With CurrentMesh
                .Name = Name
                .Geometry = CurrentMeshGeometry
                .Material = CreateModel_ReturnMaterial(Index, MaterialIndex)
                .WireframeColor = mWireFrame_Color
                .RenderWireframe = mShow_WireFrame
                .IsTransparent = mShow_Model
            End With
            Return CurrentMesh
        End Function
        Private Function CreateModel_ReturnMaterial(Index As Integer, MaterialIndex As Integer) As HelixToolkit.Wpf.SharpDX.Material
            Dim Material As HelixToolkit.Wpf.SharpDX.Material
            If mShow_Materials = False Then
                Material = New HelixToolkit.Wpf.SharpDX.DiffuseMaterial(New Model.DiffuseMaterialCore() With {.DiffuseColor = RetrieveGroupColor(Calculate_NumberMaterialGroups(Index, MaterialIndex)).ToColor4})
            Else
                Dim TheTexture As COH_Resource_Texture = Nothing
                Dim TheTextureName As String = mCurrentGEO.Models(Index).Mesh.TextureNames(MaterialIndex)

                If rLinked_Textures.TryGetValue(System.IO.Path.GetFileNameWithoutExtension(TheTextureName), TheTexture) Then
                    Dim DiffuseMapStream As New System.IO.MemoryStream()
                    rCurrentTextureStreams.Add(DiffuseMapStream)
                    Dim TempIMage As Bitmap = TheTexture.Extract_Resource_Texture()
                    'TempIMage.RotateFlip(RotateFlipType.RotateNoneFlipY) '//THIS STILL ISNT THE ISSUE
                    TempIMage.Save(DiffuseMapStream, System.Drawing.Imaging.ImageFormat.Png)
                    TheTexture.Extract_Resource_Texture().Save(DiffuseMapStream, System.Drawing.Imaging.ImageFormat.Png)
                    Material = New HelixToolkit.Wpf.SharpDX.DiffuseMaterial(New Model.DiffuseMaterialCore() With {.DiffuseMap = DiffuseMapStream})
                Else
                    Material = New HelixToolkit.Wpf.SharpDX.DiffuseMaterial(New Model.DiffuseMaterialCore() With {.DiffuseColor = RetrieveGroupColor(Calculate_NumberMaterialGroups(Index, MaterialIndex)).ToColor4})
                End If
            End If
            Return Material
        End Function
        Private Sub AddModel_Vertex(Name As String, ByRef TheGeometry As HelixToolkit.Wpf.SharpDX.PointGeometry3D) '//Set Scale Later
            If mVertexModels Is Nothing Then mVertexModels = New List(Of PointGeometryModel3D)
            Dim VertexModel As New HelixToolkit.Wpf.SharpDX.PointGeometryModel3D
            With VertexModel
                .Name = Name
                .Geometry = TheGeometry
                .Color = mVertex_Color
                .Size = New Windows.Size(mVertex_Size, mVertex_Size)
            End With
            mVertexModels.Add(VertexModel)
        End Sub
        Private Sub AddModel_BoundingBox(Name As String, ByRef BoundingBox As Rect3D, TheRadius As Single)
            If mBoundingBox Is Nothing Then mBoundingBox = New List(Of MeshGeometryModel3D)
            Dim Material As HelixToolkit.Wpf.SharpDX.Material = New HelixToolkit.Wpf.SharpDX.DiffuseMaterial(New Model.DiffuseMaterialCore() With {.DiffuseColor = mBoundingBox_Color.ToColor4})
            Dim MeshBuilder As New HelixToolkit.Wpf.SharpDX.MeshBuilder
            MeshBuilder.AddBox(BoundingBox, HelixToolkit.Wpf.BoxFaces.All)
            MeshBuilder.ToMesh()
            Dim CurrentMesh As New MeshGeometryModel3D()
            With CurrentMesh
                .Name = "BoundingBox" & Name
                .Geometry = MeshBuilder.ToMesh()
                .Material = Material
                .WireframeColor = mWireFrame_Color
                .RenderWireframe = True
                .IsTransparent = True
            End With
            mBoundingBox.Add(CurrentMesh)
        End Sub
        Private Sub Update_ModelGrid(Optional AdjustHandiness As Integer = 1)
            Dim TheBox As Rect3D = HelperFunctions.Toolkit.GEO.Calculate_MaxBoundingBox(mCurrentGEO, AdjustHandiness)
            Dim TheMin As Vector2 = New Vector2(Math.Floor(TheBox.X), Math.Floor(TheBox.Z))
            Dim Size As Integer = TheBox.SizeX
            If TheBox.X > -10 Then
                mGrid = HelperFunctions.Toolkit.GEO.Create_RetrieveGrid_Lines("Grid", New Vector2(-10, -10), 20, 1, mGrid_Color)
            ElseIf TheBox.X < -100 Then
                mGrid = HelperFunctions.Toolkit.GEO.Create_RetrieveGrid_Lines("Grid", New Vector2(-1000, -1000), 2000, 50, mGrid_Color)
            ElseIf TheBox.X < -10 Then
                mGrid = HelperFunctions.Toolkit.GEO.Create_RetrieveGrid_Lines("Grid", New Vector2(-100, -100), 200, 5, mGrid_Color)
            Else
                mGrid = HelperFunctions.Toolkit.GEO.Create_RetrieveGrid_Lines("Grid", New Vector2(-10000, -10000), 20000, 50, mGrid_Color)
            End If
        End Sub
        Private Function RetrieveGroupColor(Index As Integer) As Windows.Media.Color
            Select Case Index
                Case 0
                    Return Colors.Blue
                Case 1
                    Return Colors.Red
                Case 2
                    Return Colors.Green
                Case 3
                    Return Colors.Yellow
                Case 4
                    Return Colors.Purple
                Case 5
                    Return Colors.Orange
                Case 6
                    Return Colors.Pink
                Case 7
                    Return Colors.YellowGreen
                Case Else
                    Dim TheRnd As New Random
                    Return Windows.Media.Color.FromArgb(255, TheRnd.Next(255), TheRnd.Next(255), TheRnd.Next(255))
            End Select
        End Function
        Private Function Calculate_BoundingBox_Visible() As Rect3D
            Dim MinPos As New COH_Struct_Vector3
            Dim MaxPos As New COH_Struct_Vector3
            For X = 0 To ModelList.Items.Count - 1
                If ModelList.Items(X).Checked = True And mModels.Count > 0 Then
                    HelperFunctions.Toolkit.GEO.Calculate_BoundingBox_Regions(mCurrentGEO.Models(X).Mesh.Vertexs, MinPos, MaxPos, -1) '//THIS NEEDS SET SOMEWHERE
                End If
            Next
            Return HelperFunctions.Toolkit.GEO.Calculate_BoundingBox_FromMinMax(MinPos, MaxPos)
        End Function

#End Region

#Region "Update Render"
        Public Sub Update_TextureSelection(ByRef TextureList As ListBox, ModelIndex As Integer)
            ' TextureList.ItemsSource = Nothing
            'TextureList.Items.Clear()
            ''Materials = New List(Of Controls.WPF.COH_MaterialThumbnail)
            'For X = 0 To mCurrentGEO.Header.TextureNames.Count - 1
            ' Materials.Add(New Controls.WPF.COH_MaterialThumbnail())
            ' Next
            ' TextureList.ItemsSource = ModelItems

            '// mCurrentGEO.Header.ModelHeader.Models(x).Texture_Indexes


            ResetPosition()
            CenterPosition()
        End Sub
        Public Sub Update_Models_RenderOptions()
            If mModels Is Nothing Then Exit Sub
            For Each Entry In mModels
                For Each Child As HelixToolkit.Wpf.SharpDX.MeshGeometryModel3D In Entry.Children
                    Child.RenderWireframe = mShow_WireFrame
                    Child.WireframeColor = mWireFrame_Color
                    Child.IsTransparent = mShow_Transparent
                Next
            Next
            For Each Entry In mVertexModels
                Entry.Color = mVertex_Color
                Entry.Size = New Windows.Size(mVertex_Size, mVertex_Size)
            Next
        End Sub 'ClearTextures
        Public Sub Update_Models_MaterialsOptions()
            If mModels Is Nothing Then Exit Sub
            ClearTextures()
            For X = 0 To mModels.Count - 1
                For X2 = 0 To mModels(X).Children.Count - 1
                    Dim Child As HelixToolkit.Wpf.SharpDX.MeshGeometryModel3D = mModels(X).Children(X2)
                    Child.Material = CreateModel_ReturnMaterial(X, X2)
                Next
            Next
            For Each Entry In mVertexModels
                Entry.Color = mVertex_Color
                Entry.Size = New Windows.Size(mVertex_Size, mVertex_Size)
            Next
        End Sub
        Public Sub Update_Models_BonesUsedOptions()
            If mBones Is Nothing Then Exit Sub
            If mCurrentGEO.Models(mModelIndex).Mesh.Bones Is Nothing OrElse mCurrentGEO.Models(mModelIndex).Mesh.Bones.Count = 0 Then Exit Sub
            For X2 = 0 To mBones.Children.Count - 1
                Dim Child As HelixToolkit.Wpf.SharpDX.MeshGeometryModel3D = mBones.Children(X2)
                Dim BoneUsed As Boolean = False
                Dim BoneName As String = Child.Name
                For X = 0 To mCurrentGEO.Models(mModelIndex).Mesh.Bones.Count - 1
                    If mCurrentGEO.Models(mModelIndex).Mesh.Bones(X).ToString = BoneName Then
                        BoneUsed = True
                        Exit For
                    End If
                Next
                If BoneUsed = True Then
                    Child.Material = New HelixToolkit.Wpf.SharpDX.DiffuseMaterial(New Model.DiffuseMaterialCore() With {.DiffuseColor = mBone_ColorUsed.ToColor4})
                Else
                    Child.Material = New HelixToolkit.Wpf.SharpDX.DiffuseMaterial(New Model.DiffuseMaterialCore() With {.DiffuseColor = mBone_Color.ToColor4})
                End If
            Next
        End Sub
#End Region

#Region "Controls"
        Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
            If Changes_Locked = True Then Exit Sub
            mSelectedBoneIndex = ComboBox1.SelectedIndex
            ResetModel()
        End Sub
        Private Sub Button_AdjustPos_Click(sender As Object, e As EventArgs) Handles Button_AdjustPos.Click
            If Changes_Locked = True Then Exit Sub
            Skeleton_AdjustPositions = Button_AdjustPos.Checked
            ResetModel()
        End Sub
        Private Sub ModelList_ItemCheckedChanged(sender As Object, e As ItemCheckedEventArgs) Handles ModelList.ItemChecked
            If Changes_Locked = True Then Exit Sub
            Update_Display()
        End Sub
        Private Sub ModelList_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ModelList.SelectedIndexChanged
            If Changes_Locked = True Then Exit Sub
            If ModelList.SelectedItems.Count = 0 Then Exit Sub
            mModelIndex = ModelList.SelectedItems(0).Index
            Update_Details()
        End Sub
        Private Sub Button_SelectAll_Click(sender As Object, e As EventArgs) Handles Button_SelectAll.Click
            If Changes_Locked = True Then Exit Sub
            Select_AllModels(True)
        End Sub
        Private Sub Button_SelectNone_Click(sender As Object, e As EventArgs) Handles Button_SelectNone.Click
            If Changes_Locked = True Then Exit Sub
            Select_AllModels(False)
        End Sub
        Public Sub Select_AllModels(SetSelected As Boolean)
            Changes_Locked = True
            For X = 0 To ModelList.Items.Count - 1
                ModelList.Items(X).Checked = SetSelected
            Next
            Changes_Locked = False
            Update_Display()
        End Sub
        Private Sub ToggleButton_Transparent_Click(sender As Object, e As EventArgs) Handles ToggleButton_Transparent.Click
            If Changes_Locked = True Then Exit Sub
            UpdateAppearance_TooltipButton(ToggleButton_Transparent)
            Model_Show_Transparent = ToggleButton_Transparent.Checked
        End Sub
        Private Sub ToggleButton_Model_Click(sender As Object, e As EventArgs) Handles ToggleButton_Model.CheckedChanged
            If Changes_Locked = True Then Exit Sub
            UpdateAppearance_TooltipButton(ToggleButton_Model)
            Model_Show = ToggleButton_Model.Checked
        End Sub
        Private Sub ToggleButton_Bones_Click(sender As Object, e As EventArgs) Handles ToggleButton_Bones.CheckedChanged
            If Changes_Locked = True Then Exit Sub
            UpdateAppearance_TooltipButton(ToggleButton_Bones)
            Skeleton_Show = ToggleButton_Bones.Checked
        End Sub
        Private Sub ToggleButton_WireFrame_Click(sender As Object, e As EventArgs) Handles ToggleButton_WireFrame.Click
            If Changes_Locked = True Then Exit Sub
            UpdateAppearance_TooltipButton(ToggleButton_WireFrame)
            WireFrame_Show = ToggleButton_WireFrame.Checked
        End Sub
        Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToggleButton_Materials.Click
            If Changes_Locked = True Then Exit Sub
            UpdateAppearance_TooltipButton(ToggleButton_Materials)
            Model_Show_Materials = ToggleButton_Materials.Checked
        End Sub
        Private Sub Toggle_Vertex_Click(sender As Object, e As EventArgs) Handles Toggle_Vertex.CheckedChanged
            If Changes_Locked = True Then Exit Sub
            UpdateAppearance_TooltipButton(Toggle_Vertex)
            Vertex_Show = Toggle_Vertex.Checked
        End Sub
        Private Sub UpdateAppearance_TooltipButton(ByRef theButton As ToolStripButton)
            If theButton.Checked = True Then
                theButton.BackColor = System.Drawing.Color.Yellow
            Else
                theButton.BackColor = Me.ToolStrip1.BackColor
            End If
        End Sub

#End Region

    End Class
End Namespace