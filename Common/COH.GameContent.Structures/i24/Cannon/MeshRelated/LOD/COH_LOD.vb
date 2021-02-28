Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_LOD
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "LOD"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Far As Single
            Get
                Return mFar
            End Get
            Set(value As Single)
                mFar = value
            End Set
        End Property
        Property FarFade As Single
            Get
                Return mFarFade
            End Get
            Set(value As Single)
                mFarFade = value
            End Set
        End Property
        Property Scale As Single
            Get
                Return mScale
            End Get
            Set(value As Single)
                mScale = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mFar As Single
       Private mFarFade As Single
       Private mScale As Single
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
            mFar = 0
            mFarFade = 0
            mScale = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_LOD
            Dim Result As COH_LOD = New COH_LOD
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mFar = mFar
                .mFarFade = mFarFade
                .mScale = mScale
                Return Result
            End With
        End Function
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mFar = CurrentReader.ReadSingle
            mFarFade = CurrentReader.ReadSingle
            mScale = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
