Public Class Edit_User
    Private Sub Edit_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With users1.selected_user
            cmbPrivilege.SelectedItem = .getPrivilege
            txtFullname.Text = .getFullname
            txtUsername.Text = .getUsername
            txtPhone.Text = .getPhone
            PictureBox1.Image = ConvertToImage(.getImage)
        End With
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If uploadImg(upload, PictureBox1) Then
            btnRemove.Enabled = True
        Else
            btnRemove.Enabled = False
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        PictureBox1.Image = My.Resources.Profile_Image
        btnRemove.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not (ValidateText(ErrorProvider1, txtFullname) And
                ValidateComboBox(ErrorProvider1, cmbPrivilege) And
                (users1.selected_user.getUsername = txtUsername.Text.Trim Or ValidateUsername(ErrorProvider1, txtUsername)) And
                (users1.selected_user.getPhone = txtPhone.Text.Trim Or ValidateUserPhoneN0(ErrorProvider1, txtPhone))) Then
            Exit Sub
        End If
        Dim user As New User(users1.selected_user.getId, txtFullname.Text, cmbPrivilege.Text, txtUsername.Text, users1.selected_user.getPassword, txtPhone.Text, users1.selected_user.getSecurityQuestion, users1.selected_user.getSecurityAnswer, ConvertToByteArray(PictureBox1.Image), users1.selected_user.getIsActive, users1.selected_user.getDeletedAt, users1.selected_user.getCreatedAt, Now)

        If updateUser(user) Then
            users1.UpdateRecord(users1.selected_item, user)
            message = "Update Successful"
            ShowMessage(users1.Timer1, users1.lblMsg, Color.LimeGreen, message)
            Reset()
            Me.Close()
            Exit Sub
        Else
            message = "Update failed"
            ShowMessage(users1.Timer1, users1.lblMsg, Color.Red, message)
        End If
    End Sub

    Private Sub cmbPrivilege_Leave(sender As Object, e As EventArgs) Handles cmbPrivilege.Leave
        ValidateComboBox(ErrorProvider1, sender)
    End Sub

    Private Sub txtFullname_Leave(sender As Object, e As EventArgs) Handles txtFullname.Leave
        ValidateText(ErrorProvider1, sender)
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If Not users1.selected_user.getUsername = txtUsername.Text.Trim Then ValidateUsername(ErrorProvider1, txtUsername)
    End Sub

    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        If Not (users1.selected_user.getPhone = txtPhone.Text.Trim) Then ValidateUserPhoneN0(ErrorProvider1, txtPhone)
    End Sub

    Private Sub Edit_User_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cmbPrivilege.Focus()
    End Sub

    Private Sub Reset()
        cmbPrivilege.SelectedIndex = 0
        txtFullname.Clear()
        txtUsername.Clear()
        txtPhone.Clear()
        PictureBox1.Image = My.Resources.Profile_Image
        btnRemove.Enabled = False
        ErrorProvider1.Clear()
        cmbPrivilege.Focus()
    End Sub
End Class