Imports COH.CodeManagement.Enums.Structures
Imports COH.CodeManagement.Interfaces.Structures
Imports COH.Storage.Serialization
Imports COH.Storage.Serialization.Configuration
Imports COH.Storage.Structures

Namespace Store
    Public NotInheritable Class COH_Loyalty_RewardNode
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
        Property DisplayDescription As String
            Get
                Return mDisplayDescription
            End Get
            Set(value As String)
                mDisplayDescription = value
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
        Property Repeatable As Boolean
            Get
                Return mRepeatable
            End Get
            Set(value As Boolean)
                mRepeatable = value
            End Set
        End Property
        Property Purchasable As Boolean
            Get
                Return mPurchasable
            End Get
            Set(value As Boolean)
                mPurchasable = value
            End Set
        End Property
        Property VIPOnly As Boolean
            Get
                Return mVIPOnly
            End Get
            Set(value As Boolean)
                mVIPOnly = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
        Private mName As String
        Private mDisplayName As String
        Private mDisplayDescription As String
        Private mProduct As String()
        Private mRepeatable As Boolean
        Private mPurchasable As Boolean
        Private mVIPOnly As Boolean
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mName = String.Empty
            mDisplayName = String.Empty
            mDisplayDescription = String.Empty
            mProduct = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Loyalty_RewardNode
            Dim Result As COH_Loyalty_RewardNode = New COH_Loyalty_RewardNode
            ' MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayDescription = String.Copy(mDisplayDescription)
                '.mProduct = mProduct.CloneTheStrings
                .mRepeatable = mRepeatable
                .mPurchasable = mPurchasable
                .mVIPOnly = mVIPOnly
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_String(mDisplayDescription)
            CurrentWriter.Write_CrypticS_StringArray(mProduct)
            CurrentWriter.Write_CrypticS_Boolean(mRepeatable)
            CurrentWriter.Write_CrypticS_Boolean(mPurchasable)
            CurrentWriter.Write_CrypticS_Boolean(mVIPOnly)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mDisplayName = CurrentReader.Read_CrypticS_String
            mDisplayDescription = CurrentReader.Read_CrypticS_String
            mProduct = CurrentReader.Read_CrypticS_StringArray()
            mRepeatable = CurrentReader.Read_CrypticS_Boolean
            mPurchasable = CurrentReader.Read_CrypticS_Boolean
            mVIPOnly = CurrentReader.Read_CrypticS_Boolean
            Return True
        End Function
#End Region

    End Class
End Namespace
