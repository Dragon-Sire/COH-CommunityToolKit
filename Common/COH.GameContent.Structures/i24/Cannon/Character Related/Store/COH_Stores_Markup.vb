Namespace GameContent.Structures.Store
    Public NotInheritable Class COH_Stores_Markup
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Store"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Department As Int32
            Get
                Return mDepartment
            End Get
            Set(value As Int32)
                mDepartment = value
            End Set
        End Property
        Property Markup As Single
            Get
                Return mMarkup
            End Get
            Set(value As Single)
                mMarkup = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mDepartment As Int32
       Private mMarkup As Single
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
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Stores_Markup
            Dim Result As COH_Stores_Markup = New COH_Stores_Markup
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDepartment = mDepartment
                .mMarkup = mMarkup
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mDepartment)
            CurrentWriter.Write(mMarkup)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDepartment = CurrentReader.ReadInt32
            mMarkup = CurrentReader.ReadSingle
            Return True
        End Function
#End Region

    End Class
End Namespace
