Imports System.Windows.Media.Media3D
Imports COH.GameContent.Structures.Resources.GEO
Imports COH.GameContent.Structures.Resources_Simplified
Imports COH.HelperClasses
Imports HelixToolkit.Wpf.SharpDX
Imports SharpDX

Namespace HelperFunctions.Toolkit.GEO
    <HideModuleName> Public Module COH_HelperFunctions_GEO

#Region "Vectors"
        Function Convert_Vector3_SharpVector3D(ByRef Vector As COH_Struct_Vector3, Optional AdjustHandiness As Integer = 1) As SharpDX.Vector3
            Return New SharpDX.Vector3(Vector.X * AdjustHandiness, Vector.Y, Vector.Z)
        End Function
        Function Convert_Vector2_SharpVector3D(ByRef Vector As COH_Struct_Vector2) As SharpDX.Vector2
            Return New SharpDX.Vector2(Vector.X, Vector.Y)
        End Function
        Function Convert_Vector2_SharpVector3D_InversedY(ByRef Vector As COH_Struct_Vector2) As SharpDX.Vector2
            Return New SharpDX.Vector2(Vector.X, 1 - Vector.Y)
        End Function
        Function Convert_Vector2_SharpVector3D_InversedXY(ByRef Vector As COH_Struct_Vector2) As SharpDX.Vector2
            Return New SharpDX.Vector2(1 - Vector.X, 1 - Vector.Y)
        End Function
#End Region

#Region "Grids"
        Public Function Create_RetrieveGrid_Lines(Name As String, MinPosition As Vector2, Width As Integer, Spacing As Integer, GridColor As System.Windows.Media.Color, Optional LineThickNess As Single = 0.5) As LineGeometryModel3D
            Dim lineBilder = New LineBuilder()
            For x As Integer = 0 To Width Step Spacing
                lineBilder.AddLine(New Vector3(MinPosition.X + x, 0, MinPosition.Y), New Vector3(MinPosition.X + x, 0, MinPosition.Y + Width))
            Next
            For Z As Integer = 0 To Width Step Spacing
                lineBilder.AddLine(New Vector3(MinPosition.X, 0, MinPosition.Y + Z), New Vector3(MinPosition.X + Width, 0, MinPosition.Y + Z))
            Next
            Dim Result As LineGeometryModel3D = New LineGeometryModel3D()
            With Result
                .Geometry = lineBilder.ToLineGeometry3D()
                .Color = GridColor
                .Transform = New TranslateTransform3D(New Vector3D(0, 0, 0))
                .Name = Name
                .Thickness = LineThickNess
            End With
            Return Result
        End Function
        Public Function Create_RetrieveGrid_Axis(PlaneColor As Windows.Media.Color, GridColor As Windows.Media.Color) As AxisPlaneGridModel3D
            Dim Result As New AxisPlaneGridModel3D
            With Result
                .Name = "GridPlane"
                .AutoSpacing = False
                .RenderShadowMap = True
                .Offset = -0.2
                .GridPattern = GridPattern.Grid
                .GridColor = GridColor
                .PlaneColor = PlaneColor
                .GridSpacing = 1
                .GridThickness = 1
            End With
            Return Result
        End Function
#End Region

