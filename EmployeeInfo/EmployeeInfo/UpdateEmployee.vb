Public Class UpdateEmployee
    Private Sub UpdateEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        cmbEmpId.Items.Clear()
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select empid from EmployeeDetails order by empid", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            rsEmployeeDetails.MoveFirst()
            Do Until rsEmployeeDetails.EOF
                cmbEmpId.Items.Add(rsEmployeeDetails.Fields("empid").Value)
                rsEmployeeDetails.MoveNext()
            Loop
        End If
        rsEmployeeDetails.Close()
        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
    End Sub
    Private Sub cmbEmpId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpId.SelectedIndexChanged
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select * from EmployeeDetails where empid = '" & cmbEmpId.Text & "'", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            txtEmpName.Text = rsEmployeeDetails.Fields("empname").Value
            txtAddress.Text = rsEmployeeDetails.Fields("address").Value
            txtage.Text = rsEmployeeDetails.Fields("age").Value
            dtpDOB.Value = rsEmployeeDetails.Fields("dob").Value
            txtsalary.Text = rsEmployeeDetails.Fields("salary").Value

        End If
        rsEmployeeDetails.Close()
        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select * from EmployeeDetails where empid = '" & cmbEmpId.Text & "'", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            rsEmployeeDetails.Fields("empname").Value = txtEmpName.Text
            rsEmployeeDetails.Fields("address").Value = txtAddress.Text
            rsEmployeeDetails.Fields("age").Value = txtage.Text
            rsEmployeeDetails.Fields("dob").Value = dtpDOB.Value
            rsEmployeeDetails.Fields("salary").Value = txtsalary.Text
            rsEmployeeDetails.Update()
            MsgBox("details updated successfully", MsgBoxStyle.Information)
            txtEmpName.Text = ""
            cmbEmpId.Text = ""
            txtAddress.Text = ""
            txtage.Text = ""
            dtpDOB.Value = Date.Now
            txtsalary.Text = ""
        End If
        rsEmployeeDetails.Close()
        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
    End Sub
End Class