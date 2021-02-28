Namespace GameContent.Structures.Powers
    Public NotInheritable Class COH_Power_AttribReturns_Set
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Set"
            End Get
        End Property
#End Region

#Region "Properties"
        Property [Default] As Int32
            Get
                Return mDefault
            End Get
            Set(value As Int32)
                mDefault = value
            End Set
        End Property
        Property Attrib As COH_Enum_Attrib_CharacterAll()
            Get
                Return mAttrib
            End Get
            Set(value As COH_Enum_Attrib_CharacterAll())
                mAttrib = value
            End Set
        End Property
        Property [Return] As COH_Power_DiminishingReturns()
            Get
                Return mReturn
            End Get
            Set(value As COH_Power_DiminishingReturns())
                mReturn = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mDefault As Int32
       Private mAttrib As COH_Enum_Attrib_CharacterAll()
       Private mReturn As COH_Power_DiminishingReturns()
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
            mReturn = New COH_Power_DiminishingReturns() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Power_AttribReturns_Set
            Dim Result As COH_Power_AttribReturns_Set = New COH_Power_AttribReturns_Set
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDefault = mDefault
                .mAttrib = mAttrib
                .mReturn = New COH_Power_DiminishingReturns(mReturn.Count - 1) {}
                For X = 0 To mReturn.Count - 1
                    .mReturn(X) = mReturn(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mDefault)
            CurrentWriter.Write_CrypticS_IntegerArray(mAttrib)
            If CurrentWriter.Write_CrypticS_StructArray(mReturn) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDefault = CurrentReader.ReadInt32
            mAttrib = CurrentReader.Read_CrypticS_IntegerArray
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Power_DiminishingReturns), mReturn) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
