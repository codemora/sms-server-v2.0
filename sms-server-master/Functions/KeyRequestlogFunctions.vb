Module KeyRequestlogFunctions
    Private TA As New SMSTableAdapters.key_requestlogTableAdapter


    '
    'Adds a requestlogKeys's record
    '
    Public Function addkeyRequestlogs(key_Requestlog_list As List(Of keyRequestlog)) As Boolean
        Try
            For Each key_Requestlog In key_Requestlog_list
                TA.Insert(key_Requestlog.getRequestlogId, key_Requestlog.getKeyId, Now, Now)
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    ' Checks if ID exists
    '
    Public Function IsExistkeyRequestlog(requestlog_id As Integer) As Boolean
        If TA.GetDataByRequestlogId(requestlog_id).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    '
    'Returns all requestlogKeys
    '
    Public Function getAllkeyRequestlogByrequestlog_id(requestlog_id As Integer) As List(Of keyRequestlog)
        'create list of requestlogKeys
        Dim key_Requestlog_list As New List(Of keyRequestlog)
        For Each key_Requestlog In TA.GetDataByRequestlogId(requestlog_id)
            Dim id As Integer = key_Requestlog.Item("id")
            Dim key_id As Integer = key_Requestlog.Item("key_id")
            Dim created_at As DateTime = key_Requestlog.Item("created_at")
            Dim updated_at As DateTime = key_Requestlog.Item("updated_at")
            'adds requestlogKeys object to requestlogKeysList
            key_Requestlog_list.Add(New keyRequestlog(id, requestlog_id, key_id, created_at, updated_at))
        Next
        Return key_Requestlog_list
    End Function

    '
    'Returns all requestlogKeys
    '
    Public Function getAllrequestlogKeysString(requestlog_id As Integer) As String
        Dim keys As String = ""
        For Each requestlogKeys In TA.GetDataByRequestlogId(requestlog_id).Rows()
            keys += getKeyById(requestlogKeys.item("key_id")).getTag + " , "
        Next
        Return keys.Substring(0, keys.Length - 2)
    End Function

End Module
