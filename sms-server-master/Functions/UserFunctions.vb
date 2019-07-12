Module UserFunctions

    Private TA As New SMSTableAdapters.usersTableAdapter

    '
    'Adds a user's record
    '
    Public Function addUser(user As User) As Boolean
        Try
            Return TA.Insert(user.getFullname, user.getPrivilege, user.getUsername, user.getPassword, user.getPhone, user.getSecurityQuestion, user.getSecurityAnswer, user.getImage, user.getIsActive, user.getDeletedAt, user.getCreatedAt, user.getUpdatedAt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    'Deletes a user's record
    '
    Public Function deleteUser(user As User) As Boolean
        Try
            Return TA.UpdateById(user.getFullname, user.getPrivilege, user.getUsername, user.getPassword, user.getPhone, user.getSecurityQuestion, user.getSecurityAnswer, user.getImage, False, Now, user.getCreatedAt, user.getUpdatedAt, user.getId)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    'Updates a user's record
    '
    Public Function updateUser(user As User) As Boolean
        Try
            Return TA.UpdateById(user.getFullname, user.getPrivilege, user.getUsername, user.getPassword, user.getPhone, user.getSecurityQuestion, user.getSecurityAnswer, user.getImage, user.getIsActive, user.getDeletedAt, user.getCreatedAt, user.getUpdatedAt, user.getId)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    'Changes user's status
    '
    Public Function blockUser(user As User) As Boolean
        Try
            Return TA.UpdateById(user.getFullname, user.getPrivilege, user.getUsername, user.getPassword, user.getPhone, user.getSecurityQuestion, user.getSecurityAnswer, user.getImage, Not user.getIsActive, user.getDeletedAt, user.getCreatedAt, user.getUpdatedAt, user.getId)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    '
    ' Checks if username exists
    '
    Public Function IsExistUsername(username As String) As Boolean
        If TA.GetDataByUsername(username).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    ' Checks if Phone number exists
    '
    Public Function IsExistUserPhoneNo(phone_no As String) As Boolean
        If TA.GetDataByPhone(phone_no).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    ' Checks if user with ID exists
    '
    Public Function IsExistUser(id As Integer) As Boolean
        If TA.GetDataById(id).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    ' Checks if user with ID exists
    '
    Public Function IsExistUser() As Boolean
        If TA.GetData.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    'Returns user record using username
    '
    Public Function getUserByUsername(username As String) As User
        Dim id As Integer = TA.GetDataByUsername(username).Rows(0).Item("id")
        Dim password As String = TA.GetDataByUsername(username).Rows(0).Item("password").ToString()
        Dim privilege As String = TA.GetDataByUsername(username).Rows(0).Item("privilege").ToString()
        Dim created_at As DateTime = TA.GetDataByUsername(username).Rows(0).Item("created_at")
        Dim updated_at As DateTime = TA.GetDataByUsername(username).Rows(0).Item("updated_at")
        Dim phone As String = TA.GetDataByUsername(username).Rows(0).Item("phone").ToString()
        Dim security_question As String = TA.GetDataByUsername(username).Rows(0).Item("security_question").ToString()
        Dim security_answer As String = TA.GetDataByUsername(username).Rows(0).Item("security_answer").ToString()
        Dim deleted_at As DateTime = TA.GetDataByUsername(username).Rows(0).Item("deleted_at")
        Dim image As Byte() = TA.GetDataByUsername(username).Rows(0).Item("image")
        Dim is_active As Boolean = TA.GetDataByUsername(username).Rows(0).Item("is_active")
        Dim fullname As String = TA.GetDataByUsername(username).Rows(0).Item("fullname").ToString()
        Return New User(id, fullname, privilege, username, password, phone, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at)
    End Function

    '
    'Returns user record using staffId
    '
    Public Function getUserById(id As Integer) As User
        Dim username As String = TA.GetDataById(id).Rows(0).Item("username").ToString
        Dim password As String = TA.GetDataById(id).Rows(0).Item("password").ToString()
        Dim privilege As String = TA.GetDataById(id).Rows(0).Item("privilege").ToString()
        Dim created_at As DateTime = TA.GetDataById(id).Rows(0).Item("created_at")
        Dim updated_at As DateTime = TA.GetDataById(id).Rows(0).Item("updated_at")
        Dim phone As String = TA.GetDataById(id).Rows(0).Item("phone").ToString()
        Dim security_question As String = TA.GetDataById(id).Rows(0).Item("security_question").ToString()
        Dim security_answer As String = TA.GetDataById(id).Rows(0).Item("security_answer").ToString()
        Dim deleted_at As DateTime = TA.GetDataById(id).Rows(0).Item("deleted_at")
        Dim image As Byte() = TA.GetDataById(id).Rows(0).Item("image")
        Dim is_active As Boolean = TA.GetDataById(id).Rows(0).Item("is_active")
        Dim fullname As String = TA.GetDataById(id).Rows(0).Item("fullname").ToString()
        Return New User(id, fullname, privilege, username, password, phone, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at)
    End Function

    '
    'Returns All users
    '
    Public Function getAllUser() As List(Of User)
        Dim UserList As New List(Of User)
        For Each person In TA.GetData
            If person.Item("deleted_at") > Now Then
                Dim id As Integer = person.Item("id")
                Dim username As String = person.Item("username").ToString
                Dim password As String = person.Item("password").ToString()
                Dim privilege As String = person.Item("privilege").ToString()
                Dim created_at As DateTime = person.Item("created_at")
                Dim updated_at As DateTime = person.Item("updated_at")
                Dim phone As String = person.Item("phone").ToString()
                Dim security_question As String = person.Item("security_question").ToString()
                Dim security_answer As String = person.Item("security_answer").ToString()
                Dim deleted_at As DateTime = person.Item("deleted_at")
                Dim image As Byte() = person.Item("image")
                Dim is_active As Boolean = person.Item("is_active")
                Dim fullname As String = person.Item("fullname").ToString()
                'adds user object to UserList
                UserList.Add(New User(id, fullname, privilege, username, password, phone, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at))
            End If
        Next
        Return UserList
    End Function


    '
    'Returns All users
    '
    Public Function getAllUserBySearch(search As String) As List(Of User)
        Dim UserList As New List(Of User)
        For Each person In TA.GetDataBySearch(search)
            If person.Item("deleted_at") > Now Then
                Dim id As Integer = person.Item("id")
                Dim username As String = person.Item("username").ToString
                Dim password As String = person.Item("password").ToString()
                Dim privilege As String = person.Item("privilege").ToString()
                Dim created_at As DateTime = person.Item("created_at")
                Dim updated_at As DateTime = person.Item("updated_at")
                Dim phone As String = person.Item("phone").ToString()
                Dim security_question As String = person.Item("security_question").ToString()
                Dim security_answer As String = person.Item("security_answer").ToString()
                Dim deleted_at As DateTime = person.Item("deleted_at")
                Dim image As Byte() = person.Item("image")
                Dim is_active As Boolean = person.Item("is_active")
                Dim fullname As String = person.Item("fullname").ToString()

                'adds user object to UserList
                UserList.Add(New User(id, fullname, privilege, username, password, phone, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at))
            End If
        Next
        Return UserList
    End Function

    '
    'Authenticates the user
    '
    Public Function checkUser(username As String, pass As String) As Boolean
        Try
            'checks if username exist and password is correct
            If TA.GetDataByAuth(username).Count > 0 Then
                If TA.GetDataByAuth(username).Rows(0).Item("password").ToString = pass Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error")
            Return False
        End Try
    End Function

End Module
