Namespace GameContent.Structures.World
    Public NotInheritable Class COH_ObjectDetail_CategoryLimit
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Category
            End Get
        End Property
#End Region

#Region "Properties"
        Property Category As String
            Get
                Return mCategory
            End Get
            Set(value As String)
                mCategory = value
            End Set
        End Property
        Property Limit As Int32
            Get
                Return mLimit
            End Get
            Set(value As Int32)
                mLimit = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mCategory As String
       Private mLimit As Int32
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
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
            mCategory = String.Empty
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ObjectDetail_CategoryLimit
            Dim Result As COH_ObjectDetail_CategoryLimit = New COH_ObjectDetail_CategoryLimit
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCategory = String.Copy(mCategory)
                .mLimit = mLimit
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mCategory)
            CurrentWriter.Write(mLimit)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mCategory = CurrentReader.Read_CrypticS_String
            mLimit = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
