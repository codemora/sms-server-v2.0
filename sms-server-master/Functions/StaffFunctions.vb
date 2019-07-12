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
    'Returns Staff record using ID
    '
    Public Function getStaffById(id As Integer) As Staff
        Dim ref As String = TA.GetDataById(id).Rows(0).Item("ref").ToString()
        Dim fullname As String = TA.GetDataById(id).Rows(0).Item("fullname").ToString()
        Dim phone As String = TA.GetDataById(id).Rows(0).Item("phone").ToString()
        Dim email As String = TA.GetDataById(id).Rows(0).Item("email").ToString()
        Dim gender As String = TA.GetDataById(id).Rows(0).Item("gender").ToString()
        Dim position As String = TA.GetDataById(id).Rows(0).Item("position").ToString()
        Dim department As String = TA.GetDataById(id).Rows(0).Item("department").ToString
        Dim pass_code As String = TA.GetDataById(id).Rows(0).Item("pass_code").ToString()
        Dim security_question As String = TA.GetDataById(id).Rows(0).Item("security_question").ToString()
        Dim security_answer As String = TA.GetDataById(id).Rows(0).Item("security_answer").ToString()
        Dim image As Byte() = TA.GetDataById(id).Rows(0).Item("image")
        'Dim image As Byte() = ConvertToByteArray(My.Resources.Profile_Image)
        Dim is_active As Boolean = TA.GetDataById(id).Rows(0).Item("is_active")
        Dim deleted_at As DateTime = TA.GetDataById(id).Rows(0).Item("deleted_at")
        Dim created_at As DateTime = TA.GetDataById(id).Rows(0).Item("created_at")
        Dim updated_at As DateTime = TA.GetDataById(id).Rows(0).Item("updated_at")
        Return New Staff(id, ref, fullname, gender, department, position, pass_code, phone, email, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at)
    End Function

    '
    'Returns Staff record using Ref
    '
    Public Function getStaffByRef(ref As String) As Staff
        Dim id As Integer = TA.GetDataByRef(ref).Rows(0).Item("id")
        Dim fullname As String = TA.GetDataByRef(ref).Rows(0).Item("fullname").ToString()
        Dim phone As String = TA.GetDataByRef(ref).Rows(0).Item("phone").ToString()
        Dim email As String = TA.GetDataByRef(ref).Rows(0).Item("email").ToString()
        Dim gender As String = TA.GetDataByRef(ref).Rows(0).Item("gender").ToString()
        Dim position As String = TA.GetDataByRef(ref).Rows(0).Item("position").ToString()
        Dim department As String = TA.GetDataByRef(ref).Rows(0).Item("department").ToString
        Dim pass_code As String = TA.GetDataByRef(ref).Rows(0).Item("pass_code").ToString()
        Dim security_question As String = TA.GetDataByRef(ref).Rows(0).Item("security_question").ToString()
        Dim security_answer As String = TA.GetDataByRef(ref).Rows(0).Item("security_answer").ToString()
        Dim image As Byte() = TA.GetDataByRef(ref).Rows(0).Item("image")
        Dim is_active As Boolean = TA.GetDataByRef(ref).Rows(0).Item("is_active")
        Dim deleted_at As DateTime = TA.GetDataByRef(ref).Rows(0).Item("deleted_at")
        Dim created_at As DateTime = TA.GetDataByRef(ref).Rows(0).Item("created_at")
        Dim updated_at As DateTime = TA.GetDataByRef(ref).Rows(0).Item("updated_at")
        Return New Staff(id, ref, fullname, gender, department, position, pass_code, phone, email, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at)
    End Function


    '
    'Returns all Staff
    '
    Public Function getAllStaff() As List(Of Staff)
        'create list of staffs
        Dim staffList As New List(Of Staff)
        For Each person In TA.GetData
            If person.Item("deleted_at") > Now Then
                Dim id As Integer = person.Item("id")
                Dim ref As String = person.Item("ref").ToString()
                Dim fullname As String = person.Item("fullname").ToString()
                Dim phone As String = person.Item("phone").ToString()
                Dim email As String = person.Item("email").ToString()
                Dim gender As String = person.Item("gender").ToString()
                Dim position As String = person.Item("position").ToString()
                Dim department As String = person.Item("department").ToString
                Dim pass_code As String = person.Item("pass_code").ToString()
                Dim security_question As String = person.Item("security_question").ToString()
                Dim security_answer As String = person.Item("security_answer").ToString()
                Dim image As Byte() = person.Item("image")
                Dim is_active As Boolean = person.Item("is_active")
                Dim deleted_at As DateTime = person.Item("deleted_at")
                Dim created_at As DateTime = person.Item("created_at")
                Dim updated_at As DateTime = person.Item("updated_at")
                'adds staff object to stafflist
                staffList.Add(New Staff(id, ref, fullname, gender, department, position, pass_code, phone, email, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at))
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
                Dim id As Integer = person.Item("id")
                Dim ref As String = person.Item("ref").ToString()
                Dim fullname As String = person.Item("fullname").ToString()
                Dim phone As String = person.Item("phone").ToString()
                Dim email As String = person.Item("email").ToString()
                Dim gender As String = person.Item("gender").ToString()
                'Dim position As String = person.Item("position").ToString()
                Dim department As String = person.Item("department").ToString
                Dim pass_code As String = person.Item("pass_code").ToString()
                Dim security_question As String = person.Item("security_question").ToString()
                Dim security_answer As String = person.Item("security_answer").ToString()
                Dim image As Byte() = person.Item("image")
                Dim is_active As Boolean = person.Item("is_active")
                Dim deleted_at As DateTime = person.Item("deleted_at")
                Dim created_at As DateTime = person.Item("created_at")
                Dim updated_at As DateTime = person.Item("updated_at")
                'adds staff object to stafflist
                staffList.Add(New Staff(id, ref, fullname, gender, department, position, pass_code, phone, email, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at))
            End If
        Next
        Return staffList
    End Function


    Public Sub blockAllExpiredStaff()
        For Each person In TA.GetDataByDeleted
            Dim id As Integer = person.Item("id")
            Dim ref As String = person.Item("ref").ToString()
            Dim fullname As String = person.Item("fullname").ToString()
            Dim phone As String = person.Item("phone").ToString()
            Dim email As String = person.Item("email").ToString()
            Dim gender As String = person.Item("gender").ToString()
            Dim position As String = person.Item("position").ToString()
            Dim department As String = person.Item("department").ToString
            Dim pass_code As String = person.Item("pass_code").ToString()
            Dim security_question As String = person.Item("security_question").ToString()
            Dim security_answer As String = person.Item("security_answer").ToString()
            Dim image As Byte() = person.Item("image")
            Dim deleted_at As DateTime = person.Item("deleted_at")
            Dim created_at As DateTime = person.Item("created_at")
            Dim updated_at As DateTime = person.Item("updated_at")
            'adds staff object to stafflist
            updateStaff(New Staff(id, ref, fullname, gender, department, position, pass_code, phone, email, security_question, security_answer, image, False, deleted_at, created_at, updated_at))
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
                Dim id As Integer = person.Item("id")
                Dim ref As String = person.Item("ref").ToString()
                Dim fullname As String = person.Item("fullname").ToString()
                Dim phone As String = person.Item("phone").ToString()
                Dim email As String = person.Item("email").ToString()
                Dim gender As String = person.Item("gender").ToString()
                Dim position As String = person.Item("position").ToString()
                Dim department As String = person.Item("department").ToString
                Dim pass_code As String = person.Item("pass_code").ToString()
                Dim security_question As String = person.Item("security_question").ToString()
                Dim security_answer As String = person.Item("security_answer").ToString()
                Dim image As Byte() = person.Item("image")
                Dim is_active As Boolean = person.Item("is_active")
                Dim deleted_at As DateTime = person.Item("deleted_at")
                Dim created_at As DateTime = person.Item("created_at")
                Dim updated_at As DateTime = person.Item("updated_at")
                'adds staff object to stafflist
                staffList.Add(New Staff(id, ref, fullname, gender, department, position, pass_code, phone, email, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at))
            End If
        Next
        Return staffList
    End Function

End Module
