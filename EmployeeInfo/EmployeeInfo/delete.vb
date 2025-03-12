Public Class delete


    Private Sub delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("delete from EmployeeDetails where empid = '" & cmbEmpId.Text & "'", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        MsgBox("details deleted successfully", MsgBoxStyle.Information)
        cmbEmpId.Text = ""
        rsEmployeeDetails.Close()
        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
    End Sub
End Class