#Region "BoundingBox"
        Function Calculate_BoundingBox(ByRef TheVectors As Vector3(), Optional AdjustHandiness As Integer = 1) As Rect3D
            Dim MinPos As New Vector3D
            Dim MaxPos As New Vector3D
            For Each Vector In TheVectors
                Dim UsedX As Single = (Vector.X * AdjustHandiness)
                If UsedX > MaxPos.X Then MaxPos.X = UsedX
                If Vector.Y > MaxPos.Y Then MaxPos.Y = Vector.Y
                If Vector.Z > MaxPos.Z Then MaxPos.Z = Vector.Z
                If UsedX < MinPos.X Then MinPos.X = UsedX
                If Vector.Y < MinPos.Y Then MinPos.Y = Vector.Y
                If Vector.Z < MinPos.Z Then MinPos.Z = Vector.Z
            Next
            Dim NewBox As New Rect3D(MinPos.X, MinPos.Y, MinPos.Z, (MaxPos.X - MinPos.X), (MaxPos.Y - MinPos.Y), (MaxPos.Z - MinPos.Z))
            Return NewBox
        End Function
        Function Calculate_MaxBoundingBox(ByRef GEO As COH_Resource_GEO, Optional AdjustHandiness As Integer = 1) As Rect3D
            Dim MinPos As New COH_Struct_Vector3
            Dim MaxPos As New COH_Struct_Vector3
            For Each SelectedModel In GEO.Models
                Calculate_BoundingBox_Regions(SelectedModel.Mesh.Vertexs, MinPos, MaxPos, AdjustHandiness)
            Next
            Return Calculate_BoundingBox_FromMinMax(MinPos, MaxPos)
        End Function
        Sub Calculate_BoundingBox_Regions(ByRef TheVectors As COH_Struct_Vector3(), ByRef MinPos As COH_Struct_Vector3, ByRef MaxPos As COH_Struct_Vector3, Optional AdjustHandiness As Integer = 1)
            If MinPos Is Nothing Then MinPos = New COH_Struct_Vector3
            If MaxPos Is Nothing Then MaxPos = New COH_Struct_Vector3
            For Each Vector In TheVectors
                Dim UsedX As Single = (Vector.X * AdjustHandiness)
                If UsedX > MaxPos.X Then MaxPos.X = UsedX
                If Vector.Y > MaxPos.Y Then MaxPos.Y = Vector.Y
                If Vector.Z > MaxPos.Z Then MaxPos.Z = Vector.Z
                If UsedX < MinPos.X Then MinPos.X = UsedX
                If Vector.Y < MinPos.Y Then MinPos.Y = Vector.Y
                If Vector.Z < MinPos.Z Then MinPos.Z = Vector.Z
            Next
        End Sub
        Function Calculate_BoundingBox_FromMinMax(ByRef MinPos As COH_Struct_Vector3, ByRef MaxPos As COH_Struct_Vector3) As Rect3D
            Dim NewBox As New Rect3D(MinPos.X, MinPos.Y, MinPos.Z, (MaxPos.X - MinPos.X), (MaxPos.Y - MinPos.Y), (MaxPos.Z - MinPos.Z))
            Return NewBox
        End Function
#End Region

#Region "Slot"
        Function BuildModel_VectorArrow(Name As String, ArrowColor As Windows.Media.Color, UpVector As Vector3) As MeshGeometryModel3D
            Dim ArrowHead_Diameter As Single = 0.08, ArrowHeadLength As Single = 4, Theta As Integer = 12
            Dim Arrow_Diameter As Single = 0.04, ArrowLength As Single = 1.5F
            Dim ArrowHeadPosition_Start As Vector3 = New Vector3(UpVector.X * ArrowLength, UpVector.Y * ArrowLength, UpVector.Z * ArrowLength)
            Dim ArrowHeadPosition_Finish As Vector3 = New Vector3((UpVector.X * ArrowLength) * 1.2, (UpVector.Y * ArrowLength) * 1.2, (UpVector.Z * ArrowLength) * 1.2)
            Dim ArrowFinish As Vector3 = New Vector3(UpVector.X * ArrowLength, UpVector.Y * ArrowLength, UpVector.Z * ArrowLength)
            Dim bd = New MeshBuilder()
            bd.AddArrow(ArrowHeadPosition_Start, ArrowHeadPosition_Finish, ArrowHead_Diameter, ArrowHeadLength, Theta)
            bd.AddCylinder(Vector3.Zero, ArrowFinish, Arrow_Diameter, Theta)
            Dim MeshGeom = bd.ToMesh()

            Dim CurrentMesh As New MeshGeometryModel3D()
            With CurrentMesh
                .Name = Name
                .Geometry = MeshGeom
                .Material = New HelixToolkit.Wpf.SharpDX.DiffuseMaterial(New Model.DiffuseMaterialCore() With {.DiffuseColor = ArrowColor.ToColor4})

            End With
            Return CurrentMesh
        End Function
        Function BuildModel_VectorArrows() As HelixToolkit.Wpf.SharpDX.GroupModel3D
            Dim bd = New MeshBuilder()
            bd.AddSphere(Vector3.Zero, 0.08)
            Dim MeshGeom = bd.ToMesh()
            Dim CenterAxis As New MeshGeometryModel3D()
            With CenterAxis
                .Name = "Axis"
                .Geometry = MeshGeom
                .Material = New HelixToolkit.Wpf.SharpDX.DiffuseMaterial(New Model.DiffuseMaterialCore() With {.DiffuseColor = Windows.Media.Colors.Yellow.ToColor4})
            End With

            Dim XArrow As MeshGeometryModel3D = BuildModel_VectorArrow("X_Arrow", Windows.Media.Colors.Red, New Vector3(1, 0, 0))
            Dim YArrow As MeshGeometryModel3D = BuildModel_VectorArrow("Y_Arrow", Windows.Media.Colors.Green, New Vector3(0, 1, 0))
            Dim ZArrow As MeshGeometryModel3D = BuildModel_VectorArrow("Z_Arrow", Windows.Media.Colors.Blue, New Vector3(0, 0, 1))

            Dim Result As New HelixToolkit.Wpf.SharpDX.GroupModel3D
            Result.Children.Add(CenterAxis)
            Result.Children.Add(XArrow)
            Result.Children.Add(YArrow)
            Result.Children.Add(ZArrow)

            Return Result
        End Function
