Imports VB = Microsoft.VisualBasic
Imports CefSharp.WinForms
Imports CefSharp


Public Class Form9

    Private WithEvents browser As ChromiumWebBrowser
    Private WithEvents browser1 As ChromiumWebBrowser
    Dim rs As New Resizer
    Public totaltime = "30"
    Public totaltime2 = "60"
    Public totaltime3 = "120"
    Shared random As New Random()
    Private Declare Function music Lib “winmm.dll” Alias “mciSendStringA” (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Dim zzz As Integer

    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)

        browser = New ChromiumWebBrowser("http://thechriskent.com") With {
            .Dock = DockStyle.Fill
        }

        browser1 = New ChromiumWebBrowser("http://thechriskent.com") With {
            .Dock = DockStyle.Fill
        }

        Panel3.Controls.Add(browser)
        Panel4.Controls.Add(browser1)

    End Sub

    Private Sub Form9_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        rs.ResizeAllControls(Me)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label4.Parent = browser1
        Label11.Parent = browser1
        Label2.Text = Form1.Label13.Text
        Label6.Text = Form1.Label4.Text
        Timer1.Enabled = True
        Timer5.Enabled = True
        rs.FindAllControls(Me)
        Panel1.BringToFront()
        Panel2.BringToFront()
        Panel5.BringToFront()
        zzz = Form3.ListView1.Items.Count
        TextBox1.Text = "http://"
        PictureBox10.Visible = False
        'Panel1.Visible = True
        'Panel2.Visible = True
        'Panel5.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Label2.Text = Form1.Label13.Text
        Label6.Text = Form1.Label4.Text
        Label8.Text = Form2.Label10.Text
        Label9.Text = Form2.Label8.Text
        Label10.Text = Form2.Label3.Text

        Label1.Text = Form2.Label4.Text

        Label5.Text = Form2.Label5.Text

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

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

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        On Error Resume Next

        If totaltime2 = 59 Then

            Dim FileName As String
            Dim a As Integer

            a = random.Next(1, zzz)

            FileName = Chr(34) & (“C:\Users\Admin\Desktop\My Music\” & Form3.ListView1.Items(a).Text) & Chr(34)

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

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        On Error Resume Next

        If totaltime3 = 119 Then

            Dim FileName As String
            Dim a As Integer

            a = random.Next(1, zzz)

            FileName = Chr(34) & (“C:\Users\Admin\Desktop\My Music\” & Form3.ListView1.Items(a).Text) & Chr(34)

            music(“open ” & FileName & ” alias myDevice”, Nothing, 0, 0)
            music(“play myDevice”, Nothing, 0, 0)

            'My.Computer.Audio.Play("C:\Users\Admin\Desktop\Dexter_Stuffs\Images\Leave_Out_All_The_Rest.wav")

        End If

        If totaltime3 = 0 Then

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

    End Sub

    Private Sub Form9_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Form2.Close()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        If Timer2.Enabled = False Then

            totaltime = 30

        End If

    End Sub

    Private Sub Form9_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode.ToString = "F5" Then

            browser.Load(TextBox1.Text)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        browser.Load(TextBox1.Text)

        If VB.Right(TextBox1.Text, 4) = "1688" Then

            TextBox2.Text = TextBox1.Text & "/#!/fullscreen"

        End If

        If VB.Right(TextBox1.Text, 4) = "8080" Then

            TextBox2.Text = TextBox1.Text & "/browserfs.html"

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        browser.Reload

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        browser1.Load(TextBox2.Text)
        TabControl1.SelectedTab = TabPage2

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        browser1.Reload

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'enablepanel()

        PictureBox9.Image = My.Resources.San_Remigio
        Panel1.Visible = True
        Panel2.Visible = True
        Panel5.Visible = False

    End Sub

    Function disablePanel()

        For Each element In Panel1.Controls

            element.enabled = False

        Next

        Return Nothing

        For Each element In Panel2.Controls

            element.enabled = False

        Next

        Return Nothing

    End Function


    Function enablePanel()

        For Each element In Panel1.Controls
            element.enabled = True
        Next

        Return Nothing

        For Each element In Panel2.Controls
            element.enabled = True
        Next

        Return Nothing

    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        MsgBox("Make sure Mic/Aux is connected.")

        'disablePanel()
        Panel1.Visible = False
        Panel2.Visible = False
        Panel5.BringToFront()
        Panel5.Visible = True

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        PictureBox9.Image = My.Resources.VDrink
        Label3.Text = "PLAYER OF THE GAME"
        PictureBox13.Visible = True
        PictureBox11.Image = My.Resources.VDrink
        PictureBox11.Visible = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        PictureBox9.Image = My.Resources.Blip
        Label3.Text = "PLAYER OF THE GAME"
        PictureBox11.Visible = True
        PictureBox11.Image = My.Resources.Blip
        PictureBox13.Visible = False

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        PictureBox9.Image = My.Resources.Pocari_Sweat_logo
        Label3.Text = "PLAYER OF THE GAME"
        PictureBox11.Visible = True
        PictureBox11.Image = My.Resources.Pocari_Sweat_logo
        PictureBox13.Visible = False

    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick

        If Label14.Left < Width Then
            Label14.Left = Label14.Left + 10

        Else

            Label14.Left = 0

        End If

        If Label12.Left < Width Then
            Label12.Left = Label12.Left + 10

        Else

            Label12.Left = 0

        End If

        If Label13.Left < Width Then
            Label13.Left = Label13.Left + 10

        Else

            Label13.Left = 0

        End If

        If Label15.Left < Width Then
            Label15.Left = Label15.Left + 10

        Else

            Label15.Left = 0

        End If

    End Sub
End Class