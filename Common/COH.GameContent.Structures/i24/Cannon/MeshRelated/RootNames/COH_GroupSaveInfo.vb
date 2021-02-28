Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_GroupSaveInfo
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "RootName"
            End Get
        End Property
#End Region

#Region "Properties"
        Property F As COH_GroupSaveInfo_FileEntry()
            Get
                Return mF
            End Get
            Set(value As COH_GroupSaveInfo_FileEntry())
                mF = value
            End Set
        End Property
        Property N As COH_GroupSaveInfo_LibEntry()
            Get
                Return mN
            End Get
            Set(value As COH_GroupSaveInfo_LibEntry())
                mN = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mF As COH_GroupSaveInfo_FileEntry()
       Private mN As COH_GroupSaveInfo_LibEntry()
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mF = New COH_GroupSaveInfo_FileEntry() {}
            mN = New COH_GroupSaveInfo_LibEntry() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_GroupSaveInfo
            Dim Result As COH_GroupSaveInfo = New COH_GroupSaveInfo
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mF = New COH_GroupSaveInfo_FileEntry(mF.Count - 1) {}
                For X = 0 To mF.Count - 1
                    .mF(X) = mF(X).Clone
                Next
                .mN = New COH_GroupSaveInfo_LibEntry(mN.Count - 1) {}
                For X = 0 To mN.Count - 1
                    .mN(X) = mN(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Write_CrypticS_StructArray(mF) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mN) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GroupSaveInfo_FileEntry), mF) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_GroupSaveInfo_LibEntry), mN) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
