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
        allRecordsData = New DataGridView()
        CustomerIDTextBox = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        CustomerFirstNameTextBox = New TextBox()
        CustomerLastNameTextBox = New TextBox()
        dtbirthday = New DateTimePicker()
        Birthday = New Label()
        Label6 = New Label()
        CustomerGenderLabel = New Label()
        CustomerAddressTextBox = New TextBox()
        CustomerEmailTextBox = New TextBox()
        btnMale = New RadioButton()
        btFemale = New RadioButton()
        Label8 = New Label()
        TextBox6 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        ComboBox1 = New ComboBox()
        Label11 = New Label()
        Label12 = New Label()
        ComboBox2 = New ComboBox()
        Label13 = New Label()
        CustomerPhoneTextBox = New TextBox()
        Label14 = New Label()
        TextBox10 = New TextBox()
        Button1 = New Button()
        EditBtn = New Button()
        PrintBtn = New Button()
        DeleteBtn = New Button()
        Button5 = New Button()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        Customer_ID = New DataGridViewTextBoxColumn()
        CustomerFirstName = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        CustomerBirthday = New DataGridViewTextBoxColumn()
        Address = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        phoneNo = New DataGridViewTextBoxColumn()
        gender = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(allRecordsData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(457, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(597, 41)
        Label1.TabIndex = 0
        Label1.Text = "Rodeeza Airlines Appointment System"
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
        ' allRecordsData
        ' 
        allRecordsData.AllowUserToOrderColumns = True
        allRecordsData.BackgroundColor = Color.White
        allRecordsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        allRecordsData.Columns.AddRange(New DataGridViewColumn() {Customer_ID, CustomerFirstName, Column1, CustomerBirthday, Address, email, phoneNo, gender})
        allRecordsData.Location = New Point(931, 206)
        allRecordsData.Name = "allRecordsData"
        allRecordsData.RowHeadersWidth = 51
        allRecordsData.Size = New Size(600, 526)
        allRecordsData.TabIndex = 4
        ' 
        ' CustomerIDTextBox
        ' 
        CustomerIDTextBox.Location = New Point(187, 211)
        CustomerIDTextBox.Name = "CustomerIDTextBox"
        CustomerIDTextBox.Size = New Size(250, 32)
        CustomerIDTextBox.TabIndex = 5
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
        ' CustomerFirstNameTextBox
        ' 
        CustomerFirstNameTextBox.Location = New Point(187, 293)
        CustomerFirstNameTextBox.Name = "CustomerFirstNameTextBox"
        CustomerFirstNameTextBox.Size = New Size(250, 32)
        CustomerFirstNameTextBox.TabIndex = 8
        ' 
        ' CustomerLastNameTextBox
        ' 
        CustomerLastNameTextBox.Location = New Point(187, 371)
        CustomerLastNameTextBox.Name = "CustomerLastNameTextBox"
        CustomerLastNameTextBox.Size = New Size(250, 32)
        CustomerLastNameTextBox.TabIndex = 9
        ' 
        ' dtbirthday
        ' 
        dtbirthday.Location = New Point(187, 442)
        dtbirthday.Name = "dtbirthday"
        dtbirthday.Size = New Size(250, 32)
        dtbirthday.TabIndex = 10
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
        ' CustomerGenderLabel
        ' 
        CustomerGenderLabel.AutoSize = True
        CustomerGenderLabel.ForeColor = Color.White
        CustomerGenderLabel.Location = New Point(50, 713)
        CustomerGenderLabel.Name = "CustomerGenderLabel"
        CustomerGenderLabel.Size = New Size(80, 24)
        CustomerGenderLabel.TabIndex = 13
        CustomerGenderLabel.Text = "Gender:"
        ' 
        ' CustomerAddressTextBox
        ' 
        CustomerAddressTextBox.Location = New Point(187, 508)
        CustomerAddressTextBox.Name = "CustomerAddressTextBox"
        CustomerAddressTextBox.Size = New Size(250, 32)
        CustomerAddressTextBox.TabIndex = 14
        ' 
        ' CustomerEmailTextBox
        ' 
        CustomerEmailTextBox.Location = New Point(187, 573)
        CustomerEmailTextBox.Name = "CustomerEmailTextBox"
        CustomerEmailTextBox.Size = New Size(250, 32)
        CustomerEmailTextBox.TabIndex = 15
        ' 
        ' btnMale
        ' 
        btnMale.AutoSize = True
        btnMale.ForeColor = Color.White
        btnMale.Location = New Point(187, 711)
        btnMale.Name = "btnMale"
        btnMale.Size = New Size(75, 28)
        btnMale.TabIndex = 16
        btnMale.TabStop = True
        btnMale.Text = "Male"
        btnMale.UseVisualStyleBackColor = True
        ' 
        ' btFemale
        ' 
        btFemale.AutoSize = True
        btFemale.ForeColor = Color.White
        btFemale.Location = New Point(334, 709)
        btFemale.Name = "btFemale"
        btFemale.Size = New Size(98, 28)
        btFemale.TabIndex = 17
        btFemale.TabStop = True
        btFemale.Text = "Female"
        btFemale.UseVisualStyleBackColor = True
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
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"    Economy Class", "    Premium Economy Class", "    Business Class", "    First Class", "    Basic Economy Class", "    Flexible Economy Class", "    Economy Plus Class", "    Premium Business Class", "    Business Suite Class", "    Premium First Class"})
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
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Gate 1", "Gate 2", "Gate 3", "Gate 4", "Gate 5"})
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
        ' CustomerPhoneTextBox
        ' 
        CustomerPhoneTextBox.Location = New Point(187, 645)
        CustomerPhoneTextBox.Name = "CustomerPhoneTextBox"
        CustomerPhoneTextBox.Size = New Size(250, 32)
        CustomerPhoneTextBox.TabIndex = 29
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.ForeColor = Color.White
        Label14.Location = New Point(931, 170)
        Label14.Name = "Label14"
        Label14.Size = New Size(164, 24)
        Label14.TabIndex = 30
        Label14.Text = "View All Records:"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(1147, 167)
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
        ' EditBtn
        ' 
        EditBtn.Location = New Point(931, 753)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(94, 29)
        EditBtn.TabIndex = 33
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = True
        ' 
        ' PrintBtn
        ' 
        PrintBtn.Location = New Point(1177, 753)
        PrintBtn.Name = "PrintBtn"
        PrintBtn.Size = New Size(94, 29)
        PrintBtn.TabIndex = 34
        PrintBtn.Text = "Print"
        PrintBtn.UseVisualStyleBackColor = True
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.Location = New Point(1437, 753)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(94, 29)
        DeleteBtn.TabIndex = 35
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = True
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
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"    23A", "    7C", "    14F", "    31D", "    8B", "    17E", "    29G", "    5A", "    12D", "    30F", "    9C", "    20B", "    3E", "    18H", "    11A", "    25C", "    6F", "    21G", "    10D", "    26B", "    2E", "    15H", "    28A", "    1C", "    16G", "    22D", "    4B", "    19F", "    27A", "    13C", "    24E", "    32H", "    33D", "    34B", "    35F", "    36A", "    37C", "    38E", "    39G", "    40B", "    41D", "    42F", "    43A", "    44C", "    45E", "    46G", "    47B", "    48D", "    49F", "    50A", "    51C", "    52E", "    53G", "    54B", "    55D", "    56F", "    57A", "    58C", "    59E", "    60G", "    61B", "    61D", "    63F", "    64A", "    65C", "    66E", "    67G", "    68B", "    69D", "    70F", "    71A", "    71C", "    73E", "    74G", "    75B", "    75D", "    77F", "    78A", "    79C", "    80E", "    80G", "    81B", "    81D", "    84F", "    85A", "    85C", "    87E", "    88G", "    89B", "    89D", "    91F", "    92A", "    92C", "    94E", "    95G", "    96B", "    96D", "    98F", "    99A", "    100C"})
        ComboBox3.Location = New Point(696, 371)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(151, 32)
        ComboBox3.TabIndex = 37
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"    Manila", "    Boracay Island", "    Palawan", "    Cebu City", "    Baguio City", "    Davao City", "    Bohol", "    Siargao Island", "    Tagaytay City", "    Vigan", "    Batanes", "    Camiguin Island", "    Sagada", "    Puerto Galera", "    Coron", "    Banaue Rice Terraces", "    Dumaguete City", "    Subic Bay", "    Pampanga", "    Batangas City", "    Legazpi City", "    Zamboanga City", "    Iloilo City", "    Bacolod City", "    Roxas City", "    Antique", "    Catanduanes", "    Siquijor Island", "    Surigao City", "    Butuan City", "    Marinduque", "    Bicol Region", "    Calbayog City", "    Ormoc City", "    Tacloban City", "    Leyte", "    Samar", "    Tuguegarao City", "    Laoag City", "    Vigan", "    Baler", "    San Juan, La Union", "    San Fernando, La Union", "    Bataan", "    Nueva Ecija", "    Isabela", "    Pangasinan", "    Tarlac City", "    Pampanga", "    Zambales", "    Masbate", "    Sorsogon", "    Albay", "    Camarines Sur", "    Camarines Norte", "    Quezon Province", "    Batangas", "    Cavite", "    Laguna", "    Rizal Province", "    Bulacan", "    Nueva Vizcaya", "    Quirino", "    Aurora", "    Benguet", "    Ifugao", "    Mountain Province", "    Kalinga", "    Apayao", "    Abra", "    Ilocos Norte", "    Ilocos Sur", "    La Union", "    Pangasinan", "    Cagayan", "    Isabela", "    Quirino", "    Aurora", "    Nueva Ecija", "    Tarlac", "    Pampanga", "    Bulacan", "    Metro Manila", "    Rizal", "    Cavite", "    Laguna", "    Batangas", "    Quezon", "    Marinduque", "    Occidental Mindoro", "    Oriental Mindoro", "    Romblon", "    Palawan", "    Catanduanes", "    Albay", "    Camarines Norte", "    Camarines Sur", "    Sorsogon", "    Masbate", "    Tawi-Tawi"})
        ComboBox4.Location = New Point(696, 442)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(151, 32)
        ComboBox4.TabIndex = 38
        ' 
        ' Customer_ID
        ' 
        Customer_ID.HeaderText = "Customer I.D"
        Customer_ID.MinimumWidth = 6
        Customer_ID.Name = "Customer_ID"
        Customer_ID.Width = 125
        ' 
        ' CustomerFirstName
        ' 
        CustomerFirstName.HeaderText = "First Name"
        CustomerFirstName.MinimumWidth = 6
        CustomerFirstName.Name = "CustomerFirstName"
        CustomerFirstName.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Last Name"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' CustomerBirthday
        ' 
        CustomerBirthday.HeaderText = "Birthday"
        CustomerBirthday.MinimumWidth = 6
        CustomerBirthday.Name = "CustomerBirthday"
        CustomerBirthday.Width = 125
        ' 
        ' Address
        ' 
        Address.HeaderText = "Address"
        Address.MinimumWidth = 6
        Address.Name = "Address"
        Address.Width = 125
        ' 
        ' email
        ' 
        email.HeaderText = "Email"
        email.MinimumWidth = 6
        email.Name = "email"
        email.Width = 125
        ' 
        ' phoneNo
        ' 
        phoneNo.HeaderText = "Phone"
        phoneNo.MinimumWidth = 6
        phoneNo.Name = "phoneNo"
        phoneNo.Width = 125
        ' 
        ' gender
        ' 
        gender.HeaderText = "Gender"
        gender.MinimumWidth = 6
        gender.Name = "gender"
        gender.Width = 125
        ' 
        ' AppoitmentForm
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 24.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(117), CByte(186))
        ClientSize = New Size(1565, 806)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(Button5)
        Controls.Add(DeleteBtn)
        Controls.Add(PrintBtn)
        Controls.Add(EditBtn)
        Controls.Add(Button1)
        Controls.Add(TextBox10)
        Controls.Add(Label14)
        Controls.Add(CustomerPhoneTextBox)
        Controls.Add(Label13)
        Controls.Add(ComboBox2)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(ComboBox1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(TextBox6)
        Controls.Add(Label8)
        Controls.Add(btFemale)
        Controls.Add(btnMale)
        Controls.Add(CustomerEmailTextBox)
        Controls.Add(CustomerAddressTextBox)
        Controls.Add(CustomerGenderLabel)
        Controls.Add(Label6)
        Controls.Add(Birthday)
        Controls.Add(dtbirthday)
        Controls.Add(CustomerLastNameTextBox)
        Controls.Add(CustomerFirstNameTextBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(CustomerIDTextBox)
        Controls.Add(allRecordsData)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Font = New Font("Roboto", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "AppoitmentForm"
        Text = "Appoitment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(allRecordsData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents allRecordsData As DataGridView
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CustomerFirstNameTextBox As TextBox
    Friend WithEvents CustomerLastNameTextBox As TextBox
    Friend WithEvents dtbirthday As DateTimePicker
    Friend WithEvents Birthday As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CustomerGenderLabel As Label
    Friend WithEvents CustomerAddressTextBox As TextBox
    Friend WithEvents CustomerEmailTextBox As TextBox
    Friend WithEvents btnMale As RadioButton
    Friend WithEvents btFemale As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CustomerPhoneTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents PrintBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Customer_ID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerFirstName As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerBirthday As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents phoneNo As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
End Class
