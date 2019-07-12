Public Class Log_In

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, Panel1.DisplayRectangle, Color.LightBlue, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If txtUsername.Text.Trim = "" Or txtPassword.Text.Trim = "" Then
            lblError.Text = "Please Fill All Fields"
        ElseIf checkUser(txtUsername.Text.Trim, txtPassword.Text.Trim) Then
            Dim user As User = getUserByUsername(txtUsername.Text.Trim)
            My.Settings.DISPLAY_NAME = getDisplayName(user.getFullname)
            My.Settings.PRIVILEGE = user.getPrivilege
            My.Settings.USER_ID = user.getId
            My.Settings.DISPLAY_IMAGE = convertByteToString(user.getImage)
            If user.getSecurityQuestion() = "" Or user.getSecurityAnswer() = "" Then
                Create_Password.ShowDialog()
            ElseIf user.getPrivilege.ToLower = "user" Then
                Dashboard.Show()
                Dashboard.btnStaff.Visible = False
                Dashboard.btnUsers.Visible = False
                Dashboard.btnKeys.Visible = False
                Me.Close()
            Else
                Dashboard.Show()
                Me.Close()
            End If
        Else
            lblError.Text = "Incorrect username or password"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As Integer = MessageBox.Show("Sure You Want To Exit", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub pboxEye_MouseDown(sender As Object, e As MouseEventArgs) Handles pboxEye.MouseDown
        txtPassword.UseSystemPasswordChar = False
        pboxEye.Image = My.Resources._006_eye
        pboxEye.BackColor = Color.Black
    End Sub

    Private Sub pboxEye_MouseUp(sender As Object, e As MouseEventArgs) Handles pboxEye.MouseUp
        txtPassword.UseSystemPasswordChar = True
        pboxEye.Image = My.Resources.eye_1
        pboxEye.BackColor = Color.White
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text <> "" Then
            pboxEye.Visible = True
        Else
            pboxEye.Visible = False
        End If
    End Sub

    Private Sub Log_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsExistUser() Then
            Dim user As New User(1, "Administrator", "Admin", "admin", "12345678", "05732325605", "What was the first company you worked for?", "UENR", ConvertToByteArray(My.Resources.Profile_Image), True, CDate("12/12/9998"), Now, Now)
            addUser(user)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class
