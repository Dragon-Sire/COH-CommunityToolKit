Namespace GameContent.Structures.Characters
    Public NotInheritable Class COH_ExperienceTable
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Exp"
            End Get
        End Property
#End Region

#Region "Properties"
        Property ExperienceRequired As Int32()
            Get
                Return mExperienceRequired
            End Get
            Set(value As Int32())
                mExperienceRequired = value
            End Set
        End Property
        Property DefeatPenalty As Int32()
            Get
                Return mDefeatPenalty
            End Get
            Set(value As Int32())
                mDefeatPenalty = value
            End Set
        End Property
#End Region
#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mExperienceRequired As Int32()
       Private mDefeatPenalty As Int32()
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
            mExperienceRequired = New Int32() {}
            mDefeatPenalty = New Int32() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ExperienceTable
            Dim Result As COH_ExperienceTable = New COH_ExperienceTable
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mExperienceRequired = New Int32(mExperienceRequired.Count - 1) {} : mExperienceRequired.CopyTo(.mExperienceRequired, 0)
                .mDefeatPenalty = New Int32(mDefeatPenalty.Count - 1) {} : mDefeatPenalty.CopyTo(.mDefeatPenalty, 0)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_IntegerArray(mExperienceRequired)
            CurrentWriter.Write_CrypticS_IntegerArray(mDefeatPenalty)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mExperienceRequired = CurrentReader.Read_CrypticS_IntegerArray()
            mDefeatPenalty = CurrentReader.Read_CrypticS_IntegerArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
