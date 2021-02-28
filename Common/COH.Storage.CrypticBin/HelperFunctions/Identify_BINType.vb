Imports System.IO
Imports COH.CodeManagement.Enums.Structures
Imports COH.Storage.Serialization

Namespace Helperfunctions.Serialize.PIGG
    <HideModuleName> Public Module HelperFunctions_PIGG
        Public Function Identify_BinType(FilePath As String) As COH_Supported_ContentType
            Dim Result As COH_Supported_ContentType = COH_Supported_ContentType.Unknown
            Dim FileStream = New FileStream(FilePath, FileMode.Open, FileAccess.Read)
            Using CurrentReader = New COH_BinaryReader(FileStream, Text.Encoding.ASCII)
                Result = Identify_BinType(CurrentReader)
            End Using
            Return Result
        End Function
        Public Function Identify_BinType(ByRef CurrentReader As COH_BinaryReader) As COH_Supported_ContentType
            Dim Result As COH_Supported_ContentType = COH_Supported_ContentType.Unknown
            Dim mIdentifier As Byte() = CurrentReader.ReadBytes(8)
            If System.Text.Encoding.ASCII.GetString(mIdentifier) = "CrypticS" Then
                Result = COH_Supported_ContentType.Resource_BIN_CrypticS
            ElseIf BitConverter.ToUInt32(mIdentifier, 0) = 20090521 Then
                Result = COH_Supported_ContentType.Resource_BIN_MessageStore
            End If
            Return Result
        End Function
    End Module
End Namespace