Namespace GameContent.Structures.Enemies
    Public NotInheritable Class COH_Enemy_GroupMM
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
        Property MinGroupLevel As Int32
            Get
                Return mMinGroupLevel
            End Get
            Set(value As Int32)
                mMinGroupLevel = value
            End Set
        End Property
        Property MaxGroupLevel As Int32
            Get
                Return mMaxGroupLevel
            End Get
            Set(value As Int32)
                mMaxGroupLevel = value
            End Set
        End Property
        Property Exclude As String
            Get
                Return mExclude
            End Get
            Set(value As String)
                mExclude = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mMinLevel As Int32
       Private mMaxLevel As Int32
       Private mMinGroupLevel As Int32
       Private mMaxGroupLevel As Int32
       Private mExclude As String
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
            mExclude = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Enemy_GroupMM
            Dim Result As COH_Enemy_GroupMM = New COH_Enemy_GroupMM
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mMinLevel = mMinLevel
                .mMaxLevel = mMaxLevel
                .mMinGroupLevel = mMinGroupLevel
                .mMaxGroupLevel = mMaxGroupLevel
                .mExclude = String.Copy(mExclude)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mMinLevel)
            CurrentWriter.Write(mMaxLevel)
            CurrentWriter.Write(mMinGroupLevel)
            CurrentWriter.Write(mMaxGroupLevel)
            CurrentWriter.Write_CrypticS_String(mExclude)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mMinLevel = CurrentReader.ReadInt32
            mMaxLevel = CurrentReader.ReadInt32
            mMinGroupLevel = CurrentReader.ReadInt32
            mMaxGroupLevel = CurrentReader.ReadInt32
            mExclude = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
