Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_BoneCapsule
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return BoneID.tostring
            End Get
        End Property
#End Region

#Region "Properties"
        Property BoneID As GEO_Enums_MESH_BoneId
            Get
                Return mBoneID
            End Get
            Set(value As GEO_Enums_MESH_BoneId)
                mBoneID = value
            End Set
        End Property
        Property Radius As Single
            Get
                Return mRadius
            End Get
            Set(value As Single)
                mRadius = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mBoneID As GEO_Enums_MESH_BoneId
       Private mRadius As Single
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings as COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings as COH_Serialization_Settings = Nothing)
             MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
             MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mBoneID = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_BoneCapsule
            Dim Result As COH_BoneCapsule = New COH_BoneCapsule
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mBoneID = mBoneID
                .mRadius = mRadius
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(CInt(mBoneID))
            CurrentWriter.Write(mRadius)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mBoneID = CurrentReader.ReadInt32
            mRadius = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
