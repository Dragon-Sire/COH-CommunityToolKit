Namespace GameContent.Structures.PlayerCreated.UI
    Public NotInheritable Class COH_UI_PlayerCreated_MapLimit
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Map Limit"
            End Get
        End Property
#End Region

#Region "Properties"
        Property regular_only As Int32()
            Get
                Return mregular_only
            End Get
            Set(value As Int32())
                mregular_only = value
            End Set
        End Property
        Property around_only As Int32()
            Get
                Return maround_only
            End Get
            Set(value As Int32())
                maround_only = value
            End Set
        End Property
        Property around_or_regular As Int32()
            Get
                Return maround_or_regular
            End Get
            Set(value As Int32())
                maround_or_regular = value
            End Set
        End Property
        Property giant_monster As Int32
            Get
                Return mgiant_monster
            End Get
            Set(value As Int32)
                mgiant_monster = value
            End Set
        End Property
        Property wall As Int32()
            Get
                Return mwall
            End Get
            Set(value As Int32())
                mwall = value
            End Set
        End Property
        Property floor As Int32()
            Get
                Return mfloor
            End Get
            Set(value As Int32())
                mfloor = value
            End Set
        End Property
        Property defeat_all As Int32
            Get
                Return mdefeat_all
            End Get
            Set(value As Int32)
                mdefeat_all = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mregular_only As Int32()
       Private maround_only As Int32()
       Private maround_or_regular As Int32()
       Private mgiant_monster As Int32
       Private mwall As Int32()
       Private mfloor As Int32()
       Private mdefeat_all As Int32
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
            mregular_only = New Int32() {}
            maround_only = New Int32() {}
            maround_or_regular = New Int32() {}
            mwall = New Int32() {}
            mfloor = New Int32() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_UI_PlayerCreated_MapLimit
            Dim Result As COH_UI_PlayerCreated_MapLimit = New COH_UI_PlayerCreated_MapLimit
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mregular_only = New Int32(mregular_only.Count - 1) {} : mregular_only.CopyTo(.mregular_only, 0)
                .maround_only = New Int32(maround_only.Count - 1) {} : maround_only.CopyTo(.maround_only, 0)
                .maround_or_regular = New Int32(maround_or_regular.Count - 1) {} : maround_or_regular.CopyTo(.maround_or_regular, 0)
                .mgiant_monster = mgiant_monster
                .mwall = New Int32(mwall.Count - 1) {} : mwall.CopyTo(.mwall, 0)
                .mfloor = New Int32(mfloor.Count - 1) {} : mfloor.CopyTo(.mfloor, 0)
                .mdefeat_all = mdefeat_all
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mMapLimit)
            CurrentWriter.Write_CrypticS_IntegerArray(mregular_only)
            CurrentWriter.Write_CrypticS_IntegerArray(maround_only)
            CurrentWriter.Write_CrypticS_IntegerArray(maround_or_regular)
            CurrentWriter.Write(mgiant_monster)
            CurrentWriter.Write_CrypticS_IntegerArray(mwall)
            CurrentWriter.Write_CrypticS_IntegerArray(mfloor)
            CurrentWriter.Write(mdefeat_all)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mMapLimit = 
            mregular_only = CurrentReader.Read_CrypticS_IntegerArray(4)
            maround_only = CurrentReader.Read_CrypticS_IntegerArray(4)
            maround_or_regular = CurrentReader.Read_CrypticS_IntegerArray(4)
            mgiant_monster = CurrentReader.ReadInt32
            mwall = CurrentReader.Read_CrypticS_IntegerArray(4)
            mfloor = CurrentReader.Read_CrypticS_IntegerArray(4)
            mdefeat_all = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
