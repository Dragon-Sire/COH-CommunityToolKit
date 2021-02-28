Imports COH.CodeManagement.Enums

Namespace GameContent.Structures.Resources.Anim
    Public Class COH_Skeleton_Hierarchy_BoneLink
        Inherits COH_FileStructure

#Region "Properties"
        <Category("_ProjectFile")> Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return ID
            End Get
        End Property
        <Xml.Serialization.XmlAttribute> Property ID As GEO_Enums_MESH_BoneId
        <Xml.Serialization.XmlAttribute> Property Child As Integer '//Enums.GEO_Enums_MESH_BoneId
        <Xml.Serialization.XmlAttribute> Property [Next] As Integer '//Enums.GEO_Enums_MESH_BoneId
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version, BuildType)
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
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Skeleton_Hierarchy_BoneLink
            Dim Result As COH_Skeleton_Hierarchy_BoneLink = New COH_Skeleton_Hierarchy_BoneLink
            'MyBase.CloneTo(Result)
            With Result
                .ID = ID
                .Child = Child
                .Next = [Next]
            End With
            Return Result
        End Function
#End Region

#Region "Read/Write"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Throw New NotImplementedException()
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Child = CurrentReader.ReadInt32
            [Next] = CurrentReader.ReadInt32
            ID = CurrentReader.ReadInt32
            Return True
        End Function
#End Region
    End Class
End Namespace
