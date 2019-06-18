Module functions

    Public message As String

    '
    'show message
    '
    Public Sub ShowMessage(time As Timer, lbl As Label, fontcolor As Color, message As String)
        time.Start()
        lbl.Text = message
        lbl.Visible = True
        lbl.ForeColor = fontcolor
    End Sub

    '
    'closes message
    '
    Public Sub CloseMessage(time As Timer, lbl As Label)
        time.Stop()
        lbl.Visible = False
    End Sub

    '
    'convert picture  from image to array of byte
    '
    Public Function ConvertToByteArray(image As Image) As Byte()
        Dim converter As New ImageConverter
        Return converter.ConvertTo(image, GetType(Byte()))
    End Function

    '
    'converts picture from array of byte to image
    '
    Public Function ConvertToImage(image As Byte()) As Image
        Dim ms As New System.IO.MemoryStream(image)
        Return System.Drawing.Image.FromStream(ms)
    End Function

    '
    'truncates the string after 25 characters
    '
    Public Function TruncateString(str As String, length As Integer) As String
        Dim truncatedStr As String
        If str.Length > length Then
            truncatedStr = str.Substring(0, length) + "..."
            Return truncatedStr
        End If
        Return str
    End Function

    '
    'for uploading an image
    '
    Public Function uploadImg(pic As OpenFileDialog, imgBox As PictureBox) As Boolean
        Try
            Dim file As String
            If pic.ShowDialog() = DialogResult.Cancel Then
                Return False
            Else
                file = pic.FileName
                imgBox.Image = Image.FromFile(file)
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function



    '
    'Returns the number of display records
    '
    Public Function numberOfDisplayedRecords(num_of_recs_displayed As Integer, total_recs As Integer) As String
        Return num_of_recs_displayed.ToString + " of " + total_recs.ToString + " Records"
    End Function

    '
    'Converts byte() to string
    '
    Public Function convertByteToString(byteArray As Byte()) As String
        Return System.Convert.ToBase64String(byteArray)
    End Function

    '
    'Converts string to byte()
    '
    Public Function convertStringToByte(imageString As String) As Byte()
        Return System.Convert.FromBase64String(imageString)
    End Function

    '
    'Return FirstName
    '
    Public Function getDisplayName(name As String) As String

        If IsNothing(name.Trim) Then Return Nothing
        Dim firstname As String
        If name.IndexOf(" ") = -1 Then
            firstname = name.Substring(0)
        Else
            firstname = name.Substring(0, name.IndexOf(" "))
        End If
        Dim display_name As String = firstname.Substring(0, 1).ToUpper + firstname.Substring(1).ToLower
        Return display_name

    End Function
End Module
