Imports System.CodeDom

Public Class EmpDetails
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        Dim rsEmployeeDetails1 As ADODB.Recordset

        rsEmployeeDetails1 = New ADODB.Recordset
        rsEmployeeDetails1.Open("Select empid from EmployeeDetails where empid = '" & txtempid.Text & "'", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails1.RecordCount > 0 Then
            MsgBox("Employee Id Already Exists", MsgBoxStyle.Information)
        Else
            rsEmployeeDetails = New ADODB.Recordset
            rsEmployeeDetails.Open("EmployeeDetails", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
            rsEmployeeDetails.AddNew()
            rsEmployeeDetails.Fields("empname").Value = txtEmpName.Text
            rsEmployeeDetails.Fields("empid").Value = txtempid.Text
            rsEmployeeDetails.Fields("address").Value = txtAddress.Text
            rsEmployeeDetails.Fields("age").Value = txtage.Text
            rsEmployeeDetails.Fields("dob").Value = dtpDOB.Value
            rsEmployeeDetails.Fields("salary").Value = txtsalary.Text
            rsEmployeeDetails.Update()
            MsgBox("details added successfully", MsgBoxStyle.Information)
            txtEmpName.Text = ""
            txtempid.Text = ""
            txtAddress.Text = ""
            txtage.Text = ""
            dtpDOB.Value = Date.Now
            txtsalary.Text = ""
            rsEmployeeDetails.Close()
            dbEmployeeInfo.Close()
            dbEmployeeInfo = Nothing
        End If
    End Sub
    Private Sub txtempid_LostFocus(sender As Object, e As EventArgs) Handles txtempid.LostFocus
        If IsNumeric(txtempid.Text) = False Then
            txtempid.Text = ""
            txtempid.Focus()
            MsgBox("Please Enter Numeric Value", MsgBoxStyle.Information)
        Else
        End If
    End Sub
    Private Sub txtage_LostFocus(sender As Object, e As EventArgs) Handles txtage.LostFocus
        If IsNumeric(txtage.Text) = False Then
            txtage.Text = ""
            txtage.Focus()
            MsgBox("Please Enter Numeric Value", MsgBoxStyle.Information)
        Else
        End If
    End Sub


End Class

