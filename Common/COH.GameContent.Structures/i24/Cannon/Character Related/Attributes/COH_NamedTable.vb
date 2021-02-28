Namespace GameContent.Structures.[Shared]
    Public Class COH_NamedTable
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property Values As Single()
            Get
                Return mValues
            End Get
            Set(value As Single())
                mValues = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mValues As Single()
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
            mName = String.Empty
            mValues = New Single() {}
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_NamedTable
            Dim Result As COH_NamedTable = New COH_NamedTable
            With Result
                .mName = String.Copy(mName)
                .mValues = New Single(mValues.Count - 1) {} : mValues.CopyTo(.mValues, 0)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(Name)
            CurrentWriter.Write_CrypticS_SingleArray(Values)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Name = CurrentReader.Read_CrypticS_String
            Values = CurrentReader.Read_CrypticS_SingleArray()
            Return True
        End Function
#End Region
    End Class
End Namespace