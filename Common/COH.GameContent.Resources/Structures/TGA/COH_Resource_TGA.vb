Imports System.Drawing

Namespace GameContent.Structures.Resources.Textures
    Public Class COH_Resource_TGA
        Inherits COH_FileStructure

#Region "Properties"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "TGA"
            End Get
        End Property
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
#End Region

#Region "Private Properties"
       Private mFilePath As String
       Private mRawBytes As Byte() = Nothing
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
            Return "TGA"
        End Function
        Public Overrides Function EntryType() As COH_Supported_ContentType
            Return COH_Supported_ContentType.Resource_TGA
        End Function
#End Region

#Region "Update"
        Public Sub Update_FromBytes(RawBytes As Byte())
            mRawBytes = RawBytes
        End Sub
#End Region

#Region "Process Image"
        Public Function Extract_Resource_Texture() As Bitmap
            Dim Format As Imaging.PixelFormat
            Dim Image = Global.Pfim.Pfim.FromStream(New IO.MemoryStream(mRawBytes))
            Select Case Image.Format
                Case Pfim.ImageFormat.Rgb24
                    Format = Imaging.PixelFormat.Format24bppRgb
                Case Pfim.ImageFormat.Rgba32
                    Format = Imaging.PixelFormat.Format32bppArgb
                Case Else
                    ShowErrorOccured("TGA Image Format Different - " & Format.ToString)
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
        Public Function Clone() As COH_Resource_TGA
            Dim Result As COH_Resource_TGA = New COH_Resource_TGA
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mRawBytes = New Byte(mRawBytes.Length - 1) {}
                Array.Copy(mRawBytes, .mRawBytes, mRawBytes.Length)
            End With
            Return Result
        End Function
#End Region

#Region "Import /Export"
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Throw New NotImplementedException()
        End Function

        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Settings.Option_SelectedFormat = COH_StreamFormat.Binary Then 'DDS
                CurrentWriter.Write(mRawBytes)
            ElseIf CurrentWriter.Settings.Option_SelectedFormat = COH_StreamFormat.CrypticS_BINFormat Then 'Texture
            Else
                Return MyBase.Export_To_Stream(CurrentWriter)
            End If
        End Function
#End Region

    End Class
End Namespace