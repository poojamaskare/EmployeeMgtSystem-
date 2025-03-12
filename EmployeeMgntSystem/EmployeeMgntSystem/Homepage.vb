Public Class Homepage
    Private Sub Cmdadd_Click(sender As Object, e As EventArgs) Handles Cmdadd.Click
        Me.Hide()
        Employee.Show()
    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Me.Hide()
        details.Show()
    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        Me.Hide()
        Salary.Show()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class