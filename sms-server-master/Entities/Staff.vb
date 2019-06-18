Public Class Staff

    Private id As Integer
    Private ref As String
    Private last_name As String
    Private other_names As String
    Private gender As String
    Private department As String
    Private position As String
    Private pass_code As String
    Private phone As String
    Private second_phone As String
    Private security_question As String
    Private security_answer As String
    Private image As Byte()
    Private is_active As Boolean
    Private deleted_at As DateTime?
    Private created_at As DateTime
    Private updated_at As DateTime

    Public Sub New(id As Integer, ref As String, last_name As String, other_names As String, gender As String, department As String, position As String, pass_code As String, phone As String, second_phone As String, security_question As String, security_answer As String, image As Byte(), is_active As Boolean, deleted_at As DateTime?, created_at As DateTime, updated_at As DateTime)

        Me.id = id
        Me.ref = ref.Trim
        Me.last_name = last_name.Trim
        Me.other_names = other_names.Trim
        Me.phone = phone.Trim
        Me.second_phone = second_phone.Trim
        Me.gender = gender.Trim
        Me.position = position.Trim
        Me.security_question = security_question
        Me.security_answer = security_answer
        Me.department = department.Trim
        Me.pass_code = pass_code
        Me.image = image
        Me.is_active = is_active
        Me.deleted_at = deleted_at
        Me.created_at = created_at
        Me.updated_at = updated_at
    End Sub

    Public Function getDepartment() As String
        Return Me.department
    End Function

    Public Function getPassCode() As String
        Return Me.pass_code
    End Function

    Public Function getPosition() As String
        Return Me.position
    End Function

    Public Function getId() As Integer
        Return Me.id
    End Function
    Public Function getRef() As String
        Return Me.ref
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
    Public Function getSecondPhone() As String
        Return Me.second_phone
    End Function
    Public Function getGender() As String
        Return Me.gender
    End Function
    Public Function getSecurityQuestion() As String
        Return Me.security_question
    End Function
    Public Function getSecurityAnswer() As String
        Return Me.security_answer
    End Function
    Public Function getImage() As Byte()
        Return Me.image
    End Function
    Public Function getIsActive() As Boolean
        Return Me.is_active
    End Function
    Public Function getDeletedAt() As DateTime?
        Return Me.deleted_at
    End Function
    Public Function getCreatedAt() As DateTime
        Return Me.created_at
    End Function
    Public Function getUpdatedAt() As DateTime
        Return Me.updated_at
    End Function
End Class
