Imports System.Text
Imports MySql.Data.MySqlClient
Public Class AppoitmentForm


    Private selectedRowIndex As Integer = -1

    Private random As New Random()

    Private Sub AppoitmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form or any other necessary setup
    End Sub

    Private Sub allRecordsData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles allRecordsData.CellClick
        ' Store the selected row index
        selectedRowIndex = e.RowIndex
        Console.WriteLine("Selected Row Index: " & selectedRowIndex.ToString())
    End Sub

    Private Sub GenerateRandomFlightID()
        ' Generate a random integer between 1000 and 9999
        Dim randomInteger As Integer = random.Next(1000, 10000)

        ' Generate a random string of 3 uppercase letters
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim randomString As String = New String(Enumerable.Repeat(chars, 3).Select(Function(s) s(random.Next(s.Length))).ToArray())

        ' Combine the random integer and random string to form the FlightID
        Dim flightID As String = randomInteger.ToString() & randomString

        ' Assign the generated FlightID to the TextBox
        FlightIDTxtBox.Text = flightID
    End Sub

    Private Sub GenerateRandomCustomerID()
        ' Generate a random integer between 1000 and 9999
        Dim randomInteger As Integer = random.Next(1000, 10000)

        ' Generate a random string of 2 uppercase letters
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim randomString As String = New String(Enumerable.Repeat(chars, 2).Select(Function(s) s(random.Next(s.Length))).ToArray())

        ' Combine the random integer and random string to form the CustomerID
        Dim customerId As String = randomInteger.ToString() & randomString

        ' Assign the generated CustomerID to the TextBox
        CustomerIDTextBox.Text = customerId
    End Sub

    Private Sub CustomerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTextBox.TextChanged
        ' You can handle any necessary logic here when the CustomerIDTextBox changes
    End Sub

    Private Sub FlightIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles FlightIDTxtBox.TextChanged
        ' You can handle any necessary logic here when the FlightIDTxtBox changes
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Check if data with the same Customer ID already exists in the DataGridView
        Dim exists As Boolean = False
        For Each row As DataGridViewRow In allRecordsData.Rows
            ' Assuming the first column (index 0) contains the unique identifier (e.g., CustomerID)
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = CustomerIDTextBox.Text Then
                exists = True
                Exit For
            End If
        Next

        ' If data already exists, show an error message and exit the sub
        If exists Then
            MessageBox.Show("Data with the same Customer ID already exists in the DataGridView.")
            Return
        End If

        ' If data doesn't exist, add it to the DataGridView
        GenerateRandomCustomerID() ' Generate random CustomerID
        GenerateRandomFlightID() ' Generate random FlightID
        allRecordsData.Rows.Add(
            CustomerIDTextBox.Text,
            FlightIDTxtBox.Text,
            CustomerFirstNameTextBox.Text,
            CustomerLastNameTextBox.Text,
            dtbirthday.Value.ToString("MM/dd/yyyy"),
            CustomerAddressTextBox.Text,
            CustomerEmailTextBox.Text,
            CustomerPhoneTextBox.Text,
            CustomerGenderLabel.Text,
            FlightClassCombo.Text,
            SeatsCombo.Text,
            DestinationCombo.Text,
            GateCombo.Text)

        ' Clear the input fields after adding data
        ClearInputFields()
    End Sub

    Private Sub ClearInputFields()
        ' Clear all input fields after adding data
        CustomerFirstNameTextBox.Text = ""
        CustomerLastNameTextBox.Text = ""
        ' Clear other fields as well...
        ' For example: dtbirthday.Value = DateTime.Today
    End Sub

    Private Sub allRecordsData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles allRecordsData.CellContentClick
        ' Handle cell content click event if needed

    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        ' Check if the DataGridView contains any rows
        Console.WriteLine("Total Rows in DataGridView: " & allRecordsData.Rows.Count.ToString())

        If allRecordsData.Rows.Count = -1 Then
            MessageBox.Show("There are no records to print.")
            Return
        End If

        ' Check if a row is selected
        If selectedRowIndex < -1 OrElse selectedRowIndex >= allRecordsData.Rows.Count Then
            MessageBox.Show("Please select a valid row to print. Selected Row Index: " & selectedRowIndex.ToString())
            Return
        End If

        ' Get the selected row
        Dim selectedRow As DataGridViewRow = allRecordsData.Rows(selectedRowIndex)

        ' Create a StringBuilder to store the receipt text
        Dim receiptText As New StringBuilder()

        ' Add header
        receiptText.AppendLine("-------- Receipt --------")

        ' Add customer and flight details to the receipt based on user selection
        ' Adjust the indices according to the structure of your DataGridView
        receiptText.AppendLine("Customer ID: " & selectedRow.Cells(0).Value.ToString())
        receiptText.AppendLine("Flight ID: " & selectedRow.Cells(1).Value.ToString())
        receiptText.AppendLine("Customer Name: " & selectedRow.Cells(2).Value.ToString() & " " & selectedRow.Cells(3).Value.ToString())
        receiptText.AppendLine("Date of Birth: " & selectedRow.Cells(4).Value.ToString())
        receiptText.AppendLine("Address: " & selectedRow.Cells(5).Value.ToString())
        receiptText.AppendLine("Email: " & selectedRow.Cells(6).Value.ToString())
        receiptText.AppendLine("Phone: " & selectedRow.Cells(7).Value.ToString())
        receiptText.AppendLine("Gender: " & selectedRow.Cells(8).Value.ToString())
        receiptText.AppendLine("Flight Class: " & selectedRow.Cells(9).Value.ToString())
        receiptText.AppendLine("Seats: " & selectedRow.Cells(10).Value.ToString())
        receiptText.AppendLine("Destination: " & selectedRow.Cells(11).Value.ToString())
        receiptText.AppendLine("Gate: " & selectedRow.Cells(12).Value.ToString())
        receiptText.AppendLine("------------------------")

        ' Display the receipt in a message box (you can modify this to print the receipt using a printer or any other desired method)
        MessageBox.Show(receiptText.ToString(), "Receipt")

        ' Clear the selected row index
        selectedRowIndex = -1
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        ' Check if a row is selected
        If selectedRowIndex < 0 OrElse selectedRowIndex >= allRecordsData.Rows.Count Then
            MessageBox.Show("Please select a valid row to delete.")
            Return
        End If

        ' Confirm deletion with user
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Remove the selected row from the DataGridView
            allRecordsData.Rows.RemoveAt(selectedRowIndex)
            ' Clear the selected row index
            selectedRowIndex = -1
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        ' Check if a row is selected
        If selectedRowIndex < 0 OrElse selectedRowIndex >= allRecordsData.Rows.Count Then
            MessageBox.Show("Please select a valid row to edit.")
            Return
        End If

        ' Enter edit mode for the selected row
        allRecordsData.BeginEdit(True)
    End Sub


    Sub LoadCustomer()
        Try
            Dim queryStr As String = "SELECT * FROM customer_2"
            readquery(queryStr)
            allRecordsData.Rows.Clear()
            With cmdRead
                While .Read
                    ' Adjust the column index according to your database schema
                    allRecordsData.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6), .GetValue(7), .GetValue(8))
                End While
            End With
            allRecordsData.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("Error loading customer data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadCustomer()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CustomerFirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerFirstNameTextBox.TextChanged

    End Sub
    ' Other event handlers and methods...

End Class
