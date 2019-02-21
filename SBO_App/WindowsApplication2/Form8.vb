Imports System.IO
Imports VB = Microsoft.VisualBasic
Imports Microsoft.Office.Interop
Public Class Form8
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Focus()

        Dim response = MsgBox("Are you sure you want to clear all values and start a new game?", vbYesNo, "SHOHO-Q BASKETBALL OPEN")

        If response = MsgBoxResult.Yes Then

            Form6.WindowState = FormWindowState.Minimized
            Form2.WindowState = FormWindowState.Maximized

            Form1.Timer1.Enabled = False
            Form1.Timer2.Enabled = False
            Form1.Timer3.Enabled = False
            Form1.Timer5.Enabled = False
            Form1.Timer6.Enabled = False
            Form1.Timer7.Enabled = False

            Form6.Timer2.Enabled = False
            Form6.Timer3.Enabled = False
            Form6.Timer4.Enabled = False
            Form1.Button3.Enabled = True
            Form1.Button5.Enabled = True
            Form1.Button6.Enabled = True
            Form1.Button7.Enabled = True

            Form1.Label4.Text = Form3.NumericUpDown1.Value & ":" & AddZero(Form3.NumericUpDown2.Value)
            Form1.Label8.Text = 0
            Form1.Label9.Text = 0
            Form1.Label10.Text = 0
            Form1.NumericUpDown7.Value = 0
            Form1.NumericUpDown2.Value = 0
            Form1.NumericUpDown3.Value = 0
            Form1.NumericUpDown4.Value = 0
            Form1.CheckBox1.Checked = False
            Form1.CheckBox2.Checked = False
            Form1.Label5.Text = ""
            Form1.Label5.BackColor = Color.Transparent

            Form9.Timer6.Stop()

            Form9.Panel6.Visible = False
            Form9.PictureBox9.Visible = True
            Form9.PictureBox10.Visible = False
            Form9.Panel1.Visible = True
            Form9.Panel2.Visible = True
            Form9.PictureBox17.Visible = False
            Form9.PictureBox18.Visible = False
            Form9.Label4.Visible = False
            Form9.Label11.Visible = False

            xlApp = New Excel.Application
            xlApp.DisplayAlerts = False

            ' Open test Excel spreadsheet
            xlWorkBook = xlApp.Workbooks.Open("C:\Users\Admin\Desktop\Dexter_Stuffs\Logs\Operator Per Game\Logs.xlsx")

            'xlsWorkBook = xlsApp.ActiveWorkbook
            xlWorkSheet = xlWorkBook.Sheets("Logs")

            Dim entries = xlApp.WorksheetFunction.CountA(xlWorkSheet.Columns(1))
            xlWorkSheet.Cells(entries + 1, 1) = ComboBox1.Text
            xlWorkSheet.Cells(entries + 1, 2) = Form2.Label4.Text & " vs " & Form2.Label5.Text
            xlWorkSheet.Cells(entries + 1, 3) = Format(Now(), "MM/dd/yy")


            xlWorkBook.Save()
            xlApp.Workbooks.Close()
            xlApp.Quit()

        Else


        End If

        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Close()

    End Sub

End Class