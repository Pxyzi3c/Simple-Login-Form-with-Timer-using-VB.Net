Public Class DashboardForm
    Dim varNameValue As String
    Dim varGenderValue As String
    Dim varProgramValue As String

    Public Sub New(ByVal varName As String, ByVal varProgram As String, ByVal varGender As String)
        InitializeComponent()
        varNameValue = varName
        varProgramValue = varProgram
        varGenderValue = varGender
    End Sub
    Private Sub DashboardForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim surveyForm = New SurveyForm
        Dim responseForm = New ResponseForm
        surveyForm.MdiParent = Me
        responseForm.MdiParent = Me
    End Sub

    Private Sub ToolstripAnswer_Click(sender As Object, e As EventArgs) Handles ToolstripAnswer.Click
        Dim surveyForm = New SurveyForm
        surveyForm.MdiParent = Me
        surveyForm.lblName.Text = varNameValue
        surveyForm.lblProgram.Text = varProgramValue
        surveyForm.lblGender.Text = varGenderValue
        surveyForm.Show()
    End Sub

    Private Sub ToolstripResponse_Click(sender As Object, e As EventArgs) Handles ToolstripResponse.Click
        Dim responseForm = New ResponseForm
        responseForm.MdiParent = Me
        responseForm.Show()
    End Sub

    Private Sub ToolstripExit_Click(sender As Object, e As EventArgs) Handles ToolstripExit.Click
        For i = Me.MdiChildren.Length - 1 To 0 Step -1
            Me.MdiChildren(i).Close()
        Next
    End Sub
End Class