Namespace GameContent.Structures.Enemies
    Public Class COH_EnemyVillain_Level
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mLevel
            End Get
        End Property
#End Region

#Region "Properties"
        Property Level As Int32
            Get
                Return mLevel
            End Get
            Set(value As Int32)
                mLevel = value
            End Set
        End Property
        Property DisplayNames As String()
            Get
                Return mDisplayNames
            End Get
            Set(value As String())
                mDisplayNames = value
            End Set
        End Property
        Property Costumes As String()
            Get
                Return mCostumes
            End Get
            Set(value As String())
                mCostumes = value
            End Set
        End Property
        Property XP As Int32
            Get
                Return mXP
            End Get
            Set(value As Int32)
                mXP = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mLevel As Int32
       Private mDisplayNames As String()
       Private mCostumes As String()
       Private mXP As Int32
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
            mLevel = 0
            mDisplayNames = New String() {}
            mCostumes = New String() {}
            mXP = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_EnemyVillain_Level
            Dim Result As COH_EnemyVillain_Level = New COH_EnemyVillain_Level
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mLevel = mLevel
                .mDisplayNames = mDisplayNames.CloneTheStrings
                .mCostumes = mCostumes.CloneTheStrings
                .mXP = mXP
                Return Result
            End With
            Return Result
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mLevel)
            CurrentWriter.Write_CrypticS_StringArray(mDisplayNames)
            CurrentWriter.Write_CrypticS_StringArray(mCostumes)
            CurrentWriter.Write(mXP)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mLevel = CurrentReader.ReadInt32
            mDisplayNames = CurrentReader.Read_CrypticS_StringArray()
            mCostumes = CurrentReader.Read_CrypticS_StringArray()
            mXP = CurrentReader.ReadInt32
            Return True
        End Function
#End Region
    End Class
End Namespace