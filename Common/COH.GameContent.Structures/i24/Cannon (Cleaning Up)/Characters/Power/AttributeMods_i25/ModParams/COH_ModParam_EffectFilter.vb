Namespace GameContent.Structures.Characters.Powers.ModParams
    Public NotInheritable Class COH_ModParam_EffectFilter
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "EffectFilter"
            End Get
        End Property
#End Region

#Region "Properties"
        Property PowerCategory As String()
            Get
                Return mPowerCategory
            End Get
            Set(value As String())
                SetValue(mPowerCategory, value)
            End Set
        End Property
        Property Powerset As String()
            Get
                Return mPowerset
            End Get
            Set(value As String())
                SetValue(mPowerset, value)
            End Set
        End Property
        Property Power As String()
            Get
                Return mPower
            End Get
            Set(value As String())
                SetValue(mPower, value)
            End Set
        End Property
        Property Tag As String()
            Get
                Return mTag
            End Get
            Set(value As String())
                SetValue(mTag, value)
            End Set
        End Property

#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mPowerCategory As String()
       Private mPowerset As String()
       Private mPower As String()
       Private mTag As String()
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
            mPowerCategory = New String() {}
            mPowerset = New String() {}
            mPower = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ModParam_EffectFilter
            Dim Result As COH_ModParam_EffectFilter = New COH_ModParam_EffectFilter
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mPowerCategory = CloneStrings(mPowerCategory)
                .mPowerset = CloneStrings(mPowerset)
                .mPower = CloneStrings(mPower)
                .mTag = CloneStrings(mTag)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_StringArray(mPowerCategory)
            CurrentWriter.Write_CrypticS_StringArray(mPowerset)
            CurrentWriter.Write_CrypticS_StringArray(mPower)
            CurrentWriter.Write_CrypticS_StringArray(mTag)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mPowerCategory = CurrentReader.Read_CrypticS_StringArray
            mPowerset = CurrentReader.Read_CrypticS_StringArray
            mPower = CurrentReader.Read_CrypticS_StringArray
            mTag = CurrentReader.Read_CrypticS_StringArray
            Return True
        End Function
#End Region

    End Class
End Namespace
