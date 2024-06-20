Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private totalForms As Integer = 0

    Private Sub UpdateNavigationButtons()
        btnPrevious.Enabled = (currentIndex > 0)
        btnNext.Enabled = (currentIndex < totalForms - 1)
    End Sub
    Private Async Function UpdateSubmission(index As Integer, updatedSubmission As Dictionary(Of String, String)) As Task(Of Boolean)
        Using client As New HttpClient()
            Try
                Dim json = JsonConvert.SerializeObject(updatedSubmission)
                Dim content = New StringContent(json, Encoding.UTF8, "application/json")
                Dim response = Await client.PutAsync("http://localhost:3000/update?index=" & index.ToString(), content) ' Replace with your Mac's IP address
                response.EnsureSuccessStatusCode()
                Return True
            Catch ex As Exception
                MessageBox.Show("Error updating submission: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Async Function FetchSubmissions(index As Integer) As Task(Of Dictionary(Of String, String))
        Dim client As New HttpClient()

        Try
            Dim response = Await client.GetAsync("http://localhost:3000/read?index=" & index.ToString())
            response.EnsureSuccessStatusCode()

            Dim content = Await response.Content.ReadAsStringAsync()
            Dim submission = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(content)
            totalForms = submission("totalForms")

            Return submission
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Async Function DeleteSubmission(index As Integer) As Task(Of Boolean)
        Using client As New HttpClient()
            Try
                Dim response = Await client.DeleteAsync("http://localhost:3000/delete?index=" & index.ToString()) ' Replace with your Mac's IP address
                response.EnsureSuccessStatusCode()
                Return True
            Catch ex As Exception
                MessageBox.Show("Error deleting submission: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Sub UpdateSubmissionFields(submission As Dictionary(Of String, String))
        lblName.Text = submission("name")
        lblEmail.Text = submission("email")
        lblPhone.Text = submission("phone")
        lblGit.Text = submission("github_link")
        lblStopwatch.Text = submission("stopwatch_time")
    End Sub
    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim submission = Await FetchSubmissions(currentIndex)
        UpdateNavigationButtons()

        If submission IsNot Nothing Then
            UpdateSubmissionFields(submission)

        Else
            MessageBox.Show("Submission not found or error fetching submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Me.KeyPreview = True

    End Sub

    Private Sub ViewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            UpdateNavigationButtons()
            Dim submission = Await FetchSubmissions(currentIndex)
            If submission IsNot Nothing Then

                UpdateSubmissionFields(submission)
            Else
                ' Handle case where submission is not found or error occurred
                MessageBox.Show("Submission not found or error fetching submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("This is the first form")
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        currentIndex += 1
        UpdateNavigationButtons()
        Dim submission = Await FetchSubmissions(currentIndex)
        If submission IsNot Nothing Then

            UpdateSubmissionFields(submission)
        Else
            MessageBox.Show("Submission not found or error fetching submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Dim success = Await DeleteSubmission(currentIndex)

            If success Then
                MessageBox.Show("Submission deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Load the next submission if available

                Dim submission = Await FetchSubmissions(currentIndex)
                If submission IsNot Nothing Then
                    UpdateSubmissionFields(submission)
                    UpdateNavigationButtons()
                Else
                    ' Handle no submissions available
                    lblName.Text = ""
                    lblEmail.Text = ""
                    lblPhone.Text = ""
                    lblGit.Text = ""
                    lblStopwatch.Text = ""
                    MessageBox.Show("No more submissions available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Failed to delete submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EnableEditing(True)
    End Sub

    Private Sub EnableEditing(enable As Boolean)
        lblName.Visible = Not enable
        lblEmail.Visible = Not enable
        lblPhone.Visible = Not enable
        lblGit.Visible = Not enable
        lblStopwatch.Visible = Not enable
        btnPrevious.Enabled = Not enable
        btnNext.Enabled = Not enable

        txtVname.Visible = enable
        txtVemail.Visible = enable
        txtVphone.Visible = enable
        txtVgit.Visible = enable
        txtVstopwatch.Visible = enable

        btnSave.Visible = enable
        btnSave.Enabled = enable

        btnEdit.Enabled = Not enable

        If enable Then
            txtVname.Text = lblName.Text
            txtVemail.Text = lblEmail.Text
            txtVphone.Text = lblPhone.Text
            txtVgit.Text = lblGit.Text
            txtVstopwatch.Text = lblStopwatch.Text
        End If

    End Sub

    Private Sub UpdateLabels(submission As Dictionary(Of String, String))
        lblName.Text = submission("name")
        lblEmail.Text = submission("email")
        lblPhone.Text = submission("phone")
        lblGit.Text = submission("github_link")
        lblStopwatch.Text = submission("stopwatch_time")
    End Sub
    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim updatedSubmission As New Dictionary(Of String, String) From {
            {"name", txtVname.Text},
            {"email", txtVemail.Text},
            {"phone", txtVphone.Text},
            {"github_link", txtVgit.Text},
            {"stopwatch_time", txtVstopwatch.Text}
        }

        Dim success = Await UpdateSubmission(currentIndex, updatedSubmission)

        If success Then
            MessageBox.Show("Submission updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            EnableEditing(False)
            UpdateNavigationButtons()
            UpdateLabels(updatedSubmission)
        Else
            MessageBox.Show("Failed to update submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class