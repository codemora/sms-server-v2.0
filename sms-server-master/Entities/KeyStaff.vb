Public Class KeyStaff
    Private id As Integer
    Private staff_id As Integer
    Private key_id As Integer
    Private is_fav As Boolean
    Private created_at As DateTime
    Private updated_at As DateTime

    Public Sub New(id As Integer, staff_id As Integer, key_id As Integer, is_fav As Boolean, created_at As DateTime, updated_at As DateTime)

        Me.id = id
        Me.staff_id = staff_id
        Me.key_id = key_id
        Me.is_fav = is_fav
        Me.created_at = created_at
        Me.updated_at = updated_at
    End Sub


    Public Function getId() As Integer
        Return Me.id
    End Function

    Public Function getStaffId() As Integer
        Return Me.staff_id
    End Function
    Public Function getKeyId() As Integer
        Return Me.key_id
    End Function
    Public Function getIsFav() As Boolean
        Return Me.is_fav
    End Function
    Public Function getCreatedAt() As DateTime
        Return Me.created_at
    End Function
    Public Function getUpdatedAt() As DateTime
        Return Me.updated_at
    End Function
End Class
