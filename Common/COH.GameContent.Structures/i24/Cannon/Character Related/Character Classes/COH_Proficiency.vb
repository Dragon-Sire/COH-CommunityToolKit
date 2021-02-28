Namespace GameContent.Structures.Characters
    Public NotInheritable Class COH_Proficiency
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
        Property UI_Details As UI.COH_UI_Widget
            Get
                Return mUI_Details
            End Get
            Set(value As UI.COH_UI_Widget)
                mUI_Details = value
            End Set
        End Property
        Property Origin As COH_Enum_Origin
            Get
                Return mOrigin
            End Get
            Set(value As COH_Enum_Origin)
                mOrigin = value
            End Set
        End Property
        Property Rarity As COH_Enum_SalvageRarity
            Get
                Return mRarity
            End Get
            Set(value As COH_Enum_SalvageRarity)
                mRarity = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mUI_Details As UI.COH_UI_Widget
       Private mOrigin As COH_Enum_Origin
       Private mRarity As COH_Enum_SalvageRarity
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
            mUI_Details = New UI.COH_UI_Widget
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            '//mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Proficiency
            Dim Result As COH_Proficiency = New COH_Proficiency
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mUI_Details = mUI_Details.Clone
                .mOrigin = mOrigin
                .mRarity = mRarity
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            mUI_Details.Export_To_Stream(CurrentWriter)
            CurrentWriter.Write(CInt(mOrigin))
            CurrentWriter.Write(CInt(mRarity))
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mUI_Details = New UI.COH_UI_Widget(CurrentReader)
            mOrigin = CurrentReader.ReadInt32
            mRarity = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
