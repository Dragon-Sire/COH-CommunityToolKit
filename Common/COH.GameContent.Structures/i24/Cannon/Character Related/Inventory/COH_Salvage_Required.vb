Namespace GameContent.Structures.Inventory
    Public NotInheritable Class COH_Salvage_Required
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Salvage Required"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Amount As Int32
            Get
                Return mAmount
            End Get
            Set(value As Int32)
                mAmount = value
            End Set
        End Property
        Property Salvage As String
            Get
                Return mSalvage
            End Get
            Set(value As String)
                mSalvage = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mAmount As Int32
       Private mSalvage As String
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
            mSalvage = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Salvage_Required
            Dim Result As COH_Salvage_Required = New COH_Salvage_Required
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mAmount = mAmount
                .mSalvage = String.Copy(mSalvage)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mAmount)
            CurrentWriter.Write_CrypticS_String(mSalvage)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mAmount = CurrentReader.ReadInt32
            mSalvage = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
