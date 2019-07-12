Public Class Edit_Staff
    Public deleted_at As DateTime = CDate("12/12/9998")

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListKeys.Items.Clear()
        If ComboBox1.SelectedIndex = 0 Then
            For Each key In getAllKey()
                If Not ListKeys.Items.Contains(key.getLock) Then
                    ListKeys.Items.Add(key.getLock)
                End If
            Next
        ElseIf ComboBox1.SelectedIndex > 0 Then
            For Each key In getAllKey(ComboBox1.SelectedItem)
                If Not ListKeys.Items.Contains(key.getLock) Then
                    ListKeys.Items.Add(key.getLock)
                End If
            Next
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        PictureBox1.Image = My.Resources.Profile_Image
        btnRemove.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ErrorProvider1.Clear()

        If Not (ValidateComboBox(ErrorProvider1, cmbDepartment) And
                ValidateComboBox(ErrorProvider1, cmbPosition) And
                (staff1.selected_staff.getRef = txtStaffRef.Text.Trim Or ValidateStaffRef(ErrorProvider1, txtStaffRef)) And
                ValidateComboBox(ErrorProvider1, cmbGender) And
                ValidateText(ErrorProvider1, txtFullname) And
                (staff1.selected_staff.getPhone = txtPhone.Text.Trim Or ValidateStaffPhoneN0(ErrorProvider1, txtPhone)) And
               (staff1.selected_staff.getEmail = txtEmail.Text.Trim Or ValidateEmail(ErrorProvider1, txtEmail))) Then
            Exit Sub
        End If

        'creates the staff object
        Dim staff As New Staff(staff1.selected_staff.getId, txtStaffRef.Text, txtFullname.Text, cmbGender.Text, cmbDepartment.Text, cmbPosition.Text, staff1.selected_staff.getPassCode, txtPhone.Text, txtEmail.Text, staff1.selected_staff.getSecurityQuestion, staff1.selected_staff.getSecurityAnswer, ConvertToByteArray(PictureBox1.Image), staff1.selected_staff.getIsActive, staff1.selected_staff.getDeletedAt, staff1.selected_staff.getCreatedAt, Now())

        'Creates a list of keys the staff can have access to
        Dim keystaffs As New List(Of KeyStaff)
        For Each key In ListKeys.CheckedItems
            Dim key_staff As New KeyStaff(0, staff1.selected_staff.getId, getKeyId(key), False, Now, Now)
            keystaffs.Add(key_staff)
        Next

        If keystaffs.Count > 0 Then
            If updateStaff(staff) Then ' And deleteKeyStaff(staff) And addKeyStaff(keystaffs) Then
                staff1.UpdateRecord(staff1.selected_item, staff)
                message = "Update Successful"
                ShowMessage(staff1.Timer1, staff1.lblMsg, Color.LimeGreen, message)
                Reset()
                Me.Close()
            Else
                message = "Update failed"
                ShowMessage(staff1.Timer1, staff1.lblMsg, Color.Red, message)
            End If
        Else
            message = "Atleast 1 key must be selected"
        ShowMessage(Timer1, lblMsg, Color.Red, message)
        End If

    End Sub

    Private Sub StaffUpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        With staff1.selected_staff
            txtStaffRef.Text = .getRef
            If .getRef = "" Then txtStaffRef.Enabled = True : btnGenerateID.Enabled = True : btnClear.Enabled = False
            txtFullname.Text = .getFullname
            txtEmail.Text = .getEmail
            txtPhone.Text = .getPhone
            PictureBox1.Image = ConvertToImage(.getImage)
            cmbDepartment.Text = .getDepartment
            cmbGender.Text = .getGender
            cmbPosition.Text = .getPosition
            ComboBox1.SelectedIndex = 0
            For Each key In getAllKey()
                If Not ListKeys.Items.Contains(key.getLock) Then
                    ListKeys.Items.Add(key.getLock)
                End If
            Next
            For Each key_staff In getAllKeyStaffByStaffId(.getId)
                ListKeys.SetItemCheckState(ListKeys.Items.IndexOf(getKeyById(key_staff.getKeyId).getLock), CheckState.Checked)
            Next
        End With

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseMessage(Timer1, lblMsg)
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStaffRef.Clear()
        txtStaffRef.Enabled = True
        txtStaffRef.Focus()
        btnClear.Enabled = False
        deleted_at = CDate("12/12/9998")
    End Sub

    Private Sub btnGenerateID_Click(sender As Object, e As EventArgs) Handles btnGenerateID.Click
        Dim idGen As New TempIDGenerator
        idGen.ComboBox1.SelectedItem = cmbPosition.SelectedItem
        idGen.ShowDialog(Me)
    End Sub
    Private Sub cmbPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPosition.SelectedIndexChanged

        Select Case cmbPosition.SelectedItem.ToString.ToLower
            Case "National Service Person".ToLower, "Casual Staff".ToLower, "Casual Labourer".ToLower, "Intern".ToLower
                btnGenerateID.Enabled = True
            Case Else
                btnGenerateID.Enabled = False
        End Select
    End Sub

    Private Sub cmbDepartment_Leave(sender As Object, e As EventArgs) Handles cmbDepartment.Leave
        ValidateComboBox(ErrorProvider1, sender)
    End Sub

    Private Sub txtStaffRef_Leave(sender As Object, e As EventArgs) Handles txtStaffRef.Leave
        If Not (staff1.selected_staff.getRef = txtStaffRef.Text.Trim) Then ValidateStaffRef(ErrorProvider1, txtStaffRef)
    End Sub

    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        If Not (staff1.selected_staff.getPhone = txtPhone.Text.Trim) Then ValidateStaffPhoneN0(ErrorProvider1, txtPhone)
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If Not (staff1.selected_staff.getEmail = txtEmail.Text.Trim) Then ValidateEmail(ErrorProvider1, txtEmail)
    End Sub

    Private Sub Edit_Staff_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cmbDepartment.Focus()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If uploadImg(upload, PictureBox1) Then
            btnRemove.Enabled = True
        Else
            btnRemove.Enabled = False
        End If
    End Sub

    Private Sub Reset()
        txtStaffRef.Clear()
        txtStaffRef.Enabled = True
        txtFullname.Clear()
        cmbGender.SelectedIndex = 0
        cmbDepartment.SelectedIndex = 0
        cmbPosition.SelectedIndex = 0
        txtPhone.Clear()
        txtEmail.Clear()
        ComboBox1.SelectedIndex = 0
        PictureBox1.Image = My.Resources.Profile_Image
        btnRemove.Enabled = False
        ErrorProvider1.Clear()
        deleted_at = CDate("12/12/9998")
        For Each itm In ListKeys.CheckedIndices
            ListKeys.SetItemChecked(itm, False)
        Next
        cmbDepartment.Focus()
    End Sub
End Class