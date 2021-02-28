Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_LOD_Info
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mModelName
            End Get
        End Property
#End Region

#Region "Properties"
        Property ModelName As String
            Get
                Return mModelName
            End Get
            Set(value As String)
                mModelName = value
            End Set
        End Property
        Property Filename As String
            Get
                Return mFilename
            End Get
            Set(value As String)
                mFilename = value
            End Set
        End Property
        Property AutoLOD As COH_LOD_Auto()
            Get
                Return mAutoLOD
            End Get
            Set(value As COH_LOD_Auto())
                mAutoLOD = value
            End Set
        End Property
        Property ForceAutomatic As Boolean
            Get
                Return mForceAutomatic
            End Get
            Set(value As Boolean)
                mForceAutomatic = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mModelName As String
       Private mFilename As String
       Private mAutoLOD As COH_LOD_Auto()
       Private mForceAutomatic As Boolean
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
            mModelName = String.Empty
            mFilename = String.Empty
            mAutoLOD = New COH_LOD_Auto(5) {}
            mForceAutomatic = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_LOD_Info
            Dim Result As COH_LOD_Info = New COH_LOD_Info
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mModelName = String.Copy(mModelName)
                .mFilename = String.Copy(mFilename)
                .mAutoLOD = New COH_LOD_Auto(mAutoLOD.Count - 1) {}
                For X = 0 To mAutoLOD.Count - 1
                    .mAutoLOD(X) = mAutoLOD(X).Clone
                Next
                .mForceAutomatic = mForceAutomatic
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mModelName)
            CurrentWriter.Write_CrypticS_String(mFilename)
            If CurrentWriter.Write_CrypticS_StructArray(mAutoLOD) = False Then Return False
            CurrentWriter.Write_CrypticS_Boolean(mForceAutomatic)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mModelName = CurrentReader.Read_CrypticS_String
            mFilename = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_LOD_Auto), mAutoLOD) = False Then Return False
            mForceAutomatic = CurrentReader.Read_CrypticS_Boolean
            Return True
        End Function
#End Region

    End Class
End Namespace
