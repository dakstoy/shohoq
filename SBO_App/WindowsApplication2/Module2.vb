Module Module2

    Function AddZero(ByVal par As Integer) As String

        Dim a = ""
        If par < 10 Then
            a = "0" & par
        Else
            a = par
        End If

        Return a

    End Function

End Module
