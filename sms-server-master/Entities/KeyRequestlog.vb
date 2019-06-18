Public Class keyRequestlog

    Private id As Integer
    Private requestlog_id As Integer
    Private key_id As Integer
    Private created_at As DateTime
    Private updated_at As DateTime

    Public Sub New(id As Integer, requestlog_id As Integer, key_id As Integer, created_at As DateTime, updated_at As DateTime)
        Me.id = id
        Me.requestlog_id = requestlog_id
        Me.key_id = key_id
        Me.created_at = created_at
        Me.updated_at = updated_at

    End Sub


    Public Function getRequestlogId() As Integer
        Return Me.requestlog_id
    End Function

    Public Function getId() As Integer
        Return Me.id
    End Function

    Public Function getKeyId() As Integer
        Return Me.key_id
    End Function
    Public Function getCreatedAt() As DateTime
        Return Me.created_at
    End Function
    Public Function getUpdatedAt() As DateTime
        Return Me.updated_at
    End Function

End Class
