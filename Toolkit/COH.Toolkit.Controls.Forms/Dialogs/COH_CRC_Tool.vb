Imports COH.Toolkit.CodeManagement.Interfaces

Namespace Toolkit.Controls.WinForms.Dialogs

    Public Class COH_CRC_Tool

#Region "Create New Control Instance"
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
        End Sub
#End Region

#Region "Control Usage"
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim Input As String = TextBox1.Text
            If String.IsNullOrEmpty(Input) = True Then Exit Sub
            TextBox2.Text = "P" & COH.HelperFunctions.Cryptic.Calculate_CRC32(Input, COH.HelperFunctions.Cryptic.COH_CRC32_Functions.CRC32_Method.PKZIP)
            TextBox3.Text = "P" & COH.HelperFunctions.Cryptic.Calculate_CRC32(Chr(34) & Input & Chr(34), COH.HelperFunctions.Cryptic.COH_CRC32_Functions.CRC32_Method.PKZIP)
            Dim Path As String = Input.ToLower
            Path = Replace(Path, "\", "/")
            TextBox4.Text = COH.HelperFunctions.Cryptic.Calculate_CRC32_ToHex(Path, COH.HelperFunctions.Cryptic.COH_CRC32_Functions.CRC32_Method.CRC32c_CASTAGNOLI)
        End Sub
#End Region

    End Class
End Namespace