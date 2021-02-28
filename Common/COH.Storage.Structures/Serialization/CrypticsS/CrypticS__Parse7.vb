Imports COH.Storage.Serialization

Namespace Storage.Structures.CrypticsS
    Partial Public Class COH_CrypticS

#Region "Read Structures Parse7"
        Public Function Import_FromStream_Parse7(ByRef CurrentReader As COH_BinaryReader, Optional ShowProgress As Boolean = False) As Boolean
            mParseVersionUsed = CodeManagement.Enums.Structures.COH_BinaryFormat.CrypticsS_Parse7
            CurrentReader.Settings.Argument = CurrentReader.Read_CrypticS_String_Parse7BIN
            CurrentReader.Settings.Option_Version = 7
            Entries = New List(Of COH_CrypticS_FileEntry)
            Return Create_FromStream_RootSections(CurrentReader, ShowProgress)
        End Function
#End Region
    End Class
End Namespace