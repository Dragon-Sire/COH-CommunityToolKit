Namespace GameContent.Structures.Powers.Boosts
    Public NotInheritable Class COH_Boost_Set
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
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property GroupName As String
            Get
                Return mGroupName
            End Get
            Set(value As String)
                mGroupName = value
            End Set
        End Property
        Property ConversionGroups As String()
            Get
                Return mConversionGroups
            End Get
            Set(value As String())
                mConversionGroups = value
            End Set
        End Property
        Property Powers As String()
            Get
                Return mPowers
            End Get
            Set(value As String())
                mPowers = value
            End Set
        End Property
        Property BoostLists As COH_Boost_List()
            Get
                Return mBoostLists
            End Get
            Set(value As COH_Boost_List())
                mBoostLists = value
            End Set
        End Property
        Property Bonuses As COH_Boost_SetBonus()
            Get
                Return mBonuses
            End Get
            Set(value As COH_Boost_SetBonus())
                mBonuses = value
            End Set
        End Property
        Property MinLevel As Int32
            Get
                Return mMinLevel
            End Get
            Set(value As Int32)
                mMinLevel = value
            End Set
        End Property
        Property MaxLevel As Int32
            Get
                Return mMaxLevel
            End Get
            Set(value As Int32)
                mMaxLevel = value
            End Set
        End Property
        Property StoreProduct As String
            Get
                Return mStoreProduct
            End Get
            Set(value As String)
                mStoreProduct = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mDisplayName As String
       Private mGroupName As String
       Private mConversionGroups As String()
       Private mPowers As String()
       Private mBoostLists As COH_Boost_List()
       Private mBonuses As COH_Boost_SetBonus()
       Private mMinLevel As Int32
       Private mMaxLevel As Int32
       Private mStoreProduct As String
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
            mDisplayName = String.Empty
            mGroupName = String.Empty
            mConversionGroups = New String() {}
            mPowers = New String() {}
            mBoostLists = New COH_Boost_List() {}
            mBonuses = New COH_Boost_SetBonus() {}
            mStoreProduct = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Boost_Set
            Dim Result As COH_Boost_Set = New COH_Boost_Set
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mGroupName = String.Copy(mGroupName)
                .mConversionGroups = mConversionGroups.CloneTheStrings
                .mPowers = mPowers.CloneTheStrings
                .mBoostLists = New COH_Boost_List(mBoostLists.Count - 1) {}
                For X = 0 To mBoostLists.Count - 1
                    .mBoostLists(X) = mBoostLists(X).Clone
                Next
                .mBonuses = New COH_Boost_SetBonus(mBonuses.Count - 1) {}
                For X = 0 To mBonuses.Count - 1
                    .mBonuses(X) = mBonuses(X).Clone
                Next
                .mMinLevel = mMinLevel
                .mMaxLevel = mMaxLevel
                .mStoreProduct = String.Copy(mStoreProduct)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_String(mGroupName)
            CurrentWriter.Write_CrypticS_StringArray(mConversionGroups)
            CurrentWriter.Write_CrypticS_StringArray(mPowers)
            If CurrentWriter.Write_CrypticS_StructArray(mBoostLists) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mBonuses) = False Then Return False
            CurrentWriter.Write(mMinLevel)
            CurrentWriter.Write(mMaxLevel)
            CurrentWriter.Write_CrypticS_String(mStoreProduct)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mDisplayName = CurrentReader.Read_CrypticS_String
            mGroupName = CurrentReader.Read_CrypticS_String
            mConversionGroups = CurrentReader.Read_CrypticS_StringArray()
            mPowers = CurrentReader.Read_CrypticS_StringArray()
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Boost_List), mBoostLists) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Boost_SetBonus), mBonuses) = False Then Return False
            mMinLevel = CurrentReader.ReadInt32
            mMaxLevel = CurrentReader.ReadInt32
            mStoreProduct = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
