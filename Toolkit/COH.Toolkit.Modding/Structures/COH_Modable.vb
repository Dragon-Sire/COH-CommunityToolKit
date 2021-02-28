Imports System.IO
Imports System.Xml.Serialization
Imports COH.CodeManagement.Enums.Structures
Imports COH.CodeManagement.Interfaces.Structures
Imports COH.GameContent
Imports COH.GameContent.Internal.Events
Imports COH.GameContent.Structures
Imports COH.GameContent.Structures.COH_FileStructure
Imports COH.GameContent.Utilities
Imports COH.Storage.Serialization
Imports COH.Storage.Serialization.Configuration
Imports COH.Storage.Structures

Public NotInheritable Class COH_ModableContent
    Implements ISupport_COH_OriginolSources

#Region "Properties - Project Handling"
    <Category("_ProjectFile")> Property FullName As String Implements ISupport_COH_OriginolSources.FullName
        Get
            Return mFullName
        End Get
        Set(value As String)
            mFullName = value
        End Set
    End Property
    <Category("_ProjectFile")> Property RelativePath_Originol As String Implements ISupport_COH_OriginolSources.RelativePath_Originol
        Get
            Return mFilePath_Reference_Original
        End Get
        Set(value As String)
            mFilePath_Reference_Original = value
        End Set
    End Property
    <Category("_ProjectFile")> <XmlAttribute> <ReadOnlyAttribute(True)> Property IsCustom As Boolean Implements ISupport_COH_OriginolSources.IsCustom
        Get
            Return mIsCustom
        End Get
        Set(value As Boolean)
            mIsCustom = value
        End Set
    End Property
    <Category("_ProjectFile")> <XmlAttribute> <ReadOnlyAttribute(True)> Property WasModified_FromSource As Boolean Implements ISupport_COH_OriginolSources.WasModified_FromSource
        Get
            Return mWasModified_FromSource
        End Get
        Set(value As Boolean)
            mWasModified_FromSource = value
        End Set
    End Property
    <Category("_ProjectFile")> <XmlAttribute> Public Property RelativePath_Current As String Implements ISupport_COH_OriginolSources.RelativePath_Current
        Get
            Return mFilePath_Relative_Current
        End Get
        Set(value As String)
            mFilePath_Relative_Current = value
        End Set
    End Property
    <XmlIgnore> Public ReadOnly Property SourceFile As String
        Get
            Return mFullPath
        End Get
    End Property
    <XmlIgnore> Public Property Content As COH_FileStructure Implements ISupport_COH_OriginolSources.Content
#End Region

#Region "Private Properties"
    Private mFullName As String
    Private mFullPath As String
    Private mFilePath_Relative_Current As String
    Private mFilePath_Reference_Original As String
    Private mIsCustom As Boolean
    Private mWasModified_FromSource As Boolean
#End Region

#Region "Create New Instances"
    Public Sub New()
        Me.New(True)
    End Sub
    Public Sub New(SetDefaults As Boolean)
        If SetDefaults = True Then ResetDefaults()
    End Sub
#End Region

#Region "Initialize"
    Protected Sub ResetDefaults()
        mFullName = String.Empty
        mFilePath_Relative_Current = String.Empty
        mFilePath_Reference_Original = String.Empty
        mIsCustom = False
        mWasModified_FromSource = False
    End Sub
#End Region

#Region "MustOverrides"
    Public Sub Initialize_DefaultRelativePath() Implements ISupport_COH_OriginolSources.Initialize_DefaultRelativePath
        mFilePath_Relative_Current = Determine_DefaultRelativeFilePath()
    End Sub
    Protected Function Determine_DefaultRelativeFilePath() As String
        Return Content.Determine_DefaultRelativeFilePath(COH_ExportFormat.XML)
    End Function
#End Region

#Region "Save"
    Public Function Save() As Boolean
        If String.IsNullOrEmpty(mFullPath) = True Then Return False
        Return Export_ToXMLFile(mFullPath, Me)
    End Function
#End Region

#Region "Clone"
    Public Overloads Sub CloneTo(ByRef Destination As COH_ModableContent)
        With Destination
            .mFullName = Helperfunctions.StringsAndThings.CloneString(mFullName)
            .mFilePath_Relative_Current = Helperfunctions.StringsAndThings.CloneString(mFilePath_Relative_Current)
            .mFilePath_Reference_Original = Helperfunctions.StringsAndThings.CloneString(mFilePath_Reference_Original)
            .mIsCustom = mIsCustom
            .mWasModified_FromSource = mWasModified_FromSource
        End With
    End Sub
    Protected Shared Function CreateClone(ByRef Source As Object) As Object
        Dim m As New IO.MemoryStream()
        Dim f As New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        f.Serialize(m, Source)
        m.Seek(0, IO.SeekOrigin.Begin)
        Return f.Deserialize(m)
    End Function
#End Region

#Region "Import/Export"
    Public Shared Function Import_FromXMLFile(Filepath As String, SelectedType As Type, ByRef Result As ISupport_COH_OriginolSources) As Boolean
        Dim ImportXMLResult As ISupport_COH_OriginolSources = Nothing
        Dim ImportResult As Boolean = True
        If IO.File.Exists(Filepath) = True Then
            Try
                Dim Reader As New IO.StreamReader(Filepath)
                Dim x As New XmlSerializer(SelectedType)
                ImportXMLResult = x.Deserialize(Reader)
                Reader.Close()
                TryCast(ImportXMLResult, COH_ModableContent).mFullPath = Filepath
            Catch ex As Exception
                ' COH_LibraryEventController.ShowErrorOccured_Exception(Internal.Events.COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Import XML", ex, True)
                ImportResult = False
            End Try
        End If
        Result = ImportXMLResult
        Return ImportResult
    End Function
    Public Shared Function Export_ToXMLFile(Filepath As String, Source As Object) As Boolean
        Dim NewPath As String = Helperfunctions.XML.COH_HelperFunctions_XML.CleanupFileName(Filepath)
        If IO.Directory.Exists(IO.Path.GetDirectoryName(NewPath)) = False Then IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(NewPath))
        Dim XMlString As String = ""
        Dim ExportResult As Boolean = Export_ToXMLFile_String(Source, XMlString, New COH_Serialization_Settings(True, COH_ExportFormat.XML))
        If ExportResult = False Then Return False
        Try
            File.WriteAllText(NewPath, XMlString)
        Catch ex As Exception
            ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Export XML", ex, True)
            ExportResult = False
        End Try
        Return ExportResult
    End Function
    Public Shared Function Export_ToXMLFile_String(Source As Object, ByRef Result As String, Optional ByRef Settings As COH_Serialization_Settings = Nothing) As Boolean
        Result = ""
        Dim ExportResult As Boolean = True
        Try
            Dim Test As COH_XML_Serialization = New COH_XML_Serialization(Settings)
            Result = Test.Serialize_ToXML(Source)
        Catch ex As Exception
            ' COH_LibraryEventController.ShowErrorOccured_Exception(Internal.Events.COH_Event_Error.COH_ErrorEvent.ControlledError, "Unable to Export XML", ex, True)
            ExportResult = False
        End Try
        Return ExportResult
    End Function
#End Region
End Class
