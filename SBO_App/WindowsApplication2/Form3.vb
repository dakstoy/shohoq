Imports VB = Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Office.Interop
Public Class Form3
    Dim rs As New Resizer
    Shared random As New Random()

    Function AddZero(ByVal par As Integer) As String

        Dim a = ""
        If par < 10 Then
            a = "0" & par
        Else
            a = par
        End If

        Return a

    End Function


    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter

        TextBox1.BackColor = System.Drawing.Color.Yellow
        TextBox1.Text = "Press a Key"


    End Sub

    Private Sub Textbox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox1.Text = "Left mouse button"

            Case 2
                TextBox1.Text = "Right mouse button"

            Case 3
                TextBox1.Text = "Cancel"

            Case 4
                TextBox1.Text = "Middle mouse button"

            Case 8
                TextBox1.Text = "Backspace"

            Case 9
                TextBox1.Text = "Tab"

            Case 12

                TextBox1.Text = "Clear"

            Case 13
                TextBox1.Text = "Enter"

            Case 16

                TextBox1.Text = "Shift"

            Case 17

                TextBox1.Text = "Ctrl"

            Case 18

                TextBox1.Text = "Menu"

            Case 19

                TextBox1.Text = "Pause"

            Case 20

                TextBox1.Text = "Choose another"

            Case 27

                TextBox1.Text = "Choose another"

            Case 32

                TextBox1.Text = "Choose another"

            Case 33

                TextBox1.Text = "PageUp"

            Case 34

                TextBox1.Text = "PageDown"

            Case 35

                TextBox1.Text = "End"

            Case 36

                TextBox1.Text = "Home"


            Case 45

                TextBox1.Text = "Insert"

            Case 46

                TextBox1.Text = "Delete"

            Case 48
                TextBox1.Text = ""
            Case 49
                TextBox1.Text = ""
            Case 50
                TextBox1.Text = ""
            Case 51
                TextBox1.Text = ""
            Case 52
                TextBox1.Text = ""
            Case 53
                TextBox1.Text = ""
            Case 54
                TextBox1.Text = ""
            Case 55
                TextBox1.Text = ""
            Case 56
                TextBox1.Text = ""
            Case 57
                TextBox1.Text = ""
            Case 65
                TextBox1.Text = "A"
            Case 66
                TextBox1.Text = "B"
            Case 67
                TextBox1.Text = "C"
            Case 68
                TextBox1.Text = "D"
            Case 69
                TextBox1.Text = "E"
            Case 70
                TextBox1.Text = "F"
            Case 71
                TextBox1.Text = "G"
            Case 72
                TextBox1.Text = "H"
            Case 73
                TextBox1.Text = "I"
            Case 74
                TextBox1.Text = "J"
            Case 75
                TextBox1.Text = "K"
            Case 76
                TextBox1.Text = "L"
            Case 77
                TextBox1.Text = "M"
            Case 78
                TextBox1.Text = "N"
            Case 79
                TextBox1.Text = "O"
            Case 80
                TextBox1.Text = "P"
            Case 81
                TextBox1.Text = "Q"
            Case 82
                TextBox1.Text = "R"
            Case 83
                TextBox1.Text = "S"
            Case 84
                TextBox1.Text = "T"
            Case 85
                TextBox1.Text = "U"
            Case 86
                TextBox1.Text = "V"
            Case 87
                TextBox1.Text = "W"
            Case 88
                TextBox1.Text = "X"
            Case 89
                TextBox1.Text = "Y"
            Case 90
                TextBox1.Text = "Z"
            Case 96
                TextBox1.Text = ""
            Case 97
                TextBox1.Text = ""
            Case 98
                TextBox1.Text = ""
            Case 99
                TextBox1.Text = ""
            Case 100
                TextBox1.Text = ""
            Case 101
                TextBox1.Text = ""
            Case 102
                TextBox1.Text = ""
            Case 103
                TextBox1.Text = ""
            Case 104
                TextBox1.Text = ""
            Case 105
                TextBox1.Text = ""
            Case 106

                TextBox1.Text = "Multiply"

            Case 107

                TextBox1.Text = "Choose another"

            Case 108

                TextBox1.Text = "Choose another"

            Case 109

                TextBox1.Text = "Choose another"

            Case 110

                TextBox1.Text = "Choose another"

            Case 111

                TextBox1.Text = "Divide"

            Case 112
                TextBox1.Text = "Choose another"
            Case 113
                TextBox1.Text = "Choose another"
            Case 114
                TextBox1.Text = "F3"
            Case 115
                TextBox1.Text = "F4"
            Case 116
                TextBox1.Text = "F5"
            Case 117
                TextBox1.Text = "F6"
            Case 118
                TextBox1.Text = "F7"
            Case 119
                TextBox1.Text = "F8"
            Case 120
                TextBox1.Text = "F9"
            Case 121
                TextBox1.Text = "Choose another"
            Case 122
                TextBox1.Text = "Choose another"
            Case 123
                TextBox1.Text = "Choose another"
            Case 144

                TextBox1.Text = "Choose another"

        End Select


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

        TextBox1.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each tb As TabPage In TabControl1.TabPages


            TabControl1.SelectedTab = tb

            SuspendLayout()

            Dim textBoxes As TextBox() = New TextBox() {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12, TextBox13, TextBox14, TextBox15}
            For i As Integer = 0 To textBoxes.Length - 2
                For j As Integer = i + 1 To textBoxes.Length - 1
                    If textBoxes(i).Text = textBoxes(j).Text Then
                        'failed to execute, found duplicates
                        MessageBox.Show(Me, "Duplicate values found.")
                        textBoxes(j).Focus()
                        Return
                    End If
                Next
            Next
            'sucessful

            'TextBox16.Text = ComboBox1.Text
            'TextBox17.Text = ComboBox2.Text

            Form1.Label6.Text = TextBox16.Text
            Form1.Label7.Text = TextBox17.Text
            Form1.PictureBox1.Image = PictureBox1.Image
            Form9.PictureBox15.Image = PictureBox1.Image
            Form1.PictureBox2.Image = PictureBox2.Image
            Form9.PictureBox16.Image = PictureBox2.Image

            Form6.PictureBox2.Image = PictureBox3.Image
            Form1.Label11.Text = TextBox18.Text
            Form1.Label1.Text = TextBox21.Text
            Form1.BackColor = TextBox22.BackColor
            Form1.Label4.BackColor = TextBox23.BackColor
            Form1.Label8.BackColor = TextBox23.BackColor
            Form1.Label9.BackColor = TextBox23.BackColor
            Form1.Label10.BackColor = TextBox23.BackColor
            Form1.Label10.ForeColor = TextBox24.BackColor

            Form1.Label8.ForeColor = TextBox25.BackColor
            Form1.Label9.ForeColor = TextBox25.BackColor

            Form1.Label1.ForeColor = TextBox26.BackColor
            Form1.Label2.ForeColor = TextBox26.BackColor
            Form1.Label6.ForeColor = TextBox26.BackColor
            Form1.Label7.ForeColor = TextBox26.BackColor
            Form1.Label11.ForeColor = TextBox26.BackColor

            Form1.Label4.ForeColor = TextBox27.BackColor
            Form2.Label2.ForeColor = TextBox27.BackColor

            'Form1.Label4.Text = AddZero(NumericUpDown1.Value) & ":" & AddZero(NumericUpDown2.Value)

            If CheckBox1.Checked = False Then

                Form1.Hide()

            Else

                Form1.Show()

            End If

            Form2.BackColor = TextBox22.BackColor
            Form2.Label10.BackColor = TextBox23.BackColor
            Form2.Label3.BackColor = TextBox23.BackColor
            Form2.Label8.BackColor = TextBox23.BackColor
            Form2.Label10.ForeColor = TextBox24.BackColor

            Form2.Label8.ForeColor = TextBox25.BackColor
            Form2.Label3.ForeColor = TextBox25.BackColor

            'Form2.Label1.ForeColor = TextBox26.BackColor
            Form2.Label4.ForeColor = TextBox26.BackColor
            Form2.Label5.ForeColor = TextBox26.BackColor
            Form2.Label6.ForeColor = TextBox26.BackColor

            Form2.Label2.ForeColor = TextBox27.BackColor

            My.Settings.Save()

        Next

        ListView1.Items.Clear()

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(TextBox32.Text)

            Dim ThisFile As String = VB.Right(foundFile, Len(foundFile) - Len(TextBox32.Text))

            Dim item11 As New ListViewItem(ThisFile)
            ListView1.Items.Add(item11)

        Next

        Form1.zzz = ListView1.Items.Count

        ResumeLayout()
        Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        My.Settings.Reload()
        Hide()

    End Sub

    Private Sub Textbox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter

        TextBox2.BackColor = System.Drawing.Color.Yellow
        TextBox2.Text = "Press a Key"


    End Sub

    Private Sub Textbox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox2.Text = "Left mouse button"
            Case 2
                TextBox2.Text = "Right mouse button"
            Case 3
                TextBox2.Text = "Cancel"
            Case 4
                TextBox2.Text = "Middle mouse button"
            Case 8
                TextBox2.Text = "Backspace"
            Case 9
                TextBox2.Text = "Tab"
            Case 12
                TextBox2.Text = "Clear"
            Case 13
                TextBox2.Text = "Enter"
            Case 16
                TextBox2.Text = "Shift"
            Case 17
                TextBox2.Text = "Ctrl"
            Case 18
                TextBox2.Text = "Menu"
            Case 19
                TextBox2.Text = "Pause"
            Case 20
                TextBox2.Text = "Choose another"
            Case 27
                TextBox2.Text = "Choose another"
            Case 32
                TextBox2.Text = "Choose another"
            Case 33
                TextBox2.Text = "PageUp"
            Case 34
                TextBox2.Text = "PageDown"
            Case 35
                TextBox2.Text = "End"
            Case 36
                TextBox2.Text = "Home"

            Case 45
                TextBox2.Text = "Insert"
            Case 46
                TextBox2.Text = "Delete"
            Case 47
                TextBox2.Text = "HELP"
            Case 48
                TextBox2.Text = ""
            Case 49
                TextBox2.Text = ""
            Case 50
                TextBox2.Text = ""
            Case 51
                TextBox2.Text = ""
            Case 52
                TextBox2.Text = ""
            Case 53
                TextBox2.Text = ""
            Case 54
                TextBox2.Text = ""
            Case 55
                TextBox2.Text = ""
            Case 56
                TextBox2.Text = ""
            Case 57
                TextBox2.Text = ""
            Case 65
                TextBox2.Text = "A"
            Case 66
                TextBox2.Text = "B"
            Case 67
                TextBox2.Text = "C"
            Case 68
                TextBox2.Text = "D"
            Case 69
                TextBox2.Text = "E"
            Case 70
                TextBox2.Text = "F"
            Case 71
                TextBox2.Text = "G"
            Case 72
                TextBox2.Text = "H"
            Case 73
                TextBox2.Text = "I"
            Case 74
                TextBox2.Text = "J"
            Case 75
                TextBox2.Text = "K"
            Case 76
                TextBox2.Text = "L"
            Case 77
                TextBox2.Text = "M"
            Case 78
                TextBox2.Text = "N"
            Case 79
                TextBox2.Text = "O"
            Case 80
                TextBox2.Text = "P"
            Case 81
                TextBox2.Text = "Q"
            Case 82
                TextBox2.Text = "R"
            Case 83
                TextBox2.Text = "S"
            Case 84
                TextBox2.Text = "T"
            Case 85
                TextBox2.Text = "U"
            Case 86
                TextBox2.Text = "V"
            Case 87
                TextBox2.Text = "W"
            Case 88
                TextBox2.Text = "X"
            Case 89
                TextBox2.Text = "Y"
            Case 90
                TextBox2.Text = "Z"
            Case 96
                TextBox2.Text = ""
            Case 97
                TextBox2.Text = ""
            Case 98
                TextBox2.Text = ""
            Case 99
                TextBox2.Text = ""
            Case 100
                TextBox2.Text = ""
            Case 101
                TextBox2.Text = ""
            Case 102
                TextBox2.Text = ""
            Case 103
                TextBox2.Text = ""
            Case 104
                TextBox2.Text = ""
            Case 105
                TextBox2.Text = ""
            Case 106
                TextBox2.Text = "Multiply"
            Case 107
                TextBox2.Text = "Choose another"
            Case 108
                TextBox2.Text = "Choose another"
            Case 109
                TextBox2.Text = "Choose another"
            Case 110
                TextBox2.Text = "Choose another"
            Case 111
                TextBox2.Text = "Divide"
            Case 112
                TextBox2.Text = "Choose another"
            Case 113
                TextBox2.Text = "Choose another"
            Case 114
                TextBox2.Text = "F3"
            Case 115
                TextBox2.Text = "F4"
            Case 116
                TextBox2.Text = "F5"
            Case 117
                TextBox2.Text = "F6"
            Case 118
                TextBox2.Text = "F7"
            Case 119
                TextBox2.Text = "F8"
            Case 120
                TextBox2.Text = "F9"
            Case 121
                TextBox2.Text = "Choose another"
            Case 122
                TextBox2.Text = "Choose another"
            Case 123
                TextBox2.Text = "Choose another"

            Case 144
                TextBox2.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave

        TextBox2.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.Enter

        TextBox3.BackColor = System.Drawing.Color.Yellow
        TextBox3.Text = "Press a Key"


    End Sub

    Private Sub Textbox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox3.Text = "Left mouse button"
            Case 2
                TextBox3.Text = "Right mouse button"
            Case 3
                TextBox3.Text = "Cancel"
            Case 4
                TextBox3.Text = "Middle mouse button"
            Case 8
                TextBox3.Text = "Backspace"
            Case 9
                TextBox3.Text = "Tab"
            Case 12
                TextBox3.Text = "Clear"
            Case 13
                TextBox3.Text = "Enter"
            Case 16
                TextBox3.Text = "Shift"
            Case 17
                TextBox3.Text = "Ctrl"
            Case 18
                TextBox3.Text = "Menu"
            Case 19
                TextBox3.Text = "Pause"
            Case 20
                TextBox3.Text = "Choose another"
            Case 27
                TextBox3.Text = "Choose another"
            Case 32
                TextBox3.Text = "Choose another"
            Case 33
                TextBox3.Text = "PageUp"
            Case 34
                TextBox3.Text = "PageDown"
            Case 35
                TextBox3.Text = "End"
            Case 36
                TextBox3.Text = "Home"

            Case 45
                TextBox3.Text = "Insert"
            Case 46
                TextBox3.Text = "Delete"
            Case 47
                TextBox3.Text = "HELP"
            Case 48
                TextBox3.Text = ""
            Case 49
                TextBox3.Text = ""
            Case 50
                TextBox3.Text = ""
            Case 51
                TextBox3.Text = ""
            Case 52
                TextBox3.Text = ""
            Case 53
                TextBox3.Text = ""
            Case 54
                TextBox3.Text = ""
            Case 55
                TextBox3.Text = ""
            Case 56
                TextBox3.Text = ""
            Case 57
                TextBox3.Text = ""
            Case 65
                TextBox3.Text = "A"
            Case 66
                TextBox3.Text = "B"
            Case 67
                TextBox3.Text = "C"
            Case 68
                TextBox3.Text = "D"
            Case 69
                TextBox3.Text = "E"
            Case 70
                TextBox3.Text = "F"
            Case 71
                TextBox3.Text = "G"
            Case 72
                TextBox3.Text = "H"
            Case 73
                TextBox3.Text = "I"
            Case 74
                TextBox3.Text = "J"
            Case 75
                TextBox3.Text = "K"
            Case 76
                TextBox3.Text = "L"
            Case 77
                TextBox3.Text = "M"
            Case 78
                TextBox3.Text = "N"
            Case 79
                TextBox3.Text = "O"
            Case 80
                TextBox3.Text = "P"
            Case 81
                TextBox3.Text = "Q"
            Case 82
                TextBox3.Text = "R"
            Case 83
                TextBox3.Text = "S"
            Case 84
                TextBox3.Text = "T"
            Case 85
                TextBox3.Text = "U"
            Case 86
                TextBox3.Text = "V"
            Case 87
                TextBox3.Text = "W"
            Case 88
                TextBox3.Text = "X"
            Case 89
                TextBox3.Text = "Y"
            Case 90
                TextBox3.Text = "Z"
            Case 96
                TextBox3.Text = ""
            Case 97
                TextBox3.Text = ""
            Case 98
                TextBox3.Text = ""
            Case 99
                TextBox3.Text = ""
            Case 100
                TextBox3.Text = ""
            Case 101
                TextBox3.Text = ""
            Case 102
                TextBox3.Text = ""
            Case 103
                TextBox3.Text = ""
            Case 104
                TextBox3.Text = ""
            Case 105
                TextBox3.Text = ""
            Case 106
                TextBox3.Text = "Multiply"
            Case 107
                TextBox3.Text = "Choose another"
            Case 108
                TextBox3.Text = "Choose another"
            Case 109
                TextBox3.Text = "Choose another"
            Case 110
                TextBox3.Text = "Choose another"
            Case 111
                TextBox3.Text = "Divide"
            Case 112
                TextBox3.Text = "Choose another"
            Case 113
                TextBox3.Text = "Choose another"
            Case 114
                TextBox3.Text = "F3"
            Case 115
                TextBox3.Text = "F4"
            Case 116
                TextBox3.Text = "F5"
            Case 117
                TextBox3.Text = "F6"
            Case 118
                TextBox3.Text = "F7"
            Case 119
                TextBox3.Text = "F8"
            Case 120
                TextBox3.Text = "F9"
            Case 121
                TextBox3.Text = "Choose another"
            Case 122
                TextBox3.Text = "Choose another"
            Case 123
                TextBox3.Text = "Choose another"

            Case 144
                TextBox3.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave

        TextBox3.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox4_Enter(sender As Object, e As EventArgs) Handles TextBox4.Enter

        TextBox4.BackColor = System.Drawing.Color.Yellow
        TextBox4.Text = "Press a Key"


    End Sub

    Private Sub Textbox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox4.Text = "Left mouse button"
            Case 2
                TextBox4.Text = "Right mouse button"
            Case 3
                TextBox4.Text = "Cancel"
            Case 4
                TextBox4.Text = "Middle mouse button"
            Case 8
                TextBox4.Text = "Backspace"
            Case 9
                TextBox4.Text = "Tab"
            Case 12
                TextBox4.Text = "Clear"
            Case 13
                TextBox4.Text = "Enter"
            Case 16
                TextBox4.Text = "Shift"
            Case 17
                TextBox4.Text = "Ctrl"
            Case 18
                TextBox4.Text = "Menu"
            Case 19
                TextBox4.Text = "Pause"
            Case 20
                TextBox4.Text = "Choose another"
            Case 27
                TextBox4.Text = "Choose another"
            Case 32
                TextBox4.Text = "Choose another"
            Case 33
                TextBox4.Text = "PageUp"
            Case 34
                TextBox4.Text = "PageDown"
            Case 35
                TextBox4.Text = "End"
            Case 36
                TextBox4.Text = "Home"

            Case 45
                TextBox4.Text = "Insert"
            Case 46
                TextBox4.Text = "Delete"
            Case 47
                TextBox4.Text = "HELP"
            Case 48
                TextBox4.Text = ""
            Case 49
                TextBox4.Text = ""
            Case 50
                TextBox4.Text = ""
            Case 51
                TextBox4.Text = ""
            Case 52
                TextBox4.Text = ""
            Case 53
                TextBox4.Text = ""
            Case 54
                TextBox4.Text = ""
            Case 55
                TextBox4.Text = ""
            Case 56
                TextBox4.Text = ""
            Case 57
                TextBox4.Text = ""
            Case 65
                TextBox4.Text = "A"
            Case 66
                TextBox4.Text = "B"
            Case 67
                TextBox4.Text = "C"
            Case 68
                TextBox4.Text = "D"
            Case 69
                TextBox4.Text = "E"
            Case 70
                TextBox4.Text = "F"
            Case 71
                TextBox4.Text = "G"
            Case 72
                TextBox4.Text = "H"
            Case 73
                TextBox4.Text = "I"
            Case 74
                TextBox4.Text = "J"
            Case 75
                TextBox4.Text = "K"
            Case 76
                TextBox4.Text = "L"
            Case 77
                TextBox4.Text = "M"
            Case 78
                TextBox4.Text = "N"
            Case 79
                TextBox4.Text = "O"
            Case 80
                TextBox4.Text = "P"
            Case 81
                TextBox4.Text = "Q"
            Case 82
                TextBox4.Text = "R"
            Case 83
                TextBox4.Text = "S"
            Case 84
                TextBox4.Text = "T"
            Case 85
                TextBox4.Text = "U"
            Case 86
                TextBox4.Text = "V"
            Case 87
                TextBox4.Text = "W"
            Case 88
                TextBox4.Text = "X"
            Case 89
                TextBox4.Text = "Y"
            Case 90
                TextBox4.Text = "Z"
            Case 96
                TextBox4.Text = ""
            Case 97
                TextBox4.Text = ""
            Case 98
                TextBox4.Text = ""
            Case 99
                TextBox4.Text = ""
            Case 100
                TextBox4.Text = ""
            Case 101
                TextBox4.Text = ""
            Case 102
                TextBox4.Text = ""
            Case 103
                TextBox4.Text = ""
            Case 104
                TextBox4.Text = ""
            Case 105
                TextBox4.Text = ""
            Case 106
                TextBox4.Text = "Multiply"
            Case 107
                TextBox4.Text = "Choose another"
            Case 108
                TextBox4.Text = "Choose another"
            Case 109
                TextBox4.Text = "Choose another"
            Case 110
                TextBox4.Text = "Choose another"
            Case 111
                TextBox4.Text = "Divide"
            Case 112
                TextBox4.Text = "Choose another"
            Case 113
                TextBox4.Text = "Choose another"
            Case 114
                TextBox4.Text = "F3"
            Case 115
                TextBox4.Text = "F4"
            Case 116
                TextBox4.Text = "F5"
            Case 117
                TextBox4.Text = "F6"
            Case 118
                TextBox4.Text = "F7"
            Case 119
                TextBox4.Text = "F8"
            Case 120
                TextBox4.Text = "F9"
            Case 121
                TextBox4.Text = "Choose another"
            Case 122
                TextBox4.Text = "Choose another"
            Case 123
                TextBox4.Text = "Choose another"

            Case 144
                TextBox4.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave

        TextBox4.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox5_Enter(sender As Object, e As EventArgs) Handles TextBox5.Enter

        TextBox5.BackColor = System.Drawing.Color.Yellow
        TextBox5.Text = "Press a Key"


    End Sub

    Private Sub Textbox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox5.Text = "Left mouse button"
            Case 2
                TextBox5.Text = "Right mouse button"
            Case 3
                TextBox5.Text = "Cancel"
            Case 4
                TextBox5.Text = "Middle mouse button"
            Case 8
                TextBox5.Text = "Backspace"
            Case 9
                TextBox5.Text = "Tab"
            Case 12
                TextBox5.Text = "Clear"
            Case 13
                TextBox5.Text = "Enter"
            Case 16
                TextBox5.Text = "Shift"
            Case 17
                TextBox5.Text = "Ctrl"
            Case 18
                TextBox5.Text = "Menu"
            Case 19
                TextBox5.Text = "Pause"
            Case 20
                TextBox5.Text = "Choose another"
            Case 27
                TextBox5.Text = "Choose another"
            Case 32
                TextBox5.Text = "Choose another"
            Case 33
                TextBox5.Text = "PageUp"
            Case 34
                TextBox5.Text = "PageDown"
            Case 35
                TextBox5.Text = "End"
            Case 36
                TextBox5.Text = "Home"

            Case 45
                TextBox5.Text = "Insert"
            Case 46
                TextBox5.Text = "Delete"
            Case 47
                TextBox5.Text = "HELP"
            Case 48
                TextBox5.Text = ""
            Case 49
                TextBox5.Text = ""
            Case 50
                TextBox5.Text = ""
            Case 51
                TextBox5.Text = ""
            Case 52
                TextBox5.Text = ""
            Case 53
                TextBox5.Text = ""
            Case 54
                TextBox5.Text = ""
            Case 55
                TextBox5.Text = ""
            Case 56
                TextBox5.Text = ""
            Case 57
                TextBox5.Text = ""
            Case 65
                TextBox5.Text = "A"
            Case 66
                TextBox5.Text = "B"
            Case 67
                TextBox5.Text = "C"
            Case 68
                TextBox5.Text = "D"
            Case 69
                TextBox5.Text = "E"
            Case 70
                TextBox5.Text = "F"
            Case 71
                TextBox5.Text = "G"
            Case 72
                TextBox5.Text = "H"
            Case 73
                TextBox5.Text = "I"
            Case 74
                TextBox5.Text = "J"
            Case 75
                TextBox5.Text = "K"
            Case 76
                TextBox5.Text = "L"
            Case 77
                TextBox5.Text = "M"
            Case 78
                TextBox5.Text = "N"
            Case 79
                TextBox5.Text = "O"
            Case 80
                TextBox5.Text = "P"
            Case 81
                TextBox5.Text = "Q"
            Case 82
                TextBox5.Text = "R"
            Case 83
                TextBox5.Text = "S"
            Case 84
                TextBox5.Text = "T"
            Case 85
                TextBox5.Text = "U"
            Case 86
                TextBox5.Text = "V"
            Case 87
                TextBox5.Text = "W"
            Case 88
                TextBox5.Text = "X"
            Case 89
                TextBox5.Text = "Y"
            Case 90
                TextBox5.Text = "Z"
            Case 96
                TextBox5.Text = ""
            Case 97
                TextBox5.Text = ""
            Case 98
                TextBox5.Text = ""
            Case 99
                TextBox5.Text = ""
            Case 100
                TextBox5.Text = ""
            Case 101
                TextBox5.Text = ""
            Case 102
                TextBox5.Text = ""
            Case 103
                TextBox5.Text = ""
            Case 104
                TextBox5.Text = ""
            Case 105
                TextBox5.Text = ""
            Case 106
                TextBox5.Text = "Multiply"
            Case 107
                TextBox5.Text = "Choose another"
            Case 108
                TextBox5.Text = "Choose another"
            Case 109
                TextBox5.Text = "Choose another"
            Case 110
                TextBox5.Text = "Choose another"
            Case 111
                TextBox5.Text = "Divide"
            Case 112
                TextBox5.Text = "Choose another"
            Case 113
                TextBox5.Text = "Choose another"
            Case 114
                TextBox5.Text = "F3"
            Case 115
                TextBox5.Text = "F4"
            Case 116
                TextBox5.Text = "F5"
            Case 117
                TextBox5.Text = "F6"
            Case 118
                TextBox5.Text = "F7"
            Case 119
                TextBox5.Text = "F8"
            Case 120
                TextBox5.Text = "F9"
            Case 121
                TextBox5.Text = "Choose another"
            Case 122
                TextBox5.Text = "Choose another"
            Case 123
                TextBox5.Text = "Choose another"

            Case 144
                TextBox5.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox5_Leave(sender As Object, e As EventArgs) Handles TextBox5.Leave

        TextBox5.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox6_Enter(sender As Object, e As EventArgs) Handles TextBox6.Enter

        TextBox6.BackColor = System.Drawing.Color.Yellow
        TextBox6.Text = "Press a Key"


    End Sub

    Private Sub Textbox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox6.Text = "Left mouse button"
            Case 2
                TextBox6.Text = "Right mouse button"
            Case 3
                TextBox6.Text = "Cancel"
            Case 4
                TextBox6.Text = "Middle mouse button"
            Case 8
                TextBox6.Text = "Backspace"
            Case 9
                TextBox6.Text = "Tab"
            Case 12
                TextBox6.Text = "Clear"
            Case 13
                TextBox6.Text = "Enter"
            Case 16
                TextBox6.Text = "Shift"
            Case 17
                TextBox6.Text = "Ctrl"
            Case 18
                TextBox6.Text = "Menu"
            Case 19
                TextBox6.Text = "Pause"
            Case 20
                TextBox6.Text = "Choose another"
            Case 27
                TextBox6.Text = "Choose another"
            Case 32
                TextBox6.Text = "Choose another"
            Case 33
                TextBox6.Text = "PageUp"
            Case 34
                TextBox6.Text = "PageDown"
            Case 35
                TextBox6.Text = "End"
            Case 36
                TextBox6.Text = "Home"

            Case 45
                TextBox6.Text = "Insert"
            Case 46
                TextBox6.Text = "Delete"
            Case 47
                TextBox6.Text = "HELP"
            Case 48
                TextBox6.Text = ""
            Case 49
                TextBox6.Text = ""
            Case 50
                TextBox6.Text = ""
            Case 51
                TextBox6.Text = ""
            Case 52
                TextBox6.Text = ""
            Case 53
                TextBox6.Text = ""
            Case 54
                TextBox6.Text = ""
            Case 55
                TextBox6.Text = ""
            Case 56
                TextBox6.Text = ""
            Case 57
                TextBox6.Text = ""
            Case 65
                TextBox6.Text = "A"
            Case 66
                TextBox6.Text = "B"
            Case 67
                TextBox6.Text = "C"
            Case 68
                TextBox6.Text = "D"
            Case 69
                TextBox6.Text = "E"
            Case 70
                TextBox6.Text = "F"
            Case 71
                TextBox6.Text = "G"
            Case 72
                TextBox6.Text = "H"
            Case 73
                TextBox6.Text = "I"
            Case 74
                TextBox6.Text = "J"
            Case 75
                TextBox6.Text = "K"
            Case 76
                TextBox6.Text = "L"
            Case 77
                TextBox6.Text = "M"
            Case 78
                TextBox6.Text = "N"
            Case 79
                TextBox6.Text = "O"
            Case 80
                TextBox6.Text = "P"
            Case 81
                TextBox6.Text = "Q"
            Case 82
                TextBox6.Text = "R"
            Case 83
                TextBox6.Text = "S"
            Case 84
                TextBox6.Text = "T"
            Case 85
                TextBox6.Text = "U"
            Case 86
                TextBox6.Text = "V"
            Case 87
                TextBox6.Text = "W"
            Case 88
                TextBox6.Text = "X"
            Case 89
                TextBox6.Text = "Y"
            Case 90
                TextBox6.Text = "Z"
            Case 96
                TextBox6.Text = ""
            Case 97
                TextBox6.Text = ""
            Case 98
                TextBox6.Text = ""
            Case 99
                TextBox6.Text = ""
            Case 100
                TextBox6.Text = ""
            Case 101
                TextBox6.Text = ""
            Case 102
                TextBox6.Text = ""
            Case 103
                TextBox6.Text = ""
            Case 104
                TextBox6.Text = ""
            Case 105
                TextBox6.Text = ""
            Case 106
                TextBox6.Text = "Multiply"
            Case 107
                TextBox6.Text = "Choose another"
            Case 108
                TextBox6.Text = "Choose another"
            Case 109
                TextBox6.Text = "Choose another"
            Case 110
                TextBox6.Text = "Choose another"
            Case 111
                TextBox6.Text = "Divide"
            Case 112
                TextBox6.Text = "Choose another"
            Case 113
                TextBox6.Text = "Choose another"
            Case 114
                TextBox6.Text = "F3"
            Case 115
                TextBox6.Text = "F4"
            Case 116
                TextBox6.Text = "F5"
            Case 117
                TextBox6.Text = "F6"
            Case 118
                TextBox6.Text = "F7"
            Case 119
                TextBox6.Text = "F8"
            Case 120
                TextBox6.Text = "F9"
            Case 121
                TextBox6.Text = "Choose another"
            Case 122
                TextBox6.Text = "Choose another"
            Case 123
                TextBox6.Text = "Choose another"

            Case 144
                TextBox6.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave

        TextBox6.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox7_Enter(sender As Object, e As EventArgs) Handles TextBox7.Enter

        TextBox7.BackColor = System.Drawing.Color.Yellow
        TextBox7.Text = "Press a Key"


    End Sub

    Private Sub Textbox7_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox7.Text = "Left mouse button"
            Case 2
                TextBox7.Text = "Right mouse button"
            Case 3
                TextBox7.Text = "Cancel"
            Case 4
                TextBox7.Text = "Middle mouse button"
            Case 8
                TextBox7.Text = "Backspace"
            Case 9
                TextBox7.Text = "Tab"
            Case 12
                TextBox7.Text = "Clear"
            Case 13
                TextBox7.Text = "Enter"
            Case 16
                TextBox7.Text = "Shift"
            Case 17
                TextBox7.Text = "Ctrl"
            Case 18
                TextBox7.Text = "Menu"
            Case 19
                TextBox7.Text = "Pause"
            Case 20
                TextBox7.Text = "Choose another"
            Case 27
                TextBox7.Text = "Choose another"
            Case 32
                TextBox7.Text = "Choose another"
            Case 33
                TextBox7.Text = "PageUp"
            Case 34
                TextBox7.Text = "PageDown"
            Case 35
                TextBox7.Text = "End"
            Case 36
                TextBox7.Text = "Home"

            Case 45
                TextBox7.Text = "Insert"
            Case 46
                TextBox7.Text = "Delete"
            Case 47
                TextBox7.Text = "HELP"
            Case 48
                TextBox7.Text = ""
            Case 49
                TextBox7.Text = ""
            Case 50
                TextBox7.Text = ""
            Case 51
                TextBox7.Text = ""
            Case 52
                TextBox7.Text = ""
            Case 53
                TextBox7.Text = ""
            Case 54
                TextBox7.Text = ""
            Case 55
                TextBox7.Text = ""
            Case 56
                TextBox7.Text = ""
            Case 57
                TextBox7.Text = ""
            Case 65
                TextBox7.Text = "A"
            Case 66
                TextBox7.Text = "B"
            Case 67
                TextBox7.Text = "C"
            Case 68
                TextBox7.Text = "D"
            Case 69
                TextBox7.Text = "E"
            Case 70
                TextBox7.Text = "F"
            Case 71
                TextBox7.Text = "G"
            Case 72
                TextBox7.Text = "H"
            Case 73
                TextBox7.Text = "I"
            Case 74
                TextBox7.Text = "J"
            Case 75
                TextBox7.Text = "K"
            Case 76
                TextBox7.Text = "L"
            Case 77
                TextBox7.Text = "M"
            Case 78
                TextBox7.Text = "N"
            Case 79
                TextBox7.Text = "O"
            Case 80
                TextBox7.Text = "P"
            Case 81
                TextBox7.Text = "Q"
            Case 82
                TextBox7.Text = "R"
            Case 83
                TextBox7.Text = "S"
            Case 84
                TextBox7.Text = "T"
            Case 85
                TextBox7.Text = "U"
            Case 86
                TextBox7.Text = "V"
            Case 87
                TextBox7.Text = "W"
            Case 88
                TextBox7.Text = "X"
            Case 89
                TextBox7.Text = "Y"
            Case 90
                TextBox7.Text = "Z"
            Case 96
                TextBox7.Text = ""
            Case 97
                TextBox7.Text = ""
            Case 98
                TextBox7.Text = ""
            Case 99
                TextBox7.Text = ""
            Case 100
                TextBox7.Text = ""
            Case 101
                TextBox7.Text = ""
            Case 102
                TextBox7.Text = ""
            Case 103
                TextBox7.Text = ""
            Case 104
                TextBox7.Text = ""
            Case 105
                TextBox7.Text = ""
            Case 106
                TextBox7.Text = "Multiply"
            Case 107
                TextBox7.Text = "Choose another"
            Case 108
                TextBox7.Text = "Choose another"
            Case 109
                TextBox7.Text = "Choose another"
            Case 110
                TextBox7.Text = "Choose another"
            Case 111
                TextBox7.Text = "Divide"
            Case 112
                TextBox7.Text = "Choose another"
            Case 113
                TextBox7.Text = "Choose another"
            Case 114
                TextBox7.Text = "F3"
            Case 115
                TextBox7.Text = "F4"
            Case 116
                TextBox7.Text = "F5"
            Case 117
                TextBox7.Text = "F6"
            Case 118
                TextBox7.Text = "F7"
            Case 119
                TextBox7.Text = "F8"
            Case 120
                TextBox7.Text = "F9"
            Case 121
                TextBox7.Text = "Choose another"
            Case 122
                TextBox7.Text = "Choose another"
            Case 123
                TextBox7.Text = "Choose another"

            Case 144
                TextBox7.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox7_Leave(sender As Object, e As EventArgs) Handles TextBox7.Leave

        TextBox7.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox8_Enter(sender As Object, e As EventArgs) Handles TextBox8.Enter

        TextBox8.BackColor = System.Drawing.Color.Yellow
        TextBox8.Text = "Press a Key"


    End Sub

    Private Sub Textbox8_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox8.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox8.Text = "Left mouse button"
            Case 2
                TextBox8.Text = "Right mouse button"
            Case 3
                TextBox8.Text = "Cancel"
            Case 4
                TextBox8.Text = "Middle mouse button"
            Case 8
                TextBox8.Text = "Backspace"
            Case 9
                TextBox8.Text = "Tab"
            Case 12
                TextBox8.Text = "Clear"
            Case 13
                TextBox8.Text = "Enter"
            Case 16
                TextBox8.Text = "Shift"
            Case 17
                TextBox8.Text = "Ctrl"
            Case 18
                TextBox8.Text = "Menu"
            Case 19
                TextBox8.Text = "Pause"
            Case 20
                TextBox8.Text = "Choose another"
            Case 27
                TextBox8.Text = "Choose another"
            Case 32
                TextBox8.Text = "Choose another"
            Case 33
                TextBox8.Text = "PageUp"
            Case 34
                TextBox8.Text = "PageDown"
            Case 35
                TextBox8.Text = "End"
            Case 36
                TextBox8.Text = "Home"

            Case 45
                TextBox8.Text = "Insert"
            Case 46
                TextBox8.Text = "Delete"
            Case 47
                TextBox8.Text = "HELP"
            Case 48
                TextBox8.Text = ""
            Case 49
                TextBox8.Text = ""
            Case 50
                TextBox8.Text = ""
            Case 51
                TextBox8.Text = ""
            Case 52
                TextBox8.Text = ""
            Case 53
                TextBox8.Text = ""
            Case 54
                TextBox8.Text = ""
            Case 55
                TextBox8.Text = ""
            Case 56
                TextBox8.Text = ""
            Case 57
                TextBox8.Text = ""
            Case 65
                TextBox8.Text = "A"
            Case 66
                TextBox8.Text = "B"
            Case 67
                TextBox8.Text = "C"
            Case 68
                TextBox8.Text = "D"
            Case 69
                TextBox8.Text = "E"
            Case 70
                TextBox8.Text = "F"
            Case 71
                TextBox8.Text = "G"
            Case 72
                TextBox8.Text = "H"
            Case 73
                TextBox8.Text = "I"
            Case 74
                TextBox8.Text = "J"
            Case 75
                TextBox8.Text = "K"
            Case 76
                TextBox8.Text = "L"
            Case 77
                TextBox8.Text = "M"
            Case 78
                TextBox8.Text = "N"
            Case 79
                TextBox8.Text = "O"
            Case 80
                TextBox8.Text = "P"
            Case 81
                TextBox8.Text = "Q"
            Case 82
                TextBox8.Text = "R"
            Case 83
                TextBox8.Text = "S"
            Case 84
                TextBox8.Text = "T"
            Case 85
                TextBox8.Text = "U"
            Case 86
                TextBox8.Text = "V"
            Case 87
                TextBox8.Text = "W"
            Case 88
                TextBox8.Text = "X"
            Case 89
                TextBox8.Text = "Y"
            Case 90
                TextBox8.Text = "Z"
            Case 96
                TextBox8.Text = ""
            Case 97
                TextBox8.Text = ""
            Case 98
                TextBox8.Text = ""
            Case 99
                TextBox8.Text = ""
            Case 100
                TextBox8.Text = ""
            Case 101
                TextBox8.Text = ""
            Case 102
                TextBox8.Text = ""
            Case 103
                TextBox8.Text = ""
            Case 104
                TextBox8.Text = ""
            Case 105
                TextBox8.Text = ""
            Case 106
                TextBox8.Text = "Multiply"
            Case 107
                TextBox8.Text = "Choose another"
            Case 108
                TextBox8.Text = "Choose another"
            Case 109
                TextBox8.Text = "Choose another"
            Case 110
                TextBox8.Text = "Choose another"
            Case 111
                TextBox8.Text = "Divide"
            Case 112
                TextBox8.Text = "Choose another"
            Case 113
                TextBox8.Text = "Choose another"
            Case 114
                TextBox8.Text = "F3"
            Case 115
                TextBox8.Text = "F4"
            Case 116
                TextBox8.Text = "F5"
            Case 117
                TextBox8.Text = "F6"
            Case 118
                TextBox8.Text = "F7"
            Case 119
                TextBox8.Text = "F8"
            Case 120
                TextBox8.Text = "F9"
            Case 121
                TextBox8.Text = "Choose another"
            Case 122
                TextBox8.Text = "Choose another"
            Case 123
                TextBox8.Text = "Choose another"

            Case 144
                TextBox8.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox8_Leave(sender As Object, e As EventArgs) Handles TextBox8.Leave

        TextBox8.BackColor = System.Drawing.Color.White

    End Sub


    Private Sub Textbox9_Enter(sender As Object, e As EventArgs) Handles TextBox9.Enter

        TextBox9.BackColor = System.Drawing.Color.Yellow
        TextBox9.Text = "Press a Key"


    End Sub

    Private Sub Textbox9_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox9.Text = "Left mouse button"
            Case 2
                TextBox9.Text = "Right mouse button"
            Case 3
                TextBox9.Text = "Cancel"
            Case 4
                TextBox9.Text = "Middle mouse button"
            Case 8
                TextBox9.Text = "Backspace"
            Case 9
                TextBox9.Text = "Tab"
            Case 12
                TextBox9.Text = "Clear"
            Case 13
                TextBox9.Text = "Enter"
            Case 16
                TextBox9.Text = "Shift"
            Case 17
                TextBox9.Text = "Ctrl"
            Case 18
                TextBox9.Text = "Menu"
            Case 19
                TextBox9.Text = "Pause"
            Case 20
                TextBox9.Text = "Choose another"
            Case 27
                TextBox9.Text = "Choose another"
            Case 32
                TextBox9.Text = "Choose another"
            Case 33
                TextBox9.Text = "PageUp"
            Case 34
                TextBox9.Text = "PageDown"
            Case 35
                TextBox9.Text = "End"
            Case 36
                TextBox9.Text = "Home"

            Case 45
                TextBox9.Text = "Insert"
            Case 46
                TextBox9.Text = "Delete"
            Case 47
                TextBox9.Text = "HELP"
            Case 48
                TextBox9.Text = ""
            Case 49
                TextBox9.Text = ""
            Case 50
                TextBox9.Text = ""
            Case 51
                TextBox9.Text = ""
            Case 52
                TextBox9.Text = ""
            Case 53
                TextBox9.Text = ""
            Case 54
                TextBox9.Text = ""
            Case 55
                TextBox9.Text = ""
            Case 56
                TextBox9.Text = ""
            Case 57
                TextBox9.Text = ""
            Case 65
                TextBox9.Text = "A"
            Case 66
                TextBox9.Text = "B"
            Case 67
                TextBox9.Text = "C"
            Case 68
                TextBox9.Text = "D"
            Case 69
                TextBox9.Text = "E"
            Case 70
                TextBox9.Text = "F"
            Case 71
                TextBox9.Text = "G"
            Case 72
                TextBox9.Text = "H"
            Case 73
                TextBox9.Text = "I"
            Case 74
                TextBox9.Text = "J"
            Case 75
                TextBox9.Text = "K"
            Case 76
                TextBox9.Text = "L"
            Case 77
                TextBox9.Text = "M"
            Case 78
                TextBox9.Text = "N"
            Case 79
                TextBox9.Text = "O"
            Case 80
                TextBox9.Text = "P"
            Case 81
                TextBox9.Text = "Q"
            Case 82
                TextBox9.Text = "R"
            Case 83
                TextBox9.Text = "S"
            Case 84
                TextBox9.Text = "T"
            Case 85
                TextBox9.Text = "U"
            Case 86
                TextBox9.Text = "V"
            Case 87
                TextBox9.Text = "W"
            Case 88
                TextBox9.Text = "X"
            Case 89
                TextBox9.Text = "Y"
            Case 90
                TextBox9.Text = "Z"
            Case 96
                TextBox9.Text = ""
            Case 97
                TextBox9.Text = ""
            Case 98
                TextBox9.Text = ""
            Case 99
                TextBox9.Text = ""
            Case 100
                TextBox9.Text = ""
            Case 101
                TextBox9.Text = ""
            Case 102
                TextBox9.Text = ""
            Case 103
                TextBox9.Text = ""
            Case 104
                TextBox9.Text = ""
            Case 105
                TextBox9.Text = ""
            Case 106
                TextBox9.Text = "Multiply"
            Case 107
                TextBox9.Text = "Choose another"
            Case 108
                TextBox9.Text = "Choose another"
            Case 109
                TextBox9.Text = "Choose another"
            Case 110
                TextBox9.Text = "Choose another"
            Case 111
                TextBox9.Text = "Divide"
            Case 112
                TextBox9.Text = "Choose another"
            Case 113
                TextBox9.Text = "Choose another"
            Case 114
                TextBox9.Text = "F3"
            Case 115
                TextBox9.Text = "F4"
            Case 116
                TextBox9.Text = "F5"
            Case 117
                TextBox9.Text = "F6"
            Case 118
                TextBox9.Text = "F7"
            Case 119
                TextBox9.Text = "F8"
            Case 120
                TextBox9.Text = "F9"
            Case 121
                TextBox9.Text = "Choose another"
            Case 122
                TextBox9.Text = "Choose another"
            Case 123
                TextBox9.Text = "Choose another"

            Case 144
                TextBox9.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox9_Leave(sender As Object, e As EventArgs) Handles TextBox9.Leave

        TextBox9.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox10_Enter(sender As Object, e As EventArgs) Handles TextBox10.Enter

        TextBox10.BackColor = System.Drawing.Color.Yellow
        TextBox10.Text = "Press a Key"


    End Sub

    Private Sub Textbox10_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox10.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox10.Text = "Left mouse button"
            Case 2
                TextBox10.Text = "Right mouse button"
            Case 3
                TextBox10.Text = "Cancel"
            Case 4
                TextBox10.Text = "Middle mouse button"
            Case 8
                TextBox10.Text = "Backspace"
            Case 9
                TextBox10.Text = "Tab"
            Case 12
                TextBox10.Text = "Clear"
            Case 13
                TextBox10.Text = "Enter"
            Case 16
                TextBox10.Text = "Shift"
            Case 17
                TextBox10.Text = "Ctrl"
            Case 18
                TextBox10.Text = "Menu"
            Case 19
                TextBox10.Text = "Pause"
            Case 20
                TextBox10.Text = "Choose another"
            Case 27
                TextBox10.Text = "Choose another"
            Case 32
                TextBox10.Text = "Choose another"
            Case 33
                TextBox10.Text = "PageUp"
            Case 34
                TextBox10.Text = "PageDown"
            Case 35
                TextBox10.Text = "End"
            Case 36
                TextBox10.Text = "Home"

            Case 45
                TextBox10.Text = "Insert"
            Case 46
                TextBox10.Text = "Delete"
            Case 47
                TextBox10.Text = "HELP"
            Case 48
                TextBox10.Text = ""
            Case 49
                TextBox10.Text = ""
            Case 50
                TextBox10.Text = ""
            Case 51
                TextBox10.Text = ""
            Case 52
                TextBox10.Text = ""
            Case 53
                TextBox10.Text = ""
            Case 54
                TextBox10.Text = ""
            Case 55
                TextBox10.Text = ""
            Case 56
                TextBox10.Text = ""
            Case 57
                TextBox10.Text = ""
            Case 65
                TextBox10.Text = "A"
            Case 66
                TextBox10.Text = "B"
            Case 67
                TextBox10.Text = "C"
            Case 68
                TextBox10.Text = "D"
            Case 69
                TextBox10.Text = "E"
            Case 70
                TextBox10.Text = "F"
            Case 71
                TextBox10.Text = "G"
            Case 72
                TextBox10.Text = "H"
            Case 73
                TextBox10.Text = "I"
            Case 74
                TextBox10.Text = "J"
            Case 75
                TextBox10.Text = "K"
            Case 76
                TextBox10.Text = "L"
            Case 77
                TextBox10.Text = "M"
            Case 78
                TextBox10.Text = "N"
            Case 79
                TextBox10.Text = "O"
            Case 80
                TextBox10.Text = "P"
            Case 81
                TextBox10.Text = "Q"
            Case 82
                TextBox10.Text = "R"
            Case 83
                TextBox10.Text = "S"
            Case 84
                TextBox10.Text = "T"
            Case 85
                TextBox10.Text = "U"
            Case 86
                TextBox10.Text = "V"
            Case 87
                TextBox10.Text = "W"
            Case 88
                TextBox10.Text = "X"
            Case 89
                TextBox10.Text = "Y"
            Case 90
                TextBox10.Text = "Z"
            Case 96
                TextBox10.Text = ""
            Case 97
                TextBox10.Text = ""
            Case 98
                TextBox10.Text = ""
            Case 99
                TextBox10.Text = ""
            Case 100
                TextBox10.Text = ""
            Case 101
                TextBox10.Text = ""
            Case 102
                TextBox10.Text = ""
            Case 103
                TextBox10.Text = ""
            Case 104
                TextBox10.Text = ""
            Case 105
                TextBox10.Text = ""
            Case 106
                TextBox10.Text = "Multiply"
            Case 107
                TextBox10.Text = "Choose another"
            Case 108
                TextBox10.Text = "Choose another"
            Case 109
                TextBox10.Text = "Choose another"
            Case 110
                TextBox10.Text = "Choose another"
            Case 111
                TextBox10.Text = "Divide"
            Case 112
                TextBox10.Text = "Choose another"
            Case 113
                TextBox10.Text = "Choose another"
            Case 114
                TextBox10.Text = "F3"
            Case 115
                TextBox10.Text = "F4"
            Case 116
                TextBox10.Text = "F5"
            Case 117
                TextBox10.Text = "F6"
            Case 118
                TextBox10.Text = "F7"
            Case 119
                TextBox10.Text = "F8"
            Case 120
                TextBox10.Text = "F9"
            Case 121
                TextBox10.Text = "Choose another"
            Case 122
                TextBox10.Text = "Choose another"
            Case 123
                TextBox10.Text = "Choose another"

            Case 144
                TextBox10.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox10_Leave(sender As Object, e As EventArgs) Handles TextBox10.Leave

        TextBox10.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox11_Enter(sender As Object, e As EventArgs) Handles TextBox11.Enter

        TextBox11.BackColor = System.Drawing.Color.Yellow
        TextBox11.Text = "Press a Key"


    End Sub

    Private Sub Textbox11_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox11.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox11.Text = "Left mouse button"
            Case 2
                TextBox11.Text = "Right mouse button"
            Case 3
                TextBox11.Text = "Cancel"
            Case 4
                TextBox11.Text = "Middle mouse button"
            Case 8
                TextBox11.Text = "Backspace"
            Case 9
                TextBox11.Text = "Tab"
            Case 12
                TextBox11.Text = "Clear"
            Case 13
                TextBox11.Text = "Enter"
            Case 16
                TextBox11.Text = "Shift"
            Case 17
                TextBox11.Text = "Ctrl"
            Case 18
                TextBox11.Text = "Menu"
            Case 19
                TextBox11.Text = "Pause"
            Case 20
                TextBox11.Text = "Choose another"
            Case 27
                TextBox11.Text = "Choose another"
            Case 32
                TextBox11.Text = "Choose another"
            Case 33
                TextBox11.Text = "PageUp"
            Case 34
                TextBox11.Text = "PageDown"
            Case 35
                TextBox11.Text = "End"
            Case 36
                TextBox11.Text = "Home"

            Case 45
                TextBox11.Text = "Insert"
            Case 46
                TextBox11.Text = "Delete"
            Case 47
                TextBox11.Text = "HELP"
            Case 48
                TextBox11.Text = ""
            Case 49
                TextBox11.Text = ""
            Case 50
                TextBox11.Text = ""
            Case 51
                TextBox11.Text = ""
            Case 52
                TextBox11.Text = ""
            Case 53
                TextBox11.Text = ""
            Case 54
                TextBox11.Text = ""
            Case 55
                TextBox11.Text = ""
            Case 56
                TextBox11.Text = ""
            Case 57
                TextBox11.Text = ""
            Case 65
                TextBox11.Text = "A"
            Case 66
                TextBox11.Text = "B"
            Case 67
                TextBox11.Text = "C"
            Case 68
                TextBox11.Text = "D"
            Case 69
                TextBox11.Text = "E"
            Case 70
                TextBox11.Text = "F"
            Case 71
                TextBox11.Text = "G"
            Case 72
                TextBox11.Text = "H"
            Case 73
                TextBox11.Text = "I"
            Case 74
                TextBox11.Text = "J"
            Case 75
                TextBox11.Text = "K"
            Case 76
                TextBox11.Text = "L"
            Case 77
                TextBox11.Text = "M"
            Case 78
                TextBox11.Text = "N"
            Case 79
                TextBox11.Text = "O"
            Case 80
                TextBox11.Text = "P"
            Case 81
                TextBox11.Text = "Q"
            Case 82
                TextBox11.Text = "R"
            Case 83
                TextBox11.Text = "S"
            Case 84
                TextBox11.Text = "T"
            Case 85
                TextBox11.Text = "U"
            Case 86
                TextBox11.Text = "V"
            Case 87
                TextBox11.Text = "W"
            Case 88
                TextBox11.Text = "X"
            Case 89
                TextBox11.Text = "Y"
            Case 90
                TextBox11.Text = "Z"
            Case 96
                TextBox11.Text = ""
            Case 97
                TextBox11.Text = ""
            Case 98
                TextBox11.Text = ""
            Case 99
                TextBox11.Text = ""
            Case 100
                TextBox11.Text = ""
            Case 101
                TextBox11.Text = ""
            Case 102
                TextBox11.Text = ""
            Case 103
                TextBox11.Text = ""
            Case 104
                TextBox11.Text = ""
            Case 105
                TextBox11.Text = ""
            Case 106
                TextBox11.Text = "Multiply"
            Case 107
                TextBox11.Text = "Choose another"
            Case 108
                TextBox11.Text = "Choose another"
            Case 109
                TextBox11.Text = "Choose another"
            Case 110
                TextBox11.Text = "Choose another"
            Case 111
                TextBox11.Text = "Divide"
            Case 112
                TextBox11.Text = "Choose another"
            Case 113
                TextBox11.Text = "Choose another"
            Case 114
                TextBox11.Text = "F3"
            Case 115
                TextBox11.Text = "F4"
            Case 116
                TextBox11.Text = "F5"
            Case 117
                TextBox11.Text = "F6"
            Case 118
                TextBox11.Text = "F7"
            Case 119
                TextBox11.Text = "F8"
            Case 120
                TextBox11.Text = "F9"
            Case 121
                TextBox11.Text = "Choose another"
            Case 122
                TextBox11.Text = "Choose another"
            Case 123
                TextBox11.Text = "Choose another"

            Case 144
                TextBox11.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox11_Leave(sender As Object, e As EventArgs) Handles TextBox11.Leave

        TextBox11.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox12_Enter(sender As Object, e As EventArgs) Handles TextBox12.Enter

        TextBox12.BackColor = System.Drawing.Color.Yellow
        TextBox12.Text = "Press a Key"


    End Sub

    Private Sub Textbox12_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox12.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox12.Text = "Left mouse button"
            Case 2
                TextBox12.Text = "Right mouse button"
            Case 3
                TextBox12.Text = "Cancel"
            Case 4
                TextBox12.Text = "Middle mouse button"
            Case 8
                TextBox12.Text = "Backspace"
            Case 9
                TextBox12.Text = "Tab"
            Case 12
                TextBox12.Text = "Clear"
            Case 13
                TextBox12.Text = "Enter"
            Case 16
                TextBox12.Text = "Shift"
            Case 17
                TextBox12.Text = "Ctrl"
            Case 18
                TextBox12.Text = "Menu"
            Case 19
                TextBox12.Text = "Pause"
            Case 20
                TextBox12.Text = "Choose another"
            Case 27
                TextBox12.Text = "Choose another"
            Case 32
                TextBox12.Text = "Choose another"
            Case 33
                TextBox12.Text = "PageUp"
            Case 34
                TextBox12.Text = "PageDown"
            Case 35
                TextBox12.Text = "End"
            Case 36
                TextBox12.Text = "Home"

            Case 45
                TextBox12.Text = "Insert"
            Case 46
                TextBox12.Text = "Delete"
            Case 47
                TextBox12.Text = "HELP"
            Case 48
                TextBox12.Text = ""
            Case 49
                TextBox12.Text = ""
            Case 50
                TextBox12.Text = ""
            Case 51
                TextBox12.Text = ""
            Case 52
                TextBox12.Text = ""
            Case 53
                TextBox12.Text = ""
            Case 54
                TextBox12.Text = ""
            Case 55
                TextBox12.Text = ""
            Case 56
                TextBox12.Text = ""
            Case 57
                TextBox12.Text = ""
            Case 65
                TextBox12.Text = "A"
            Case 66
                TextBox12.Text = "B"
            Case 67
                TextBox12.Text = "C"
            Case 68
                TextBox12.Text = "D"
            Case 69
                TextBox12.Text = "E"
            Case 70
                TextBox12.Text = "F"
            Case 71
                TextBox12.Text = "G"
            Case 72
                TextBox12.Text = "H"
            Case 73
                TextBox12.Text = "I"
            Case 74
                TextBox12.Text = "J"
            Case 75
                TextBox12.Text = "K"
            Case 76
                TextBox12.Text = "L"
            Case 77
                TextBox12.Text = "M"
            Case 78
                TextBox12.Text = "N"
            Case 79
                TextBox12.Text = "O"
            Case 80
                TextBox12.Text = "P"
            Case 81
                TextBox12.Text = "Q"
            Case 82
                TextBox12.Text = "R"
            Case 83
                TextBox12.Text = "S"
            Case 84
                TextBox12.Text = "T"
            Case 85
                TextBox12.Text = "U"
            Case 86
                TextBox12.Text = "V"
            Case 87
                TextBox12.Text = "W"
            Case 88
                TextBox12.Text = "X"
            Case 89
                TextBox12.Text = "Y"
            Case 90
                TextBox12.Text = "Z"
            Case 96
                TextBox12.Text = ""
            Case 97
                TextBox12.Text = ""
            Case 98
                TextBox12.Text = ""
            Case 99
                TextBox12.Text = ""
            Case 100
                TextBox12.Text = ""
            Case 101
                TextBox12.Text = ""
            Case 102
                TextBox12.Text = ""
            Case 103
                TextBox12.Text = ""
            Case 104
                TextBox12.Text = ""
            Case 105
                TextBox12.Text = ""
            Case 106
                TextBox12.Text = "Multiply"
            Case 107
                TextBox12.Text = "Choose another"
            Case 108
                TextBox12.Text = "Choose another"
            Case 109
                TextBox12.Text = "Choose another"
            Case 110
                TextBox12.Text = "Choose another"
            Case 111
                TextBox12.Text = "Divide"
            Case 112
                TextBox12.Text = "Choose another"
            Case 113
                TextBox12.Text = "Choose another"
            Case 114
                TextBox12.Text = "F3"
            Case 115
                TextBox12.Text = "F4"
            Case 116
                TextBox12.Text = "F5"
            Case 117
                TextBox12.Text = "F6"
            Case 118
                TextBox12.Text = "F7"
            Case 119
                TextBox12.Text = "F8"
            Case 120
                TextBox12.Text = "F9"
            Case 121
                TextBox12.Text = "Choose another"
            Case 122
                TextBox12.Text = "Choose another"
            Case 123
                TextBox12.Text = "Choose another"

            Case 144
                TextBox12.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox12_Leave(sender As Object, e As EventArgs) Handles TextBox12.Leave

        TextBox12.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox13_Enter(sender As Object, e As EventArgs) Handles TextBox13.Enter

        TextBox13.BackColor = System.Drawing.Color.Yellow
        TextBox13.Text = "Press a Key"


    End Sub


    Private Sub Textbox14_Enter(sender As Object, e As EventArgs) Handles TextBox14.Enter

        TextBox14.BackColor = System.Drawing.Color.Yellow
        TextBox14.Text = "Press a Key"


    End Sub

    Private Sub Textbox14_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox14.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox14.Text = "Left mouse button"
            Case 2
                TextBox14.Text = "Right mouse button"
            Case 3
                TextBox14.Text = "Cancel"
            Case 4
                TextBox14.Text = "Middle mouse button"
            Case 8
                TextBox14.Text = "Backspace"
            Case 9
                TextBox14.Text = "Tab"
            Case 12
                TextBox14.Text = "Clear"
            Case 13
                TextBox14.Text = "Enter"
            Case 16
                TextBox14.Text = "Shift"
            Case 17
                TextBox14.Text = "Ctrl"
            Case 18
                TextBox14.Text = "Menu"
            Case 19
                TextBox14.Text = "Pause"
            Case 20
                TextBox14.Text = "Choose another"
            Case 27
                TextBox14.Text = "Choose another"
            Case 32
                TextBox14.Text = "Choose another"
            Case 33
                TextBox14.Text = "PageUp"
            Case 34
                TextBox14.Text = "PageDown"
            Case 35
                TextBox14.Text = "End"
            Case 36
                TextBox14.Text = "Home"

            Case 45
                TextBox14.Text = "Insert"
            Case 46
                TextBox14.Text = "Delete"
            Case 47
                TextBox14.Text = "HELP"
            Case 48
                TextBox14.Text = ""
            Case 49
                TextBox14.Text = ""
            Case 50
                TextBox14.Text = ""
            Case 51
                TextBox14.Text = ""
            Case 52
                TextBox14.Text = ""
            Case 53
                TextBox14.Text = ""
            Case 54
                TextBox14.Text = ""
            Case 55
                TextBox14.Text = ""
            Case 56
                TextBox14.Text = ""
            Case 57
                TextBox14.Text = ""
            Case 65
                TextBox14.Text = "A"
            Case 66
                TextBox14.Text = "B"
            Case 67
                TextBox14.Text = "C"
            Case 68
                TextBox14.Text = "D"
            Case 69
                TextBox14.Text = "E"
            Case 70
                TextBox14.Text = "F"
            Case 71
                TextBox14.Text = "G"
            Case 72
                TextBox14.Text = "H"
            Case 73
                TextBox14.Text = "I"
            Case 74
                TextBox14.Text = "J"
            Case 75
                TextBox14.Text = "K"
            Case 76
                TextBox14.Text = "L"
            Case 77
                TextBox14.Text = "M"
            Case 78
                TextBox14.Text = "N"
            Case 79
                TextBox14.Text = "O"
            Case 80
                TextBox14.Text = "P"
            Case 81
                TextBox14.Text = "Q"
            Case 82
                TextBox14.Text = "R"
            Case 83
                TextBox14.Text = "S"
            Case 84
                TextBox14.Text = "T"
            Case 85
                TextBox14.Text = "U"
            Case 86
                TextBox14.Text = "V"
            Case 87
                TextBox14.Text = "W"
            Case 88
                TextBox14.Text = "X"
            Case 89
                TextBox14.Text = "Y"
            Case 90
                TextBox14.Text = "Z"
            Case 96
                TextBox14.Text = ""
            Case 97
                TextBox14.Text = ""
            Case 98
                TextBox14.Text = ""
            Case 99
                TextBox14.Text = ""
            Case 100
                TextBox14.Text = ""
            Case 101
                TextBox14.Text = ""
            Case 102
                TextBox14.Text = ""
            Case 103
                TextBox14.Text = ""
            Case 104
                TextBox14.Text = ""
            Case 105
                TextBox14.Text = ""
            Case 106
                TextBox14.Text = "Multiply"
            Case 107
                TextBox14.Text = "Choose another"
            Case 108
                TextBox14.Text = "Choose another"
            Case 109
                TextBox14.Text = "Choose another"
            Case 110
                TextBox14.Text = "Choose another"
            Case 111
                TextBox14.Text = "Divide"
            Case 112
                TextBox14.Text = "Choose another"
            Case 113
                TextBox14.Text = "Choose another"
            Case 114
                TextBox14.Text = "F3"
            Case 115
                TextBox14.Text = "F4"
            Case 116
                TextBox14.Text = "F5"
            Case 117
                TextBox14.Text = "F6"
            Case 118
                TextBox14.Text = "F7"
            Case 119
                TextBox14.Text = "F8"
            Case 120
                TextBox14.Text = "F9"
            Case 121
                TextBox14.Text = "Choose another"
            Case 122
                TextBox14.Text = "Choose another"
            Case 123
                TextBox14.Text = "Choose another"

            Case 144
                TextBox14.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox14_Leave(sender As Object, e As EventArgs) Handles TextBox14.Leave

        TextBox14.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Textbox15_Enter(sender As Object, e As EventArgs) Handles TextBox15.Enter

        TextBox15.BackColor = System.Drawing.Color.Yellow
        TextBox15.Text = "Press a Key"


    End Sub

    Private Sub Textbox15_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox15.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox15.Text = "Left mouse button"
            Case 2
                TextBox15.Text = "Right mouse button"
            Case 3
                TextBox15.Text = "Cancel"
            Case 4
                TextBox15.Text = "Middle mouse button"
            Case 8
                TextBox15.Text = "Backspace"
            Case 9
                TextBox15.Text = "Tab"
            Case 12
                TextBox15.Text = "Clear"
            Case 13
                TextBox15.Text = "Enter"
            Case 16
                TextBox15.Text = "Shift"
            Case 17
                TextBox15.Text = "Ctrl"
            Case 18
                TextBox15.Text = "Menu"
            Case 19
                TextBox15.Text = "Pause"
            Case 20
                TextBox15.Text = "Choose another"
            Case 27
                TextBox15.Text = "Choose another"
            Case 32
                TextBox15.Text = "Choose another"
            Case 33
                TextBox15.Text = "PageUp"
            Case 34
                TextBox15.Text = "PageDown"
            Case 35
                TextBox15.Text = "End"
            Case 36
                TextBox15.Text = "Home"

            Case 45
                TextBox15.Text = "Insert"
            Case 46
                TextBox15.Text = "Delete"
            Case 47
                TextBox15.Text = "HELP"
            Case 48
                TextBox15.Text = ""
            Case 49
                TextBox15.Text = ""
            Case 50
                TextBox15.Text = ""
            Case 51
                TextBox15.Text = ""
            Case 52
                TextBox15.Text = ""
            Case 53
                TextBox15.Text = ""
            Case 54
                TextBox15.Text = ""
            Case 55
                TextBox15.Text = ""
            Case 56
                TextBox15.Text = ""
            Case 57
                TextBox15.Text = ""
            Case 65
                TextBox15.Text = "A"
            Case 66
                TextBox15.Text = "B"
            Case 67
                TextBox15.Text = "C"
            Case 68
                TextBox15.Text = "D"
            Case 69
                TextBox15.Text = "E"
            Case 70
                TextBox15.Text = "F"
            Case 71
                TextBox15.Text = "G"
            Case 72
                TextBox15.Text = "H"
            Case 73
                TextBox15.Text = "I"
            Case 74
                TextBox15.Text = "J"
            Case 75
                TextBox15.Text = "K"
            Case 76
                TextBox15.Text = "L"
            Case 77
                TextBox15.Text = "M"
            Case 78
                TextBox15.Text = "N"
            Case 79
                TextBox15.Text = "O"
            Case 80
                TextBox15.Text = "P"
            Case 81
                TextBox15.Text = "Q"
            Case 82
                TextBox15.Text = "R"
            Case 83
                TextBox15.Text = "S"
            Case 84
                TextBox15.Text = "T"
            Case 85
                TextBox15.Text = "U"
            Case 86
                TextBox15.Text = "V"
            Case 87
                TextBox15.Text = "W"
            Case 88
                TextBox15.Text = "X"
            Case 89
                TextBox15.Text = "Y"
            Case 90
                TextBox15.Text = "Z"
            Case 96
                TextBox15.Text = ""
            Case 97
                TextBox15.Text = ""
            Case 98
                TextBox15.Text = ""
            Case 99
                TextBox15.Text = ""
            Case 100
                TextBox15.Text = ""
            Case 101
                TextBox15.Text = ""
            Case 102
                TextBox15.Text = ""
            Case 103
                TextBox15.Text = ""
            Case 104
                TextBox15.Text = ""
            Case 105
                TextBox15.Text = ""
            Case 106
                TextBox15.Text = "Multiply"
            Case 107
                TextBox15.Text = "Choose another"
            Case 108
                TextBox15.Text = "Choose another"
            Case 109
                TextBox15.Text = "Choose another"
            Case 110
                TextBox15.Text = "Choose another"
            Case 111
                TextBox15.Text = "Divide"
            Case 112
                TextBox15.Text = "Choose another"
            Case 113
                TextBox15.Text = "Choose another"
            Case 114
                TextBox15.Text = "F3"
            Case 115
                TextBox15.Text = "F4"
            Case 116
                TextBox15.Text = "F5"
            Case 117
                TextBox15.Text = "F6"
            Case 118
                TextBox15.Text = "F7"
            Case 119
                TextBox15.Text = "F8"
            Case 120
                TextBox15.Text = "F9"
            Case 121
                TextBox15.Text = "Choose another"
            Case 122
                TextBox15.Text = "Choose another"
            Case 123
                TextBox15.Text = "Choose another"

            Case 144
                TextBox15.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox15_Leave(sender As Object, e As EventArgs) Handles TextBox15.Leave

        TextBox15.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox1.Text = "S"
        TextBox2.Text = "R"
        TextBox3.Text = "C"
        TextBox4.Text = "Insert"
        TextBox5.Text = "Home"
        TextBox6.Text = "PageUp"
        TextBox7.Text = "P"
        TextBox8.Text = "O"
        TextBox9.Text = "Pause"
        TextBox10.Text = "M"
        TextBox11.Text = "Delete"
        TextBox12.Text = "End"
        TextBox13.Text = "PageDown"
        TextBox14.Text = "N"
        TextBox15.Text = "B"


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

            Form5.TextBox1.Text = opf.FileName

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        PictureBox1.Image = Nothing

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox2.Image = Image.FromFile(opf.FileName)

            Form5.TextBox2.Text = opf.FileName

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        PictureBox2.Image = Nothing

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        Dim response = MsgBox("Are you sure you want to reset all text?", vbYesNo, "SHOHO-Q BASKETBALL OPEN")

        If response = MsgBoxResult.Yes Then

            TextBox18.Text = "Period"
            TextBox19.Text = "BONUS"
            TextBox20.Text = "POSS"

        Else


        End If



    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        ColorDialog1.ShowDialog()
        TextBox22.BackColor = ColorDialog1.Color


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        ColorDialog1.ShowDialog()
        TextBox23.BackColor = ColorDialog1.Color


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        ColorDialog1.ShowDialog()
        TextBox24.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        ColorDialog1.ShowDialog()
        TextBox25.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        ColorDialog1.ShowDialog()
        TextBox26.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        ColorDialog1.ShowDialog()
        TextBox27.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        ColorDialog1.ShowDialog()
        TextBox28.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        ColorDialog1.ShowDialog()
        TextBox29.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        ColorDialog1.ShowDialog()
        TextBox30.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        Dim response = MsgBox("Are you sure you want to reset all colors?", vbYesNo, "SHOHO-Q BASKETBALL OPEN")

        If response = MsgBoxResult.Yes Then

            TextBox22.BackColor = Color.FromArgb(64, 64, 64)
            TextBox23.BackColor = Color.Black
            TextBox24.BackColor = Color.Green
            TextBox25.BackColor = Color.Orange
            TextBox26.BackColor = Color.White
            TextBox27.BackColor = Color.Red
            TextBox28.BackColor = Color.Yellow
            TextBox29.BackColor = Color.Green
            TextBox30.BackColor = Color.Orange

        Else

        End If

    End Sub


    Private Sub Textbox13_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox13.KeyDown


        Select Case UCase(e.KeyCode)
            Case 1
                TextBox13.Text = "Left mouse button"
            Case 2
                TextBox13.Text = "Right mouse button"
            Case 3
                TextBox13.Text = "Cancel"
            Case 4
                TextBox13.Text = "Middle mouse button"
            Case 8
                TextBox13.Text = "Backspace"
            Case 9
                TextBox13.Text = "Tab"
            Case 12
                TextBox13.Text = "Clear"
            Case 13
                TextBox13.Text = "Enter"
            Case 16
                TextBox13.Text = "Shift"
            Case 17
                TextBox13.Text = "Ctrl"
            Case 18
                TextBox13.Text = "Menu"
            Case 19
                TextBox13.Text = "Pause"
            Case 20
                TextBox13.Text = "Choose another"
            Case 27
                TextBox13.Text = "Choose another"
            Case 32
                TextBox13.Text = "Choose another"
            Case 33
                TextBox13.Text = "PageUp"
            Case 34
                TextBox13.Text = "PageDown"
            Case 35
                TextBox13.Text = "End"
            Case 36
                TextBox13.Text = "Home"

            Case 45
                TextBox13.Text = "Insert"
            Case 46
                TextBox13.Text = "Delete"
            Case 47
                TextBox13.Text = "HELP"
            Case 48
                TextBox13.Text = ""
            Case 49
                TextBox13.Text = ""
            Case 50
                TextBox13.Text = ""
            Case 51
                TextBox13.Text = ""
            Case 52
                TextBox13.Text = ""
            Case 53
                TextBox13.Text = ""
            Case 54
                TextBox13.Text = ""
            Case 55
                TextBox13.Text = ""
            Case 56
                TextBox13.Text = ""
            Case 57
                TextBox13.Text = ""
            Case 65
                TextBox13.Text = "A"
            Case 66
                TextBox13.Text = "B"
            Case 67
                TextBox13.Text = "C"
            Case 68
                TextBox13.Text = "D"
            Case 69
                TextBox13.Text = "E"
            Case 70
                TextBox13.Text = "F"
            Case 71
                TextBox13.Text = "G"
            Case 72
                TextBox13.Text = "H"
            Case 73
                TextBox13.Text = "I"
            Case 74
                TextBox13.Text = "J"
            Case 75
                TextBox13.Text = "K"
            Case 76
                TextBox13.Text = "L"
            Case 77
                TextBox13.Text = "M"
            Case 78
                TextBox13.Text = "N"
            Case 79
                TextBox13.Text = "O"
            Case 80
                TextBox13.Text = "P"
            Case 81
                TextBox13.Text = "Q"
            Case 82
                TextBox13.Text = "R"
            Case 83
                TextBox13.Text = "S"
            Case 84
                TextBox13.Text = "T"
            Case 85
                TextBox13.Text = "U"
            Case 86
                TextBox13.Text = "V"
            Case 87
                TextBox13.Text = "W"
            Case 88
                TextBox13.Text = "X"
            Case 89
                TextBox13.Text = "Y"
            Case 90
                TextBox13.Text = "Z"
            Case 96
                TextBox13.Text = ""
            Case 97
                TextBox13.Text = ""
            Case 98
                TextBox13.Text = ""
            Case 99
                TextBox13.Text = ""
            Case 100
                TextBox13.Text = ""
            Case 101
                TextBox13.Text = ""
            Case 102
                TextBox13.Text = ""
            Case 103
                TextBox13.Text = ""
            Case 104
                TextBox13.Text = ""
            Case 105
                TextBox13.Text = ""
            Case 106
                TextBox13.Text = "Multiply"
            Case 107
                TextBox13.Text = "Choose another"
            Case 108
                TextBox13.Text = "Choose another"
            Case 109
                TextBox13.Text = "Choose another"
            Case 110
                TextBox13.Text = "Choose another"
            Case 111
                TextBox13.Text = "Divide"
            Case 112
                TextBox13.Text = "Choose another"
            Case 113
                TextBox13.Text = "Choose another"
            Case 114
                TextBox13.Text = "F3"
            Case 115
                TextBox13.Text = "F4"
            Case 116
                TextBox13.Text = "F5"
            Case 117
                TextBox13.Text = "F6"
            Case 118
                TextBox13.Text = "F7"
            Case 119
                TextBox13.Text = "F8"
            Case 120
                TextBox13.Text = "F9"
            Case 121
                TextBox13.Text = "Choose another"
            Case 122
                TextBox13.Text = "Choose another"
            Case 123
                TextBox13.Text = "Choose another"

            Case 144
                TextBox13.Text = "Choose another"

        End Select

    End Sub

    Private Sub Textbox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress

        DirectCast(sender, TextBox).SelectAll()


    End Sub

    Private Sub Textbox13_Leave(sender As Object, e As EventArgs) Handles TextBox13.Leave

        TextBox13.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        On Error Resume Next

        Dim RM As Resources.ResourceManager
        RM = New Resources.ResourceManager("WindowsApplication2.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'PictureBox1.Image = Image.FromFile("C:\Users\Admin\Desktop\Dexter_Stuffs\Extra Curricular\Season 7\Team Logo\" & TextBox16.Text & ".jpg")
        PictureBox1.Image = RM.GetObject(TextBox16.Text)
        'PictureBox2.Image = Image.FromFile("C:\Users\Admin\Desktop\Dexter_Stuffs\Extra Curricular\Season 7\Team Logo\" & TextBox17.Text & ".jpg")
        PictureBox2.Image = RM.GetObject(TextBox17.Text)
        PictureBox3.Image = RM.GetObject("logo")
        rs.FindAllControls(Me)

    End Sub

    Private Sub Form3_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        rs.ResizeAllControls(Me)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox3.Image = Image.FromFile(opf.FileName)

            Form5.TextBox3.Text = opf.FileName

        End If

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        PictureBox3.Image = Nothing

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)

        MsgBox(Convert.ToString(random.Next(1, 10)))

    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        For Each foundFile As String In My.Computer.FileSystem.GetFiles("C:\Users\Admin\Desktop\My Music\")

            Dim ThisFile As String = VB.Right(foundFile, Len(foundFile) - 32)

            Dim item11 As New ListViewItem(ThisFile)
            ListView1.Items.Add(item11)
            Form7.ComboBox1.Items.Add(ThisFile)

        Next

    End Sub

End Class