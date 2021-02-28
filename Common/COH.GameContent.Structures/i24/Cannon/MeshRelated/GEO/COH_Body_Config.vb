Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_Body_Config
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return DisplayName
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
        Property BodyType As String
            Get
                Return mBodyType
            End Get
            Set(value As String)
                mBodyType = value
            End Set
        End Property
        Property BodyBuild As String
            Get
                Return mBuild
            End Get
            Set(value As String)
                mBuild = value
            End Set
        End Property
        Property Scales As COH_Body_Scales
            Get
                Return mScales
            End Get
            Set(value As COH_Body_Scales)
                mScales = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mDisplayName As String
       Private mBodyType As String
       Private mBuild As String
       Private mScales As COH_Body_Scales
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
            mBodyType = String.Empty
            mBuild = String.Empty
            mScales = New COH_Body_Scales()
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Body_Config
            Dim Result As COH_Body_Config = New COH_Body_Config
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayName = String.Copy(mDisplayName)
                .mBodyType = String.Copy(mBodyType)
                .mBuild = String.Copy(mBuild)
                .mScales = mScales
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_String(mBodyType)
            CurrentWriter.Write_CrypticS_String(mBuild)
            If CurrentWriter.Write_CrypticS_Struct(mScales) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDisplayName = CurrentReader.Read_CrypticS_String
            mBodyType = CurrentReader.Read_CrypticS_String
            mBuild = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_Struct(GetType(COH_Body_Scales), mScales) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
