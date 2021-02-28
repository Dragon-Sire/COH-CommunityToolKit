Namespace GameContent.Structures.Characters.Powers.ModParams
    Public NotInheritable Class COH_ModParam
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return TheParamType.ToString
            End Get
        End Property
#End Region

#Region "Properties"
        Property TheParamType As COH_Enum_AttribModParamType
            Get
                Return mType
            End Get
            Set(value As COH_Enum_AttribModParamType)
                SetValue(mType, value)
            End Set
        End Property
        <DefaultValue(5)> Property Param As COH_FileStructure
            Get
                Return mStruct
            End Get
            Set(value As COH_FileStructure)
                SetValue(mStruct, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mType As COH_Enum_AttribModParamType
       Private mStruct As COH_FileStructure
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
            mType = COH_Enum_AttribModParamType.ParamType_None
            mStruct = Nothing
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ModParam
            Dim Result As COH_ModParam = New COH_ModParam
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mType = mType
                ' If Not (mStruct Is Nothing) Then .mStruct = mStruct.CloneMe
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mType = CurrentReader.ReadInt32
            If mType = COH_Enum_AttribModParamType.ParamType_None Then Return True
            Dim Size = CurrentReader.ReadInt32
            Select Case mType
                Case COH_Enum_AttribModParamType.ParamType_None
                    mStruct = Nothing
                Case COH_Enum_AttribModParamType.ParamType_Costume
                    mStruct = New COH_ModParam_Costume(CurrentReader)
                Case COH_Enum_AttribModParamType.ParamType_Power
                    mStruct = New COH_ModParam_Power(CurrentReader)
                Case COH_Enum_AttribModParamType.ParamType_Reward
                    mStruct = New COH_ModParam_Reward(CurrentReader)

                Case COH_Enum_AttribModParamType.ParamType_Behavior
                    mStruct = New COH_ModParam_Behavior(CurrentReader)
                Case COH_Enum_AttribModParamType.ParamType_EffectFilter
                    mStruct = New COH_ModParam_EffectFilter(CurrentReader)
                Case COH_Enum_AttribModParamType.ParamType_EntCreate
                    mStruct = New COH_ModParam_EntCreate(CurrentReader)
                Case COH_Enum_AttribModParamType.ParamType_Phase
                    mStruct = New COH_ModParam_Phase(CurrentReader)
                Case COH_Enum_AttribModParamType.ParamType_SZEValue
                    mStruct = New COH_ModParam_SizeValue(CurrentReader)
                Case COH_Enum_AttribModParamType.ParamType_Teleport
                    mStruct = New COH_ModParam_Teleport(CurrentReader)
                Case COH_Enum_AttribModParamType.ParamType_Token
                    mStruct = New COH_ModParam_Token(CurrentReader)
                Case Else
                    ShowErrorOccured(mType & " - Param ID Not Yet Supported")
                    Return False
            End Select
            Return True
        End Function
#End Region

    End Class
End Namespace
