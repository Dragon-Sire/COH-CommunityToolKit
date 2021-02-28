Namespace GameContent.Structures.Enemies
    Public Class COH_EnemyVillainGroup
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        <Category("Display")> Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property DisplaySingluar As String
            Get
                Return mDisplaySingluar
            End Get
            Set(value As String)
                mDisplaySingluar = value
            End Set
        End Property
        Property DisplayLeaderName As String
            Get
                Return mDisplayLeaderName
            End Get
            Set(value As String)
                mDisplayLeaderName = value
            End Set
        End Property
        Property Description As String
            Get
                Return mDescription
            End Get
            Set(value As String)
                mDescription = value
            End Set
        End Property
        Property ShowInKiosk As Boolean
            Get
                Return mShowInKiosk
            End Get
            Set(value As Boolean)
                mShowInKiosk = value
            End Set
        End Property
        Property Ally As COH_Enum_GroupAlly
            Get
                Return mAlly
            End Get
            Set(value As COH_Enum_GroupAlly)
                mAlly = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
        Property DisplayNameKey As String
            Get
                Return mDisplayNameKey
            End Get
            Set(value As String)
                mDisplayNameKey = value
            End Set
        End Property
        Property DisplaySingluarKey As String
            Get
                Return mDisplaySingluarKey
            End Get
            Set(value As String)
                mDisplaySingluarKey = value
            End Set
        End Property
        Property DisplayLeaderNameKey As String
            Get
                Return mDisplayLeaderNameKey
            End Get
            Set(value As String)
                mDisplayLeaderNameKey = value
            End Set
        End Property
        Property DescriptionKey As String
            Get
                Return mDescriptionKey
            End Get
            Set(value As String)
                mDescriptionKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mDisplayName As String
       Private mDisplaySingluar As String
       Private mDisplayLeaderName As String
       Private mDescription As String
       Private mShowInKiosk As Boolean
       Private mAlly As COH_Enum_GroupAlly
        '//Localized
       Private mDisplayNameKey As String
       Private mDisplaySingluarKey As String
       Private mDisplayLeaderNameKey As String
       Private mDescriptionKey As String
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mName = String.Empty
            mDisplayName = String.Empty
            mDisplaySingluar = String.Empty
            mDisplayLeaderName = String.Empty
            mDescription = String.Empty
            mDisplayNameKey = String.Empty
            mDisplaySingluarKey = String.Empty
            mDisplayLeaderNameKey = String.Empty
            mDescriptionKey = String.Empty
            mShowInKiosk = 0
            mAlly = COH_Enum_GroupAlly.VG_ALLY_NONE
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            mDisplayLeaderName = LocalizeController.RetrieveLocalizedString(mDisplayLeaderNameKey)
            mDisplaySingluar = LocalizeController.RetrieveLocalizedString(mDisplaySingluarKey)
            mDescription = LocalizeController.RetrieveLocalizedString(mDescriptionKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_EnemyVillainGroup
            Dim Result As COH_EnemyVillainGroup = New COH_EnemyVillainGroup
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplaySingluar = String.Copy(mDisplaySingluar)
                .mDisplayLeaderName = String.Copy(mDisplayLeaderName)
                .mDescription = String.Copy(mDescription)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mDisplaySingluarKey = String.Copy(mDisplaySingluarKey)
                .mDisplayLeaderNameKey = String.Copy(mDisplayLeaderNameKey)
                .mDescriptionKey = String.Copy(mDescriptionKey)
                .mShowInKiosk = mShowInKiosk
                .mAlly = mAlly
                Return Result
            End With
            Return Result
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_String(mDisplaySingluarKey)
            CurrentWriter.Write_CrypticS_String(mDisplayLeaderNameKey)
            CurrentWriter.Write_CrypticS_String(mDescriptionKey)
            CurrentWriter.Write(CInt(mShowInKiosk))
            CurrentWriter.Write(CInt(mAlly))
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mDisplaySingluarKey = CurrentReader.Read_CrypticS_String
            mDisplayLeaderNameKey = CurrentReader.Read_CrypticS_String
            mDescriptionKey = CurrentReader.Read_CrypticS_String
            mShowInKiosk = CurrentReader.ReadInt32
            mAlly = CurrentReader.ReadInt32
            Return True
        End Function
#End Region
    End Class
End Namespace