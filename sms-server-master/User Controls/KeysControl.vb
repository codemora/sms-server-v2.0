Public Class KeysControl
    Private Sub keys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel6.Width = (panelButtonTray.Width - 572) / 2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Add_Key.ShowDialog()
    End Sub
End Class