#End Region

#Region "Bones"
        Public Function CreateModel_Bones(ByRef BonesH As COH_Resource_GEO_Skeleton, BoneColor As Windows.Media.Color) As BoneSkinMeshGeometryModel3D
            Dim Result As New BoneSkinMeshGeometryModel3D
            With Result
                .Geometry = CreateModel_BonesMesh(BonesH)
                .Name = "Skeleton"
                .Material = New HelixToolkit.Wpf.SharpDX.DiffuseMaterial(New Model.DiffuseMaterialCore() With {.DiffuseColor = BoneColor.ToColor4})
            End With
            Return Result
        End Function
        Private Function CreateModel_BonesMesh(ByRef BonesH As COH_Resource_GEO_Skeleton) As BoneSkinnedMeshGeometry3D
            Dim mBoneList As List(Of Animations.Bone) = CreateModel_Bones(BonesH)
            Dim Result = CreateSkeletonMesh(mBoneList, 0.06)
            Return Result
        End Function
        Private Function CreateModel_Bones(ByRef BonesH As COH_Resource_GEO_Skeleton) As List(Of Animations.Bone)
            Dim mBoneList As New List(Of Animations.Bone)
            Dim BonesNodeIndex As Integer = 0
            If BonesH Is Nothing Then Return mBoneList
            For X = 0 To BonesH.Bones.Count - 1
                CreateModel_Bones_AddChild(BonesH.Bones(X), mBoneList)
            Next
            Return mBoneList
        End Function
        Private Sub CreateModel_Bones_AddChild(ByRef Bone As COH_Resource_GEO_SkeletonBone, ByRef BoneList As List(Of Animations.Bone))
            Dim NewBone As New Animations.Bone
            With NewBone
                .ParentIndex = Bone.ParentIndex
                .Name = Bone.ID.ToString
                .BindPose = SharpDX.Matrix.Translation(New Vector3(Bone.ConnectedPosition.Retrieve_Singles))
                '.BindPose.Row1 = New Vector4(Bone.ConnectedRotation.Retrieve_Singles)
            End With
            BoneList.Add(NewBone)
            For X = 0 To Bone.Children.Count - 1
                CreateModel_Bones_AddChild(Bone.Children(X), BoneList)
            Next
        End Sub
#End Region

