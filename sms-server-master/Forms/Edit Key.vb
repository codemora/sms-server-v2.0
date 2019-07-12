Public Class Edit_Key

    Private Sub UpateKeyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With keys1.selected_key
            txtTag.Text = .getTag
            txtLock.Text = .getLock
            txtLocation.Text = .getLocation
            cmbKeyType.Text = .getKeyType
            cmbBlock.Text = .getBlock
            NumericUpDown1.Value = .getQuantity
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim key As New Key(keys1.selected_key.getId, txtTag.Text, cmbKeyType.Text, txtLock.Text, cmbBlock.Text, txtLocation.Text, NumericUpDown1.Value, "In", keys1.selected_key.getCreatedAt, Now())
        If Not ((key.getTag = keys1.selected_key.getTag Or ValidateKeyTag(ErrorProvider1, txtTag)) And
                ValidateComboBox(ErrorProvider1, cmbKeyType) And
                (key.getLock = keys1.selected_key.getLock Or ValidateLock(ErrorProvider1, txtLock)) And
                ValidateComboBox(ErrorProvider1, cmbBlock) And
                ValidateText(ErrorProvider1, txtLocation)) Then
            Exit Sub
        End If

        If updateKey(key) Then
            keys1.UpdateRecord(keys1.selected_item, key)
            message = "Update Successful"
            ShowMessage(keys1.Timer1, keys1.lblMsg, Color.LimeGreen, message)
            Reset()
            Me.Close()
            Exit Sub
        Else
            message = "Update failed"
            ShowMessage(keys1.Timer1, keys1.lblMsg, Color.Red, message)
        End If
    End Sub

    Private Sub Add_Key_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtTag.Focus()
    End Sub

    Private Sub txtTag_Leave(sender As Object, e As EventArgs) Handles txtTag.Leave
        If Not txtTag.Text.Trim = keys1.selected_key.getTag Then ValidateKeyTag(ErrorProvider1, sender)
    End Sub

    Private Sub cmbBlock_Leave(sender As Object, e As EventArgs) Handles cmbKeyType.Leave, cmbBlock.Leave
        ValidateComboBox(ErrorProvider1, sender)
    End Sub

    Private Sub txtLock_Leave(sender As Object, e As EventArgs) Handles txtLock.Leave
        If Not txtLock.Text.Trim = keys1.selected_key.getLock Then ValidateLock(ErrorProvider1, sender)
    End Sub

    Private Sub txtLocation_Leave(sender As Object, e As EventArgs) Handles txtLocation.Leave
        ValidateText(ErrorProvider1, sender)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseMessage(sender, lblMsg)
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
End Class