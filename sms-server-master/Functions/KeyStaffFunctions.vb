Module KeyStaffFunctions
    Private TA As New SMSTableAdapters.key_staffTableAdapter

    '
    'Adds a KeyStaff's record
    '
    Public Function addKeyStaff(key_staff_list As List(Of KeyStaff)) As Boolean
        Try
            For Each key_staff In key_staff_list
                TA.Insert(key_staff.getStaffId, key_staff.getKeyId, key_staff.getIsFav, key_staff.getCreatedAt, key_staff.getUpdatedAt)
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    'Deletes a KeyStaff's record
    '
    Public Function deleteKeyStaff(staff As Staff) As Boolean
        Try
            Return TA.DeleteByStaffId(staff.getId)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    ' Checks if ID exists
    '
    Public Function IsExistKeyStaff(staff_id As Integer, key_id As Integer) As Boolean
        If TA.GetDataByStaffAndKeyId(staff_id, key_id).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    'Returns KeyStaff record using ID
    '
    Public Function getKeyStaff(staff_id As Integer, key_id As Integer) As KeyStaff
        Dim id As Integer = TA.GetDataByStaffAndKeyId(staff_id, key_id).Rows(0).Item("id")
        Dim is_fav As Boolean = TA.GetDataByStaffAndKeyId(staff_id, key_id).Rows(0).Item("is_fav")
        Dim created_at As DateTime = TA.GetDataByStaffAndKeyId(staff_id, key_id).Rows(0).Item("created_at")
        Dim updated_at As DateTime = TA.GetDataByStaffAndKeyId(staff_id, key_id).Rows(0).Item("updated_at")
        Return New KeyStaff(id, staff_id, key_id, is_fav, created_at, updated_at)
    End Function

    '
    'Returns all KeyStaff
    '
    Public Function getAllKeyStaffByStaffId(staff_id As Integer) As List(Of KeyStaff)
        'create list of KeyStaffs
        Dim key_staff_list As New List(Of KeyStaff)
        For Each key_staff In TA.GetDataByStaffId(staff_id)
            Dim id As Integer = key_staff.Item("id")
            Dim key_id As Integer = key_staff.Item("key_id")
            Dim is_fav As Boolean = key_staff.Item("is_fav")
            Dim created_at As DateTime = key_staff.Item("created_at")
            Dim updated_at As DateTime = key_staff.Item("updated_at")
            'adds KeyStaff object to KeyStaffList
            key_staff_list.Add(New KeyStaff(id, staff_id, key_id, is_fav, created_at, updated_at))
        Next
        Return key_staff_list
    End Function


    'Returns all KeyStaff
    '
    Public Function getAllKeyStaffByKeyId(key_id As Integer) As List(Of KeyStaff)
        'create list of KeyStaffs
        Dim key_staff_list As New List(Of KeyStaff)
        For Each key_staff In TA.GetDataByKeyId(key_id)
            Dim id As Integer = key_staff.Item("id")
            Dim staff_id As Integer = key_staff.Item("staff_id")
            Dim is_fav As Boolean = key_staff.Item("is_fav")
            Dim created_at As DateTime = key_staff.Item("created_at")
            Dim updated_at As DateTime = key_staff.Item("updated_at")
            'adds KeyStaff object to KeyStaffList
            key_staff_list.Add(New KeyStaff(id, staff_id, key_id, is_fav, created_at, updated_at))
        Next
        Return key_staff_list
    End Function
End Module
