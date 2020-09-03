Module StaffFunctions
    Private TA As New SMSTableAdapters.staffsTableAdapter

    '
    'Adds a Staff's record
    '
    Public Function addStaff(staff As Staff) As Boolean
        Try
            Return TA.Insert(staff.getRef, staff.getFullname, staff.getGender, staff.getDepartment, staff.getPosition, staff.getPassCode, staff.getPhone, staff.getEmail, staff.getSecurityQuestion, staff.getSecurityAnswer, staff.getImage, staff.getIsActive, staff.getDeletedAt, staff.getCreatedAt, staff.getUpdatedAt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    'Deletes a Staff's record
    '
    Public Function deleteStaff(staff As Staff) As Boolean
        Try
            Return TA.UpdateById(staff.getRef, staff.getFullname, staff.getGender, staff.getDepartment, staff.getPosition, staff.getPassCode, staff.getPhone, staff.getEmail, staff.getSecurityQuestion, staff.getSecurityAnswer, staff.getImage, False, Today, staff.getCreatedAt, staff.getUpdatedAt, staff.getId)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    'Updates a Staff's record
    '
    Public Function updateStaff(staff As Staff) As Boolean
        Try
            Return TA.UpdateById(staff.getRef, staff.getFullname, staff.getGender, staff.getDepartment, staff.getPosition, staff.getPassCode, staff.getPhone, staff.getEmail, staff.getSecurityQuestion, staff.getSecurityAnswer, staff.getImage, staff.getIsActive, staff.getDeletedAt, staff.getCreatedAt, staff.getUpdatedAt, staff.getId)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    'changes a Staff's status
    '
    Public Function blockStaff(staff As Staff) As Boolean
        Try
            Return TA.UpdateById(staff.getRef, staff.getFullname, staff.getGender, staff.getDepartment, staff.getPosition, staff.getPassCode, staff.getPhone, staff.getEmail, staff.getSecurityQuestion, staff.getSecurityAnswer, staff.getImage, Not staff.getIsActive, staff.getDeletedAt, staff.getCreatedAt, staff.getUpdatedAt, staff.getId)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    ' Checks if ID exists
    '
    Public Function IsExistStaff(ref As String) As Boolean
        If TA.GetDataByRef(ref).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    ' Checks if Phone Number exists
    '
    Public Function IsExistStaffPhone(phone As String) As Boolean
        If TA.GetDataByPhone(phone).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    ' Checks if Email exists
    '
    Public Function IsExistStaffEmail(email As String) As Boolean
        If TA.GetDataByEmail(email).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    ' Returns index for next temp ref
    '
    Public Function nextIndex(position As String) As Integer
        Return TA.GetDataByPositionWithinYr(position).Count + 1
    End Function

    '
    'Create staff object from record
    '
    Private Function createObject(record As DataRow) As Staff
        Dim id As Integer = record.Item("id")
        Dim ref As String = record.Item("ref").ToString()
        Dim fullname As String = record.Item("fullname").ToString()
        Dim phone As String = record.Item("phone").ToString()
        Dim email As String = record.Item("email").ToString()
        Dim gender As String = record.Item("gender").ToString()
        Dim position As String = record.Item("position").ToString()
        Dim department As String = record.Item("department").ToString
        Dim pass_code As String = record.Item("pass_code").ToString()
        Dim security_question As String = record.Item("security_question").ToString()
        Dim security_answer As String = record.Item("security_answer").ToString()
        Dim image As Byte() = Nothing
        If IsDBNull(record.Item("image")) Then
            image = ConvertToByteArray(My.Resources.Default_Image)
        Else
            image = record.Item("image")
        End If
        Dim is_active As Boolean = record.Item("is_active")
        Dim deleted_at As DateTime = record.Item("deleted_at")
        Dim created_at As DateTime = record.Item("created_at")
        Dim updated_at As DateTime = record.Item("updated_at")
        Return New Staff(id, ref, fullname, gender, department, position, pass_code, phone, email, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at)
    End Function



    '
    'Returns Staff record using ID
    '
    Public Function getStaffById(id As Integer) As Staff
        Dim person = TA.GetDataById(id).Rows(0)
        Return createObject(person)
    End Function

    '
    'Returns Staff record using Ref
    '
    Public Function getStaffByRef(ref As String) As Staff
        Dim person = TA.GetDataByRef(ref).Rows(0)
        Return createObject(person)
    End Function


    '
    'Returns all Staff
    '
    Public Function getAllStaff() As List(Of Staff)
        'create list of staffs
        Dim staffList As New List(Of Staff)
        For Each person In TA.GetData
            If person.Item("deleted_at") > Now Then
                'adds staff object to stafflist
                staffList.Add(createObject(person))
            End If
        Next
        Return staffList
    End Function

    '
    'Returns all Staff by
    '
    Public Function getStaffByPosition(position As String) As List(Of Staff)
        'create list of staffs
        Dim staffList As New List(Of Staff)
        For Each person In TA.GetDataByPosition(position)
            If person.Item("deleted_at") > Now Then
                staffList.Add(createObject(person))
            End If
        Next
        Return staffList
    End Function


    Public Sub blockAllExpiredStaff()
        For Each person In TA.GetDataByDeleted
            'adds staff object to stafflist
            updateStaff(createObject(person))
        Next
    End Sub

    '
    'Returns all Staff
    '
    Public Function getAllStaffBySearch(search As String) As List(Of Staff)
        'create list of staffs
        Dim staffList As New List(Of Staff)
        For Each person In TA.GetDataBySearch(search)
            If person.Item("deleted_at") > Now Then
                'adds staff object to stafflist
                staffList.Add(createObject(person))
            End If
        Next
        Return staffList
    End Function

End Module
