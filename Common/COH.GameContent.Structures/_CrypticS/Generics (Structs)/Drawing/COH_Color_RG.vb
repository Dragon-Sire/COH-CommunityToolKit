Imports System.Xml.Serialization

Namespace GameContent.Structures.[Shared].Drawing
    Public NotInheritable Class COH_Color_RG
        Inherits COH_FileStructure

#Region "Enum"
        Public Enum InternalVerions
            Standard = 0
        End Enum
#End Region

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return String.Format("{0},{1}", New Object(1) {Red, Green})
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
#End Region

#Region "Private Properties"
       Private mRed As UInteger
       Private mGreen As UInteger
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(Red As UInteger, Green As UInteger)
            MyBase.New
            mRed = Red
            mGreen = Green
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
            Select Case Version
                Case InternalVerions.Standard
                    mRed = mGreen = 0
            End Select
        End Sub
#End Region

#Region "Convert"
        Public Function Convert_To_Color() As System.Drawing.Color
            Return System.Drawing.Color.FromArgb(mRed, mGreen, 0)
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_Color_RG
            Dim Result As COH_Color_RG = New COH_Color_RG
            'MyBase.CloneTo(Result)
            With Result
                .mRed = mRed
                .mGreen = mGreen
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mRed)
            CurrentWriter.Write(mGreen)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mRed = CurrentReader.ReadUInt32
            mGreen = CurrentReader.ReadUInt32
            Return True
        End Function
#End Region
    End Class
End Namespace
