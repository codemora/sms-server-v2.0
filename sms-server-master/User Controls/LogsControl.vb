Public Class LogsControl

    '
    'Fills lvData with staff data List
    '
    Private Sub fillListView(data As List(Of Requestlog))
        showLoader()
        lvData.Items.Clear()
        For Each request In data
            addItem(request)
        Next
        hideLoader()
    End Sub

    '
    'Add Request to log
    '
    Public Sub addItem(request As Requestlog)
        Dim newItem As New ListViewItem
        With newItem
            .Text = request.getId
            .SubItems.Add(request.getStaffRef)
            .SubItems.Add(request.getKeys)
            .SubItems.Add(request.getAction)
            .SubItems.Add(request.getStatus)
            .SubItems.Add(request.getUsername)
            .SubItems.Add(request.getCreatedAt)
        End With
        lvData.Items.Add(newItem)
    End Sub

    '
    'Add Request on top of log
    '
    Public Sub addItemTop(request As Requestlog)
        Dim newItem As New ListViewItem
        With newItem
            .Text = request.getId
            .SubItems.Add(request.getStaffRef)
            .SubItems.Add(request.getKeys)
            .SubItems.Add(request.getAction)
            .SubItems.Add(request.getStatus)
            .SubItems.Add(request.getUsername)
            .SubItems.Add(request.getCreatedAt)
        End With
        lvData.Items.Insert(0, newItem)
    End Sub

    Public Function newListItem(request As Requestlog) As ListViewItem
        Dim newItem As New ListViewItem
        With newItem
            .Text = request.getId
            .SubItems.Add(request.getStaffRef)
            .SubItems.Add(request.getKeys)
            .SubItems.Add(request.getAction)
            .SubItems.Add(request.getStatus)
            .SubItems.Add(request.getUsername)
            .SubItems.Add(request.getCreatedAt)
        End With
        Return newItem
    End Function


    Private Sub LogsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Focus()
        cmbPeriod.SelectedIndex = 0
    End Sub

    '
    'Returns number of records on display in ListView
    '
    Public Function NumOfRecs() As String
        Return lvData.Items.Count.ToString + " Records"
    End Function

    'Private Sub lvData_RetrieveVirtualItem(sender As Object, e As RetrieveVirtualItemEventArgs) Handles lvData.RetrieveVirtualItem
    '    Dim request As Requestlog = Logs_data(e.ItemIndex)
    '    e.Item = newListItem(request)
    'End Sub

    Private Sub cmbPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPeriod.SelectedIndexChanged
        txtSearch.Clear()
        showLoader()
        If cmbPeriod.SelectedIndex = 0 Then
            Logs_data = getAllRequestlog(Today)
        ElseIf cmbPeriod.SelectedIndex = 1 Then
            Logs_data = getAllRequestlog(Today.AddDays(-1))
        ElseIf cmbPeriod.SelectedIndex = 2 Then
            Logs_data = getAllRequestlog(Today.AddDays(-7))
        ElseIf cmbPeriod.SelectedIndex = 3 Then
            Logs_data = getAllRequestlog(Today.AddMonths(-1))
        ElseIf cmbPeriod.SelectedIndex = 4 Then
            Logs_data = getAllRequestlog(Today.AddYears(-1))
        Else
            Logs_data = getAllRequestlogComplete()
        End If
        If Logs_data.Count = 0 Then
            showNoRecord()
        Else
            fillListView(Logs_data)
        End If
        lblCount.Text = NumOfRecs()
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
        If cmbPeriod.SelectedIndex = 0 Then
            Logs_data = getAllRequestlog(Today, search)
        ElseIf cmbPeriod.SelectedIndex = 1 Then
            Logs_data = getAllRequestlog(Today.AddDays(-1), search)
        ElseIf cmbPeriod.SelectedIndex = 2 Then
            Logs_data = getAllRequestlog(Today.AddDays(-7), search)
        ElseIf cmbPeriod.SelectedIndex = 3 Then
            Logs_data = getAllRequestlog(Today.AddMonths(-1), search)
        ElseIf cmbPeriod.SelectedIndex = 4 Then
            Logs_data = getAllRequestlog(Today.AddYears(-1), search)
        Else
            Logs_data = getAllRequestlogBySearch(search)
        End If
        If Logs_data.Count = 0 Then
            showNoRecord()
        Else
            fillListView(Logs_data)
        End If
        lblCount.Text = NumOfRecs()
    End Sub
End Class
