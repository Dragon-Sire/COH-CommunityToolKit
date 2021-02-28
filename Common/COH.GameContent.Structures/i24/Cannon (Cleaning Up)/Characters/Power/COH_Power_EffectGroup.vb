Imports COH.GameContent.Structures.Powers

Namespace GameContent.Structures.Characters.Powers
    Public NotInheritable Class COH_PowerEffectGroup
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Effect Group"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Tag As String()
            Get
                Return mTag
            End Get
            Set(value As String())
                SetValue(mTag, value)
            End Set
        End Property
        <DefaultValue(1)> Property Chance As Single
            Get
                Return mChance
            End Get
            Set(value As Single)
                SetValue(mChance, value)
            End Set
        End Property
        Property ProcsPerMinute As Single
            Get
                Return mProcsPerMinute
            End Get
            Set(value As Single)
                SetValue(mProcsPerMinute, value)
            End Set
        End Property
        Property Delay As Single
            Get
                Return mDelay
            End Get
            Set(value As Single)
                SetValue(mDelay, value)
            End Set
        End Property
        <DefaultValue(-1)> Property RadiusInner As Single
            Get
                Return mRadiusInner
            End Get
            Set(value As Single)
                SetValue(mRadiusInner, value)
            End Set
        End Property
        <DefaultValue(-1)> Property RadiusOuter As Single
            Get
                Return mRadiusOuter
            End Get
            Set(value As Single)
                SetValue(mRadiusOuter, value)
            End Set
        End Property
        Property Requires As String()
            Get
                Return mRequires
            End Get
            Set(value As String())
                SetValue(mRequires, value)
            End Set
        End Property
        Property EvalFlags As Int32
            Get
                Return mEvalFlags
            End Get
            Set(value As Int32)
                SetValue(mEvalFlags, value)
            End Set
        End Property
        Property Flags As COH_EnumFlags_EffectGroup
            Get
                Return mFlags
            End Get
            Set(value As COH_EnumFlags_EffectGroup)
                SetValue(mFlags, value)
            End Set
        End Property
        Property AttribMod As COH_Power_AttributeMod_i25_Score()
            Get
                Return mAttribMod
            End Get
            Set(value As COH_Power_AttributeMod_i25_Score())
                SetValue(mAttribMod, value)
            End Set
        End Property
        Property Effect As COH_PowerEffectGroup()
            Get
                Return mEffect
            End Get
            Set(value As COH_PowerEffectGroup())
                SetValue(mEffect, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTag As String()
       Private mChance As Single
       Private mProcsPerMinute As Single
       Private mDelay As Single
       Private mRadiusInner As Single
       Private mRadiusOuter As Single
       Private mRequires As String()
       Private mFlags As COH_EnumFlags_EffectGroup
       Private mEvalFlags As Int32
       Private mAttribMod As COH_Power_AttributeMod_i25_Score()
       Private mEffect As COH_PowerEffectGroup()
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
            mFlags = 1
            mTag = New String() {}
            mRequires = New String() {}
            mAttribMod = New COH_Power_AttributeMod_i25_Score() {}
            mEffect = New COH_PowerEffectGroup() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_PowerEffectGroup
            Dim Result As COH_PowerEffectGroup = New COH_PowerEffectGroup
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTag = CloneStrings(mTag)
                .mChance = mChance
                .mProcsPerMinute = mProcsPerMinute
                .mDelay = mDelay
                .mRadiusInner = mRadiusInner
                .mRadiusOuter = mRadiusOuter
                .mRequires = CloneStrings(mRequires)
                .mEvalFlags = mEvalFlags
                .mAttribMod = New COH_Power_AttributeMod_i25_Score(mAttribMod.Count - 1) {}
                For X = 0 To mAttribMod.Count - 1
                    .mAttribMod(X) = mAttribMod(X).Clone
                Next
                .mEffect = New COH_PowerEffectGroup(mEffect.Count - 1) {}
                For X = 0 To mEffect.Count - 1
                    .mEffect(X) = mEffect(X).Clone
                Next
                .mFlags = mFlags
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_StringArray(mTag)
            CurrentWriter.Write(mChance)
            CurrentWriter.Write(mProcsPerMinute)
            CurrentWriter.Write(mDelay)
            CurrentWriter.Write(mRadiusInner)
            CurrentWriter.Write(mRadiusOuter)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write(mFlags)
            CurrentWriter.Write(mEvalFlags)
            If CurrentWriter.Write_CrypticS_StructArray(mAttribMod) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mEffect) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTag = CurrentReader.Read_CrypticS_StringArray
            mChance = CurrentReader.ReadSingle
            mProcsPerMinute = CurrentReader.ReadSingle
            mDelay = CurrentReader.ReadSingle
            mRadiusInner = CurrentReader.ReadSingle
            mRadiusOuter = CurrentReader.ReadSingle
            mRequires = CurrentReader.Read_CrypticS_StringArray
            mFlags = CurrentReader.ReadInt32
            mEvalFlags = CurrentReader.ReadInt32

            'FAILS HERE DO TO ATTRIBUTE MOD

            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Power_AttributeMod_i25_Score), mAttribMod) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_PowerEffectGroup), mEffect) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
