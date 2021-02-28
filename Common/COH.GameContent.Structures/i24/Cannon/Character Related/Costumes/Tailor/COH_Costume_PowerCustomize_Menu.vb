Namespace GameContent.Structures.Costumes.Tailor
    Public NotInheritable Class COH_Costum_PowerCustomize_Menu
        Inherits COH_FileStructure

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
        Property Sets As String()
            Get
                Return mSets
            End Get
            Set(value As String())
                mSets = value
            End Set
        End Property
        Property HideIf As String
            Get
                Return mHideIf
            End Get
            Set(value As String)
                mHideIf = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mCategory As String
       Private mSets As String()
       Private mHideIf As String
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
            mSets = New String() {}
            mHideIf = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Costum_PowerCustomize_Menu
            Dim Result As COH_Costum_PowerCustomize_Menu = New COH_Costum_PowerCustomize_Menu
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCategory = String.Copy(mCategory)
                .mSets = mSets.CloneTheStrings
                .mHideIf = String.Copy(mHideIf)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mCategory)
            CurrentWriter.Write_CrypticS_StringArray(mSets)
            CurrentWriter.Write_CrypticS_String(mHideIf)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mCategory = CurrentReader.Read_CrypticS_String
            mSets = CurrentReader.Read_CrypticS_StringArray()
            mHideIf = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
