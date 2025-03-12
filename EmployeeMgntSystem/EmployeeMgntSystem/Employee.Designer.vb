<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewGroup1 As ListViewGroup = New ListViewGroup("AGE", HorizontalAlignment.Right)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Panel2 = New Panel()
        ListView1 = New ListView()
        EmpID = New ColumnHeader()
        EmpName = New ColumnHeader()
        AGE = New ColumnHeader()
        ADDRESS = New ColumnHeader()
        GENDER = New ColumnHeader()
        POSITION = New ColumnHeader()
        QUALIFICATION = New ColumnHeader()
        DOB = New ColumnHeader()
        cmbempposition = New ComboBox()
        cmbgender = New ComboBox()
        cmbqualification = New ComboBox()
        cmddelete = New Button()
        cmdupdate = New Button()
        dtpdob = New DateTimePicker()
        Label8 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        txtemployeeadd = New TextBox()
        txtemployeeage = New TextBox()
        cmdadd = New Button()
        cmdHOME = New Button()
        Label7 = New Label()
        txtemployeename = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        EMPLOYEENAME = New ColumnHeader()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(ListView1)
        Panel2.Controls.Add(cmbempposition)
        Panel2.Controls.Add(cmbgender)
        Panel2.Controls.Add(cmbqualification)
        Panel2.Controls.Add(cmddelete)
        Panel2.Controls.Add(cmdupdate)
        Panel2.Controls.Add(dtpdob)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtemployeeadd)
        Panel2.Controls.Add(txtemployeeage)
        Panel2.Controls.Add(cmdadd)
        Panel2.Controls.Add(cmdHOME)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txtemployeename)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Panel2.Location = New Point(-1, 87)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1023, 382)
        Panel2.TabIndex = 1
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = SystemColors.Menu
        ListView1.Columns.AddRange(New ColumnHeader() {EmpID, EmpName, AGE, ADDRESS, GENDER, POSITION, QUALIFICATION, DOB})
        ListView1.Font = New Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListViewGroup1.FooterAlignment = HorizontalAlignment.Right
        ListViewGroup1.Header = "AGE"
        ListViewGroup1.HeaderAlignment = HorizontalAlignment.Right
        ListViewGroup1.Name = "AGE"
        ListView1.Groups.AddRange(New ListViewGroup() {ListViewGroup1})
        ListView1.Location = New Point(375, 14)
        ListView1.MultiSelect = False
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(645, 335)
        ListView1.Sorting = SortOrder.Ascending
        ListView1.TabIndex = 75
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' EmpID
        ' 
        EmpID.Text = "EmpId"
        ' 
        ' EmpName
        ' 
        EmpName.Text = "EmpName"
        EmpName.Width = 100
        ' 
        ' AGE
        ' 
        AGE.Text = "AGE"
        AGE.Width = 50
        ' 
        ' ADDRESS
        ' 
        ADDRESS.Text = "ADDRESS"
        ADDRESS.Width = 90
        ' 
        ' GENDER
        ' 
        GENDER.Text = "GENDER"
        GENDER.Width = 100
        ' 
        ' POSITION
        ' 
        POSITION.Text = "POSITION"
        POSITION.Width = 100
        ' 
        ' QUALIFICATION
        ' 
        QUALIFICATION.Text = "QUALIFICATION"
        QUALIFICATION.Width = 100
        ' 
        ' DOB
        ' 
        DOB.Text = "DOB"
        DOB.Width = 100
        ' 
        ' cmbempposition
        ' 
        cmbempposition.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cmbempposition.FormattingEnabled = True
        cmbempposition.Items.AddRange(New Object() {"MANAGER", "DIRECTOR", "ACCOUNTANT", "IT", "CO", "SECURITY", "CLEANER"})
        cmbempposition.Location = New Point(14, 199)
        cmbempposition.Name = "cmbempposition"
        cmbempposition.Size = New Size(172, 30)
        cmbempposition.TabIndex = 5
        ' 
        ' cmbgender
        ' 
        cmbgender.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cmbgender.FormattingEnabled = True
        cmbgender.Items.AddRange(New Object() {"FEMALE ", "MALE", "OTHER"})
        cmbgender.Location = New Point(196, 141)
        cmbgender.Name = "cmbgender"
        cmbgender.Size = New Size(173, 30)
        cmbgender.TabIndex = 4
        ' 
        ' cmbqualification
        ' 
        cmbqualification.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cmbqualification.FormattingEnabled = True
        cmbqualification.Items.AddRange(New Object() {"DIPLOMA ", "GRADUATE", "UG", "PG"})
        cmbqualification.Location = New Point(196, 199)
        cmbqualification.Name = "cmbqualification"
        cmbqualification.Size = New Size(173, 30)
        cmbqualification.TabIndex = 6
        ' 
        ' cmddelete
        ' 
        cmddelete.BackColor = SystemColors.GradientActiveCaption
        cmddelete.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmddelete.Location = New Point(267, 299)
        cmddelete.Name = "cmddelete"
        cmddelete.Size = New Size(94, 29)
        cmddelete.TabIndex = 10
        cmddelete.Text = "DELETE"
        cmddelete.UseVisualStyleBackColor = False
        ' 
        ' cmdupdate
        ' 
        cmdupdate.BackColor = SystemColors.GradientActiveCaption
        cmdupdate.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmdupdate.Location = New Point(143, 299)
        cmdupdate.Name = "cmdupdate"
        cmdupdate.Size = New Size(94, 29)
        cmdupdate.TabIndex = 9
        cmdupdate.Text = "UPDATE"
        cmdupdate.UseVisualStyleBackColor = False
        ' 
        ' dtpdob
        ' 
        dtpdob.Location = New Point(173, 244)
        dtpdob.Name = "dtpdob"
        dtpdob.Size = New Size(196, 29)
        dtpdob.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(196, 174)
        Label8.Name = "Label8"
        Label8.Size = New Size(150, 22)
        Label8.TabIndex = 66
        Label8.Text = "QUALIFICATION :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(13, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 22)
        Label5.TabIndex = 64
        Label5.Text = "EMP POSOTION :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(14, 249)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 22)
        Label6.TabIndex = 54
        Label6.Text = "EMPLOYEE DOB :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(196, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 22)
        Label1.TabIndex = 62
        Label1.Text = "GENDER:"
        ' 
        ' txtemployeeadd
        ' 
        txtemployeeadd.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtemployeeadd.Location = New Point(13, 139)
        txtemployeeadd.Name = "txtemployeeadd"
        txtemployeeadd.Size = New Size(173, 26)
        txtemployeeadd.TabIndex = 3
        ' 
        ' txtemployeeage
        ' 
        txtemployeeage.Enabled = False
        txtemployeeage.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtemployeeage.Location = New Point(196, 75)
        txtemployeeage.Name = "txtemployeeage"
        txtemployeeage.Size = New Size(173, 26)
        txtemployeeage.TabIndex = 2
        ' 
        ' cmdadd
        ' 
        cmdadd.BackColor = SystemColors.GradientActiveCaption
        cmdadd.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmdadd.Location = New Point(14, 299)
        cmdadd.Name = "cmdadd"
        cmdadd.Size = New Size(94, 29)
        cmdadd.TabIndex = 8
        cmdadd.Text = "ADD"
        cmdadd.UseVisualStyleBackColor = False
        ' 
        ' cmdHOME
        ' 
        cmdHOME.BackColor = SystemColors.GradientActiveCaption
        cmdHOME.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmdHOME.Location = New Point(157, 334)
        cmdHOME.Name = "cmdHOME"
        cmdHOME.Size = New Size(110, 34)
        cmdHOME.TabIndex = 11
        cmdHOME.Text = "HOME"
        cmdHOME.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(13, 114)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 22)
        Label7.TabIndex = 56
        Label7.Text = "EMPLOYEE ADD :"
        ' 
        ' txtemployeename
        ' 
        txtemployeename.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtemployeename.Location = New Point(13, 75)
        txtemployeename.Name = "txtemployeename"
        txtemployeename.Size = New Size(173, 26)
        txtemployeename.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(196, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 22)
        Label4.TabIndex = 49
        Label4.Text = "EMPLOYEE AGE :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(13, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 22)
        Label3.TabIndex = 48
        Label3.Text = "EMPLOYEE NAME :"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ButtonHighlight
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 19)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(110, 62)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(128, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(232, 28)
        Label2.TabIndex = 14
        Label2.Text = "MANAGE EMPLOYEE"
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1023, 524)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Name = "Employee"
        Text = "Employee"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtemployeeadd As TextBox
    Friend WithEvents txtemployeeage As TextBox
    Friend WithEvents cmdadd As Button
    Friend WithEvents cmdHOME As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtemployeename As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmddelete As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents dtpdob As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbqualification As ComboBox
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents cmbempposition As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents EmpID As ColumnHeader
    Friend WithEvents EMPLOYEENAME As ColumnHeader
    Friend WithEvents AGE As ColumnHeader
    Friend WithEvents ADDRESS As ColumnHeader
    Friend WithEvents GENDER As ColumnHeader
    Friend WithEvents POSITION As ColumnHeader
    Friend WithEvents QUALIFICATION As ColumnHeader
    Friend WithEvents DOB As ColumnHeader
    Friend WithEvents EmpName As ColumnHeader
End Class
