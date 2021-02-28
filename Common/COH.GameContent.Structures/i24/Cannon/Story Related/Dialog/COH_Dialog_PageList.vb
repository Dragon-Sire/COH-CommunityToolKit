Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_DialogPageList
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
        Property List As String()
            Get
                Return mList
            End Get
            Set(value As String())
                mList = value
            End Set
        End Property
        Property Fallback As String
            Get
                Return mFallback
            End Get
            Set(value As String)
                mFallback = value
            End Set
        End Property
        Property Requires As String()
            Get
                Return mRequires
            End Get
            Set(value As String())
                mRequires = value
            End Set
        End Property
        Property Flags As COH_Enum_DialogPage_ListFlags
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_DialogPage_ListFlags)
                mFlags = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mList As String()
       Private mFallback As String
       Private mRequires As String()
       Private mFlags As COH_Enum_DialogPage_ListFlags
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0)
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
            mName = String.Empty
            mList = New String() {}
            mFallback = String.Empty
            mRequires = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_DialogPageList
            Dim Result As COH_DialogPageList = New COH_DialogPageList
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mList = mList.CloneTheStrings
                .mFallback = String.Copy(mFallback)
                .mRequires = mRequires.CloneTheStrings
                .mFlags = mFlags
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_StringArray(mList)
            CurrentWriter.Write_CrypticS_String(mFallback)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mList = CurrentReader.Read_CrypticS_StringArray()
            mFallback = CurrentReader.Read_CrypticS_String
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace
