Namespace GameContent.Structures.Animation.FX
    Public NotInheritable Class COH_FX_Info
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
        Property FileAge As Int32
            Get
                Return mFileAge
            End Get
            Set(value As Int32)
                mFileAge = value
            End Set
        End Property
        Property LifeSpan As Int32
            Get
                Return mLifeSpan
            End Get
            Set(value As Int32)
                mLifeSpan = value
            End Set
        End Property
        Property Lighting As Int32
            Get
                Return mLighting
            End Get
            Set(value As Int32)
                mLighting = value
            End Set
        End Property
        Property Input As COH_FX_Input()
            Get
                Return mInput
            End Get
            Set(value As COH_FX_Input())
                mInput = value
            End Set
        End Property
        Property Condition As COH_FX_Condition()
            Get
                Return mCondition
            End Get
            Set(value As COH_FX_Condition())
                mCondition = value
            End Set
        End Property
        Property Flags As COH_Enum_FX_Used
            Get
                Return mFlags
            End Get
            Set(value As COH_Enum_FX_Used)
                mFlags = value
            End Set
        End Property
        Property PerformanceRadius As Single
            Get
                Return mPerformanceRadius
            End Get
            Set(value As Single)
                mPerformanceRadius = value
            End Set
        End Property
        Property OnForceRadius As Single
            Get
                Return mOnForceRadius
            End Get
            Set(value As Single)
                mOnForceRadius = value
            End Set
        End Property
        Property AnimScale As Single
            Get
                Return mAnimScale
            End Get
            Set(value As Single)
                mAnimScale = value
            End Set
        End Property
        Property ClampMinScale As COH_Struct_Vector3
            Get
                Return mClampMinScale
            End Get
            Set(value As COH_Struct_Vector3)
                mClampMinScale = value
            End Set
        End Property
        Property ClampMaxScale As COH_Struct_Vector3
            Get
                Return mClampMaxScale
            End Get
            Set(value As COH_Struct_Vector3)
                mClampMaxScale = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mFileAge As Int32
       Private mLifeSpan As Int32
       Private mLighting As Int32
       Private mInput As COH_FX_Input()
       Private mCondition As COH_FX_Condition()
       Private mFlags As COH_Enum_FX_Used
       Private mPerformanceRadius As Single
       Private mOnForceRadius As Single
       Private mAnimScale As Single
       Private mClampMinScale As COH_Struct_Vector3
       Private mClampMaxScale As COH_Struct_Vector3
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
            mInput = New COH_FX_Input() {}
            mCondition = New COH_FX_Condition() {}
            mClampMinScale = New COH_Struct_Vector3
            mClampMaxScale = New COH_Struct_Vector3
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_FX_Info
            Dim Result As COH_FX_Info = New COH_FX_Info
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFileAge = mFileAge
                .mLifeSpan = mLifeSpan
                .mLighting = mLighting
                .mInput = New COH_FX_Input(mInput.Count - 1) {}
                For X = 0 To mInput.Count - 1
                    .mInput(X) = mInput(X).Clone
                Next
                .mCondition = New COH_FX_Condition(mCondition.Count - 1) {}
                For X = 0 To mCondition.Count - 1
                    .mCondition(X) = mCondition(X).Clone
                Next
                .mFlags = mFlags
                .mPerformanceRadius = mPerformanceRadius
                .mOnForceRadius = mOnForceRadius
                .mAnimScale = mAnimScale
                .mClampMinScale = mClampMinScale
                .mClampMaxScale = mClampMaxScale
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mFxInfo)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_TimeStamp(mFileAge)
            CurrentWriter.Write(mLifeSpan)
            CurrentWriter.Write(mLighting)
            If CurrentWriter.Write_CrypticS_StructArray(mInput) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mCondition) = False Then Return False
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            CurrentWriter.Write(mPerformanceRadius)
            CurrentWriter.Write(mOnForceRadius)
            CurrentWriter.Write(mAnimScale)
            CurrentWriter.Write_CrypticS_Vector3(mClampMinScale)
            CurrentWriter.Write_CrypticS_Vector3(mClampMaxScale)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mFxInfo = 
            mName = CurrentReader.Read_CrypticS_String
            mFileAge = CurrentReader.Read_CrypticS_TimeStamp
            mLifeSpan = CurrentReader.ReadInt32
            mLighting = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_FX_Input), mInput) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_FX_Condition), mCondition) = False Then Return False
            mFlags = CurrentReader.Read_CrypticS_Flags
            mPerformanceRadius = CurrentReader.ReadSingle
            mOnForceRadius = CurrentReader.ReadSingle
            mAnimScale = CurrentReader.ReadSingle
            mClampMinScale = CurrentReader.Read_CrypticS_Vector3
            mClampMaxScale = CurrentReader.Read_CrypticS_Vector3
            Return True
        End Function
#End Region

    End Class
End Namespace
