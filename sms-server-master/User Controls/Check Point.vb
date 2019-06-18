Public Class Check_Point

    Public full_reload As Boolean = True
    Public Sub Check_Point_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmRefresh.Start()
    End Sub

    '
    'Fills listView2 with staff data List
    '
    Private Sub fillListView(data As List(Of Requestlog))
        Dim items As New List(Of ListViewItem)
        For Each itm In data
            Dim item As New ListViewItem
            With item
                .Text = itm.getId
                .SubItems.Add(getStaffById(itm.getStaffId).getLastName + " " + getStaffById(itm.getStaffId).getOtherNames)
                .SubItems.Add(getAllrequestlogKeysString(itm.getId))
                .SubItems.Add(itm.getAction)
                .SubItems.Add(itm.getCreatedAt)
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
            lblCount.Text = numberOfDisplayedRecords(lvData.Items.Count, getAllRequestlogByStatus("pending").Count)
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
            lblCount.Text = numberOfDisplayedRecords(lvData.Items.Count, getAllRequestlogByStatus("pending").Count)
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
End Class

