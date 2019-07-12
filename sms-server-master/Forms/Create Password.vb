Public Class Create_Password
    Dim user As User = getUserById(My.Settings.USER_ID)
    Private Sub pboxEye_MouseDown(sender As Object, e As MouseEventArgs)
        txtConfirmPassword.UseSystemPasswordChar = False
        pboxEye.Image = My.Resources._006_eye
        pboxEye.BackColor = Color.Black
    End Sub

    Private Sub pboxEye_MouseUp(sender As Object, e As MouseEventArgs)
        txtConfirmPassword.UseSystemPasswordChar = True
        pboxEye.Image = My.Resources.eye_1
        pboxEye.BackColor = Color.White
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)
        If txtConfirmPassword.Text <> "" Then
            pboxEye.Visible = True
        Else
            pboxEye.Visible = False
        End If
    End Sub

    Private Sub Create_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSecurityQuestion.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Dim new_user As New User(user.getId, user.getFullname, user.getPrivilege, user.getUsername, txtPassword.Text, user.getPhone, cmbSecurityQuestion.Text, txtSecurityAnswer.Text, user.getImage, user.getIsActive, user.getDeletedAt, user.getCreatedAt, user.getUpdatedAt)
        If updateUser(new_user) Then
            Dashboard.Show()
            Log_In.Close()
            Me.Close()
        End If

    End Sub

End Class