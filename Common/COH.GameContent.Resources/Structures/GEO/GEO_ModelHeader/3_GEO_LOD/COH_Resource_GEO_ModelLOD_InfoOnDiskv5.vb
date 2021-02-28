Namespace GameContent.Structures.Resources.GEO
    Public NotInheritable Class COH_Resource_GEO_ModelLOD_OnDiskv5
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Model LOD on Disk v5"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Number_Auto_Used As Integer
            Get
                Return mNumberLOD
            End Get
            Set(value As Integer)
                mNumberLOD = value
            End Set
        End Property
        Property LOD As COH_Resource_GEO_AutoLOD_OnDiskv5()
            Get
                Return mLods
            End Get
            Set(value As COH_Resource_GEO_AutoLOD_OnDiskv5())
                mLods = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mNumberLOD As Integer
       Private mLods As COH_Resource_GEO_AutoLOD_OnDiskv5()
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
            mNumberLOD = 1
            mLods = New COH_Resource_GEO_AutoLOD_OnDiskv5(5) {}
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Resource_GEO_ModelLOD_OnDiskv5
            Dim Result As COH_Resource_GEO_ModelLOD_OnDiskv5 = New COH_Resource_GEO_ModelLOD_OnDiskv5
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mNumberLOD = mNumberLOD
                .mLods = New COH_Resource_GEO_AutoLOD_OnDiskv5(5) {}
                For x = 0 To 5
                    .mLods(x) = .mLods(x).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
    Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mNumberLOD)
            For X = 0 To 5
                mLods(X).Export_To_Stream(CurrentWriter)
            Next
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mNumberLOD = CurrentReader.ReadInt32
            mLods = New COH_Resource_GEO_AutoLOD_OnDiskv5(5) {}
            For X = 0 To 5
                Dim Temp = New COH_Resource_GEO_AutoLOD_OnDiskv5(CurrentReader)
                mLods(X) = Temp
            Next
            Return True
        End Function
#End Region

    End Class
End Namespace