<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Panel1 = New Panel()
        Cmdlogin = New Button()
        txtpassword = New TextBox()
        Label3 = New Label()
        txtusername = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(Cmdlogin)
        Panel1.Controls.Add(txtpassword)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtusername)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(-4, 106)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(731, 320)
        Panel1.TabIndex = 0
        ' 
        ' Cmdlogin
        ' 
        Cmdlogin.BackColor = SystemColors.GradientActiveCaption
        Cmdlogin.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Cmdlogin.Location = New Point(244, 184)
        Cmdlogin.Name = "Cmdlogin"
        Cmdlogin.Size = New Size(107, 39)
        Cmdlogin.TabIndex = 46
        Cmdlogin.Text = "LOGIN"
        Cmdlogin.UseVisualStyleBackColor = False
        ' 
        ' txtpassword
        ' 
        txtpassword.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtpassword.Location = New Point(216, 126)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.Size = New Size(197, 26)
        txtpassword.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(170, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 22)
        Label3.TabIndex = 40
        Label3.Text = "PASSWORD :"
        ' 
        ' txtusername
        ' 
        txtusername.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtusername.Location = New Point(216, 65)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(197, 26)
        txtusername.TabIndex = 39
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(170, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 22)
        Label1.TabIndex = 15
        Label1.Text = "USERNAME :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(87, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(87, 107)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(77, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(83, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(390, 28)
        Label2.TabIndex = 14
        Label2.Text = "EMPLOYEE MANAGEMENT SYSTEM"
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(739, 438)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "LOGIN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Cmdlogin As Button
End Class
