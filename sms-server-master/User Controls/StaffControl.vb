Public Class StaffControl
    Public selected_staff As Staff
    Public selected_item As ListViewItem

    Private Sub StaffControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel6.Width = (panelButtonTray.Width - 730) / 2
        ' updateAll(1, 545)
        txtSearch.Focus()
        showLoader()
        staff_data = getAllStaff()
        If getAllStaff.Count = 0 Then
            showNoRecord()
        Else
            fillListView(staff_data)
        End If
        lblCount.Text = NumOfRecs()
    End Sub

    '
    'Fills lvData with staff data List
    '
    Private Sub fillListView(data As List(Of Staff))
        showLoader()
        lvData.Items.Clear()
        For Each staff In data
            addItem(staff)
        Next
        hideLoader()
    End Sub

    Public Sub addItem(staff As Staff)
        Dim newItem As New ListViewItem
        With newItem
            .Text = staff.getId
            .SubItems.Add(staff.getRef)
            .SubItems.Add(staff.getFullname)
            .SubItems.Add(staff.getGender)
            .SubItems.Add(staff.getDepartment)
            .SubItems.Add(staff.getPosition)
            .SubItems.Add(staff.getPhone)
            .SubItems.Add(staff.getEmail)
            .SubItems.Add(staff.getCreatedAt)
            .SubItems.Add(staff.getUpdatedAt)
            If Not staff.getIsActive Then .BackColor = Color.OrangeRed : .ForeColor = Color.White
        End With
        lvData.Items.Add(newItem)
    End Sub

    '
    'Updates lvData record as specific index
    '
    Public Sub UpdateRecord(item As ListViewItem, staff As Staff)

        Dim newItem As New ListViewItem
        With newItem
            .Text = staff.getId
            .SubItems.Add(staff.getRef)
            .SubItems.Add(staff.getFullname)
            .SubItems.Add(staff.getGender)
            .SubItems.Add(staff.getDepartment)
            .SubItems.Add(staff.getPosition)
            .SubItems.Add(staff.getPhone)
            .SubItems.Add(staff.getEmail)
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
        Return lvData.Items.Count.ToString + " Records"
    End Function


    Private Sub lvData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvData.SelectedIndexChanged

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
            btnEditStaff.Enabled = True
        Else
            btnBlockStaff.Enabled = False
            btnViewStaff.Enabled = False
            btnDeleteStaff.Enabled = False
            btnEditStaff.Enabled = False
            btnBlockStaff.Text = "Block Staff"
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseMessage(sender, lblMsg)
    End Sub


    Private Sub btnDeleteStaff_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click
        Dim result As Integer

        result = MessageBox.Show("You Are Deleting Record with Ref '" + selected_staff.getRef + "'", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
                showNoRecord()
            End If
            lblCount.Text = NumOfRecs()
        End If
    End Sub

    Private Sub btnBlockStaff_Click(sender As Object, e As EventArgs) Handles btnBlockStaff.Click
        If blockStaff(selected_staff) Then
            With selected_staff
                selected_staff = New Staff(.getId, .getRef, .getFullname, .getGender, .getDepartment, .getPosition, .getPassCode, .getPhone, .getEmail, .getSecurityQuestion, .getSecurityAnswer, .getImage, Not .getIsActive, .getDeletedAt, .getCreatedAt, .getUpdatedAt)
            End With
            UpdateRecord(selected_item, selected_staff)
        End If
    End Sub

    Private Sub btnViewStaff_Click(sender As Object, e As EventArgs) Handles btnViewStaff.Click
        Dim new_view_staff As New View_Staff
        new_view_staff.ShowDialog()
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        'Dim new_add_staff As New Add_Staff
        Add_Staff.ShowDialog()
    End Sub

    Private Sub btnEditStaff_Click(sender As Object, e As EventArgs) Handles btnEditStaff.Click
        'Dim new_edit_staff As New Edit_Staff
        Edit_Staff.ShowDialog()
    End Sub

    '
    'Show loading label
    '
    Public Sub showLoader()
        lblloader.Text = "Loading..."
        lblloader.Visible = True
        My.Application.DoEvents()
    End Sub

    '
    'hides loading label
    '
    Public Sub hideLoader()
        My.Application.DoEvents()
        lblloader.Visible = False
    End Sub

    '
    'show no records found label
    '
    Public Sub showNoRecord()
        lblloader.Text = "No Records Found"
        lblloader.Visible = True
        My.Application.DoEvents()
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        Dim search As String = txtSearch.Text.Trim
        showLoader()
        staff_data = getAllStaffBySearch(search)
        If staff_data.Count = 0 Then
            showNoRecord()
        Else
            fillListView(staff_data)
        End If
        lblCount.Text = NumOfRecs()
    End Sub

    Public Sub updateAll(start As Integer, finish As Integer)
        Dim staff As Staff
        For i = start To finish
            staff = getStaffById(i)
            With staff
                updateStaff(staff)
            End With
        Next
    End Sub
End Class
