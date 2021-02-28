Namespace GameContent.Structures.Powers
    Public Class COH_PowerVar
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Index As Int32
            Get
                Return mIndex
            End Get
            Set(value As Int32)
                mIndex = value
            End Set
        End Property
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property Min As Single
            Get
                Return mMin
            End Get
            Set(value As Single)
                mMin = value
            End Set
        End Property
        Property Max As Single
            Get
                Return mMax
            End Get
            Set(value As Single)
                mMax = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mIndex As Int32
       Private mName As String
       Private mMin As Single
       Private mMax As Single
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mIndex = 0
            mName = String.Empty
            mMin = 0
            mMax = 0
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_PowerVar
            Dim Result As COH_PowerVar = New COH_PowerVar
            With Result
                .mIndex = mIndex
                .mName = String.Copy(mName)
                .mMin = mMin
                .mMax = mMax
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(Index)
            CurrentWriter.Write_CrypticS_String(Name)
            CurrentWriter.Write(Min)
            CurrentWriter.Write(Max)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Index = CurrentReader.ReadInt32
            Name = CurrentReader.Read_CrypticS_String
            Min = CurrentReader.ReadSingle
            Max = CurrentReader.ReadSingle
            Return True
        End Function
#End Region
    End Class
End Namespace