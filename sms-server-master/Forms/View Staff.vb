Public Class View_Staff
    Private Sub View_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With staff1.selected_staff
            PictureBox2.Image = ConvertToImage(.getImage)
            lblName.Text = .getOtherNames + " " + .getLastName
            'lblID.Text = .getRef
            'lblGender.Text = .getGender
            'lblEmail.Text = .getEmail
            lblDept.Text = "Dept: " + .getDepartment + vbNewLine + "Position: " + .getPosition
            'lblPhone.Text = .getPhone
            ' lblPosition.Text = "Position: " + staff.getPosition
            For Each itm In getAllKeyStaffByStaffId(.getId)
                listkeys.Items.Add(getKeyById(itm.getKeyId).getLock)
            Next
        End With
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'UpdateStaffForm.ShowDialog()
        Me.Close()
    End Sub
End Class