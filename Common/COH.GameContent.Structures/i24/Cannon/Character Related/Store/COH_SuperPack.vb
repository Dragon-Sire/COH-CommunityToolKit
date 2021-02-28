Namespace GameContent.Structures.Store
    Public NotInheritable Class COH_Store_SuperPack
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
        Property Icon As String
            Get
                Return mIcon
            End Get
            Set(value As String)
                mIcon = value
            End Set
        End Property
        Property CardBack As String
            Get
                Return mCardBack
            End Get
            Set(value As String)
                mCardBack = value
            End Set
        End Property
        Property Salvage As String
            Get
                Return mSalvage
            End Get
            Set(value As String)
                mSalvage = value
            End Set
        End Property
        Property Cards As COH_Store_SuperPackCard()
            Get
                Return mCards
            End Get
            Set(value As COH_Store_SuperPackCard())
                mCards = value
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
#End Region

#Region "Private Properties"
       Private mName As String
       Private mDisplayName As String
       Private mIcon As String
       Private mCardBack As String
       Private mSalvage As String
       Private mCards As COH_Store_SuperPackCard()
        '//Localization
       Private mDisplayNameKey As String
#End Region

#Region "Create New Instance"
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
            mDisplayNameKey = String.Empty
            mIcon = String.Empty
            mCardBack = String.Empty
            mSalvage = String.Empty
            mCards = New COH_Store_SuperPackCard() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            For Each TheCard In mCards
                TheCard.UpdateLocalizations(LocalizeController)
            Next
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Store_SuperPack
            Dim Result As COH_Store_SuperPack = New COH_Store_SuperPack
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mIcon = String.Copy(mIcon)
                .mCardBack = String.Copy(mCardBack)
                .mSalvage = String.Copy(mSalvage)
                .mCards = New COH_Store_SuperPackCard(mCards.Count - 1) {}
                For X = 0 To mCards.Count - 1
                    .mCards(X) = mCards(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_String(mIcon)
            CurrentWriter.Write_CrypticS_String(mCardBack)
            CurrentWriter.Write_CrypticS_String(mSalvage)
            If CurrentWriter.Write_CrypticS_StructArray(mCards) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mIcon = CurrentReader.Read_CrypticS_String
            mCardBack = CurrentReader.Read_CrypticS_String
            mSalvage = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Store_SuperPackCard), mCards) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
