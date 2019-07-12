Public Class View_Staff
    Private Sub View_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With staff1.selected_staff
            PictureBox1.Image = ConvertToImage(.getImage)
            lblFullname.Text = .getFullname
            lblRef.Text = "@" + .getRef.ToUpper
            lblGender.Text = .getGender
            If .getIsActive Then
                lblActive.Text = "Active"
                lblActive.BackColor = Color.Green
            Else
                lblActive.Text = "Deactivated"
                lblActive.BackColor = Color.Red
            End If
            If .getEmail = "" Then
                lblContact.Text = .getPhone
            Else
                lblContact.Text = .getPhone + " | " + .getEmail
            End If
            lblDepartment.Text = "Department: " + .getDepartment
            lblPosition.Text = "Position: " + .getPosition
            Dim key As Key
            For Each itm In getAllKeyStaffByStaffId(.getId)
                key = getKeyById(itm.getKeyId)
                lboxKeysAccessible.Items.Add(key.getTag + " (" + key.getLock + ")")
            Next
        End With
    End Sub

End Class