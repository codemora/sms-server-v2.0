Imports System.Text.RegularExpressions
Module ValidationFunction
    'sta
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
            Return False
        ElseIf Not name.IsMatch(txtbox.Text.Trim) Then
            errorProvider.SetError(txtbox, message)
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function
    Function ValidateComboBox(errorProvider As ErrorProvider, cmbBox As ComboBox, message As String, searchBox As MaskedTextBox) As Boolean
        If searchBox.Focused Then
            errorProvider.SetError(cmbBox, "")
            Return False
        ElseIf cmbBox.SelectedIndex = -1 Then
            errorProvider.SetError(cmbBox, message)
            Return False
        Else
            errorProvider.SetError(cmbBox, "")
            Return True
        End If
    End Function
    Public Function ValidateEmail(errorProvider As ErrorProvider, txtbox As TextBox, searchBox As MaskedTextBox) As Boolean

        'Set Up Reg Exp Pattern To Allow Most Characters, And No Special Characters
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", RegexOptions.IgnoreCase Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace Or RegexOptions.Compiled)

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(txtbox.Text.Trim)
        If searchBox.Focused Then
            errorProvider.SetError(txtbox, "")
            Return False
        ElseIf IsNothing(txtbox) Then
            txtbox.Text = "default@example.com"
            errorProvider.SetError(txtbox, "") 'Inform User
            Return True
        ElseIf blnPossibleMatch Then

            'Check If Entered Email Is In Correct Format
            If Not txtbox.Text.Equals(reEmail.Match(txtbox.Text.Trim).ToString) Then
                errorProvider.SetError(txtbox, "Invalid Email Address!") 'Inform User
                Return False
            Else
                errorProvider.SetError(txtbox, "")
                Return True 'Email is Perfect
            End If

        Else 'Not A Match To Pattern
            errorProvider.SetError(txtbox, "Invalid Email Address!") 'Inform User
            Return False 'Set Boolean Variable To False
        End If

    End Function
    Public Function ValidateID(errorProvider As ErrorProvider, txtbox As MaskedTextBox, message As String, searchBox As MaskedTextBox) As Boolean
        If searchBox.Focused Then
            errorProvider.SetError(txtbox, "")
            Return False
        ElseIf txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Field should not be empty")
            Return False
        ElseIf txtbox.Text.Length > 10 Or txtbox.Text.Length < 8 Then
            errorProvider.SetError(txtbox, message)
            Return False
       
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function

    Public Function ValidatePhoneN0(errorProvider As ErrorProvider, txtbox As MaskedTextBox, message As String, searchBox As MaskedTextBox) As Boolean
        If searchBox.Focused Then
            errorProvider.SetError(txtbox, "")
            Return False
        ElseIf txtbox.Text = "" Then
            errorProvider.SetError(txtbox, "Field should not be empty")
            Return False
        ElseIf txtbox.Text.Length < 14 Then
            errorProvider.SetError(txtbox, message)
            Return False
        Else
            errorProvider.SetError(txtbox, "")
            Return True
        End If
    End Function



End Module
