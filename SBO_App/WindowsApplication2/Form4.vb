Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "#Ballislife013" Then

            Form2.Show()
            Form6.Show()

        Else

            MsgBox("The password you entered is invalid!", vbOKOnly, "Shoho-Q Basketball Open")

            TextBox1.Text = ""
            TextBox1.Focus()

        End If

    End Sub

    Private Sub Form4_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

        TextBox1.Text = ""

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = 108 Or e.KeyCode = 13 Then

            Button1.PerformClick()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Form2.Show()

    End Sub


End Class