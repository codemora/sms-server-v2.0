Public Class User

    Private id As Integer
    Private last_name As String
    Private other_names As String
    Private username As String
    Private password As String
    Private privilege As String
    Private phone As String
    Private image As Byte()
    Private security_question As String
    Private security_answer As String
    Private is_active As Boolean
    Private deleted_at As DateTime
    Private created_at As DateTime
    Private updated_at As DateTime

    Public Sub New(id As String, last_name As String, other_names As String, privilege As String, username As String, password As String, phone As String, security_question As String, security_answer As String, image As Byte(), is_active As Boolean, deleted_at As DateTime, created_at As DateTime, updated_at As DateTime)

        Me.id = id
        Me.username = username.Trim
        Me.password = password.Trim
        Me.privilege = privilege.Trim
        Me.created_at = created_at
        Me.updated_at = updated_at
        Me.phone = phone.Trim
        Me.last_name = last_name.Trim
        Me.image = image
        Me.security_answer = security_answer
        Me.security_question = security_question
        Me.is_active = is_active
        Me.deleted_at = deleted_at
        Me.other_names = other_names

    End Sub


    Public Function getId() As Integer
        Return Me.id
    End Function
    Public Function getUsername() As String
        Return Me.username
    End Function
    Public Function getPassword() As String
        Return Me.password
    End Function
    Public Function getPrivilege() As String
        Return Me.privilege
    End Function
    Public Function getLastName() As String
        Return Me.last_name
    End Function
    Public Function getOtherNames() As String
        Return Me.other_names
    End Function
    Public Function getPhone() As String
        Return Me.phone
    End Function
    Public Function getCreatedAt() As DateTime
        Return Me.created_at
    End Function
    Public Function getUpdatedAt() As DateTime
        Return Me.updated_at
    End Function
    Public Function getDeletedAt() As DateTime
        Return Me.deleted_at
    End Function
    Public Function getImage() As Byte()
        Return Me.image
    End Function
    Public Function getSecurityQuestion() As String
        Return Me.security_question
    End Function
    Public Function getSecurityAnswer() As String
        Return Me.security_answer
    End Function
    Public Function getIsActive() As Boolean
        Return Me.is_active
    End Function
End Class
