Imports System.Drawing
Imports COH.CodeManagement.Enums
Imports COH.GameContent.Structures.CodeManagement.Enums

Namespace GameContent.Structures.Resources.Textures
    Public Class COH_Resource_Texture
        Inherits COH_FileStructure

        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "DDS"
            End Get
        End Property

#Region "Properties"
        ReadOnly Property FileName As String
            Get
                If String.IsNullOrEmpty(mFilePath) = True Then Return ""
                Return IO.Path.GetFileName(mFilePath)
            End Get
        End Property
        ReadOnly Property FileName_NoExt As String
            Get
                If String.IsNullOrEmpty(mFilePath) = True Then Return ""
                Return IO.Path.GetFileNameWithoutExtension(mFilePath)
            End Get
        End Property
        Property ImageID As COH_PiggEnum_Texture_ResourceType
            Get
                Return mID
            End Get
            Set(value As COH_PiggEnum_Texture_ResourceType)
                mID = value
            End Set
        End Property
        Property Header As COH_Resource_Texture_Header
            Get
                Return mHeader
            End Get
            Set(value As COH_Resource_Texture_Header)
                mHeader = value
            End Set
        End Property
        Property ImageBytes As Byte()
            Get
                Return mImageBytes
            End Get
            Set(value As Byte())
                mImageBytes = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mFilePath As String
        Private mID As COH_PiggEnum_Texture_ResourceType = Nothing
        Private mHeader As COH_Resource_Texture_Header
        Private mImageBytes As Byte() = Nothing
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
        End Sub
        Public Overrides Function Default_BinaryExtention() As String
            Return "DDS"
        End Function
        Public Overrides Function EntryType() As COH_Supported_ContentType
            Return COH_Supported_ContentType.Resource_Texture
        End Function
#End Region

#Region "Update"
        Public Sub Update_FromBytes(RawBytes As Byte()) '//SHOULD BE REPLACED AND MOVE THROUGH BUFFER METHOD 
            mHeader = New COH_Resource_Texture_Header(RawBytes)
            mImageBytes = New Byte((RawBytes.Length - mHeader.HeaderSize) - 1) {}
            Array.ConstrainedCopy(RawBytes, mHeader.HeaderSize, mImageBytes, 0, RawBytes.Length - mHeader.HeaderSize)
            mID = BitConverter.ToUInt32(mImageBytes, 0)
        End Sub
#End Region

#Region "Process Image"
        Public Function Extract_Resource_Texture() As Bitmap
            If mID = 0 Then Return Nothing
            Select Case mID
                Case COH_PiggEnum_Texture_ResourceType.DDS
                    Return Extract_Resource_Texture_DDS()
                Case COH_PiggEnum_Texture_ResourceType.JPG
                    Return Extract_Resource_Texture_JPG()
                Case Else
                    ShowErrorOccured("DDS Image DIFFERENT - " & mID.ToString)
            End Select
            Return Nothing
        End Function
        Private Function Extract_Resource_Texture_JPG() As Image
            Return Image.FromStream(New IO.MemoryStream(mImageBytes))
        End Function
        Private Function Extract_Resource_Texture_DDS() As Bitmap
            Dim Format As Imaging.PixelFormat
            Dim Image = Global.Pfim.Pfim.FromStream(New IO.MemoryStream(mImageBytes))
            Select Case Image.Format
                Case Pfim.ImageFormat.Rgb24
                    Format = Imaging.PixelFormat.Format24bppRgb
                Case Pfim.ImageFormat.Rgba32
                    Format = Imaging.PixelFormat.Format32bppArgb
                Case Else
                    ShowErrorOccured("DDS Image Format Different - " & Format.ToString)
            End Select
            Dim handle = Runtime.InteropServices.GCHandle.Alloc(Image.Data, Runtime.InteropServices.GCHandleType.Pinned)
            Try
                Dim data = Runtime.InteropServices.Marshal.UnsafeAddrOfPinnedArrayElement(Image.Data, 0)
                Dim bitmap = New Bitmap(Image.Width, Image.Height, Image.Stride, Format, data)
                Return bitmap
            Finally
                handle.Free()
            End Try
            Return Nothing
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_Texture
            Dim Result As COH_Resource_Texture = New COH_Resource_Texture
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
            End With
            Return Result
        End Function
#End Region

#Region "Import/Export"
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mHeader = New COH_Resource_Texture_Header(CurrentReader)
            mImageBytes = CurrentReader.ReadBytes(CurrentReader.RemainingBytes)
            mID = BitConverter.ToUInt32(mImageBytes, 0)
            Return True
        End Function
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Settings.Option_SelectedFormat = COH_StreamFormat.Binary Then 'DDS
                CurrentWriter.Write(mImageBytes)
            ElseIf CurrentWriter.Settings.Option_SelectedFormat = COH_StreamFormat.CrypticS_BINFormat Then 'Texture
            Else
                Return MyBase.Export_To_Stream(CurrentWriter)
            End If
        End Function
#End Region
    End Class
End Namespace