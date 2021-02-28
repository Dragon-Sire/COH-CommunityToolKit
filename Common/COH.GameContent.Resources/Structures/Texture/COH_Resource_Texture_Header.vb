Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources.Textures
    <TypeConverter(GetType(ExpandableObjectConverter))> Public Class COH_Resource_Texture_Header

#Region "Properties"
        Property HeaderSize As UInt32 '// Number of bytes in header data of file (not sizeof(struct))
        Property File_Size As UInt32 '// Number of bytes in data chunk of file (everything after the header + name + mip = .tga file or .dds file)
        Property Texture_Height As UInt32
        Property Texture_Width As UInt32
        Property TextureOptions As COH_EnumFlags_Texture_Options
        Property Fade1 As Single
        Property Fade2 As Single
        Property Alpha As Byte
        Property ExtentionName As String
        Property FileName As String
        '//UNKNOWN
        Private AdditionalBytes As Byte()
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
        Public Overrides Function ToString() As String
            Return FileName
        End Function
#End Region

#Region "Import/Export"
        Private Function ReadFromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            HeaderSize = CurrentReader.ReadUInt32
            File_Size = CurrentReader.ReadUInt32 '314856
            Texture_Width = CurrentReader.ReadUInt32 '1024
            Texture_Height = CurrentReader.ReadUInt32 '768
            TextureOptions = CurrentReader.ReadUInt32 '65730
            Fade1 = CurrentReader.ReadSingle  '0
            Fade2 = CurrentReader.ReadSingle '0
            Alpha = CurrentReader.ReadByte '0     '29 Bytes
            ExtentionName = CurrentReader.ReadString_LengthFixed_Ascii(3)
            Dim UsedSize As Integer = 32
            If UsedSize = HeaderSize Then Return True
            '//SecondaryHeader Mips Maybe?
            FileName = CurrentReader.ReadString_ZeroEnded_UTF8
            AdditionalBytes = CurrentReader.ReadBytes(HeaderSize - (UsedSize + FileName.Length + 1))
            Return True
        End Function
        Public Function WriteToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(HeaderSize)
            CurrentWriter.Write(File_Size)
            CurrentWriter.Write(Texture_Height)
            CurrentWriter.Write(Texture_Width)
            CurrentWriter.Write(TextureOptions)
            CurrentWriter.Write(Fade1)
            CurrentWriter.Write(Fade2)
            CurrentWriter.Write(Alpha)
            CurrentWriter.WriteString_NoMarker_Ascii(ExtentionName)
            Return True
        End Function
#End Region

    End Class
End Namespace