#Region "Skeleton - Seperate Bones"
        Public Function CreateSkeletonMesh_Bones(ByRef BonesH As COH_Resource_GEO_Skeleton, BoneColor As Windows.Media.Color) As HelixToolkit.Wpf.SharpDX.GroupModel3D
            Dim BoneList As List(Of Animations.Bone) = CreateModel_Bones(BonesH)
            Dim Result As New HelixToolkit.Wpf.SharpDX.GroupModel3D
            With Result
                For X = 0 To BoneList.Count - 1
                    Dim NewModel = CreateSkeletonMesh_SingleBone(BoneList(X).Name, BoneList(X), X, BoneList, BoneColor, 0.06, 0.06)
                    Result.Children.Add(NewModel)
                Next
            End With
            Return Result
        End Function
        Private Function CreateSkeletonMesh_SingleBone(BoneName As String, ByRef Bone As Animations.Bone, BoneIndex As Integer, ByRef Bones As IList(Of Animations.Bone), BoneColor As Windows.Media.Color, Optional ByVal BoneScale As Single = 1.0F, Optional ByVal JointScale As Single = 1.0F) As MeshGeometryModel3D
            Dim Result As New BoneSkinMeshGeometryModel3D
            With Result
                .Geometry = CreateSkeletonMesh_SingleBone_Mesh(Bone, BoneIndex, Bones, BoneScale, JointScale)
                .Name = BoneName
                .Material = New HelixToolkit.Wpf.SharpDX.DiffuseMaterial(New Model.DiffuseMaterialCore() With {.DiffuseColor = BoneColor.ToColor4})
            End With
            Return Result
        End Function
        Private Function CreateSkeletonMesh_SingleBone_Mesh(ByRef Bone As Animations.Bone, BoneIndex As Integer, ByRef Bones As IList(Of Animations.Bone), Optional ByVal BoneScale As Single = 1.0F, Optional ByVal JointScale As Single = 1.0F) As HelixToolkit.Wpf.SharpDX.MeshGeometry3D
            Dim MeshBuilder = New MeshBuilder(True, False)
            MeshBuilder.AddPyramid(New Vector3(0, BoneScale / 2, 0), Vector3.UnitZ, Vector3.UnitY, BoneScale, 0, True)
            Dim SingleBone = MeshBuilder.ToMesh()
            Dim Mesh_BoneIds As New List(Of BoneIds)()
            Dim Mesh_VerticesPositions As New Vector3Collection(SingleBone.Positions.Count)
            Dim Mesh_Faces As New IntCollection(SingleBone.Indices.Count)
            If Bone.ParentIndex >= 0 Then
                Dim V As Integer = 0
                Mesh_Faces.AddRange(SingleBone.Indices.[Select](Function(x) x))
                For V = 0 To SingleBone.Positions.Count - 6 Step 3
                    Mesh_VerticesPositions.Add(Vector3.TransformCoordinate(SingleBone.Positions(V), Bones(Bone.ParentIndex).BindPose))
                    Mesh_VerticesPositions.Add(Vector3.TransformCoordinate(SingleBone.Positions(V + 1), Bones(Bone.ParentIndex).BindPose))
                    Mesh_VerticesPositions.Add(Bone.BindPose.TranslationVector)
                    Mesh_BoneIds.Add(New BoneIds() With {.Bone1 = Bone.ParentIndex, .Weights = New Vector4(1, 0, 0, 0)})
                    Mesh_BoneIds.Add(New BoneIds() With {.Bone1 = Bone.ParentIndex, .Weights = New Vector4(1, 0, 0, 0)})
                    Mesh_BoneIds.Add(New BoneIds() With {.Bone1 = BoneIndex, .Weights = New Vector4(1, 0, 0, 0)})
                Next
                Do While V < SingleBone.Positions.Count
                    Mesh_VerticesPositions.Add(Vector3.TransformCoordinate(SingleBone.Positions(V), Bones(Bone.ParentIndex).BindPose))
                    Mesh_BoneIds.Add(New BoneIds() With {.Bone1 = Bone.ParentIndex, .Weights = New Vector4(1, 0, 0, 0)})
                    V += 1
                Loop
            End If
            '///JOINTS
            MeshBuilder = New MeshBuilder(True, False)

            Dim currPos As Integer = MeshBuilder.Positions.Count
            MeshBuilder.AddSphere(Vector3.Zero, JointScale / 2, 12, 12)
            For j As Integer = currPos To MeshBuilder.Positions.Count - 1
                MeshBuilder.Positions(j) = Vector3.TransformCoordinate(MeshBuilder.Positions(j), Bone.BindPose)
                Mesh_BoneIds.Add(New BoneIds() With {.Bone1 = BoneIndex, .Weights = New Vector4(1, 0, 0, 0)})
            Next j

            Mesh_VerticesPositions.AddRange(MeshBuilder.Positions)
            Mesh_Faces.AddRange(MeshBuilder.TriangleIndices.[Select](Function(x) x))
            Dim Result As New HelixToolkit.Wpf.SharpDX.MeshGeometry3D()
            With Result
                '.VertexBoneIds = Mesh_BoneIds
                .Indices = Mesh_Faces
                .Positions = Mesh_VerticesPositions
                .Normals = Result.CalculateNormals()
            End With
            Return Result
        End Function
