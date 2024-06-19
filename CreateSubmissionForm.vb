Private stopwatch As Stopwatch = New Stopwatch()

Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
    If stopwatch.IsRunning Then
        stopwatch.Stop()
        btnToggleStopwatch.Text = "Resume Stopwatch (Ctrl+T)"
    Else
        stopwatch.Start()
        btnToggleStopwatch.Text = "Pause Stopwatch (Ctrl+T)"
    End If
    lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
End Sub
