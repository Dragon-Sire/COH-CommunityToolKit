﻿Namespace Structures.GEO
    Public Class COH_Resource_GEO_Portal
        Inherits COH_Struct

#Region "Proporties - Identifier"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Portal"
            End Get
        End Property
#End Region

#Region "Properties"
        Property PortalPostion As Vector3
        Property Min As Vector3
        Property Max As Vector3
        Property Normal As Vector3
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
#End Region

#Region "Import / Export"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            PortalPostion = CurrentReader.Read_CrypticS_Vector3
            Min = CurrentReader.Read_CrypticS_Vector3
            Max = CurrentReader.Read_CrypticS_Vector3
            Normal = CurrentReader.Read_CrypticS_Vector3
            Return True
        End Function
#End Region
    End Class
End Namespace