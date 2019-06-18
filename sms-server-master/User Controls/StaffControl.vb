Public Class StaffControl
    Public selected_staff As Staff
    Dim selected_item As ListViewItem
    Private Sub staff_Load(sender As Object, e As EventArgs)

    End Sub


    Private Sub StaffControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel6.Width = (panelButtonTray.Width - 730) / 2
        staff_data = getAllStaff()

        If getAllStaff.Count = 0 Then
            lvData.GridLines = False
            'Label19.Visible = True
        Else
            fillListView(staff_data)
        End If
        lblCount.Text = NumOfRecs()
    End Sub

    '
    'Fills listView2 with staff data List
    '
    Private Sub fillListView(data As List(Of Staff))
        For Each staff In data
            Dim newItem As New ListViewItem
            With newItem
                .Text = staff.getId
                .SubItems.Add(staff.getRef)
                .SubItems.Add(staff.getOtherNames + " " + staff.getLastName)
                .SubItems.Add(staff.getGender)
                .SubItems.Add(staff.getDepartment)
                .SubItems.Add(staff.getPosition)
                .SubItems.Add(staff.getPhone + "/" + staff.getSecondPhone)
                .SubItems.Add(staff.getCreatedAt)
                .SubItems.Add(staff.getUpdatedAt)
                If Not staff.getIsActive Then .BackColor = Color.OrangeRed : .ForeColor = Color.White
            End With
            lvData.Items.Add(newItem)
        Next
    End Sub

    '
    'Updates listView2 record as specific index
    '
    Public Sub UpdateRecord(item As ListViewItem, staff As Staff)

        Dim newItem As New ListViewItem
        With newItem
            .Text = staff.getId
            .SubItems.Add(staff.getRef)
            .SubItems.Add(staff.getOtherNames + " " + staff.getLastName)
            .SubItems.Add(staff.getGender)
            .SubItems.Add(staff.getDepartment)
            .SubItems.Add(staff.getPosition)
            .SubItems.Add(staff.getPhone + "/" + staff.getSecondPhone)
            .SubItems.Add(staff.getCreatedAt)
            .SubItems.Add(staff.getUpdatedAt)
            If Not staff.getIsActive Then .BackColor = Color.OrangeRed : .ForeColor = Color.White
        End With
        lvData.Items.Insert(lvData.Items.IndexOf(item), newItem)
        lvData.Items.Remove(item)
    End Sub

    '
    'Returns number of records on display in ListView
    '
    Private Function NumOfRecs() As String
        Return lvData.Items.Count.ToString + " of " + getAllStaff.Count.ToString + " Records"
    End Function


    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvData.SelectedIndexChanged

        If lvData.SelectedItems.Count > 0 Then
            selected_item = lvData.SelectedItems.Item(0)  'gets selected ListView item
            selected_staff = getStaffById(CInt(selected_item.Text))
            If selected_staff.getIsActive Then
                btnBlockStaff.Text = "Block Staff"
            Else
                btnBlockStaff.Text = "Unblock Staff"
            End If
            btnBlockStaff.Enabled = True
            btnViewStaff.Enabled = True
            btnDeleteStaff.Enabled = True
            btnUpdateStaff.Enabled = True
        Else
            btnBlockStaff.Enabled = False
            btnViewStaff.Enabled = False
            btnDeleteStaff.Enabled = False
            btnUpdateStaff.Enabled = False
            btnBlockStaff.Text = "Block Staff"
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        CloseMessage(Timer1, lblMsg)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click
        Dim result As Integer

        result = MessageBox.Show("You Are Deleting Record with key '" + selected_staff.getRef + "'", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If deleteStaff(selected_staff) Then
                lvData.Items.Remove(selected_item)

                message = "Delete Successful"
                ShowMessage(Timer1, lblMsg, Color.LimeGreen, message)
            Else
                message = "Delete Failed"
                ShowMessage(Timer1, lblMsg, Color.Red, message)
            End If
            If getAllStaff.Count = 0 Then
                lvData.GridLines = False
                '  Label19.Visible = True
            End If
            lblCount.Text = NumOfRecs()
        End If
    End Sub

    Private Sub btnBlockStaff_Click(sender As Object, e As EventArgs) Handles btnBlockStaff.Click
        If blockStaff(selected_staff) Then
            With selected_staff
                selected_staff = New Staff(.getId, .getRef, .getLastName, .getOtherNames, .getGender, .getDepartment, .getPosition, .getPassCode, .getPhone, .getSecondPhone, .getSecurityQuestion, .getSecurityAnswer, .getImage, Not .getIsActive, .getDeletedAt, .getCreatedAt, .getUpdatedAt)
            End With
            UpdateRecord(selected_item, selected_staff)
        End If
    End Sub

    Private Sub btnViewStaff_Click(sender As Object, e As EventArgs) Handles btnViewStaff.Click
        View_Staff.ShowDialog()
    End Sub
End Class
