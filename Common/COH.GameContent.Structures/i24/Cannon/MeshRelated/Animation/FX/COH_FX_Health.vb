Namespace GameContent.Structures.Animation.FX
    Public NotInheritable Class COH_FX_Health
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Health"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Range As COH_Struct_Vector2
            Get
                Return mRange
            End Get
            Set(value As COH_Struct_Vector2)
                mRange = value
            End Set
        End Property
        Property LibraryPiece As String()
            Get
                Return mLibraryPiece
            End Get
            Set(value As String())
                mLibraryPiece = value
            End Set
        End Property
        Property OneShotFx As String()
            Get
                Return mOneShotFx
            End Get
            Set(value As String())
                mOneShotFx = value
            End Set
        End Property
        Property ContinuingFx As String()
            Get
                Return mContinuingFx
            End Get
            Set(value As String())
                mContinuingFx = value
            End Set
        End Property
        Property Flags As COH_Enum_HealthFX
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_HealthFX)
                mFlags = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mRange As COH_Struct_Vector2
       Private mLibraryPiece As String()
       Private mOneShotFx As String()
       Private mContinuingFx As String()
       Private mFlags As COH_Enum_HealthFX
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
            mRange = New COH_Struct_Vector2
            mLibraryPiece = New String() {}
            mOneShotFx = New String() {}
            mContinuingFx = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_FX_Health
            Dim Result As COH_FX_Health = New COH_FX_Health
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mRange = mRange
                .mLibraryPiece = mLibraryPiece.CloneTheStrings
                .mOneShotFx = mOneShotFx.CloneTheStrings
                .mContinuingFx = mContinuingFx.CloneTheStrings
                .mFlags = mFlags
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_Vector2(mRange)
            CurrentWriter.Write_CrypticS_StringArray(mLibraryPiece)
            CurrentWriter.Write_CrypticS_StringArray(mOneShotFx)
            CurrentWriter.Write_CrypticS_StringArray(mContinuingFx)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mRange = CurrentReader.Read_CrypticS_Vector2
            mLibraryPiece = CurrentReader.Read_CrypticS_StringArray()
            mOneShotFx = CurrentReader.Read_CrypticS_StringArray()
            mContinuingFx = CurrentReader.Read_CrypticS_StringArray()
            mFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace
