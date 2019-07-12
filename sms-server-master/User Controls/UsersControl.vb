Public Class UsersControl
    Public selected_user As User
    Public selected_item As ListViewItem
    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel6.Width = (panelButtonTray.Width - 730) / 2
        txtSearch.Focus()
        showLoader()
        users_data = getAllUser()
        If users_data.Count = 0 Then
            showNoRecord()
        Else
            fillListView(users_data)
        End If
        lblCount.Text = NumOfRecs()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim new_add_user As New Add_User
        new_add_user.ShowDialog()
    End Sub

    '
    'Fills lvData with staff data List
    '
    Private Sub fillListView(data As List(Of User))
        showLoader()
        lvData.Items.Clear()

        For Each user In data
            addItem(user)
        Next
        hideLoader()
    End Sub

    Public Sub addItem(user As User)
        Dim newItem As New ListViewItem
        With newItem
            .Text = user.getId
            .SubItems.Add(user.getFullname)
            .SubItems.Add(user.getPrivilege)
            .SubItems.Add(user.getUsername)
            .SubItems.Add(user.getPhone)
            .SubItems.Add(user.getCreatedAt)
            .SubItems.Add(user.getUpdatedAt)
            If Not user.getIsActive Then .BackColor = Color.OrangeRed : .ForeColor = Color.White
        End With
        lvData.Items.Add(newItem)
    End Sub


    '
    'Returns number of records on display in ListView
    '
    Private Function NumOfRecs() As String
        Return lvData.Items.Count.ToString + " Records"
    End Function


    '
    'Updates lvData record as specific index
    '
    Public Sub UpdateRecord(item As ListViewItem, user As User)
        Dim newItem As New ListViewItem
        With newItem
            With newItem
                .Text = user.getId
                .SubItems.Add(user.getFullname)
                .SubItems.Add(user.getPrivilege)
                .SubItems.Add(user.getUsername)
                .SubItems.Add(user.getPhone)
                .SubItems.Add(user.getCreatedAt)
                .SubItems.Add(user.getUpdatedAt)
                If Not user.getIsActive Then .BackColor = Color.OrangeRed : .ForeColor = Color.White
            End With
        End With
        lvData.Items.Insert(lvData.Items.IndexOf(item), newItem)
        lvData.Items.Remove(item)
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click

        Dim result As Integer
        result = MessageBox.Show("You Are Deleting User with Username '" + selected_user.getUsername + "'", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If deleteUser(selected_user) Then
                lvData.Items.Remove(selected_item)
                message = "Delete Successful"
                ShowMessage(Timer1, lblMsg, Color.LimeGreen, message)
            Else
                message = "Delete failed"
                ShowMessage(Timer1, lblMsg, Color.Red, message)
            End If
            If getAllUser.Count = 0 Then
                showNoRecord()
            End If
            lblCount.Text = NumOfRecs()
        End If
    End Sub

    Private Sub lvData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvData.SelectedIndexChanged

        If lvData.SelectedItems.Count > 0 Then
            selected_item = lvData.SelectedItems.Item(0)  'gets selected ListView item
            selected_user = getUserById(CInt(selected_item.Text))
            btnViewUser.Enabled = True
            If selected_user.getIsActive Then
                btnBlockUser.Text = "Block User"
            Else
                btnBlockUser.Text = "Unblock User"
            End If
            If selected_user.getPrivilege.ToLower = "user" Then
                btnDeleteUser.Enabled = True
                btnEditUser.Enabled = True
                btnBlockUser.Enabled = True
            Else
                btnDeleteUser.Enabled = False
                btnEditUser.Enabled = False
                btnBlockUser.Enabled = False
            End If
        Else
            btnViewUser.Enabled = False
            btnDeleteUser.Enabled = False
            btnEditUser.Enabled = False
            btnBlockUser.Text = "Block User"
            btnBlockUser.Enabled = False
        End If

    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        Dim new_edit_user As New Edit_User
        new_edit_user.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseMessage(sender, lblMsg)
    End Sub

    Private Sub btnBlockUser_Click(sender As Object, e As EventArgs) Handles btnBlockUser.Click
        If blockUser(selected_user) Then
            With selected_user
                selected_user = New User(.getId, .getFullname, .getPrivilege, .getUsername, .getPassword, .getPhone, .getSecurityQuestion, .getSecurityAnswer, .getImage, Not .getIsActive, .getDeletedAt, .getCreatedAt, Now)
            End With
        End If
        UpdateRecord(selected_item, selected_user)
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
        users_data = getAllUserBySearch(search)
        If users_data.Count = 0 Then
            showNoRecord()
        Else
            fillListView(users_data)
        End If
        lblCount.Text = NumOfRecs()
    End Sub

    Private Sub btnViewUser_Click(sender As Object, e As EventArgs) Handles btnViewUser.Click
        Dim new_view_user As New View_User
        new_view_user.ShowDialog()
    End Sub
End Class
