Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String
        fullname = txtFullName.Text

        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        Dim space As Integer
        space = fullnameTrimmed.IndexOf(" ")

        Dim first As String
        first = fullnameTrimmed.Substring(0, space)

        txtFirstName.Text = first

    End Sub
End Class
