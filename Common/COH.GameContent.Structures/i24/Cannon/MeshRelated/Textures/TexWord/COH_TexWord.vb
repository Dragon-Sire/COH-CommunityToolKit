Namespace GameContent.Structures.Textures
    Public NotInheritable Class COH_TextWord
        Inherits COH_FileStructure

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
        Property Size As COH_TextWord_Layer_Size ' No Default Defined()
            Get
                Return mSize
            End Get
            Set(value As COH_TextWord_Layer_Size) ' No Default Defined())
                mSize = value
            End Set
        End Property
        Property Layer As COH_TextWord_Layer()
            Get
                Return mLayer
            End Get
            Set(value As COH_TextWord_Layer())
                mLayer = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mSize As COH_TextWord_Layer_Size ' No Default Defined()
       Private mLayer As COH_TextWord_Layer()
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
            mName = String.Empty
            mSize = New COH_TextWord_Layer_Size
            mLayer = New COH_TextWord_Layer() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_TextWord
            Dim Result As COH_TextWord = New COH_TextWord
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mSize = mSize.Clone
                .mLayer = New COH_TextWord_Layer(mLayer.Count - 1) {}
                For X = 0 To mLayer.Count - 1
                    .mLayer(X) = mLayer(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mTexWord)
            CurrentWriter.Write_CrypticS_String(mName)
            If CurrentWriter.Write_CrypticS_Struct(mSize) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mLayer) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mTexWord = 
            mName = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_Struct(GetType(COH_TextWord_Layer_Size), mSize) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_TextWord_Layer), mLayer) = False Then Return False
            Return True
End Function
#End Region

    End Class
End Namespace
