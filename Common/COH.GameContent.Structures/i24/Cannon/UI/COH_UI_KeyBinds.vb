Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_UI_KeyBinds
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
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
        Property KeyBind As COH_UI_KeyBind()
            Get
                Return mKeyBind
            End Get
            Set(value As COH_UI_KeyBind())
                mKeyBind = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mDisplayName As String
       Private mName As String
       Private mKeyBind As COH_UI_KeyBind()
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
            mDisplayName = String.Empty
            mName = String.Empty
            mKeyBind = New COH_UI_KeyBind() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_UI_KeyBinds
            Dim Result As COH_UI_KeyBinds = New COH_UI_KeyBinds
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayName = String.Copy(mDisplayName)
                .mName = String.Copy(mName)
                .mKeyBind = New COH_UI_KeyBind(mKeyBind.Count - 1) {}
                For X = 0 To mKeyBind.Count - 1
                    .mKeyBind(X) = mKeyBind(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_String(mName)
            If CurrentWriter.Write_CrypticS_StructArray(mKeyBind) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDisplayName = CurrentReader.Read_CrypticS_String
            mName = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_UI_KeyBind), mKeyBind) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
