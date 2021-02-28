Namespace GameContent.Structures.Costumes.Cloth
    Public NotInheritable Class COH_Costume_Cloth_CollisionInfo
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Type
            End Get
        End Property
#End Region

#Region "Properties"
        Property Type As String
            Get
                Return mType
            End Get
            Set(value As String)
                mType = value
            End Set
        End Property
        Property LOD As COH_Costume_Cloth_CollisionInfoLOD()
            Get
                Return mLOD
            End Get
            Set(value As COH_Costume_Cloth_CollisionInfoLOD())
                mLOD = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mType As String
       Private mLOD As COH_Costume_Cloth_CollisionInfoLOD()
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
            mType = String.Empty
            mLOD = New COH_Costume_Cloth_CollisionInfoLOD() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Costume_Cloth_CollisionInfo
            Dim Result As COH_Costume_Cloth_CollisionInfo = New COH_Costume_Cloth_CollisionInfo
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mType = String.Copy(mType)
                .mLOD = New COH_Costume_Cloth_CollisionInfoLOD(mLOD.Count - 1) {}
                For X = 0 To mLOD.Count - 1
                    .mLOD(X) = mLOD(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mType)
            If CurrentWriter.Write_CrypticS_StructArray(mLOD) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mType = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Costume_Cloth_CollisionInfoLOD), mLOD) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
