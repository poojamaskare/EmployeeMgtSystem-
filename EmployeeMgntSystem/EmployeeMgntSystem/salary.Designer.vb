<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Salary))
        Panel1 = New Panel()
        cmdadd = New Button()
        cmdprint = New Button()
        cmdview = New Button()
        txtempposition = New TextBox()
        salarytb = New RichTextBox()
        cmdHOME = New Button()
        txtworkeddays = New TextBox()
        Label1 = New Label()
        Label5 = New Label()
        txtemployeename = New TextBox()
        Label3 = New Label()
        Cmbempid = New ComboBox()
        Label9 = New Label()
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
        Panel1.Controls.Add(cmdadd)
        Panel1.Controls.Add(cmdprint)
        Panel1.Controls.Add(cmdview)
        Panel1.Controls.Add(txtempposition)
        Panel1.Controls.Add(salarytb)
        Panel1.Controls.Add(cmdHOME)
        Panel1.Controls.Add(txtworkeddays)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtemployeename)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Cmbempid)
        Panel1.Controls.Add(Label9)
        Panel1.Location = New Point(-2, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(909, 386)
        Panel1.TabIndex = 0
        ' 
        ' cmdadd
        ' 
        cmdadd.BackColor = SystemColors.GradientActiveCaption
        cmdadd.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmdadd.Location = New Point(221, 267)
        cmdadd.Name = "cmdadd"
        cmdadd.Size = New Size(105, 42)
        cmdadd.TabIndex = 7
        cmdadd.Text = "ADD"
        cmdadd.UseVisualStyleBackColor = False
        ' 
        ' cmdprint
        ' 
        cmdprint.BackColor = SystemColors.GradientActiveCaption
        cmdprint.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmdprint.Location = New Point(540, 322)
        cmdprint.Name = "cmdprint"
        cmdprint.Size = New Size(111, 42)
        cmdprint.TabIndex = 8
        cmdprint.Text = "PRINT"
        cmdprint.UseVisualStyleBackColor = False
        ' 
        ' cmdview
        ' 
        cmdview.BackColor = SystemColors.GradientActiveCaption
        cmdview.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmdview.Location = New Point(117, 267)
        cmdview.Name = "cmdview"
        cmdview.Size = New Size(98, 42)
        cmdview.TabIndex = 6
        cmdview.Text = "VIEW"
        cmdview.UseVisualStyleBackColor = False
        ' 
        ' txtempposition
        ' 
        txtempposition.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtempposition.Location = New Point(14, 158)
        txtempposition.Name = "txtempposition"
        txtempposition.Size = New Size(232, 26)
        txtempposition.TabIndex = 3
        ' 
        ' salarytb
        ' 
        salarytb.BackColor = SystemColors.ScrollBar
        salarytb.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        salarytb.Location = New Point(369, 33)
        salarytb.Name = "salarytb"
        salarytb.Size = New Size(515, 266)
        salarytb.TabIndex = 104
        salarytb.Text = ""
        ' 
        ' cmdHOME
        ' 
        cmdHOME.BackColor = SystemColors.GradientActiveCaption
        cmdHOME.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmdHOME.Location = New Point(14, 267)
        cmdHOME.Name = "cmdHOME"
        cmdHOME.Size = New Size(97, 42)
        cmdHOME.TabIndex = 5
        cmdHOME.Text = "HOME"
        cmdHOME.UseVisualStyleBackColor = False
        ' 
        ' txtworkeddays
        ' 
        txtworkeddays.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtworkeddays.Location = New Point(14, 212)
        txtworkeddays.Name = "txtworkeddays"
        txtworkeddays.Size = New Size(232, 26)
        txtworkeddays.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 187)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 22)
        Label1.TabIndex = 100
        Label1.Text = "WORKED DAYS :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(14, 133)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 22)
        Label5.TabIndex = 98
        Label5.Text = "EMP POSOTION :"
        ' 
        ' txtemployeename
        ' 
        txtemployeename.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtemployeename.Location = New Point(14, 104)
        txtemployeename.Name = "txtemployeename"
        txtemployeename.Size = New Size(232, 26)
        txtemployeename.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(14, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 22)
        Label3.TabIndex = 96
        Label3.Text = "EMPLOYEE NAME :"
        ' 
        ' Cmbempid
        ' 
        Cmbempid.FormattingEnabled = True
        Cmbempid.Location = New Point(149, 29)
        Cmbempid.Name = "Cmbempid"
        Cmbempid.Size = New Size(97, 23)
        Cmbempid.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(14, 27)
        Label9.Name = "Label9"
        Label9.Size = New Size(129, 22)
        Label9.TabIndex = 93
        Label9.Text = "EMPLOYEE ID :"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(108, 60)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(115, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 31)
        Label2.TabIndex = 103
        Label2.Text = "SALARY"
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
        ' Salary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(909, 476)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Name = "Salary"
        Text = "salary"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Cmbempid As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtemployeename As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtworkeddays As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdHOME As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents salarytb As RichTextBox
    Friend WithEvents txtempposition As TextBox
    Friend WithEvents cmdview As Button
    Friend WithEvents cmdprint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents cmdadd As Button
End Class
