Public Class Request
    Dim id As Integer
    Dim action As String
    Private Sub RequestApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id = CInt(checkpoint1.lvData.SelectedItems(0).Text)
        Dim request = getRequestlog(id)
        action = request.getAction
        Dim requestedKeys = getAllkeyRequestlogByrequestlog_id(id)
        Dim staff As Staff = getStaffById(request.getStaffId)
        lblAction.Text = request.getAction + " Request"
        lblDate.Text = request.getCreatedAt
        lblName.Text = staff.getOtherNames + " " + staff.getLastName
        lblInfo.Text = "Gender: " + staff.getGender + vbNewLine + "Dept: " + staff.getDepartment + vbNewLine + "Position: " + staff.getPosition
        PictureBox1.Image = ConvertToImage(staff.getImage)
        For Each key In requestedKeys
            Dim newItem As New ListViewItem
            With newItem
                .Text = getKeyById(key.getKeyId).getTag
                .SubItems.Add(getKeyById(key.getKeyId).getLocation)
            End With
            lvRequestedKeys.Items.Add(newItem)
        Next
    End Sub

    Private Sub RequestApproval_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        reset()
        'RequestCenter.Timer1.Start()
    End Sub

    Private Sub processRequest(requestlogId As Integer, action As String, approval As String)
        Dim status As String = "Out"
        If approval = "Approved" Then
            If action.ToLower = "checkin" Then
                status = "In"
            Else
                status = "Out"
            End If
        ElseIf approval = "Denied" Then
            If action.ToLower = "checkin" Then
                status = "Out"
            Else
                status = "In"
            End If
        End If
        Dim original_request As Requestlog = getRequestlog(id)
        Dim request As New Requestlog(original_request.getId, original_request.getStaffId, My.Settings.USER_ID, original_request.getAction, approval, original_request.getCreatedAt, Now)
        updaterequestlog(request)

        For Each original_keyRequestlog In getAllkeyRequestlogByrequestlog_id(id)
            Dim original_key = getKeyById(original_keyRequestlog.getKeyId)
            Dim key As New Key(original_key.getId, original_key.getTag, original_key.getKeyType, original_key.getLock, original_key.getBlock, original_key.getLocation, original_key.getQuantity, status, original_key.getCreatedAt, Now)
            updateKey(key)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        processRequest(id, action, "Approved")
        checkpoint1.lvData.Items.Remove(checkpoint1.lvData.SelectedItems(0))
        ShowMessage(checkpoint1.tmMessage, checkpoint1.lblMsg, Color.LimeGreen, "Request Approved")
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        processRequest(id, action, "Denied")
        checkpoint1.lvData.Items.Remove(checkpoint1.lvData.SelectedItems(0))
        ShowMessage(checkpoint1.tmMessage, checkpoint1.lblMsg, Color.LimeGreen, "Request Denied")
        Me.Close()
    End Sub

    Private Sub reset()
        lblAction.Text = ""
        lblDate.Text = ""
        lblInfo.Text = ""
        lblName.Text = ""
        lvRequestedKeys.Items.Clear()
    End Sub


End Class