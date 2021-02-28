Namespace GameContent.Structures.Store
    Public NotInheritable Class COH_Store_SuperPackCard
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mTitle & " (" & mProduct & ")"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Number As Int32
            Get
                Return mNumber
            End Get
            Set(value As Int32)
                mNumber = value
            End Set
        End Property
        Property Rarity As String
            Get
                Return mRarity
            End Get
            Set(value As String)
                mRarity = value
            End Set
        End Property
        Property Count As Int32
            Get
                Return mCount
            End Get
            Set(value As Int32)
                mCount = value
            End Set
        End Property
        Property DisplayCount As Int32
            Get
                Return mDisplayCount
            End Get
            Set(value As Int32)
                mDisplayCount = value
            End Set
        End Property
        Property Product As String
            Get
                Return mProduct
            End Get
            Set(value As String)
                mProduct = value
            End Set
        End Property
        Property Title As String
            Get
                Return mTitle
            End Get
            Set(value As String)
                mTitle = value
            End Set
        End Property
        Property Category As String
            Get
                Return mCategory
            End Get
            Set(value As String)
                mCategory = value
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
        Property Border As String
            Get
                Return mBorder
            End Get
            Set(value As String)
                mBorder = value
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
#End Region

#Region "Properties - Localized"
        Property TitleKey As String
            Get
                Return mTitleKey
            End Get
            Set(value As String)
                mTitleKey = value
            End Set
        End Property
        Property CategoryKey As String
            Get
                Return mCategoryKey
            End Get
            Set(value As String)
                mCategoryKey = value
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
       Private mNumber As Int32
       Private mRarity As String
       Private mCount As Int32
       Private mDisplayCount As Int32
       Private mProduct As String
       Private mTitle As String
       Private mCategory As String
       Private mDescription As String
       Private mBorder As String
       Private mIcon As String
        '//Localized
       Private mTitleKey As String
       Private mCategoryKey As String
       Private mDescriptionKey As String
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
            mNumber = 0
            mRarity = String.Empty
            mCount = 0
            mDisplayCount = 0
            mProduct = String.Empty
            mTitle = String.Empty
            mCategory = String.Empty
            mDescription = String.Empty
            mTitleKey = String.Empty
            mCategoryKey = String.Empty
            mDescriptionKey = String.Empty
            mBorder = String.Empty
            mIcon = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
            mTitle = LocalizeController.RetrieveLocalizedString(mTitleKey)
            mCategory = LocalizeController.RetrieveLocalizedString(mCategoryKey)
            mDescription = LocalizeController.RetrieveLocalizedString(mDescriptionKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Store_SuperPackCard
            Dim Result As COH_Store_SuperPackCard = New COH_Store_SuperPackCard
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mNumber = mNumber
                .mRarity = String.Copy(mRarity)
                .mCount = mCount
                .mDisplayCount = mDisplayCount
                .mProduct = String.Copy(mProduct)
                .mTitle = String.Copy(mTitle)
                .mCategory = String.Copy(mCategory)
                .mDescription = String.Copy(mDescription)
                .mTitleKey = String.Copy(mTitleKey)
                .mCategoryKey = String.Copy(mCategoryKey)
                .mDescriptionKey = String.Copy(mDescriptionKey)
                .mBorder = String.Copy(mBorder)
                .mIcon = String.Copy(mIcon)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mNumber)
            CurrentWriter.Write_CrypticS_String(mRarity)
            CurrentWriter.Write(mCount)
            CurrentWriter.Write(mDisplayCount)
            CurrentWriter.Write_CrypticS_String(mProduct)
            CurrentWriter.Write_CrypticS_String(mTitleKey)
            CurrentWriter.Write_CrypticS_String(mCategoryKey)
            CurrentWriter.Write_CrypticS_String(mDescriptionKey)
            CurrentWriter.Write_CrypticS_String(mBorder)
            CurrentWriter.Write_CrypticS_String(mIcon)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mNumber = CurrentReader.ReadInt32
            mRarity = CurrentReader.Read_CrypticS_String
            mCount = CurrentReader.ReadInt32
            mDisplayCount = CurrentReader.ReadInt32
            mProduct = CurrentReader.Read_CrypticS_String
            mTitleKey = CurrentReader.Read_CrypticS_String
            mCategoryKey = CurrentReader.Read_CrypticS_String
            mDescriptionKey = CurrentReader.Read_CrypticS_String
            mBorder = CurrentReader.Read_CrypticS_String
            mIcon = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
