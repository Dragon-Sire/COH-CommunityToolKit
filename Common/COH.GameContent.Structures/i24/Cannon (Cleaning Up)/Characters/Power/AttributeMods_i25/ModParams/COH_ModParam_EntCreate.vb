Namespace GameContent.Structures.Characters.Powers.ModParams
    Public NotInheritable Class COH_ModParam_EntCreate
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return EntityDef
            End Get
        End Property
#End Region

#Region "Properties"
        Property EntityDef As String
            Get
                Return mEntityDef
            End Get
            Set(value As String)
                SetValue(mEntityDef, value)
            End Set
        End Property
        Property [Class] As String
            Get
                Return mClass
            End Get
            Set(value As String)
                SetValue(mClass, value)
            End Set
        End Property
        Property Costume As String
            Get
                Return mCostume
            End Get
            Set(value As String)
                SetValue(mCostume, value)
            End Set
        End Property
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                SetValue(mDisplayName, value)
            End Set
        End Property
        Property PriorityList As String
            Get
                Return mPriorityList
            End Get
            Set(value As String)
                SetValue(mPriorityList, value)
            End Set
        End Property
        Property AIConfig As String
            Get
                Return mAIConfig
            End Get
            Set(value As String)
                SetValue(mAIConfig, value)
            End Set
        End Property
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
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mEntityDef As String
       Private mClass As String
       Private mCostume As String
       Private mDisplayName As String
       Private mPriorityList As String
       Private mAIConfig As String
       Private mPowerCategory As String()
       Private mPowerset As String()
       Private mPower As String()
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
            mEntityDef = String.Empty
            mClass = String.Empty
            mCostume = String.Empty
            mDisplayName = String.Empty
            mPriorityList = String.Empty
            mAIConfig = String.Empty
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
        Public Function Clone() As COH_ModParam_EntCreate
            Dim Result As COH_ModParam_EntCreate = New COH_ModParam_EntCreate
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mEntityDef = CloneString(mEntityDef)
                .mClass = CloneString(mClass)
                .mCostume = CloneString(mCostume)
                .mDisplayName = CloneString(mDisplayName)
                .mPriorityList = CloneString(mPriorityList)
                .mAIConfig = CloneString(mAIConfig)
                .mPowerCategory = CloneStrings(mPowerCategory)
                .mPowerset = CloneStrings(mPowerset)
                .mPower = CloneStrings(mPower)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mEntityDef)
            CurrentWriter.Write_CrypticS_String(mClass)
            CurrentWriter.Write_CrypticS_String(mCostume)
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_String(mPriorityList)
            CurrentWriter.Write_CrypticS_String(mAIConfig)
            CurrentWriter.Write_CrypticS_StringArray(mPowerCategory)
            CurrentWriter.Write_CrypticS_StringArray(mPowerset)
            CurrentWriter.Write_CrypticS_StringArray(mPower)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mEntityDef = CurrentReader.Read_CrypticS_String
            mClass = CurrentReader.Read_CrypticS_String
            mCostume = CurrentReader.Read_CrypticS_String
            mDisplayName = CurrentReader.Read_CrypticS_String
            mPriorityList = CurrentReader.Read_CrypticS_String
            mAIConfig = CurrentReader.Read_CrypticS_String
            mPowerCategory = CurrentReader.Read_CrypticS_StringArray
            mPowerset = CurrentReader.Read_CrypticS_StringArray
            mPower = CurrentReader.Read_CrypticS_StringArray
            Return True
        End Function
#End Region

    End Class
End Namespace
