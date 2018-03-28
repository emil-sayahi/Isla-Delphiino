Imports System.IO
Imports System.Net
Public Class mainForm
    Private WithEvents httpclient As WebClient
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        percent.Text = ""
        Dim FileDelete As String

        FileDelete = "log.txt"

        If System.IO.File.Exists(FileDelete) = True Then
            System.IO.File.Delete(FileDelete)
        End If
        percent.Font = New Font("FOT-RodinBokutoh Pro", 14, FontStyle.Regular)
        BuildLabel.Font = New Font("FOT-RodinBokutoh Pro", 20, FontStyle.Regular)
        titleLabel.Font = New Font("FOT-RodinBokutoh Pro DB", 20, FontStyle.Regular)
        BuildLabel.Parent = Build
        titleLabel.Parent = systemTop
        BuildLabel.BringToFront()
        BuildLabel.Location = New Point(115, 8)
    End Sub

    Private Sub Build_Click(sender As Object, e As EventArgs) Handles Build.Click
        Process.Start("cmd", "/c git > log.txt")
        Threading.Thread.Sleep(500)
        Dim text As String = File.ReadAllText("log.txt")
        Dim index As Integer = text.IndexOf("'git' is not recognized")
        If index >= 0 Then
            ' String is in file, starting at character "index"
            Build.Enabled = False
            httpclient = New WebClient
            AddHandler httpclient.DownloadFileCompleted, AddressOf Downloaded
            httpclient.DownloadFileAsync(New Uri("https://github.com/git-for-windows/git/releases/download/v2.14.1.windows.1/Git-2.14.1-64-bit.exe"), ("Git.exe"))
        Else
            Build.Enabled = False
            httpclient = New WebClient
            AddHandler httpclient.DownloadFileCompleted, AddressOf Downloaded
            httpclient.DownloadFileAsync(New Uri("https://go.microsoft.com/fwlink/p/?linkid=845298"), ("winsdksetup.exe"))

            Process.Start("cmd", "/c Isla Delphiino.bat")
        End If

    End Sub
    Private Sub Downloaded()


        If System.IO.File.Exists("Git.exe") = True Then
            Build.Enabled = False

            Dim FileDelete As String

            FileDelete = "log.txt"

            If System.IO.File.Exists(FileDelete) = True Then
                System.IO.File.Delete(FileDelete)
            End If
            Process.Start("cmd", "/c Isla Delphiino.bat")

        End If
    End Sub
    Private Sub dpc(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles httpclient.DownloadProgressChanged
        percent.Text = e.ProgressPercentage
    End Sub

    Private Sub Build_MouseHover(sender As Object, e As EventArgs) Handles Build.MouseHover
        Build.Image = My.Resources.ResourceManager.GetObject("systemButtonHighlight")
    End Sub

    Private Sub Build_MouseLeave(sender As Object, e As EventArgs) Handles Build.MouseLeave
        Build.Image = My.Resources.ResourceManager.GetObject("systemButton")
    End Sub

    Private Sub BuildLabel_Click(sender As Object, e As EventArgs) Handles BuildLabel.Click
        Process.Start("cmd", "/c git > log.txt")
        Threading.Thread.Sleep(500)
        Dim text As String = File.ReadAllText("log.txt")
        Dim index As Integer = text.IndexOf("'git' is not recognized")
        If index >= 0 Then
            ' String is in file, starting at character "index"
            Build.Enabled = False
            httpclient = New WebClient
            AddHandler httpclient.DownloadFileCompleted, AddressOf Downloaded
            httpclient.DownloadFileAsync(New Uri("https://github.com/git-for-windows/git/releases/download/v2.14.1.windows.1/Git-2.14.1-64-bit.exe"), ("Git.exe"))
        Else
            Build.Enabled = False
            httpclient = New WebClient
            AddHandler httpclient.DownloadFileCompleted, AddressOf Downloaded
            httpclient.DownloadFileAsync(New Uri("https://go.microsoft.com/fwlink/p/?linkid=845298"), ("winsdksetup.exe"))

            Process.Start("cmd", "/c Isla Delphiino.bat")
        End If

    End Sub

    Private Sub BuildLabel_MouseHover(sender As Object, e As EventArgs) Handles BuildLabel.MouseHover
        Build.Image = My.Resources.ResourceManager.GetObject("systemButtonHighlight")
    End Sub

    Private Sub BuildLabel_MouseLeave(sender As Object, e As EventArgs) Handles BuildLabel.MouseLeave
        Build.Image = My.Resources.ResourceManager.GetObject("systemButton")
    End Sub
End Class
