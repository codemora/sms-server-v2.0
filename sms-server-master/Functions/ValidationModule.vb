Imports System.Text.RegularExpressions
Module ValidationModule
    'Public student As New StudentFunctions
    'Public staff As New StaffFunctions
    'Public user As New UserFunctions
    '
    'Options
    '
    'Public Enum keyType 'Search type options
    '    Id
    '    Room
    '    Phone
    'End Enum

    'Public Function GetOption(cmb As ComboBox) As keyType 'Gets a Search Type option 
    '    If cmb.SelectedItem = "Id" Then
    '        Return keyType.Id
    '    ElseIf cmb.SelectedItem = "Room" Then
    '        Return keyType.Room
    '    ElseIf cmb.SelectedItem = "Phone" Then
    '        Return keyType.Phone
    '    Else
    '        Return keyType.Id
    '    End If
    'End Function

    '
    'VALIDATION FUNCTIONS
    '

    Public Function ValidatePassword(errorProvider As ErrorProvider, txtbox As TextBox, message As String, searchBox As MaskedTextBox) As Boolean
        Dim pattern As String = "^.*(?=.{5,16}).*$"
        Dim password As New Regex(pattern) 'Attach Pattern To name Textbox

        'Not A Match
        If searchBox.Focused Then
            errorProvider.SetError(txtbox, "")
            Return False
        ElseIf txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Please the field must not be empty")
            Beep()
            Return False
        ElseIf Not password.IsMatch(txtbox.Text.Trim) Then
            errorProvider.SetError(txtbox, message)
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    Public Function ValidateConfirmPassword(errorProvider As ErrorProvider, txtbox As TextBox, txtbox1 As TextBox, message As String, searchBox As MaskedTextBox) As Boolean
        If searchBox.Focused Then
            errorProvider.SetError(txtbox, "")
            Return False
        ElseIf txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Please the field must not be empty")
            Beep()
            Return False
        ElseIf txtbox.Text.Trim <> txtbox1.Text.Trim Then
            errorProvider.SetError(txtbox, message)
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function


    Public Function ValidateUsername(errorProvider As ErrorProvider, txtbox As TextBox) As Boolean

        Dim pattern As String = "^[a-zA-Z0-9_]{3,16}$"

        Dim name As New Regex(pattern) 'Attach Pattern To name Textbox

        'Not A Match
        If txtbox.Text.Trim = "" Then
            errorProvider.SetError(txtbox, "Please the field must not be empty")
            Beep()
            Return False
        ElseIf Not name.IsMatch(txtbox.Text.Trim) Then
            errorProvider.SetError(txtbox, "Invalid Username! May include lower or upper case letter, digits or underscore. Must be 3 to 16 characters.")
            Beep()
            Return False
        ElseIf IsExistUsername(txtbox.Text.Trim) Then
            errorProvider.SetError(txtbox, "This Username already exist")
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    Public Function ValidateStaffRef(errorProvider As ErrorProvider, txtbox As TextBox) As Boolean

        Dim pattern As String = "^[a-zA-Z0-9_]{3,16}$"

        Dim name As New Regex(pattern) 'Attach Pattern To name Textbox

        'Not A Match
        If txtbox.Text.Trim = "" Then
            errorProvider.SetError(txtbox, "Please the field must not be empty")
            Beep()
            Return False
        ElseIf Not name.IsMatch(txtbox.Text.Trim) Then
            errorProvider.SetError(txtbox, "Invalid Staff Ref! May include lower or upper case letter, digits or underscore. Must be 3 to 16 characters.")
            Beep()
            Return False
        ElseIf IsExistStaff(txtbox.Text.Trim) Then
            errorProvider.SetError(txtbox, "Staff Ref already exist")
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function


    Public Function ValidateName(errorProvider As ErrorProvider, txtbox As TextBox, message As String, searchBox As MaskedTextBox) As Boolean
        'Create A Pattern For name
        Dim pattern As String = "^[a-zA-Z\s]+$"

        Dim name As New Regex(pattern) 'Attach Pattern To name Textbox

        'Not A Match
        If searchBox.Focused Then
            errorProvider.SetError(txtbox, "")
            Return False
        ElseIf txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Please the field must not be empty")
            Beep()
            Return False
        ElseIf Not name.IsMatch(txtbox.Text.Trim) Then
            errorProvider.SetError(txtbox, message)
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    Public Function ValidateText(errorProvider As ErrorProvider, txtbox As TextBox) As Boolean
        If txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Field must not be empty")
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    Public Function ValidateComboBox(errorProvider As ErrorProvider, cmbBox As ComboBox) As Boolean
        'If searchBox.Focused Then
        '    errorProvider.SetError(cmbBox, "")
        '    Return False
        If cmbBox.SelectedIndex = 0 Then
            errorProvider.SetError(cmbBox, "Select an option")
            Beep()
            Return False
        Else
            errorProvider.SetError(cmbBox, "")
            Return True
        End If
    End Function


    Public Function ValidateEmail(errorProvider As ErrorProvider, txtbox As TextBox) As Boolean

        'Set Up Reg Exp Pattern To Allow Most Characters, And No Special Characters
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." +
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", RegexOptions.IgnoreCase Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace Or RegexOptions.Compiled)

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(txtbox.Text.Trim)
        If txtbox.Text.Trim = "" Then
            errorProvider.SetError(txtbox, "") 'Inform User
            Return True
            'Check If Entered Email Is In Correct Format
        ElseIf Not txtbox.Text.Equals(reEmail.Match(txtbox.Text.Trim).ToString) Then
            errorProvider.SetError(txtbox, "Invalid Email Address!") 'Inform User
            Beep()
            Return False
        ElseIf IsExistStaffEmail(txtbox.Text.Trim) Then
            errorProvider.SetError(txtbox, "Email already exist")
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If


    End Function



    Public Function ValidateAmount(errorProvider As ErrorProvider, txtbox As TextBox, amountToPay As Double, searchBox As MaskedTextBox) As Boolean
        If searchBox.Focused Then
            errorProvider.SetError(txtbox, "")
            Return False
        ElseIf IsNothing(txtbox.Text) = True Then
            errorProvider.SetError(txtbox, "")
            Return True
        ElseIf IsNumeric(txtbox.Text) = False Then
            errorProvider.SetError(txtbox, "Please enter valid amount paid")
            Beep()
            Return False
        ElseIf Int(txtbox.Text) < 0 Then
            errorProvider.SetError(txtbox, "Amount should not be less then 0")
            Beep()
            Return False
        ElseIf CDbl(txtbox.Text) > amountToPay Then
            errorProvider.SetError(txtbox, "Amount should not be more then amount to be paid")
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function


    Public Function ValidateNumber(errorProvider As ErrorProvider, txtbox As TextBox, message As String, searchBox As MaskedTextBox) As Boolean
        If searchBox.Focused Then
            errorProvider.SetError(txtbox, "")
            Return False
        ElseIf IsNothing(txtbox.Text) = True Then
            errorProvider.SetError(txtbox, "Field should not be empty")
            Beep()
            Return False
        ElseIf IsNumeric(txtbox.Text) = False Then
            errorProvider.SetError(txtbox, message)
            Beep()
            Return False

        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    Public Function ValidateKeyTag(errorProvider As ErrorProvider, txtbox As TextBox) As Boolean
        If txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Field should not be empty")
            Beep()
            Return False
        ElseIf isExistKey(txtbox.text) Then
            errorProvider.SetError(txtbox, "Key Tag already exist")
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    Public Function ValidateLock(errorProvider As ErrorProvider, txtbox As TextBox) As Boolean
        If txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Field should not be empty")
            Beep()
            Return False
        ElseIf isExistLock(txtbox.Text) Then
            errorProvider.SetError(txtbox, "Lock already exist")
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    'Public Function ValidateID(errorProvider As ErrorProvider, txtbox As MaskedTextBox, message As String, searchBox As MaskedTextBox) As Boolean
    '    If searchBox.Focused Then
    '        errorProvider.SetError(txtbox, "")
    '        Return False
    '    ElseIf txtbox.Text = "" Then
    '        errorProvider.SetError(txtbox, "Field should not be empty")
    '        Beep()
    '        Return False
    '    ElseIf txtbox.Text.Length > 10 Or txtbox.Text.Length < 8 Then
    '        errorProvider.SetError(txtbox, message)
    '        Beep()
    '        Return False
    '    ElseIf Form3.btnUpdate.Enabled = True And student.updateKey = Form3.txtindexno.Text.Trim Then
    '        errorProvider.SetError(txtbox, "")
    '        Return True

    '    ElseIf student.IsExist(keyType.Id, txtbox.Text.Trim) Then
    '        errorProvider.SetError(txtbox, "This ID already exist")
    '        Beep()
    '        Return False
    '    Else
    '        errorProvider.SetError(txtbox, "")
    '        Return True
    '    End If
    'End Function


    'Public Function ValidateIDStaff(errorProvider As ErrorProvider, txtbox As MaskedTextBox, message As String, searchBox As MaskedTextBox) As Boolean
    '    If searchBox.Focused Then
    '        errorProvider.SetError(txtbox, "")
    '        Return False
    '    ElseIf txtbox.Text = "" Then
    '        errorProvider.SetError(txtbox, "Field should not be empty")
    '        Beep()
    '        Return False
    '    ElseIf txtbox.Text.Length > 10 Or txtbox.Text.Length < 8 Then
    '        errorProvider.SetError(txtbox, message)
    '        Beep()
    '        Return False
    '    ElseIf Form6.btnUpdate.Enabled = True And staff.updateKey = Form6.txtStaffID.Text.Trim Then
    '        errorProvider.SetError(txtbox, "")
    '        Return True

    '    ElseIf staff.IsExist(keyType.Id, txtbox.Text.Trim) Then
    '        errorProvider.SetError(txtbox, "This ID already exist")
    '        Beep()
    '        Return False
    '    Else
    '        errorProvider.SetError(txtbox, "")
    '        Return True
    '    End If
    'End Function

    Public Function ValidateStaffPhoneN0(errorProvider As ErrorProvider, txtbox As TextBox) As Boolean
        If txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Field should not be empty")
            Beep()
            Return False
        ElseIf txtbox.Text.Length < 10 Then
            errorProvider.SetError(txtbox, "Invalid Phone number")
            Beep()
            Return False
        ElseIf IsExistStaffPhone(txtbox.Text.Trim) Then
            errorProvider.SetError(txtbox, "Phone number already exist")
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    Public Function ValidateUserPhoneN0(errorProvider As ErrorProvider, txtbox As TextBox) As Boolean
        If txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Field should not be empty")
            Beep()
            Return False
        ElseIf txtbox.Text.Length < 10 Then
            errorProvider.SetError(txtbox, "Invalid Phone number")
            Beep()
            Return False
        ElseIf IsExistUserPhoneNo(txtbox.Text.Trim) Then
            errorProvider.SetError(txtbox, "Phone number already exist")
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    Public Function ValidateDOB(errorProvider As ErrorProvider, txtbox As MaskedTextBox, message As String, searchBox As MaskedTextBox) As Boolean
        If searchBox.Focused Then
            errorProvider.SetError(txtbox, "")
            Return False
        ElseIf txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Field should not be empty")
            Beep()
            Return False
        ElseIf txtbox.Text.Length < 10 Then
            errorProvider.SetError(txtbox, message)
            Beep()
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    Public Function ValidateDate(errorProvider As ErrorProvider, datePicker As DateTimePicker, message As String, searchBox As MaskedTextBox) As Boolean
        If searchBox.Focused Then
            errorProvider.SetError(datePicker, "")
            Return False
        ElseIf datePicker.Value.CompareTo(Now) = 1 Then
            errorProvider.SetError(datePicker, message)
            Beep()
            Return False
        Else
            errorProvider.SetError(datePicker, "")
            Return True
        End If
    End Function

    'Public Function ValidateRoomN0(errorProvider As ErrorProvider, txtbox As MaskedTextBox, gender As String, numPerRoom As Integer, searchBox As MaskedTextBox) As Boolean
    '    If searchBox.Focused Then
    '        errorProvider.SetError(txtbox, "")
    '        Return False

    '    ElseIf txtbox.Text = "" Then
    '        errorProvider.SetError(txtbox, "Field should not be empty")
    '        Beep()
    '        Return False
    '    ElseIf student.original_room = txtbox.Text.Trim Then
    '        errorProvider.SetError(txtbox, "")
    '        Return True
    '    ElseIf txtbox.Text.Length > 3 Or IsNumeric(txtbox.Text) Then
    '        errorProvider.SetError(txtbox, "Invalid Room Number")
    '        Beep()
    '        Return False
    '    ElseIf Form3.btnUpdate.Enabled = True And student.original_room = Form3.txtRoom.Text.Trim Then
    '        errorProvider.SetError(txtbox, "")
    '        Return True
    '    ElseIf Not student.Room.IsExist(txtbox.Text) Then
    '        errorProvider.SetError(txtbox, "Room does not exist")
    '        Beep()
    '        Return False
    '    ElseIf student.Room.IsFull() Then
    '        errorProvider.SetError(txtbox, "Room is full")
    '        Beep()
    '        Return False
    '    ElseIf Not student.Room.GenderAccept(gender) Then
    '        errorProvider.SetError(txtbox, "Room can not accept this gender")
    '        Beep()
    '        Return False
    '    ElseIf Not student.Room.NumberPerRoom(numPerRoom) Then
    '        errorProvider.SetError(txtbox, "Invalid Number Per Room")
    '        Beep()
    '        Return False
    '    Else
    '        errorProvider.SetError(txtbox, "")
    '        Return True
    '    End If
    'End Function

    ''
    ''show message
    ''
    'Public Sub ShowMessage(time As Timer, lbl As Label, fontcolor As Color, message As String)
    '    time.Start()
    '    lbl.Text = message
    '    lbl.Visible = True
    '    lbl.ForeColor = fontcolor
    'End Sub

    ''
    ''closes message
    ''
    'Public Sub CloseMessage(time As Timer, lbl As Label)
    '    time.Stop()
    '    lbl.Visible = False
    'End Sub
End Module
