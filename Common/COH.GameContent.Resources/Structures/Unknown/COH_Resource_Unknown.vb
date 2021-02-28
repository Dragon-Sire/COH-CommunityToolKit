Namespace GameContent.Structures.Resources.Other
    Public Class COH_Resource_Unknown
        Inherits COH_FileStructure

#Region "Properties"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Unknown"
            End Get
        End Property
#End Region

#Region "Private Properties"
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
        Public Overrides Function EntryType() As COH_Supported_ContentType
            Return COH_Supported_ContentType.Unknown
        End Function
#End Region

#Region "Update"
        Public Sub Update_FromBytes(RawBytes As Byte())
            mRawBytes = RawBytes
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_Unknown
            Dim Result As COH_Resource_Unknown = New COH_Resource_Unknown
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