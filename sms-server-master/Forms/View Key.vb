Public Class View_Key
    Private Sub View_Key_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With keys1.selected_key
            lblTag.Text = .getTag.ToUpper + " (" + .getLock.ToUpper + ")"
            lblLocation.Text = "Location:" + .getLocation
            lblQuantity.Text = "Quantity: " + .getQuantity.ToString
            If .getStatus.ToLower = "in" Then
                lblActive.Text = "In"
                lblActive.BackColor = Color.Green
            Else
                lblActive.Text = "Out"
                lblActive.BackColor = Color.Red
            End If
            lblBlock.Text = .getBlock
            lblType.Text = "Type: " + .getKeyType
            Dim staff As Staff
            For Each itm In getAllKeyStaffByKeyId(.getId)
                staff = getStaffById(itm.getStaffId)
                lboxAccessibleTo.Items.Add(staff.getRef + " (" + staff.getFullname + ")")
            Next
        End With
    End Sub
End Class