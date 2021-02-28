Namespace GameContent.Structures.Characters.Powers.ModParams
    Public NotInheritable Class COH_ModParam_Phase
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Phase"
            End Get
        End Property
#End Region

#Region "Properties"
        Property CombatPhases As Int32()
            Get
                Return mCombatPhases
            End Get
            Set(value As Int32())
                SetValue(mCombatPhases, value)
            End Set
        End Property
        Property VisionPhases As Int32()
            Get
                Return mVisionPhases
            End Get
            Set(value As Int32())
                SetValue(mVisionPhases, value)
            End Set
        End Property
        <DefaultValue(-1)> Property ExclusiveVisionPhase As Int32
            Get
                Return mExclusiveVisionPhase
            End Get
            Set(value As Int32)
                SetValue(mExclusiveVisionPhase, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mCombatPhases As Int32()
       Private mVisionPhases As Int32()
       Private mExclusiveVisionPhase As Int32
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0)
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
            mCombatPhases = New Int32() {}
            mVisionPhases = New Int32() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ModParam_Phase
            Dim Result As COH_ModParam_Phase = New COH_ModParam_Phase
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCombatPhases = New Int32(mCombatPhases.Count - 1) {} : mCombatPhases.CopyTo(.mCombatPhases, 0)
                .mVisionPhases = New Int32(mVisionPhases.Count - 1) {} : mVisionPhases.CopyTo(.mVisionPhases, 0)
                .mExclusiveVisionPhase = mExclusiveVisionPhase
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_IntegerArray(mCombatPhases)
            CurrentWriter.Write_CrypticS_IntegerArray(mVisionPhases)
            CurrentWriter.Write(mExclusiveVisionPhase)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mCombatPhases = CurrentReader.Read_CrypticS_IntegerArray()
            mVisionPhases = CurrentReader.Read_CrypticS_IntegerArray()
            mExclusiveVisionPhase = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
