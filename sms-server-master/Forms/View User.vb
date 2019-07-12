Public Class View_User
    Private Sub View_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As User = users1.selected_user
        With user
            PictureBox1.Image = ConvertToImage(.getImage)
            lblFullname.Text = .getFullname
            lblPhone.Text = .getPhone
            lblPrivilege.Text = .getPrivilege
            lblUsername.Text = "@" + .getUsername.ToUpper
            If .getIsActive Then
                lblActive.Text = "Active"
                lblActive.BackColor = Color.Green
            Else
                lblActive.Text = "Deactivated"
                lblActive.BackColor = Color.Red
            End If
        End With
    End Sub
End Class