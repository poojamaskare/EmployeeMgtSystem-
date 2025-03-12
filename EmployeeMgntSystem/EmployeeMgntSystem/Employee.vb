Imports System.Diagnostics.Eventing.Reader
Imports ADODB

Public Class Employee
    Private rsEmployeeDetails As Recordset
    Private dbEmployeeInfo As Object

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        Dim sEmpId As Integer
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select TOP(1) EmpId from EmployeeDetails order by EmpId DESC", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            sEmpId = rsEmployeeDetails.Fields(0).Value + 1
        Else
            sEmpId = 1
        End If
        rsEmployeeDetails.Close()
        If txtemployeename.Text = "" Then
            MsgBox("Please Enter Employee Name", MsgBoxStyle.Information)
        Else
            If txtemployeeadd.Text = "" Then
                MsgBox(" Please Enter Employee Address ", MsgBoxStyle.Information)
            Else
                If cmbempposition.Text = "" Then
                    MsgBox("Please Enter Employee Position ", MsgBoxStyle.Information)
                Else
                    If cmbqualification.Text = "" Then
                        MsgBox("Please Enter Employee Qualification", MsgBoxStyle.Information)
                    Else
                        If cmbgender.Text = "" Then
                            MsgBox("", MsgBoxStyle.Information)
                        Else
                            rsEmployeeDetails = New ADODB.Recordset
                            rsEmployeeDetails.Open("EmployeeDetails", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
                            rsEmployeeDetails.AddNew()
                            rsEmployeeDetails.Fields("Empid").Value = sEmpId
                            rsEmployeeDetails.Fields("Name").Value = txtemployeename.Text
                            rsEmployeeDetails.Fields("Age").Value = dtpdob.Value
                            rsEmployeeDetails.Fields("Address").Value = txtemployeeadd.Text
                            rsEmployeeDetails.Fields("Gender").Value = cmbgender.Text
                            rsEmployeeDetails.Fields("Position").Value = cmbempposition.Text
                            rsEmployeeDetails.Fields("Qualification").Value = cmbqualification.Text
                            rsEmployeeDetails.Fields("DOB").Value = dtpdob.Value
                            rsEmployeeDetails.Update()
                            rsEmployeeDetails.Close()

                            ListView1.Items.Clear()
                            Dim lv As New ListViewItem
                            rsEmployeeDetails = New ADODB.Recordset
                            rsEmployeeDetails.Open("Select * from EmployeeDetails order by EmpId", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
                            If rsEmployeeDetails.RecordCount > 0 Then
                                rsEmployeeDetails.MoveFirst()
                                Do Until rsEmployeeDetails.EOF
                                    lv = ListView1.Items.Add(rsEmployeeDetails.Fields("EmpId").Value)
                                    lv.SubItems.Add(rsEmployeeDetails.Fields("Name").Value)
                                    lv.SubItems.Add(rsEmployeeDetails.Fields("Age").Value)
                                    lv.SubItems.Add(rsEmployeeDetails.Fields("Address").Value)
                                    lv.SubItems.Add(rsEmployeeDetails.Fields("Gender").Value)
                                    lv.SubItems.Add(rsEmployeeDetails.Fields("Position").Value)
                                    lv.SubItems.Add(rsEmployeeDetails.Fields("Qualification").Value)
                                    lv.SubItems.Add(rsEmployeeDetails.Fields("DOB").Value)
                                    rsEmployeeDetails.MoveNext()
                                Loop
                            End If
                            rsEmployeeDetails.Close()
                            dbEmployeeInfo.Close()
                            dbEmployeeInfo = Nothing
                            txtemployeename.Text = " "
                            txtemployeeage.Text = " "
                            txtemployeeadd.Text = " "
                            cmbgender.Text = ""
                            cmbempposition.Text = ""
                            cmbqualification.Text = ""
                            dtpdob.Value = Date.Now
                            MsgBox("Details Added Successfully", MsgBoxStyle.Information)
                        End If
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdadd.Enabled = True
        cmdupdate.Enabled = False
        cmddelete.Enabled = False

        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")
        Dim rsEmployeeDetails As ADODB.Recordset
        Dim lv As New ListViewItem
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select * from EmployeeDetails order by EmpId", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            rsEmployeeDetails.MoveFirst()
            Do Until rsEmployeeDetails.EOF
                lv = ListView1.Items.Add(rsEmployeeDetails.Fields("EmpId").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Name").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Age").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Address").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Gender").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Position").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Qualification").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("DOB").Value)
                rsEmployeeDetails.MoveNext()
            Loop
        End If
        rsEmployeeDetails.Close()
        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
        txtemployeename.Text = " "
        txtemployeeage.Text = " "
        txtemployeeadd.Text = " "
        cmbgender.Text = ""
        cmbempposition.Text = ""
        cmbqualification.Text = ""
        dtpdob.Value = Date.Now
    End Sub
    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        cmdadd.Enabled = False
        cmdupdate.Enabled = True
        cmddelete.Enabled = True

        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")
        Dim rsEmployeeDetails As ADODB.Recordset
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select * from EmployeeDetails where EmpId = '" & ListView1.SelectedItems(0).Text & "' order by EmpId", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            txtemployeename.Text = rsEmployeeDetails.Fields("Name").Value
            txtemployeeage.Text = rsEmployeeDetails.Fields("Age").Value
            txtemployeeadd.Text = rsEmployeeDetails.Fields("Address").Value
            cmbgender.Text = rsEmployeeDetails.Fields("Gender").Value
            cmbempposition.Text = rsEmployeeDetails.Fields("Position").Value
            cmbqualification.Text = rsEmployeeDetails.Fields("Qualification").Value
            dtpdob.Value = rsEmployeeDetails.Fields("DOB").Value
        End If
    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select * from EmployeeDetails where EmpId = '" & ListView1.SelectedItems(0).Text & "' order by EmpId", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            rsEmployeeDetails.Fields("Name").Value = txtemployeename.Text
            rsEmployeeDetails.Fields("Age").Value = txtemployeeage.Text
            rsEmployeeDetails.Fields("Address").Value = txtemployeeadd.Text
            rsEmployeeDetails.Fields("Gender").Value = cmbgender.Text
            rsEmployeeDetails.Fields("Position").Value = cmbempposition.Text
            rsEmployeeDetails.Fields("Qualification").Value = cmbqualification.Text
            rsEmployeeDetails.Fields("Dob").Value = dtpdob.Value
            rsEmployeeDetails.Update()
        End If


        ListView1.Items.Clear()
        Dim lv As New ListViewItem
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select * from EmployeeDetails order by EmpId", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            rsEmployeeDetails.MoveFirst()
            Do Until rsEmployeeDetails.EOF
                lv = ListView1.Items.Add(rsEmployeeDetails.Fields("EmpId").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Name").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Age").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Address").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Gender").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Position").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Qualification").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("DOB").Value)
                rsEmployeeDetails.MoveNext()
            Loop
        End If
        rsEmployeeDetails.Close()

        MsgBox("details updated successfully", MsgBoxStyle.Information)
        txtemployeename.Text = " "
        txtemployeeage.Text = " "
        txtemployeeadd.Text = " "
        cmbgender.Text = ""
        cmbempposition.Text = ""
        cmbqualification.Text = ""
        dtpdob.Value = Date.Now


        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        Dim dbEmployeeInfo As ADODB.Connection
        dbEmployeeInfo = New ADODB.Connection
        dbEmployeeInfo.Open("EmployeeInfo", "sa", "citect@123")

        Dim rsEmployeeDetails As ADODB.Recordset
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("delete from EmployeeDetails where Empid = '" & ListView1.SelectedItems(0).Text & "' ", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        ListView1.Items.Clear()
        Dim lv As New ListViewItem
        rsEmployeeDetails = New ADODB.Recordset
        rsEmployeeDetails.Open("Select * from EmployeeDetails order by EmpId", dbEmployeeInfo, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsEmployeeDetails.RecordCount > 0 Then
            rsEmployeeDetails.MoveFirst()
            Do Until rsEmployeeDetails.EOF
                lv = ListView1.Items.Add(rsEmployeeDetails.Fields("EmpId").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Name").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Age").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Address").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Gender").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Position").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("Qualification").Value)
                lv.SubItems.Add(rsEmployeeDetails.Fields("DOB").Value)
                rsEmployeeDetails.MoveNext()
            Loop
        End If
        rsEmployeeDetails.Close()
        MsgBox("details deleted successfully", MsgBoxStyle.Information)
        txtemployeename.Text = " "
        txtemployeeage.Text = " "
        txtemployeeadd.Text = " "
        cmbgender.Text = ""
        cmbempposition.Text = ""
        cmbqualification.Text = ""
        dtpdob.Value = Date.Now


        dbEmployeeInfo.Close()
        dbEmployeeInfo = Nothing
    End Sub

    Private Sub cmdHOME_Click(sender As Object, e As EventArgs) Handles cmdHOME.Click
        Me.Hide()
        Homepage.Show()

    End Sub

    Private Sub dtpdob_ValueChanged(sender As Object, e As EventArgs) Handles dtpdob.ValueChanged

        Dim age As Integer = Today.Year - dtpdob.Value.Year

        If (dtpdob.Value > Today.AddYears(-age)) Then age -= 1
        txtemployeeage.Text = age

    End Sub


End Class
