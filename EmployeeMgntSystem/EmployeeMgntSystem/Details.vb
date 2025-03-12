Public Class details
    Private Sub details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        cmbempid.Items.Clear()
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select empid from EmployeeDetails order by empid", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            rsEmployeeDetails.MoveFirst()
            Do Until rsEmployeeDetails.EOF
                cmbempid.Items.Add(rsEmployeeDetails.Fields("empid").Value)
                rsEmployeeDetails.MoveNext()
            Loop
        End If
        rsEmployeeDetails.Close()
        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
    End Sub

    Private Sub cmbempid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbempid.SelectedIndexChanged

        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select * from EmployeeDetails where Empid = '" & cmbempid.Text & "'", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            txtemployeename.Text = rsEmployeeDetails.Fields("Name").Value
            txtemployeeage.Text = rsEmployeeDetails.Fields("Age").Value
            txtemployeeadd.Text = rsEmployeeDetails.Fields("Address").Value
            txtgender.Text = rsEmployeeDetails.Fields("Gender").Value
            txtempposition.Text = rsEmployeeDetails.Fields("Position").Value
            txtqualification.Text = rsEmployeeDetails.Fields("Qualification").Value
            txtdob.Text = rsEmployeeDetails.Fields("dob").Value
        End If
        rsEmployeeDetails.Close()
        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
    End Sub

    Private Sub cmdhome_Click(sender As Object, e As EventArgs) Handles cmdhome.Click
        Me.Hide()
        Homepage.Show()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System ", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("********EMPLOYEE SUMMARY********", New Font("Arial", 20), Brushes.Black, 250, 100)
        e.Graphics.DrawString("EMPLOYEE Name =" + txtemployeename.Text, New Font("cambria", 22), Brushes.Black, 140, 200)
        e.Graphics.DrawString("EMPLOYEE Age =" + txtemployeeage.Text, New Font("cambria", 22), Brushes.Black, 140, 250)
        e.Graphics.DrawString("EMPLOYEE Address=" + txtemployeeadd.Text, New Font("cambria", 22), Brushes.Black, 140, 300)
        e.Graphics.DrawString("Employee Gender = " + txtgender.Text, New Font("cambria", 22), Brushes.Black, 140, 350)
        e.Graphics.DrawString("Employee Position = " + txtempposition.Text, New Font("cambria", 22), Brushes.Black, 140, 400)
        e.Graphics.DrawString("Employee Qualification = " + txtqualification.Text, New Font("cambria", 22), Brushes.Black, 140, 450)
        e.Graphics.DrawString("EMPLOYEE DOB =" + txtdob.Text, New Font("cambria", 22), Brushes.Black, 140, 500)
    End Sub
    Private Sub cmdprint_Click(sender As Object, e As EventArgs) Handles cmdprint.Click
        PrintPreviewDialog1.Show()

    End Sub
End Class