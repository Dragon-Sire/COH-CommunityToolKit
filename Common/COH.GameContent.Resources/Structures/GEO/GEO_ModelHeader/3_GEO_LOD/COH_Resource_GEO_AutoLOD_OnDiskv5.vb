Imports COH.CodeManagement.Enums
Imports COH.GameContent.Structures.Enums

Namespace GameContent.Structures.Resources.GEO
    Public NotInheritable Class COH_Resource_GEO_AutoLOD_OnDiskv5
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Auto LOD"
            End Get
        End Property
#End Region

#Region "Properties"
        Property MaxError As Single
            Get
                Return mMaxError
            End Get
            Set(value As Single)
                mMaxError = value
            End Set
        End Property
        Property LodNearFade As Single
            Get
                Return mLodNearFade
            End Get
            Set(value As Single)
                mLodNearFade = value
            End Set
        End Property
        Property LodNear As Single
            Get
                Return mLodNear
            End Get
            Set(value As Single)
                mLodNear = value
            End Set
        End Property
        Property LodFar As Single
            Get
                Return mLodFar
            End Get
            Set(value As Single)
                mLodFar = value
            End Set
        End Property
        Property LodFarFade As Single
            Get
                Return mLodFarFade
            End Get
            Set(value As Single)
                mLodFarFade = value
            End Set
        End Property
        Property LodFlags As COH_Enum_AutoLODFlags
            Get
                Return mLodFlags
            End Get
            Set(value As COH_Enum_AutoLODFlags)
                mLodFlags = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mMaxError As Single
        Private mLodNear As Single
        Private mLodFar As Single
        Private mLodNearFade As Single
        Private mLodFarFade As Single
        Private mLodFlags As COH_Enum_AutoLODFlags
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
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mMaxError = 0
            mLodNearFade = 0
            mLodNear = 0
            mLodFar = 0
            mLodFarFade = 0
            mLodFlags = COH_Enum_AutoLODFlags.None
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_GEO_AutoLOD_OnDiskv5
            Dim Result As COH_Resource_GEO_AutoLOD_OnDiskv5 = New COH_Resource_GEO_AutoLOD_OnDiskv5
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mMaxError = mMaxError
                .mLodNearFade = mLodNearFade
                .mLodNear = mLodNear
                .mLodFar = mLodFar
                .mLodFarFade = mLodFarFade
                .mLodFlags = mLodFlags
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mMaxError)
            CurrentWriter.Write(mLodNearFade)
            CurrentWriter.Write(mLodNear)
            CurrentWriter.Write(mLodFar)
            CurrentWriter.Write(mLodFarFade)
            CurrentWriter.Write_CrypticS_Flags(mLodFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mMaxError = CurrentReader.ReadSingle
            mLodNearFade = CurrentReader.ReadSingle
            mLodNear = CurrentReader.ReadSingle
            mLodFar = CurrentReader.ReadSingle
            mLodFarFade = CurrentReader.ReadSingle
            mLodFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace