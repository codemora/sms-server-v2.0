Public Class Add_User
    Private Sub Add_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPrivilege.SelectedIndex = 0
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not (ValidateText(ErrorProvider1, txtFullname) And
                ValidateComboBox(ErrorProvider1, cmbPrivilege) And
                ValidateUsername(ErrorProvider1, txtUsername) And
                ValidateUserPhoneN0(ErrorProvider1, txtPhone)) Then
            Exit Sub
        End If

        Dim user As New User(0, txtFullname.Text, cmbPrivilege.Text, txtUsername.Text, My.Settings.DEFAULT_PASSWORD, txtPhone.Text, Nothing, Nothing, ConvertToByteArray(PictureBox1.Image), True, CDate("12/12/9998"), Now, Now)

        If addUser(user) Then
            users1.showLoader()
            users1.addItem(getUserByUsername(user.getUsername))
            users1.lblCount.Text = users1.NumOfRecs()
            users1.hideLoader()
            message = "Registration Successful"
            ShowMessage(Timer1, lblMsg, Color.LimeGreen, message)
            Reset()
            Exit Sub
        Else
            message = "Registration failed"
            ShowMessage(Timer1, lblMsg, Color.Red, message)
        End If

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseMessage(Timer1, lblMsg)
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        ValidateUsername(ErrorProvider1, sender)
    End Sub

    Private Sub cmbPrivilege_Leave(sender As Object, e As EventArgs) Handles cmbPrivilege.Leave
        ValidateComboBox(ErrorProvider1, sender)
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

    Private Sub txtFullname_Leave(sender As Object, e As EventArgs) Handles txtFullname.Leave
        ValidateText(ErrorProvider1, sender)
    End Sub

    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        ValidateUserPhoneN0(ErrorProvider1, sender)
    End Sub

    Private Sub Add_User_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cmbPrivilege.Focus()
    End Sub
End Class