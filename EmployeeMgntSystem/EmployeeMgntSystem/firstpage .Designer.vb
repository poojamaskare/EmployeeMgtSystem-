<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Firstpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Firstpage))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        cmdenter = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(27, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(458, 28)
        Label1.TabIndex = 0
        Label1.Text = "EMPLOYEE MANAGEMENT SYSTEM "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(147, 63)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(201, 177)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' cmdenter
        ' 
        cmdenter.BackColor = SystemColors.GradientActiveCaption
        cmdenter.Font = New Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmdenter.Location = New Point(187, 259)
        cmdenter.Name = "cmdenter"
        cmdenter.Size = New Size(91, 34)
        cmdenter.TabIndex = 2
        cmdenter.Text = "ENTER"
        cmdenter.UseVisualStyleBackColor = False
        ' 
        ' Firstpage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(517, 301)
        Controls.Add(cmdenter)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Firstpage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "first page "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdenter As Button
End Class
