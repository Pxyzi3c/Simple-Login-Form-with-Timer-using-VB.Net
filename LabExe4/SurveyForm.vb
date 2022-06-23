Public Class SurveyForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHr.Text = Now.Hour
        lblMin.Text = Now.Minute
        lblSec.Text = Now.Second
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
    End Sub

    Private Sub SurveyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBG.BackColor = Color.FromArgb(125, Color.White)
    End Sub
End Class