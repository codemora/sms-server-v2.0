Public Class Dashboard
    Public loading As Boolean 'loading indicator
    Public no_record_found As Boolean 'no record found indicator

    Private Sub btnCheckpoint_Click(sender As Object, e As EventArgs) Handles btnCheckpoint.Click
        If checkpoint1.Visible = False Then
            panActive.Top = btnCheckpoint.Top
            checkpoint1.BringToFront()
            checkpoint1.Visible = True
            logs1.Visible = False
            staff1.Visible = False
            keys1.Visible = False
            users1.Visible = False
        End If
        'Me.Controls.SetChildIndex(checkpoint1, 0)
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        If logs1.Visible = False Then
            panActive.Top = btnLogs.Top
            logs1.BringToFront()
            logs1.Visible = True
            checkpoint1.Visible = False
            staff1.Visible = False
            keys1.Visible = False
            users1.Visible = False
        End If
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        If staff1.Visible = False Then
            panActive.Top = btnStaff.Top
            staff1.BringToFront()
            staff1.Visible = True
            checkpoint1.Visible = False
            logs1.Visible = False
            keys1.Visible = False
            users1.Visible = False
        End If
    End Sub

    Private Sub btnKeys_Click(sender As Object, e As EventArgs) Handles btnKeys.Click
        If keys1.Visible = False Then
            panActive.Top = btnKeys.Top
            keys1.BringToFront()
            keys1.Visible = True
            checkpoint1.Visible = False
            staff1.Visible = False
            logs1.Visible = False
            users1.Visible = False

        End If
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        If users1.Visible = False Then
            panActive.Top = btnUsers.Top
            users1.BringToFront()
            users1.Visible = True
            checkpoint1.Visible = False
            staff1.Visible = False
            keys1.Visible = False
            logs1.Visible = False
        End If
    End Sub

    Private Sub Dashboard_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblDisplayName.Text = "Hi, " + My.Settings.DISPLAY_NAME
        pboxDisplayImage.Image = ConvertToImage(convertStringToByte(My.Settings.DISPLAY_IMAGE))

        loader1 = New LoaderControl
        loader1.Location = New Point(((Me.Width - 280) / 2) - 50 + 280, ((Me.Height - 260) / 2) - 50 + 195)
        Me.Controls.Add(loader1)

        no_record1 = New NoRecordControl
        no_record1.Location = New Point(((Me.Width - 280) / 2) - 100 + 280, ((Me.Height - 260) / 2) - 25 + 195)
        Me.Controls.Add(no_record1)

        'Adds Users control to the Dashboard
        users1 = New UsersControl
        users1.Visible = False
        users1.Dock = DockStyle.Fill
        Me.Controls.Add(users1)
        'users1.Location = New Point(0, 0)
        users1.BringToFront()

        'Adds Keys control to the Dashboard
        keys1 = New KeysControl
        keys1.Visible = False
        keys1.Dock = DockStyle.Fill
        Me.Controls.Add(keys1)
        'keys1.Location = New Point(0, 0)
        keys1.BringToFront()

        'Adds Staff control to the Dashboard
        staff1 = New StaffControl
        staff1.Visible = False
        staff1.Dock = DockStyle.Fill
        Me.Controls.Add(staff1)
        staff1.BringToFront()

        'Adds Logs control to the Dashboard
        logs1 = New LogsControl
        logs1.Visible = False
        logs1.Dock = DockStyle.Fill
        Me.Controls.Add(logs1)
        'logs1.Location = New Point(0, 0)
        logs1.BringToFront()

        'Adds Checkpoint control to the Dashboard
        checkpoint1 = New Check_Point
        checkpoint1.Visible = False
        checkpoint1.Dock = DockStyle.Fill
        Me.Controls.Add(checkpoint1)
        checkpoint1.BringToFront()
        checkpoint1.Visible = True

    End Sub


    '
    'Preloader
    '

    'shows the preloader
    Public Sub showLoader()
        hideNoRecordDisplay()
        loader1.Location = New Point(((Me.Width - 280) / 2) - 50 + 280, ((Me.Height - 260) / 2) - 50 + 195)
        loader1.BringToFront()
        loading = True
    End Sub

    'hides the preloader
    Public Sub hideLoader()
        loader1.SendToBack()
        loading = False
    End Sub

    'reloader loads the preloader or noRecordDisplay when form resizes
    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If loading Then
            showLoader()
        ElseIf no_record_found Then
            showNoRecordDisplay()
        End If
    End Sub

    '
    'NoRecordDisplay
    '

    'shows the NoRecordDisplay
    Public Sub showNoRecordDisplay()
        no_record1.Location = New Point(((Me.Width - 280) / 2) - 110 + 280, ((Me.Height - 260) / 2) - 25 + 195)
        no_record1.BringToFront()
        no_record_found = True
    End Sub

    'hides the NoRecordDisplay
    Public Sub hideNoRecordDisplay()
        no_record1.SendToBack()
        no_record_found = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.DISPLAY_IMAGE = Nothing
        My.Settings.DISPLAY_NAME = Nothing
        My.Settings.USER_ID = Nothing
        Log_In.Show()
        Me.Close()
    End Sub
End Class
