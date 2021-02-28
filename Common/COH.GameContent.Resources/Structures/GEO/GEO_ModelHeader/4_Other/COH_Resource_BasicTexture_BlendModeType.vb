Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources
    Public Class COH_Resource_BasicTexture_BlendModeType

#Region "Private Properties"
        Property Value As UInt32
            Get
                Return BitConverter.ToUInt32(Bytes, 0)
            End Get
            Set(value As UInt32)
                Bytes = BitConverter.GetBytes(value)
            End Set
        End Property
        Property Shader As COH_Enum_BlendModeShader
            Get
                Return BitConverter.ToUInt16(Bytes, 0)
            End Get
            Set(value As COH_Enum_BlendModeShader)
                Dim Temp = BitConverter.GetBytes(value)
                Bytes(0) = Temp(0)
                Bytes(1) = Temp(1)
            End Set
        End Property
        Property BlendBits As COH_EnumFlags_Texture_BlendModeBits
            Get
                Return BitConverter.ToUInt16(Bytes, 2)
            End Get
            Set(value As COH_EnumFlags_Texture_BlendModeBits)
                Dim Temp = BitConverter.GetBytes(value)
                Bytes(2) = Temp(0)
                Bytes(3) = Temp(1)
            End Set
        End Property
        Private Bytes() As Byte
#End Region

#Region "Create New Instances"
        Public Sub New(Version As Integer, ByRef RawBytes As Byte())
            MyBase.New
            Update_FromBytes(Version, RawBytes)
        End Sub
#End Region

#Region "Update"
        Private Sub Update_FromBytes(Version As Integer, RawBytes As Byte())
            Dim Stream As New IO.MemoryStream(RawBytes)
            Using CurrentReader As New COH_BinaryReader(Stream)

            End Using
        End Sub
#End Region

    End Class
End Namespace