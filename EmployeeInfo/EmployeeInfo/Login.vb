Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Login

    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        If txtusername.Text = "admin" And txtpassword.Text = "super@123" Then
            MainPage.Show()
        Else
            MsgBox("Login Failed", MsgBoxStyle.Information)
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        End If
    End Sub
End Class