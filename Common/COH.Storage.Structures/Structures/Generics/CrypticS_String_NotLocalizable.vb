Imports COH.CodeManagement.Interfaces.Structures
Imports COH.CodeManagement.Interfaces.TOKs
Imports COH.Storage.Serialization

Namespace Storage.Structures.Generics
    Public NotInheritable Class CrypticS_String_NotLocalizable
        Implements ISupport_COH_Export, ISupport_COH_Import, ISupport_COH_TOK_String

#Region "Properties"
        <Xml.Serialization.XmlAttribute> Property DisplayText As String
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
            ResetDefaults()
        End Sub
        Public Sub New(Display As String)
            MyBase.New
            DisplayText = Display
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New
            Import_From_Stream(CurrentReader)
        End Sub
        Public Sub ResetDefaults()
            DisplayText = String.Empty
        End Sub
        Public Overrides Function ToString() As String
            Return DisplayText
        End Function
#End Region

#Region "Converting"
        Public Function Convert_ToString(Optional ReturnKey As Boolean = True, Optional WithQuotes As Boolean = True) As String Implements ISupport_COH_TOK_String.Convert_ToString
            If WithQuotes = True AndAlso String.IsNullOrEmpty(DisplayText) = False Then
                Return ChrW(34) & DisplayText & ChrW(34)
            Else
                Return DisplayText
            End If
        End Function
        Public Shared Widening Operator CType(ByVal value As String) As CrypticS_String_NotLocalizable
            Return New CrypticS_String_NotLocalizable(value)
        End Operator
        Public Shared Widening Operator CType(ByVal value As CrypticS_String_NotLocalizable) As String
            If value Is Nothing Then Return ""
            Return value.DisplayText
        End Operator
#End Region

#Region "Clone"
        Public Function Clone() As CrypticS_String_NotLocalizable
            Dim Result As CrypticS_String_NotLocalizable = New CrypticS_String_NotLocalizable
            With Result
                .DisplayText = String.Copy(DisplayText)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Public Function Export_To_Stream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean Implements ISupport_COH_Export.Export_To_Stream
            CurrentWriter.Write_CrypticS_String(DisplayText)
            Return True
        End Function
        Public Function Import_From_Stream(ByRef CurrentReader As COH_BinaryReader) As Boolean Implements ISupport_COH_Import.Import_From_Stream
            DisplayText = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace