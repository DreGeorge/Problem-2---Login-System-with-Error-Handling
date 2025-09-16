Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim username As String = txtUsername.Text
            Dim password As String = txtPassword.Text



            If username = "" Or password = "" Then
                Throw New Exception("Username or Password cannot be empty.")
            ElseIf username = "Dre" And password = "1234" Then
                lblResult.Text = "Login successful!"
            Else
                lblResult.Text = "Invalid username or password."
            End If
        Catch ex As Exception

            lblResult.Text = ex.Message
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

