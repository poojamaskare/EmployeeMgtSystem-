<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Panel1 = New Panel()
        Cmdadd = New Button()
        cmdupdate = New Button()
        cmddelete = New Button()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(Cmdadd)
        Panel1.Controls.Add(cmdupdate)
        Panel1.Controls.Add(cmddelete)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Location = New Point(-4, 90)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(811, 317)
        Panel1.TabIndex = 0
        ' 
        ' Cmdadd
        ' 
        Cmdadd.BackColor = SystemColors.GradientActiveCaption
        Cmdadd.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Cmdadd.Location = New Point(57, 240)
        Cmdadd.Name = "Cmdadd"
        Cmdadd.Size = New Size(118, 34)
        Cmdadd.TabIndex = 18
        Cmdadd.Text = "EMPLOYEE"
        Cmdadd.UseVisualStyleBackColor = False
        ' 
        ' cmdupdate
        ' 
        cmdupdate.BackColor = SystemColors.GradientActiveCaption
        cmdupdate.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmdupdate.Location = New Point(329, 240)
        cmdupdate.Name = "cmdupdate"
        cmdupdate.Size = New Size(91, 34)
        cmdupdate.TabIndex = 17
        cmdupdate.Text = "DETAILS"
        cmdupdate.UseVisualStyleBackColor = False
        ' 
        ' cmddelete
        ' 
        cmddelete.BackColor = SystemColors.GradientActiveCaption
        cmddelete.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmddelete.Location = New Point(572, 240)
        cmddelete.Name = "cmddelete"
        cmddelete.Size = New Size(91, 34)
        cmddelete.TabIndex = 15
        cmddelete.Text = "SALARY"
        cmddelete.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(532, 73)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(159, 126)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 14
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.ButtonHighlight
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(290, 73)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(159, 126)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 13
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonHighlight
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(29, 73)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(159, 126)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(260, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(374, 32)
        Label3.TabIndex = 19
        Label3.Text = "EMPLOYEE MANAGEMENT "
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 22)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(82, 62)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(100, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 18)
        Label2.TabIndex = 3
        Label2.Text = "HOME"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(663, 416)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 25)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(709, 423)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 18)
        Label1.TabIndex = 4
        Label1.Text = "LOGOUT"
        ' 
        ' Homepage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Name = "Homepage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Homepage"
        Panel1.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmdadd As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmddelete As Button
    Friend WithEvents Label3 As Label
End Class
