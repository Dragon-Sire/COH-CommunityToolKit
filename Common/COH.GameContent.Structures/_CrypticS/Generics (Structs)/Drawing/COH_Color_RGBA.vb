Imports System.Xml.Serialization

Namespace GameContent.Structures.[Shared].Drawing
    Public NotInheritable Class COH_Color_RGBA
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return String.Format("{0},{1},{2} Alpha = {3}", New Object(3) {Red, Green, Blue, Alpha})
            End Get
        End Property
#End Region

#Region "Properties"
        <XmlAttribute> Property Red As UInteger
            Get
                Return mRed
            End Get
            Set(value As UInteger)
                mRed = value
            End Set
        End Property
        <XmlAttribute> Property Green As UInteger
            Get
                Return mGreen
            End Get
            Set(value As UInteger)
                mGreen = value
            End Set
        End Property
        <XmlAttribute> Property Blue As UInteger
            Get
                Return mBlue
            End Get
            Set(value As UInteger)
                mBlue = value
            End Set
        End Property
        <XmlAttribute> Property Alpha As UInteger
            Get
                Return mAlpha
            End Get
            Set(value As UInteger)
                mAlpha = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mRed As UInteger
       Private mGreen As UInteger
       Private mBlue As UInteger
       Private mAlpha As UInteger
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(Red As UInteger, Green As UInteger, Blue As UInteger, Alpha As UInteger)
            MyBase.New
            mRed = Red
            mGreen = Green
            mBlue = Blue
            mAlpha = Alpha
        End Sub
        Public Sub New(TheColors As UInt32())
            MyBase.New
            If TheColors Is Nothing OrElse TheColors.Count = 0 Then Exit Sub
            If TheColors.Count >= 1 Then mRed = TheColors(0)
            If TheColors.Count >= 2 Then mGreen = TheColors(1)
            If TheColors.Count >= 3 Then mBlue = TheColors(2)
            If TheColors.Count >= 4 Then mAlpha = TheColors(3)
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
            mAlpha = 0
            mRed = 0
            mGreen = 0
            mBlue = 0
        End Sub
#End Region

#Region "Convert"
        Public Function Convert_To_Color() As System.Drawing.Color
            Return System.Drawing.Color.FromArgb(mAlpha, mRed, mGreen, mBlue)
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_Color_RGBA
            Dim Result As COH_Color_RGBA = New COH_Color_RGBA
            'MyBase.CloneTo(Result)
            With Result
                .mRed = mRed
                .mGreen = mGreen
                .mBlue = mBlue
                .mAlpha = mAlpha
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mRed)
            CurrentWriter.Write(mGreen)
            CurrentWriter.Write(mBlue)
            CurrentWriter.Write(mAlpha)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mRed = CurrentReader.ReadUInt32
            mGreen = CurrentReader.ReadUInt32
            mBlue = CurrentReader.ReadUInt32
            mAlpha = CurrentReader.ReadUInt32
            Return True
        End Function
#End Region
    End Class
End Namespace
