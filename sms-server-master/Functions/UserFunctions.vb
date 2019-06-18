Module UserFunctions

    Private TA As New SMSTableAdapters.usersTableAdapter

    '
    'Adds a user's record
    '
    Public Function addUser(user As User) As Boolean
        Try
            Return TA.Insert(user.getLastName, user.getOtherNames, user.getPrivilege, user.getUsername, user.getPassword, user.getPhone, user.getSecurityQuestion, user.getSecurityAnswer, user.getImage, user.getIsActive, user.getDeletedAt, user.getCreatedAt, user.getUpdatedAt)
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
            Return TA.UpdateById(user.getLastName, user.getOtherNames, user.getPrivilege, user.getUsername, user.getPassword, user.getPhone, user.getSecurityQuestion, user.getSecurityAnswer, user.getImage, False, Now, user.getCreatedAt, user.getUpdatedAt, user.getId)
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
            Return TA.UpdateById(user.getLastName, user.getOtherNames, user.getPrivilege, user.getUsername, user.getPassword, user.getPhone, user.getSecurityQuestion, user.getSecurityAnswer, user.getImage, user.getIsActive, user.getDeletedAt, user.getCreatedAt, user.getUpdatedAt, user.getId)
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
            Return TA.UpdateById(user.getLastName, user.getOtherNames, user.getPrivilege, user.getUsername, user.getPassword, user.getPhone, user.getSecurityQuestion, user.getSecurityAnswer, user.getImage, Not user.getIsActive, user.getDeletedAt, user.getCreatedAt, user.getUpdatedAt, user.getId)
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
        Dim last_name As String = TA.GetDataByUsername(username).Rows(0).Item("last_name").ToString()
        Dim other_names As String = TA.GetDataByUsername(username).Rows(0).Item("other_names").ToString()
        Return New User(id, last_name, other_names, privilege, username, password, phone, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at)
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
        Dim last_name As String = TA.GetDataById(id).Rows(0).Item("last_name").ToString()
        Dim other_names As String = TA.GetDataById(id).Rows(0).Item("other_names").ToString()
        Return New User(id, last_name, other_names, privilege, username, password, phone, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at)
    End Function

    '
    'Returns All users
    '
    Public Function getAllUser() As List(Of User)
        Dim UserList As New List(Of User)
        For Each person In TA.GetData
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
            Dim last_name As String = person.Item("last_name").ToString()
            Dim other_names As String = person.Item("other_names").ToString()
            'adds user object to UserList
            UserList.Add(New User(id, last_name, other_names, privilege, username, password, phone, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at))
        Next
        Return UserList
    End Function


    '
    'Returns All users
    '
    Public Function getAllUser(recsOnDisplay As Integer) As List(Of User)
        Dim UserList As New List(Of User)
        For Each person In TA.GetData.Skip(recsOnDisplay)
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
            Dim last_name As String = person.Item("last_name").ToString()
            Dim other_names As String = person.Item("other_names").ToString()
            'adds user object to UserList
            UserList.Add(New User(id, last_name, other_names, privilege, username, password, phone, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at))
        Next
        Return UserList
    End Function


    '
    'Returns All users
    '
    Public Function getAllUser(page As Integer, numPerPage As Integer) As List(Of User)
        Dim UserList As New List(Of User)
        For Each person In TA.GetData.Skip(page * numPerPage).Take(numPerPage)
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
            Dim last_name As String = person.Item("last_name").ToString()
            Dim other_names As String = person.Item("other_names").ToString()
            'adds user object to UserList
            UserList.Add(New User(id, last_name, other_names, privilege, username, password, phone, security_question, security_answer, image, is_active, deleted_at, created_at, updated_at))
        Next
        Return UserList
    End Function

    '
    'Authenticates the user
    '
    Public Function checkUser(username As String, pass As String) As Boolean
        Try
            Dim user As User = getUserByUsername(username)

            'checks if username exist and password is correct 
            If user.getPassword = pass Then

                'If Me.name.IndexOf(" ") > 0 And Me.name.Substring(0, Me.name.IndexOf(" ") + 1).Length > 13 Then
                '    HomePage.UserMenu.Text = Me.name.Substring(0, 10) + "..."
                '    HomePage.UserMenu.Image = ConvertToImage(Me.image)
                'ElseIf Me.name.IndexOf(" ") > 0 Then
                '    HomePage.UserMenu.Text = Me.name.Substring(0, Me.name.IndexOf(" ") + 1)
                '    HomePage.UserMenu.Image = ConvertToImage(Me.image)
                'ElseIf Me.name.Length > 13 Then
                '    HomePage.UserMenu.Text = Me.name.Substring(0, 10) + "..."
                '    HomePage.UserMenu.Image = ConvertToImage(Me.image)
                'Else
                '    HomePage.UserMenu.Text = Me.name
                '    HomePage.UserMenu.Image = ConvertToImage(Me.image)
                'End If
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error")
            Return False
        End Try
    End Function

End Module
