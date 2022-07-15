Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Brothers" And TextBox2.Text = "12345" Then
            MsgBox("Login Sucessfully")
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Invalid Input")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    
End Class
