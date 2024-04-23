Imports System.Text
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Reflection.Metadata
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

        ' Save the new data to the database
        SaveNewDataToDatabase(CustomerIDTextBox.Text, FlightIDTxtBox.Text, CustomerFirstNameTextBox.Text,
                          CustomerLastNameTextBox.Text, dtbirthday.Value.ToString("yyyy-MM-dd"),
                          CustomerAddressTextBox.Text, CustomerEmailTextBox.Text, CustomerPhoneTextBox.Text,
                          CustomerGenderLabel.Text, FlightClassCombo.Text, SeatsCombo.Text, DestinationCombo.Text,
                          GateCombo.Text)

        ' Clear the input fields after adding data
        ClearInputFields()
    End Sub

    Private Sub SaveNewDataToDatabase(ByVal customerId As String, ByVal flightId As String, ByVal firstName As String,
                                  ByVal lastName As String, ByVal birthday As String, ByVal address As String,
                                  ByVal email As String, ByVal phone As String, ByVal gender As String,
                                  ByVal flightClass As String, ByVal seats As String, ByVal destination As String,
                                  ByVal gate As String)
        Try
            Dim query As String = "INSERT INTO customertable_2 (CustomerId, FlightId, FirstName, LastName, Birthday, Address, Email, Phone, Gender, FlightClass, Seats, Destination, Gate) VALUES (@CustomerId, @FlightId, @FirstName, @LastName, @Birthday, @Address, @Email, @Phone, @Gender, @FlightClass, @Seats, @Destination, @Gate)"
            Using connection As New MySqlConnection("server=" & db_server & "; port=" & db_port & ";uid=" & db_uid & ";password=" & db_pwd & ";database=" & db_name & ";")
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@CustomerId", customerId)
                    command.Parameters.AddWithValue("@FlightId", flightId)
                    command.Parameters.AddWithValue("@FirstName", firstName)
                    command.Parameters.AddWithValue("@LastName", lastName)
                    command.Parameters.AddWithValue("@Birthday", birthday)
                    command.Parameters.AddWithValue("@Address", address)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Phone", phone)
                    command.Parameters.AddWithValue("@Gender", gender)
                    command.Parameters.AddWithValue("@FlightClass", flightClass)
                    command.Parameters.AddWithValue("@Seats", seats)
                    command.Parameters.AddWithValue("@Destination", destination)
                    command.Parameters.AddWithValue("@Gate", gate)

                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("New data saved successfully.")
                    Else
                        MessageBox.Show("No rows were affected by the insert operation. Check your query or database connection.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving new data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        ' Check if a row is selected
        If selectedRowIndex < 0 OrElse selectedRowIndex >= allRecordsData.Rows.Count Then
            MessageBox.Show("Please select a valid row to print.")
            Return
        End If

        ' Get the selected row
        Dim selectedRow As DataGridViewRow = allRecordsData.Rows(selectedRowIndex)

        ' Create a new PDF document
        Dim doc As New iTextSharp.text.Document()
        Dim filename As String = "CustomerData.pdf"

        Try
            ' Create a PdfWriter object to write the document to a file
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(filename, FileMode.Create))

            ' Open the document
            doc.Open()

            ' Create a PdfPTable to store the data
            Dim table As New PdfPTable(2) ' Assuming two columns for simplicity
            table.WidthPercentage = 100

            ' Add headers
            table.AddCell("Field")
            table.AddCell("Value")

            ' Add data rows
            For Each cell As DataGridViewCell In selectedRow.Cells
                table.AddCell(cell.OwningColumn.HeaderText)
                table.AddCell(cell.Value.ToString())
            Next

            ' Add the table to the document
            doc.Add(table)

            ' Close the document
            doc.Close()

            ' Show success message
            MessageBox.Show("PDF file generated successfully.", "Success")

            ' Specify the path to the PDF viewer executable
            Dim pdfViewerPath As String = "C:\Program Files\Mozilla Firefox\firefox.exe"

            ' Check if the PDF viewer executable exists
            If File.Exists(pdfViewerPath) Then
                ' Open the PDF file using the specified PDF viewer
                Process.Start(pdfViewerPath, filename)
            Else
                ' Show error message if the PDF viewer executable is not found
                MessageBox.Show("PDF viewer application not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Show error message if an exception occurs
            MessageBox.Show("Error generating PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the document if it's still open
            If doc.IsOpen() Then
                doc.Close()
            End If
        End Try
    End Sub






    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        ' Check if a row is selected
        If selectedRowIndex < 0 OrElse selectedRowIndex >= allRecordsData.Rows.Count Then
            MessageBox.Show("Please select a valid row to edit.")
            Return
        End If

        ' Set the current cell to the Customer Name cell (index 2) of the selected row
        allRecordsData.CurrentCell = allRecordsData.Rows(selectedRowIndex).Cells(2)

        ' Enter edit mode for the selected cell
        allRecordsData.BeginEdit(True)

        ' Prompt the user if they want to save the edited data
        Dim result As DialogResult = MessageBox.Show("Do you want to save the edited data?", "Save Changes", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            SaveEditedData()
        End If
    End Sub


    Private Sub SaveEditedData()
        Try
            ' Get the edited data from the DataGridView
            Dim editedCustomerID As String = allRecordsData.Rows(selectedRowIndex).Cells(0).Value.ToString()
            Dim editedFlightID As String = allRecordsData.Rows(selectedRowIndex).Cells(1).Value.ToString()
            Dim editedFirstName As String = allRecordsData.Rows(selectedRowIndex).Cells(2).Value.ToString()
            Dim editedLastName As String = allRecordsData.Rows(selectedRowIndex).Cells(3).Value.ToString()
            Dim editedBirthday As String = allRecordsData.Rows(selectedRowIndex).Cells(4).Value.ToString()
            Dim editedAddress As String = allRecordsData.Rows(selectedRowIndex).Cells(5).Value.ToString()
            Dim editedEmail As String = allRecordsData.Rows(selectedRowIndex).Cells(6).Value.ToString()
            Dim editedPhone As String = allRecordsData.Rows(selectedRowIndex).Cells(7).Value.ToString()
            Dim editedGender As String = allRecordsData.Rows(selectedRowIndex).Cells(8).Value.ToString()
            Dim editedFlightClass As String = allRecordsData.Rows(selectedRowIndex).Cells(9).Value.ToString()
            Dim editedSeats As String = allRecordsData.Rows(selectedRowIndex).Cells(10).Value.ToString()
            Dim editedDestination As String = allRecordsData.Rows(selectedRowIndex).Cells(11).Value.ToString()
            Dim editedGate As String = allRecordsData.Rows(selectedRowIndex).Cells(12).Value.ToString()

            ' Update the data in the database
            Dim query As String = "UPDATE customertable_2 SET 
                                    FirstName = @FirstName, 
                                    LastName = @LastName, 
                                    Birthday = @Birthday, 
                                    Address = @Address, 
                                    Email = @Email, 
                                    Phone = @Phone, 
                                    Gender = @Gender, 
                                    FlightClass = @FlightClass, 
                                    Seats = @Seats, 
                                    Destination = @Destination, 
                                    Gate = @Gate
                                    WHERE CustomerId = @CustomerId 
                                    AND FlightId = @FlightId"

            Using connection As New MySqlConnection("server=" & db_server & "; port=" & db_port & ";uid=" & db_uid & ";password=" & db_pwd & ";database=" & db_name & ";")
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@CustomerId", editedCustomerID)
                    command.Parameters.AddWithValue("@FlightId", editedFlightID)
                    command.Parameters.AddWithValue("@FirstName", editedFirstName)
                    command.Parameters.AddWithValue("@LastName", editedLastName)
                    command.Parameters.AddWithValue("@Birthday", editedBirthday)
                    command.Parameters.AddWithValue("@Address", editedAddress)
                    command.Parameters.AddWithValue("@Email", editedEmail)
                    command.Parameters.AddWithValue("@Phone", editedPhone)
                    command.Parameters.AddWithValue("@Gender", editedGender)
                    command.Parameters.AddWithValue("@FlightClass", editedFlightClass)
                    command.Parameters.AddWithValue("@Seats", editedSeats)
                    command.Parameters.AddWithValue("@Destination", editedDestination)
                    command.Parameters.AddWithValue("@Gate", editedGate)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Edited data saved successfully.")
        Catch ex As Exception
            MessageBox.Show("Error saving edited data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub LoadCustomer()
        Try
            Dim queryStr As String = "SELECT * FROM customertable_2 WHERE FirstName LIKE @searchKeyword OR LastName LIKE @searchKeyword OR CustomerId LIKE @searchkeyword"
            Using connection As New MySqlConnection("server=" & db_server & "; port=" & db_port & ";uid=" & db_uid & ";password=" & db_pwd & ";database=" & db_name & ";")
                Using command As New MySqlCommand(queryStr, connection)
                    ' Add a parameter for the search keyword
                    command.Parameters.AddWithValue("@searchKeyword", "%" & SearchTxtBox.Text.Trim() & "%")

                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        allRecordsData.Rows.Clear()
                        While reader.Read()
                            ' Add the retrieved rows to the DataGridView
                            Dim rowIndex As Integer = allRecordsData.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3),
                                                                          reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7),
                                                                          reader.GetValue(8), reader.GetValue(9), reader.GetValue(10), reader.GetValue(11),
                                                                          reader.GetValue(12))
                            ' Set CustomerID and FlightID cells as non-editable
                            allRecordsData.Rows(rowIndex).Cells(0).ReadOnly = True
                            allRecordsData.Rows(rowIndex).Cells(1).ReadOnly = True
                        End While
                    End Using
                End Using
            End Using
            allRecordsData.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("Error loading customer data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        ' Check if a row is selected
        If selectedRowIndex < 0 OrElse selectedRowIndex >= allRecordsData.Rows.Count Then
            MessageBox.Show("Please select a valid row to delete.")
            Return
        End If

        ' Confirm deletion with user
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                ' Remove the selected row from the DataGridView
                Dim selectedRow As DataGridViewRow = allRecordsData.Rows(selectedRowIndex)

                ' Retrieve CustomerID and FlightID of the row to be deleted
                Dim customerIdToDelete As String = selectedRow.Cells(0).Value.ToString()
                Dim flightIdToDelete As String = selectedRow.Cells(1).Value.ToString()

                ' Delete the corresponding record from the database
                Dim deleteQuery As String = "DELETE FROM customertable_2 WHERE CustomerId = @CustomerId AND FlightId = @FlightId"

                Using connection As New MySqlConnection("server=" & db_server & "; port=" & db_port & ";uid=" & db_uid & ";password=" & db_pwd & ";database=" & db_name & ";")
                    Using command As New MySqlCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@CustomerId", customerIdToDelete)
                        command.Parameters.AddWithValue("@FlightId", flightIdToDelete)

                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Remove the selected row from the DataGridView
                allRecordsData.Rows.RemoveAt(selectedRowIndex)

                ' Clear the selected row index
                selectedRowIndex = -1

                MessageBox.Show("Record deleted successfully.")
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        ' Call the LoadCustomer method to load filtered data based on the search criteria
        LoadCustomer()
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

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles SearchTxtBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click

    End Sub
    ' Other event handlers and methods...
End Class