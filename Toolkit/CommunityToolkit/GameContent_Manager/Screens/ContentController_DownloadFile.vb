Imports System.Net
Imports COH.Tools.Internal.Enums

Namespace Internal.ContentController

    Partial Public NotInheritable Class COH_ContentController

#Region "Private Properties"
        Private WithEvents mWebClient As WebClient
        Private WithEvents mFileDownloading As String
#End Region

        Public Sub Download_GitForWindows()
            ProgressDisplay_Create("Downloading Git For Windows", 0, 100, 0)
            mWebClient = New WebClient()
            mFileDownloading = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources) & "\Git_Install.exe"
            mWebClient.DownloadFileAsync(New Uri("https://github.com/git-for-windows/git/releases/download/v2.22.0.windows.1/Git-2.22.0-64-bit.exe"), mFileDownloading)
        End Sub
        Public Sub DownloadProgress(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles mWebClient.DownloadProgressChanged
            ProgressDisplay_UpdateValue("Downloading Git For Windows", e.ProgressPercentage)
        End Sub
        Public Sub DownloadCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles mWebClient.DownloadFileCompleted
            ShowMessage_Simple("Download Complete")
            ProgressDisplay_Destroy()
            If IO.File.Exists(mFileDownloading) = True And mFileDownloading.Contains("exe") = True Then
                Dim p As Process = New Process()
                Dim psi As ProcessStartInfo = New ProcessStartInfo()
                psi.FileName = mFileDownloading
                psi.Arguments = ""
                p.StartInfo = psi
                p.Start()
                p.WaitForExit()
            End If
        End Sub

    End Class
End Namespace