Public Class AppoitmentForm

    Private Sub AppoitmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTextBox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles CustomerFirstNameTextBox.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles CustomerLastNameTextBox.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtbirthday.ValueChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If CustomerIDTextBox.Text = "" OrElse CustomerFirstNameTextBox.Text = "" OrElse
       CustomerLastNameTextBox.Text = "" OrElse dtbirthday.Text = "" OrElse
       CustomerAddressTextBox.Text = "" OrElse CustomerEmailTextBox.Text = "" OrElse
       CustomerPhoneTextBox.Text = "" OrElse CustomerGenderLabel.Text = "" Then

            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the method if any required field is empty
        End If

        ' Check if CustomerID is a valid number
        Dim customerId As Integer
        If Not Integer.TryParse(CustomerIDTextBox.Text, customerId) Then
            MessageBox.Show("CustomerID must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the method if CustomerID is not a valid number
        End If

        ' Add the data to the allRecordsData table
        Me.allRecordsData.Rows.Add(CustomerIDTextBox.Text, CustomerFirstNameTextBox.Text, CustomerLastNameTextBox.Text,
                               dtbirthday.Text, CustomerAddressTextBox.Text, CustomerEmailTextBox.Text,
                               CustomerPhoneTextBox.Text, CustomerGenderLabel.Text)

        ' Optionally, you can clear the textboxes after adding the data
        ClearTextBoxes()
    End Sub

    Private Sub ClearTextBoxes()
        ' Clear all textboxes
        CustomerIDTextBox.Text = ""
        CustomerFirstNameTextBox.Text = ""
        CustomerLastNameTextBox.Text = ""
        dtbirthday.Text = ""
        CustomerAddressTextBox.Text = ""
        CustomerEmailTextBox.Text = ""
        CustomerPhoneTextBox.Text = ""
        CustomerGenderLabel.Text = ""
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles allRecordsData.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class