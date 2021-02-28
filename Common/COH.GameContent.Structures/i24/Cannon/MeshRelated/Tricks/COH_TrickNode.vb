Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_TrickNode
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Node"
            End Get
        End Property
#End Region

#Region "Properties"
        Property TextureScale_Y As Single '//Only Used by FX
        Property Animation_Age As Single
        Property Color1 As [Shared].Drawing.COH_Color_RGBA
        Property Color2 As [Shared].Drawing.COH_Color_RGBA
        Property Flags64 As UInt64
            Get
                Return BitConverter.ToUInt64(mBytes, 0)
            End Get
            Set(value As UInt64)
                BitConverter.GetBytes(value)
            End Set
        End Property
        Property Flags1 As UInt32
            Get
                Return BitConverter.ToUInt32(mBytes, 0)
            End Get
            Set(value As UInt32)
                Dim Result As Byte() = BitConverter.GetBytes(value)
                Array.ConstrainedCopy(Result, 0, mBytes, 0, 4)
            End Set
        End Property
        Property Flags2 As UInt32
            Get
                Return BitConverter.ToUInt32(mBytes, 4)
            End Get
            Set(value As UInt32)
                Dim Result As Byte() = BitConverter.GetBytes(value)
                Array.ConstrainedCopy(Result, 0, mBytes, 4, 4)
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mBytes As Byte()
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
            mBytes = New Byte(15) {}
        End Sub
#End Region

#Region "Update From MAP"
#End Region

#Region "Clone"
        Public Function Clone() As COH_TrickNode
            Dim Result As COH_TrickNode = New COH_TrickNode
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mBytes = mBytes
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Return True
        End Function
#End Region

    End Class
End Namespace
