Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_TextureOptions_Fallback
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Fallback"
            End Get
        End Property
#End Region

#Region "Properties"
        Property ScaleST As COH_Struct_Vector2()
            Get
                Return mScaleST
            End Get
            Set(value As COH_Struct_Vector2())
                mScaleST = value
            End Set
        End Property
        Property Base As String
            Get
                Return mBase
            End Get
            Set(value As String)
                mBase = value
            End Set
        End Property
        Property Blend As String
            Get
                Return mBlend
            End Get
            Set(value As String)
                mBlend = value
            End Set
        End Property
        Property BumpMap As String
            Get
                Return mBumpMap
            End Get
            Set(value As String)
                mBumpMap = value
            End Set
        End Property
        Property BlendType As Int32
            Get
                Return mBlendType
            End Get
            Set(value As Int32)
                mBlendType = value
            End Set
        End Property
        Property UseFallback As Byte
            Get
                Return mUseFallback
            End Get
            Set(value As Byte)
                mUseFallback = value
            End Set
        End Property
        Property DiffuseScaleVec As COH_Struct_Vector3
            Get
                Return mDiffuseScaleVec
            End Get
            Set(value As COH_Struct_Vector3)
                mDiffuseScaleVec = value
            End Set
        End Property
        Property AmbientScaleVec As COH_Struct_Vector3
            Get
                Return mAmbientScaleVec
            End Get
            Set(value As COH_Struct_Vector3)
                mAmbientScaleVec = value
            End Set
        End Property
        Property AmbientMinVec As COH_Struct_Vector3
            Get
                Return mAmbientMinVec
            End Get
            Set(value As COH_Struct_Vector3)
                mAmbientMinVec = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mScaleST As COH_Struct_Vector2()
       Private mBase As String
       Private mBlend As String
       Private mBumpMap As String
       Private mBlendType As Int32
       Private mUseFallback As Byte
       Private mDiffuseScaleVec As COH_Struct_Vector3
       Private mAmbientScaleVec As COH_Struct_Vector3
       Private mAmbientMinVec As COH_Struct_Vector3
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mScaleST = New COH_Struct_Vector2(1) {New COH_Struct_Vector2(1, 1), New COH_Struct_Vector2(1, 1)}
            mBase = String.Empty
            mBlend = String.Empty
            mBumpMap = String.Empty
            mDiffuseScaleVec = New COH_Struct_Vector3(1, 1, 1)
            mAmbientScaleVec = New COH_Struct_Vector3(1, 1, 1)
            mAmbientMinVec = New COH_Struct_Vector3
        End Sub
#End Region

#Region "Update From MAP"
#End Region

#Region "Clone"
        Public Function Clone() As COH_TextureOptions_Fallback
            Dim Result As COH_TextureOptions_Fallback = New COH_TextureOptions_Fallback
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mScaleST = mScaleST
                .mBase = String.Copy(mBase)
                .mBlend = String.Copy(mBlend)
                .mBumpMap = String.Copy(mBumpMap)
                .mBlendType = mBlendType
                .mUseFallback = mUseFallback
                .mDiffuseScaleVec = mDiffuseScaleVec
                .mAmbientScaleVec = mAmbientScaleVec
                .mAmbientMinVec = mAmbientMinVec
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            ''///If CurrentWriter.Write_CrypticS_StructEmbedd(mScaleST0) = False Then Return False
            ''//If CurrentWriter.Write_CrypticS_StructEmbedd(mScaleST1) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mBase)
            CurrentWriter.Write_CrypticS_String(mBlend)
            CurrentWriter.Write_CrypticS_String(mBumpMap)
            CurrentWriter.Write(mBlendType)
            CurrentWriter.Write(mUseFallback)
            '!!REDUNDENT!!CurrentWriter.Write(mAmbientScale)
            '!!REDUNDENT!!CurrentWriter.Write(mDiffuseScale)
            '!!REDUNDENT!!CurrentWriter.Write(mAmbientMin)
            '///If CurrentWriter.Write_CrypticS_StructEmbedd(mDiffuseScaleVec) = False Then Return False
            '///If CurrentWriter.Write_CrypticS_StructEmbedd(mAmbientScaleVec) = False Then Return False
            CurrentWriter.Write_CrypticS_Vector3(mAmbientMinVec)
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Dim EmbeddedStructureSize As Integer = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 8 Then Return False
            mScaleST(1) = CurrentReader.Read_CrypticS_Vector2 '//Why Flipped??

            EmbeddedStructureSize = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 8 Then Return False
            mScaleST(0) = CurrentReader.Read_CrypticS_Vector2

            mBase = CurrentReader.Read_CrypticS_String
            mBlend = CurrentReader.Read_CrypticS_String
            mBumpMap = CurrentReader.Read_CrypticS_String
            mBlendType = CurrentReader.ReadInt32
            mUseFallback = CurrentReader.ReadUInt32
            '!!REDUNDENT!!mAmbientScale = CurrentReader.ReadSingle
            '!!REDUNDENT!!mDiffuseScale = CurrentReader.ReadSingle
            '!!REDUNDENT!!mAmbientMin = CurrentReader.ReadSingle
            EmbeddedStructureSize = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 12 Then Return False
            mDiffuseScaleVec = CurrentReader.Read_CrypticS_Vector3

            EmbeddedStructureSize = CurrentReader.ReadInt32 : If EmbeddedStructureSize <> 12 Then Return False
            mAmbientScaleVec = CurrentReader.Read_CrypticS_Vector3

            mAmbientMinVec = CurrentReader.Read_CrypticS_Vector3
            Return True
        End Function
#End Region

    End Class
End Namespace
