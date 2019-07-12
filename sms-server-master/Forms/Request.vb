Public Class Request
    Dim id As Integer
    Dim action As String
    Private Sub RequestApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        action = checkpoint1.selected_request.getAction
        id = checkpoint1.selected_request.getId
        Dim staff As Staff = getStaffByRef(checkpoint1.selected_request.getStaffRef)
        lblAction.Text = checkpoint1.selected_request.getAction + " Request"
        lblDate.Text = checkpoint1.selected_request.getCreatedAt
        lblName.Text = staff.getFullname
        lblInfo.Text = "Gender: " + staff.getGender + vbNewLine + "Dept: " + staff.getDepartment + vbNewLine + "Position: " + staff.getPosition
        PictureBox1.Image = ConvertToImage(staff.getImage)
        For Each key In getKeyList(checkpoint1.selected_request.getKeys)
            Dim newItem As New ListViewItem
            With newItem
                .Text = key
                .SubItems.Add(getKeyByTag(key).getLocation)
            End With
            lvRequestedKeys.Items.Add(newItem)
        Next
    End Sub

    '
    'Return array of key tags
    '
    Function getKeyList(keys As String) As String()
        Return keys.Split(",")
    End Function

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

        Dim request As New Requestlog(checkpoint1.selected_request.getId, checkpoint1.selected_request.getStaffRef, getUserById(My.Settings.USER_ID).getUsername, checkpoint1.selected_request.getKeys, checkpoint1.selected_request.getAction, approval, checkpoint1.selected_request.getCreatedAt, Now)
        updaterequestlog(request)
        logs1.showLoader()
        logs1.addItemTop(request)
        logs1.hideLoader()

        For Each key_tag In getKeyList(checkpoint1.selected_request.getKeys)
            Dim original_key = getKeyByTag(key_tag)
            Dim key As New Key(original_key.getId, original_key.getTag, original_key.getKeyType, original_key.getLock, original_key.getBlock, original_key.getLocation, original_key.getQuantity, status, original_key.getCreatedAt, Now)
            updateKey(key)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        processRequest(id, action, "Approved")
        checkpoint1.lvData.Items.Remove(checkpoint1.selected_item)
        ShowMessage(checkpoint1.tmMessage, checkpoint1.lblMsg, Color.LimeGreen, "Request Approved")
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        processRequest(id, action, "Denied")
        checkpoint1.lvData.Items.Remove(checkpoint1.selected_item)
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