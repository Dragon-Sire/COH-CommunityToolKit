Imports COH.CodeManagement.Interfaces.Structures
Imports COH.Storage.Serialization
Imports COH.Storage.Structures

Namespace Store
    Public NotInheritable Class COH_Loyalty_RewardLevel
        Inherits COH_FileStructure

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
        Property DisplayVIP As String
            Get
                Return mDisplayVIP
            End Get
            Set(value As String)
                mDisplayVIP = value
            End Set
        End Property
        Property DisplayFree As String
            Get
                Return mDisplayFree
            End Get
            Set(value As String)
                mDisplayFree = value
            End Set
        End Property
        Property Product As String()
            Get
                Return mProduct
            End Get
            Set(value As String())
                mProduct = value
            End Set
        End Property
        Property LoyaltyPointsRequired As Int32
            Get
                Return mLoyaltyPointsRequired
            End Get
            Set(value As Int32)
                mLoyaltyPointsRequired = value
            End Set
        End Property
        Property InfluenceCap As Int64
            Get
                Return mInfluenceCap
            End Get
            Set(value As Int64)
                mInfluenceCap = value
            End Set
        End Property
        Private mName As String
        Private mDisplayName As String
        Private mDisplayVIP As String
        Private mDisplayFree As String
        Private mProduct As String()
        Private mLoyaltyPointsRequired As Int32
        Private mInfluenceCap As Int64
#End Region

#If EDITOR Then
#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
        'Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
        ' MyBase.New(SetDefaults, Version)
        ' End Sub
        'Public Sub New(ByRef Buffer As Byte(), Optional Settings As COH_Serialization_Settings = Nothing)
        ' MyBase.New(Buffer, Settings)
        ' End Sub
        ' Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings As COH_Serialization_Settings = Nothing)
        ' MyBase.New(Stream, Settings)
        ' End Sub
        ' Public Sub New(ByRef CurrentReader As COH_BinaryReader)
        ' MyBase.New(CurrentReader)
        ' End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mName = String.Empty
            mDisplayName = String.Empty
            mDisplayVIP = String.Empty
            mDisplayFree = String.Empty
            mProduct = New String() {}
        End Sub
#End Region
#End If

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub


#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Loyalty_RewardLevel
            Dim Result As COH_Loyalty_RewardLevel = New COH_Loyalty_RewardLevel
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayVIP = String.Copy(mDisplayVIP)
                .mDisplayFree = String.Copy(mDisplayFree)
                '.mProduct = mProduct.CloneTheStrings
                .mLoyaltyPointsRequired = mLoyaltyPointsRequired
                .mInfluenceCap = mInfluenceCap
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_String(mDisplayVIP)
            CurrentWriter.Write_CrypticS_String(mDisplayFree)
            CurrentWriter.Write_CrypticS_StringArray(mProduct)
            CurrentWriter.Write(mLoyaltyPointsRequired)
            CurrentWriter.Write(mInfluenceCap)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mDisplayName = CurrentReader.Read_CrypticS_String
            mDisplayVIP = CurrentReader.Read_CrypticS_String
            mDisplayFree = CurrentReader.Read_CrypticS_String
            mProduct = CurrentReader.Read_CrypticS_StringArray()
            mLoyaltyPointsRequired = CurrentReader.ReadInt32
            mInfluenceCap = CurrentReader.ReadInt64
            Return True
        End Function
#End Region

    End Class
End Namespace
