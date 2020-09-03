Public Class Check_Point
    Public selected_request As Requestlog
    Public selected_item As ListViewItem
    Public full_reload As Boolean = True
    Public Sub Check_Point_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmRefresh.Start()
    End Sub

    '
    'Fills lvData with staff data List
    '
    Private Sub fillListView(data As List(Of Requestlog))
        Dim items As New List(Of ListViewItem)
        For Each request In data
            Dim item As New ListViewItem
            With item
                .Text = request.getId
                .SubItems.Add(getStaffByRef(request.getStaffRef).getFullname)
                .SubItems.Add(request.getKeys)
                .SubItems.Add(request.getAction)
                .SubItems.Add(request.getCreatedAt)
            End With
            items.Add(item)
        Next
        lvData.BeginUpdate()
        lvData.Items.AddRange(items.ToArray())
        lvData.EndUpdate()
    End Sub

    Private Sub tmRefresh_Tick(sender As Object, e As EventArgs) Handles tmRefresh.Tick

        If getAllRequestlogByStatus("pending").Count = 0 Then
            lvData.Items.Clear()
            lvData.GridLines = False
            lblCount.Text = numOfRecs(lvData)
            Dashboard.showNoRecordDisplay()
        Else
            If Dashboard.no_record_found Then Dashboard.hideNoRecordDisplay()

            If full_reload Then
                fillListView(getAllRequestlogByStatus("pending"))
                full_reload = False
            Else
                fillListView(getAllRequestlogByStatus("pending", lvData.Items.Count))
            End If
            lvData.GridLines = True
            lblCount.Text = numOfRecs(lvData)
        End If
        Dashboard.hideLoader()

    End Sub

    'Private Sub RequestCenter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '        Timer1.Stop()
    '    End Sub

    Private Sub lvPendingRequest_ItemActivate(sender As Object, e As EventArgs) Handles lvData.ItemActivate
        Request.ShowDialog()
    End Sub

    Private Sub tmMessage_Tick(sender As Object, e As EventArgs) Handles tmMessage.Tick
        CloseMessage(tmMessage, lblMsg)
    End Sub

    Private Sub Check_Point_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dashboard.showLoader()
            tmRefresh.Start()
        Else
            tmRefresh.Stop()
            Dashboard.hideLoader()
            Dashboard.hideNoRecordDisplay()
        End If
    End Sub

    Private Sub lvData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvData.SelectedIndexChanged

        If lvData.SelectedItems.Count > 0 Then
            selected_item = lvData.SelectedItems.Item(0)  'gets selected ListView item
            selected_request = getRequestlog(CInt(selected_item.Text))
        End If
    End Sub
End Class

