Namespace GameContent.Structures.World.Monorail
    Public NotInheritable Class COH_Monorail
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
        Property Title As String
            Get
                Return mTitle
            End Get
            Set(value As String)
                mTitle = value
            End Set
        End Property
        Property Logo As String
            Get
                Return mLogo
            End Get
            Set(value As String)
                mLogo = value
            End Set
        End Property
        Property [Stop] As COH_Monorail_LineStop()
            Get
                Return mStop
            End Get
            Set(value As COH_Monorail_LineStop())
                mStop = value
            End Set
        End Property
        Property ZoneTransferDoorTypes As String()
            Get
                Return mZoneTransferDoorTypes
            End Get
            Set(value As String())
                mZoneTransferDoorTypes = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mTitle As String
       Private mLogo As String
       Private mStop As COH_Monorail_LineStop()
       Private mZoneTransferDoorTypes As String()
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
            mName = String.Empty
            mTitle = String.Empty
            mLogo = String.Empty
            mStop = New COH_Monorail_LineStop() {}
            mZoneTransferDoorTypes = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Monorail
            Dim Result As COH_Monorail = New COH_Monorail
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mTitle = String.Copy(mTitle)
                .mLogo = String.Copy(mLogo)
                .mStop = New COH_Monorail_LineStop(mStop.Count - 1) {}
                For X = 0 To mStop.Count - 1
                    .mStop(X) = mStop(X).Clone
                Next
                .mZoneTransferDoorTypes = mZoneTransferDoorTypes.CloneTheStrings
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            '!!IGNORED!! m{)
            CurrentWriter.Write_CrypticS_String(mTitle)
            CurrentWriter.Write_CrypticS_String(mLogo)
            If CurrentWriter.Write_CrypticS_StructArray(mStop) = False Then Return False
            CurrentWriter.Write_CrypticS_StringArray(mZoneTransferDoorTypes)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            '!!IGNORED!! m{ = 
            mTitle = CurrentReader.Read_CrypticS_String
            mLogo = CurrentReader.Read_CrypticS_String
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Monorail_LineStop), mStop) = False Then Return False
            mZoneTransferDoorTypes = CurrentReader.Read_CrypticS_StringArray()
            Return True
        End Function
#End Region

    End Class
End Namespace
