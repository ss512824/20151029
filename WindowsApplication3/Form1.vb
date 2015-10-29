Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        If (String.IsNullOrEmpty(txtUserName.Text)) Then
            txtUserName.BackColor = Color.MistyRose
        End If
        If (String.IsNullOrEmpty(txtPassword.Text)) Then
            txtPassword.BackColor = Color.MistyRose
        End If

        If txtUserName.Text = "LOGIN" Then
            If txtPassword.Text = "ABC123" Then
                MsgBox("帳戶密碼正確:)")
                Application.Exit()
            Else
                txtPassword.BackColor = Color.MistyRose
            End If
        Else
            txtUserName.BackColor = Color.MistyRose
        End If
        If txtUserName.Text = "LOGIN" Then
            txtUserName.BackColor = Color.White
        End If
        If txtPassword.Text = "ABC123" Then
            txtPassword.BackColor = Color.White
        End If

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        Application.Exit()
    End Sub
End Class
