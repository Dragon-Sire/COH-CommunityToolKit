Namespace GameContent.Structures.Characters.Powers
    Public NotInheritable Class COH_AttribMod_i25Score_FX
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "FX"
            End Get
        End Property
#End Region

#Region "Properties"
        Property ContinuingBits As Int32()
            Get
                Return mContinuingBits
            End Get
            Set(value As Int32())
                SetValue(mContinuingBits, value)
            End Set
        End Property
        Property ContinuingFX As String
            Get
                Return mContinuingFX
            End Get
            Set(value As String)
                SetValue(mContinuingFX, value)
            End Set
        End Property
        Property ConditionalBits As Int32()
            Get
                Return mConditionalBits
            End Get
            Set(value As Int32())
                SetValue(mConditionalBits, value)
            End Set
        End Property
        Property ConditionalFX As String
            Get
                Return mConditionalFX
            End Get
            Set(value As String)
                SetValue(mConditionalFX, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mContinuingBits As Int32()
       Private mContinuingFX As String
       Private mConditionalBits As Int32()
       Private mConditionalFX As String
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
            mContinuingBits = New Int32() {}
            mContinuingFX = String.Empty
            mConditionalBits = New Int32() {}
            mConditionalFX = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_AttribMod_i25Score_FX
            Dim Result As COH_AttribMod_i25Score_FX = New COH_AttribMod_i25Score_FX
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mContinuingBits = New Int32(mContinuingBits.Count - 1) {} : mContinuingBits.CopyTo(.mContinuingBits, 0)
                .mContinuingFX = CloneString(mContinuingFX)
                .mConditionalBits = New Int32(mConditionalBits.Count - 1) {} : mConditionalBits.CopyTo(.mConditionalBits, 0)
                .mConditionalFX = CloneString(mConditionalFX)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_IntegerArray(mContinuingBits)
            CurrentWriter.Write_CrypticS_String(mContinuingFX)
            CurrentWriter.Write_CrypticS_IntegerArray(mConditionalBits)
            CurrentWriter.Write_CrypticS_String(mConditionalFX)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mContinuingBits = CurrentReader.Read_CrypticS_IntegerArray()
            mContinuingFX = CurrentReader.Read_CrypticS_String
            mConditionalBits = CurrentReader.Read_CrypticS_IntegerArray()
            mConditionalFX = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
