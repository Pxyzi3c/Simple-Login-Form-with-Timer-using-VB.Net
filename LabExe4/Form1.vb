Public Class Form1
    Dim varName As String
    Dim varGender As String
    Dim varProgram As String
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        varName = txtName.Text.ToUpper()
        varProgram = cmbYearlevel.SelectedItem.ToString()
        If rbtnMale.Checked = True Then
            varGender = rbtnMale.Text
        ElseIf rbtnFemale.Checked = True Then
            varGender = rbtnFemale.Text
        End If
        Dim dashboardForm = New DashboardForm(varName, varGender, varProgram)
        Me.Hide()
        dashboardForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBG.BackColor = Color.FromArgb(125, Color.White)
    End Sub
End Class
