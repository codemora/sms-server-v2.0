Public Class UsersControl
    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel6.Width = (panelButtonTray.Width - 730) / 2
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Add_User.ShowDialog()
    End Sub
End Class
