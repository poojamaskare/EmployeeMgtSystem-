Public Class LOGIN

    Private Sub Cmdlogin_Click(sender As Object, e As EventArgs) Handles Cmdlogin.Click
        If txtusername.Text = "admin" And txtpassword.Text = "super@123" Then
            Me.Hide()
            Homepage.Show()
        Else
            MsgBox("Login Failed", MsgBoxStyle.Information)
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class