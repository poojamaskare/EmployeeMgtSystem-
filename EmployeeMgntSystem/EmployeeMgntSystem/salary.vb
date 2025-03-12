Imports System.ComponentModel.Design

Public Class Salary
    Public total As Double
    Public dailypay As Integer
    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        Cmbempid.Items.Clear()
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select empid from EmployeeDetails order by empid", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            rsEmployeeDetails.MoveFirst()
            Do Until rsEmployeeDetails.EOF
                Cmbempid.Items.Add(rsEmployeeDetails.Fields("empid").Value)
                rsEmployeeDetails.MoveNext()
            Loop
        End If
        rsEmployeeDetails.Close()
        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
    End Sub
    Private Sub Cmbempid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbempid.SelectedIndexChanged
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")
        salarytb.Clear()
        Dim rsEmployeeDetails As ADODB.Recordset
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select * from EmployeeDetails where Empid = '" & Cmbempid.Text & "'", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            txtemployeename.Text = rsEmployeeDetails.Fields("Name").Value
            txtempposition.Text = rsEmployeeDetails.Fields("Position").Value
        End If

        rsEmployeeDetails.Close()
        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
    End Sub

    Private Sub cmdview_Click(sender As Object, e As EventArgs) Handles cmdview.Click
        If Cmbempid.Text = "" Then
            MsgBox("Please Select an Empid")
        ElseIf txtworkeddays.Text = "" Or txtworkeddays.Text > 28 Then
            MsgBox("Entered invalid number of days", MsgBoxStyle.Information)
        Else
            If txtempposition.Text = "MANAGER" Then
                dailypay = 1200
            ElseIf txtempposition.Text = "DIRECTOR " Then
                dailypay = 2000
            ElseIf txtempposition.Text = "ACCOUNTANT" Then
                dailypay = 1300
            ElseIf txtempposition.Text = "IT" Then
                dailypay = 1300
            ElseIf txtempposition.Text = "CO" Then
                dailypay = 1300
            ElseIf txtempposition.Text = "SECURITY" Then
                dailypay = 700
            ElseIf txtempposition.Text = "CLEANER" Then
                dailypay = 500
            Else dailypay = 500
            End If
            total = dailypay * txtworkeddays.Text
            salarytb.Text = "Employee Id: " + Cmbempid.Text + vbCrLf + " Employee Name: " + txtemployeename.Text + vbCrLf + "Emplloyee Position: " + txtempposition.Text + vbCrLf + "Worked Days: " + txtworkeddays.Text + vbCrLf + "Daily Salary Rs: " + Convert.ToString(dailypay) + vbCrLf + "TOTAL SALARY: " + Convert.ToString(total)
        End If
    End Sub
    Private Sub cmdHOME_Click(sender As Object, e As EventArgs) Handles cmdHOME.Click
        Me.Hide()
        Homepage.Show()

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 30), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("*****PAYSLIP*****", New Font("Arial", 18), Brushes.Crimson, 330, 10)
        e.Graphics.DrawString(salarytb.Text, New Font("Century Gothic", 20), Brushes.Black, 150, 190)
    End Sub

    Private Sub cmdprint_Click(sender As Object, e As EventArgs) Handles cmdprint.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmpslary As ADODB.Recordset
        rsEmpslary = New ADODB.Recordset

        rsEmpslary = New ADODB.Recordset
        rsEmpslary.Open("Empsalary", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        rsEmpslary.AddNew()
        rsEmpslary.Fields("Empid").Value = Cmbempid.Text
        rsEmpslary.Fields("Empname").Value = txtemployeename.Text
        rsEmpslary.Fields("Empposition").Value = txtempposition.Text
        rsEmpslary.Fields("Workeddays").Value = txtworkeddays.Text
        rsEmpslary.Fields("Total").Value = total
        rsEmpslary.Fields("dailypay").Value = dailypay
        rsEmpslary.Fields("Date").Value = Date.Now
        rsEmpslary.Update()
        rsEmpslary.Close()
        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
        Cmbempid.Text = ""
        txtemployeename.Text = ""
        txtempposition.Text = ""
        txtworkeddays.Text = ""
        salarytb.Clear()
        MsgBox("Details Added Successfully", MsgBoxStyle.Information)
    End Sub
End Class



