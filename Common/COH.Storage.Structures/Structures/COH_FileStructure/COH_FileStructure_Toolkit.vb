#If EDITOR Then
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports COH.CodeManagement.Enums.Structures
Imports COH.CodeManagement.Interfaces.Structures
Imports COH.Storage.Serialization
Imports COH.Storage.Serialization.Configuration
#End If

Namespace Storage.Structures
#If EDITOR Then
    Partial Public Class COH_FileStructure
#Region "Properties - Project Handling"
        <Browsable(False)> MustOverride ReadOnly Property InternalDisplayName As String Implements ISupport_COH_DisplayName.InternalDisplayName
        <XmlAttribute> <Category("_ProjectFile")> Property Build As COH_BuildType
            Get
                Return pBuild
            End Get
            Set(value As COH_BuildType)
                pBuild = value
            End Set
        End Property
        <XmlAttribute> <Category("_ProjectFile")> Property BinVersion As COH_BinaryFormat
            Get
                Return pBinVersion
            End Get
            Set(value As COH_BinaryFormat)
                pBinVersion = value
            End Set
        End Property
        Private pBuild As COH_BuildType
        Private pBinVersion As COH_BinaryFormat
#End Region

#Region "Create New Instances"
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            If SetDefaults = True Then ResetDefaults(Version)
            pValid = True
            pBuild = BuildType
            pBinVersion = Version
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings As COH_Serialization_Settings = Nothing)
            If Settings Is Nothing Then Settings = New COH_Serialization_Settings(True, COH_ExportFormat.Unspecified)
            ResetDefaults(Settings.Option_Version)
            pValid = Import_From_Buffer(Buffer, Settings)
            Update_FromSettings(Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings As COH_Serialization_Settings = Nothing)
            If Settings Is Nothing Then Settings = New COH_Serialization_Settings(True, COH_ExportFormat.Unspecified)
            ResetDefaults(Settings.Option_Version)
            pValid = Import_From_MemoryStream(Stream, Settings)
            Update_FromSettings(Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            If CurrentReader.Settings Is Nothing Then CurrentReader.Settings = New COH_Serialization_Settings(True, COH_ExportFormat.Unspecified)
            ResetDefaults(CurrentReader.Settings.Option_Version)
            pValid = Import_From_Stream(CurrentReader)
            Update_FromSettings(CurrentReader.Settings)
        End Sub
        Public Sub Update_FromSettings(ByRef Settings As COH_Serialization_Settings)
            pBinVersion = Settings.Option_Version
            pBuild = Settings.Option_Build
        End Sub
#End Region

#Region "Initialize"
        Public Overridable Sub ResetDefaults(Optional Version As Integer = 0)
            pBuild = COH_BuildType.Either
            pBinVersion = COH_BinaryFormat.CrypticsS_Parse6
        End Sub
        Public Overrides Function ToString() As String
            Return InternalDisplayName
        End Function
        Public Sub ForceNotValid()
            pValid = False
        End Sub
#End Region
#Region "Property Changed"
        Public Event WasModified As PropertyChangedEventHandler
        Protected Function SetValue(Of T)(ByRef backingField As T, ByVal value As T, <Runtime.CompilerServices.CallerMemberName> ByVal Optional PropertyName As String = "") As Boolean
            If Object.Equals(backingField, value) Then
                Return False
            End If
            backingField = value
            UpdateModified(PropertyName)
            OnModified()
            Return True
        End Function
        Protected Sub UpdateModified(Optional PropertyName As String = "")
            RaiseEvent WasModified(Me, New PropertyChangedEventArgs(PropertyName))
        End Sub
        Protected Overridable Sub OnModified()
        End Sub
#End Region
#Region "ProjectRelated"
        Public Overridable Function EntryType() As COH_Supported_ContentType
            Return COH_Supported_ContentType.GameContent_Struct
        End Function
        Public Overridable Function Default_CrypricSExtention() As String
            Return "DEF"
        End Function
        Public Overridable Function Default_BinaryExtention() As String
            Return "RAW"
        End Function
        Public Overridable Function Retrieve_OriginolSourceReference() As String
            Return ""
        End Function
        Public Overridable Function Retrieve_LookupName() As String
            Return InternalDisplayName
        End Function
        Public Function CurrentInstance_Valid() As Boolean
            Return pValid
        End Function
#End Region
#Region "Update From MAP"
        Public Overridable Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region
#Region "Clone"
        Protected Function CreateClone() As Object
            'Dim TheStream As IO.MemoryStream = Export_ToStream()
            'Dim TheResult As IDS_Structure = Activator.CreateInstance(Me.GetType)
            'Dim CurrentReader As New FlexStreamEditor(TheStream)
            'CurrentReader.Position = 0
            'TheResult.Read_FromStream(CurrentReader)
            'CurrentReader.CloseStream()
            'Return TheResult
        End Function
#End Region
    End Class
#End If
End Namespace
