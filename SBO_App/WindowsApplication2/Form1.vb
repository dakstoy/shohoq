Imports System.ComponentModel
Imports System.IO
Imports VB = Microsoft.VisualBasic
Imports Microsoft.Office.Interop

Public Class Form1

    Dim infoReader As System.IO.FileInfo

    Shared random As New Random()
    Private Declare Function music Lib “winmm.dll” Alias “mciSendStringA” (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private MyInput As String = ""

    Dim totaltime, totaltime2, totaltime3, a, b, c As Long
    Dim mins = Form3.NumericUpDown1.Value
    Dim secs = Form3.NumericUpDown2.Value
    Dim mins2 = Form3.NumericUpDown3.Value
    Dim secs2 = Form3.NumericUpDown4.Value
    Dim secs3 = Form3.NumericUpDown4.Value
    Dim mins3 = Form3.NumericUpDown3.Value
    Dim mins4 = 0
    Dim secs4 = 60
    Dim mins5 = 1
    Dim secs5 = 60
    Dim sec6 = 24
    Dim totaltime4 = 60
    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height
    Dim rs As New Resizer
    Public zzz As Integer
    Dim lSeconds As Long = 8 * 60000
    Dim milliseconds = 60
    Dim secs100 As String
    Dim sign1 As String
    Dim gameformat = VB.Left(Form3.ComboBox3.Text, 1)
    Private stopwatch As New Stopwatch
    Dim commercial As Integer


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Timer1.Interval = 1000
        Button3.Enabled = True
        Timer1.Enabled = False
        mins = Form3.NumericUpDown1.Value
        secs = Form3.NumericUpDown2.Value
        Label4.Text = AddZero(Form3.NumericUpDown1.Value) & ":" & AddZero(Form3.NumericUpDown2.Value)
        Form2.Label2.Text = Label4.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form9.PictureBox10.Visible = True
        Form9.PictureBox10.Image = My.Resources.timeoutlogo

        commercial = random.Next(1, 4)

        Select Case commercial
            Case 1

                Form9.PictureBox19.Image = My.Resources._2019_02_21_10h09_58

            Case 2

                Form9.PictureBox19.Image = My.Resources.KCS_Commercial

            Case 3

                Form9.PictureBox19.Image = My.Resources.blip_commercial

        End Select

        Form9.PictureBox19.Visible = True
        mins2 = Form3.NumericUpDown3.Value
        secs2 = Form3.NumericUpDown4.Value

        Label5.Text = "TO"
        Form6.Label4.Text = "30"
        Form6.Label12.Text = ""
        Label5.BackColor = Color.Black

        Button3.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False

        Label4.Text = AddZero(Form3.NumericUpDown3.Value) & ":" & AddZero(Form3.NumericUpDown4.Value)
        Form2.Label2.Text = Label4.Text
        Timer1.Enabled = False
        Timer3.Enabled = False
        Timer2.Enabled = True
        Form2.WindowState = FormWindowState.Minimized
        Form6.WindowState = FormWindowState.Maximized
        Focus()
        Form6.Label3.Text = "TIMEOUT"
        Form6.Timer2.Enabled = True
        Form6.Label2.Text = Label6.Text
        Form6.PictureBox1.Image = PictureBox1.Image
        Timer9.Stop()
        Timer11.Stop()
        stopwatch.Stop()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        On Error Resume Next
        'Form3.NumericUpDown5.Value = mins
        'Form3.NumericUpDown6.Value = secs

        Select Case commercial

            Case 1

                If secs2 = 25 Then

                    Form9.PictureBox19.Image = My.Resources.CS1

                End If

                If secs2 = 20 Then

                    Form9.PictureBox19.Image = My.Resources.CS2

                End If

                If secs2 = 15 Then

                    Form9.PictureBox19.Image = My.Resources.CS3

                End If

                If secs2 = 10 Then

                    Form9.PictureBox19.Image = My.Resources.CS4

                End If

                If secs2 = 5 Then

                    Form9.PictureBox19.Image = My.Resources.CS5

                End If

            Case 2

                Form9.PictureBox19.Image = My.Resources.KCS_Commercial

            Case 3

                Form9.PictureBox19.Image = My.Resources.blip_commercial

        End Select


        If secs2 = 1 Then

            Form9.PictureBox10.Visible = False
            music(“close myDevice”, Nothing, 0, 0)
            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

        End If

        If secs2 = 30 Then

            Dim FileName As String
            Dim a As Integer

            a = random.Next(1, zzz)

            FileName = Chr(34) & (Form3.TextBox32.Text & Form3.ListView1.Items(a).Text) & Chr(34)

            music(“open ” & FileName & ” alias myDevice”, Nothing, 0, 0)
            music(“play myDevice”, Nothing, 0, 0)

            'My.Computer.Audio.Play("C:\Users\Admin\Desktop\Dexter_Stuffs\Images\SC30_1.wav")

        End If

        If mins2 = 0 And secs2 = 0 Then

            Timer2.Enabled = False

            Form9.PictureBox19.Visible = False

            Button3.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True

            Label5.Text = ""
            Label5.BackColor = Color.Transparent

            'mins2 = Form3.NumericUpDown3.Value
            'secs2 = Form3.NumericUpDown4.Value

            If mins = 0 Then

                Label4.Text = milliseconds - 1 - stopwatch.Elapsed.Seconds & "." & VB.Left(1000 - stopwatch.Elapsed.Milliseconds, 2) + 1

            Else

                Label4.Text = AddZero(mins) & ":" & AddZero(secs)

            End If

            Form2.Label2.Text = Label4.Text

            GoTo Ending

        End If


        If Not secs2 = "0" Then

            secs2 -= 1
        Else

            secs2 = 59

            If Not mins2 = "1" Then

                mins2 -= 1

            Else

                mins2 = 0

            End If

        End If

        Label4.Text = AddZero(mins2) & ":" & AddZero(secs2)
        Form2.Label2.Text = Label4.Text

Ending:

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form9.PictureBox10.Visible = True
        Form9.PictureBox10.Image = My.Resources.timeoutlogo

        commercial = random.Next(1, 4)

        Select Case commercial

            Case 1

                Form9.PictureBox19.Image = My.Resources._2019_02_21_10h09_58

            Case 2

                Form9.PictureBox19.Image = My.Resources.KCS_Commercial

            Case 3

                Form9.PictureBox19.Image = My.Resources.blip_commercial

        End Select

        Form9.PictureBox19.Visible = True
        mins3 = Form3.NumericUpDown3.Value
        secs3 = Form3.NumericUpDown4.Value

        Label5.Text = "TO"
        Label5.BackColor = Color.Black
        Form6.Label4.Text = "30"
        Form6.Label12.Text = ""
        Button3.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False

        Label4.Text = AddZero(Form3.NumericUpDown3.Value) & ":" & AddZero(Form3.NumericUpDown4.Value)
        Form2.Label2.Text = Label4.Text
        Timer1.Enabled = False
        Timer3.Enabled = True
        Timer2.Enabled = False

        Form2.WindowState = FormWindowState.Minimized
        Form6.WindowState = FormWindowState.Maximized
        Focus()
        Form6.Label3.Text = "TIMEOUT"
        Form6.Timer2.Enabled = True
        Form6.Label2.Text = Label7.Text
        Form6.PictureBox1.Image = PictureBox2.Image
        Timer9.Stop()
        Timer11.Stop()
        stopwatch.Stop()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        On Error Resume Next

        Select Case commercial

            Case 1

                If secs3 = 25 Then

                    Form9.PictureBox19.Image = My.Resources.CS1

                End If

                If secs3 = 20 Then

                    Form9.PictureBox19.Image = My.Resources.CS2

                End If

                If secs3 = 15 Then

                    Form9.PictureBox19.Image = My.Resources.CS3

                End If

                If secs3 = 10 Then

                    Form9.PictureBox19.Image = My.Resources.CS4

                End If

                If secs3 = 5 Then

                    Form9.PictureBox19.Image = My.Resources.CS5

                End If

            Case 2

                Form9.PictureBox19.Image = My.Resources.KCS_Commercial

            Case 3

                Form9.PictureBox19.Image = My.Resources.blip_commercial

        End Select


        If secs3 = 1 Then

            Form9.PictureBox10.Visible = False
            music(“close myDevice”, Nothing, 0, 0)
            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

        End If

        If secs3 = 30 Then

            Dim FileName As String
            Dim a As Integer

            a = random.Next(1, zzz)

            FileName = Chr(34) & (Form3.TextBox32.Text & Form3.ListView1.Items(a).Text) & Chr(34)

            music(“open ” & FileName & ” alias myDevice”, Nothing, 0, 0)
            music(“play myDevice”, Nothing, 0, 0)

            'My.Computer.Audio.Play("C:\Users\Admin\Desktop\Dexter_Stuffs\Images\SC30_2.wav")

        End If

        If mins3 = 0 And secs3 = 0 Then

            Timer3.Enabled = False

            Form9.PictureBox19.Visible = False

            Button3.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True

            Label5.Text = ""
            Label5.BackColor = Color.Transparent

            If mins = 0 Then

                Label4.Text = milliseconds - 1 - stopwatch.Elapsed.Seconds & "." & VB.Left(1000 - stopwatch.Elapsed.Milliseconds, 2) + 1

            Else

                Label4.Text = AddZero(mins) & ":" & AddZero(secs)

            End If

            Form2.Label2.Text = Label4.Text

            GoTo Ending

        End If


        If Not secs3 = "0" Then

            secs3 -= 1
        Else

            secs3 = 59

            If Not mins3 = "1" Then

                mins3 -= 1

            Else

                mins3 = 0

            End If

        End If

        Label4.Text = AddZero(mins3) & ":" & AddZero(secs3)
        Form2.Label2.Text = Label4.Text

Ending:

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If NumericUpDown7.Value = 0 Then

            Timer9.Stop()
            Timer1.Enabled = False
            stopwatch.Stop()
            stopwatch.Reset()

            mins = NumericUpDown7.Value
            milliseconds = NumericUpDown2.Value

            Form6.Label6.Text = milliseconds & ".00"
            Label4.Text = milliseconds & ".00"
            Form2.Label2.Text = Label4.Text

        Else

            Timer1.Interval = 1000
            Timer9.Stop()
            stopwatch.Stop()
            stopwatch.Reset()
            Timer1.Enabled = False

            mins = NumericUpDown7.Value
            secs = NumericUpDown2.Value
            milliseconds = 60
            secs100 = 47

            Form6.Label6.Text = AddZero(mins) & ":" & AddZero(secs)
            Label4.Text = AddZero(mins) & ":" & AddZero(secs)
            Form2.Label2.Text = Label4.Text

        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        sign1 = "No"
        Timer9.Stop()
        Label8.Text = CDbl(Label8.Text) + 3
        sec6 = 24
        Label13.Text = sec6

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        sign1 = "No"
        Timer9.Stop()
        Label8.Text = CDbl(Label8.Text) + 2
        sec6 = 24
        Label13.Text = sec6

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        sign1 = "No"
        Timer9.Stop()
        Label8.Text = CDbl(Label8.Text) + 1
        sec6 = 24
        Label13.Text = sec6

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        Label8.Text = CDbl(Label8.Text) - 1

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        sign1 = "No"
        Timer9.Stop()
        Label9.Text = CDbl(Label9.Text) + 3
        sec6 = 24
        Label13.Text = sec6

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        sign1 = "No"
        Timer9.Stop()
        Label9.Text = CDbl(Label9.Text) + 2
        sec6 = 24
        Label13.Text = sec6

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        sign1 = "No"
        Timer9.Stop()
        Label9.Text = CDbl(Label9.Text) + 1
        sec6 = 24
        Label13.Text = sec6

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        Label9.Text = CDbl(Label9.Text) - 1

    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged

        Label8.Text = NumericUpDown3.Value

    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged

        Label9.Text = NumericUpDown4.Value

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sign1 = "No"
        Timer9.Stop()
        Timer1.Stop()
        Timer11.Stop()
        stopwatch.Stop()

Ending:

    End Sub



    Function AddZero(ByVal par As Integer) As String

        Dim a = ""
        If par < 10 Then
            a = "0" & par
        Else
            a = par
        End If

        Return a

    End Function

    Function AddZeroAfter(ByVal par As Integer) As String

        Dim a = ""
        If par < 10 Then
            a = par & "0"
        Else
            a = par
        End If

        Return a

    End Function

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        Form3.Show()

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        Form2.Close()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        Dim p() As Process

        p = Process.GetProcessesByName("obs64")

        If p.Count > 0 Then

            MsgBox("Press ] to end recording.")

        Else

            Dim msgRslt1 As MsgBoxResult = MsgBox("OBS is not running, do you want to open the application?.", MsgBoxStyle.YesNo)
            If msgRslt1 = MsgBoxResult.Yes Then

                Dim proc As New System.Diagnostics.Process()
                proc = Process.Start("C:\Users\Admin\Desktop\obs64.exe - Shortcut", "")

            ElseIf msgRslt1 = MsgBoxResult.No Then


            End If

        End If

        Dim msgRslt As MsgBoxResult = MsgBox("Do you want to log this game?.", MsgBoxStyle.YesNo)
        If msgRslt = MsgBoxResult.Yes Then

            mins = Form3.NumericUpDown1.Value
            secs = Form3.NumericUpDown2.Value
            Form8.Show()

        ElseIf msgRslt = MsgBoxResult.No Then

            Form6.WindowState = FormWindowState.Minimized
            Form2.WindowState = FormWindowState.Maximized

            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer5.Enabled = False
            Timer6.Enabled = False
            Timer7.Enabled = False

            Form6.Timer2.Enabled = False
            Form6.Timer3.Enabled = False
            Form6.Timer4.Enabled = False
            Button3.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True

            Label4.Text = Form3.NumericUpDown1.Value & ":" & AddZero(Form3.NumericUpDown2.Value)
            Label8.Text = 0
            Label9.Text = 0
            Label10.Text = 0
            NumericUpDown7.Value = 0
            NumericUpDown2.Value = 0
            NumericUpDown3.Value = 0
            NumericUpDown4.Value = 0
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            Label5.Text = ""
            Label5.BackColor = Color.Transparent

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
            Form9.Label16.Visible = False

        End If

        Form9.PictureBox10.Visible = False

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        If Label10.Text = 0 Then

            Dim p() As Process

            p = Process.GetProcessesByName("obs64")

            If p.Count > 0 Then

                MsgBox("OBS is running, make sure Mic/Aux is connected, press ] to start recording the game.", vbOKOnly)

            Else

                Dim msgRslt As MsgBoxResult = MsgBox("OBS is not running, do you want to open the application?.", MsgBoxStyle.YesNo)
                If msgRslt = MsgBoxResult.Yes Then

                    Dim proc As New System.Diagnostics.Process()
                    proc = Process.Start("C:\Users\Admin\Desktop\obs64.exe - Shortcut", "")

                ElseIf msgRslt = MsgBoxResult.No Then


                End If

            End If

        End If

        Label10.Text = CDbl(Label10.Text) + 1

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

        Label10.Text = CDbl(Label10.Text) - 1

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        Form2.Label1.Text = Label13.Text
        Form2.Label2.Text = Label4.Text
        Form2.Label2.ForeColor = Label4.ForeColor
        Form2.Label2.BackColor = Label4.BackColor

        Form2.Label8.Text = Label8.Text
        Form2.Label8.ForeColor = Label8.ForeColor

        Form2.Label3.Text = Label9.Text
        Form2.Label3.ForeColor = Label9.ForeColor

        Form2.Label4.Text = Label6.Text
        Form2.Label4.ForeColor = Label6.ForeColor

        Form2.Label5.Text = Label7.Text
        Form2.Label5.ForeColor = Label7.ForeColor

        Form2.Label6.Text = Label11.Text
        Form2.Label6.ForeColor = Label11.ForeColor

        Form2.Label10.Text = Label10.Text
        Form2.Label10.ForeColor = Label10.ForeColor

        Form2.Label7.Text = Label5.Text
        Form2.Label7.BackColor = Label5.BackColor
        Form2.Label7.ForeColor = Label5.ForeColor

        Form2.PictureBox1.Image = PictureBox1.Image
        Form2.PictureBox2.Image = PictureBox2.Image

        Form9.PictureBox17.Image = PictureBox1.Image
        Form9.PictureBox18.Image = PictureBox2.Image

        Form9.Label4.Text = Form2.Label8.Text
        Form9.Label11.Text = Form2.Label3.Text

        Form9.Label13.Text = Label10.Text


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            CheckBox2.Checked = False

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then

            CheckBox1.Checked = False

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer8.Enabled = True

        Dim RM As Resources.ResourceManager

        RM = New Resources.ResourceManager("WindowsApplication2.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        On Error Resume Next

        Timer4.Enabled = True
        Timer10.Enabled = True

        Form2.Timer1.Enabled = False

        Me.Label6.Text = Form3.TextBox16.Text
        Me.Label7.Text = Form3.TextBox17.Text
        Me.PictureBox1.Image = RM.GetObject(Form3.TextBox16.Text)
        Me.PictureBox2.Image = RM.GetObject(Form3.TextBox17.Text)
        Me.Label11.Text = Form3.TextBox18.Text
        Me.Label1.Text = Form3.TextBox21.Text
        Me.BackColor = Form3.TextBox22.BackColor
        Me.Label4.BackColor = Form3.TextBox23.BackColor
        Me.Label8.BackColor = Form3.TextBox23.BackColor
        Me.Label9.BackColor = Form3.TextBox23.BackColor
        Me.Label10.BackColor = Form3.TextBox23.BackColor
        Me.Label10.ForeColor = Form3.TextBox24.BackColor

        Me.Label8.ForeColor = Form3.TextBox25.BackColor
        Me.Label9.ForeColor = Form3.TextBox25.BackColor

        Me.Label1.ForeColor = Form3.TextBox26.BackColor
        Me.Label2.ForeColor = Form3.TextBox26.BackColor
        Me.Label6.ForeColor = Form3.TextBox26.BackColor
        Me.Label7.ForeColor = Form3.TextBox26.BackColor
        Me.Label11.ForeColor = Form3.TextBox26.BackColor

        Me.Label4.ForeColor = Form3.TextBox27.BackColor
        Form2.Label2.ForeColor = Form3.TextBox27.BackColor
        Label10.Text = 0

        rs.FindAllControls(Me)

        Label4.Text = AddZero(Form3.NumericUpDown1.Value) & ":" & AddZero(Form3.NumericUpDown2.Value)

        Me.KeyPreview = True

        Form4.Hide()

        Form9.Show()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        On Error Resume Next

        Form9.Timer6.Start()

        If CInt(Form9.Label4.Text) > CInt(Form9.Label11.Text) Then

            Form9.Label4.ForeColor = Color.Blue
            Form9.Label11.ForeColor = Color.Red

        Else

            If CInt(Form9.Label4.Text) = CInt(Form9.Label11.Text) Then

                Form9.Label4.ForeColor = Color.Gray
                Form9.Label11.ForeColor = Color.Gray

            Else

                Form9.Label4.ForeColor = Color.Red
                Form9.Label11.ForeColor = Color.Blue

            End If

        End If

        Form9.Panel6.Visible = True
        Form9.PictureBox9.Visible = False
        Form9.Panel1.Visible = False
        Form9.Panel2.Visible = False
        Form9.PictureBox17.Visible = True
        Form9.PictureBox18.Visible = True
        Form9.Label4.Visible = True
        Form9.Label11.Visible = True
        Form9.PictureBox20.Visible = True

        If Form9.PictureBox10.Visible = True Then

        Else

            Form9.PictureBox10.Visible = True
            Form9.PictureBox10.Image = My.Resources.ty

        End If


        If totaltime4 = 59 Then

        ElseIf totaltime4 = 55 Then

            Form9.PictureBox10.Image = My.Resources.VDrink

        ElseIf totaltime4 = 49 Then

            Form9.PictureBox10.Image = My.Resources.CSAS

        ElseIf totaltime4 = 43 Then

            Form9.PictureBox10.Image = My.Resources.emar

        ElseIf totaltime4 = 37 Then

            Form9.PictureBox10.Image = My.Resources.cyber_bellying

        ElseIf totaltime4 = 31 Then

            Form9.PictureBox10.Image = My.Resources.KCS

        ElseIf totaltime4 = 25 Then

            Form9.PictureBox10.Image = My.Resources.Blip2

        ElseIf totaltime4 = 19 Then

            Form9.PictureBox10.Image = My.Resources.Custom_Sports

        ElseIf totaltime4 = 13 Then

            Form9.PictureBox10.Image = My.Resources.San_Remigio

        End If

        If totaltime4 = 60 And Not Form6.Label2.Text = "OVERTIME" Then

            Dim FileName As String
            Dim a As Integer

            a = random.Next(1, zzz)

            FileName = Chr(34) & (Form3.TextBox32.Text & Form3.ListView1.Items(a).Text) & Chr(34)

            music(“open ” & FileName & ” alias myDevice”, Nothing, 0, 0)
            music(“play myDevice”, Nothing, 0, 0)

            'My.Computer.Audio.Play("C:\Users\Admin\Desktop\Dexter_Stuffs\Images\Remember_The_Name.wav")

            Timer5.Enabled = False
            Timer6.Start()
            totaltime4 = 59

            GoTo Ending

        End If

        If totaltime4 = 58 Then

            Dim FileName As String
            Dim a As Integer

            a = random.Next(1, zzz)

            FileName = Chr(34) & (Form3.TextBox32.Text & Form3.ListView1.Items(a).Text) & Chr(34)

            music(“open ” & FileName & ” alias myDevice”, Nothing, 0, 0)
            music(“play myDevice”, Nothing, 0, 0)

            'My.Computer.Audio.Play("C:\Users\Admin\Desktop\Dexter_Stuffs\Images\Remember_The_Name.wav")

        End If


        If totaltime4 = 0 Then

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
            Form9.Label16.Visible = False
            Form9.PictureBox20.Visible = False

            Timer5.Enabled = False
            totaltime4 = 59

        End If

        If Not totaltime4 = "0" Then

            totaltime4 -= 1

        Else

            totaltime4 = 59

        End If

        Form6.Label4.Text = totaltime4

Ending:
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.WaitToComplete)

    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick

        On Error Resume Next


        Form9.Timer6.Start()

        If CInt(Form9.Label4.Text) > CInt(Form9.Label11.Text) Then

            Form9.Label4.ForeColor = Color.Blue
            Form9.Label11.ForeColor = Color.Red

        Else

            If CInt(Form9.Label4.Text) = CInt(Form9.Label11.Text) Then

                Form9.Label4.ForeColor = Color.Gray
                Form9.Label11.ForeColor = Color.Gray

            Else

                Form9.Label4.ForeColor = Color.Red
                Form9.Label11.ForeColor = Color.Blue

            End If

        End If



        Form9.Panel6.Visible = True
        Form9.Panel1.Visible = False
        Form9.Panel2.Visible = False
        Form9.PictureBox17.Visible = True
        Form9.PictureBox18.Visible = True
        Form9.Label4.Visible = True
        Form9.Label11.Visible = True
        Form9.PictureBox9.Visible = False
        Form9.PictureBox20.Visible = True

        If Form9.PictureBox10.Visible = True Then

        Else

            Form9.PictureBox10.Visible = True
            Form9.PictureBox10.Image = My.Resources.ty

        End If


        If secs4 = 59 Then

        ElseIf secs4 = 55 Then

            Form9.PictureBox10.Image = My.Resources.VDrink

        ElseIf secs4 = 49 Then

            Form9.PictureBox10.Image = My.Resources.CSAS

        ElseIf secs4 = 43 Then

            Form9.PictureBox10.Image = My.Resources.emar

        ElseIf secs4 = 37 Then

            Form9.PictureBox10.Image = My.Resources.cyber_bellying

        ElseIf secs4 = 31 Then

            Form9.PictureBox10.Image = My.Resources.KCS

        ElseIf secs4 = 25 Then

            Form9.PictureBox10.Image = My.Resources.Blip2

        ElseIf secs4 = 19 Then

            Form9.PictureBox10.Image = My.Resources.Custom_Sports

        ElseIf secs4 = 13 Then

            Form9.PictureBox10.Image = My.Resources.Pocari_Sweat_logo

        ElseIf secs4 = 7 Then

            Form9.PictureBox10.Image = My.Resources.San_Remigio

        End If

        If secs4 = 1 Then

            music(“close myDevice”, Nothing, 0, 0)
            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

        End If

        If mins4 = 0 And secs4 = 0 Then

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
            Form9.Label16.Visible = False
            Form9.PictureBox20.Visible = False

            Timer6.Enabled = False

            Form2.WindowState = FormWindowState.Maximized
            Form6.WindowState = FormWindowState.Minimized

            If Form6.Label2.Text = "OVERTIME" Then

                Label10.Text = CDbl(Label10.Text) + 1
                mins = 5
                secs = 0
                Form6.Label6.Text = AddZero(mins) & ":" & AddZero(secs)

            Else

                mins = Form3.NumericUpDown1.Value
                secs = Form3.NumericUpDown2.Value

            End If

            mins4 = 0
            secs4 = 60

            Button3.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True

            Label5.Text = ""
            Label5.BackColor = Color.Transparent

            'mins4 = Form3.NumericUpDown3.Value
            'secs4 = Form3.NumericUpDown4.Value

            Label4.Text = AddZero(mins) & ":" & AddZero(secs)
            Form2.Label2.Text = Label4.Text

            GoTo Ending

        End If


        If Not secs4 = "0" Then

            secs4 -= 1
        Else

            secs4 = 59

            If Not mins4 = "1" Then

                mins4 -= 1

            Else

                mins4 = 0

            End If

        End If

        Label4.Text = AddZero(mins4) & ":" & AddZero(secs4)
        Form2.Label2.Text = Label4.Text

Ending:

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick

        On Error Resume Next

        'Form3.NumericUpDown5.Value = mins
        'Form3.NumericUpDown6.Value = secs

        If mins5 = 0 And secs5 = 1 Then

            music(“close myDevice”, Nothing, 0, 0)
            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

        End If

        If mins5 = 0 And secs5 = 0 Then


            Timer7.Enabled = False

            mins = Form3.NumericUpDown1.Value
            secs = Form3.NumericUpDown2.Value
            mins5 = 2
            secs5 = 0

            Button3.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True

            Label5.Text = ""
            Label5.BackColor = Color.Transparent


            Label4.Text = AddZero(mins) & ":" & AddZero(secs)
            Form2.Label2.Text = Label4.Text

            GoTo Ending

        End If


        If Not secs5 = "0" Then

            secs5 -= 1
        Else

            secs5 = 59

            If Not mins5 = "1" Then

                mins5 -= 1

            Else

                mins5 = 0

            End If

        End If

        Label4.Text = AddZero(mins5) & ":" & AddZero(secs5)
        Form2.Label2.Text = Label4.Text

Ending:

    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick

        'Form6.Label6.Text = AddZero(Form3.NumericUpDown5.Value) & ":" & AddZero(Form3.NumericUpDown6.Value)

        'If mins = 0 And secs = 0 Then

        '    Form6.Label6.Text = "00:00"

        'End If

        If CDbl(Label10.Text) > 4 Then

            Label11.Text = "Overtime"

        Else

            Label11.Text = "Period"

        End If

    End Sub

    Private Sub Button22_Click_1(sender As Object, e As EventArgs) Handles Button22.Click

        Form7.Show()

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click

        Form9.Label16.Visible = False
        Form9.Timer6.Stop()
        Form9.Panel6.Visible = False
        Form9.PictureBox10.Visible = False
        Form9.PictureBox19.Visible = False
        Form9.PictureBox9.Visible = True
        Form9.Panel1.Visible = True
        Form9.Panel2.Visible = True
        Form9.PictureBox17.Visible = False
        Form9.PictureBox18.Visible = False
        Form9.Label4.Visible = False
        Form9.Label11.Visible = False

        music(“close myDevice”, Nothing, 0, 0)
        Form6.Timer2.Enabled = False
        Form6.Timer3.Enabled = False
        Form6.Timer4.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer5.Enabled = False
        Form6.totaltime = 30
        Form6.totaltime2 = 60
        Form6.totaltime3 = 120

        If Timer6.Enabled = True Then

            Timer6.Stop()
            mins4 = 0
            secs4 = 60

            mins = Form3.NumericUpDown1.Value
            secs = Form3.NumericUpDown2.Value
            Label10.Text = Label10.Text + 1

        End If

        If Timer7.Enabled = True Then

            Timer7.Stop()
            mins5 = 1
            secs5 = 60

            mins = Form3.NumericUpDown1.Value
            secs = Form3.NumericUpDown2.Value
            Label10.Text = Label10.Text + 1

        End If

        Button3.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True

        Label5.Text = ""
        Label5.BackColor = Color.Transparent

        Form6.WindowState = FormWindowState.Minimized
        Form2.WindowState = FormWindowState.Maximized

        If mins = 0 Then

            Label4.Text = milliseconds - 1 - stopwatch.Elapsed.Seconds & "." & VB.Left(1000 - stopwatch.Elapsed.Milliseconds, 2) + 1

        Else

            Label4.Text = AddZero(mins) & ":" & AddZero(secs)

        End If

        Form2.Label2.Text = Label4.Text

    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick

        If mins = 0 And milliseconds - 1 - stopwatch.Elapsed.Seconds < sec6 Then

            sec6 = 24
            Label13.Text = sec6

        Else

            If Not sec6 = 0 Then

                sec6 -= 1

            End If

            If sec6 = 0 Then

                Select Case gameformat

                    Case 1

                        If Label10.Text = 1 Then

                            If mins = 0 Then

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"
                                Timer9.Stop()
                                Timer1.Stop()
                                Timer11.Stop()
                                stopwatch.Stop()

                            Else

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"

                            End If

                        Else

                            music(“close myDevice”, Nothing, 0, 0)
                            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                            sec6 = 24
                            sign1 = "No"
                            Timer9.Stop()
                            Timer1.Stop()
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Case 2

                        If Label10.Text = 2 Then

                            If mins = 0 Then

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"
                                Timer9.Stop()
                                Timer1.Stop()
                                Timer11.Stop()
                                stopwatch.Stop()

                            Else

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"

                            End If

                        Else

                            music(“close myDevice”, Nothing, 0, 0)
                            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                            sec6 = 24
                            sign1 = "No"
                            Timer9.Stop()
                            Timer1.Stop()
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Case 3

                        If Label10.Text = 3 Then

                            If mins = 0 Then

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"
                                Timer9.Stop()
                                Timer1.Stop()
                                Timer11.Stop()
                                stopwatch.Stop()

                            Else

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"

                            End If

                        Else

                            music(“close myDevice”, Nothing, 0, 0)
                            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                            sec6 = 24
                            sign1 = "No"
                            Timer9.Stop()
                            Timer1.Stop()
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Case 4

                        If Label10.Text = 4 Then

                            If mins = 0 Then

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"
                                Timer9.Stop()
                                Timer1.Stop()
                                Timer11.Stop()
                                stopwatch.Stop()

                            Else

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"

                            End If

                        Else

                            music(“close myDevice”, Nothing, 0, 0)
                            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                            sec6 = 24
                            sign1 = "No"
                            Timer9.Stop()
                            Timer1.Stop()
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Case 5

                        If Label10.Text < 3 Then

                            If mins = 0 Then

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"
                                Timer9.Stop()
                                Timer1.Stop()
                                Timer11.Stop()
                                stopwatch.Stop()

                            Else

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"

                            End If

                        Else

                            music(“close myDevice”, Nothing, 0, 0)
                            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                            sec6 = 24
                            sign1 = "No"
                            Timer9.Stop()
                            Timer1.Stop()
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Case 6

                        If Label10.Text > 2 Then

                            If mins = 0 Then

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"
                                Timer9.Stop()
                                Timer1.Stop()
                                Timer11.Stop()
                                stopwatch.Stop()

                            Else

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"

                            End If

                        Else

                            music(“close myDevice”, Nothing, 0, 0)
                            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                            sec6 = 24
                            sign1 = "No"
                            Timer9.Stop()
                            Timer1.Stop()
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Case 7

                        If Label10.Text < 4 Then

                            If mins = 0 Then

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"
                                Timer9.Stop()
                                Timer1.Stop()
                                Timer11.Stop()
                                stopwatch.Stop()

                            Else

                                music(“close myDevice”, Nothing, 0, 0)
                                My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                                sec6 = 24
                                sign1 = "No"

                            End If

                        Else

                            music(“close myDevice”, Nothing, 0, 0)
                            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                            sec6 = 24
                            sign1 = "No"
                            Timer9.Stop()
                            Timer1.Stop()
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Case 8

                        music(“close myDevice”, Nothing, 0, 0)
                        My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

                        sec6 = 24
                        sign1 = "No"
                        Timer9.Stop()
                        Timer1.Stop()
                        Timer11.Stop()
                        stopwatch.Stop()

                End Select

            End If

            Label13.Text = sec6

        End If

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        If Timer9.Enabled = True Then

            sign1 = "No"

        Else

            sign1 = "Yes"

        End If


    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click

        If Timer9.Enabled = True Then

            sign1 = "No"
            sec6 = 24
            Label13.Text = sec6
            sign1 = "Yes"

        Else

            sec6 = 24
            Label13.Text = sec6

        End If



    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

        If Timer9.Enabled = True Then

            sign1 = "No"
            sec6 = 14
            Label13.Text = sec6
            sign1 = "Yes"

        Else

            sec6 = 14
            Label13.Text = sec6

        End If

    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick

        gameformat = VB.Left(Form3.ComboBox3.Text, 1)

        Dim RM As Resources.ResourceManager

        RM = New Resources.ResourceManager("WindowsApplication2.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        On Error Resume Next

        If CheckBox1.Checked = False And CheckBox2.Checked = False Then

            Form2.PictureBox3.Image = Nothing
            Form2.PictureBox4.Image = Nothing

        End If

        If CheckBox1.Checked = True And CheckBox2.Checked = False Then

            Form2.PictureBox4.Image = Nothing
            PictureBox4.Image = Nothing

            Form2.PictureBox3.Image = RM.GetObject("gg7x_final")
            PictureBox3.Image = RM.GetObject("gg7x_final")


        End If

        If CheckBox2.Checked = True And CheckBox1.Checked = False Then

            Form2.PictureBox3.Image = Nothing
            PictureBox3.Image = Nothing
            Form2.PictureBox4.Image = RM.GetObject("gg7x_final")
            PictureBox4.Image = RM.GetObject("gg7x_final")

        End If

    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick

        Dim elapsed As TimeSpan = stopwatch.Elapsed

        If milliseconds - 1 - elapsed.Seconds = 0 And elapsed.Milliseconds > 900 Then 'VB.Left(Label4.Text, 1) = 0 Then elapsed.Minutes = 1 Then Or 

            music(“close myDevice”, Nothing, 0, 0)
            My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)

            Timer11.Enabled = False
            stopwatch.Stop()
            stopwatch.Reset()
            Timer1.Enabled = False
            Timer9.Enabled = False
            Label4.Text = "0.00"

            milliseconds = 59
            secs100 = 47

            mins = Form3.NumericUpDown1.Value
            secs = Form3.NumericUpDown2.Value
            Form6.Label6.Text = "0.00"

            If Label10.Text = 0 Then

                GoTo Ending

            End If


            If Label10.Text = 1 Then

                Form2.WindowState = FormWindowState.Minimized
                Form6.WindowState = FormWindowState.Maximized
                Focus()

                Form6.Label3.Text = "Ball Possession"
                Form6.Label12.Text = "End of 1st Quarter"
                Form6.Label11.Text = "BASKETBALL"
                Form6.Label4.Text = "60"

                If CheckBox1.Checked = True Then

                    Form6.Label2.Text = Label7.Text
                    Form6.PictureBox1.Image = PictureBox2.Image

                Else

                    Form6.Label2.Text = Label6.Text
                    Form6.PictureBox1.Image = PictureBox1.Image

                End If

                Form6.Timer3.Enabled = True
                Timer6.Enabled = True


            End If

            If Label10.Text = 2 Then

                Form2.WindowState = FormWindowState.Minimized
                Form6.WindowState = FormWindowState.Maximized
                Focus()

                Form6.Label3.Text = "Ball Possession"
                Form6.Label11.Text = "BASKETBALL"
                Form6.Label12.Text = "HALFTIME"
                Form6.Label4.Text = "120"

                If CheckBox1.Checked = True Then

                    Form6.Label2.Text = Label7.Text
                    Form6.PictureBox1.Image = PictureBox2.Image

                Else

                    Form6.Label2.Text = Label6.Text
                    Form6.PictureBox1.Image = PictureBox1.Image

                End If

                Form6.Timer4.Enabled = True
                Timer7.Enabled = True

            End If

            If Label10.Text = 3 Then

                Form2.WindowState = FormWindowState.Minimized
                Form6.WindowState = FormWindowState.Maximized
                Focus()

                Form6.Label3.Text = "Ball Possession"
                Form6.Label12.Text = "End of 3rd Quarter"
                Form6.Label11.Text = "BASKETBALL"
                Form6.Label4.Text = "60"

                If CheckBox1.Checked = True Then

                    Form6.Label2.Text = Label7.Text
                    Form6.PictureBox1.Image = PictureBox2.Image

                Else

                    Form6.Label2.Text = Label6.Text
                    Form6.PictureBox1.Image = PictureBox1.Image

                End If

                Form6.Timer3.Enabled = True
                Timer6.Enabled = True

            End If

            If Label10.Text >= 4 Then

                Form2.WindowState = FormWindowState.Minimized
                Form6.WindowState = FormWindowState.Maximized
                Focus()

                Form6.Label11.Text = ""
                Form6.Label12.Text = ""
                Form6.Label3.Text = "End of regulation"

                If CDbl(Label8.Text) > CDbl(Label9.Text) Then

                    Form6.Label2.Text = "WINNER"
                    Form6.PictureBox1.Image = PictureBox1.Image
                    Form6.Label4.Text = 0
                    Form6.Label11.Text = Label6.Text

                    Focus()

                    Form9.PictureBox10.Visible = True
                    Form9.Label16.Visible = True
                    Timer5.Enabled = True
                    'Timer6.Enabled = True

                    GoTo Ending

                End If

                If CDbl(Label9.Text) > CDbl(Label8.Text) Then

                    Form6.Label2.Text = "WINNER"
                    Form6.PictureBox1.Image = PictureBox2.Image
                    Form6.Label4.Text = 0
                    Form6.Label11.Text = Label7.Text

                    Focus()

                    Form9.PictureBox10.Visible = True
                    Form9.Label16.Visible = True
                    Timer5.Enabled = True
                    'Timer6.Enabled = True

                    GoTo Ending

                End If

                If CDbl(Label8.Text) = CDbl(Label9.Text) Then

                    Form6.Label2.Text = "OVERTIME"
                    Form6.PictureBox1.Image = My.Resources.overtime
                    Form6.Label4.Text = 60

                    Timer5.Enabled = True
                    Timer6.Enabled = True

                End If

            End If

            Label4.Text = AddZero(mins) & ":" & AddZero(secs)
            Form2.Label2.Text = Label4.Text

            GoTo Ending

        End If

        Label4.Text = milliseconds - 1 - elapsed.Seconds & "." & AddZeroAfter(VB.Left(1000 - elapsed.Milliseconds, 2))
        'Label14.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds)
        Form2.Label2.Text = Label4.Text

Ending:

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If sign1 = "Yes" Then

            If Form3.CheckBox3.Checked = True Then

                Timer9.Start()

            Else

                Label13.Text = 24
                Timer9.Stop()

            End If

        Else

            Timer9.Stop()

        End If

        Timer5.Enabled = False

        Dim z As Integer = secs - 1

        If z < 0 Then

            Form6.Label6.Text = AddZero(mins - 1) & ":" & AddZero(59)

        Else

            Form6.Label6.Text = AddZero(mins) & ":" & AddZero(secs - 1)

        End If

        If Not secs = "0" Then

            secs -= 1
        Else
            secs = 59
            If Not mins = 0 Then

                mins -= 1

            Else

                mins = 0

            End If

        End If

        If mins = 0 Then

            Timer11.Start()
            Timer11.Interval = 1
            stopwatch.Start()

        Else

            Label4.Text = AddZero(mins) & ":" & AddZero(secs)
            Form2.Label2.Text = Label4.Text

        End If


    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Select Case gameformat

            Case 1

                If Not Label10.Text = 1 Then

                    If Timer1.Enabled = True Then

                        If Timer9.Enabled = False Then

                            sign1 = "Yes"
                            Timer9.Start()

                        Else

                            Timer1.Enabled = False
                            sign1 = "No"
                            Timer9.Enabled = False
                            Timer11.Stop()

                        End If

                    Else

                        Timer1.Enabled = True
                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                        End If
                    End If

                Else

                    Timer1.Start()

                    If Timer9.Enabled = True Then

                        sign1 = "No"
                        Timer9.Enabled = False
                        Timer11.Stop()

                    Else

                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                        End If

                    End If

                End If

            Case 2

                If Not Label10.Text = 2 Then

                    If Timer1.Enabled = True Then

                        If Timer9.Enabled = False Then

                            sign1 = "Yes"
                            Timer9.Start()

                        Else

                            Timer1.Enabled = False
                            sign1 = "No"
                            Timer9.Enabled = False
                            Timer11.Stop()

                        End If

                    Else

                        Timer1.Enabled = True
                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If
                    End If


                Else

                    Timer1.Start()

                    If Timer9.Enabled = True Then

                        sign1 = "No"
                        Timer9.Enabled = False
                        Timer11.Stop()
                        stopwatch.Stop()
                    Else

                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If

                    End If

                End If

            Case 3

                If Not Label10.Text = 3 Then

                    If Timer1.Enabled = True Then

                        If Timer9.Enabled = False Then

                            sign1 = "Yes"
                            Timer9.Start()

                        Else

                            Timer1.Enabled = False
                            sign1 = "No"
                            Timer9.Enabled = False
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Else

                        Timer1.Enabled = True
                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If
                    End If


                Else

                    Timer1.Start()

                    If Timer9.Enabled = True Then

                        sign1 = "No"
                        Timer9.Enabled = False
                        Timer11.Stop()
                        stopwatch.Stop()
                    Else

                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If

                    End If

                End If

            Case 4

                If Not Label10.Text = 4 Then

                    If Timer1.Enabled = True Then

                        If Timer9.Enabled = False Then

                            sign1 = "Yes"
                            Timer9.Start()

                        Else

                            Timer1.Enabled = False
                            sign1 = "No"
                            Timer9.Enabled = False
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Else

                        Timer1.Enabled = True
                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If
                    End If


                Else

                    Timer1.Start()

                    If Timer9.Enabled = True Then

                        sign1 = "No"
                        Timer9.Enabled = False
                        Timer11.Stop()
                        stopwatch.Stop()
                    Else

                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If

                    End If

                End If

            Case 5

                If Label10.Text > 2 Then

                    If Timer1.Enabled = True Then

                        If Timer9.Enabled = False Then

                            sign1 = "Yes"
                            Timer9.Start()

                        Else

                            Timer1.Enabled = False
                            sign1 = "No"
                            Timer9.Enabled = False
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Else

                        Timer1.Enabled = True
                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If
                    End If


                Else

                    Timer1.Start()

                    If Timer9.Enabled = True Then

                        sign1 = "No"
                        Timer9.Enabled = False
                        Timer11.Stop()
                        stopwatch.Stop()
                    Else

                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If

                    End If

                End If

            Case 6

                If Label10.Text < 3 Then

                    If Timer1.Enabled = True Then

                        If Timer9.Enabled = False Then

                            sign1 = "Yes"
                            Timer9.Start()

                        Else

                            Timer1.Enabled = False
                            sign1 = "No"
                            Timer9.Enabled = False
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Else

                        Timer1.Enabled = True
                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If
                    End If


                Else

                    Timer1.Start()

                    If Timer9.Enabled = True Then

                        sign1 = "No"
                        Timer9.Enabled = False
                        Timer11.Stop()
                        stopwatch.Stop()
                    Else

                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If

                    End If

                End If

            Case 7

                If Label10.Text > 3 Then

                    If Timer1.Enabled = True Then

                        If Timer9.Enabled = False Then

                            sign1 = "Yes"
                            Timer9.Start()

                        Else

                            Timer1.Enabled = False
                            sign1 = "No"
                            Timer9.Enabled = False
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Else

                        Timer1.Enabled = True
                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If
                    End If

                Else


                    If mins = 0 Or VB.Right(VB.Left(Label4.Text, 3), 1) = "." Then

                        If Timer1.Enabled = True Then

                            If Timer9.Enabled = False Then

                                sign1 = "Yes"
                                Timer9.Start()

                            Else

                                Timer1.Enabled = False
                                sign1 = "No"
                                Timer9.Enabled = False
                                Timer11.Stop()
                                stopwatch.Stop()

                            End If

                        Else

                            Timer1.Enabled = True
                            sign1 = "Yes"
                            Timer9.Enabled = True
                            If mins = 0 Then
                                Timer11.Start()
                                stopwatch.Start()
                            End If
                        End If

                    Else

                        Timer1.Start()

                        If Timer9.Enabled = True Then

                            sign1 = "No"
                            Timer9.Enabled = False
                            Timer11.Stop()
                            stopwatch.Stop()
                        Else

                            sign1 = "Yes"
                            Timer9.Enabled = True
                            If mins = 0 Then
                                Timer11.Start()
                                stopwatch.Start()
                            End If

                        End If

                    End If

                End If

            Case 8

                If Label10.Text > 0 Then

                    If Timer1.Enabled = True Then

                        If Timer9.Enabled = False Then

                            sign1 = "Yes"
                            Timer9.Start()

                        Else

                            Timer1.Enabled = False
                            sign1 = "No"
                            Timer9.Enabled = False
                            Timer11.Stop()
                            stopwatch.Stop()

                        End If

                    Else

                        Timer1.Enabled = True
                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If
                    End If


                Else

                    Timer1.Start()

                    If Timer9.Enabled = True Then

                        sign1 = "No"
                        Timer9.Enabled = False
                        Timer11.Stop()
                        stopwatch.Stop()
                    Else

                        sign1 = "Yes"
                        Timer9.Enabled = True
                        If mins = 0 Then
                            Timer11.Start()
                            stopwatch.Start()
                        End If

                    End If

                End If

        End Select


    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        rs.ResizeAllControls(Me)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode.ToString = "F2" Then

            Form3.Show()

        End If

        If e.KeyCode.ToString = Form3.TextBox1.Text Then

            Button5.PerformClick()

        Else

            If e.KeyCode.ToString = Form3.TextBox1.Text Then

                Button5.PerformClick()

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox2.Text Then

            Button25.PerformClick()

        End If


        If e.KeyCode.ToString = Form3.TextBox3.Text Then

            Button26.PerformClick()

        End If


        If e.KeyCode.ToString = Form3.TextBox31.Text Then

            Button3.PerformClick()

        End If


        If e.KeyCode.ToString = Form3.TextBox4.Text Then

            Button10.PerformClick()

            If CheckBox1.Checked = False And CheckBox2.Checked = False And CDbl(Label8.Text) > 0 And CDbl(Label9.Text) > 0 Then

                Focus()
                MsgBox("Please select who got the first possession")

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox5.Text Then

            Button9.PerformClick()

            If CheckBox1.Checked = False And CheckBox2.Checked = False And CDbl(Label8.Text) > 0 And CDbl(Label9.Text) > 0 Then

                Focus()
                MsgBox("Please select who got the first possession")

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox6.Text Then

            Button8.PerformClick()

            If CheckBox1.Checked = False And CheckBox2.Checked = False And CDbl(Label8.Text) > 0 And CDbl(Label9.Text) > 0 Then

                Focus()
                MsgBox("Please select who got the first possession")

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox7.Text Then

            Button20.PerformClick()

        End If

        If e.KeyCode.ToString = Form3.TextBox9.Text Then

            Button1.PerformClick()

        End If

        If e.KeyCode.ToString = Form3.TextBox10.Text Then

            Button2.PerformClick()

        End If

        If e.KeyCode.ToString = Form3.TextBox11.Text Then

            Button14.PerformClick()

            If CheckBox1.Checked = False And CheckBox2.Checked = False And CDbl(Label8.Text) > 0 And CDbl(Label9.Text) > 0 Then

                Focus()
                MsgBox("Please select who got the first possession")

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox12.Text Then

            Button13.PerformClick()

            If CheckBox1.Checked = False And CheckBox2.Checked = False And CDbl(Label8.Text) > 0 And CDbl(Label9.Text) > 0 Then

                Focus()
                MsgBox("Please select who got the first possession")

            End If

        End If

        If e.KeyCode = 34 Then

            Button12.PerformClick()

        Else

            If e.KeyCode.ToString = Form3.TextBox13.Text Then

                Button12.PerformClick()

                If CheckBox1.Checked = False And CheckBox2.Checked = False And CDbl(Label8.Text) > 0 And CDbl(Label9.Text) > 0 Then

                    Focus()
                    MsgBox("Please select who got the first possession")

                End If

            End If

        End If

        If e.KeyCode.ToString = Form3.TextBox14.Text Then

            Button19.PerformClick()

        End If

        If e.KeyCode = 37 Then

            CheckBox1.Checked = True

        End If

        If e.KeyCode = 39 Then

            CheckBox2.Checked = True

        End If


    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Form2.Close()

    End Sub

    Public Sub wait2(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

End Class
