Imports System.ComponentModel
Imports COH.CodeManagement.Attributes
Imports COH.CodeManagement.Interfaces.Structures
Imports COH.CodeManagement.Interfaces.TOKs
Imports COH.Storage.Serialization

Namespace Storage.Structures.Generics
    <TypeConverter(GetType(COH_FileStructure_ExpandableObjectCoverter))> Public NotInheritable Class CrypticS_NotAligned
        Implements ISupport_COH_Export, ISupport_COH_Import, ISupport_COH_TOK_String

#Region "Properties"
        <Xml.Serialization.XmlAttribute> Property DisplayText As String
        <Xml.Serialization.XmlAttribute> Property IsShort As Boolean = False
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
            ResetDefaults()
        End Sub
        Public Sub New(Value As String, Optional UseShortMarker As Boolean = False)
            DisplayText = Value
            IsShort = UseShortMarker
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader, Optional UseShortMarker As Boolean = False)
            MyBase.New
            IsShort = UseShortMarker
            Import_From_Stream(CurrentReader)
        End Sub
        Public Sub ResetDefaults()
            IsShort = False
            DisplayText = String.Empty
        End Sub
        Public Overrides Function ToString() As String
            If String.IsNullOrEmpty(DisplayText) = True Then
                Return String.Empty
            Else
                Return DisplayText
            End If
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
        Public Shared Widening Operator CType(ByVal value As String) As CrypticS_NotAligned
            Return New CrypticS_NotAligned(value)
        End Operator
        Public Shared Widening Operator CType(ByVal value As CrypticS_NotAligned) As String
            Return value.ToString
        End Operator
#End Region

#Region "Clone"
        Public Function Clone() As CrypticS_NotAligned
            Dim Result As CrypticS_NotAligned = New CrypticS_NotAligned
            With Result
                .DisplayText = String.Copy(DisplayText)
                .IsShort = IsShort
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Public Function Export_To_Stream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean Implements ISupport_COH_Export.Export_To_Stream
            If String.IsNullOrEmpty(DisplayText) Then
                CurrentWriter.Write(CByte(0))
            Else
                If IsShort = True Then
                    CurrentWriter.Write(CShort(DisplayText.Length))
                Else
                    CurrentWriter.Write(CUInt(DisplayText.Length))
                End If
                CurrentWriter.WriteString_NoMarker_UTF8_COH(DisplayText)
            End If
            Return True
        End Function
        Public Function Import_From_Stream(ByRef CurrentReader As COH_BinaryReader) As Boolean Implements ISupport_COH_Import.Import_From_Stream
            Dim Count As UInt32 = 0
            If IsShort = True Then
                Count = CurrentReader.ReadUInt16
            Else
                Count = CurrentReader.ReadUInt32
            End If
            DisplayText = CurrentReader.Read_CrypticS_String_FixedLength_UTF8(Count)
            Return True
        End Function
#End Region

    End Class
End Namespace