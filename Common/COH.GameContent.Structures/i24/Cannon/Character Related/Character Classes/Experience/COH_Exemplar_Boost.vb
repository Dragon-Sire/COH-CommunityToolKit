Namespace GameContent.Structures.Characters
    Public NotInheritable Class COH_Exemplar_Boost
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Boost"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Limits As Single()
            Get
                Return mLimits
            End Get
            Set(value As Single())
                mLimits = value
            End Set
        End Property
        Property Weights As Single()
            Get
                Return mWeights
            End Get
            Set(value As Single())
                mWeights = value
            End Set
        End Property
        Property PreClamp As Single()
            Get
                Return mPreClamp
            End Get
            Set(value As Single())
                mPreClamp = value
            End Set
        End Property
        Property PostClamp As Single()
            Get
                Return mPostClamp
            End Get
            Set(value As Single())
                mPostClamp = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mLimits As Single()
       Private mWeights As Single()
       Private mPreClamp As Single()
       Private mPostClamp As Single()
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
            mLimits = New Single() {}
            mWeights = New Single() {}
            mPreClamp = New Single() {}
            mPostClamp = New Single() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Exemplar_Boost
            Dim Result As COH_Exemplar_Boost = New COH_Exemplar_Boost
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mLimits = New Single(mLimits.Count - 1) {} : mLimits.CopyTo(.mLimits, 0)
                .mWeights = New Single(mWeights.Count - 1) {} : mWeights.CopyTo(.mWeights, 0)
                .mPreClamp = New Single(mPreClamp.Count - 1) {} : mPreClamp.CopyTo(.mPreClamp, 0)
                .mPostClamp = New Single(mPostClamp.Count - 1) {} : mPostClamp.CopyTo(.mPostClamp, 0)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_SingleArray(mLimits)
            CurrentWriter.Write_CrypticS_SingleArray(mWeights)
            CurrentWriter.Write_CrypticS_SingleArray(mPreClamp)
            CurrentWriter.Write_CrypticS_SingleArray(mPostClamp)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mLimits = CurrentReader.Read_CrypticS_SingleArray()
            mWeights = CurrentReader.Read_CrypticS_SingleArray()
            mPreClamp = CurrentReader.Read_CrypticS_SingleArray()
            mPostClamp = CurrentReader.Read_CrypticS_SingleArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
