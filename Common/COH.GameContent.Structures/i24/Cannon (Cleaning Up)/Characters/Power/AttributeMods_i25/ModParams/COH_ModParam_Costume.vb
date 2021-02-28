Namespace GameContent.Structures.Characters.Powers.ModParams
    Public NotInheritable Class COH_ModParam_Costume
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Costume
            End Get
        End Property
#End Region

#Region "Properties"
        Property Costume As String
            Get
                Return mCostume
            End Get
            Set(value As String)
                SetValue(mCostume, value)
            End Set
        End Property
        <DefaultValue(5)> Property Priority As Int32
            Get
                Return mPriority
            End Get
            Set(value As Int32)
                SetValue(mPriority, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mCostume As String
       Private mPriority As Int32
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
            mCostume = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ModParam_Costume
            Dim Result As COH_ModParam_Costume = New COH_ModParam_Costume
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCostume = CloneString(mCostume)
                .mPriority = mPriority
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mCostume)
            CurrentWriter.Write(mPriority)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mCostume = CurrentReader.Read_CrypticS_String
            mPriority = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
