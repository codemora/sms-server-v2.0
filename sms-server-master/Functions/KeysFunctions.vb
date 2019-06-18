Module KeysFunctions
    Private TA As New SMSTableAdapters.keysTableAdapter

    '
    'Adds a Key's record
    '
    Public Function addKey(Key As Key) As Boolean
        Try
            Return TA.Insert(Key.getTag, Key.getKeyType, Key.getLock, Key.getBlock, Key.getLocation, Key.getQuantity, Key.getStatus, Key.getCreatedAt, Key.getUpatedAt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    'Deletes a Key's record
    '
    Public Function deleteKey(Key As Key) As Boolean
        Try
            Return TA.Delete(Key.getId, Key.getTag, Key.getKeyType, Key.getLock, Key.getBlock, Key.getLocation, Key.getQuantity, Key.getStatus, Key.getCreatedAt, Key.getUpatedAt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    'Updates a Key's record
    '
    Public Function updateKey(Key As Key) As Boolean
        Try
            Return TA.UpdateById(Key.getTag, Key.getKeyType, Key.getLock, Key.getBlock, Key.getLocation, Key.getQuantity, Key.getStatus, Key.getCreatedAt, Key.getUpatedAt, Key.getId)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    ' Checks if ID exists
    '
    Public Function isExistKey(tag As String) As Boolean
        If TA.GetDataByTag(tag).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    ' Checks if Lock exists
    '
    Public Function isExistLock(lock As String) As Boolean
        If TA.GetDataByLock(lock).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    ' Checks if key is Available
    '
    Public Function isAvailableKey(id As Integer) As Boolean
        If TA.GetDataByIdWhereIn(id).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    ' Checks if key is Unavailable
    '
    Public Function isUnavailableKey(id As Integer) As Boolean
        If TA.GetDataByIdWhereOut(id).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    'Returns Key record using tag
    '
    Public Function getKeyByTag(tag As String) As Key
        Dim id As Integer = TA.GetDataByTag(tag).Rows(0).Item("id")
        Dim key_type As String = TA.GetDataByTag(tag).Rows(0).Item("type").ToString()
        Dim lock As String = TA.GetDataByTag(tag).Rows(0).Item("lock").ToString()
        Dim block As String = TA.GetDataByTag(tag).Rows(0).Item("block").ToString()
        Dim location As String = TA.GetDataByTag(tag).Rows(0).Item("location").ToString()
        Dim quantity As Integer = TA.GetDataByTag(tag).Rows(0).Item("quantity")
        Dim status As String = TA.GetDataByTag(tag).Rows(0).Item("status").ToString()
        Dim created_at As Date = TA.GetDataByTag(tag).Rows(0).Item("created_at")
        Dim updated_at As Date = TA.GetDataByTag(tag).Rows(0).Item("updated_at")

        Return New Key(id, tag, key_type, lock, block, location, quantity, status, created_at, updated_at)
    End Function

    '
    'Returns Key record using id
    '
    Public Function getKeyById(id As Integer) As Key
        Dim tag As String = TA.GetDataById(id).Rows(0).Item("tag").ToString
        Dim key_type As String = TA.GetDataById(id).Rows(0).Item("type").ToString()
        Dim lock As String = TA.GetDataById(id).Rows(0).Item("lock").ToString()
        Dim block As String = TA.GetDataById(id).Rows(0).Item("block").ToString()
        Dim location As String = TA.GetDataById(id).Rows(0).Item("location").ToString()
        Dim quantity As Integer = TA.GetDataById(id).Rows(0).Item("quantity")
        Dim status As String = TA.GetDataById(id).Rows(0).Item("status").ToString()
        Dim created_at As Date = TA.GetDataById(id).Rows(0).Item("created_at")
        Dim updated_at As Date = TA.GetDataById(id).Rows(0).Item("updated_at")

        Return New Key(id, tag, key_type, lock, block, location, quantity, status, created_at, updated_at)
    End Function

    '
    'Returns ID record using Lock
    '
    Public Function getKeyId(lock As String) As String
        Dim id As Integer = TA.GetDataByLock(lock).Rows(0).Item("id")
        Return id
    End Function

    '
    'Returns All Keys for a location
    '
    Public Function getAllKey(block As String) As List(Of Key)
        Dim KeyList As New List(Of Key)
        For Each keylock In TA.GetDataByBlock(block)
            Dim id As Integer = keylock.Item("id")
            Dim key_type As String = keylock.Item("type").ToString()
            Dim lock As String = keylock.Item("lock").ToString()
            Dim location As String = keylock.Item("location").ToString()
            Dim tag As String = keylock.Item("tag").ToString()
            Dim quantity As Integer = keylock.Item("quantity")
            Dim status As String = keylock.Item("status").ToString()
            Dim created_at As Date = keylock.Item("created_at")
            Dim updated_at As Date = keylock.Item("updated_at")
            'adds Key object to KeyList
            KeyList.Add(New Key(id, tag, key_type, lock, block, location, quantity, status, created_at, updated_at))
        Next
        Return KeyList
    End Function

    '
    'Returns All Keys
    '
    Public Function getAllKey() As List(Of Key)
        Dim KeyList As New List(Of Key)
        For Each keylock In TA.GetData
            Dim id As Integer = keylock.Item("id")
            Dim key_type As String = keylock.Item("type").ToString()
            Dim lock As String = keylock.Item("lock").ToString()
            Dim block As String = keylock.Item("block").ToString()
            Dim location As String = keylock.Item("location").ToString()
            Dim tag As String = keylock.Item("tag").ToString()
            Dim quantity As Integer = keylock.Item("quantity")
            Dim status As String = keylock.Item("status").ToString()
            Dim created_at As Date = keylock.Item("created_at")
            Dim updated_at As Date = keylock.Item("updated_at")
            'adds Key object to KeyList
            KeyList.Add(New Key(id, tag, key_type, lock, block, location, quantity, status, created_at, updated_at))
        Next
        Return KeyList
    End Function

    '
    'Returns All Keys
    '
    Public Function getAllKey(page As Integer, numPerPage As Integer) As List(Of Key)
        Dim KeyList As New List(Of Key)
        For Each keylock In TA.GetData.Skip(page * numPerPage).Take(numPerPage)
            Dim id As Integer = keylock.Item("id")
            Dim key_type As String = keylock.Item("type").ToString()
            Dim lock As String = keylock.Item("lock").ToString()
            Dim block As String = keylock.Item("block").ToString()
            Dim location As String = keylock.Item("block").ToString()
            Dim tag As String = keylock.Item("tag").ToString()
            Dim quantity As Integer = keylock.Item("quantity")
            Dim status As String = keylock.Item("status").ToString()
            Dim created_at As Date = keylock.Item("created_at")
            Dim updated_at As Date = keylock.Item("updated_at")
            'adds Key object to KeyList
            KeyList.Add(New Key(id, tag, key_type, lock, block, location, quantity, status, created_at, updated_at))
        Next
        Return KeyList
    End Function

    '
    'Returns All Keys
    '
    Public Function getAllKey(recsOnDisplay As Integer) As List(Of Key)
        Dim KeyList As New List(Of Key)
        For Each keylock In TA.GetData.Skip(recsOnDisplay)
            Dim id As Integer = keylock.Item("id")
            Dim key_type As String = keylock.Item("type").ToString()
            Dim lock As String = keylock.Item("lock").ToString()
            Dim block As String = keylock.Item("block").ToString()
            Dim location As String = keylock.Item("block").ToString()
            Dim tag As String = keylock.Item("tag").ToString()
            Dim quantity As Integer = keylock.Item("quantity")
            Dim status As String = keylock.Item("status").ToString()
            Dim created_at As Date = keylock.Item("created_at")
            Dim updated_at As Date = keylock.Item("updated_at")
            'adds Key object to KeyList
            KeyList.Add(New Key(id, tag, key_type, lock, block, location, quantity, status, created_at, updated_at))
        Next
        Return KeyList
    End Function


End Module
