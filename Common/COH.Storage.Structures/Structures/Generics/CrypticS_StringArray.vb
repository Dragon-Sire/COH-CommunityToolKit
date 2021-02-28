Imports System.ComponentModel
Imports COH.CodeManagement.Attributes
Imports COH.CodeManagement.Interfaces.Structures
Imports COH.CodeManagement.Interfaces.TOKs
Imports COH.Storage.Serialization

Namespace Storage.Structures.Generics
    <TypeConverter(GetType(COH_FileStructure_ExpandableObjectCoverter))> Public NotInheritable Class CrypticS_StringArray
        Implements ISupport_COH_Export, ISupport_COH_Import, ISupport_COH_TOK_StringArray

#Region "Properties"
        Property TheStrings As CrypticS_String()
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
            ResetDefaults()
        End Sub
        Public Sub New(values As String(), Optional TheseAreKeys As Boolean = True)
            MyBase.New
            If values Is Nothing Then
                ResetDefaults()
            Else
                TheStrings = New CrypticS_String(values.Count - 1) {}
                For X = 0 To TheStrings.Count - 1
                    If TheseAreKeys = True Then
                        TheStrings(X) = New CrypticS_String(values(X), String.Empty)
                    Else
                        TheStrings(X) = New CrypticS_String(String.Empty, values(X))
                    End If
                Next
            End If
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New
            Import_From_Stream(CurrentReader)
        End Sub
        Public Sub ResetDefaults()
            TheStrings = New CrypticS_String() {}
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
            Dim Result As String() = New String(TheStrings.Count - 1) {}
            For X = 0 To TheStrings.Count - 1
                Result(X) = TheStrings(X).Convert_ToString(ReturnKeys, WithQuotes)
            Next
            Return Result
        End Function
#End Region

#Region "Converting"
        Public Shared Widening Operator CType(ByVal value As String()) As CrypticS_StringArray
            Return New CrypticS_StringArray(value)
        End Operator
        Public Shared Widening Operator CType(ByVal value As CrypticS_StringArray) As String()
            Return value.Convert_ToStrings
        End Operator
#End Region

#Region "Clone"
        Public Function Clone() As CrypticS_StringArray
            Dim Result As CrypticS_StringArray = New CrypticS_StringArray
            With Result
                .TheStrings = New CrypticS_String(TheStrings.Count - 1) {}
                For x = 0 To TheStrings.Count - 1
                    .TheStrings(x) = TheStrings(x).Clone
                Next
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
                    TheStrings(X).Export_To_Stream(CurrentWriter)
                Next
            End If
            Return True
        End Function
        Public Function Import_From_Stream(ByRef CurrentReader As COH_BinaryReader) As Boolean Implements ISupport_COH_Import.Import_From_Stream
            Dim Count As UInt32 = CurrentReader.ReadInt32()
            TheStrings = New CrypticS_String(Count - 1) {}
            For X = 0 To Count - 1
                TheStrings(X) = New CrypticS_String(CurrentReader)
            Next
            Return True
        End Function
#End Region

    End Class
End Namespace
