Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_CityZone
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
        Property Icon As String
            Get
                Return mIcon
            End Get
            Set(value As String)
                mIcon = value
            End Set
        End Property
        Property Location As COH_Struct_Vector2
            Get
                Return mLocation
            End Get
            Set(value As COH_Struct_Vector2)
                mLocation = value
            End Set
        End Property
        Property TextLocation As COH_Struct_Vector2
            Get
                Return mTextLocation
            End Get
            Set(value As COH_Struct_Vector2)
                mTextLocation = value
            End Set
        End Property
        Property Hide As Int32
            Get
                Return mHide
            End Get
            Set(value As Int32)
                mHide = value
            End Set
        End Property
        Property City As COH_Enum_City
            Get
                Return mCity
            End Get
            Set(value As COH_Enum_City)
                mCity = value
            End Set
        End Property
        Property TeamArea As COH_Enum_TeamArea
            Get
                Return mTeamArea
            End Get
            Set(value As COH_Enum_TeamArea)
                mTeamArea = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mIcon As String
       Private mLocation As COH_Struct_Vector2
       Private mTextLocation As COH_Struct_Vector2
       Private mHide As Int32
       Private mCity As COH_Enum_City
       Private mTeamArea As COH_Enum_TeamArea
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
            mIcon = String.Empty
            mLocation = New COH_Struct_Vector2()
            mTextLocation = New COH_Struct_Vector2()
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CityZone
            Dim Result As COH_CityZone = New COH_CityZone
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mIcon = String.Copy(mIcon)
                .mLocation = mLocation
                .mTextLocation = mTextLocation
                .mHide = mHide
                .mCity = mCity
                .mTeamArea = mTeamArea
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mIcon)
            CurrentWriter.Write_CrypticS_Vector2(mLocation)
            CurrentWriter.Write_CrypticS_Vector2(mTextLocation)
            CurrentWriter.Write(mHide)
            CurrentWriter.Write(mCity)
            CurrentWriter.Write(mTeamArea)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mIcon = CurrentReader.Read_CrypticS_String
            mLocation = CurrentReader.Read_CrypticS_Vector2
            mTextLocation = CurrentReader.Read_CrypticS_Vector2
            mHide = CurrentReader.ReadInt32
            mCity = CurrentReader.ReadInt32
            mTeamArea = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
