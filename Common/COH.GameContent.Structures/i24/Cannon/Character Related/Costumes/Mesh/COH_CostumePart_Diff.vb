Namespace GameContent.Structures.Costumes
    Public NotInheritable Class COH_CostumePart_Diff
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Diff"
            End Get
        End Property
#End Region

#Region "Properties"
        Property BaseCostumeNum As Int32
            Get
                Return mBaseCostumeNum
            End Get
            Set(value As Int32)
                mBaseCostumeNum = value
            End Set
        End Property
        Property DiffCostumePart As COH_CostumePart()
            Get
                Return mDiffCostumePart
            End Get
            Set(value As COH_CostumePart())
                mDiffCostumePart = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mBaseCostumeNum As Int32
       Private mDiffCostumePart As COH_CostumePart()
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
            mDiffCostumePart = New COH_CostumePart() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumePart_Diff
            Dim Result As COH_CostumePart_Diff = New COH_CostumePart_Diff
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mBaseCostumeNum = mBaseCostumeNum
                .mDiffCostumePart = New COH_CostumePart(mDiffCostumePart.Count - 1) {}
                For X = 0 To mDiffCostumePart.Count - 1
                    .mDiffCostumePart(X) = mDiffCostumePart(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mBaseCostumeNum)
            If CurrentWriter.Write_CrypticS_StructArray(mDiffCostumePart) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mBaseCostumeNum = CurrentReader.ReadInt32
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_CostumePart), mDiffCostumePart) = False Then Return False '//OPTIONAL
            Return True
        End Function
#End Region

    End Class
End Namespace
