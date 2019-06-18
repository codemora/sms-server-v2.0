Public Class Key

    Private id As Integer
    Private tag As String
    Private key_type As String
    Private lock As String
    Private block As String
    Private location As String
    Private quantity As Integer
    Private status As String
    Private created_at As Date
    Private updated_at As Date

    Public Sub New(id As Integer, tag As String, key_type As String, lock As String, block As String, location As String, quantity As Integer, status As String, created_at As Date, updated_at As Date)

        Me.id = id
        Me.tag = tag.Trim
        Me.key_type = key_type.Trim
        Me.lock = lock.Trim
        Me.block = block.Trim
        Me.location = location.Trim
        Me.quantity = quantity
        Me.status = status.Trim
        Me.created_at = created_at
        Me.updated_at = updated_at
    End Sub

    Public Function getId() As Integer
        Return Me.id
    End Function
    Public Function getTag() As String
        Return Me.tag
    End Function
    Public Function getKeyType() As String
        Return Me.key_type
    End Function
    Public Function getLock() As String
        Return Me.lock
    End Function
    Public Function getBlock() As String
        Return Me.block
    End Function
    Public Function getLocation() As String
        Return Me.location
    End Function
    Public Function getQuantity() As Integer
        Return Me.quantity
    End Function
    Public Function getStatus() As String
        Return Me.status
    End Function
    Public Function getUpatedAt() As Date
        Return Me.updated_at
    End Function
    Public Function getCreatedAt() As Date
        Return Me.created_at
    End Function
End Class
