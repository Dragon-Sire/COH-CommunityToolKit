Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_LOD_Auto
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mModelName
            End Get
        End Property
#End Region

#Region "Properties"
        Property AllowedError As Single
            Get
                Return mAllowedError
            End Get
            Set(value As Single)
                mAllowedError = value
            End Set
        End Property
        Property LodNearFade As Single
            Get
                Return mLodNearFade
            End Get
            Set(value As Single)
                mLodNearFade = value
            End Set
        End Property
        Property LodNear As Single
            Get
                Return mLodNear
            End Get
            Set(value As Single)
                mLodNear = value
            End Set
        End Property
        Property LodFar As Single
            Get
                Return mLodFar
            End Get
            Set(value As Single)
                mLodFar = value
            End Set
        End Property
        Property LodFarFade As Single
            Get
                Return mLodFarFade
            End Get
            Set(value As Single)
                mLodFarFade = value
            End Set
        End Property
        Property LodFlags As COH_Enum_AutoLODFlags
            Get
                Return mLodFlags
            End Get
            Set(value As COH_Enum_AutoLODFlags)
                mLodFlags = value
            End Set
        End Property
        Property ModelName As String
            Get
                Return mModelName
            End Get
            Set(value As String)
                mModelName = value
            End Set
        End Property
        Property FileName As String
            Get
                Return mFileName
            End Get
            Set(value As String)
                mFileName = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mAllowedError As Single
       Private mLodNearFade As Single
       Private mLodNear As Single
       Private mLodFar As Single
       Private mLodFarFade As Single
       Private mLodFlags As COH_Enum_AutoLODFlags
       Private mModelName As String
       Private mFileName As String
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
            mAllowedError = 0
            mLodNearFade = 0
            mLodNear = 0
            mLodFar = 0
            mLodFarFade = 0
            mLodFlags = COH_Enum_AutoLODFlags.None
            mModelName = String.Empty
        End Sub
#End Region
#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_LOD_Auto
            Dim Result As COH_LOD_Auto = New COH_LOD_Auto
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mAllowedError = mAllowedError
                .mLodNearFade = mLodNearFade
                .mLodNear = mLodNear
                .mLodFar = mLodFar
                .mLodFarFade = mLodFarFade
                .mLodFlags = mLodFlags
                .mModelName = String.Copy(mModelName)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mAllowedError)
            CurrentWriter.Write(mLodNearFade)
            CurrentWriter.Write(mLodNear)
            CurrentWriter.Write(mLodFar)
            CurrentWriter.Write(mLodFarFade)
            CurrentWriter.Write_CrypticS_Flags(mLodFlags)
            CurrentWriter.Write_CrypticS_String(mModelName)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mAllowedError = CurrentReader.ReadSingle
            mLodNearFade = CurrentReader.ReadSingle
            mLodNear = CurrentReader.ReadSingle
            mLodFar = CurrentReader.ReadSingle
            mLodFarFade = CurrentReader.ReadSingle
            mLodFlags = CurrentReader.Read_CrypticS_Flags
            mModelName = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace