Public Class TempIDGenerator
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text.ToLower
            Case "national service person"
                ComboBox2.SelectedItem = "others"
                DateTimePicker1.Value = generateServiceYear()
            Case "casual staff", "casual labourer"
                ComboBox2.SelectedItem = "Indefinate"
            Case "intern"
                ComboBox2.SelectedItem = "1 month"
        End Select
    End Sub

    Function generateServiceYear() As Date
        Dim year As String = Today.AddYears(1).Year
        Return CDate("09/09/" + year)
    End Function

    Function generateDate(duration As String) As DateTime
        duration = duration.ToLower
        If duration = "1 day" Then
            Return Today.AddDays(1)
        ElseIf duration = "1 week" Then
            Return Today.AddDays(7)
        ElseIf duration = "1 month" Then
            Return Today.AddMonths(1)
        ElseIf duration = "1 year" Then
            Return Today.AddYears(1)
        Else
            Return Today
        End If
    End Function

    Function generateId(id_type As String) As String
        Try
            id_type = id_type.ToLower
            Dim index As String = nextIndex(id_type).ToString

            If id_type = "national service person" Then
                Return "NSS" + index + Today.ToString("yy")
            ElseIf id_type = "intern" Then
                Return "INT" + index + Today.ToString("yy")
            ElseIf id_type = "casual staff" Then
                Return "CS" + index + Today.ToString("yy")
            ElseIf id_type = "casual labourer" Then
                Return "CL" + index + Today.ToString("yy")
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Indefinate" Then
            DateTimePicker1.Value = CDate("12/12/9998")
            DateTimePicker1.Enabled = True
        ElseIf ComboBox2.Text = "others" Then
            DateTimePicker1.Value = Today
            DateTimePicker1.Enabled = True
        Else
            DateTimePicker1.Value = generateDate(ComboBox2.Text)
            DateTimePicker1.Enabled = False
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If Me.Owner.Name = "Add_Staff" Then
            Add_Staff.txtStaffRef.Text = generateId(ComboBox1.Text)
            Add_Staff.txtStaffRef.Enabled = False
            Add_Staff.btnClear.Enabled = True
            Add_Staff.txtFullname.Focus()
            Add_Staff.deleted_at = DateTimePicker1.Value
        ElseIf Me.Owner.Name = "Edit_Staff" Then
            Edit_Staff.txtStaffRef.Text = generateId(ComboBox1.Text)
            Edit_Staff.txtStaffRef.Enabled = False
            Edit_Staff.btnClear.Enabled = True
            Edit_Staff.txtfullname.Focus()
            Edit_Staff.deleted_at = DateTimePicker1.Value
        End If
        Me.ComboBox1.SelectedIndex = -1
        Me.ComboBox2.SelectedIndex = -1
        Me.DateTimePicker1.Value = Now
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class