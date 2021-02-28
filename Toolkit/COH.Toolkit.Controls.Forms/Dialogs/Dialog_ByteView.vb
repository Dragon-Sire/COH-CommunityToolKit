Imports COH.COH_VirtualByte_Viewer
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Controls.WinForms.COH_VirtualByte_Viewer

Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class Dialog_ByteView

#Region "Initialize"
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
        End Sub
#End Region

#Region "Usage"
        Public Sub LoadFile(TheFile As String, Optional Encoding As BytesEncoding = BytesEncoding.DEFAULT, Optional LeaveOpen As Boolean = True)
            CoH_BytesViewer1.LoadFile(TheFile, Encoding, LeaveOpen)
        End Sub
        Public Sub LoadStream(ByRef theStream As IO.MemoryStream, Optional Encoding As BytesEncoding = BytesEncoding.DEFAULT, Optional LeaveOpen As Boolean = True)
            CoH_BytesViewer1.LoadStream(theStream, Encoding, LeaveOpen)
        End Sub
        Public Sub LoadStream(ByRef ExistingReader As COH_BinaryReader)
            CoH_BytesViewer1.LoadStream(ExistingReader)
        End Sub
#End Region
    End Class
End Namespace