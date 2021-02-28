Imports COH.GameContent.CodeManagement.Enums
Imports COH.GameContent.CodeManagement.Enums.Structures
Imports COH.GameContent.Storage.Controllers
Imports COH.GameContent.Storage.Serialization
Imports COH.Storage.Controllers
Imports COH.Storage.Serialization

Namespace Storage.Structures.CrypticsS
    Partial Public Class COH_CrypticS

#Region "Read Structures Parse6"
        Public Function Import_FromStream_Parse6(ByRef CurrentReader As COH_BinaryReader, Optional ShowProgress As Boolean = False) As Boolean
            mParseVersionUsed = CodeManagement.Enums.Structures.COH_BinaryFormat.CrypticsS_Parse6
            Dim L1 = CurrentReader.ReadInt16
            Dim TempV = System.Text.Encoding.ASCII.GetString(CurrentReader.ReadBytes(L1))
            If Not TempV.Contains("Files") Then Return False
            Dim NumberFiles = TempV.Replace("Files", "")
            If Create_FromStream_FileTable_Entry(CurrentReader, ShowProgress) = False Then Return False
            Return Create_FromStream_RootSections(CurrentReader, ShowProgress)
        End Function
        Private Function Create_FromStream_RootSections(ByRef CurrentReader As COH_BinaryReader, Optional ShowProgress As Boolean = False) As Boolean
            Dim Supported As Boolean = True
            Dim Result As COH_FSI_Entry = Nothing
            Dim IsSingleItem As Boolean = False
            Dim Count As Integer = 0
            If rFileStructs Is Nothing Then
                Count = 1
                Supported = False
            Else
                If rFileStructs.Retrieve_SupportedType(mName, Result) = False Then
                    If rFileStructs.Retrieve_SupportedType(mAdler32CheckSum, Result) = False Then Supported = False
                End If
                If (Result Is Nothing) = True OrElse Result.Sections Is Nothing Then
                    Count = 1
                ElseIf Result.Sections.Count >= 1 Then
                    Count = Result.Sections.Count
                End If
            End If
            mFiles = New List(Of COH_CrypticS_File)
            For X = 0 To Count - 1
                Dim NewFile As COH_CrypticS_File = New COH_CrypticS_File
                NewFile.BinaryTableStarts = CurrentReader.Position
                If Supported = True Then
                    IsSingleItem = Result.SingleRoot
                    NewFile.Update_SupportedType(Result.Sections(X).SectionName, Result.Sections(X).SectionType)
                Else
                    IsSingleItem = False
                    NewFile.Update_SupportedType("Unknown", Nothing)
                End If
                mFiles.Add(NewFile)
                If Update_ContentDetails(Name, IsSingleItem, X, CurrentReader, mFiles(X)) = False Then Return False
                If Not CurrentReader.RemainingBytes <= 20 AndAlso (X = (Count - 1)) Then
                    If Not IsSingleItem Then
                        ' COH_LibraryEventController.ShowErrorOccured_Exception(COH_Event_Error.COH_ErrorEvent.ControlledError, "May Have Additional Structure", Nothing, True)
                        ' COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)
                    End If
                End If
            Next
            If Supported = False Then Return False
            Return True
        End Function
        Private Function Create_FromStream_FileTable_Entry(ByRef CurrentReader As COH_BinaryReader, Optional ShowProgress As Boolean = False) As Boolean
            Entries = New List(Of COH_CrypticS_FileEntry)
            Dim NumBytes = CurrentReader.ReadInt32 '4660
            If NumBytes = 0 Then Return True
            Dim NumberEntries = CurrentReader.ReadInt32 '88
            For X = 0 To NumberEntries - 1
                Dim NewItem As New COH_CrypticS_FileEntry()
                Dim t1 As String = CurrentReader.Read_CrypticS_String()
                Dim t2 As String = CurrentReader.ReadInt32
                Entries.Add(New COH_CrypticS_FileEntry(t1, t2))
            Next
            Return True
        End Function
        Public Function Update_ContentType() As Boolean
            Dim Result As COH_FSI_Entry = Nothing
            If rFileStructs.Retrieve_SupportedType(mName, Result) = False Then
                If rFileStructs.Retrieve_SupportedType(mAdler32CheckSum, Result) = False Then Return False
                Return True
            End If
            For x = 0 To mFiles.Count - 1
                mFiles(x).Update_SupportedType(Result.Sections(x).SectionName, Result.Sections(x).SectionType)
            Next
            Return True
        End Function
        Private Function Update_ContentDetails(Name As String, DoesItContainOnly1Item As Boolean, Index As Integer, ByRef CurrentReader As COH_BinaryReader, ByRef Result As COH_CrypticS_File) As Boolean
            If DoesItContainOnly1Item Then
                Result.Size = CurrentReader.ReadInt32
                Result.NumberContents = 1
                Result.Details.Add(New COH_CrypticS_FileContentDetails() With {.XML_RelativePath = Name, .Size = CurrentReader.RemainingBytes, .Offset = CurrentReader.Position, .FileIndex = 0})
            Else
                If Index = 0 Then Result.Size = CurrentReader.ReadInt32
                Result.NumberContents = CurrentReader.ReadInt32
                Dim NewDetailt_Size As Integer = 0
                Dim NewDetail_Offset As Integer = 0
                Dim NewDetail_Name As String = ""
                For X = 0 To Result.NumberContents - 1
                    NewDetailt_Size = CurrentReader.ReadInt32
                    NewDetail_Offset = CurrentReader.Position
                    NewDetail_Name = CurrentReader.Read_CrypticS_String
                    If String.IsNullOrEmpty(NewDetail_Name) Then NewDetail_Name = Name & " - " & X
                    If NewDetail_Name.Substring(0, 1) = ChrW(0) Then NewDetail_Name = Name & " - " & X
                    Result.Details.Add(New COH_CrypticS_FileContentDetails() With {.XML_RelativePath = NewDetail_Name, .Size = NewDetailt_Size, .Offset = NewDetail_Offset, .FileIndex = X})
                    CurrentReader.Position = (NewDetail_Offset + NewDetailt_Size)
                Next
            End If
            Return True
        End Function
#End Region
    End Class
End Namespace