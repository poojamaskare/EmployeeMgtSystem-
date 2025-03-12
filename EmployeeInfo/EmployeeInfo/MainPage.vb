Public Class MainPage
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs)
        EmpDetails.Show()
    End Sub

    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UpdateEmployee.Show()
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        delete.Show()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'MainPage
        '
        Me.ClientSize = New System.Drawing.Size(328, 261)
        Me.Name = "MainPage"
        Me.ResumeLayout(False)

    End Sub
End Class

