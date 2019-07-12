Public Class Requestlog
    Private id As Integer
    Private staff_ref As String
    Private username As String
    Private keys As String
    Private action As String
    Private status As String
    Private created_at As DateTime
    Private updated_at As DateTime


    Public Sub New(id As Integer, staff_ref As String, username As String, keys As String, action As String, status As String, created_at As DateTime, updated_at As DateTime)
        Me.id = id
        Me.username = username
        Me.staff_ref = staff_ref
        Me.action = action.Trim
        Me.created_at = created_at
        Me.updated_at = updated_at
        Me.status = status
        Me.keys = keys
    End Sub

    Public Function getId() As Integer
        Return Me.id
    End Function

    Public Function getKeys() As String
        Return Me.keys
    End Function

    Public Function getUsername() As String
        Return Me.username
    End Function
    Public Function getStaffRef() As String
        Return Me.staff_ref
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
