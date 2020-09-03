Imports System.Text.RegularExpressions
Public Class Add_Staff

    Public deleted_at As DateTime = CDate("12/12/9998")


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, Panel1.DisplayRectangle, Color.White, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FormStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbDepartment.Focus()
        ComboBox1.SelectedIndex = 0
        cmbDepartment.SelectedIndex = 0
        cmbGender.SelectedIndex = 0
        cmbPosition.SelectedIndex = 0

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListKeys.Items.Clear()
        Dim keys As List(Of Key)
        If ComboBox1.SelectedIndex < 1 Then
            keys = getAllKey()
        Else
            keys = getAllKey(ComboBox1.SelectedItem)
        End If
        For Each key In keys
            If Not ListKeys.Items.Contains(key.getLock) Then
                ListKeys.Items.Add(key.getLock)
            End If
        Next
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not (ValidateComboBox(ErrorProvider1, cmbDepartment) And
                ValidateComboBox(ErrorProvider1, cmbPosition) And
                ValidateStaffRef(ErrorProvider1, txtStaffRef) And
                ValidateComboBox(ErrorProvider1, cmbGender) And
                ValidateText(ErrorProvider1, txtFullname) And
                ValidateStaffPhoneN0(ErrorProvider1, txtPhone) And
                ValidateEmail(ErrorProvider1, txtEmail)) Then
            Exit Sub
        End If
        'creates the staff object
        Dim staff As New Staff(0, txtStaffRef.Text, txtFullname.Text, cmbGender.Text, cmbDepartment.Text, cmbPosition.Text, Nothing, txtPhone.Text, txtEmail.Text, Nothing, Nothing, ConvertToByteArray(PictureBox1.Image), True, deleted_at, Now(), Now())

        If ListKeys.Items.Count > 0 Then
            message = "Atleast 1 key must be selected"
            ShowMessage(Timer1, lblMsg, Color.Red, message)
            Exit Sub
        End If

        If addStaff(staff) Then
            staff = getStaffByRef(staff.getRef)
            'Creates a list of keys the staff can have access to
            Dim staffkeys As New List(Of KeyStaff)
            For Each key In ListKeys.CheckedItems
                Dim keys As New KeyStaff(0, staff.getId, getKeyId(key), False, Now, Now)
                staffkeys.Add(keys)
            Next
            addKeyStaff(staffkeys)
            staff1.showLoader()
            staff1.addItem(staff)
            staff1.lblCount.Text = staff1.NumOfRecs()
            staff1.hideLoader()
            message = "Registration Successful"
            ShowMessage(Timer1, lblMsg, Color.LimeGreen, message)
            Reset()
            Exit Sub
        Else
            message = "Registration failed"
            ShowMessage(Timer1, lblMsg, Color.Red, message)
            Exit Sub
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseMessage(Timer1, lblMsg)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
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
        ListKeys.ClearSelected()
        cmbDepartment.Focus()
    End Sub

    Private Sub txtFullname_Leave(sender As Object, e As EventArgs) Handles txtFullname.Leave
        ValidateText(ErrorProvider1, sender)
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

    Private Sub cmbDepartment_Leave(sender As Object, e As EventArgs) Handles cmbPosition.Leave, cmbGender.Leave, cmbDepartment.Leave
        ValidateComboBox(ErrorProvider1, sender)
    End Sub

    Private Sub txtStaffRef_Leave(sender As Object, e As EventArgs) Handles txtStaffRef.Leave
        ValidateStaffRef(ErrorProvider1, sender)
    End Sub

    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        ValidateStaffPhoneN0(ErrorProvider1, sender)
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        ValidateEmail(ErrorProvider1, sender)
    End Sub

    Private Sub Add_Staff_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cmbDepartment.Focus()
    End Sub
End Class