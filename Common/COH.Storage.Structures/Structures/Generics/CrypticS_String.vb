Imports System.ComponentModel
Imports COH.CodeManagement.Attributes
Imports COH.CodeManagement.Interfaces.Structures
Imports COH.CodeManagement.Interfaces.TOKs
Imports COH.Storage.Serialization

Namespace Storage.Structures.Generics
    <TypeConverter(GetType(COH_FileStructure_ExpandableObjectCoverter))> Public NotInheritable Class CrypticS_String
        Implements ISupport_COH_Localized, ISupport_COH_Export, ISupport_COH_Import, ISupport_COH_TOK_String

#Region "Properties"
        <Xml.Serialization.XmlAttribute> Property Key As String
        <Xml.Serialization.XmlAttribute> Property DisplayText As String
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
            ResetDefaults()
        End Sub
        Public Sub New(UniqueKey As String)
            MyBase.New
            Key = UniqueKey
            DisplayText = String.Empty
        End Sub
        Public Sub New(UniqueKey As String, Display As String)
            MyBase.New
            Key = UniqueKey
            DisplayText = Display
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New
            Import_From_Stream(CurrentReader)
        End Sub
        Public Sub ResetDefaults()
            Key = String.Empty
            DisplayText = String.Empty
        End Sub
        Public Overrides Function ToString() As String
            If String.IsNullOrEmpty(DisplayText) Then
                Return DisplayText
            Else
                Return Key
            End If
        End Function
#End Region

#Region "Update From MAP"
        Public Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent) Implements ISupport_COH_Localized.UpdateLocalizations
            If LocalizeController Is Nothing Then Exit Sub
            DisplayText = LocalizeController.RetrieveLocalizedString(Key)
        End Sub
#End Region

#Region "Converting"
        Public Function Convert_ToString(Optional ReturnKey As Boolean = True, Optional WithQuotes As Boolean = True) As String Implements ISupport_COH_TOK_String.Convert_ToString
            Dim Result As String = String.Empty
            If ReturnKey = True Then
                Result = Key
            Else
                Result = DisplayText
            End If
            If WithQuotes = True AndAlso String.IsNullOrEmpty(Result) = False Then
                Return ChrW(34) & Result & ChrW(34)
            Else
                Return Result
            End If
        End Function
        Public Shared Widening Operator CType(ByVal value As String) As CrypticS_String
            Return New CrypticS_String(value)
        End Operator
        Public Shared Widening Operator CType(ByVal value As CrypticS_String) As String
            Return value.ToString
        End Operator
#End Region

#Region "Clone"
        Public Function Clone() As CrypticS_String
            Dim Result As CrypticS_String = New CrypticS_String
            With Result
                .Key = String.Copy(Key)
                .DisplayText = String.Copy(DisplayText)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Public Function Export_To_Stream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean Implements ISupport_COH_Export.Export_To_Stream
            CurrentWriter.Write_CrypticS_String(Key)
            Return True
        End Function
        Public Function Import_From_Stream(ByRef CurrentReader As COH_BinaryReader) As Boolean Implements ISupport_COH_Import.Import_From_Stream
            Key = CurrentReader.Read_CrypticS_String
            UpdateLocalizations(CurrentReader.Settings.LocalizeController)
            Return True
        End Function
#End Region

    End Class
End Namespace
