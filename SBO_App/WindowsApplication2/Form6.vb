Imports VB = Microsoft.VisualBasic
Public Class Form6
    Dim rs As New Resizer
    Public totaltime = "30"
    Public totaltime2 = "60"
    Public totaltime3 = "120"
    Shared random As New Random()
    Private Declare Function music Lib “winmm.dll” Alias “mciSendStringA” (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private Sub Form6_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        rs.ResizeAllControls(Me)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label6.Text = Form1.Label4.Text
        Timer1.Enabled = True
        Timer5.Enabled = True
        rs.FindAllControls(Me)

        zzz = Form3.ListView1.Items.Count

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label8.Text = Form2.Label10.Text
        Label9.Text = Form2.Label8.Text
        Label10.Text = Form2.Label3.Text

        Label1.Text = VB.Left(Form2.Label4.Text, 3)

        Label5.Text = VB.Left(Form2.Label5.Text, 3)

        'Select Case Form2.Label4.Text
        '    Case "CONRADS"
        '        Label1.Text = "Con"
        '    Case "Mopro Reapers"
        '        Label1.Text = "MR"
        '    Case "SpamTitan"
        '        Label1.Text = "Spam"
        '    Case "Lycans"
        '        Label1.Text = "Lyc"
        '    Case "The Rebels"
        '        Label1.Text = "TR"
        '    Case "New Alpine"
        '        Label1.Text = "NA"
        '    Case "Napuli Construction"
        '        Label1.Text = "NC"
        '    Case "ARMY"
        '        Label1.Text = "Arm"
        '    Case "KXB Basketball"
        '        Label1.Text = "KXB"
        '    Case "BEER PA DAY"
        '        Label1.Text = "BPD"
        '    Case "Mandaue Phenoms 3.0"
        '        Label1.Text = "MP"
        '    Case "SMC"
        '        Label1.Text = "SMC"
        '    Case "Chico"
        '        Label1.Text = "Chi"
        '    Case "Pastor Brothers"
        '        Label1.Text = "PB"
        '    Case "TEAM COOP"
        '        Label1.Text = "TC"
        '    Case "ASPA"
        '        Label1.Text = "Asp"
        '    Case "Kiboy's Computer Solution"
        '        Label1.Text = "KCS"
        '    Case "PANDAS UNITED"
        '        Label1.Text = "PU"
        '    Case "JL Engineering"
        '        Label1.Text = "JLE"
        '    Case "Brazzers"
        '        Label1.Text = "Bra"
        '    Case "Coding Avenue"
        '        Label1.Text = "CA"
        '    Case "Mustangs"
        '        Label1.Text = "Mus"
        '    Case "White Oleander Farm"
        '        Label1.Text = "WOF"
        '    Case "Mitsubishi"
        '        Label1.Text = "Mit"
        '    Case "Sherwin Printshop"
        '        Label1.Text = "SP"
        '    Case "Princess and Faith Kitchenette"
        '        Label1.Text = "PFK"
        '    Case "Jonher"
        '        Label1.Text = "Jon"
        '    Case "Active Fitness Gym"
        '        Label1.Text = "AFG"
        '    Case "Penthel"
        '        Label1.Text = "Pen"
        '    Case "HOTSHOTS"
        '        Label1.Text = "Hot"
        '    Case "Kaiju Renewed"
        '        Label1.Text = "KR"
        '    Case "team gladjoula"
        '        Label1.Text = "TG"
        '    Case "Vdrink Malunggay Juice"
        '        Label1.Text = "VMJ"
        '    Case "Tibur"
        '        Label1.Text = "Tib"
        '    Case "The Butter Movement"
        '        Label1.Text = "TBM"
        '    Case "Team 1"
        '        Label1.Text = "TM1"
        '    Case "Team 2"
        '        Label1.Text = "TM2"
        '    Case "Team 3"
        '        Label1.Text = "TM3"
        '    Case "Team 4"
        '        Label1.Text = "TM4"
        '    Case "Wednesday Club"
        '        Label1.Text = "WC"
        '    Case "JAEGERS"
        '        Label1.Text = "JAE"
        '    Case "VITAS"
        '        Label1.Text = "VIT"
        '    Case "TROJAN"
        '        Label1.Text = "TRO"
        '    Case "PIRANHAS"
        '        Label1.Text = "PIR"
        '    Case "SHARKS"
        '        Label1.Text = "SHA"
        '    Case "RENEGADES"
        '        Label1.Text = "REN"
        '    Case "WOLVES"
        '        Label1.Text = "WOL"
        '    Case "GOLEMS"
        '        Label1.Text = "GOL"
        '    Case "KALMA"
        '        Label1.Text = "KAL"
        '    Case "DISCIPLES"
        '        Label1.Text = "DIS"
        '    Case "DENTECH"
        '        Label1.Text = "DEN"
        '    Case "SANREM"
        '        Label1.Text = "SR"
        '    Case "PHIL IINO"
        '        Label1.Text = "PI"
        '    Case "WARRIORS"
        '        Label1.Text = "WAR"
        '    Case "UNKNOWN"
        '        Label1.Text = "UNK"


        'End Select

        'Select Case Form2.Label5.Text
        '    Case "CONRADS"
        '        Label5.Text = "Con"
        '    Case "Mopro Reapers"
        '        Label5.Text = "MR"
        '    Case "SpamTitan"
        '        Label5.Text = "Spa"
        '    Case "Lycans"
        '        Label5.Text = "Lyc"
        '    Case "The Rebels"
        '        Label5.Text = "TR"
        '    Case "New Alpine"
        '        Label5.Text = "NA"
        '    Case "Napuli Construction"
        '        Label5.Text = "NC"
        '    Case "ARMY"
        '        Label5.Text = "Arm"
        '    Case "KXB Basketball"
        '        Label5.Text = "KXB"
        '    Case "BEER PA DAY"
        '        Label5.Text = "BPD"
        '    Case "Mandaue Phenoms 3.0"
        '        Label5.Text = "MP"
        '    Case "SMC"
        '        Label5.Text = "SMC"
        '    Case "Chico"
        '        Label5.Text = "Chi"
        '    Case "Pastor Brothers"
        '        Label5.Text = "PB"
        '    Case "TEAM COOP"
        '        Label5.Text = "TC"
        '    Case "ASPA"
        '        Label5.Text = "Asp"
        '    Case "Kiboy's Computer Solution"
        '        Label5.Text = "KCS"
        '    Case "PANDAS UNITED"
        '        Label5.Text = "PU"
        '    Case "JL Engineering"
        '        Label5.Text = "JLE"
        '    Case "Brazzers"
        '        Label5.Text = "Bra"
        '    Case "Coding Avenue"
        '        Label5.Text = "CA"
        '    Case "Mustangs"
        '        Label5.Text = "Mus"
        '    Case "White Oleander Farm"
        '        Label5.Text = "WOF"
        '    Case "Mitsubishi"
        '        Label5.Text = "Mit"
        '    Case "Sherwin Printshop"
        '        Label5.Text = "SP"
        '    Case "Princess and Faith Kitchenette"
        '        Label5.Text = "PFK"
        '    Case "Jonher"
        '        Label5.Text = "Jon"
        '    Case "Active Fitness Gym"
        '        Label5.Text = "AFG"
        '    Case "Penthel"
        '        Label5.Text = "Pen"
        '    Case "HOTSHOTS"
        '        Label5.Text = "Hot"
        '    Case "Kaiju Renewed"
        '        Label5.Text = "Kai"
        '    Case "team gladjoula"
        '        Label5.Text = "TG"
        '    Case "Vdrink Malunggay Juice"
        '        Label5.Text = "VMJ"
        '    Case "Tibur"
        '        Label5.Text = "Tib"
        '    Case "The Butter Movement"
        '        Label5.Text = "TBM"
        '    Case "Team 1"
        '        Label5.Text = "TM1"
        '    Case "Team 2"
        '        Label5.Text = "TM2"
        '    Case "Team 3"
        '        Label5.Text = "TM3"
        '    Case "Team 4"
        '        Label5.Text = "TM4"
        '    Case "Wednesday Club"
        '        Label5.Text = "WC"
        '    Case "JAEGERS"
        '        Label5.Text = "JAE"
        '    Case "VITAS"
        '        Label5.Text = "VIT"
        '    Case "TROJAN"
        '        Label5.Text = "TRO"
        '    Case "PIRANHAS"
        '        Label5.Text = "PIR"
        '    Case "SHARKS"
        '        Label5.Text = "SHA"
        '    Case "RENEGADES"
        '        Label5.Text = "REN"
        '    Case "WOLVES"
        '        Label5.Text = "WOL"
        '    Case "GOLEMS"
        '        Label5.Text = "GOL"
        '    Case "KALMA"
        '        Label5.Text = "KAL"
        '    Case "DISCIPLES"
        '        Label5.Text = "DIS"
        '    Case "DENTECH"
        '        Label5.Text = "DEN"
        '    Case "SANREM"
        '        Label5.Text = "SR"
        '    Case "PHIL IINO"
        '        Label5.Text = "PI"
        '    Case "WARRIORS"
        '        Label5.Text = "WAR"
        '    Case "UNKNOWN"
        '        Label5.Text = "UNK"

        'End Select

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Label11.Text = ""

        If totaltime = 0 Then

            totaltime = 31
            Timer2.Enabled = False
            Form2.WindowState = FormWindowState.Maximized
            WindowState = FormWindowState.Minimized
            Form1.Focus()

        End If

        If Not totaltime = 0 Then
            totaltime -= 1
        End If

        Label4.Text = totaltime

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        On Error Resume Next

        If totaltime2 = 59 Then

            Dim FileName As String
            Dim a As Integer

            a = random.Next(1, Form1.zzz)

            FileName = Chr(34) & (Form3.TextBox32.Text & Form3.ListView1.Items(a).Text) & Chr(34)

            music(“open ” & FileName & ” alias myDevice”, Nothing, 0, 0)
            music(“play myDevice”, Nothing, 0, 0)

            'My.Computer.Audio.Play("C:\Users\Admin\Desktop\Dexter_Stuffs\Images\What_Ive_Done.wav")

        End If

        If totaltime2 = 0 Then

            Label6.Text = AddZero(Form3.NumericUpDown1.Value) & ":" & AddZero(Form3.NumericUpDown2.Value)
            totaltime2 = 61
            Timer3.Enabled = False
            Form2.WindowState = FormWindowState.Maximized
            WindowState = FormWindowState.Minimized
            Form1.Label10.Text = CDbl(Form1.Label10.Text) + 1

            If Form1.CheckBox1.Checked = True Then

                Form1.CheckBox2.Checked = True

            Else

                Form1.CheckBox1.Checked = True

            End If

            Form1.Focus()

        End If

        If Not totaltime2 = 0 Then
            totaltime2 -= 1
        End If

        Label4.Text = totaltime2

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

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

        If totaltime3 = 59 Then

            Form9.PictureBox10.Visible = True
            Form9.PictureBox10.Image = My.Resources.ty

        ElseIf totaltime3 = 55 Then

            Form9.PictureBox10.Image = My.Resources.VDrink

        ElseIf totaltime3 = 49 Then

            Form9.PictureBox10.Image = My.Resources.CSAS

        ElseIf totaltime3 = 43 Then

            Form9.PictureBox10.Image = My.Resources.emar

        ElseIf totaltime3 = 37 Then

            Form9.PictureBox10.Image = My.Resources.cyber_bellying

        ElseIf totaltime3 = 31 Then

            Form9.PictureBox10.Image = My.Resources.KCS

        ElseIf totaltime3 = 25 Then

            Form9.PictureBox10.Image = My.Resources.Blip2

        ElseIf totaltime3 = 19 Then

            Form9.PictureBox10.Image = My.Resources.Custom_Sports

        ElseIf totaltime3 = 13 Then

            Form9.PictureBox10.Image = My.Resources.Pocari_Sweat_logo

        ElseIf totaltime3 = 7 Then

            Form9.PictureBox10.Image = My.Resources.San_Remigio

        End If

        If totaltime3 = 119 Then

            Form9.PictureBox10.Visible = True
            Form9.PictureBox10.Image = My.Resources.halftime

            Form9.Panel6.Visible = True
            Form9.PictureBox9.Visible = False
            Form9.Panel1.Visible = False
            Form9.Panel2.Visible = False
            Form9.PictureBox17.Visible = True
            Form9.PictureBox18.Visible = True
            Form9.Label4.Visible = True
            Form9.Label11.Visible = True

            Dim FileName As String
            Dim a As Integer

            a = random.Next(1, Form1.zzz)

            FileName = Chr(34) & (Form3.TextBox32.Text & Form3.ListView1.Items(a).Text) & Chr(34)

            music(“open ” & FileName & ” alias myDevice”, Nothing, 0, 0)
            music(“play myDevice”, Nothing, 0, 0)

            'My.Computer.Audio.Play("C:\Users\Admin\Desktop\Dexter_Stuffs\Images\Leave_Out_All_The_Rest.wav")

        End If

        If totaltime3 = 0 Then

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

            Label6.Text = AddZero(Form3.NumericUpDown1.Value) & ":" & AddZero(Form3.NumericUpDown2.Value)
            totaltime3 = 121
            Timer4.Enabled = False
            Form2.WindowState = FormWindowState.Maximized
            WindowState = FormWindowState.Minimized
            Form1.Label10.Text = CDbl(Form1.Label10.Text) + 1

            If Form1.CheckBox1.Checked = True Then

                Form1.CheckBox2.Checked = True

            Else

                Form1.CheckBox1.Checked = True

            End If

            Form1.Focus()

        End If

        If Not totaltime3 = 0 Then
            totaltime3 -= 1
        End If

        Label4.Text = totaltime3

    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Form2.Close()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        If Timer2.Enabled = False Then

            totaltime = 30

        End If

    End Sub

End Class