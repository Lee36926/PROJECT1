Public Class FormMain

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        txtName.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtIC.Clear()
        txtPhone.Clear()
        radioMale.Checked = False
        radioFemale.Checked = False
        NudAge.Value = 0
    End Sub

    Private Sub BtnCheck_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCheck.Click
        Dim intPhone As Integer
        Try
            intPhone = txtPhone.Text
            checkInput()
        Catch ex As Exception
            MsgBox("Please enter correct phone number !", vbExclamation + vbOKOnly, "Badminton Event")
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to Exit?", "Badminton Event", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = vbYes) Then
            Me.Close()
        End If
    End Sub

    Public Function checkInput()
        If txtName.Text = "" Then
            MsgBox("Please fill in your name !", vbExclamation + vbOKOnly, "Badminton Event")
        ElseIf txtIC.TextLength < 12 Then
            MsgBox("Identical Card Number should not less than 12 !", vbExclamation + vbOKOnly, "Badminton Event")
        ElseIf txtIC.TextLength > 12 Then
            MsgBox("Identical Card Number should not more than 12 !", vbExclamation + vbOKOnly, "Badminton Event")
        ElseIf radioFemale.Checked = False And radioMale.Checked = False Then
            MsgBox("Please select gender !", vbExclamation + vbOKOnly, "Badminton Event")
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please fill in your address !", vbExclamation + vbOKOnly, "Badminton Event")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please fill in your email address !", vbExclamation + vbOKOnly, "Badminton Event")
        ElseIf txtPhone.TextLength < 10 Then
            MsgBox("Phone Number should not less than 10 !", vbExclamation + vbOKOnly, "Badminton Event")
        ElseIf txtPhone.TextLength > 11 Then
            MsgBox("Phone Number should not more than 11 !", vbExclamation + vbOKOnly, "Badminton Event")
        Else
            Dim formResult As New FromResult
            MsgBox("Register Successful !", vbOKOnly, "Badminton Event")
            FromResult.Show()
            FromResult.dataSubmit()
        End If
        Return True
    End Function
End Class
