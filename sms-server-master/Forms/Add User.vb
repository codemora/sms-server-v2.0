Public Class Add_User
    Private Sub Add_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPrivilege.SelectedIndex = 0
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim user As New User(0, txtLastName.Text, txtOtherNames.Text, cmbPrivilege.Text, txtUsername.Text, My.Settings.DEFAULT_PASSWORD, txtPhone.Text, Nothing, Nothing, ConvertToByteArray(PictureBox1.Image), True, CDate("12/31/9999"), Now, Now)

        If Not IsExistUsername(user.getUsername) Then
            If addUser(user) Then
                message = "Operation Successful"
                ShowMessage(Timer1, lblMsg, Color.LimeGreen, message)
                Reset()
                Exit Sub
            Else
                message = "Operation failed"
                ShowMessage(Timer1, lblMsg, Color.Red, message)
            End If
        Else
            message = "User already Exist"
        End If
        ShowMessage(Timer1, lblMsg, Color.Red, message)

        'Dim user1 = getUser(user.getUsername)
        'MessageBox.Show(user1.getId + " " + user1.getUsername + " " + user1.getPassword + " " + user1.getPrivilege + " " + user1.getDateCreated + " " + user1.getDateModified)
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub Reset()
        cmbPrivilege.SelectedIndex = 0
        txtOtherNames.Clear()
        txtLastName.Clear()
        txtUsername.Clear()
        txtPhone.Clear()
        PictureBox1.Image = My.Resources._006_user
        btnRemove.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseMessage(Timer1, lblMsg)
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If IsExistUsername(txtUsername.Text.Trim) Then
            ErrorProvider1.SetError(txtUsername, "User already exist!")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub cmbPrivilege_Leave(sender As Object, e As EventArgs) Handles cmbPrivilege.Leave
        If cmbPrivilege.SelectedIndex = 0 Then
            ErrorProvider1.SetError(cmbPrivilege, "Field must not be empty")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If uploadImg(upload, PictureBox1) Then
            btnRemove.Enabled = True
        Else
            btnRemove.Enabled = False

        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        PictureBox1.Image = My.Resources._006_user
        btnRemove.Enabled = False

    End Sub
End Class