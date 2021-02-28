Imports System.Drawing

Namespace GameContent.Structures.Resources.BIN
    Public Class COH_Resource_BIN
        Inherits COH_FileStructure

        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "BIN"
            End Get
        End Property

#Region "Properties"
        Public ReadOnly Property RawBytes As Byte()
            Get
                Return mRawBytes
            End Get
        End Property
#End Region

#Region "Private Properties"
       Private mRawBytes As Byte() = Nothing
       Private mEntryType As COH_Supported_ContentType
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
            mEntryType = COH_Supported_ContentType.Resource_BIN_CrypticS
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
        End Sub
        Public Overrides Function EntryType() As COH_Supported_ContentType
            Return mEntryType
        End Function
#End Region

#Region "Update"
        Public Sub Update_FromBytes(RawBytes As Byte())
            mRawBytes = RawBytes
            mEntryType = Identify_BinType()
        End Sub
        Private Function Identify_BinType() As COH_Supported_ContentType
            If System.Text.Encoding.ASCII.GetString(mRawBytes, 0, 8).Contains("CrypticS") Then
                Return COH_Supported_ContentType.Resource_BIN_CrypticS
            ElseIf BitConverter.ToUInt32(mRawBytes, 0) = 20090521 Then
                Return COH_Supported_ContentType.Resource_BIN_MessageStore
            Else
                Return COH_Supported_ContentType.Unknown
            End If
        End Function
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_BIN
            Dim Result As COH_Resource_BIN = New COH_Resource_BIN
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mRawBytes = New Byte(mRawBytes.Length - 1) {}
                Array.Copy(mRawBytes, .mRawBytes, mRawBytes.Length)
            End With
            Return Result
        End Function

        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Throw New NotImplementedException()
        End Function

    Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
#End Region
    End Class
End Namespace