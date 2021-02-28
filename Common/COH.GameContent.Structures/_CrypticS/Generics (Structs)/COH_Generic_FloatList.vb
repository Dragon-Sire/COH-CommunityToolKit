Namespace GameContent.Structures.[Shared]
    Public NotInheritable Class COH_Generic_FloatArray
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "GenericFloatList"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Items As Single()
            Get
                Return mItems
            End Get
            Set(value As Single())
                mItems = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mItems As Single()
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
            mItems = New Single() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Generic_FloatArray
            Dim Result As COH_Generic_FloatArray = New COH_Generic_FloatArray
            ''MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mItems = New Single(mItems.Count - 1) {}
                For X = 0 To mItems.Count - 1
                    .mItems(X) = mItems(X)
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If mItems Is Nothing OrElse mItems.Length = 0 Then
                CurrentWriter.Write(CInt(0))
                Return True
            Else
                CurrentWriter.Write(CInt(mItems.Length))
            End If
            For X = 0 To mItems.Length - 1
                CurrentWriter.Write(mItems(X))
            Next
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Dim Count As Integer = CurrentReader.ReadInt32()
            mItems = New Single(Count - 1) {}
            For X = 0 To Count - 1
                mItems(X) = CurrentReader.ReadSingle
            Next
            Return True
        End Function
#End Region

    End Class
End Namespace