#End Region

#Region "Skeleton - Complete Single"
        Private Function CreateSkeletonMesh(ByRef Bones As IList(Of Animations.Bone), Optional ByVal scale As Single = 1.0F) As BoneSkinnedMeshGeometry3D
            Dim builder = New MeshBuilder(True, False)
            builder.AddPyramid(New Vector3(0, scale / 2, 0), Vector3.UnitZ, Vector3.UnitY, scale, 0, True)
            Dim singleBone = builder.ToMesh()
            Dim boneIds As New List(Of BoneIds)()
            Dim positions As New Vector3Collection(Bones.Count * singleBone.Positions.Count)
            Dim tris As New IntCollection(Bones.Count * singleBone.Indices.Count)
            Dim offset As Integer = 0
            For i As Integer = 0 To Bones.Count - 1
                If Bones(i).ParentIndex >= 0 Then
                    Dim currPos As Integer = positions.Count
                    tris.AddRange(singleBone.Indices.[Select](Function(x) x + offset))
                    Dim j As Integer = 0
                    Do While j < singleBone.Positions.Count - 6
                        positions.Add(Vector3.TransformCoordinate(singleBone.Positions(j), Bones(Bones(i).ParentIndex).BindPose))
                        positions.Add(Vector3.TransformCoordinate(singleBone.Positions(j + 1), Bones(Bones(i).ParentIndex).BindPose))
                        positions.Add(Bones(i).BindPose.TranslationVector)
                        boneIds.Add(New BoneIds() With {.Bone1 = Bones(i).ParentIndex, .Weights = New Vector4(1, 0, 0, 0)})
                        boneIds.Add(New BoneIds() With {.Bone1 = Bones(i).ParentIndex, .Weights = New Vector4(1, 0, 0, 0)})
                        boneIds.Add(New BoneIds() With {.Bone1 = i, .Weights = New Vector4(1, 0, 0, 0)})
                        j += 3
                    Loop
                    Do While j < singleBone.Positions.Count
                        positions.Add(Vector3.TransformCoordinate(singleBone.Positions(j), Bones(Bones(i).ParentIndex).BindPose))
                        boneIds.Add(New BoneIds() With {.Bone1 = Bones(i).ParentIndex, .Weights = New Vector4(1, 0, 0, 0)})
                        j += 1
                    Loop
                    offset += singleBone.Positions.Count
                End If
            Next i
            builder = New MeshBuilder(True, False)
            For i As Integer = 0 To Bones.Count - 1
                Dim currPos As Integer = builder.Positions.Count
                builder.AddSphere(Vector3.Zero, scale / 2, 12, 12)
                For j As Integer = currPos To builder.Positions.Count - 1
                    builder.Positions(j) = Vector3.TransformCoordinate(builder.Positions(j), Bones(i).BindPose)
                    boneIds.Add(New BoneIds() With {.Bone1 = i, .Weights = New Vector4(1, 0, 0, 0)})
                Next j
            Next i
            positions.AddRange(builder.Positions)
            tris.AddRange(builder.TriangleIndices.[Select](Function(x) x + offset))
            Dim mesh As New HelixToolkit.Wpf.SharpDX.BoneSkinnedMeshGeometry3D()
            With mesh
                .VertexBoneIds = boneIds
                .Indices = tris
                .Positions = positions
                .Normals = mesh.CalculateNormals()
            End With
            Return mesh
        End Function
#End Region

    End Module
End Namespace

