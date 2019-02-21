Public Class Best_Player

    Dim rs As New Resizer
    Private Sub Best_Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rs.FindAllControls(Me)

    End Sub

    Private Sub Best_Player_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        rs.ResizeAllControls(Me)

    End Sub
End Class