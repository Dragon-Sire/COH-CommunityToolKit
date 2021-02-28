Namespace GameContent.Structures.Powers.Boosts
    Public NotInheritable Class COH_Boost_SetBonus
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return DisplayText
            End Get
        End Property
#End Region

#Region "Properties"
        Property DisplayText As String
            Get
                Return mDisplayText
            End Get
            Set(value As String)
                mDisplayText = value
            End Set
        End Property
        Property MinBoosts As Int32
            Get
                Return mMinBoosts
            End Get
            Set(value As Int32)
                mMinBoosts = value
            End Set
        End Property
        Property MaxBoosts As Int32
            Get
                Return mMaxBoosts
            End Get
            Set(value As Int32)
                mMaxBoosts = value
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
        Property AutoPowers As String()
            Get
                Return mAutoPowers
            End Get
            Set(value As String())
                mAutoPowers = value
            End Set
        End Property
        Property BonusPower As String
            Get
                Return mBonusPower
            End Get
            Set(value As String)
                mBonusPower = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mDisplayText As String
       Private mMinBoosts As Int32
       Private mMaxBoosts As Int32
       Private mRequires As String()
       Private mAutoPowers As String()
       Private mBonusPower As String
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
            mDisplayText = String.Empty
            mRequires = New String() {}
            mAutoPowers = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Boost_SetBonus
            Dim Result As COH_Boost_SetBonus = New COH_Boost_SetBonus
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayText = String.Copy(mDisplayText)
                .mMinBoosts = mMinBoosts
                .mMaxBoosts = mMaxBoosts
                .mRequires = mRequires.CloneTheStrings
                .mAutoPowers = mAutoPowers.CloneTheStrings
                .mBonusPower = String.Copy(mBonusPower)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mDisplayText)
            CurrentWriter.Write(mMinBoosts)
            CurrentWriter.Write(mMaxBoosts)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write_CrypticS_StringArray(mAutoPowers)
            CurrentWriter.Write_CrypticS_String(mBonusPower)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDisplayText = CurrentReader.Read_CrypticS_String
            mMinBoosts = CurrentReader.ReadInt32
            mMaxBoosts = CurrentReader.ReadInt32
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mAutoPowers = CurrentReader.Read_CrypticS_StringArray()
            mBonusPower = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
