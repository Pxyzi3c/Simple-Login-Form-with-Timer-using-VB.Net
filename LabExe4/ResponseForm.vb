Public Class ResponseForm
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        lbValues.Items.Add(txtName.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lbValues.SelectedItems.Count = 0 Then
            MsgBox("Nothing Selected")
        Else
            lbSelected.Items.Add(lbValues.SelectedItem.ToString)
            lbValues.Items.Remove(lbValues.SelectedItem.ToString)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lbSelected.SelectedItems.Count = 0 Then
            MsgBox("Nothing Selected")
        Else
            lbValues.Items.Add(lbSelected.SelectedItem.ToString)
            lbSelected.Items.Remove(lbSelected.SelectedItem.ToString)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbValues.Items.Clear()
    End Sub

    Private Sub ResponseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class