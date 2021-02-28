Imports System.ComponentModel
Imports COH.CodeManagement.Attributes
Imports COH.CodeManagement.Interfaces.Structures
Imports COH.CodeManagement.Interfaces.TOKs
Imports COH.Storage.Serialization

Namespace Storage.Structures.Generics
    <TypeConverter(GetType(COH_FileStructure_ExpandableObjectCoverter))> Public NotInheritable Class CrypticS_StringArray_NotLocalizable
        Implements ISupport_COH_Export, ISupport_COH_Import, ISupport_COH_TOK_StringArray

#Region "Properties"
        Property TheStrings As String()
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
            ResetDefaults()
        End Sub
        Public Sub New(values As String())
            MyBase.New
            If values Is Nothing Then
                ResetDefaults()
            Else
                TheStrings = values
            End If
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New
            Import_From_Stream(CurrentReader)
        End Sub
        Public Sub ResetDefaults()
            TheStrings = New String() {}
        End Sub
        Public Overrides Function ToString() As String
            If TheStrings Is Nothing Then Return ""
            Return Convert_ToString(True, False)
        End Function
#End Region

#Region "Convert"
        Public Function Convert_ToString(Optional ReturnKeys As Boolean = True, Optional WithQuotes_Array As Boolean = False, Optional WithQuotesItem As Boolean = False) As String Implements ISupport_COH_TOK_StringArray.Convert_ToString
            Dim Result As String() = Convert_ToStrings(ReturnKeys, WithQuotesItem)
            If WithQuotes_Array = True AndAlso (Result Is Nothing) = False Then
                Return ChrW(34) & String.Join(", ", Result) & ChrW(34)
            Else
                Return String.Join(", ", Result)
            End If
        End Function
        Public Function Convert_ToStrings(Optional ReturnKeys As Boolean = True, Optional WithQuotes As Boolean = False) As String() Implements ISupport_COH_TOK_StringArray.Convert_ToStrings
            If TheStrings Is Nothing Then Return New String() {}
            If WithQuotes = False Then Return TheStrings
            Dim Result As String() = New String(TheStrings.Count - 1) {}
            For X = 0 To TheStrings.Count - 1
                Result(X) = ChrW(34) & TheStrings(X) & ChrW(34)
            Next
            Return Result
        End Function
#End Region

#Region "Converting"
        Public Shared Widening Operator CType(ByVal values As String()) As CrypticS_StringArray_NotLocalizable
            Return New CrypticS_StringArray_NotLocalizable(values)
        End Operator
        Public Shared Widening Operator CType(ByVal value As CrypticS_StringArray_NotLocalizable) As String()
            Return value.TheStrings
        End Operator
#End Region

#Region "Clone"
        Public Function Clone() As CrypticS_StringArray_NotLocalizable
            Dim Result As CrypticS_StringArray_NotLocalizable = New CrypticS_StringArray_NotLocalizable
            With Result
                ''.TheStrings = TheStrings.CloneTheStrings
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Public Function Export_To_Stream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean Implements ISupport_COH_Export.Export_To_Stream
            If TheStrings Is Nothing OrElse TheStrings.Length = 0 Then
                CurrentWriter.Write(CInt(0))
            Else
                CurrentWriter.Write(CInt(TheStrings.Length))
                For X = 0 To TheStrings.Length - 1
                    CurrentWriter.Write_CrypticS_String(TheStrings(X))
                Next
            End If
            Return True
        End Function
        Public Function Import_From_Stream(ByRef CurrentReader As COH_BinaryReader) As Boolean Implements ISupport_COH_Import.Import_From_Stream
            Dim Count As UInt32 = CurrentReader.ReadInt32()
            TheStrings = New String(Count - 1) {}
            For X = 0 To Count - 1
                TheStrings(X) = CurrentReader.Read_CrypticS_String
            Next
            Return True
        End Function
#End Region

    End Class
End Namespace
