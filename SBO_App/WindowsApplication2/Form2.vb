Public Class Form2
    Private MyInput As String = ""
    Dim rs As New Resizer

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If MessageBox.Show("Do you want to close scoreboard?", "Shoho-Q Basketball Open", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            e.Cancel = False

            Form4.Close()

        Else

            Form4.Timer1.Enabled = True
            Timer1.Enabled = True
            e.Cancel = True

        End If

    End Sub
    Public Function isOpened(ByVal frm As Form) As Boolean

        Dim frmCol As New FormCollection()

        frmCol = Application.OpenForms

        Dim Cnt As Integer = 0

        For Each f As Form In frmCol
            If f.Name = frm.Name Then
                Cnt += 1
            End If
        Next

        Return IIf(Cnt > 0, True, False)

    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim RM As Resources.ResourceManager

        RM = New Resources.ResourceManager("WindowsApplication2.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        On Error Resume Next

        Form4.Timer1.Enabled = False

        'PictureBox5.Image = RM.GetObject("logo")

        rs.FindAllControls(Me)

        If Form3.CheckBox1.Checked = False Then

            Form1.Hide()

        Else

            Form1.Show()

        End If


        rs.FindAllControls(Me)

        Label4.Text = AddZero(Form3.NumericUpDown1.Value) & ":" & AddZero(Form3.NumericUpDown2.Value)

        Me.KeyPreview = True


    End Sub

    Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        rs.ResizeAllControls(Me)

    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode.ToString = "F2" Then

            Form3.Show()

        End If


        If e.KeyCode.ToString = Form3.TextBox1.Text Then

            Form1.Button5.PerformClick()

        Else

            If e.KeyCode.ToString = Form3.TextBox1.Text Then

                Form1.Button5.PerformClick()

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox2.Text Then

            Form1.Button25.PerformClick()

        End If

        If e.KeyCode.ToString = Form3.TextBox3.Text Then

            Form1.Button26.PerformClick()

        End If

        If e.KeyCode.ToString = Form3.TextBox31.Text Then

            Form1.Button3.PerformClick()

        End If

        If e.KeyCode.ToString = Form3.TextBox4.Text Then

            Form1.Button10.PerformClick()

            If Form1.CheckBox1.Checked = False And Form1.CheckBox2.Checked = False And CDbl(Form1.Label8.Text) > 0 And CDbl(Form1.Label9.Text) > 0 Then

                Form1.Focus()
                MsgBox("Please select who got the first possession")

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox5.Text Then

            Form1.Button9.PerformClick()

            If Form1.CheckBox1.Checked = False And Form1.CheckBox2.Checked = False And CDbl(Form1.Label8.Text) > 0 And CDbl(Form1.Label9.Text) > 0 Then

                Form1.Focus()
                MsgBox("Please select who got the first possession")

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox6.Text Then

            Form1.Button8.PerformClick()

            If Form1.CheckBox1.Checked = False And Form1.CheckBox2.Checked = False And CDbl(Form1.Label8.Text) > 0 And CDbl(Form1.Label9.Text) > 0 Then

                Form1.Focus()
                MsgBox("Please select who got the first possession")

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox7.Text Then

            Form1.Button20.PerformClick()

        End If

        If e.KeyCode.ToString = Form3.TextBox9.Text Then

            Form1.Button1.PerformClick()

        End If

        If e.KeyCode.ToString = Form3.TextBox10.Text Then

            Form1.Button2.PerformClick()

        End If

        If e.KeyCode.ToString = Form3.TextBox11.Text Then

            Form1.Button14.PerformClick()

            If Form1.CheckBox1.Checked = False And Form1.CheckBox2.Checked = False And CDbl(Form1.Label8.Text) > 0 And CDbl(Form1.Label9.Text) > 0 Then

                Form1.Focus()
                MsgBox("Please select who got the first possession")

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox12.Text Then

            Form1.Button13.PerformClick()

            If Form1.CheckBox1.Checked = False And Form1.CheckBox2.Checked = False And CDbl(Form1.Label8.Text) > 0 And CDbl(Form1.Label9.Text) > 0 Then

                Form1.Focus()
                MsgBox("Please select who got the first possession")

            End If

        End If

        If e.KeyCode = 34 Then

            Form1.Button12.PerformClick()

        Else

            If e.KeyCode.ToString = Form3.TextBox13.Text Then

                Form1.Button12.PerformClick()

                If Form1.CheckBox1.Checked = False And Form1.CheckBox2.Checked = False And CDbl(Form1.Label8.Text) > 0 And CDbl(Form1.Label9.Text) > 0 Then

                    Form1.Focus()
                    MsgBox("Please select who got the first possession")

                End If

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox14.Text Then

            Form1.Button19.PerformClick()

        End If

        If e.KeyCode = 37 Then

            Form1.CheckBox1.Checked = True

        End If

        If e.KeyCode = 39 Then

            Form1.CheckBox2.Checked = True

        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Form1.Show()

    End Sub

End Class