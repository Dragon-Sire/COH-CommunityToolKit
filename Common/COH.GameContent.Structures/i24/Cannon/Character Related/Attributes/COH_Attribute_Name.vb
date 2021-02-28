Namespace GameContent.Structures.[Shared]
    Public Class COH_AttributeName
        inherits COH_FileStructure

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
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property DisplayNameKey As String
            Get
                Return mDisplayNameKey
            End Get
            Set(value As String)
                mDisplayNameKey = value
            End Set
        End Property
        Property IconName As String
            Get
                Return mIconName
            End Get
            Set(value As String)
                mIconName = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mDisplayName As String
       Private mDisplayNameKey As String
       Private mIconName As String
#End Region

#Region "Create New Instances"
        Public Sub New()
            ResetDefaults()
        End Sub
        Private Sub ResetDefaults()
            mName = String.Empty
            mDisplayName = String.Empty
            mDisplayNameKey = String.Empty
            mIconName = String.Empty
        End Sub
        Public Overrides Function ToString() As String
            Return mName
        End Function
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_AttributeName
            Dim Result As COH_AttributeName = New COH_AttributeName
            With Result
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mIconName = String.Copy(mIconName)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - XML"
        Public Shared Function Export_XML_AttributeNames(Folder As String, Name As String, ByRef Items As COH_AttributeName()) As Boolean
            If HelperFunctions.XML.Export_XMLFile(Folder & Name & ".xml", Items) = False Then
                Return False
            End If
            Return True
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Name = CurrentReader.Read_CrypticS_String
            DisplayNameKey = CurrentReader.Read_CrypticS_String
            IconName = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region
    End Class
End Namespace