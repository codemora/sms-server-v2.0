Module RequestlogFunctions
    Private TA As New SMSTableAdapters.requestlogsTableAdapter

    '
    'Adds a requestlog's record
    '
    Public Function addRequestlog(requestlog As Requestlog) As Boolean
        Try
            Return TA.Insert(requestlog.getStaffRef, requestlog.getUsername, requestlog.getKeys, requestlog.getAction, requestlog.getStatus, Now, Now)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    ''
    ''Deletes a requestlog's record
    ''
    'Public Sub deleterequestlog(requestlog As requestlog)
    '    Try
    '        TA.Delete(requestlog.getStaff, requestlog.getDateOfrequestlog, requestlog.getAction, requestlog.getUser)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    '
    'Updates a requestlog's record
    '
    Public Sub updaterequestlog(requestlog As Requestlog)
        Try
            TA.UpdateById(requestlog.getStaffRef, requestlog.getUsername, requestlog.getKeys, requestlog.getAction, requestlog.getStatus, requestlog.getCreatedAt, requestlog.getUpdatedAt, requestlog.getId)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '
    ' Checks if ID exists
    '
    Public Function IsExistRequestlog(id As Integer) As Boolean
        If TA.GetDataById(id).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    'Returns requestlog record using ID
    '
    Public Function getRequestlog(id As Integer) As Requestlog
        Dim staff_ref As String = TA.GetDataById(id).Rows(0).Item("staff_ref")
        Dim username As String = TA.GetDataById(id).Rows(0).Item("username")
        Dim keys As String = TA.GetDataById(id).Rows(0).Item("keys").ToString()
        Dim action As String = TA.GetDataById(id).Rows(0).Item("action").ToString()
        Dim status As String = TA.GetDataById(id).Rows(0).Item("status").ToString()
        Dim created_at As DateTime = TA.GetDataById(id).Rows(0).Item("created_at")
        Dim updated_at As DateTime = TA.GetDataById(id).Rows(0).Item("updated_at")
        Return New Requestlog(id, staff_ref, username, keys, action, status, created_at, updated_at)
    End Function

    '
    'Returns requestlog ID of last log entry
    '
    Public Function getRequestlogID() As Integer
        Dim Id As Integer = TA.GetData.Last.id
        Return Id
    End Function

    '
    'Returns All requestlogs
    '
    Public Function getAllRequestlogByStatus(status As String, Optional skip_number As Integer = 0) As List(Of Requestlog)
        Dim requestlogList As New List(Of Requestlog)
        For Each requestlogAction In TA.GetDataByStatus(status).Skip(skip_number)
            Dim id As Integer = requestlogAction.Item("id")
            Dim staff_ref As String = requestlogAction.Item("staff_ref")
            Dim username As String = requestlogAction.Item("username")
            Dim keys As String = TA.GetDataById(id).Rows(0).Item("keys").ToString()
            Dim action As String = requestlogAction.Item("action").ToString()
            Dim created_at As DateTime = requestlogAction.Item("created_at")
            Dim updated_at As DateTime = requestlogAction.Item("updated_at")
            'adds requestlog object to requestlogList
            requestlogList.Add(New Requestlog(id, staff_ref, username, keys, action, status, created_at, updated_at))
        Next
        Return requestlogList
    End Function

    '
    'Returns All requestlogs
    '
    Public Function getAllRequestlog() As List(Of Requestlog) 'recOnDisplay = page * numPerPage
        Dim requestlogList As New List(Of Requestlog)
        For Each requestlogAction In TA.GetData
            Dim id As Integer = requestlogAction.Item("id")
            Dim staff_ref As String = requestlogAction.Item("staff_ref")
            Dim username As String = requestlogAction.Item("username")
            Dim keys As String = TA.GetDataById(id).Rows(0).Item("keys").ToString()
            Dim action As String = requestlogAction.Item("action").ToString()
            Dim status As String = requestlogAction.Item("status").ToString()
            Dim created_at As DateTime = requestlogAction.Item("created_at")
            Dim updated_at As DateTime = requestlogAction.Item("updated_at")
            'adds requestlog object to requestlogList
            requestlogList.Add(New Requestlog(id, staff_ref, username, keys, action, status, created_at, updated_at))
        Next
        Return requestlogList
    End Function

    '
    'Returns All requestlogs
    '
    Public Function getAllRequestlogComplete() As List(Of Requestlog)
        Dim requestlogList As New List(Of Requestlog)
        For Each requestlogAction In TA.GetDataByRequestComplete.Reverse
            Dim id As Integer = requestlogAction.Item("id")
            Dim staff_ref As String = requestlogAction.Item("staff_ref")
            Dim username As String = requestlogAction.Item("username")
            Dim keys As String = TA.GetDataById(id).Rows(0).Item("keys").ToString()
            Dim action As String = requestlogAction.Item("action").ToString()
            Dim status As String = requestlogAction.Item("status").ToString()
            Dim created_at As DateTime = requestlogAction.Item("created_at")
            Dim updated_at As DateTime = requestlogAction.Item("updated_at")
            'adds requestlog object to requestlogList
            requestlogList.Add(New Requestlog(id, staff_ref, username, keys, action, status, created_at, updated_at))
        Next
        Return requestlogList
    End Function

    '
    'Returns All requestlogs
    '
    Public Function getAllRequestlog(log_date As DateTime) As List(Of Requestlog)
        Dim requestlogList As New List(Of Requestlog)
        For Each requestlogAction In TA.GetDataByDate(log_date).Reverse
            Dim id As Integer = requestlogAction.Item("id")
            Dim staff_ref As String = requestlogAction.Item("staff_ref")
            Dim username As String = requestlogAction.Item("username")
            Dim keys As String = TA.GetDataById(id).Rows(0).Item("keys").ToString()
            Dim action As String = requestlogAction.Item("action").ToString()
            Dim status As String = requestlogAction.Item("status").ToString()
            Dim created_at As DateTime = requestlogAction.Item("created_at")
            Dim updated_at As DateTime = requestlogAction.Item("updated_at")
            'adds requestlog object to requestlogList
            requestlogList.Add(New Requestlog(id, staff_ref, username, keys, action, status, created_at, updated_at))
        Next
        Return requestlogList
    End Function


    '
    'Returns All requestlogs
    '
    Public Function getAllRequestlog(log_date As DateTime, search_query As String) As List(Of Requestlog)
        Dim requestlogList As New List(Of Requestlog)
        For Each requestlogAction In TA.GetDataByDateAndSearch(log_date, search_query).Reverse
            Dim id As Integer = requestlogAction.Item("id")
            Dim staff_ref As String = requestlogAction.Item("staff_ref")
            Dim username As String = requestlogAction.Item("username")
            Dim keys As String = TA.GetDataById(id).Rows(0).Item("keys").ToString()
            Dim action As String = requestlogAction.Item("action").ToString()
            Dim status As String = requestlogAction.Item("status").ToString()
            Dim created_at As DateTime = requestlogAction.Item("created_at")
            Dim updated_at As DateTime = requestlogAction.Item("updated_at")
            'adds requestlog object to requestlogList
            requestlogList.Add(New Requestlog(id, staff_ref, username, keys, action, status, created_at, updated_at))
        Next
        Return requestlogList
    End Function

    '
    'Returns All requestlogs by search
    '
    Public Function getAllRequestlogBySearch(search_query As String) As List(Of Requestlog)
        Dim requestlogList As New List(Of Requestlog)
        For Each requestlogAction In TA.GetDataBySearch(search_query).Reverse
            Dim id As Integer = requestlogAction.Item("id")
            Dim staff_ref As String = requestlogAction.Item("staff_ref")
            Dim username As String = requestlogAction.Item("username")
            Dim keys As String = TA.GetDataById(id).Rows(0).Item("keys").ToString()
            Dim action As String = requestlogAction.Item("action").ToString()
            Dim status As String = requestlogAction.Item("status").ToString()
            Dim created_at As DateTime = requestlogAction.Item("created_at")
            Dim updated_at As DateTime = requestlogAction.Item("updated_at")
            'adds requestlog object to requestlogList
            requestlogList.Add(New Requestlog(id, staff_ref, username, keys, action, status, created_at, updated_at))
        Next
        Return requestlogList
    End Function
End Module
