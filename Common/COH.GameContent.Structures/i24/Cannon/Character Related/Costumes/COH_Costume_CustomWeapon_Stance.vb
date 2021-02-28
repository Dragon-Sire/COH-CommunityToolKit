Namespace GameContent.Structures.Costumes
    Public NotInheritable Class COH_CostumeWeapon_Stance
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Weapon
            End Get
        End Property
#End Region

#Region "Properties"
        Property Weapon As String
            Get
                Return mWeapon
            End Get
            Set(value As String)
                mWeapon = value
            End Set
        End Property
        Property StanceType As COH_Enum_WeaponStance
            Get
                Return mStanceType
            End Get
            Set(value As COH_Enum_WeaponStance)
                mStanceType = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mWeapon As String
       Private mStanceType As COH_Enum_WeaponStance
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
            mWeapon = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeWeapon_Stance
            Dim Result As COH_CostumeWeapon_Stance = New COH_CostumeWeapon_Stance
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mWeapon = String.Copy(mWeapon)
                .mStanceType = mStanceType
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mWeapon)
            CurrentWriter.Write(mStanceType)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mWeapon = CurrentReader.Read_CrypticS_String
            mStanceType = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
