<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class details
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(details))
        Panel1 = New Panel()
        cmdprint = New Button()
        txtdob = New TextBox()
        Label9 = New Label()
        txtqualification = New TextBox()
        cmbempid = New ComboBox()
        txtempposition = New TextBox()
        txtemployeeage = New TextBox()
        Label8 = New Label()
        txtemployeeadd = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtgender = New TextBox()
        Label1 = New Label()
        Label7 = New Label()
        txtemployeename = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        cmdhome = New Button()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(cmdprint)
        Panel1.Controls.Add(txtdob)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtqualification)
        Panel1.Controls.Add(cmbempid)
        Panel1.Controls.Add(txtempposition)
        Panel1.Controls.Add(txtemployeeage)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtemployeeadd)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtgender)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtemployeename)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cmdhome)
        Panel1.Location = New Point(-4, 84)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(897, 320)
        Panel1.TabIndex = 0
        ' 
        ' cmdprint
        ' 
        cmdprint.BackColor = SystemColors.GradientActiveCaption
        cmdprint.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmdprint.Location = New Point(512, 260)
        cmdprint.Name = "cmdprint"
        cmdprint.Size = New Size(125, 47)
        cmdprint.TabIndex = 94
        cmdprint.Text = "PRINT"
        cmdprint.UseVisualStyleBackColor = False
        ' 
        ' txtdob
        ' 
        txtdob.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtdob.Location = New Point(371, 207)
        txtdob.Name = "txtdob"
        txtdob.Size = New Size(173, 26)
        txtdob.TabIndex = 93
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(258, 17)
        Label9.Name = "Label9"
        Label9.Size = New Size(129, 22)
        Label9.TabIndex = 92
        Label9.Text = "EMPLOYEE ID :"
        ' 
        ' txtqualification
        ' 
        txtqualification.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtqualification.Location = New Point(585, 150)
        txtqualification.Name = "txtqualification"
        txtqualification.Size = New Size(173, 26)
        txtqualification.TabIndex = 91
        ' 
        ' cmbempid
        ' 
        cmbempid.FormattingEnabled = True
        cmbempid.Location = New Point(435, 19)
        cmbempid.Name = "cmbempid"
        cmbempid.Size = New Size(173, 23)
        cmbempid.TabIndex = 90
        ' 
        ' txtempposition
        ' 
        txtempposition.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtempposition.Location = New Point(193, 154)
        txtempposition.Name = "txtempposition"
        txtempposition.Size = New Size(173, 26)
        txtempposition.TabIndex = 81
        ' 
        ' txtemployeeage
        ' 
        txtemployeeage.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtemployeeage.Location = New Point(585, 68)
        txtemployeeage.Name = "txtemployeeage"
        txtemployeeage.Size = New Size(173, 26)
        txtemployeeage.TabIndex = 80
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(435, 154)
        Label8.Name = "Label8"
        Label8.Size = New Size(150, 22)
        Label8.TabIndex = 86
        Label8.Text = "QUALIFICATION :"
        ' 
        ' txtemployeeadd
        ' 
        txtemployeeadd.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtemployeeadd.Location = New Point(192, 110)
        txtemployeeadd.Name = "txtemployeeadd"
        txtemployeeadd.Size = New Size(173, 26)
        txtemployeeadd.TabIndex = 85
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(24, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 22)
        Label5.TabIndex = 84
        Label5.Text = "EMP POSOTION :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(217, 208)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 22)
        Label6.TabIndex = 76
        Label6.Text = "EMPLOYEE DOB :"
        ' 
        ' txtgender
        ' 
        txtgender.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtgender.Location = New Point(585, 109)
        txtgender.Name = "txtgender"
        txtgender.Size = New Size(173, 26)
        txtgender.TabIndex = 83
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(432, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 22)
        Label1.TabIndex = 82
        Label1.Text = "GENDER:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(24, 110)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 22)
        Label7.TabIndex = 77
        Label7.Text = "EMPLOYEE ADD :"
        ' 
        ' txtemployeename
        ' 
        txtemployeename.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtemployeename.Location = New Point(192, 68)
        txtemployeename.Name = "txtemployeename"
        txtemployeename.Size = New Size(173, 26)
        txtemployeename.TabIndex = 75
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(432, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 22)
        Label4.TabIndex = 74
        Label4.Text = "EMPLOYEE AGE :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(24, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 22)
        Label3.TabIndex = 73
        Label3.Text = "EMPLOYEE NAME :"
        ' 
        ' cmdhome
        ' 
        cmdhome.BackColor = SystemColors.GradientActiveCaption
        cmdhome.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmdhome.Location = New Point(340, 260)
        cmdhome.Name = "cmdhome"
        cmdhome.Size = New Size(125, 47)
        cmdhome.TabIndex = 44
        cmdhome.Text = "HOME"
        cmdhome.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(20, 16)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(97, 62)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(148, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(221, 28)
        Label2.TabIndex = 13
        Label2.Text = "EMPLOYEE DETAILS"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' details
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(895, 416)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Name = "details"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UPDATE EMPLOYEE"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdhome As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbempid As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtemployeeadd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtgender As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtempposition As TextBox
    Friend WithEvents txtemployeeage As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtemployeename As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtqualification As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbfetch As Button
    Friend WithEvents txtdob As TextBox
    Friend WithEvents cmdprint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
