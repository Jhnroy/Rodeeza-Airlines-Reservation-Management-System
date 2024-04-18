
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices


Public Class Form1
    Private Users As New Dictionary(Of String, String)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Users.Add("admin", "admin")
        Users.Add("username2", "password2")
        Users.Add("username3", "password3")
        Users.Add("username4", "password4")
    End Sub



    Private Sub UsernameLabel_TextChanged_1(sender As Object, e As EventArgs) Handles UsernameLabel.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PasswordLabel.TextChanged

    End Sub
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim username As String = UsernameLabel.Text.Trim()
        Dim password As String = PasswordLabel.Text.Trim()

        If Users.ContainsKey(username) Then

            If Users(username) = (password) Then
                MessageBox.Show("Login Succesfully!")
                AppoitmentForm.Show()
                Me.Hide()
            Else MessageBox.Show("Incorrect Password")
            End If

        Else MessageBox.Show("Username does not exist!")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        UsernameLabel.Clear()
        PasswordLabel.Clear()
    End Sub

    Private Sub UsernameLabel_TextChanged(sender As Object, e As EventArgs)

    End Sub



End Class
