Public Class Add_Key
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
        'ControlPaint.DrawBorder(e.Graphics, Panel1.DisplayRectangle, Color.LightBlue, ButtonBorderStyle.Solid)
    End Sub

    Private Sub Add_Key_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbKeyType.SelectedIndex = 0
        cmbBlock.SelectedIndex = 0
        NumericUpDown1.Value = 1
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub
    Private Sub Reset()
        cmbKeyType.SelectedIndex = 0
        cmbBlock.SelectedIndex = 0
        NumericUpDown1.Value = 1
        txtTag.Clear()
        txtLock.Clear()
        txtLocation.Clear()
        ErrorProvider1.Clear()
        txtTag.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not (ValidateKeyTag(ErrorProvider1, txtTag) And
                ValidateComboBox(ErrorProvider1, cmbKeyType) And
                ValidateLock(ErrorProvider1, txtLock) And
                ValidateKeyBlock(ErrorProvider1, cmbBlock) And
                ValidateText(ErrorProvider1, txtLocation)) Then
            Exit Sub
        End If

        Dim key As New Key(0, txtTag.Text, cmbKeyType.Text, txtLock.Text, cmbBlock.Text, txtLocation.Text, NumericUpDown1.Value, "In", Now(), Now())

        If addKey(key) Then
            message = "Registration Successful"
            ShowMessage(Timer1, lblMsg, Color.FromArgb(36, 118, 46), message)
            keys1.showLoader()
            keys1.addItem(getKeyByTag(key.getTag))
            keys1.lblCount.Text = keys1.NumOfRecs()
            keys1.hideLoader()
            Reset()
            Exit Sub
        Else
            message = "Registration Failed"
            ShowMessage(Timer1, lblMsg, Color.Red, message)
        End If
    End Sub

    Private Sub Add_Key_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtTag.Focus()
    End Sub

    Private Sub txtTag_Leave(sender As Object, e As EventArgs) Handles txtTag.Leave
        ValidateKeyTag(ErrorProvider1, txtTag)
    End Sub

    Private Sub cmbBlock_Leave(sender As Object, e As EventArgs) Handles cmbBlock.Leave
        ValidateKeyBlock(ErrorProvider1, cmbBlock)
    End Sub

    Private Sub txtLock_Leave(sender As Object, e As EventArgs) Handles txtLock.Leave
        ValidateLock(ErrorProvider1, txtLock)
    End Sub

    Private Sub txtLocation_Leave(sender As Object, e As EventArgs) Handles txtLocation.Leave
        ValidateText(ErrorProvider1, txtLocation)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseMessage(sender, lblMsg)
    End Sub

    Private Sub cmbKeyType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKeyType.SelectedIndexChanged
        If cmbKeyType.SelectedItem.ToString.ToLower = "car" Then
            cmbBlock.SelectedIndex = -1
            cmbBlock.Enabled = False
        Else
            cmbBlock.Enabled = True
            cmbBlock.SelectedIndex = 0
        End If
    End Sub
End Class