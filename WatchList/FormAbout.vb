Public Class FormAbout

    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = "Version: " & Application.ProductVersion
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim proc As New Process

        With proc.StartInfo
            .FileName = LinkLabel1.Text
            .UseShellExecute = True
            .Verb = "open"
        End With
        proc.Start()



    End Sub
End Class