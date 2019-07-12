Public Class KeysControl
    Public selected_key As Key
    Public selected_item As ListViewItem

    Private Sub keys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel6.Width = (panelButtonTray.Width - 572) / 2
        showLoader()
        keys_data = getAllKey()

        If keys_data.Count = 0 Then
            showNoRecord()
        Else
            fillListView(keys_data)
        End If
        lblCount.Text = NumOfRecs()
    End Sub

    Private Sub btnAddKey_Click(sender As Object, e As EventArgs) Handles btnAddKey.Click
        Dim new_add_key As New Add_Key
        new_add_key.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseMessage(sender, lblMsg)
    End Sub

    '
    'Fills lvdata with key data List
    '
    Private Sub fillListView(data As List(Of Key))
        showLoader()
        lvData.Items.Clear()
        For Each key In data
            addItem(key)
        Next
        hideLoader()
    End Sub

    Public Sub addItem(key As Key)
        Dim newItem As New ListViewItem
        With newItem
            .Text = key.getId
            .SubItems.Add(key.getTag)
            .SubItems.Add(key.getKeyType)
            .SubItems.Add(key.getLock)
            .SubItems.Add(key.getBlock)
            .SubItems.Add(key.getLocation)
            .SubItems.Add(key.getQuantity)
            .SubItems.Add(key.getStatus)
            .SubItems.Add(key.getCreatedAt)
            .SubItems.Add(key.getUpatedAt)
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
    'Updates lvdata record as specific index
    '
    Public Sub UpdateRecord(item As ListViewItem, key As Key)
        Dim newItem As New ListViewItem
        With newItem
            With newItem
                .Text = key.getId
                .SubItems.Add(key.getTag)
                .SubItems.Add(key.getKeyType)
                .SubItems.Add(key.getLock)
                .SubItems.Add(key.getBlock)
                .SubItems.Add(key.getLocation)
                .SubItems.Add(key.getQuantity)
                .SubItems.Add(key.getStatus)
                .SubItems.Add(key.getCreatedAt)
                .SubItems.Add(key.getUpatedAt)
            End With
        End With
        lvData.Items.Insert(lvData.Items.IndexOf(item), newItem)
        lvData.Items.Remove(item)
    End Sub

    Private Sub btnDeleteKey_Click(sender As Object, e As EventArgs) Handles btnDeleteKey.Click

        Dim result As Integer

        result = MessageBox.Show("You are deleting Key with Tag '" + selected_key.getTag + "'", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If deleteKey(selected_key) Then
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

    Private Sub lvData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvData.SelectedIndexChanged

        If lvData.SelectedItems.Count > 0 Then
            selected_item = lvData.SelectedItems.Item(0)  'gets selected ListView item
            selected_key = getKeyById(CInt(selected_item.Text))
            btnViewKey.Enabled = True
            btnDeleteKey.Enabled = True
            btnEditKey.Enabled = True
        Else
            btnViewKey.Enabled = False
            btnDeleteKey.Enabled = False
            btnEditKey.Enabled = False
        End If

    End Sub

    Private Sub btnEditKey_Click(sender As Object, e As EventArgs) Handles btnEditKey.Click
        Dim new_edit_key As New Edit_Key
        new_edit_key.ShowDialog()
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
        keys_data = getAllKeyBySearch(search)
        If keys_data.Count = 0 Then
            showNoRecord()
        Else
            fillListView(keys_data)
        End If
        lblCount.Text = NumOfRecs()
    End Sub

    Private Sub btnViewKey_Click(sender As Object, e As EventArgs) Handles btnViewKey.Click
        Dim new_view_key As New View_Key
        new_view_key.ShowDialog()
    End Sub
End Class
