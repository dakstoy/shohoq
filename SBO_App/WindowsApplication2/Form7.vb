Imports System.ComponentModel
Imports System.IO
Imports VB = Microsoft.VisualBasic
Imports Microsoft.Office.Interop

Public Class Form7
    Dim rs As New Resizer
    Dim mins = 0
    Dim secs = 0
    Private Declare Function music Lib “winmm.dll” Alias “mciSendStringA” (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Timer1.Enabled = False
        mins = 0
        secs = 0
        music(“close myDevice”, Nothing, 0, 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text = "" Then

            MsgBox("Please select a song first", vbCriticalbOKOnly, "OOOOPPPPSSSS!!!!!")

            GoTo Ending

        End If

        If Not ComboBox1.Text = Label2.Text Then

            Timer1.Enabled = False
            mins = 0
            secs = 0

            music(“close myDevice”, Nothing, 0, 0)

        End If

        Timer1.Enabled = True

        Dim FileName As String

        FileName = Chr(34) & (Form3.TextBox32.Text & ComboBox1.Text) & Chr(34)

        music(“open ” & FileName & ” alias myDevice”, Nothing, 0, 0)
        music(“play myDevice”, Nothing, 0, 0)

        Dim Duration As String
        Dim w As New WMPLib.WindowsMediaPlayer
        Dim m As WMPLib.IWMPMedia = w.newMedia(Form3.TextBox32.Text & ComboBox1.Text)
        If m IsNot Nothing Then

            Duration = m.durationString
            Label3.Text = Duration

        End If

        Dim a As Integer

        On Error Resume Next

        a = 0

        Do

            If ComboBox1.Items.Item(a) = ComboBox1.Text Then

                Label1.Text = a
                Label2.Text = ComboBox1.Text
                GoTo Ending

            End If

            a = a + 1

        Loop

Ending:
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Timer1.Enabled = False
        music(“pause myDevice”, Nothing, 0, 0)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        On Error Resume Next

        Timer1.Enabled = False
        mins = 0
        secs = 0
        ComboBox1.Text = ComboBox1.Items.Item(Label1.Text + 1)
        music(“close myDevice”, Nothing, 0, 0)
        Button1.PerformClick()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        On Error Resume Next

        Timer1.Enabled = False
        mins = 0
        secs = 0
        ComboBox1.Text = ComboBox1.Items.Item(Label1.Text - 1)
        music(“close myDevice”, Nothing, 0, 0)
        Button1.PerformClick()

    End Sub

    Private Sub Form7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        music(“close myDevice”, Nothing, 0, 0)
        Timer1.Enabled = False

    End Sub

    Private Sub Form7_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        'rs.ResizeAllControls(Me)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Not secs = 59 Then

            secs += 1

        Else

            secs = 0
            If Not mins = 0 Then

                mins += 1

            Else

                mins = 1

            End If

        End If

        If AddZero(mins) & ":" & AddZero(secs) = Label3.Text Then

            Timer1.Enabled = False
            mins = 0
            secs = 0
            Button5.PerformClick()

        End If

Ending2:

    End Sub

    Sub Duration()

        Dim Duration As String
        Dim w As New WMPLib.WindowsMediaPlayer
        Dim m As WMPLib.IWMPMedia = w.newMedia(Filename)
        If m IsNot Nothing Then
            Duration = m.durationString
        End If
        w.close()

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Form3.TextBox32.Text)

            Dim ThisFile As String = VB.Right(foundFile, Len(foundFile) - Len(Form3.TextBox32.Text))

            Dim item11 As New ListViewItem(ThisFile)
            Form3.ListView1.Items.Add(item11)
            ComboBox1.Items.Add(ThisFile)

        Next

    End Sub

End Class