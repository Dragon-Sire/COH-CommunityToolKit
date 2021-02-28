Namespace GameContent.Structures.Characters.Powers
    Public NotInheritable Class COH_AttribMod_i25Score_Messages
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Messages"
            End Get
        End Property
#End Region

#Region "Properties"
        Property DisplayAttackerHit As CrypticS_String
            Get
                Return mDisplayAttackerHit
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayAttackerHit, value)
            End Set
        End Property
        Property DisplayVictimHit As CrypticS_String
            Get
                Return mDisplayVictimHit
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayVictimHit, value)
            End Set
        End Property
        Property DisplayFloat As CrypticS_String
            Get
                Return mDisplayFloat
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayFloat, value)
            End Set
        End Property
        Property DisplayAttribDefenseFloat As CrypticS_String
            Get
                Return mDisplayAttribDefenseFloat
            End Get
            Set(value As CrypticS_String)
                SetValue(mDisplayAttribDefenseFloat, value)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mDisplayAttackerHit As CrypticS_String
       Private mDisplayVictimHit As CrypticS_String
       Private mDisplayFloat As CrypticS_String
       Private mDisplayAttribDefenseFloat As CrypticS_String
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
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_AttribMod_i25Score_Messages
            Dim Result As COH_AttribMod_i25Score_Messages = New COH_AttribMod_i25Score_Messages
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayAttackerHit = mDisplayAttackerHit.Clone
                .mDisplayVictimHit = mDisplayVictimHit.Clone
                .mDisplayFloat = mDisplayFloat.Clone
                .mDisplayAttribDefenseFloat = mDisplayAttribDefenseFloat.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            mDisplayAttackerHit.Export_To_Stream(CurrentWriter)
            mDisplayVictimHit.Export_To_Stream(CurrentWriter)
            mDisplayFloat.Export_To_Stream(CurrentWriter)
            mDisplayAttribDefenseFloat.Export_To_Stream(CurrentWriter)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDisplayAttackerHit = New CrypticS_String(CurrentReader)
            mDisplayVictimHit = New CrypticS_String(CurrentReader)
            mDisplayFloat = New CrypticS_String(CurrentReader)
            mDisplayAttribDefenseFloat = New CrypticS_String(CurrentReader)
            Return True
        End Function
#End Region

    End Class
End Namespace
