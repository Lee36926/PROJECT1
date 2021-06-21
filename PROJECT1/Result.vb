Public Class FromResult
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormMain.Show()
        Me.Close()
    End Sub
    Public Function dataSubmit()
        LabelName.Text = FormMain.txtName.Text
        LabelIC.Text = FormMain.txtIC.Text
        LabelAddress.Text = FormMain.txtAddress.Text
        LabelAge.Text = FormMain.NudAge.Value
        LabelEmail.Text = FormMain.txtEmail.Text
        LabelPhone.Text = FormMain.txtPhone.Text
        If FormMain.radioMale.Checked = True Then
            LabelGender.Text = FormMain.radioMale.Text
        ElseIf FormMain.radioFemale.Checked = True Then
            LabelGender.Text = FormMain.radioFemale.Text
        End If
        ViewResult()
        Return True
    End Function

    Private Function ViewResult()
        If FormMain.NudAge.Value >= 18 Then
            LabelFinal.Text = "Enable to Register"
            LabelFinal.ForeColor = Color.Green
        Else
            LabelFinal.Text = "Not Enable,Below 18," + vbCrLf + "Back home"
            LabelFinal.ForeColor = Color.Red
        End If
        Return True
    End Function
End Class