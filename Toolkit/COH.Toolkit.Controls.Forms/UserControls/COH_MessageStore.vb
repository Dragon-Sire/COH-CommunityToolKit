Imports COH.GameContent
Imports COH.GameContent.Enums
Imports COH.GameContent.Structures
Imports COH.Storage.PiggyBin
Imports COH.Storage.PiggyBin.Utilities
Imports COH.Utilities

Namespace Toolkit.Controls.WinForms.UserControls
    Public Class COH_Control_MessageStore

#Region "Private Properties"
        Private mFileSource As String
        Private mMessageTool As COH_BinTool_MessageStore
#End Region

#Region "Prepare Usage"
        Public Sub Prepare_Editor(FilePath As String)
            Select Case HelperFunctions.Serialize.PIGG.Identify_BinType(FilePath)
                Case COH_Supported_ContentType.Resource_BIN_MessageStore
                    mMessageTool = New Utilities.COH_BinTool_MessageStore(FilePath, False)
                    DisplayInfo()
            End Select

        End Sub
        Public Sub Prepare_Editor(Name As String, EntryType As COH_Supported_ContentType, ByRef Bytes As Byte())
            Select Case EntryType
                Case COH_Supported_ContentType.Resource_BIN_MessageStore
                    mMessageTool = New COH_BinTool_MessageStore
                    mMessageTool.OpenExisting_MessageStore(Name, Bytes, False)
                    DisplayInfo()
                Case COH_Supported_ContentType.Resource_BIN_CrypticS
                Case COH_Supported_ContentType.Unknown
            End Select

        End Sub
        Private Sub DisplayInfo()
            Cursor.Current = Cursors.WaitCursor
            Dim Result As COH_FileStructure = Nothing
            Dim TheXML As String = Nothing
            If mMessageTool.MessageStore.Export_ToTextString_XMLFormat(TheXML) = False Then
                XML_View.ViewText("ERROR")
            Else
                XML_View.ViewText(TheXML)
                PropertyGrid1.SelectedObject = mMessageTool.MessageStore
            End If
            Cursor.Current = Cursors.Default
        End Sub
#End Region

    End Class
End Namespace