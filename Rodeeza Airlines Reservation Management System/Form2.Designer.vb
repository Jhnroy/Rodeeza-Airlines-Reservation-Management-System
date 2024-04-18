<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppoitmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppoitmentForm))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Birthday = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label8 = New Label()
        TextBox6 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        TextBox7 = New TextBox()
        ComboBox1 = New ComboBox()
        Label11 = New Label()
        Label12 = New Label()
        TextBox8 = New TextBox()
        ComboBox2 = New ComboBox()
        Label13 = New Label()
        TextBox9 = New TextBox()
        Label14 = New Label()
        TextBox10 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(457, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(578, 41)
        Label1.TabIndex = 0
        Label1.Text = "Rodeeza Airlines Appoitment System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(33, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(175, 155)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(50, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 24)
        Label2.TabIndex = 2
        Label2.Text = "Customer I.D:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(50, 301)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 24)
        Label3.TabIndex = 3
        Label3.Text = "First Name:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(1042, 211)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(489, 526)
        DataGridView1.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(187, 211)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 32)
        TextBox1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(50, 379)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 24)
        Label4.TabIndex = 6
        Label4.Text = "Last Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(50, 450)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 24)
        Label5.TabIndex = 7
        Label5.Text = "Birthday:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(187, 293)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(250, 32)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(187, 371)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(250, 32)
        TextBox3.TabIndex = 9
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(187, 442)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 32)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Birthday
        ' 
        Birthday.AutoSize = True
        Birthday.ForeColor = Color.White
        Birthday.Location = New Point(50, 516)
        Birthday.Name = "Birthday"
        Birthday.Size = New Size(88, 24)
        Birthday.TabIndex = 11
        Birthday.Text = "Address:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(50, 581)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 24)
        Label6.TabIndex = 12
        Label6.Text = "Email:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.White
        Label7.Location = New Point(50, 713)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 24)
        Label7.TabIndex = 13
        Label7.Text = "Gender:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(187, 508)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(250, 32)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(187, 573)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(250, 32)
        TextBox5.TabIndex = 15
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.ForeColor = Color.White
        RadioButton1.Location = New Point(187, 711)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 28)
        RadioButton1.TabIndex = 16
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.ForeColor = Color.White
        RadioButton2.Location = New Point(334, 709)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(98, 28)
        RadioButton2.TabIndex = 17
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(560, 219)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 24)
        Label8.TabIndex = 18
        Label8.Text = "Flight I.D:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(696, 211)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(151, 32)
        TextBox6.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(560, 306)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 24)
        Label9.TabIndex = 20
        Label9.Text = "Flight Class:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(560, 379)
        Label10.Name = "Label10"
        Label10.Size = New Size(66, 24)
        Label10.TabIndex = 21
        Label10.Text = "Seats:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(696, 371)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(151, 32)
        TextBox7.TabIndex = 22
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(696, 298)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 32)
        ComboBox1.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Location = New Point(560, 450)
        Label11.Name = "Label11"
        Label11.Size = New Size(117, 24)
        Label11.TabIndex = 24
        Label11.Text = "Destination:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Location = New Point(560, 516)
        Label12.Name = "Label12"
        Label12.Size = New Size(58, 24)
        Label12.TabIndex = 25
        Label12.Text = "Gate:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(696, 442)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(151, 32)
        TextBox8.TabIndex = 26
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(696, 508)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 32)
        ComboBox2.TabIndex = 27
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = Color.White
        Label13.Location = New Point(50, 653)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 24)
        Label13.TabIndex = 28
        Label13.Text = "Phone:"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(187, 645)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(250, 32)
        TextBox9.TabIndex = 29
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.ForeColor = Color.White
        Label14.Location = New Point(1042, 170)
        Label14.Name = "Label14"
        Label14.Size = New Size(164, 24)
        Label14.TabIndex = 30
        Label14.Text = "View All Records:"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(1224, 162)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(191, 32)
        TextBox10.TabIndex = 31
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1437, 164)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 30)
        Button1.TabIndex = 32
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1042, 753)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 33
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1244, 753)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 34
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(1437, 753)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 35
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(545, 753)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 36
        Button5.Text = "Submit"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' AppoitmentForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(117), CByte(186))
        ClientSize = New Size(1565, 806)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox10)
        Controls.Add(Label14)
        Controls.Add(TextBox9)
        Controls.Add(Label13)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox8)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox7)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(TextBox6)
        Controls.Add(Label8)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Birthday)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "AppoitmentForm"
        Text = "Appoitment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Birthday As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
