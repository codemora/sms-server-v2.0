Public Class Requestlog
    Private id As Integer
    Private staff_id As Integer
    Private user_id As Integer
    Private action As String
    Private status As String
    Private created_at As DateTime
    Private updated_at As DateTime


    Public Sub New(id As Integer, staff_id As Integer, user_id As Integer, action As String, status As String, created_at As DateTime, updated_at As DateTime)
        Me.id = id
        Me.user_id = user_id
        Me.staff_id = staff_id
        Me.action = action.Trim
        Me.created_at = created_at
        Me.updated_at = updated_at
        Me.status = status

    End Sub

    Public Function getId() As Integer
        Return Me.id
    End Function

    Public Function getUserId() As Integer
        Return Me.user_id
    End Function
    Public Function getStaffId() As Integer
        Return Me.staff_id
    End Function
    Public Function getAction() As String
        Return Me.action
    End Function
    Public Function getCreatedAt() As DateTime
        Return Me.created_at
    End Function
    Public Function getUpdatedAt() As DateTime
        Return Me.updated_at
    End Function
    Public Function getStatus() As String
        Return Me.status
    End Function
End Class
