Namespace GameContent.Structures.Costumes.NPC
    Public NotInheritable Class COH_CostumeNPC
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mOriginalNPCName
            End Get
        End Property
#End Region

#Region "Properties"
        Property OriginalNPCName As String
            Get
                Return mOriginalNPCName
            End Get
            Set(value As String)
                mOriginalNPCName = value
            End Set
        End Property
        Property SkinColor As COH_XML_Color
            Get
                Return mSkinColor
            End Get
            Set(value As COH_XML_Color)
                mSkinColor = value
            End Set
        End Property
        Property CostumeParts As COH_CostumeNPC_Part()
            Get
                Return mCostumeParts
            End Get
            Set(value As COH_CostumeNPC_Part())
                mCostumeParts = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mOriginalNPCName As String
       Private mSkinColor As Drawing.Color
       Private mCostumeParts As COH_CostumeNPC_Part()
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
            mOriginalNPCName = String.Empty
            mSkinColor = New Drawing.Color  ' No Default Defined
            mCostumeParts = New COH_CostumeNPC_Part() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeNPC
            Dim Result As COH_CostumeNPC = New COH_CostumeNPC
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mOriginalNPCName = String.Copy(mOriginalNPCName)
                .mSkinColor = mSkinColor
                .mCostumeParts = New COH_CostumeNPC_Part(mCostumeParts.Count - 1) {}
                For X = 0 To mCostumeParts.Count - 1
                    .mCostumeParts(X) = mCostumeParts(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mOriginalNPCName)
            CurrentWriter.Write_CrypticS_RGB(mSkinColor)
            If CurrentWriter.Write_CrypticS_StructArray(mCostumeParts) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mOriginalNPCName = CurrentReader.Read_CrypticS_String
            mSkinColor = CurrentReader.Read_CrypticS_RGB
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumeNPC_Part), mCostumeParts) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
