<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        UsernameLabel = New TextBox()
        PasswordLabel = New TextBox()
        LoginBtn = New Button()
        ResetBtn = New Button()
        ExitBtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(249, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 38)
        Label1.TabIndex = 0
        Label1.Text = "Log in"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.bwink_bld_03_single_03
        PictureBox1.Location = New Point(45, 103)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(144, 113)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(249, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 19)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(249, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 19)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(357, 95)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(150, 27)
        UsernameLabel.TabIndex = 4
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(357, 164)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.PasswordChar = "*"c
        PasswordLabel.Size = New Size(150, 27)
        PasswordLabel.TabIndex = 5
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.FromArgb(CByte(17), CByte(149), CByte(132))
        LoginBtn.Font = New Font("Roboto", 9.75F, FontStyle.Bold)
        LoginBtn.ForeColor = Color.White
        LoginBtn.Location = New Point(114, 307)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(70, 32)
        LoginBtn.TabIndex = 6
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.FromArgb(CByte(17), CByte(149), CByte(132))
        ResetBtn.Font = New Font("Roboto", 9.75F, FontStyle.Bold)
        ResetBtn.ForeColor = Color.White
        ResetBtn.Location = New Point(278, 307)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(70, 32)
        ResetBtn.TabIndex = 7
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' ExitBtn
        ' 
        ExitBtn.BackColor = Color.FromArgb(CByte(17), CByte(149), CByte(132))
        ExitBtn.Font = New Font("Roboto", 9.75F, FontStyle.Bold)
        ExitBtn.ForeColor = Color.White
        ExitBtn.Location = New Point(432, 307)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(70, 32)
        ExitBtn.TabIndex = 8
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(117), CByte(186))
        ClientSize = New Size(575, 381)
        Controls.Add(ExitBtn)
        Controls.Add(ResetBtn)
        Controls.Add(LoginBtn)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Font = New Font("Roboto", 12F)
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UsernameLabel As TextBox
    Friend WithEvents PasswordLabel As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents ExitBtn As Button

End Class
