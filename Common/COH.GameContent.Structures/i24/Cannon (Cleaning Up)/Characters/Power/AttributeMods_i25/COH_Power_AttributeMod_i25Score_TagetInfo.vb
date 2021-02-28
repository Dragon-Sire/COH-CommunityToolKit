Namespace GameContent.Structures.Characters.Powers
    Public NotInheritable Class COH_AttribMod_i25Score_TagetInfo
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Target"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Marker As String()
            Get
                Return mMarker
            End Get
            Set(value As String())
                SetValue(mMarker, value)
            End Set
        End Property
        Property Count As Int32()
            Get
                Return mCount
            End Get
            Set(value As Int32())
                SetValue(mCount, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mMarker As String()
       Private mCount As Int32()
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
            mMarker = New String() {}
            mCount = New Int32() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_AttribMod_i25Score_TagetInfo
            Dim Result As COH_AttribMod_i25Score_TagetInfo = New COH_AttribMod_i25Score_TagetInfo
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mMarker = CloneStrings(mMarker)
                .mCount = New Int32(mCount.Count - 1) {} : mCount.CopyTo(.mCount, 0)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_StringArray(mMarker)
            CurrentWriter.Write_CrypticS_IntegerArray(mCount)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mMarker = CurrentReader.Read_CrypticS_StringArray
            mCount = CurrentReader.Read_CrypticS_IntegerArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
