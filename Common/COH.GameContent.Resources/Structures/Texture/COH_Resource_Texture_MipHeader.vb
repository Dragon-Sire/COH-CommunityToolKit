Namespace GameContent.Structures.Resources.Textures
    Public Class COH_Resource_Texture_MipHeader

#Region "Enums"
#End Region

#Region "Properties"
        Property StructSize As Int32
        Property Width As Int32
        Property Height As Int32
        Property Format As Int32
        '//UNKNOWN
        Property AdditionalBytes As Byte()
#End Region

#Region "Create New Instances"
        Public Sub New(ByRef RawBytes As Byte())
            Using CurrentReader As New COH_BinaryReader(New IO.MemoryStream(RawBytes))
                ReadFromStream(CurrentReader)
            End Using
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            ReadFromStream(CurrentReader)
        End Sub
#End Region

#Region "Import/Export"
        Private Function ReadFromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            StructSize = CurrentReader.ReadInt32
            Width = CurrentReader.ReadInt32
            Height = CurrentReader.ReadInt32
            Dim UsedSize As Integer = 32
            If UsedSize = StructSize Then Return True
            '//SecondaryHeader Mips Maybe?
            AdditionalBytes = CurrentReader.ReadBytes(StructSize - UsedSize)
            Return True
        End Function
        Public Function WriteToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(StructSize)
            CurrentWriter.Write(Height)
            CurrentWriter.Write(Width)
            Return True
        End Function
#End Region

    End Class
End Namespace