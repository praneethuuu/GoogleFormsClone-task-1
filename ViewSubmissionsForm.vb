Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmission(currentIndex)
    End Sub

    Private Sub BTNPREVIOUS_CLICK(sender As Object, e As EventArgs) Handles btnPrevious.Click
    Private Sub BTNPREVIOUS_CLICK(sender As Object, e As EventArgs) Handles 
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub BTNNEXT_CLICK(sender As Object, e As EventArgs) Handles btnNext.Click
    Private Sub BTNNEXT_CLICK(sender As Object, e As EventArgs) Handles 
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub LoadSubmission(index As Integer)
        Try
            Dim client As New HttpClient()
            Dim response As String = client.DownloadString($"http://localhost:3000/read?index={index}")
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(response)
            lblName.Text = submission.name
            lblEmail.Text = submission.email
            lblPhone.Text = submission.phone
            lblGithubLink.Text = submission.github_link
            lblStopwatchTime.Text = submission.stopwatch_time.ToString()
        Catch ex As Exception
            MessageBox.Show("No more submissions.")
        End Try
    End Sub

    Private Sub LBLEMAIL_CLICK(sender As Object, e As EventArgs) Handles LBLEMAIL_CLICK

    End Sub
End Class

Public Class Submission
    Public Property NAME As String
    Public Property EMAIL As String
    Public Property PHONE As String
    Public Property GITHUB_link As String
    Public Property STOPWATCH_LINK As Integer
End Class
