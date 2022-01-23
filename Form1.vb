Public Class BetaNetBrowser
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub forwardBtn_Click(sender As Object, e As EventArgs) Handles forwardBtn.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        WebBrowser1.Navigate("https://mass.my.id/betanetbrowser")
    End Sub

    Private Sub goBtn_Click(sender As Object, e As EventArgs) Handles goBtn.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://mass.my.id/betanetbrowser")
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub
End Class
